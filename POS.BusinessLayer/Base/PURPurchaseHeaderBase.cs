//
// Class	:	PURPurchaseHeaderBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	2/24/2015 11:36:31 AM
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
	public class PURPurchaseHeaderBase
	{

		#region Data Contract (Business Object Interface To Service)

		
		[DataMember]
		public int? PurcaseHeaderID {get;set;}

		[DataMember]
		public DateTime? PurchaseDate {get;set;}

		[DataMember]
		public int? PaymentTypeID {get;set;}

		[DataMember]
		public int? SupplierID {get;set;}

		[DataMember]
		public string InvoiceNumber {get;set;}

		[DataMember]
		public DateTime? CreateDate {get;set;}

		[DataMember]
		public int? CreatedBy {get;set;}

		[DataMember]
		public DateTime? updateDate {get;set;}

		[DataMember]
		public int? UpdatedBy {get;set;}

		[DataMember]
		public bool? IsDeleted {get;set;}

		[DataMember]
		public DateTime? DeleteDate {get;set;}

		[DataMember]
		public decimal? TotalPrice {get;set;}

		[DataMember]
		public decimal? ServicePrice {get;set;}

		[DataMember]
		public decimal? PaidAmount {get;set;}

		[DataMember]
		public bool? IsClosed {get;set;}

		[DataMember]
		public bool? IsVoid {get;set;}

		[DataMember]
		public bool? IsPrinted {get;set;}

		[DataMember]
		public int? RefuseReasonID {get;set;}

		[DataMember]
		public decimal? TotalDiscountAmount {get;set;}

		[DataMember]
		public double? TotalDiscountRatio {get;set;}

		[DataMember]
		public int? TaxTypeID {get;set;}

		[DataMember]
		public decimal? RemainingAmount {get;set;}

		[DataMember]
		public DateTime? LastDayToPay {get;set;}

		[DataMember]
		public int? DeletedBy {get;set;}

		[DataMember]
		public string Notes {get;set;}

		[DataMember]
		public int? InventoryID {get;set;}

		[DataMember]
		public DateTime? InvoiceDate {get;set;}

		
		#endregion
	}
}
			
