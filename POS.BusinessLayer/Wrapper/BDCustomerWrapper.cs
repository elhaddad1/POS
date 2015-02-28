using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BusinessLayer.Wrapper
{
    public class BDCustomerWrapper : BDCustomerService
    {
        private BDCustomer _bDCustomerWCF;
        public BDCustomerCollection SearchByCriteria(string CustomerName,string CustomerCode )
        {
            BDCustomerCollection bDCustomerCollection = new BDCustomerCollection();
            foreach (POS.DataLayer.BDCustomer _bDCustomer in POS.DataLayer.BDCustomer.SearcByCriteria(CustomerName,CustomerCode ))
            {
                _bDCustomerWCF = new BDCustomer();

                _bDCustomerWCF.CustomerID = _bDCustomer.CustomerID;
                _bDCustomerWCF.CustomerName = _bDCustomer.CustomerName;
                _bDCustomerWCF.CustomerCode = _bDCustomer.CustomerCode;
                _bDCustomerWCF.Address = _bDCustomer.Address;
                _bDCustomerWCF.Phone1 = _bDCustomer.Phone1;
                _bDCustomerWCF.Phone2 = _bDCustomer.Phone2;
                _bDCustomerWCF.Mobile1 = _bDCustomer.Mobile1;
                _bDCustomerWCF.Mobile2 = _bDCustomer.Mobile2;
                _bDCustomerWCF.Email = _bDCustomer.Email;
                _bDCustomerWCF.IsActive = _bDCustomer.IsActive;
                _bDCustomerWCF.Credit = _bDCustomer.Credit;
                _bDCustomerWCF.Debit = _bDCustomer.Debit;

                bDCustomerCollection.Add(_bDCustomerWCF);
            }
            return bDCustomerCollection;
        }
		


    }
}
