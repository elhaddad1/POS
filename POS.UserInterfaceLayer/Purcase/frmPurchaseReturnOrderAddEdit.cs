using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS.BusinessLayer;
using POS.BusinessLayer.Wrapper;

namespace POS.UserInterfaceLayer.Purcase
{
    public partial class frmPurchaseReturnOrderAddEdit : Form
    {
        PURPurchaseReturnHeaderWrapper pURPurchaseReturnHeaderWrapper;
        private INVInventoryWrapper iNVInventoryWrapper = new INVInventoryWrapper();
        PURPurchaseReturnLineWrraper pURPurchaseReturnLineWrraper;
        VPURPurchaseOrderCollection vPURPurchaseOrderCollection;
        BDProductWrapper bDProductWrapper;
        PURPurchaseReturnHeader pURPurchaseReturnHeader;
        PURPurchaseReturnLineCollection pURPurchaseReturnLineCollection;
        VPURPurchaseOrder _vPURPurchaseOrder;
        double invoiceTax = 0.00;
        double invoiceDescount = 0.00;
        public frmPurchaseReturnOrderAddEdit()
        {
            InitializeComponent();
            pURPurchaseReturnHeaderWrapper = new PURPurchaseReturnHeaderWrapper();
            pURPurchaseReturnLineWrraper = new PURPurchaseReturnLineWrraper();
            bDProductWrapper = new BDProductWrapper();
            pURPurchaseReturnHeader = new PURPurchaseReturnHeader();
            pURPurchaseReturnLineCollection = new PURPurchaseReturnLineCollection();
            FillProductCBX();
        }

        public frmPurchaseReturnOrderAddEdit(int salesReturnHeaderID)
        {
            InitializeComponent();
            pURPurchaseReturnHeaderWrapper = new PURPurchaseReturnHeaderWrapper();
            pURPurchaseReturnLineWrraper = new PURPurchaseReturnLineWrraper();
            bDProductWrapper = new BDProductWrapper();
            FillProductCBX();
            FillInventoryCBX();
            
            FillScreenWithDataForEdit(salesReturnHeaderID);

        }

