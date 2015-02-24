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
        private INVTransferHeaderWrapper invtransferHeaderWrapper = new INVTransferHeaderWrapper();
        public FrmTransferOrderSearch()
        {
            InitiateGrid(null);
            InitializeComponent();
            base.lbl_FormHeader.Text = "بحث";
        }

        public void InitiateGrid(INVTransferHeader invtransferHeader)
        {
            dgrid_Result.Columns.Clear();

            dgrid_Result.AutoGenerateColumns = false;

            dgrid_Result.Height = 150;

            dgrid_Result.Size = new Size(10, 250);

            addColumnToGrid("INVTransferHeaderID", "INVTransferHeaderID", 120, false);

            addColumnToGrid("المخزن المحول منه", "FromInventory", 120, true);

            addColumnToGrid("المخزن المحول اليه", "ToInventory", 120, true);

            addColumnToGrid("تاريخ التحويل", "TransferDate", 120, true);

            addColumnToGrid("الموظف", "CreatedBy", 120, true);

            List<INVTransferHeaderModel> transferList = new List<INVTransferHeaderModel>();

            if (invtransferHeader == null)
                transferList = invtransferHeaderWrapper.getAllTransferTransaction();
            else
                transferList = invtransferHeaderWrapper.getAllTransferTransaction(invtransferHeader);

            dgrid_Result.DataSource = transferList;

        }


        void search()
        {
            INVTransferHeader invtransferHeader = new INVTransferHeader();
            invtransferHeader.CreateDate = dtp_TransferDate.Value;
            int fromInv = 0, toInv = 0;
            int.TryParse(ddl_InventoryName.SelectedValue.ToString(), out fromInv);
            int.TryParse(ddl_InventoryName.SelectedValue.ToString(), out toInv);
            if (fromInv > 0)
                invtransferHeader.FromInventoryID = fromInv;
            if (toInv > 0)
                invtransferHeader.ToInventoryID = toInv;

            InitiateGrid(invtransferHeader);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            search();
        }

        public override void btn_Add_Click(object sender, EventArgs e)
        {
            FrmAddEditTransferOrder frm = new FrmAddEditTransferOrder(this,0);
            frm.ShowDialog();
        }
        public override void btn_Edit_Click(object sender, EventArgs e)
        {
            if (dgrid_Result.SelectedRows.Count != 0)
                if (!Convert.ToBoolean(dgrid_Result.SelectedRows[0].Cells["IsClosed"].Value))
                {
                    FrmAddEditTransferOrder frm = new FrmAddEditTransferOrder(this,Convert.ToInt32(dgrid_Result.SelectedRows[0].Cells["SalesHeaderID"].Value));
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
                    invtransferHeaderWrapper.DeleteOrder(Convert.ToInt32(dgrid_Result.SelectedRows[0].Cells["SalesHeaderID"].Value));
                    InitiateGrid(null);
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
                    if (invtransferHeaderWrapper.CloseOrder(Convert.ToInt32(dgrid_Result.SelectedRows[0].Cells["SalesHeaderID"].Value)))
                    {
                        InitiateGrid(null);
                        // Utility.Print(null, 1); 
                    }
                }
                else
                    MessageBox.Show(" لا يمكنك إغلاق هذه الفاتوره حيث انها مغلقه");
        }
    }
}
