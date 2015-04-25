//
// Class	:	VPURPurchaseOrder.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	11/4/2015 9:57:47 PM
//
using System;
using System.Runtime.Serialization;
using POS.DataLayer;

namespace POS.BusinessLayer
{

	/// <summary>
	/// This class describes the attributes of a VPURPurchaseOrder and is the public interface for this service.
	/// </summary>
	[DataContract(Namespace = "POS.BusinessLayer")]
	public class VPURPurchaseOrder : VPURPurchaseOrderBase
	{
	}
}
			
