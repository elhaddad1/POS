//
// Class	:	PURPurchaseLine.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	2/24/2015 10:40:54 AM
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
        private DatabaseHelper oDatabaseHelper;
        private string _productNameNonDefault = null;
        private string _batchNumberNonDefault = null;
        private DateTime? _expiryDateNonDefault;
        private decimal _batchQtyNonDefault;
        private bool _isAcceptBatchNonDefault;
        private int _batchIDNonDefault;
        private int _PurchaseLineBatchIDNonDefault;

        
		#endregion
		
		#region Constants
		
		#endregion

		#region Constructors / Destructors 
		
		public PURPurchaseLine() : base()
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
        public string BatchNumber
        {
            get { return _batchNumberNonDefault; }
            set { _batchNumberNonDefault = value; }
        }
        public DateTime? ExpiryDate
        {
            get { return _expiryDateNonDefault; }
            set { _expiryDateNonDefault = value; }
        }
        public decimal BatchQty
        {
            get { return _batchQtyNonDefault; }
            set { _batchQtyNonDefault = value; }
        }
        public bool IsAcceptBatch
        {
            get { return _isAcceptBatchNonDefault; }
            set { _isAcceptBatchNonDefault = value; }
        }
        public int BatchID
        {
            get { return _batchIDNonDefault; }
            set { _batchIDNonDefault = value; }
        }
        public int PurchaseLineBatchID
        {
            get { return _PurchaseLineBatchIDNonDefault; }
            set { _PurchaseLineBatchIDNonDefault = value; }
        }
       
		#endregion

		#region Methods (Public)
        public int SaveTransaction(PURPurchaseHeader pURPurchaseHeader, PURPurchaseLineCollection sALPurchaseLineCollection)
        {
            oDatabaseHelper = new DatabaseHelper();
            bool ExecutionState = false;
            int salesHeaderID;
            oDatabaseHelper.BeginTransaction();
            if (InsertHeader(oDatabaseHelper, pURPurchaseHeader, out salesHeaderID))
            {
                foreach (PURPurchaseLine sALPurchaseLine in sALPurchaseLineCollection)
                {
                    if (!InsertDetails(oDatabaseHelper, sALPurchaseLine, salesHeaderID))
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

        public bool UpdateTransaction(PURPurchaseHeader pURPurchaseHeader, PURPurchaseLineCollection sALPurchaseLineCollection)
        {
            oDatabaseHelper = new DatabaseHelper();
            bool ExecutionState = false;
            oDatabaseHelper.BeginTransaction();
            if (UpdateHeader(oDatabaseHelper, pURPurchaseHeader))
            {
                if (DeleteDetails(oDatabaseHelper, (int)pURPurchaseHeader.PurcaseHeaderID, (int)pURPurchaseHeader.CreatedBy))
                {
                    foreach (PURPurchaseLine sALPurchaseLine in sALPurchaseLineCollection)
                    {
                        if (!InsertDetails(oDatabaseHelper, sALPurchaseLine, (int)pURPurchaseHeader.PurcaseHeaderID))
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
         public  PURPurchaseLineCollection SelectByHeaderID(int HeaderID)
                {
                    DatabaseHelper oDatabaseHelper = new DatabaseHelper();
                    bool ExecutionState = false;
                    oDatabaseHelper.AddParameter("@HeaderID", HeaderID);
                    oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);

                    IDataReader rdr = oDatabaseHelper.ExecuteReader("usp_PURPurchaseLine_SelectByHeaderID", ref ExecutionState);
                    PURPurchaseLineCollection lines = new PURPurchaseLineCollection();
                    while(rdr.Read())
                    {
                        PURPurchaseLine obj = new PURPurchaseLine();
                        obj.PurchaseLineID = rdr.GetInt32(rdr.GetOrdinal(PURPurchaseLineFields.PurchaseLineID));
                        //obj.PurchaseHeaderID = rdr.GetInt32(rdr.GetOrdinal(PURPurchaseLineFields.PurchaseHeaderID));
                        obj.ProductID = rdr.GetInt32(rdr.GetOrdinal(PURPurchaseLineFields.ProductID));
                        obj.TotalQty = rdr.GetDecimal(rdr.GetOrdinal(PURPurchaseLineFields.TotalQty));
                        obj.BonusQty = rdr.GetDecimal(rdr.GetOrdinal(PURPurchaseLineFields.BonusQty));
                        obj.DiscountRatio = rdr.GetDecimal(rdr.GetOrdinal(PURPurchaseLineFields.DiscountRatio));
                        obj.IsAcceptBatch = rdr.GetBoolean(rdr.GetOrdinal("IsAcceptBatch"));
                        //obj.DiscountAmount = rdr.GetDecimal(rdr.GetOrdinal(PURPurchaseLineFields.DiscountAmount));
                        obj.Unitprice = rdr.GetDecimal(rdr.GetOrdinal(PURPurchaseLineFields.Unitprice));
                        if (rdr.GetOrdinal("PurchaseLineBatchID") != null && rdr.GetInt32(rdr.GetOrdinal("PurchaseLineBatchID")) !=0)
                            obj.PurchaseLineBatchID = rdr.GetInt32(rdr.GetOrdinal("PurchaseLineBatchID"));
                        if (rdr.GetOrdinal("BatchID") != null && rdr.GetInt32(rdr.GetOrdinal("BatchID")) != 0)
                        {
                            obj.BatchID = rdr.GetInt32(rdr.GetOrdinal("BatchID"));
                            obj.BatchNumber = rdr.GetString(rdr.GetOrdinal("BatchNumber"));
                            obj.ExpiryDate = rdr.GetDateTime(rdr.GetOrdinal("ExpiryDate"));
                        }
                        lines.Add(obj);
                    }
                   
                        rdr.Close();
                        return lines;
         }
			

                
		#endregion
		
		#region Methods (Private)
        private bool InsertHeader(DatabaseHelper oDatabaseHelper, PURPurchaseHeader pURPurchaseHeader, out int pK)
        {
            bool ExecutionState = false;
            // Pass the value of '_salesDate' as parameter 'PurchaseDate' of the stored procedure.

            oDatabaseHelper.AddParameter("@PurchaseDate", pURPurchaseHeader.PurchaseDate);
            // Pass the value of '_customerID' as parameter 'SupplierID' of the stored procedure.
            if (pURPurchaseHeader.SupplierID != null)
                oDatabaseHelper.AddParameter("@SupplierID", pURPurchaseHeader.SupplierID);
            else
                oDatabaseHelper.AddParameter("@SupplierID", DBNull.Value);
            // Pass the value of '_invoiceNumber' as parameter 'InvoiceNumber' of the stored procedure.

            if (pURPurchaseHeader.InvoiceNumber != null)
                oDatabaseHelper.AddParameter("@InvoiceNumber", pURPurchaseHeader.InvoiceNumber );
            else
                oDatabaseHelper.AddParameter("@InvoiceNumber", DBNull.Value);
            // Pass the value of '_invoiceNumber' as parameter 'InvoiceNumber' of the stored procedure.

            // Pass the value of '_invoiceDate' as parameter 'InvoiceDate' of the stored procedure.
            if (pURPurchaseHeader.InvoiceDate != null)
                oDatabaseHelper.AddParameter("@InvoiceDate", pURPurchaseHeader.InvoiceDate);
            else
                oDatabaseHelper.AddParameter("@InvoiceDate", DBNull.Value);
            // Pass the value of '_sellerID' as parameter 'SellerID' of the stored procedure.
            //if (pURPurchaseHeader.SellerID != null)
            //    oDatabaseHelper.AddParameter("@SellerID", pURPurchaseHeader.SellerID);
            //else
            //    oDatabaseHelper.AddParameter("@SellerID", DBNull.Value);
            // Pass the value of '_paymentTypeID' as parameter 'PaymentTypeID' of the stored procedure.
            if (pURPurchaseHeader.PaymentTypeID != null)
                oDatabaseHelper.AddParameter("@PaymentTypeID", pURPurchaseHeader.PaymentTypeID);
            else
                oDatabaseHelper.AddParameter("@PaymentTypeID", DBNull.Value);

            if (pURPurchaseHeader.InventoryID != null)
                oDatabaseHelper.AddParameter("@InventoryID", pURPurchaseHeader.InventoryID);
            else
                oDatabaseHelper.AddParameter("@InventoryID", DBNull.Value);


            // Pass the value of '_totalPrice' as parameter 'TotalPrice' of the stored procedure.
            if (pURPurchaseHeader.TotalPrice != null)
                oDatabaseHelper.AddParameter("@TotalPrice", pURPurchaseHeader.TotalPrice);
            else
                oDatabaseHelper.AddParameter("@TotalPrice", DBNull.Value);
            // Pass the value of '_paidAmount' as parameter 'PaidAmount' of the stored procedure.
            if (pURPurchaseHeader.PaidAmount != null)
                oDatabaseHelper.AddParameter("@PaidAmount", pURPurchaseHeader.PaidAmount);
            else
                oDatabaseHelper.AddParameter("@PaidAmount", DBNull.Value);
            // Pass the value of '_remainingAmount' as parameter 'RemainingAmount' of the stored procedure.
            if (pURPurchaseHeader.RemainingAmount != null)
                oDatabaseHelper.AddParameter("@RemainingAmount", pURPurchaseHeader.RemainingAmount);
            else
                oDatabaseHelper.AddParameter("@RemainingAmount", DBNull.Value);
            // Pass the value of '_lastDayToPay' as parameter 'LastDayToPay' of the stored procedure.
            if (pURPurchaseHeader.LastDayToPay != null)
                oDatabaseHelper.AddParameter("@LastDayToPay", pURPurchaseHeader.LastDayToPay);
            else
                oDatabaseHelper.AddParameter("@LastDayToPay", DBNull.Value);

            if (pURPurchaseHeader.ChequeNumber != null)
                oDatabaseHelper.AddParameter("@ChequeNumber", pURPurchaseHeader.ChequeNumber);
            else
                oDatabaseHelper.AddParameter("@ChequeNumber", DBNull.Value);


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
            // Pass the value of '_servicePrice' as parameter 'ServicePrice' of the stored procedure.
            if (pURPurchaseHeader.ServicePrice != null)
                oDatabaseHelper.AddParameter("@ServicePrice", pURPurchaseHeader.ServicePrice);
            else
                oDatabaseHelper.AddParameter("@ServicePrice", DBNull.Value);
            // Pass the value of '_taxTypeID' as parameter 'TaxTypeID' of the stored procedure.
            if (pURPurchaseHeader.TaxTypeID != null)
                oDatabaseHelper.AddParameter("@TaxTypeID", pURPurchaseHeader.TaxTypeID);
            else
                oDatabaseHelper.AddParameter("@TaxTypeID", DBNull.Value);
            // Pass the value of '_refuseReasonID' as parameter 'RefuseReasonID' of the stored procedure.
            if (pURPurchaseHeader.RefuseReasonID != null)
                oDatabaseHelper.AddParameter("@RefuseReasonID", pURPurchaseHeader.RefuseReasonID);
            else
                oDatabaseHelper.AddParameter("@RefuseReasonID", DBNull.Value);
            // Pass the value of '_createdBy' as parameter 'CreatedBy' of the stored procedure.
            if (pURPurchaseHeader.CreatedBy != null)
                oDatabaseHelper.AddParameter("@CreatedBy", pURPurchaseHeader.CreatedBy);
            else
                oDatabaseHelper.AddParameter("@CreatedBy", DBNull.Value);
            // Pass the value of '_createDate' as parameter 'CreateDate' of the stored procedure.
            if (pURPurchaseHeader.CreateDate != null)
                oDatabaseHelper.AddParameter("@CreateDate", pURPurchaseHeader.CreateDate);
            else
                oDatabaseHelper.AddParameter("@CreateDate", DBNull.Value);
            // Pass the value of '_updatedBy' as parameter 'UpdatedBy' of the stored procedure.
            if (pURPurchaseHeader.UpdatedBy != null)
                oDatabaseHelper.AddParameter("@UpdatedBy", pURPurchaseHeader.UpdatedBy);
            else
                oDatabaseHelper.AddParameter("@UpdatedBy", DBNull.Value);
            // Pass the value of '_updateDate' as parameter 'UpdateDate' of the stored procedure.
            if (pURPurchaseHeader.updateDate != null)
                oDatabaseHelper.AddParameter("@UpdateDate", pURPurchaseHeader.updateDate);
            else
                oDatabaseHelper.AddParameter("@UpdateDate", DBNull.Value);
            // Pass the value of '_isDeleted' as parameter 'IsDeleted' of the stored procedure.
            if (pURPurchaseHeader.IsDeleted != null)
                oDatabaseHelper.AddParameter("@IsDeleted", pURPurchaseHeader.IsDeleted);
            else
                oDatabaseHelper.AddParameter("@IsDeleted", DBNull.Value);
            // Pass the value of '_deletedBy' as parameter 'DeletedBy' of the stored procedure.
            if (pURPurchaseHeader.DeletedBy != null)
                oDatabaseHelper.AddParameter("@DeletedBy", pURPurchaseHeader.DeletedBy);
            else
                oDatabaseHelper.AddParameter("@DeletedBy", DBNull.Value);
            // Pass the value of '_deletDate' as parameter 'DeletDate' of the stored procedure.
            if (pURPurchaseHeader.DeleteDate != null)
                oDatabaseHelper.AddParameter("@DeletDate", pURPurchaseHeader.DeleteDate);
            else
                oDatabaseHelper.AddParameter("@DeletDate", DBNull.Value);
            // The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
            oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);

            try
            {
                pK = Convert.ToInt32(oDatabaseHelper.ExecuteScalar("usp_PURPurcaseHeader_Insert", CommandType.StoredProcedure, ConnectionState.KeepOpen, ref ExecutionState));
                //    oDatabaseHelper.Dispose();
            }
            catch (Exception ex)
            {

                throw;
            }
            return ExecutionState;
        }
        private bool InsertDetails(DatabaseHelper oDatabaseHelper, PURPurchaseLine sALPurchaseLine, int salesHeaderID)
        {
            bool ExecutionState = false;
            // Pass the value of '_salesHeaderID' as parameter 'PurchaseHeaderID' of the stored procedure.
            if (salesHeaderID != null)
                oDatabaseHelper.AddParameter("@PurchaseHeaderID", salesHeaderID);
            else
                oDatabaseHelper.AddParameter("@PurchaseHeaderID", DBNull.Value);
            // Pass the value of '_productID' as parameter 'ProductID' of the stored procedure.
            if (sALPurchaseLine.ProductID != null)
                oDatabaseHelper.AddParameter("@ProductID", sALPurchaseLine.ProductID);
            else
                oDatabaseHelper.AddParameter("@ProductID", DBNull.Value);
            // Pass the value of '_totalQty' as parameter 'TotalQty' of the stored procedure.
            if (sALPurchaseLine.TotalQty != null)
                oDatabaseHelper.AddParameter("@BatchQty", sALPurchaseLine.TotalQty);
            else
                oDatabaseHelper.AddParameter("@BatchQty", DBNull.Value);
            // Pass the value of '_totalBonus' as parameter 'TotalBonus' of the stored procedure.
            if (sALPurchaseLine.BonusQty != null)
                oDatabaseHelper.AddParameter("@BonusQty", sALPurchaseLine.BonusQty);
            else
                oDatabaseHelper.AddParameter("@BonusQty", DBNull.Value);
            // Pass the value of '_discountAmount' as parameter 'DiscountAmount' of the stored procedure.
            if (sALPurchaseLine.DiscountAmount != null)
                oDatabaseHelper.AddParameter("@DiscountAmount", sALPurchaseLine.DiscountAmount);
            else
                oDatabaseHelper.AddParameter("@DiscountAmount", DBNull.Value);
            // Pass the value of '_discountRatio' as parameter 'DiscountRatio' of the stored procedure.
            if (sALPurchaseLine.DiscountRatio != null)
                oDatabaseHelper.AddParameter("@DiscountRatio", sALPurchaseLine.DiscountRatio);
            else
                oDatabaseHelper.AddParameter("@DiscountRatio", DBNull.Value);
            // Pass the value of '_unitPrice' as parameter 'UnitPrice' of the stored procedure.
            if (sALPurchaseLine.Unitprice != null)
                oDatabaseHelper.AddParameter("@UnitPrice", sALPurchaseLine.Unitprice);
            else
                oDatabaseHelper.AddParameter("@UnitPrice", DBNull.Value);
            if (sALPurchaseLine.BatchNumber != null || sALPurchaseLine.BatchNumber !="")
                    oDatabaseHelper .AddParameter ("@BatchNumber",sALPurchaseLine.BatchNumber);

            if (sALPurchaseLine.ExpiryDate != null || sALPurchaseLine.ExpiryDate != null )
                oDatabaseHelper.AddParameter("@ExpiryDate", sALPurchaseLine.ExpiryDate);

            // Pass the value of '_createdBy' as parameter 'CreatedBy' of the stored procedure.
            if (sALPurchaseLine.CreatedBy != null)
                oDatabaseHelper.AddParameter("@CreatedBy", sALPurchaseLine.CreatedBy);
            else
                oDatabaseHelper.AddParameter("@CreatedBy", DBNull.Value);
            // Pass the value of '_createDate' as parameter 'CreateDate' of the stored procedure.
            if (sALPurchaseLine.CreatedDate != null)
                oDatabaseHelper.AddParameter("@CreateDate", sALPurchaseLine.CreatedDate);
            else
                oDatabaseHelper.AddParameter("@CreateDate", DBNull.Value);

            // The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
            oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);

            try
            {
                oDatabaseHelper.ExecuteScalar("usp_PURPurchaseLine_SaveLine", CommandType.StoredProcedure, ConnectionState.KeepOpen, ref ExecutionState);

            }
            catch (Exception ex)
            {
                
               
            }
            return ExecutionState;
        }
        private bool UpdateHeader(DatabaseHelper oDatabaseHelper, PURPurchaseHeader pURPurchaseHeader)
        {
            bool ExecutionState = false;
            // Pass the value of '_salesDate' as parameter 'PurchaseDate' of the stored procedure.
            oDatabaseHelper.AddParameter("@PurcaseHeaderID", pURPurchaseHeader.PurcaseHeaderID);
            oDatabaseHelper.AddParameter("@PurchaseDate", pURPurchaseHeader.PurchaseDate);
            // Pass the value of '_customerID' as parameter 'SupplierID' of the stored procedure.
            if (pURPurchaseHeader.SupplierID != null)
                oDatabaseHelper.AddParameter("@SupplierID", pURPurchaseHeader.SupplierID);
            else
                oDatabaseHelper.AddParameter("@SupplierID", DBNull.Value);
            // Pass the value of '_invoiceNumber' as parameter 'InvoiceNumber' of the stored procedure.

            oDatabaseHelper.AddParameter("@InvoiceNumber", DBNull.Value);
            // Pass the value of '_invoiceDate' as parameter 'InvoiceDate' of the stored procedure.
            if (pURPurchaseHeader.InvoiceDate != null)
                oDatabaseHelper.AddParameter("@InvoiceDate", pURPurchaseHeader.InvoiceDate);
            else
                oDatabaseHelper.AddParameter("@InvoiceDate", DBNull.Value);
            // Pass the value of '_sellerID' as parameter 'SellerID' of the stored procedure.
            //if (pURPurchaseHeader.SellerID != null)
            //    oDatabaseHelper.AddParameter("@SellerID", pURPurchaseHeader.SellerID);
            //else
            //    oDatabaseHelper.AddParameter("@SellerID", DBNull.Value);
            // Pass the value of '_paymentTypeID' as parameter 'PaymentTypeID' of the stored procedure.
            if (pURPurchaseHeader.PaymentTypeID != null)
                oDatabaseHelper.AddParameter("@PaymentTypeID", pURPurchaseHeader.PaymentTypeID);
            else
                oDatabaseHelper.AddParameter("@PaymentTypeID", DBNull.Value);

            if (pURPurchaseHeader.InventoryID != null)
                oDatabaseHelper.AddParameter("@InventoryID", pURPurchaseHeader.InventoryID);
            else
                oDatabaseHelper.AddParameter("@InventoryID", DBNull.Value);


            // Pass the value of '_totalPrice' as parameter 'TotalPrice' of the stored procedure.
            if (pURPurchaseHeader.TotalPrice != null)
                oDatabaseHelper.AddParameter("@TotalPrice", pURPurchaseHeader.TotalPrice);
            else
                oDatabaseHelper.AddParameter("@TotalPrice", DBNull.Value);
            // Pass the value of '_paidAmount' as parameter 'PaidAmount' of the stored procedure.
            if (pURPurchaseHeader.PaidAmount != null)
                oDatabaseHelper.AddParameter("@PaidAmount", pURPurchaseHeader.PaidAmount);
            else
                oDatabaseHelper.AddParameter("@PaidAmount", DBNull.Value);
            // Pass the value of '_remainingAmount' as parameter 'RemainingAmount' of the stored procedure.
            if (pURPurchaseHeader.RemainingAmount != null)
                oDatabaseHelper.AddParameter("@RemainingAmount", pURPurchaseHeader.RemainingAmount);
            else
                oDatabaseHelper.AddParameter("@RemainingAmount", DBNull.Value);
            // Pass the value of '_lastDayToPay' as parameter 'LastDayToPay' of the stored procedure.
            if (pURPurchaseHeader.LastDayToPay != null)
                oDatabaseHelper.AddParameter("@LastDayToPay", pURPurchaseHeader.LastDayToPay);
            else
                oDatabaseHelper.AddParameter("@LastDayToPay", DBNull.Value);

            if (pURPurchaseHeader.ChequeNumber != null)
                oDatabaseHelper.AddParameter("@ChequeNumber", pURPurchaseHeader.ChequeNumber);
            else
                oDatabaseHelper.AddParameter("@ChequeNumber", DBNull.Value);
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
            // Pass the value of '_servicePrice' as parameter 'ServicePrice' of the stored procedure.
            if (pURPurchaseHeader.ServicePrice != null)
                oDatabaseHelper.AddParameter("@ServicePrice", pURPurchaseHeader.ServicePrice);
            else
                oDatabaseHelper.AddParameter("@ServicePrice", DBNull.Value);
            // Pass the value of '_taxTypeID' as parameter 'TaxTypeID' of the stored procedure.
            if (pURPurchaseHeader.TaxTypeID != null)
                oDatabaseHelper.AddParameter("@TaxTypeID", pURPurchaseHeader.TaxTypeID);
            else
                oDatabaseHelper.AddParameter("@TaxTypeID", DBNull.Value);
            // Pass the value of '_refuseReasonID' as parameter 'RefuseReasonID' of the stored procedure.
            if (pURPurchaseHeader.RefuseReasonID != null)
                oDatabaseHelper.AddParameter("@RefuseReasonID", pURPurchaseHeader.RefuseReasonID);
            else
                oDatabaseHelper.AddParameter("@RefuseReasonID", DBNull.Value);
            // Pass the value of '_createdBy' as parameter 'CreatedBy' of the stored procedure.
            
            // Pass the value of '_updatedBy' as parameter 'UpdatedBy' of the stored procedure.
            if (pURPurchaseHeader.UpdatedBy != null)
                oDatabaseHelper.AddParameter("@UpdatedBy", pURPurchaseHeader.UpdatedBy);
            else
                oDatabaseHelper.AddParameter("@UpdatedBy", DBNull.Value);
            // Pass the value of '_updateDate' as parameter 'UpdateDate' of the stored procedure.
            if (pURPurchaseHeader.updateDate != null)
                oDatabaseHelper.AddParameter("@UpdateDate", pURPurchaseHeader.updateDate);
            else
                oDatabaseHelper.AddParameter("@UpdateDate", DBNull.Value);
            // Pass the value of '_isDeleted' as parameter 'IsDeleted' of the stored procedure.
            if (pURPurchaseHeader.IsDeleted != null)
                oDatabaseHelper.AddParameter("@IsDeleted", pURPurchaseHeader.IsDeleted);
            else
                oDatabaseHelper.AddParameter("@IsDeleted", DBNull.Value);
            // Pass the value of '_deletedBy' as parameter 'DeletedBy' of the stored procedure.
            
            // The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
            oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);

            oDatabaseHelper.ExecuteScalar("usp_PURPurchaseHeader_Update", CommandType.StoredProcedure, ConnectionState.KeepOpen, ref ExecutionState);

            return ExecutionState;

        }
        private bool DeleteDetails(DatabaseHelper oDatabaseHelper, int PurchaseHeaderID, int UserID)
        {
            bool ExecutionState = false;

            oDatabaseHelper.AddParameter("@UserID", UserID);
            oDatabaseHelper.AddParameter("@PurchaseHeaderID", PurchaseHeaderID);
            oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
            oDatabaseHelper.ExecuteScalar("usp_PURPurchaseLine_DeleteLines", CommandType.StoredProcedure, ConnectionState.KeepOpen, ref ExecutionState);

            return ExecutionState;
        }
        internal static PURPurchaseLineCollection FillCollection( IDataReader rdr)
        {
            PURPurchaseLineCollection list = new PURPurchaseLineCollection();

            while (rdr.Read())
            {
                PURPurchaseLine obj = new PURPurchaseLine();
                obj.PurchaseLineID = rdr.GetInt32(rdr.GetOrdinal(PURPurchaseLineFields.PurchaseLineID));
                //obj.PurchaseHeaderID = rdr.GetInt32(rdr.GetOrdinal(PURPurchaseLineFields.PurchaseHeaderID));
                obj.ProductID = rdr.GetInt32(rdr.GetOrdinal(PURPurchaseLineFields.ProductID));
                obj.TotalQty = rdr.GetDecimal(rdr.GetOrdinal(PURPurchaseLineFields.TotalQty));
                obj.BonusQty = rdr.GetDecimal(rdr.GetOrdinal(PURPurchaseLineFields.BonusQty));
                obj.DiscountRatio = rdr.GetDecimal(rdr.GetOrdinal(PURPurchaseLineFields.DiscountRatio));
                //obj.DiscountAmount = rdr.GetDecimal(rdr.GetOrdinal(PURPurchaseLineFields.DiscountAmount));
                obj.Unitprice = rdr.GetDecimal(rdr.GetOrdinal(PURPurchaseLineFields.Unitprice));
                if (rdr.GetOrdinal("PurchaseLineBatchID") != null)
                {
                        obj.PurchaseLineBatchID = rdr.GetInt32(rdr.GetOrdinal("PurchaseLineBatchID"));
                    
                    
                }
                if (rdr.GetOrdinal("BatchID") != null)
                {
                    obj.BatchID = rdr.GetInt32(rdr.GetOrdinal("BatchID"));
                }
                
                if (rdr.GetOrdinal("BatchNumber") != null)
                {
                    obj.BatchNumber = rdr.GetString(rdr.GetOrdinal("BatchNumber"));
                }
                if (rdr.GetOrdinal("ExpiryDate") != null)
                {
                    obj.ExpiryDate = rdr.GetDateTime(rdr.GetOrdinal("ExpiryDate"));
                }

              
                list.Add(obj);
            }
            return list;
        }
		#endregion

	}
	
}
