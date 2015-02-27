using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BusinessLayer.Wrapper
{
    public class BDCustomerAccountWrapper : BDCustomerAccountService
    {
        private BDCustomerService _customerService = new BDCustomerService();

        private SALSalesHeaderService _purchaseHeaderService = new SALSalesHeaderService();

        public List<BDCustomerAccount> GetCustomerAccounts(int id)
        {
            List<BDCustomerAccount> customerAccountCollection = new List<BDCustomerAccount>();

            BDCustomerPrimaryKey pk = new BDCustomerPrimaryKey();
            pk.CustomerID = id;

            customerAccountCollection = (from item in SelectAllByForeignKeyCustomerID(pk)
                                         join customer in _customerService.SelectAll() on item.CustomerID equals customer.CustomerID
                                         select new BDCustomerAccount()
                                         {
                                             CustomerAccountNumber = item.CustomerAccountNumber,
                                             CustomerID = item.CustomerID,
                                             CustomerName = customer.CustomerName,
                                             InvoiceNumber = item.InvoiceNumber,
                                             IsVoid = item.IsVoid,
                                             PaidAmount = item.PaidAmount,
                                             RemainingAmount = item.RemainingAmount,
                                             SalesDate = item.SalesDate,
                                             SalesInvoiceId = item.SalesInvoiceId,
                                             TotalPrice = item.TotalPrice,
                                             CreateDate = item.CreateDate
                                         }
                                          ).ToList();
            return customerAccountCollection;

        }

        public bool SaveAccountUpdates(BDCustomerAccount _customerAccount)
        {
            #region select area
            SALSalesHeaderPrimaryKey purchaseHeaderpk = new SALSalesHeaderPrimaryKey();
            purchaseHeaderpk.SalesHeaderID = _customerAccount.SalesInvoiceId;
            SALSalesHeader _salSalesHeader = _purchaseHeaderService.SelectOne(purchaseHeaderpk);

            BDCustomerAccountPrimaryKey customerAccountpk = new BDCustomerAccountPrimaryKey();
            customerAccountpk.CustomerAccountNumber = _customerAccount.CustomerAccountNumber;
            BDCustomerAccount customerAccount = SelectOne(customerAccountpk);
            #endregion

            #region customer account area
            POS.DataLayer.BDCustomerAccount customerAccountDal = new POS.DataLayer.BDCustomerAccount();
            customerAccountDal.CreateDate = customerAccount.CreateDate;
            customerAccountDal.CreatedBy = customerAccount.CreatedBy;
            customerAccountDal.DeletedDate = customerAccount.DeletedDate;
            customerAccountDal.DeletedBy = customerAccount.DeletedBy;
            customerAccountDal.InvoiceNumber = customerAccount.InvoiceNumber;
            customerAccountDal.IsDeleted = customerAccount.IsDeleted;
            customerAccountDal.IsVoid = customerAccount.IsVoid;
            customerAccountDal.SalesInvoiceId = customerAccount.SalesInvoiceId;
            customerAccountDal.SalesDate = customerAccount.SalesDate;
            customerAccountDal.CustomerAccountNumber = customerAccount.CustomerAccountNumber;
            customerAccountDal.CustomerID = customerAccount.CustomerID;
            customerAccountDal.UpdateDate = customerAccount.UpdateDate;
            customerAccountDal.UpdatedBy = customerAccount.UpdatedBy;
            ////////// Updated area
            customerAccountDal.PaidAmount = _customerAccount.PaidAmount;
            customerAccountDal.RemainingAmount = _customerAccount.RemainingAmount;
            customerAccountDal.TotalPrice = _customerAccount.TotalPrice;
            #endregion

            #region purchase area

            POS.DataLayer.SALSalesHeader _purchaseHeaderDAL = new POS.DataLayer.SALSalesHeader();
            _purchaseHeaderDAL.SalesHeaderID = _salSalesHeader.SalesHeaderID;
            _purchaseHeaderDAL.SalesDate = _salSalesHeader.SalesDate;
            _purchaseHeaderDAL.CustomerID = _salSalesHeader.CustomerID;
            _purchaseHeaderDAL.CustomerName = _salSalesHeader.CustomerName;
            _purchaseHeaderDAL.InvoiceNumber = _salSalesHeader.InvoiceNumber;
            _purchaseHeaderDAL.InvoiceDate = _salSalesHeader.InvoiceDate;
            _purchaseHeaderDAL.SellerID = _salSalesHeader.SellerID;
            _purchaseHeaderDAL.PaymentTypeID = _salSalesHeader.PaymentTypeID;
            _purchaseHeaderDAL.LastDayToPay = _salSalesHeader.LastDayToPay;
            _purchaseHeaderDAL.TotalDiscountAmount = _salSalesHeader.TotalDiscountAmount;
            _purchaseHeaderDAL.TotalDiscountRatio = _salSalesHeader.TotalDiscountRatio;
            _purchaseHeaderDAL.IsClosed = _salSalesHeader.IsClosed;
            _purchaseHeaderDAL.IsVoid = _salSalesHeader.IsVoid;
            _purchaseHeaderDAL.IsPrinted = _salSalesHeader.IsPrinted;
            _purchaseHeaderDAL.ServicePrice = _salSalesHeader.ServicePrice;
            _purchaseHeaderDAL.TaxTypeID = _salSalesHeader.TaxTypeID;
            _purchaseHeaderDAL.RefuseReasonID = _salSalesHeader.RefuseReasonID;
            _purchaseHeaderDAL.CreatedBy = _salSalesHeader.CreatedBy;
            _purchaseHeaderDAL.CreateDate = _salSalesHeader.CreateDate;
            _purchaseHeaderDAL.UpdatedBy = _salSalesHeader.UpdatedBy;
            _purchaseHeaderDAL.UpdateDate = _salSalesHeader.UpdateDate;
            _purchaseHeaderDAL.IsDeleted = _salSalesHeader.IsDeleted;
            _purchaseHeaderDAL.DeletedBy = _salSalesHeader.DeletedBy;
            _purchaseHeaderDAL.DeletDate = _salSalesHeader.DeletDate;
            ///////////// updated area
            _purchaseHeaderDAL.TotalPrice = _customerAccount.TotalPrice;
            _purchaseHeaderDAL.PaidAmount = _customerAccount.PaidAmount;
            _purchaseHeaderDAL.RemainingAmount = _customerAccount.RemainingAmount;
            #endregion

            POS.DataLayer.BDCustomerAccount customerAccountObj = new DataLayer.BDCustomerAccount();
            return customerAccountObj.SaveAccountUpdates(_purchaseHeaderDAL, customerAccountDal);
        }
    }
}
