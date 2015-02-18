namespace POS.UserInterfaceLayer.BasicData
{
    partial class FrmCustomerSearch
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
            this.label1 = new System.Windows.Forms.Label();
            this.grb_search = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tbx_cusomerName = new System.Windows.Forms.TextBox();
            this.tbx_customerCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grb_search.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_FormHeader
            // 
            this.lbl_FormHeader.Location = new System.Drawing.Point(275, 20);
            this.lbl_FormHeader.Size = new System.Drawing.Size(73, 19);
            this.lbl_FormHeader.Text = "بحث العملاء";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(569, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "كود العميل";
            // 
            // grb_search
            // 
            this.grb_search.Controls.Add(this.btn_Search);
            this.grb_search.Controls.Add(this.tbx_cusomerName);
            this.grb_search.Controls.Add(this.tbx_customerCode);
            this.grb_search.Controls.Add(this.label2);
            this.grb_search.Controls.Add(this.label1);
            this.grb_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.grb_search.Location = new System.Drawing.Point(0, 53);
            this.grb_search.Name = "grb_search";
            this.grb_search.Size = new System.Drawing.Size(635, 100);
            this.grb_search.TabIndex = 7;
            this.grb_search.TabStop = false;
            this.grb_search.Text = "بحث العملاء";
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
            // tbx_cusomerName
            // 
            this.tbx_cusomerName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbx_cusomerName.Location = new System.Drawing.Point(352, 59);
            this.tbx_cusomerName.Name = "tbx_cusomerName";
            this.tbx_cusomerName.Size = new System.Drawing.Size(184, 22);
            this.tbx_cusomerName.TabIndex = 9;
            // 
            // tbx_customerCode
            // 
            this.tbx_customerCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbx_customerCode.Location = new System.Drawing.Point(352, 30);
            this.tbx_customerCode.Name = "tbx_customerCode";
            this.tbx_customerCode.Size = new System.Drawing.Size(184, 22);
            this.tbx_customerCode.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(569, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "إسم العميل";
            // 
            // FrmCustomerSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(635, 452);
            this.Controls.Add(this.grb_search);
            this.Name = "FrmCustomerSearch";
            this.Text = "العملاء";
            this.Load += new System.EventHandler(this.FrmCustomerSearch_Load);
            this.Controls.SetChildIndex(this.grb_search, 0);
            this.grb_search.ResumeLayout(false);
            this.grb_search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grb_search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tbx_cusomerName;
        private System.Windows.Forms.TextBox tbx_customerCode;
        private System.Windows.Forms.Label label2;

    }
}
