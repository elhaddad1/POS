using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS.BusinessLayer.Utility;
using POS.UserInterfaceLayer.Administration;
using POS.UserInterfaceLayer.BasicData;
using POS.UserInterfaceLayer.Inventory;
using POS.UserInterfaceLayer.Purcase;
using POS.UserInterfaceLayer.Sales;
using POS.UserInterfaceLayer.Transfer;
using POS.UserInterfaceLayer.Purcase;

namespace POS.UserInterfaceLayer.Portal
{
    public partial class frmMain : Form
    {
        Form activeForm;
        public frmMain()
        {
            InitializeComponent();
            ApplyingUserPriviliges();
        }

        // Events
        //
        private void frmMain_Load(object sender, EventArgs e)
        {


        }
        private void mnuItem_UserGroups_Click(object sender, EventArgs e)
        {
            frmUserGroupSearch frm = new frmUserGroupSearch();
            switchForm(frm);
        }
        private void mnuItem_Customers_Click(object sender, EventArgs e)
        {
            FrmCustomerSearch frm = new FrmCustomerSearch();
            switchForm(frm);
        }
        private void mnuItem_Products_Click(object sender, EventArgs e)
        {
            frmBDProductSearch frm = new frmBDProductSearch();
            switchForm(frm);
        }

        private void mnuItem_ProductGroup_Click(object sender, EventArgs e)
        {
            frmProductGroupSearch frm = new frmProductGroupSearch();
            switchForm(frm);
        }

        private void mnuItem_Suppliers_Click(object sender, EventArgs e)
        {
            FrmSupplierSearch frm = new FrmSupplierSearch();
            switchForm(frm);
        }


