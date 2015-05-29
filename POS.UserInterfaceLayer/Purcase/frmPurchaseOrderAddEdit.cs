using POS.BusinessLayer;
using POS.BusinessLayer.Wrapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.UserInterfaceLayer.Purcase
{
    public partial class frmPurchaseOrderAddEdit : Form
    {
        private BDTaxTypeWrapper _bDTaxTypeWrapper;
        private PaymentTypeWrapper _paymentTypeWrapper;
        private BDSupplierWrapper _bDSupplierWrapper;
        private PURPurchaseLineWrapper _pURPurchaseLinerWrapper;
        private INVInventoryService _invInventoryService;
        public PURPurchaseLineCollection pURPurchaseLineCollection;
        private BDProductWrapper _productWrapper;
        int? CurrentHeaderID;
        public frmPurchaseOrderAddEdit()
        {
            InitializeComponent();
            LoadScreenData();
            //this.Enabled = true;
        }

        public frmPurchaseOrderAddEdit(int HeaderID)
        {
            InitializeComponent();
            CurrentHeaderID = HeaderID;
            LoadScreenData();
            LoadLines((int)CurrentHeaderID);
           // this.Enabled = false;
           
        }



        #region -- Events

        private void frmPurchaseOrderAddEdit_Load(object sender, EventArgs e)
        {

            ((DataGridViewComboBoxColumn)dgrd_OrderLines.Columns["ProductName"]).DataSource = _productWrapper.SelectAll();
            ((DataGridViewComboBoxColumn)dgrd_OrderLines.Columns["ProductName"]).ValueMember = "ProductID";
            ((DataGridViewComboBoxColumn)dgrd_OrderLines.Columns["ProductName"]).DisplayMember = "ProductName";
            //((DataGridViewTextBoxColumn)dgrd_OrderLines.Columns["ProductName"]).=;
        }
        private void btn_AddLine_Click(object sender, EventArgs e)
        {
            dgrd_OrderLines.Rows.Add();

        }
        private void btn_DeleteLine_Click(object sender, EventArgs e)
        {
            if (dgrd_OrderLines.SelectedCells.Count != 0)
            {
                dgrd_OrderLines.Rows.RemoveAt(dgrd_OrderLines.SelectedCells[0].RowIndex);
                //dgrd_OrderLines.Rows.RemoveAt(dgrd_OrderLines.SelectedRows[0].Index);
                //  BindGrid();
                CalculateTotal();
            }
            else
                MessageBox.Show("برجاء أختيار عنصر من القائمه");
        }
        private void btn_Plus_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dgrd_OrderLines.SelectedCells[0].RowIndex;
            if ((bool)dgrd_OrderLines .Rows[selectedRowIndex].Cells["IsAcceptBatch"].Value == true)
            {
                dgrd_OrderLines.Rows.InsertCopy(selectedRowIndex, selectedRowIndex + 1);
                dgrd_OrderLines.Rows[selectedRowIndex + 1].Cells["ProductName"].Value = dgrd_OrderLines.Rows[selectedRowIndex].Cells["ProductName"].Value;
                dgrd_OrderLines.Rows[selectedRowIndex + 1].Cells["PurchasePrice"].Value = dgrd_OrderLines.Rows[selectedRowIndex].Cells["PurchasePrice"].Value;
                // dgrd_OrderLines.Rows[selectedRowIndex + 1].Cells["ItemDiscount"].Value = dgrd_OrderLines.Rows[selectedRowIndex].Cells["ItemDiscount"].Value;
                // dgrd_OrderLines.Rows[selectedRowIndex + 1].Cells["ProductName"].Value = dgrd_OrderLines.Rows[selectedRowIndex].Cells["ProductName"].Value;
                
            }
            else
            {
                MessageBox.Show("المنتج الذي تم اختياره لا يقبل تشغيله");
            }
            // dgrd_OrderLines.Rows.InsertCopy(dgrd_OrderLines.SelectedCells[0].RowIndex, dgrd_OrderLines.SelectedCells[0].RowIndex + 1);
        }
        private void btn_ClosePrint_Click(object sender, EventArgs e)
        {
            if (ValidateSaving())
            {
                try
                {
                    SaveInvoice();
                    CommitInvoice();
                    MessageBox.Show("تمت العلية");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("حدث خطأ برجاء المحاولة مرة آخرى");
                }
            }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (ValidateSaving())
            {
                try
                {
                    bool saved= SaveInvoice();
                    if (saved)
                    {
                        MessageBox.Show("تمت العملية");
                        this.Close();
                    }
                    else
                        MessageBox.Show("برجاء تصحيح المعلومات الخاطئه");
                    
               
                }
                catch (Exception ex)
                {
                    MessageBox.Show("حدث خطأ برجاء المحاولة مرة آخرى");
                }
            }

            //Convert.ToDecimal(float.Parse(tbx_Discount.Text.Trim(new char[] { '%' })) / 100);
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmSalesLineAddEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            BindGrid();
           //CalculateTotal();
        }

        private void num_Remaining_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(num_Remaining.Text) < 0)
            {
                dtb_LastTimeToPay.Enabled = true;
            }
        }
      
        private void dgrd_OrderLines_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex == dgrd_OrderLines.Columns["ProductName"].Index)
            {
                BDProductPrimaryKey pk = new BDProductPrimaryKey();
                pk.ProductID = Convert.ToInt32(dgrd_OrderLines.Rows[e.RowIndex].Cells["ProductName"].Value);
                BDProduct _product = _productWrapper.SelectOne(pk);
                dgrd_OrderLines.Rows[e.RowIndex].Cells["IsAcceptBatch"].Value = _product.IsAcceptBatch;

                if (_product.IsAcceptBatch == true)
                {
                    dgrd_OrderLines.Rows[e.RowIndex].Cells["BatchNumber"].ReadOnly = false;
                    dgrd_OrderLines.Rows[e.RowIndex].Cells["ExpiryDate"].ReadOnly = false;
                }
                else
                {
                    dgrd_OrderLines.Rows[e.RowIndex].Cells["BatchNumber"].ReadOnly = true;
                    dgrd_OrderLines.Rows[e.RowIndex].Cells["ExpiryDate"].ReadOnly = true;
                }
            }

            if (e.RowIndex != -1 && e.ColumnIndex == dgrd_OrderLines.Columns["TotalQty"].Index
                || e.RowIndex != -1 && e.ColumnIndex == dgrd_OrderLines.Columns["PurchasePrice"].Index)
            {
                CalculateTotal();
            }

        }
        private void txt_Total_TextChanged(object sender, EventArgs e)
        {
            decimal totalPrice = decimal.Parse(txt_Total.Text);
            decimal discountAmount = decimal.Parse(txt_DiscountAmount.Text) * totalPrice / 100;

            txt_AfterDescount.Text =(totalPrice-discountAmount).ToString();
            num_Remaining.Text = (decimal.Parse(txt_AfterDescount.Text) - decimal.Parse(num_Paied.Text)).ToString();
        }
        private void num_Paied_TextChanged(object sender, EventArgs e)
        {
            num_Remaining.Text = (decimal.Parse(txt_AfterDescount.Text) - decimal.Parse(num_Paied.Text)).ToString();
        }


        #endregion

        #region -- Public Methods

        #endregion

        #region -- Private Methods
        private void LoadScreenData()
        {
            _bDTaxTypeWrapper = new BDTaxTypeWrapper();
            _paymentTypeWrapper = new PaymentTypeWrapper();
            _bDSupplierWrapper = new BDSupplierWrapper();
            pURPurchaseLineCollection = new PURPurchaseLineCollection();
            _pURPurchaseLinerWrapper = new PURPurchaseLineWrapper();
            _productWrapper = new BDProductWrapper();
            _invInventoryService = new INVInventoryService();
            FillSupplierCBX();
            FillPaymentTypeCBX();
            FillTaxTypeCBX();
            FillInventoryCBX();
        }
        private void LoadLines(int HeaderID)
        {
            try
            {
                PURPurchaseHeaderPrimaryKey headerKey = new PURPurchaseHeaderPrimaryKey();
                headerKey.PurcaseHeaderID = HeaderID;
                PURPurchaseHeaderService headerService = new PURPurchaseHeaderService();
                PURPurchaseHeader selectedHeader = headerService.SelectOne(headerKey);

                PURPurchaseLineWrapper LineService = new PURPurchaseLineWrapper();
                PURPurchaseLineCollection selectedLines = LineService.SelectByHeaderID(HeaderID);
                LoadHeaderControls(selectedHeader);
                LoadGridLines(selectedLines);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void LoadHeaderControls(PURPurchaseHeader Header)
        {
            dtb_Date.Value = Header.InvoiceDate.Value;
            cbx_Inventory.SelectedValue = Header.InventoryID;
            cbx_Supplier.SelectedValue = Header.SupplierID;
            cbx_PaymentType.SelectedValue = Header.PaymentTypeID;
            txt_Total.Text = Header.TotalPrice.ToString();
            txt_DiscountAmount.Text = Header.TotalDiscountAmount.ToString();
            num_Paied.Text = Header.PaidAmount.ToString();
           // num_Remaining.Text = Header.RemainingAmount.ToString();
            dtb_LastTimeToPay.Value = Header.LastDayToPay.Value;
            if(Header.TaxTypeID != null)
                cbx_TaxType.SelectedValue = Header.TaxTypeID;
            num_OtherPayments.Text = Header.ServicePrice.ToString();
            if (Header .IsClosed == true)
            {
                 pnl_headerData.Enabled = false;
            pnl_footer.Enabled = false;
            grb_lineData.Enabled = false;
            btn_Save.Enabled = false;
            btn_ClosePrint.Enabled = false;
            }
           // txt_DiscountRatio.Text = Header.TotalDiscountRatio.ToString();
        }
        private void LoadGridLines(PURPurchaseLineCollection Lines)
        {
            dgrd_OrderLines.Rows.Add(Lines.Count);
            for (int i = 0; i < Lines.Count; i++)
            {
                //dgrd_OrderLines.Rows[i].Cells["PurchaseLineID"].Value = Lines[i].PurchaseLineID;
                //dgrd_OrderLines.Rows[i].Cells["PurchaseLineBatchID"].Value = Lines[i].PurchaseLineBatchID;
                dgrd_OrderLines.Rows[i].Cells["ProductName"].Value = Lines[i].ProductID;
                dgrd_OrderLines.Rows[i].Cells["IsAcceptBatch"].Value = Lines[i].IsAcceptBatch;
                dgrd_OrderLines.Rows[i].Cells["TotalQty"].Value = Lines[i].TotalQty;
               // dgrd_OrderLines.Rows[i].Cells["Bonus"].Value = Lines[i].BonusQty;
                dgrd_OrderLines.Rows[i].Cells["PurchasePrice"].Value = Lines[i].Unitprice;
               // dgrd_OrderLines.Rows[i].Cells["ItemDiscount"].Value = Lines[i].DiscountRatio;
                dgrd_OrderLines.Rows[i].Cells["BatchNumber"].Value = Lines[i].BatchNumber;
                dgrd_OrderLines.Rows[i].Cells["ExpiryDate"].Value = Lines[i].ExpiryDate;
            }
        }
        private void FillSupplierCBX()
        {

            try
            {
                cbx_Supplier.DataSource = _bDSupplierWrapper.SelectAll().OrderBy(a => a.SupplierName).ToList();
                cbx_Supplier.DisplayMember = "SupplierName";
                cbx_Supplier.ValueMember = "SupplierID";
                cbx_Supplier.SelectedIndex = -1;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void FillTaxTypeCBX()
        {

            try
            {
                cbx_TaxType.DataSource = _bDTaxTypeWrapper.SelectAll();
                cbx_TaxType.DisplayMember = "TaxTypeName";
                cbx_TaxType.ValueMember = "TaxTypeID";
                cbx_TaxType.SelectedIndex = -1;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void FillPaymentTypeCBX()
        {

            try
            {
                cbx_PaymentType.DataSource = _paymentTypeWrapper.SelectAll();
                cbx_PaymentType.DisplayMember = "PaymentTypeName";
                cbx_PaymentType.ValueMember = "PaymentTypeID";
                cbx_PaymentType.SelectedIndex = -1;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void FillInventoryCBX()
        {
            cbx_Inventory.DataSource = _invInventoryService.SelectAll();
            cbx_Inventory.ValueMember = "InventoryID";
            cbx_Inventory.DisplayMember = "InventoryName";
            cbx_Inventory.SelectedIndex = -1;
        }
        private void BindGrid()
        {
            dgrd_OrderLines.DataSource = null;
            dgrd_OrderLines.AutoGenerateColumns = false;
            dgrd_OrderLines.DataSource = pURPurchaseLineCollection;
            dgrd_OrderLines.Columns[0].DataPropertyName = "ProductID";
            dgrd_OrderLines.Columns[1].DataPropertyName = "ProductName";
            dgrd_OrderLines.Columns[2].DataPropertyName = "TotalQty";
            dgrd_OrderLines.Columns[3].DataPropertyName = "UnitPrice";

        }
        private void CalculateTotal()
        {
            decimal TotalPrice = 0;
            for (int i = 0; i < dgrd_OrderLines.RowCount; i++)
            {
                decimal Qty = 0;
                decimal price = 0;
                if (dgrd_OrderLines.Rows[i].Cells["TotalQty"].Value != null && !decimal.TryParse(dgrd_OrderLines.Rows[i].Cells["TotalQty"].Value.ToString(), out Qty))
                {
                    Qty = 0;
                    // dgrd_OrderLines.Rows[i].Cells["TotalQty"].Style.BackColor = Color .Red;
                }
                if (dgrd_OrderLines.Rows[i].Cells["PurchasePrice"].Value != null && !decimal.TryParse(dgrd_OrderLines.Rows[i].Cells["PurchasePrice"].Value.ToString(), out price))
                {
                    price = 0;
                    // dgrd_OrderLines.Rows[i].Cells["PurchasePrice"].Style.BackColor = Color .Red;
                }
                TotalPrice += Qty * price;
                txt_Total.Text = TotalPrice.ToString();
            }
        }
        private PURPurchaseHeader CollectHeaderData()
        {
            PURPurchaseHeader _pURPurchaseHeader = new PURPurchaseHeader();
            if (CurrentHeaderID !=0 && CurrentHeaderID !=null)
            {
                _pURPurchaseHeader.PurcaseHeaderID = CurrentHeaderID;
            }
            _pURPurchaseHeader.SupplierID = Convert.ToInt32(cbx_Supplier.SelectedValue);
            _pURPurchaseHeader.InvoiceDate = dtb_Date.Value.Date;
            _pURPurchaseHeader.InvoiceNumber = txt_invoiceNumber.Text;
            _pURPurchaseHeader.LastDayToPay = dtb_LastTimeToPay.Value.Date;
            _pURPurchaseHeader.PaidAmount = string.IsNullOrEmpty(num_Paied.Text) ? 0 : Convert.ToDecimal(num_Paied.Text);
            _pURPurchaseHeader.RemainingAmount = string.IsNullOrEmpty(num_Remaining.Text) ? 0 : Convert.ToDecimal(num_Remaining.Text);
            _pURPurchaseHeader.PaymentTypeID = Convert.ToInt32(cbx_PaymentType.SelectedValue);
            _pURPurchaseHeader.ServicePrice = string.IsNullOrEmpty(num_OtherPayments.Text) ? 0 : Convert.ToDecimal(num_OtherPayments.Text);
            _pURPurchaseHeader.TaxTypeID = cbx_TaxType.SelectedIndex == -1 ? null : (int?)(cbx_TaxType.SelectedValue);
            decimal total = Convert.ToDecimal(txt_Total.Text);
           // decimal discountRatio = (Convert.ToDecimal(txt_DiscountRatio.Text.Trim(new char[] { '%' })) / 100);
            _pURPurchaseHeader.TotalDiscountRatio = Convert.ToDouble(txt_DiscountAmount.Text);
            _pURPurchaseHeader.TotalDiscountAmount = 0;
            _pURPurchaseHeader.TotalPrice = Convert.ToDecimal(txt_Total.Text);
            _pURPurchaseHeader.InventoryID = Convert.ToInt32(cbx_Inventory.SelectedValue);
            _pURPurchaseHeader.TotalPrice = total;
            return _pURPurchaseHeader;
        }
        private bool ValidateSaving()
        {
            if (cbx_Supplier.SelectedIndex == -1)
            {
                MessageBox.Show("اختار مورد أولا");
                return false;
            }
            if (cbx_Inventory.SelectedIndex == -1)
            {
                MessageBox.Show("اختار المخزن أولا");
                return false;
            }
            if (cbx_PaymentType.SelectedIndex == -1)
            {
                MessageBox.Show("اختار طريقه دفع أولا");
                return false;
            }

            return true;
        }
        private bool SaveInvoice()
        {
              //save lines
            for (int i = 0; i < dgrd_OrderLines.Rows.Count; i++)
            {
                PURPurchaseLine _line = new PURPurchaseLine();
                _line.ProductID = Convert.ToInt32(dgrd_OrderLines.Rows[i].Cells["ProductName"].Value);
                _line.TotalQty = Convert.ToDecimal(dgrd_OrderLines.Rows[i].Cells["TotalQty"].Value);
                _line.BonusQty = 0;
                _line.Unitprice = Convert.ToDecimal(dgrd_OrderLines.Rows[i].Cells["PurchasePrice"].Value);
                _line.DiscountRatio = 0;
                _line.DiscountAmount = 0;
                if ((bool)dgrd_OrderLines.Rows[i].Cells["IsAcceptBatch"].Value == true)
                {
                    _line.BatchNumber = dgrd_OrderLines.Rows[i].Cells["BatchNumber"].Value.ToString();
                    DateTime _expiryDate;
                    if (DateTime.TryParse(dgrd_OrderLines.Rows[i].Cells["ExpiryDate"].Value.ToString(), out _expiryDate))
                    {
                        _line.ExpiryDate = _expiryDate;
                        dgrd_OrderLines.Rows[i].Cells["ExpiryDate"].Style.BackColor = Color.White;
                    }
                    else
                    {
                        dgrd_OrderLines.Rows[i].Cells["ExpiryDate"].Style.BackColor = Color.Red;
                        return false;
                        
                    }
                    _line.BatchQty = Convert.ToDecimal(dgrd_OrderLines.Rows[i].Cells["TotalQty"].Value);
                }

                pURPurchaseLineCollection.Add(_line);
            }
            if (CurrentHeaderID != 0 && CurrentHeaderID != null)
            {
                _pURPurchaseLinerWrapper.UpdatePurchaseOrder(CollectHeaderData(), pURPurchaseLineCollection);
            }
            else
            {
              CurrentHeaderID=  _pURPurchaseLinerWrapper.SavePURPurchaseOrder(CollectHeaderData(), pURPurchaseLineCollection);
            }
            return true;       
        }
        private void CommitInvoice()
        {
            if (CurrentHeaderID != null && CurrentHeaderID != 0)
            {
                PURPurchaseHeaderWrapper pURPurchaseHeaderWrapper = new PURPurchaseHeaderWrapper();
                pURPurchaseHeaderWrapper.CloseOrder((int)CurrentHeaderID);
                
            }
            else
            {
                MessageBox.Show("لابد من حفظ الفاتوره اولا ");
            }
        }

        #endregion


       
       







    }
}
