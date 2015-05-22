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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_close = new System.Windows.Forms.Button();
            this.dgv_Lines = new System.Windows.Forms.DataGridView();
            this.Col_TakingInventoryLineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_TakingLineBatchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_StockType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_IsAcceptBantch = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Col_BatchNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ExpectedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ActualQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtbox_InventoryName = new System.Windows.Forms.TextBox();
            this.txtbox_Date = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmboBox_TakingName = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lines)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(200, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(97, 55);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "إغلاق";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // dgv_Lines
            // 
            this.dgv_Lines.AllowUserToAddRows = false;
            this.dgv_Lines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Lines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Lines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_TakingInventoryLineID,
            this.Col_TakingLineBatchID,
            this.Col_Productname,
            this.Col_StockType,
            this.Col_IsAcceptBantch,
            this.Col_BatchNumber,
            this.Col_ExpiryDate,
            this.Col_ExpectedQty,
            this.Col_ActualQty});
            this.dgv_Lines.Location = new System.Drawing.Point(30, 121);
            this.dgv_Lines.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Lines.Name = "dgv_Lines";
            this.dgv_Lines.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_Lines.Size = new System.Drawing.Size(783, 365);
            this.dgv_Lines.TabIndex = 9;
            // 
            // Col_TakingInventoryLineID
            // 
            this.Col_TakingInventoryLineID.DataPropertyName = "TakingLineID";
            this.Col_TakingInventoryLineID.HeaderText = "Col_TakingInventoryLineID";
            this.Col_TakingInventoryLineID.Name = "Col_TakingInventoryLineID";
            this.Col_TakingInventoryLineID.ReadOnly = true;
            this.Col_TakingInventoryLineID.Visible = false;
            // 
            // Col_TakingLineBatchID
            // 
            this.Col_TakingLineBatchID.DataPropertyName = "TakingLineBatchID";
            this.Col_TakingLineBatchID.HeaderText = "TakingLineBatchID";
            this.Col_TakingLineBatchID.Name = "Col_TakingLineBatchID";
            this.Col_TakingLineBatchID.ReadOnly = true;
            this.Col_TakingLineBatchID.Visible = false;
            // 
            // Col_Productname
            // 
            this.Col_Productname.DataPropertyName = "ProductName";
            this.Col_Productname.HeaderText = "إسم المنتج";
            this.Col_Productname.Name = "Col_Productname";
            this.Col_Productname.ReadOnly = true;
            this.Col_Productname.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_Productname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Col_Productname.Width = 180;
            // 
            // Col_StockType
            // 
            this.Col_StockType.DataPropertyName = "StockTypeName";
            this.Col_StockType.HeaderText = "نوع المخزون";
            this.Col_StockType.Name = "Col_StockType";
            this.Col_StockType.ReadOnly = true;
            // 
            // Col_IsAcceptBantch
            // 
            this.Col_IsAcceptBantch.DataPropertyName = "IsAcceptBatch";
            this.Col_IsAcceptBantch.HeaderText = "يقبل تشغيله";
            this.Col_IsAcceptBantch.Name = "Col_IsAcceptBantch";
            this.Col_IsAcceptBantch.ReadOnly = true;
            this.Col_IsAcceptBantch.Width = 60;
            // 
            // Col_BatchNumber
            // 
            this.Col_BatchNumber.DataPropertyName = "BatchNumber";
            this.Col_BatchNumber.HeaderText = "رقم التشغيله";
            this.Col_BatchNumber.Name = "Col_BatchNumber";
            this.Col_BatchNumber.ReadOnly = true;
            this.Col_BatchNumber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_BatchNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_ExpiryDate
            // 
            this.Col_ExpiryDate.DataPropertyName = "ExpiryDate";
            this.Col_ExpiryDate.HeaderText = "تاريخ الصلاحيه";
            this.Col_ExpiryDate.Name = "Col_ExpiryDate";
            this.Col_ExpiryDate.ReadOnly = true;
            this.Col_ExpiryDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_ExpiryDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_ExpectedQty
            // 
            this.Col_ExpectedQty.DataPropertyName = "ExpectedQty";
            this.Col_ExpectedQty.HeaderText = "الكميه المتوقعه";
            this.Col_ExpectedQty.Name = "Col_ExpectedQty";
            this.Col_ExpectedQty.ReadOnly = true;
            // 
            // Col_ActualQty
            // 
            this.Col_ActualQty.DataPropertyName = "ActualQty";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Col_ActualQty.DefaultCellStyle = dataGridViewCellStyle6;
            this.Col_ActualQty.HeaderText = "الكميه الحقيقيه";
            this.Col_ActualQty.Name = "Col_ActualQty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(511, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "إغلاق جرد";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtbox_InventoryName);
            this.panel1.Controls.Add(this.txtbox_Date);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmboBox_TakingName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 64);
            this.panel1.TabIndex = 10;
            // 
            // txtbox_InventoryName
            // 
            this.txtbox_InventoryName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtbox_InventoryName.Location = new System.Drawing.Point(108, 19);
            this.txtbox_InventoryName.Margin = new System.Windows.Forms.Padding(2);
            this.txtbox_InventoryName.Name = "txtbox_InventoryName";
            this.txtbox_InventoryName.ReadOnly = true;
            this.txtbox_InventoryName.Size = new System.Drawing.Size(126, 20);
            this.txtbox_InventoryName.TabIndex = 14;
            // 
            // txtbox_Date
            // 
            this.txtbox_Date.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtbox_Date.Location = new System.Drawing.Point(334, 20);
            this.txtbox_Date.Margin = new System.Windows.Forms.Padding(2);
            this.txtbox_Date.Name = "txtbox_Date";
            this.txtbox_Date.ReadOnly = true;
            this.txtbox_Date.Size = new System.Drawing.Size(76, 20);
            this.txtbox_Date.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "التاريخ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "إسم المخزن";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(702, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "إسم الجرد";
            // 
            // cmboBox_TakingName
            // 
            this.cmboBox_TakingName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmboBox_TakingName.FormattingEnabled = true;
            this.cmboBox_TakingName.Location = new System.Drawing.Point(506, 20);
            this.cmboBox_TakingName.Margin = new System.Windows.Forms.Padding(2);
            this.cmboBox_TakingName.Name = "cmboBox_TakingName";
            this.cmboBox_TakingName.Size = new System.Drawing.Size(192, 21);
            this.cmboBox_TakingName.TabIndex = 9;
            this.cmboBox_TakingName.SelectedIndexChanged += new System.EventHandler(this.cmboBox_TakingName_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(842, 44);
            this.panel2.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(425, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "اغلاق جرد";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btn_Save);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 506);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(842, 63);
            this.panel3.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(188, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 48);
            this.button2.TabIndex = 2;
            this.button2.Text = "رجوع";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(334, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "إغلاق";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(471, 12);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(123, 48);
            this.btn_Save.TabIndex = 0;
            this.btn_Save.Text = "حفظ";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // FrmCloseTakingInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(842, 569);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv_Lines);
            this.Name = "FrmCloseTakingInventory";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "اغلاق جرد";
            this.Load += new System.EventHandler(this.FrmCloseTakingInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lines)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.DataGridView dgv_Lines;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtbox_InventoryName;
        private System.Windows.Forms.TextBox txtbox_Date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmboBox_TakingName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_TakingInventoryLineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_TakingLineBatchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Productname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_StockType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Col_IsAcceptBantch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_BatchNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ExpiryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ExpectedQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ActualQty;
    }
}