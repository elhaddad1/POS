//
// Enum		:	EnumTypeOperation.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	12/26/2014 2:45:51 AM
//

using System.Collections;

namespace DAPOS
{
	/// <summary>
	/// Enumeration of the types of operations
	/// </summary>
	public enum TypeOperation
	{
		Like,
		Less,
		Greater,
		Equal,
		NotEqual
	}
	
	
	/// <summary>
	/// This class returns a string that match the enum TypeOperation
	/// </summary>
	public static class OperationCollection
	{
		public static readonly Hashtable Operation = new Hashtable() { { 0, "Like" }, { 1, "<" }, { 2, ">" }, { 3, "=" }, { 4, "<>" } };
	}
}

