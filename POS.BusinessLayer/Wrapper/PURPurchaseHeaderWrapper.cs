using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BusinessLayer.Wrapper
{
   public class PURPurchaseHeaderWrapper:PURPurchaseHeaderService
    {
        public PURPurchaseHeaderCollection HeaderSearch(int InventoryID,DateTime FromDate,DateTime ToDate ,string SupplierName, string InvoiceNumber)
        {
            PURPurchaseHeaderCollection PURPurcaseHeaderCollection = new PURPurchaseHeaderCollection();
            foreach (POS.DataLayer.PURPurchaseHeader _pURPurchaseHeader in POS.DataLayer.PURPurchaseHeader.HeaderSearch(InventoryID,FromDate, ToDate ,SupplierName, InvoiceNumber))
            {
                PURPurchaseHeader _pURPurchaseHeaderWCF = new PURPurchaseHeader();

                _pURPurchaseHeaderWCF.PurcaseHeaderID = _pURPurchaseHeader.PurcaseHeaderID;
                _pURPurchaseHeaderWCF.PurchaseDate = _pURPurchaseHeader.PurchaseDate;
                _pURPurchaseHeaderWCF.SupplierID = _pURPurchaseHeader.SupplierID;
                _pURPurchaseHeaderWCF .SupplierName = _pURPurchaseHeader.SupplierName;
                _pURPurchaseHeaderWCF.InvoiceNumber = _pURPurchaseHeader.InvoiceNumber;
                _pURPurchaseHeaderWCF.InvoiceDate = _pURPurchaseHeader.InvoiceDate;
               // _pURPurchaseHeaderWCF.SellerID = _pURPurchaseHeader.SellerID;
                _pURPurchaseHeaderWCF.PaymentTypeID = _pURPurchaseHeader.PaymentTypeID;
                _pURPurchaseHeaderWCF.TotalPrice = _pURPurchaseHeader.TotalPrice;
                _pURPurchaseHeaderWCF.PaidAmount = _pURPurchaseHeader.PaidAmount;
                _pURPurchaseHeaderWCF.RemainingAmount = _pURPurchaseHeader.RemainingAmount;
                _pURPurchaseHeaderWCF.LastDayToPay = _pURPurchaseHeader.LastDayToPay;
                _pURPurchaseHeaderWCF.TotalDiscountAmount = _pURPurchaseHeader.TotalDiscountAmount;
                _pURPurchaseHeaderWCF.TotalDiscountRatio = _pURPurchaseHeader.TotalDiscountRatio;
                _pURPurchaseHeaderWCF.IsClosed = _pURPurchaseHeader.IsClosed;
                _pURPurchaseHeaderWCF.IsVoid = _pURPurchaseHeader.IsVoid;
                _pURPurchaseHeaderWCF.IsPrinted = _pURPurchaseHeader.IsPrinted;
                _pURPurchaseHeaderWCF.ServicePrice = _pURPurchaseHeader.ServicePrice;
                _pURPurchaseHeaderWCF.TaxTypeID = _pURPurchaseHeader.TaxTypeID;
                _pURPurchaseHeaderWCF.RefuseReasonID = _pURPurchaseHeader.RefuseReasonID;
                _pURPurchaseHeaderWCF.CreatedBy = _pURPurchaseHeader.CreatedBy;
                _pURPurchaseHeaderWCF.CreateDate = _pURPurchaseHeader.CreateDate;
                _pURPurchaseHeaderWCF.UpdatedBy = _pURPurchaseHeader.UpdatedBy;
                _pURPurchaseHeaderWCF.updateDate = _pURPurchaseHeader.updateDate;
                _pURPurchaseHeaderWCF.IsDeleted = _pURPurchaseHeader.IsDeleted;
                _pURPurchaseHeaderWCF.DeletedBy = _pURPurchaseHeader.DeletedBy;
                _pURPurchaseHeaderWCF.DeleteDate = _pURPurchaseHeader.DeleteDate;

                PURPurcaseHeaderCollection.Add(_pURPurchaseHeaderWCF);
            }
            return PURPurcaseHeaderCollection;
        }

        public bool DeleteOrder(int PurchaseHeaderID)
        {
            //int x = Utility.GlobalVariables.CurrentUser.UserID;
            return POS.DataLayer.PURPurchaseHeader.DeleteOrder(PurchaseHeaderID, Utility.GlobalVariables.CurrentUser.UserID);
        }

        public bool CloseOrder(int PurchaseHeaderID)
        {
            return POS.DataLayer.PURPurchaseHeader.CloseOrder(PurchaseHeaderID, Utility.GlobalVariables.CurrentUser.UserID);

        }
    }
}
