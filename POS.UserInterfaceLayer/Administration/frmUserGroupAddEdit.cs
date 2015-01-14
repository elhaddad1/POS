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
    public partial class frmUserGroupAddEdit : POS.UserInterfaceLayer.Portal.frmBaseAddEditForm
    {
        ADGroupWrapper _aDGroupWrapper;
        ADRoleWrapper _aDRoleWrapper;
        ADGroupRoleWrapper _aDGroupRoleWrapper;
        private int _groupID = 0;

        public frmUserGroupAddEdit()
        {
            InitializeComponent();
            base.lbl_FormHeader.Text = "أضافة مجموعة";
            _aDGroupWrapper = new ADGroupWrapper();
            _aDRoleWrapper = new ADRoleWrapper();
            FillRolesDataGrid();
        }

        public frmUserGroupAddEdit(int groupID)
        {
            InitializeComponent();
            base.lbl_FormHeader.Text = "تعديل مجموعة";
            _aDGroupWrapper = new ADGroupWrapper();
            _aDRoleWrapper = new ADRoleWrapper();
            _aDGroupRoleWrapper = new ADGroupRoleWrapper();

            _groupID = groupID;
            FillRolesDataGrid();
            InitiateEntity(groupID);
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
            {
                MessageBox.Show("لابد من ادخال اسم المجموعة");
                return;
            }
            ADGroup _aDGroup = new ADGroup();
            _aDGroup.GroupName = tbx_GroupName.Text;


            if (_groupID == 0)
            {
                _aDGroupWrapper.Insert(_aDGroup);
            }
            else
            {
                _aDGroup.GroupID = _groupID;
                _aDGroupWrapper.Update(_aDGroup);
            }
            this.Close();

        }
        public override void btn_Back_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        /// <summary>
        /// Private methods
        /// </summary>
        /// <param name="groupID"></param>
        /// 
        private void FillRolesDataGrid()
        {
            dgrid_Roles.DataSource = null;
            dgrid_Roles.AutoGenerateColumns = false;

            dgrid_Roles.DataSource = _aDRoleWrapper.SelectAll();
            dgrid_Roles.Columns[0].DataPropertyName = "RoleID";
            dgrid_Roles.Columns[2].DataPropertyName = "RoleName";
            for (int i = 0; i < dgrid_Roles.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dgrid_Roles.Rows[i].Cells["check"];
                chk.Selected = false;
                chk.Value = 1;
            }

        }
        private void InitiateEntity(int groupID)
        {
            ADGroupPrimaryKey pk = new ADGroupPrimaryKey();
            pk.GroupID = groupID;
            ADGroup _aDGroup = _aDGroupWrapper.SelectOne(pk);
            tbx_GroupName.Text = _aDGroup.GroupName;

            ADGroupRoleCollection _aDGroupRoleCollection = _aDGroupRoleWrapper.SelectByGroupID(groupID);
            foreach (ADGroupRole _aDGroupRole in _aDGroupRoleCollection)
            {
                for (int i = 0; i < dgrid_Roles.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dgrid_Roles.Rows[i].Cells["RoleID"].Value) == _aDGroupRole.RoleID)
                    {
                        DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dgrid_Roles.Rows[i].Cells["check"];
                        chk.Selected = true;
                        chk.Value = 1;
                    }
                }
            }
        }
        private bool Valdation()
        {
            if (string.IsNullOrEmpty(tbx_GroupName.Text))
            {
                tbx_GroupName.Focus();
                return false;
            }
            return true;
        }

        private void btn_GroupPriviliges_Click(object sender, EventArgs e)
        {
            frmGroupPriviliges frm = new frmGroupPriviliges();
            frm.ShowDialog();
        }
    }
}
