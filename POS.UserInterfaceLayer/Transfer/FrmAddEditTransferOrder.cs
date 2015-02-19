using POS.BusinessLayer;
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
        private INVInventoryWrapper _inventoryWrapper;
        private BDTaxTypeWrapper _bDTaxTypeWrapper;
        private PaymentTypeWrapper _paymentTypeWrapper;
        private BDCustomerWrapper _bDCustomerWrapper;
        public INVTransferLineCollection transferLineCollection;

        public FrmAddEditTransferOrder()
        {
            InitializeComponent();
            this._bDTaxTypeWrapper = new BDTaxTypeWrapper();
            this._paymentTypeWrapper = new PaymentTypeWrapper();
            this._bDCustomerWrapper = new BDCustomerWrapper();
            this.transferLineCollection = new INVTransferLineCollection();
            this._inventoryWrapper = new INVInventoryWrapper();
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
            FrmTransferLineAddEdit frm = new FrmTransferLineAddEdit(this);
            frm.FormClosed += frmSalesOrderAddEdit_FormClosed;
            frm.ShowDialog();

        }

        private void btn_DeleteLine_Click(object sender, EventArgs e)
        {
            if (dgrd_OrderLines.SelectedRows.Count != 0)
            {
                transferLineCollection.RemoveAt(dgrd_OrderLines.SelectedRows[0].Index);
                //dgrd_OrderLines.Rows.RemoveAt(dgrd_OrderLines.SelectedRows[0].Index);
                BindGrid();

            }
            else
                MessageBox.Show("برجاء أختيار عنصر من القائمه");
        }

        private void btn_Plus_Click(object sender, EventArgs e)
        {
            if (dgrd_OrderLines.SelectedRows.Count != 0)
            {
                //transferLineCollection.Where(a => a.ProductID == (int?)dgrd_OrderLines.SelectedRows[0].Cells["ProductID"].Value).SingleOrDefault().TotalQty++;
                BindGrid();
            }
            else
                MessageBox.Show("برجاء أختيار عنصر من القائمه");
        }

        private void btn_Minus_Click(object sender, EventArgs e)
        {
            if (dgrd_OrderLines.SelectedRows.Count != 0)
            {
                //transferLineCollection.Where(a => a.ProductID == (int?)dgrd_OrderLines.SelectedRows[0].Cells["ProductID"].Value).SingleOrDefault().TotalQty--;
                BindGrid();
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

        private void frmSalesOrderAddEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            BindGrid();
        }
        #endregion

        #region -- Public Methods

        #endregion

        #region -- Private Methods
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

        private void BindGrid()
        {
            dgrd_OrderLines.DataSource = null;
            dgrd_OrderLines.AutoGenerateColumns = false;
            dgrd_OrderLines.DataSource = transferLineCollection;
            dgrd_OrderLines.Columns[0].DataPropertyName = "ProductID";
            dgrd_OrderLines.Columns[1].DataPropertyName = "ProductName";
            dgrd_OrderLines.Columns[2].DataPropertyName = "TotalQty";
            dgrd_OrderLines.Columns[3].DataPropertyName = "UnitPrice";
           
        }

        #endregion


    }
}
