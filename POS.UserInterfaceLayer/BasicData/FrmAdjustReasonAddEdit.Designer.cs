namespace POS.UserInterfaceLayer.BasicData
{
    partial class FrmAdjustReasonAddEdit
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
            this.txb_AdjustStockReason = new System.Windows.Forms.TextBox();
            this.panl_Header.SuspendLayout();
            this.panl_Footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panl_Header
            // 
            this.panl_Header.Size = new System.Drawing.Size(457, 53);
            // 
            // lbl_FormHeader
            // 
            this.lbl_FormHeader.Location = new System.Drawing.Point(160, 19);
            this.lbl_FormHeader.Size = new System.Drawing.Size(135, 19);
            this.lbl_FormHeader.Text = "اضافه\\تعديل سبب تسويه";
            // 
            // panl_Footer
            // 
            this.panl_Footer.Location = new System.Drawing.Point(0, 171);
            this.panl_Footer.Size = new System.Drawing.Size(457, 62);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(232, 4);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(127, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "سبب التسويه";
            // 
            // txb_AdjustStockReason
            // 
            this.txb_AdjustStockReason.Location = new System.Drawing.Point(126, 95);
            this.txb_AdjustStockReason.Name = "txb_AdjustStockReason";
            this.txb_AdjustStockReason.Size = new System.Drawing.Size(270, 22);
            this.txb_AdjustStockReason.TabIndex = 3;
            // 
            // FrmAdjustReasonAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 233);
            this.Controls.Add(this.txb_AdjustStockReason);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAdjustReasonAddEdit";
            this.Text = "اضافه\\تعديل سبب تسويه";
            this.Controls.SetChildIndex(this.panl_Header, 0);
            this.Controls.SetChildIndex(this.panl_Footer, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txb_AdjustStockReason, 0);
            this.panl_Header.ResumeLayout(false);
            this.panl_Header.PerformLayout();
            this.panl_Footer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_AdjustStockReason;
    }
}