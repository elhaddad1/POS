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
using POS.BusinessLayer.Wrapper;
using POS.UserInterfaceLayer.Portal;
namespace POS.UserInterfaceLayer.Inventory
{
    public partial class frmStockInquiry : Form
    {
        INVProductStockWrapper _invProductStockWrapper;
        public frmStockInquiry()
        {
            InitializeComponent();
            _invProductStockWrapper = new INVProductStockWrapper();
        }

        private void frmStockInquiry_Load(object sender, EventArgs e)
        {
            INVInventoryWrapper _inventoryWrapper = new INVInventoryWrapper();
            cmb_Inventory.DataSource = _inventoryWrapper.SelectAll();
            cmb_Inventory.DisplayMember = "InventoryName";
            cmb_Inventory.ValueMember = "InventoryID";
            cmb_Inventory.SelectedIndex = -1;

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (cmb_Inventory.SelectedValue != null && cmb_Inventory.SelectedValue != "")
            {
                dgrid_stock.AutoGenerateColumns = false;
                string code = tbx_ProductCode.Text != "" ? tbx_ProductCode.Text : null;
                string name = tbx_ProductName.Text != "" ? tbx_ProductName.Text : null;
                POS.BusinessLayer.INVProductStockCollection items = _invProductStockWrapper.GetInventoryStock(null, code, name, null, false, (int)cmb_Inventory.SelectedValue);
                dgrid_stock.DataSource = items;
            }
        }

        private void dgrid_stock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgrid_stock_SelectionChanged(object sender, EventArgs e)
        {
            if (dgrid_stock.SelectedRows.Count > 0)
            {
                int _productStockID = (int)dgrid_stock.SelectedRows[0].Cells["col_invProductStock"].Value;
                INVProductStockWrapper _iNVProductStockWrapper;
                _iNVProductStockWrapper = new INVProductStockWrapper();
                dgrid_batches.AutoGenerateColumns = false;
                dgrid_batches.DataSource = _iNVProductStockWrapper.GetInventoryStock(_productStockID, null, null, true, true, (int)cmb_Inventory.SelectedValue);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                List<KeyValuePair<string, object>> paramList = new List<KeyValuePair<string, object>>();
                paramList.Add(new KeyValuePair<string, object>("@InventoryID", Convert.ToInt32(cmb_Inventory.SelectedValue)));


                CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer
                    = Utility.ViewReport("InventoryStock_Report.rpt", paramList);

                frmReportViewer host = new frmReportViewer();
                host.Controls.Add(crystalReportViewer);
                host.Controls["crystalReportViewer1"].Dock = DockStyle.Fill;
                host.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




    }
}
