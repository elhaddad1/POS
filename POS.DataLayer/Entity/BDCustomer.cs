//
// Class	:	BDCustomer.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	2/28/2015 11:31:47 PM
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
	/// Data access class for the "BDCustomer" table.
	/// </summary>
	[Serializable]
	public class BDCustomer : BDCustomerBase
	{
	
		#region Class Level Variables

		#endregion
		
		#region Constants
		
		#endregion

		#region Constructors / Destructors 
		
		public BDCustomer() : base()
		{
		}

		#endregion

		#region Properties

		#endregion

        #region Methods (Public)
        public static BDCustomerCollection SearcByCriteria(string CustomerName, string CustomerCode)
        {
            DatabaseHelper oDatabaseHelper = new DatabaseHelper();
            bool ExecutionState = false;

            // Pass the specified field and its value to the stored procedure.
            oDatabaseHelper.AddParameter("@CustomerName", CustomerName);
            oDatabaseHelper.AddParameter("@CustomerCode", CustomerCode);

            // The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
            oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);

            IDataReader dr = oDatabaseHelper.ExecuteReader("usp_BDCustomer_SearchByCriteria", ref ExecutionState);
            BDCustomerCollection BDCustomerCollection = PopulateObjectsFromReader(dr);
            dr.Close();
            oDatabaseHelper.Dispose();
            return BDCustomerCollection;

        }

        #endregion

            #region Methods (Private)

            #endregion

	}
	
}
