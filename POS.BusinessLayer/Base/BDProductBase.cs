//
// Class	:	BDProductBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	2/16/2015 7:27:51 PM
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
	public class BDProductBase
	{

		#region Data Contract (Business Object Interface To Service)

		
		[DataMember]
		public int? ProductID {get;set;}

		[DataMember]
		public string ProductName {get;set;}

		[DataMember]
		public int? ProductGroupID {get;set;}

		[DataMember]
		public string ProductCode {get;set;}

		[DataMember]
		public bool? IsAcceptBatch {get;set;}

		[DataMember]
		public decimal? ProductPrice {get;set;}

		[DataMember]
		public bool? IsFixedPrice {get;set;}

		[DataMember]
		public bool? HasDiscount {get;set;}

		[DataMember]
		public decimal? DiscountAmount {get;set;}

		[DataMember]
		public double? DescountRatio {get;set;}

		[DataMember]
		public bool? IsActive {get;set;}

		[DataMember]
		public string Notes {get;set;}

		[DataMember]
		public decimal? MinPrice {get;set;}

		[DataMember]
		public decimal? MaxPrice {get;set;}

		
		#endregion
	}
}
			
