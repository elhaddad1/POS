using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.UserInterfaceLayer.Portal
{
    public partial class frmBaseSearchForm : Form
    {
        public frmBaseSearchForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Events implementation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public virtual void btn_Add_Click(object sender, EventArgs e) { }
        public virtual void btn_Edit_Click(object sender, EventArgs e) { }
        public virtual void btn_Delete_Click(object sender, EventArgs e) { }
        public virtual void btn_Back_Click(object sender, EventArgs e) { }


    }
}
