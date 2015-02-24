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
using POS.UserInterfaceLayer.BasicData;

namespace POS.UserInterfaceLayer.Purcase
{
    public partial class frmPurchaseOrderSearch : POS.UserInterfaceLayer.Portal.frmBaseSearchForm
    {
        PURPurchaseHeaderWrapper sALPurchaseHeaderWrapper;

        public frmPurchaseOrderSearch()
        {
            InitializeComponent();
            // base.toggelButton(base.btn_Close);
            base.lbl_FormHeader.Text = "فواتير الشراء";
            sALPurchaseHeaderWrapper = new PURPurchaseHeaderWrapper();
            InitiateGrid();
        }

        #region --Events
        private void btn_AddCustomer_Click(object sender, EventArgs e)
        {
            FrmSupplierAddEdit frm = new FrmSupplierAddEdit();
            frm.ShowDialog();
        }
        public override void btn_Add_Click(object sender, EventArgs e)
        {
            frmPurchaseOrderAddEdit frm = new frmPurchaseOrderAddEdit();
            frm.FormClosed += frmPurchaseOrderAddEdit_FormClosed;
            frm.ShowDialog();
        }
        public override void btn_Edit_Click(object sender, EventArgs e)
        {
            if (dgrid_Result.SelectedRows.Count != 0)
                if (!Convert.ToBoolean(dgrid_Result.SelectedRows[0].Cells["IsClosed"].Value))
                {

                }
                else
                    MessageBox.Show("لا يمكنك تعديل هذه الفاتوره حيث انها مغلقه");
        }
        public override void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgrid_Result.SelectedRows.Count != 0)
                if (!Convert.ToBoolean(dgrid_Result.SelectedRows[0].Cells["IsClosed"].Value))
                {
                    sALPurchaseHeaderWrapper.DeleteOrder(Convert.ToInt32(dgrid_Result.SelectedRows[0].Cells["PurcaseHeaderID"].Value));
                    BindGrid();
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
                    if (sALPurchaseHeaderWrapper.CloseOrder(Convert.ToInt32(dgrid_Result.SelectedRows[0].Cells["PurchaseHeaderID"].Value)))
                    {
                        BindGrid();
                        // Utility.Print(null, 1); 
                    }
                }
                else
                    MessageBox.Show(" لا يمكنك إغلاق هذه الفاتوره حيث انها مغلقه");
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            BindGrid();
        }
        private void frmPurchaseOrderAddEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            BindGrid();
        }
        #endregion

        #region --Private Methods
        private void InitiateGrid()
        {
            dgrid_Result.Size = new Size(800, 200);
            dgrid_Result.DataSource = null;
            dgrid_Result.AutoGenerateColumns = false;
            addColumnToGrid("", "PurcaseHeaderID", 20, false);
            addColumnToGrid("مسلسل الفاتورة", "InvoiceNumber", 120, true);
            addColumnToGrid("أسم المورد", "CustomerName", 120, true);
            addColumnToGrid("تاريخ الأصدار", "InvoiceDate", 120, true);
            addColumnToGrid("المبلغ المطلوب", "TotalPrice", 120, true);
            addColumnToGrid("مغلق", "IsClosed", 60, true);

        }
        private void BindGrid()
        {
            dgrid_Result.DataSource = null;
            dgrid_Result.DataSource = sALPurchaseHeaderWrapper.HeaderSearch(tbx_SupplierName.Text, tbx_OrderSerial.Text);
        }
        #endregion


    }
}
