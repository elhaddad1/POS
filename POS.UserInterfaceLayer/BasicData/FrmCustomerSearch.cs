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
        BDCustomerWrapper bDCustomerWrapper;
        public FrmCustomerSearch()
        {
            InitializeComponent();
            bDCustomerWrapper = new BDCustomerWrapper();
        }
        private void FrmCustomerSearch_Load(object sender, EventArgs e)
        {
           // grb_Search.Height = 150;
            dgrid_Result .Size = new Size(10, 250);
            dgrid_Result.DataSource = bDCustomerWrapper.SelectAll();
             addColumnToGrid("رقم العميل", "CustomerID", 120, false );
            addColumnToGrid("كود لعميل", "CustomerCode", 80, true);
            addColumnToGrid("إسم العميل", "CustomerName", 120, true);
            addColumnToGrid(" رقم تليفون ", "CustomerPhone1", 100, true);
            addColumnToGrid("رقم موبيل", "CustomerMobile1", 100, true);

           
        }
        public override void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public override void btn_Add_Click(object sender, EventArgs e)
        {
            FrmCustomerAddEdit frm = new FrmCustomerAddEdit(null);
            frm.ShowDialog(frm);
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
        }

        private void btn_Search_Click_1(object sender, EventArgs e)
        {

        }


    }
}
