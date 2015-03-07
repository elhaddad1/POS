//
// Class	:	INVTakingInventoryLineBatchBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	3/7/2015 2:37:29 PM
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
	public class INVTakingInventoryLineBatchBase
	{

		#region Data Contract (Business Object Interface To Service)

		
		[DataMember]
		public int? TakingLineBatchID {get;set;}

		[DataMember]
		public int? TakingLineID {get;set;}

		[DataMember]
		public int? BatchID {get;set;}

		
		#endregion
	}
}
			
