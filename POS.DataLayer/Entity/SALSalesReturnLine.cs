//
// Class	:	SALSalesReturnLine.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:56:04 PM
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
    /// Data access class for the "SALSalesReturnLine" table.
    /// </summary>
    [Serializable]
    public class SALSalesReturnLine : SALSalesReturnLineBase
    {

        #region Class Level Variables
        private DatabaseHelper oDatabaseHelper;
        #endregion

        #region Constants

        #endregion

        #region Constructors / Destructors

        public SALSalesReturnLine()
            : base()
        {
        }

        #endregion

        #region Properties

        #endregion

        #region Methods (Public)

        public int SaveTransaction(SALSalesReturnHeader sALSalesReturnHeader, SALSalesReturnLineCollection sALSalesReturnLineCollection)
        {
            oDatabaseHelper = new DatabaseHelper();
            bool ExecutionState = false;
            int salesReturnHeaderID = -1;
            oDatabaseHelper.BeginTransaction();
            if (InsertHeader(oDatabaseHelper, sALSalesReturnHeader, out salesReturnHeaderID))
            {
                foreach (SALSalesReturnLine sALSalesLine in sALSalesReturnLineCollection)
                {
                    if (!InsertDetails(oDatabaseHelper, sALSalesLine, salesReturnHeaderID))
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
            oDatabaseHelper.Dispose();
            return salesReturnHeaderID;
        }

        public bool UpdateTransaction(SALSalesReturnHeader sALSalesReturnHeader, SALSalesReturnLineCollection sALSalesReturnLineCollection)
        {
            oDatabaseHelper = new DatabaseHelper();
            bool ExecutionState = false;
            oDatabaseHelper.BeginTransaction();
            if (UpdateHeader(oDatabaseHelper, sALSalesReturnHeader))
            {
                if (DeleteDetails(oDatabaseHelper, (int)sALSalesReturnHeader.SlaesReturnHeaderID, (int)sALSalesReturnHeader.UpdatedBy))
                {
                    foreach (SALSalesReturnLine sALSalesReturnLine in sALSalesReturnLineCollection)
                    {
                        if (!InsertDetails(oDatabaseHelper, sALSalesReturnLine, (int)sALSalesReturnHeader.SlaesReturnHeaderID))
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
            oDatabaseHelper.Dispose();
            return ExecutionState;
        }
        #endregion

        #region Methods (Private)
        private bool InsertHeader(DatabaseHelper oDatabaseHelper, SALSalesReturnHeader sALSalesReturnHeader, out int pK)
        {
            bool ExecutionState = false;
            // Pass the value of '_returnDate' as parameter 'ReturnDate' of the stored procedure.
            if (sALSalesReturnHeader.ReturnDate != null)
                oDatabaseHelper.AddParameter("@ReturnDate", sALSalesReturnHeader.ReturnDate);
            else
                oDatabaseHelper.AddParameter("@ReturnDate", DBNull.Value);
            // Pass the value of '_originalSalesHeadeID' as parameter 'OriginalSalesHeadeID' of the stored procedure.
            if (sALSalesReturnHeader.OriginalSalesHeadeID != null)
                oDatabaseHelper.AddParameter("@OriginalSalesHeadeID", sALSalesReturnHeader.OriginalSalesHeadeID);
            else
                oDatabaseHelper.AddParameter("@OriginalSalesHeadeID", DBNull.Value);
            // Pass the value of '_createdBy' as parameter 'CreatedBy' of the stored procedure.
            if (sALSalesReturnHeader.CreatedBy != null)
                oDatabaseHelper.AddParameter("@CreatedBy", sALSalesReturnHeader.CreatedBy);
            else
                oDatabaseHelper.AddParameter("@CreatedBy", DBNull.Value);
            // Pass the value of '_createDate' as parameter 'CreateDate' of the stored procedure.
            if (sALSalesReturnHeader.CreateDate != null)
                oDatabaseHelper.AddParameter("@CreateDate", sALSalesReturnHeader.CreateDate);
            else
                oDatabaseHelper.AddParameter("@CreateDate", DBNull.Value);
            // Pass the value of '_updatedBy' as parameter 'UpdatedBy' of the stored procedure.
            if (sALSalesReturnHeader.UpdatedBy != null)
                oDatabaseHelper.AddParameter("@UpdatedBy", sALSalesReturnHeader.UpdatedBy);
            else
                oDatabaseHelper.AddParameter("@UpdatedBy", DBNull.Value);
            // Pass the value of '_updateDate' as parameter 'UpdateDate' of the stored procedure.
            if (sALSalesReturnHeader.UpdateDate != null)
                oDatabaseHelper.AddParameter("@UpdateDate", sALSalesReturnHeader.UpdateDate);
            else
                oDatabaseHelper.AddParameter("@UpdateDate", DBNull.Value);
            // Pass the value of '_isDeleted' as parameter 'IsDeleted' of the stored procedure.
            if (sALSalesReturnHeader.IsDeleted != null)
                oDatabaseHelper.AddParameter("@IsDeleted", sALSalesReturnHeader.IsDeleted);
            else
                oDatabaseHelper.AddParameter("@IsDeleted", DBNull.Value);
            // Pass the value of '_deletedBy' as parameter 'DeletedBy' of the stored procedure.
            if (sALSalesReturnHeader.DeletedBy != null)
                oDatabaseHelper.AddParameter("@DeletedBy", sALSalesReturnHeader.DeletedBy);
            else
                oDatabaseHelper.AddParameter("@DeletedBy", DBNull.Value);
            // Pass the value of '_deleteDate' as parameter 'DeleteDate' of the stored procedure.
            if (sALSalesReturnHeader.DeleteDate != null)
                oDatabaseHelper.AddParameter("@DeleteDate", sALSalesReturnHeader.DeleteDate);
            else
                oDatabaseHelper.AddParameter("@DeleteDate", DBNull.Value);
            // Pass the value of '_isClosed' as parameter 'IsClosed' of the stored procedure.
            if (sALSalesReturnHeader.IsClosed != null)
                oDatabaseHelper.AddParameter("@IsClosed", sALSalesReturnHeader.IsClosed);
            else
                oDatabaseHelper.AddParameter("@IsClosed", DBNull.Value);
            // Pass the value of '_isVoid' as parameter 'IsVoid' of the stored procedure.
            if (sALSalesReturnHeader.IsVoid != null)
                oDatabaseHelper.AddParameter("@IsVoid", sALSalesReturnHeader.IsVoid);
            else
                oDatabaseHelper.AddParameter("@IsVoid", DBNull.Value);
            // The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
            oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);

            try
            {
                pK = Convert.ToInt32(oDatabaseHelper.ExecuteScalar("usp_SALSalesReturnHeader_Insert", CommandType.StoredProcedure, ConnectionState.KeepOpen, ref ExecutionState));
                //    oDatabaseHelper.Dispose();
            }
            catch (Exception ex)
            {

                throw;
            }
            return ExecutionState;
        }
        private bool InsertDetails(DatabaseHelper oDatabaseHelper, SALSalesReturnLine sALSalesReturnLine, int salesReturnHeaderID)
        {
            bool ExecutionState = false;
            // Pass the value of '_qty' as parameter 'Qty' of the stored procedure.
            if (sALSalesReturnLine.Qty != null)
                oDatabaseHelper.AddParameter("@Qty", sALSalesReturnLine.Qty);
            else
                oDatabaseHelper.AddParameter("@Qty", DBNull.Value);
            // Pass the value of '_reason' as parameter 'Reason' of the stored procedure.
            if (sALSalesReturnLine.Reason != null)
                oDatabaseHelper.AddParameter("@Reason", sALSalesReturnLine.Reason);
            else
                oDatabaseHelper.AddParameter("@Reason", DBNull.Value);
            // Pass the value of '_originalSalesLineID' as parameter 'OriginalSalesLineID' of the stored procedure.
            if (sALSalesReturnLine.OriginalSalesLineID != null)
                oDatabaseHelper.AddParameter("@OriginalSalesLineID", sALSalesReturnLine.OriginalSalesLineID);
            else
                oDatabaseHelper.AddParameter("@OriginalSalesLineID", DBNull.Value);
            // Pass the value of '_batchID' as parameter 'BatchID' of the stored procedure.
            if (sALSalesReturnLine.BatchID != null)
                oDatabaseHelper.AddParameter("@BatchID", sALSalesReturnLine.BatchID);
            else
                oDatabaseHelper.AddParameter("@BatchID", DBNull.Value);
            // Pass the value of '_batchNumber' as parameter 'BatchNumber' of the stored procedure.
            if (sALSalesReturnLine.BatchNumber != null)
                oDatabaseHelper.AddParameter("@BatchNumber", sALSalesReturnLine.BatchNumber);
            else
                oDatabaseHelper.AddParameter("@BatchNumber", DBNull.Value);
            // Pass the value of '_expiryDate' as parameter 'ExpiryDate' of the stored procedure.
            if (sALSalesReturnLine.ExpiryDate != null)
                oDatabaseHelper.AddParameter("@ExpiryDate", sALSalesReturnLine.ExpiryDate);
            else
                oDatabaseHelper.AddParameter("@ExpiryDate", DBNull.Value);
            // Pass the value of '_salesReturnHeaderID' as parameter 'SalesReturnHeaderID' of the stored procedure.
            if (sALSalesReturnLine.SalesReturnHeaderID != null)
                oDatabaseHelper.AddParameter("@SalesReturnHeaderID", salesReturnHeaderID);
            else
                oDatabaseHelper.AddParameter("@SalesReturnHeaderID", DBNull.Value);
            // The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
            oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
            oDatabaseHelper.ExecuteScalar("usp_SALSalesReturnLine_InsertCommit", CommandType.StoredProcedure, ConnectionState.KeepOpen, ref ExecutionState);

            return ExecutionState;
        }
        private bool UpdateHeader(DatabaseHelper oDatabaseHelper, SALSalesReturnHeader sALSalesReturnHeader)
        {
            bool ExecutionState = false;
            // Pass the value of '_slaesReturnHeaderID' as parameter 'SlaesReturnHeaderID' of the stored procedure.
            oDatabaseHelper.AddParameter("@SlaesReturnHeaderID", sALSalesReturnHeader.SlaesReturnHeaderID);

            // Pass the value of '_returnDate' as parameter 'ReturnDate' of the stored procedure.
            oDatabaseHelper.AddParameter("@ReturnDate", sALSalesReturnHeader.ReturnDate);

            // Pass the value of '_originalSalesHeadeID' as parameter 'OriginalSalesHeadeID' of the stored procedure.
            oDatabaseHelper.AddParameter("@OriginalSalesHeadeID", sALSalesReturnHeader.OriginalSalesHeadeID);

            // Pass the value of '_createdBy' as parameter 'CreatedBy' of the stored procedure.
            oDatabaseHelper.AddParameter("@CreatedBy", sALSalesReturnHeader.CreatedBy);

            // Pass the value of '_createDate' as parameter 'CreateDate' of the stored procedure.
            oDatabaseHelper.AddParameter("@CreateDate", sALSalesReturnHeader.CreateDate);

            // Pass the value of '_updatedBy' as parameter 'UpdatedBy' of the stored procedure.
            oDatabaseHelper.AddParameter("@UpdatedBy", sALSalesReturnHeader.UpdatedBy);

            // Pass the value of '_updateDate' as parameter 'UpdateDate' of the stored procedure.
            oDatabaseHelper.AddParameter("@UpdateDate", sALSalesReturnHeader.UpdateDate);

            // Pass the value of '_isDeleted' as parameter 'IsDeleted' of the stored procedure.
            oDatabaseHelper.AddParameter("@IsDeleted", sALSalesReturnHeader.IsDeleted);

            // Pass the value of '_deletedBy' as parameter 'DeletedBy' of the stored procedure.
            oDatabaseHelper.AddParameter("@DeletedBy", sALSalesReturnHeader.DeletedBy);

            // Pass the value of '_deleteDate' as parameter 'DeleteDate' of the stored procedure.
            oDatabaseHelper.AddParameter("@DeleteDate", sALSalesReturnHeader.DeleteDate);

            // Pass the value of '_isClosed' as parameter 'IsClosed' of the stored procedure.
            oDatabaseHelper.AddParameter("@IsClosed", sALSalesReturnHeader.IsClosed);

            // Pass the value of '_isVoid' as parameter 'IsVoid' of the stored procedure.
            oDatabaseHelper.AddParameter("@IsVoid", sALSalesReturnHeader.IsVoid);

            // The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
            oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);

            oDatabaseHelper.ExecuteScalar("usp_SALSalesReturnHeader_Update", CommandType.StoredProcedure, ConnectionState.KeepOpen, ref ExecutionState);

            return ExecutionState;

        }
        private bool DeleteDetails(DatabaseHelper oDatabaseHelper, int SalesReturnHeaderID, int UserID)
        {
            bool ExecutionState = false;

            oDatabaseHelper.AddParameter("@UserID", UserID);
            oDatabaseHelper.AddParameter("@SalesReturnHeaderID", SalesReturnHeaderID);
            oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
            oDatabaseHelper.ExecuteScalar("usp_SALSalesReturnLine_DeleteLines", ref ExecutionState);

            return ExecutionState;
        }
        #endregion


    }

}
