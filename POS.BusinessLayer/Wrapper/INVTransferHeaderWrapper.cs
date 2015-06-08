using POS.BusinessLayer.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BusinessLayer.Wrapper
{
    public class INVTransferHeaderWrapper : INVTransferHeaderService
    {
        private POS.DataLayer.INVTransferHeader _invTransferHeader = new DataLayer.INVTransferHeader();

        private INVInventoryService invinventoryService = new INVInventoryService();

        private BDProductService productService = new BDProductService();

        private INVTransferLineService transferLineService = new INVTransferLineService();

        private ADUserService aduserService = new ADUserService();

        public List<INVTransferHeaderModel> getAllTransferTransaction()
        {
            List<INVTransferHeaderModel> resultList = new List<INVTransferHeaderModel>();
            try
            {
                resultList = (from item in SelectAll()
                              join fromInv in invinventoryService.SelectAll() on item.FromInventoryID equals fromInv.InventoryID
                              join toInv in invinventoryService.SelectAll() on item.ToInventoryID equals toInv.InventoryID
                              join usr in aduserService.SelectAll() on item.CreatedBy equals usr.UserID
                              where item.IsDeleted == false
                              select new INVTransferHeaderModel()
                              {
                                  INVTransferHeaderID = item.INVTransferHeaderID.Value,
                                  CreatedBy = usr.UserName,
                                  FromInventory = fromInv.InventoryName,
                                  ToInventory = toInv.InventoryName,
                                  TransferDate = item.CreateDate.Value.Date.ToShortDateString(),
                                  IsClosed = item.IsClosed.Value,
                                  InvoiceNumber = item.InvoiceNumber
                              }
                                  ).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return resultList;
        }

        public List<INVTransferHeaderModel> getAllTransferTransaction(INVTransferHeader invtransferHeader, DateTime? dateFrom = null, DateTime? toFrom = null)
        {
            List<INVTransferHeaderModel> resultList = new List<INVTransferHeaderModel>();
            try
            {
                DateTime? fromCreationDate = dateFrom!=null?dateFrom:null;
                DateTime? toCreationDate = toFrom!=null?toFrom:null;

                resultList = (from item in SelectAll()
                              join fromInv in invinventoryService.SelectAll() on item.FromInventoryID equals fromInv.InventoryID
                              join toInv in invinventoryService.SelectAll() on item.ToInventoryID equals toInv.InventoryID
                              join usr in aduserService.SelectAll() on item.CreatedBy equals usr.UserID
                              where (
                              item.IsDeleted == false
                              &&
                              (!invtransferHeader.FromInventoryID.HasValue || item.FromInventoryID == invtransferHeader.FromInventoryID)
                              && (!invtransferHeader.ToInventoryID.HasValue || item.ToInventoryID == invtransferHeader.ToInventoryID)
                              && (string.IsNullOrEmpty(invtransferHeader.InvoiceNumber) || item.InvoiceNumber.Contains(invtransferHeader.InvoiceNumber))
                              && (invtransferHeader==null || (item.CreateDate > fromCreationDate && item.CreateDate > toCreationDate))
                              )
                              select new INVTransferHeaderModel()
                              {
                                  INVTransferHeaderID = item.INVTransferHeaderID.Value,
                                  CreatedBy = usr.UserName,
                                  FromInventory = fromInv.InventoryName,
                                  ToInventory = toInv.InventoryName,
                                  TransferDate = item.CreateDate.Value.Date.ToShortDateString(),
                                  IsClosed = item.IsClosed.Value,
                                  InvoiceNumber = item.InvoiceNumber
                              }
                                  ).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return resultList;
        }

        /////

        public bool SaveTransferOrder(INVTransferHeader transferHeader, INVTransferLineCollection sALSalesLineCollection)
        {
            POS.DataLayer.INVTransferHeader _transferHeader = new POS.DataLayer.INVTransferHeader();
            _transferHeader.TransferDate = DateTime.Now;
            _transferHeader.InvoiceDate = DateTime.Now;
            _transferHeader.FromInventoryID = transferHeader.FromInventoryID;
            _transferHeader.ToInventoryID = transferHeader.ToInventoryID;
            _transferHeader.IsClosed = false;
            _transferHeader.CreatedBy = GlobalVariables.CurrentUser.UserID;
            _transferHeader.CreateDate = DateTime.Now;
            _transferHeader.UpdatedBy = null;
            _transferHeader.UpdateDate = null;
            _transferHeader.IsDeleted = false;
            _transferHeader.DeletedBy = null;
            _transferHeader.DeletedDate = null;

            POS.DataLayer.INVTransferLineCollection _sALSalesLineCollection = new DataLayer.INVTransferLineCollection();
            foreach (INVTransferLine sALSalesLine in sALSalesLineCollection)
            {
                POS.DataLayer.INVTransferLine _sALSalesLine = new POS.DataLayer.INVTransferLine();
                _sALSalesLine.ProductID = sALSalesLine.ProductID;
                _sALSalesLine.Qty = sALSalesLine.Qty;
                _sALSalesLine.CreatedBy = GlobalVariables.CurrentUser.UserID;
                _sALSalesLine.CreateDate = DateTime.Now;
                _sALSalesLine.UpdatedBy = null;
                _sALSalesLine.UpdateDate = null;
                _sALSalesLine.IsDeleted = false;
                _sALSalesLine.DeletedBy = null;
                _sALSalesLine.DeletedDate = null;
                _sALSalesLineCollection.Add(_sALSalesLine);
            }
            POS.DataLayer.INVTransferLine transferLineObj = new DataLayer.INVTransferLine();
            return transferLineObj.SaveTransaction(_transferHeader, _sALSalesLineCollection);
        }
        public bool SaveCloseTransferOrder(INVTransferHeader transferHeader, INVTransferLineCollection sALSalesLineCollection)
        {
            POS.DataLayer.INVTransferHeader _transferHeader = new POS.DataLayer.INVTransferHeader();
            _transferHeader.TransferDate = DateTime.Now;
            _transferHeader.InvoiceDate = DateTime.Now;
            _transferHeader.FromInventoryID = transferHeader.FromInventoryID;
            _transferHeader.ToInventoryID = transferHeader.ToInventoryID;
            _transferHeader.IsClosed = true;
            _transferHeader.CreatedBy = GlobalVariables.CurrentUser.UserID;
            _transferHeader.CreateDate = DateTime.Now;
            _transferHeader.UpdatedBy = null;
            _transferHeader.UpdateDate = null;
            _transferHeader.IsDeleted = false;
            _transferHeader.DeletedBy = null;
            _transferHeader.DeletedDate = null;

            POS.DataLayer.INVTransferLineCollection _sALSalesLineCollection = new DataLayer.INVTransferLineCollection();
            foreach (INVTransferLine sALSalesLine in sALSalesLineCollection)
            {
                POS.DataLayer.INVTransferLine _sALSalesLine = new POS.DataLayer.INVTransferLine();
                _sALSalesLine.ProductID = sALSalesLine.ProductID;
                _sALSalesLine.Qty = sALSalesLine.Qty;
                _sALSalesLine.CreatedBy = GlobalVariables.CurrentUser.UserID;
                _sALSalesLine.CreateDate = DateTime.Now;
                _sALSalesLine.UpdatedBy = null;
                _sALSalesLine.UpdateDate = null;
                _sALSalesLine.IsDeleted = false;
                _sALSalesLine.DeletedBy = null;
                _sALSalesLine.DeletedDate = null;
                _sALSalesLineCollection.Add(_sALSalesLine);
            }
            POS.DataLayer.INVTransferLine transferLineObj = new DataLayer.INVTransferLine();
            return transferLineObj.SaveAndCommitTransaction(_transferHeader, _sALSalesLineCollection);
        }
        public bool UpdateTransferOrder(INVTransferHeader transferHeader, INVTransferLineCollection transferLineCollection)
        {
            POS.DataLayer.INVTransferHeader _transferHeader = new POS.DataLayer.INVTransferHeader();
            _transferHeader.INVTransferHeaderID = transferHeader.INVTransferHeaderID;
            _transferHeader.TransferDate = DateTime.Now;
            _transferHeader.FromInventoryID = transferHeader.FromInventoryID;
            _transferHeader.ToInventoryID = transferHeader.ToInventoryID;
            _transferHeader.InvoiceNumber = transferHeader.InvoiceNumber;
            _transferHeader.InvoiceDate = transferHeader.InvoiceDate;
            _transferHeader.IsClosed = false;
            _transferHeader.IsVoid = false;
            _transferHeader.IsPrinted = false;
            _transferHeader.CreatedBy = GlobalVariables.CurrentUser.UserID;
            _transferHeader.CreateDate = DateTime.Now;
            _transferHeader.UpdatedBy = GlobalVariables.CurrentUser.UserID;
            _transferHeader.UpdateDate = DateTime.Now;
            _transferHeader.IsDeleted = false;
            _transferHeader.DeletedBy = null;
            _transferHeader.DeletedDate = null;

            POS.DataLayer.INVTransferLineCollection _transferLineCollection = new DataLayer.INVTransferLineCollection();
            foreach (INVTransferLine transferLine in transferLineCollection)
            {
                POS.DataLayer.INVTransferLine _transferLine = new POS.DataLayer.INVTransferLine();
                _transferLine.TransferHeaderID = transferLine.TransferHeaderID;
                _transferLine.TransferLineID = transferLine.TransferLineID;
                _transferLine.ProductID = transferLine.ProductID;
                _transferLine.Qty = transferLine.Qty;
                _transferLine.CreatedBy = GlobalVariables.CurrentUser.UserID;
                _transferLine.CreateDate = DateTime.Now;
                _transferLine.UpdatedBy = GlobalVariables.CurrentUser.UserID; ;
                _transferLine.UpdateDate = DateTime.Now;
                _transferLine.IsDeleted = false;
                _transferLine.DeletedBy = null;
                _transferLine.DeletedDate = null;
                _transferLineCollection.Add(_transferLine);
            }
            POS.DataLayer.INVTransferLine transferLineObj = new DataLayer.INVTransferLine();
            return transferLineObj.UpdateTransaction(_transferHeader, _transferLineCollection);
        }
        public bool UpdateCloseTransferOrder(INVTransferHeader transferHeader, INVTransferLineCollection transferLineCollection)
        {
            POS.DataLayer.INVTransferHeader _transferHeader = new POS.DataLayer.INVTransferHeader();
            _transferHeader.INVTransferHeaderID = transferHeader.INVTransferHeaderID;
            _transferHeader.TransferDate = DateTime.Now;
            _transferHeader.FromInventoryID = transferHeader.FromInventoryID;
            _transferHeader.ToInventoryID = transferHeader.ToInventoryID;
            _transferHeader.InvoiceNumber = transferHeader.InvoiceNumber;
            _transferHeader.InvoiceDate = transferHeader.InvoiceDate;
            _transferHeader.IsClosed = true;
            _transferHeader.IsVoid = false;
            _transferHeader.IsPrinted = false;
            _transferHeader.CreatedBy = GlobalVariables.CurrentUser.UserID;
            _transferHeader.CreateDate = DateTime.Now;
            _transferHeader.UpdatedBy = GlobalVariables.CurrentUser.UserID;
            _transferHeader.UpdateDate = DateTime.Now;
            _transferHeader.IsDeleted = false;
            _transferHeader.DeletedBy = null;
            _transferHeader.DeletedDate = null;

            POS.DataLayer.INVTransferLineCollection _transferLineCollection = new DataLayer.INVTransferLineCollection();
            foreach (INVTransferLine transferLine in transferLineCollection)
            {
                POS.DataLayer.INVTransferLine _transferLine = new POS.DataLayer.INVTransferLine();
                _transferLine.TransferLineID = transferLine.TransferLineID;
                _transferLine.TransferHeaderID = transferLine.TransferHeaderID;
                _transferLine.ProductID = transferLine.ProductID;
                _transferLine.Qty = transferLine.Qty;
                _transferLine.CreatedBy = GlobalVariables.CurrentUser.UserID;
                _transferLine.CreateDate = DateTime.Now;
                _transferLine.UpdatedBy = GlobalVariables.CurrentUser.UserID; ;
                _transferLine.UpdateDate = DateTime.Now;
                _transferLine.IsDeleted = false;
                _transferLine.DeletedBy = null;
                _transferLine.DeletedDate = null;
                _transferLineCollection.Add(_transferLine);
            }
            POS.DataLayer.INVTransferLine transferLineObj = new DataLayer.INVTransferLine();
            return transferLineObj.UpdateTransaction(_transferHeader, _transferLineCollection);
        }

        public INVTransferLineCollection SelectByField(int transferHeaderID)
        {
            List<INVTransferLine> transferLineList = new List<INVTransferLine>();
            INVTransferLineCollection invtransferLineCollection = transferLineService.SelectByField("TransferHeaderID", transferHeaderID, null, DataLayer.TypeOperation.Equal);
            transferLineList = (
                from line in invtransferLineCollection
                join product in productService.SelectAll() on line.ProductID equals product.ProductID
                select new INVTransferLine
                {
                    TransferLineID = line.TransferLineID,
                    TransferHeaderID = line.TransferHeaderID,
                    ProductID = line.ProductID,
                    ProductName = product.ProductName,
                    Qty = line.Qty,
                    CreatedBy = line.CreatedBy,
                    CreateDate = line.CreateDate,
                    UpdatedBy = line.UpdatedBy,
                    UpdateDate = line.UpdateDate,
                    IsDeleted = line.IsDeleted,
                    DeletedBy = line.DeletedBy,
                    DeletedDate = line.DeletedDate
                }
                ).ToList();
            invtransferLineCollection = new INVTransferLineCollection();
            invtransferLineCollection.AddRange(transferLineList);
            return invtransferLineCollection;
        }

        public bool DeleteOrder(int INVTransferHeaderID)
        {
            return POS.DataLayer.INVTransferHeader.DeleteOrder(INVTransferHeaderID, Utility.GlobalVariables.CurrentUser.UserID);
        }

        public bool CloseOrder(int INVTransferHeaderID)
        {
            INVTransferHeaderPrimaryKey pk = new INVTransferHeaderPrimaryKey();
            pk.INVTransferHeaderID = INVTransferHeaderID;
            INVTransferLineCollection transferLineCollection = null;// transferLineService.SelectAllByForeignKeyTransferHeaderID(pk);

            POS.DataLayer.INVTransferLineCollection _transferLineCollection = new DataLayer.INVTransferLineCollection();
            foreach (INVTransferLine transferLine in transferLineCollection)
            {
                POS.DataLayer.INVTransferLine _transferLine = new POS.DataLayer.INVTransferLine();
                _transferLine.ProductID = transferLine.ProductID;
                _transferLine.Qty = transferLine.Qty;
                _transferLine.TransferHeaderID = transferLine.TransferHeaderID;
                _transferLine.TransferLineID = transferLine.TransferLineID;
                _transferLine.CreatedBy = transferLine.CreatedBy;
                _transferLine.CreateDate = transferLine.CreateDate;
                _transferLine.UpdatedBy = transferLine.UpdatedBy;
                _transferLine.UpdateDate = transferLine.UpdateDate;
                _transferLine.IsDeleted = transferLine.IsDeleted;
                _transferLine.DeletedBy = transferLine.DeletedBy;
                _transferLine.DeletedDate = transferLine.DeletedDate;
                _transferLineCollection.Add(_transferLine);
            }
            return _invTransferHeader.CloseOrder(INVTransferHeaderID, Utility.GlobalVariables.CurrentUser.UserID, _transferLineCollection);

        }

    }

    public class INVTransferHeaderModel
    {
        public int INVTransferHeaderID { get; set; }
        public string TransferDate { get; set; }
        public string FromInventory { get; set; }
        public string ToInventory { get; set; }
        public string CreatedBy { get; set; }
        public bool IsClosed { get; set; }
        public string InvoiceNumber { get; set; }
    }
}
