using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POS.UserInterfaceLayer.BasicData
{
    public partial class frmProductGroupAddEdit : POS.UserInterfaceLayer.Portal.frmBaseAddEditForm
    {
        public frmProductGroupAddEdit()
        {
            InitializeComponent();
            base.lbl_FormHeader.Text = "أضافة / تعديل";
        }

        /// <summary>
        /// Events Override
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        public override void btn_Save_Click(object sender, EventArgs e) { }

        public override void btn_Back_Click(object sender, EventArgs e) { }
    }
}
