//
// Class	:	VPurchaseReturnHeaderBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	11/4/2015 9:57:48 PM
//
using System;
using System.Runtime.Serialization;
using POS.DataLayer;

namespace POS.BusinessLayer
{
	/// <summary>
	/// Class for the properties of the object
	/// </summary>
	[DataContract(Namespace = "POS.BusinessLayer")]
	public class VPurchaseReturnHeaderBase
	{

		#region Data Contract (Business Object Interface To Service)

		
		[DataMember]
		public int? PurchaseReturnID {get;set;}

		[DataMember]
		public DateTime? ReturnDate {get;set;}

		[DataMember]
		public bool? IsClosed {get;set;}

		[DataMember]
		public string InvoiceNumber {get;set;}

		[DataMember]
		public string SupplierName {get;set;}

		[DataMember]
		public int? PurcaseHeaderID {get;set;}

		
		#endregion
	}
}
			
