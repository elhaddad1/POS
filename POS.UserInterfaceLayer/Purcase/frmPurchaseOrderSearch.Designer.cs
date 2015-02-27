namespace POS.UserInterfaceLayer.Purcase
{
    partial class frmPurchaseOrderSearch
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_OrderSerial = new System.Windows.Forms.TextBox();
            this.tbx_SupplierName = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.panl_Header.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Search);
            this.groupBox2.Controls.Add(this.tbx_OrderSerial);
            this.groupBox2.Controls.Add(this.tbx_SupplierName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Size = new System.Drawing.Size(698, 91);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(616, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "مسلسل الفاتورة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(636, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "أسم المورد";
            // 
            // tbx_OrderSerial
            // 
            this.tbx_OrderSerial.Location = new System.Drawing.Point(366, 47);
            this.tbx_OrderSerial.Name = "tbx_OrderSerial";
            this.tbx_OrderSerial.Size = new System.Drawing.Size(247, 22);
            this.tbx_OrderSerial.TabIndex = 18;
            // 
            // tbx_SupplierName
            // 
            this.tbx_SupplierName.Location = new System.Drawing.Point(366, 12);
            this.tbx_SupplierName.Name = "tbx_SupplierName";
            this.tbx_SupplierName.Size = new System.Drawing.Size(247, 22);
            this.tbx_SupplierName.TabIndex = 17;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(6, 41);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 40);
            this.btn_Search.TabIndex = 19;
            this.btn_Search.Text = "بحث";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // frmPurchaseOrderSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(698, 403);
            this.Name = "frmPurchaseOrderSearch";
            this.panl_Header.ResumeLayout(false);
            this.panl_Header.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_OrderSerial;
        private System.Windows.Forms.TextBox tbx_SupplierName;
        private System.Windows.Forms.Button btn_Search;
    }
}
