//
// Class	:	ADUserBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	3/7/2015 2:37:27 PM
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
	public class ADUserBase
	{

		#region Data Contract (Business Object Interface To Service)

		
		[DataMember]
		public int? UserID {get;set;}

		[DataMember]
		public string UserFullName {get;set;}

		[DataMember]
		public string UserName {get;set;}

		[DataMember]
		public string Password {get;set;}

		[DataMember]
		public int? GroupID {get;set;}

		[DataMember]
		public string Email {get;set;}

		[DataMember]
		public string Address {get;set;}

		[DataMember]
		public string Phone {get;set;}

		[DataMember]
		public string Mobile {get;set;}

		
		#endregion
	}
}
			
