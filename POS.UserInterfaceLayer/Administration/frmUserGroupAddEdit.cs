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

        ADGroup _aDGroup;


        private int _groupID = -1;

        public frmUserGroupAddEdit()
        {
            InitializeComponent();
            base.lbl_FormHeader.Text = "أضافة مجموعة";
            _aDGroupWrapper = new ADGroupWrapper();


        }

        public frmUserGroupAddEdit(int groupID)
        {
            InitializeComponent();
            base.lbl_FormHeader.Text = "تعديل مجموعة";
            _aDGroupWrapper = new ADGroupWrapper();
            _groupID = groupID;

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
            if (!Valdation()) {  return; }
            CollectScreenData();
            try
            {
                if (_groupID == -1)
                    _aDGroupWrapper.Insert(_aDGroup);
                else
                {
                    _aDGroup.GroupID = _groupID;
                    _aDGroupWrapper.Update(_aDGroup);
                }
                MessageBox.Show("تم الحفظ بنجاح");
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
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
        //private void FillRolesDataGrid()
        //{
        //    dgrid_Roles.DataSource = null;
        //    dgrid_Roles.AutoGenerateColumns = false;

        //    dgrid_Roles.DataSource = _aDRoleWrapper.SelectAll();
        //    dgrid_Roles.Columns[0].DataPropertyName = "RoleID";
        //    dgrid_Roles.Columns[2].DataPropertyName = "RoleName";
        //    for (int i = 0; i < dgrid_Roles.Rows.Count; i++)
        //    {
        //        //DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dgrid_Roles.Rows[i].Cells["check"];
        //        //chk.Selected = false;

        //    }

        //}
        private void InitiateEntity(int groupID)
        {
            ADGroupPrimaryKey pk = new ADGroupPrimaryKey();
            pk.GroupID = groupID;
            ADGroup _aDGroup = _aDGroupWrapper.SelectOne(pk);
            tbx_GroupName.Text = _aDGroup.GroupName;

            //ADGroupRoleCollection _aDGroupRoleCollection = _aDGroupRoleWrapper.SelectByGroupID(groupID);
            //foreach (ADGroupRole _aDGroupRole in _aDGroupRoleCollection)
            //{
            //    foreach (DataGridViewRow row in dgrid_Roles.Rows)
            //    {
            //        if (Convert.ToInt32(row.Cells["RoleID"].Value) == _aDGroupRole.RoleID)
            //        {
            //            row.Cells["check"].Value = true;
            //            //chk.Selected = true;
            //            //chk.TrueValue = true;
            //            //chk.Value = 1;
            //        }
            //    }
            //}
        }
        private bool Valdation()
        {
            if (string.IsNullOrEmpty(tbx_GroupName.Text))
            {
                MessageBox.Show("لابد من ادخال اسم المجموعة");
                tbx_GroupName.Focus();
                return false;
            }
            return true;
        }
        private void CollectScreenData()
        {
            _aDGroup = new ADGroup();
            _aDGroup.GroupName = tbx_GroupName.Text;

            //foreach (DataGridViewRow row in dgrid_Roles.Rows)
            //{
            //    ADGroupRole _aDGroupRole = new ADGroupRole();

            //    if ((bool)row.Cells["check"].Value == true)
            //        _aDGroupRole.RoleID = Convert.ToInt32(row.Cells["RoleID"].Value);

            //    _aDGroupRoleCollection.Add(_aDGroupRole);
            //}
        }
    }
}
