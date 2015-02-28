using POS.BusinessLayer;
using POS.BusinessLayer.Wrapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POS.UserInterfaceLayer.BasicData
{
    public partial class frmCustomerAccounts : POS.UserInterfaceLayer.Portal.frmBaseSearchForm
    {
        private BDCustomerAccountWrapper _customerAccountWrapper;
        private BDCustomerWrapper _customerWrapper;

        public frmCustomerAccounts()
        {
            InitializeComponent();
            base.lbl_FormHeader.Text = "بحث";
            base.btn_Add.Visible = false;
            base.btn_Delete.Visible = false;
            this._customerAccountWrapper = new BDCustomerAccountWrapper();
            this._customerWrapper = new BDCustomerWrapper();
            FillCustomerCBX();
            InitiateGrid(null);
        }

        public void InitiateGrid(int? CustomerId)
        {
            dgrid_Result.Columns.Clear();

            dgrid_Result.AutoGenerateColumns = false;

            dgrid_Result.Height = 150;

            dgrid_Result.Size = new Size(10, 250);

            addColumnToGrid("CustomerAccountNumber", "CustomerAccountNumber", 120, false);

            addColumnToGrid("CustomerID", "CustomerID", 120, false);

            addColumnToGrid("SalesInvoiceId", "SalesInvoiceId", 120, false);

            addColumnToGrid("المبلغ الكلى", "TotalPrice", 120, true);

            addColumnToGrid("المبلغ المدفوع", "PaidAmount", 120, true);

            addColumnToGrid("المبلغ المتبقى", "RemainingAmount", 120, true);

            addColumnToGrid("تاريخ العملية", "SalesDate", 120, true);

            addColumnToGrid("رقم الفاتورة", "InvoiceNumber", 120, true);

            addColumnToGrid("العميل", "CustomerName", 120, true);

            addColumnToGrid("الموظف", "CreatedByName", 120, true);

            List<BDCustomerAccount> customerAccountList = new List<BDCustomerAccount>();

            if (CustomerId != null)
                customerAccountList = _customerAccountWrapper.GetCustomerAccounts(CustomerId.Value);

            dgrid_Result.DataSource = customerAccountList;

        }

        #region Form Event
        private void btn_Search_Click(object sender, EventArgs e)
        {
            search();
        }

        public override void btn_Edit_Click(object sender, EventArgs e)
        {
            if (dgrid_Result.SelectedRows.Count != 0)
                if (!Convert.ToBoolean(dgrid_Result.SelectedRows[0].Cells["IsVoid"].Value))
                {
                    //FrmAddEditTransferOrder frm = new FrmAddEditTransferOrder(this, Convert.ToInt32(dgrid_Result.SelectedRows[0].Cells["INVTransferHeaderID"].Value));
                    //frm.ShowDialog();
                }
                else
                    MessageBox.Show("لا يمكنك تعديل هذا الحساب حيث انها محذوفة");
        }

        public override void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region private methods
        private void FillCustomerCBX()
        {

            try
            {
                cbx_Customer.DataSource = _customerWrapper.SelectAll();
                cbx_Customer.DisplayMember = "CustomerName";
                cbx_Customer.ValueMember = "CustomerID";
                cbx_Customer.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        private void search()
        {
            int customerId = 0;

            if (cbx_Customer.SelectedValue == null)
                return;

            int.TryParse(cbx_Customer.SelectedValue.ToString(),out customerId);

            InitiateGrid(customerId);
        }
        #endregion
    }
}
