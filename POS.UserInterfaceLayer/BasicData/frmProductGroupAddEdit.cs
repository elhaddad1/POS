using POS.BusinessLayer;
using POS.BusinessLayer.Wrapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POS.UserInterfaceLayer.BasicData
{
    public partial class frmProductGroupAddEdit : POS.UserInterfaceLayer.Portal.frmBaseAddEditForm
    {
        private BDProductGroupWrapper _bdProductGroupWrapper = new BDProductGroupWrapper();
        private int _groupId = 0;
        private BDProductGroup _bdProductGroup = new BDProductGroup();

        public frmProductGroupAddEdit()
        {
            InitializeComponent();
            base.lbl_FormHeader.Text = "أضافة";
        }

        public frmProductGroupAddEdit(int groupId)
        {
            InitializeComponent();
            base.lbl_FormHeader.Text = "تعديل";
            this._groupId = groupId;
            initEntity(groupId);
        }


        private void initEntity(int groupId)
        {
            BDProductGroupPrimaryKey pk = new BDProductGroupPrimaryKey();
            pk.ProductGroupID = groupId;
            _bdProductGroup = _bdProductGroupWrapper.SelectOne(pk);
        }

        private bool frmValidation()
        {
            return !string.IsNullOrEmpty(txtGroupName.Text);
        }


        /// <summary>
        /// Events Override
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        public override void btn_Save_Click(object sender, EventArgs e) {
            if (!frmValidation())
            {
                MessageBox.Show("لابد من ادخال اسم المجموعة");
                return;
            }

            _bdProductGroup.ProductGroupName = txtGroupName.Text;
            _bdProductGroup.Notes = txtNotes.Text;
            if(_groupId==0)
                _bdProductGroupWrapper.Insert(_bdProductGroup);
            else
                _bdProductGroupWrapper.Update(_bdProductGroup);
            this.Close();
        
        }

        public override void btn_Back_Click(object sender, EventArgs e) {

            this.Close();
        }
    }
}
