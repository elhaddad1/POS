//
// Class	:	INVTakingInventoryLineCollection.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	27/4/2015 7:28:58 PM
//

using System.Runtime.Serialization;
using System.Collections.Generic;
using POS.DataLayer;

namespace POS.BusinessLayer
{
	[CollectionDataContract(Namespace = "POS.BusinessLayer")]
	public class INVTakingInventoryLineCollection : List<INVTakingInventoryLine>
	{
	}
}
			
