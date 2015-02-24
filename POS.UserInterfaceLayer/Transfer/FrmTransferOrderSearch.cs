using POS.BusinessLayer;
using POS.BusinessLayer.Wrapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POS.UserInterfaceLayer.Transfer
{
    public partial class FrmTransferOrderSearch : POS.UserInterfaceLayer.Portal.frmBaseSearchForm
    {
        private INVTransferHeaderWrapper _invtransferHeaderWrapper;
        private INVInventoryWrapper _inventoryWrapper;
        public FrmTransferOrderSearch()
        {
            InitializeComponent();
            base.lbl_FormHeader.Text = "بحث";
            this._invtransferHeaderWrapper = new INVTransferHeaderWrapper();
            this._inventoryWrapper = new INVInventoryWrapper();
            FillStokeCBX();
            InitiateGrid(null);
        }

        public void InitiateGrid(INVTransferHeader invtransferHeader)
        {
            dgrid_Result.Columns.Clear();

            dgrid_Result.AutoGenerateColumns = false;

            dgrid_Result.Height = 150;

            dgrid_Result.Size = new Size(10, 250);

            addColumnToGrid("INVTransferHeaderID", "INVTransferHeaderID", 120, false);

            addColumnToGrid("IsClosed", "IsClosed", 120, false);

            addColumnToGrid("المخزن المحول منه", "FromInventory", 120, true);

            addColumnToGrid("المخزن المحول اليه", "ToInventory", 120, true);

            addColumnToGrid("تاريخ التحويل", "TransferDate", 120, true);

            addColumnToGrid("رقم الفاتورة", "InvoiceNumber", 120, true);

            addColumnToGrid("الموظف", "CreatedBy", 120, true);

            List<INVTransferHeaderModel> transferList = new List<INVTransferHeaderModel>();

            if (invtransferHeader == null)
                transferList = _invtransferHeaderWrapper.getAllTransferTransaction();
            else
                transferList = _invtransferHeaderWrapper.getAllTransferTransaction(invtransferHeader);

            dgrid_Result.DataSource = transferList;

        }



        #region Events
        private void btn_search_Click(object sender, EventArgs e)
        {
            search();
        }
        public override void btn_Add_Click(object sender, EventArgs e)
        {
            FrmAddEditTransferOrder frm = new FrmAddEditTransferOrder(this, 0);
            frm.ShowDialog();
        }
        public override void btn_Edit_Click(object sender, EventArgs e)
        {
            if (dgrid_Result.SelectedRows.Count != 0)
                if (!Convert.ToBoolean(dgrid_Result.SelectedRows[0].Cells["IsClosed"].Value))
                {
                    FrmAddEditTransferOrder frm = new FrmAddEditTransferOrder(this, Convert.ToInt32(dgrid_Result.SelectedRows[0].Cells["INVTransferHeaderID"].Value));
                    frm.ShowDialog();
                }
                else
                    MessageBox.Show("لا يمكنك تعديل هذه الفاتوره حيث انها مغلقه");
        }
        public override void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgrid_Result.SelectedRows.Count != 0)
                if (!Convert.ToBoolean(dgrid_Result.SelectedRows[0].Cells["IsClosed"].Value))
                {
                    _invtransferHeaderWrapper.DeleteOrder(Convert.ToInt32(dgrid_Result.SelectedRows[0].Cells["INVTransferHeaderID"].Value));
                    InitiateGrid(null);
                    MessageBox.Show("تمت العملية");
                }
                else
                    MessageBox.Show("لا يمكنك مسح هذه الفاتوره حيث انها مغلقه");
        }
        public override void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void btn_Close_Click(object sender, EventArgs e)
        {
            if (dgrid_Result.SelectedRows.Count != 0)
                if (!Convert.ToBoolean(dgrid_Result.SelectedRows[0].Cells["IsClosed"].Value))
                {
                    _invtransferHeaderWrapper.CloseOrder(Convert.ToInt32(dgrid_Result.SelectedRows[0].Cells["INVTransferHeaderID"].Value));
                    InitiateGrid(null);
                    MessageBox.Show("تمت العملية");
                }
                else
                    MessageBox.Show("لا يمكنك إغلاق هذه الفاتوره حيث انها مغلقه");
        }
        #endregion

        #region private methods
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
            catch (Exception ex)
            {

                throw;
            }
        }
        private void search()
        {
            INVTransferHeader invtransferHeader = new INVTransferHeader();
            //invtransferHeader.CreateDate = dtb_Date.Value;
            int fromInv = 0, toInv = 0;
            if (cbx_StoreFrom.SelectedValue != null)
                int.TryParse(cbx_StoreFrom.SelectedValue.ToString(), out fromInv);
            if (cbx_StoreTo.SelectedValue != null)
                int.TryParse(cbx_StoreTo.SelectedValue.ToString(), out toInv);
            if (fromInv > 0)
                invtransferHeader.FromInventoryID = fromInv;
            if (toInv > 0)
                invtransferHeader.ToInventoryID = toInv;

            InitiateGrid(invtransferHeader);
        }
        private void clearUI()
        {
            cbx_StoreTo.SelectedIndex = -1;
            cbx_StoreFrom.SelectedIndex = -1;
            InitiateGrid(null);
        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            clearUI();
        }

    }
}
