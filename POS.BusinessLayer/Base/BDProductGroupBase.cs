//
// Class	:	BDProductGroupBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:55:56 PM
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
	public class BDProductGroupBase
	{

		#region Data Contract (Business Object Interface To Service)

		
		[DataMember]
		public int? ProductGroupID {get;set;}

		[DataMember]
		public string ProductGroupName {get;set;}

		[DataMember]
		public string Notes {get;set;}

		
		#endregion
	}
}
			
