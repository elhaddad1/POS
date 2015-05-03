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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_fromDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_toDate = new System.Windows.Forms.DateTimePicker();
            this.cbx_Inventory = new System.Windows.Forms.ComboBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.panl_Header.SuspendLayout();
            this.panl_Footer.SuspendLayout();
            this.grb_search.SuspendLayout();
            this.SuspendLayout();
            // 
            // panl_Header
            // 
            this.panl_Header.Size = new System.Drawing.Size(763, 47);
            // 
            // lbl_FormHeader
            // 
            this.lbl_FormHeader.Location = new System.Drawing.Point(453, 9);
            // 
            // panl_Footer
            // 
            this.panl_Footer.Controls.Add(this.btn_Close);
            this.panl_Footer.Location = new System.Drawing.Point(0, 391);
            this.panl_Footer.Size = new System.Drawing.Size(763, 62);
            this.panl_Footer.Controls.SetChildIndex(this.btn_Delete, 0);
            this.panl_Footer.Controls.SetChildIndex(this.btn_Edit, 0);
            this.panl_Footer.Controls.SetChildIndex(this.btn_Back, 0);
            this.panl_Footer.Controls.SetChildIndex(this.btn_Add, 0);
            this.panl_Footer.Controls.SetChildIndex(this.btn_Close, 0);
            // 
            // groupBox2
            // 
            this.grb_search.Controls.Add(this.cbx_Inventory);
            this.grb_search.Controls.Add(this.dtp_toDate);
            this.grb_search.Controls.Add(this.dtp_fromDate);
            this.grb_search.Controls.Add(this.label5);
            this.grb_search.Controls.Add(this.btn_Search);
            this.grb_search.Controls.Add(this.label4);
            this.grb_search.Controls.Add(this.label2);
            this.grb_search.Controls.Add(this.tbx_OrderSerial);
            this.grb_search.Controls.Add(this.tbx_SupplierName);
            this.grb_search.Controls.Add(this.label3);
            this.grb_search.Controls.Add(this.label1);
            this.grb_search.Size = new System.Drawing.Size(763, 128);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(663, 2);
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(246, 4);
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(558, 2);
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(453, 2);
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "مسلسل الفاتورة";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(649, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "أسم المورد";
            // 
            // tbx_OrderSerial
            // 
            this.tbx_OrderSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_OrderSerial.Location = new System.Drawing.Point(190, 93);
            this.tbx_OrderSerial.Name = "tbx_OrderSerial";
            this.tbx_OrderSerial.Size = new System.Drawing.Size(140, 22);
            this.tbx_OrderSerial.TabIndex = 18;
            // 
            // tbx_SupplierName
            // 
            this.tbx_SupplierName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_SupplierName.Location = new System.Drawing.Point(446, 93);
            this.tbx_SupplierName.Name = "tbx_SupplierName";
            this.tbx_SupplierName.Size = new System.Drawing.Size(180, 22);
            this.tbx_SupplierName.TabIndex = 17;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(6, 84);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 40);
            this.btn_Search.TabIndex = 19;
            this.btn_Search.Text = "بحث";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "إلي";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(637, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "الفتره      من";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(649, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "أسم المخزن";
            // 
            // dtp_fromDate
            // 
            this.dtp_fromDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_fromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fromDate.Location = new System.Drawing.Point(446, 55);
            this.dtp_fromDate.Name = "dtp_fromDate";
            this.dtp_fromDate.RightToLeftLayout = true;
            this.dtp_fromDate.Size = new System.Drawing.Size(180, 22);
            this.dtp_fromDate.TabIndex = 23;
            // 
            // dtp_toDate
            // 
            this.dtp_toDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_toDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_toDate.Location = new System.Drawing.Point(190, 56);
            this.dtp_toDate.Name = "dtp_toDate";
            this.dtp_toDate.RightToLeftLayout = true;
            this.dtp_toDate.Size = new System.Drawing.Size(140, 22);
            this.dtp_toDate.TabIndex = 24;
            // 
            // cbx_Inventory
            // 
            this.cbx_Inventory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_Inventory.FormattingEnabled = true;
            this.cbx_Inventory.Location = new System.Drawing.Point(446, 14);
            this.cbx_Inventory.Name = "cbx_Inventory";
            this.cbx_Inventory.Size = new System.Drawing.Size(180, 24);
            this.cbx_Inventory.TabIndex = 25;
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(351, 5);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(97, 53);
            this.btn_Close.TabIndex = 9;
            this.btn_Close.Text = "إغلاق";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // frmPurchaseOrderSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(763, 453);
            this.Name = "frmPurchaseOrderSearch";
            this.Text = "بحث فواتير الشراء";
            this.Load += new System.EventHandler(this.frmPurchaseOrderSearch_Load);
            this.panl_Header.ResumeLayout(false);
            this.panl_Header.PerformLayout();
            this.panl_Footer.ResumeLayout(false);
            this.grb_search.ResumeLayout(false);
            this.grb_search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_OrderSerial;
        private System.Windows.Forms.TextBox tbx_SupplierName;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ComboBox cbx_Inventory;
        private System.Windows.Forms.DateTimePicker dtp_toDate;
        private System.Windows.Forms.DateTimePicker dtp_fromDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Close;
    }
}