        private void mnuItem_Inventory_Click(object sender, EventArgs e)
        {
            frmInventorySearch frm = new frmInventorySearch();
            switchForm(frm);

        }
        private void switchForm(Form frm)
        {
            //frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //frm.TopLevel = false;
            //frm.Dock = DockStyle.None;
            //pnlContent.Controls.Clear();
            //pnlContent.Controls.Add(frm);
            //pnl_content.Controls.Add(frm);
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            activeForm = frm;
        }
        /// private Methods
        /// 
        private void ApplyingUserPriviliges()
        {
            try
            {
                foreach (string roles in GlobalVariables.CurrentUser.UserRoles)
                {
                    string[] arr = roles.Split('/');
                    foreach (string element in arr)
                    {
                        var result = mnu_MainMenu.Items.Find(element, true).FirstOrDefault();
                        if (result != null)
                            result.Enabled = true;
                    }
                }
                foreach (string btn in GlobalVariables.CurrentUser.UserShrtBtn)
                {
                    Control[] btns = this.Controls.Find(btn, true);
                    if (btns != null && btns.Length > 0)
                        btns[0].Enabled = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void mnuItem_AdjustReason_Click(object sender, EventArgs e)
        {
            FrmAdjustmentReasons frm = new FrmAdjustmentReasons();
            switchForm(frm);
        }

        private void mnuItem_StockInquiry_Click(object sender, EventArgs e)
        {
            frmStockInquiry frm = new frmStockInquiry();
            switchForm(frm);
        }

        private void mnuItem_PurchaseReturn_Click(object sender, EventArgs e)
        {
           frmPurcaseReturnSearch frm = new frmPurcaseReturnSearch(); 
            switchForm(frm);
        }

        private void mnuItem_PurcaseOrder_Click(object sender, EventArgs e)
        {
            frmPurchaseOrderSearch frm = new frmPurchaseOrderSearch();
            switchForm(frm);
        }

        private void mnuItem_OpenTakingInventory_Click(object sender, EventArgs e)
        {
            FrmOpenTakingInventory frm = new FrmOpenTakingInventory();
            switchForm(frm);
        }

        private void mnuItem_CloseTakingInventory_Click(object sender, EventArgs e)
        {
            FrmCloseTakingInventory frm = new FrmCloseTakingInventory();
            switchForm(frm);
        }

        private void mnuItem_TransferOrder_Click(object sender, EventArgs e)
        {
            FrmTransferOrderSearch frm = new FrmTransferOrderSearch();
            switchForm(frm);
        }

        private void mnuItem_SalesOrders_Click(object sender, EventArgs e)
        {
            frmSalesOrderSearch frm = new frmSalesOrderSearch();
            switchForm(frm);
        }

        private void mnuItem_SalesOrder_Click(object sender, EventArgs e)
        {
            frmSalesOrderAddEdit frm = new frmSalesOrderAddEdit();
            switchForm(frm);
        }

        private void mnuItem_OpenningQuantities_Click(object sender, EventArgs e)
        {
            frmOpenningQuantities frm = new frmOpenningQuantities();
            switchForm(frm);
        }

        private void mnuItem_CustomerAccount_Click(object sender, EventArgs e)
        {
            frmCustomerAccounts frm = new frmCustomerAccounts();
            switchForm(frm);
        }

        private void mnuItem_SupplierAccount_Click(object sender, EventArgs e)
        {
            frmSupplierAccounts frm = new frmSupplierAccounts();
            switchForm(frm);
        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {

            frmBDProductSearch frm = new frmBDProductSearch();
            switchForm(frm);
        }

        private void btn_AddCustomer_Click(object sender, EventArgs e)
        {
            FrmCustomerSearch frm = new FrmCustomerSearch();
            switchForm(frm);
        }

        private void btn_AddSupplier_Click(object sender, EventArgs e)
        {
            FrmSupplierSearch frm = new FrmSupplierSearch();
            switchForm(frm);
        }

        private void btn_CustomerAccount_Click(object sender, EventArgs e)
        {
            frmCustomerAccounts frm = new frmCustomerAccounts();
            frm.ShowDialog();
        }

        private void btn_SupplierAccount_Click(object sender, EventArgs e)
        {
            frmSupplierAccounts frm = new frmSupplierAccounts();
            frm.ShowDialog();
        }

        private void btn_SalesOrder_Click(object sender, EventArgs e)
        {
            frmSalesOrderSearch frm = new frmSalesOrderSearch();
            switchForm(frm);
        }

        private void btn_ReturnSalesOrder_Click(object sender, EventArgs e)
        {
            frmSalesReturnSearch frm = new frmSalesReturnSearch();
            frm.ShowDialog();
        }

        private void btn_ReturnPurchaceOrder_Click(object sender, EventArgs e)
        {
            frmPurchaseReturnOrderAddEdit frm = new frmPurchaseReturnOrderAddEdit();
            frm.ShowDialog();
        }

        private void btn_PurchaceOrder_Click(object sender, EventArgs e)
        {
            frmPurchaseOrderSearch frm = new frmPurchaseOrderSearch();
            switchForm(frm);
        }

        private void mnuItem_Adjustment_Click(object sender, EventArgs e)
        {
            FrmAdjustmentSearch frm = new FrmAdjustmentSearch();
            switchForm(frm);
        }

        private void mnuItem_Users_Click(object sender, EventArgs e)
        {
            frmSearchUsers frm = new frmSearchUsers();
            frm.ShowDialog();
        }

        private void mnuItem_SalesReturnOrder_Click(object sender, EventArgs e)
        {
            frmSalesReturnSearch frm = new frmSalesReturnSearch();
            frm.ShowDialog();
        }

        private void mnuItem_CustomerAccount_Click_1(object sender, EventArgs e)
        {
            frmCustomerAccounts frm = new frmCustomerAccounts();
            frm.ShowDialog();
        }

        private void mnuItem_SupplierAccount_Click_1(object sender, EventArgs e)
        {
            frmSupplierAccounts frm = new frmSupplierAccounts();
            frm.ShowDialog();
        }

    }
}
