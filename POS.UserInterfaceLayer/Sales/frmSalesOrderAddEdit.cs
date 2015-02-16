using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS.BusinessLayer.Wrapper;

namespace POS.UserInterfaceLayer.Sales
{
    public partial class frmSalesOrderAddEdit : Form
    {
        BDTaxTypeWrapper _bDTaxTypeWrapper;
        PaymentTypeWrapper _paymentTypeWrapper;
        BDCustomerWrapper _bDCustomerWrapper;
        public frmSalesOrderAddEdit()
        {
            InitializeComponent();
            _bDTaxTypeWrapper = new BDTaxTypeWrapper();
            _paymentTypeWrapper = new PaymentTypeWrapper();
            _bDCustomerWrapper = new BDCustomerWrapper();
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
            frmSalesLineAddEdit frm = new frmSalesLineAddEdit();
            frm.ShowDialog();
        }

        private void btn_DeleteLine_Click(object sender, EventArgs e)
        {
            if (dgrd_OrderLines.SelectedRows.Count != 0)
                dgrd_OrderLines.Rows.RemoveAt(dgrd_OrderLines.SelectedRows[0].Index);
            else
                MessageBox.Show("برجاء أختيار عنصر من القائمه");
        }

        private void btn_Plus_Click(object sender, EventArgs e)
        {
            if (dgrd_OrderLines.SelectedRows.Count != 0)
            {
                int Qty = Convert.ToInt32(dgrd_OrderLines.SelectedRows[0].Cells["Qty"].Value);
                Qty++;
                dgrd_OrderLines.SelectedRows[0].Cells["Qty"].Value = Qty;
            }
            else
                MessageBox.Show("برجاء أختيار عنصر من القائمه");
        }

        private void btn_Minus_Click(object sender, EventArgs e)
        {
            if (dgrd_OrderLines.SelectedRows.Count != 0)
            {
                int Qty = Convert.ToInt32(dgrd_OrderLines.SelectedRows[0].Cells["Qty"].Value);
                Qty--;
                dgrd_OrderLines.SelectedRows[0].Cells["Qty"].Value = Qty;
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

        #endregion


    }
}
