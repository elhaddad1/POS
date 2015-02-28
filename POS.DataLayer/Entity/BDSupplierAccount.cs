//
// Class	:	BDSupplierAccount.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	2/27/2015 12:29:26 PM
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
	/// Data access class for the "BDSupplierAccounts" table.
	/// </summary>
    [Serializable]
    public class BDSupplierAccount : BDSupplierAccountBase
    {

        #region Class Level Variables
        private DatabaseHelper oDatabaseHelper;
        #endregion

        #region Constants

        #endregion

        #region Constructors / Destructors

        public BDSupplierAccount()
            : base()
        {
        }

        #endregion

        #region Properties

        #endregion

        #region Methods (Public)
        public bool SaveAccountUpdates(PURPurchaseHeader purchaseHeader, BDSupplierAccount supplierAccount)
        {
            oDatabaseHelper = new DatabaseHelper();
            bool ExecutionState = false;
            oDatabaseHelper.BeginTransaction();
            ExecutionState = UpdateSupplierAccount(oDatabaseHelper, supplierAccount, ExecutionState);
            if (!UpdatePurchaseHeader(oDatabaseHelper, purchaseHeader))
            {
                ExecutionState = false;
            }
            else
                ExecutionState = true;
            if (ExecutionState)
                oDatabaseHelper.CommitTransaction();
            else
                oDatabaseHelper.RollbackTransaction();
            oDatabaseHelper.Dispose();
            return ExecutionState;
        }


        #endregion

        #region Methods (Private)

        private bool UpdateSupplierAccount(DatabaseHelper oDatabaseHelper, BDSupplierAccount supplierAccount, bool ExecutionState)
        {
            oDatabaseHelper.AddParameter("@SupplierAccountId", supplierAccount.SupplierAccountId);
            oDatabaseHelper.AddParameter("@PurcaseInvoiceID", supplierAccount.PurcaseInvoiceID);
            oDatabaseHelper.AddParameter("@PurchaseDate", supplierAccount.PurchaseDate);
            oDatabaseHelper.AddParameter("@SupplierID", supplierAccount.SupplierID);
            oDatabaseHelper.AddParameter("@InvoiceNumber", supplierAccount.InvoiceNumber);
            oDatabaseHelper.AddParameter("@TotalPrice", supplierAccount.TotalPrice);
            oDatabaseHelper.AddParameter("@PaidAmount", supplierAccount.PaidAmount);
            oDatabaseHelper.AddParameter("@IsVoid", supplierAccount.IsVoid);
            oDatabaseHelper.AddParameter("@RemainingAmount", supplierAccount.RemainingAmount);
            oDatabaseHelper.AddParameter("@CreateDate", supplierAccount.CreateDate);
            oDatabaseHelper.AddParameter("@CreatedBy", supplierAccount.CreatedBy);
            oDatabaseHelper.AddParameter("@updateDate", supplierAccount.updateDate);
            oDatabaseHelper.AddParameter("@UpdatedBy", supplierAccount.UpdatedBy);
            oDatabaseHelper.AddParameter("@IsDeleted", supplierAccount.IsDeleted);
            oDatabaseHelper.AddParameter("@DeleteDate", supplierAccount.DeleteDate);
            oDatabaseHelper.AddParameter("@DeletedBy", supplierAccount.DeletedBy);
            oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
            oDatabaseHelper.ExecuteScalar("gsp_BDSupplierAccounts_Update", CommandType.StoredProcedure, ConnectionState.KeepOpen, ref ExecutionState);
            return ExecutionState;
        }

        private bool UpdatePurchaseHeader(DatabaseHelper oDatabaseHelper, PURPurchaseHeader purchaseHeader)
        {
            bool ExecutionState = false;
            // Pass the value of '_salesHeaderID' as parameter 'PurchaseHeaderID' of the stored procedure.
            oDatabaseHelper.AddParameter("@PurcaseHeaderID", purchaseHeader.PurcaseHeaderID);
            oDatabaseHelper.AddParameter("@PurchaseDate", purchaseHeader.PurchaseDate);
            // Pass the value of '_customerID' as parameter 'SupplierID' of the stored procedure.
            if (purchaseHeader.SupplierID != null)
                oDatabaseHelper.AddParameter("@SupplierID", purchaseHeader.SupplierID);
            else
                oDatabaseHelper.AddParameter("@SupplierID", DBNull.Value);
            // Pass the value of '_invoiceNumber' as parameter 'InvoiceNumber' of the stored procedure.

            oDatabaseHelper.AddParameter("@InvoiceNumber", purchaseHeader.InvoiceNumber);


            // Pass the value of '_invoiceDate' as parameter 'Notes' of the stored procedure.
            if (purchaseHeader.Notes != null)
                oDatabaseHelper.AddParameter("@Notes", purchaseHeader.Notes);
            else
                oDatabaseHelper.AddParameter("@Notes", DBNull.Value);


            // Pass the value of '_invoiceDate' as parameter 'InventoryID' of the stored procedure.
            if (purchaseHeader.InventoryID != null)
                oDatabaseHelper.AddParameter("@InventoryID", purchaseHeader.InventoryID);
            else
                oDatabaseHelper.AddParameter("@InventoryID", DBNull.Value);

            // Pass the value of '_invoiceDate' as parameter 'InvoiceDate' of the stored procedure.
            if (purchaseHeader.InvoiceDate != null)
                oDatabaseHelper.AddParameter("@InvoiceDate", purchaseHeader.InvoiceDate);
            else
                oDatabaseHelper.AddParameter("@InvoiceDate", DBNull.Value);
            // Pass the value of '_paymentTypeID' as parameter 'PaymentTypeID' of the stored procedure.
            if (purchaseHeader.PaymentTypeID != null)
                oDatabaseHelper.AddParameter("@PaymentTypeID", purchaseHeader.PaymentTypeID);
            else
                oDatabaseHelper.AddParameter("@PaymentTypeID", DBNull.Value);
            // Pass the value of '_totalPrice' as parameter 'TotalPrice' of the stored procedure.
            if (purchaseHeader.TotalPrice != null)
                oDatabaseHelper.AddParameter("@TotalPrice", purchaseHeader.TotalPrice);
            else
                oDatabaseHelper.AddParameter("@TotalPrice", DBNull.Value);
            // Pass the value of '_paidAmount' as parameter 'PaidAmount' of the stored procedure.
            if (purchaseHeader.PaidAmount != null)
                oDatabaseHelper.AddParameter("@PaidAmount", purchaseHeader.PaidAmount);
            else
                oDatabaseHelper.AddParameter("@PaidAmount", DBNull.Value);
            // Pass the value of '_remainingAmount' as parameter 'RemainingAmount' of the stored procedure.
            if (purchaseHeader.RemainingAmount != null)
                oDatabaseHelper.AddParameter("@RemainingAmount", purchaseHeader.RemainingAmount);
            else
                oDatabaseHelper.AddParameter("@RemainingAmount", DBNull.Value);
            // Pass the value of '_lastDayToPay' as parameter 'LastDayToPay' of the stored procedure.
            if (purchaseHeader.LastDayToPay != null)
                oDatabaseHelper.AddParameter("@LastDayToPay", purchaseHeader.LastDayToPay);
            else
                oDatabaseHelper.AddParameter("@LastDayToPay", DBNull.Value);
            // Pass the value of '_totalDiscountAmount' as parameter 'TotalDiscountAmount' of the stored procedure.
            if (purchaseHeader.TotalDiscountAmount != null)
                oDatabaseHelper.AddParameter("@TotalDiscountAmount", purchaseHeader.TotalDiscountAmount);
            else
                oDatabaseHelper.AddParameter("@TotalDiscountAmount", DBNull.Value);
            // Pass the value of '_totalDiscountRatio' as parameter 'TotalDiscountRatio' of the stored procedure.
            if (purchaseHeader.TotalDiscountRatio != null)
                oDatabaseHelper.AddParameter("@TotalDiscountRatio", purchaseHeader.TotalDiscountRatio);
            else
                oDatabaseHelper.AddParameter("@TotalDiscountRatio", DBNull.Value);
            // Pass the value of '_isClosed' as parameter 'IsClosed' of the stored procedure.
            if (purchaseHeader.IsClosed != null)
                oDatabaseHelper.AddParameter("@IsClosed", purchaseHeader.IsClosed);
            else
                oDatabaseHelper.AddParameter("@IsClosed", DBNull.Value);
            // Pass the value of '_isVoid' as parameter 'IsVoid' of the stored procedure.
            if (purchaseHeader.IsVoid != null)
                oDatabaseHelper.AddParameter("@IsVoid", purchaseHeader.IsVoid);
            else
                oDatabaseHelper.AddParameter("@IsVoid", DBNull.Value);
            // Pass the value of '_isPrinted' as parameter 'IsPrinted' of the stored procedure.
            if (purchaseHeader.IsPrinted != null)
                oDatabaseHelper.AddParameter("@IsPrinted", purchaseHeader.IsPrinted);
            else
                oDatabaseHelper.AddParameter("@IsPrinted", DBNull.Value);
            // Pass the value of '_servicePrice' as parameter 'ServicePrice' of the stored procedure.
            if (purchaseHeader.ServicePrice != null)
                oDatabaseHelper.AddParameter("@ServicePrice", purchaseHeader.ServicePrice);
            else
                oDatabaseHelper.AddParameter("@ServicePrice", DBNull.Value);
            // Pass the value of '_taxTypeID' as parameter 'TaxTypeID' of the stored procedure.
            if (purchaseHeader.TaxTypeID != null)
                oDatabaseHelper.AddParameter("@TaxTypeID", purchaseHeader.TaxTypeID);
            else
                oDatabaseHelper.AddParameter("@TaxTypeID", DBNull.Value);
            // Pass the value of '_refuseReasonID' as parameter 'RefuseReasonID' of the stored procedure.
            if (purchaseHeader.RefuseReasonID != null)
                oDatabaseHelper.AddParameter("@RefuseReasonID", purchaseHeader.RefuseReasonID);
            else
                oDatabaseHelper.AddParameter("@RefuseReasonID", DBNull.Value);
            // Pass the value of '_createdBy' as parameter 'CreatedBy' of the stored procedure.
            if (purchaseHeader.CreatedBy != null)
                oDatabaseHelper.AddParameter("@CreatedBy", purchaseHeader.CreatedBy);
            else
                oDatabaseHelper.AddParameter("@CreatedBy", DBNull.Value);
            // Pass the value of '_createDate' as parameter 'CreateDate' of the stored procedure.
            if (purchaseHeader.CreateDate != null)
                oDatabaseHelper.AddParameter("@CreateDate", purchaseHeader.CreateDate);
            else
                oDatabaseHelper.AddParameter("@CreateDate", DBNull.Value);
            // Pass the value of '_updatedBy' as parameter 'UpdatedBy' of the stored procedure.
            if (purchaseHeader.UpdatedBy != null)
                oDatabaseHelper.AddParameter("@UpdatedBy", purchaseHeader.UpdatedBy);
            else
                oDatabaseHelper.AddParameter("@UpdatedBy", DBNull.Value);
            // Pass the value of '_updateDate' as parameter 'UpdateDate' of the stored procedure.
            if (purchaseHeader.updateDate != null)
                oDatabaseHelper.AddParameter("@UpdateDate", purchaseHeader.updateDate);
            else
                oDatabaseHelper.AddParameter("@UpdateDate", DBNull.Value);
            // Pass the value of '_isDeleted' as parameter 'IsDeleted' of the stored procedure.
            if (purchaseHeader.IsDeleted != null)
                oDatabaseHelper.AddParameter("@IsDeleted", purchaseHeader.IsDeleted);
            else
                oDatabaseHelper.AddParameter("@IsDeleted", DBNull.Value);
            // Pass the value of '_deletedBy' as parameter 'DeletedBy' of the stored procedure.
            if (purchaseHeader.DeletedBy != null)
                oDatabaseHelper.AddParameter("@DeletedBy", purchaseHeader.DeletedBy);
            else
                oDatabaseHelper.AddParameter("@DeletedBy", DBNull.Value);
            // Pass the value of '_deletDate' as parameter 'DeletDate' of the stored procedure.
            if (purchaseHeader.DeleteDate != null)
                oDatabaseHelper.AddParameter("@DeletDate", purchaseHeader.DeleteDate);
            else
                oDatabaseHelper.AddParameter("@DeletDate", DBNull.Value);
            // The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
            oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);

            oDatabaseHelper.ExecuteScalar("gsp_PURPurchaseHeader_Update", CommandType.StoredProcedure, ConnectionState.KeepOpen, ref ExecutionState);

            return ExecutionState;

        }

        #endregion

    }
	
}
