namespace POS.UserInterfaceLayer.BasicData
{
    partial class frmProductGroupAddEdit
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
            this.lbl_GroupName = new System.Windows.Forms.Label();
            this.lbl_Notes = new System.Windows.Forms.Label();
            this.txt_GroupName = new System.Windows.Forms.TextBox();
            this.txt_Notes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_FormHeader
            // 
            this.lbl_FormHeader.Location = new System.Drawing.Point(938, 9);
            // 
            // lbl_GroupName
            // 
            this.lbl_GroupName.AutoSize = true;
            this.lbl_GroupName.Location = new System.Drawing.Point(144, 110);
            this.lbl_GroupName.Name = "lbl_GroupName";
            this.lbl_GroupName.Size = new System.Drawing.Size(69, 16);
            this.lbl_GroupName.TabIndex = 2;
            this.lbl_GroupName.Text = "اسم المجموعة";
            // 
            // lbl_Notes
            // 
            this.lbl_Notes.AutoSize = true;
            this.lbl_Notes.Location = new System.Drawing.Point(144, 154);
            this.lbl_Notes.Name = "lbl_Notes";
            this.lbl_Notes.Size = new System.Drawing.Size(51, 16);
            this.lbl_Notes.TabIndex = 3;
            this.lbl_Notes.Text = "الملاحظات";
            // 
            // txt_GroupName
            // 
            this.txt_GroupName.Location = new System.Drawing.Point(270, 104);
            this.txt_GroupName.Name = "txt_GroupName";
            this.txt_GroupName.Size = new System.Drawing.Size(420, 22);
            this.txt_GroupName.TabIndex = 4;
            // 
            // txt_Notes
            // 
            this.txt_Notes.Location = new System.Drawing.Point(270, 154);
            this.txt_Notes.Multiline = true;
            this.txt_Notes.Name = "txt_Notes";
            this.txt_Notes.Size = new System.Drawing.Size(420, 97);
            this.txt_Notes.TabIndex = 5;
            // 
            // frmProductGroupAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(883, 322);
            this.Controls.Add(this.txt_Notes);
            this.Controls.Add(this.txt_GroupName);
            this.Controls.Add(this.lbl_Notes);
            this.Controls.Add(this.lbl_GroupName);
            this.Name = "frmProductGroupAddEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مجموعات الأصناف";
            this.Controls.SetChildIndex(this.lbl_GroupName, 0);
            this.Controls.SetChildIndex(this.lbl_Notes, 0);
            this.Controls.SetChildIndex(this.txt_GroupName, 0);
            this.Controls.SetChildIndex(this.txt_Notes, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_GroupName;
        private System.Windows.Forms.Label lbl_Notes;
        private System.Windows.Forms.TextBox txt_GroupName;
        private System.Windows.Forms.TextBox txt_Notes;

    }
}
