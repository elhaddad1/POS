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
            this.lbl_StoreName = new System.Windows.Forms.Label();
            this.lbl_TransferDate = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.ddl_InventoryName = new System.Windows.Forms.ComboBox();
            this.dtp_TransferDate = new System.Windows.Forms.DateTimePicker();
            this.panl_Header.SuspendLayout();
            this.panl_Footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panl_Header
            // 
            this.panl_Header.Size = new System.Drawing.Size(854, 53);
            // 
            // lbl_FormHeader
            // 
            this.lbl_FormHeader.Location = new System.Drawing.Point(1164, 20);
            // 
            // panl_Footer
            // 
            this.panl_Footer.Location = new System.Drawing.Point(0, 423);
            this.panl_Footer.Size = new System.Drawing.Size(854, 67);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(486, 12);
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click_1);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(12, 9);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(381, 12);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(850, 6);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(266, 9);
            // 
            // lbl_StoreName
            // 
            this.lbl_StoreName.AutoSize = true;
            this.lbl_StoreName.Location = new System.Drawing.Point(12, 67);
            this.lbl_StoreName.Name = "lbl_StoreName";
            this.lbl_StoreName.Size = new System.Drawing.Size(59, 16);
            this.lbl_StoreName.TabIndex = 6;
            this.lbl_StoreName.Text = "اسم المخزن";
            // 
            // lbl_TransferDate
            // 
            this.lbl_TransferDate.AutoSize = true;
            this.lbl_TransferDate.Location = new System.Drawing.Point(16, 98);
            this.lbl_TransferDate.Name = "lbl_TransferDate";
            this.lbl_TransferDate.Size = new System.Drawing.Size(69, 16);
            this.lbl_TransferDate.TabIndex = 7;
            this.lbl_TransferDate.Text = "تاريخ التحويل";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(12, 126);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(99, 55);
            this.btn_search.TabIndex = 8;
            this.btn_search.Text = "بحث";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // ddl_InventoryName
            // 
            this.ddl_InventoryName.FormattingEnabled = true;
            this.ddl_InventoryName.Location = new System.Drawing.Point(106, 67);
            this.ddl_InventoryName.Name = "ddl_InventoryName";
            this.ddl_InventoryName.Size = new System.Drawing.Size(206, 24);
            this.ddl_InventoryName.TabIndex = 9;
            // 
            // dtp_TransferDate
            // 
            this.dtp_TransferDate.Location = new System.Drawing.Point(106, 98);
            this.dtp_TransferDate.Name = "dtp_TransferDate";
            this.dtp_TransferDate.Size = new System.Drawing.Size(206, 22);
            this.dtp_TransferDate.TabIndex = 10;
            // 
            // FrmTransferOrderSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(854, 490);
            this.Controls.Add(this.dtp_TransferDate);
            this.Controls.Add(this.ddl_InventoryName);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.lbl_TransferDate);
            this.Controls.Add(this.lbl_StoreName);
            this.Name = "FrmTransferOrderSearch";
            this.Controls.SetChildIndex(this.panl_Header, 0);
            this.Controls.SetChildIndex(this.panl_Footer, 0);
            this.Controls.SetChildIndex(this.lbl_StoreName, 0);
            this.Controls.SetChildIndex(this.lbl_TransferDate, 0);
            this.Controls.SetChildIndex(this.btn_search, 0);
            this.Controls.SetChildIndex(this.ddl_InventoryName, 0);
            this.Controls.SetChildIndex(this.dtp_TransferDate, 0);
            this.panl_Header.ResumeLayout(false);
            this.panl_Header.PerformLayout();
            this.panl_Footer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_StoreName;
        private System.Windows.Forms.Label lbl_TransferDate;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox ddl_InventoryName;
        private System.Windows.Forms.DateTimePicker dtp_TransferDate;
    }
}
