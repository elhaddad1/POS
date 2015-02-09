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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_CustomerName = new System.Windows.Forms.TextBox();
            this.tbx_OrderSerial = new System.Windows.Forms.TextBox();
            this.tbx_OrderDate = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panl_Header.SuspendLayout();
            this.panl_Footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panl_Header
            // 
            this.panl_Header.Size = new System.Drawing.Size(644, 53);
            // 
            // lbl_FormHeader
            // 
            this.lbl_FormHeader.Location = new System.Drawing.Point(519, 20);
            // 
            // panl_Footer
            // 
            this.panl_Footer.AllowDrop = true;
            this.panl_Footer.AutoSize = true;
            this.panl_Footer.Controls.Add(this.button1);
            this.panl_Footer.Location = new System.Drawing.Point(0, 130);
            this.panl_Footer.Size = new System.Drawing.Size(644, 65);
            this.panl_Footer.Controls.SetChildIndex(this.button1, 0);
            this.panl_Footer.Controls.SetChildIndex(this.btn_Add, 0);
            this.panl_Footer.Controls.SetChildIndex(this.btn_Edit, 0);
            this.panl_Footer.Controls.SetChildIndex(this.btn_Delete, 0);
            this.panl_Footer.Controls.SetChildIndex(this.btn_Back, 0);
            this.panl_Footer.Controls.SetChildIndex(this.btn_Close, 0);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(481, 5);
            this.btn_Add.Text = "فتح فاتورة";
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(53, 5);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(267, 5);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(374, 5);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(160, 5);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "تاريخ البيع";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "مسلسل الفاتورة";
            // 
            // tbx_CustomerName
            // 
            this.tbx_CustomerName.Location = new System.Drawing.Point(70, 59);
            this.tbx_CustomerName.Name = "tbx_CustomerName";
            this.tbx_CustomerName.Size = new System.Drawing.Size(196, 22);
            this.tbx_CustomerName.TabIndex = 9;
            // 
            // tbx_OrderSerial
            // 
            this.tbx_OrderSerial.Location = new System.Drawing.Point(357, 59);
            this.tbx_OrderSerial.Name = "tbx_OrderSerial";
            this.tbx_OrderSerial.Size = new System.Drawing.Size(196, 22);
            this.tbx_OrderSerial.TabIndex = 10;
            // 
            // tbx_OrderDate
            // 
            this.tbx_OrderDate.Location = new System.Drawing.Point(70, 98);
            this.tbx_OrderDate.Name = "tbx_OrderDate";
            this.tbx_OrderDate.Size = new System.Drawing.Size(196, 22);
            this.tbx_OrderDate.TabIndex = 11;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(357, 87);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 40);
            this.btn_Search.TabIndex = 12;
            this.btn_Search.Text = "بحث";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(541, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 62);
            this.button1.TabIndex = 6;
            this.button1.Text = "أضافة عميل";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmSalesOrderSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(644, 407);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tbx_OrderDate);
            this.Controls.Add(this.tbx_OrderSerial);
            this.Controls.Add(this.tbx_CustomerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSalesOrderSearch";
            this.Controls.SetChildIndex(this.panl_Header, 0);
            this.Controls.SetChildIndex(this.panl_Footer, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.tbx_CustomerName, 0);
            this.Controls.SetChildIndex(this.tbx_OrderSerial, 0);
            this.Controls.SetChildIndex(this.tbx_OrderDate, 0);
            this.Controls.SetChildIndex(this.btn_Search, 0);
            this.panl_Header.ResumeLayout(false);
            this.panl_Header.PerformLayout();
            this.panl_Footer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_CustomerName;
        private System.Windows.Forms.TextBox tbx_OrderSerial;
        private System.Windows.Forms.TextBox tbx_OrderDate;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button button1;
    }
}
