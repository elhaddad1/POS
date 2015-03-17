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
        private INVAdjustStockReasonWrapper _adjustStockReasonWrapper;
        private INVAdjustStockReasonService service=new INVAdjustStockReasonService ();
        private INVProductStockWrapper _invProductStockWrapper;
        private INVInventoryWrapper _inventoryWrapper;
        private INVStockTypeWrapper _stockTypeWrapper;
        #region ///Event Area
        public FrmAdjustStockAddEdit(FrmAdjustmentSearch frmAdjustmentSearch)
        {
            InitializeComponent();
            this._invProductStockWrapper = new INVProductStockWrapper();
            this._inventoryWrapper = new INVInventoryWrapper();
            this._stockTypeWrapper = new INVStockTypeWrapper();
            this._adjustStockReasonWrapper = new INVAdjustStockReasonWrapper();
        }
        
        public FrmAdjustStockAddEdit(int id, FrmAdjustmentSearch frmAdjustmentSearch)
        {
            InitializeComponent();
            this._invProductStockWrapper = new INVProductStockWrapper();
        }

        private void FrmAdjustStockAddEdit_Load(object sender, EventArgs e)
        {
            FillAdjustReasonCBX();
            FillStokeCBX();
            FillStokeTypeCBX();
        }

        public override void btn_Save_Click(object sender, EventArgs e)
        {
        }
        
        public override void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
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
        #endregion
        #region/// Private functions
        private void FillProductStock()
        {
            dgrid_stock.AutoGenerateColumns = false;
            dgrid_stock.DataSource = _invProductStockWrapper.SelectByField(Convert.ToInt32(cbx_Store.SelectedValue));
        }

        private void FillBatches()
        {

            int _productStockID = (int)dgrid_stock.SelectedRows[0].Cells["col_invProductStock"].Value;
             INVProductStockWrapper _iNVProductStockWrapper = new INVProductStockWrapper();
            dgrid_batches.AutoGenerateColumns = false;
            dgrid_batches.DataSource = _iNVProductStockWrapper.GetInventoryStock(_productStockID, null, null, true, true);
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

                throw;
            }
        }

        private void FillStokeTypeCBX()
        {

            try
            {
                cbx_StockTypeTO.DataSource = _stockTypeWrapper.SelectAll();
                cbx_StockTypeTO.DisplayMember = "StockTypeName";
                cbx_StockTypeTO.ValueMember = "StockTypeID";
                cbx_StockTypeTO.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                throw;
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

                throw;
            }
        }

        private bool validation()
        {
            bool isValid = false;

            int ProductID=0;
            int BatchID = 0;
            int AdjustReasonID = 0;
            int StockTypeID = 0;
            int InventoryID = 0;
            int.TryParse(dgrid_stock.SelectedRows[0].Cells["col_invProductStock"].Value.ToString(), out ProductID);
            int.TryParse(dgrid_batches.SelectedRows[0].Cells["BatchNumber"].Value.ToString(), out BatchID);
            int.TryParse(cbx_AdjustReason.SelectedValue.ToString(), out AdjustReasonID);
            int.TryParse(cbx_StockTypeTO.SelectedValue.ToString(), out StockTypeID);
            int.TryParse(cbx_Store.SelectedValue.ToString(), out InventoryID);

            return isValid;
        }
        #endregion
    }
}
