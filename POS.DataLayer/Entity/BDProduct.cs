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
        private int? _basicQtyNonDefault = null;
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
        public int? TotalQty
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

        #endregion

        #region Methods (Private)

        #endregion

    }

}
