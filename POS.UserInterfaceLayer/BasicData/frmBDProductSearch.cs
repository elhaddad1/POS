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

        public frmBDProductSearch()
        {
            InitiateGrid();
            InitializeComponent();
            base.lbl_FormHeader.Text = "بحث";
        }

        public void InitiateGrid()
        {
            dgrid_Result.Columns.Clear();

            dgrid_Result.AutoGenerateColumns = false;

            dgrid_Result.Height = 150;

            dgrid_Result.Size = new Size(10, 250);

            addColumnToGrid("ProductID", "ProductID", 120, false);
            
            addColumnToGrid("إسم الصنف", "ProductName", 120, true);
            
            addColumnToGrid("رقم الصنف", "ProductCode", 120, true);
            
            addColumnToGrid("سعر الصنف", "ProductPrice", 120, true);

            addColumnToGrid("إسم المجموعة", "ProductGroupName", 120, true);

            List<VProduct> productList = _bdVProductWrapper.SelectAll();

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
        public override void btn_Edit_Click(object sender, EventArgs e) {

            int productID = 0;
            if (dgrid_Result.Rows[dgrid_Result.SelectedCells[0].RowIndex].Cells["ProductID"].Value != null)
            {
                productID = Convert.ToInt32(dgrid_Result.Rows[dgrid_Result.SelectedCells[0].RowIndex].Cells["ProductID"].Value);
            }
            else
            {
                MessageBox.Show("لابد من اختيار صنف");
            }
            frmBDProductAddEdit frm = new frmBDProductAddEdit(productID,this);
            frm.ShowDialog();

        }
        public override void btn_Delete_Click(object sender, EventArgs e) { }
        public override void btn_Back_Click(object sender, EventArgs e) { }
    }
}
