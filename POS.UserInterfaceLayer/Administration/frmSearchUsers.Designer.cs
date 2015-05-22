namespace POS.UserInterfaceLayer.Administration
{
    partial class frmSearchUsers
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
            // panl_Header
            // 
            this.panl_Header.Size = new System.Drawing.Size(590, 47);
            // 
            // lbl_FormHeader
            // 
            this.lbl_FormHeader.Location = new System.Drawing.Point(279, 17);
            // 
            // panl_Footer
            // 
            this.panl_Footer.Location = new System.Drawing.Point(0, 351);
            this.panl_Footer.Size = new System.Drawing.Size(590, 70);
            // 
            // grb_search
            // 
            this.grb_search.Size = new System.Drawing.Size(590, 128);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(408, 6);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(93, 6);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(303, 6);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(198, 6);
            // 
            // frmSearchUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 421);
            this.ControlBox = false;
            this.Name = "frmSearchUsers";
            this.Text = "المستخدمين";
            this.panl_Header.ResumeLayout(false);
            this.panl_Header.PerformLayout();
            this.panl_Footer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}