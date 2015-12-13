namespace POS.UserInterfaceLayer.Purcase
{
    partial class frmSelectSinglePurchaseOrder
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
            this.dgv_Orders = new System.Windows.Forms.DataGridView();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_InvoiceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_InvoiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_PurchaseHeaderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Orders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Orders
            // 
            this.dgv_Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select,
            this.col_InvoiceNumber,
            this.col_InvoiceDate,
            this.col_SupplierName,
            this.Col_PurchaseHeaderID});
            this.dgv_Orders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Orders.Location = new System.Drawing.Point(0, 0);
            this.dgv_Orders.Name = "dgv_Orders";
            this.dgv_Orders.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_Orders.Size = new System.Drawing.Size(499, 311);
            this.dgv_Orders.TabIndex = 0;
            this.dgv_Orders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Orders_CellContentClick);
            // 
            // select
            // 
            this.select.HeaderText = "أختر";
            this.select.Name = "select";
            // 
            // col_InvoiceNumber
            // 
            this.col_InvoiceNumber.DataPropertyName = "InvoiceNumber";
            this.col_InvoiceNumber.HeaderText = "رقم الفاتوره";
            this.col_InvoiceNumber.Name = "col_InvoiceNumber";
            // 
            // col_InvoiceDate
            // 
            this.col_InvoiceDate.DataPropertyName = "InvoiceDate";
            this.col_InvoiceDate.HeaderText = "تاريخ الفاتوره";
            this.col_InvoiceDate.Name = "col_InvoiceDate";
            // 
            // col_SupplierName
            // 
            this.col_SupplierName.DataPropertyName = "SupplierName";
            this.col_SupplierName.HeaderText = "اسم المورد";
            this.col_SupplierName.Name = "col_SupplierName";
            this.col_SupplierName.Width = 150;
            // 
            // Col_PurchaseHeaderID
            // 
            this.Col_PurchaseHeaderID.DataPropertyName = "PurchaseHeaderID";
            this.Col_PurchaseHeaderID.HeaderText = "HeaderID";
            this.Col_PurchaseHeaderID.Name = "Col_PurchaseHeaderID";
            this.Col_PurchaseHeaderID.Visible = false;
            // 
            // frmSelectSinglePurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 311);
            this.Controls.Add(this.dgv_Orders);
            this.Name = "frmSelectSinglePurchaseOrder";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "اختر من الفواتير التاليه";
            this.Load += new System.EventHandler(this.frmSelectSinglePurchaseOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Orders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Orders;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_InvoiceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_InvoiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_PurchaseHeaderID;
    }
}