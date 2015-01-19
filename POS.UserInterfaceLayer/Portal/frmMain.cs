using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS.BusinessLayer.Utility;
using POS.UserInterfaceLayer.Administration;
using POS.UserInterfaceLayer.BasicData;

namespace POS.UserInterfaceLayer.Portal
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            ApplyingUserPriviliges();
        }

        // Events
        //
        private void frmMain_Load(object sender, EventArgs e)
        {
            

        }
        private void mnuItem_UserGroups_Click(object sender, EventArgs e)
        {
            frmUserGroupSearch frm = new frmUserGroupSearch();
            frm.ShowDialog();
        }
        private void mnuItem_Customers_Click(object sender, EventArgs e)
        {
            FrmCustomerSearch frm = new FrmCustomerSearch();
            frm.ShowDialog();
        }
        private void mnuItem_Products_Click(object sender, EventArgs e)
        {
            frmBDProductSearch frm = new frmBDProductSearch();
            frm.ShowDialog();
        }

        private void mnuItem_ProductGroup_Click(object sender, EventArgs e)
        {
            frmProductGroupSearch frm = new frmProductGroupSearch();
            frm.ShowDialog();
        }

        private void mnuItem_Suppliers_Click(object sender, EventArgs e)
        {
            FrmSupplierSearch frm = new FrmSupplierSearch();
            frm.ShowDialog();
        }
        /// private Methods
        /// 
        private void ApplyingUserPriviliges()
        {

            lbl_Welcome.Text = GlobalVariables.CurrentUser.UserFullName;
            try
            {
                foreach (string roles in GlobalVariables.CurrentUser.UserRoles)
                {
                    string[] arr = roles.Split('/');
                    foreach (string element in arr)
                    {
                        mnu_MainMenu.Items.Find(element, true).FirstOrDefault().Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }









    }
}
