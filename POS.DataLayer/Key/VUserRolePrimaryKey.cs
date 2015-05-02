//
// Class	:	VUserRolePrimaryKey.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	5/2/2015 4:13:16 AM
//

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Specialized;

namespace POS.DataLayer
{
	public class VUserRolePrimaryKey
	{

	#region Class Level Variables
			private int?           	_userIDNonDefault        	= null;
		private int?           	_groupIDNonDefault       	= null;
		private int?           	_expr1NonDefault         	= null;
	#endregion

	#region Constants

	#endregion

	#region Constructors / Destructors

		/// <summary>
		/// Constructor setting values for all fields
		/// </summary>
		public VUserRolePrimaryKey(int? userID,int? groupID,int? expr1) 
		{
	
			
			this._userIDNonDefault = userID;
			
			this._groupIDNonDefault = groupID;
			
			this._expr1NonDefault = expr1;

		}

		#endregion

	#region Properties

		/// <summary>
		/// This property is mapped to the "UserID" field.  Mandatory.
		/// </summary>
		public int? UserID
		{
			get 
			{ 
				return _userIDNonDefault;
			}
			set 
			{
			
				_userIDNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "GroupID" field.  Mandatory.
		/// </summary>
		public int? GroupID
		{
			get 
			{ 
				return _groupIDNonDefault;
			}
			set 
			{
			
				_groupIDNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "Expr1" field.  Mandatory.
		/// </summary>
		public int? Expr1
		{
			get 
			{ 
				return _expr1NonDefault;
			}
			set 
			{
			
				_expr1NonDefault = value; 
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
		/// DLGenerator			5/2/2015 4:13:16 AM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public NameValueCollection GetKeysAndValues() 
		{
			NameValueCollection nvc=new NameValueCollection();
			
			nvc.Add("UserID",_userIDNonDefault.ToString());
			nvc.Add("GroupID",_groupIDNonDefault.ToString());
			nvc.Add("Expr1",_expr1NonDefault.ToString());
			return nvc;
			
		}

		#endregion	
		
	#region Methods (Private)

	#endregion

	}
}