        #region --Events
        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(tbx_InvoiceNumber.Text))
                {
                    vPURPurchaseOrderCollection = pURPurchaseReturnHeaderWrapper.VPURPurchaseOrder_SelectOneByInvoiceNumber(tbx_InvoiceNumber.Text);
                    if (vPURPurchaseOrderCollection.Count != 0)
                        FillScreenData();
                    else
                        MessageBox.Show("لايوجد فاتورة بهذا المسلسل ");
                }
                else
                    MessageBox.Show("برجاء أدخال مسلسل الفاتورة أولا");
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ برجاء تكرار العمليه مره اخرى واذا تكرر الخطا برجاءالاتصال بالشخص المصمم للبرنامج وارسال رسالة الخطا التى ستظهر بعد قليل له");
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_ClosePrint_Click(object sender, EventArgs e)
        {
            CollectHeaderData();
            CollectLinesData();
            if (pURPurchaseReturnHeader.PurchaseReturnID == null)
            {
                pURPurchaseReturnLineWrraper.SaveClosePURPurchaseReturnOrder(pURPurchaseReturnHeader, pURPurchaseReturnLineCollection);
            }
            else
            {
                pURPurchaseReturnLineWrraper.UpdateClosePURPurchaseOrder(pURPurchaseReturnHeader, pURPurchaseReturnLineCollection);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            CollectHeaderData();
            CollectLinesData();
            if (pURPurchaseReturnHeader.PurchaseReturnID == null)
            {
                try
                {
                    pURPurchaseReturnLineWrraper.SavePURPurchaseReturnOrder(pURPurchaseReturnHeader, pURPurchaseReturnLineCollection);
                    MessageBox.Show("تمت العمليه بنجاح");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("حدث خطأ برجاء تكرار العمليه مره اخرى واذا تكرر الخطا برجاءالاتصال بالشخص المصمم للبرنامج وارسال رسالة الخطا التى ستظهر بعد قليل له");
                    MessageBox.Show(ex.Message);
                
                }
            }
            //else
            //{
            //    pURPurchaseReturnLineWrraper.UpdatePURPurchaseOrder(pURPurchaseReturnHeader, pURPurchaseReturnLineCollection);
            //}
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgrd_ReturnOrderLines_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            //if column = product name
            if (e.RowIndex != -1 && e.ColumnIndex == senderGrid.Columns["ProductName"].Index)
            {
               List< VPURPurchaseOrder> vPURPurchaseOrder = vPURPurchaseOrderCollection.Where(a => a.ProductID == Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells["ProductName"].Value)).ToList();
                if (vPURPurchaseOrder.Count == 0)
                {
                    MessageBox.Show("هذا الصنف غير موجود بالفاتورة الاصليه");
                    senderGrid.Rows[e.RowIndex].ErrorText = "هذا الصنف غير موجود بالفاتورة الاصليه";
                    senderGrid.Rows[e.RowIndex].Cells["ProductName"].Style.BackColor = Color.Red;
                    return;
                }
                else
                {
                    ((DataGridViewComboBoxCell)senderGrid.Rows[e.RowIndex].Cells["BatchNumber"]).DataSource = vPURPurchaseOrder;
                    ((DataGridViewComboBoxCell)senderGrid.Rows[e.RowIndex].Cells["BatchNumber"]).ValueMember = "BatchNumber";
                    ((DataGridViewComboBoxCell)senderGrid.Rows[e.RowIndex].Cells["BatchNumber"]).DisplayMember = "BatchNumber";

                    //senderGrid.Rows[e.RowIndex].Cells["SaledQty"].Value = vPURPurchaseOrder.TotalQty;
                    senderGrid.Rows[e.RowIndex].Cells["IsAcceptBatch"].Value = vPURPurchaseOrder.First().IsAcceptBatch;
                    senderGrid.Rows[e.RowIndex].Cells["UnitPrice"].Value = vPURPurchaseOrder.First().UnitPrice;
                   senderGrid.Rows[e.RowIndex].Cells["BatchNumber"].ReadOnly = !(bool)vPURPurchaseOrder.First().IsAcceptBatch;
                    senderGrid.Rows[e.RowIndex].Cells["ExpiryDate"].ReadOnly = !(bool)vPURPurchaseOrder.First().IsAcceptBatch;
                    if (vPURPurchaseOrder.First ().IsAcceptBatch == false)
                    {
                    senderGrid.Rows[e.RowIndex].Cells["SaledQty"].Value = vPURPurchaseOrder.First ().TotalQty;
                    }
                }
            }
            //if column = BatchNumber
            if (e.RowIndex != -1 && e.ColumnIndex == senderGrid.Columns["BatchNumber"].Index)
            {
                VPURPurchaseOrder vPURPurchaseOrder = vPURPurchaseOrderCollection.Where(a => a.ProductID == Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells["ProductName"].Value)
                                                                                                    && a.BatchNumber == senderGrid.Rows[e.RowIndex].Cells["BatchNumber"].Value.ToString ()).FirstOrDefault();
                if (vPURPurchaseOrder == null)
                {
                    MessageBox.Show("هذا الصنف غير موجود بالفاتورة الاصليه");
                    senderGrid.Rows[e.RowIndex].ErrorText = "هذا الصنف غير موجود بالفاتورة الاصليه";
                    senderGrid.Rows[e.RowIndex].Cells["ProductName"].Style.BackColor = Color.Red;
                    return;
                }
                else
                {
                    senderGrid.Rows[e.RowIndex].Cells["SaledQty"].Value = vPURPurchaseOrder.Qty != null ? vPURPurchaseOrder.Qty : vPURPurchaseOrder.TotalQty ;
                    senderGrid.Rows[e.RowIndex].Cells["ExpiryDate"].Value = vPURPurchaseOrder.ExpiryDate.Value.Date;
                    // senderGrid.Rows[e.RowIndex].Cells["IsAcceptBatch"].Value = vPURPurchaseOrder.IsAcceptBatch;
                }
            }
            if (e.RowIndex != -1 && (e.ColumnIndex == senderGrid.Columns["ReturnedQty"].Index || e.ColumnIndex == senderGrid.Columns["UnitPrice"].Index))
            {
                CalculateTotal();
            }
        }

        private void frmPurchaseReturnOrderAddEdit_Load(object sender, EventArgs e)
        {

        }



        #endregion
        #region --Public  Methods
        #endregion
        #region --Private Methods
        private void FillScreenData()
        {
            _vPURPurchaseOrder = vPURPurchaseOrderCollection.FirstOrDefault();
            tbx_CustomerName.Text = _vPURPurchaseOrder.SupplierName;
            tbxPurchaseMan.Text = _vPURPurchaseOrder.UserFullName;
            dtb_InvoiceDate.Value = (DateTime)_vPURPurchaseOrder.InvoiceDate;
            dtb_PurchaseDate.Value = (DateTime)_vPURPurchaseOrder.PurchaseDate;
            invoiceDescount = (double)_vPURPurchaseOrder.TotalDiscountRatio;
            if (_vPURPurchaseOrder.TaxValue != null)
            invoiceTax = (double)_vPURPurchaseOrder.TaxValue;

        }
        private void CollectHeaderData()
        {
            pURPurchaseReturnHeader.OriginalHeaderID = _vPURPurchaseOrder.PurcaseHeaderID;
            pURPurchaseReturnHeader.ReturnDate = DateTime.Now.Date;
            pURPurchaseReturnHeader.ReturnMoney = decimal.Parse(tbx_Total.Text);
        }
        private void CalculateTotal()
        {
            double total = 0;
            for (int i = 0; i < dgrd_ReturnOrderLines.Rows .Count  -1 ; i++)
            {
                double price =dgrd_ReturnOrderLines.Rows[i].Cells["UnitPrice"].Value !=null? Convert.ToDouble (dgrd_ReturnOrderLines.Rows[i].Cells["UnitPrice"].Value):0;
                double qty =dgrd_ReturnOrderLines.Rows[i].Cells["returnedQty"].Value!= null? Convert.ToDouble(dgrd_ReturnOrderLines.Rows[i].Cells["returnedQty"].Value):0;
                total += price * qty;
                
            }
            tbx_Total.Text = total.ToString ();
        }
        private void FillProductCBX()
        {
            ((DataGridViewComboBoxColumn)dgrd_ReturnOrderLines.Columns["ProductName"]).DataSource = bDProductWrapper.SelectAll();
            ((DataGridViewComboBoxColumn)dgrd_ReturnOrderLines.Columns["ProductName"]).ValueMember = "ProductID";
            ((DataGridViewComboBoxColumn)dgrd_ReturnOrderLines.Columns["ProductName"]).DisplayMember = "ProductName";
        }
        private void CollectLinesData()
        {
            pURPurchaseReturnLineCollection.Clear();
            foreach (DataGridViewRow row in dgrd_ReturnOrderLines.Rows)
            {
                if (row.Cells["ProductName"].Value == null )
                {
                    return;
                }
                VPURPurchaseOrder vPURPurchaseOrder ;
                if ((bool)row.Cells["IsAcceptBatch"].Value == true)
                {
                    vPURPurchaseOrder = vPURPurchaseOrderCollection.Where(a => a.ProductID == Convert.ToInt32(row.Cells["ProductName"].Value)
                                                                                && a.BatchNumber == row.Cells["BatchNumber"].Value).SingleOrDefault(); 
                }
                else
                {
                     vPURPurchaseOrder = vPURPurchaseOrderCollection.Where(a => a.ProductID == Convert.ToInt32(row.Cells["ProductName"].Value)).SingleOrDefault(); 

                }


                if (vPURPurchaseOrder != null)
                {
                   PURPurchaseReturnLine line= new PURPurchaseReturnLine();
                   line.OriginalpurchaseLineID = vPURPurchaseOrder.PurchaseLineID;
                   line.Qty =Convert .ToDecimal ( row.Cells["returnedQty"].Value);
                   line.BatchNumber = vPURPurchaseOrder.IsAcceptBatch == true ? row.Cells["BatchNumber"].Value.ToString() : null;
                   line.ExpiryDate = vPURPurchaseOrder.IsAcceptBatch == true ? Convert.ToDateTime(row.Cells["ExpiryDate"].Value) : (DateTime?)null;
                   line.Reason = row.Cells["Reason"].Value.ToString();
                   pURPurchaseReturnLineCollection.Add(line);
                }

                else
                {
                    MessageBox.Show("لقد قمت باختيار اصناف غير موجوده بالفاتورة الأصلية");
                    row.Cells["ProductName"].Style.BackColor = Color.Red;
                    return;
                }
            }

        }
        private PURPurchaseReturnHeader GetPurchaseReturnHeader(int salesReturnHeaderID)
        {
            PURPurchaseReturnHeaderPrimaryKey pk = new PURPurchaseReturnHeaderPrimaryKey();
            pk.PurchaseReturnID = salesReturnHeaderID;
            return pURPurchaseReturnHeaderWrapper.SelectOne(pk);
        }
        private PURPurchaseReturnLineCollection GetPurchaseReturnLines(int salesReturnHeaderID)
        {
            return pURPurchaseReturnLineWrraper.SelectByField(salesReturnHeaderID);
        }
        private VPURPurchaseOrderCollection GetPurchaseOriginalPurchaseOrderData(int PURPurchaseHeaderID)
        {
            return pURPurchaseReturnHeaderWrapper.VPURPurchaseOrder_SelectOne(PURPurchaseHeaderID);
        }
        private void FillScreenWithDataForEdit(int salesReturnHeaderID)
        {
            pURPurchaseReturnHeader = GetPurchaseReturnHeader(salesReturnHeaderID);
            pURPurchaseReturnLineCollection = GetPurchaseReturnLines(salesReturnHeaderID);
            vPURPurchaseOrderCollection = GetPurchaseOriginalPurchaseOrderData((int)pURPurchaseReturnHeader.OriginalHeaderID);
            FillScreenData();
        }
        private void FillInventoryCBX()
        {
            try
            {
                cbx_Inventory.DataSource = iNVInventoryWrapper.SelectAll();
                cbx_Inventory.DisplayMember = "InventoryName";
                cbx_Inventory.ValueMember = "InventoryID";
                cbx_Inventory.SelectedIndex = 0;
            }
            catch (Exception ex)
            {

                MessageBox.Show("حدث خطأ برجاء تكرار العمليه مره اخرى واذا تكرر الخطا برجاءالاتصال بالشخص المصمم للبرنامج وارسال رسالة الخطا التى ستظهر بعد قليل له");
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        



    }
}
