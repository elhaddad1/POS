//
// Class	:	VPurchaseReturnHeaderPrimaryKey.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	11/4/2015 9:57:48 PM
//
	
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Specialized;
using System.Runtime.Serialization;

namespace POS.BusinessLayer
{
	[DataContract(Namespace = "POS.BusinessLayer")]
	public class VPurchaseReturnHeaderPrimaryKey
	{
		#region Data Contract (Business Object Interface To Service)
		
			[DataMember]
			public int? PurchaseReturnID {get;set;}
			
			[DataMember]
			public int? PurcaseHeaderID {get;set;}
			

		#endregion
	}
}

