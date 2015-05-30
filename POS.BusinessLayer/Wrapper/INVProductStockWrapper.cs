using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.BusinessLayer.Utility;

namespace POS.BusinessLayer.Wrapper
{
    public class INVProductStockWrapper : INVProductStockService
    {

        // private POS.DataLayer.INVProductStock _iNVProductStock;
        public INVProductStockCollection GetInventoryStock(int? ProductStockID, string productCode, string productName, bool? IsAcceptBatch, bool getWithBatch,int? InventoryID)
        {
            INVProductStock _iNVProductStockWCF;

            INVProductStockCollection iNVProductStockCollection = new INVProductStockCollection();
            foreach (POS.DataLayer.INVProductStock _iNVProductStock in POS.DataLayer.INVProductStock.GetInventoryStock(ProductStockID, productCode, productName, IsAcceptBatch, getWithBatch, InventoryID))
            {
                _iNVProductStockWCF = new INVProductStock();

                _iNVProductStockWCF.ProductStockID = _iNVProductStock.ProductStockID;
                _iNVProductStockWCF.ProductID = _iNVProductStock.ProductID;
                _iNVProductStockWCF.TotalQty = _iNVProductStock.TotalQty;
                _iNVProductStockWCF.StockTypeID = _iNVProductStock.StockTypeID;
                _iNVProductStockWCF.OpeningQty = _iNVProductStock.OpeningQty;
                _iNVProductStockWCF.OpennigDate = _iNVProductStock.OpennigDate;
                _iNVProductStockWCF.CreateDate = _iNVProductStock.CreateDate;
                _iNVProductStockWCF.CreatedBy = _iNVProductStock.CreatedBy;
                _iNVProductStockWCF.UpdateDate = _iNVProductStock.UpdateDate;
                _iNVProductStockWCF.UpdatedBy = _iNVProductStock.UpdatedBy;
                _iNVProductStockWCF.ProductCode = _iNVProductStock.ProductCode;
                _iNVProductStockWCF.ProductName = _iNVProductStock.ProductName;
                _iNVProductStockWCF.StockType = _iNVProductStock.StockType;
                _iNVProductStockWCF.BatchNo = _iNVProductStock.BatchNo;
                _iNVProductStockWCF.ExpiryDate = _iNVProductStock.ExpiryDate;
                _iNVProductStockWCF.BatchQty = _iNVProductStock.BatchQty;
                _iNVProductStockWCF.IsAcceptBatch = _iNVProductStock.IsAcceptBatch;
                iNVProductStockCollection.Add(_iNVProductStockWCF);
            }
            return iNVProductStockCollection;
        }
        public bool SaveProductStockLine(INVProductStockCollection iNVProductStockCollection)
        {
            foreach (INVProductStock _iNVProductStockWCF in iNVProductStockCollection)
            {
                POS.DataLayer.INVProductStock iNVProductStock = new DataLayer.INVProductStock();
                iNVProductStock.BatchNo = _iNVProductStockWCF.BatchNo;
                iNVProductStock.BatchQty = _iNVProductStockWCF.BatchQty;
                iNVProductStock.CreatedBy = GlobalVariables.CurrentUser.UserID;
                iNVProductStock.CreateDate = _iNVProductStockWCF.CreateDate;
                iNVProductStock.ExpiryDate = _iNVProductStockWCF.ExpiryDate;
                iNVProductStock.InventoryID = _iNVProductStockWCF.InventoryID;
                iNVProductStock.OpeningQty = _iNVProductStockWCF.OpeningQty;
                iNVProductStock.OpennigDate = _iNVProductStockWCF.OpennigDate;
                iNVProductStock.ProductID = _iNVProductStockWCF.ProductID;
                iNVProductStock.StockTypeID = 1;
                iNVProductStock.TotalQty = _iNVProductStockWCF.TotalQty;
                iNVProductStock.UpdateDate = _iNVProductStockWCF.UpdateDate;
                iNVProductStock.UpdatedBy = _iNVProductStockWCF.UpdatedBy;
                if (!iNVProductStock.InsertINVProductStockWithBatch(iNVProductStock))
                {
                    return false;
                }
            }
            return true;
        }

        public INVProductStockCollection SelectByField(int inventoryID)
        {
            return base.SelectByField("InventoryID", inventoryID, null, DataLayer.TypeOperation.Equal);
        }
    }
}
