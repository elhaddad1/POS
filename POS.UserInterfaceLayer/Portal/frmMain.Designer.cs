namespace POS.UserInterfaceLayer.Portal
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnu_MainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuItem_Administration = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem_UserGroups = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem_BasicData = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem_Customers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem_Products = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem_ProductGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem_Suppliers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem_Inventory = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.mnu_MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnu_MainMenu
            // 
            this.mnu_MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItem_Administration,
            this.mnuItem_BasicData});
            this.mnu_MainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnu_MainMenu.Name = "mnu_MainMenu";
            this.mnu_MainMenu.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.mnu_MainMenu.Size = new System.Drawing.Size(776, 25);
            this.mnu_MainMenu.TabIndex = 0;
            this.mnu_MainMenu.Text = "menuStrip1";
            // 
            // mnuItem_Administration
            // 
            this.mnuItem_Administration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItem_UserGroups});
            this.mnuItem_Administration.Enabled = false;
            this.mnuItem_Administration.Name = "mnuItem_Administration";
            this.mnuItem_Administration.Size = new System.Drawing.Size(71, 19);
            this.mnuItem_Administration.Text = "المستخدمين";
            // 
            // mnuItem_UserGroups
            // 
            this.mnuItem_UserGroups.Enabled = false;
            this.mnuItem_UserGroups.Name = "mnuItem_UserGroups";
            this.mnuItem_UserGroups.Size = new System.Drawing.Size(170, 22);
            this.mnuItem_UserGroups.Text = "مجموعات المستخدمين";
            this.mnuItem_UserGroups.Click += new System.EventHandler(this.mnuItem_UserGroups_Click);
            // 
            // mnuItem_BasicData
            // 
            this.mnuItem_BasicData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItem_Customers,
            this.mnuItem_Products,
            this.mnuItem_ProductGroup,
            this.mnuItem_Suppliers,
            this.mnuItem_Inventory});
            this.mnuItem_BasicData.Enabled = false;
            this.mnuItem_BasicData.Name = "mnuItem_BasicData";
            this.mnuItem_BasicData.Size = new System.Drawing.Size(95, 19);
            this.mnuItem_BasicData.Text = "البيانات الرئيسية";
            // 
            // mnuItem_Customers
            // 
            this.mnuItem_Customers.Enabled = false;
            this.mnuItem_Customers.Name = "mnuItem_Customers";
            this.mnuItem_Customers.Size = new System.Drawing.Size(149, 22);
            this.mnuItem_Customers.Text = "بيانات العملاء";
            this.mnuItem_Customers.Click += new System.EventHandler(this.mnuItem_Customers_Click);
            // 
            // mnuItem_Products
            // 
            this.mnuItem_Products.Enabled = false;
            this.mnuItem_Products.Name = "mnuItem_Products";
            this.mnuItem_Products.Size = new System.Drawing.Size(149, 22);
            this.mnuItem_Products.Text = "الاصناف";
            this.mnuItem_Products.Click += new System.EventHandler(this.mnuItem_Products_Click);
            // 
            // mnuItem_ProductGroup
            // 
            this.mnuItem_ProductGroup.Enabled = false;
            this.mnuItem_ProductGroup.Name = "mnuItem_ProductGroup";
            this.mnuItem_ProductGroup.Size = new System.Drawing.Size(149, 22);
            this.mnuItem_ProductGroup.Text = "مجموعة الاصناف";
            this.mnuItem_ProductGroup.Click += new System.EventHandler(this.mnuItem_ProductGroup_Click);
            // 
            // mnuItem_Suppliers
            // 
            this.mnuItem_Suppliers.Enabled = false;
            this.mnuItem_Suppliers.Name = "mnuItem_Suppliers";
            this.mnuItem_Suppliers.Size = new System.Drawing.Size(149, 22);
            this.mnuItem_Suppliers.Text = "بيانات الموردين";
            this.mnuItem_Suppliers.Click += new System.EventHandler(this.mnuItem_Suppliers_Click);
            // 
            // mnuItem_Inventory
            // 
            this.mnuItem_Inventory.Enabled = false;
            this.mnuItem_Inventory.Name = "mnuItem_Inventory";
            this.mnuItem_Inventory.Size = new System.Drawing.Size(149, 22);
            this.mnuItem_Inventory.Text = "المخازن";
            this.mnuItem_Inventory.Click += new System.EventHandler(this.mnuItem_Inventory_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 25);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(776, 403);
            this.pnlContent.TabIndex = 6;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(776, 428);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.mnu_MainMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mnu_MainMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "برنامج المخازن";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnu_MainMenu.ResumeLayout(false);
            this.mnu_MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnu_MainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_BasicData;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_Customers;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_Administration;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_UserGroups;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_Products;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_ProductGroup;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_Suppliers;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_Inventory;
        private System.Windows.Forms.Panel pnlContent;
    }
}