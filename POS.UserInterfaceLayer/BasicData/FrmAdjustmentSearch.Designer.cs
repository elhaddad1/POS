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
            this.cbx_AdjustReason = new System.Windows.Forms.ComboBox();
            this.cbx_Store = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_toDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_fromDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panl_Header.SuspendLayout();
            this.panl_Footer.SuspendLayout();
            this.grb_search.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_search
            // 
            this.grb_search.Controls.Add(this.button1);
            this.grb_search.Controls.Add(this.label7);
            this.grb_search.Controls.Add(this.dtp_toDate);
            this.grb_search.Controls.Add(this.dtp_fromDate);
            this.grb_search.Controls.Add(this.label6);
            this.grb_search.Controls.Add(this.label5);
            this.grb_search.Controls.Add(this.label4);
            this.grb_search.Controls.Add(this.cbx_AdjustReason);
            this.grb_search.Controls.Add(this.cbx_Store);
            this.grb_search.Size = new System.Drawing.Size(646, 164);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Visible = false;
            // 
            // cbx_AdjustReason
            // 
            this.cbx_AdjustReason.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_AdjustReason.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbx_AdjustReason.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_AdjustReason.FormattingEnabled = true;
            this.cbx_AdjustReason.Location = new System.Drawing.Point(328, 54);
            this.cbx_AdjustReason.Name = "cbx_AdjustReason";
            this.cbx_AdjustReason.Size = new System.Drawing.Size(241, 24);
            this.cbx_AdjustReason.TabIndex = 72;
            // 
            // cbx_Store
            // 
            this.cbx_Store.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_Store.FormattingEnabled = true;
            this.cbx_Store.Location = new System.Drawing.Point(328, 15);
            this.cbx_Store.Name = "cbx_Store";
            this.cbx_Store.Size = new System.Drawing.Size(241, 24);
            this.cbx_Store.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(601, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 73;
            this.label4.Text = "المخزن";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(575, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 74;
            this.label5.Text = "سبب التسوية";
            // 
            // dtp_toDate
            // 
            this.dtp_toDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_toDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_toDate.Location = new System.Drawing.Point(51, 100);
            this.dtp_toDate.Name = "dtp_toDate";
            this.dtp_toDate.RightToLeftLayout = true;
            this.dtp_toDate.Size = new System.Drawing.Size(241, 22);
            this.dtp_toDate.TabIndex = 77;
            // 
            // dtp_fromDate
            // 
            this.dtp_fromDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_fromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fromDate.Location = new System.Drawing.Point(325, 99);
            this.dtp_fromDate.Name = "dtp_fromDate";
            this.dtp_fromDate.RightToLeftLayout = true;
            this.dtp_fromDate.Size = new System.Drawing.Size(241, 22);
            this.dtp_fromDate.TabIndex = 76;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(572, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 75;
            this.label6.Text = "الفتره      من";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(298, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 16);
            this.label7.TabIndex = 78;
            this.label7.Text = "الى";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 79;
            this.button1.Text = "بحث";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmAdjustmentSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(646, 595);
            this.Name = "FrmAdjustmentSearch";
            this.Text = "التسويه";
            this.Load += new System.EventHandler(this.FrmAdjustmentSearch_Load);
            this.panl_Header.ResumeLayout(false);
            this.panl_Header.PerformLayout();
            this.panl_Footer.ResumeLayout(false);
            this.grb_search.ResumeLayout(false);
            this.grb_search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_AdjustReason;
        private System.Windows.Forms.ComboBox cbx_Store;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_toDate;
        private System.Windows.Forms.DateTimePicker dtp_fromDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;

    }
}
