using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using POS.BusinessLayer.Utility;
using POS.BusinessLayer.Wrapper;
using POS.UserInterfaceLayer.BasicData;

namespace POS.UserInterfaceLayer.Sales
{
    public partial class frmSalesOrderSearch : POS.UserInterfaceLayer.Portal.frmBaseSearchForm
    {
        SALSalesHeaderWrapper sALSalesHeaderWrapper;
        public frmSalesOrderSearch()
        {
            InitializeComponent();
            // base.toggelButton(base.btn_Close);
            base.lbl_FormHeader.Text = "فواتير البيع";
            base.panl_Header.Dock = DockStyle.Top;
            sALSalesHeaderWrapper = new SALSalesHeaderWrapper();
            InitiateGrid();

        }
        #region --Events
        private void btn_AddCustomer_Click(object sender, EventArgs e)
        {
            FrmCustomerAddEdit frm = new FrmCustomerAddEdit();
            frm.ShowDialog();
        }
        public override void btn_Add_Click(object sender, EventArgs e)
        {
            frmSalesOrderAddEdit frm = new frmSalesOrderAddEdit();
            frm.FormClosed += frmSalesOrderAddEdit_FormClosed;
            frm.ShowDialog();
        }
        public override void btn_Edit_Click(object sender, EventArgs e)
        {
            if (dgrid_Result.SelectedRows.Count != 0)
                if (!Convert.ToBoolean(dgrid_Result.SelectedRows[0].Cells["IsClosed"].Value))
                {
                    frmSalesOrderAddEdit frm = new frmSalesOrderAddEdit(Convert.ToInt32(dgrid_Result.SelectedRows[0].Cells["SalesHeaderID"].Value));
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
                    sALSalesHeaderWrapper.DeleteOrder(Convert.ToInt32(dgrid_Result.SelectedRows[0].Cells["SalesHeaderID"].Value));
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

        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            BindGrid();
        }
        private void frmSalesOrderAddEdit_FormClosed(object sender, FormClosedEventArgs e)
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
            addColumnToGrid("", "SalesHeaderID", 20, false);
            addColumnToGrid("مسلسل الفاتورة", "InvoiceNumber", 120, true);
            addColumnToGrid("أسم العميل", "CustomerName", 120, true);
            addColumnToGrid("تاريخ الأصدار", "InvoiceDate", 120, true);
            addColumnToGrid("المبلغ المطلوب", "TotalPrice", 120, true);
            addColumnToGrid("مغلق", "IsClosed", 60, true);

        }
        private void BindGrid()
        {
            dgrid_Result.DataSource = null;
            dgrid_Result.DataSource = sALSalesHeaderWrapper.HeaderSearch(tbx_CustomerName.Text, tbx_OrderSerial.Text);

        }
        #endregion




    }
}
