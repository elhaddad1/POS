using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BusinessLayer.Wrapper
{
    public class BDCustomerWrapper : BDCustomerService
    {
        private BDCustomer _bDCustomerBl;
        private POS.DataLayer.BDCustomer _bDCustomerDl;
        public BDCustomerCollection SelectAll()
        {
            return base.SelectAll();
        }



    }
}
