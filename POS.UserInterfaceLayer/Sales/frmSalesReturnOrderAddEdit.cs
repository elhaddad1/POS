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

namespace POS.UserInterfaceLayer.Sales
{
    public partial class frmSalesReturnOrderAddEdit : Form
    {
        SALSalesReturnHeaderWrapper sALSalesReturnHeaderWrapper;
        SALSalesReturnLineWrraper sALSalesReturnLineWrraper;
        private INVInventoryWrapper iNVInventoryWrapper = new INVInventoryWrapper();
        VSALSalesOrderCollection vSALSalesOrderCollection;
        BDProductWrapper bDProductWrapper;
        SALSalesReturnHeader sALSalesReturnHeader;
        SALSalesReturnLineCollection sALSalesReturnLineCollection;
        VSALSalesOrder _vSALSalesOrder;
        double invoiceTax = 0.00;
        double invoiceDescount = 0.00;
        public frmSalesReturnOrderAddEdit()
        {
            InitializeComponent();
            sALSalesReturnHeaderWrapper = new SALSalesReturnHeaderWrapper();
            sALSalesReturnLineWrraper = new SALSalesReturnLineWrraper();
            bDProductWrapper = new BDProductWrapper();
            sALSalesReturnHeader = new SALSalesReturnHeader();
            sALSalesReturnLineCollection = new SALSalesReturnLineCollection();
            FillInventoryCBX();
            FillProductCBX();
        }

        public frmSalesReturnOrderAddEdit(int salesReturnHeaderID)
        {
            InitializeComponent();
            sALSalesReturnHeaderWrapper = new SALSalesReturnHeaderWrapper();
            sALSalesReturnLineWrraper = new SALSalesReturnLineWrraper();
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
                    vSALSalesOrderCollection = sALSalesReturnHeaderWrapper.VSALSalesOrder_SelectOneByInvoiceNumber(tbx_InvoiceNumber.Text);
                    if (vSALSalesOrderCollection.Count != 0)
                        FillScreenData();
                    else
                        MessageBox.Show("لايوجد فاتورة بهذا المسلسل");
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
            if (sALSalesReturnHeader.SlaesReturnHeaderID == null)
            {
                sALSalesReturnLineWrraper.SaveCloseSALSalesReturnOrder(sALSalesReturnHeader, sALSalesReturnLineCollection);
                MessageBox.Show("تمت العملية بنجاح");
                this.Close();
            }
            else
            {
                sALSalesReturnLineWrraper.UpdateCloseSALSalesOrder(sALSalesReturnHeader, sALSalesReturnLineCollection);
                MessageBox.Show("تمت العملية بنجاح");
                this.Close();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            CollectHeaderData();
            CollectLinesData();
            if (sALSalesReturnHeader.SlaesReturnHeaderID == null)
            {
                sALSalesReturnLineWrraper.SaveSALSalesReturnOrder(sALSalesReturnHeader, sALSalesReturnLineCollection);
                MessageBox.Show("تمت العملية بنجاح");
                this.Close();
            }
            else
            {
                sALSalesReturnLineWrraper.UpdateSALSalesOrder(sALSalesReturnHeader, sALSalesReturnLineCollection);
                MessageBox.Show("تمت العملية بنجاح");
                this.Close();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgrd_ReturnOrderLines_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.RowIndex != -1 && (e.ColumnIndex == senderGrid.Columns["TotalQty"].Index /*|| e.ColumnIndex == senderGrid.Columns["UnitPrice"].Index*/) && !string.IsNullOrEmpty(senderGrid.Rows[e.RowIndex].Cells["TotalQty"].Value.ToString()))
            {
                if (Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells["ProductName"].Value) == -1)
                {
                    MessageBox.Show("أختر صنف أولا");
                    return;
                }

                //VSALSalesOrder vSALSalesOrder = vSALSalesOrderCollection.Where(a => a.ProductID == Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells["ProductName"].Value)).SingleOrDefault();
                //if (vSALSalesOrder == null)
                //{
                //    MessageBox.Show("هذا الصنف غير موجود بالفاتورة الاصليه");
                //    senderGrid.Rows[e.RowIndex].ErrorText = "هذا الصنف غير موجود بالفاتورة الاصليه";
                //    senderGrid.Rows[e.RowIndex].Cells["ProductName"].Style.BackColor = Color.Red;
                //    return;
                //}
                if (senderGrid.Rows[e.RowIndex].Cells["UnitPrice"].Value != null && senderGrid.Rows[e.RowIndex].Cells["TotalQty"].Value != null)
                    tbx_Total.Text = (CalculateTotal(Convert.ToDouble(senderGrid.Rows[e.RowIndex].Cells["UnitPrice"].Value) * Convert.ToDouble(senderGrid.Rows[e.RowIndex].Cells["TotalQty"].Value))).ToString();
                else
                    return;

            }

            if (e.RowIndex != -1 && e.ColumnIndex == senderGrid.Columns["ProductName"].Index)
            {
                VSALSalesOrder vSALSalesOrder = vSALSalesOrderCollection.Where(a => a.ProductID == Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells["ProductName"].Value)).SingleOrDefault();
                if (vSALSalesOrder == null)
                {
                    MessageBox.Show("هذا الصنف غير موجود بالفاتورة الاصليه");
                    senderGrid.Rows[e.RowIndex].ErrorText = "هذا الصنف غير موجود بالفاتورة الاصليه";
                    //senderGrid.Rows[e.RowIndex].Cells["ProductName"].Value = null;
                    senderGrid.Rows[e.RowIndex].Cells["ProductName"].Style.BackColor = Color.Red;
                    return;
                }

                BDProductPrimaryKey pk = new BDProductPrimaryKey();
                pk.ProductID = Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells["ProductName"].Value);

