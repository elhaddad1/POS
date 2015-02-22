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

        public static bool CloseOrder(int INVTransferHeaderID, int UserID)
        {
            DatabaseHelper oDatabaseHelper = new DatabaseHelper();
            bool ExecutionState = false;
            // Pass the value of '_deletedBy' as parameter 'DeletedBy' of the stored procedure.
            oDatabaseHelper.AddParameter("@UserID", UserID);
            oDatabaseHelper.AddParameter("@INVTransferHeaderID", INVTransferHeaderID);
            oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
            oDatabaseHelper.ExecuteScalar("usp_INVTransferHader_CloseOrder", ref ExecutionState);
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
		#endregion

	}
	
}
