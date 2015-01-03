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

namespace POS.UserInterfaceLayer.Portal
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // Events
        //
        private void frmMain_Load(object sender, EventArgs e)
        {
            ApplyingUserPriviliges();

        }
        private void mnuItem_UserGroups_Click(object sender, EventArgs e)
        {
            frmUserGroupSearch frm = new frmUserGroupSearch();
            frm.ShowDialog();
        }

        /// private Methods
        /// 
        private void ApplyingUserPriviliges()
        {
            lbl_Welcome.Text = GlobalVariables.CurrentUser.UserFullName;
            foreach (string roles in GlobalVariables.CurrentUser.UserRoles)
            {
                string[] arr = roles.Split('/');
                foreach (string element in arr)
                {
                    mnu_MainMenu.Items.Find(element, true).FirstOrDefault().Visible = true;
                }
            }
        }




    }
}
