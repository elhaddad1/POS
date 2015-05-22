namespace POS.UserInterfaceLayer.Portal
{
    partial class frmBaseSearchForm
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
            this.panl_Header = new System.Windows.Forms.Panel();
            this.lbl_FormHeader = new System.Windows.Forms.Label();
            this.panl_Footer = new System.Windows.Forms.Panel();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.grb_search = new System.Windows.Forms.GroupBox();
            this.Dgrid_Result = new System.Windows.Forms.DataGridView();
            this.panl_Header.SuspendLayout();
            this.panl_Footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgrid_Result)).BeginInit();
            this.SuspendLayout();
            // 
            // panl_Header
            // 
            this.panl_Header.BackColor = System.Drawing.Color.MintCream;
            this.panl_Header.Controls.Add(this.lbl_FormHeader);
            this.panl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panl_Header.Location = new System.Drawing.Point(0, 0);
            this.panl_Header.Name = "panl_Header";
            this.panl_Header.Size = new System.Drawing.Size(646, 47);
            this.panl_Header.TabIndex = 0;
            // 
            // lbl_FormHeader
            // 
            this.lbl_FormHeader.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.lbl_FormHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_FormHeader.AutoSize = true;
            this.lbl_FormHeader.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FormHeader.Location = new System.Drawing.Point(307, 17);
            this.lbl_FormHeader.Name = "lbl_FormHeader";
            this.lbl_FormHeader.Size = new System.Drawing.Size(45, 19);
            this.lbl_FormHeader.TabIndex = 0;
            this.lbl_FormHeader.Text = "label";
            // 
            // panl_Footer
            // 
            this.panl_Footer.Controls.Add(this.btn_Add);
            this.panl_Footer.Controls.Add(this.btn_Back);
            this.panl_Footer.Controls.Add(this.btn_Edit);
            this.panl_Footer.Controls.Add(this.btn_Delete);
            this.panl_Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panl_Footer.Location = new System.Drawing.Point(0, 525);
            this.panl_Footer.Name = "panl_Footer";
            this.panl_Footer.Size = new System.Drawing.Size(646, 70);
            this.panl_Footer.TabIndex = 1;
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(436, 6);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(99, 55);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "أضافة";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(121, 6);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(99, 55);
            this.btn_Back.TabIndex = 6;
            this.btn_Back.Text = "رجوع";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(331, 6);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(99, 55);
            this.btn_Edit.TabIndex = 8;
            this.btn_Edit.Text = "تعديل";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(226, 6);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(99, 55);
            this.btn_Delete.TabIndex = 7;
            this.btn_Delete.Text = "حذف";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // grb_search
            // 
            this.grb_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.grb_search.Location = new System.Drawing.Point(0, 47);
            this.grb_search.Name = "grb_search";
            this.grb_search.Size = new System.Drawing.Size(646, 128);
            this.grb_search.TabIndex = 7;
            this.grb_search.TabStop = false;
            this.grb_search.Text = "بحث";
            // 
            // Dgrid_Result
            // 
            this.Dgrid_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgrid_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgrid_Result.Location = new System.Drawing.Point(0, 175);
            this.Dgrid_Result.Name = "Dgrid_Result";
            this.Dgrid_Result.Size = new System.Drawing.Size(646, 350);
            this.Dgrid_Result.TabIndex = 8;
            // 
            // frmBaseSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(646, 595);
            this.ControlBox = false;
            this.Controls.Add(this.Dgrid_Result);
            this.Controls.Add(this.grb_search);
            this.Controls.Add(this.panl_Footer);
            this.Controls.Add(this.panl_Header);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmBaseSearchForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmBaseForm";
            this.panl_Header.ResumeLayout(false);
            this.panl_Header.PerformLayout();
            this.panl_Footer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgrid_Result)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel panl_Header;
        protected System.Windows.Forms.Label lbl_FormHeader;
        protected System.Windows.Forms.Button btn_Close;
        protected System.Windows.Forms.Panel panl_Footer;
        public System.Windows.Forms.GroupBox grb_search;
        private System.Windows.Forms.DataGridView Dgrid_Result;
        protected System.Windows.Forms.Button btn_Add;
        protected System.Windows.Forms.Button btn_Back;
        protected System.Windows.Forms.Button btn_Edit;
        protected System.Windows.Forms.Button btn_Delete;
    }
}