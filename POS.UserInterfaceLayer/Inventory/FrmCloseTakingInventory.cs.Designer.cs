namespace POS.UserInterfaceLayer.Inventory
{
    partial class FrmCloseTakingInventory
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
            this.button1 = new System.Windows.Forms.Button();
            this.cmboBox_TakingName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbox_Date = new System.Windows.Forms.TextBox();
            this.txtbox_InventoryName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panl_Header.SuspendLayout();
            this.panl_Footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panl_Header
            // 
            this.panl_Header.Size = new System.Drawing.Size(830, 53);
            // 
            // lbl_FormHeader
            // 
            this.lbl_FormHeader.Location = new System.Drawing.Point(393, 17);
            this.lbl_FormHeader.Size = new System.Drawing.Size(73, 19);
            this.lbl_FormHeader.Text = "اغلاق الجرد";
            // 
            // panl_Footer
            // 
            this.panl_Footer.Controls.Add(this.button1);
            this.panl_Footer.Location = new System.Drawing.Point(0, 502);
            this.panl_Footer.Size = new System.Drawing.Size(830, 62);
            this.panl_Footer.Controls.SetChildIndex(this.btn_Save, 0);
            this.panl_Footer.Controls.SetChildIndex(this.btn_Back, 0);
            this.panl_Footer.Controls.SetChildIndex(this.button1, 0);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(502, 4);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(258, 4);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(380, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 55);
            this.button1.TabIndex = 3;
            this.button1.Text = "إغلاق";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmboBox_TakingName
            // 
            this.cmboBox_TakingName.FormattingEnabled = true;
            this.cmboBox_TakingName.Location = new System.Drawing.Point(92, 71);
            this.cmboBox_TakingName.Name = "cmboBox_TakingName";
            this.cmboBox_TakingName.Size = new System.Drawing.Size(255, 24);
            this.cmboBox_TakingName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "إسم الجرد";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "إسم المخزن";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(649, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "التاريخ";
            // 
            // txtbox_Date
            // 
            this.txtbox_Date.Location = new System.Drawing.Point(705, 73);
            this.txtbox_Date.Name = "txtbox_Date";
            this.txtbox_Date.ReadOnly = true;
            this.txtbox_Date.Size = new System.Drawing.Size(100, 22);
            this.txtbox_Date.TabIndex = 7;
            // 
            // txtbox_InventoryName
            // 
            this.txtbox_InventoryName.Location = new System.Drawing.Point(442, 73);
            this.txtbox_InventoryName.Name = "txtbox_InventoryName";
            this.txtbox_InventoryName.ReadOnly = true;
            this.txtbox_InventoryName.Size = new System.Drawing.Size(166, 22);
            this.txtbox_InventoryName.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(830, 371);
            this.dataGridView1.TabIndex = 9;
            // 
            // FrmCloseTakingInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 564);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtbox_InventoryName);
            this.Controls.Add(this.txtbox_Date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmboBox_TakingName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmCloseTakingInventory";
            this.Text = "FrmCloseTakingInventory";
            this.Controls.SetChildIndex(this.panl_Header, 0);
            this.Controls.SetChildIndex(this.panl_Footer, 0);
            this.Controls.SetChildIndex(this.cmboBox_TakingName, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtbox_Date, 0);
            this.Controls.SetChildIndex(this.txtbox_InventoryName, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.panl_Header.ResumeLayout(false);
            this.panl_Header.PerformLayout();
            this.panl_Footer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmboBox_TakingName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbox_Date;
        private System.Windows.Forms.TextBox txtbox_InventoryName;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}