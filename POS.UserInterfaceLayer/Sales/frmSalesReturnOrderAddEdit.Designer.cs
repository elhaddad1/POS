namespace POS.UserInterfaceLayer.Sales
{
    partial class frmSalesReturnOrderAddEdit
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
            this.lbl_FormHeader = new System.Windows.Forms.Label();
            this.panl_Header = new System.Windows.Forms.Panel();
            this.tbx_Total = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_ClosePrint = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgrd_ReturnOrderLines = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IsAcceptBatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtb_InvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.tbx_CustomerName = new System.Windows.Forms.TextBox();
            this.tbx_InvoiceNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtb_SalesDate = new System.Windows.Forms.DateTimePicker();
            this.tbx_SalesMan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.cbx_Inventory = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panl_Header.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrd_ReturnOrderLines)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_FormHeader
            // 
            this.lbl_FormHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_FormHeader.AutoSize = true;
            this.lbl_FormHeader.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FormHeader.Location = new System.Drawing.Point(336, 20);
            this.lbl_FormHeader.Name = "lbl_FormHeader";
            this.lbl_FormHeader.Size = new System.Drawing.Size(79, 19);
            this.lbl_FormHeader.TabIndex = 0;
            this.lbl_FormHeader.Text = "مرتجع فاتورة";
            // 
            // panl_Header
            // 
            this.panl_Header.BackColor = System.Drawing.Color.MintCream;
            this.panl_Header.Controls.Add(this.lbl_FormHeader);
            this.panl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panl_Header.Location = new System.Drawing.Point(0, 0);
            this.panl_Header.Name = "panl_Header";
            this.panl_Header.Size = new System.Drawing.Size(704, 53);
            this.panl_Header.TabIndex = 6;
            // 
            // tbx_Total
            // 
            this.tbx_Total.Enabled = false;
            this.tbx_Total.Location = new System.Drawing.Point(521, 213);
            this.tbx_Total.Name = "tbx_Total";
            this.tbx_Total.ReadOnly = true;
            this.tbx_Total.Size = new System.Drawing.Size(95, 20);
            this.tbx_Total.TabIndex = 30;
            this.tbx_Total.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(623, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "المجموع";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(410, 421);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(99, 55);
            this.btn_Cancel.TabIndex = 41;
            this.btn_Cancel.Text = "ألغاء";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(303, 421);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(99, 55);
            this.btn_Save.TabIndex = 40;
            this.btn_Save.Text = "حفظ فقط";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_ClosePrint
            // 
            this.btn_ClosePrint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ClosePrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClosePrint.Location = new System.Drawing.Point(196, 421);
            this.btn_ClosePrint.Name = "btn_ClosePrint";
            this.btn_ClosePrint.Size = new System.Drawing.Size(99, 55);
            this.btn_ClosePrint.TabIndex = 39;
            this.btn_ClosePrint.Text = "أغلاق ";
            this.btn_ClosePrint.UseVisualStyleBackColor = true;
            this.btn_ClosePrint.Click += new System.EventHandler(this.btn_ClosePrint_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgrd_ReturnOrderLines);
            this.groupBox1.Controls.Add(this.tbx_Total);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(2, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 246);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "المرتجعات";
            // 
            // dgrd_ReturnOrderLines
            // 
            this.dgrd_ReturnOrderLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrd_ReturnOrderLines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.IsAcceptBatch,
            this.ExpiryDate,
            this.BatchNumber,
            this.TotalQty,
            this.UnitPrice,
            this.Reason});
            this.dgrd_ReturnOrderLines.Location = new System.Drawing.Point(10, 19);
            this.dgrd_ReturnOrderLines.Name = "dgrd_ReturnOrderLines";
            this.dgrd_ReturnOrderLines.RowHeadersVisible = false;
            this.dgrd_ReturnOrderLines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrd_ReturnOrderLines.Size = new System.Drawing.Size(686, 187);
            this.dgrd_ReturnOrderLines.TabIndex = 32;
            this.dgrd_ReturnOrderLines.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrd_ReturnOrderLines_CellValueChanged);
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "الصنف";
            this.ProductName.Name = "ProductName";
            this.ProductName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ProductName.Width = 210;
            // 
            // IsAcceptBatch
            // 
            this.IsAcceptBatch.HeaderText = "يقبل رقم تشغيلة";
            this.IsAcceptBatch.Name = "IsAcceptBatch";
            // 
            // ExpiryDate
            // 
            this.ExpiryDate.HeaderText = "تاريخ الصلاحية yyyy-mm-dd";
            this.ExpiryDate.Name = "ExpiryDate";
            this.ExpiryDate.Width = 150;
            // 
            // BatchNumber
            // 
            this.BatchNumber.HeaderText = "رقم الشتغيلة";
            this.BatchNumber.Name = "BatchNumber";
            // 
            // TotalQty
            // 
            this.TotalQty.HeaderText = "الكمية";
            this.TotalQty.Name = "TotalQty";
            this.TotalQty.Width = 90;
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "السعر المباع به";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Width = 120;
            // 
            // Reason
            // 
            this.Reason.HeaderText = "سبب الرجوع";
            this.Reason.Name = "Reason";
            this.Reason.Width = 300;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "أسم العميل";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "تاريخ الفاتورة";
            // 
            // dtb_InvoiceDate
            // 
            this.dtb_InvoiceDate.Enabled = false;
            this.dtb_InvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtb_InvoiceDate.Location = new System.Drawing.Point(434, 97);
            this.dtb_InvoiceDate.Name = "dtb_InvoiceDate";
            this.dtb_InvoiceDate.RightToLeftLayout = true;
            this.dtb_InvoiceDate.Size = new System.Drawing.Size(243, 20);
            this.dtb_InvoiceDate.TabIndex = 26;
            // 
            // tbx_CustomerName
            // 
            this.tbx_CustomerName.Enabled = false;
            this.tbx_CustomerName.Location = new System.Drawing.Point(95, 97);
            this.tbx_CustomerName.Name = "tbx_CustomerName";
            this.tbx_CustomerName.ReadOnly = true;
            this.tbx_CustomerName.Size = new System.Drawing.Size(243, 20);
            this.tbx_CustomerName.TabIndex = 42;
            // 
            // tbx_InvoiceNumber
            // 
            this.tbx_InvoiceNumber.Location = new System.Drawing.Point(95, 59);
            this.tbx_InvoiceNumber.Name = "tbx_InvoiceNumber";
            this.tbx_InvoiceNumber.Size = new System.Drawing.Size(243, 20);
            this.tbx_InvoiceNumber.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "مسلسل الفاتورة";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "تاريخ البيع";
            // 
            // dtb_SalesDate
            // 
            this.dtb_SalesDate.Enabled = false;
            this.dtb_SalesDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtb_SalesDate.Location = new System.Drawing.Point(95, 133);
            this.dtb_SalesDate.Name = "dtb_SalesDate";
            this.dtb_SalesDate.RightToLeftLayout = true;
            this.dtb_SalesDate.Size = new System.Drawing.Size(243, 20);
            this.dtb_SalesDate.TabIndex = 45;
            // 
            // tbx_SalesMan
            // 
            this.tbx_SalesMan.Location = new System.Drawing.Point(434, 133);
            this.tbx_SalesMan.Name = "tbx_SalesMan";
            this.tbx_SalesMan.ReadOnly = true;
            this.tbx_SalesMan.Size = new System.Drawing.Size(243, 20);
            this.tbx_SalesMan.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "البائع";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(356, 58);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(61, 23);
            this.btn_Search.TabIndex = 49;
            this.btn_Search.Text = "بحث";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // cbx_Inventory
            // 
            this.cbx_Inventory.FormattingEnabled = true;
            this.cbx_Inventory.Location = new System.Drawing.Point(480, 59);
            this.cbx_Inventory.Name = "cbx_Inventory";
            this.cbx_Inventory.Size = new System.Drawing.Size(197, 21);
            this.cbx_Inventory.TabIndex = 51;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(437, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 50;
            this.label12.Text = "المخزن";
            // 
            // frmSalesReturnOrderAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(704, 486);
            this.ControlBox = false;
            this.Controls.Add(this.cbx_Inventory);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tbx_SalesMan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtb_SalesDate);
            this.Controls.Add(this.tbx_InvoiceNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_CustomerName);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_ClosePrint);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtb_InvoiceDate);
            this.Controls.Add(this.panl_Header);
            this.Name = "frmSalesReturnOrderAddEdit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مرتج فاتورة";
            this.panl_Header.ResumeLayout(false);
            this.panl_Header.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrd_ReturnOrderLines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label lbl_FormHeader;
        protected System.Windows.Forms.Panel panl_Header;
        private System.Windows.Forms.TextBox tbx_Total;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_ClosePrint;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgrd_ReturnOrderLines;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtb_InvoiceDate;
        private System.Windows.Forms.TextBox tbx_CustomerName;
        private System.Windows.Forms.TextBox tbx_InvoiceNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtb_SalesDate;
        private System.Windows.Forms.TextBox tbx_SalesMan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridViewComboBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsAcceptBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason;
        private System.Windows.Forms.ComboBox cbx_Inventory;
        private System.Windows.Forms.Label label12;
    }
}