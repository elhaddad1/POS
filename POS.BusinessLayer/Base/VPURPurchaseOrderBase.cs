//
// Class	:	VPURPurchaseOrderBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	11/4/2015 9:57:47 PM
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
	public class VPURPurchaseOrderBase
	{

		#region Data Contract (Business Object Interface To Service)

		
		[DataMember]
		public int? SupplierID {get;set;}

		[DataMember]
		public string SupplierName {get;set;}

		[DataMember]
		public decimal? Qty {get;set;}

		[DataMember]
		public int? PurchaseLineID {get;set;}

		[DataMember]
		public decimal? TotalQty {get;set;}

		[DataMember]
		public decimal? UnitPrice {get;set;}

		[DataMember]
		public string BatchNumber {get;set;}

		[DataMember]
		public DateTime? ExpiryDate {get;set;}

		[DataMember]
		public decimal? TaxValue {get;set;}

		[DataMember]
		public int? PurcaseHeaderID {get;set;}

		[DataMember]
		public DateTime? PurchaseDate {get;set;}

		[DataMember]
		public string InvoiceNumber {get;set;}

		[DataMember]
		public DateTime? InvoiceDate {get;set;}

		[DataMember]
		public int? PaymentTypeID {get;set;}

		[DataMember]
		public double? TotalDiscountRatio {get;set;}

		[DataMember]
		public string TaxTypeName {get;set;}

		[DataMember]
		public bool? IsClosed {get;set;}

		[DataMember]
		public bool? IsVoid {get;set;}

		[DataMember]
		public decimal? ChequeNumber {get;set;}

		[DataMember]
		public string ProductName {get;set;}

		[DataMember]
		public string ProductCode {get;set;}

		[DataMember]
		public bool? IsAcceptBatch {get;set;}

		[DataMember]
		public string UserFullName {get;set;}

		[DataMember]
		public int? ProductID {get;set;}

		
		#endregion
	}
}
			
