//
// Class	:	VSalesReturnHeaderCollection.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	3/9/2015 4:39:23 PM
//

using System.Runtime.Serialization;
using System.Collections.Generic;
using POS.DataLayer;

namespace POS.BusinessLayer
{
	[CollectionDataContract(Namespace = "POS.BusinessLayer")]
	public class VSalesReturnHeaderCollection : List<VSalesReturnHeader>
	{
	}
}
			
