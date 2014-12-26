//
// Class	:	SALSalesLineBatchPrimaryKey.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	12/26/2014 2:45:58 AM
//

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Specialized;

namespace DAPOS
{
	public class SALSalesLineBatchPrimaryKey
	{

	#region Class Level Variables
			private int?           	_salesLineBatchIDNonDefault	= null;
	#endregion

	#region Constants

	#endregion

	#region Constructors / Destructors

		/// <summary>
		/// Constructor setting values for all fields
		/// </summary>
		public SALSalesLineBatchPrimaryKey(int? salesLineBatchID) 
		{
	
			
			this._salesLineBatchIDNonDefault = salesLineBatchID;

		}

		#endregion

	#region Properties

		/// <summary>
		/// This property is mapped to the "SalesLineBatchID" field.  Mandatory.
		/// </summary>
		public int? SalesLineBatchID
		{
			get 
			{ 
				return _salesLineBatchIDNonDefault;
			}
			set 
			{
			
				_salesLineBatchIDNonDefault = value; 
			}
		}

		#endregion

	#region Methods (Public)

		/// <summary>
		/// Method to get the list of fields and their values
		/// </summary>
		///
		/// <returns>Name value collection containing the fields and the values</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:58 AM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public NameValueCollection GetKeysAndValues() 
		{
			NameValueCollection nvc=new NameValueCollection();
			
			nvc.Add("SalesLineBatchID",_salesLineBatchIDNonDefault.ToString());
			return nvc;
			
		}

		#endregion	
		
	#region Methods (Private)

	#endregion

	}
}
