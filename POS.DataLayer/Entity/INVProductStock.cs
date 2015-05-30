//
// Class	:	INVProductStock.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:56:07 PM
//

using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Collections;
using System.Data.Common;

namespace POS.DataLayer
{
    public class ALLINVProductStockFields : INVProductStockFields
    {
        public const string StockTypeName = "StockTypeName";
        public const string ProductName = "ProductName";
        public const string ProductCode = "ProductCode";
        public const string BatchQty = "BatchQty";
        public const string BatchNumber = "BatchNumber";
        public const string ExpiryDate = "ExpiryDate";
    }
    /// <summary>
    /// Data access class for the "INVProductStock" table.
    /// </summary>
    [Serializable]
    public class INVProductStock : INVProductStockBase
    {

        #region Class Level Variables
        string _productCode;
        string _productName;
        string _stockType;
        decimal _batchQty;
        string _batcNo;
        bool _isAcceptbatch;

       


        DateTime? _expiryDate = null;


        #endregion

        #region Constants

        #endregion

        #region Constructors / Destructors

        public INVProductStock()
            : base()
        {
        }

        #endregion

        #region Properties
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
            get { return _batcNo; }
            set { _batcNo = value; }
        }
        public bool IsAcceptBatch
        {
            get { return _isAcceptbatch; }
            set { _isAcceptbatch = value; }
        }
        #endregion

        #region Methods (Public)
        public static INVProductStockCollection GetInventoryStock(int? ProductStockID, string productCode, string productName, bool? IsAcceptBatch, bool getWithBatch,int? InventoryID)
        {
            DatabaseHelper oDatabaseHelper = new DatabaseHelper();
            bool ExecutionState = false;

            // The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
            oDatabaseHelper.AddParameter("@ProductStockID", ProductStockID);
            oDatabaseHelper.AddParameter("@ProductCode", productCode);
            oDatabaseHelper.AddParameter("@ProductName", productName);
            oDatabaseHelper.AddParameter("@IsAcceptBatch", IsAcceptBatch);
            if (InventoryID != null)
            {
                oDatabaseHelper.AddParameter("@InventoryID", InventoryID); 
            }
            IDataReader dr = oDatabaseHelper.ExecuteReader("USP_GetInventoryStock", ref ExecutionState);
            INVProductStockCollection INVProductStockCollection = Fill(dr, getWithBatch);
            dr.Close();
            oDatabaseHelper.Dispose();
            return INVProductStockCollection;

        }
        public bool InsertINVProductStockWithBatch(INVProductStock iNVProductStock)
        {
            bool ExecutionState = false;
            DatabaseHelper oDatabaseHelper = new DatabaseHelper();

            oDatabaseHelper.AddParameter("@ProductID", iNVProductStock.ProductID);

            oDatabaseHelper.AddParameter("@TotalQty", iNVProductStock.TotalQty);

            oDatabaseHelper.AddParameter("@CreatedBy", iNVProductStock.CreatedBy);

            oDatabaseHelper.AddParameter("@InventoryID", iNVProductStock.InventoryID);

            oDatabaseHelper.AddParameter("@BatchNumber", iNVProductStock.BatchNo);

            oDatabaseHelper.AddParameter("@ExpiryDate", iNVProductStock.ExpiryDate);

            oDatabaseHelper.AddParameter("@BatchQty", iNVProductStock.BatchQty);

            oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);

            oDatabaseHelper.ExecuteScalar("usp_INVProductStock_InsertProductStockWithBatches", ref ExecutionState);

            oDatabaseHelper.Dispose();
            return ExecutionState;
        }
        #endregion

        #region Methods (Private)
        private static INVProductStockCollection Fill(IDataReader dr, bool getWithBatch)
        {
            INVProductStockCollection collection = new INVProductStockCollection();

            while (dr.Read())
            {
                INVProductStock obj = new INVProductStock();
                obj.ProductStockID = dr.GetInt32(dr.GetOrdinal(ALLINVProductStockFields.ProductStockID));
                obj.ProductID = dr.GetInt32(dr.GetOrdinal(ALLINVProductStockFields.ProductID));
                obj.TotalQty = dr.GetDecimal(dr.GetOrdinal(ALLINVProductStockFields.TotalQty));
                obj.StockTypeID = dr.GetInt32(dr.GetOrdinal(ALLINVProductStockFields.StockTypeID));
                obj.ProductName = dr.GetString(dr.GetOrdinal(ALLINVProductStockFields.ProductName));
                obj.StockType = dr.GetString(dr.GetOrdinal(ALLINVProductStockFields.StockTypeName));
                if (!dr.IsDBNull(dr.GetOrdinal(ALLINVProductStockFields.ProductCode)))
                {
                    obj.ProductCode = dr.GetString(dr.GetOrdinal(ALLINVProductStockFields.ProductCode));
                }
                if (dr.GetOrdinal("IsAcceptBatch") != null)
                {
                    obj.IsAcceptBatch = dr.GetBoolean(dr.GetOrdinal("IsAcceptBatch"));
                }
                if (getWithBatch)
                {
                    if (dr.GetOrdinal(ALLINVProductStockFields.BatchNumber) != null)
                    {
                        obj.BatchNo = dr.GetString(dr.GetOrdinal(ALLINVProductStockFields.BatchNumber));
                    }
                    if (dr.GetOrdinal(ALLINVProductStockFields.ExpiryDate) != null)
                    {
                        obj.ExpiryDate = dr.GetDateTime(dr.GetOrdinal(ALLINVProductStockFields.ExpiryDate));
                    }
                    if (dr.GetOrdinal(ALLINVProductStockFields.BatchQty) != null)
                    {
                        obj.BatchQty = dr.GetDecimal(dr.GetOrdinal(ALLINVProductStockFields.BatchQty));
                    }
                   
                }
                collection.Add(obj);

            }
            return collection;
        }

        #endregion

    }

}
