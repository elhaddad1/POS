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
        public FrmCustomerAddEdit()
        {
            InitializeComponent();
            customerWrapper = new BDCustomerWrapper();
           
        }
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
            if (tbx_Name.Text != "")
            {
                customer = new BDCustomer();
                BDCustomerService customerService = new BDCustomerService();
                if (CustomerID == null)//new customer
                {
                    customer.CustomerCode = tbx_Code.Text;
                    customer.CustomerName = tbx_Name.Text;
                    customer.Address = tbx_Address.Text;
                    customer.Phone1 = tbx_Pone1.Text;
                    customer.Phone2 = tbx_phone2.Text;
                    customer.Mobile1 = tbx_Mobile1.Text;
                    customer.Mobile2 = tbx_Mobile2.Text;
                    customer.Email = tbx_Email.Text;
                    customer.IsActive = chk_IsActive.Checked;
                    customer.Debit = 0;
                    customer.Credit = 0;
                    customerService.Insert(customer);
                    MessageBox.Show("تم الحفظ بنجاح");
                   
                }
                else
                {
                    BDCustomerPrimaryKey pk = new BDCustomerPrimaryKey();
                    pk.CustomerID = CustomerID;
                    customer = customerService.SelectOne(pk);
                    customer.CustomerCode = tbx_Code.Text;
                    customer.CustomerName = tbx_Name.Text;
                    customer.Address = tbx_Address.Text;
                    customer.Phone1 = tbx_Pone1.Text;
                    customer.Phone2 = tbx_phone2.Text;
                    customer.Mobile1 = tbx_Mobile1.Text;
                    customer.Mobile2 = tbx_Mobile2.Text;
                    customer.Email = tbx_Email.Text;
                    customer.IsActive = chk_IsActive.Checked;
                   customerService.Update(customer);
                   MessageBox.Show("تم التعديل بنجاح");
                }
               
               
            
            }
            else
            {
                MessageBox.Show("لابد من ادخال إسم العميل");
            }

            this.Close();
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
            tbx_Code.Text = customer.CustomerCode != null ? customer.CustomerCode : "";
            tbx_Name.Text = customer.CustomerName;
            tbx_Address.Text = customer.Address != null ? customer.Address : "";
            tbx_Pone1.Text = customer.Phone1 != null ? customer.Phone1 : "";
            tbx_phone2.Text = customer.Phone2 != null ? customer.Phone2 : "";
            tbx_Mobile1.Text = customer.Mobile1 != null ? customer.Mobile1 : "";
            tbx_Mobile2.Text = customer.Mobile2 != null ? customer.Mobile2 : "";
            tbx_Email.Text = customer.Email != null ? customer.Email : "";
            chk_IsActive.Checked = customer.IsActive != null ? (bool)customer.IsActive : true;
        }
        private void ClearControls()
        {
            tbx_Code.Text =  "";
            tbx_Name.Text = "";
            tbx_Address.Text =  "";
            tbx_Pone1.Text =  "";
            tbx_phone2.Text =  "";
            tbx_Mobile1.Text ="";
            tbx_Mobile2.Text =  "";
            tbx_Email.Text = "";
            chk_IsActive.Checked = true;
        }
        #endregion
    }
}
