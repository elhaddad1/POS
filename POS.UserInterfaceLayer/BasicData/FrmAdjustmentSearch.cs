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
        private INVInventoryWrapper _inventoryWrapper = new INVInventoryWrapper();
        private INVAdjustStockReasonWrapper _adjustStockReasonWrapper = new INVAdjustStockReasonWrapper();

        public FrmAdjustmentSearch()
        {
           
            InitializeComponent();
            InitiateGrid();
            FillStokeCBX();
            FillAdjustReasonCBX();
            base.lbl_FormHeader.Text = "بحث التسوية";
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

        private void FillStokeCBX()
        {

            try
            {
                cbx_Store.DataSource = _inventoryWrapper.SelectAll();
                cbx_Store.DisplayMember = "InventoryName";
                cbx_Store.ValueMember = "InventoryID";
                cbx_Store.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ برجاء المحاولة مرة آخرى");
            }
        }

        private void FillAdjustReasonCBX()
        {

            try
            {
                cbx_AdjustReason.DataSource = _adjustStockReasonWrapper.SelectAll();
                cbx_AdjustReason.DisplayMember = "AdjustStockreasonName";
                cbx_AdjustReason.ValueMember = "AdjustStockReasonID";
                cbx_AdjustReason.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ برجاء المحاولة مرة آخرى");
            }
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
                if (MessageBox.Show("هل نت متأكد من حذف التسوية؟", "تحذير", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
            int AdjustReasonID = 0;
            int InventoryID = 0;
            DateTime? dateFrom = null;
            DateTime? toFrom = null;
            if (toFrom < dateFrom)
            {
                MessageBox.Show("يجب اختيار فترة زمنية صحيحة");
                return;
            }
            if (cbx_AdjustReason.SelectedValue != null)
            {
                int.TryParse(cbx_AdjustReason.SelectedValue.ToString(), out AdjustReasonID);
                searchModel.AdjustReasonID = AdjustReasonID;
            }
            if (cbx_Store.SelectedValue != null)
            {
                int.TryParse(cbx_Store.SelectedValue.ToString(), out InventoryID);
                searchModel.InventoryID = InventoryID;
            }
            if(dtp_fromDate.Value!=null)
                dateFrom = dtp_fromDate.Value;
            if (dtp_toDate.Value != null)
                toFrom = dtp_toDate.Value;
            List<INVAdjustStock> adjustStocks = _invAdjustStockWrapper.SearchByCriteria(searchModel, dateFrom, toFrom);
            dgrid_Result.DataSource = adjustStocks;
        }

        private void FrmAdjustmentSearch_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search();
        }

    }
}
