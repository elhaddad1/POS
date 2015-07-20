using POS.BusinessLayer;
using POS.BusinessLayer.Wrapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
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
            //InitiateGrid(null);
        }

        public void InitiateGrid(int? CustomerId, DateTime? dateFrom = null, DateTime? toFrom = null)
        {
            try
            {
                dgrid_Result.Columns.Clear();

                dgrid_Result.AutoGenerateColumns = false;

                dgrid_Result.Height = 150;

                dgrid_Result.Size = new Size(10, 250);

                addColumnToGrid("CustomerAccountNumber", "CustomerAccountNumber", 120, false);

                addColumnToGrid("CustomerID", "CustomerID", 120, false);

                addColumnToGrid("SalesInvoiceId", "SalesInvoiceId", 120, false);

                addColumnToGrid("نوع العملية", "InvoiceType", 100, true);

                addColumnToGrid("رقم الفاتورة", "InvoiceNumber", 120, true);

                addColumnToGrid("العميل", "CustomerName", 120, true);

                addColumnToGrid("المبلغ الكلى", "TotalPrice", 120, true);

                addColumnToGrid("المبلغ المدفوع", "PaidAmount", 120, true);

                addColumnToGrid("المبلغ المتبقى", "RemainingAmount", 120, true);

                addColumnToGrid("مدين", "Depit", 100, true);

                addColumnToGrid("دائن", "Credit", 100, true);

                addColumnToGrid("رقم الشيك", "ChequeNumber", 100, true);

                addColumnToGrid("أخر ميعاد للدفع", "LstDayToPay", 100, true);

                addColumnToGrid("تاريخ العملية", "SalesDate", 120, true);

                addColumnToGrid("الموظف", "CreatedByName", 120, true);


                List<BDCustomerAccount> customerAccountList = new List<BDCustomerAccount>();

                customerAccountList = _customerAccountWrapper.GetCustomerAccounts(CustomerId, dateFrom, toFrom);

                dgrid_Result.DataSource = customerAccountList;

                if (customerAccountList.Count > 0)
                {
                    lbl_TotalAmount.Text = customerAccountList.Sum(a => a.TotalPrice).Value.ToString();
                    lbl_Paid.Text = customerAccountList.Sum(a => a.PaidAmount).Value.ToString();
                    lbl_Remaining.Text = customerAccountList.Sum(a => a.RemainingAmount).Value.ToString();
                }
                else
                {
                    lbl_TotalAmount.Text = "0";
                    lbl_Paid.Text = "0";
                    lbl_Remaining.Text = "0";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
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

                MessageBox.Show("حدث خطأ برجاء تكرار العمليه مره اخرى واذا تكرر الخطا برجاءالاتصال بالشخص المصمم للبرنامج وارسال رسالة الخطا التى ستظهر بعد قليل له");
                MessageBox.Show(ex.Message);
            }
        }
        private void search()
        {
            int? customerId = null;

            if (cbx_Customer.SelectedValue != null && !string.IsNullOrEmpty(cbx_Customer.SelectedValue.ToString()))
                customerId = int.Parse(cbx_Customer.SelectedValue.ToString());

            DateTime? dateFrom = null;
            DateTime? toFrom = null;

            if (dtp_fromDate.Value != null)
                dateFrom = dtp_fromDate.Value;
            if (dtp_toDate.Value != null)
                toFrom = dtp_toDate.Value;

            if (toFrom == null || dateFrom == null || toFrom.Value.Date < dateFrom.Value.Date)
            {
                MessageBox.Show("يجب اختيار فترة زمنية صحيحة");
                return;
            }


            InitiateGrid(customerId, dateFrom, toFrom);
        }
        #endregion
    }
}
