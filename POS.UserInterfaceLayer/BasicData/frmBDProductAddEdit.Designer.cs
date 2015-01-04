namespace POS.UserInterfaceLayer.BasicData
{
    partial class frmBDProductAddEdit
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
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.lbl_Notes = new System.Windows.Forms.Label();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.txt_Notes = new System.Windows.Forms.TextBox();
            this.txt_ProductCode = new System.Windows.Forms.TextBox();
            this.lbl_ProductCode = new System.Windows.Forms.Label();
            this.lbl_ProductPrice = new System.Windows.Forms.Label();
            this.lbl_DiscountAmount = new System.Windows.Forms.Label();
            this.nmr_ProductPrice = new System.Windows.Forms.NumericUpDown();
            this.nmr_DiscountAmount = new System.Windows.Forms.NumericUpDown();
            this.lbl_ProductGroupID = new System.Windows.Forms.Label();
            this.ddl_ProductGroupID = new System.Windows.Forms.ComboBox();
            this.chk_IsFixedPrice = new System.Windows.Forms.CheckBox();
            this.chk_HasDiscount = new System.Windows.Forms.CheckBox();
            this.nmr_DescountRatio = new System.Windows.Forms.NumericUpDown();
            this.lbl_DescountRatio = new System.Windows.Forms.Label();
            this.chk_IsAcceptBatch = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_ProductPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_DiscountAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_DescountRatio)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_FormHeader
            // 
            this.lbl_FormHeader.Location = new System.Drawing.Point(1910, 9);
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.AutoSize = true;
            this.lbl_ProductName.Location = new System.Drawing.Point(16, 65);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(58, 16);
            this.lbl_ProductName.TabIndex = 2;
            this.lbl_ProductName.Text = "اسم الصنف";
            // 
            // lbl_Notes
            // 
            this.lbl_Notes.AutoSize = true;
            this.lbl_Notes.Location = new System.Drawing.Point(16, 305);
            this.lbl_Notes.Name = "lbl_Notes";
            this.lbl_Notes.Size = new System.Drawing.Size(51, 16);
            this.lbl_Notes.TabIndex = 3;
            this.lbl_Notes.Text = "الملاحظات";
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.Location = new System.Drawing.Point(142, 59);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(188, 22);
            this.txt_ProductName.TabIndex = 4;
            // 
            // txt_Notes
            // 
            this.txt_Notes.Location = new System.Drawing.Point(142, 305);
            this.txt_Notes.Multiline = true;
            this.txt_Notes.Name = "txt_Notes";
            this.txt_Notes.Size = new System.Drawing.Size(420, 97);
            this.txt_Notes.TabIndex = 5;
            // 
            // txt_ProductCode
            // 
            this.txt_ProductCode.Location = new System.Drawing.Point(142, 138);
            this.txt_ProductCode.Name = "txt_ProductCode";
            this.txt_ProductCode.Size = new System.Drawing.Size(188, 22);
            this.txt_ProductCode.TabIndex = 7;
            // 
            // lbl_ProductCode
            // 
            this.lbl_ProductCode.AutoSize = true;
            this.lbl_ProductCode.Location = new System.Drawing.Point(16, 144);
            this.lbl_ProductCode.Name = "lbl_ProductCode";
            this.lbl_ProductCode.Size = new System.Drawing.Size(57, 16);
            this.lbl_ProductCode.TabIndex = 6;
            this.lbl_ProductCode.Text = "رقم الصنف";
            // 
            // lbl_ProductPrice
            // 
            this.lbl_ProductPrice.AutoSize = true;
            this.lbl_ProductPrice.Location = new System.Drawing.Point(16, 219);
            this.lbl_ProductPrice.Name = "lbl_ProductPrice";
            this.lbl_ProductPrice.Size = new System.Drawing.Size(61, 16);
            this.lbl_ProductPrice.TabIndex = 8;
            this.lbl_ProductPrice.Text = "سعر الصنف";
            // 
            // lbl_DiscountAmount
            // 
            this.lbl_DiscountAmount.AutoSize = true;
            this.lbl_DiscountAmount.Location = new System.Drawing.Point(16, 256);
            this.lbl_DiscountAmount.Name = "lbl_DiscountAmount";
            this.lbl_DiscountAmount.Size = new System.Drawing.Size(47, 16);
            this.lbl_DiscountAmount.TabIndex = 10;
            this.lbl_DiscountAmount.Text = "خصومات";
            // 
            // nmr_ProductPrice
            // 
            this.nmr_ProductPrice.Location = new System.Drawing.Point(142, 213);
            this.nmr_ProductPrice.Name = "nmr_ProductPrice";
            this.nmr_ProductPrice.Size = new System.Drawing.Size(188, 22);
            this.nmr_ProductPrice.TabIndex = 11;
            // 
            // nmr_DiscountAmount
            // 
            this.nmr_DiscountAmount.Location = new System.Drawing.Point(142, 254);
            this.nmr_DiscountAmount.Name = "nmr_DiscountAmount";
            this.nmr_DiscountAmount.Size = new System.Drawing.Size(188, 22);
            this.nmr_DiscountAmount.TabIndex = 12;
            // 
            // lbl_ProductGroupID
            // 
            this.lbl_ProductGroupID.AutoSize = true;
            this.lbl_ProductGroupID.Location = new System.Drawing.Point(16, 94);
            this.lbl_ProductGroupID.Name = "lbl_ProductGroupID";
            this.lbl_ProductGroupID.Size = new System.Drawing.Size(69, 16);
            this.lbl_ProductGroupID.TabIndex = 13;
            this.lbl_ProductGroupID.Text = "اسم المجموعة";
            // 
            // ddl_ProductGroupID
            // 
            this.ddl_ProductGroupID.FormattingEnabled = true;
            this.ddl_ProductGroupID.Location = new System.Drawing.Point(141, 91);
            this.ddl_ProductGroupID.Name = "ddl_ProductGroupID";
            this.ddl_ProductGroupID.Size = new System.Drawing.Size(188, 24);
            this.ddl_ProductGroupID.TabIndex = 14;
            // 
            // chk_IsFixedPrice
            // 
            this.chk_IsFixedPrice.AutoSize = true;
            this.chk_IsFixedPrice.Location = new System.Drawing.Point(357, 217);
            this.chk_IsFixedPrice.Name = "chk_IsFixedPrice";
            this.chk_IsFixedPrice.Size = new System.Drawing.Size(69, 20);
            this.chk_IsFixedPrice.TabIndex = 17;
            this.chk_IsFixedPrice.Text = "سعر ثابت";
            this.chk_IsFixedPrice.UseVisualStyleBackColor = true;
            // 
            // chk_HasDiscount
            // 
            this.chk_HasDiscount.AutoSize = true;
            this.chk_HasDiscount.Location = new System.Drawing.Point(356, 253);
            this.chk_HasDiscount.Name = "chk_HasDiscount";
            this.chk_HasDiscount.Size = new System.Drawing.Size(69, 20);
            this.chk_HasDiscount.TabIndex = 18;
            this.chk_HasDiscount.Text = "لديه خصم";
            this.chk_HasDiscount.UseVisualStyleBackColor = true;
            // 
            // nmr_DescountRatio
            // 
            this.nmr_DescountRatio.Location = new System.Drawing.Point(592, 254);
            this.nmr_DescountRatio.Name = "nmr_DescountRatio";
            this.nmr_DescountRatio.Size = new System.Drawing.Size(188, 22);
            this.nmr_DescountRatio.TabIndex = 20;
            // 
            // lbl_DescountRatio
            // 
            this.lbl_DescountRatio.AutoSize = true;
            this.lbl_DescountRatio.Location = new System.Drawing.Point(466, 256);
            this.lbl_DescountRatio.Name = "lbl_DescountRatio";
            this.lbl_DescountRatio.Size = new System.Drawing.Size(61, 16);
            this.lbl_DescountRatio.TabIndex = 19;
            this.lbl_DescountRatio.Text = "نسبة الخصم";
            // 
            // chk_IsAcceptBatch
            // 
            this.chk_IsAcceptBatch.AutoSize = true;
            this.chk_IsAcceptBatch.Location = new System.Drawing.Point(19, 180);
            this.chk_IsAcceptBatch.Name = "chk_IsAcceptBatch";
            this.chk_IsAcceptBatch.Size = new System.Drawing.Size(87, 20);
            this.chk_IsAcceptBatch.TabIndex = 21;
            this.chk_IsAcceptBatch.Text = "له رقم تشغيله";
            this.chk_IsAcceptBatch.UseVisualStyleBackColor = true;
            // 
            // frmBDProductAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(951, 480);
            this.Controls.Add(this.chk_IsAcceptBatch);
            this.Controls.Add(this.nmr_DescountRatio);
            this.Controls.Add(this.lbl_DescountRatio);
            this.Controls.Add(this.chk_HasDiscount);
            this.Controls.Add(this.chk_IsFixedPrice);
            this.Controls.Add(this.ddl_ProductGroupID);
            this.Controls.Add(this.lbl_ProductGroupID);
            this.Controls.Add(this.nmr_DiscountAmount);
            this.Controls.Add(this.nmr_ProductPrice);
            this.Controls.Add(this.lbl_DiscountAmount);
            this.Controls.Add(this.lbl_ProductPrice);
            this.Controls.Add(this.txt_ProductCode);
            this.Controls.Add(this.lbl_ProductCode);
            this.Controls.Add(this.txt_Notes);
            this.Controls.Add(this.txt_ProductName);
            this.Controls.Add(this.lbl_Notes);
            this.Controls.Add(this.lbl_ProductName);
            this.Name = "frmBDProductAddEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الاصناف";
            this.Controls.SetChildIndex(this.lbl_ProductName, 0);
            this.Controls.SetChildIndex(this.lbl_Notes, 0);
            this.Controls.SetChildIndex(this.txt_ProductName, 0);
            this.Controls.SetChildIndex(this.txt_Notes, 0);
            this.Controls.SetChildIndex(this.lbl_ProductCode, 0);
            this.Controls.SetChildIndex(this.txt_ProductCode, 0);
            this.Controls.SetChildIndex(this.lbl_ProductPrice, 0);
            this.Controls.SetChildIndex(this.lbl_DiscountAmount, 0);
            this.Controls.SetChildIndex(this.nmr_ProductPrice, 0);
            this.Controls.SetChildIndex(this.nmr_DiscountAmount, 0);
            this.Controls.SetChildIndex(this.lbl_ProductGroupID, 0);
            this.Controls.SetChildIndex(this.ddl_ProductGroupID, 0);
            this.Controls.SetChildIndex(this.chk_IsFixedPrice, 0);
            this.Controls.SetChildIndex(this.chk_HasDiscount, 0);
            this.Controls.SetChildIndex(this.lbl_DescountRatio, 0);
            this.Controls.SetChildIndex(this.nmr_DescountRatio, 0);
            this.Controls.SetChildIndex(this.chk_IsAcceptBatch, 0);
            ((System.ComponentModel.ISupportInitialize)(this.nmr_ProductPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_DiscountAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_DescountRatio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ProductName;
        private System.Windows.Forms.Label lbl_Notes;
        private System.Windows.Forms.TextBox txt_ProductName;
        private System.Windows.Forms.TextBox txt_Notes;
        private System.Windows.Forms.TextBox txt_ProductCode;
        private System.Windows.Forms.Label lbl_ProductCode;
        private System.Windows.Forms.Label lbl_ProductPrice;
        private System.Windows.Forms.Label lbl_DiscountAmount;
        private System.Windows.Forms.NumericUpDown nmr_ProductPrice;
        private System.Windows.Forms.NumericUpDown nmr_DiscountAmount;
        private System.Windows.Forms.Label lbl_ProductGroupID;
        private System.Windows.Forms.ComboBox ddl_ProductGroupID;
        private System.Windows.Forms.CheckBox chk_IsFixedPrice;
        private System.Windows.Forms.CheckBox chk_HasDiscount;
        private System.Windows.Forms.NumericUpDown nmr_DescountRatio;
        private System.Windows.Forms.Label lbl_DescountRatio;
        private System.Windows.Forms.CheckBox chk_IsAcceptBatch;

    }
}
