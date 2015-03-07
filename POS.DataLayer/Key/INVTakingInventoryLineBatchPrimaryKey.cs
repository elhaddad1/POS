//
// Class	:	INVTakingInventoryLineBatchPrimaryKey.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	3/7/2015 2:37:29 PM
//

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Specialized;

namespace POS.DataLayer
{
	public class INVTakingInventoryLineBatchPrimaryKey
	{

	#region Class Level Variables
			private int?           	_takingLineBatchIDNonDefault	= null;
	#endregion

	#region Constants

	#endregion

	#region Constructors / Destructors

		/// <summary>
		/// Constructor setting values for all fields
		/// </summary>
		public INVTakingInventoryLineBatchPrimaryKey(int? takingLineBatchID) 
		{
	
			
			this._takingLineBatchIDNonDefault = takingLineBatchID;

		}

		#endregion

	#region Properties

		/// <summary>
		/// This property is mapped to the "TakingLineBatchID" field.  Mandatory.
		/// </summary>
		public int? TakingLineBatchID
		{
			get 
			{ 
				return _takingLineBatchIDNonDefault;
			}
			set 
			{
			
				_takingLineBatchIDNonDefault = value; 
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
		/// DLGenerator			3/7/2015 2:37:29 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public NameValueCollection GetKeysAndValues() 
		{
			NameValueCollection nvc=new NameValueCollection();
			
			nvc.Add("TakingLineBatchID",_takingLineBatchIDNonDefault.ToString());
			return nvc;
			
		}

		#endregion	
		
	#region Methods (Private)

	#endregion

	}
}
