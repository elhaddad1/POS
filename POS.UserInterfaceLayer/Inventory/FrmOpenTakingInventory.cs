using POS.BusinessLayer;
using POS.BusinessLayer.Wrapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                INVTakingInventoryLineWrapper _TakingInventoryWrapper = new INVTakingInventoryLineWrapper();
                int takingType = 0;
                if (ridb_Product.Checked)
                    takingType = 1;
                else if (ridb_ProductGroup.Checked)
                    takingType = 2;

                int? _productID = (cmb_Product.SelectedValue != null) ? cmb_Product.SelectedValue as int? : null;
                int? _productGroupID = (cmb_productGroup.SelectedValue != null) ? cmb_productGroup.SelectedValue as int? : null;

                try
                {
                    bool result = _TakingInventoryWrapper.OpenTakingInventory(tbx_takingName.Text, dtp_takingDate.Value, (int)cmb_inventory.SelectedValue,
                                                                   takingType, _productID, _productGroupID, tbx_notes.Text);

                    if (result == false)
                    {
                        MessageBox.Show("حدث خطأ يرجي المحاوله مره اخري");
                    }
                    else
                    {
                        MessageBox.Show("تم فتح الجرد بنجاح");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                
            }
        }
        private bool Validate()
        {
            if (tbx_takingName.Text  == "")
            {
                MessageBox.Show("لابد من إدخال اسم الجرد");
                return false;
            }
            else if (cmb_inventory .SelectedValue == null || cmb_inventory .SelectedValue=="" )
            {
                MessageBox.Show("لابد من اختيار اسم المخزن");
                return false;
            }
            else
            {
                return true;
            }
        }
        
    }
}
