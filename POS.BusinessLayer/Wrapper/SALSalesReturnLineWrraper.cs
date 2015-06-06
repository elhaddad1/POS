using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.BusinessLayer.Utility;

namespace POS.BusinessLayer.Wrapper
{
    public class SALSalesReturnLineWrraper : SALSalesReturnLineService
    {
        public SALSalesReturnLineCollection SelectByField(int salesReturnHeaderID)
        {
            return base.SelectByField("SalesReturnLineID", salesReturnHeaderID, null, DataLayer.TypeOperation.Equal);
        }

        public int SaveSALSalesReturnOrder(SALSalesReturnHeader sALSalesReturnHeader, SALSalesReturnLineCollection sALSalesReturnLineCollection)
        {
            POS.DataLayer.SALSalesReturnHeader _sALSalesReturnHeader = new POS.DataLayer.SALSalesReturnHeader();
            _sALSalesReturnHeader.IsClosed = false;
            return SaveTransaction(sALSalesReturnHeader, sALSalesReturnLineCollection, _sALSalesReturnHeader);
        }

        public int SaveCloseSALSalesReturnOrder(SALSalesReturnHeader sALSalesReturnHeader, SALSalesReturnLineCollection sALSalesReturnLineCollection)
        {
            POS.DataLayer.SALSalesReturnHeader _sALSalesReturnHeader = new POS.DataLayer.SALSalesReturnHeader();
            _sALSalesReturnHeader.IsClosed = true;
            return SaveTransaction(sALSalesReturnHeader, sALSalesReturnLineCollection, _sALSalesReturnHeader);
        }
        public bool UpdateSALSalesOrder(SALSalesReturnHeader sALSalesReturnHeader, SALSalesReturnLineCollection sALSalesReturnLineCollection)
        {
            POS.DataLayer.SALSalesReturnHeader _sALSalesReturnHeader = new POS.DataLayer.SALSalesReturnHeader();
            _sALSalesReturnHeader.IsClosed = false;
            return UpdateTransaction(sALSalesReturnHeader, sALSalesReturnLineCollection, _sALSalesReturnHeader);
        }

