namespace POS.UserInterfaceLayer.BasicData
{
    partial class FrmAdjustStockAddEdit
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
            this.cbx_StockTypeTO = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_AdjustReason = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgrid_batches = new System.Windows.Forms.DataGridView();
            this.dgrid_stock = new System.Windows.Forms.DataGridView();
            this.col_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_invProductStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_StockTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stockType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbx_Store = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.num_Qty = new System.Windows.Forms.NumericUpDown();
            this.col_batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_expiry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_batchQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panl_Header.SuspendLayout();
            this.panl_Footer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_batches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Qty)).BeginInit();
            this.SuspendLayout();
            // 
            // panl_Header
            // 
            this.panl_Header.Size = new System.Drawing.Size(962, 53);
            // 
            // lbl_FormHeader
            // 
            this.lbl_FormHeader.Location = new System.Drawing.Point(7135, 21);
            // 
            // panl_Footer
            // 
            this.panl_Footer.Location = new System.Drawing.Point(0, 413);
            this.panl_Footer.Size = new System.Drawing.Size(962, 62);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Save.Location = new System.Drawing.Point(540, 3);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(340, 3);
            // 
            // cbx_StockTypeTO
            // 
            this.cbx_StockTypeTO.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbx_StockTypeTO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_StockTypeTO.FormattingEnabled = true;
            this.cbx_StockTypeTO.Location = new System.Drawing.Point(135, 222);
            this.cbx_StockTypeTO.Name = "cbx_StockTypeTO";
            this.cbx_StockTypeTO.Size = new System.Drawing.Size(241, 24);
            this.cbx_StockTypeTO.TabIndex = 76;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 75;
            this.label6.Text = "تحويل الى";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 71;
            this.label4.Text = "الكمية";
            // 
            // cbx_AdjustReason
            // 
            this.cbx_AdjustReason.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbx_AdjustReason.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_AdjustReason.FormattingEnabled = true;
            this.cbx_AdjustReason.Location = new System.Drawing.Point(135, 146);
            this.cbx_AdjustReason.Name = "cbx_AdjustReason";
            this.cbx_AdjustReason.Size = new System.Drawing.Size(241, 24);
            this.cbx_AdjustReason.TabIndex = 70;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgrid_batches);
            this.groupBox1.Controls.Add(this.dgrid_stock);
            this.groupBox1.Location = new System.Drawing.Point(391, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 320);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الباتشات";
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
            this.dgrid_batches.Location = new System.Drawing.Point(3, 193);
            this.dgrid_batches.Name = "dgrid_batches";
            this.dgrid_batches.ReadOnly = true;
            this.dgrid_batches.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgrid_batches.Size = new System.Drawing.Size(562, 124);
            this.dgrid_batches.TabIndex = 5;
            // 
            // dgrid_stock
            // 
            this.dgrid_stock.AllowUserToAddRows = false;
            this.dgrid_stock.AllowUserToDeleteRows = false;
            this.dgrid_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_stock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_code,
            this.col_invProductStock,
            this.col_name,
            this.col_StockTypeID,
            this.col_stockType,
            this.col_qty});
            this.dgrid_stock.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgrid_stock.Location = new System.Drawing.Point(3, 18);
            this.dgrid_stock.Name = "dgrid_stock";
            this.dgrid_stock.ReadOnly = true;
            this.dgrid_stock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgrid_stock.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgrid_stock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_stock.Size = new System.Drawing.Size(562, 169);
            this.dgrid_stock.TabIndex = 4;
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
            // col_StockTypeID
            // 
            this.col_StockTypeID.DataPropertyName = "StockTypeID";
            this.col_StockTypeID.HeaderText = "StockTypeID";
            this.col_StockTypeID.Name = "col_StockTypeID";
            this.col_StockTypeID.ReadOnly = true;
            this.col_StockTypeID.Visible = false;
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
            // cbx_Store
            // 
            this.cbx_Store.FormattingEnabled = true;
            this.cbx_Store.Location = new System.Drawing.Point(135, 101);
            this.cbx_Store.Name = "cbx_Store";
            this.cbx_Store.Size = new System.Drawing.Size(241, 24);
            this.cbx_Store.TabIndex = 66;
            this.cbx_Store.SelectedIndexChanged += new System.EventHandler(this.cbx_Store_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 65;
            this.label3.Text = "المخزن ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 64;
            this.label1.Text = "سبب التسويه";
            // 
            // num_Qty
            // 
            this.num_Qty.Location = new System.Drawing.Point(135, 186);
            this.num_Qty.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.num_Qty.Name = "num_Qty";
            this.num_Qty.Size = new System.Drawing.Size(241, 22);
            this.num_Qty.TabIndex = 77;
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
            // FrmAdjustStockAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(962, 475);
            this.Controls.Add(this.num_Qty);
            this.Controls.Add(this.cbx_StockTypeTO);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbx_AdjustReason);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbx_Store);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FrmAdjustStockAddEdit";
            this.Load += new System.EventHandler(this.FrmAdjustStockAddEdit_Load);
            this.Controls.SetChildIndex(this.panl_Header, 0);
            this.Controls.SetChildIndex(this.panl_Footer, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.cbx_Store, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.cbx_AdjustReason, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.cbx_StockTypeTO, 0);
            this.Controls.SetChildIndex(this.num_Qty, 0);
            this.panl_Header.ResumeLayout(false);
            this.panl_Header.PerformLayout();
            this.panl_Footer.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_batches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Qty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_StockTypeTO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_AdjustReason;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbx_Store;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgrid_batches;
        private System.Windows.Forms.DataGridView dgrid_stock;
        private System.Windows.Forms.NumericUpDown num_Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_invProductStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_StockTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stockType;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_batch;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_expiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_batchQty;
    }
}
