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

namespace POS.UserInterfaceLayer.Administration
{
    public partial class frmLogin : Form
    {
        ADUserServiceWrapper ADUserService;
        public frmLogin()
        {
            InitializeComponent();
            ADUserService = new ADUserServiceWrapper();
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            if (Validate())
                if (!ADUserService.SelectByUserNameAndPassword(tbx_UserName.Text, tbx_Password.Text))
                    MessageBox.Show("خطأ فى اسم المستخدم او رمز الدخول");
        }

        private bool Validate()
        {
            if (string.IsNullOrEmpty(tbx_UserName.Text))
            {
                tbx_UserName.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tbx_Password.Text))
            {
                tbx_Password.Focus();
                return false;
            }
            return true;
        }
    }
}
