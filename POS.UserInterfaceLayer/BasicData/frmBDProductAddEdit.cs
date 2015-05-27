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
        private BDProductGroupWrapper _bdProductGroupWrapper = new BDProductGroupWrapper();
        private int _productId = 0;
        private BDProduct _bdProduct = new BDProduct();
        private frmBDProductSearch _frmBDProductSearch = null;

        public frmBDProductAddEdit(frmBDProductSearch frmBDProductSearch)
        {
            InitializeComponent();
            base.lbl_FormHeader.Text = "أضافة";
            loadResourcses();
            this._frmBDProductSearch = frmBDProductSearch;
        }

        public frmBDProductAddEdit(int productId, frmBDProductSearch frmBDProductSearch)
        {
            InitializeComponent();
            base.lbl_FormHeader.Text = "تعديل";
            this._productId = productId;
            initEntity(productId);
            this._frmBDProductSearch = frmBDProductSearch;
        }


        private void initEntity(int productId)
        {
            try
            {
                BDProductPrimaryKey pk = new BDProductPrimaryKey();
                pk.ProductID = productId;
                _bdProduct = _bdProductWrapper.SelectOne(pk);
                loadUI();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private string frmValidation()
        {
            if (string.IsNullOrEmpty(txt_ProductName.Text))
            {
                return "لابد من ادخال اسم الصنف";
            }

            if (ddl_ProductGroupID == null || ddl_ProductGroupID.SelectedValue == null)
            {
                return "لابد من إختيار المجموعة";
            }
            int groupId = 0;
            int.TryParse(ddl_ProductGroupID.SelectedValue.ToString(), out groupId);
            if (groupId == 0)
            {
                return "لابد من إختيار المجموعة";
            }
            return string.Empty;
        }


        /// <summary>
        /// Events Override
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        public override void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                string validationMSG = frmValidation();
                if (!string.IsNullOrEmpty(validationMSG))
                {
                    MessageBox.Show(validationMSG);
                    return;
                }
                if (saveChanges())
                {
                    MessageBox.Show("تم الحفظ بنجاح");
                    this._frmBDProductSearch.InitiateGrid();
                    this.Close();
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطا برجاء الرجوع لمصمم البرنامج ");
                MessageBox.Show(ex.Message);
            }
        }

        private bool saveChanges()
        {

            _bdProduct.ProductName = txt_ProductName.Text;
            _bdProduct.Notes = txt_Notes.Text;
            _bdProduct.DescountRatio = (double)nmr_DescountRatio.Value;
            _bdProduct.DiscountAmount = (decimal)nmr_DiscountAmount.Value;

            _bdProduct.MinPrice = (decimal)nmr_MinPrice.Value;
            _bdProduct.MaxPrice = (decimal)nmr_MaxPrice.Value;

            _bdProduct.HasDiscount = chk_HasDiscount.Checked;
            _bdProduct.IsAcceptBatch = chk_IsAcceptBatch.Checked;
            _bdProduct.IsActive = chk_IsActive.Checked;
            _bdProduct.IsFixedPrice = chk_IsFixedPrice.Checked;
            _bdProduct.ProductCode = txt_ProductCode.Text;
            _bdProduct.ProductGroupID = int.Parse(ddl_ProductGroupID.SelectedValue.ToString());
            _bdProduct.ProductPrice = (decimal)nmr_ProductPrice.Value;
            if (_productId == 0)
            {
                if (!_bdProductWrapper.Insert(_bdProduct))
                    return false;
            }
            else
            {
                if (!_bdProductWrapper.Update(_bdProduct))
                    return false;
            }
            return true;
        }

        private void loadUI()
        {
            loadResourcses();
            txt_ProductName.Text = _bdProduct.ProductName;
            txt_Notes.Text = _bdProduct.Notes;
            nmr_DescountRatio.Value = (decimal)_bdProduct.DescountRatio.Value;
            nmr_DiscountAmount.Value = _bdProduct.DiscountAmount.Value;
            nmr_MinPrice.Value = (decimal)_bdProduct.MinPrice;
            nmr_MaxPrice.Value = (decimal)_bdProduct.MaxPrice;
            chk_HasDiscount.Checked = _bdProduct.HasDiscount.Value;
            chk_IsAcceptBatch.Checked = _bdProduct.IsAcceptBatch.Value;
            chk_IsActive.Checked = _bdProduct.IsActive.Value;
            chk_IsFixedPrice.Checked = _bdProduct.IsFixedPrice.Value;
            chk_IsFixedPrice_CheckedChanged(chk_IsFixedPrice, new EventArgs());
            txt_ProductCode.Text = _bdProduct.ProductCode;
            ddl_ProductGroupID.SelectedValue = _bdProduct.ProductGroupID;
            nmr_ProductPrice.Value = _bdProduct.ProductPrice.Value;
        }
        private void loadResourcses()
        {
            ddl_ProductGroupID.DataSource = _bdProductGroupWrapper.SelectAll();
            ddl_ProductGroupID.DisplayMember = "ProductGroupName";
            ddl_ProductGroupID.ValueMember = "ProductGroupID";
        }
        public override void btn_Back_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void chk_IsFixedPrice_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_IsFixedPrice.Checked)
            {
                nmr_MinPrice.ReadOnly = true;
                nmr_MaxPrice.ReadOnly = true;
            }
            else
            {
                nmr_MinPrice.ReadOnly = false;
                nmr_MaxPrice.ReadOnly = false;
            }
        }

    }
}
