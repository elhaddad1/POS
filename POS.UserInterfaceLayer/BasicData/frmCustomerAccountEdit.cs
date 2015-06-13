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

namespace POS.UserInterfaceLayer.BasicData
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
            catch (Exception ex)
            {

                MessageBox.Show("حدث خطأ برجاء تكرار العمليه مره اخرى واذا تكرر الخطا برجاءالاتصال بالشخص المصمم للبرنامج وارسال رسالة الخطا التى ستظهر بعد قليل له");
                MessageBox.Show(ex.Message);
            }
        }
        private bool Validate()
        {
            decimal total = num_Credit.Value-num_Debit.Value;
            if (total < 0)
            {
                num_Credit.Value = 0;
                num_Debit.Value = (total * (-1));
            }
            else
            {
                num_Credit.Value = total;
                num_Debit.Value = 0;
            }
            return true;
        }
        #endregion


    }
}
