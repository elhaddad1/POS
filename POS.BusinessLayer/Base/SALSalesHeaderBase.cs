//
// Class	:	SALSalesHeaderBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	2/24/2015 2:25:55 AM
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
	public class SALSalesHeaderBase
	{

		#region Data Contract (Business Object Interface To Service)

		
		[DataMember]
		public int? SalesHeaderID {get;set;}

		[DataMember]
		public DateTime? SalesDate {get;set;}

		[DataMember]
		public int? CustomerID {get;set;}

		[DataMember]
		public string InvoiceNumber {get;set;}

		[DataMember]
		public DateTime? InvoiceDate {get;set;}

		[DataMember]
		public int? SellerID {get;set;}

		[DataMember]
		public int? PaymentTypeID {get;set;}

		[DataMember]
		public decimal? TotalPrice {get;set;}

		[DataMember]
		public decimal? PaidAmount {get;set;}

		[DataMember]
		public decimal? RemainingAmount {get;set;}

		[DataMember]
		public DateTime? LastDayToPay {get;set;}

		[DataMember]
		public decimal? TotalDiscountAmount {get;set;}

		[DataMember]
		public double? TotalDiscountRatio {get;set;}

		[DataMember]
		public bool? IsClosed {get;set;}

		[DataMember]
		public bool? IsVoid {get;set;}

		[DataMember]
		public bool? IsPrinted {get;set;}

		[DataMember]
		public decimal? ServicePrice {get;set;}

		[DataMember]
		public int? TaxTypeID {get;set;}

		[DataMember]
		public int? RefuseReasonID {get;set;}

		[DataMember]
		public int? CreatedBy {get;set;}

		[DataMember]
		public DateTime? CreateDate {get;set;}

		[DataMember]
		public int? UpdatedBy {get;set;}

		[DataMember]
		public DateTime? UpdateDate {get;set;}

		[DataMember]
		public bool? IsDeleted {get;set;}

		[DataMember]
		public int? DeletedBy {get;set;}

		[DataMember]
		public DateTime? DeletDate {get;set;}

		[DataMember]
		public int? InventoryID {get;set;}

		[DataMember]
		public decimal? FinalPrice {get;set;}

		
		#endregion
	}
}
			
