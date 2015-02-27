using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POS.UserInterfaceLayer.BasicData
{
    public partial class frmCustomerAccounts : POS.UserInterfaceLayer.Portal.frmBaseSearchForm
    {
        public frmCustomerAccounts()
        {
            InitializeComponent();
            base.btn_Add.Visible = false;
            base.btn_Delete.Visible = false;
        }
    }
}
