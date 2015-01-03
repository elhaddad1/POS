using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using POS.BusinessLayer;
using POS.BusinessLayer.Wrapper;


namespace POS.UserInterfaceLayer.Administration
{
    public partial class frmUserGroupAddEdit : POS.UserInterfaceLayer.Portal.frmBaseAddEditForm
    {
        public frmUserGroupAddEdit()
        {
            InitializeComponent();
        }

        public frmUserGroupAddEdit(ADGroup aDGroup)
        {
            InitializeComponent();
        }
    }
}
