//
// Class	:	VPurchaseReturnHeaderCollection.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	11/4/2015 9:57:48 PM
//

using System.Runtime.Serialization;
using System.Collections.Generic;
using POS.DataLayer;

namespace POS.BusinessLayer
{
	[CollectionDataContract(Namespace = "POS.BusinessLayer")]
	public class VPurchaseReturnHeaderCollection : List<VPurchaseReturnHeader>
	{
	}
}
			
