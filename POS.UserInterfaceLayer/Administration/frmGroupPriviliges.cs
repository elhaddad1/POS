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
        public frmGroupPriviliges(int groupID)
        {
            InitializeComponent();
            _aDRoleWrapper = new ADRoleWrapper();
            _aDGroupRoleWrapper = new ADGroupRoleWrapper();
            lbl_FormHeader.Text = "صلاحيات مجموعة المستخدمين";

            FillRolesDataGrid();
            GetGroupRoles(groupID);
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
            dgrid_Roles.DataSource = null;
            dgrid_Roles.AutoGenerateColumns = false;

            dgrid_Roles.DataSource = _aDRoleWrapper.SelectAll();
            dgrid_Roles.Columns[0].DataPropertyName = "RoleID";
            dgrid_Roles.Columns[2].DataPropertyName = "RoleName";
            foreach (DataGridViewRow row in dgrid_Roles.Rows)
            {
                //DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dgrid_Roles.Rows[i].Cells["check"];
                //chk.Selected = false;

            }
        }

        private void GetGroupRoles(int groupID)
        {
            ADGroupRoleCollection _aDGroupRoleCollection = _aDGroupRoleWrapper.SelectByGroupID(groupID);
            foreach (ADGroupRole _aDGroupRole in _aDGroupRoleCollection)
            {
                for (int i = 0; i < dgrid_Roles.Rows.Count; i++)
                {
                    CheckBox check = new CheckBox();
                    dgrid_Roles.Rows[i].Cells["Check"].Value = true;
                    dgrid_Roles.RefreshEdit();
                }
                //foreach (DataGridViewRow row in dgrid_Roles.Rows)
                //{
                //    if (Convert.ToInt32(row.Cells["RoleID"].Value) == _aDGroupRole.RoleID)
                //    {
                //        //(DataGridViewCheckBoxCell)row.Cells["Check"].EditedFormattedValue = true;
                //        //(DataGridViewCheckBoxCell)row.Cells["Check"].EditingCellFormattedValue = true;
                //        //ck.EditingCellFormattedValue = true;
                //        //row.Cells["Check"].Selected = false;
                //        //chk.TrueValue = true;
                //        //chk.Value = 1;

                //    }
                //}
            }
        }

        private void test()
        {
            //foreach (DataGridViewRow row in dgrid_Roles.Rows)
            //{
            //    DataGridViewCheckBoxCell x = (DataGridViewCheckBoxCell)row.Cells["Check"];
            //}

        }
    }
}
