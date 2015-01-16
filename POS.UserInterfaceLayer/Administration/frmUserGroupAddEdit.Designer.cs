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
            this.dgrid_Roles = new System.Windows.Forms.DataGridView();
            this.RoleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Roles)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_FormHeader
            // 
            this.lbl_FormHeader.Location = new System.Drawing.Point(149, 9);
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
            // dgrid_Roles
            // 
            this.dgrid_Roles.AllowUserToAddRows = false;
            this.dgrid_Roles.AllowUserToDeleteRows = false;
            this.dgrid_Roles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgrid_Roles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgrid_Roles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_Roles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoleID,
            this.check,
            this.RoleName});
            this.dgrid_Roles.Location = new System.Drawing.Point(93, 115);
            this.dgrid_Roles.Name = "dgrid_Roles";
            this.dgrid_Roles.RowHeadersVisible = false;
            this.dgrid_Roles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_Roles.Size = new System.Drawing.Size(307, 150);
            this.dgrid_Roles.TabIndex = 4;
            // 
            // RoleID
            // 
            this.RoleID.HeaderText = "";
            this.RoleID.Name = "RoleID";
            this.RoleID.Visible = false;
            // 
            // check
            // 
            this.check.HeaderText = "";
            this.check.Name = "check";
            this.check.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.check.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.check.Width = 20;
            // 
            // RoleName
            // 
            this.RoleName.HeaderText = "أسم الصلاحية";
            this.RoleName.Name = "RoleName";
            this.RoleName.Width = 280;
            // 
            // frmUserGroupAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(485, 346);
            this.Controls.Add(this.dgrid_Roles);
            this.Controls.Add(this.lbl_GroupName);
            this.Controls.Add(this.tbx_GroupName);
            this.Name = "frmUserGroupAddEdit";
            this.Text = "أضافة / تعديل مجموعة";
            this.Controls.SetChildIndex(this.tbx_GroupName, 0);
            this.Controls.SetChildIndex(this.lbl_GroupName, 0);
            this.Controls.SetChildIndex(this.dgrid_Roles, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Roles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_GroupName;
        private System.Windows.Forms.Label lbl_GroupName;
        private System.Windows.Forms.DataGridView dgrid_Roles;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleName;
    }
}
