//
// Class	:	SALSalesLineBatchBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	2/16/2015 7:27:49 PM
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
	public class SALSalesLineBatchBase
	{

		#region Data Contract (Business Object Interface To Service)

		
		[DataMember]
		public int? SalesLineBatchID {get;set;}

		[DataMember]
		public int? SalesLineID {get;set;}

		[DataMember]
		public int? BatchID {get;set;}

		[DataMember]
		public decimal? Qty {get;set;}

		
		#endregion
	}
}
			
