//
// Class	:	VSALSalesOrderPrimaryKey.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	3/19/2015 1:00:18 PM
//
	
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Specialized;
using System.Runtime.Serialization;

namespace POS.BusinessLayer
{
	[DataContract(Namespace = "POS.BusinessLayer")]
	public class VSALSalesOrderPrimaryKey
	{
		#region Data Contract (Business Object Interface To Service)
		
			[DataMember]
			public int? CustomerID {get;set;}
			
			[DataMember]
			public int? SalesLineID {get;set;}
			
			[DataMember]
			public int? SalesHeaderID {get;set;}
			
			[DataMember]
			public int? ProductID {get;set;}
			

		#endregion
	}
}

