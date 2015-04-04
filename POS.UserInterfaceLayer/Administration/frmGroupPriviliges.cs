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
        int _groupID;
        public frmGroupPriviliges(int groupID)
        {
            InitializeComponent();
            _aDRoleWrapper = new ADRoleWrapper();
            _aDGroupRoleWrapper = new ADGroupRoleWrapper();
            lbl_FormHeader.Text = "صلاحيات مجموعة المستخدمين";

          
            _groupID = groupID;
        }

        /// Events
        /// 
        public override void btn_Save_Click(object sender, EventArgs e)
        {
            // bool b=(bool)dgrid_Roles.Rows[0].Cells["Check"].Value;
            //if (!Valdation()) { return; }
            //CollectScreenData();
            try
            {
                test();
                //if (_groupID == -1)
                //    _aDGroupWrapper.Insert(_aDGroup);
                //else
                //{
                //    _aDGroup.GroupID = _groupID;
                //    _aDGroupWrapper.Update(_aDGroup);
                //}
                //MessageBox.Show("تم الحفظ بنجاح");
                //this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public override void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
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
                //foreach (DataGridViewRow row in dgrid_Roles.Rows)
                //{
                //    row.Cells["check"].Value = true;
                //   // chk.Selected = false;

                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetGroupRoles(int groupID)
        {
            try
            {
                ADGroupRoleCollection _aDGroupRoleCollection = _aDGroupRoleWrapper.SelectByGroupID(groupID);
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
                MessageBox.Show(ex.Message);
            }
        }

        private void test()
        {
            //foreach (DataGridViewRow row in dgrid_Roles.Rows)
            //{
            //    DataGridViewCheckBoxCell x = (DataGridViewCheckBoxCell)row.Cells["Check"];
            //}

        }

        private void frmGroupPriviliges_Load(object sender, EventArgs e)
        {
            FillRolesDataGrid();
            GetGroupRoles(_groupID);
        }
    }
}
