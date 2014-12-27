//
// Class	:	PURPurchaseHeader.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:56:07 PM
//
using System;
using System.Runtime.Serialization;
using POS.DataLayer;

namespace POS.BusinessLayer
{

	/// <summary>
	/// This class describes the attributes of a PURPurchaseHeader and is the public interface for this service.
	/// </summary>
	[DataContract(Namespace = "POS.BusinessLayer")]
	public class PURPurchaseHeader : PURPurchaseHeaderBase
	{
	}
}
			
