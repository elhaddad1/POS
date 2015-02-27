//
// Class	:	BDSupplierAccount.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	2/27/2015 12:29:26 PM
//
using System;
using System.Runtime.Serialization;
using POS.DataLayer;

namespace POS.BusinessLayer
{

	/// <summary>
	/// This class describes the attributes of a BDSupplierAccount and is the public interface for this service.
	/// </summary>
	[DataContract(Namespace = "POS.BusinessLayer")]
	public class BDSupplierAccount : BDSupplierAccountBase
	{
	}
}
			
