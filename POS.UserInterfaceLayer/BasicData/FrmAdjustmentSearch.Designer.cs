namespace POS.UserInterfaceLayer.BasicData
{
    partial class FrmAdjustmentSearch
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
            this.panl_Header.SuspendLayout();
            this.panl_Footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Edit
            // 
            this.btn_Edit.Visible = false;
            // 
            // FrmAdjustmentSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(646, 595);
            this.Name = "FrmAdjustmentSearch";
            this.Text = "اسباب التسويه";
            this.Load += new System.EventHandler(this.FrmAdjustmentSearch_Load);
            this.panl_Header.ResumeLayout(false);
            this.panl_Header.PerformLayout();
            this.panl_Footer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tbx_ProductName;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_StockTypeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_AdjustName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_InventoryName;

    }
}
