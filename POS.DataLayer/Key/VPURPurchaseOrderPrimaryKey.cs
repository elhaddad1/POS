//
// Class	:	VPURPurchaseOrderPrimaryKey.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	11/4/2015 9:57:47 PM
//

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Specialized;

namespace POS.DataLayer
{
	public class VPURPurchaseOrderPrimaryKey
	{

	#region Class Level Variables
			private int?           	_supplierIDNonDefault    	= null;
		private int?           	_purchaseLineIDNonDefault	= null;
		private int?           	_purcaseHeaderIDNonDefault	= null;
		private int?           	_productIDNonDefault     	= null;
	#endregion

	#region Constants

	#endregion

	#region Constructors / Destructors

		/// <summary>
		/// Constructor setting values for all fields
		/// </summary>
		public VPURPurchaseOrderPrimaryKey(int? supplierID,int? purchaseLineID,int? purcaseHeaderID,int? productID) 
		{
	
			
			this._supplierIDNonDefault = supplierID;
			
			this._purchaseLineIDNonDefault = purchaseLineID;
			
			this._purcaseHeaderIDNonDefault = purcaseHeaderID;
			
			this._productIDNonDefault = productID;

		}

		#endregion

	#region Properties

		/// <summary>
		/// This property is mapped to the "SupplierID" field.  Mandatory.
		/// </summary>
		public int? SupplierID
		{
			get 
			{ 
				return _supplierIDNonDefault;
			}
			set 
			{
			
				_supplierIDNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "PurchaseLineID" field.  Mandatory.
		/// </summary>
		public int? PurchaseLineID
		{
			get 
			{ 
				return _purchaseLineIDNonDefault;
			}
			set 
			{
			
				_purchaseLineIDNonDefault = value; 
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

		/// <summary>
		/// This property is mapped to the "ProductID" field.  Mandatory.
		/// </summary>
		public int? ProductID
		{
			get 
			{ 
				return _productIDNonDefault;
			}
			set 
			{
			
				_productIDNonDefault = value; 
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
		/// DLGenerator			11/4/2015 9:57:47 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public NameValueCollection GetKeysAndValues() 
		{
			NameValueCollection nvc=new NameValueCollection();
			
			nvc.Add("SupplierID",_supplierIDNonDefault.ToString());
			nvc.Add("PurchaseLineID",_purchaseLineIDNonDefault.ToString());
			nvc.Add("PurcaseHeaderID",_purcaseHeaderIDNonDefault.ToString());
			nvc.Add("ProductID",_productIDNonDefault.ToString());
			return nvc;
			
		}

		#endregion	
		
	#region Methods (Private)

	#endregion

	}
}
