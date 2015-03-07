//
// Class	:	ADRoleBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	3/7/2015 2:36:59 PM
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
	public class ADRoleBase
	{

		#region Data Contract (Business Object Interface To Service)

		
		[DataMember]
		public int? RoleID {get;set;}

		[DataMember]
		public string RoleName {get;set;}

		[DataMember]
		public string RolePath {get;set;}

		[DataMember]
		public string MenuButton {get;set;}

		
		#endregion
	}
}
			
