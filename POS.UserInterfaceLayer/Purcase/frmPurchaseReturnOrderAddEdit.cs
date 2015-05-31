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
                        MessageBox.Show("لايوجد فاتورة بهذا المسلسل");
                }
                else
                    MessageBox.Show("برجاء أدخال مسلسل الفاتورة أولا");
            }
            catch (Exception ex)
            {
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
                pURPurchaseReturnLineWrraper.SavePURPurchaseReturnOrder(pURPurchaseReturnHeader, pURPurchaseReturnLineCollection);
            }
            else
            {
                pURPurchaseReturnLineWrraper.UpdatePURPurchaseOrder(pURPurchaseReturnHeader, pURPurchaseReturnLineCollection);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgrd_ReturnOrderLines_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (e.RowIndex != -1 && e.ColumnIndex == senderGrid.Columns["TotalQty"].Index && !string.IsNullOrEmpty(senderGrid.Rows[e.RowIndex].Cells["TotalQty"].Value.ToString()))
            {
                if (Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells["ProductName"].Value) == -1)
                {
                    MessageBox.Show("أختر صنف أولا");
                    return;
                }
                VPURPurchaseOrder vPURPurchaseOrder = vPURPurchaseOrderCollection.Where(a => a.ProductID == Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells["ProductName"].Value)).SingleOrDefault();
                if (vPURPurchaseOrder == null)
                {
                    MessageBox.Show("هذا الصنف غير موجود بالفاتورة الاصليه");
                    senderGrid.Rows[e.RowIndex].ErrorText = "هذا الصنف غير موجود بالفاتورة الاصليه";
                    senderGrid.Rows[e.RowIndex].Cells["ProductName"].Style.BackColor = Color.Red;
                    return;
                }
               
                tbx_Total.Text = (CalculateTotal((double)senderGrid.Rows[e.RowIndex].Cells["UnitPrice"].Value * (double)senderGrid.Rows[e.RowIndex].Cells["TotalQty"].Value)).ToString();
            }

            if (e.RowIndex != -1 && e.ColumnIndex == senderGrid.Columns["ProductName"].Index)
            {
                BDProductPrimaryKey pk = new BDProductPrimaryKey();
                pk.ProductID = Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells["ProductName"].Value);

                BDProduct _product = bDProductWrapper.SelectOne(pk);
                senderGrid.Rows[e.RowIndex].Cells["IsAcceptBatch"].Value = _product.IsAcceptBatch;
                //senderGrid.Rows[e.RowIndex].Cells["IsAcceptBatch"].Value = vPURPurchaseOrder.
                if (_product.IsAcceptBatch == true)
                {
                    senderGrid.Rows[e.RowIndex].Cells["BatchNumber"].ReadOnly = false;
                    senderGrid.Rows[e.RowIndex].Cells["ExpiryDate"].ReadOnly = false;
                }
                else
                {
                    senderGrid.Rows[e.RowIndex].Cells["BatchNumber"].ReadOnly = true;
                    senderGrid.Rows[e.RowIndex].Cells["ExpiryDate"].ReadOnly = true;
                }

            }
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
        }
        private double CalculateTotal(double newValue)
        {
            double descountAmount = newValue * invoiceDescount;
            double taxAmount = newValue * invoiceTax;
            double total = Convert.ToDouble(tbx_Total.Text) + newValue - descountAmount + taxAmount;
            return total;
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
                VPURPurchaseOrder vPURPurchaseOrder = vPURPurchaseOrderCollection.Where(a => a.ProductID == Convert.ToInt32(row.Cells["ProductName"].Value)).SingleOrDefault();
                if (vPURPurchaseOrder != null)
                    pURPurchaseReturnLineCollection.Add(new PURPurchaseReturnLine()
                                          {
                                              OriginalpurchaseLineID = vPURPurchaseOrder.PurchaseLineID,
                                              Qty = (decimal)row.Cells["TotalQty"].Value,
                                              BatchNumber = vPURPurchaseOrder.IsAcceptBatch == true ? row.Cells["BatchNumber"].Value.ToString() : null,
                                              ExpiryDate = vPURPurchaseOrder.IsAcceptBatch == true ? Convert.ToDateTime(row.Cells["ExpiryDate"].Value) : (DateTime?)null,
                                              Reason = row.Cells["Reason"].Value.ToString()
                                          });

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
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        private void frmPurchaseReturnOrderAddEdit_Load(object sender, EventArgs e)
        {

        }






    }
}
