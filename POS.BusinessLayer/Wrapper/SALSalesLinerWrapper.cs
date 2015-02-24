using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.BusinessLayer.Utility;

namespace POS.BusinessLayer.Wrapper
{
    public class SALSalesLinerWrapper : SALSalesLineService
    {
        public int SaveSALSalesOrder(SALSalesHeader sALSalesHeader, SALSalesLineCollection sALSalesLineCollection)
        {
            POS.DataLayer.SALSalesHeader _sALSalesHeader = new POS.DataLayer.SALSalesHeader();
            //_sALSalesHeader.SalesHeaderID = sALSalesHeader.SalesHeaderID;
            _sALSalesHeader.SalesDate = DateTime.Now;
            _sALSalesHeader.CustomerID = sALSalesHeader.CustomerID;
            _sALSalesHeader.InventoryID = sALSalesHeader.InventoryID;
            _sALSalesHeader.FinalPrice = sALSalesHeader.FinalPrice;
            _sALSalesHeader.InvoiceDate = sALSalesHeader.InvoiceDate;
            _sALSalesHeader.SellerID = GlobalVariables.CurrentUser.UserID;
            _sALSalesHeader.PaymentTypeID = sALSalesHeader.PaymentTypeID;
            _sALSalesHeader.TotalPrice = sALSalesHeader.TotalPrice;
            _sALSalesHeader.PaidAmount = sALSalesHeader.PaidAmount;
            _sALSalesHeader.RemainingAmount = sALSalesHeader.RemainingAmount;
            _sALSalesHeader.LastDayToPay = sALSalesHeader.LastDayToPay;
            _sALSalesHeader.TotalDiscountAmount = sALSalesHeader.TotalDiscountAmount;
            _sALSalesHeader.TotalDiscountRatio = sALSalesHeader.TotalDiscountRatio;
            _sALSalesHeader.IsClosed = false;
            _sALSalesHeader.IsVoid = false;
            _sALSalesHeader.IsPrinted = false;
            _sALSalesHeader.ServicePrice = sALSalesHeader.ServicePrice;
            _sALSalesHeader.TaxTypeID = sALSalesHeader.TaxTypeID;
            _sALSalesHeader.RefuseReasonID = null;
            _sALSalesHeader.CreatedBy = GlobalVariables.CurrentUser.UserID;
            _sALSalesHeader.CreateDate = DateTime.Now;
            _sALSalesHeader.UpdatedBy = null;
            _sALSalesHeader.UpdateDate = null;
            _sALSalesHeader.IsDeleted = false;
            _sALSalesHeader.DeletedBy = null;
            _sALSalesHeader.DeletDate = null;

            POS.DataLayer.SALSalesLineCollection _sALSalesLineCollection = new DataLayer.SALSalesLineCollection();
            foreach (SALSalesLine sALSalesLine in sALSalesLineCollection)
            {
                POS.DataLayer.SALSalesLine _sALSalesLine = new POS.DataLayer.SALSalesLine();
                _sALSalesLine.ProductID = sALSalesLine.ProductID;
                _sALSalesLine.TotalQty = sALSalesLine.TotalQty;
                _sALSalesLine.TotalBonus = sALSalesLine.TotalBonus;
                _sALSalesLine.DiscountAmount = sALSalesLine.DiscountAmount;
                _sALSalesLine.DiscountRatio = sALSalesLine.DiscountRatio;
                _sALSalesLine.UnitPrice = sALSalesLine.UnitPrice;
                _sALSalesLine.CreatedBy = GlobalVariables.CurrentUser.UserID;
                _sALSalesLine.CreateDate = DateTime.Now;
                _sALSalesLine.UpdatedBy = null;
                _sALSalesLine.UpdateDate = null;
                _sALSalesLine.IsDeleted = false;
                _sALSalesLine.DeletedBy = null;
                _sALSalesLine.DeleteDate = null;
                _sALSalesLineCollection.Add(_sALSalesLine);
            }
            POS.DataLayer.SALSalesLine sALSalesLineObj = new DataLayer.SALSalesLine();
            return sALSalesLineObj.SaveTransaction(_sALSalesHeader, _sALSalesLineCollection);
        }
        public int SaveCloseSALSalesOrder(SALSalesHeader sALSalesHeader, SALSalesLineCollection sALSalesLineCollection)
        {
            POS.DataLayer.SALSalesHeader _sALSalesHeader = new POS.DataLayer.SALSalesHeader();

            _sALSalesHeader.SalesDate = DateTime.Now;
            _sALSalesHeader.CustomerID = sALSalesHeader.CustomerID;
            _sALSalesHeader.InvoiceDate = sALSalesHeader.InvoiceDate;
            _sALSalesHeader.InventoryID = sALSalesHeader.InventoryID;
            _sALSalesHeader.SellerID = GlobalVariables.CurrentUser.UserID;
            _sALSalesHeader.PaymentTypeID = sALSalesHeader.PaymentTypeID;
            _sALSalesHeader.TotalPrice = sALSalesHeader.TotalPrice;
            _sALSalesHeader.FinalPrice = sALSalesHeader.FinalPrice;
            _sALSalesHeader.PaidAmount = sALSalesHeader.PaidAmount;
            _sALSalesHeader.RemainingAmount = sALSalesHeader.RemainingAmount;
            _sALSalesHeader.LastDayToPay = sALSalesHeader.LastDayToPay;
            _sALSalesHeader.TotalDiscountAmount = sALSalesHeader.TotalDiscountAmount;
            _sALSalesHeader.TotalDiscountRatio = sALSalesHeader.TotalDiscountRatio;
            _sALSalesHeader.IsClosed = true;
            _sALSalesHeader.IsVoid = false;
            _sALSalesHeader.IsPrinted = false;
            _sALSalesHeader.ServicePrice = sALSalesHeader.ServicePrice;
            _sALSalesHeader.TaxTypeID = sALSalesHeader.TaxTypeID;
            _sALSalesHeader.RefuseReasonID = null;
            _sALSalesHeader.CreatedBy = GlobalVariables.CurrentUser.UserID;
            _sALSalesHeader.CreateDate = DateTime.Now;
            _sALSalesHeader.UpdatedBy = null;
            _sALSalesHeader.UpdateDate = null;
            _sALSalesHeader.IsDeleted = false;
            _sALSalesHeader.DeletedBy = null;
            _sALSalesHeader.DeletDate = null;

            POS.DataLayer.SALSalesLineCollection _sALSalesLineCollection = new DataLayer.SALSalesLineCollection();
            foreach (SALSalesLine sALSalesLine in sALSalesLineCollection)
            {
                POS.DataLayer.SALSalesLine _sALSalesLine = new POS.DataLayer.SALSalesLine();
                _sALSalesLine.ProductID = sALSalesLine.ProductID;
                _sALSalesLine.TotalQty = sALSalesLine.TotalQty;
                _sALSalesLine.TotalBonus = sALSalesLine.TotalBonus;
                _sALSalesLine.DiscountAmount = sALSalesLine.DiscountAmount;
                _sALSalesLine.DiscountRatio = sALSalesLine.DiscountRatio;
                _sALSalesLine.UnitPrice = sALSalesLine.UnitPrice;
                _sALSalesLine.CreatedBy = GlobalVariables.CurrentUser.UserID;
                _sALSalesLine.CreateDate = DateTime.Now;
                _sALSalesLine.UpdatedBy = null;
                _sALSalesLine.UpdateDate = null;
                _sALSalesLine.IsDeleted = false;
                _sALSalesLine.DeletedBy = null;
                _sALSalesLine.DeleteDate = null;
                _sALSalesLineCollection.Add(_sALSalesLine);
            }
            POS.DataLayer.SALSalesLine sALSalesLineObj = new DataLayer.SALSalesLine();
            return sALSalesLineObj.SaveTransaction(_sALSalesHeader, _sALSalesLineCollection);
        }
        public bool UpdateSALSalesOrder(SALSalesHeader sALSalesHeader, SALSalesLineCollection sALSalesLineCollection)
        {
            POS.DataLayer.SALSalesHeader _sALSalesHeader = new POS.DataLayer.SALSalesHeader();
            _sALSalesHeader.SalesHeaderID = sALSalesHeader.SalesHeaderID;
            _sALSalesHeader.SalesDate = DateTime.Now;
            _sALSalesHeader.CustomerID = sALSalesHeader.CustomerID;
            _sALSalesHeader.InvoiceNumber = sALSalesHeader.InvoiceNumber;
            _sALSalesHeader.InventoryID = sALSalesHeader.InventoryID;
            _sALSalesHeader.InvoiceDate = sALSalesHeader.InvoiceDate;
            _sALSalesHeader.SellerID = GlobalVariables.CurrentUser.UserID;
            _sALSalesHeader.PaymentTypeID = sALSalesHeader.PaymentTypeID;
            _sALSalesHeader.TotalPrice = sALSalesHeader.TotalPrice;
            _sALSalesHeader.FinalPrice = sALSalesHeader.FinalPrice;
            _sALSalesHeader.PaidAmount = sALSalesHeader.PaidAmount;
            _sALSalesHeader.RemainingAmount = sALSalesHeader.RemainingAmount;
            _sALSalesHeader.LastDayToPay = sALSalesHeader.LastDayToPay;
            _sALSalesHeader.TotalDiscountAmount = sALSalesHeader.TotalDiscountAmount;
            _sALSalesHeader.TotalDiscountRatio = sALSalesHeader.TotalDiscountRatio;
            _sALSalesHeader.IsClosed = false;
            _sALSalesHeader.IsVoid = false;
            _sALSalesHeader.IsPrinted = false;
            _sALSalesHeader.ServicePrice = sALSalesHeader.ServicePrice;
            _sALSalesHeader.TaxTypeID = sALSalesHeader.TaxTypeID;
            _sALSalesHeader.RefuseReasonID = null;
            _sALSalesHeader.CreatedBy = GlobalVariables.CurrentUser.UserID;
            _sALSalesHeader.CreateDate = DateTime.Now;
            _sALSalesHeader.UpdatedBy = GlobalVariables.CurrentUser.UserID;
            _sALSalesHeader.UpdateDate = DateTime.Now;
            _sALSalesHeader.IsDeleted = false;
            _sALSalesHeader.DeletedBy = null;
            _sALSalesHeader.DeletDate = null;

            POS.DataLayer.SALSalesLineCollection _sALSalesLineCollection = new DataLayer.SALSalesLineCollection();
            foreach (SALSalesLine sALSalesLine in sALSalesLineCollection)
            {
                POS.DataLayer.SALSalesLine _sALSalesLine = new POS.DataLayer.SALSalesLine();
                _sALSalesLine.ProductID = sALSalesLine.ProductID;
                _sALSalesLine.TotalQty = sALSalesLine.TotalQty;
                _sALSalesLine.TotalBonus = sALSalesLine.TotalBonus;
                _sALSalesLine.DiscountAmount = sALSalesLine.DiscountAmount;
                _sALSalesLine.DiscountRatio = sALSalesLine.DiscountRatio;
                _sALSalesLine.UnitPrice = sALSalesLine.UnitPrice;
                _sALSalesLine.CreatedBy = GlobalVariables.CurrentUser.UserID;
                _sALSalesLine.CreateDate = DateTime.Now;
                _sALSalesLine.UpdatedBy = GlobalVariables.CurrentUser.UserID; ;
                _sALSalesLine.UpdateDate = DateTime.Now;
                _sALSalesLine.IsDeleted = false;
                _sALSalesLine.DeletedBy = null;
                _sALSalesLine.DeleteDate = null;
                _sALSalesLineCollection.Add(_sALSalesLine);
            }
            POS.DataLayer.SALSalesLine sALSalesLineObj = new DataLayer.SALSalesLine();
            return sALSalesLineObj.UpdateTransaction(_sALSalesHeader, _sALSalesLineCollection);
        }
        public bool UpdateCloseSALSalesOrder(SALSalesHeader sALSalesHeader, SALSalesLineCollection sALSalesLineCollection)
        {
            POS.DataLayer.SALSalesHeader _sALSalesHeader = new POS.DataLayer.SALSalesHeader();
            _sALSalesHeader.SalesHeaderID = sALSalesHeader.SalesHeaderID;
            _sALSalesHeader.SalesDate = DateTime.Now;
            _sALSalesHeader.CustomerID = sALSalesHeader.CustomerID;
            _sALSalesHeader.InvoiceNumber = sALSalesHeader.InvoiceNumber;
            _sALSalesHeader.InvoiceDate = sALSalesHeader.InvoiceDate;
            _sALSalesHeader.InventoryID = sALSalesHeader.InventoryID;
            _sALSalesHeader.SellerID = GlobalVariables.CurrentUser.UserID;
            _sALSalesHeader.PaymentTypeID = sALSalesHeader.PaymentTypeID;
            _sALSalesHeader.TotalPrice = sALSalesHeader.TotalPrice;
            _sALSalesHeader.FinalPrice = sALSalesHeader.FinalPrice;
            _sALSalesHeader.PaidAmount = sALSalesHeader.PaidAmount;
            _sALSalesHeader.RemainingAmount = sALSalesHeader.RemainingAmount;
            _sALSalesHeader.LastDayToPay = sALSalesHeader.LastDayToPay;
            _sALSalesHeader.TotalDiscountAmount = sALSalesHeader.TotalDiscountAmount;
            _sALSalesHeader.TotalDiscountRatio = sALSalesHeader.TotalDiscountRatio;
            _sALSalesHeader.IsClosed = true;
            _sALSalesHeader.IsVoid = false;
            _sALSalesHeader.IsPrinted = false;
            _sALSalesHeader.ServicePrice = sALSalesHeader.ServicePrice;
            _sALSalesHeader.TaxTypeID = sALSalesHeader.TaxTypeID;
            _sALSalesHeader.RefuseReasonID = null;
            _sALSalesHeader.CreatedBy = GlobalVariables.CurrentUser.UserID;
            _sALSalesHeader.CreateDate = DateTime.Now;
            _sALSalesHeader.UpdatedBy = GlobalVariables.CurrentUser.UserID;
            _sALSalesHeader.UpdateDate = DateTime.Now;
            _sALSalesHeader.IsDeleted = false;
            _sALSalesHeader.DeletedBy = null;
            _sALSalesHeader.DeletDate = null;

            POS.DataLayer.SALSalesLineCollection _sALSalesLineCollection = new DataLayer.SALSalesLineCollection();
            foreach (SALSalesLine sALSalesLine in sALSalesLineCollection)
            {
                POS.DataLayer.SALSalesLine _sALSalesLine = new POS.DataLayer.SALSalesLine();
                _sALSalesLine.ProductID = sALSalesLine.ProductID;
                _sALSalesLine.TotalQty = sALSalesLine.TotalQty;
                _sALSalesLine.TotalBonus = sALSalesLine.TotalBonus;
                _sALSalesLine.DiscountAmount = sALSalesLine.DiscountAmount;
                _sALSalesLine.DiscountRatio = sALSalesLine.DiscountRatio;
                _sALSalesLine.UnitPrice = sALSalesLine.UnitPrice;
                _sALSalesLine.CreatedBy = GlobalVariables.CurrentUser.UserID;
                _sALSalesLine.CreateDate = DateTime.Now;
                _sALSalesLine.UpdatedBy = GlobalVariables.CurrentUser.UserID; ;
                _sALSalesLine.UpdateDate = DateTime.Now;
                _sALSalesLine.IsDeleted = false;
                _sALSalesLine.DeletedBy = null;
                _sALSalesLine.DeleteDate = null;
                _sALSalesLineCollection.Add(_sALSalesLine);
            }
            POS.DataLayer.SALSalesLine sALSalesLineObj = new DataLayer.SALSalesLine();
            return sALSalesLineObj.UpdateTransaction(_sALSalesHeader, _sALSalesLineCollection);
        }

        public SALSalesLineCollection SelectByField(int salesHeaderID)
        {
            return base.SelectByField("SalesHeaderID", salesHeaderID, null, DataLayer.TypeOperation.Equal);
        }
    }
}
