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
using POS.UserInterfaceLayer.Purcase;

namespace POS.UserInterfaceLayer.Purchase
{
    public partial class frmPurcaseReturnSearch : Form
    {

        PURPurchaseReturnHeaderWrapper pURPurchaseReturnHeaderWrapper;
        public frmPurcaseReturnSearch()
        {
            InitializeComponent();
            pURPurchaseReturnHeaderWrapper = new PURPurchaseReturnHeaderWrapper();
            InitiateGrid();
        }

        #region --Events

        public void btn_Add_Click(object sender, EventArgs e)
        {
            frmPurchaseReturnOrderAddEdit frm = new frmPurchaseReturnOrderAddEdit();
            frm.FormClosed += frmPurchaseReturnOrderAddEdit_FormClosed;
            frm.ShowDialog();
        }
        public void btn_Edit_Click(object sender, EventArgs e)
        {
            if (dgrid_PurchaseReturnSearch.SelectedRows.Count != 0)
                if (!Convert.ToBoolean(dgrid_PurchaseReturnSearch.SelectedRows[0].Cells["IsClosed"].Value))
                {
                    frmPurchaseReturnOrderAddEdit frm = new frmPurchaseReturnOrderAddEdit(Convert.ToInt32(dgrid_PurchaseReturnSearch.SelectedRows[0].Cells["PurchaseHeaderID"].Value));
                    frm.ShowDialog();
                }
                else
                    MessageBox.Show("لا يمكنك تعديل هذه الفاتوره حيث انها مغلقه");
        }
        public void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgrid_PurchaseReturnSearch.SelectedRows.Count != 0)
                if (!Convert.ToBoolean(dgrid_PurchaseReturnSearch.SelectedRows[0].Cells["IsClosed"].Value))
                {
                    pURPurchaseReturnHeaderWrapper.DeleteOrder(Convert.ToInt32(dgrid_PurchaseReturnSearch.SelectedRows[0].Cells["PurchaseHeaderID"].Value));
                    BindGrid();
                }
                else
                    MessageBox.Show("لا يمكنك مسح هذه الفاتوره حيث انها مغلقه");
        }
        public void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void btn_Close_Click(object sender, EventArgs e)
        {
            if (dgrid_PurchaseReturnSearch.SelectedRows.Count != 0)
                if (!Convert.ToBoolean(dgrid_PurchaseReturnSearch.SelectedRows[0].Cells["IsClosed"].Value))
                {
                    pURPurchaseReturnHeaderWrapper.CloseOrder(Convert.ToInt32(dgrid_PurchaseReturnSearch.SelectedRows[0].Cells["PurchaseHeaderID"].Value));
                    BindGrid();
                }
                else
                    MessageBox.Show("لا يمكنك مسح هذه الفاتوره حيث انها مغلقه");
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            BindGrid();
        }
        private void frmPurchaseReturnOrderAddEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            BindGrid();
        }
        #endregion

        #region --Private Methods
        private void InitiateGrid()
        {
            dgrid_PurchaseReturnSearch.DataSource = null;
            dgrid_PurchaseReturnSearch.AutoGenerateColumns = false;
            addColumnToGrid("", "SlaesReturnHeaderID", 0, false);
            addColumnToGrid("مسلسل فاتورة البيع", "InvoiceNumber", 120, true);
            addColumnToGrid("أسم العميل", "CustomerName", 120, true);
            addColumnToGrid("تاريخ الأرجاع", "ReturnDate", 120, true);
            addColumnToGrid("مغلق", "IsClosed", 60, true);

        }
        private void addColumnToGrid(string header, string dataField, int width, bool visible)//you can overload this method if u need additional parameters
        {
            DataGridViewColumn col = new DataGridViewColumn();
            DataGridViewCell dataGridViewCell = new DataGridViewTextBoxCell();
            col.CellTemplate = dataGridViewCell;
            col.Name = dataField;
            col.HeaderText = header;
            col.DataPropertyName = dataField;
            if (visible)
            {
                col.Width = width;
            }

            dgrid_PurchaseReturnSearch.Columns.Add(col);

            dgrid_PurchaseReturnSearch.Columns[dataField].Visible = visible;

        }
        private void BindGrid()
        {
            dgrid_PurchaseReturnSearch.DataSource = null;
            dgrid_PurchaseReturnSearch.DataSource = pURPurchaseReturnHeaderWrapper.SearchByCriteria(tbx_CustomerName.Text, tbx_VoucherSerial.Text, dtb_From.Value, dtb_To.Value);
        }
        #endregion
    }
}
