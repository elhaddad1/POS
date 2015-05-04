using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using POS.BusinessLayer;
using POS.BusinessLayer.Wrapper;

namespace POS.UserInterfaceLayer.BasicData
{
    public partial class frmBDProductSearch : POS.UserInterfaceLayer.Portal.frmBaseSearchForm
    {
        private BDVProductWrapper _bdVProductWrapper = new BDVProductWrapper();
        private BDProductWrapper _bdProductWrapper = new BDProductWrapper();

        public frmBDProductSearch()
        {

            InitializeComponent();
            base.lbl_FormHeader.Text = "بحث";
            InitiateGrid();
        }

        public void InitiateGrid()
        {
            dgrid_Result.Columns.Clear();
            dgrid_Result.AutoGenerateColumns = false;
            dgrid_Result.RowHeadersVisible = false;
            dgrid_Result.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            addColumnToGrid("ProductID", "ProductID", 120, false);
            addColumnToGrid("كود الصنف", "ProductCode", 120, true);
            addColumnToGrid("إسم الصنف", "ProductName", 250, true);
            // addColumnToGrid("سعر الصنف", "ProductPrice", 120, true);
            addColumnToGrid("المجموعه التابع لها", "ProductGroupName", 250, true);

            BindGrid();

        }
        private void BindGrid()
        {
            dgrid_Result.DataSource = null;
            List<VProduct> productList = _bdVProductWrapper.SelectAll();
            dgrid_Result.DataSource = productList;
        }

        private void Search()
        {
            dgrid_Result.DataSource = null;
            string productName = tbx_productName.Text != "" ? tbx_productName.Text : null;
            string productCode = tbx_productCode.Text != "" ? tbx_productCode.Text : null;
            List<VProduct> productList = _bdVProductWrapper.SearchByCriteria(productName, productCode);
            dgrid_Result.DataSource = productList;
        }
        /// <summary>
        /// Events Override
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void btn_Add_Click(object sender, EventArgs e)
        {
            frmBDProductAddEdit frm = new frmBDProductAddEdit(this);
            frm.ShowDialog();
        }
        public override void btn_Edit_Click(object sender, EventArgs e)
        {

            int productID = 0;
            if (dgrid_Result.Rows[dgrid_Result.SelectedCells[0].RowIndex].Cells["ProductID"].Value != null)
            {
                productID = Convert.ToInt32(dgrid_Result.Rows[dgrid_Result.SelectedCells[0].RowIndex].Cells["ProductID"].Value);
            }
            else
            {
                MessageBox.Show("لابد من اختيار صنف");
            }
            frmBDProductAddEdit frm = new frmBDProductAddEdit(productID, this);
            frm.ShowDialog();

        }
        public override void btn_Delete_Click(object sender, EventArgs e)
        {
            int? productID = 0;
            if (dgrid_Result.Rows[dgrid_Result.SelectedCells[0].RowIndex].Cells["ProductID"].Value != null)
            {
                if (MessageBox.Show("هل نت متأكد من حذف الصنف؟", "تحذير", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    productID = Convert.ToInt32(dgrid_Result.Rows[dgrid_Result.SelectedCells[0].RowIndex].Cells["ProductID"].Value);
                    BDProductPrimaryKey productPK = new BDProductPrimaryKey();
                    productPK.ProductID = productID;
                    _bdProductWrapper.Delete(productPK);
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("لابد من اختيار الصنف");
            }
            InitiateGrid();
        }
        public override void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Search();
        }


    }
}
