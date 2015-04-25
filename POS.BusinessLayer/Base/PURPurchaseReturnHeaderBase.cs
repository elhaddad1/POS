//
// Class	:	PURPurchaseReturnHeaderBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	11/4/2015 8:46:46 PM
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
	public class PURPurchaseReturnHeaderBase
	{

		#region Data Contract (Business Object Interface To Service)

		
		[DataMember]
		public int? PurchaseReturnID {get;set;}

		[DataMember]
		public DateTime? ReturnDate {get;set;}

		[DataMember]
		public int? OriginalHeaderID {get;set;}

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
		public string DeletedBy {get;set;}

		[DataMember]
		public DateTime? DeleteDate {get;set;}

		[DataMember]
		public bool? IsClosed {get;set;}

		[DataMember]
		public bool? IsVoid {get;set;}

		[DataMember]
		public decimal? ReturnMoney {get;set;}

		
		#endregion
	}
}
			
