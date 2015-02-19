namespace POS.UserInterfaceLayer.Sales
{
    partial class frmSalesOrderAddEdit
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
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_FormHeader = new System.Windows.Forms.Label();
            this.panl_Header = new System.Windows.Forms.Panel();
            this.cbx_Customer = new System.Windows.Forms.ComboBox();
            this.cbx_PaymentType = new System.Windows.Forms.ComboBox();
            this.num_Paied = new System.Windows.Forms.NumericUpDown();
            this.num_Remaining = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtb_LastTimeToPay = new System.Windows.Forms.DateTimePicker();
            this.cbx_TaxType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_AddLine = new System.Windows.Forms.Button();
            this.btn_DeleteLine = new System.Windows.Forms.Button();
            this.btn_Minus = new System.Windows.Forms.Button();
            this.btn_Plus = new System.Windows.Forms.Button();
            this.dgrd_OrderLines = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_DiscountRatio = new System.Windows.Forms.TextBox();
            this.txt_DiscountAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_ClosePrint = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.num_OtherPayments = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panl_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Paied)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Remaining)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrd_OrderLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_OtherPayments)).BeginInit();
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
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "طريقة الدفع";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "أسم العميل";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "المدفوع";
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
            // cbx_Customer
            // 
            this.cbx_Customer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbx_Customer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_Customer.FormattingEnabled = true;
            this.cbx_Customer.Location = new System.Drawing.Point(98, 93);
            this.cbx_Customer.Name = "cbx_Customer";
            this.cbx_Customer.Size = new System.Drawing.Size(241, 21);
            this.cbx_Customer.TabIndex = 6;
            // 
            // cbx_PaymentType
            // 
            this.cbx_PaymentType.FormattingEnabled = true;
            this.cbx_PaymentType.Location = new System.Drawing.Point(455, 93);
            this.cbx_PaymentType.Name = "cbx_PaymentType";
            this.cbx_PaymentType.Size = new System.Drawing.Size(241, 21);
            this.cbx_PaymentType.TabIndex = 7;
            // 
            // num_Paied
            // 
            this.num_Paied.Location = new System.Drawing.Point(98, 122);
            this.num_Paied.Name = "num_Paied";
            this.num_Paied.Size = new System.Drawing.Size(78, 20);
            this.num_Paied.TabIndex = 8;
            // 
            // num_Remaining
            // 
            this.num_Remaining.Location = new System.Drawing.Point(260, 122);
            this.num_Remaining.Name = "num_Remaining";
            this.num_Remaining.Size = new System.Drawing.Size(78, 20);
            this.num_Remaining.TabIndex = 10;
            this.num_Remaining.Leave += new System.EventHandler(this.num_Remaining_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "المتبقى";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "أخر ميعاد للدفع";
            // 
            // dtb_LastTimeToPay
            // 
            this.dtb_LastTimeToPay.Enabled = false;
            this.dtb_LastTimeToPay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtb_LastTimeToPay.Location = new System.Drawing.Point(453, 122);
            this.dtb_LastTimeToPay.Name = "dtb_LastTimeToPay";
            this.dtb_LastTimeToPay.RightToLeftLayout = true;
            this.dtb_LastTimeToPay.Size = new System.Drawing.Size(243, 20);
            this.dtb_LastTimeToPay.TabIndex = 11;
            // 
            // cbx_TaxType
            // 
            this.cbx_TaxType.FormattingEnabled = true;
            this.cbx_TaxType.Location = new System.Drawing.Point(97, 151);
            this.cbx_TaxType.Name = "cbx_TaxType";
            this.cbx_TaxType.Size = new System.Drawing.Size(241, 21);
            this.cbx_TaxType.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "الضريبة";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_AddLine);
            this.groupBox1.Controls.Add(this.btn_DeleteLine);
            this.groupBox1.Controls.Add(this.btn_Minus);
            this.groupBox1.Controls.Add(this.btn_Plus);
            this.groupBox1.Controls.Add(this.dgrd_OrderLines);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_Total);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_DiscountRatio);
            this.groupBox1.Controls.Add(this.txt_DiscountAmount);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 274);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الفاتورة";
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
            // dgrd_OrderLines
            // 
            this.dgrd_OrderLines.AllowUserToAddRows = false;
            this.dgrd_OrderLines.AllowUserToDeleteRows = false;
            this.dgrd_OrderLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrd_OrderLines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.TotalQty,
            this.UnitPrice});
            this.dgrd_OrderLines.Location = new System.Drawing.Point(23, 52);
            this.dgrd_OrderLines.Name = "dgrd_OrderLines";
            this.dgrd_OrderLines.ReadOnly = true;
            this.dgrd_OrderLines.RowHeadersVisible = false;
            this.dgrd_OrderLines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrd_OrderLines.Size = new System.Drawing.Size(595, 187);
            this.dgrd_OrderLines.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(131, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = " نسبة الخصم الكلى";
            // 
            // txt_Total
            // 
            this.txt_Total.Location = new System.Drawing.Point(435, 244);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.ReadOnly = true;
            this.txt_Total.Size = new System.Drawing.Size(100, 20);
            this.txt_Total.TabIndex = 30;
            this.txt_Total.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(339, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "قيمة الخصم الكلى ";
            // 
            // txt_DiscountRatio
            // 
            this.txt_DiscountRatio.Location = new System.Drawing.Point(23, 244);
            this.txt_DiscountRatio.Name = "txt_DiscountRatio";
            this.txt_DiscountRatio.Size = new System.Drawing.Size(100, 20);
            this.txt_DiscountRatio.TabIndex = 28;
            this.txt_DiscountRatio.Text = "%0";
            // 
            // txt_DiscountAmount
            // 
            this.txt_DiscountAmount.Location = new System.Drawing.Point(230, 244);
            this.txt_DiscountAmount.Name = "txt_DiscountAmount";
            this.txt_DiscountAmount.Size = new System.Drawing.Size(100, 20);
            this.txt_DiscountAmount.TabIndex = 27;
            this.txt_DiscountAmount.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(543, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "مجموع الفاتورة";
            // 
            // btn_ClosePrint
            // 
            this.btn_ClosePrint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ClosePrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClosePrint.Location = new System.Drawing.Point(195, 468);
            this.btn_ClosePrint.Name = "btn_ClosePrint";
            this.btn_ClosePrint.Size = new System.Drawing.Size(99, 55);
            this.btn_ClosePrint.TabIndex = 16;
            this.btn_ClosePrint.Text = "أغلاق وطباعة";
            this.btn_ClosePrint.UseVisualStyleBackColor = true;
            this.btn_ClosePrint.Click += new System.EventHandler(this.btn_ClosePrint_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(302, 468);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(99, 55);
            this.btn_Save.TabIndex = 17;
            this.btn_Save.Text = "حفظ فقط";
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
            // num_OtherPayments
            // 
            this.num_OtherPayments.Location = new System.Drawing.Point(453, 151);
            this.num_OtherPayments.Name = "num_OtherPayments";
            this.num_OtherPayments.Size = new System.Drawing.Size(78, 20);
            this.num_OtherPayments.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(367, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "مدفوعات آخرى";
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
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "سعر الوحدة";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // frmSalesOrderAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(703, 532);
            this.ControlBox = false;
            this.Controls.Add(this.num_OtherPayments);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_ClosePrint);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbx_TaxType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtb_LastTimeToPay);
            this.Controls.Add(this.num_Remaining);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.num_Paied);
            this.Controls.Add(this.cbx_PaymentType);
            this.Controls.Add(this.cbx_Customer);
            this.Controls.Add(this.panl_Header);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtb_Date);
            this.Name = "frmSalesOrderAddEdit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "شاشة البيع";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSalesOrderAddEdit_FormClosed);
            this.panl_Header.ResumeLayout(false);
            this.panl_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Paied)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Remaining)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrd_OrderLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_OtherPayments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtb_Date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label lbl_FormHeader;
        protected System.Windows.Forms.Panel panl_Header;
        private System.Windows.Forms.ComboBox cbx_Customer;
        private System.Windows.Forms.ComboBox cbx_PaymentType;
        private System.Windows.Forms.NumericUpDown num_Paied;
        private System.Windows.Forms.NumericUpDown num_Remaining;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtb_LastTimeToPay;
        private System.Windows.Forms.ComboBox cbx_TaxType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_AddLine;
        private System.Windows.Forms.Button btn_DeleteLine;
        private System.Windows.Forms.Button btn_Minus;
        private System.Windows.Forms.Button btn_Plus;
        private System.Windows.Forms.DataGridView dgrd_OrderLines;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_DiscountRatio;
        private System.Windows.Forms.TextBox txt_DiscountAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_ClosePrint;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.NumericUpDown num_OtherPayments;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
    }
}