//
// Class	:	VUserRoleBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	1/3/2015 2:37:33 AM
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
	public class VUserRoleBase
	{

		#region Data Contract (Business Object Interface To Service)

		
		[DataMember]
		public int? UserID {get;set;}

		[DataMember]
		public int? GroupID {get;set;}

		[DataMember]
		public string GroupName {get;set;}

		[DataMember]
		public string RoleName {get;set;}

		[DataMember]
		public string RolePath {get;set;}

		[DataMember]
		public int? Expr1 {get;set;}

		[DataMember]
		public string MenuButton {get;set;}

		
		#endregion
	}
}
			
