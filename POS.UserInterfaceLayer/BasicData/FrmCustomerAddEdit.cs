using POS.BusinessLayer;
using POS.BusinessLayer.Wrapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POS.UserInterfaceLayer.BasicData
{
    public partial class FrmCustomerAddEdit : POS.UserInterfaceLayer.Portal.frmBaseAddEditForm
    {
        int? CustomerID;
        BDCustomerWrapper customerWrapper;
        BDCustomer customer;
        public FrmCustomerAddEdit(int? CustomerId)
        {
            InitializeComponent();
            customerWrapper = new BDCustomerWrapper();
            CustomerID = CustomerId;
        }
        #region Event Handeler
        private void FrmCustomerAddEdit_Load(object sender, EventArgs e)
        {
            if (CustomerID != null)
            {
                LoadControls();
            }
        }


        public override void btn_Save_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                customer = new BDCustomer();
                BDCustomerService customerService = new BDCustomerService();
                if (CustomerID == null)//new customer
                {
                    customer.CustomerCode = txtCode.Text;
                    customer.CustomerName = txtName.Text;
                    customer.Phone1 = txtPone1.Text;
                    customer.Phone2 = txtphone2.Text;
                    customer.Mobile1 = txtMobile1.Text;
                    customer.Mobile2 = txtMobile2.Text;
                    customer.Email = txtEmail.Text;
                    customer.IsActive = chkIsActive.Checked;
                    customerService.Insert(customer);
                }
                else
                {
                    BDCustomerPrimaryKey pk = new BDCustomerPrimaryKey();
                    pk.CustomerID = CustomerID;
                    customer = customerService.SelectOne(pk);
                    customer.CustomerCode = txtCode.Text;
                    customer.CustomerName = txtName.Text;
                    customer.Phone1 = txtPone1.Text;
                    customer.Phone2 = txtphone2.Text;
                    customer.Mobile1 = txtMobile1.Text;
                    customer.Mobile2 = txtMobile2.Text;
                    customer.Email = txtEmail.Text;
                    customer.IsActive = chkIsActive.Checked;
                }
                customerService.Update(customer);
                 MessageBox.Show("تم الحفظ بنجاح");
            
            }
            else
            {
                MessageBox.Show("لابد من ادخال إسم العميل");
            }
        }
        public override void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        #endregion
        #region Methods
        private void LoadControls()
        {
            BDCustomerPrimaryKey pk = new BDCustomerPrimaryKey();
            pk.CustomerID = CustomerID;
            customer = customerWrapper.SelectOne(pk);
            txtCode.Text = customer.CustomerCode != null ? customer.CustomerCode : "";
            txtName.Text = customer.CustomerName;
            txtPone1.Text = customer.Phone1 != null ? customer.Phone1 : "";
            txtphone2.Text = customer.Phone2 != null ? customer.Phone2 : "";
            txtMobile1.Text = customer.Mobile1 != null ? customer.Mobile1 : "";
            txtMobile2.Text = customer.Mobile2 != null ? customer.Mobile2 : "";
            txtEmail.Text = customer.Email != null ? customer.Email : "";
            chkIsActive.Checked = customer.IsActive != null ? (bool)customer.IsActive : true;
        } 
        #endregion
    }
}