        public bool UpdateCloseSALSalesOrder(SALSalesReturnHeader sALSalesReturnHeader, SALSalesReturnLineCollection sALSalesReturnLineCollection)
        {
            POS.DataLayer.SALSalesReturnHeader _sALSalesReturnHeader = new POS.DataLayer.SALSalesReturnHeader();
            _sALSalesReturnHeader.IsClosed = true;
            return UpdateTransaction(sALSalesReturnHeader, sALSalesReturnLineCollection, _sALSalesReturnHeader);
        }
        private static int SaveTransaction(SALSalesReturnHeader sALSalesReturnHeader, SALSalesReturnLineCollection sALSalesReturnLineCollection, POS.DataLayer.SALSalesReturnHeader _sALSalesReturnHeader)
        {
            _sALSalesReturnHeader.IsVoid = false;
            _sALSalesReturnHeader.CreatedBy = GlobalVariables.CurrentUser.UserID;
            _sALSalesReturnHeader.CreateDate = DateTime.Now;
            _sALSalesReturnHeader.UpdatedBy = null;
            _sALSalesReturnHeader.UpdateDate = null;
            _sALSalesReturnHeader.IsDeleted = false;
            _sALSalesReturnHeader.DeletedBy = null;
            _sALSalesReturnHeader.DeleteDate = null;
            _sALSalesReturnHeader.OriginalSalesHeadeID = sALSalesReturnHeader.OriginalSalesHeadeID;
            _sALSalesReturnHeader.ReturnDate = sALSalesReturnHeader.ReturnDate;
            _sALSalesReturnHeader.InventoryID = sALSalesReturnHeader.InventoryID;
            _sALSalesReturnHeader.ReturnMoney = sALSalesReturnHeader.ReturnMoney;
            POS.DataLayer.SALSalesReturnLineCollection _sALSalesReturnLineCollection = new DataLayer.SALSalesReturnLineCollection();
            foreach (SALSalesReturnLine sALSalesReturnLine in sALSalesReturnLineCollection)
            {
                POS.DataLayer.SALSalesReturnLine _sALSalesReturnLine = new POS.DataLayer.SALSalesReturnLine();

                _sALSalesReturnLine.Qty = sALSalesReturnLine.Qty;
                _sALSalesReturnLine.BatchNumber = sALSalesReturnLine.BatchNumber;
                _sALSalesReturnLine.ExpiryDate = sALSalesReturnLine.ExpiryDate;
                _sALSalesReturnLine.OriginalSalesLineID = sALSalesReturnLine.OriginalSalesLineID;
                _sALSalesReturnLine.Reason = sALSalesReturnLine.Reason;
                _sALSalesReturnLine.StockTypeID = sALSalesReturnLine.StockTypeID;

                _sALSalesReturnLineCollection.Add(_sALSalesReturnLine);
            }
            POS.DataLayer.SALSalesReturnLine sALSalesReturnLineObj = new DataLayer.SALSalesReturnLine();
            return sALSalesReturnLineObj.SaveTransaction(_sALSalesReturnHeader, _sALSalesReturnLineCollection);
        }
        private static bool UpdateTransaction(SALSalesReturnHeader sALSalesReturnHeader, SALSalesReturnLineCollection sALSalesReturnLineCollection, POS.DataLayer.SALSalesReturnHeader _sALSalesReturnHeader)
        {
            _sALSalesReturnHeader.IsVoid = false;
            _sALSalesReturnHeader.CreatedBy = GlobalVariables.CurrentUser.UserID;
            _sALSalesReturnHeader.CreateDate = DateTime.Now;
            _sALSalesReturnHeader.UpdatedBy = GlobalVariables.CurrentUser.UserID;
            _sALSalesReturnHeader.UpdateDate = DateTime.Now;
            _sALSalesReturnHeader.IsDeleted = false;
            _sALSalesReturnHeader.DeletedBy = null;
            _sALSalesReturnHeader.DeleteDate = null;
            _sALSalesReturnHeader.OriginalSalesHeadeID = sALSalesReturnHeader.OriginalSalesHeadeID;
            _sALSalesReturnHeader.ReturnDate = sALSalesReturnHeader.ReturnDate;
            _sALSalesReturnHeader.SlaesReturnHeaderID = sALSalesReturnHeader.SlaesReturnHeaderID;
            _sALSalesReturnHeader.InventoryID = sALSalesReturnHeader.InventoryID;
            _sALSalesReturnHeader.ReturnMoney = sALSalesReturnHeader.ReturnMoney;

            POS.DataLayer.SALSalesReturnLineCollection _sALSalesReturnLineCollection = new DataLayer.SALSalesReturnLineCollection();
            foreach (SALSalesReturnLine sALSalesReturnLine in sALSalesReturnLineCollection)
            {
                POS.DataLayer.SALSalesReturnLine _sALSalesReturnLine = new POS.DataLayer.SALSalesReturnLine();

                _sALSalesReturnLine.Qty = sALSalesReturnLine.Qty;
                _sALSalesReturnLine.BatchNumber = sALSalesReturnLine.BatchNumber;
                _sALSalesReturnLine.ExpiryDate = sALSalesReturnLine.ExpiryDate;
                _sALSalesReturnLine.OriginalSalesLineID = sALSalesReturnLine.OriginalSalesLineID;
                _sALSalesReturnLine.Reason = sALSalesReturnLine.Reason;

                _sALSalesReturnLineCollection.Add(_sALSalesReturnLine);
            }
            POS.DataLayer.SALSalesReturnLine sALSalesReturnLineObj = new DataLayer.SALSalesReturnLine();

            return sALSalesReturnLineObj.UpdateTransaction(_sALSalesReturnHeader, _sALSalesReturnLineCollection);
        }

    }
}
