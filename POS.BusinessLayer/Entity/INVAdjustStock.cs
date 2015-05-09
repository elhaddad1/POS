//
// Class	:	INVAdjustStock.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	3/12/2015 1:28:42 AM
//
using System;
using System.Runtime.Serialization;
using POS.DataLayer;

namespace POS.BusinessLayer
{

	/// <summary>
	/// This class describes the attributes of a INVAdjustStock and is the public interface for this service.
	/// </summary>
	[DataContract(Namespace = "POS.UserInterfaceLayer")]
	public class INVAdjustStock : INVAdjustStockBase
    {
        [DataMember]
        public string ProductName { get; set; }
        [DataMember]
        public string CreatedByName { get; set; }

        [DataMember]
        public string InventoryName { get; set; }
        [DataMember]
        public string AdjustReasonName { get; set; }
        [DataMember]
        public string StockTypeName { get; set; }


        [DataMember]
        public string OldStockTypeName { get; set; }
	}
}
			
