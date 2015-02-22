//
// Class	:	INVTransferLineBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	2/22/2015 7:27:21 PM
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
	public class INVTransferLineBase
	{

		#region Data Contract (Business Object Interface To Service)

		
		[DataMember]
		public int? TransferLineID {get;set;}

		[DataMember]
		public int? TransferHeaderID {get;set;}

		[DataMember]
		public int? ProductID {get;set;}

		[DataMember]
		public decimal? Qty {get;set;}

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
		public DateTime? DeletedDate {get;set;}

		
		#endregion
	}
}
			
