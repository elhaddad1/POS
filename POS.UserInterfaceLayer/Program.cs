using POS.UserInterfaceLayer.BasicData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS.UserInterfaceLayer.Portal;
using POS.UserInterfaceLayer.Administration;
using POS.UserInterfaceLayer.Inventory;
using POS.UserInterfaceLayer.Purcase;


namespace POS.UserInterfaceLayer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPurchaseOrderSearch  ());
        }
    }
}
