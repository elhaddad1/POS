using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS.BusinessLayer.Wrapper;

namespace POS.UserInterfaceLayer.Inventory
{
    public partial class frmOpenningQuantities : Form
    {
        BDProductWrapper _bDProductWrapper;
        private INVInventoryWrapper _iNVInventoryWrapper;
        public frmOpenningQuantities()
        {
            InitializeComponent();
            _iNVInventoryWrapper = new INVInventoryWrapper();
            _bDProductWrapper = new BDProductWrapper();
            FillInventoryCBX();
        }
        #region --  Events
        private void cbx_Inventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Inventory.SelectedIndex != -1)
                BindGrid();
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgrd_OpeningStockProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                if (string.IsNullOrEmpty((senderGrid.Rows[e.RowIndex].Cells["Qty"].Value).ToString()))
                {
                    MessageBox.Show("لابد من أدخال أجمالى الكمية أولا");
                    return;
                }
                //else
                //{
                //    int inventoryID = Convert.ToInt32(cbx_Inventory.SelectedValue);
                //    int productID = (int)(senderGrid.Rows[e.RowIndex].Cells["ProductID"].Value);
                //    //frmOpenningQuantitiesBatches frm = new frmOpenningQuantitiesBatches();
                //    //frm.ShowDialog();
                //}
            }
            //if (senderGrid.Columns[e.ColumnIndex] is DataGridTextBoxColumn &&
            //   e.RowIndex >= 0)
            //{ }


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
        #endregion






    }
}
