using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS.BusinessLayer;
using POS.BusinessLayer.Utility;
using POS.BusinessLayer.Wrapper;

namespace POS.UserInterfaceLayer.Inventory
{
    public partial class frmOpenningQuantities : Form
    {
        private BDProductWrapper _bDProductWrapper;
        private INVInventoryWrapper _iNVInventoryWrapper;
        private INVProductStockWrapper _iNVProductStockWrapper;
        public INVProductStockCollection iNVProductStockCollection;

        public frmOpenningQuantities()
        {
            InitializeComponent();
            iNVProductStockCollection = new INVProductStockCollection();
            _iNVInventoryWrapper = new INVInventoryWrapper();
            _bDProductWrapper = new BDProductWrapper();
            _iNVProductStockWrapper = new INVProductStockWrapper();
            FillInventoryCBX();
        }
        #region --  Events
        private void cbx_Inventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbx_Inventory.SelectedIndex != -1)
                    BindGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                CollectScreenData();
                if (_iNVProductStockWrapper.SaveProductStockLine(iNVProductStockCollection))
                {
                    MessageBox.Show("تمت العملية بنجاح");
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void dgrd_OpeningStockProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    if ((bool)(senderGrid.Rows[e.RowIndex].Cells["IsAcceptBatch"].Value) == false)
                    {
                        MessageBox.Show("هذا الصنف لايقبل رقم تشغيلة");
                        return;
                    }
                    if (senderGrid.Rows[e.RowIndex].Cells["TotalQty"].Value == null)
                    {
                        MessageBox.Show("لابد من أدخال أجمالى الكمية أولا");
                        senderGrid.Rows[e.RowIndex].Cells["TotalQty"].Style.BackColor = Color.Red;
                        return;
                    }
                    frmOpenningQuantitiesBatches frm = new frmOpenningQuantitiesBatches(CollectHeaderData(senderGrid.Rows[e.RowIndex]), this);
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region -- Public Methods
        #endregion
        #region -- Private Methods
        private void FillInventoryCBX()
        {
            try
            {
                this.cbx_Inventory.SelectedIndexChanged -= new System.EventHandler(this.cbx_Inventory_SelectedIndexChanged);
                cbx_Inventory.DataSource = _iNVInventoryWrapper.SelectAll();
                cbx_Inventory.DisplayMember = "InventoryName";
                cbx_Inventory.ValueMember = "InventoryID";
                this.cbx_Inventory.SelectedIndexChanged += new System.EventHandler(this.cbx_Inventory_SelectedIndexChanged);
                cbx_Inventory.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BindGrid()
        {
            try
            {
                dgrd_OpeningStockProducts.DataSource = null;
                dgrd_OpeningStockProducts.AutoGenerateColumns = false;
                dgrd_OpeningStockProducts.DataSource = _bDProductWrapper.GetAllProductsForOpenningQuantities(Convert.ToInt32(cbx_Inventory.SelectedValue));
                dgrd_OpeningStockProducts.Columns[0].DataPropertyName = "ProductID";
                dgrd_OpeningStockProducts.Columns[1].DataPropertyName = "ProductCode";
                dgrd_OpeningStockProducts.Columns[2].DataPropertyName = "ProductName";
                dgrd_OpeningStockProducts.Columns[4].DataPropertyName = "IsAcceptBatch";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private INVProductStock CollectHeaderData(DataGridViewRow row)
        {
            INVProductStock _iNVProductStock = new INVProductStock();
            _iNVProductStock.InventoryID = Convert.ToInt32(cbx_Inventory.SelectedValue);
            _iNVProductStock.OpeningQty = Convert.ToDecimal(row.Cells["TotalQty"].Value);
            _iNVProductStock.OpennigDate = DateTime.Now;
            _iNVProductStock.ProductID = Convert.ToInt32(row.Cells["ProductID"].Value);
            _iNVProductStock.StockTypeID = 1;
            _iNVProductStock.TotalQty = Convert.ToDecimal(row.Cells["TotalQty"].Value);
            _iNVProductStock.CreateDate = DateTime.Now;
            _iNVProductStock.CreatedBy = GlobalVariables.CurrentUser.UserID;
            return _iNVProductStock;
        }
        private void CollectScreenData()
        {
            foreach (DataGridViewRow row in dgrd_OpeningStockProducts.Rows)
            {
                if (row.Cells["TotalQty"].Value != null)
                {
                    var result = iNVProductStockCollection.Where(a => a.ProductID == Convert.ToInt32(row.Cells["ProductID"].Value)).ToList();
                    if (result.Count == 0)
                    {
                        INVProductStock _iNVProductStock = new INVProductStock();
                        _iNVProductStock.InventoryID = Convert.ToInt32(cbx_Inventory.SelectedValue);
                        _iNVProductStock.CreateDate = DateTime.Now;
                        _iNVProductStock.OpeningQty = Convert.ToDecimal(row.Cells["TotalQty"].Value);
                        _iNVProductStock.OpennigDate = DateTime.Now;
                        _iNVProductStock.ProductID = Convert.ToInt32(row.Cells["ProductID"].Value);
                        _iNVProductStock.StockTypeID = 1;
                        _iNVProductStock.TotalQty = Convert.ToDecimal(row.Cells["TotalQty"].Value);
                        iNVProductStockCollection.Add(_iNVProductStock);
                    }
                }
            }

        }
        #endregion

    }
}
