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
    public partial class frmSalesOrderAddEdit : Form
    {
        private BDTaxTypeWrapper _bDTaxTypeWrapper;
        private PaymentTypeWrapper _paymentTypeWrapper;
        private BDCustomerWrapper _bDCustomerWrapper;
        public SALSalesLineCollection sALSalesLineCollection;

        public frmSalesOrderAddEdit()
        {
            InitializeComponent();
            _bDTaxTypeWrapper = new BDTaxTypeWrapper();
            _paymentTypeWrapper = new PaymentTypeWrapper();
            _bDCustomerWrapper = new BDCustomerWrapper();
            sALSalesLineCollection = new SALSalesLineCollection();
            FillCustomerCBX();
            FillPaymentTypeCBX();
            FillTaxTypeCBX();
        }

        #region -- Events

        private void num_Remaining_Leave(object sender, EventArgs e)
        {

            if (num_Remaining.Value > 0)
            {
                dtb_LastTimeToPay.Enabled = true;
            }
        }

        private void btn_AddLine_Click(object sender, EventArgs e)
        {
            frmSalesLineAddEdit frm = new frmSalesLineAddEdit(this);
            frm.FormClosed += frmSalesOrderAddEdit_FormClosed;
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

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSalesOrderAddEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            BindGrid();
            CalculateTotal();
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
            return Total;
        }
        #endregion




    }
}
