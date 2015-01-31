using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.UserInterfaceLayer.Administration
{
    public partial class frmSearchUsers : POS.UserInterfaceLayer.Portal.frmBaseSearchForm
    {
        public frmSearchUsers()
        {
            InitializeComponent();
            base.lbl_FormHeader.Text = "المستخدمين";
        }
    }
}
