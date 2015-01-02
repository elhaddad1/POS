//
// Class	:	VUserRoleBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	1/2/2015 2:16:12 AM
//

using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Collections;
using System.Data.Common;
using System.IO;
using System.Xml;

namespace POS.DataLayer
{

	/// <summary>
	/// Class for the properties of the object
	/// </summary>
	public class VUserRoleFields
	{
		public const string UserID                    = "UserID";
		public const string GroupID                   = "GroupID";
		public const string GroupName                 = "GroupName";
		public const string RoleName                  = "RoleName";
		public const string RolePath                  = "RolePath";
		public const string Expr1                     = "Expr1";
	}
	
	/// <summary>
	/// Data access class for the "VUserRoles" table.
	/// </summary>
	[Serializable]
	public class VUserRoleBase
	{
		
		#region Class Level Variables
		
		private DatabaseHelper oDatabaseHelper = new DatabaseHelper();

		private int?           	_userIDNonDefault        	= null;
		private int?           	_groupIDNonDefault       	= null;
		private string         	_groupNameNonDefault     	= null;
		private string         	_roleNameNonDefault      	= null;
		private string         	_rolePathNonDefault      	= null;
		private int?           	_expr1NonDefault         	= null;
		
		#endregion
		
		#region Constants
		
		#endregion
		
		#region Constructors / Destructors

		/// <summary>
		/// Class Constructor
		///</summary>
		public VUserRoleBase() { }
					
		#endregion
		
		#region Properties

		/// <summary>
		/// Returns the identifier of the persistent object. Mandatory.
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
		/// Returns the identifier of the persistent object. Mandatory.
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
		/// This property is mapped to the "GroupName" field. Length must be between 0 and 50 characters. 
		/// </summary>
		public string GroupName
		{
			get 
			{ 
				if(_groupNameNonDefault==null)return _groupNameNonDefault;
				else return _groupNameNonDefault.Trim(); 
			}
			set 
			{
			    if (value != null && value.Length > 50)
					throw new ArgumentException("GroupName length must be between 0 and 50 characters.");

				
				if(value ==null)
				{
					_groupNameNonDefault =null;//null value 
				}
				else
				{		           
					_groupNameNonDefault = value.Trim(); 
				}
			}
		}

		/// <summary>
		/// This property is mapped to the "RoleName" field. Length must be between 0 and 50 characters. 
		/// </summary>
		public string RoleName
		{
			get 
			{ 
				if(_roleNameNonDefault==null)return _roleNameNonDefault;
				else return _roleNameNonDefault.Trim(); 
			}
			set 
			{
			    if (value != null && value.Length > 50)
					throw new ArgumentException("RoleName length must be between 0 and 50 characters.");

				
				if(value ==null)
				{
					_roleNameNonDefault =null;//null value 
				}
				else
				{		           
					_roleNameNonDefault = value.Trim(); 
				}
			}
		}

		/// <summary>
		/// This property is mapped to the "RolePath" field. Length must be between 0 and 255 characters. 
		/// </summary>
		public string RolePath
		{
			get 
			{ 
				if(_rolePathNonDefault==null)return _rolePathNonDefault;
				else return _rolePathNonDefault.Trim(); 
			}
			set 
			{
			    if (value != null && value.Length > 255)
					throw new ArgumentException("RolePath length must be between 0 and 255 characters.");

				
				if(value ==null)
				{
					_rolePathNonDefault =null;//null value 
				}
				else
				{		           
					_rolePathNonDefault = value.Trim(); 
				}
			}
		}

		/// <summary>
		/// Returns the identifier of the persistent object. Mandatory.
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
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="VUserRolePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class VUserRole</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			1/2/2015 2:16:12 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static VUserRole SelectOne(VUserRolePrimaryKey pk)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// Pass the values of all key parameters to the stored procedure.
			System.Collections.Specialized.NameValueCollection nvc = pk.GetKeysAndValues();
			foreach (string key in nvc.Keys)
			{
				oDatabaseHelper.AddParameter("@" + key,nvc[key] );
			}
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_VUserRoles_SelectbyPrimaryKey", ref ExecutionState);
			if (dr.Read())
			{
				VUserRole obj=new VUserRole();	
				PopulateObjectFromReader(obj,dr);
				dr.Close();              
				oDatabaseHelper.Dispose();
				return obj;
			}
			else
			{
				dr.Close();
				oDatabaseHelper.Dispose();
				return null;
			}
			
		}

