//
// Class	:	BDCustomerAccountCollection.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	6/13/2015 10:16:23 AM
//

using System.Runtime.Serialization;
using System.Collections.Generic;
using POS.DataLayer;

namespace POS.BusinessLayer
{
	[CollectionDataContract(Namespace = "POS.BusinessLayer")]
	public class BDCustomerAccountCollection : List<BDCustomerAccount>
	{
	}
}
			
