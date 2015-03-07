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

namespace POS.UserInterfaceLayer.Sales
{
    public partial class frmSalesReturnSearch : Form
    {

        SALSalesReturnHeaderWrapper sALSalesReturnHeaderWrapper;
        public frmSalesReturnSearch()
        {
            InitializeComponent();
            sALSalesReturnHeaderWrapper = new SALSalesReturnHeaderWrapper();
            InitiateGrid();
        }

        #region --Events

        public void btn_Add_Click(object sender, EventArgs e)
        {
            frmSalesOrderAddEdit frm = new frmSalesOrderAddEdit();
            frm.FormClosed += frmSalesOrderAddEdit_FormClosed;
            frm.ShowDialog();
        }
        public void btn_Edit_Click(object sender, EventArgs e)
        {
            if (dgrid_SalesReturnSearch.SelectedRows.Count != 0)
                if (!Convert.ToBoolean(dgrid_SalesReturnSearch.SelectedRows[0].Cells["IsClosed"].Value))
                {
                    frmSalesOrderAddEdit frm = new frmSalesOrderAddEdit(Convert.ToInt32(dgrid_SalesReturnSearch.SelectedRows[0].Cells["SalesHeaderID"].Value));
                    frm.ShowDialog();
                }
                else
                    MessageBox.Show("لا يمكنك تعديل هذه الفاتوره حيث انها مغلقه");
        }
        public void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgrid_SalesReturnSearch.SelectedRows.Count != 0)
                if (!Convert.ToBoolean(dgrid_SalesReturnSearch.SelectedRows[0].Cells["IsClosed"].Value))
                {
                    // sALSalesReturnHeaderWrapper.DeleteOrder(Convert.ToInt32(dgrid_SalesReturnSearch.SelectedRows[0].Cells["SalesHeaderID"].Value));
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
            dgrid_SalesReturnSearch.DataSource = null;
            dgrid_SalesReturnSearch.AutoGenerateColumns = false;
            addColumnToGrid("", "SlaesReturnHeaderID", 0, false);
            addColumnToGrid("مسلسل فاتورة البيع", "InvoiceNumber", 120, true);
            addColumnToGrid("أسم العميل", "CustomerName", 120, true);
            addColumnToGrid("تاريخ الأصدار", "InvoiceDate", 120, true);
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

            dgrid_SalesReturnSearch.Columns.Add(col);

            dgrid_SalesReturnSearch.Columns[dataField].Visible = visible;

        }
        private void BindGrid()
        {
            //dgrid_SalesReturnSearch.DataSource = null;
            //dgrid_SalesReturnSearch.DataSource = sALSalesHeaderWrapper.HeaderSearch(tbx_CustomerName.Text, tbx_OrderSerial.Text);

        }
        #endregion
    }
}
