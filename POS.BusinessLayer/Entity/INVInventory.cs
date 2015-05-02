//
// Class	:	INVInventory.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	5/2/2015 2:22:12 AM
//
using System;
using System.Runtime.Serialization;
using POS.DataLayer;

namespace POS.BusinessLayer
{

	/// <summary>
	/// This class describes the attributes of a INVInventory and is the public interface for this service.
	/// </summary>
	[DataContract(Namespace = "POS.BusinessLayer")]
	public class INVInventory : INVInventoryBase
	{
	}
}
			
