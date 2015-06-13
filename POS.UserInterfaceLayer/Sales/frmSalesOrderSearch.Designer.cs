namespace POS.UserInterfaceLayer.Sales
{
    partial class frmSalesOrderSearch
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
            this.tbx_OrderSerial = new System.Windows.Forms.TextBox();
            this.tbx_CustomerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_AddCustomer = new System.Windows.Forms.Button();
            this.panl_Header.SuspendLayout();
            this.panl_Footer.SuspendLayout();
            this.grb_search.SuspendLayout();
            this.SuspendLayout();
            // 
            // panl_Header
            // 
            this.panl_Header.Size = new System.Drawing.Size(704, 47);
            // 
            // lbl_FormHeader
            // 
            this.lbl_FormHeader.Location = new System.Drawing.Point(552, 17);
            // 
            // panl_Footer
            // 
            this.panl_Footer.Controls.Add(this.btn_AddCustomer);
            this.panl_Footer.Controls.Add(this.btn_Close);
            this.panl_Footer.Location = new System.Drawing.Point(0, 389);
            this.panl_Footer.Size = new System.Drawing.Size(704, 62);
            this.panl_Footer.Controls.SetChildIndex(this.btn_Delete, 0);
            this.panl_Footer.Controls.SetChildIndex(this.btn_Edit, 0);
            this.panl_Footer.Controls.SetChildIndex(this.btn_Back, 0);
            this.panl_Footer.Controls.SetChildIndex(this.btn_Add, 0);
            this.panl_Footer.Controls.SetChildIndex(this.btn_Close, 0);
            this.panl_Footer.Controls.SetChildIndex(this.btn_AddCustomer, 0);
            // 
            // grb_search
            // 
            this.grb_search.Controls.Add(this.tbx_OrderSerial);
            this.grb_search.Controls.Add(this.tbx_CustomerName);
            this.grb_search.Controls.Add(this.label3);
            this.grb_search.Controls.Add(this.label1);
            this.grb_search.Controls.Add(this.btn_Search);
            this.grb_search.Size = new System.Drawing.Size(704, 87);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Add.Location = new System.Drawing.Point(570, 3);
            // 
            // btn_Back
            // 
            this.btn_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Back.Location = new System.Drawing.Point(35, 3);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Edit.Location = new System.Drawing.Point(463, 3);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Delete.Location = new System.Drawing.Point(356, 3);
            // 
            // tbx_OrderSerial
            // 
            this.tbx_OrderSerial.Location = new System.Drawing.Point(364, 43);
            this.tbx_OrderSerial.Name = "tbx_OrderSerial";
            this.tbx_OrderSerial.Size = new System.Drawing.Size(247, 22);
            this.tbx_OrderSerial.TabIndex = 16;
            // 
            // tbx_CustomerName
            // 
            this.tbx_CustomerName.Location = new System.Drawing.Point(364, 15);
            this.tbx_CustomerName.Name = "tbx_CustomerName";
            this.tbx_CustomerName.Size = new System.Drawing.Size(247, 22);
            this.tbx_CustomerName.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(617, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "مسلسل الفاتورة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(638, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "أسم العميل";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(249, 43);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 24);
            this.btn_Search.TabIndex = 17;
            this.btn_Search.Text = "بحث";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(249, 3);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(99, 55);
            this.btn_Close.TabIndex = 19;
            this.btn_Close.Text = "أغلاق";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_AddCustomer
            // 
            this.btn_AddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddCustomer.Location = new System.Drawing.Point(142, 3);
            this.btn_AddCustomer.Name = "btn_AddCustomer";
            this.btn_AddCustomer.Size = new System.Drawing.Size(99, 55);
            this.btn_AddCustomer.TabIndex = 18;
            this.btn_AddCustomer.Text = "أضافة عميل";
            this.btn_AddCustomer.UseVisualStyleBackColor = true;
            this.btn_AddCustomer.Click += new System.EventHandler(this.btn_AddCustomer_Click);
            // 
            // frmSalesOrderSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(704, 451);
            this.Name = "frmSalesOrderSearch";
            this.Text = "قائمة الفواتير";
            this.panl_Header.ResumeLayout(false);
            this.panl_Header.PerformLayout();
            this.panl_Footer.ResumeLayout(false);
            this.grb_search.ResumeLayout(false);
            this.grb_search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_OrderSerial;
        private System.Windows.Forms.TextBox tbx_CustomerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_AddCustomer;
    }
}
