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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgrid_Roles = new System.Windows.Forms.DataGridView();
            this.RoleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panl_Header.SuspendLayout();
            this.panl_Footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Roles)).BeginInit();
            this.SuspendLayout();
            // 
            // panl_Header
            // 
            this.panl_Header.Size = new System.Drawing.Size(381, 53);
            // 
            // lbl_FormHeader
            // 
            this.lbl_FormHeader.Location = new System.Drawing.Point(168, 20);
            // 
            // panl_Footer
            // 
            this.panl_Footer.Location = new System.Drawing.Point(0, 210);
            this.panl_Footer.Size = new System.Drawing.Size(381, 62);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(200, 3);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(95, 3);
            // 
            // dgrid_Roles
            // 
            this.dgrid_Roles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_Roles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoleID,
            this.Check,
            this.RoleName});
            this.dgrid_Roles.Location = new System.Drawing.Point(0, 59);
            this.dgrid_Roles.Name = "dgrid_Roles";
            this.dgrid_Roles.Size = new System.Drawing.Size(357, 150);
            this.dgrid_Roles.TabIndex = 2;
            // 
            // RoleID
            // 
            this.RoleID.HeaderText = "RoleID";
            this.RoleID.Name = "RoleID";
            this.RoleID.Visible = false;
            // 
            // Check
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Check.DefaultCellStyle = dataGridViewCellStyle1;
            this.Check.HeaderText = "";
            this.Check.Name = "Check";
            // 
            // RoleName
            // 
            this.RoleName.HeaderText = "الصلاحيات";
            this.RoleName.Name = "RoleName";
            // 
            // frmGroupPriviliges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(381, 272);
            this.Controls.Add(this.dgrid_Roles);
            this.Name = "frmGroupPriviliges";
            this.Controls.SetChildIndex(this.panl_Header, 0);
            this.Controls.SetChildIndex(this.panl_Footer, 0);
            this.Controls.SetChildIndex(this.dgrid_Roles, 0);
            this.panl_Header.ResumeLayout(false);
            this.panl_Header.PerformLayout();
            this.panl_Footer.ResumeLayout(false);
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
