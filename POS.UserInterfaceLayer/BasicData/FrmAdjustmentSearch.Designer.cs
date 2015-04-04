namespace POS.UserInterfaceLayer.BasicData
{
    partial class FrmAdjustmentSearch
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
            this.btn_Search = new System.Windows.Forms.Button();
            this.tbx_ProductName = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_InventoryName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_AdjustName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_StockTypeName = new System.Windows.Forms.TextBox();
            this.panl_Header.SuspendLayout();
            this.panl_Footer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panl_Header
            // 
            this.panl_Header.Size = new System.Drawing.Size(609, 53);
            // 
            // lbl_FormHeader
            // 
            this.lbl_FormHeader.Location = new System.Drawing.Point(189, 9);
            // 
            // panl_Footer
            // 
            this.panl_Footer.Location = new System.Drawing.Point(0, 365);
            this.panl_Footer.Size = new System.Drawing.Size(609, 62);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbx_StockTypeName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbx_AdjustName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbx_InventoryName);
            this.groupBox2.Controls.Add(this.btn_Search);
            this.groupBox2.Controls.Add(this.lbl_name);
            this.groupBox2.Controls.Add(this.tbx_ProductName);
            this.groupBox2.Location = new System.Drawing.Point(0, 53);
            this.groupBox2.Size = new System.Drawing.Size(609, 126);
            this.groupBox2.Text = "بحث التسوية";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(341, 2);
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(26, 2);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(236, 2);
            this.btn_Edit.Visible = false;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(131, 2);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(6, 91);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 29);
            this.btn_Search.TabIndex = 10;
            this.btn_Search.Text = "بحث";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tbx_ProductName
            // 
            this.tbx_ProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_ProductName.Location = new System.Drawing.Point(330, 27);
            this.tbx_ProductName.Name = "tbx_ProductName";
            this.tbx_ProductName.Size = new System.Drawing.Size(184, 22);
            this.tbx_ProductName.TabIndex = 9;
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(536, 30);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(58, 16);
            this.lbl_name.TabIndex = 7;
            this.lbl_name.Text = "اسم الصنف";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(536, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "اسم المخزن";
            // 
            // tbx_InventoryName
            // 
            this.tbx_InventoryName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_InventoryName.Location = new System.Drawing.Point(330, 55);
            this.tbx_InventoryName.Name = "tbx_InventoryName";
            this.tbx_InventoryName.Size = new System.Drawing.Size(184, 22);
            this.tbx_InventoryName.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "سبب التسوية";
            // 
            // tbx_AdjustName
            // 
            this.tbx_AdjustName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_AdjustName.Location = new System.Drawing.Point(68, 27);
            this.tbx_AdjustName.Name = "tbx_AdjustName";
            this.tbx_AdjustName.Size = new System.Drawing.Size(184, 22);
            this.tbx_AdjustName.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "نوع الصنف";
            // 
            // tbx_StockTypeName
            // 
            this.tbx_StockTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_StockTypeName.Location = new System.Drawing.Point(68, 55);
            this.tbx_StockTypeName.Name = "tbx_StockTypeName";
            this.tbx_StockTypeName.Size = new System.Drawing.Size(184, 22);
            this.tbx_StockTypeName.TabIndex = 16;
            // 
            // FrmAdjustmentSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(609, 427);
            this.Name = "FrmAdjustmentSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "التسوية";
            this.panl_Header.ResumeLayout(false);
            this.panl_Header.PerformLayout();
            this.panl_Footer.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tbx_ProductName;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_StockTypeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_AdjustName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_InventoryName;

    }
}
