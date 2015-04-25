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
using POS.BusinessLayer;

namespace POS.UserInterfaceLayer.Administration
{
    public partial class frmSearchUsers : POS.UserInterfaceLayer.Portal.frmBaseSearchForm
    {
        ADUserWrapper aDUserWrapper;
        public frmSearchUsers()
        {
            InitializeComponent();
            aDUserWrapper = new ADUserWrapper();
            base.lbl_FormHeader.Text = "المستخدمين";
            InitiateGrid();
        }

        public override void btn_Add_Click(object sender, EventArgs e)
        {
            frmUserAddEdit frm = new frmUserAddEdit();
            frm.FormClosed += frmUserAddEditClosed;
            frm.ShowDialog();
        }
        public override void btn_Edit_Click(object sender, EventArgs e)
        {
            if (dgrid_Result.SelectedRows.Count != 0)
            {
                frmUserAddEdit frm = new frmUserAddEdit(Convert.ToInt32(dgrid_Result.SelectedRows[0].Cells["UserID"].Value.ToString()));
                frm.FormClosed += frmUserAddEditClosed;
                frm.ShowDialog();
            }
            else { MessageBox.Show("اختر عنصر اولا"); }
        }
        public override void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgrid_Result.SelectedRows.Count != 0)
            {
                ADUserPrimaryKey pk = new ADUserPrimaryKey();
                pk.UserID = Convert.ToInt32(dgrid_Result.SelectedRows[0].Cells["UserID"].Value);
                if (aDUserWrapper.Delete(pk))
                {
                    MessageBox.Show("تم الحذف");
                    BindGrid();
                }
            }
            else { MessageBox.Show("اختر عنصر اولا"); }

        }
        public override void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUserAddEditClosed(object sender, FormClosedEventArgs e)
        {
            BindGrid();
        }
        ///<summary>
        ///private methods
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InitiateGrid()
        {
            dgrid_Result.DataSource = null;
            dgrid_Result.DataSource = aDUserWrapper.SelectAll();
            addColumnToGrid("رقم المستخدم", "UserID", 20, false);
            addColumnToGrid("أسم المستخدم", "UserFullName", 200, true);
            addColumnToGrid("أسم الدخول", "UserName", 100, true);
            addColumnToGrid("محمول", "Mobile", 100, true);
            addColumnToGrid("العنوان", "Address", 200, true);
            dgrid_Result.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgrid_Result.RowHeadersVisible = false;
        }
        private void BindGrid()
        {
            dgrid_Result.DataSource = null;
            dgrid_Result.DataSource = aDUserWrapper.SelectAll();
        }
    }
}
