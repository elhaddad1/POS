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
        private PURPurchaseLineWrapper  _pURPurchaseLinerWrapper;
        private INVInventoryService _invInventoryService;
        public PURPurchaseLineCollection pURPurchaseLineCollection;
        private BDProductWrapper _productWrapper;
        public frmPurchaseOrderAddEdit()
        {
            InitializeComponent();
            _bDTaxTypeWrapper = new BDTaxTypeWrapper();
            _paymentTypeWrapper = new PaymentTypeWrapper();
            _bDSupplierWrapper = new BDSupplierWrapper();
            pURPurchaseLineCollection = new PURPurchaseLineCollection();
            _pURPurchaseLinerWrapper = new PURPurchaseLineWrapper();
            _productWrapper=new BDProductWrapper ();
            _invInventoryService=new INVInventoryService ();
            FillSupplierCBX();
            FillPaymentTypeCBX();
            FillTaxTypeCBX();
            FillInventoryCBX();

        }
        public frmPurchaseOrderAddEdit(int HeaderID)
        {
            InitializeComponent();
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

     

        #region -- Events

        private void frmPurchaseOrderAddEdit_Load(object sender, EventArgs e)
        {
           
            ((DataGridViewComboBoxColumn)dgrd_OrderLines .Columns ["ProductName"]).DataSource =  _productWrapper.SelectAll();
            ((DataGridViewComboBoxColumn)dgrd_OrderLines.Columns["ProductName"]).ValueMember = "ProductID";
            ((DataGridViewComboBoxColumn)dgrd_OrderLines.Columns["ProductName"]).DisplayMember = "ProductName";
            //((DataGridViewTextBoxColumn)dgrd_OrderLines.Columns["ProductName"]).=;
        }
        private void num_Remaining_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(num_Remaining.Text) < 0)
            {
                dtb_LastTimeToPay.Enabled = true;
            }
        }

        private void btn_AddLine_Click(object sender, EventArgs e)
        {
            dgrd_OrderLines.Rows.Add();

        }

        private void btn_DeleteLine_Click(object sender, EventArgs e)
        {
            if (dgrd_OrderLines.SelectedRows.Count != 0)
            {
                dgrd_OrderLines.Rows .RemoveAt(dgrd_OrderLines.SelectedRows[0].Index);
                 //dgrd_OrderLines.Rows.RemoveAt(dgrd_OrderLines.SelectedRows[0].Index);
                //  BindGrid();
                CalculateTotal();
            }
            else
                MessageBox.Show("برجاء أختيار عنصر من القائمه");
        }

        private void btn_Plus_Click(object sender, EventArgs e)
        {
            int selectedRowIndex=dgrd_OrderLines.SelectedCells[0].RowIndex;
            dgrd_OrderLines.Rows.InsertCopy(selectedRowIndex,selectedRowIndex+1);
            dgrd_OrderLines.Rows[selectedRowIndex+1].Cells["ProductName"].Value = dgrd_OrderLines.Rows[selectedRowIndex].Cells["ProductName"].Value;
            dgrd_OrderLines.Rows[selectedRowIndex+1].Cells["PurchasePrice"].Value = dgrd_OrderLines.Rows[selectedRowIndex].Cells["PurchasePrice"].Value;
            dgrd_OrderLines.Rows[selectedRowIndex + 1].Cells["ItemDiscount"].Value = dgrd_OrderLines.Rows[selectedRowIndex].Cells["ItemDiscount"].Value;
            // dgrd_OrderLines.Rows[selectedRowIndex + 1].Cells["ProductName"].Value = dgrd_OrderLines.Rows[selectedRowIndex].Cells["ProductName"].Value;
          
            
           // dgrd_OrderLines.Rows.InsertCopy(dgrd_OrderLines.SelectedCells[0].RowIndex, dgrd_OrderLines.SelectedCells[0].RowIndex + 1);
        }


        private void btn_ClosePrint_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                try
                {
                    if (_pURPurchaseLinerWrapper.SaveClosePURPurchaseOrder(CollectHeaderData(), pURPurchaseLineCollection))
                    {
                        // print
                        //  Utility.Print(null, 1);
                        MessageBox.Show("تمت العلية");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("حدث خطأ برجاء المحاولة مرة آخرى");
                }
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                try
                {
                    //save lines
                    for (int i = 0; i < dgrd_OrderLines .Rows .Count; i++)
                    {
                        PURPurchaseLine _line = new PURPurchaseLine();
                        _line.ProductID =Convert .ToInt32( dgrd_OrderLines.Rows[i].Cells["ProductName"].Value);
                        _line.TotalQty = Convert.ToDecimal(dgrd_OrderLines.Rows[i].Cells["TotalQty"].Value);
                        _line.BonusQty = Convert.ToDecimal(dgrd_OrderLines.Rows[i].Cells["Bonus"].Value);
                        _line.Unitprice = Convert.ToDecimal(dgrd_OrderLines.Rows[i].Cells["PurchasePrice"].Value);
                        _line.DiscountRatio = Convert.ToDecimal(dgrd_OrderLines.Rows[i].Cells["ItemDiscount"].Value);
                        if ((bool)dgrd_OrderLines.Rows[i].Cells["IsAcceptBatch"].Value ==true)
                        {
                            _line.BatchNumber = dgrd_OrderLines.Rows[i].Cells["BatchNumber"].Value.ToString();
                            DateTime _expiryDate;
                          if (DateTime.TryParse(dgrd_OrderLines.Rows[i].Cells["ExpiryDate"].Value.ToString (),out _expiryDate))
	                            {
		                              _line.ExpiryDate = _expiryDate ;
                                      dgrd_OrderLines.Rows[i].Cells["ExpiryDate"].Style.BackColor = Color.White;
	                            }
                          else
                              {
                                  dgrd_OrderLines.Rows[i].Cells["ExpiryDate"].Style.BackColor = Color.Red;
                                  return;
                              }
                          _line.BatchQty = Convert.ToDecimal(dgrd_OrderLines.Rows[i].Cells["TotalQty"].Value) +
                                            Convert.ToDecimal(dgrd_OrderLines.Rows[i].Cells["Bonus"].Value); ;
                        }

                        pURPurchaseLineCollection.Add(_line);
                    }

                    if (_pURPurchaseLinerWrapper.SavePURPurchaseOrder(CollectHeaderData(), pURPurchaseLineCollection))
                    {
                        MessageBox.Show("تمت العلية");
                        this.Close();
                    }
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

        private void txt_DiscountRatio_Leave(object sender, EventArgs e)
        {
            decimal total = Convert.ToDecimal(txt_Total.Text);
            decimal discountRatio = (Convert.ToDecimal(txt_DiscountRatio.Text.Trim(new char[] { '%' })) / 100);
            decimal totalAfterDiscount = total - (discountRatio * total);
            txt_AfterDescount.Text = totalAfterDiscount.ToString();
            num_Paied_KeyUp(null, null);
            num_Remaining.Text = (Convert.ToDecimal(num_Paied.Text) - Convert.ToDecimal(txt_AfterDescount.Text)).ToString();

        }

        private void frmSalesLineAddEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            BindGrid();
            CalculateTotal();
        }

        private void num_Paied_KeyUp(object sender, KeyEventArgs e)
        {
            num_Remaining.Text = (Convert.ToDecimal(num_Paied.Text) - Convert.ToDecimal(txt_Total.Text)).ToString();

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
        }

       
        #endregion

        #region -- Public Methods

        #endregion

        #region -- Private Methods
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
        private decimal CalculateTotal()
        {
            decimal Total = 0;
            foreach (PURPurchaseLine q in pURPurchaseLineCollection)
            {
                Total += (decimal)(q.TotalQty * q.Unitprice);

            }
            txt_Total.Text = Total.ToString();
            txt_AfterDescount.Text = Total.ToString();
            num_Remaining.Text = (Convert.ToDecimal(num_Paied.Text) - Total).ToString();
            return Total;
        }
        private PURPurchaseHeader CollectHeaderData()
        {
            PURPurchaseHeader _pURPurchaseHeader = new PURPurchaseHeader();
            _pURPurchaseHeader.SupplierID = Convert.ToInt32(cbx_Supplier.SelectedValue);
            _pURPurchaseHeader.InvoiceDate = dtb_Date.Value.Date;
            _pURPurchaseHeader.LastDayToPay = dtb_LastTimeToPay.Value.Date;
            _pURPurchaseHeader.PaidAmount = string.IsNullOrEmpty(num_Paied.Text) ? 0 : Convert.ToDecimal(num_Paied.Text);
            _pURPurchaseHeader.RemainingAmount = string.IsNullOrEmpty(num_Remaining.Text) ? 0 : Convert.ToDecimal(num_Remaining.Text);
            _pURPurchaseHeader.PaymentTypeID = Convert.ToInt32(cbx_PaymentType.SelectedValue);
            _pURPurchaseHeader.ServicePrice = string.IsNullOrEmpty(num_OtherPayments.Text) ? 0 : Convert.ToDecimal(num_OtherPayments.Text);
            _pURPurchaseHeader.TaxTypeID = cbx_TaxType.SelectedIndex == -1 ? null : (int?)(cbx_TaxType.SelectedValue);
            decimal total = Convert.ToDecimal(txt_Total.Text);
            decimal discountRatio = (Convert.ToDecimal(txt_DiscountRatio.Text.Trim(new char[] { '%' })) / 100);
            _pURPurchaseHeader.TotalDiscountAmount = total * discountRatio;
            _pURPurchaseHeader.TotalDiscountRatio = (double)discountRatio;
            _pURPurchaseHeader.TotalPrice = Convert.ToDecimal(txt_Total.Text);
            _pURPurchaseHeader.InventoryID = Convert.ToInt32(cbx_Inventory.SelectedValue);
            return _pURPurchaseHeader;
        }
        private bool Validate()
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



            return true;
        }
        #endregion

       

      


    }
}
