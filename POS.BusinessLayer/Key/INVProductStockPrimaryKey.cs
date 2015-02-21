//
// Class	:	INVProductStockPrimaryKey.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	2/20/2015 7:03:51 PM
//
	
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Specialized;
using System.Runtime.Serialization;

namespace POS.BusinessLayer
{
	[DataContract(Namespace = "POS.BusinessLayer")]
	public class INVProductStockPrimaryKey
	{
		#region Data Contract (Business Object Interface To Service)
		
			[DataMember]
			public int? ProductStockID {get;set;}
			

		#endregion
	}
}

