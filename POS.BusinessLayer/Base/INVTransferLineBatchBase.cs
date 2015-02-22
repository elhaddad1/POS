//
// Class	:	INVTransferLineBatchBase.cs
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
	public class INVTransferLineBatchBase
	{

		#region Data Contract (Business Object Interface To Service)

		
		[DataMember]
		public int? TransferLineBatchID {get;set;}

		[DataMember]
		public int? TransferLineID {get;set;}

		[DataMember]
		public int? BatchID {get;set;}

		[DataMember]
		public decimal? Qty {get;set;}

		
		#endregion
	}
}
			
