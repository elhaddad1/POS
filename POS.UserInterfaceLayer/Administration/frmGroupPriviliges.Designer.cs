namespace POS.UserInterfaceLayer.Administration
{
    partial class frmGroupPriviliges
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
            this.dgrid_Roles = new System.Windows.Forms.DataGridView();
            this.RoleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Roles)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_FormHeader
            // 
            this.lbl_FormHeader.Location = new System.Drawing.Point(169, 17);
            // 
            // dgrid_Roles
            // 
            this.dgrid_Roles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_Roles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoleID,
            this.Check,
            this.RoleName});
            this.dgrid_Roles.Location = new System.Drawing.Point(32, 59);
            this.dgrid_Roles.Name = "dgrid_Roles";
            this.dgrid_Roles.RowHeadersVisible = false;
            this.dgrid_Roles.Size = new System.Drawing.Size(440, 204);
            this.dgrid_Roles.TabIndex = 2;
            // 
            // RoleID
            // 
            this.RoleID.HeaderText = "Column1";
            this.RoleID.Name = "RoleID";
            this.RoleID.Visible = false;
            // 
            // Check
            // 
            this.Check.HeaderText = "";
            this.Check.Name = "Check";
            this.Check.Width = 20;
            // 
            // RoleName
            // 
            this.RoleName.HeaderText = "الصلاحيات";
            this.RoleName.Name = "RoleName";
            this.RoleName.ReadOnly = true;
            this.RoleName.Width = 400;
            // 
            // frmGroupPriviliges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(504, 327);
            this.Controls.Add(this.dgrid_Roles);
            this.Name = "frmGroupPriviliges";
            this.Controls.SetChildIndex(this.dgrid_Roles, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Roles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrid_Roles;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleName;
    }
}
