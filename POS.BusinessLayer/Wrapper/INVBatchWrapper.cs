using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.BusinessLayer.Utility;

namespace POS.BusinessLayer.Wrapper
{
    public class INVBatchWrapper : INVBatchService
    {
        public bool SaveProductStockWithBatches(INVBatchCollection iNVBatchCollection, int ProductStockID)
        {
            bool ExecutionState = false;
            foreach (INVBatch iNVBatch in iNVBatchCollection)
            {
                POS.DataLayer.INVBatch _iNVBatch = new DataLayer.INVBatch();
                _iNVBatch.BatchNumber = iNVBatch.BatchNumber;
                _iNVBatch.ExpiryDate = iNVBatch.ExpiryDate;
                _iNVBatch.ProductStockID = ProductStockID;
                _iNVBatch.Qty = iNVBatch.Qty;
                ExecutionState = _iNVBatch.InsertProductStockBatches(GlobalVariables.CurrentUser.UserID, _iNVBatch);
            }
            return ExecutionState;
        }
    }
}
