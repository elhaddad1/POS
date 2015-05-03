namespace POS.UserInterfaceLayer.Inventory
{
    partial class frmStockInquiry
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
            this.grb_Search = new System.Windows.Forms.GroupBox();
            this.tbx_ProductName = new System.Windows.Forms.TextBox();
            this.tbx_ProductCode = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgrid_stock = new System.Windows.Forms.DataGridView();
            this.col_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_invProductStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stockType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgrid_batches = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Inventory = new System.Windows.Forms.ComboBox();
            this.col_batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_expiry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_batchQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_batches)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "الاستعلام عن مخزون";
            // 
            // grb_Search
            // 
            this.grb_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_Search.Controls.Add(this.cmb_Inventory);
            this.grb_Search.Controls.Add(this.label4);
            this.grb_Search.Controls.Add(this.tbx_ProductName);
            this.grb_Search.Controls.Add(this.tbx_ProductCode);
            this.grb_Search.Controls.Add(this.btn_Search);
            this.grb_Search.Controls.Add(this.label3);
            this.grb_Search.Controls.Add(this.label2);
            this.grb_Search.Location = new System.Drawing.Point(0, 50);
            this.grb_Search.Name = "grb_Search";
            this.grb_Search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grb_Search.Size = new System.Drawing.Size(784, 138);
            this.grb_Search.TabIndex = 1;
            this.grb_Search.TabStop = false;
            this.grb_Search.Text = "بحث";
            // 
            // tbx_ProductName
            // 
            this.tbx_ProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_ProductName.Location = new System.Drawing.Point(498, 96);
            this.tbx_ProductName.Name = "tbx_ProductName";
            this.tbx_ProductName.Size = new System.Drawing.Size(167, 20);
            this.tbx_ProductName.TabIndex = 4;
            // 
            // tbx_ProductCode
            // 
            this.tbx_ProductCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_ProductCode.Location = new System.Drawing.Point(498, 61);
            this.tbx_ProductCode.Name = "tbx_ProductCode";
            this.tbx_ProductCode.Size = new System.Drawing.Size(167, 20);
            this.tbx_ProductCode.TabIndex = 3;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Search.Location = new System.Drawing.Point(42, 109);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "بحث";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(704, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "إسم المنتج";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(704, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "كود المنتج";
            // 
            // dgrid_stock
            // 
            this.dgrid_stock.AllowUserToAddRows = false;
            this.dgrid_stock.AllowUserToDeleteRows = false;
            this.dgrid_stock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrid_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_stock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_code,
            this.col_invProductStock,
            this.col_name,
            this.col_stockType,
            this.col_qty});
            this.dgrid_stock.Location = new System.Drawing.Point(0, 194);
            this.dgrid_stock.Name = "dgrid_stock";
            this.dgrid_stock.ReadOnly = true;
            this.dgrid_stock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgrid_stock.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgrid_stock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_stock.Size = new System.Drawing.Size(784, 266);
            this.dgrid_stock.TabIndex = 2;
            this.dgrid_stock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_stock_CellContentClick);
            this.dgrid_stock.SelectionChanged += new System.EventHandler(this.dgrid_stock_SelectionChanged);
            // 
            // col_code
            // 
            this.col_code.DataPropertyName = "ProductCode";
            this.col_code.HeaderText = "كود المنتج";
            this.col_code.Name = "col_code";
            this.col_code.ReadOnly = true;
            // 
            // col_invProductStock
            // 
            this.col_invProductStock.DataPropertyName = "ProductStockID";
            this.col_invProductStock.HeaderText = "Column1";
            this.col_invProductStock.Name = "col_invProductStock";
            this.col_invProductStock.ReadOnly = true;
            this.col_invProductStock.Visible = false;
            // 
            // col_name
            // 
            this.col_name.DataPropertyName = "ProductName";
            this.col_name.HeaderText = "اسم المنتج";
            this.col_name.Name = "col_name";
            this.col_name.ReadOnly = true;
            this.col_name.Width = 200;
            // 
            // col_stockType
            // 
            this.col_stockType.DataPropertyName = "StockType";
            this.col_stockType.HeaderText = "نوع المخزون";
            this.col_stockType.Name = "col_stockType";
            this.col_stockType.ReadOnly = true;
            // 
            // col_qty
            // 
            this.col_qty.DataPropertyName = "TotalQty";
            this.col_qty.HeaderText = "الكميه";
            this.col_qty.Name = "col_qty";
            this.col_qty.ReadOnly = true;
            // 
            // dgrid_batches
            // 
            this.dgrid_batches.AllowUserToAddRows = false;
            this.dgrid_batches.AllowUserToDeleteRows = false;
            this.dgrid_batches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_batches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_batch,
            this.col_expiry,
            this.col_batchQty});
            this.dgrid_batches.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_batches.Location = new System.Drawing.Point(0, 460);
            this.dgrid_batches.Name = "dgrid_batches";
            this.dgrid_batches.ReadOnly = true;
            this.dgrid_batches.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgrid_batches.Size = new System.Drawing.Size(784, 133);
            this.dgrid_batches.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(704, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "المخزن";
            // 
            // cmb_Inventory
            // 
            this.cmb_Inventory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Inventory.FormattingEnabled = true;
            this.cmb_Inventory.Location = new System.Drawing.Point(498, 23);
            this.cmb_Inventory.Name = "cmb_Inventory";
            this.cmb_Inventory.Size = new System.Drawing.Size(167, 21);
            this.cmb_Inventory.TabIndex = 6;
            // 
            // col_batch
            // 
            this.col_batch.DataPropertyName = "BatchNo";
            this.col_batch.HeaderText = "رقم التشغيله";
            this.col_batch.Name = "col_batch";
            this.col_batch.ReadOnly = true;
            // 
            // col_expiry
            // 
            this.col_expiry.DataPropertyName = "ExpiryDate";
            this.col_expiry.HeaderText = "تاريخ الصلاحيه";
            this.col_expiry.Name = "col_expiry";
            this.col_expiry.ReadOnly = true;
            // 
            // col_batchQty
            // 
            this.col_batchQty.DataPropertyName = "BatchQty";
            this.col_batchQty.HeaderText = "الكميه";
            this.col_batchQty.Name = "col_batchQty";
            this.col_batchQty.ReadOnly = true;
            // 
            // frmStockInquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 593);
            this.Controls.Add(this.dgrid_batches);
            this.Controls.Add(this.dgrid_stock);
            this.Controls.Add(this.grb_Search);
            this.Controls.Add(this.label1);
            this.Name = "frmStockInquiry";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "الاستعلام عن مخزون";
            this.Load += new System.EventHandler(this.frmStockInquiry_Load);
            this.grb_Search.ResumeLayout(false);
            this.grb_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_batches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grb_Search;
        private System.Windows.Forms.DataGridView dgrid_stock;
        private System.Windows.Forms.TextBox tbx_ProductName;
        private System.Windows.Forms.TextBox tbx_ProductCode;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgrid_batches;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_invProductStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stockType;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_qty;
        private System.Windows.Forms.ComboBox cmb_Inventory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_batch;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_expiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_batchQty;
    }
}