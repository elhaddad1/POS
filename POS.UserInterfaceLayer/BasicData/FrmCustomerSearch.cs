using POS.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POS.UserInterfaceLayer.BasicData
{
    public partial class FrmCustomerSearch : POS.UserInterfaceLayer.Portal.frmBaseSearchForm
    {
        BDCustomerService customerservice;
        public FrmCustomerSearch()
        {
            InitializeComponent();
            customerservice = new BDCustomerService();
        }
        public override void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCustomerSearch_Load(object sender, EventArgs e)
        { 
            GrbSearch .Height  = 150;
            DgvResult.Size=new Size (10, 250);
            List<BDCustomer> customers = customerservice.SelectAll();
           
            DgvResult.DataSource = customers;
            
            addColumnToGrid("إسم العميل", "CustomerName", 120, true);
        }
       

           
    }
}
