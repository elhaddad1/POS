//
// Class	:	SALSalesHeader.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:56:13 PM
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
    /// Data access class for the "SALSalesHeader" table.
    /// </summary>
    [Serializable]
    public class SALSalesHeader : SALSalesHeaderBase
    {

        #region Class Level Variables
        private string _customerNameNonDefault = null;
        #endregion

        #region Constants

        #endregion

        #region Constructors / Destructors

        public SALSalesHeader()
            : base()
        {
        }

        #endregion

        #region Properties
        public string CustomerName
        {
            get
            {
                return _customerNameNonDefault;
            }
            set
            {

                _customerNameNonDefault = value;
            }
        }
        #endregion

        #region Methods (Public)
        public static SALSalesHeaderCollection HeaderSearch(string CustomerName, string InvoiceNumber)
        {
            DatabaseHelper oDatabaseHelper = new DatabaseHelper();
            bool ExecutionState = false;

            // Pass the specified field and its value to the stored procedure.
            oDatabaseHelper.AddParameter("@CustomerName", CustomerName);
            oDatabaseHelper.AddParameter("@InvoiceDate", null);
            oDatabaseHelper.AddParameter("@InvoiceNumber", InvoiceNumber);
            // The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
            oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);

            IDataReader dr = oDatabaseHelper.ExecuteReader("usp_SALSalesHeader_SearchByCriteria", ref ExecutionState);
            SALSalesHeaderCollection SALSalesHeaderCollection = PopulateFromReader(dr);

            dr.Close();
            oDatabaseHelper.Dispose();
            return SALSalesHeaderCollection;

        }
        public static bool DeleteOrder(int SalesHeaderID, int UserID)
        {
            DatabaseHelper oDatabaseHelper = new DatabaseHelper();
            bool ExecutionState = false;
            // Pass the value of '_deletedBy' as parameter 'DeletedBy' of the stored procedure.
            oDatabaseHelper.AddParameter("@UserID", UserID);
            oDatabaseHelper.AddParameter("@SalesHeaderID", SalesHeaderID);
            oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
            oDatabaseHelper.ExecuteScalar("usp_SALSalesHader_DeleteOrder", ref ExecutionState);
            oDatabaseHelper.Dispose();
            return ExecutionState;
        }

        public static bool CloseOrder(int SalesHeaderID, int UserID)
        {
            DatabaseHelper oDatabaseHelper = new DatabaseHelper();
            bool ExecutionState = false;
            // Pass the value of '_deletedBy' as parameter 'DeletedBy' of the stored procedure.
            oDatabaseHelper.AddParameter("@UserID", UserID);
            oDatabaseHelper.AddParameter("@SalesHeaderID", SalesHeaderID);
            oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
            oDatabaseHelper.ExecuteScalar("usp_SALSalesHader_CloseOrder", ref ExecutionState);
            oDatabaseHelper.Dispose();
            return ExecutionState;
        }

        #endregion

        #region Methods (Private)
        private static SALSalesHeaderCollection PopulateFromReader(IDataReader rdr)
        {
            SALSalesHeaderCollection sALSalesHeaderCollection = new SALSalesHeaderCollection();
            while (rdr.Read())
            {
                SALSalesHeader obj = new SALSalesHeader();
                obj.SalesHeaderID = rdr.GetInt32(rdr.GetOrdinal(SALSalesHeaderFields.SalesHeaderID));
                obj.SalesDate = rdr.GetDateTime(rdr.GetOrdinal(SALSalesHeaderFields.SalesDate));
                obj.CustomerID = rdr.GetInt32(rdr.GetOrdinal(SALSalesHeaderFields.CustomerID));

                if (!rdr.IsDBNull(rdr.GetOrdinal("CustomerName")))
                {
                    obj.CustomerName = rdr.GetString(rdr.GetOrdinal("CustomerName"));
                }
                if (!rdr.IsDBNull(rdr.GetOrdinal(SALSalesHeaderFields.InvoiceNumber)))
                {
                    obj.InvoiceNumber = rdr.GetString(rdr.GetOrdinal(SALSalesHeaderFields.InvoiceNumber));
                }

                if (!rdr.IsDBNull(rdr.GetOrdinal(SALSalesHeaderFields.InvoiceDate)))
                {
                    obj.InvoiceDate = rdr.GetDateTime(rdr.GetOrdinal(SALSalesHeaderFields.InvoiceDate));
                }

                if (!rdr.IsDBNull(rdr.GetOrdinal(SALSalesHeaderFields.SellerID)))
                {
                    obj.SellerID = rdr.GetInt32(rdr.GetOrdinal(SALSalesHeaderFields.SellerID));
                }

                if (!rdr.IsDBNull(rdr.GetOrdinal(SALSalesHeaderFields.PaymentTypeID)))
                {
                    obj.PaymentTypeID = rdr.GetInt32(rdr.GetOrdinal(SALSalesHeaderFields.PaymentTypeID));
                }

                obj.TotalPrice = rdr.GetDecimal(rdr.GetOrdinal(SALSalesHeaderFields.TotalPrice));
                obj.PaidAmount = rdr.GetDecimal(rdr.GetOrdinal(SALSalesHeaderFields.PaidAmount));
                obj.RemainingAmount = rdr.GetDecimal(rdr.GetOrdinal(SALSalesHeaderFields.RemainingAmount));
                if (!rdr.IsDBNull(rdr.GetOrdinal(SALSalesHeaderFields.LastDayToPay)))
                {
                    obj.LastDayToPay = rdr.GetDateTime(rdr.GetOrdinal(SALSalesHeaderFields.LastDayToPay));
                }

                obj.TotalDiscountAmount = rdr.GetDecimal(rdr.GetOrdinal(SALSalesHeaderFields.TotalDiscountAmount));
                obj.TotalDiscountRatio = rdr.GetDouble(rdr.GetOrdinal(SALSalesHeaderFields.TotalDiscountRatio));
                obj.IsClosed = rdr.GetBoolean(rdr.GetOrdinal(SALSalesHeaderFields.IsClosed));
                obj.IsVoid = rdr.GetBoolean(rdr.GetOrdinal(SALSalesHeaderFields.IsVoid));
                obj.IsPrinted = rdr.GetBoolean(rdr.GetOrdinal(SALSalesHeaderFields.IsPrinted));
                obj.ServicePrice = rdr.GetDecimal(rdr.GetOrdinal(SALSalesHeaderFields.ServicePrice));
                if (!rdr.IsDBNull(rdr.GetOrdinal(SALSalesHeaderFields.TaxTypeID)))
                {
                    obj.TaxTypeID = rdr.GetInt32(rdr.GetOrdinal(SALSalesHeaderFields.TaxTypeID));
                }

                if (!rdr.IsDBNull(rdr.GetOrdinal(SALSalesHeaderFields.RefuseReasonID)))
                {
                    obj.RefuseReasonID = rdr.GetInt32(rdr.GetOrdinal(SALSalesHeaderFields.RefuseReasonID));
                }

                if (!rdr.IsDBNull(rdr.GetOrdinal(SALSalesHeaderFields.CreatedBy)))
                {
                    obj.CreatedBy = rdr.GetInt32(rdr.GetOrdinal(SALSalesHeaderFields.CreatedBy));
                }

                if (!rdr.IsDBNull(rdr.GetOrdinal(SALSalesHeaderFields.CreateDate)))
                {
                    obj.CreateDate = rdr.GetDateTime(rdr.GetOrdinal(SALSalesHeaderFields.CreateDate));
                }

                if (!rdr.IsDBNull(rdr.GetOrdinal(SALSalesHeaderFields.UpdatedBy)))
                {
                    obj.UpdatedBy = rdr.GetInt32(rdr.GetOrdinal(SALSalesHeaderFields.UpdatedBy));
                }

                if (!rdr.IsDBNull(rdr.GetOrdinal(SALSalesHeaderFields.UpdateDate)))
                {
                    obj.UpdateDate = rdr.GetDateTime(rdr.GetOrdinal(SALSalesHeaderFields.UpdateDate));
                }

                obj.IsDeleted = rdr.GetBoolean(rdr.GetOrdinal(SALSalesHeaderFields.IsDeleted));
                if (!rdr.IsDBNull(rdr.GetOrdinal(SALSalesHeaderFields.DeletedBy)))
                {
                    obj.DeletedBy = rdr.GetInt32(rdr.GetOrdinal(SALSalesHeaderFields.DeletedBy));
                }

                if (!rdr.IsDBNull(rdr.GetOrdinal(SALSalesHeaderFields.DeletDate)))
                {
                    obj.DeletDate = rdr.GetDateTime(rdr.GetOrdinal(SALSalesHeaderFields.DeletDate));
                }
                sALSalesHeaderCollection.Add(obj);
            }
            return sALSalesHeaderCollection;
        }
        #endregion

    }

}
