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
            this.panl_Header.SuspendLayout();
            this.panl_Footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panl_Header
            // 
            this.panl_Header.Size = new System.Drawing.Size(665, 53);
            // 
            // lbl_FormHeader
            // 
            this.lbl_FormHeader.Location = new System.Drawing.Point(418, 20);
            // 
            // panl_Footer
            // 
            this.panl_Footer.Location = new System.Drawing.Point(0, 337);
            this.panl_Footer.Size = new System.Drawing.Size(665, 62);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(551, 5);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(123, 5);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(337, 5);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(444, 5);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(230, 5);
            // 
            // btn_Priviligies
            // 
            this.btn_Priviligies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Priviligies.Location = new System.Drawing.Point(554, 153);
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
            this.ClientSize = new System.Drawing.Size(665, 399);
            this.Controls.Add(this.btn_Priviligies);
            this.Name = "frmUserGroupSearch";
            this.Text = "مجموعات المستخدمين";
            this.Controls.SetChildIndex(this.panl_Header, 0);
            this.Controls.SetChildIndex(this.panl_Footer, 0);
            this.Controls.SetChildIndex(this.btn_Priviligies, 0);
            this.panl_Header.ResumeLayout(false);
            this.panl_Header.PerformLayout();
            this.panl_Footer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Priviligies;
    }
}
