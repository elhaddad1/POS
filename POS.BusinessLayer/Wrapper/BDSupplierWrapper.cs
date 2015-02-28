using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BusinessLayer.Wrapper
{
    public class BDSupplierWrapper:BDSupplierService
    {

        private BDSupplier _bDSupplierWCF;
        public BDSupplierCollection SearchByCriteria(string SupplierName, string SupplierCode)
        {
            BDSupplierCollection bDSupplierCollection = new BDSupplierCollection();
            foreach (POS.DataLayer.BDSupplier _bDSupplier in POS.DataLayer.BDSupplier.SearcByCriteria(SupplierName, SupplierCode))
            {
                _bDSupplierWCF = new BDSupplier();

                _bDSupplierWCF.SupplierID = _bDSupplier.SupplierID;
                _bDSupplierWCF.SupplierName = _bDSupplier.SupplierName;
                _bDSupplierWCF.SupplierCode = _bDSupplier.SupplierCode;
                _bDSupplierWCF.Address = _bDSupplier.Address;
                _bDSupplierWCF.Phone1 = _bDSupplier.Phone1;
                _bDSupplierWCF.phone2 = _bDSupplier.Phone2;
                _bDSupplierWCF.Mobile1 = _bDSupplier.Mobile1;
                _bDSupplierWCF.Mobile2 = _bDSupplier.Mobile2;
                _bDSupplierWCF.Email = _bDSupplier.Email;
                _bDSupplierWCF.IsActive = _bDSupplier.IsActive;
                _bDSupplierWCF.Credit = _bDSupplier.Credit;
                _bDSupplierWCF.Debit = _bDSupplier.Debit;

                bDSupplierCollection.Add(_bDSupplierWCF);
            }
            return bDSupplierCollection;
        }
    }
}
