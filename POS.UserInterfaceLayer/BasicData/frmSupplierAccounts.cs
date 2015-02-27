using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POS.UserInterfaceLayer.BasicData
{
    public partial class frmSupplierAccounts : POS.UserInterfaceLayer.Portal.frmBaseSearchForm
    {
        public frmSupplierAccounts()
        {
            InitializeComponent();
            base.btn_Add.Visible = false;
            base.btn_Delete.Visible = false;
        }
    }
}
