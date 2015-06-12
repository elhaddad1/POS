//
// Class	:	VPURPurchaseOrder.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	11/4/2015 9:57:47 PM
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
	/// Data access class for the "VPURPurchaseOrder" table.
	/// </summary>
	[Serializable]
	public class VPURPurchaseOrder : VPURPurchaseOrderBase
	{
	
		#region Class Level Variables

		#endregion
		
		#region Constants
		
		#endregion

		#region Constructors / Destructors 
		
		public VPURPurchaseOrder() : base()
		{
		}

		#endregion

		#region Properties

		#endregion

		#region Methods (Public)
        public static VPURPurchaseOrderCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
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

            IDataReader dr = oDatabaseHelper.ExecuteReader("gsp_VPURPurchaseOrder_SelectByField", ref ExecutionState);
            VPURPurchaseOrderCollection VPURPurchaseOrderCollection = PopulateObjectsFromReader(dr);
            dr.Close();
            oDatabaseHelper.Dispose();
            return VPURPurchaseOrderCollection;

        }
		#endregion
		
		#region Methods (Private)
        internal static VPURPurchaseOrderCollection PopulateObjectsFromReader(IDataReader rdr)
        {
            VPURPurchaseOrderCollection list = new VPURPurchaseOrderCollection();

            while (rdr.Read())
            {
                VPURPurchaseOrder obj = new VPURPurchaseOrder();
                obj.SupplierID = rdr.GetInt32(rdr.GetOrdinal(VPURPurchaseOrderFields.SupplierID));
                obj.SupplierName = rdr.GetString(rdr.GetOrdinal(VPURPurchaseOrderFields.SupplierName));
                if (!rdr.IsDBNull(rdr.GetOrdinal(VPURPurchaseOrderFields.Qty)))
                {
                    obj.Qty = rdr.GetDecimal(rdr.GetOrdinal(VPURPurchaseOrderFields.Qty));
                }
                obj.PurchaseLineID = rdr.GetInt32(rdr.GetOrdinal(VPURPurchaseOrderFields.PurchaseLineID));
                if ( !rdr.IsDBNull(rdr.GetOrdinal(VPURPurchaseOrderFields.TotalQty)))
                {
                    obj.TotalQty = rdr.GetDecimal(rdr.GetOrdinal(VPURPurchaseOrderFields.TotalQty)); 
                }
                obj.UnitPrice = rdr.GetDecimal(rdr.GetOrdinal(VPURPurchaseOrderFields.UnitPrice));
                if (!rdr.IsDBNull(rdr.GetOrdinal(VPURPurchaseOrderFields.BatchNumber)))
                {
                    obj.BatchNumber = rdr.GetString(rdr.GetOrdinal(VPURPurchaseOrderFields.BatchNumber));
                }
                if (!rdr.IsDBNull(rdr.GetOrdinal(VPURPurchaseOrderFields.ExpiryDate)))
                {
                    obj.ExpiryDate = rdr.GetDateTime(rdr.GetOrdinal(VPURPurchaseOrderFields.ExpiryDate));
                }
                if (!rdr.IsDBNull(rdr.GetOrdinal(VPURPurchaseOrderFields.TaxValue)))
                {
                    obj.TaxValue = rdr.GetDecimal(rdr.GetOrdinal(VPURPurchaseOrderFields.TaxValue));
                }

                obj.PurcaseHeaderID = rdr.GetInt32(rdr.GetOrdinal(VPURPurchaseOrderFields.PurcaseHeaderID));
                obj.PurchaseDate = rdr.GetDateTime(rdr.GetOrdinal(VPURPurchaseOrderFields.PurchaseDate));
                if (!rdr.IsDBNull(rdr.GetOrdinal(VPURPurchaseOrderFields.InvoiceNumber)))
                {
                    obj.InvoiceNumber = rdr.GetString(rdr.GetOrdinal(VPURPurchaseOrderFields.InvoiceNumber));
                }

                if (!rdr.IsDBNull(rdr.GetOrdinal(VPURPurchaseOrderFields.InvoiceDate)))
                {
                    obj.InvoiceDate = rdr.GetDateTime(rdr.GetOrdinal(VPURPurchaseOrderFields.InvoiceDate));
                }

                if (!rdr.IsDBNull(rdr.GetOrdinal(VPURPurchaseOrderFields.PaymentTypeID)))
                {
                    obj.PaymentTypeID = rdr.GetInt32(rdr.GetOrdinal(VPURPurchaseOrderFields.PaymentTypeID));
                }

                obj.TotalDiscountRatio = rdr.GetDouble(rdr.GetOrdinal(VPURPurchaseOrderFields.TotalDiscountRatio));
                if (!rdr.IsDBNull(rdr.GetOrdinal(VPURPurchaseOrderFields.TaxTypeName)))
                {
                    obj.TaxTypeName = rdr.GetString(rdr.GetOrdinal(VPURPurchaseOrderFields.TaxTypeName));
                }

                obj.IsClosed = rdr.GetBoolean(rdr.GetOrdinal(VPURPurchaseOrderFields.IsClosed));
                obj.IsVoid = rdr.GetBoolean(rdr.GetOrdinal(VPURPurchaseOrderFields.IsVoid));
                if (!rdr.IsDBNull(rdr.GetOrdinal(VPURPurchaseOrderFields.ChequeNumber)))
                {
                    obj.ChequeNumber = rdr.GetDecimal(rdr.GetOrdinal(VPURPurchaseOrderFields.ChequeNumber));
                }

                obj.ProductName = rdr.GetString(rdr.GetOrdinal(VPURPurchaseOrderFields.ProductName));
                if (!rdr.IsDBNull(rdr.GetOrdinal(VPURPurchaseOrderFields.ProductCode)))
                {
                    obj.ProductCode = rdr.GetString(rdr.GetOrdinal(VPURPurchaseOrderFields.ProductCode));
                }

                obj.IsAcceptBatch = rdr.GetBoolean(rdr.GetOrdinal(VPURPurchaseOrderFields.IsAcceptBatch));
                obj.UserFullName = rdr.GetString(rdr.GetOrdinal(VPURPurchaseOrderFields.UserFullName));
                obj.ProductID = rdr.GetInt32(rdr.GetOrdinal(VPURPurchaseOrderFields.ProductID));

                list.Add(obj);
            }
            return list;

        }
		#endregion

	}
	
}
