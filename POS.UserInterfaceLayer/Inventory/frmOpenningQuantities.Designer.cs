namespace POS.UserInterfaceLayer.Inventory
{
    partial class frmOpenningQuantities
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_FormHeader = new System.Windows.Forms.Label();
            this.panl_Header = new System.Windows.Forms.Panel();
            this.cbx_Inventory = new System.Windows.Forms.ComboBox();
            this.dgrd_OpeningStockProducts = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsAcceptBatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Batches = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.panl_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrd_OpeningStockProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "المخزن";
            // 
            // lbl_FormHeader
            // 
            this.lbl_FormHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_FormHeader.AutoSize = true;
            this.lbl_FormHeader.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FormHeader.Location = new System.Drawing.Point(291, 25);
            this.lbl_FormHeader.Name = "lbl_FormHeader";
            this.lbl_FormHeader.Size = new System.Drawing.Size(91, 19);
            this.lbl_FormHeader.TabIndex = 0;
            this.lbl_FormHeader.Text = "الرصيد الأفتاحى";
            // 
            // panl_Header
            // 
            this.panl_Header.BackColor = System.Drawing.Color.MintCream;
            this.panl_Header.Controls.Add(this.lbl_FormHeader);
            this.panl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panl_Header.Location = new System.Drawing.Point(0, 0);
            this.panl_Header.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panl_Header.Name = "panl_Header";
            this.panl_Header.Size = new System.Drawing.Size(626, 65);
            this.panl_Header.TabIndex = 3;
            // 
            // cbx_Inventory
            // 
            this.cbx_Inventory.FormattingEnabled = true;
            this.cbx_Inventory.Location = new System.Drawing.Point(211, 82);
            this.cbx_Inventory.Name = "cbx_Inventory";
            this.cbx_Inventory.Size = new System.Drawing.Size(255, 21);
            this.cbx_Inventory.TabIndex = 4;
            this.cbx_Inventory.SelectedIndexChanged += new System.EventHandler(this.cbx_Inventory_SelectedIndexChanged);
            // 
            // dgrd_OpeningStockProducts
            // 
            this.dgrd_OpeningStockProducts.AllowUserToAddRows = false;
            this.dgrd_OpeningStockProducts.AllowUserToDeleteRows = false;
            this.dgrd_OpeningStockProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrd_OpeningStockProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductCode,
            this.ProductName,
            this.TotalQty,
            this.IsAcceptBatch,
            this.btn_Batches});
            this.dgrd_OpeningStockProducts.Location = new System.Drawing.Point(0, 116);
            this.dgrd_OpeningStockProducts.Name = "dgrd_OpeningStockProducts";
            this.dgrd_OpeningStockProducts.RowHeadersVisible = false;
            this.dgrd_OpeningStockProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrd_OpeningStockProducts.Size = new System.Drawing.Size(626, 315);
            this.dgrd_OpeningStockProducts.TabIndex = 5;
            this.dgrd_OpeningStockProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrd_OpeningStockProducts_CellContentClick);
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "";
            this.ProductID.Name = "ProductID";
            this.ProductID.Visible = false;
            // 
            // ProductCode
            // 
            this.ProductCode.HeaderText = "كود المنتج";
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "أسم المنتج";
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 220;
            // 
            // TotalQty
            // 
            this.TotalQty.HeaderText = "الكمية";
            this.TotalQty.Name = "TotalQty";
            // 
            // IsAcceptBatch
            // 
            this.IsAcceptBatch.HeaderText = "يقبل تشغيلة";
            this.IsAcceptBatch.Name = "IsAcceptBatch";
            this.IsAcceptBatch.ReadOnly = true;
            // 
            // btn_Batches
            // 
            this.btn_Batches.HeaderText = "التشغيلات";
            this.btn_Batches.Name = "btn_Batches";
            this.btn_Batches.ReadOnly = true;
            this.btn_Batches.Text = "التشغيلات";
            this.btn_Batches.UseColumnTextForButtonValue = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(198, 446);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(104, 48);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "حفظ";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(325, 446);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(104, 48);
            this.btn_Back.TabIndex = 8;
            this.btn_Back.Text = "رجوع";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // frmOpenningQuantities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(626, 497);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.dgrd_OpeningStockProducts);
            this.Controls.Add(this.cbx_Inventory);
            this.Controls.Add(this.panl_Header);
            this.Controls.Add(this.label1);
            this.Name = "frmOpenningQuantities";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الرصيد الأفتتاحى";
            this.panl_Header.ResumeLayout(false);
            this.panl_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrd_OpeningStockProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label lbl_FormHeader;
        protected System.Windows.Forms.Panel panl_Header;
        private System.Windows.Forms.ComboBox cbx_Inventory;
        private System.Windows.Forms.DataGridView dgrd_OpeningStockProducts;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsAcceptBatch;
        private System.Windows.Forms.DataGridViewButtonColumn btn_Batches;
    }
}