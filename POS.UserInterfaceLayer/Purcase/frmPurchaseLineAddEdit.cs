using POS.BusinessLayer;
using POS.BusinessLayer.Utility;
using POS.BusinessLayer.Wrapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.UserInterfaceLayer.Purcase
{
    // purcase
    public partial class frmPurchaseLineAddEdit : Form
    {
        BDProductGroupWrapper _bDProductGroupWrapper;
        BDProductWrapper _bDProductWrapper;
        public PURPurchaseLine pURPurchaseLine;
        public frmPurchaseOrderAddEdit frmPurchaseOrderAddEditObj;
        public frmPurchaseLineAddEdit(frmPurchaseOrderAddEdit _frmPurchaseOrderAddEdit)
        {
            InitializeComponent();
            _bDProductGroupWrapper = new BDProductGroupWrapper();
            _bDProductWrapper = new BDProductWrapper();
            this.frmPurchaseOrderAddEditObj = _frmPurchaseOrderAddEdit;
            FillProductGroupCBX();
        }
        #region -- Events Methods

        private void tbx_Price_Leave(object sender, EventArgs e)
        {

        }
        private void btn_Finish_Click(object sender, EventArgs e)
        {
            if (Validate())
            {

                if ((frmPurchaseOrderAddEditObj.pURPurchaseLineCollection.Where(a => a.ProductID == Convert.ToInt32(cbx_Product.SelectedValue)).ToList().Count) == 0)
                    frmPurchaseOrderAddEditObj.pURPurchaseLineCollection.Add(CollectScreenData());
                else
                    frmPurchaseOrderAddEditObj.pURPurchaseLineCollection.Where(a => a.ProductID == Convert.ToInt32(cbx_Product.SelectedValue)).SingleOrDefault().TotalQty++;

                this.Close();
            }
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cbx_ProductGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_ProductGroup.SelectedIndex != -1)
            {
                FillProductCBX(Convert.ToInt32(cbx_ProductGroup.SelectedValue));
            }
        }
        private void cbx_Product_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Product.SelectedIndex != -1)
            {
                AdjustScreenControls();
            }
        }
        private void num_Quantity_ValueChanged(object sender, EventArgs e)
        {
            if (cbx_Product.SelectedIndex == -1)
            {
                num_Quantity.Text = "0";
                MessageBox.Show("لابد من أختيار منتج أولا");
            }
        }
        #endregion

        #region -- Public Methods

        #endregion

        #region -- Private Methods
        private void FillProductGroupCBX()
        {
            try
            {
                this.cbx_ProductGroup.SelectedIndexChanged -= new System.EventHandler(this.cbx_ProductGroup_SelectedIndexChanged);
                cbx_ProductGroup.DataSource = _bDProductGroupWrapper.SelectAll();
                cbx_ProductGroup.DisplayMember = "ProductGroupName";
                cbx_ProductGroup.ValueMember = "ProductGroupID";
                this.cbx_ProductGroup.SelectedIndexChanged += new System.EventHandler(this.cbx_ProductGroup_SelectedIndexChanged);
                cbx_ProductGroup.SelectedIndex = -1;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void FillProductCBX(int groupID)
        {
            try
            {
                BDProductGroupPrimaryKey pk = new BDProductGroupPrimaryKey();
                pk.ProductGroupID = groupID;
                this.cbx_Product.SelectedIndexChanged -= new System.EventHandler(this.cbx_Product_SelectedIndexChanged);
                cbx_Product.DataSource = null;
                cbx_Product.DataSource = null;//_bDProductWrapper.SelectAllByForeignKeyProductGroupID(pk);
                cbx_Product.DisplayMember = "ProductName";
                cbx_Product.ValueMember = "ProductID";
                this.cbx_Product.SelectedIndexChanged += new System.EventHandler(this.cbx_Product_SelectedIndexChanged);
                cbx_Product.SelectedIndex = -1;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void AdjustScreenControls()
        {
            BDProduct _bDProduct = (BDProduct)cbx_Product.SelectedItem;
            if (!(bool)_bDProduct.IsFixedPrice)
            {
                lbl_MinPriceHeader.Visible = true;
                lbl_MinPriceValue.Visible = true;
                tbx_Price.Enabled = true;
                tbx_Price.ReadOnly = false;
                tbx_Price.Text = "0";
                lbl_MinPriceValue.Text = _bDProduct.MinPrice.ToString();
            }
            else
            {
                lbl_MinPriceHeader.Visible = false;
                lbl_MinPriceValue.Visible = false;
                tbx_Price.Enabled = false;
                tbx_Price.ReadOnly = true;
                tbx_Price.Text = _bDProduct.ProductPrice.ToString();
            }

            if ((bool)_bDProduct.HasDiscount)
                tbx_Discount.Text = (_bDProduct.DescountRatio * 100).ToString() + "%";


        }
        private PURPurchaseLine CollectScreenData()
        {
            pURPurchaseLine = new PURPurchaseLine();
            pURPurchaseLine.DiscountAmount = 0;//(decimal)((float.Parse(tbx_Discount.Text.Trim(new char[] { '%' })) / 100) * float.Parse(tbx_Price.Text));
            pURPurchaseLine.DiscountRatio = 0;//Convert.ToDecimal(float.Parse(tbx_Discount.Text.Trim(new char[] { '%' })) / 100);
            pURPurchaseLine.ProductID = Convert.ToInt32(cbx_Product.SelectedValue);
            pURPurchaseLine.ProductName = cbx_Product.Text;
            pURPurchaseLine.BonusQty = 0;
            pURPurchaseLine.TotalQty = Convert.ToInt32(num_Quantity.Text);
            pURPurchaseLine.Unitprice = Convert.ToDecimal(tbx_Price.Text);
            pURPurchaseLine.CreatedBy = GlobalVariables.CurrentUser.UserID;


            return pURPurchaseLine;
        }
        private bool Validate()
        {
            if (string.IsNullOrEmpty(tbx_Price.Text))
            {
                MessageBox.Show("برجاء أدهال سعر المنتج");
                return false;
            }
            if (Convert.ToDecimal(tbx_Price.Text == "" ? "0" : tbx_Price.Text) < Convert.ToDecimal(lbl_MinPriceValue.Text == "" ? "0" : lbl_MinPriceValue.Text))
            {
                MessageBox.Show("برجاء مراعاة أقل سعر للمنتج");
                return false;
            }
            if (Convert.ToInt32(num_Quantity.Text) == 0)
            {
                MessageBox.Show("أدخل كميه مناسبه");
                return false;
            }
            return true;
        }
        #endregion


    }
}
