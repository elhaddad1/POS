//
// Class	:	INVTransferLineBatchCollection.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	2/18/2015 10:55:38 PM
//

using System.Runtime.Serialization;
using System.Collections.Generic;
using POS.DataLayer;

namespace POS.BusinessLayer
{
	[CollectionDataContract(Namespace = "POS.BusinessLayer")]
	public class INVTransferLineBatchCollection : List<INVTransferLineBatch>
	{
	}
}
			
