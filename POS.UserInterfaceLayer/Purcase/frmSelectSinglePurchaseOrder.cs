using POS.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.UserInterfaceLayer.Purcase
{
    public partial class frmSelectSinglePurchaseOrder : Form
    {
        protected VPURPurchaseOrderCollection CurrentCollection;
        protected VPURPurchaseOrder SelectedOrder;
        public frmSelectSinglePurchaseOrder()
        {
            InitializeComponent();
        }
        public frmSelectSinglePurchaseOrder(VPURPurchaseOrderCollection _purchaseOrderCollection)
        {
            InitializeComponent();
            CurrentCollection = _purchaseOrderCollection;
           // dgv_Orders.DataSource = CurrentCollection;
        }
        private void frmSelectSinglePurchaseOrder_Load(object sender, EventArgs e)
        {
            dgv_Orders.DataSource = CurrentCollection;
            

        }
    }
}
