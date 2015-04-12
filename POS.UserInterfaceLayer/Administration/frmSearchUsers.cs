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
            //frmUserGroupAddEdit frm = new frmUserGroupAddEdit();
            //frm.FormClosed += frmUserGroupAddEditClosed;
            //frm.ShowDialog();
        }
        public override void btn_Edit_Click(object sender, EventArgs e)
        {
            if (dgrid_Result.SelectedRows.Count != 0)
            {
                //frmUserGroupAddEdit frm = new frmUserGroupAddEdit(Convert.ToInt32(dgrid_Result.SelectedRows[0].Cells["GroupID"].Value.ToString()));
                //frm.FormClosed += frmUserGroupAddEditClosed;
                //frm.ShowDialog();
            }
            else { MessageBox.Show("اختر عنصر اولا"); }
        }
        public override void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgrid_Result.SelectedRows.Count != 0)
            {
                //ADGroupPrimaryKey pk = new ADGroupPrimaryKey();
                //pk.GroupID = Convert.ToInt32(dgrid_Result.SelectedRows[0].Cells["GroupID"].Value);
                //if (_aDGroupWrapper.Delete(pk))
                //{
                //    MessageBox.Show("تم الحذف");
                //    BindGrid();
                //}
            }
            else { MessageBox.Show("اختر عنصر اولا"); }

        }
        public override void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUserGroupAddEditClosed(object sender, FormClosedEventArgs e)
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
            // dgrid_Result.Size = new Size(10, 250);
            dgrid_Result.DataSource = null;

            dgrid_Result.DataSource = aDUserWrapper.SelectAll();
            addColumnToGrid("رقم المجموعه", "UserID", 20, false);
            addColumnToGrid("أسم المستخدم", "UserFullName", 200, true);
            addColumnToGrid("أسم الدخةول", "UserName", 100, true);
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
