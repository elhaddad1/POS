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
using POS.UserInterfaceLayer.BasicData;

namespace POS.UserInterfaceLayer.Sales
{
    public partial class frmCustomerAccountEdit : Form
    {
        BDCustomerWrapper _bDCustomerWrapper;
        public BDCustomer _customer;
        public FrmCustomerSearch frmCustomerSearchObj;
        private int _customerID = -1;
        public frmCustomerAccountEdit(int customerID, FrmCustomerSearch _frmCustomerSearch)
        {
            InitializeComponent();
            this._customerID = customerID;
            this._bDCustomerWrapper = new BDCustomerWrapper();
            this._customer = new BDCustomer();
            this.frmCustomerSearchObj = _frmCustomerSearch;
            FillCustomerData();
        }

        #region -- Events Methods

        private void tbx_Price_Leave(object sender, EventArgs e)
        {

        }
        private void btn_Finish_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                _customer.Credit = num_Credit.Value ;
                _customer.Debit = num_Debit.Value;
                _bDCustomerWrapper.Update(_customer);
                frmCustomerSearchObj.InitionGrid();
                this.Close();
            }
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region -- Public Methods

        #endregion

        #region -- Private Methods
        private void FillCustomerData()
        {
            try
            {
                BDCustomerPrimaryKey _customerPrimaryKey = new BDCustomerPrimaryKey();
                _customerPrimaryKey.CustomerID = _customerID;
                _customer = _bDCustomerWrapper.SelectOne(_customerPrimaryKey);
                num_Credit.Value = _customer.Credit.Value;
                num_Debit.Value = _customer.Debit.Value;
            }
            catch (Exception)
            {

                throw;
            }
        }
        new private bool Validate()
        {
            /*if (string.IsNullOrEmpty(tbx_Price.Text))
            {
                MessageBox.Show("برجاء أدهال سعر المنتج");
                return false;
            }
            if (Convert.ToDecimal(tbx_Price.Text == "" ? "0" : tbx_Price.Text) < Convert.ToDecimal(lbl_MinPriceValue.Text == "" ? "0" : lbl_MinPriceValue.Text))
            {
                MessageBox.Show("برجاء مراعاة أقل سعر للمنتج");
                return false;
            }
            if (string.IsNullOrEmpty(num_Quantity.Text) || Convert.ToInt32(num_Quantity.Text) <= 0)
            {
                MessageBox.Show("أدخل كميه مناسبه");
                return false;
            }*/
            return true;
        }
        #endregion


    }
}
