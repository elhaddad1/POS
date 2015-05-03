using POS.UserInterfaceLayer.Portal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



using POS.BusinessLayer;namespace POS.UserInterfaceLayer.BasicData
{
    public partial class FrmAdjustmentReasons : frmBaseSearchForm
    {
        INVAdjustStockReasonService adjustStock;
        public FrmAdjustmentReasons()
        {
            InitializeComponent();
            adjustStock =new INVAdjustStockReasonService ();
        }

        private void FrmAdjustmentReasons_Load(object sender, EventArgs e)
        {
            grb_search.Visible = false;
            dgrid_Result.Dock =   DockStyle.Fill;
           // dgrid_Result .Columns .
            addColumnToGrid("سبب التسويه", "AdjustStockReasonID", 10, false);
            addColumnToGrid("سبب التسويه", "AdjustStockreasonName", 400, true);
            dgrid_Result.DataSource = adjustStock .SelectAll ();

            
        }
        public override void btn_Add_Click(object sender, EventArgs e)
        {
            FrmAdjustReasonAddEdit frm = new FrmAdjustReasonAddEdit();
            frm.ShowDialog();
            dgrid_Result.DataSource = adjustStock.SelectAll();

        }
        public override void btn_Edit_Click(object sender, EventArgs e)
        {
            INVAdjustStockReasonPrimaryKey pk = new INVAdjustStockReasonPrimaryKey();
            pk.AdjustStockReasonID= (int)dgrid_Result.Rows [dgrid_Result.SelectedCells[0].RowIndex].Cells["AdjustStockReasonID"].Value;
            INVAdjustStockReason reason= adjustStock.SelectOne(pk);
            FrmAdjustReasonAddEdit frm = new FrmAdjustReasonAddEdit(reason);
            frm.ShowDialog();
            dgrid_Result.DataSource = adjustStock.SelectAll();
        }
        public override void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgrid_Result .SelectedCells.Count > 0)
            {
                if (MessageBox.Show ("هل نت متأكد من الحذف ؟","تحذير",MessageBoxButtons.YesNo)==  System.Windows.Forms.DialogResult.Yes)
                {
                    INVAdjustStockReasonPrimaryKey pk = new INVAdjustStockReasonPrimaryKey();
                    pk.AdjustStockReasonID = (int)dgrid_Result.Rows[dgrid_Result.SelectedCells[0].RowIndex].Cells["AdjustStockReasonID"].Value;
                    try
                    {
                        adjustStock.Delete(pk); 
                        MessageBox.Show("لقد تمت عمليه الحذف بنجاح");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("لم تتم عمليه الحذف .. حيث ان السبب مستخدم ");
                    }
                   
                    dgrid_Result.DataSource = adjustStock.SelectAll();
                }
            }
        }
        public override void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
