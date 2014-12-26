//
// Class	:	BDTaxTypePrimaryKey.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	12/26/2014 2:45:51 AM
//

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Specialized;

namespace DAPOS
{
	public class BDTaxTypePrimaryKey
	{

	#region Class Level Variables
			private int?           	_taxTypeIDNonDefault     	= null;
	#endregion

	#region Constants

	#endregion

	#region Constructors / Destructors

		/// <summary>
		/// Constructor setting values for all fields
		/// </summary>
		public BDTaxTypePrimaryKey(int? taxTypeID) 
		{
	
			
			this._taxTypeIDNonDefault = taxTypeID;

		}

		#endregion

	#region Properties

		/// <summary>
		/// This property is mapped to the "TaxTypeID" field.  Mandatory.
		/// </summary>
		public int? TaxTypeID
		{
			get 
			{ 
				return _taxTypeIDNonDefault;
			}
			set 
			{
			
				_taxTypeIDNonDefault = value; 
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
		/// DLGenerator			12/26/2014 2:45:51 AM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public NameValueCollection GetKeysAndValues() 
		{
			NameValueCollection nvc=new NameValueCollection();
			
			nvc.Add("TaxTypeID",_taxTypeIDNonDefault.ToString());
			return nvc;
			
		}

		#endregion	
		
	#region Methods (Private)

	#endregion

	}
}
