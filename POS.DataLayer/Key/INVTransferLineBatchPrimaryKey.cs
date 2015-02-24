//
// Class	:	INVTransferLineBatchPrimaryKey.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	2/22/2015 7:27:21 PM
//

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Specialized;

namespace POS.DataLayer
{
	public class INVTransferLineBatchPrimaryKey
	{

	#region Class Level Variables
			private int?           	_transferLineBatchIDNonDefault	= null;
	#endregion

	#region Constants

	#endregion

	#region Constructors / Destructors

		/// <summary>
		/// Constructor setting values for all fields
		/// </summary>
		public INVTransferLineBatchPrimaryKey(int? transferLineBatchID) 
		{
	
			
			this._transferLineBatchIDNonDefault = transferLineBatchID;

		}

		#endregion

	#region Properties

		/// <summary>
		/// This property is mapped to the "TransferLineBatchID" field.  Mandatory.
		/// </summary>
		public int? TransferLineBatchID
		{
			get 
			{ 
				return _transferLineBatchIDNonDefault;
			}
			set 
			{
			
				_transferLineBatchIDNonDefault = value; 
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
		/// DLGenerator			2/22/2015 7:27:21 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public NameValueCollection GetKeysAndValues() 
		{
			NameValueCollection nvc=new NameValueCollection();
			
			nvc.Add("TransferLineBatchID",_transferLineBatchIDNonDefault.ToString());
			return nvc;
			
		}

		#endregion	
		
	#region Methods (Private)

	#endregion

	}
}
