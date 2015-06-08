using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BusinessLayer.Wrapper
{
    public class INVAdjustStockWrapper : INVAdjustStockService
    {

        private POS.DataLayer.INVTransferHeader _invTransferHeader = new DataLayer.INVTransferHeader();

        private INVAdjustStockReasonService invAdjustStockReasonService = new INVAdjustStockReasonService();

        private INVStockTypeService invStockTypeService = new INVStockTypeService();

        private INVInventoryService invinventoryService = new INVInventoryService();

        private BDProductService productService = new BDProductService();

        private ADUserService aduserService = new ADUserService();

        private INVProductStockWrapper _invProductStockWrapper = new INVProductStockWrapper();

        public List<INVAdjustStock> getAllINVAdjustStock()
        {
            List<INVAdjustStock> resultList = new List<INVAdjustStock>();
            try
            {
                resultList = (from item in SelectAll()
                              join product in productService.SelectAll() on item.ProductID equals product.ProductID
                              join invt in invinventoryService.SelectAll() on item.InventoryID equals invt.InventoryID
                              join aRes in invAdjustStockReasonService.SelectAll() on item.AdjustReasonID equals aRes.AdjustStockReasonID
                              join sType in invStockTypeService.SelectAll() on item.StockTypeID equals sType.StockTypeID
                              join oldSType in invStockTypeService.SelectAll() on item.OldStockTypeID equals oldSType.StockTypeID
                              join usr in aduserService.SelectAll() on item.CreatedBy equals usr.UserID
                              select new INVAdjustStock()
                              {
                                  AdjustReasonID = item.AdjustReasonID,
                                  AdjustStockID = item.AdjustStockID,
                                  BatchID = item.BatchID,
                                  CreatedBy = item.CreatedBy,
                                  CreatedByName = usr.UserName,
                                  CredateDate = item.CredateDate,
                                  InventoryID = item.InventoryID,
                                  ProductID = item.ProductID,
                                  ProductName = product.ProductName,
                                  Qty = item.Qty,
                                  StockTypeID = item.StockTypeID,
                                  UpdateDate = item.UpdateDate,
                                  UpdatedBy = item.UpdatedBy,
                                  StockTypeName = sType.StockTypeName,
                                  OldStockTypeName = oldSType.StockTypeName,
                                  InventoryName = invt.InventoryName,
                                  AdjustReasonName = aRes.AdjustStockreasonName
                              }
                                  ).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return resultList;
        }

        public List<INVAdjustStock> SearchByCriteria(INVAdjustStock SearchModel,DateTime? dateFrom = null,DateTime? toFrom = null)
        {
            List<INVAdjustStock> resultList = new List<INVAdjustStock>();
            try
            {
                
                resultList = (from item in SelectAll()
                              join product in productService.SelectAll() on item.ProductID equals product.ProductID
                              join invt in invinventoryService.SelectAll() on item.InventoryID equals invt.InventoryID
                              join aRes in invAdjustStockReasonService.SelectAll() on item.AdjustReasonID equals aRes.AdjustStockReasonID
                              join sType in invStockTypeService.SelectAll() on item.StockTypeID equals sType.StockTypeID
                              join oldSType in invStockTypeService.SelectAll() on item.OldStockTypeID equals oldSType.StockTypeID
                              join usr in aduserService.SelectAll() on item.CreatedBy equals usr.UserID
                              where 
                              (
                              SearchModel.InventoryID == null || item.InventoryID == SearchModel.InventoryID
                              &&
                              SearchModel.AdjustReasonID == null || item.AdjustReasonID == SearchModel.AdjustReasonID
                              &&
                              item.CredateDate >= dateFrom.Value
                              &&
                              item.CredateDate <= toFrom.Value
                              )
                              select new INVAdjustStock()
                              {
                                  AdjustReasonID = item.AdjustReasonID,
                                  AdjustStockID = item.AdjustStockID,
                                  BatchID = item.BatchID,
                                  CreatedBy = item.CreatedBy,
                                  CreatedByName = usr.UserName,
                                  CredateDate = item.CredateDate,
                                  InventoryID = item.InventoryID,
                                  ProductID = item.ProductID,
                                  ProductName = product.ProductName,
                                  Qty = item.Qty,
                                  StockTypeID = item.StockTypeID,
                                  UpdateDate = item.UpdateDate,
                                  UpdatedBy = item.UpdatedBy,
                                  OldStockTypeName = oldSType.StockTypeName,
                                  StockTypeName = sType.StockTypeName,
                                  InventoryName = invt.InventoryName,
                                  AdjustReasonName = aRes.AdjustStockreasonName
                              }).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return resultList;
        }

        public bool DeleteAdjustStock(int id)
        {
            bool deleted = false;
            try
            {
                INVAdjustStockCollection ajustStockCollection = new INVAdjustStockCollection();
                INVAdjustStock _adjustNewStock = new INVAdjustStock();
                INVAdjustStock _adjustOldStock = new INVAdjustStock();
                INVAdjustStockPrimaryKey pk = new INVAdjustStockPrimaryKey();
                pk.AdjustStockID = id;
                _adjustNewStock = SelectOne(pk);
                _adjustOldStock = SelectOne(pk);
                INVAdjustStock _EditNewAdjustStock = _adjustNewStock;
                _EditNewAdjustStock.Qty *= -1;
                ajustStockCollection.Add(_EditNewAdjustStock);
                INVAdjustStock _EditOldAdjustStock = _adjustOldStock;
                _EditOldAdjustStock.StockTypeID = _adjustOldStock.OldStockTypeID;
                ajustStockCollection.Add(_EditOldAdjustStock);
                POS.DataLayer.INVAdjustStock adjustStockEntity = new DataLayer.INVAdjustStock();
                deleted = adjustStockEntity.DeleteTransaction(id, GetAdjustStockFromBLLayer(ajustStockCollection));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return deleted;
        }

        public List<INVProductStock> GetProductStockList(int invId)
        {
            List<INVProductStock> productStockList = new List<INVProductStock>();

            try
            {
                productStockList = (from item in _invProductStockWrapper.SelectByField(invId)
                                    join product in productService.SelectAll() on item.ProductID equals product.ProductID
                                    join invt in invinventoryService.SelectAll() on item.InventoryID equals invt.InventoryID
                                    join sType in invStockTypeService.SelectAll() on item.StockTypeID equals sType.StockTypeID
                                    join usr in aduserService.SelectAll() on item.CreatedBy equals usr.UserID
                                    select new INVProductStock()
                                    {
                                        BatchNo = item.BatchNo,
                                        BatchQty = item.BatchQty,
                                        CreateDate = item.CreateDate,
                                        CreatedBy = item.CreatedBy,
                                        ExpiryDate = item.ExpiryDate,
                                        InventoryID = item.InventoryID,
                                        ProductID = item.ProductID,
                                        ProductName = product.ProductName,
                                        IsBlocked = item.IsBlocked,
                                        StockTypeID = item.StockTypeID,
                                        UpdateDate = item.UpdateDate,
                                        UpdatedBy = item.UpdatedBy,
                                        StockType = sType.StockTypeName,
                                        OpeningQty = item.ProductID,
                                        OpennigDate = item.OpennigDate,
                                        ProductCode = product.ProductCode,
                                        ProductStockID = item.ProductStockID,
                                        TotalQty = item.TotalQty
                                    }
                                  ).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return productStockList;
        }

        public bool SaveAdjustStock(INVAdjustStockCollection adjustStockCollection)
        {
            POS.DataLayer.INVAdjustStockCollection _adjustStockCollection = GetAdjustStockFromBLLayer(adjustStockCollection);
            POS.DataLayer.INVAdjustStock adjustStockEntity = new DataLayer.INVAdjustStock();
            return adjustStockEntity.SaveTransaction(_adjustStockCollection);
        }

        private static DataLayer.INVAdjustStockCollection GetAdjustStockFromBLLayer(INVAdjustStockCollection adjustStockCollection)
        {

            POS.DataLayer.INVAdjustStockCollection _adjustStockCollection = new DataLayer.INVAdjustStockCollection();
            foreach (INVAdjustStock adjustStock in adjustStockCollection)
            {
                POS.DataLayer.INVAdjustStock _adjustStock = new POS.DataLayer.INVAdjustStock();
                _adjustStock.ProductID = adjustStock.ProductID;
                _adjustStock.AdjustReasonID = adjustStock.AdjustReasonID;
                _adjustStock.AdjustStockID = adjustStock.AdjustStockID;
                _adjustStock.BatchID = adjustStock.BatchID;
                _adjustStock.InventoryID = adjustStock.InventoryID;
                _adjustStock.StockTypeID = adjustStock.StockTypeID;
                _adjustStock.Qty = adjustStock.Qty;
                _adjustStock.UpdateDate = adjustStock.UpdateDate;
                _adjustStock.UpdatedBy = adjustStock.UpdatedBy;
                _adjustStock.CredateDate = adjustStock.CredateDate;
                _adjustStock.CreatedBy = adjustStock.CreatedBy;
                _adjustStock.ExpiryDate = adjustStock.ExpiryDate;
                _adjustStock.BatchNumber = adjustStock.BatchNumber;
                _adjustStockCollection.Add(_adjustStock);
            }
            return _adjustStockCollection;
        }
    }
}
