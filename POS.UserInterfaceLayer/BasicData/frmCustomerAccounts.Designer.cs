namespace POS.UserInterfaceLayer.BasicData
{
    partial class frmCustomerAccounts
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
            this.cbx_Customer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Paid = new System.Windows.Forms.Label();
            this.lbl_TotalAmount = new System.Windows.Forms.Label();
            this.lbl_Remaining = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_toDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_fromDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.panl_Header.SuspendLayout();
            this.panl_Footer.SuspendLayout();
            this.grb_search.SuspendLayout();
            this.SuspendLayout();
            // 
            // panl_Header
            // 
            this.panl_Header.Size = new System.Drawing.Size(893, 47);
            // 
            // lbl_FormHeader
            // 
            this.lbl_FormHeader.Location = new System.Drawing.Point(529, 17);
            // 
            // panl_Footer
            // 
            this.panl_Footer.Location = new System.Drawing.Point(0, 333);
            this.panl_Footer.Size = new System.Drawing.Size(893, 70);
            // 
            // grb_search
            // 
            this.grb_search.Controls.Add(this.label7);
            this.grb_search.Controls.Add(this.dtp_toDate);
            this.grb_search.Controls.Add(this.dtp_fromDate);
            this.grb_search.Controls.Add(this.label6);
            this.grb_search.Controls.Add(this.btn_Search);
            this.grb_search.Controls.Add(this.lbl_Remaining);
            this.grb_search.Controls.Add(this.lbl_TotalAmount);
            this.grb_search.Controls.Add(this.lbl_Paid);
            this.grb_search.Controls.Add(this.label5);
            this.grb_search.Controls.Add(this.label4);
            this.grb_search.Controls.Add(this.label2);
            this.grb_search.Controls.Add(this.label1);
            this.grb_search.Controls.Add(this.label3);
            this.grb_search.Controls.Add(this.cbx_Customer);
            this.grb_search.Size = new System.Drawing.Size(893, 128);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(658, 6);
            // 
            // btn_Back
            // 
            this.btn_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Back.Location = new System.Drawing.Point(299, 6);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(553, 6);
            this.btn_Edit.Visible = false;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(448, 6);
            // 
            // cbx_Customer
            // 
            this.cbx_Customer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbx_Customer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_Customer.FormattingEnabled = true;
            this.cbx_Customer.Location = new System.Drawing.Point(572, 30);
            this.cbx_Customer.Name = "cbx_Customer";
            this.cbx_Customer.Size = new System.Drawing.Size(241, 24);
            this.cbx_Customer.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(834, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "أسم العميل";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(826, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "المبلغ الكلى ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(628, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "المدفوع";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(459, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "المتبقى";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.AliceBlue;
            this.label5.Location = new System.Drawing.Point(737, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 12;
            // 
            // lbl_Paid
            // 
            this.lbl_Paid.AutoSize = true;
            this.lbl_Paid.BackColor = System.Drawing.Color.AliceBlue;
            this.lbl_Paid.Location = new System.Drawing.Point(580, 98);
            this.lbl_Paid.Name = "lbl_Paid";
            this.lbl_Paid.Size = new System.Drawing.Size(15, 16);
            this.lbl_Paid.TabIndex = 13;
            this.lbl_Paid.Text = "0";
            // 
            // lbl_TotalAmount
            // 
            this.lbl_TotalAmount.AutoSize = true;
            this.lbl_TotalAmount.BackColor = System.Drawing.Color.AliceBlue;
            this.lbl_TotalAmount.Location = new System.Drawing.Point(782, 98);
            this.lbl_TotalAmount.Name = "lbl_TotalAmount";
            this.lbl_TotalAmount.Size = new System.Drawing.Size(15, 16);
            this.lbl_TotalAmount.TabIndex = 14;
            this.lbl_TotalAmount.Text = "0";
            // 
            // lbl_Remaining
            // 
            this.lbl_Remaining.AutoSize = true;
            this.lbl_Remaining.BackColor = System.Drawing.Color.AliceBlue;
            this.lbl_Remaining.Location = new System.Drawing.Point(403, 98);
            this.lbl_Remaining.Name = "lbl_Remaining";
            this.lbl_Remaining.Size = new System.Drawing.Size(15, 16);
            this.lbl_Remaining.TabIndex = 15;
            this.lbl_Remaining.Text = "0";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(6, 95);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 16;
            this.btn_Search.Text = "بحث";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(545, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 16);
            this.label7.TabIndex = 82;
            this.label7.Text = "الى";
            // 
            // dtp_toDate
            // 
            this.dtp_toDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_toDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_toDate.Location = new System.Drawing.Point(298, 61);
            this.dtp_toDate.Name = "dtp_toDate";
            this.dtp_toDate.RightToLeftLayout = true;
            this.dtp_toDate.Size = new System.Drawing.Size(241, 22);
            this.dtp_toDate.TabIndex = 81;
            // 
            // dtp_fromDate
            // 
            this.dtp_fromDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_fromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fromDate.Location = new System.Drawing.Point(572, 60);
            this.dtp_fromDate.Name = "dtp_fromDate";
            this.dtp_fromDate.RightToLeftLayout = true;
            this.dtp_fromDate.Size = new System.Drawing.Size(241, 22);
            this.dtp_fromDate.TabIndex = 80;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(819, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 79;
            this.label6.Text = "الفتره      من";
            // 
            // frmCustomerAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(893, 403);
            this.Name = "frmCustomerAccounts";
            this.Text = "حسابات العملة";
            this.panl_Header.ResumeLayout(false);
            this.panl_Header.PerformLayout();
            this.panl_Footer.ResumeLayout(false);
            this.grb_search.ResumeLayout(false);
            this.grb_search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_Customer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Remaining;
        private System.Windows.Forms.Label lbl_TotalAmount;
        private System.Windows.Forms.Label lbl_Paid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_toDate;
        private System.Windows.Forms.DateTimePicker dtp_fromDate;
        private System.Windows.Forms.Label label6;
    }
}
