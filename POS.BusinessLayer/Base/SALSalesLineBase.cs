//
// Class	:	SALSalesLineBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	2/24/2015 2:25:54 AM
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
	public class SALSalesLineBase
	{

		#region Data Contract (Business Object Interface To Service)

		
		[DataMember]
		public int? SalesLineID {get;set;}

		[DataMember]
		public int? SalesHeaderID {get;set;}

		[DataMember]
		public int? ProductID {get;set;}

		[DataMember]
		public decimal? TotalQty {get;set;}

		[DataMember]
		public decimal? TotalBonus {get;set;}

		[DataMember]
		public decimal? DiscountAmount {get;set;}

		[DataMember]
		public decimal? DiscountRatio {get;set;}

		[DataMember]
		public decimal? UnitPrice {get;set;}

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
		public DateTime? DeleteDate {get;set;}

		
		#endregion
	}
}
			
