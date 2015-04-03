//
// Class	:	INVAdjustStockPrimaryKey.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	4/4/2015 12:03:46 AM
//

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Specialized;

namespace POS.DataLayer
{
	public class INVAdjustStockPrimaryKey
	{

	#region Class Level Variables
			private int?           	_adjustStockIDNonDefault 	= null;
	#endregion

	#region Constants

	#endregion

	#region Constructors / Destructors

		/// <summary>
		/// Constructor setting values for all fields
		/// </summary>
		public INVAdjustStockPrimaryKey(int? adjustStockID) 
		{
	
			
			this._adjustStockIDNonDefault = adjustStockID;

		}

		#endregion

	#region Properties

		/// <summary>
		/// This property is mapped to the "AdjustStockID" field.  Mandatory.
		/// </summary>
		public int? AdjustStockID
		{
			get 
			{ 
				return _adjustStockIDNonDefault;
			}
			set 
			{
			
				_adjustStockIDNonDefault = value; 
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
		/// DLGenerator			4/4/2015 12:03:46 AM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public NameValueCollection GetKeysAndValues() 
		{
			NameValueCollection nvc=new NameValueCollection();
			
			nvc.Add("AdjustStockID",_adjustStockIDNonDefault.ToString());
			return nvc;
			
		}

		#endregion	
		
	#region Methods (Private)

	#endregion

	}
}
