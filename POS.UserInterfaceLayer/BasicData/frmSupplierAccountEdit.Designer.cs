namespace POS.UserInterfaceLayer.BasicData
{
    partial class frmSupplierAccountEdit
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
            this.lbl_FormHeader = new System.Windows.Forms.Label();
            this.panl_Header = new System.Windows.Forms.Panel();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Finish = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.num_Debit = new System.Windows.Forms.NumericUpDown();
            this.num_Credit = new System.Windows.Forms.NumericUpDown();
            this.panl_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Debit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Credit)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_FormHeader
            // 
            this.lbl_FormHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_FormHeader.AutoSize = true;
            this.lbl_FormHeader.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FormHeader.Location = new System.Drawing.Point(231, 20);
            this.lbl_FormHeader.Name = "lbl_FormHeader";
            this.lbl_FormHeader.Size = new System.Drawing.Size(101, 19);
            this.lbl_FormHeader.TabIndex = 0;
            this.lbl_FormHeader.Text = "تعديل حساب مورد";
            // 
            // panl_Header
            // 
            this.panl_Header.BackColor = System.Drawing.Color.MintCream;
            this.panl_Header.Controls.Add(this.lbl_FormHeader);
            this.panl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panl_Header.Location = new System.Drawing.Point(0, 0);
            this.panl_Header.Name = "panl_Header";
            this.panl_Header.Size = new System.Drawing.Size(495, 53);
            this.panl_Header.TabIndex = 6;
            // 
            // btn_Back
            // 
            this.btn_Back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(248, 126);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(99, 55);
            this.btn_Back.TabIndex = 35;
            this.btn_Back.Text = "رجوع";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Finish
            // 
            this.btn_Finish.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Finish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Finish.Location = new System.Drawing.Point(141, 126);
            this.btn_Finish.Name = "btn_Finish";
            this.btn_Finish.Size = new System.Drawing.Size(99, 55);
            this.btn_Finish.TabIndex = 34;
            this.btn_Finish.Text = "حفظ";
            this.btn_Finish.UseVisualStyleBackColor = true;
            this.btn_Finish.Click += new System.EventHandler(this.btn_Finish_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "دائن";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "مدين";
            // 
            // num_Debit
            // 
            this.num_Debit.Location = new System.Drawing.Point(91, 75);
            this.num_Debit.Maximum = new decimal(new int[] {
            -559939585,
            902409669,
            54,
            0});
            this.num_Debit.Name = "num_Debit";
            this.num_Debit.Size = new System.Drawing.Size(120, 20);
            this.num_Debit.TabIndex = 40;
            // 
            // num_Credit
            // 
            this.num_Credit.Location = new System.Drawing.Point(273, 75);
            this.num_Credit.Maximum = new decimal(new int[] {
            -559939585,
            902409669,
            54,
            0});
            this.num_Credit.Name = "num_Credit";
            this.num_Credit.Size = new System.Drawing.Size(120, 20);
            this.num_Credit.TabIndex = 41;
            // 
            // frmSupplierAccountEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(495, 183);
            this.ControlBox = false;
            this.Controls.Add(this.num_Credit);
            this.Controls.Add(this.num_Debit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Finish);
            this.Controls.Add(this.panl_Header);
            this.Name = "frmSupplierAccountEdit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تعديل حساب مورد";
            this.panl_Header.ResumeLayout(false);
            this.panl_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Debit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Credit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label lbl_FormHeader;
        protected System.Windows.Forms.Panel panl_Header;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Finish;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown num_Debit;
        private System.Windows.Forms.NumericUpDown num_Credit;
    }
}