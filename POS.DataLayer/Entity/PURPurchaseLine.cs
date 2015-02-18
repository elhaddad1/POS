//
// Class	:	PURPurchaseLine.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:56:11 PM
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
    /// Data access class for the "PURPurchaseLine" table.
    /// </summary>
    [Serializable]
    public class PURPurchaseLine : PURPurchaseLineBase
    {

        #region Class Level Variables
        private DatabaseHelper oDatabaseHelper = new DatabaseHelper();
        #endregion

        #region Constants

        #endregion

        #region Constructors / Destructors

        public PURPurchaseLine()
            : base()
        {
        }

        #endregion

        #region Properties

        #endregion

        #region Methods (Public)
        public bool InsertTransaction(PURPurchaseHeader pURPurchaseHeader, PURPurchaseLineCollection pURPurchaseLineCollection)
        {
            oDatabaseHelper = new DatabaseHelper();
            bool ExecutionState = false;
            int purchaseHeaderID;
            oDatabaseHelper.BeginTransaction();
            if (InsertHeader(oDatabaseHelper, pURPurchaseHeader, out purchaseHeaderID))
                if (InsertDetails(oDatabaseHelper))
                {
                    oDatabaseHelper.CommitTransaction(); ExecutionState = true;
                }
                else
                {
                    oDatabaseHelper.RollbackTransaction();
                    ExecutionState = false;
                }

            return ExecutionState;
        }

        #endregion

        #region Methods (Private)
        private bool InsertHeader(DatabaseHelper oDatabaseHelper, PURPurchaseHeader pURPurchaseHeader, out int pK)
        {
            bool ExecutionState = false;
            //   pK = -1;
            // Pass the value of '_purchaseDate' as parameter 'PurchaseDate' of the stored procedure.
            if (pURPurchaseHeader.PurchaseDate != null)
                oDatabaseHelper.AddParameter("@PurchaseDate", pURPurchaseHeader.PurchaseDate);
            else
                oDatabaseHelper.AddParameter("@PurchaseDate", DBNull.Value);
            // Pass the value of '_paymentTypeID' as parameter 'PaymentTypeID' of the stored procedure.
            if (pURPurchaseHeader.PaymentTypeID != null)
                oDatabaseHelper.AddParameter("@PaymentTypeID", pURPurchaseHeader.PaymentTypeID);
            else
                oDatabaseHelper.AddParameter("@PaymentTypeID", DBNull.Value);
            // Pass the value of '_supplierID' as parameter 'SupplierID' of the stored procedure.
            if (pURPurchaseHeader.SupplierID != null)
                oDatabaseHelper.AddParameter("@SupplierID", pURPurchaseHeader.SupplierID);
            else
                oDatabaseHelper.AddParameter("@SupplierID", DBNull.Value);
            // Pass the value of '_invoiceNumber' as parameter 'InvoiceNumber' of the stored procedure.
            if (pURPurchaseHeader.InvoiceNumber != null)
                oDatabaseHelper.AddParameter("@InvoiceNumber", pURPurchaseHeader.InvoiceNumber);
            else
                oDatabaseHelper.AddParameter("@InvoiceNumber", DBNull.Value);
            // Pass the value of '_createDate' as parameter 'CreateDate' of the stored procedure.
            if (pURPurchaseHeader.CreateDate != null)
                oDatabaseHelper.AddParameter("@CreateDate", pURPurchaseHeader.CreateDate);
            else
                oDatabaseHelper.AddParameter("@CreateDate", DBNull.Value);
            // Pass the value of '_createdBy' as parameter 'CreatedBy' of the stored procedure.
            if (pURPurchaseHeader.CreatedBy != null)
                oDatabaseHelper.AddParameter("@CreatedBy", pURPurchaseHeader.CreatedBy);
            else
                oDatabaseHelper.AddParameter("@CreatedBy", DBNull.Value);
            // Pass the value of '_updateDate' as parameter 'updateDate' of the stored procedure.
            if (pURPurchaseHeader.updateDate != null)
                oDatabaseHelper.AddParameter("@updateDate", pURPurchaseHeader.updateDate);
            else
                oDatabaseHelper.AddParameter("@updateDate", DBNull.Value);
            // Pass the value of '_updatedBy' as parameter 'UpdatedBy' of the stored procedure.
            if (pURPurchaseHeader.UpdatedBy != null)
                oDatabaseHelper.AddParameter("@UpdatedBy", pURPurchaseHeader.UpdatedBy);
            else
                oDatabaseHelper.AddParameter("@UpdatedBy", DBNull.Value);
            // Pass the value of '_isDeleted' as parameter 'IsDeleted' of the stored procedure.
            if (pURPurchaseHeader.IsDeleted != null)
                oDatabaseHelper.AddParameter("@IsDeleted", pURPurchaseHeader.IsDeleted);
            else
                oDatabaseHelper.AddParameter("@IsDeleted", DBNull.Value);
            // Pass the value of '_deleteDate' as parameter 'DeleteDate' of the stored procedure.
            if (pURPurchaseHeader.DeleteDate != null)
                oDatabaseHelper.AddParameter("@DeleteDate", pURPurchaseHeader.DeleteDate);
            else
                oDatabaseHelper.AddParameter("@DeleteDate", DBNull.Value);
            // Pass the value of '_totalPrice' as parameter 'TotalPrice' of the stored procedure.
            if (pURPurchaseHeader.TotalPrice != null)
                oDatabaseHelper.AddParameter("@TotalPrice", pURPurchaseHeader.TotalPrice);
            else
                oDatabaseHelper.AddParameter("@TotalPrice", DBNull.Value);
            // Pass the value of '_servicePrice' as parameter 'ServicePrice' of the stored procedure.
            if (pURPurchaseHeader.ServicePrice != null)
                oDatabaseHelper.AddParameter("@ServicePrice", pURPurchaseHeader.ServicePrice);
            else
                oDatabaseHelper.AddParameter("@ServicePrice", DBNull.Value);
            // Pass the value of '_paidAmount' as parameter 'PaidAmount' of the stored procedure.
            if (pURPurchaseHeader.PaidAmount != null)
                oDatabaseHelper.AddParameter("@PaidAmount", pURPurchaseHeader.PaidAmount);
            else
                oDatabaseHelper.AddParameter("@PaidAmount", DBNull.Value);
            // Pass the value of '_isClosed' as parameter 'IsClosed' of the stored procedure.
            if (pURPurchaseHeader.IsClosed != null)
                oDatabaseHelper.AddParameter("@IsClosed", pURPurchaseHeader.IsClosed);
            else
                oDatabaseHelper.AddParameter("@IsClosed", DBNull.Value);
            // Pass the value of '_isVoid' as parameter 'IsVoid' of the stored procedure.
            if (pURPurchaseHeader.IsVoid != null)
                oDatabaseHelper.AddParameter("@IsVoid", pURPurchaseHeader.IsVoid);
            else
                oDatabaseHelper.AddParameter("@IsVoid", DBNull.Value);
            // Pass the value of '_isPrinted' as parameter 'IsPrinted' of the stored procedure.
            if (pURPurchaseHeader.IsPrinted != null)
                oDatabaseHelper.AddParameter("@IsPrinted", pURPurchaseHeader.IsPrinted);
            else
                oDatabaseHelper.AddParameter("@IsPrinted", DBNull.Value);
            // Pass the value of '_refuseReasonID' as parameter 'RefuseReasonID' of the stored procedure.
            if (pURPurchaseHeader.RefuseReasonID != null)
                oDatabaseHelper.AddParameter("@RefuseReasonID", pURPurchaseHeader.RefuseReasonID);
            else
                oDatabaseHelper.AddParameter("@RefuseReasonID", DBNull.Value);
            // Pass the value of '_totalDiscountAmount' as parameter 'TotalDiscountAmount' of the stored procedure.
            if (pURPurchaseHeader.TotalDiscountAmount != null)
                oDatabaseHelper.AddParameter("@TotalDiscountAmount", pURPurchaseHeader.TotalDiscountAmount);
            else
                oDatabaseHelper.AddParameter("@TotalDiscountAmount", DBNull.Value);
            // Pass the value of '_totalDiscountRatio' as parameter 'TotalDiscountRatio' of the stored procedure.
            if (pURPurchaseHeader.TotalDiscountRatio != null)
                oDatabaseHelper.AddParameter("@TotalDiscountRatio", pURPurchaseHeader.TotalDiscountRatio);
            else
                oDatabaseHelper.AddParameter("@TotalDiscountRatio", DBNull.Value);
            // Pass the value of '_taxTypeID' as parameter 'TaxTypeID' of the stored procedure.
            if (pURPurchaseHeader.TaxTypeID != null)
                oDatabaseHelper.AddParameter("@TaxTypeID", pURPurchaseHeader.TaxTypeID);
            else
                oDatabaseHelper.AddParameter("@TaxTypeID", DBNull.Value);
            // Pass the value of '_renainingAmount' as parameter 'RenainingAmount' of the stored procedure.
            if (pURPurchaseHeader.RenainingAmount != null)
                oDatabaseHelper.AddParameter("@RenainingAmount", pURPurchaseHeader.RenainingAmount);
            else
                oDatabaseHelper.AddParameter("@RenainingAmount", DBNull.Value);
            // Pass the value of '_lastDayToPay' as parameter 'LastDayToPay' of the stored procedure.
            if (pURPurchaseHeader.LastDayToPay != null)
                oDatabaseHelper.AddParameter("@LastDayToPay", pURPurchaseHeader.LastDayToPay);
            else
                oDatabaseHelper.AddParameter("@LastDayToPay", DBNull.Value);
            // Pass the value of '_deletedBy' as parameter 'DeletedBy' of the stored procedure.
            if (pURPurchaseHeader.DeletedBy != null)
                oDatabaseHelper.AddParameter("@DeletedBy", pURPurchaseHeader.DeletedBy);
            else
                oDatabaseHelper.AddParameter("@DeletedBy", DBNull.Value);
            // Pass the value of '_notes' as parameter 'Notes' of the stored procedure.
            if (pURPurchaseHeader.Notes != null)
                oDatabaseHelper.AddParameter("@Notes", pURPurchaseHeader.Notes);
            else
                oDatabaseHelper.AddParameter("@Notes", DBNull.Value);
            // The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
            oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);

            pK = (int)oDatabaseHelper.ExecuteScalar("gsp_PURPurchaseHeader_Insert", CommandType.StoredProcedure, ConnectionState.KeepOpen, ref ExecutionState);
            //  oDatabaseHelper.Dispose();
            return ExecutionState;

        }

        private bool InsertDetails(DatabaseHelper oDatabaseHelper)
        { return false; }
        #endregion

    }

}
