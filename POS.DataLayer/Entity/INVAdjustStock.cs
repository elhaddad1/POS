//
// Class	:	INVAdjustStock.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	3/12/2015 1:28:41 AM
//

using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Collections;
using System.Data.Common;

namespace POS.DataLayer
{
	
	/// <summary>
	/// Data access class for the "INVAdjustStock" table.
	/// </summary>
	[Serializable]
	public class INVAdjustStock : INVAdjustStockBase
	{
	
		#region Class Level Variables

        private DatabaseHelper oDatabaseHelper;

        private string _productNameNonDefault = null;

		#endregion
		
		#region Constants
		
		#endregion

		#region Constructors / Destructors 
		
		public INVAdjustStock() : base()
		{
		}

		#endregion

		#region Properties

		#endregion

		#region Methods (Public)

        public bool SaveTransaction(INVAdjustStockCollection ajustStockCollection)
        {
            oDatabaseHelper = new DatabaseHelper();
            bool ExecutionState = false;

            oDatabaseHelper.BeginTransaction();
            foreach (INVAdjustStock adjustStock in ajustStockCollection)
            {
                if (!InsertDetailsAndCommit(oDatabaseHelper, adjustStock))
                {
                    ExecutionState = false;
                    break;
                }
                else
                    ExecutionState = true;
            }
            if (ExecutionState)
                oDatabaseHelper.CommitTransaction();
            else
                oDatabaseHelper.RollbackTransaction();
            return ExecutionState;
        }

		#endregion
		
		#region Methods (Private)
        private bool InsertDetailsAndCommit(DatabaseHelper oDatabaseHelper, INVAdjustStock adjustStock)
        {
            bool ExecutionState = false;
            // Pass the value of '_TransferHeaderID' as parameter 'TransferHeaderID' of the stored procedure.

            if (adjustStock.ProductID != null)
                oDatabaseHelper.AddParameter("@ProductID", adjustStock.ProductID);
            else
                oDatabaseHelper.AddParameter("@ProductID", DBNull.Value);

            // Pass the value of '_productID' as parameter 'ProductID' of the stored procedure.
            if (adjustStock.StockTypeID != null)
                oDatabaseHelper.AddParameter("@StockTypeID", adjustStock.StockTypeID);
            else
                oDatabaseHelper.AddParameter("@StockTypeID", DBNull.Value);
            // Pass the value of '_Qty' as parameter 'Qty' of the stored procedure.
            if (adjustStock.InventoryID != null)
                oDatabaseHelper.AddParameter("@InventoryID", adjustStock.InventoryID);
            else
                oDatabaseHelper.AddParameter("@InventoryID", DBNull.Value);
            // Pass the value of '_createdBy' as parameter 'CreatedBy' of the stored procedure.
            if (adjustStock.CreatedBy != null)
                oDatabaseHelper.AddParameter("@CreatedBy", adjustStock.CreatedBy);
            else
                oDatabaseHelper.AddParameter("@CreatedBy", DBNull.Value);
            // Pass the value of '_createDate' as parameter 'CreateDate' of the stored procedure.
            if (adjustStock.Qty != null)
                oDatabaseHelper.AddParameter("@BatchQty", adjustStock.Qty);
            else
                oDatabaseHelper.AddParameter("@BatchQty", DBNull.Value);
            // Pass the value of '_updatedBy' as parameter 'UpdatedBy' of the stored procedure.
            if (adjustStock.BatchNumber != null)
                oDatabaseHelper.AddParameter("@BatchNumber", adjustStock.BatchNumber);
            else
                oDatabaseHelper.AddParameter("@BatchNumber", DBNull.Value);
            // Pass the value of '_updateDate' as parameter 'UpdateDate' of the stored procedure.
            if (adjustStock.ExpiryDate != null)
                oDatabaseHelper.AddParameter("@ExpiryDate", adjustStock.ExpiryDate);
            else
                oDatabaseHelper.AddParameter("@ExpiryDate", DBNull.Value);
            // The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
            oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);

            oDatabaseHelper.ExecuteScalar("usp_INVInventory_AddQtyToInventory", CommandType.StoredProcedure, ConnectionState.KeepOpen, ref ExecutionState);

            return ExecutionState;
        }
		#endregion

	}
	
}
