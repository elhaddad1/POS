//
// Class	:	VSalesReturnHeaderPrimaryKey.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	3/9/2015 4:39:22 PM
//

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Specialized;

namespace POS.DataLayer
{
	public class VSalesReturnHeaderPrimaryKey
	{

	#region Class Level Variables
			private int?           	_slaesReturnHeaderIDNonDefault	= null;
		private int?           	_salesHeaderIDNonDefault 	= null;
	#endregion

	#region Constants

	#endregion

	#region Constructors / Destructors

		/// <summary>
		/// Constructor setting values for all fields
		/// </summary>
		public VSalesReturnHeaderPrimaryKey(int? slaesReturnHeaderID,int? salesHeaderID) 
		{
	
			
			this._slaesReturnHeaderIDNonDefault = slaesReturnHeaderID;
			
			this._salesHeaderIDNonDefault = salesHeaderID;

		}

		#endregion

	#region Properties

		/// <summary>
		/// This property is mapped to the "SlaesReturnHeaderID" field.  Mandatory.
		/// </summary>
		public int? SlaesReturnHeaderID
		{
			get 
			{ 
				return _slaesReturnHeaderIDNonDefault;
			}
			set 
			{
			
				_slaesReturnHeaderIDNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "SalesHeaderID" field.  Mandatory.
		/// </summary>
		public int? SalesHeaderID
		{
			get 
			{ 
				return _salesHeaderIDNonDefault;
			}
			set 
			{
			
				_salesHeaderIDNonDefault = value; 
			}
		}

		#endregion

	#region Methods (Public)

		/// <summary>
		/// Method to get the list of fields and their values
		/// </summary>
		///
		/// <returns>Name value collection containing the fields and the values</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/9/2015 4:39:22 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public NameValueCollection GetKeysAndValues() 
		{
			NameValueCollection nvc=new NameValueCollection();
			
			nvc.Add("SlaesReturnHeaderID",_slaesReturnHeaderIDNonDefault.ToString());
			nvc.Add("SalesHeaderID",_salesHeaderIDNonDefault.ToString());
			return nvc;
			
		}

		#endregion	
		
	#region Methods (Private)

	#endregion

	}
}
