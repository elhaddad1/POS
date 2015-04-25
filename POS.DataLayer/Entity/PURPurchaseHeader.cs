//
// Class	:	PURPurchaseHeader.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	2/24/2015 10:40:55 AM
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
	/// Data access class for the "PURPurchaseHeader" table.
	/// </summary>
	[Serializable]
	public class PURPurchaseHeader : PURPurchaseHeaderBase
	{
	
		#region Class Level Variables
        private string _supplierNameNonDefault = null;
		#endregion
		
		#region Constants
		
		#endregion

		#region Constructors / Destructors 
		
		public PURPurchaseHeader() : base()
		{
		}

		#endregion

		#region Properties
        public string SupplierName
        {
            get
            {
                return _supplierNameNonDefault;
            }
            set
            {

                _supplierNameNonDefault = value;
            }
        }
		#endregion

		#region Methods (Public)
        public static PURPurchaseHeaderCollection HeaderSearch(int InventoryID, DateTime FromDate, DateTime ToDate, string SupplierName, string InvoiceNumber)
        {
            DatabaseHelper oDatabaseHelper = new DatabaseHelper();
            bool ExecutionState = false;

            // Pass the specified field and its value to the stored procedure.
            oDatabaseHelper.AddParameter("@InventoryID", InventoryID );
            oDatabaseHelper.AddParameter("@FromDate", FromDate);
            oDatabaseHelper.AddParameter("@ToDate", ToDate );
            if (SupplierName!="")
            {
                oDatabaseHelper.AddParameter("@SupplierName", SupplierName); 
            }
            if (InvoiceNumber != "")
            {
                oDatabaseHelper.AddParameter("@InvoiceNumber", InvoiceNumber);
            }
            // The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
            oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);

            IDataReader dr = oDatabaseHelper.ExecuteReader("usp_PURPurchaseHeader_SearchByCriteria", ref ExecutionState);
            PURPurchaseHeaderCollection PURPurchaseHeaderCollection = PopulateFromReader(dr);

            dr.Close();
            oDatabaseHelper.Dispose();
            return PURPurchaseHeaderCollection;

        }
        public static bool DeleteOrder(int PurchaseHeaderID, int UserID)
        {
            DatabaseHelper oDatabaseHelper = new DatabaseHelper();
            bool ExecutionState = false;
            // Pass the value of '_deletedBy' as parameter 'DeletedBy' of the stored procedure.
            oDatabaseHelper.AddParameter("@UserID", UserID);
            oDatabaseHelper.AddParameter("@PurchaseHeaderID", PurchaseHeaderID);
            oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
            oDatabaseHelper.ExecuteScalar("usp_PURPurchaseHeader_DeleteOrder", ref ExecutionState);
            oDatabaseHelper.Dispose();
            return ExecutionState;
        }

        public static bool CloseOrder(int PurchaseHeaderID, int UserID)
        {
            DatabaseHelper oDatabaseHelper = new DatabaseHelper();
            bool ExecutionState = false;
            // Pass the value of '_deletedBy' as parameter 'DeletedBy' of the stored procedure.
            oDatabaseHelper.AddParameter("@UserID", UserID);
            oDatabaseHelper.AddParameter("@PurchaseHeaderID", PurchaseHeaderID);
            oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
            oDatabaseHelper.ExecuteScalar("usp_PURPurchaseLine_InsertCommit", ref ExecutionState);
            oDatabaseHelper.Dispose();
            return ExecutionState;
        }

		#endregion
		
		#region Methods (Private)
        private static PURPurchaseHeaderCollection PopulateFromReader(IDataReader rdr)
        {
            PURPurchaseHeaderCollection pURPurchaseHeaderCollection = new PURPurchaseHeaderCollection();
            while (rdr.Read())
            {
                PURPurchaseHeader obj = new PURPurchaseHeader();
                obj.PurcaseHeaderID = rdr.GetInt32(rdr.GetOrdinal(PURPurchaseHeaderFields.PurcaseHeaderID));
                obj.PurchaseDate = rdr.GetDateTime(rdr.GetOrdinal(PURPurchaseHeaderFields.PurchaseDate));
                obj.SupplierID = rdr.GetInt32(rdr.GetOrdinal(PURPurchaseHeaderFields.SupplierID));

                if (!rdr.IsDBNull(rdr.GetOrdinal("SupplierName")))
                {
                    obj.SupplierName = rdr.GetString(rdr.GetOrdinal("SupplierName"));
                }
                if (!rdr.IsDBNull(rdr.GetOrdinal(PURPurchaseHeaderFields.InvoiceNumber)))
                {
                    obj.InvoiceNumber = rdr.GetString(rdr.GetOrdinal(PURPurchaseHeaderFields.InvoiceNumber));
                }

                if (!rdr.IsDBNull(rdr.GetOrdinal(PURPurchaseHeaderFields.InvoiceDate)))
                {
                    obj.InvoiceDate = rdr.GetDateTime(rdr.GetOrdinal(PURPurchaseHeaderFields.InvoiceDate));
                }

               // if (!rdr.IsDBNull(rdr.GetOrdinal(PURPurchaseHeaderFields.SellerID)))
               // {
              //      obj.SellerID = rdr.GetInt32(rdr.GetOrdinal(PURPurchaseHeaderFields.SellerID));
              //  }

                //if (!rdr.IsDBNull(rdr.GetOrdinal(PURPurchaseHeaderFields.PaymentTypeID)))
                //{
                //    obj.PaymentTypeID = rdr.GetInt32(rdr.GetOrdinal(PURPurchaseHeaderFields.PaymentTypeID));
                //}

                obj.TotalPrice = rdr.GetDecimal(rdr.GetOrdinal(PURPurchaseHeaderFields.TotalPrice));
                obj.PaidAmount = rdr.GetDecimal(rdr.GetOrdinal(PURPurchaseHeaderFields.PaidAmount));
                obj.RemainingAmount = rdr.GetDecimal(rdr.GetOrdinal(PURPurchaseHeaderFields.RemainingAmount));
                if (!rdr.IsDBNull(rdr.GetOrdinal(PURPurchaseHeaderFields.LastDayToPay)))
                {
                    obj.LastDayToPay = rdr.GetDateTime(rdr.GetOrdinal(PURPurchaseHeaderFields.LastDayToPay));
                }

                obj.TotalDiscountAmount = rdr.GetDecimal(rdr.GetOrdinal(PURPurchaseHeaderFields.TotalDiscountAmount));
                obj.TotalDiscountRatio = rdr.GetDouble(rdr.GetOrdinal(PURPurchaseHeaderFields.TotalDiscountRatio));
                obj.IsClosed = rdr.GetBoolean(rdr.GetOrdinal(PURPurchaseHeaderFields.IsClosed));
                obj.IsVoid = rdr.GetBoolean(rdr.GetOrdinal(PURPurchaseHeaderFields.IsVoid));
                obj.IsPrinted = rdr.GetBoolean(rdr.GetOrdinal(PURPurchaseHeaderFields.IsPrinted));
                obj.ServicePrice = rdr.GetDecimal(rdr.GetOrdinal(PURPurchaseHeaderFields.ServicePrice));
                if (!rdr.IsDBNull(rdr.GetOrdinal(PURPurchaseHeaderFields.TaxTypeID)))
                {
                    obj.TaxTypeID = rdr.GetInt32(rdr.GetOrdinal(PURPurchaseHeaderFields.TaxTypeID));
                }

                if (!rdr.IsDBNull(rdr.GetOrdinal(PURPurchaseHeaderFields.RefuseReasonID)))
                {
                    obj.RefuseReasonID = rdr.GetInt32(rdr.GetOrdinal(PURPurchaseHeaderFields.RefuseReasonID));
                }

                if (!rdr.IsDBNull(rdr.GetOrdinal(PURPurchaseHeaderFields.CreatedBy)))
                {
                    obj.CreatedBy = rdr.GetInt32(rdr.GetOrdinal(PURPurchaseHeaderFields.CreatedBy));
                }

                if (!rdr.IsDBNull(rdr.GetOrdinal(PURPurchaseHeaderFields.CreateDate)))
                {
                    obj.CreateDate = rdr.GetDateTime(rdr.GetOrdinal(PURPurchaseHeaderFields.CreateDate));
                }

                if (!rdr.IsDBNull(rdr.GetOrdinal(PURPurchaseHeaderFields.UpdatedBy)))
                {
                    obj.UpdatedBy = rdr.GetInt32(rdr.GetOrdinal(PURPurchaseHeaderFields.UpdatedBy));
                }

                if (!rdr.IsDBNull(rdr.GetOrdinal(PURPurchaseHeaderFields.updateDate)))
                {
                    obj.updateDate = rdr.GetDateTime(rdr.GetOrdinal(PURPurchaseHeaderFields.updateDate));
                }

                obj.IsDeleted = rdr.GetBoolean(rdr.GetOrdinal(PURPurchaseHeaderFields.IsDeleted));
                if (!rdr.IsDBNull(rdr.GetOrdinal(PURPurchaseHeaderFields.DeletedBy)))
                {
                    obj.DeletedBy = rdr.GetInt32(rdr.GetOrdinal(PURPurchaseHeaderFields.DeletedBy));
                }

                if (!rdr.IsDBNull(rdr.GetOrdinal(PURPurchaseHeaderFields.DeleteDate)))
                {
                    obj.DeleteDate = rdr.GetDateTime(rdr.GetOrdinal(PURPurchaseHeaderFields.DeleteDate));
                }
                pURPurchaseHeaderCollection.Add(obj);
            }
            return pURPurchaseHeaderCollection;
        }
       
		#endregion

	}
	
}
