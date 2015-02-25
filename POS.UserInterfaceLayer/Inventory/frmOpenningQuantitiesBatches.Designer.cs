namespace POS.UserInterfaceLayer.Inventory
{
    partial class frmOpenningQuantitiesBatches
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
            this.lbl_FormHeader = new System.Windows.Forms.Label();
            this.panl_Header = new System.Windows.Forms.Panel();
            this.dgrd_Batches = new System.Windows.Forms.DataGridView();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.BatchNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panl_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrd_Batches)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_FormHeader
            // 
            this.lbl_FormHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_FormHeader.AutoSize = true;
            this.lbl_FormHeader.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FormHeader.Location = new System.Drawing.Point(170, 25);
            this.lbl_FormHeader.Name = "lbl_FormHeader";
            this.lbl_FormHeader.Size = new System.Drawing.Size(60, 19);
            this.lbl_FormHeader.TabIndex = 0;
            this.lbl_FormHeader.Text = "التشغيلات";
            // 
            // panl_Header
            // 
            this.panl_Header.BackColor = System.Drawing.Color.MintCream;
            this.panl_Header.Controls.Add(this.lbl_FormHeader);
            this.panl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panl_Header.Location = new System.Drawing.Point(0, 0);
            this.panl_Header.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panl_Header.Name = "panl_Header";
            this.panl_Header.Size = new System.Drawing.Size(384, 65);
            this.panl_Header.TabIndex = 4;
            // 
            // dgrd_Batches
            // 
            this.dgrd_Batches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrd_Batches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BatchNumber,
            this.ExpiryDate,
            this.Qty});
            this.dgrd_Batches.Location = new System.Drawing.Point(6, 69);
            this.dgrd_Batches.Name = "dgrd_Batches";
            this.dgrd_Batches.RowHeadersVisible = false;
            this.dgrd_Batches.Size = new System.Drawing.Size(372, 146);
            this.dgrd_Batches.TabIndex = 55;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(197, 221);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 35);
            this.btn_Cancel.TabIndex = 57;
            this.btn_Cancel.Text = "رجوع";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(114, 221);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 35);
            this.btn_Save.TabIndex = 56;
            this.btn_Save.Text = "حفظ";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // BatchNumber
            // 
            this.BatchNumber.HeaderText = "رقم التشغيلة";
            this.BatchNumber.Name = "BatchNumber";
            this.BatchNumber.Width = 120;
            // 
            // ExpiryDate
            // 
            this.ExpiryDate.HeaderText = "تاريخ الصلاحيه";
            this.ExpiryDate.Name = "ExpiryDate";
            this.ExpiryDate.Width = 140;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "الكمية";
            this.Qty.Name = "Qty";
            this.Qty.Width = 105;
            // 
            // frmOpenningQuantitiesBatches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.dgrd_Batches);
            this.Controls.Add(this.panl_Header);
            this.Name = "frmOpenningQuantitiesBatches";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "التشغيلات";
            this.panl_Header.ResumeLayout(false);
            this.panl_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrd_Batches)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label lbl_FormHeader;
        protected System.Windows.Forms.Panel panl_Header;
        private System.Windows.Forms.DataGridView dgrd_Batches;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
    }
}