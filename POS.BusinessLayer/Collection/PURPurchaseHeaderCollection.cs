//
// Class	:	PURPurchaseHeaderCollection.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	31/5/2015 10:35:27 PM
//

using System.Runtime.Serialization;
using System.Collections.Generic;
using POS.DataLayer;

namespace POS.BusinessLayer
{
	[CollectionDataContract(Namespace = "POS.BusinessLayer")]
	public class PURPurchaseHeaderCollection : List<PURPurchaseHeader>
	{
	}
}
			
