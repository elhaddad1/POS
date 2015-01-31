using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BusinessLayer.Wrapper
{
    public class INVProductStockWrapper:INVProductStockService
    {
        private INVProductStock _iNVProductStockWCF;
       // private POS.DataLayer.INVProductStock _iNVProductStock;
        public INVProductStockCollection GetInventoryStock(int? ProductStockID, string productCode, string productName, bool? IsAcceptBatch, bool getWithBatch)
        {

            INVProductStockCollection iNVProductStockCollection = new INVProductStockCollection();
            foreach (POS.DataLayer.INVProductStock _iNVProductStock in POS.DataLayer.INVProductStock.GetInventoryStock(ProductStockID, productCode, productName, IsAcceptBatch, getWithBatch))
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
                iNVProductStockCollection.Add(_iNVProductStockWCF);
            }
            return iNVProductStockCollection;
        }
    }
}
