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
    public partial class _FrmTransferOrderSearch : POS.UserInterfaceLayer.Portal.frmBaseSearchForm
    {
        private INVTransferHeaderWrapper invtransferHeaderWrapper = new INVTransferHeaderWrapper();
        public _FrmTransferOrderSearch()
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

        private void btn_Add_Click_1(object sender, EventArgs e)
        {
            //FrmAddEditTransferOrder frm = new FrmAddEditTransferOrder(this);
            //frm.ShowDialog();
        }
    }
}
