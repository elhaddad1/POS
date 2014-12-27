//
// Class	:	INVAdjustStockReasonPrimaryKey.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:55:53 PM
//
	
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Specialized;
using System.Runtime.Serialization;

namespace POS.BusinessLayer
{
	[DataContract(Namespace = "POS.BusinessLayer")]
	public class INVAdjustStockReasonPrimaryKey
	{
		#region Data Contract (Business Object Interface To Service)
		
			[DataMember]
			public int? AdjustStockReasonID {get;set;}
			

		#endregion
	}
}

