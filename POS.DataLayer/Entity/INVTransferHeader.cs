//
// Class	:	INVTransferHeader.cs
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
	/// Data access class for the "INVTransferHeader" table.
	/// </summary>
	[Serializable]
	public class INVTransferHeader : INVTransferHeaderBase
	{

        #region Class Level Variables
        private DatabaseHelper oDatabaseHelper;

        private string _productNameNonDefault = null;

		#endregion
		
		#region Constants
		
		#endregion

		#region Constructors / Destructors 
		
		public INVTransferHeader() : base()
		{
		}

		#endregion

		#region Properties

		#endregion

		#region Methods (Public)
        public static bool DeleteOrder(int INVTransferHeaderID, int UserID)
        {
            DatabaseHelper oDatabaseHelper = new DatabaseHelper();
            bool ExecutionState = false;
            // Pass the value of '_deletedBy' as parameter 'DeletedBy' of the stored procedure.
            oDatabaseHelper.AddParameter("@UserID", UserID);
            oDatabaseHelper.AddParameter("@INVTransferHeaderID", INVTransferHeaderID);
            oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
            oDatabaseHelper.ExecuteScalar("usp_INVTransferHader_DeleteOrder", ref ExecutionState);
            oDatabaseHelper.Dispose();
            return ExecutionState;
        }

        public bool CloseOrder(int INVTransferHeaderID, int UserID, INVTransferLineCollection transferLineCollection)
        {
            oDatabaseHelper = new DatabaseHelper();
            bool ExecutionState = false;
            oDatabaseHelper.BeginTransaction();
            oDatabaseHelper.AddParameter("@UserID", UserID);
            oDatabaseHelper.AddParameter("@INVTransferHeaderID", INVTransferHeaderID);
            oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
            oDatabaseHelper.ExecuteScalar("usp_INVTransferHader_CloseOrder", CommandType.StoredProcedure, ConnectionState.KeepOpen, ref ExecutionState);
            foreach (INVTransferLine transferLine in transferLineCollection)
            {
                if (!CommitDetails(oDatabaseHelper, transferLine))
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
            oDatabaseHelper.Dispose();
            return ExecutionState;
        }
		#endregion

        #region Methods (Private)
        private static INVTransferHeaderCollection PopulateFromReader(IDataReader rdr)
        {
            INVTransferHeaderCollection INVTransferHeaderCollection = new INVTransferHeaderCollection();
            while (rdr.Read())
            {
                INVTransferHeader obj = new INVTransferHeader();
                obj.INVTransferHeaderID = rdr.GetInt32(rdr.GetOrdinal(INVTransferHeaderFields.INVTransferHeaderID));
                obj.TransferDate = rdr.GetDateTime(rdr.GetOrdinal(INVTransferHeaderFields.TransferDate));
                obj.FromInventoryID = rdr.GetInt32(rdr.GetOrdinal(INVTransferHeaderFields.FromInventoryID));
                obj.ToInventoryID = rdr.GetInt32(rdr.GetOrdinal(INVTransferHeaderFields.ToInventoryID));
                
                if (!rdr.IsDBNull(rdr.GetOrdinal(INVTransferHeaderFields.InvoiceNumber)))
                {
                    obj.InvoiceNumber = rdr.GetString(rdr.GetOrdinal(INVTransferHeaderFields.InvoiceNumber));
                }

                if (!rdr.IsDBNull(rdr.GetOrdinal(INVTransferHeaderFields.InvoiceDate)))
                {
                    obj.InvoiceDate = rdr.GetDateTime(rdr.GetOrdinal(INVTransferHeaderFields.InvoiceDate));
                }

                obj.IsClosed = rdr.GetBoolean(rdr.GetOrdinal(INVTransferHeaderFields.IsClosed));
                obj.IsVoid = rdr.GetBoolean(rdr.GetOrdinal(INVTransferHeaderFields.IsVoid));
                obj.IsPrinted = rdr.GetBoolean(rdr.GetOrdinal(INVTransferHeaderFields.IsPrinted));

                if (!rdr.IsDBNull(rdr.GetOrdinal(INVTransferHeaderFields.CreatedBy)))
                {
                    obj.CreatedBy = rdr.GetInt32(rdr.GetOrdinal(INVTransferHeaderFields.CreatedBy));
                }

                if (!rdr.IsDBNull(rdr.GetOrdinal(INVTransferHeaderFields.CreateDate)))
                {
                    obj.CreateDate = rdr.GetDateTime(rdr.GetOrdinal(INVTransferHeaderFields.CreateDate));
                }

                if (!rdr.IsDBNull(rdr.GetOrdinal(INVTransferHeaderFields.UpdatedBy)))
                {
                    obj.UpdatedBy = rdr.GetInt32(rdr.GetOrdinal(INVTransferHeaderFields.UpdatedBy));
                }

                if (!rdr.IsDBNull(rdr.GetOrdinal(INVTransferHeaderFields.UpdateDate)))
                {
                    obj.UpdateDate = rdr.GetDateTime(rdr.GetOrdinal(INVTransferHeaderFields.UpdateDate));
                }

                obj.IsDeleted = rdr.GetBoolean(rdr.GetOrdinal(INVTransferHeaderFields.IsDeleted));
                if (!rdr.IsDBNull(rdr.GetOrdinal(INVTransferHeaderFields.DeletedBy)))
                {
                    obj.DeletedBy = rdr.GetInt32(rdr.GetOrdinal(INVTransferHeaderFields.DeletedBy));
                }

                if (!rdr.IsDBNull(rdr.GetOrdinal(INVTransferHeaderFields.DeletedDate)))
                {
                    obj.DeletedDate = rdr.GetDateTime(rdr.GetOrdinal(INVTransferHeaderFields.DeletedDate));
                }
                INVTransferHeaderCollection.Add(obj);
            }
            return INVTransferHeaderCollection;
        }
        private bool CommitDetails(DatabaseHelper oDatabaseHelper, INVTransferLine transferLine)
        {
            bool ExecutionState = false;
            // Pass the value of '_TransferHeaderID' as parameter 'TransferHeaderID' of the stored procedure.
            oDatabaseHelper.AddParameter("@TransferLineID", transferLine.TransferLineID);
            oDatabaseHelper.AddParameter("@TransferHeaderID", transferLine.TransferHeaderID);
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

            oDatabaseHelper.ExecuteScalar("usp_INVTransferLine_Commit", CommandType.StoredProcedure, ConnectionState.KeepOpen, ref ExecutionState);

            return ExecutionState;
        }
		#endregion

	}
	
}
