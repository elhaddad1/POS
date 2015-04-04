//
// Class	:	SALSalesReturnHeaderBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	4/4/2015 6:56:39 PM
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
	public class SALSalesReturnHeaderBase
	{

		#region Data Contract (Business Object Interface To Service)

		
		[DataMember]
		public int? SlaesReturnHeaderID {get;set;}

		[DataMember]
		public DateTime? ReturnDate {get;set;}

		[DataMember]
		public int? OriginalSalesHeadeID {get;set;}

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
		public int? InventoryID {get;set;}

		[DataMember]
		public decimal? ReturnMoney {get;set;}

		
		#endregion
	}
}
			
