namespace POS.UserInterfaceLayer.Administration
{
    partial class frmUserGroupAddEdit
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
            this.tbx_GroupName = new System.Windows.Forms.TextBox();
            this.lbl_GroupName = new System.Windows.Forms.Label();
            this.panl_Header.SuspendLayout();
            this.panl_Footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panl_Header
            // 
            this.panl_Header.Size = new System.Drawing.Size(399, 53);
            // 
            // lbl_FormHeader
            // 
            this.lbl_FormHeader.Location = new System.Drawing.Point(177, 9);
            // 
            // panl_Footer
            // 
            this.panl_Footer.Location = new System.Drawing.Point(0, 112);
            this.panl_Footer.Size = new System.Drawing.Size(399, 62);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(203, 3);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(98, 3);
            // 
            // tbx_GroupName
            // 
            this.tbx_GroupName.Location = new System.Drawing.Point(89, 68);
            this.tbx_GroupName.Name = "tbx_GroupName";
            this.tbx_GroupName.Size = new System.Drawing.Size(307, 22);
            this.tbx_GroupName.TabIndex = 2;
            // 
            // lbl_GroupName
            // 
            this.lbl_GroupName.AutoSize = true;
            this.lbl_GroupName.Location = new System.Drawing.Point(4, 71);
            this.lbl_GroupName.Name = "lbl_GroupName";
            this.lbl_GroupName.Size = new System.Drawing.Size(69, 16);
            this.lbl_GroupName.TabIndex = 3;
            this.lbl_GroupName.Text = "أسم المجموعة";
            // 
            // frmUserGroupAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(399, 174);
            this.Controls.Add(this.lbl_GroupName);
            this.Controls.Add(this.tbx_GroupName);
            this.Name = "frmUserGroupAddEdit";
            this.Text = "أضافة / تعديل مجموعة";
            this.Controls.SetChildIndex(this.panl_Header, 0);
            this.Controls.SetChildIndex(this.panl_Footer, 0);
            this.Controls.SetChildIndex(this.tbx_GroupName, 0);
            this.Controls.SetChildIndex(this.lbl_GroupName, 0);
            this.panl_Header.ResumeLayout(false);
            this.panl_Header.PerformLayout();
            this.panl_Footer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_GroupName;
        private System.Windows.Forms.Label lbl_GroupName;
    }
}
