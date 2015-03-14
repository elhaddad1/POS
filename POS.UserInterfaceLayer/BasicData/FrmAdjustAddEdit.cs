using POS.BusinessLayer;
using POS.UserInterfaceLayer.Portal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.UserInterfaceLayer.BasicData
{
    public partial class FrmAdjustAddEdit : frmBaseAddEditForm
    {
        INVAdjustStockReason _currentReason;
        INVAdjustStockReasonService service=new INVAdjustStockReasonService ();
        public FrmAdjustAddEdit(FrmAdjustmentSearch frmAdjustmentSearch)
        {
            InitializeComponent();
        }
        public FrmAdjustAddEdit(int id,FrmAdjustmentSearch frmAdjustmentSearch)
        {
            InitializeComponent();

        }
        public override void btn_Save_Click(object sender, EventArgs e)
        {
        }
        public override void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
