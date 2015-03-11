//
// Class	:	VSalesReturnHeaderBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	3/9/2015 4:39:22 PM
//
using System;
using System.Runtime.Serialization;
using POS.DataLayer;

namespace POS.BusinessLayer
{
	/// <summary>
	/// Class for the properties of the object
	/// </summary>
	[DataContract(Namespace = "POS.BusinessLayer")]
	public class VSalesReturnHeaderBase
	{

		#region Data Contract (Business Object Interface To Service)

		
		[DataMember]
		public int? SlaesReturnHeaderID {get;set;}

		[DataMember]
		public DateTime? ReturnDate {get;set;}

		[DataMember]
		public bool? IsClosed {get;set;}

		[DataMember]
		public string InvoiceNumber {get;set;}

		[DataMember]
		public string CustomerName {get;set;}

		[DataMember]
		public int? SalesHeaderID {get;set;}

		
		#endregion
	}
}
			
