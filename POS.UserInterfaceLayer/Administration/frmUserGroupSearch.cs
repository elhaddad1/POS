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
    public partial class frmUserGroupSearch : POS.UserInterfaceLayer.Portal.frmBaseSearchForm
    {
        private ADGroupWrapper _aDGroupWrapper;
        public frmUserGroupSearch()
        {
            InitializeComponent();
            _aDGroupWrapper = new ADGroupWrapper();
            base.lbl_FormHeader.Text = "مجموعات المستخدمين";
            InitiateGrid();
        }

        //methods
        private void InitiateGrid()
        {
            dgrid_Result.Size = new Size(10, 250);
            dgrid_Result.DataSource = _aDGroupWrapper.SelectAll();
            addColumnToGrid("رقم المجموعه", "GroupID", 20, false);
            addColumnToGrid("أسم المجموعة", "GroupName", 80, true);
        }

    }
}
