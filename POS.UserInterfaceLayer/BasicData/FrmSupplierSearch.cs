using POS.BusinessLayer;
using POS.BusinessLayer.Wrapper;
using POS.UserInterfaceLayer.Portal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.UserInterfaceLayer.BasicData
{
    public partial class FrmSupplierSearch : frmBaseSearchForm
    {
        BDSupplierWrapper _bDSupplierWrapper;
        public FrmSupplierSearch()
        {
            InitializeComponent();
            _bDSupplierWrapper = new BDSupplierWrapper();
        }
        private void FrmSupplierSearch_Load(object sender, EventArgs e)
        {
            InitionGrid();
            Search();

        }

        public void InitionGrid()
        {

            dgrid_Result.Columns.Clear();

            dgrid_Result.AutoGenerateColumns = false;

            dgrid_Result.Height = 150;

            dgrid_Result.Size = new Size(10, 250);

            addColumnToGrid("رقم المورد", "SupplierID", 120, false);
            addColumnToGrid("كود لمورد", "SupplierCode", 80, true);
            addColumnToGrid("إسم العميل", "SupplierName", 200, true);
            addColumnToGrid(" رقم تليفون ", "SupplierPhone1", 100, true);
            addColumnToGrid("رقم موبيل", "SupplierMobile1", 100, true);
            /////////
            addColumnToGrid("دائن", "Debit", 100, true);
            addColumnToGrid("مدين", "Credit", 100, true);

            dgrid_Result.DataSource = _bDSupplierWrapper.SelectAll();
        }
        public override void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public override void btn_Add_Click(object sender, EventArgs e)
        {
            FrmSupplierAddEdit frm = new FrmSupplierAddEdit();
            frm.ShowDialog();
            Search();
        }
        public override void btn_Edit_Click(object sender, EventArgs e)
        {
            int? supplierID = 0;
            if (dgrid_Result.Rows[dgrid_Result.SelectedCells[0].RowIndex].Cells["SupplierID"].Value != null)
            {
                supplierID = Convert.ToInt32(dgrid_Result.Rows[dgrid_Result.SelectedCells[0].RowIndex].Cells["SupplierID"].Value);
            }
            else
            {
                MessageBox.Show("لابد من اختيار مورد");
            }
            FrmSupplierAddEdit frm = new FrmSupplierAddEdit(supplierID);
            frm.ShowDialog();
            Search();
        }
        public override void btn_Delete_Click(object sender, EventArgs e)
        {

            int? supplierID = 0;
            if (dgrid_Result.Rows[dgrid_Result.SelectedCells[0].RowIndex].Cells["SupplierID"].Value != null)
            {
                if (MessageBox.Show("هل نت متأكد من حذف المورد؟", "تحذير", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    supplierID = Convert.ToInt32(dgrid_Result.Rows[dgrid_Result.SelectedCells[0].RowIndex].Cells["SupplierID"].Value);
                    BDSupplierPrimaryKey customerPK = new BDSupplierPrimaryKey();
                    customerPK.SupplierID = supplierID;
                    _bDSupplierWrapper.Delete(customerPK);
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("لابد من اختيار مورد");
            }
            Search();
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            dgrid_Result.DataSource = null;
            string customerName = tbx_cusomerName.Text != "" ? tbx_cusomerName.Text : null;
            string customerCode = tbx_customerCode.Text != "" ? tbx_customerCode.Text : null;
            BDSupplierCollection customers = _bDSupplierWrapper.SearchByCriteria(customerName, customerCode);
            dgrid_Result.DataSource = customers;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int? supplierID = 0;
            if (dgrid_Result.Rows[dgrid_Result.SelectedCells[0].RowIndex].Cells["SupplierID"].Value != null)
            {
                if (MessageBox.Show("هل نت متأكد من تعديل حساب هذا المورد؟", "تحذير", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    supplierID = Convert.ToInt32(dgrid_Result.Rows[dgrid_Result.SelectedCells[0].RowIndex].Cells["SupplierID"].Value);
                    frmSupplierAccountEdit _frmSupplierAccountEdit = new frmSupplierAccountEdit(supplierID.Value, this);
                    _frmSupplierAccountEdit.ShowDialog();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("لابد من اختيار مورد");
            }
        }
    }
}
