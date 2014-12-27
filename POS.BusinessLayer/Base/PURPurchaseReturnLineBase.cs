//
// Class	:	PURPurchaseReturnLineBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:56:14 PM
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
	public class PURPurchaseReturnLineBase
	{

		#region Data Contract (Business Object Interface To Service)

		
		[DataMember]
		public int? PurchaseReturnLineID {get;set;}

		[DataMember]
		public decimal? Qty {get;set;}

		[DataMember]
		public string Reason {get;set;}

		[DataMember]
		public int? OriginalpurchaseLineID {get;set;}

		[DataMember]
		public int? BatchID {get;set;}

		[DataMember]
		public string BatchNumber {get;set;}

		[DataMember]
		public DateTime? ExpiryDate {get;set;}

		
		#endregion
	}
}
			
