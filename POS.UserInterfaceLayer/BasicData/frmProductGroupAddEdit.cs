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
        private frmProductGroupSearch _frmProductGroupSearch = new frmProductGroupSearch();

        public frmProductGroupAddEdit(frmProductGroupSearch frmProductGroupSearch)
        {
            InitializeComponent();
            base.lbl_FormHeader.Text = "أضافة";
            this._frmProductGroupSearch = frmProductGroupSearch;
        }

        public frmProductGroupAddEdit(int groupId, frmProductGroupSearch frmProductGroupSearch)
        {
            InitializeComponent();
            base.lbl_FormHeader.Text = "تعديل";
            this._groupId = groupId;
            initEntity(groupId);
            this._frmProductGroupSearch = frmProductGroupSearch;
        }


        private void initEntity(int groupId)
        {
            BDProductGroupPrimaryKey pk = new BDProductGroupPrimaryKey();
            pk.ProductGroupID = groupId;
            _bdProductGroup = _bdProductGroupWrapper.SelectOne(pk);
            txt_GroupName.Text =_bdProductGroup.ProductGroupName;
            txt_Notes.Text = _bdProductGroup.Notes;
        }

        private bool frmValidation()
        {
            return !string.IsNullOrEmpty(txt_GroupName.Text);
        }


        /// <summary>
        /// Events Override
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        public override void btn_Save_Click(object sender, EventArgs e) {
            try
            {
                if (!frmValidation())
                {
                    MessageBox.Show("لابد من ادخال اسم المجموعة");
                    return;
                }
                saveChanges();
                this._frmProductGroupSearch.InitiateGrid();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ برجاء تكرار العمليه مره اخرى واذا تكرر الخطا برجاءالاتصال بالشخص المصمم للبرنامج وارسال رسالة الخطا التى ستظهر بعد قليل له");
                MessageBox.Show(ex.Message);
            }
        }

        private void saveChanges()
        {

            _bdProductGroup.ProductGroupName = txt_GroupName.Text;
            _bdProductGroup.Notes = txt_Notes.Text;
            if (_groupId == 0)
                _bdProductGroupWrapper.Insert(_bdProductGroup);
            else
                _bdProductGroupWrapper.Update(_bdProductGroup);
        }

        public override void btn_Back_Click(object sender, EventArgs e) {

            this.Close();
        }
    }
}
