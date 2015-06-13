using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using POS.BusinessLayer;
using POS.BusinessLayer.Wrapper;

namespace POS.UserInterfaceLayer.Administration
{
    public partial class frmGroupPriviliges : POS.UserInterfaceLayer.Portal.frmBaseAddEditForm
    {
        ADRoleWrapper _aDRoleWrapper;
        ADGroupRoleWrapper _aDGroupRoleWrapper;
        ADGroupRoleCollection _aDGroupRoleCollection;
        // ADGroupRole _aDGroupRole;
        int _groupID;
        public frmGroupPriviliges(int groupID)
        {
            InitializeComponent();
            _aDRoleWrapper = new ADRoleWrapper();
            _aDGroupRoleWrapper = new ADGroupRoleWrapper();
            lbl_FormHeader.Text = "صلاحيات مجموعة المستخدمين";
            _groupID = groupID;
            _aDGroupRoleCollection = new ADGroupRoleCollection();
        }

        /// Events
        /// 
        public override void btn_Save_Click(object sender, EventArgs e)
        {
            CollectScreenData();
            try
            {
                if (_aDGroupRoleWrapper.InsertGroupRoles(_aDGroupRoleCollection, _groupID))
                {
                    MessageBox.Show("تم الحفظ بنجاح");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ برجاء تكرار العمليه مره اخرى واذا تكرر الخطا برجاءالاتصال بالشخص المصمم للبرنامج وارسال رسالة الخطا التى ستظهر بعد قليل له");
                MessageBox.Show(ex.Message);
            }
        }
        public override void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmGroupPriviliges_Load(object sender, EventArgs e)
        {
            FillRolesDataGrid();
            GetGroupRoles(_groupID);
        }

        /// methods
        /// 
        private void FillRolesDataGrid()
        {
            try
            {
                dgrid_Roles.DataSource = null;
                dgrid_Roles.AutoGenerateColumns = false;
                dgrid_Roles.DataSource = _aDRoleWrapper.SelectAll();
                dgrid_Roles.Columns[0].DataPropertyName = "RoleID";
                dgrid_Roles.Columns[2].DataPropertyName = "RoleName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ برجاء تكرار العمليه مره اخرى واذا تكرر الخطا برجاءالاتصال بالشخص المصمم للبرنامج وارسال رسالة الخطا التى ستظهر بعد قليل له");
                MessageBox.Show(ex.Message);
            }
        }

        private void GetGroupRoles(int groupID)
        {
            try
            {
                ADGroupRoleCollection _aDGroupRoleCollection = _aDGroupRoleWrapper.SelectByGroupID(groupID);
                if (_aDGroupRoleCollection.Count == 0)
                    return;
                foreach (ADGroupRole _aDGroupRole in _aDGroupRoleCollection)
                {
                    foreach (DataGridViewRow row in dgrid_Roles.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["RoleID"].Value) == _aDGroupRole.RoleID)
                        {
                            row.Cells["Check"].Value = true;

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ برجاء تكرار العمليه مره اخرى واذا تكرر الخطا برجاءالاتصال بالشخص المصمم للبرنامج وارسال رسالة الخطا التى ستظهر بعد قليل له");
                MessageBox.Show(ex.Message);
            }
        }

        private void CollectScreenData()
        {
            ADGroupRole _aDGroupRole;
            foreach (DataGridViewRow row in dgrid_Roles.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Check"].Value) == true)
                {
                    _aDGroupRole = new ADGroupRole();
                    _aDGroupRole.RoleID = Convert.ToInt32(row.Cells["RoleID"].Value);
                    _aDGroupRole.GroupID = _groupID;
                    _aDGroupRoleCollection.Add(_aDGroupRole);
                }
            }
            //_aDGroupRoleCollection.
        }


    }
}
