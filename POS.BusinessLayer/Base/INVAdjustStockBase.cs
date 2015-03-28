//
// Class	:	INVAdjustStockBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	3/12/2015 1:28:42 AM
//
using System;
using System.Runtime.Serialization;
using POS.DataLayer;

namespace POS.BusinessLayer
{
	/// <summary>
	/// Class for the properties of the object
	/// </summary>
	[DataContract(Namespace = "POS.UserInterfaceLayer")]
	public class INVAdjustStockBase
	{

		#region Data Contract (Business Object Interface To Service)

		
		[DataMember]
		public int? AdjustStockID {get;set;}

		[DataMember]
		public int? ProductID {get;set;}

		[DataMember]
		public int? BatchID {get;set;}

		[DataMember]
		public decimal? Qty {get;set;}

		[DataMember]
		public int? AdjustReasonID {get;set;}

		[DataMember]
		public int? CreatedBy {get;set;}

		[DataMember]
		public DateTime? CredateDate {get;set;}

		[DataMember]
		public int? UpdatedBy {get;set;}

		[DataMember]
		public DateTime? UpdateDate {get;set;}

		[DataMember]
		public int? StockTypeID {get;set;}

		[DataMember]
		public int? InventoryID {get;set;}

		
		#endregion
	}
}
			
