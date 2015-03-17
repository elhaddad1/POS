using POS.BusinessLayer;
using POS.BusinessLayer.Wrapper;
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

namespace POS.UserInterfaceLayer.BasicData
{
    public partial class FrmAdjustStockAddEdit : POS.UserInterfaceLayer.Portal.frmBaseAddEditForm
    {
        private INVAdjustStockReason _currentReason;
        private INVAdjustStockReasonService service=new INVAdjustStockReasonService ();
        private INVProductStockWrapper _invProductStockWrapper;
        public FrmAdjustStockAddEdit(FrmAdjustmentSearch frmAdjustmentSearch)
        {
            InitializeComponent();
            this._invProductStockWrapper = new INVProductStockWrapper();
        }
        public FrmAdjustStockAddEdit(int id, FrmAdjustmentSearch frmAdjustmentSearch)
        {
            InitializeComponent();
            this._invProductStockWrapper = new INVProductStockWrapper();
        }
        public override void btn_Save_Click(object sender, EventArgs e)
        {
        }
        public override void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillProductStock()
        {
            dgrid_stock.DataSource = _invProductStockWrapper.SelectByField(Convert.ToInt32(cbx_Store.SelectedValue));
        }


        private void FillBatches()
        {

            int _productStockID = (int)dgrid_stock.SelectedRows[0].Cells["col_invProductStock"].Value;
             INVProductStockWrapper _iNVProductStockWrapper = new INVProductStockWrapper();
            dgrid_batches.AutoGenerateColumns = false;
            dgrid_batches.DataSource = _iNVProductStockWrapper.GetInventoryStock(_productStockID, null, null, true, true);
        }

        private void cbx_Store_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Store.SelectedValue == null)
                return;
            int stkId = 0;
            int.TryParse(cbx_Store.SelectedValue.ToString(), out stkId);
            if (stkId > 0)
                FillProductStock();
        }
    }
}
