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
    public partial class FrmAdjustReasonAddEdit : frmBaseAddEditForm
    {
        INVAdjustStockReason _currentReason;
        INVAdjustStockReasonService service=new INVAdjustStockReasonService ();
        public FrmAdjustReasonAddEdit()
        {
            InitializeComponent();
        }
        public FrmAdjustReasonAddEdit(INVAdjustStockReason reason )
        {
            InitializeComponent();
            _currentReason = reason;
            txb_AdjustStockReason.Text = reason.AdjustStockreasonName;

        }
        public override void btn_Save_Click(object sender, EventArgs e)
        {
            if (txb_AdjustStockReason.Text!="")
            {
                if (_currentReason == null)
                {
                    _currentReason = new INVAdjustStockReason();
                    _currentReason.AdjustStockreasonName = txb_AdjustStockReason.Text;
                    service.Insert(_currentReason);
                }
                else
                {
                    INVAdjustStockReasonPrimaryKey pk = new INVAdjustStockReasonPrimaryKey();
                    pk.AdjustStockReasonID = _currentReason.AdjustStockReasonID;
                    _currentReason = service.SelectOne(pk);
                    _currentReason.AdjustStockreasonName = txb_AdjustStockReason.Text;
                    service.Update(_currentReason);
                }
                MessageBox.Show("تم الحفظ بنجاح");
            }
        }
        public override void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
