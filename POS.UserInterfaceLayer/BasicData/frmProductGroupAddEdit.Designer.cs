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
            this.lblGroupName = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_FormHeader
            // 
            this.lbl_FormHeader.Location = new System.Drawing.Point(810, 9);
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Location = new System.Drawing.Point(144, 110);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(69, 16);
            this.lblGroupName.TabIndex = 2;
            this.lblGroupName.Text = "اسم المجموعة";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(144, 154);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(51, 16);
            this.lblNotes.TabIndex = 3;
            this.lblNotes.Text = "الملاحظات";
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(270, 104);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(420, 22);
            this.txtGroupName.TabIndex = 4;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(270, 154);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(420, 97);
            this.txtNotes.TabIndex = 5;
            // 
            // frmProductGroupAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(883, 322);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtGroupName);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.lblGroupName);
            this.Name = "frmProductGroupAddEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مجموعات الأصناف";
            this.Controls.SetChildIndex(this.lblGroupName, 0);
            this.Controls.SetChildIndex(this.lblNotes, 0);
            this.Controls.SetChildIndex(this.txtGroupName, 0);
            this.Controls.SetChildIndex(this.txtNotes, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.TextBox txtNotes;

    }
}