                BDProduct _product = bDProductWrapper.SelectOne(pk);
                senderGrid.Rows[e.RowIndex].Cells["IsAcceptBatch"].Value = _product.IsAcceptBatch;

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
                senderGrid.Rows[e.RowIndex].Cells["UnitPrice"].Value = vSALSalesOrder.FinalPrice;
            }

            if (e.RowIndex != -1 && e.ColumnIndex == senderGrid.Columns["ExpiryDate"].Index)
            {
                if (Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells["ProductName"].Value) == -1)
                {
                    MessageBox.Show("أختر صنف أولا");
                    return;
                }
                DateTime result;
                if (!DateTime.TryParse(senderGrid.Rows[e.RowIndex].Cells["ExpiryDate"].Value.ToString(), out result))
                {
                    MessageBox.Show("صيغة تاريخ الصلاحية غير صحيحة لابد ان تكون (يوم -شهر -سنة)");
                    senderGrid.Rows[e.RowIndex].Cells["ExpiryDate"].Style.BackColor = Color.Red;
                    senderGrid.Rows[e.RowIndex].Cells["ExpiryDate"].Value = "";
                }
                else
                {
                    senderGrid.Rows[e.RowIndex].Cells["ExpiryDate"].Style.BackColor = Color.White;
                }
            }
        }

        #endregion
        #region --Public  Methods
        #endregion
        #region --Private Methods
        private void FillScreenData()
        {
            _vSALSalesOrder = vSALSalesOrderCollection.FirstOrDefault();
            tbx_InvoiceNumber.Text = _vSALSalesOrder.InvoiceNumber;
            tbx_CustomerName.Text = _vSALSalesOrder.CustomerName;
            tbx_SalesMan.Text = _vSALSalesOrder.UserFullName;
            dtb_InvoiceDate.Value = (DateTime)_vSALSalesOrder.InvoiceDate;
            dtb_SalesDate.Value = (DateTime)_vSALSalesOrder.SalesDate;
            invoiceDescount = (double)_vSALSalesOrder.TotalDiscountRatio;
            invoiceTax = (double)_vSALSalesOrder.TaxValue;

        }
        private void CollectHeaderData()
        {
            sALSalesReturnHeader.OriginalSalesHeadeID = _vSALSalesOrder.SalesHeaderID;
            sALSalesReturnHeader.InventoryID = Convert.ToInt32(cbx_Inventory.SelectedValue);
            sALSalesReturnHeader.ReturnDate = DateTime.Now.Date;
            sALSalesReturnHeader.ReturnMoney = Convert.ToDecimal(tbx_Total.Text);
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
            sALSalesReturnLineCollection.Clear();
            foreach (DataGridViewRow row in dgrd_ReturnOrderLines.Rows)
            {
                if (row.Index == dgrd_ReturnOrderLines.Rows.Count - 1)
                    break;

                VSALSalesOrder vSALSalesOrder = vSALSalesOrderCollection.Where(a => a.ProductID == Convert.ToInt32(row.Cells["ProductName"].Value)).SingleOrDefault();
                if (vSALSalesOrder != null)
                    sALSalesReturnLineCollection.Add(new SALSalesReturnLine()
                                          {
                                              OriginalSalesLineID = vSALSalesOrder.SalesLineID,
                                              Qty = Convert.ToDecimal(row.Cells["TotalQty"].Value),
                                              BatchNumber = vSALSalesOrder.IsAcceptBatch == true ? row.Cells["BatchNumber"].Value.ToString() : null,
                                              ExpiryDate = vSALSalesOrder.IsAcceptBatch == true ? Convert.ToDateTime(row.Cells["ExpiryDate"].Value) : (DateTime?)null,
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
        private SALSalesReturnHeader GetSalesReturnHeader(int salesReturnHeaderID)
        {
            SALSalesReturnHeaderPrimaryKey pk = new SALSalesReturnHeaderPrimaryKey();
            pk.SlaesReturnHeaderID = salesReturnHeaderID;
            return sALSalesReturnHeaderWrapper.SelectOne(pk);
        }
        private SALSalesReturnLineCollection GetSalesReturnLines(int salesReturnHeaderID)
        {
            return sALSalesReturnLineWrraper.SelectByField(salesReturnHeaderID);
        }
        private VSALSalesOrderCollection GetSalesOriginalSalesOrderData(int SALSalesHeaderID)
        {
            return sALSalesReturnHeaderWrapper.VSALSalesOrder_SelectOne(SALSalesHeaderID);
        }
        private void FillScreenWithDataForEdit(int salesReturnHeaderID)
        {
            sALSalesReturnHeader = GetSalesReturnHeader(salesReturnHeaderID);
            sALSalesReturnLineCollection = GetSalesReturnLines(salesReturnHeaderID);
            vSALSalesOrderCollection = GetSalesOriginalSalesOrderData((int)sALSalesReturnHeader.OriginalSalesHeadeID);
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
