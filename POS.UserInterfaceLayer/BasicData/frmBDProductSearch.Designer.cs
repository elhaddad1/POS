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
            this.grb_search = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tbx_productName = new System.Windows.Forms.TextBox();
            this.tbx_productCode = new System.Windows.Forms.TextBox();
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.lbl_ProductCode = new System.Windows.Forms.Label();
            this.grb_search.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_FormHeader
            // 
            this.lbl_FormHeader.Location = new System.Drawing.Point(301, 20);
            // 
            // grb_search
            // 
            this.grb_search.Controls.Add(this.btn_Search);
            this.grb_search.Controls.Add(this.tbx_productName);
            this.grb_search.Controls.Add(this.tbx_productCode);
            this.grb_search.Controls.Add(this.lbl_ProductName);
            this.grb_search.Controls.Add(this.lbl_ProductCode);
            this.grb_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.grb_search.Location = new System.Drawing.Point(0, 53);
            this.grb_search.Name = "grb_search";
            this.grb_search.Size = new System.Drawing.Size(635, 100);
            this.grb_search.TabIndex = 8;
            this.grb_search.TabStop = false;
            this.grb_search.Text = "بحث الاصناف";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(28, 65);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 29);
            this.btn_Search.TabIndex = 10;
            this.btn_Search.Text = "بحث";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tbx_productName
            // 
            this.tbx_productName.Location = new System.Drawing.Point(352, 59);
            this.tbx_productName.Name = "tbx_productName";
            this.tbx_productName.Size = new System.Drawing.Size(184, 22);
            this.tbx_productName.TabIndex = 9;
            // 
            // tbx_productCode
            // 
            this.tbx_productCode.Location = new System.Drawing.Point(352, 30);
            this.tbx_productCode.Name = "tbx_productCode";
            this.tbx_productCode.Size = new System.Drawing.Size(184, 22);
            this.tbx_productCode.TabIndex = 8;
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.AutoSize = true;
            this.lbl_ProductName.Location = new System.Drawing.Point(569, 65);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(58, 16);
            this.lbl_ProductName.TabIndex = 7;
            this.lbl_ProductName.Text = "إسم الصنف";
            // 
            // lbl_ProductCode
            // 
            this.lbl_ProductCode.AutoSize = true;
            this.lbl_ProductCode.Location = new System.Drawing.Point(569, 30);
            this.lbl_ProductCode.Name = "lbl_ProductCode";
            this.lbl_ProductCode.Size = new System.Drawing.Size(57, 16);
            this.lbl_ProductCode.TabIndex = 6;
            this.lbl_ProductCode.Text = "كود الصنف";
            // 
            // frmBDProductSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(635, 427);
            this.Controls.Add(this.grb_search);
            this.Name = "frmBDProductSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مجموعات الأصناف";
            this.Controls.SetChildIndex(this.grb_search, 0);
            this.grb_search.ResumeLayout(false);
            this.grb_search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tbx_productName;
        private System.Windows.Forms.TextBox tbx_productCode;
        private System.Windows.Forms.Label lbl_ProductName;
        private System.Windows.Forms.Label lbl_ProductCode;

    }
}
