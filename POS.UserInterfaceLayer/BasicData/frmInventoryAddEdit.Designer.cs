namespace POS.UserInterfaceLayer.BasicData
{
    partial class frmInventoryAddEdit
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
            this.lbl_InventoryName = new System.Windows.Forms.Label();
            this.lbl_Notes = new System.Windows.Forms.Label();
            this.txt_InventoryName = new System.Windows.Forms.TextBox();
            this.txt_Notes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panl_Header.SuspendLayout();
            this.panl_Footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panl_Header
            // 
            this.panl_Header.Controls.Add(this.label1);
            this.panl_Header.Size = new System.Drawing.Size(576, 53);
            this.panl_Header.Controls.SetChildIndex(this.lbl_FormHeader, 0);
            this.panl_Header.Controls.SetChildIndex(this.label1, 0);
            // 
            // lbl_FormHeader
            // 
            this.lbl_FormHeader.Location = new System.Drawing.Point(1079, 9);
            // 
            // panl_Footer
            // 
            this.panl_Footer.Location = new System.Drawing.Point(0, 260);
            this.panl_Footer.Size = new System.Drawing.Size(576, 62);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(292, 4);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(187, 4);
            // 
            // lbl_InventoryName
            // 
            this.lbl_InventoryName.AutoSize = true;
            this.lbl_InventoryName.Location = new System.Drawing.Point(12, 89);
            this.lbl_InventoryName.Name = "lbl_InventoryName";
            this.lbl_InventoryName.Size = new System.Drawing.Size(59, 16);
            this.lbl_InventoryName.TabIndex = 2;
            this.lbl_InventoryName.Text = "اسم المخزن";
            // 
            // lbl_Notes
            // 
            this.lbl_Notes.AutoSize = true;
            this.lbl_Notes.Location = new System.Drawing.Point(12, 133);
            this.lbl_Notes.Name = "lbl_Notes";
            this.lbl_Notes.Size = new System.Drawing.Size(51, 16);
            this.lbl_Notes.TabIndex = 3;
            this.lbl_Notes.Text = "الملاحظات";
            // 
            // txt_InventoryName
            // 
            this.txt_InventoryName.Location = new System.Drawing.Point(138, 83);
            this.txt_InventoryName.Name = "txt_InventoryName";
            this.txt_InventoryName.Size = new System.Drawing.Size(420, 22);
            this.txt_InventoryName.TabIndex = 4;
            // 
            // txt_Notes
            // 
            this.txt_Notes.Location = new System.Drawing.Point(138, 133);
            this.txt_Notes.Multiline = true;
            this.txt_Notes.Name = "txt_Notes";
            this.txt_Notes.Size = new System.Drawing.Size(420, 97);
            this.txt_Notes.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "إضافه\\تعديل مخزن";
            // 
            // frmInventoryAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(576, 322);
            this.Controls.Add(this.txt_Notes);
            this.Controls.Add(this.txt_InventoryName);
            this.Controls.Add(this.lbl_Notes);
            this.Controls.Add(this.lbl_InventoryName);
            this.Name = "frmInventoryAddEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المخازن";
            this.Controls.SetChildIndex(this.panl_Header, 0);
            this.Controls.SetChildIndex(this.panl_Footer, 0);
            this.Controls.SetChildIndex(this.lbl_InventoryName, 0);
            this.Controls.SetChildIndex(this.lbl_Notes, 0);
            this.Controls.SetChildIndex(this.txt_InventoryName, 0);
            this.Controls.SetChildIndex(this.txt_Notes, 0);
            this.panl_Header.ResumeLayout(false);
            this.panl_Header.PerformLayout();
            this.panl_Footer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_InventoryName;
        private System.Windows.Forms.Label lbl_Notes;
        private System.Windows.Forms.TextBox txt_InventoryName;
        private System.Windows.Forms.TextBox txt_Notes;
        private System.Windows.Forms.Label label1;

    }
}
