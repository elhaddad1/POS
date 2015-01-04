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
    public partial class frmUserGroupAddEdit : POS.UserInterfaceLayer.Portal.frmBaseAddEditForm
    {
        ADGroupWrapper _aDGroupWrapper;
        private int _groupID = 0;
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
        private void InitiateEntity(int groupID)
        {
            ADGroupPrimaryKey pk = new ADGroupPrimaryKey();
            pk.GroupID = groupID;
            ADGroup _aDGroup = _aDGroupWrapper.SelectOne(pk);
            tbx_GroupName.Text = _aDGroup.GroupName;
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
