using POS.BusinessLayer;
using POS.BusinessLayer.Utility;
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
        #region /// Private variables
        private INVAdjustStockReasonWrapper _adjustStockReasonWrapper;
        private INVAdjustStockWrapper _adjustStockWrapper;
        private INVProductStockWrapper _invProductStockWrapper;
        private BDProductWrapper _ProductWrapper;
        private INVInventoryWrapper _inventoryWrapper;
        private INVStockTypeWrapper _stockTypeWrapper;
        private INVAdjustStockCollection _adjustStockCollection;
        private INVAdjustStock _adjustStock;
        private bool _isEdit;
        private int? _adjustStockID = null;
        private FrmAdjustmentSearch _frmAdjustmentSearch;
        #endregion
        #region /// Event Area
        public FrmAdjustStockAddEdit(FrmAdjustmentSearch frmAdjustmentSearch)
        {
            InitializeComponent();
            this._invProductStockWrapper = new INVProductStockWrapper();
            this._inventoryWrapper = new INVInventoryWrapper();
            this._stockTypeWrapper = new INVStockTypeWrapper();
            this._adjustStockReasonWrapper = new INVAdjustStockReasonWrapper();
            this._adjustStockWrapper = new INVAdjustStockWrapper();
            this._adjustStock = new INVAdjustStock();
            this._ProductWrapper = new BDProductWrapper();
            this._adjustStockCollection = new INVAdjustStockCollection();
            this._isEdit = false;
            this._frmAdjustmentSearch = frmAdjustmentSearch;
        }
        
        public FrmAdjustStockAddEdit(int id, FrmAdjustmentSearch frmAdjustmentSearch)
        {
            InitializeComponent();
            this._invProductStockWrapper = new INVProductStockWrapper();
            this._inventoryWrapper = new INVInventoryWrapper();
            this._stockTypeWrapper = new INVStockTypeWrapper();
            this._adjustStockReasonWrapper = new INVAdjustStockReasonWrapper();
            this._adjustStockWrapper = new INVAdjustStockWrapper();
            this._adjustStock = new INVAdjustStock();
            this._ProductWrapper = new BDProductWrapper();
            this._isEdit = true;
            this._adjustStockID = id;
            GetAdjustStockData(_adjustStockID.Value);
            this._frmAdjustmentSearch = frmAdjustmentSearch;
        }

        private void FrmAdjustStockAddEdit_Load(object sender, EventArgs e)
        {
            FillAdjustReasonCBX();
            FillStokeCBX();
            FillStokeTypeCBX();
        }

        public override void btn_Save_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                try
                {
                    bool rtn_result = false;
                    if (_adjustStockID > 0)
                        rtn_result = _adjustStockWrapper.Update(_adjustStock);
                    else
                        rtn_result = _adjustStockWrapper.Insert(_adjustStock);

                    _adjustStockWrapper.SaveAdjustStock(_adjustStockCollection);

                    if (rtn_result)
                    {
                        _frmAdjustmentSearch.InitiateGrid();
                        MessageBox.Show("تمت العملية");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("حدث خطأ برجاء المحاولة مرة آخرى");
                }
            }
            else
                MessageBox.Show("خطأ بالبيانات يرجى مراجعتها .");

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
            dgrid_stock.DataSource = _adjustStockWrapper.GetProductStockList(Convert.ToInt32(cbx_Store.SelectedValue));
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


        private void GetAdjustStockData(int adjustStockID)
        {
            INVAdjustStockPrimaryKey pk = new INVAdjustStockPrimaryKey();
            pk.AdjustStockID = adjustStockID;
            _adjustStock = _adjustStockWrapper.SelectOne(pk);
        }


        new private bool Validate()
        {
            bool isValid = false;
            bool isValidProduct = false;
            int ProductID=0;
            int? oldStockTypeId = dgrid_stock.SelectedRows.Count > 0 ? int.Parse(dgrid_stock.SelectedRows[0].Cells["col_StockTypeID"].Value.ToString()) : 0;
            string BatchID = dgrid_batches.SelectedRows.Count > 0 ? dgrid_batches.SelectedRows[0].Cells["col_batch"].Value.ToString() : "";
            DateTime? ExpiryDate = dgrid_batches.SelectedRows.Count > 0 ? Convert.ToDateTime(dgrid_batches.SelectedRows[0].Cells["col_expiry"].Value.ToString()) : (DateTime?)null;
            decimal oldQty = dgrid_batches.SelectedRows.Count > 0 ? Convert.ToDecimal(dgrid_batches.SelectedRows[0].Cells["col_batchQty"].Value.ToString()) : Convert.ToDecimal(dgrid_stock.SelectedRows[0].Cells["col_qty"].Value.ToString());
            int AdjustReasonID = 0;
            int StockTypeID = 0;
            int InventoryID = 0;
            decimal Qty = num_Qty.Value;
            int.TryParse(dgrid_stock.SelectedRows[0].Cells["col_invProductStock"].Value.ToString(), out ProductID);
            int.TryParse(cbx_AdjustReason.SelectedValue.ToString(), out AdjustReasonID);
            int.TryParse(cbx_StockTypeTO.SelectedValue.ToString(), out StockTypeID);
            int.TryParse(cbx_Store.SelectedValue.ToString(), out InventoryID);

            if (ProductID > 0)
            {
                isValidProduct = true;
                BDProductPrimaryKey pk = new BDProductPrimaryKey();
                pk.ProductID = ProductID;
                if (_ProductWrapper.SelectOne(pk).IsAcceptBatch == true)
                    isValidProduct = (!string.IsNullOrEmpty(BatchID) && ExpiryDate.HasValue);
            }

            if (!isValidProduct || AdjustReasonID == 0 || StockTypeID == 0 || InventoryID == 0 || Qty == 0 || Qty > oldQty)
                isValid= false;
            else
            {

                isValid = true;

                if (_isEdit)
                {
                    INVAdjustStock _EditNewAdjustStock = _adjustStock;
                    _EditNewAdjustStock.Qty *= -1;
                    _adjustStockCollection.Add(_EditNewAdjustStock);
                    INVAdjustStock _EditOldAdjustStock = _adjustStock;
                    _adjustStock.StockTypeID = _adjustStock.OldStockTypeID;
                    _adjustStockCollection.Add(_EditOldAdjustStock);
                }
                _adjustStock.ProductID = ProductID;
                _adjustStock.AdjustReasonID = AdjustReasonID;
                _adjustStock.AdjustStockID = _adjustStockID;
                _adjustStock.BatchID = null;
                _adjustStock.InventoryID = InventoryID;
                _adjustStock.StockTypeID = StockTypeID;
                _adjustStock.OldStockTypeID = oldStockTypeId;
                _adjustStock.Qty = Qty;
                _adjustStock.BatchNumber = BatchID;
                _adjustStock.ExpiryDate = ExpiryDate;
                if (_isEdit)
                {
                    _adjustStock.UpdateDate = DateTime.Now;
                    _adjustStock.UpdatedBy = GlobalVariables.CurrentUser.UserID;
                }
                else
                {
                    _adjustStock.CredateDate = DateTime.Now;
                    _adjustStock.CreatedBy = GlobalVariables.CurrentUser.UserID;
                }

                INVAdjustStock _oldAdjustStock = new INVAdjustStock();
                _oldAdjustStock.ProductID = ProductID;
                _oldAdjustStock.AdjustReasonID = AdjustReasonID;
                _oldAdjustStock.AdjustStockID = _adjustStockID;
                _oldAdjustStock.BatchID = null;
                _oldAdjustStock.InventoryID = InventoryID;
                _oldAdjustStock.StockTypeID = oldStockTypeId;
                _oldAdjustStock.Qty = (-1 * Qty);
                _oldAdjustStock.BatchNumber = BatchID;
                _oldAdjustStock.ExpiryDate = ExpiryDate;
                if (_isEdit)
                {
                    _oldAdjustStock.UpdateDate = DateTime.Now;
                    _oldAdjustStock.UpdatedBy = GlobalVariables.CurrentUser.UserID;
                }
                else
                {
                    _oldAdjustStock.CredateDate = DateTime.Now;
                    _oldAdjustStock.CreatedBy = GlobalVariables.CurrentUser.UserID;
                }

                _adjustStockCollection.Add(_oldAdjustStock);
            }
            return isValid;
        }
        #endregion
    }
}
