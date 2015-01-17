namespace POS.UserInterfaceLayer.Administration
{
    partial class frmUserGroupSearch
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
            this.btn_Priviligies = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_FormHeader
            // 
            this.lbl_FormHeader.Location = new System.Drawing.Point(291, 20);
            // 
            // btn_Priviligies
            // 
            this.btn_Priviligies.Location = new System.Drawing.Point(514, 71);
            this.btn_Priviligies.Name = "btn_Priviligies";
            this.btn_Priviligies.Size = new System.Drawing.Size(99, 57);
            this.btn_Priviligies.TabIndex = 6;
            this.btn_Priviligies.Text = "صلاحيات المجموعة";
            this.btn_Priviligies.UseVisualStyleBackColor = true;
            this.btn_Priviligies.Click += new System.EventHandler(this.btn_Priviligies_Click);
            // 
            // frmUserGroupSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(646, 327);
            this.Controls.Add(this.btn_Priviligies);
            this.Name = "frmUserGroupSearch";
            this.Text = "مجموعات المستخدمين";
            this.Controls.SetChildIndex(this.btn_Priviligies, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Priviligies;
    }
}
