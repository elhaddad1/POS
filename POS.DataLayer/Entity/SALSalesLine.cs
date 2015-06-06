//
// Class	:	SALSalesLine.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:56:03 PM
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
    /// Data access class for the "SALSalesLine" table.
    /// </summary>
    [Serializable]
    public class SALSalesLine : SALSalesLineBase
    {

        #region Class Level Variables
        private DatabaseHelper oDatabaseHelper;

        private string _productNameNonDefault = null;
        #endregion

        #region Constants

        #endregion

        #region Constructors / Destructors

        public SALSalesLine()
            : base()
        {
        }

        #endregion

        #region Properties
        public string ProductName
        {
            get
            {
                return _productNameNonDefault;
            }
            set
            {

                _productNameNonDefault = value;
            }
        }
        #endregion

        #region Methods (Public)
        public int SaveTransaction(SALSalesHeader sALSalesHeader, SALSalesLineCollection sALSalesLineCollection)
        {
            oDatabaseHelper = new DatabaseHelper();
            bool ExecutionState = false;
            int salesHeaderID = -1;
            oDatabaseHelper.BeginTransaction();
            if (InsertHeader(oDatabaseHelper, sALSalesHeader, out salesHeaderID))
            {
                foreach (SALSalesLine sALSalesLine in sALSalesLineCollection)
                {
                    if (!InsertDetails(oDatabaseHelper, sALSalesLine, salesHeaderID))
                    {
                        ExecutionState = false;
                        break;
                    }
                    else
                        ExecutionState = true;
                }
                if (ExecutionState)
                    oDatabaseHelper.CommitTransaction();
                else
                    oDatabaseHelper.RollbackTransaction();
            }
            return salesHeaderID;
        }

        public bool UpdateTransaction(SALSalesHeader sALSalesHeader, SALSalesLineCollection sALSalesLineCollection)
        {
            oDatabaseHelper = new DatabaseHelper();
            bool ExecutionState = false;
            oDatabaseHelper.BeginTransaction();
            if (UpdateHeader(oDatabaseHelper, sALSalesHeader))
            {
                if (DeleteDetails(oDatabaseHelper, (int)sALSalesHeader.SalesHeaderID, (int)sALSalesHeader.SellerID))
                {
                    foreach (SALSalesLine sALSalesLine in sALSalesLineCollection)
                    {
                        if (!InsertDetails(oDatabaseHelper, sALSalesLine, (int)sALSalesHeader.SalesHeaderID))
                        {
                            ExecutionState = false;
                            break;
                        }
                        else
                            ExecutionState = true;
                    }
                    if (ExecutionState)
                        oDatabaseHelper.CommitTransaction();
                    else
                        oDatabaseHelper.RollbackTransaction();
                }
                else
                    ExecutionState = false;
            }
            else
                ExecutionState = false;
            return ExecutionState;
        }

        #endregion

        #region Methods (Private)
        private bool InsertHeader(DatabaseHelper oDatabaseHelper, SALSalesHeader sALSalesHeader, out int pK)
        {
            bool ExecutionState = false;
            oDatabaseHelper.AddParameter("@InventoryID", sALSalesHeader.InventoryID);
            
            // Pass the value of '_salesDate' as parameter 'SalesDate' of the stored procedure.

            oDatabaseHelper.AddParameter("@SalesDate", sALSalesHeader.SalesDate);
            // Pass the value of '_customerID' as parameter 'CustomerID' of the stored procedure.
            if (sALSalesHeader.CustomerID != null)
                oDatabaseHelper.AddParameter("@CustomerID", sALSalesHeader.CustomerID);
            else
                oDatabaseHelper.AddParameter("@CustomerID", DBNull.Value);
            // Pass the value of '_invoiceNumber' as parameter 'InvoiceNumber' of the stored procedure.

            oDatabaseHelper.AddParameter("@InvoiceNumber", DBNull.Value);
            // Pass the value of '_invoiceDate' as parameter 'InvoiceDate' of the stored procedure.
            if (sALSalesHeader.InvoiceDate != null)
                oDatabaseHelper.AddParameter("@InvoiceDate", sALSalesHeader.InvoiceDate);
            else
                oDatabaseHelper.AddParameter("@InvoiceDate", DBNull.Value);
            // Pass the value of '_sellerID' as parameter 'SellerID' of the stored procedure.
            if (sALSalesHeader.SellerID != null)
                oDatabaseHelper.AddParameter("@SellerID", sALSalesHeader.SellerID);
            else
                oDatabaseHelper.AddParameter("@SellerID", DBNull.Value);
            // Pass the value of '_paymentTypeID' as parameter 'PaymentTypeID' of the stored procedure.
            if (sALSalesHeader.PaymentTypeID != null)
                oDatabaseHelper.AddParameter("@PaymentTypeID", sALSalesHeader.PaymentTypeID);
            else
                oDatabaseHelper.AddParameter("@PaymentTypeID", DBNull.Value);
            // Pass the value of '_totalPrice' as parameter 'TotalPrice' of the stored procedure.
            if (sALSalesHeader.TotalPrice != null)
                oDatabaseHelper.AddParameter("@TotalPrice", sALSalesHeader.TotalPrice);
            else
                oDatabaseHelper.AddParameter("@TotalPrice", DBNull.Value);

            // Pass the value of '_totalPrice' as parameter 'TotalPrice' of the stored procedure.
            if (sALSalesHeader.FinalPrice != null)
                oDatabaseHelper.AddParameter("@FinalPrice", sALSalesHeader.FinalPrice);
            else
                oDatabaseHelper.AddParameter("@TotalPrice", DBNull.Value);
            
            // Pass the value of '_paidAmount' as parameter 'PaidAmount' of the stored procedure.
                    
            if (sALSalesHeader.PaidAmount != null)
                oDatabaseHelper.AddParameter("@PaidAmount", sALSalesHeader.PaidAmount);
            else
                oDatabaseHelper.AddParameter("@PaidAmount", DBNull.Value);
            // Pass the value of '_remainingAmount' as parameter 'RemainingAmount' of the stored procedure.
            if (sALSalesHeader.RemainingAmount != null)
                oDatabaseHelper.AddParameter("@RemainingAmount", sALSalesHeader.RemainingAmount);
            else
                oDatabaseHelper.AddParameter("@RemainingAmount", DBNull.Value);
            // Pass the value of '_lastDayToPay' as parameter 'LastDayToPay' of the stored procedure.
            if (sALSalesHeader.LastDayToPay != null)
                oDatabaseHelper.AddParameter("@LastDayToPay", sALSalesHeader.LastDayToPay);
            else
                oDatabaseHelper.AddParameter("@LastDayToPay", DBNull.Value);
            // Pass the value of '_totalDiscountAmount' as parameter 'TotalDiscountAmount' of the stored procedure.
            if (sALSalesHeader.TotalDiscountAmount != null)
                oDatabaseHelper.AddParameter("@TotalDiscountAmount", sALSalesHeader.TotalDiscountAmount);
            else
                oDatabaseHelper.AddParameter("@TotalDiscountAmount", DBNull.Value);
            // Pass the value of '_totalDiscountRatio' as parameter 'TotalDiscountRatio' of the stored procedure.
            if (sALSalesHeader.TotalDiscountRatio != null)
                oDatabaseHelper.AddParameter("@TotalDiscountRatio", sALSalesHeader.TotalDiscountRatio);
            else
                oDatabaseHelper.AddParameter("@TotalDiscountRatio", DBNull.Value);
            // Pass the value of '_isClosed' as parameter 'IsClosed' of the stored procedure.
            if (sALSalesHeader.IsClosed != null)
                oDatabaseHelper.AddParameter("@IsClosed", sALSalesHeader.IsClosed);
            else
                oDatabaseHelper.AddParameter("@IsClosed", DBNull.Value);
            // Pass the value of '_isVoid' as parameter 'IsVoid' of the stored procedure.
            if (sALSalesHeader.IsVoid != null)
                oDatabaseHelper.AddParameter("@IsVoid", sALSalesHeader.IsVoid);
            else
                oDatabaseHelper.AddParameter("@IsVoid", DBNull.Value);
            // Pass the value of '_isPrinted' as parameter 'IsPrinted' of the stored procedure.
            if (sALSalesHeader.IsPrinted != null)
                oDatabaseHelper.AddParameter("@IsPrinted", sALSalesHeader.IsPrinted);
            else
                oDatabaseHelper.AddParameter("@IsPrinted", DBNull.Value);
            // Pass the value of '_servicePrice' as parameter 'ServicePrice' of the stored procedure.
            if (sALSalesHeader.ServicePrice != null)
                oDatabaseHelper.AddParameter("@ServicePrice", sALSalesHeader.ServicePrice);
            else
                oDatabaseHelper.AddParameter("@ServicePrice", DBNull.Value);
            // Pass the value of '_taxTypeID' as parameter 'TaxTypeID' of the stored procedure.
            if (sALSalesHeader.TaxTypeID != null)
                oDatabaseHelper.AddParameter("@TaxTypeID", sALSalesHeader.TaxTypeID);
            else
                oDatabaseHelper.AddParameter("@TaxTypeID", DBNull.Value);
            // Pass the value of '_refuseReasonID' as parameter 'RefuseReasonID' of the stored procedure.
            if (sALSalesHeader.RefuseReasonID != null)
                oDatabaseHelper.AddParameter("@RefuseReasonID", sALSalesHeader.RefuseReasonID);
            else
                oDatabaseHelper.AddParameter("@RefuseReasonID", DBNull.Value);
            // Pass the value of '_createdBy' as parameter 'CreatedBy' of the stored procedure.
            if (sALSalesHeader.CreatedBy != null)
                oDatabaseHelper.AddParameter("@CreatedBy", sALSalesHeader.CreatedBy);
            else
                oDatabaseHelper.AddParameter("@CreatedBy", DBNull.Value);
            // Pass the value of '_createDate' as parameter 'CreateDate' of the stored procedure.
            if (sALSalesHeader.CreateDate != null)
                oDatabaseHelper.AddParameter("@CreateDate", sALSalesHeader.CreateDate);
            else
                oDatabaseHelper.AddParameter("@CreateDate", DBNull.Value);
            // Pass the value of '_updatedBy' as parameter 'UpdatedBy' of the stored procedure.
            if (sALSalesHeader.UpdatedBy != null)
                oDatabaseHelper.AddParameter("@UpdatedBy", sALSalesHeader.UpdatedBy);
            else
                oDatabaseHelper.AddParameter("@UpdatedBy", DBNull.Value);
            // Pass the value of '_updateDate' as parameter 'UpdateDate' of the stored procedure.
            if (sALSalesHeader.UpdateDate != null)
                oDatabaseHelper.AddParameter("@UpdateDate", sALSalesHeader.UpdateDate);
            else
                oDatabaseHelper.AddParameter("@UpdateDate", DBNull.Value);
            // Pass the value of '_isDeleted' as parameter 'IsDeleted' of the stored procedure.
            if (sALSalesHeader.IsDeleted != null)
                oDatabaseHelper.AddParameter("@IsDeleted", sALSalesHeader.IsDeleted);
            else
                oDatabaseHelper.AddParameter("@IsDeleted", DBNull.Value);
            // Pass the value of '_deletedBy' as parameter 'DeletedBy' of the stored procedure.
            if (sALSalesHeader.DeletedBy != null)
                oDatabaseHelper.AddParameter("@DeletedBy", sALSalesHeader.DeletedBy);
            else
                oDatabaseHelper.AddParameter("@DeletedBy", DBNull.Value);
            // Pass the value of '_deletDate' as parameter 'DeletDate' of the stored procedure.
            if (sALSalesHeader.DeletDate != null)
                oDatabaseHelper.AddParameter("@DeletDate", sALSalesHeader.DeletDate);
            else
                oDatabaseHelper.AddParameter("@DeletDate", DBNull.Value);
            // The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
            oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);

            try
            {
                pK = Convert.ToInt32(oDatabaseHelper.ExecuteScalar("usp_SALSalesHeader_Insert", CommandType.StoredProcedure, ConnectionState.KeepOpen, ref ExecutionState));
                //    oDatabaseHelper.Dispose();
            }
            catch (Exception ex)
            {

                throw;
            }
            return ExecutionState;
        }
        private bool InsertDetails(DatabaseHelper oDatabaseHelper, SALSalesLine sALSalesLine, int salesHeaderID)
        {
            bool ExecutionState = false;
            // Pass the value of '_salesHeaderID' as parameter 'SalesHeaderID' of the stored procedure.
            if (salesHeaderID != null)
                oDatabaseHelper.AddParameter("@SalesHeaderID", salesHeaderID);
            else
                oDatabaseHelper.AddParameter("@SalesHeaderID", DBNull.Value);
            // Pass the value of '_productID' as parameter 'ProductID' of the stored procedure.
            if (sALSalesLine.ProductID != null)
                oDatabaseHelper.AddParameter("@ProductID", sALSalesLine.ProductID);
            else
                oDatabaseHelper.AddParameter("@ProductID", DBNull.Value);
            // Pass the value of '_totalQty' as parameter 'TotalQty' of the stored procedure.
            if (sALSalesLine.TotalQty != null)
                oDatabaseHelper.AddParameter("@TotalQty", sALSalesLine.TotalQty);
            else
                oDatabaseHelper.AddParameter("@TotalQty", DBNull.Value);
            // Pass the value of '_totalBonus' as parameter 'TotalBonus' of the stored procedure.
            if (sALSalesLine.TotalBonus != null)
                oDatabaseHelper.AddParameter("@TotalBonus", sALSalesLine.TotalBonus);
            else
                oDatabaseHelper.AddParameter("@TotalBonus", DBNull.Value);
            // Pass the value of '_discountAmount' as parameter 'DiscountAmount' of the stored procedure.
            if (sALSalesLine.DiscountAmount != null)
                oDatabaseHelper.AddParameter("@DiscountAmount", sALSalesLine.DiscountAmount);
            else
                oDatabaseHelper.AddParameter("@DiscountAmount", DBNull.Value);
            // Pass the value of '_discountRatio' as parameter 'DiscountRatio' of the stored procedure.
            if (sALSalesLine.DiscountRatio != null)
                oDatabaseHelper.AddParameter("@DiscountRatio", sALSalesLine.DiscountRatio);
            else
                oDatabaseHelper.AddParameter("@DiscountRatio", DBNull.Value);
            // Pass the value of '_unitPrice' as parameter 'UnitPrice' of the stored procedure.
            if (sALSalesLine.UnitPrice != null)
                oDatabaseHelper.AddParameter("@UnitPrice", sALSalesLine.UnitPrice);
            else
                oDatabaseHelper.AddParameter("@UnitPrice", DBNull.Value);
            // Pass the value of '_createdBy' as parameter 'CreatedBy' of the stored procedure.
            if (sALSalesLine.CreatedBy != null)
                oDatabaseHelper.AddParameter("@CreatedBy", sALSalesLine.CreatedBy);
            else
                oDatabaseHelper.AddParameter("@CreatedBy", DBNull.Value);
            // Pass the value of '_createDate' as parameter 'CreateDate' of the stored procedure.
            if (sALSalesLine.CreateDate != null)
                oDatabaseHelper.AddParameter("@CreateDate", sALSalesLine.CreateDate);
            else
                oDatabaseHelper.AddParameter("@CreateDate", DBNull.Value);
            // Pass the value of '_updatedBy' as parameter 'UpdatedBy' of the stored procedure.
            if (sALSalesLine.UpdatedBy != null)
                oDatabaseHelper.AddParameter("@UpdatedBy", sALSalesLine.UpdatedBy);
            else
                oDatabaseHelper.AddParameter("@UpdatedBy", DBNull.Value);
            // Pass the value of '_updateDate' as parameter 'UpdateDate' of the stored procedure.
            if (sALSalesLine.UpdateDate != null)
                oDatabaseHelper.AddParameter("@UpdateDate", sALSalesLine.UpdateDate);
            else
                oDatabaseHelper.AddParameter("@UpdateDate", DBNull.Value);
            // Pass the value of '_isDeleted' as parameter 'IsDeleted' of the stored procedure.
            if (sALSalesLine.IsDeleted != null)
                oDatabaseHelper.AddParameter("@IsDeleted", sALSalesLine.IsDeleted);
            else
                oDatabaseHelper.AddParameter("@IsDeleted", DBNull.Value);
            // Pass the value of '_deletedBy' as parameter 'DeletedBy' of the stored procedure.
            if (sALSalesLine.DeletedBy != null)
                oDatabaseHelper.AddParameter("@DeletedBy", sALSalesLine.DeletedBy);
            else
                oDatabaseHelper.AddParameter("@DeletedBy", DBNull.Value);
            // Pass the value of '_deleteDate' as parameter 'DeleteDate' of the stored procedure.
            if (sALSalesLine.DeleteDate != null)
                oDatabaseHelper.AddParameter("@DeleteDate", sALSalesLine.DeleteDate);
            else
                oDatabaseHelper.AddParameter("@DeleteDate", DBNull.Value);
            // The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
            oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);

            oDatabaseHelper.ExecuteScalar("usp_SALSalesLine_InsertCommit", CommandType.StoredProcedure, ConnectionState.KeepOpen, ref ExecutionState);

            return ExecutionState;
        }
        private bool UpdateHeader(DatabaseHelper oDatabaseHelper, SALSalesHeader sALSalesHeader)
        {
            bool ExecutionState = false;
            // Pass the value of '_salesHeaderID' as parameter 'SalesHeaderID' of the stored procedure.
            oDatabaseHelper.AddParameter("@InventoryID", sALSalesHeader.InventoryID);
            
            oDatabaseHelper.AddParameter("@SalesHeaderID", sALSalesHeader.SalesHeaderID);
            oDatabaseHelper.AddParameter("@SalesDate", sALSalesHeader.SalesDate);
            // Pass the value of '_customerID' as parameter 'CustomerID' of the stored procedure.
            if (sALSalesHeader.CustomerID != null)
                oDatabaseHelper.AddParameter("@CustomerID", sALSalesHeader.CustomerID);
            else
                oDatabaseHelper.AddParameter("@CustomerID", DBNull.Value);
            // Pass the value of '_invoiceNumber' as parameter 'InvoiceNumber' of the stored procedure.

            oDatabaseHelper.AddParameter("@InvoiceNumber", sALSalesHeader.InvoiceNumber);
            // Pass the value of '_invoiceDate' as parameter 'InvoiceDate' of the stored procedure.
            if (sALSalesHeader.InvoiceDate != null)
                oDatabaseHelper.AddParameter("@InvoiceDate", sALSalesHeader.InvoiceDate);
            else
                oDatabaseHelper.AddParameter("@InvoiceDate", DBNull.Value);
            // Pass the value of '_sellerID' as parameter 'SellerID' of the stored procedure.
            if (sALSalesHeader.SellerID != null)
                oDatabaseHelper.AddParameter("@SellerID", sALSalesHeader.SellerID);
            else
                oDatabaseHelper.AddParameter("@SellerID", DBNull.Value);
            // Pass the value of '_paymentTypeID' as parameter 'PaymentTypeID' of the stored procedure.
            if (sALSalesHeader.PaymentTypeID != null)
                oDatabaseHelper.AddParameter("@PaymentTypeID", sALSalesHeader.PaymentTypeID);
            else
                oDatabaseHelper.AddParameter("@PaymentTypeID", DBNull.Value);
            // Pass the value of '_totalPrice' as parameter 'TotalPrice' of the stored procedure.
            if (sALSalesHeader.TotalPrice != null)
                oDatabaseHelper.AddParameter("@TotalPrice", sALSalesHeader.TotalPrice);
            else
                oDatabaseHelper.AddParameter("@TotalPrice", DBNull.Value);

            // Pass the value of 'FinalPrice' as parameter 'TotalPrice' of the stored procedure.
            if (sALSalesHeader.FinalPrice != null)
                oDatabaseHelper.AddParameter("@FinalPrice", sALSalesHeader.FinalPrice);
            else
                oDatabaseHelper.AddParameter("@TotalPrice", DBNull.Value);

            // Pass the value of '_paidAmount' as parameter 'PaidAmount' of the stored procedure.
            if (sALSalesHeader.PaidAmount != null)
                oDatabaseHelper.AddParameter("@PaidAmount", sALSalesHeader.PaidAmount);
            else
                oDatabaseHelper.AddParameter("@PaidAmount", DBNull.Value);
            // Pass the value of '_remainingAmount' as parameter 'RemainingAmount' of the stored procedure.
            if (sALSalesHeader.RemainingAmount != null)
                oDatabaseHelper.AddParameter("@RemainingAmount", sALSalesHeader.RemainingAmount);
            else
                oDatabaseHelper.AddParameter("@RemainingAmount", DBNull.Value);
            // Pass the value of '_lastDayToPay' as parameter 'LastDayToPay' of the stored procedure.
            if (sALSalesHeader.LastDayToPay != null)
                oDatabaseHelper.AddParameter("@LastDayToPay", sALSalesHeader.LastDayToPay);
            else
                oDatabaseHelper.AddParameter("@LastDayToPay", DBNull.Value);
            // Pass the value of '_totalDiscountAmount' as parameter 'TotalDiscountAmount' of the stored procedure.
            if (sALSalesHeader.TotalDiscountAmount != null)
                oDatabaseHelper.AddParameter("@TotalDiscountAmount", sALSalesHeader.TotalDiscountAmount);
            else
                oDatabaseHelper.AddParameter("@TotalDiscountAmount", DBNull.Value);
            // Pass the value of '_totalDiscountRatio' as parameter 'TotalDiscountRatio' of the stored procedure.
            if (sALSalesHeader.TotalDiscountRatio != null)
                oDatabaseHelper.AddParameter("@TotalDiscountRatio", sALSalesHeader.TotalDiscountRatio);
            else
                oDatabaseHelper.AddParameter("@TotalDiscountRatio", DBNull.Value);
            // Pass the value of '_isClosed' as parameter 'IsClosed' of the stored procedure.
            if (sALSalesHeader.IsClosed != null)
                oDatabaseHelper.AddParameter("@IsClosed", sALSalesHeader.IsClosed);
            else
                oDatabaseHelper.AddParameter("@IsClosed", DBNull.Value);
            // Pass the value of '_isVoid' as parameter 'IsVoid' of the stored procedure.
            if (sALSalesHeader.IsVoid != null)
                oDatabaseHelper.AddParameter("@IsVoid", sALSalesHeader.IsVoid);
            else
                oDatabaseHelper.AddParameter("@IsVoid", DBNull.Value);
            // Pass the value of '_isPrinted' as parameter 'IsPrinted' of the stored procedure.
            if (sALSalesHeader.IsPrinted != null)
                oDatabaseHelper.AddParameter("@IsPrinted", sALSalesHeader.IsPrinted);
            else
                oDatabaseHelper.AddParameter("@IsPrinted", DBNull.Value);
            // Pass the value of '_servicePrice' as parameter 'ServicePrice' of the stored procedure.
            if (sALSalesHeader.ServicePrice != null)
                oDatabaseHelper.AddParameter("@ServicePrice", sALSalesHeader.ServicePrice);
            else
                oDatabaseHelper.AddParameter("@ServicePrice", DBNull.Value);
            // Pass the value of '_taxTypeID' as parameter 'TaxTypeID' of the stored procedure.
            if (sALSalesHeader.TaxTypeID != null)
                oDatabaseHelper.AddParameter("@TaxTypeID", sALSalesHeader.TaxTypeID);
            else
                oDatabaseHelper.AddParameter("@TaxTypeID", DBNull.Value);
            // Pass the value of '_refuseReasonID' as parameter 'RefuseReasonID' of the stored procedure.
            if (sALSalesHeader.RefuseReasonID != null)
                oDatabaseHelper.AddParameter("@RefuseReasonID", sALSalesHeader.RefuseReasonID);
            else
                oDatabaseHelper.AddParameter("@RefuseReasonID", DBNull.Value);
            // Pass the value of '_createdBy' as parameter 'CreatedBy' of the stored procedure.
            if (sALSalesHeader.CreatedBy != null)
                oDatabaseHelper.AddParameter("@CreatedBy", sALSalesHeader.CreatedBy);
            else
                oDatabaseHelper.AddParameter("@CreatedBy", DBNull.Value);
            // Pass the value of '_createDate' as parameter 'CreateDate' of the stored procedure.
            if (sALSalesHeader.CreateDate != null)
                oDatabaseHelper.AddParameter("@CreateDate", sALSalesHeader.CreateDate);
            else
                oDatabaseHelper.AddParameter("@CreateDate", DBNull.Value);
            // Pass the value of '_updatedBy' as parameter 'UpdatedBy' of the stored procedure.
            if (sALSalesHeader.UpdatedBy != null)
                oDatabaseHelper.AddParameter("@UpdatedBy", sALSalesHeader.UpdatedBy);
            else
                oDatabaseHelper.AddParameter("@UpdatedBy", DBNull.Value);
            // Pass the value of '_updateDate' as parameter 'UpdateDate' of the stored procedure.
            if (sALSalesHeader.UpdateDate != null)
                oDatabaseHelper.AddParameter("@UpdateDate", sALSalesHeader.UpdateDate);
            else
                oDatabaseHelper.AddParameter("@UpdateDate", DBNull.Value);
            // Pass the value of '_isDeleted' as parameter 'IsDeleted' of the stored procedure.
            if (sALSalesHeader.IsDeleted != null)
                oDatabaseHelper.AddParameter("@IsDeleted", sALSalesHeader.IsDeleted);
            else
                oDatabaseHelper.AddParameter("@IsDeleted", DBNull.Value);
            // Pass the value of '_deletedBy' as parameter 'DeletedBy' of the stored procedure.
            if (sALSalesHeader.DeletedBy != null)
                oDatabaseHelper.AddParameter("@DeletedBy", sALSalesHeader.DeletedBy);
            else
                oDatabaseHelper.AddParameter("@DeletedBy", DBNull.Value);
            // Pass the value of '_deletDate' as parameter 'DeletDate' of the stored procedure.
            if (sALSalesHeader.DeletDate != null)
                oDatabaseHelper.AddParameter("@DeletDate", sALSalesHeader.DeletDate);
            else
                oDatabaseHelper.AddParameter("@DeletDate", DBNull.Value);
            // The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
            oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);

            oDatabaseHelper.ExecuteScalar("usp_SALSalesHeader_Update", CommandType.StoredProcedure, ConnectionState.KeepOpen, ref ExecutionState);

            return ExecutionState;

        }
        private bool DeleteDetails(DatabaseHelper oDatabaseHelper, int SalesHeaderID, int UserID)
        {
            bool ExecutionState = false;

            oDatabaseHelper.AddParameter("@UserID", UserID);
            oDatabaseHelper.AddParameter("@SalesHeaderID", SalesHeaderID);
            oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
            oDatabaseHelper.ExecuteScalar("usp_SALSalesLine_DeleteLines", ref ExecutionState);

            return ExecutionState;
        }
        #endregion

    }

}
