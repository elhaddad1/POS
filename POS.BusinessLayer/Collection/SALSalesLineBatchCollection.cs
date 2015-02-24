//
// Class	:	SALSalesLineBatchCollection.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	2/24/2015 2:25:53 AM
//

using System.Runtime.Serialization;
using System.Collections.Generic;
using POS.DataLayer;

namespace POS.BusinessLayer
{
	[CollectionDataContract(Namespace = "POS.BusinessLayer")]
	public class SALSalesLineBatchCollection : List<SALSalesLineBatch>
	{
	}
}
			
