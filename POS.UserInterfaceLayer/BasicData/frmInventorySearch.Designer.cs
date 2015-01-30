namespace POS.UserInterfaceLayer.BasicData
{
    partial class frmInventorySearch
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
            this.grb_search = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tbx_Name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.grb_search.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_FormHeader
            // 
            this.lbl_FormHeader.Location = new System.Drawing.Point(274, 9);
            // 
            // grb_search
            // 
            this.grb_search.Controls.Add(this.btn_Search);
            this.grb_search.Controls.Add(this.tbx_Name);
            this.grb_search.Controls.Add(this.lbl_name);
            this.grb_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.grb_search.Location = new System.Drawing.Point(0, 53);
            this.grb_search.Name = "grb_search";
            this.grb_search.Size = new System.Drawing.Size(613, 100);
            this.grb_search.TabIndex = 10;
            this.grb_search.TabStop = false;
            this.grb_search.Text = "بحث المخازن";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(28, 34);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 29);
            this.btn_Search.TabIndex = 10;
            this.btn_Search.Text = "بحث";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tbx_Name
            // 
            this.tbx_Name.Location = new System.Drawing.Point(322, 37);
            this.tbx_Name.Name = "tbx_Name";
            this.tbx_Name.Size = new System.Drawing.Size(184, 22);
            this.tbx_Name.TabIndex = 9;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(528, 40);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(59, 16);
            this.lbl_name.TabIndex = 7;
            this.lbl_name.Text = "إسم المخزن";
            // 
            // frmInventorySearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(613, 427);
            this.Controls.Add(this.grb_search);
            this.Name = "frmInventorySearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المخازن";
            this.Controls.SetChildIndex(this.grb_search, 0);
            this.grb_search.ResumeLayout(false);
            this.grb_search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tbx_Name;
        private System.Windows.Forms.Label lbl_name;

    }
}
