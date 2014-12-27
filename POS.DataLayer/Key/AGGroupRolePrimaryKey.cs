//
// Class	:	AGGroupRolePrimaryKey.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:56:01 PM
//

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Specialized;

namespace POS.DataLayer
{
	public class AGGroupRolePrimaryKey
	{

	#region Class Level Variables
			private int?           	_groupRoleIDNonDefault   	= null;
	#endregion

	#region Constants

	#endregion

	#region Constructors / Destructors

		/// <summary>
		/// Constructor setting values for all fields
		/// </summary>
		public AGGroupRolePrimaryKey(int? groupRoleID) 
		{
	
			
			this._groupRoleIDNonDefault = groupRoleID;

		}

		#endregion

	#region Properties

		/// <summary>
		/// This property is mapped to the "GroupRoleID" field.  Mandatory.
		/// </summary>
		public int? GroupRoleID
		{
			get 
			{ 
				return _groupRoleIDNonDefault;
			}
			set 
			{
			
				_groupRoleIDNonDefault = value; 
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
		/// DLGenerator			12/27/2014 6:56:01 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public NameValueCollection GetKeysAndValues() 
		{
			NameValueCollection nvc=new NameValueCollection();
			
			nvc.Add("GroupRoleID",_groupRoleIDNonDefault.ToString());
			return nvc;
			
		}

		#endregion	
		
	#region Methods (Private)

	#endregion

	}
}
