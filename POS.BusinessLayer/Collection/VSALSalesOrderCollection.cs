//
// Class	:	VSALSalesOrderCollection.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	3/19/2015 1:00:18 PM
//

using System.Runtime.Serialization;
using System.Collections.Generic;
using POS.DataLayer;

namespace POS.BusinessLayer
{
	[CollectionDataContract(Namespace = "POS.BusinessLayer")]
	public class VSALSalesOrderCollection : List<VSALSalesOrder>
	{
	}
}
			
