namespace POS.UserInterfaceLayer.Transfer
{
    partial class FrmTransferOrderSearch
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
            this.cbx_StoreTo = new System.Windows.Forms.ComboBox();
            this.cbx_StoreFrom = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.tbx_OrderSerial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panl_Header.Size = new System.Drawing.Size(698, 47);
            // 
            // lbl_FormHeader
            // 
            this.lbl_FormHeader.Location = new System.Drawing.Point(333, 17);
            // 
            // panl_Footer
            // 
            this.panl_Footer.Location = new System.Drawing.Point(0, 333);
            this.panl_Footer.Size = new System.Drawing.Size(698, 70);
            // 
            // grb_search
            // 
            this.grb_search.Controls.Add(this.label7);
            this.grb_search.Controls.Add(this.dtp_toDate);
            this.grb_search.Controls.Add(this.dtp_fromDate);
            this.grb_search.Controls.Add(this.label6);
            this.grb_search.Controls.Add(this.tbx_OrderSerial);
            this.grb_search.Controls.Add(this.label1);
            this.grb_search.Controls.Add(this.btn_Close);
            this.grb_search.Controls.Add(this.button2);
            this.grb_search.Controls.Add(this.button1);
            this.grb_search.Controls.Add(this.cbx_StoreTo);
            this.grb_search.Controls.Add(this.cbx_StoreFrom);
            this.grb_search.Controls.Add(this.label3);
            this.grb_search.Controls.Add(this.label2);
            this.grb_search.Size = new System.Drawing.Size(698, 128);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(462, 6);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(147, 6);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(357, 6);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(252, 6);
            // 
            // cbx_StoreTo
            // 
            this.cbx_StoreTo.FormattingEnabled = true;
            this.cbx_StoreTo.Location = new System.Drawing.Point(349, 13);
            this.cbx_StoreTo.Name = "cbx_StoreTo";
            this.cbx_StoreTo.Size = new System.Drawing.Size(241, 24);
            this.cbx_StoreTo.TabIndex = 13;
            // 
            // cbx_StoreFrom
            // 
            this.cbx_StoreFrom.FormattingEnabled = true;
            this.cbx_StoreFrom.Location = new System.Drawing.Point(349, 41);
            this.cbx_StoreFrom.Name = "cbx_StoreFrom";
            this.cbx_StoreFrom.Size = new System.Drawing.Size(241, 24);
            this.cbx_StoreFrom.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(600, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "المخزن المحول منه";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(600, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "المخزن المحول اليه";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 14;
            this.button1.Text = "بحث";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 15;
            this.button2.Text = "إلغاء البحث";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(12, 84);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 29);
            this.btn_Close.TabIndex = 20;
            this.btn_Close.Text = "أغلاق";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // tbx_OrderSerial
            // 
            this.tbx_OrderSerial.Location = new System.Drawing.Point(349, 71);
            this.tbx_OrderSerial.Name = "tbx_OrderSerial";
            this.tbx_OrderSerial.Size = new System.Drawing.Size(241, 22);
            this.tbx_OrderSerial.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(616, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "مسلسل الفاتورة";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 16);
            this.label7.TabIndex = 82;
            this.label7.Text = "الى";
            // 
            // dtp_toDate
            // 
            this.dtp_toDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_toDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_toDate.Location = new System.Drawing.Point(93, 100);
            this.dtp_toDate.Name = "dtp_toDate";
            this.dtp_toDate.RightToLeftLayout = true;
            this.dtp_toDate.Size = new System.Drawing.Size(241, 22);
            this.dtp_toDate.TabIndex = 81;
            // 
            // dtp_fromDate
            // 
            this.dtp_fromDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_fromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fromDate.Location = new System.Drawing.Point(367, 99);
            this.dtp_fromDate.Name = "dtp_fromDate";
            this.dtp_fromDate.RightToLeftLayout = true;
            this.dtp_fromDate.Size = new System.Drawing.Size(241, 22);
            this.dtp_fromDate.TabIndex = 80;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(614, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 79;
            this.label6.Text = "الفتره      من";
            // 
            // FrmTransferOrderSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(698, 403);
            this.Name = "FrmTransferOrderSearch";
            this.panl_Header.ResumeLayout(false);
            this.panl_Header.PerformLayout();
            this.panl_Footer.ResumeLayout(false);
            this.grb_search.ResumeLayout(false);
            this.grb_search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbx_StoreTo;
        private System.Windows.Forms.ComboBox cbx_StoreFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.TextBox tbx_OrderSerial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_toDate;
        private System.Windows.Forms.DateTimePicker dtp_fromDate;
        private System.Windows.Forms.Label label6;

    }
}
