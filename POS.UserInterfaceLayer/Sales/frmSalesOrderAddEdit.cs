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
using POS.BusinessLayer.Utility;
using POS.BusinessLayer.Wrapper;

namespace POS.UserInterfaceLayer.Sales
{
    public partial class frmSalesOrderAddEdit : Form
    {
        private BDTaxTypeWrapper _bDTaxTypeWrapper;
        private PaymentTypeWrapper _paymentTypeWrapper;
        private BDCustomerWrapper _bDCustomerWrapper;
        private SALSalesLinerWrapper _sALSalesLinerWrapper;
        public SALSalesLineCollection sALSalesLineCollection;

        public frmSalesOrderAddEdit()
        {
            InitializeComponent();
            _bDTaxTypeWrapper = new BDTaxTypeWrapper();
            _paymentTypeWrapper = new PaymentTypeWrapper();
            _bDCustomerWrapper = new BDCustomerWrapper();
            sALSalesLineCollection = new SALSalesLineCollection();
            _sALSalesLinerWrapper = new SALSalesLinerWrapper();
            FillCustomerCBX();
            FillPaymentTypeCBX();
            FillTaxTypeCBX();
        }

        #region -- Events

        private void num_Remaining_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(num_Remaining.Text) < 0)
            {
                dtb_LastTimeToPay.Enabled = true;
            }
        }

        private void btn_AddLine_Click(object sender, EventArgs e)
        {
            frmSalesLineAddEdit frm = new frmSalesLineAddEdit(this);
            frm.FormClosed += frmSalesLineAddEdit_FormClosed;
            frm.ShowDialog();

        }

        private void btn_DeleteLine_Click(object sender, EventArgs e)
        {
            if (dgrd_OrderLines.SelectedRows.Count != 0)
            {
                sALSalesLineCollection.RemoveAt(dgrd_OrderLines.SelectedRows[0].Index);
                //dgrd_OrderLines.Rows.RemoveAt(dgrd_OrderLines.SelectedRows[0].Index);
                BindGrid();
                CalculateTotal();
            }
            else
                MessageBox.Show("برجاء أختيار عنصر من القائمه");
        }

        private void btn_Plus_Click(object sender, EventArgs e)
        {
            if (dgrd_OrderLines.SelectedRows.Count != 0)
            {
                sALSalesLineCollection.Where(a => a.ProductID == (int?)dgrd_OrderLines.SelectedRows[0].Cells["ProductID"].Value).SingleOrDefault().TotalQty++;
                BindGrid();
                CalculateTotal();
            }
            else
                MessageBox.Show("برجاء أختيار عنصر من القائمه");
        }

        private void btn_Minus_Click(object sender, EventArgs e)
        {
            if (dgrd_OrderLines.SelectedRows.Count != 0)
            {
                sALSalesLineCollection.Where(a => a.ProductID == (int?)dgrd_OrderLines.SelectedRows[0].Cells["ProductID"].Value).SingleOrDefault().TotalQty--;
                BindGrid();
                CalculateTotal();
            }
            else
                MessageBox.Show("برجاء أختيار عنصر من القائمه");
        }

        private void btn_ClosePrint_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                try
                {
                    if (_sALSalesLinerWrapper.SaveCloseSALSalesOrder(CollectHeaderData(), sALSalesLineCollection))
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
                    if (_sALSalesLinerWrapper.SaveSALSalesOrder(CollectHeaderData(), sALSalesLineCollection))
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
        #endregion

        #region -- Public Methods

        #endregion

        #region -- Private Methods
        private void FillCustomerCBX()
        {

            try
            {
                cbx_Customer.DataSource = _bDCustomerWrapper.SelectAll().OrderBy(a => a.CustomerName).ToList();
                cbx_Customer.DisplayMember = "CustomerName";
                cbx_Customer.ValueMember = "CustomerID";
                cbx_Customer.SelectedIndex = -1;
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
        private void BindGrid()
        {
            dgrd_OrderLines.DataSource = null;
            dgrd_OrderLines.AutoGenerateColumns = false;
            dgrd_OrderLines.DataSource = sALSalesLineCollection;
            dgrd_OrderLines.Columns[0].DataPropertyName = "ProductID";
            dgrd_OrderLines.Columns[1].DataPropertyName = "ProductName";
            dgrd_OrderLines.Columns[2].DataPropertyName = "TotalQty";
            dgrd_OrderLines.Columns[3].DataPropertyName = "UnitPrice";

        }
        private decimal CalculateTotal()
        {
            decimal Total = 0;
            foreach (SALSalesLine q in sALSalesLineCollection)
            {
                Total += (decimal)(q.TotalQty * q.UnitPrice);

            }
            txt_Total.Text = Total.ToString();
            txt_AfterDescount.Text = Total.ToString();
            num_Remaining.Text = (Convert.ToDecimal(num_Paied.Text) - Total).ToString();
            return Total;
        }
        private SALSalesHeader CollectHeaderData()
        {
            SALSalesHeader _sALSalesHeader = new SALSalesHeader();
            _sALSalesHeader.CustomerID = Convert.ToInt32(cbx_Customer.SelectedValue);
            _sALSalesHeader.InvoiceDate = dtb_Date.Value.Date;
            _sALSalesHeader.LastDayToPay = dtb_LastTimeToPay.Value.Date;
            _sALSalesHeader.PaidAmount = string.IsNullOrEmpty(num_Paied.Text) ? 0 : Convert.ToDecimal(num_Paied.Text);
            _sALSalesHeader.RemainingAmount = string.IsNullOrEmpty(num_Remaining.Text) ? 0 : Convert.ToDecimal(num_Remaining.Text);
            _sALSalesHeader.PaymentTypeID = Convert.ToInt32(cbx_PaymentType.SelectedValue);
            _sALSalesHeader.ServicePrice = string.IsNullOrEmpty(num_OtherPayments.Text) ? 0 : Convert.ToDecimal(num_OtherPayments.Text);
            _sALSalesHeader.TaxTypeID = cbx_TaxType.SelectedIndex == -1 ? null : (int?)(cbx_TaxType.SelectedValue);
            decimal total = Convert.ToDecimal(txt_Total.Text);
            decimal discountRatio = (Convert.ToDecimal(txt_DiscountRatio.Text.Trim(new char[] { '%' })) / 100);
            _sALSalesHeader.TotalDiscountAmount = total * discountRatio;
            _sALSalesHeader.TotalDiscountRatio = (double)discountRatio;
            _sALSalesHeader.TotalPrice = Convert.ToDecimal(txt_Total.Text);

            return _sALSalesHeader;
        }
        private bool Validate()
        {
            if (cbx_Customer.SelectedIndex == -1)
            {
                MessageBox.Show("اختار عميل أولا");
                return false;
            }
            if (cbx_PaymentType.SelectedIndex == -1)
            {
                MessageBox.Show("اختار طريقة دفع أولا");
                return false;
            }



            return true;
        }
        #endregion


    }
}
