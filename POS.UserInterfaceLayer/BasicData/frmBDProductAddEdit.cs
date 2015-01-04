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
    public partial class frmBDProductAddEdit : POS.UserInterfaceLayer.Portal.frmBaseAddEditForm
    {
        private BDProductWrapper _bdProductWrapper = new BDProductWrapper();
        private int _productId = 0;
        private BDProduct _bdProduct = new BDProduct();

        public frmBDProductAddEdit()
        {
            InitializeComponent();
            base.lbl_FormHeader.Text = "أضافة";
        }

        public frmBDProductAddEdit(int productId)
        {
            InitializeComponent();
            base.lbl_FormHeader.Text = "تعديل";
            this._productId = productId;
            initEntity(productId);
        }


        private void initEntity(int productId)
        {
            BDProductPrimaryKey pk = new BDProductPrimaryKey();
            pk.ProductID = productId;
            _bdProduct = _bdProductWrapper.SelectOne(pk);
        }

        private bool frmValidation()
        {
            return !string.IsNullOrEmpty(txt_ProductName.Text);
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

            _bdProduct.ProductName = txt_ProductName.Text;
            _bdProduct.Notes = txt_Notes.Text;
            if(_productId==0)
                _bdProductWrapper.Insert(_bdProduct);
            else
                _bdProductWrapper.Update(_bdProduct);
            this.Close();
        
        }

        public override void btn_Back_Click(object sender, EventArgs e) {

            this.Close();
        }
    }
}
