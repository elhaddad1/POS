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
            this.OrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Orders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Orders
            // 
            this.dgv_Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select,
            this.OrderNumber,
            this.supplierName,
            this.InvoiceDate});
            this.dgv_Orders.Location = new System.Drawing.Point(0, 74);
            this.dgv_Orders.Name = "dgv_Orders";
            this.dgv_Orders.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_Orders.Size = new System.Drawing.Size(729, 335);
            this.dgv_Orders.TabIndex = 0;
            // 
            // select
            // 
            this.select.HeaderText = "أختر";
            this.select.Name = "select";
            // 
            // OrderNumber
            // 
            this.OrderNumber.DataPropertyName = "InvoiceNumber";
            this.OrderNumber.HeaderText = "رقم الفاتوره";
            this.OrderNumber.Name = "OrderNumber";
            // 
            // supplierName
            // 
            this.supplierName.DataPropertyName = "SupplierName";
            this.supplierName.HeaderText = "اسم المورد";
            this.supplierName.Name = "supplierName";
            // 
            // InvoiceDate
            // 
            this.InvoiceDate.DataPropertyName = "InvoiceDate";
            this.InvoiceDate.HeaderText = "التاريخ";
            this.InvoiceDate.Name = "InvoiceDate";
            // 
            // frmSelectSinglePurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 409);
            this.Controls.Add(this.dgv_Orders);
            this.Name = "frmSelectSinglePurchaseOrder";
            this.Text = "frmSelectSinglePurchaseOrder";
            this.Load += new System.EventHandler(this.frmSelectSinglePurchaseOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Orders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Orders;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceDate;
    }
}