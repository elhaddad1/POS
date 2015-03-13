namespace POS.UserInterfaceLayer.Inventory
{
    partial class FrmOpenTakingInventory
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.tbx_takingName = new System.Windows.Forms.TextBox();
            this.panl_Header = new System.Windows.Forms.Panel();
            this.lbl_FormHeader = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.dtp_takingDate = new System.Windows.Forms.DateTimePicker();
            this.grb_takingOn = new System.Windows.Forms.GroupBox();
            this.cmb_productGroup = new System.Windows.Forms.ComboBox();
            this.cmb_Product = new System.Windows.Forms.ComboBox();
            this.ridb_All = new System.Windows.Forms.RadioButton();
            this.ridb_ProductGroup = new System.Windows.Forms.RadioButton();
            this.ridb_Product = new System.Windows.Forms.RadioButton();
            this.btn_newTaking = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_inventory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_notes = new System.Windows.Forms.TextBox();
            this.panl_Header.SuspendLayout();
            this.grb_takingOn.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(20, 97);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(51, 16);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "إسم الجرد";
            // 
            // tbx_takingName
            // 
            this.tbx_takingName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_takingName.Location = new System.Drawing.Point(114, 91);
            this.tbx_takingName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_takingName.Name = "tbx_takingName";
            this.tbx_takingName.Size = new System.Drawing.Size(359, 22);
            this.tbx_takingName.TabIndex = 1;
            // 
            // panl_Header
            // 
            this.panl_Header.BackColor = System.Drawing.Color.MintCream;
            this.panl_Header.Controls.Add(this.lbl_FormHeader);
            this.panl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panl_Header.Location = new System.Drawing.Point(0, 0);
            this.panl_Header.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panl_Header.Name = "panl_Header";
            this.panl_Header.Size = new System.Drawing.Size(610, 65);
            this.panl_Header.TabIndex = 2;
            // 
            // lbl_FormHeader
            // 
            this.lbl_FormHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_FormHeader.AutoSize = true;
            this.lbl_FormHeader.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FormHeader.Location = new System.Drawing.Point(283, 25);
            this.lbl_FormHeader.Name = "lbl_FormHeader";
            this.lbl_FormHeader.Size = new System.Drawing.Size(51, 19);
            this.lbl_FormHeader.TabIndex = 0;
            this.lbl_FormHeader.Text = "فتح جرد";
            // 
            // lbl_date
            // 
            this.lbl_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(20, 128);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(59, 16);
            this.lbl_date.TabIndex = 3;
            this.lbl_date.Text = "تاريخ الجرد";
            // 
            // dtp_takingDate
            // 
            this.dtp_takingDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_takingDate.CustomFormat = "dd/MM/yyyy";
            this.dtp_takingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_takingDate.Location = new System.Drawing.Point(114, 122);
            this.dtp_takingDate.Name = "dtp_takingDate";
            this.dtp_takingDate.RightToLeftLayout = true;
            this.dtp_takingDate.Size = new System.Drawing.Size(147, 22);
            this.dtp_takingDate.TabIndex = 4;
            // 
            // grb_takingOn
            // 
            this.grb_takingOn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_takingOn.Controls.Add(this.cmb_productGroup);
            this.grb_takingOn.Controls.Add(this.cmb_Product);
            this.grb_takingOn.Controls.Add(this.ridb_All);
            this.grb_takingOn.Controls.Add(this.ridb_ProductGroup);
            this.grb_takingOn.Controls.Add(this.ridb_Product);
            this.grb_takingOn.Location = new System.Drawing.Point(23, 194);
            this.grb_takingOn.Name = "grb_takingOn";
            this.grb_takingOn.Size = new System.Drawing.Size(450, 166);
            this.grb_takingOn.TabIndex = 5;
            this.grb_takingOn.TabStop = false;
            this.grb_takingOn.Text = "جرد علي";
            // 
            // cmb_productGroup
            // 
            this.cmb_productGroup.Enabled = false;
            this.cmb_productGroup.FormattingEnabled = true;
            this.cmb_productGroup.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cmb_productGroup.Location = new System.Drawing.Point(212, 78);
            this.cmb_productGroup.Name = "cmb_productGroup";
            this.cmb_productGroup.Size = new System.Drawing.Size(138, 24);
            this.cmb_productGroup.TabIndex = 4;
            // 
            // cmb_Product
            // 
            this.cmb_Product.Enabled = false;
            this.cmb_Product.FormattingEnabled = true;
            this.cmb_Product.Location = new System.Drawing.Point(212, 39);
            this.cmb_Product.Name = "cmb_Product";
            this.cmb_Product.Size = new System.Drawing.Size(138, 24);
            this.cmb_Product.TabIndex = 3;
            // 
            // ridb_All
            // 
            this.ridb_All.AutoSize = true;
            this.ridb_All.Checked = true;
            this.ridb_All.Location = new System.Drawing.Point(372, 124);
            this.ridb_All.Name = "ridb_All";
            this.ridb_All.Size = new System.Drawing.Size(72, 20);
            this.ridb_All.TabIndex = 2;
            this.ridb_All.TabStop = true;
            this.ridb_All.Text = "كل المخزن";
            this.ridb_All.UseVisualStyleBackColor = true;
            // 
            // ridb_ProductGroup
            // 
            this.ridb_ProductGroup.AutoSize = true;
            this.ridb_ProductGroup.Location = new System.Drawing.Point(348, 82);
            this.ridb_ProductGroup.Name = "ridb_ProductGroup";
            this.ridb_ProductGroup.Size = new System.Drawing.Size(96, 20);
            this.ridb_ProductGroup.TabIndex = 1;
            this.ridb_ProductGroup.Text = "مجموعه منتجات";
            this.ridb_ProductGroup.UseVisualStyleBackColor = true;
            this.ridb_ProductGroup.CheckedChanged += new System.EventHandler(this.ridb_ProductGroup_CheckedChanged);
            // 
            // ridb_Product
            // 
            this.ridb_Product.AutoSize = true;
            this.ridb_Product.Location = new System.Drawing.Point(398, 43);
            this.ridb_Product.Name = "ridb_Product";
            this.ridb_Product.Size = new System.Drawing.Size(46, 20);
            this.ridb_Product.TabIndex = 0;
            this.ridb_Product.TabStop = true;
            this.ridb_Product.Text = "منتج";
            this.ridb_Product.UseVisualStyleBackColor = true;
            this.ridb_Product.CheckedChanged += new System.EventHandler(this.ridb_Product_CheckedChanged);
            // 
            // btn_newTaking
            // 
            this.btn_newTaking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_newTaking.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newTaking.Location = new System.Drawing.Point(383, 7);
            this.btn_newTaking.Name = "btn_newTaking";
            this.btn_newTaking.Size = new System.Drawing.Size(104, 48);
            this.btn_newTaking.TabIndex = 6;
            this.btn_newTaking.Text = "جرد جديد";
            this.btn_newTaking.UseVisualStyleBackColor = true;
            this.btn_newTaking.Click += new System.EventHandler(this.btn_newTaking_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_newTaking);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 454);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 63);
            this.panel1.TabIndex = 6;
            // 
            // btn_back
            // 
            this.btn_back.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_back.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(123, 7);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(104, 48);
            this.btn_back.TabIndex = 8;
            this.btn_back.Text = "عوده";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(256, 7);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(104, 48);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "حفظ";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "إسم المخزن";
            // 
            // cmb_inventory
            // 
            this.cmb_inventory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_inventory.FormattingEnabled = true;
            this.cmb_inventory.Location = new System.Drawing.Point(117, 153);
            this.cmb_inventory.Name = "cmb_inventory";
            this.cmb_inventory.Size = new System.Drawing.Size(144, 24);
            this.cmb_inventory.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "ملاحظات";
            // 
            // tbx_notes
            // 
            this.tbx_notes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_notes.Location = new System.Drawing.Point(123, 379);
            this.tbx_notes.Multiline = true;
            this.tbx_notes.Name = "tbx_notes";
            this.tbx_notes.Size = new System.Drawing.Size(350, 69);
            this.tbx_notes.TabIndex = 10;
            this.tbx_notes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FrmOpenTakingInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 517);
            this.Controls.Add(this.tbx_notes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_inventory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grb_takingOn);
            this.Controls.Add(this.dtp_takingDate);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.panl_Header);
            this.Controls.Add(this.tbx_takingName);
            this.Controls.Add(this.lbl_name);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmOpenTakingInventory";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "شاشه فتح جرد";
            this.Load += new System.EventHandler(this.FrmOpenTakingInventory_Load);
            this.panl_Header.ResumeLayout(false);
            this.panl_Header.PerformLayout();
            this.grb_takingOn.ResumeLayout(false);
            this.grb_takingOn.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox tbx_takingName;
        protected System.Windows.Forms.Panel panl_Header;
        protected System.Windows.Forms.Label lbl_FormHeader;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.DateTimePicker dtp_takingDate;
        private System.Windows.Forms.GroupBox grb_takingOn;
        private System.Windows.Forms.ComboBox cmb_productGroup;
        private System.Windows.Forms.ComboBox cmb_Product;
        private System.Windows.Forms.RadioButton ridb_All;
        private System.Windows.Forms.RadioButton ridb_ProductGroup;
        private System.Windows.Forms.RadioButton ridb_Product;
        private System.Windows.Forms.Button btn_newTaking;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_inventory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_notes;
    }
}