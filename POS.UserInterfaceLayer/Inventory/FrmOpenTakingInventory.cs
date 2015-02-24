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

namespace POS.UserInterfaceLayer.Inventory
{
    public partial class FrmOpenTakingInventory : Form
    {
        public FrmOpenTakingInventory()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_newTaking_Click(object sender, EventArgs e)
        {
            ResetFields();
        }

        private void ResetFields()
        {
            tbx_takingName.Text = string.Empty;
            dtp_takingDate.Value = DateTime.Now;
            cmb_Product.SelectedIndex = -1;
            cmb_productGroup.SelectedIndex = -1;
            cmb_inventory.SelectedIndex = -1;
            tbx_notes.Text = string.Empty;
        }

        private void FrmOpenTakingInventory_Load(object sender, EventArgs e)
        {
            INVInventoryService inventoryService=new INVInventoryService ();
            cmb_inventory.DataSource = inventoryService.SelectAll();
            cmb_inventory.DisplayMember = "InventoryName";
            cmb_inventory.ValueMember= "InventoryID";

            BDProductService productService = new BDProductService();
            cmb_Product.DataSource = productService.SelectAll();
            cmb_Product.DisplayMember = "ProductName";
            cmb_Product.ValueMember = "ProductID";

            BDProductGroupService productGroupService = new BDProductGroupService();
            cmb_productGroup.DataSource = productGroupService.SelectAll();
            cmb_productGroup.DisplayMember = "ProductGroupName";
            cmb_productGroup.ValueMember = "ProductGroupID";

            ResetFields();
        }

        private void ridb_Product_CheckedChanged(object sender, EventArgs e)
        {
            cmb_Product.Enabled = ridb_Product.Checked;
        }

        private void ridb_ProductGroup_CheckedChanged(object sender, EventArgs e)
        {
            cmb_productGroup.Enabled = ridb_ProductGroup.Checked;
        }

        
    }
}
