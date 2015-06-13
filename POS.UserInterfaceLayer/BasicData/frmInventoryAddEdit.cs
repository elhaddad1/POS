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
    public partial class frmInventoryAddEdit : POS.UserInterfaceLayer.Portal.frmBaseAddEditForm
    {
        private INVInventoryWrapper _invInventoryWrapper = new INVInventoryWrapper();
        private int _inventoryId = 0;
        private INVInventory _invInventory = new INVInventory();
        private frmInventorySearch _frmInventorySearch = new frmInventorySearch();

        public frmInventoryAddEdit(frmInventorySearch frmInventorySearch)
        {
            InitializeComponent();
            base.lbl_FormHeader.Text = "أضافة";
            this._frmInventorySearch = frmInventorySearch;
        }

        public frmInventoryAddEdit(int inventoryId, frmInventorySearch frmInventorySearch)
        {
            InitializeComponent();
            base.lbl_FormHeader.Text = "تعديل";
            this._inventoryId = inventoryId;
            initEntity(inventoryId);
            this._frmInventorySearch = frmInventorySearch;
        }


        private void initEntity(int inventoryId)
        {
            INVInventoryPrimaryKey pk = new INVInventoryPrimaryKey();
            pk.InventoryID = inventoryId;
            _invInventory = _invInventoryWrapper.SelectOne(pk);
            txt_InventoryName.Text =_invInventory.InventoryName;
            txt_Notes.Text = _invInventory.Notes;
        }

        private bool frmValidation()
        {
            return !string.IsNullOrEmpty(txt_InventoryName.Text);
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
                    MessageBox.Show("لابد من ادخال اسم المخزن");
                    return;
                }
                saveChanges();
                this._frmInventorySearch.InitiateGrid();
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

            _invInventory.InventoryName = txt_InventoryName.Text;
            _invInventory.Notes = txt_Notes.Text;
            _invInventory.IsBasic = false;
            if (_inventoryId == 0)
                _invInventoryWrapper.Insert(_invInventory);
            else
                _invInventoryWrapper.Update(_invInventory);
        }

        public override void btn_Back_Click(object sender, EventArgs e) {

            this.Close();
        }
    }
}
