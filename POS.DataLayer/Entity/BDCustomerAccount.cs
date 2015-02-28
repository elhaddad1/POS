//
// Class	:	BDCustomerAccount.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	2/27/2015 12:29:25 PM
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
	/// Data access class for the "BDCustomerAccounts" table.
	/// </summary>
	[Serializable]
	public class BDCustomerAccount : BDCustomerAccountBase
	{

        #region Class Level Variables
        private DatabaseHelper oDatabaseHelper;
		#endregion
		
		#region Constants
		
		#endregion

		#region Constructors / Destructors 
		
		public BDCustomerAccount() : base()
		{
		}

		#endregion

		#region Properties

		#endregion

        #region Methods (Public)
        public bool SaveAccountUpdates(SALSalesHeader salesHeader, BDCustomerAccount customerAccount)
        {
            oDatabaseHelper = new DatabaseHelper();
            bool ExecutionState = false;
            oDatabaseHelper.BeginTransaction();
            ExecutionState = UpdateCustomerAccount(oDatabaseHelper, customerAccount, ExecutionState);
            if (!UpdateSalesHeader(oDatabaseHelper, salesHeader))
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

        private bool UpdateCustomerAccount(DatabaseHelper oDatabaseHelper, BDCustomerAccount customerAccount, bool ExecutionState)
        {
            oDatabaseHelper.AddParameter("@CustomerAccountNumber", customerAccount.CustomerAccountNumber);
            oDatabaseHelper.AddParameter("@SalesInvoiceId", customerAccount.SalesInvoiceId);
            oDatabaseHelper.AddParameter("@SalesDate", customerAccount.SalesDate);
            oDatabaseHelper.AddParameter("@CustomerID", customerAccount.CustomerID);
            oDatabaseHelper.AddParameter("@InvoiceNumber", customerAccount.InvoiceNumber);
            oDatabaseHelper.AddParameter("@TotalPrice", customerAccount.TotalPrice);
            oDatabaseHelper.AddParameter("@PaidAmount", customerAccount.PaidAmount);
            oDatabaseHelper.AddParameter("@IsVoid", customerAccount.IsVoid);
            oDatabaseHelper.AddParameter("@RemainingAmount", customerAccount.RemainingAmount);
            oDatabaseHelper.AddParameter("@CreateDate", customerAccount.CreateDate);
            oDatabaseHelper.AddParameter("@CreatedBy", customerAccount.CreatedBy);
            oDatabaseHelper.AddParameter("@UpdateDate", customerAccount.UpdateDate);
            oDatabaseHelper.AddParameter("@UpdatedBy", customerAccount.UpdatedBy);
            oDatabaseHelper.AddParameter("@IsDeleted", customerAccount.IsDeleted);
            oDatabaseHelper.AddParameter("@DeletedDate", customerAccount.DeletedDate);
            oDatabaseHelper.AddParameter("@DeletedBy", customerAccount.DeletedBy);
            oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
            oDatabaseHelper.ExecuteScalar("gsp_BDCustomerAccounts_Update", CommandType.StoredProcedure, ConnectionState.KeepOpen, ref ExecutionState);
            return ExecutionState;
        }

        private bool UpdateSalesHeader(DatabaseHelper oDatabaseHelper, SALSalesHeader sALSalesHeader)
        {
            bool ExecutionState = false;
            // Pass the value of '_salesHeaderID' as parameter 'SalesHeaderID' of the stored procedure.
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

            oDatabaseHelper.ExecuteScalar("gsp_SALSalesHeader_Update", CommandType.StoredProcedure, ConnectionState.KeepOpen, ref ExecutionState);

            return ExecutionState;
        }

		#endregion

	}
	
}
