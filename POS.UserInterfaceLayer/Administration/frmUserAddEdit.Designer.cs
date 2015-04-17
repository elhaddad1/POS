namespace POS.UserInterfaceLayer.Administration
{
    partial class frmUserAddEdit
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
            this.tbx_UserFullName = new System.Windows.Forms.TextBox();
            this.lbl_GroupName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_Address = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_Mobile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_Phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_Email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_Password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_UserName = new System.Windows.Forms.TextBox();
            this.cbx_Group = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panl_Header.SuspendLayout();
            this.panl_Footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panl_Header
            // 
            this.panl_Header.Size = new System.Drawing.Size(679, 53);
            // 
            // lbl_FormHeader
            // 
            this.lbl_FormHeader.Location = new System.Drawing.Point(534, 17);
            // 
            // panl_Footer
            // 
            this.panl_Footer.Location = new System.Drawing.Point(0, 195);
            this.panl_Footer.Size = new System.Drawing.Size(679, 62);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(560, 3);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(455, 3);
            // 
            // tbx_UserFullName
            // 
            this.tbx_UserFullName.Location = new System.Drawing.Point(76, 58);
            this.tbx_UserFullName.Name = "tbx_UserFullName";
            this.tbx_UserFullName.Size = new System.Drawing.Size(245, 22);
            this.tbx_UserFullName.TabIndex = 2;
            // 
            // lbl_GroupName
            // 
            this.lbl_GroupName.AutoSize = true;
            this.lbl_GroupName.Location = new System.Drawing.Point(4, 61);
            this.lbl_GroupName.Name = "lbl_GroupName";
            this.lbl_GroupName.Size = new System.Drawing.Size(67, 16);
            this.lbl_GroupName.TabIndex = 3;
            this.lbl_GroupName.Text = "أسم المستخدم";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "العنوان";
            // 
            // tbx_Address
            // 
            this.tbx_Address.Location = new System.Drawing.Point(431, 58);
            this.tbx_Address.Name = "tbx_Address";
            this.tbx_Address.Size = new System.Drawing.Size(245, 22);
            this.tbx_Address.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "محمول";
            // 
            // tbx_Mobile
            // 
            this.tbx_Mobile.Location = new System.Drawing.Point(431, 90);
            this.tbx_Mobile.Name = "tbx_Mobile";
            this.tbx_Mobile.Size = new System.Drawing.Size(245, 22);
            this.tbx_Mobile.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "تليفون";
            // 
            // tbx_Phone
            // 
            this.tbx_Phone.Location = new System.Drawing.Point(76, 90);
            this.tbx_Phone.Name = "tbx_Phone";
            this.tbx_Phone.Size = new System.Drawing.Size(245, 22);
            this.tbx_Phone.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "بريد الكترونى";
            // 
            // tbx_Email
            // 
            this.tbx_Email.Location = new System.Drawing.Point(76, 122);
            this.tbx_Email.Name = "tbx_Email";
            this.tbx_Email.Size = new System.Drawing.Size(245, 22);
            this.tbx_Email.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "رمز الدخول";
            // 
            // tbx_Password
            // 
            this.tbx_Password.Location = new System.Drawing.Point(431, 154);
            this.tbx_Password.Name = "tbx_Password";
            this.tbx_Password.PasswordChar = '*';
            this.tbx_Password.Size = new System.Drawing.Size(170, 22);
            this.tbx_Password.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "أسم الدخول";
            // 
            // tbx_UserName
            // 
            this.tbx_UserName.Location = new System.Drawing.Point(76, 154);
            this.tbx_UserName.Name = "tbx_UserName";
            this.tbx_UserName.Size = new System.Drawing.Size(170, 22);
            this.tbx_UserName.TabIndex = 14;
            // 
            // cbx_Group
            // 
            this.cbx_Group.FormattingEnabled = true;
            this.cbx_Group.Location = new System.Drawing.Point(431, 121);
            this.cbx_Group.Name = "cbx_Group";
            this.cbx_Group.Size = new System.Drawing.Size(170, 24);
            this.cbx_Group.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(364, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "المجموعة";
            // 
            // frmUserAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(679, 257);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbx_Group);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbx_UserName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbx_Password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbx_Email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_Phone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_Mobile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_Address);
            this.Controls.Add(this.lbl_GroupName);
            this.Controls.Add(this.tbx_UserFullName);
            this.Name = "frmUserAddEdit";
            this.Text = "أضافة / تعديل مجموعة";
            this.Controls.SetChildIndex(this.panl_Header, 0);
            this.Controls.SetChildIndex(this.panl_Footer, 0);
            this.Controls.SetChildIndex(this.tbx_UserFullName, 0);
            this.Controls.SetChildIndex(this.lbl_GroupName, 0);
            this.Controls.SetChildIndex(this.tbx_Address, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tbx_Mobile, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.tbx_Phone, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.tbx_Email, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.tbx_Password, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.tbx_UserName, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.cbx_Group, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.panl_Header.ResumeLayout(false);
            this.panl_Header.PerformLayout();
            this.panl_Footer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_UserFullName;
        private System.Windows.Forms.Label lbl_GroupName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_Address;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_Mobile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_Phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_Email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_Password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_UserName;
        private System.Windows.Forms.ComboBox cbx_Group;
        private System.Windows.Forms.Label label7;
    }
}
