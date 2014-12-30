using POS.BusinessLayer;
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
        public FrmCustomerAddEdit(int? CustomerId)
        {
            InitializeComponent();
            CustomerID = CustomerId;
        }
        public override void btn_Save_Click(object sender, EventArgs e)
        {
            if (txtName .Text !="")
            {   BDCustomer customer = new BDCustomer();
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
                    BDCustomerPrimaryKey pk=new BDCustomerPrimaryKey ();
                    pk.CustomerID =CustomerID;
                    customer=customerService.SelectOne(pk);
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
    }
}
