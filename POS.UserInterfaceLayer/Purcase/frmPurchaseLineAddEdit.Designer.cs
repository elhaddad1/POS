namespace POS.UserInterfaceLayer.Purcase
{
    partial class frmPurchaseLineAddEdit
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
            this.num_Quantity = new System.Windows.Forms.TextBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Finish = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tbx_Discount = new System.Windows.Forms.TextBox();
            this.num_Bonus = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_MinPriceValue = new System.Windows.Forms.Label();
            this.lbl_MinPriceHeader = new System.Windows.Forms.Label();
            this.tbx_Price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_Product = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_ProductGroup = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panl_Header = new System.Windows.Forms.Panel();
            this.lbl_FormHeader = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BatchNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.num_Bonus)).BeginInit();
            this.panl_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // num_Quantity
            // 
            this.num_Quantity.Location = new System.Drawing.Point(105, 112);
            this.num_Quantity.Name = "num_Quantity";
            this.num_Quantity.Size = new System.Drawing.Size(100, 20);
            this.num_Quantity.TabIndex = 53;
            this.num_Quantity.Text = "0";
            // 
            // btn_Back
            // 
            this.btn_Back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(372, 316);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(99, 55);
            this.btn_Back.TabIndex = 52;
            this.btn_Back.Text = "رجوع";
            this.btn_Back.UseVisualStyleBackColor = true;
            // 
            // btn_Finish
            // 
            this.btn_Finish.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Finish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Finish.Location = new System.Drawing.Point(267, 316);
            this.btn_Finish.Name = "btn_Finish";
            this.btn_Finish.Size = new System.Drawing.Size(99, 55);
            this.btn_Finish.TabIndex = 51;
            this.btn_Finish.Text = "أنهاء";
            this.btn_Finish.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "الخصم";
            this.label10.Visible = false;
            // 
            // tbx_Discount
            // 
            this.tbx_Discount.Location = new System.Drawing.Point(103, 145);
            this.tbx_Discount.Name = "tbx_Discount";
            this.tbx_Discount.ReadOnly = true;
            this.tbx_Discount.Size = new System.Drawing.Size(78, 20);
            this.tbx_Discount.TabIndex = 49;
            this.tbx_Discount.Text = "%0";
            this.tbx_Discount.Visible = false;
            // 
            // num_Bonus
            // 
            this.num_Bonus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.num_Bonus.Location = new System.Drawing.Point(267, 113);
            this.num_Bonus.Name = "num_Bonus";
            this.num_Bonus.Size = new System.Drawing.Size(78, 20);
            this.num_Bonus.TabIndex = 48;
            this.num_Bonus.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(218, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "أضافى";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "الكمية";
            // 
            // lbl_MinPriceValue
            // 
            this.lbl_MinPriceValue.AutoSize = true;
            this.lbl_MinPriceValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_MinPriceValue.Location = new System.Drawing.Point(635, 117);
            this.lbl_MinPriceValue.Name = "lbl_MinPriceValue";
            this.lbl_MinPriceValue.Size = new System.Drawing.Size(13, 13);
            this.lbl_MinPriceValue.TabIndex = 45;
            this.lbl_MinPriceValue.Text = "0";
            this.lbl_MinPriceValue.Visible = false;
            // 
            // lbl_MinPriceHeader
            // 
            this.lbl_MinPriceHeader.AutoSize = true;
            this.lbl_MinPriceHeader.ForeColor = System.Drawing.Color.Red;
            this.lbl_MinPriceHeader.Location = new System.Drawing.Point(573, 117);
            this.lbl_MinPriceHeader.Name = "lbl_MinPriceHeader";
            this.lbl_MinPriceHeader.Size = new System.Drawing.Size(48, 13);
            this.lbl_MinPriceHeader.TabIndex = 44;
            this.lbl_MinPriceHeader.Text = "أقل سعر";
            this.lbl_MinPriceHeader.Visible = false;
            // 
            // tbx_Price
            // 
            this.tbx_Price.Location = new System.Drawing.Point(431, 113);
            this.tbx_Price.Name = "tbx_Price";
            this.tbx_Price.ReadOnly = true;
            this.tbx_Price.Size = new System.Drawing.Size(115, 20);
            this.tbx_Price.TabIndex = 43;
            this.tbx_Price.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "سعر الوحدة";
            // 
            // cbx_Product
            // 
            this.cbx_Product.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbx_Product.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_Product.FormattingEnabled = true;
            this.cbx_Product.Location = new System.Drawing.Point(431, 80);
            this.cbx_Product.Name = "cbx_Product";
            this.cbx_Product.Size = new System.Drawing.Size(241, 21);
            this.cbx_Product.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "أسم الصنف";
            // 
            // cbx_ProductGroup
            // 
            this.cbx_ProductGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbx_ProductGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_ProductGroup.FormattingEnabled = true;
            this.cbx_ProductGroup.Location = new System.Drawing.Point(105, 80);
            this.cbx_ProductGroup.Name = "cbx_ProductGroup";
            this.cbx_ProductGroup.Size = new System.Drawing.Size(241, 21);
            this.cbx_ProductGroup.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "مجموعة الأصناف";
            // 
            // panl_Header
            // 
            this.panl_Header.BackColor = System.Drawing.Color.MintCream;
            this.panl_Header.Controls.Add(this.lbl_FormHeader);
            this.panl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panl_Header.Location = new System.Drawing.Point(0, 0);
            this.panl_Header.Name = "panl_Header";
            this.panl_Header.Size = new System.Drawing.Size(691, 53);
            this.panl_Header.TabIndex = 37;
            // 
            // lbl_FormHeader
            // 
            this.lbl_FormHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_FormHeader.AutoSize = true;
            this.lbl_FormHeader.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FormHeader.Location = new System.Drawing.Point(289, 9);
            this.lbl_FormHeader.Name = "lbl_FormHeader";
            this.lbl_FormHeader.Size = new System.Drawing.Size(109, 19);
            this.lbl_FormHeader.TabIndex = 0;
            this.lbl_FormHeader.Text = "أضافة منتج لفاتورة";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BatchNumber,
            this.ExpiryDate});
            this.dataGridView1.Location = new System.Drawing.Point(31, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(264, 123);
            this.dataGridView1.TabIndex = 54;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(21, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 145);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الباتشات";
            // 
            // BatchNumber
            // 
            this.BatchNumber.HeaderText = "رقم الباتش";
            this.BatchNumber.Name = "BatchNumber";
            // 
            // ExpiryDate
            // 
            this.ExpiryDate.HeaderText = "تاريخ الصلاحيه";
            this.ExpiryDate.Name = "ExpiryDate";
            // 
            // frmPurchaseLineAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 379);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.num_Quantity);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Finish);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbx_Discount);
            this.Controls.Add(this.num_Bonus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_MinPriceValue);
            this.Controls.Add(this.lbl_MinPriceHeader);
            this.Controls.Add(this.tbx_Price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_Product);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_ProductGroup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panl_Header);
            this.Name = "frmPurchaseLineAddEdit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "frmPurchaseLineAddEdit";
            ((System.ComponentModel.ISupportInitialize)(this.num_Bonus)).EndInit();
            this.panl_Header.ResumeLayout(false);
            this.panl_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num_Quantity;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Finish;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbx_Discount;
        private System.Windows.Forms.NumericUpDown num_Bonus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_MinPriceValue;
        private System.Windows.Forms.Label lbl_MinPriceHeader;
        private System.Windows.Forms.TextBox tbx_Price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_Product;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_ProductGroup;
        private System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Panel panl_Header;
        protected System.Windows.Forms.Label lbl_FormHeader;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiryDate;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}