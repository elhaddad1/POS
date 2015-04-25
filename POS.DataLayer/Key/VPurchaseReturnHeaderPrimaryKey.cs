//
// Class	:	VPurchaseReturnHeaderPrimaryKey.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	11/4/2015 9:57:48 PM
//

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Specialized;

namespace POS.DataLayer
{
	public class VPurchaseReturnHeaderPrimaryKey
	{

	#region Class Level Variables
			private int?           	_purchaseReturnIDNonDefault	= null;
		private int?           	_purcaseHeaderIDNonDefault	= null;
	#endregion

	#region Constants

	#endregion

	#region Constructors / Destructors

		/// <summary>
		/// Constructor setting values for all fields
		/// </summary>
		public VPurchaseReturnHeaderPrimaryKey(int? purchaseReturnID,int? purcaseHeaderID) 
		{
	
			
			this._purchaseReturnIDNonDefault = purchaseReturnID;
			
			this._purcaseHeaderIDNonDefault = purcaseHeaderID;

		}

		#endregion

	#region Properties

		/// <summary>
		/// This property is mapped to the "PurchaseReturnID" field.  Mandatory.
		/// </summary>
		public int? PurchaseReturnID
		{
			get 
			{ 
				return _purchaseReturnIDNonDefault;
			}
			set 
			{
			
				_purchaseReturnIDNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "PurcaseHeaderID" field.  Mandatory.
		/// </summary>
		public int? PurcaseHeaderID
		{
			get 
			{ 
				return _purcaseHeaderIDNonDefault;
			}
			set 
			{
			
				_purcaseHeaderIDNonDefault = value; 
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
		/// DLGenerator			11/4/2015 9:57:48 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public NameValueCollection GetKeysAndValues() 
		{
			NameValueCollection nvc=new NameValueCollection();
			
			nvc.Add("PurchaseReturnID",_purchaseReturnIDNonDefault.ToString());
			nvc.Add("PurcaseHeaderID",_purcaseHeaderIDNonDefault.ToString());
			return nvc;
			
		}

		#endregion	
		
	#region Methods (Private)

	#endregion

	}
}
