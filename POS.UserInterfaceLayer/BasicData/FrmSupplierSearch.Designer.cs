namespace POS.UserInterfaceLayer.BasicData
{
    partial class FrmSupplierSearch
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
            this.tbx_cusomerName = new System.Windows.Forms.TextBox();
            this.tbx_customerCode = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_code = new System.Windows.Forms.Label();
            this.panl_Header.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panl_Header
            // 
            this.panl_Header.Size = new System.Drawing.Size(613, 53);
            // 
            // lbl_FormHeader
            // 
            this.lbl_FormHeader.Location = new System.Drawing.Point(223, 20);
            this.lbl_FormHeader.Size = new System.Drawing.Size(82, 19);
            this.lbl_FormHeader.Text = "بحث الموردين";
            // 
            // panl_Footer
            // 
            this.panl_Footer.Location = new System.Drawing.Point(0, 375);
            this.panl_Footer.Size = new System.Drawing.Size(613, 62);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Search);
            this.groupBox2.Controls.Add(this.lbl_code);
            this.groupBox2.Controls.Add(this.tbx_cusomerName);
            this.groupBox2.Controls.Add(this.lbl_name);
            this.groupBox2.Controls.Add(this.tbx_customerCode);
            this.groupBox2.Size = new System.Drawing.Size(613, 78);
            this.groupBox2.Text = "بحث الموردين";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(12, 15);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 29);
            this.btn_Search.TabIndex = 10;
            this.btn_Search.Text = "بحث";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tbx_cusomerName
            // 
            this.tbx_cusomerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_cusomerName.Location = new System.Drawing.Point(330, 47);
            this.tbx_cusomerName.Name = "tbx_cusomerName";
            this.tbx_cusomerName.Size = new System.Drawing.Size(184, 22);
            this.tbx_cusomerName.TabIndex = 9;
            // 
            // tbx_customerCode
            // 
            this.tbx_customerCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_customerCode.Location = new System.Drawing.Point(330, 18);
            this.tbx_customerCode.Name = "tbx_customerCode";
            this.tbx_customerCode.Size = new System.Drawing.Size(184, 22);
            this.tbx_customerCode.TabIndex = 8;
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(547, 53);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(55, 16);
            this.lbl_name.TabIndex = 7;
            this.lbl_name.Text = "إسم المورد";
            // 
            // lbl_code
            // 
            this.lbl_code.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_code.AutoSize = true;
            this.lbl_code.Location = new System.Drawing.Point(547, 18);
            this.lbl_code.Name = "lbl_code";
            this.lbl_code.Size = new System.Drawing.Size(54, 16);
            this.lbl_code.TabIndex = 6;
            this.lbl_code.Text = "كود المورد";
            // 
            // FrmSupplierSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 437);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSupplierSearch";
            this.Text = "الموردين";
            this.Load += new System.EventHandler(this.FrmSupplierSearch_Load);
            this.panl_Header.ResumeLayout(false);
            this.panl_Header.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tbx_cusomerName;
        private System.Windows.Forms.TextBox tbx_customerCode;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_code;
    }
}