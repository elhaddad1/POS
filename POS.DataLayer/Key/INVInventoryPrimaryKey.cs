//
// Class	:	INVInventoryPrimaryKey.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	5/2/2015 2:22:12 AM
//

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Specialized;

namespace POS.DataLayer
{
	public class INVInventoryPrimaryKey
	{

	#region Class Level Variables
			private int?           	_inventoryIDNonDefault   	= null;
	#endregion

	#region Constants

	#endregion

	#region Constructors / Destructors

		/// <summary>
		/// Constructor setting values for all fields
		/// </summary>
		public INVInventoryPrimaryKey(int? inventoryID) 
		{
	
			
			this._inventoryIDNonDefault = inventoryID;

		}

		#endregion

	#region Properties

		/// <summary>
		/// This property is mapped to the "InventoryID" field.  Mandatory.
		/// </summary>
		public int? InventoryID
		{
			get 
			{ 
				return _inventoryIDNonDefault;
			}
			set 
			{
			
				_inventoryIDNonDefault = value; 
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
		/// DLGenerator			5/2/2015 2:22:12 AM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public NameValueCollection GetKeysAndValues() 
		{
			NameValueCollection nvc=new NameValueCollection();
			
			nvc.Add("InventoryID",_inventoryIDNonDefault.ToString());
			return nvc;
			
		}

		#endregion	
		
	#region Methods (Private)

	#endregion

	}
}
