//
// Class	:	INVTakingInventoryLine.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:55:58 PM
//
using System;
using System.Runtime.Serialization;
using POS.DataLayer;

namespace POS.BusinessLayer
{

	/// <summary>
	/// This class describes the attributes of a INVTakingInventoryLine and is the public interface for this service.
	/// </summary>
	[DataContract(Namespace = "POS.BusinessLayer")]
	public class INVTakingInventoryLine : INVTakingInventoryLineBase
	{
        int? _takingLineBatch;
        string _productName;
        bool? _isAcceptBatch;
        string _stockTypeName;
        string _batchNumber;
        DateTime? _expiryDate;

        public int? TakingLineBatchID
        {
            get { return _takingLineBatch; }
            set { _takingLineBatch = value; }
        }
        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }
        public bool? IsAcceptBatch
        {
            get { return _isAcceptBatch; }
            set { _isAcceptBatch = value; }
        }
        public string StockTypeName
        {
            get { return _stockTypeName; }
            set { _stockTypeName = value; }
        }
        public string BatchNumber
        {
            get { return _batchNumber; }
            set { _batchNumber = value; }
        }
        public DateTime? ExpiryDate
        {
            get { return _expiryDate; }
            set { _expiryDate = value; }
        }
	}
}
			
