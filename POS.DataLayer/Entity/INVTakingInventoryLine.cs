//
// Class	:	INVTakingInventoryLine.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:55:58 PM
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
	/// Data access class for the "INVTakingInventoryLine" table.
	/// </summary>
	[Serializable]
	public class INVTakingInventoryLine : INVTakingInventoryLineBase
	{
	
		#region Class Level Variables
         DatabaseHelper oDatabaseHelper = new DatabaseHelper();
         int? _takingLineBatchID;        
         string _productName;         
         bool? _isAcceptBatch;
         string _stockTypeName;
         string _batchNumber;
         DateTime? _expiryDate;

         
		#endregion
		
		#region Constants
		
		#endregion

		#region Constructors / Destructors 
		
		public INVTakingInventoryLine() : base()
		{
		}

		#endregion

		#region Properties
        public int? TakingLineBatchID
        {
            get { return _takingLineBatchID; }
            set { _takingLineBatchID = value; }
        }
        public string ProductName
         {
             get { return _productName; }
             set { _productName = value; }
         }
        public bool? IsAcceptBatch
         {
             get { return _isAcceptBatch; }
             set { _isAcceptBatch = value; }
         }
        public string StockTypeName
         {
             get { return _stockTypeName; }
             set { _stockTypeName = value; }
         }
        public string BatchNumber
         {
             get { return _batchNumber; }
             set { _batchNumber = value; }
         }
        public DateTime? ExpiryDate
        {
            get { return _expiryDate; }
            set { _expiryDate = value; }
        }
		#endregion

		#region Methods (Public)
        public static  bool OpenTakingInventory(string TakingName ,DateTime TakingDate ,int InventoryID,int TakingType ,
                                        int? ProductID,int? ProductGroupID,string Notes,int UserID)
        {
             DatabaseHelper oDatabaseHelper = new DatabaseHelper();
            bool ExecutionState = false;
            oDatabaseHelper = new DatabaseHelper();

            // Pass the value of '_transferHeaderID' as parameter 'TransferHeaderID' of the stored procedure.
            if (TakingName != null)
                oDatabaseHelper.AddParameter("@TakingName", TakingName);
            else
                oDatabaseHelper.AddParameter("@TakingName", DBNull.Value);
            // Pass the value of '_productID' as parameter 'ProductID' of the stored procedure.
            if (TakingDate != null)
                oDatabaseHelper.AddParameter("@TakingDate", TakingDate);
            else
                oDatabaseHelper.AddParameter("@TakingDate", DBNull.Value);
            // Pass the value of '_qty' as parameter 'Qty' of the stored procedure.
            if (InventoryID != null)
                oDatabaseHelper.AddParameter("@InventoryID", InventoryID);
            else
                oDatabaseHelper.AddParameter("@InventoryID", DBNull.Value);
            // Pass the value of '_createdBy' as parameter 'CreatedBy' of the stored procedure.
            if (TakingType != null)
                oDatabaseHelper.AddParameter("@TakingType", TakingType);
            else
                oDatabaseHelper.AddParameter("@TakingType", DBNull.Value);
            // Pass the value of '_createDate' as parameter 'CreateDate' of the stored procedure.
            if (ProductID != null)
                oDatabaseHelper.AddParameter("@ProductID", ProductID);
            else
                oDatabaseHelper.AddParameter("@ProductID", DBNull.Value);
            // Pass the value of '_updatedBy' as parameter 'UpdatedBy' of the stored procedure.
            if (ProductGroupID != null)
                oDatabaseHelper.AddParameter("@ProductGroupID", ProductGroupID);
            else
                oDatabaseHelper.AddParameter("@ProductGroupID", DBNull.Value);
            // Pass the value of '_updateDate' as parameter 'UpdateDate' of the stored procedure.
            if (Notes != null)
                oDatabaseHelper.AddParameter("@Notes", Notes);
            else
                oDatabaseHelper.AddParameter("@Notes", DBNull.Value);
            // Pass the value of '_isDeleted' as parameter 'IsDeleted' of the stored procedure.

            if (UserID != null)
                oDatabaseHelper.AddParameter("@UserID", UserID);
            else
                oDatabaseHelper.AddParameter("@UserID", DBNull.Value);
            // Pass the value of '_isDeleted' as parameter 'IsDeleted' of the stored procedure.


            oDatabaseHelper.ExecuteScalar("usp_INVTakingInventoryline_OpenTakingInventory", ref ExecutionState);
            oDatabaseHelper.Dispose();
            return ExecutionState;

        }

        public INVTakingInventoryLineCollection GetLines(int HeaderID)
        {
            DatabaseHelper oDatabaseHelper = new DatabaseHelper();
            bool ExecutionState = false;

            // The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
            oDatabaseHelper.AddParameter("TakingHeaderID", HeaderID);
           // oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);

            IDataReader dr = oDatabaseHelper.ExecuteReader("usp_INVTakingInventory_GetLines", ref ExecutionState);

            INVTakingInventoryLineCollection list = new INVTakingInventoryLineCollection();

            while (dr.Read())
            {
                INVTakingInventoryLine obj = new INVTakingInventoryLine();
                 obj.TakingLineID = dr.GetInt32(dr.GetOrdinal(INVTakingInventoryLineFields.TakingLineID));
                 if (!dr.IsDBNull(dr.GetOrdinal("TakingLineBatchID")))
                 {
                     obj.TakingLineBatchID = dr.GetInt32(dr.GetOrdinal("TakingLineBatchID"));
                 }
                obj.ProductID = dr.GetInt32(dr.GetOrdinal(INVTakingInventoryLineFields.ProductID));
                obj.ProductName= dr.GetString(dr.GetOrdinal("ProductName"));
                obj.StockTypeName = dr.GetString(dr.GetOrdinal("StockTypeName"));
                obj.ExpectedQty = dr.GetDecimal(dr.GetOrdinal(INVTakingInventoryLineFields.ExpectedQty));
                obj.ActualQty = dr.GetDecimal(dr.GetOrdinal(INVTakingInventoryLineFields.ActualQty));
                obj.IsAcceptBatch = dr.GetBoolean(dr.GetOrdinal("IsAcceptBatch"));
                if (!dr.IsDBNull(dr.GetOrdinal("BatchNumber")))
                    obj.BatchNumber = dr.GetString(dr.GetOrdinal("BatchNumber"));
                if (!dr.IsDBNull(dr.GetOrdinal("ExpiryDate")))
                obj.ExpiryDate = dr.GetDateTime(dr.GetOrdinal("ExpiryDate"));
                list.Add(obj);
            }


            dr.Close();
            oDatabaseHelper.Dispose();
            return list;
            //usp_INVTakingInventory_GetNotCommited
        }
        public static bool SaveLine(int TakingInventoryLineID,int? TakingInventoryLineBatchID, decimal ActualQty)
        {
            DatabaseHelper oDatabaseHelper = new DatabaseHelper();
            bool ExecutionState = false;
            // Pass the value of '_deletedBy' as parameter 'DeletedBy' of the stored procedure.
            oDatabaseHelper.AddParameter("@TakingInventoryLineID", TakingInventoryLineID);
            if (TakingInventoryLineBatchID != null && TakingInventoryLineBatchID !=0)
            oDatabaseHelper.AddParameter("@TakingInventoryLineBatchID", TakingInventoryLineBatchID);

            oDatabaseHelper.AddParameter("@ActualQty", ActualQty);
            oDatabaseHelper.ExecuteScalar("usp_TakingInventoryLine_SaveLines", ref ExecutionState);
            oDatabaseHelper.Dispose();
            return ExecutionState;
        }
		#endregion
		
		#region Methods (Private)

		#endregion

	}
	
}
