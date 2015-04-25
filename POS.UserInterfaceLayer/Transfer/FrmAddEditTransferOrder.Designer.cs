namespace POS.UserInterfaceLayer.Transfer
{
    partial class FrmAddEditTransferOrder
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
            this.dtb_Date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_FormHeader = new System.Windows.Forms.Label();
            this.panl_Header = new System.Windows.Forms.Panel();
            this.cbx_StoreFrom = new System.Windows.Forms.ComboBox();
            this.cbx_StoreTo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgrd_OrderLines = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_AddLine = new System.Windows.Forms.Button();
            this.btn_DeleteLine = new System.Windows.Forms.Button();
            this.btn_Minus = new System.Windows.Forms.Button();
            this.btn_Plus = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.panl_Header.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrd_OrderLines)).BeginInit();
            this.SuspendLayout();
            // 
            // dtb_Date
            // 
            this.dtb_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtb_Date.Location = new System.Drawing.Point(98, 64);
            this.dtb_Date.Name = "dtb_Date";
            this.dtb_Date.RightToLeftLayout = true;
            this.dtb_Date.Size = new System.Drawing.Size(243, 20);
            this.dtb_Date.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "التاريخ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "المخزن المحول اليه";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "المخزن المحول منه";
            // 
            // lbl_FormHeader
            // 
            this.lbl_FormHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_FormHeader.AutoSize = true;
            this.lbl_FormHeader.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FormHeader.Location = new System.Drawing.Point(335, 20);
            this.lbl_FormHeader.Name = "lbl_FormHeader";
            this.lbl_FormHeader.Size = new System.Drawing.Size(72, 19);
            this.lbl_FormHeader.TabIndex = 0;
            this.lbl_FormHeader.Text = "فاتورة جديده";
            // 
            // panl_Header
            // 
            this.panl_Header.BackColor = System.Drawing.Color.MintCream;
            this.panl_Header.Controls.Add(this.lbl_FormHeader);
            this.panl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panl_Header.Location = new System.Drawing.Point(0, 0);
            this.panl_Header.Name = "panl_Header";
            this.panl_Header.Size = new System.Drawing.Size(703, 53);
            this.panl_Header.TabIndex = 5;
            // 
            // cbx_StoreFrom
            // 
            this.cbx_StoreFrom.FormattingEnabled = true;
            this.cbx_StoreFrom.Location = new System.Drawing.Point(98, 93);
            this.cbx_StoreFrom.Name = "cbx_StoreFrom";
            this.cbx_StoreFrom.Size = new System.Drawing.Size(241, 21);
            this.cbx_StoreFrom.TabIndex = 6;
            // 
            // cbx_StoreTo
            // 
            this.cbx_StoreTo.FormattingEnabled = true;
            this.cbx_StoreTo.Location = new System.Drawing.Point(455, 93);
            this.cbx_StoreTo.Name = "cbx_StoreTo";
            this.cbx_StoreTo.Size = new System.Drawing.Size(241, 21);
            this.cbx_StoreTo.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgrd_OrderLines);
            this.groupBox1.Controls.Add(this.btn_AddLine);
            this.groupBox1.Controls.Add(this.btn_DeleteLine);
            this.groupBox1.Controls.Add(this.btn_Minus);
            this.groupBox1.Controls.Add(this.btn_Plus);
            this.groupBox1.Location = new System.Drawing.Point(12, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 328);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الفاتورة";
            // 
            // dgrd_OrderLines
            // 
            this.dgrd_OrderLines.AllowUserToAddRows = false;
            this.dgrd_OrderLines.AllowUserToDeleteRows = false;
            this.dgrd_OrderLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrd_OrderLines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.TotalQty});
            this.dgrd_OrderLines.Location = new System.Drawing.Point(6, 56);
            this.dgrd_OrderLines.Name = "dgrd_OrderLines";
            this.dgrd_OrderLines.ReadOnly = true;
            this.dgrd_OrderLines.RowHeadersVisible = false;
            this.dgrd_OrderLines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrd_OrderLines.Size = new System.Drawing.Size(612, 266);
            this.dgrd_OrderLines.TabIndex = 37;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Visible = false;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "أسم المنتج";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 210;
            // 
            // TotalQty
            // 
            this.TotalQty.HeaderText = "الكمية";
            this.TotalQty.Name = "TotalQty";
            this.TotalQty.ReadOnly = true;
            this.TotalQty.Width = 90;
            // 
            // btn_AddLine
            // 
            this.btn_AddLine.Location = new System.Drawing.Point(545, 15);
            this.btn_AddLine.Name = "btn_AddLine";
            this.btn_AddLine.Size = new System.Drawing.Size(75, 35);
            this.btn_AddLine.TabIndex = 36;
            this.btn_AddLine.Text = "أضافة";
            this.btn_AddLine.UseVisualStyleBackColor = true;
            this.btn_AddLine.Click += new System.EventHandler(this.btn_AddLine_Click);
            // 
            // btn_DeleteLine
            // 
            this.btn_DeleteLine.Location = new System.Drawing.Point(462, 15);
            this.btn_DeleteLine.Name = "btn_DeleteLine";
            this.btn_DeleteLine.Size = new System.Drawing.Size(75, 35);
            this.btn_DeleteLine.TabIndex = 35;
            this.btn_DeleteLine.Text = "حذف";
            this.btn_DeleteLine.UseVisualStyleBackColor = true;
            this.btn_DeleteLine.Click += new System.EventHandler(this.btn_DeleteLine_Click);
            // 
            // btn_Minus
            // 
            this.btn_Minus.Location = new System.Drawing.Point(624, 120);
            this.btn_Minus.Name = "btn_Minus";
            this.btn_Minus.Size = new System.Drawing.Size(39, 31);
            this.btn_Minus.TabIndex = 34;
            this.btn_Minus.Text = "-";
            this.btn_Minus.UseVisualStyleBackColor = true;
            this.btn_Minus.Click += new System.EventHandler(this.btn_Minus_Click);
            // 
            // btn_Plus
            // 
            this.btn_Plus.Location = new System.Drawing.Point(624, 81);
            this.btn_Plus.Name = "btn_Plus";
            this.btn_Plus.Size = new System.Drawing.Size(39, 31);
            this.btn_Plus.TabIndex = 33;
            this.btn_Plus.Text = "+";
            this.btn_Plus.UseVisualStyleBackColor = true;
            this.btn_Plus.Click += new System.EventHandler(this.btn_Plus_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(302, 468);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(99, 55);
            this.btn_Save.TabIndex = 17;
            this.btn_Save.Text = "حفظ ";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(409, 468);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(99, 55);
            this.btn_Cancel.TabIndex = 18;
            this.btn_Cancel.Text = "ألغاء";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // FrmAddEditTransferOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(703, 532);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbx_StoreTo);
            this.Controls.Add(this.cbx_StoreFrom);
            this.Controls.Add(this.panl_Header);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtb_Date);
            this.Name = "FrmAddEditTransferOrder";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "شاشة التحويل";
            this.panl_Header.ResumeLayout(false);
            this.panl_Header.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrd_OrderLines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtb_Date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label lbl_FormHeader;
        protected System.Windows.Forms.Panel panl_Header;
        private System.Windows.Forms.ComboBox cbx_StoreFrom;
        private System.Windows.Forms.ComboBox cbx_StoreTo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_AddLine;
        private System.Windows.Forms.Button btn_DeleteLine;
        private System.Windows.Forms.Button btn_Minus;
        private System.Windows.Forms.Button btn_Plus;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.DataGridView dgrd_OrderLines;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalQty;
    }
}