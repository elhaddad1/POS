//
// Class	:	INVProductStock.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:56:08 PM
//
using System;
using System.Runtime.Serialization;
using POS.DataLayer;

namespace POS.BusinessLayer
{

    /// <summary>
    /// This class describes the attributes of a INVProductStock and is the public interface for this service.
    /// </summary>
    [DataContract(Namespace = "POS.BusinessLayer")]
    public class INVProductStock : INVProductStockBase
    {
        string _productCode;
        string _productName;
        string _stockType;
        decimal _batchQty;
        string _batchNo;


        DateTime? _expiryDate = null;
        public string ProductCode
        {
            get { return _productCode; }
            set { _productCode = value; }
        }
        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }
        public string StockType
        {
            get { return _stockType; }
            set { _stockType = value; }
        }
        public decimal BatchQty
        {
            get { return _batchQty; }
            set { _batchQty = value; }
        }
        public DateTime? ExpiryDate
        {
            get { return _expiryDate; }
            set { _expiryDate = value; }
        }
        public string BatchNo
        {
            get { return _batchNo; }
            set { _batchNo = value; }
        }
    }
}

