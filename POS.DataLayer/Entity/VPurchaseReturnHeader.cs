//
// Class	:	VPurchaseReturnHeader.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	11/4/2015 9:57:48 PM
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
	/// Data access class for the "VPurchaseReturnHeader" table.
	/// </summary>
	[Serializable]
	public class VPurchaseReturnHeader : VPurchaseReturnHeaderBase
	{
	
		#region Class Level Variables

		#endregion
		
		#region Constants
		
		#endregion

		#region Constructors / Destructors 
		
		public VPurchaseReturnHeader() : base()
		{
		}

		#endregion

		#region Properties

		#endregion

		#region Methods (Public)
        public static VPurchaseReturnHeaderCollection SearchByriteria(string CustomerName, DateTime FromDate, DateTime ToDate, string InvoiceNumber)
        {
            DatabaseHelper oDatabaseHelper = new DatabaseHelper();
            bool ExecutionState = false;
            oDatabaseHelper.AddParameter("@SupplierName", CustomerName);
            oDatabaseHelper.AddParameter("@FromDate", FromDate);
            oDatabaseHelper.AddParameter("@DateTo", ToDate);
            oDatabaseHelper.AddParameter("@InvoiceNumber", InvoiceNumber);
            oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);

            IDataReader dr = oDatabaseHelper.ExecuteReader("usp_VPurchaseReturnHeader_SearchByCriteria", ref ExecutionState);
            VPurchaseReturnHeaderCollection VPurchaseReturnHeaderCollection = PopulateObjectsFromReader(dr);
            dr.Close();
            oDatabaseHelper.Dispose();
            return VPurchaseReturnHeaderCollection;

        }
       
		#endregion
		
		#region Methods (Private)

		#endregion

	}
	
}
