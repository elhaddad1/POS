namespace POS.UserInterfaceLayer.Transfer
{
    partial class _FrmTransferOrderSearch
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
            this.dtp_TransferDate = new System.Windows.Forms.DateTimePicker();
            this.ddl_InventoryName = new System.Windows.Forms.ComboBox();
            this.lbl_TransferDate = new System.Windows.Forms.Label();
            this.lbl_StoreName = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.panl_Header.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_search);
            this.groupBox2.Controls.Add(this.dtp_TransferDate);
            this.groupBox2.Controls.Add(this.ddl_InventoryName);
            this.groupBox2.Controls.Add(this.lbl_TransferDate);
            this.groupBox2.Controls.Add(this.lbl_StoreName);
            this.groupBox2.Size = new System.Drawing.Size(698, 84);
            // 
            // dtp_TransferDate
            // 
            this.dtp_TransferDate.Location = new System.Drawing.Point(395, 46);
            this.dtp_TransferDate.Name = "dtp_TransferDate";
            this.dtp_TransferDate.Size = new System.Drawing.Size(206, 22);
            this.dtp_TransferDate.TabIndex = 14;
            // 
            // ddl_InventoryName
            // 
            this.ddl_InventoryName.FormattingEnabled = true;
            this.ddl_InventoryName.Location = new System.Drawing.Point(395, 13);
            this.ddl_InventoryName.Name = "ddl_InventoryName";
            this.ddl_InventoryName.Size = new System.Drawing.Size(206, 24);
            this.ddl_InventoryName.TabIndex = 13;
            // 
            // lbl_TransferDate
            // 
            this.lbl_TransferDate.AutoSize = true;
            this.lbl_TransferDate.Location = new System.Drawing.Point(623, 52);
            this.lbl_TransferDate.Name = "lbl_TransferDate";
            this.lbl_TransferDate.Size = new System.Drawing.Size(69, 16);
            this.lbl_TransferDate.TabIndex = 12;
            this.lbl_TransferDate.Text = "تاريخ التحويل";
            // 
            // lbl_StoreName
            // 
            this.lbl_StoreName.AutoSize = true;
            this.lbl_StoreName.Location = new System.Drawing.Point(633, 21);
            this.lbl_StoreName.Name = "lbl_StoreName";
            this.lbl_StoreName.Size = new System.Drawing.Size(59, 16);
            this.lbl_StoreName.TabIndex = 11;
            this.lbl_StoreName.Text = "اسم المخزن";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(6, 21);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(99, 33);
            this.btn_search.TabIndex = 15;
            this.btn_search.Text = "بحث";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // _FrmTransferOrderSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(698, 403);
            this.Name = "_FrmTransferOrderSearch";
            this.panl_Header.ResumeLayout(false);
            this.panl_Header.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_TransferDate;
        private System.Windows.Forms.ComboBox ddl_InventoryName;
        private System.Windows.Forms.Label lbl_TransferDate;
        private System.Windows.Forms.Label lbl_StoreName;
        private System.Windows.Forms.Button btn_search;
    }
}
