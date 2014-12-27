//
// Class	:	INVTransferHeaderBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:55:57 PM
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
	public class INVTransferHeaderBase
	{

		#region Data Contract (Business Object Interface To Service)

		
		[DataMember]
		public int? INVTransferHeaderID {get;set;}

		[DataMember]
		public DateTime? TransferDate {get;set;}

		[DataMember]
		public int? FromInventoryID {get;set;}

		[DataMember]
		public int? ToInventoryID {get;set;}

		[DataMember]
		public int? CreatedBy {get;set;}

		[DataMember]
		public DateTime? CreateDate {get;set;}

		[DataMember]
		public int? UpdatedBy {get;set;}

		[DataMember]
		public bool? IsDeleted {get;set;}

		[DataMember]
		public int? DeletedBy {get;set;}

		[DataMember]
		public DateTime? DeletedDate {get;set;}

		
		#endregion
	}
}
			
