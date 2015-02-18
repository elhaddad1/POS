using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BusinessLayer.Wrapper
{
    public class INVTransferHeaderWrapper : INVTransferHeaderService
    {
        private INVInventoryService invinventoryService = new INVInventoryService();

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
                              select new INVTransferHeaderModel()
                              {
                                  INVTransferHeaderID = item.INVTransferHeaderID.Value,
                                  CreatedBy = usr.UserName,
                                  FromInventory = fromInv.InventoryName,
                                  ToInventory = toInv.InventoryName,
                                  TransferDate = item.CreateDate.Value.Date.ToShortDateString()
                              }
                                  ).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return resultList;
        }

        public List<INVTransferHeaderModel> getAllTransferTransaction(INVTransferHeader invtransferHeader)
        {
            List<INVTransferHeaderModel> resultList = new List<INVTransferHeaderModel>();
            try
            {
                DateTime fromCreationDate = invtransferHeader.CreateDate.Value.Date.AddDays(-1);
                DateTime toCreationDate = invtransferHeader.CreateDate.Value.Date.AddDays(1);

                resultList = (from item in SelectAll()
                              join fromInv in invinventoryService.SelectAll() on item.FromInventoryID equals fromInv.InventoryID
                              join toInv in invinventoryService.SelectAll() on item.ToInventoryID equals toInv.InventoryID
                              join usr in aduserService.SelectAll() on item.CreatedBy equals usr.UserID
                              where (
                              (!invtransferHeader.FromInventoryID.HasValue || item.FromInventoryID == invtransferHeader.FromInventoryID)
                              && (!invtransferHeader.ToInventoryID.HasValue || item.ToInventoryID == invtransferHeader.ToInventoryID)
                              && (!invtransferHeader.CreateDate.HasValue || (item.CreateDate > fromCreationDate && item.CreateDate > toCreationDate))
                              )
                              select new INVTransferHeaderModel()
                              {
                                  INVTransferHeaderID = item.INVTransferHeaderID.Value,
                                  CreatedBy = usr.UserName,
                                  FromInventory = fromInv.InventoryName,
                                  ToInventory = toInv.InventoryName,
                                  TransferDate = item.CreateDate.Value.Date.ToShortDateString()
                              }
                                  ).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return resultList;
        }

    }

    public class INVTransferHeaderModel
    {
        public int INVTransferHeaderID { get; set; }
        public string TransferDate { get; set; }
        public string FromInventory { get; set; }
        public string ToInventory { get; set; }
        public string CreatedBy { get; set; }
    }
}
