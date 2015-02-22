//
// Class	:	INVTransferLine.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	2/22/2015 7:27:20 PM
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
	/// Data access class for the "INVTransferLine" table.
	/// </summary>
	[Serializable]
	public class INVTransferLine : INVTransferLineBase
	{
	
		#region Class Level Variables

        private DatabaseHelper oDatabaseHelper;

        private string _productNameNonDefault = null;

		#endregion
		
		#region Constants
		
		#endregion

		#region Constructors / Destructors 
		
		public INVTransferLine() : base()
		{
		}

		#endregion

		#region Properties

		#endregion

        #region Methods (Public)
        public bool SaveTransaction(INVTransferHeader transferHeader, INVTransferLineCollection transferLineCollection)
        {
            oDatabaseHelper = new DatabaseHelper();
            bool ExecutionState = false;
            int salesHeaderID;
            oDatabaseHelper.BeginTransaction();
            if (InsertHeader(oDatabaseHelper, transferHeader, out salesHeaderID))
            {
                foreach (INVTransferLine transferLine in transferLineCollection)
                {
                    if (!InsertDetails(oDatabaseHelper, transferLine, salesHeaderID))
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
            }
            return ExecutionState;
        }

        #endregion

        #region Methods (Private)
        private bool InsertHeader(DatabaseHelper oDatabaseHelper, INVTransferHeader transferHeader, out int pK)
        {
            bool ExecutionState = false;
            // Pass the value of 'TransferDate' as parameter 'TransferDate' of the stored procedure.

            oDatabaseHelper.AddParameter("@TransferDate", transferHeader.TransferDate);
            // Pass the value of 'FromInventoryID' as parameter 'FromInventoryID' of the stored procedure.
            if (transferHeader.FromInventoryID != null)
                oDatabaseHelper.AddParameter("@FromInventoryID", transferHeader.FromInventoryID);
            else
                oDatabaseHelper.AddParameter("@FromInventoryID", DBNull.Value);
            // Pass the value of 'ToInventoryID' as parameter 'ToInventoryID' of the stored procedure.
            if (transferHeader.ToInventoryID != null)
                oDatabaseHelper.AddParameter("@ToInventoryID", transferHeader.ToInventoryID);
            else
                oDatabaseHelper.AddParameter("@ToInventoryID", DBNull.Value);
            // Pass the value of '_invoiceNumber' as parameter 'InvoiceNumber' of the stored procedure.

            oDatabaseHelper.AddParameter("@InvoiceNumber", DBNull.Value);
            // Pass the value of '_invoiceDate' as parameter 'InvoiceDate' of the stored procedure.
            if (transferHeader.InvoiceDate != null)
                oDatabaseHelper.AddParameter("@InvoiceDate", transferHeader.InvoiceDate);
            else
                oDatabaseHelper.AddParameter("@InvoiceDate", DBNull.Value);
           
            // Pass the value of '_isClosed' as parameter 'IsClosed' of the stored procedure.
            if (transferHeader.IsClosed != null)
                oDatabaseHelper.AddParameter("@IsClosed", transferHeader.IsClosed);
            else
                oDatabaseHelper.AddParameter("@IsClosed", DBNull.Value);
            // Pass the value of '_isVoid' as parameter 'IsVoid' of the stored procedure.
            if (transferHeader.IsVoid != null)
                oDatabaseHelper.AddParameter("@IsVoid", transferHeader.IsVoid);
            else
                oDatabaseHelper.AddParameter("@IsVoid", DBNull.Value);
            // Pass the value of '_isPrinted' as parameter 'IsPrinted' of the stored procedure.
            if (transferHeader.IsPrinted != null)
                oDatabaseHelper.AddParameter("@IsPrinted", transferHeader.IsPrinted);
            else
                oDatabaseHelper.AddParameter("@IsPrinted", DBNull.Value);
            
            // Pass the value of '_createdBy' as parameter 'CreatedBy' of the stored procedure.
            if (transferHeader.CreatedBy != null)
                oDatabaseHelper.AddParameter("@CreatedBy", transferHeader.CreatedBy);
            else
                oDatabaseHelper.AddParameter("@CreatedBy", DBNull.Value);
            // Pass the value of '_createDate' as parameter 'CreateDate' of the stored procedure.
            if (transferHeader.CreateDate != null)
                oDatabaseHelper.AddParameter("@CreateDate", transferHeader.CreateDate);
            else
                oDatabaseHelper.AddParameter("@CreateDate", DBNull.Value);
            // Pass the value of '_updatedBy' as parameter 'UpdatedBy' of the stored procedure.
            if (transferHeader.UpdatedBy != null)
                oDatabaseHelper.AddParameter("@UpdatedBy", transferHeader.UpdatedBy);
            else
                oDatabaseHelper.AddParameter("@UpdatedBy", DBNull.Value);
            // Pass the value of '_updateDate' as parameter 'UpdateDate' of the stored procedure.
            if (transferHeader.UpdateDate != null)
                oDatabaseHelper.AddParameter("@UpdateDate", transferHeader.UpdateDate);
            else
                oDatabaseHelper.AddParameter("@UpdateDate", DBNull.Value);
            // Pass the value of '_isDeleted' as parameter 'IsDeleted' of the stored procedure.
            if (transferHeader.IsDeleted != null)
                oDatabaseHelper.AddParameter("@IsDeleted", transferHeader.IsDeleted);
            else
                oDatabaseHelper.AddParameter("@IsDeleted", DBNull.Value);
            // Pass the value of '_deletedBy' as parameter 'DeletedBy' of the stored procedure.
            if (transferHeader.DeletedBy != null)
                oDatabaseHelper.AddParameter("@DeletedBy", transferHeader.DeletedBy);
            else
                oDatabaseHelper.AddParameter("@DeletedBy", DBNull.Value);
            // Pass the value of '_deletDate' as parameter 'DeletDate' of the stored procedure.
            if (transferHeader.DeletedDate != null)
                oDatabaseHelper.AddParameter("@DeletedDate", transferHeader.DeletedDate);
            else
                oDatabaseHelper.AddParameter("@DeletedDate", DBNull.Value);
            // The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
            oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);

            try
            {
                pK = Convert.ToInt32(oDatabaseHelper.ExecuteScalar("usp_INVTransferHeader_Insert", CommandType.StoredProcedure, ConnectionState.KeepOpen, ref ExecutionState));
                //    oDatabaseHelper.Dispose();
            }
            catch (Exception ex)
            {

                throw;
            }
            return ExecutionState;
        }
        private bool InsertDetails(DatabaseHelper oDatabaseHelper, INVTransferLine transferLine, int salesHeaderID)
        {
            bool ExecutionState = false;
            // Pass the value of '_TransferHeaderID' as parameter 'TransferHeaderID' of the stored procedure.
            if (TransferHeaderID != null)
                oDatabaseHelper.AddParameter("@TransferHeaderID", TransferHeaderID);
            else
                oDatabaseHelper.AddParameter("@TransferHeaderID", DBNull.Value);
            // Pass the value of '_productID' as parameter 'ProductID' of the stored procedure.
            if (transferLine.ProductID != null)
                oDatabaseHelper.AddParameter("@ProductID", transferLine.ProductID);
            else
                oDatabaseHelper.AddParameter("@ProductID", DBNull.Value);
            // Pass the value of '_Qty' as parameter 'Qty' of the stored procedure.
            if (transferLine.Qty != null)
                oDatabaseHelper.AddParameter("@Qty", transferLine.Qty);
            else
                oDatabaseHelper.AddParameter("@Qty", DBNull.Value);
            // Pass the value of '_createdBy' as parameter 'CreatedBy' of the stored procedure.
            if (transferLine.CreatedBy != null)
                oDatabaseHelper.AddParameter("@CreatedBy", transferLine.CreatedBy);
            else
                oDatabaseHelper.AddParameter("@CreatedBy", DBNull.Value);
            // Pass the value of '_createDate' as parameter 'CreateDate' of the stored procedure.
            if (transferLine.CreateDate != null)
                oDatabaseHelper.AddParameter("@CreateDate", transferLine.CreateDate);
            else
                oDatabaseHelper.AddParameter("@CreateDate", DBNull.Value);
            // Pass the value of '_updatedBy' as parameter 'UpdatedBy' of the stored procedure.
            if (transferLine.UpdatedBy != null)
                oDatabaseHelper.AddParameter("@UpdatedBy", transferLine.UpdatedBy);
            else
                oDatabaseHelper.AddParameter("@UpdatedBy", DBNull.Value);
            // Pass the value of '_updateDate' as parameter 'UpdateDate' of the stored procedure.
            if (transferLine.UpdateDate != null)
                oDatabaseHelper.AddParameter("@UpdateDate", transferLine.UpdateDate);
            else
                oDatabaseHelper.AddParameter("@UpdateDate", DBNull.Value);
            // Pass the value of '_isDeleted' as parameter 'IsDeleted' of the stored procedure.
            if (transferLine.IsDeleted != null)
                oDatabaseHelper.AddParameter("@IsDeleted", transferLine.IsDeleted);
            else
                oDatabaseHelper.AddParameter("@IsDeleted", DBNull.Value);
            // Pass the value of '_deletedBy' as parameter 'DeletedBy' of the stored procedure.
            if (transferLine.DeletedBy != null)
                oDatabaseHelper.AddParameter("@DeletedBy", transferLine.DeletedBy);
            else
                oDatabaseHelper.AddParameter("@DeletedBy", DBNull.Value);
            // Pass the value of '_deleteDate' as parameter 'DeleteDate' of the stored procedure.
            if (transferLine.DeletedDate != null)
                oDatabaseHelper.AddParameter("@DeletedDate", transferLine.DeletedDate);
            else
                oDatabaseHelper.AddParameter("@DeletedDate", DBNull.Value);
            // The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
            oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);

            oDatabaseHelper.ExecuteScalar("gsp_INVTransferLine_Insert", CommandType.StoredProcedure, ConnectionState.KeepOpen, ref ExecutionState);

            return ExecutionState;
        }
        #endregion

	}
	
}
