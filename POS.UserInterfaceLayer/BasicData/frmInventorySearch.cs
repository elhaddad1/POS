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
    public partial class frmInventorySearch : POS.UserInterfaceLayer.Portal.frmBaseSearchForm
    {
        private INVInventoryWrapper _invInventoryWrapper = new INVInventoryWrapper();

        public frmInventorySearch()
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

            List<INVInventory> Inventory = _invInventoryWrapper.SelectAll();

            dgrid_Result.DataSource = Inventory;

            addColumnToGrid("InventoryID", "InventoryID", 120, false);
            addColumnToGrid("إسم المخزن", "InventoryName", 120, true);
        }

        /// <summary>
        /// Events Override
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void btn_Add_Click(object sender, EventArgs e)
        {
            frmInventoryAddEdit frm = new frmInventoryAddEdit(this);
            frm.ShowDialog();
        }
        public override void btn_Edit_Click(object sender, EventArgs e)
        {
            int productGroupID = 0;
            if (dgrid_Result.Rows[dgrid_Result.SelectedCells[0].RowIndex].Cells["InventoryID"].Value != null)
            {
                productGroupID = Convert.ToInt32(dgrid_Result.Rows[dgrid_Result.SelectedCells[0].RowIndex].Cells["InventoryID"].Value);
            }
            else
            {
                MessageBox.Show("لابد من اختيار مخزن");
            }
            frmInventoryAddEdit frm = new frmInventoryAddEdit(productGroupID,this);
            frm.ShowDialog();
        
        
        }
        public override void btn_Delete_Click(object sender, EventArgs e)
        {
            int? productGroupID = 0;
            if (dgrid_Result.Rows[dgrid_Result.SelectedCells[0].RowIndex].Cells["InventoryID"].Value != null)
            {
                if (MessageBox.Show("هل نت متأكد من حذف المخزن؟", "تحذير", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    productGroupID = Convert.ToInt32(dgrid_Result.Rows[dgrid_Result.SelectedCells[0].RowIndex].Cells["InventoryID"].Value);
                    INVInventoryPrimaryKey productGroupPK = new INVInventoryPrimaryKey();
                    productGroupPK.InventoryID = productGroupID;
                    _invInventoryWrapper.Delete(productGroupPK);
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("لابد من اختيار مخزن");
            }
            InitiateGrid();
        
        }
        public override void btn_Back_Click(object sender, EventArgs e) {

            this.Close();

        }
    }
}
