//
// Class	:	VSALSalesOrderBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	3/19/2015 1:00:17 PM
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
	public class VSALSalesOrderBase
	{

		#region Data Contract (Business Object Interface To Service)

		
		[DataMember]
		public int? CustomerID {get;set;}

		[DataMember]
		public string CustomerName {get;set;}

		[DataMember]
		public decimal? Qty {get;set;}

		[DataMember]
		public int? SalesLineID {get;set;}

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
		public int? SalesHeaderID {get;set;}

		[DataMember]
		public DateTime? SalesDate {get;set;}

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
		public decimal? FinalPrice {get;set;}

		[DataMember]
		public int? ChequeNumber {get;set;}

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
			
