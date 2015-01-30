//
// Class	:	INVInventory.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:56:16 PM
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
	/// Data access class for the "INVInventory" table.
	/// </summary>
	[Serializable]
	public class INVInventory : INVInventoryBase
	{
	
		#region Class Level Variables

		#endregion
		
		#region Constants
		
		#endregion

		#region Constructors / Destructors 
		
		public INVInventory() : base()
		{
		}

		#endregion

		#region Properties

		#endregion

		#region Methods (Public)

        public static INVInventoryCollection SearcByCriteria(string InventoryName)
        {
            DatabaseHelper oDatabaseHelper = new DatabaseHelper();
            bool ExecutionState = false;

            // Pass the specified field and its value to the stored procedure.
            oDatabaseHelper.AddParameter("@InventoryName", InventoryName);

            // The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
            oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);

            IDataReader dr = oDatabaseHelper.ExecuteReader("usp_Inventory_SearchByCriteria", ref ExecutionState);
            INVInventoryCollection INVInventoryCollection = PopulateObjectsFromReader(dr);
            dr.Close();
            oDatabaseHelper.Dispose();
            return INVInventoryCollection;

        }
		#endregion
		
		#region Methods (Private)

		#endregion

	}
	
}
