using POS.BusinessLayer.Wrapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.UserInterfaceLayer.Sales
{
    public partial class FrmAddEditTransferOrder : Form
    {
        BDTaxTypeWrapper _bDTaxTypeWrapper;
        INVInventoryWrapper _inventoryWrapper;
        BDCustomerWrapper _bDCustomerWrapper;
        public FrmAddEditTransferOrder()
        {
            InitializeComponent();
            _bDTaxTypeWrapper = new BDTaxTypeWrapper();
            _inventoryWrapper = new INVInventoryWrapper();
            _bDCustomerWrapper = new BDCustomerWrapper();
            FillCustomerCBX();
            FillStokeCBX();
        }

        #region -- Events 

        private void num_Remaining_Leave(object sender, EventArgs e)
        {

            /*if (num_Remaining.Value > 0)
            {
                dtb_LastTimeToPay.Enabled = true;
            }*/
        }

        private void btn_AddLine_Click(object sender, EventArgs e)
        {
            //frmSalesLineAddEdit frm = new frmSalesLineAddEdit();
            //frm.ShowDialog();
        }

        private void btn_DeleteLine_Click(object sender, EventArgs e)
        {
            if (dgrd_OrderLines.SelectedRows.Count != 0)
                dgrd_OrderLines.Rows.RemoveAt(dgrd_OrderLines.SelectedRows[0].Index);
            else
                MessageBox.Show("برجاء أختيار عنصر من القائمه");
        }

        private void btn_Plus_Click(object sender, EventArgs e)
        {
            if (dgrd_OrderLines.SelectedRows.Count != 0)
            {
                int Qty = Convert.ToInt32(dgrd_OrderLines.SelectedRows[0].Cells["Qty"].Value);
                Qty++;
                dgrd_OrderLines.SelectedRows[0].Cells["Qty"].Value = Qty;
            }
            else
                MessageBox.Show("برجاء أختيار عنصر من القائمه");
        }

        private void btn_Minus_Click(object sender, EventArgs e)
        {
            if (dgrd_OrderLines.SelectedRows.Count != 0)
            {
                int Qty = Convert.ToInt32(dgrd_OrderLines.SelectedRows[0].Cells["Qty"].Value);
                Qty--;
                dgrd_OrderLines.SelectedRows[0].Cells["Qty"].Value = Qty;
            }
            else
                MessageBox.Show("برجاء أختيار عنصر من القائمه");
        }

        private void btn_ClosePrint_Click(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region -- Public Methods

        #endregion

        #region -- Private Methods
        private void FillCustomerCBX()
        {

            try
            {
                cbx_StoreFrom.DataSource = _bDCustomerWrapper.SelectAll().OrderBy(a => a.CustomerName).ToList();
                cbx_StoreFrom.DisplayMember = "CustomerName";
                cbx_StoreFrom.ValueMember = "CustomerID";
                cbx_StoreFrom.SelectedIndex = -1;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void FillStokeCBX()
        {

            try
            {
                cbx_StoreFrom.DataSource = _inventoryWrapper.SelectAll();
                cbx_StoreFrom.DisplayMember = "InventoryName";
                cbx_StoreFrom.ValueMember = "InventoryID";
                cbx_StoreFrom.SelectedIndex = -1;
                cbx_StoreTo.DataSource = _inventoryWrapper.SelectAll();
                cbx_StoreTo.DisplayMember = "InventoryName";
                cbx_StoreTo.ValueMember = "InventoryID";
                cbx_StoreTo.SelectedIndex = -1;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        #endregion
    }
}
