//
// Class	:	VUserRoleCollection.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	1/3/2015 2:37:34 AM
//

using System.Runtime.Serialization;
using System.Collections.Generic;
using POS.DataLayer;

namespace POS.BusinessLayer
{
	[CollectionDataContract(Namespace = "POS.BusinessLayer")]
	public class VUserRoleCollection : List<VUserRole>
	{
	}
}
			
