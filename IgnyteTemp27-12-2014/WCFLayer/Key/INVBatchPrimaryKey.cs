//
// Class	:	INVBatchPrimaryKey.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:56:18 PM
//
	
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Specialized;
using System.Runtime.Serialization;

namespace POS.BusinessLayer
{
	[DataContract(Namespace = "POS.BusinessLayer")]
	public class INVBatchPrimaryKey
	{
		#region Data Contract (Business Object Interface To Service)
		
			[DataMember]
			public int? BatchID {get;set;}
			

		#endregion
	}
}

