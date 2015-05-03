namespace POS.UserInterfaceLayer.BasicData
{
    partial class frmBDProductSearch
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
            this.tbx_productName = new System.Windows.Forms.TextBox();
            this.tbx_productCode = new System.Windows.Forms.TextBox();
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.lbl_ProductCode = new System.Windows.Forms.Label();
            this.panl_Header.SuspendLayout();
            this.panl_Footer.SuspendLayout();
            this.grb_search.SuspendLayout();
            this.SuspendLayout();
            // 
            // panl_Header
            // 
            this.panl_Header.Size = new System.Drawing.Size(635, 53);
            // 
            // lbl_FormHeader
            // 
            this.lbl_FormHeader.Location = new System.Drawing.Point(316, 20);
            // 
            // panl_Footer
            // 
            this.panl_Footer.Location = new System.Drawing.Point(0, 365);
            this.panl_Footer.Size = new System.Drawing.Size(635, 62);
            // 
            // groupBox2
            // 
            this.grb_search.Controls.Add(this.btn_Search);
            this.grb_search.Controls.Add(this.tbx_productCode);
            this.grb_search.Controls.Add(this.tbx_productName);
            this.grb_search.Controls.Add(this.lbl_ProductCode);
            this.grb_search.Controls.Add(this.lbl_ProductName);
            this.grb_search.Location = new System.Drawing.Point(0, 53);
            this.grb_search.Size = new System.Drawing.Size(635, 85);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(6, 21);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 29);
            this.btn_Search.TabIndex = 10;
            this.btn_Search.Text = "بحث";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tbx_productName
            // 
            this.tbx_productName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_productName.Location = new System.Drawing.Point(355, 50);
            this.tbx_productName.Name = "tbx_productName";
            this.tbx_productName.Size = new System.Drawing.Size(184, 22);
            this.tbx_productName.TabIndex = 9;
            // 
            // tbx_productCode
            // 
            this.tbx_productCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_productCode.Location = new System.Drawing.Point(355, 21);
            this.tbx_productCode.Name = "tbx_productCode";
            this.tbx_productCode.Size = new System.Drawing.Size(184, 22);
            this.tbx_productCode.TabIndex = 8;
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ProductName.AutoSize = true;
            this.lbl_ProductName.Location = new System.Drawing.Point(572, 56);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(58, 16);
            this.lbl_ProductName.TabIndex = 7;
            this.lbl_ProductName.Text = "إسم الصنف";
            // 
            // lbl_ProductCode
            // 
            this.lbl_ProductCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ProductCode.AutoSize = true;
            this.lbl_ProductCode.Location = new System.Drawing.Point(572, 21);
            this.lbl_ProductCode.Name = "lbl_ProductCode";
            this.lbl_ProductCode.Size = new System.Drawing.Size(57, 16);
            this.lbl_ProductCode.TabIndex = 6;
            this.lbl_ProductCode.Text = "كود الصنف";
            // 
            // frmBDProductSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(635, 427);
            this.Name = "frmBDProductSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مجموعات الأصناف";
            this.panl_Header.ResumeLayout(false);
            this.panl_Header.PerformLayout();
            this.panl_Footer.ResumeLayout(false);
            this.grb_search.ResumeLayout(false);
            this.grb_search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tbx_productName;
        private System.Windows.Forms.TextBox tbx_productCode;
        private System.Windows.Forms.Label lbl_ProductName;
        private System.Windows.Forms.Label lbl_ProductCode;

    }
}
