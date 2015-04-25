//
// Class	:	PURPurchaseLine.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	2/24/2015 10:40:54 AM
//
using System;
using System.Runtime.Serialization;
using POS.DataLayer;

namespace POS.BusinessLayer
{

	/// <summary>
	/// This class describes the attributes of a PURPurchaseLine and is the public interface for this service.
	/// </summary>
	[DataContract(Namespace = "POS.BusinessLayer")]
	public class PURPurchaseLine : PURPurchaseLineBase
	{
        [DataMember]
        public string ProductName { get; set; }
        public string BatchNumber { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public decimal BatchQty { get; set; }
        public bool IsAcceptBatch { get; set; }
        public int IsBatch { get; set; }
          public int PurchaseLineBatchID { get; set; }
	}
}
			
