//
// Class	:	INVTakingInventory.cs
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
	/// Data access class for the "INVTakingInventory" table.
	/// </summary>
	[Serializable]
	public class INVTakingInventory : INVTakingInventoryBase
	{
	
		#region Class Level Variables
        string _inventoryName;

        
		#endregion
		
		#region Constants
		
		#endregion

		#region Constructors / Destructors 
		
		public INVTakingInventory() : base()
		{
		}

		#endregion

		#region Properties
        public string InventoryName
        {
            get { return _inventoryName; }
            set { _inventoryName = value; }
        }
		#endregion

		#region Methods (Public)

        public INVTakingInventoryCollection GetNotCommittedTaking()
        {
            DatabaseHelper oDatabaseHelper = new DatabaseHelper();
            bool ExecutionState = false;

            // The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
            //oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);

            IDataReader dr = oDatabaseHelper.ExecuteReader("usp_INVTakingInventory_GetNotCommited", ref ExecutionState);

            INVTakingInventoryCollection list = new INVTakingInventoryCollection();

            while (dr.Read())
            {
                INVTakingInventory obj = new INVTakingInventory();
                 obj.TakingHeaderID = dr.GetInt32(dr.GetOrdinal(INVTakingInventoryFields.TakingHeaderID));
                obj.TakingDate = dr.GetDateTime(dr.GetOrdinal(INVTakingInventoryFields.TakingDate));
                obj.TakingName = dr.GetString(dr.GetOrdinal(INVTakingInventoryFields.TakingName));
                
                if (!dr.IsDBNull(dr.GetOrdinal(INVTakingInventoryFields.Notes)))
                {
                    obj.Notes = dr.GetString(dr.GetOrdinal(INVTakingInventoryFields.Notes));
                }

                if (!dr.IsDBNull(dr.GetOrdinal(INVTakingInventoryFields.InventoryID)))
                {
                    obj.InventoryID = dr.GetInt32(dr.GetOrdinal(INVTakingInventoryFields.InventoryID));
                }
                //if (!dr.IsDBNull(dr.GetOrdinal("UserName")))
                //{
                //    obj.CreatedBy = dr.GetString(dr.GetOrdinal("UserName"));
                //}
                if (!dr.IsDBNull(dr.GetOrdinal("InventoryName")))
                {
                    obj.InventoryName = dr.GetString(dr.GetOrdinal("InventoryName"));
                }
                list.Add(obj);
            }
            
            
            dr.Close();
            oDatabaseHelper.Dispose();
            return list;
            //usp_INVTakingInventory_GetNotCommited
        }
        public static bool CommitTakingInventory(int TakingHeaderID, int UserID)
        {
            DatabaseHelper oDatabaseHelper = new DatabaseHelper();
            bool ExecutionState = false;
            // Pass the value of '_deletedBy' as parameter 'DeletedBy' of the stored procedure.
            oDatabaseHelper.AddParameter("@UserID", UserID);
            oDatabaseHelper.AddParameter("@TakingHeaderID", TakingHeaderID);
            oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
            oDatabaseHelper.ExecuteScalar("usp_INVTakingInventory_Commit", ref ExecutionState);
            oDatabaseHelper.Dispose();
            return ExecutionState;
        }
		#endregion
		
		#region Methods (Private)

		#endregion

	}
	
}
