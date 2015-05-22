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
    public partial class FrmAdjustmentSearch : POS.UserInterfaceLayer.Portal.frmBaseSearchForm
    {
        private INVAdjustStockWrapper _invAdjustStockWrapper = new INVAdjustStockWrapper();

        public FrmAdjustmentSearch()
        {
           
            InitializeComponent();
            InitiateGrid();
            base.lbl_FormHeader.Text = "بحث";
            grb_search.Visible = false;
        }

        public void InitiateGrid()
        {
            dgrid_Result.Columns.Clear();

            dgrid_Result.AutoGenerateColumns = false;

            dgrid_Result.Height = 150;

            dgrid_Result.Size = new Size(10, 250);

            List<INVAdjustStock> adjustStock = _invAdjustStockWrapper.getAllINVAdjustStock();

            dgrid_Result.DataSource = adjustStock;

            addColumnToGrid("AdjustStockID", "AdjustStockID", 120, false);
            addColumnToGrid("إسم الصنف", "ProductName", 120, true);
            addColumnToGrid("إسم المخزن", "InventoryName", 120, true);
            addColumnToGrid("السبب", "AdjustReasonName", 120, true);
            addColumnToGrid("نوع الصنف القديم", "OldStockTypeName", 120, true);
            addColumnToGrid("نوع الصنف الجديد", "StockTypeName", 120, true);
            addColumnToGrid("الكمية", "Qty", 120, true);
            addColumnToGrid("الموظف", "CreatedByName", 120, true);
        }

        /// <summary>
        /// Events Override
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void btn_Add_Click(object sender, EventArgs e)
        {
            FrmAdjustStockAddEdit frm = new FrmAdjustStockAddEdit(this);
            frm.ShowDialog();
        }
        public override void btn_Edit_Click(object sender, EventArgs e)
        {
            int productGroupID = 0;
            if (dgrid_Result.SelectedRows[0].Cells["AdjustStockID"].Value != null)
            {
                productGroupID = Convert.ToInt32(dgrid_Result.SelectedRows[0].Cells["AdjustStockID"].Value);
            }
            else
            {
                MessageBox.Show("لابد من اختيار مجموعة");
            }
            FrmAdjustStockAddEdit frm = new FrmAdjustStockAddEdit(productGroupID, this);
            frm.ShowDialog();
        
        
        }
        public override void btn_Delete_Click(object sender, EventArgs e)
        {
            int? adjustStockID = 0;
            if (dgrid_Result.SelectedRows[0].Cells["AdjustStockID"].Value != null)
            {
                if (MessageBox.Show("هل نت متأكد من حذف المجموعة؟", "تحذير", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
            if (dgrid_Result.SelectedRows[0].Cells["AdjustStockID"].Value != null)
                    adjustStockID = Convert.ToInt32(dgrid_Result.SelectedRows[0].Cells["AdjustStockID"].Value);
                    _invAdjustStockWrapper.DeleteAdjustStock(adjustStockID.Value);
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("لابد من اختيار مجموعة");
            }
            InitiateGrid();
        
        }
        public override void btn_Back_Click(object sender, EventArgs e) {

            this.Close();

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            dgrid_Result.DataSource = null;
            INVAdjustStock searchModel = new INVAdjustStock();
            searchModel.ProductName = tbx_ProductName.Text != "" ? tbx_ProductName.Text : null;
            searchModel.InventoryName = tbx_InventoryName.Text != "" ? tbx_InventoryName.Text : null;
            searchModel.StockTypeName = tbx_StockTypeName.Text != "" ? tbx_StockTypeName.Text : null;
            searchModel.AdjustReasonName = tbx_AdjustName.Text != "" ? tbx_AdjustName.Text : null;
            List<INVAdjustStock> adjustStocks = _invAdjustStockWrapper.SearchByCriteria(searchModel);
            dgrid_Result.DataSource = adjustStocks;
        }

        private void FrmAdjustmentSearch_Load(object sender, EventArgs e)
        {
           
        }

    }
}
