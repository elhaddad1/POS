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

namespace POS.UserInterfaceLayer.Transfer
{
    public partial class FrmTransferOrder : POS.UserInterfaceLayer.Portal.frmBaseSearchForm
    {
        private INVTransferHeaderWrapper invtransferHeaderWrapper = new INVTransferHeaderWrapper();

        public FrmTransferOrder()
        {
            InitiateGrid();
            InitializeComponent();
            base.lbl_FormHeader.Text = "بحث";
        }

        public void InitiateGrid()
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

            List<INVTransferHeaderModel> transferList = invtransferHeaderWrapper.getAllTransferTransaction();

            dgrid_Result.DataSource = transferList;


        }

    }
}
