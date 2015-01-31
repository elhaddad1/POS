//
// Class	:	VProduct.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	1/13/2015 9:43:39 PM
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
	/// Data access class for the "VProducts" table.
	/// </summary>
	[Serializable]
	public class VProduct : VProductBase
	{
	
		#region Class Level Variables

		#endregion
		
		#region Constants
		
		#endregion

		#region Constructors / Destructors 
		
		public VProduct() : base()
		{
		}

		#endregion

		#region Properties

		#endregion

		#region Methods (Public)
   		#endregion
		
		#region Methods (Private)

		#endregion


        public static IEnumerable<VProduct> SearcByCriteria(string productName, string productCode)
        {
            DatabaseHelper oDatabaseHelper = new DatabaseHelper();
            bool ExecutionState = false;

            // Pass the specified field and its value to the stored procedure.
            oDatabaseHelper.AddParameter("@ProductName", productName);
            oDatabaseHelper.AddParameter("@ProductCode", productCode);

            // The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
            oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);

            IDataReader dr = oDatabaseHelper.ExecuteReader("usp_BDProduct_SearchByCriteria", ref ExecutionState);
            VProductCollection BDProductCollection = PopulateObjectsFromReader(dr);
            dr.Close();
            oDatabaseHelper.Dispose();
            return BDProductCollection;
        }
    }
	
}
