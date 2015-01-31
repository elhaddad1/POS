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
            this.SuspendLayout();
            // 
            // lbl_FormHeader
            // 
            this.lbl_FormHeader.Location = new System.Drawing.Point(220, 17);
            // 
            // tbx_GroupName
            // 
            this.tbx_GroupName.Location = new System.Drawing.Point(93, 68);
            this.tbx_GroupName.Name = "tbx_GroupName";
            this.tbx_GroupName.Size = new System.Drawing.Size(307, 22);
            this.tbx_GroupName.TabIndex = 2;
            // 
            // lbl_GroupName
            // 
            this.lbl_GroupName.AutoSize = true;
            this.lbl_GroupName.Location = new System.Drawing.Point(8, 71);
            this.lbl_GroupName.Name = "lbl_GroupName";
            this.lbl_GroupName.Size = new System.Drawing.Size(69, 16);
            this.lbl_GroupName.TabIndex = 3;
            this.lbl_GroupName.Text = "أسم المجموعة";
            // 
            // frmUserGroupAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(485, 174);
            this.Controls.Add(this.lbl_GroupName);
            this.Controls.Add(this.tbx_GroupName);
            this.Name = "frmUserGroupAddEdit";
            this.Text = "أضافة / تعديل مجموعة";
            this.Controls.SetChildIndex(this.tbx_GroupName, 0);
            this.Controls.SetChildIndex(this.lbl_GroupName, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_GroupName;
        private System.Windows.Forms.Label lbl_GroupName;
    }
}