		/// <summary>
		/// This method will return a list of objects representing all records in the table.
		/// </summary>
		///
		/// <returns>list of objects of class VUserRole in the form of object of VUserRoleCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			1/2/2015 2:16:12 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static VUserRoleCollection SelectAll()
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_VUserRoles_SelectAll", ref ExecutionState);
			VUserRoleCollection VUserRoleCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return VUserRoleCollection;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class VUserRole</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class VUserRole in the form of an object of class VUserRoleCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			1/2/2015 2:16:12 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static VUserRoleCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// Pass the specified field and its value to the stored procedure.
			oDatabaseHelper.AddParameter("@Field",field);
			oDatabaseHelper.AddParameter("@Value", fieldValue );
			oDatabaseHelper.AddParameter("@Value2", fieldValue2 );
			oDatabaseHelper.AddParameter("@Operation", OperationCollection.Operation[(int)typeOperation] );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_VUserRoles_SelectByField", ref ExecutionState);
			VUserRoleCollection VUserRoleCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return VUserRoleCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number</param>
		///
		/// <returns>list of objects of class VUserRole in the form of object of VUserRoleCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			1/2/2015 2:16:12 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static VUserRoleCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// Pass the specified field and its value to the stored procedure.
			oDatabaseHelper.AddParameter("@PageSize",pageSize);
			oDatabaseHelper.AddParameter("@SkipPages", skipPages);
			oDatabaseHelper.AddParameter("@OrderByStatement", orderByStatement );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_VUserRoles_SelectAllPaged", ref ExecutionState);
			VUserRoleCollection VUserRoleCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return VUserRoleCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class VUserRole</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class VUserRole in the form of an object of class VUserRoleCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			1/2/2015 2:16:12 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static VUserRoleCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// Pass the specified field and its value to the stored procedure.
			oDatabaseHelper.AddParameter("@Field",field);
			oDatabaseHelper.AddParameter("@Value", fieldValue );
			oDatabaseHelper.AddParameter("@Value2", fieldValue2 );
			oDatabaseHelper.AddParameter("@Operation", OperationCollection.Operation[(int)typeOperation] );
			oDatabaseHelper.AddParameter("@PageSize",pageSize);
			oDatabaseHelper.AddParameter("@SkipPages", skipPages );
			oDatabaseHelper.AddParameter("@OrderByStatement", orderByStatement );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_VUserRoles_SelectByFieldPaged", ref ExecutionState);
			VUserRoleCollection VUserRoleCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return VUserRoleCollection;
			
		}

		/// <summary>
		/// This method will return a count all records in the table.
		/// </summary>
		///
		/// <returns>count records</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			1/2/2015 2:16:12 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static int SelectAllCount()
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();			
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			Object dr=oDatabaseHelper.ExecuteScalar("gsp_VUserRoles_SelectAllCount");
			int count = Convert.ToInt32(dr);		
			oDatabaseHelper.Dispose();
			return count;
			
		}

		#endregion	
		
		#region Methods (Private)

		/// <summary>
		/// tests a string to be a well formed xml or not,
		/// it throws ArgumentException when string text is not well formed.otherwise this 
		/// method is executed silently .
		/// </summary>
		/// <param name="text" type="string">xml string to validate.</param>
		/// <param name="fieldName" type="string">field Name to validate.</param>
		/// <exception cref="System.ArgumentException"> throws ArgumentException when text is not well formed parameter.otherwise this 
		/// method is executed silently .</exception>
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			1/2/2015 2:16:12 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static void IsValidXmlString(string text,string fieldName)
		{
			XmlTextReader r = new XmlTextReader(new StringReader(text));
			try
			{
				while (r.Read())
				{
				  /*do nothing ,just continue as long as xml is valid*/ 
				}
			}
			catch(Exception)
			{
				throw new ArgumentException ("Field ("+fieldName+") xml text argument isn't well formed");				
			}
			finally
			{
				r.Close();
			
			}
		  //end silently(well formed xml)
		}    
		/// <summary>
		/// Populates the fields of a single objects from the columns found in an open reader.
		/// </summary>
		/// <param name="obj" type="VUserRoles">Object of VUserRoles to populate</param>
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			1/2/2015 2:16:12 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static void PopulateObjectFromReader(VUserRoleBase obj,IDataReader rdr) 
		{

			obj.UserID = rdr.GetInt32(rdr.GetOrdinal(VUserRoleFields.UserID));
			obj.GroupID = rdr.GetInt32(rdr.GetOrdinal(VUserRoleFields.GroupID));
			if (!rdr.IsDBNull(rdr.GetOrdinal(VUserRoleFields.GroupName)))
			{
				obj.GroupName = rdr.GetString(rdr.GetOrdinal(VUserRoleFields.GroupName));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(VUserRoleFields.RoleName)))
			{
				obj.RoleName = rdr.GetString(rdr.GetOrdinal(VUserRoleFields.RoleName));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(VUserRoleFields.RolePath)))
			{
				obj.RolePath = rdr.GetString(rdr.GetOrdinal(VUserRoleFields.RolePath));
			}
			
			obj.Expr1 = rdr.GetInt32(rdr.GetOrdinal(VUserRoleFields.Expr1));

		}

		/// <summary>
		/// Populates the fields for multiple objects from the columns found in an open reader.
		/// </summary>
		///
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <returns>Object of VUserRoleCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			1/2/2015 2:16:12 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static VUserRoleCollection PopulateObjectsFromReader(IDataReader rdr) 
		{
			VUserRoleCollection list = new VUserRoleCollection();
			
			while (rdr.Read())
			{
				VUserRole obj = new VUserRole();
				PopulateObjectFromReader(obj,rdr);
				list.Add(obj);
			}
			return list;
			
		}

		/// <summary>
		/// Populates the fields for multiple objects from the columns found in an open reader.
		/// </summary>
		///
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <returns>Object of VUserRoleCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			1/2/2015 2:16:12 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static VUserRoleCollection PopulateObjectsFromReaderWithCheckingReader(IDataReader rdr, DatabaseHelper oDatabaseHelper) 
		{

			VUserRoleCollection list = new VUserRoleCollection();
			
            if (rdr.Read())
			{
				VUserRole obj = new VUserRole();
				PopulateObjectFromReader(obj, rdr);
				list.Add(obj);
				while (rdr.Read())
				{
					obj = new VUserRole();
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
