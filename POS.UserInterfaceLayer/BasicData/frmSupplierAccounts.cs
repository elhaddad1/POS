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
    public partial class frmSupplierAccounts : POS.UserInterfaceLayer.Portal.frmBaseSearchForm
    {
        private BDSupplierAccountWrapper _supplierAccountWrapper;
        private BDSupplierWrapper _supplierWrapper;

        public frmSupplierAccounts()
        {
            InitializeComponent();
            base.lbl_FormHeader.Text = "بحث";
            base.btn_Add.Visible = false;
            base.btn_Delete.Visible = false;
            this._supplierAccountWrapper = new BDSupplierAccountWrapper();
            this._supplierWrapper = new BDSupplierWrapper();
            FillSupplierCBX();
            InitiateGrid(null);
        }

        public void InitiateGrid(int? SupplierId)
        {
            dgrid_Result.Columns.Clear();

            dgrid_Result.AutoGenerateColumns = false;

            dgrid_Result.Height = 150;

            dgrid_Result.Size = new Size(10, 250);

            addColumnToGrid("SupplierAccountId", "SupplierAccountId", 120, false);

            addColumnToGrid("SupplierID", "SupplierID", 120, false);

            addColumnToGrid("PurcaseInvoiceID", "PurcaseInvoiceID", 120, false);

            addColumnToGrid("المبلغ الكلى", "TotalPrice", 120, true);

            addColumnToGrid("المبلغ المدفوع", "PaidAmount", 120, true);

            addColumnToGrid("المبلغ المتبقى", "RemainingAmount", 120, true);

            addColumnToGrid("تاريخ العملية", "PurchaseDate", 120, true);

            addColumnToGrid("رقم الفاتورة", "InvoiceNumber", 120, true);

            addColumnToGrid("المورد", "SupplierName", 120, true);

            addColumnToGrid("الموظف", "CreatedByName", 120, true);

            List<BDSupplierAccount> supplierAccountList = new List<BDSupplierAccount>();

            if (SupplierId != null)
                supplierAccountList = _supplierAccountWrapper.GetSupplierAccounts(SupplierId.Value);

            dgrid_Result.DataSource = supplierAccountList;

            if (supplierAccountList.Count > 0)
            {
                lbl_TotalAmount.Text = supplierAccountList.Sum(a => a.TotalPrice).Value.ToString();
                lbl_Paid.Text = supplierAccountList.Sum(a => a.PaidAmount).Value.ToString();
                lbl_Remaining.Text = supplierAccountList.Sum(a => a.RemainingAmount).Value.ToString();
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
        private void FillSupplierCBX()
        {

            try
            {
                cbx_Supplier.DataSource = _supplierWrapper.SelectAll();
                cbx_Supplier.DisplayMember = "SupplierName";
                cbx_Supplier.ValueMember = "SupplierID";
                cbx_Supplier.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show("حدث خطأ برجاء تكرار العمليه مره اخرى واذا تكرر الخطا برجاءالاتصال بالشخص المصمم للبرنامج وارسال رسالة الخطا التى ستظهر بعد قليل له");
                MessageBox.Show(ex.Message);
            }
        }
        private void search()
        {
            int supplierId = 0;

            if (cbx_Supplier.SelectedValue == null)
                return;

            int.TryParse(cbx_Supplier.SelectedValue.ToString(),out supplierId);

            InitiateGrid(supplierId);
        }
        #endregion
    }
}
