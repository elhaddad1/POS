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
using POS.BusinessLayer.Wrapper;


namespace POS.UserInterfaceLayer.Administration
{
    public partial class frmUserAddEdit : POS.UserInterfaceLayer.Portal.frmBaseAddEditForm
    {
        ADUserWrapper _aDUserWrapper;

        ADUser _aDUser;


        private int _userID = -1;

        public frmUserAddEdit()
        {
            InitializeComponent();
            base.lbl_FormHeader.Text = "أضافة مستخدم";
            _aDUserWrapper = new ADUserWrapper();
            FillCbxGroup();

        }

        public frmUserAddEdit(int userID)
        {
            InitializeComponent();
            base.lbl_FormHeader.Text = "تعديل مستخدم";
            _aDUserWrapper = new ADUserWrapper();
            _userID = userID;
            FillCbxGroup();
            InitiateEntity(userID);
        }

        /// <summary>
        /// Events Override
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        public override void btn_Save_Click(object sender, EventArgs e)
        {
            if (!Valdation())
                return;
            CollectScreenData();
            try
            {
                if (_userID == -1)
                {
                    if (!_aDUserWrapper.Insert(_aDUser))
                        return;
                }
                else
                {
                    _aDUser.UserID = _userID;
                    if (!_aDUserWrapper.Update(_aDUser))
                        return;
                }
                MessageBox.Show("تم الحفظ بنجاح");
                this.Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        public override void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Private methods
        /// </summary>
        /// <param name="userID"></param>
        /// 
        private void InitiateEntity(int userID)
        {
            ADUserPrimaryKey pk = new ADUserPrimaryKey();
            pk.UserID = userID;
            ADUser _aDUser = _aDUserWrapper.SelectOne(pk);
            tbx_UserFullName.Text = _aDUser.UserFullName;
            tbx_Address.Text = _aDUser.Address;
            tbx_Email.Text = _aDUser.Email;
            tbx_Mobile.Text = _aDUser.Mobile;
            tbx_Phone.Text = _aDUser.Phone;
            tbx_UserName.Text = _aDUser.UserName;
            tbx_Password.Text = _aDUser.Password;
            cbx_Group.SelectedValue = _aDUser.GroupID;
        }
        private bool Valdation()
        {
            if (string.IsNullOrEmpty(tbx_UserFullName.Text))
            {
                MessageBox.Show("لابد من ادخال اسم المستخدم");
                tbx_UserFullName.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tbx_UserName.Text))
            {
                MessageBox.Show("لابد من ادخال اسم الدخول");
                tbx_UserName.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tbx_Password.Text))
            {
                MessageBox.Show("لابد من ادخال رمز الدخول");
                tbx_Password.Focus();
                return false;
            }
            if (cbx_Group.SelectedIndex == -1)
            {
                MessageBox.Show("لابد من اختيار المجموعه التابع لها");
                return false;
            }

            return true;
        }
        private void CollectScreenData()
        {
            _aDUser = new ADUser();
            _aDUser.UserFullName = tbx_UserFullName.Text;
            _aDUser.UserName = tbx_UserName.Text;
            _aDUser.Password = tbx_Password.Text;
            _aDUser.Mobile = tbx_Mobile.Text;
            _aDUser.Phone = tbx_Phone.Text;
            _aDUser.Email = tbx_Email.Text;
            _aDUser.Address = tbx_Address.Text;
            _aDUser.GroupID = Convert.ToInt32(cbx_Group.SelectedValue);
        }
        private void FillCbxGroup()
        {
            try
            {
                ADGroupWrapper _aDGroupWrapper = new ADGroupWrapper();
                cbx_Group.DataSource = _aDGroupWrapper.SelectAll();
                cbx_Group.DisplayMember = "GroupName";
                cbx_Group.ValueMember = "GroupID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
