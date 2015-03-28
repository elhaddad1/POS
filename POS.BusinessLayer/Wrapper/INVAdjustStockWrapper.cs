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

        public List<INVAdjustStock> SearchByCriteria(INVAdjustStock SearchModel)
        {
            List<INVAdjustStock> resultList = new List<INVAdjustStock>();
            try
            {
                resultList = (from item in SelectAll()
                              join product in productService.SelectAll() on item.ProductID equals product.ProductID
                              join invt in invinventoryService.SelectAll() on item.InventoryID equals invt.InventoryID
                              join aRes in invAdjustStockReasonService.SelectAll() on item.AdjustReasonID equals aRes.AdjustStockReasonID
                              join sType in invStockTypeService.SelectAll() on item.StockTypeID equals sType.StockTypeID
                              join usr in aduserService.SelectAll() on item.CreatedBy equals usr.UserID
                              where 
                              (
                              string.IsNullOrEmpty(SearchModel.AdjustReasonName) || aRes.AdjustStockreasonName.Contains(SearchModel.AdjustReasonName)
                              &&
                              string.IsNullOrEmpty(SearchModel.ProductName) || product.ProductName.Contains(SearchModel.ProductName)
                              &&
                              string.IsNullOrEmpty(SearchModel.InventoryName) || invt.InventoryName.Contains(SearchModel.InventoryName)
                              &&
                              string.IsNullOrEmpty(SearchModel.StockTypeName) || sType.StockTypeName.Contains(SearchModel.StockTypeName)
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
    }
}
