using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BusinessLayer.Wrapper
{
    public class BDSupplierAccountWrapper : BDSupplierAccountService
    {

        private BDSupplierService _supplierService = new BDSupplierService();

        private PURPurchaseHeaderService _purchaseHeaderService = new PURPurchaseHeaderService();

        private ADUserService _userService = new ADUserService();

        public List<BDSupplierAccount> GetSupplierAccounts(int? id, DateTime? dateFrom = null, DateTime? toFrom = null)
        {
            List<BDSupplierAccount> supplierAccountCollection = new List<BDSupplierAccount>();

            var query = SelectAll().ToList();

            DateTime? fromCreationDate = dateFrom != null ? dateFrom : null;
            DateTime? toCreationDate = toFrom != null ? toFrom : null;

            if (fromCreationDate != null && toCreationDate != null)
            {
                query = (from item in query
                         where (item.CreateDate >= dateFrom.Value
                                               &&
                                               item.CreateDate <= toFrom.Value)
                         select item).ToList();
            }

            if (id != null)
            {
                BDSupplierPrimaryKey pk = new BDSupplierPrimaryKey();
                pk.SupplierID = id;
                try
                {
                    query = SelectAllByForeignKeySupplierID(pk).ToList();
                }
                catch (Exception EX)
                {
                    query = new List<BDSupplierAccount>();
                }
            }

            if (query.Count == 0)
                return supplierAccountCollection;

            supplierAccountCollection = (from item in query
                                         join customer in _supplierService.SelectAll() on item.SupplierID equals customer.SupplierID
                                         join _user in _userService.SelectAll() on item.CreatedBy equals _user.UserID
                                         select new BDSupplierAccount()
                                         {
                                             SupplierAccountId = item.SupplierAccountId,
                                             SupplierID = item.SupplierID,
                                             SupplierName = customer.SupplierName,
                                             InvoiceNumber = item.InvoiceNumber,
                                             IsVoid = item.IsVoid,
                                             PaidAmount = item.PaidAmount,
                                             RemainingAmount = item.RemainingAmount,
                                             PurchaseDate = item.PurchaseDate,
                                             PurcaseInvoiceID = item.PurcaseInvoiceID,
                                             TotalPrice = item.TotalPrice,
                                             CreateDate = item.CreateDate,
                                             CreatedByName = _user.UserFullName,
                                             ChequeNumber = item.ChequeNumber,
                                             Credit = item.Credit,
                                             Depit = item.Depit,
                                             InvoiceType = item.InvoiceType,
                                             LstDayToPay = item.LstDayToPay
                                         }
                                          ).ToList();
            return supplierAccountCollection;

        }

        public bool SaveAccountUpdates( BDSupplierAccount _supplierAccount)
        {
            #region select area
            PURPurchaseHeaderPrimaryKey purchaseHeaderpk = new PURPurchaseHeaderPrimaryKey();
            purchaseHeaderpk.PurcaseHeaderID = _supplierAccount.PurcaseInvoiceID;
            PURPurchaseHeader _pURPurchaseHeader = _purchaseHeaderService.SelectOne(purchaseHeaderpk);

            BDSupplierAccountPrimaryKey supplierAccountpk = new BDSupplierAccountPrimaryKey();
            supplierAccountpk.SupplierAccountId = _supplierAccount.SupplierAccountId;
            BDSupplierAccount supplierAccount = SelectOne(supplierAccountpk);
            #endregion

            #region supplier account area
            POS.DataLayer.BDSupplierAccount supplierAccountDal = new POS.DataLayer.BDSupplierAccount();
            supplierAccountDal.CreateDate = supplierAccount.CreateDate ;
            supplierAccountDal.CreatedBy = supplierAccount.CreatedBy ;
            supplierAccountDal.DeleteDate = supplierAccount.DeleteDate ;
            supplierAccountDal.DeletedBy = supplierAccount.DeletedBy ;
            supplierAccountDal.InvoiceNumber = supplierAccount.InvoiceNumber ;
            supplierAccountDal.IsDeleted = supplierAccount.IsDeleted ;
            supplierAccountDal.IsVoid = supplierAccount.IsVoid ;
            supplierAccountDal.PurcaseInvoiceID = supplierAccount.PurcaseInvoiceID ;
            supplierAccountDal.PurchaseDate = supplierAccount.PurchaseDate ;
            supplierAccountDal.SupplierAccountId = supplierAccount.SupplierAccountId ;
            supplierAccountDal.SupplierID = supplierAccount.SupplierID ;
            supplierAccountDal.updateDate = supplierAccount.updateDate;
            supplierAccountDal.UpdatedBy = supplierAccount.UpdatedBy;
            ////////// Updated area
            supplierAccountDal.PaidAmount = _supplierAccount.PaidAmount;
            supplierAccountDal.RemainingAmount = _supplierAccount.RemainingAmount;
            supplierAccountDal.TotalPrice = _supplierAccount.TotalPrice;
            #endregion

            #region purchase area

            POS.DataLayer.PURPurchaseHeader _purchaseHeaderDAL = new POS.DataLayer.PURPurchaseHeader();
            _purchaseHeaderDAL.PurcaseHeaderID = _pURPurchaseHeader.PurcaseHeaderID;
            _purchaseHeaderDAL.PurchaseDate = _pURPurchaseHeader.PurchaseDate;
            _purchaseHeaderDAL.SupplierID = _pURPurchaseHeader.SupplierID;
            _purchaseHeaderDAL.SupplierName = _pURPurchaseHeader.SupplierName;
            _purchaseHeaderDAL.InvoiceNumber = _pURPurchaseHeader.InvoiceNumber;
            _purchaseHeaderDAL.InvoiceDate = _pURPurchaseHeader.InvoiceDate;
            _purchaseHeaderDAL.PaymentTypeID = _pURPurchaseHeader.PaymentTypeID;
            _purchaseHeaderDAL.LastDayToPay = _pURPurchaseHeader.LastDayToPay;
            _purchaseHeaderDAL.TotalDiscountAmount = _pURPurchaseHeader.TotalDiscountAmount;
            _purchaseHeaderDAL.TotalDiscountRatio = _pURPurchaseHeader.TotalDiscountRatio;
            _purchaseHeaderDAL.IsClosed = _pURPurchaseHeader.IsClosed;
            _purchaseHeaderDAL.IsVoid = _pURPurchaseHeader.IsVoid;
            _purchaseHeaderDAL.IsPrinted = _pURPurchaseHeader.IsPrinted;
            _purchaseHeaderDAL.ServicePrice = _pURPurchaseHeader.ServicePrice;
            _purchaseHeaderDAL.TaxTypeID = _pURPurchaseHeader.TaxTypeID;
            _purchaseHeaderDAL.RefuseReasonID = _pURPurchaseHeader.RefuseReasonID;
            _purchaseHeaderDAL.CreatedBy = _pURPurchaseHeader.CreatedBy;
            _purchaseHeaderDAL.CreateDate = _pURPurchaseHeader.CreateDate;
            _purchaseHeaderDAL.UpdatedBy = _pURPurchaseHeader.UpdatedBy;
            _purchaseHeaderDAL.updateDate = _pURPurchaseHeader.updateDate;
            _purchaseHeaderDAL.IsDeleted = _pURPurchaseHeader.IsDeleted;
            _purchaseHeaderDAL.DeletedBy = _pURPurchaseHeader.DeletedBy;
            _purchaseHeaderDAL.DeleteDate = _pURPurchaseHeader.DeleteDate;
            ///////////// updated area
            _purchaseHeaderDAL.TotalPrice = _supplierAccount.TotalPrice;
            _purchaseHeaderDAL.PaidAmount = _supplierAccount.PaidAmount;
            _purchaseHeaderDAL.RemainingAmount = _supplierAccount.RemainingAmount;
            #endregion

            POS.DataLayer.BDSupplierAccount supplierAccountObj = new DataLayer.BDSupplierAccount();
            return supplierAccountObj.SaveAccountUpdates(_purchaseHeaderDAL, supplierAccountDal);
        }

    }
}
