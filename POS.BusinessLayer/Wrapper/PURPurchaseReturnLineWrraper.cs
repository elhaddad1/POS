using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.BusinessLayer.Utility;

namespace POS.BusinessLayer.Wrapper
{
    public class PURPurchaseReturnLineWrraper : PURPurchaseReturnLineService
    {
        public PURPurchaseReturnLineCollection SelectByField(int purchaseReturnHeaderID)
        {
            return base.SelectByField("PurchaseReturnLineID", purchaseReturnHeaderID, null, DataLayer.TypeOperation.Equal);
        }

        public int SavePURPurchaseReturnOrder(PURPurchaseReturnHeader pURPurchaseReturnHeader, PURPurchaseReturnLineCollection pURPurchaseReturnLineCollection)
        {
            POS.DataLayer.PURPurchaseReturnHeader _pURPurchaseReturnHeader = new POS.DataLayer.PURPurchaseReturnHeader();
            _pURPurchaseReturnHeader.IsClosed = false;
            return SaveTransaction(pURPurchaseReturnHeader, pURPurchaseReturnLineCollection, _pURPurchaseReturnHeader);
        }

        public int SaveClosePURPurchaseReturnOrder(PURPurchaseReturnHeader pURPurchaseReturnHeader, PURPurchaseReturnLineCollection pURPurchaseReturnLineCollection)
        {
            POS.DataLayer.PURPurchaseReturnHeader _pURPurchaseReturnHeader = new POS.DataLayer.PURPurchaseReturnHeader();
            _pURPurchaseReturnHeader.IsClosed = true;
            return SaveTransaction(pURPurchaseReturnHeader, pURPurchaseReturnLineCollection, _pURPurchaseReturnHeader);
        }
        public bool UpdatePURPurchaseOrder(PURPurchaseReturnHeader pURPurchaseReturnHeader, PURPurchaseReturnLineCollection pURPurchaseReturnLineCollection)
        {
            POS.DataLayer.PURPurchaseReturnHeader _pURPurchaseReturnHeader = new POS.DataLayer.PURPurchaseReturnHeader();
            _pURPurchaseReturnHeader.IsClosed = false;
            return UpdateTransaction(pURPurchaseReturnHeader, pURPurchaseReturnLineCollection, _pURPurchaseReturnHeader);
        }

