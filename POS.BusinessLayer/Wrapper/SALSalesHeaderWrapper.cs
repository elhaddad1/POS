using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BusinessLayer.Wrapper
{
    public class SALSalesHeaderWrapper : SALSalesHeaderService
    {
        public SALSalesHeaderCollection HeaderSearch(string CustomerName, string InvoiceNumber)
        {
            SALSalesHeaderCollection sALSalesHeaderCollection = new SALSalesHeaderCollection();
            foreach (POS.DataLayer.SALSalesHeader _sALSalesHeader in POS.DataLayer.SALSalesHeader.HeaderSearch(CustomerName, InvoiceNumber))
            {
                SALSalesHeader _sALSalesHeaderWCF = new SALSalesHeader();

                _sALSalesHeaderWCF.SalesHeaderID = _sALSalesHeader.SalesHeaderID;
                _sALSalesHeaderWCF.SalesDate = _sALSalesHeader.SalesDate;
                _sALSalesHeaderWCF.CustomerID = _sALSalesHeader.CustomerID;
                _sALSalesHeaderWCF.CustomerName = _sALSalesHeader.CustomerName;
                _sALSalesHeaderWCF.InvoiceNumber = _sALSalesHeader.InvoiceNumber;
                _sALSalesHeaderWCF.InvoiceDate = _sALSalesHeader.InvoiceDate;
                _sALSalesHeaderWCF.SellerID = _sALSalesHeader.SellerID;
                _sALSalesHeaderWCF.PaymentTypeID = _sALSalesHeader.PaymentTypeID;
                _sALSalesHeaderWCF.TotalPrice = _sALSalesHeader.TotalPrice;
                _sALSalesHeaderWCF.PaidAmount = _sALSalesHeader.PaidAmount;
                _sALSalesHeaderWCF.RemainingAmount = _sALSalesHeader.RemainingAmount;
                _sALSalesHeaderWCF.LastDayToPay = _sALSalesHeader.LastDayToPay;
                _sALSalesHeaderWCF.TotalDiscountAmount = _sALSalesHeader.TotalDiscountAmount;
                _sALSalesHeaderWCF.TotalDiscountRatio = _sALSalesHeader.TotalDiscountRatio;
                _sALSalesHeaderWCF.IsClosed = _sALSalesHeader.IsClosed;
                _sALSalesHeaderWCF.IsVoid = _sALSalesHeader.IsVoid;
                _sALSalesHeaderWCF.IsPrinted = _sALSalesHeader.IsPrinted;
                _sALSalesHeaderWCF.ServicePrice = _sALSalesHeader.ServicePrice;
                _sALSalesHeaderWCF.TaxTypeID = _sALSalesHeader.TaxTypeID;
                _sALSalesHeaderWCF.RefuseReasonID = _sALSalesHeader.RefuseReasonID;
                _sALSalesHeaderWCF.CreatedBy = _sALSalesHeader.CreatedBy;
                _sALSalesHeaderWCF.CreateDate = _sALSalesHeader.CreateDate;
                _sALSalesHeaderWCF.UpdatedBy = _sALSalesHeader.UpdatedBy;
                _sALSalesHeaderWCF.UpdateDate = _sALSalesHeader.UpdateDate;
                _sALSalesHeaderWCF.IsDeleted = _sALSalesHeader.IsDeleted;
                _sALSalesHeaderWCF.DeletedBy = _sALSalesHeader.DeletedBy;
                _sALSalesHeaderWCF.DeletDate = _sALSalesHeader.DeletDate;

                sALSalesHeaderCollection.Add(_sALSalesHeaderWCF);
            }
            return sALSalesHeaderCollection;
        }

        public bool DeleteOrder(int SalesHeaderID)
        {
            //int x = Utility.GlobalVariables.CurrentUser.UserID;
            return POS.DataLayer.SALSalesHeader.DeleteOrder(SalesHeaderID, Utility.GlobalVariables.CurrentUser.UserID);
        }

        public bool CloseOrder(int SalesHeaderID)
        {
            return POS.DataLayer.SALSalesHeader.CloseOrder(SalesHeaderID, Utility.GlobalVariables.CurrentUser.UserID);

        }
    }
}
