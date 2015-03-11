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
		#endregion
		
		#region Constants
		
		#endregion

		#region Constructors / Destructors 
		
		public INVTakingInventoryLine() : base()
		{
		}

		#endregion

		#region Properties

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
		#endregion
		
		#region Methods (Private)

		#endregion

	}
	
}
