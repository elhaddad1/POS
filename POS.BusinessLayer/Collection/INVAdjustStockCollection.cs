//
// Class	:	INVAdjustStockCollection.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	3/12/2015 1:28:42 AM
//

using System.Runtime.Serialization;
using System.Collections.Generic;
using POS.DataLayer;

namespace POS.BusinessLayer
{
	[CollectionDataContract(Namespace = "POS.UserInterfaceLayer")]
	public class INVAdjustStockCollection : List<INVAdjustStock>
	{
	}
}
			
