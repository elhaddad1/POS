using POS.BusinessLayer.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BusinessLayer.Wrapper
{
   public class PURPurchaseLineWrapper:PURPurchaseLineService 
    {
        public bool SavePURPurchaseOrder(PURPurchaseHeader pURPurchaseHeader, PURPurchaseLineCollection pURPurchaseLineCollection)
        {
            POS.DataLayer.PURPurchaseHeader _pURPurchaseHeader = new POS.DataLayer.PURPurchaseHeader();
            //_pURPurchaseHeader.SalesHeaderID = pURPurchaseHeader.SalesHeaderID;
            _pURPurchaseHeader.PurchaseDate = DateTime.Now;
            _pURPurchaseHeader.SupplierID = pURPurchaseHeader.SupplierID;
            // _pURPurchaseHeader.InvoiceNumber = pURPurchaseHeader.InvoiceNumber;
            _pURPurchaseHeader.InvoiceDate = pURPurchaseHeader.InvoiceDate;
           // _pURPurchaseHeader.SellerID = GlobalVariables.CurrentUser.UserID;
            _pURPurchaseHeader.PaymentTypeID = pURPurchaseHeader.PaymentTypeID;
            _pURPurchaseHeader.TotalPrice = pURPurchaseHeader.TotalPrice;
            _pURPurchaseHeader.PaidAmount = pURPurchaseHeader.PaidAmount;
            _pURPurchaseHeader.RemainingAmount = pURPurchaseHeader.RemainingAmount;
            _pURPurchaseHeader.LastDayToPay = pURPurchaseHeader.LastDayToPay;
            _pURPurchaseHeader.TotalDiscountAmount = pURPurchaseHeader.TotalDiscountAmount;
            _pURPurchaseHeader.TotalDiscountRatio = pURPurchaseHeader.TotalDiscountRatio;
            _pURPurchaseHeader.IsClosed = false;
            _pURPurchaseHeader.IsVoid = false;
            _pURPurchaseHeader.IsPrinted = false;
            _pURPurchaseHeader.ServicePrice = pURPurchaseHeader.ServicePrice;
            _pURPurchaseHeader.TaxTypeID = pURPurchaseHeader.TaxTypeID;
            _pURPurchaseHeader.RefuseReasonID = null;
            _pURPurchaseHeader.CreatedBy = GlobalVariables.CurrentUser.UserID;
            _pURPurchaseHeader.CreateDate = DateTime.Now;
            _pURPurchaseHeader.UpdatedBy = null;
            _pURPurchaseHeader.updateDate = null;
            _pURPurchaseHeader.IsDeleted = false;
            _pURPurchaseHeader.DeletedBy = null;
            _pURPurchaseHeader.DeleteDate = null;

            POS.DataLayer.PURPurchaseLineCollection _pURPurchaseLineCollection = new DataLayer.PURPurchaseLineCollection();
            foreach (PURPurchaseLine pURPurchaseLine in pURPurchaseLineCollection)
            {
                POS.DataLayer.PURPurchaseLine _pURPurchaseLine = new POS.DataLayer.PURPurchaseLine();
                _pURPurchaseLine.ProductID = pURPurchaseLine.ProductID;
                _pURPurchaseLine.TotalQty = pURPurchaseLine.TotalQty;
                _pURPurchaseLine.BonusQty = pURPurchaseLine.BonusQty;
                _pURPurchaseLine.DiscountAmount = pURPurchaseLine.DiscountAmount;
                _pURPurchaseLine.DiscountRatio = pURPurchaseLine.DiscountRatio;
                _pURPurchaseLine.Unitprice = pURPurchaseLine.Unitprice;
                _pURPurchaseLine.CreatedBy = GlobalVariables.CurrentUser.UserID;
                _pURPurchaseLine.CreatedDate = DateTime.Now;
                _pURPurchaseLine.UpdatedBy = null;
                _pURPurchaseLine.UpdateDate = null;
                _pURPurchaseLine.IsDeleted = false;
                _pURPurchaseLine.DeletedBy = null;
                _pURPurchaseLine.DeleteDate = null;
                _pURPurchaseLineCollection.Add(_pURPurchaseLine);
            }
            POS.DataLayer.PURPurchaseLine pURPurchaseLineObj = new DataLayer.PURPurchaseLine();
            return pURPurchaseLineObj.SaveTransaction(_pURPurchaseHeader, _pURPurchaseLineCollection);
        }
        public bool SaveClosePURPurchaseOrder(PURPurchaseHeader pURPurchaseHeader, PURPurchaseLineCollection pURPurchaseLineCollection)
        {
            POS.DataLayer.PURPurchaseHeader _pURPurchaseHeader = new POS.DataLayer.PURPurchaseHeader();

            _pURPurchaseHeader.PurchaseDate = DateTime.Now;
            _pURPurchaseHeader.SupplierID = pURPurchaseHeader.SupplierID;
            _pURPurchaseHeader.InvoiceDate = pURPurchaseHeader.InvoiceDate;
          //  _pURPurchaseHeader.SellerID = GlobalVariables.CurrentUser.UserID;
            _pURPurchaseHeader.PaymentTypeID = pURPurchaseHeader.PaymentTypeID;
            _pURPurchaseHeader.TotalPrice = pURPurchaseHeader.TotalPrice;
            _pURPurchaseHeader.PaidAmount = pURPurchaseHeader.PaidAmount;
            _pURPurchaseHeader.RemainingAmount = pURPurchaseHeader.RemainingAmount;
            _pURPurchaseHeader.LastDayToPay = pURPurchaseHeader.LastDayToPay;
            _pURPurchaseHeader.TotalDiscountAmount = pURPurchaseHeader.TotalDiscountAmount;
            _pURPurchaseHeader.TotalDiscountRatio = pURPurchaseHeader.TotalDiscountRatio;
            _pURPurchaseHeader.IsClosed = true;
            _pURPurchaseHeader.IsVoid = false;
            _pURPurchaseHeader.IsPrinted = false;
            _pURPurchaseHeader.ServicePrice = pURPurchaseHeader.ServicePrice;
            _pURPurchaseHeader.TaxTypeID = pURPurchaseHeader.TaxTypeID;
            _pURPurchaseHeader.RefuseReasonID = null;
            _pURPurchaseHeader.CreatedBy = GlobalVariables.CurrentUser.UserID;
            _pURPurchaseHeader.CreateDate = DateTime.Now;
            _pURPurchaseHeader.UpdatedBy = null;
            _pURPurchaseHeader.updateDate = null;
            _pURPurchaseHeader.IsDeleted = false;
            _pURPurchaseHeader.DeletedBy = null;
            _pURPurchaseHeader.DeleteDate = null;

            POS.DataLayer.PURPurchaseLineCollection _pURPurchaseLineCollection = new DataLayer.PURPurchaseLineCollection();
            foreach (PURPurchaseLine pURPurchaseLine in pURPurchaseLineCollection)
            {
                POS.DataLayer.PURPurchaseLine _pURPurchaseLine = new POS.DataLayer.PURPurchaseLine();
                _pURPurchaseLine.ProductID = pURPurchaseLine.ProductID;
                _pURPurchaseLine.TotalQty = pURPurchaseLine.TotalQty;
                _pURPurchaseLine.BonusQty = pURPurchaseLine.BonusQty;
                _pURPurchaseLine.DiscountAmount = pURPurchaseLine.DiscountAmount;
                _pURPurchaseLine.DiscountRatio = pURPurchaseLine.DiscountRatio;
                _pURPurchaseLine.Unitprice = pURPurchaseLine.Unitprice;
                _pURPurchaseLine.CreatedBy = GlobalVariables.CurrentUser.UserID;
                _pURPurchaseLine.CreatedDate = DateTime.Now;
                _pURPurchaseLine.UpdatedBy = null;
                _pURPurchaseLine.UpdateDate = null;
                _pURPurchaseLine.IsDeleted = false;
                _pURPurchaseLine.DeletedBy = null;
                _pURPurchaseLine.DeleteDate = null;
                _pURPurchaseLineCollection.Add(_pURPurchaseLine);
            }
            POS.DataLayer.PURPurchaseLine pURPurchaseLineObj = new DataLayer.PURPurchaseLine();
            return pURPurchaseLineObj.SaveTransaction(_pURPurchaseHeader, _pURPurchaseLineCollection);
        }

    }
}
