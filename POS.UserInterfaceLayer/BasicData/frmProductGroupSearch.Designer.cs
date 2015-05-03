namespace POS.UserInterfaceLayer.BasicData
{
    partial class frmProductGroupSearch
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
            this.btn_Search = new System.Windows.Forms.Button();
            this.tbx_Name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.panl_Header.SuspendLayout();
            this.panl_Footer.SuspendLayout();
            this.grb_search.SuspendLayout();
            this.SuspendLayout();
            // 
            // panl_Header
            // 
            this.panl_Header.Size = new System.Drawing.Size(609, 53);
            // 
            // lbl_FormHeader
            // 
            this.lbl_FormHeader.Location = new System.Drawing.Point(265, 9);
            // 
            // panl_Footer
            // 
            this.panl_Footer.Location = new System.Drawing.Point(0, 365);
            this.panl_Footer.Size = new System.Drawing.Size(609, 62);
            // 
            // groupBox2
            // 
            this.grb_search.Controls.Add(this.btn_Search);
            this.grb_search.Controls.Add(this.lbl_name);
            this.grb_search.Controls.Add(this.tbx_Name);
            this.grb_search.Location = new System.Drawing.Point(0, 53);
            this.grb_search.Size = new System.Drawing.Size(609, 62);
            this.grb_search.Text = "بحث مجموعات الاصناف";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(417, 2);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(102, 2);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(312, 2);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(207, 2);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(6, 17);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 29);
            this.btn_Search.TabIndex = 10;
            this.btn_Search.Text = "بحث";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tbx_Name
            // 
            this.tbx_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_Name.Location = new System.Drawing.Point(328, 27);
            this.tbx_Name.Name = "tbx_Name";
            this.tbx_Name.Size = new System.Drawing.Size(184, 22);
            this.tbx_Name.TabIndex = 9;
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(534, 30);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(69, 16);
            this.lbl_name.TabIndex = 7;
            this.lbl_name.Text = "إسم المجموعة";
            // 
            // frmProductGroupSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(609, 427);
            this.Name = "frmProductGroupSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مجموعات الأصناف";
            this.panl_Header.ResumeLayout(false);
            this.panl_Header.PerformLayout();
            this.panl_Footer.ResumeLayout(false);
            this.grb_search.ResumeLayout(false);
            this.grb_search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tbx_Name;
        private System.Windows.Forms.Label lbl_name;

    }
}
