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
        private string _productNameNonDefault = null;
		#endregion
		
		#region Constants
		
		#endregion

		#region Constructors / Destructors 
		
		public SALSalesLine() : base()
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

		#endregion
		
		#region Methods (Private)

		#endregion

	}
	
}
