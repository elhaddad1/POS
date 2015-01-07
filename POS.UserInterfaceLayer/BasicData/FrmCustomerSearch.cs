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
    public partial class FrmCustomerSearch : POS.UserInterfaceLayer.Portal.frmBaseSearchForm
    {
        BDCustomerWrapper  _bDCustomerWrapper;
        public FrmCustomerSearch()
        {
            InitializeComponent();
            _bDCustomerWrapper = new BDCustomerWrapper();
        }
        private void FrmCustomerSearch_Load(object sender, EventArgs e)
        {
           // grb_Search.Height = 150;
            dgrid_Result .Size = new Size(10, 250);
            dgrid_Result.DataSource = _bDCustomerWrapper.SelectAll();
             addColumnToGrid("رقم العميل", "CustomerID", 120, false );
            addColumnToGrid("كود لعميل", "CustomerCode", 80, true);
            addColumnToGrid("إسم العميل", "CustomerName", 160, true);
            addColumnToGrid(" رقم تليفون ", "CustomerPhone1", 100, true);
            addColumnToGrid("رقم موبيل", "CustomerMobile1", 100, true);
            Search();
           
        }
        public override void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public override void btn_Add_Click(object sender, EventArgs e)
        {
            FrmCustomerAddEdit frm = new FrmCustomerAddEdit();
            frm.ShowDialog();
            Search();
        }
        public override void btn_Edit_Click(object sender, EventArgs e)
        {
            int? customerID=0;
            if (dgrid_Result.Rows [dgrid_Result.SelectedCells[0].RowIndex ].Cells ["CustomerID"].Value !=null)
            {
                customerID =Convert .ToInt32( dgrid_Result.Rows[dgrid_Result.SelectedCells[0].RowIndex].Cells["CustomerID"].Value);
            }
            else
            {
                MessageBox.Show("لابد من اختيار عميل");
            }
            FrmCustomerAddEdit frm = new FrmCustomerAddEdit(customerID);
            frm.ShowDialog();
            Search();
        }
        public override void btn_Delete_Click(object sender, EventArgs e)
        {

            int? customerID = 0;
            if (dgrid_Result.Rows[dgrid_Result.SelectedCells[0].RowIndex].Cells["CustomerID"].Value != null)
            {
                if (MessageBox.Show("هل نت متأكد من حذف العميل؟","تحذير",MessageBoxButtons.YesNo) == DialogResult .Yes )
                {
                    customerID = Convert.ToInt32(dgrid_Result.Rows[dgrid_Result.SelectedCells[0].RowIndex].Cells["CustomerID"].Value);
                    BDCustomerPrimaryKey customerPK = new BDCustomerPrimaryKey();
                    customerPK.CustomerID = customerID;
                    _bDCustomerWrapper.Delete(customerPK); 
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("لابد من اختيار عميل");
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
            BDCustomerCollection customers= _bDCustomerWrapper.SearchByCriteria(customerName, customerCode);
            dgrid_Result.DataSource = customers;
        }
    }
}
