//
// Class	:	VSALSalesOrder.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	3/10/2015 5:24:25 PM
//
using System;
using System.Runtime.Serialization;
using POS.DataLayer;

namespace POS.BusinessLayer
{

	/// <summary>
	/// This class describes the attributes of a VSALSalesOrder and is the public interface for this service.
	/// </summary>
	[DataContract(Namespace = "POS.BusinessLayer")]
	public class VSALSalesOrder : VSALSalesOrderBase
	{
	}
}
			
