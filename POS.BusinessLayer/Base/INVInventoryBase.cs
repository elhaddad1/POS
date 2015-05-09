//
// Class	:	INVInventoryBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	5/3/2015 10:23:05 PM
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
	public class INVInventoryBase
	{

		#region Data Contract (Business Object Interface To Service)

		
		[DataMember]
		public int? InventoryID {get;set;}

		[DataMember]
		public string InventoryName {get;set;}

		[DataMember]
		public string Notes {get;set;}

		[DataMember]
		public bool? IsBasic {get;set;}

		
		#endregion
	}
}
			
