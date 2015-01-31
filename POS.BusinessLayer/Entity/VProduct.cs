//
// Class	:	VProduct.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	1/13/2015 9:43:39 PM
//
using System;
using System.Runtime.Serialization;
using POS.DataLayer;

namespace POS.BusinessLayer
{

	/// <summary>
	/// This class describes the attributes of a VProduct and is the public interface for this service.
	/// </summary>
	[DataContract(Namespace = "POS.BusinessLayer")]
	public class VProduct : VProductBase
	{
	}
}
			
