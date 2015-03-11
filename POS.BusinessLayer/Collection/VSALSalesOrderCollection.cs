//
// Class	:	VSALSalesOrderCollection.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	3/10/2015 5:24:26 PM
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
			
