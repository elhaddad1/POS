//
// Class	:	VSalesReturnHeader.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	3/9/2015 4:39:22 PM
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
	/// Data access class for the "VSalesReturnHeader" table.
	/// </summary>
	[Serializable]
	public class VSalesReturnHeader : VSalesReturnHeaderBase
	{
	
		#region Class Level Variables

		#endregion
		
		#region Constants
		
		#endregion

		#region Constructors / Destructors 
		
		public VSalesReturnHeader() : base()
		{
		}

		#endregion

		#region Properties

		#endregion

		#region Methods (Public)
        public static VSalesReturnHeaderCollection SearchByriteria()
        {
            DatabaseHelper oDatabaseHelper = new DatabaseHelper();
            bool ExecutionState = false;

            // The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
            oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);

            IDataReader dr = oDatabaseHelper.ExecuteReader("usp_VSalesReturnHeader_SearchByCriteria", ref ExecutionState);
            VSalesReturnHeaderCollection VSalesReturnHeaderCollection = PopulateObjectsFromReader(dr);
            dr.Close();
            oDatabaseHelper.Dispose();
            return VSalesReturnHeaderCollection;

        }
		#endregion
		
		#region Methods (Private)

		#endregion

	}
	
}
