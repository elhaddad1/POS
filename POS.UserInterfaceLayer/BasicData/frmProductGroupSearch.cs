using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POS.UserInterfaceLayer.BasicData
{
    public partial class frmProductGroupSearch : POS.UserInterfaceLayer.Portal.frmBaseSearchForm
    {
        public frmProductGroupSearch()
        {
            InitializeComponent();
            base.lbl_FormHeader.Text = "بحث";
        }

        /// <summary>
        /// Events Override
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void btn_Add_Click(object sender, EventArgs e)
        {
            frmProductGroupAddEdit frm = new frmProductGroupAddEdit();
            frm.ShowDialog();
        }
        public override void btn_Edit_Click(object sender, EventArgs e) { }
        public override void btn_Delete_Click(object sender, EventArgs e) { }
        public override void btn_Back_Click(object sender, EventArgs e) { }
    }
}
