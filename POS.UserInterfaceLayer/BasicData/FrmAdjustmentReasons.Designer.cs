namespace POS.UserInterfaceLayer.BasicData
{
    partial class FrmAdjustmentReasons
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
            this.SuspendLayout();
            // 
            // lbl_FormHeader
            // 
            this.lbl_FormHeader.Location = new System.Drawing.Point(270, 20);
            this.lbl_FormHeader.Size = new System.Drawing.Size(85, 19);
            this.lbl_FormHeader.Text = "اسباب التسويه";
            // 
            // FrmAdjustmentReasons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 495);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAdjustmentReasons";
            this.Text = "أسباب التسويه";
            this.Load += new System.EventHandler(this.FrmAdjustmentReasons_Load);
            this.ResumeLayout(false);

        }

        #endregion


    }
}