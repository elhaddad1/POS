//
// Class	:	BDSupplier.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:55:54 PM
//
using System;
using System.Runtime.Serialization;
using POS.DataLayer;

namespace POS.BusinessLayer
{

	/// <summary>
	/// This class describes the attributes of a BDSupplier and is the public interface for this service.
	/// </summary>
	[DataContract(Namespace = "POS.BusinessLayer")]
	public class BDSupplier : BDSupplierBase
	{
	}
}
			
