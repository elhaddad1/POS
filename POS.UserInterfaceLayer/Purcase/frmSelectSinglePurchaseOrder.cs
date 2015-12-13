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
        private frmPurchaseReturnOrderAddEdit parentFrm;
        public frmSelectSinglePurchaseOrder()
        {
            InitializeComponent();
        }
        public frmSelectSinglePurchaseOrder(VPURPurchaseOrderCollection _vPURPurchaseOrderCollection,frmPurchaseReturnOrderAddEdit parentForm):this()
        {
            //InitializeComponent();
            CurrentCollection = _vPURPurchaseOrderCollection;
            this.parentFrm = parentForm;
            // dgv_Orders.DataSource = CurrentCollection;
        }
        private void frmSelectSinglePurchaseOrder_Load(object sender, EventArgs e)
        {
            dgv_Orders.DataSource = CurrentCollection.Select(p => new
            {
                PurchaseHeaderID=p.PurcaseHeaderID,
                InvoiceNumber = p.InvoiceNumber,
                SupplierName = p.SupplierName,
                InvoiceDate = p.InvoiceDate,
            }).Distinct().ToList();


        }

        private void dgv_Orders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Col_PurchaseHeaderID
            if (e.ColumnIndex==0)
            {
                this.parentFrm.selectedHeaderID = dgv_Orders["Col_PurchaseHeaderID", e.RowIndex].Value.ToString ();
                this.Close();
                this.Dispose();
            }
        }
    }
}
