using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BusinessLayer.Wrapper
{
    public class PURPurchaseReturnHeaderWrapper : PURPurchaseReturnHeaderService
    {
        //VPurchaseReturnHeaderService vPurchaseReturnHeaderService;
        VPURPurchaseOrderService vPURPurchaseOrderService;
        PURPurchaseHeaderService pURPurchaseHeaderService;
        public VPurchaseReturnHeaderCollection SearchByCriteria(string CustomerName, string InvoiceNumber, DateTime DateFrom, DateTime DateTo)
        {
            VPurchaseReturnHeaderCollection vPurchaseReturnHeaderCollection = new VPurchaseReturnHeaderCollection();
            foreach (POS.DataLayer.VPurchaseReturnHeader _vPurchaseReturnHeader in POS.DataLayer.VPurchaseReturnHeader.SearchByriteria(CustomerName, DateFrom, DateTo, InvoiceNumber))
            {
                VPurchaseReturnHeader _vPurchaseReturnHeaderWCF = new VPurchaseReturnHeader();

                _vPurchaseReturnHeaderWCF.PurchaseReturnID = _vPurchaseReturnHeader.PurchaseReturnID;
                _vPurchaseReturnHeaderWCF.ReturnDate = _vPurchaseReturnHeader.ReturnDate;
                _vPurchaseReturnHeaderWCF.IsClosed = _vPurchaseReturnHeader.IsClosed;
                _vPurchaseReturnHeaderWCF.InvoiceNumber = _vPurchaseReturnHeader.InvoiceNumber;
                _vPurchaseReturnHeaderWCF.SupplierName = _vPurchaseReturnHeader.SupplierName;
                _vPurchaseReturnHeaderWCF.PurcaseHeaderID = _vPurchaseReturnHeader.PurcaseHeaderID;

                vPurchaseReturnHeaderCollection.Add(_vPurchaseReturnHeaderWCF);
            }
            return vPurchaseReturnHeaderCollection;
        }
        public bool DeleteOrder(int PurchaseReturnHeaderID)
        {
            return POS.DataLayer.PURPurchaseReturnHeader.DeleteOrder(PurchaseReturnHeaderID, Utility.GlobalVariables.CurrentUser.UserID);
        }
        public bool CloseOrder(int PurchaseReturnHeaderID)
        {
            return POS.DataLayer.PURPurchaseReturnHeader.CloseOrder(PurchaseReturnHeaderID, Utility.GlobalVariables.CurrentUser.UserID);

        }

        public VPURPurchaseOrderCollection VPURPurchaseOrder_SelectOneByInvoiceNumber(string InvoiceNumber)
        {
            vPURPurchaseOrderService = new VPURPurchaseOrderService();
            return vPURPurchaseOrderService.SelectByField("InvoiceNumber", InvoiceNumber, null, DataLayer.TypeOperation.Equal);
        }

        public VPURPurchaseOrderCollection VPURPurchaseOrder_SelectOne(int PurchaseHeaderID)
        {
            vPURPurchaseOrderService = new VPURPurchaseOrderService();
            return vPURPurchaseOrderService.SelectByField("PurcaseHeaderID", PurchaseHeaderID, null, DataLayer.TypeOperation.Equal);

        }

        public PURPurchaseHeaderCollection PURPurchaseOrder_SelectOneByInvoiceNumber(string InvoiceNumber)
        {
            pURPurchaseHeaderService = new PURPurchaseHeaderService();
            return pURPurchaseHeaderService.SelectByField("InvoiceNumber", InvoiceNumber, null, DataLayer.TypeOperation.Equal);
        }
    }
}
