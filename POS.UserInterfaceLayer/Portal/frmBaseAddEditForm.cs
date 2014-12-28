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
    public partial class frmBaseAddEditForm : Form
    {
        public frmBaseAddEditForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Events implementation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        public virtual void btn_Save_Click(object sender, EventArgs e) { }

        public virtual void btn_Back_Click(object sender, EventArgs e) { }

    }
}
