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
using POS.UserInterfaceLayer.Portal;

namespace POS.UserInterfaceLayer.Administration
{
    public partial class frmLogin : Form
    {
        ADUserWrapper ADUserService;

        public frmLogin()
        {
            InitializeComponent();
            ADUserService = new ADUserWrapper();
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validate())
                {
                    string _message;
                    if (ADUserService.SelectByUserNameAndPassword(tbx_UserName.Text, tbx_Password.Text, out _message))
                    {
                        frmMain frm = new frmMain();
                        frm.ShowDialog();
                        this.Close();
                    }
                    else
                        MessageBox.Show(_message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ برجاء تكرار العمليه مره اخرى واذا تكرر الخطا برجاءالاتصال بالشخص المصمم للبرنامج وارسال رسالة الخطا التى ستظهر بعد قليل له");
                MessageBox.Show(ex.Message);
                
            }
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
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
