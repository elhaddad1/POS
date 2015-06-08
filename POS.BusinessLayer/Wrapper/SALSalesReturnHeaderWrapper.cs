using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BusinessLayer.Wrapper
{
    public class SALSalesReturnHeaderWrapper : SALSalesReturnHeaderService
    {
        //VSalesReturnHeaderService vSalesReturnHeaderService;
        VSALSalesOrderService vSALSalesOrderService;

        public VSalesReturnHeaderCollection SearchByCriteria(string CustomerName, string InvoiceNumber, DateTime DateFrom, DateTime DateTo)
        {
            VSalesReturnHeaderCollection vSalesReturnHeaderCollection = new VSalesReturnHeaderCollection();
            foreach (POS.DataLayer.VSalesReturnHeader _vSalesReturnHeader in POS.DataLayer.VSalesReturnHeader.SearchByriteria(CustomerName, DateFrom, DateTo, InvoiceNumber))
            {
                VSalesReturnHeader _vSalesReturnHeaderWCF = new VSalesReturnHeader();

                _vSalesReturnHeaderWCF.SlaesReturnHeaderID = _vSalesReturnHeader.SlaesReturnHeaderID;
                _vSalesReturnHeaderWCF.ReturnDate = _vSalesReturnHeader.ReturnDate;
                _vSalesReturnHeaderWCF.IsClosed = _vSalesReturnHeader.IsClosed;
                _vSalesReturnHeaderWCF.InvoiceNumber = _vSalesReturnHeader.InvoiceNumber;
                _vSalesReturnHeaderWCF.CustomerName = _vSalesReturnHeader.CustomerName;
                _vSalesReturnHeaderWCF.SalesHeaderID = _vSalesReturnHeader.SalesHeaderID;

                vSalesReturnHeaderCollection.Add(_vSalesReturnHeaderWCF);
            }
            return vSalesReturnHeaderCollection;
        }
        public bool DeleteOrder(int SalesReturnHeaderID)
        {
            return POS.DataLayer.SALSalesReturnHeader.DeleteOrder(SalesReturnHeaderID, Utility.GlobalVariables.CurrentUser.UserID);
        }
        public bool CloseOrder(int SalesReturnHeaderID)
        {
            return POS.DataLayer.SALSalesReturnHeader.CloseOrder(SalesReturnHeaderID, Utility.GlobalVariables.CurrentUser.UserID);

        }

        public VSALSalesOrderCollection VSALSalesOrder_SelectOneByInvoiceNumber(string InvoiceNumber)
        {
            VSALSalesOrderCollection vSALSalesOrderCollection = new VSALSalesOrderCollection();

            VSALSalesOrder _vSALSalesOrderWCF = new VSALSalesOrder();
            foreach (POS.DataLayer.VSALSalesOrder _vSALSalesOrder in POS.DataLayer.VSALSalesOrder.SelectByInvoiceNumber("InvoiceNumber", InvoiceNumber, null, DataLayer.TypeOperation.Equal))
            {
                _vSALSalesOrderWCF = new VSALSalesOrder();

                _vSALSalesOrderWCF.CustomerID = _vSALSalesOrder.CustomerID;
                _vSALSalesOrderWCF.CustomerName = _vSALSalesOrder.CustomerName;
                _vSALSalesOrderWCF.Qty = _vSALSalesOrder.Qty;
                _vSALSalesOrderWCF.SalesLineID = _vSALSalesOrder.SalesLineID;
                _vSALSalesOrderWCF.TotalQty = _vSALSalesOrder.TotalQty;
                _vSALSalesOrderWCF.UnitPrice = _vSALSalesOrder.UnitPrice;
                _vSALSalesOrderWCF.BatchNumber = _vSALSalesOrder.BatchNumber;
                _vSALSalesOrderWCF.ExpiryDate = _vSALSalesOrder.ExpiryDate;
                _vSALSalesOrderWCF.TaxValue = _vSALSalesOrder.TaxValue;
                _vSALSalesOrderWCF.SalesHeaderID = _vSALSalesOrder.SalesHeaderID;
                _vSALSalesOrderWCF.SalesDate = _vSALSalesOrder.SalesDate;
                _vSALSalesOrderWCF.InvoiceNumber = _vSALSalesOrder.InvoiceNumber;
                _vSALSalesOrderWCF.InvoiceDate = _vSALSalesOrder.InvoiceDate;
                _vSALSalesOrderWCF.PaymentTypeID = _vSALSalesOrder.PaymentTypeID;
                _vSALSalesOrderWCF.TotalDiscountRatio = _vSALSalesOrder.TotalDiscountRatio;
                _vSALSalesOrderWCF.TaxTypeName = _vSALSalesOrder.TaxTypeName;
                _vSALSalesOrderWCF.IsClosed = _vSALSalesOrder.IsClosed;
                _vSALSalesOrderWCF.IsVoid = _vSALSalesOrder.IsVoid;
                _vSALSalesOrderWCF.FinalPrice = _vSALSalesOrder.FinalPrice;
                _vSALSalesOrderWCF.ChequeNumber = _vSALSalesOrder.ChequeNumber;
                _vSALSalesOrderWCF.ProductName = _vSALSalesOrder.ProductName;
                _vSALSalesOrderWCF.ProductCode = _vSALSalesOrder.ProductCode;
                _vSALSalesOrderWCF.IsAcceptBatch = _vSALSalesOrder.IsAcceptBatch;
                _vSALSalesOrderWCF.UserFullName = _vSALSalesOrder.UserFullName;
                _vSALSalesOrderWCF.ProductID = _vSALSalesOrder.ProductID;

                vSALSalesOrderCollection.Add(_vSALSalesOrderWCF);
            }
            return vSALSalesOrderCollection;
        }

        public VSALSalesOrderCollection VSALSalesOrder_SelectOne(int SalesHeaderID)
        {
            vSALSalesOrderService = new VSALSalesOrderService();
            return vSALSalesOrderService.SelectByField("SalesHeaderID", SalesHeaderID, null, DataLayer.TypeOperation.Equal);

        }


    }
}
