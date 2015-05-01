using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.DataLayer;
using POS.BusinessLayer.Utility;
namespace POS.BusinessLayer.Wrapper
{
    public class INVTakingInventoryLineWrapper:INVTakingInventoryLineService
    {
        private INVTakingInventoryLine _iNVTakingInventoryLineWCF;
		private POS.DataLayer.INVTakingInventoryLine _iNVTakingInventoryLine;
		
        public bool OpenTakingInventory(string TakingName, DateTime TakingDate, int InventoryID, int TakingType,
                                        int? ProductID, int? ProductGroupID, string Notes)
        {
            int userID = GlobalVariables.CurrentUser.UserID;
           bool a= POS.DataLayer. INVTakingInventoryLine.OpenTakingInventory(TakingName, TakingDate, InventoryID, TakingType, ProductID,
                                                                 ProductGroupID, Notes,userID);
            return true;
        }

        public INVTakingInventoryLineCollection GetLines(int HeaderID)
        {
            INVTakingInventoryLineCollection iNVTakingInventoryLineCollection = new INVTakingInventoryLineCollection();
            foreach (POS.DataLayer.INVTakingInventoryLine _iNVTakingInventoryLine in new POS.DataLayer.INVTakingInventoryLine().GetLines(HeaderID))
            {
                _iNVTakingInventoryLineWCF = new INVTakingInventoryLine();

                _iNVTakingInventoryLineWCF.TakingLineID = _iNVTakingInventoryLine.TakingLineID;
                _iNVTakingInventoryLineWCF.TakingHeaderID = _iNVTakingInventoryLine.TakingHeaderID;
                _iNVTakingInventoryLineWCF.ProductID = _iNVTakingInventoryLine.ProductID;
                _iNVTakingInventoryLineWCF.ActualQty = _iNVTakingInventoryLine.ActualQty;
                _iNVTakingInventoryLineWCF.ExpectedQty = _iNVTakingInventoryLine.ExpectedQty;
                _iNVTakingInventoryLineWCF.ProductName = _iNVTakingInventoryLine.ProductName;
                _iNVTakingInventoryLineWCF.IsAcceptBatch = _iNVTakingInventoryLine.IsAcceptBatch;
                _iNVTakingInventoryLineWCF.TakingLineBatchID = _iNVTakingInventoryLine.TakingLineBatchID;
                _iNVTakingInventoryLineWCF.BatchNumber = _iNVTakingInventoryLine.BatchNumber;
                _iNVTakingInventoryLineWCF.ExpiryDate = _iNVTakingInventoryLine.ExpiryDate;
                _iNVTakingInventoryLineWCF.StockTypeID = _iNVTakingInventoryLine.StockTypeID;
                _iNVTakingInventoryLineWCF.StockTypeName = _iNVTakingInventoryLine.StockTypeName;
                iNVTakingInventoryLineCollection.Add(_iNVTakingInventoryLineWCF);
            }

            return iNVTakingInventoryLineCollection;
        }


        public static bool saveLines(int takingLineID,int TakingLineBatchID ,decimal ActualQty)
        {
            int userID = GlobalVariables.CurrentUser.UserID;
            bool a = POS.DataLayer.INVTakingInventoryLine.SaveLine(takingLineID,TakingLineBatchID,ActualQty);
            return true;
        }
    }
}
