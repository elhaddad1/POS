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

namespace POS.UserInterfaceLayer.Portal
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ApplyingUserPriviliges();

        }

        /// Methods
        /// 
        private void ApplyingUserPriviliges()
        {
            lbl_Welcome.Text = GlobalVariables.CurrentUser.UserFullName;
            foreach (KeyValuePair<string, string> roles in GlobalVariables.CurrentUser.UserRoles)
            {
                mnu_MainMenu.Items[roles.Key].Visible = true;
                mnu_MainMenu.Items.Find(roles.Value, true).FirstOrDefault().Visible = true;
            }
        }


    }
}
