//
// Class	:	PURPurchaseReturnLine.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:56:14 PM
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
	/// Data access class for the "PURPurchaseReturnLine" table.
	/// </summary>
	[Serializable]
	public class PURPurchaseReturnLine : PURPurchaseReturnLineBase
	{
	
		#region Class Level Variables
        private DatabaseHelper oDatabaseHelper;
		#endregion
		
		#region Constants
		
		#endregion

		#region Constructors / Destructors 
		
		public PURPurchaseReturnLine() : base()
		{
		}

		#endregion

		#region Properties

		#endregion

		#region Methods (Public)
        public int SaveTransaction(PURPurchaseReturnHeader pURPurchaseReturnHeader, PURPurchaseReturnLineCollection pURPurchaseReturnLineCollection)
        {
            oDatabaseHelper = new DatabaseHelper();
            bool ExecutionState = false;
            int salesReturnHeaderID = -1;
            oDatabaseHelper.BeginTransaction();
            if (InsertHeader(oDatabaseHelper, pURPurchaseReturnHeader, out salesReturnHeaderID))
            {
                foreach (PURPurchaseReturnLine pURPurchaseLine in pURPurchaseReturnLineCollection)
                {
                    if (!InsertDetails(oDatabaseHelper, pURPurchaseLine, salesReturnHeaderID))
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
            return salesReturnHeaderID;
        }

        public bool UpdateTransaction(PURPurchaseReturnHeader pURPurchaseReturnHeader, PURPurchaseReturnLineCollection pURPurchaseReturnLineCollection)
        {
            oDatabaseHelper = new DatabaseHelper();
            bool ExecutionState = false;
            oDatabaseHelper.BeginTransaction();
            if (UpdateHeader(oDatabaseHelper, pURPurchaseReturnHeader))
            {
                if (DeleteDetails(oDatabaseHelper, (int)pURPurchaseReturnHeader.PurchaseReturnID, (int)pURPurchaseReturnHeader.UpdatedBy))
                {
                    foreach (PURPurchaseReturnLine pURPurchaseReturnLine in pURPurchaseReturnLineCollection)
                    {
                        if (!InsertDetails(oDatabaseHelper, pURPurchaseReturnLine, (int)pURPurchaseReturnHeader.PurchaseReturnID))
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
                else
                    ExecutionState = false;
            }
            else
                ExecutionState = false;
            return ExecutionState;
        }
       
		#endregion
		
		#region Methods (Private)
        private bool InsertHeader(DatabaseHelper oDatabaseHelper, PURPurchaseReturnHeader pURPurchaseReturnHeader, out int pK)
        {
            bool ExecutionState = false;
            // Pass the value of '_returnDate' as parameter 'ReturnDate' of the stored procedure.
            if (pURPurchaseReturnHeader.ReturnDate != null)
                oDatabaseHelper.AddParameter("@ReturnDate", pURPurchaseReturnHeader.ReturnDate);
            else
                oDatabaseHelper.AddParameter("@ReturnDate", DBNull.Value);
            // Pass the value of '_originalPurchaseHeadeID' as parameter 'OriginalPurchaseHeadeID' of the stored procedure.
            if (pURPurchaseReturnHeader.OriginalHeaderID != null)
                oDatabaseHelper.AddParameter("@OriginalPurchaseHeadeID", pURPurchaseReturnHeader.OriginalHeaderID);
            else
                oDatabaseHelper.AddParameter("@OriginalPurchaseHeadeID", DBNull.Value);
            // Pass the value of '_createdBy' as parameter 'CreatedBy' of the stored procedure.
            if (pURPurchaseReturnHeader.CreatedBy != null)
                oDatabaseHelper.AddParameter("@CreatedBy", pURPurchaseReturnHeader.CreatedBy);
            else
                oDatabaseHelper.AddParameter("@CreatedBy", DBNull.Value);
            // Pass the value of '_createDate' as parameter 'CreateDate' of the stored procedure.
            if (pURPurchaseReturnHeader.CreateDate != null)
                oDatabaseHelper.AddParameter("@CreateDate", pURPurchaseReturnHeader.CreateDate);
            else
                oDatabaseHelper.AddParameter("@CreateDate", DBNull.Value);
            // Pass the value of '_updatedBy' as parameter 'UpdatedBy' of the stored procedure.
            if (pURPurchaseReturnHeader.UpdatedBy != null)
                oDatabaseHelper.AddParameter("@UpdatedBy", pURPurchaseReturnHeader.UpdatedBy);
            else
                oDatabaseHelper.AddParameter("@UpdatedBy", DBNull.Value);
            // Pass the value of '_updateDate' as parameter 'UpdateDate' of the stored procedure.
            if (pURPurchaseReturnHeader.UpdateDate != null)
                oDatabaseHelper.AddParameter("@UpdateDate", pURPurchaseReturnHeader.UpdateDate);
            else
                oDatabaseHelper.AddParameter("@UpdateDate", DBNull.Value);
            // Pass the value of '_isDeleted' as parameter 'IsDeleted' of the stored procedure.
            if (pURPurchaseReturnHeader.IsDeleted != null)
                oDatabaseHelper.AddParameter("@IsDeleted", pURPurchaseReturnHeader.IsDeleted);
            else
                oDatabaseHelper.AddParameter("@IsDeleted", DBNull.Value);
            // Pass the value of '_deletedBy' as parameter 'DeletedBy' of the stored procedure.
            if (pURPurchaseReturnHeader.DeletedBy != null)
                oDatabaseHelper.AddParameter("@DeletedBy", pURPurchaseReturnHeader.DeletedBy);
            else
                oDatabaseHelper.AddParameter("@DeletedBy", DBNull.Value);
            // Pass the value of '_deleteDate' as parameter 'DeleteDate' of the stored procedure.
            if (pURPurchaseReturnHeader.DeleteDate != null)
                oDatabaseHelper.AddParameter("@DeleteDate", pURPurchaseReturnHeader.DeleteDate);
            else
                oDatabaseHelper.AddParameter("@DeleteDate", DBNull.Value);
            // Pass the value of '_isClosed' as parameter 'IsClosed' of the stored procedure.
            if (pURPurchaseReturnHeader.IsClosed != null)
                oDatabaseHelper.AddParameter("@IsClosed", pURPurchaseReturnHeader.IsClosed);
            else
                oDatabaseHelper.AddParameter("@IsClosed", DBNull.Value);
            // Pass the value of '_isVoid' as parameter 'IsVoid' of the stored procedure.
            if (pURPurchaseReturnHeader.IsVoid != null)
                oDatabaseHelper.AddParameter("@IsVoid", pURPurchaseReturnHeader.IsVoid);
            else
                oDatabaseHelper.AddParameter("@IsVoid", DBNull.Value);
            // The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
            oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);

            try
            {
                pK = Convert.ToInt32(oDatabaseHelper.ExecuteScalar("usp_PURPurchaseReturnHeader_Insert", CommandType.StoredProcedure, ConnectionState.KeepOpen, ref ExecutionState));
                //    oDatabaseHelper.Dispose();
            }
            catch (Exception ex)
            {

                throw;
            }
            return ExecutionState;
        }
        private bool InsertDetails(DatabaseHelper oDatabaseHelper, PURPurchaseReturnLine pURPurchaseReturnLine, int salesReturnHeaderID)
        {
            bool ExecutionState = false;
            // Pass the value of '_qty' as parameter 'Qty' of the stored procedure.
            if (pURPurchaseReturnLine.Qty != null)
                oDatabaseHelper.AddParameter("@Qty", pURPurchaseReturnLine.Qty);
            else
                oDatabaseHelper.AddParameter("@Qty", DBNull.Value);
            // Pass the value of '_reason' as parameter 'Reason' of the stored procedure.
            if (pURPurchaseReturnLine.Reason != null)
                oDatabaseHelper.AddParameter("@Reason", pURPurchaseReturnLine.Reason);
            else
                oDatabaseHelper.AddParameter("@Reason", DBNull.Value);
            // Pass the value of '_originalPurchaseLineID' as parameter 'OriginalPurchaseLineID' of the stored procedure.
            if (pURPurchaseReturnLine.OriginalpurchaseLineID != null)
                oDatabaseHelper.AddParameter("@OriginalPurchaseLineID", pURPurchaseReturnLine.OriginalpurchaseLineID);
            else
                oDatabaseHelper.AddParameter("@OriginalPurchaseLineID", DBNull.Value);
            // Pass the value of '_batchID' as parameter 'BatchID' of the stored procedure.
            if (pURPurchaseReturnLine.BatchID != null)
                oDatabaseHelper.AddParameter("@BatchID", pURPurchaseReturnLine.BatchID);
            else
                oDatabaseHelper.AddParameter("@BatchID", DBNull.Value);
            // Pass the value of '_batchNumber' as parameter 'BatchNumber' of the stored procedure.
            if (pURPurchaseReturnLine.BatchNumber != null)
                oDatabaseHelper.AddParameter("@BatchNumber", pURPurchaseReturnLine.BatchNumber);
            else
                oDatabaseHelper.AddParameter("@BatchNumber", DBNull.Value);
            // Pass the value of '_expiryDate' as parameter 'ExpiryDate' of the stored procedure.
            if (pURPurchaseReturnLine.ExpiryDate != null)
                oDatabaseHelper.AddParameter("@ExpiryDate", pURPurchaseReturnLine.ExpiryDate);
            else
                oDatabaseHelper.AddParameter("@ExpiryDate", DBNull.Value);
            // Pass the value of '_salesReturnHeaderID' as parameter 'PurchaseReturnHeaderID' of the stored procedure.
            if (pURPurchaseReturnLine.PurchaseReturnHeaderID != null)
                oDatabaseHelper.AddParameter("@PurchaseReturnHeaderID", salesReturnHeaderID);
            else
                oDatabaseHelper.AddParameter("@PurchaseReturnHeaderID", DBNull.Value);
            // The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
            oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
            oDatabaseHelper.ExecuteScalar("usp_PURPurchaseReturnLine_InsertCommit", CommandType.StoredProcedure, ConnectionState.KeepOpen, ref ExecutionState);

            return ExecutionState;
        }
        private bool UpdateHeader(DatabaseHelper oDatabaseHelper, PURPurchaseReturnHeader pURPurchaseReturnHeader)
        {
            bool ExecutionState = false;
            // Pass the value of '_slaesReturnHeaderID' as parameter 'SlaesReturnHeaderID' of the stored procedure.
            oDatabaseHelper.AddParameter("@SlaesReturnHeaderID", pURPurchaseReturnHeader.PurchaseReturnID);

            // Pass the value of '_returnDate' as parameter 'ReturnDate' of the stored procedure.
            oDatabaseHelper.AddParameter("@ReturnDate", pURPurchaseReturnHeader.ReturnDate);

            // Pass the value of '_originalPurchaseHeadeID' as parameter 'OriginalPurchaseHeadeID' of the stored procedure.
            oDatabaseHelper.AddParameter("@OriginalPurchaseHeadeID", pURPurchaseReturnHeader.OriginalHeaderID);

            // Pass the value of '_createdBy' as parameter 'CreatedBy' of the stored procedure.
            oDatabaseHelper.AddParameter("@CreatedBy", pURPurchaseReturnHeader.CreatedBy);

            // Pass the value of '_createDate' as parameter 'CreateDate' of the stored procedure.
            oDatabaseHelper.AddParameter("@CreateDate", pURPurchaseReturnHeader.CreateDate);

            // Pass the value of '_updatedBy' as parameter 'UpdatedBy' of the stored procedure.
            oDatabaseHelper.AddParameter("@UpdatedBy", pURPurchaseReturnHeader.UpdatedBy);

            // Pass the value of '_updateDate' as parameter 'UpdateDate' of the stored procedure.
            oDatabaseHelper.AddParameter("@UpdateDate", pURPurchaseReturnHeader.UpdateDate);

            // Pass the value of '_isDeleted' as parameter 'IsDeleted' of the stored procedure.
            oDatabaseHelper.AddParameter("@IsDeleted", pURPurchaseReturnHeader.IsDeleted);

            // Pass the value of '_deletedBy' as parameter 'DeletedBy' of the stored procedure.
            oDatabaseHelper.AddParameter("@DeletedBy", pURPurchaseReturnHeader.DeletedBy);

            // Pass the value of '_deleteDate' as parameter 'DeleteDate' of the stored procedure.
            oDatabaseHelper.AddParameter("@DeleteDate", pURPurchaseReturnHeader.DeleteDate);

            // Pass the value of '_isClosed' as parameter 'IsClosed' of the stored procedure.
            oDatabaseHelper.AddParameter("@IsClosed", pURPurchaseReturnHeader.IsClosed);

            // Pass the value of '_isVoid' as parameter 'IsVoid' of the stored procedure.
            oDatabaseHelper.AddParameter("@IsVoid", pURPurchaseReturnHeader.IsVoid);

            // The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
            oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);

            oDatabaseHelper.ExecuteScalar("usp_PURPurchaseReturnHeader_Update", CommandType.StoredProcedure, ConnectionState.KeepOpen, ref ExecutionState);

            return ExecutionState;

        }
        private bool DeleteDetails(DatabaseHelper oDatabaseHelper, int PurchaseReturnHeaderID, int UserID)
        {
            bool ExecutionState = false;

            oDatabaseHelper.AddParameter("@UserID", UserID);
            oDatabaseHelper.AddParameter("@PurchaseReturnHeaderID", PurchaseReturnHeaderID);
            oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
            oDatabaseHelper.ExecuteScalar("usp_PURPurchaseReturnLine_DeleteLines", ref ExecutionState);

            return ExecutionState;
        }
       
		#endregion

	}
	
}
