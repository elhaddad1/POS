//
// Class	:	INVBatch.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:56:17 PM
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
    /// Data access class for the "INVBatch" table.
    /// </summary>
    [Serializable]
    public class INVBatch : INVBatchBase
    {

        #region Class Level Variables
        private DatabaseHelper oDatabaseHelper = new DatabaseHelper();

        private int _ProductStockIDNonDefault;
        private decimal _qtyNonDefault;
        #endregion

        #region Constants

        #endregion

        #region Constructors / Destructors

        public INVBatch()
            : base()
        {
        }

        #endregion

        #region Properties
        public int ProductStockID
        {
            get
            {
                return _ProductStockIDNonDefault;
            }
            set
            {

                _ProductStockIDNonDefault = value;
            }
        }

        public decimal Qty
        {
            get
            {
                return _qtyNonDefault;
            }
            set
            {

                _qtyNonDefault = value;
            }
        }

        #endregion

        #region Methods (Public)

        #endregion

        #region Methods (Private)
        public  bool InsertProductStockBatches(int userID, INVBatch iNVBatch)
        {
            bool ExecutionState = false;
            oDatabaseHelper = new DatabaseHelper();
            oDatabaseHelper.AddParameter("@ProductStockID", iNVBatch.ProductStockID);
            oDatabaseHelper.AddParameter("@BatchNumber", iNVBatch.BatchNumber);
            oDatabaseHelper.AddParameter("@ExpiryDate", iNVBatch.ExpiryDate);
            oDatabaseHelper.AddParameter("@Qty", iNVBatch.Qty);

            oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);

            oDatabaseHelper.ExecuteScalar("usp_INVBatch_ProductStockBatch", ref ExecutionState);
            oDatabaseHelper.Dispose();
            return ExecutionState;

        }
        #endregion

    }

}
