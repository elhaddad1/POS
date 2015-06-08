//
// Class	:	VSALSalesOrder.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	3/10/2015 5:24:25 PM
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

    /// <summary>
    /// Data access class for the "VSALSalesOrder" table.
    /// </summary>
    [Serializable]
    public class VSALSalesOrder : VSALSalesOrderBase
    {

        #region Class Level Variables

        #endregion

        #region Constants

        #endregion

        #region Constructors / Destructors

        public VSALSalesOrder()
            : base()
        {
        }

        #endregion

        #region Properties

        #endregion

        #region Methods (Public)
        public static VSALSalesOrderCollection SelectByInvoiceNumber(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
        {
            DatabaseHelper oDatabaseHelper = new DatabaseHelper();
            bool ExecutionState = false;

            // Pass the specified field and its value to the stored procedure.
            oDatabaseHelper.AddParameter("@Field", field);
            oDatabaseHelper.AddParameter("@Value", fieldValue);
            oDatabaseHelper.AddParameter("@Value2", fieldValue2);
            oDatabaseHelper.AddParameter("@Operation", OperationCollection.Operation[(int)typeOperation]);

            // The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
            oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);

            IDataReader dr = oDatabaseHelper.ExecuteReader("gsp_VSALSalesOrder_SelectByField", ref ExecutionState);
            VSALSalesOrderCollection VSALSalesOrderCollection = PopulateObjectsFromReader(dr);
            dr.Close();
            oDatabaseHelper.Dispose();
            return VSALSalesOrderCollection;

        }
        #endregion

        #region Methods (Private)
        private static VSALSalesOrderCollection PopulateObjectsFromReader(IDataReader rdr)
        {
            VSALSalesOrderCollection list = new VSALSalesOrderCollection();

            while (rdr.Read())
            {
                VSALSalesOrder obj = new VSALSalesOrder();
                PopulateObjectFromReader(obj, rdr);
                list.Add(obj);
            }
            return list;

        }
        private static void PopulateObjectFromReader(VSALSalesOrderBase obj, IDataReader rdr)
        {

            obj.CustomerID = rdr.GetInt32(rdr.GetOrdinal(VSALSalesOrderFields.CustomerID));
            obj.CustomerName = rdr.GetString(rdr.GetOrdinal(VSALSalesOrderFields.CustomerName));
            if (!rdr.IsDBNull(rdr.GetOrdinal(VSALSalesOrderFields.Qty)))
            {
                obj.Qty = rdr.GetDecimal(rdr.GetOrdinal(VSALSalesOrderFields.Qty));
            }

            obj.SalesLineID = rdr.GetInt32(rdr.GetOrdinal(VSALSalesOrderFields.SalesLineID));
            obj.TotalQty = rdr.GetDecimal(rdr.GetOrdinal(VSALSalesOrderFields.TotalQty));
            obj.UnitPrice = rdr.GetDecimal(rdr.GetOrdinal(VSALSalesOrderFields.UnitPrice));
            if (!rdr.IsDBNull(rdr.GetOrdinal(VSALSalesOrderFields.BatchNumber)))
            {
                obj.BatchNumber = rdr.GetString(rdr.GetOrdinal(VSALSalesOrderFields.BatchNumber));
            }
            if (!rdr.IsDBNull(rdr.GetOrdinal(VSALSalesOrderFields.ExpiryDate)))
            {
                obj.ExpiryDate = rdr.GetDateTime(rdr.GetOrdinal(VSALSalesOrderFields.ExpiryDate));
            }
            if (!rdr.IsDBNull(rdr.GetOrdinal(VSALSalesOrderFields.TaxValue)))
            {
                obj.TaxValue = rdr.GetDecimal(rdr.GetOrdinal(VSALSalesOrderFields.TaxValue));
            }

            obj.SalesHeaderID = rdr.GetInt32(rdr.GetOrdinal(VSALSalesOrderFields.SalesHeaderID));
            obj.SalesDate = rdr.GetDateTime(rdr.GetOrdinal(VSALSalesOrderFields.SalesDate));
            if (!rdr.IsDBNull(rdr.GetOrdinal(VSALSalesOrderFields.InvoiceNumber)))
            {
                obj.InvoiceNumber = rdr.GetString(rdr.GetOrdinal(VSALSalesOrderFields.InvoiceNumber));
            }

            if (!rdr.IsDBNull(rdr.GetOrdinal(VSALSalesOrderFields.InvoiceDate)))
            {
                obj.InvoiceDate = rdr.GetDateTime(rdr.GetOrdinal(VSALSalesOrderFields.InvoiceDate));
            }

            if (!rdr.IsDBNull(rdr.GetOrdinal(VSALSalesOrderFields.PaymentTypeID)))
            {
                obj.PaymentTypeID = rdr.GetInt32(rdr.GetOrdinal(VSALSalesOrderFields.PaymentTypeID));
            }

            obj.TotalDiscountRatio = rdr.GetDouble(rdr.GetOrdinal(VSALSalesOrderFields.TotalDiscountRatio));
            if (!rdr.IsDBNull(rdr.GetOrdinal(VSALSalesOrderFields.TaxTypeName)))
            {
                obj.TaxTypeName = rdr.GetString(rdr.GetOrdinal(VSALSalesOrderFields.TaxTypeName));
            }

            obj.IsClosed = rdr.GetBoolean(rdr.GetOrdinal(VSALSalesOrderFields.IsClosed));
            obj.IsVoid = rdr.GetBoolean(rdr.GetOrdinal(VSALSalesOrderFields.IsVoid));
            if (!rdr.IsDBNull(rdr.GetOrdinal(VSALSalesOrderFields.FinalPrice)))
            {
                obj.FinalPrice = rdr.GetDecimal(rdr.GetOrdinal(VSALSalesOrderFields.FinalPrice));
            }

            if (!rdr.IsDBNull(rdr.GetOrdinal(VSALSalesOrderFields.ChequeNumber)))
            {
                obj.ChequeNumber = rdr.GetInt32(rdr.GetOrdinal(VSALSalesOrderFields.ChequeNumber));
            }

            obj.ProductName = rdr.GetString(rdr.GetOrdinal(VSALSalesOrderFields.ProductName));
            if (!rdr.IsDBNull(rdr.GetOrdinal(VSALSalesOrderFields.ProductCode)))
            {
                obj.ProductCode = rdr.GetString(rdr.GetOrdinal(VSALSalesOrderFields.ProductCode));
            }

            obj.IsAcceptBatch = rdr.GetBoolean(rdr.GetOrdinal(VSALSalesOrderFields.IsAcceptBatch));
            obj.UserFullName = rdr.GetString(rdr.GetOrdinal(VSALSalesOrderFields.UserFullName));
            obj.ProductID = rdr.GetInt32(rdr.GetOrdinal(VSALSalesOrderFields.ProductID));

        }

        #endregion

    }

}
