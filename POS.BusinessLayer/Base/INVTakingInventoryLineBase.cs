//
// Class	:	INVTakingInventoryLineBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:55:58 PM
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
	public class INVTakingInventoryLineBase
	{

		#region Data Contract (Business Object Interface To Service)

		
		[DataMember]
		public int? TakingLineID {get;set;}

		[DataMember]
		public int? TakingHeaderID {get;set;}

		[DataMember]
		public int? ProductID {get;set;}

		[DataMember]
		public decimal? ActualQty {get;set;}

		[DataMember]
		public decimal? ExpectedQty {get;set;}

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
			
