//
// Class	:	SALSalesReturnLinePrimaryKey.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:56:04 PM
//
	
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Specialized;
using System.Runtime.Serialization;

namespace POS.BusinessLayer
{
	[DataContract(Namespace = "POS.BusinessLayer")]
	public class SALSalesReturnLinePrimaryKey
	{
		#region Data Contract (Business Object Interface To Service)
		
			[DataMember]
			public int? SalesReturnLineID {get;set;}
			

		#endregion
	}
}