        public bool UpdateClosePURPurchaseOrder(PURPurchaseReturnHeader pURPurchaseReturnHeader, PURPurchaseReturnLineCollection pURPurchaseReturnLineCollection)
        {
            POS.DataLayer.PURPurchaseReturnHeader _pURPurchaseReturnHeader = new POS.DataLayer.PURPurchaseReturnHeader();
            _pURPurchaseReturnHeader.IsClosed = true;
            return UpdateTransaction(pURPurchaseReturnHeader, pURPurchaseReturnLineCollection, _pURPurchaseReturnHeader);
        }
        private static int SaveTransaction(PURPurchaseReturnHeader pURPurchaseReturnHeader, PURPurchaseReturnLineCollection pURPurchaseReturnLineCollection, POS.DataLayer.PURPurchaseReturnHeader _pURPurchaseReturnHeader)
        {
            _pURPurchaseReturnHeader.IsVoid = false;
            _pURPurchaseReturnHeader.CreatedBy = GlobalVariables.CurrentUser.UserID;
            _pURPurchaseReturnHeader.CreateDate = DateTime.Now;
            _pURPurchaseReturnHeader.UpdatedBy = null;
            _pURPurchaseReturnHeader.UpdateDate = null;
            _pURPurchaseReturnHeader.IsDeleted = false;
            _pURPurchaseReturnHeader.DeletedBy = null;
            _pURPurchaseReturnHeader.DeleteDate = null;
            _pURPurchaseReturnHeader.OriginalHeaderID = pURPurchaseReturnHeader.OriginalHeaderID;
            _pURPurchaseReturnHeader.ReturnDate = pURPurchaseReturnHeader.ReturnDate;
            _pURPurchaseReturnHeader.ReturnMoney = pURPurchaseReturnHeader.ReturnMoney;
            POS.DataLayer.PURPurchaseReturnLineCollection _pURPurchaseReturnLineCollection = new DataLayer.PURPurchaseReturnLineCollection();
            foreach (PURPurchaseReturnLine pURPurchaseReturnLine in pURPurchaseReturnLineCollection)
            {
                POS.DataLayer.PURPurchaseReturnLine _pURPurchaseReturnLine = new POS.DataLayer.PURPurchaseReturnLine();

                _pURPurchaseReturnLine.Qty = pURPurchaseReturnLine.Qty;
                _pURPurchaseReturnLine.BatchNumber = pURPurchaseReturnLine.BatchNumber;
                _pURPurchaseReturnLine.ExpiryDate = pURPurchaseReturnLine.ExpiryDate;
                _pURPurchaseReturnLine.OriginalpurchaseLineID = pURPurchaseReturnLine.OriginalpurchaseLineID;
                _pURPurchaseReturnLine.Reason = pURPurchaseReturnLine.Reason;

                _pURPurchaseReturnLineCollection.Add(_pURPurchaseReturnLine);
            }
            POS.DataLayer.PURPurchaseReturnLine pURPurchaseReturnLineObj = new DataLayer.PURPurchaseReturnLine();
            return pURPurchaseReturnLineObj.SaveTransaction(_pURPurchaseReturnHeader, _pURPurchaseReturnLineCollection);
        }
        private static bool UpdateTransaction(PURPurchaseReturnHeader pURPurchaseReturnHeader, PURPurchaseReturnLineCollection pURPurchaseReturnLineCollection, POS.DataLayer.PURPurchaseReturnHeader _pURPurchaseReturnHeader)
        {
            _pURPurchaseReturnHeader.IsVoid = false;
            _pURPurchaseReturnHeader.CreatedBy = GlobalVariables.CurrentUser.UserID;
            _pURPurchaseReturnHeader.CreateDate = DateTime.Now;
            _pURPurchaseReturnHeader.UpdatedBy = GlobalVariables.CurrentUser.UserID;
            _pURPurchaseReturnHeader.UpdateDate = DateTime.Now;
            _pURPurchaseReturnHeader.IsDeleted = false;
            _pURPurchaseReturnHeader.DeletedBy = null;
            _pURPurchaseReturnHeader.DeleteDate = null;
            _pURPurchaseReturnHeader.OriginalHeaderID = pURPurchaseReturnHeader.OriginalHeaderID;
            _pURPurchaseReturnHeader.ReturnDate = pURPurchaseReturnHeader.ReturnDate;
            _pURPurchaseReturnHeader.PurchaseReturnID = pURPurchaseReturnHeader.PurchaseReturnID;

            POS.DataLayer.PURPurchaseReturnLineCollection _pURPurchaseReturnLineCollection = new DataLayer.PURPurchaseReturnLineCollection();
            foreach (PURPurchaseReturnLine pURPurchaseReturnLine in pURPurchaseReturnLineCollection)
            {
                POS.DataLayer.PURPurchaseReturnLine _pURPurchaseReturnLine = new POS.DataLayer.PURPurchaseReturnLine();

                _pURPurchaseReturnLine.Qty = pURPurchaseReturnLine.Qty;
                _pURPurchaseReturnLine.BatchNumber = pURPurchaseReturnLine.BatchNumber;
                _pURPurchaseReturnLine.ExpiryDate = pURPurchaseReturnLine.ExpiryDate;
                _pURPurchaseReturnLine.OriginalpurchaseLineID = pURPurchaseReturnLine.OriginalpurchaseLineID;
                _pURPurchaseReturnLine.Reason = pURPurchaseReturnLine.Reason;

                _pURPurchaseReturnLineCollection.Add(_pURPurchaseReturnLine);
            }
            POS.DataLayer.PURPurchaseReturnLine pURPurchaseReturnLineObj = new DataLayer.PURPurchaseReturnLine();

            return pURPurchaseReturnLineObj.UpdateTransaction(_pURPurchaseReturnHeader, _pURPurchaseReturnLineCollection);
        }

    }
}
