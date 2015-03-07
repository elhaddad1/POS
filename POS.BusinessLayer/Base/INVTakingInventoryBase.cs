//
// Class	:	INVTakingInventoryBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	3/7/2015 2:37:12 PM
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
	public class INVTakingInventoryBase
	{

		#region Data Contract (Business Object Interface To Service)

		
		[DataMember]
		public int? TakingHeaderID {get;set;}

		[DataMember]
		public DateTime? TakingDate {get;set;}

		[DataMember]
		public string TakingName {get;set;}

		[DataMember]
		public int? CreatedBy {get;set;}

		[DataMember]
		public DateTime? CreatedDate {get;set;}

		[DataMember]
		public int? UpdatedBy {get;set;}

		[DataMember]
		public DateTime? UpdateDate {get;set;}

		[DataMember]
		public bool? IsDeleted {get;set;}

		[DataMember]
		public int? DeletedBy {get;set;}

		[DataMember]
		public DateTime? DeletedDate {get;set;}

		[DataMember]
		public string Notes {get;set;}

		[DataMember]
		public int? InventoryID {get;set;}

		
		#endregion
	}
}
			
