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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_CustomerName = new System.Windows.Forms.TextBox();
            this.tbx_OrderSerial = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_AddCustomer = new System.Windows.Forms.Button();
            this.panl_Header.SuspendLayout();
            this.panl_Footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panl_Header
            // 
            this.panl_Header.Size = new System.Drawing.Size(602, 53);
            // 
            // lbl_FormHeader
            // 
            this.lbl_FormHeader.Location = new System.Drawing.Point(463, 20);
            // 
            // panl_Footer
            // 
            this.panl_Footer.AllowDrop = true;
            this.panl_Footer.AutoSize = true;
            this.panl_Footer.Controls.Add(this.btn_AddCustomer);
            this.panl_Footer.Location = new System.Drawing.Point(0, 347);
            this.panl_Footer.Size = new System.Drawing.Size(602, 64);
            this.panl_Footer.Controls.SetChildIndex(this.btn_AddCustomer, 0);
            this.panl_Footer.Controls.SetChildIndex(this.btn_Add, 0);
            this.panl_Footer.Controls.SetChildIndex(this.btn_Edit, 0);
            this.panl_Footer.Controls.SetChildIndex(this.btn_Delete, 0);
            this.panl_Footer.Controls.SetChildIndex(this.btn_Back, 0);
            this.panl_Footer.Controls.SetChildIndex(this.btn_Close, 0);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(505, 4);
            this.btn_Add.Text = "فتح فاتورة";
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(77, 4);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(291, 4);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(398, 4);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(184, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "أسم العميل";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "مسلسل الفاتورة";
            // 
            // tbx_CustomerName
            // 
            this.tbx_CustomerName.Location = new System.Drawing.Point(93, 59);
            this.tbx_CustomerName.Name = "tbx_CustomerName";
            this.tbx_CustomerName.Size = new System.Drawing.Size(247, 22);
            this.tbx_CustomerName.TabIndex = 9;
            // 
            // tbx_OrderSerial
            // 
            this.tbx_OrderSerial.Location = new System.Drawing.Point(93, 94);
            this.tbx_OrderSerial.Name = "tbx_OrderSerial";
            this.tbx_OrderSerial.Size = new System.Drawing.Size(247, 22);
            this.tbx_OrderSerial.TabIndex = 10;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(449, 83);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 40);
            this.btn_Search.TabIndex = 12;
            this.btn_Search.Text = "بحث";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_AddCustomer
            // 
            this.btn_AddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddCustomer.Location = new System.Drawing.Point(10, 6);
            this.btn_AddCustomer.Name = "btn_AddCustomer";
            this.btn_AddCustomer.Size = new System.Drawing.Size(99, 55);
            this.btn_AddCustomer.TabIndex = 6;
            this.btn_AddCustomer.Text = "أضافة عميل";
            this.btn_AddCustomer.UseVisualStyleBackColor = true;
            this.btn_AddCustomer.Click += new System.EventHandler(this.btn_AddCustomer_Click);
            // 
            // frmSalesOrderSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(602, 411);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tbx_OrderSerial);
            this.Controls.Add(this.tbx_CustomerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmSalesOrderSearch";
            this.Controls.SetChildIndex(this.panl_Header, 0);
            this.Controls.SetChildIndex(this.panl_Footer, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.tbx_CustomerName, 0);
            this.Controls.SetChildIndex(this.tbx_OrderSerial, 0);
            this.Controls.SetChildIndex(this.btn_Search, 0);
            this.panl_Header.ResumeLayout(false);
            this.panl_Header.PerformLayout();
            this.panl_Footer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_CustomerName;
        private System.Windows.Forms.TextBox tbx_OrderSerial;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_AddCustomer;
    }
}
