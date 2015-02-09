using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using POS.UserInterfaceLayer.BasicData;

namespace POS.UserInterfaceLayer.Sales
{
    public partial class frmSalesOrderSearch : POS.UserInterfaceLayer.Portal.frmBaseSearchForm
    {
        public frmSalesOrderSearch()
        {
            InitializeComponent();
            base.toggelButton(base.btn_Close);
            base.lbl_FormHeader.Text = "فواتير البيع";

        }
        #region --Events
        public override void btn_Add_Click(object sender, EventArgs e)
        {
            FrmCustomerAddEdit frm = new FrmCustomerAddEdit();
            frm.ShowDialog();
        }
        public override void btn_Edit_Click(object sender, EventArgs e) { }
        public override void btn_Delete_Click(object sender, EventArgs e) { }
        public override void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public override void btn_Close_Click(object sender, EventArgs e) { }
        #endregion

        #region --Private Methods
        private void InitiateGrid()
        {
            dgrid_Result.Size = new Size(10, 250);
            dgrid_Result.DataSource = null;
           // dgrid_Result.DataSource = _aDGroupWrapper.SelectAll();
            addColumnToGrid("رقم المجموعه", "GroupID", 20, false);
            addColumnToGrid("أسم المجموعة", "GroupName", 200, true);
        }
        private void BindGrid()
        {
            dgrid_Result.DataSource = null;
          //  dgrid_Result.DataSource = _aDGroupWrapper.SelectAll();
        }
        #endregion
    }
}
