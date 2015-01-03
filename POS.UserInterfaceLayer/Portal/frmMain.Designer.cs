namespace POS.UserInterfaceLayer.Portal
{
    partial class frmMain
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
            this.mnu_MainMenu = new System.Windows.Forms.MenuStrip();
            this.BasicData = new System.Windows.Forms.ToolStripMenuItem();
            this.Administration = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnu_MainMenu
            // 
            this.mnu_MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BasicData,
            this.Administration});
            this.mnu_MainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnu_MainMenu.Name = "mnu_MainMenu";
            this.mnu_MainMenu.Size = new System.Drawing.Size(751, 24);
            this.mnu_MainMenu.TabIndex = 0;
            this.mnu_MainMenu.Text = "menuStrip1";
            // 
            // BasicData
            // 
            this.BasicData.Name = "BasicData";
            this.BasicData.Size = new System.Drawing.Size(95, 20);
            this.BasicData.Text = "البيانات الرئيسية";
            // 
            // Administration
            // 
            this.Administration.Name = "Administration";
            this.Administration.Size = new System.Drawing.Size(71, 20);
            this.Administration.Text = "المستخدمين";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(751, 262);
            this.Controls.Add(this.mnu_MainMenu);
            this.MainMenuStrip = this.mnu_MainMenu;
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "برنامج المخازن";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnu_MainMenu.ResumeLayout(false);
            this.mnu_MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnu_MainMenu;
        private System.Windows.Forms.ToolStripMenuItem BasicData;
        private System.Windows.Forms.ToolStripMenuItem Administration;
    }
}