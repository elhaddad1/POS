//
// Class	:	BDProduct.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:56:09 PM
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
    /// Data access class for the "BDProduct" table.
    /// </summary>
    [Serializable]
    public class BDProduct : BDProductBase
    {

        #region Class Level Variables
        private decimal? _basicQtyNonDefault = null;
        #endregion

        #region Constants

        #endregion

        #region Constructors / Destructors

        public BDProduct()
            : base()
        {
        }

        #endregion

        #region Properties
        public decimal? TotalQty
        {
            get
            {
                return _basicQtyNonDefault;
            }
            set
            {

                _basicQtyNonDefault = value;
            }
        }
        #endregion

        #region Methods (Public)
        public static BDProductCollection SelectAllProductsByGroupID(int InventoryID, BDProductGroupPrimaryKey pk)
        {
            DatabaseHelper oDatabaseHelper = new DatabaseHelper();
            bool ExecutionState = false;
            BDProductCollection obj = null;

            oDatabaseHelper.AddParameter("@ProductGroupID", pk.ProductGroupID);
            oDatabaseHelper.AddParameter("@InventoryID", InventoryID);
            oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);

            IDataReader dr = oDatabaseHelper.ExecuteReader("usp_SelectAllByGroupID", ref ExecutionState);
            obj = new BDProductCollection();
            obj = PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);

            dr.Close();
            oDatabaseHelper.Dispose();
            return obj;

        }
        #endregion

        #region Methods (Private)
        new private static void PopulateObjectFromReader(BDProduct obj, IDataReader rdr)
        {

            obj.ProductID = rdr.GetInt32(rdr.GetOrdinal(BDProductFields.ProductID));
            obj.ProductName = rdr.GetString(rdr.GetOrdinal(BDProductFields.ProductName));
            obj.ProductGroupID = rdr.GetInt32(rdr.GetOrdinal(BDProductFields.ProductGroupID));
            if (!rdr.IsDBNull(rdr.GetOrdinal(BDProductFields.ProductCode)))
            {
                obj.ProductCode = rdr.GetString(rdr.GetOrdinal(BDProductFields.ProductCode));
            }

            obj.IsAcceptBatch = rdr.GetBoolean(rdr.GetOrdinal(BDProductFields.IsAcceptBatch));
            if (!rdr.IsDBNull(rdr.GetOrdinal(BDProductFields.ProductPrice)))
            {
                obj.ProductPrice = rdr.GetDecimal(rdr.GetOrdinal(BDProductFields.ProductPrice));
            }

            obj.IsFixedPrice = rdr.GetBoolean(rdr.GetOrdinal(BDProductFields.IsFixedPrice));
            obj.HasDiscount = rdr.GetBoolean(rdr.GetOrdinal(BDProductFields.HasDiscount));
            if (!rdr.IsDBNull(rdr.GetOrdinal(BDProductFields.DiscountAmount)))
            {
                obj.DiscountAmount = rdr.GetDecimal(rdr.GetOrdinal(BDProductFields.DiscountAmount));
            }

            if (!rdr.IsDBNull(rdr.GetOrdinal(BDProductFields.DescountRatio)))
            {
                obj.DescountRatio = rdr.GetDouble(rdr.GetOrdinal(BDProductFields.DescountRatio));
            }

            obj.IsActive = rdr.GetBoolean(rdr.GetOrdinal(BDProductFields.IsActive));
            if (!rdr.IsDBNull(rdr.GetOrdinal(BDProductFields.Notes)))
            {
                obj.Notes = rdr.GetString(rdr.GetOrdinal(BDProductFields.Notes));
            }

            if (!rdr.IsDBNull(rdr.GetOrdinal(BDProductFields.MinPrice)))
            {
                obj.MinPrice = rdr.GetDecimal(rdr.GetOrdinal(BDProductFields.MinPrice));
            }

            if (!rdr.IsDBNull(rdr.GetOrdinal(BDProductFields.MaxPrice)))
            {
                obj.MaxPrice = rdr.GetDecimal(rdr.GetOrdinal(BDProductFields.MaxPrice));
            }
            if (!rdr.IsDBNull(rdr.GetOrdinal("TotalQty")))
            {
                obj.TotalQty = rdr.GetDecimal(rdr.GetOrdinal("TotalQty"));
            }

        }

        new private static BDProductCollection PopulateObjectsFromReaderWithCheckingReader(IDataReader rdr, DatabaseHelper oDatabaseHelper)
        {

            BDProductCollection list = new BDProductCollection();

            if (rdr.Read())
            {
                BDProduct obj = new BDProduct();
                PopulateObjectFromReader(obj, rdr);
                list.Add(obj);
                while (rdr.Read())
                {
                    obj = new BDProduct();
                    PopulateObjectFromReader(obj, rdr);
                    list.Add(obj);
                }
                oDatabaseHelper.Dispose();
                return list;
            }
            else
            {
                oDatabaseHelper.Dispose();
                return null;
            }

        }
        #endregion

    }

}
