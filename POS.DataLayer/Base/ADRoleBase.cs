//
// Class	:	ADRoleBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	1/3/2015 2:21:04 AM
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
	public class ADRoleFields
	{
		public const string RoleID                    = "RoleID";
		public const string RoleName                  = "RoleName";
		public const string RolePath                  = "RolePath";
		public const string MenuButton                = "MenuButton";
	}
	
	/// <summary>
	/// Data access class for the "ADRole" table.
	/// </summary>
	[Serializable]
	public class ADRoleBase
	{
		
		#region Class Level Variables
		
		private DatabaseHelper oDatabaseHelper = new DatabaseHelper();

		private int?           	_roleIDNonDefault        	= null;
		private string         	_roleNameNonDefault      	= null;
		private string         	_rolePathNonDefault      	= null;
		private string         	_menuButtonNonDefault    	= null;
		
		#endregion
		
		#region Constants
		
		#endregion
		
		#region Constructors / Destructors

		/// <summary>
		/// Class Constructor
		///</summary>
		public ADRoleBase() { }
					
		#endregion
		
		#region Properties

		/// <summary>
		/// Returns the identifier of the persistent object. Don't set it manually!
		/// </summary>
		public int? RoleID
		{
			get 
			{ 
				return _roleIDNonDefault;
			}
			set 
			{
			
				_roleIDNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "RoleName" field. Length must be between 0 and 50 characters. Mandatory.
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
			    if (value == null)
					throw new ArgumentNullException("value", "Value is null.");
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
		/// This property is mapped to the "RolePath" field. Length must be between 0 and 255 characters. Mandatory.
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
			    if (value == null)
					throw new ArgumentNullException("value", "Value is null.");
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
		/// This property is mapped to the "MenuButton" field. Length must be between 0 and 50 characters. Mandatory.
		/// </summary>
		public string MenuButton
		{
			get 
			{ 
				if(_menuButtonNonDefault==null)return _menuButtonNonDefault;
				else return _menuButtonNonDefault.Trim(); 
			}
			set 
			{
			    if (value == null)
					throw new ArgumentNullException("value", "Value is null.");
				   if (value != null && value.Length > 50)
					throw new ArgumentException("MenuButton length must be between 0 and 50 characters.");

				
				if(value ==null)
				{
					_menuButtonNonDefault =null;//null value 
				}
				else
				{		           
					_menuButtonNonDefault = value.Trim(); 
				}
			}
		}

		#endregion
		
		#region Methods (Public)

		/// <summary>
		/// This method will insert one new row into the database using the property Information
		/// </summary>
		/// <param name="getBackValues" type="bool">Whether to get the default values inserted, from the database</param>
		/// <returns>True if succeeded</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			1/3/2015 2:21:04 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool InsertWithDefaultValues(bool getBackValues) 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_roleName' as parameter 'RoleName' of the stored procedure.
			if(_roleNameNonDefault!=null)
			  oDatabaseHelper.AddParameter("@RoleName", _roleNameNonDefault);
			else
			  oDatabaseHelper.AddParameter("@RoleName", DBNull.Value );
			  
			// Pass the value of '_rolePath' as parameter 'RolePath' of the stored procedure.
			if(_rolePathNonDefault!=null)
			  oDatabaseHelper.AddParameter("@RolePath", _rolePathNonDefault);
			else
			  oDatabaseHelper.AddParameter("@RolePath", DBNull.Value );
			  
			// Pass the value of '_menuButton' as parameter 'MenuButton' of the stored procedure.
			if(_menuButtonNonDefault!=null)
			  oDatabaseHelper.AddParameter("@MenuButton", _menuButtonNonDefault);
			else
			  oDatabaseHelper.AddParameter("@MenuButton", DBNull.Value );
			  
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			if(!getBackValues )
			{
				oDatabaseHelper.ExecuteScalar("gsp_ADRole_Insert_WithDefaultValues", ref ExecutionState);
			}
			else
			{
				IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_ADRole_Insert_WithDefaultValues_AndReturn", ref ExecutionState);
				if (dr.Read())
				{
					PopulateObjectFromReader(this,dr);
				}
				dr.Close();
			}
			oDatabaseHelper.Dispose();	
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will insert one new row into the database using the property Information
		/// </summary>
		/// <returns>True if succeeded</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			1/3/2015 2:21:04 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Insert() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_roleName' as parameter 'RoleName' of the stored procedure.
			if(_roleNameNonDefault!=null)
			  oDatabaseHelper.AddParameter("@RoleName", _roleNameNonDefault);
			else
			  oDatabaseHelper.AddParameter("@RoleName", DBNull.Value );
			// Pass the value of '_rolePath' as parameter 'RolePath' of the stored procedure.
			if(_rolePathNonDefault!=null)
			  oDatabaseHelper.AddParameter("@RolePath", _rolePathNonDefault);
			else
			  oDatabaseHelper.AddParameter("@RolePath", DBNull.Value );
			// Pass the value of '_menuButton' as parameter 'MenuButton' of the stored procedure.
			if(_menuButtonNonDefault!=null)
			  oDatabaseHelper.AddParameter("@MenuButton", _menuButtonNonDefault);
			else
			  oDatabaseHelper.AddParameter("@MenuButton", DBNull.Value );
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_ADRole_Insert", ref ExecutionState);
			oDatabaseHelper.Dispose();	
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will Update one new row into the database using the property Information
		/// </summary>
		///
		/// <returns>True if succeeded</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			1/3/2015 2:21:04 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Update() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_roleID' as parameter 'RoleID' of the stored procedure.
			oDatabaseHelper.AddParameter("@RoleID", _roleIDNonDefault );
			
			// Pass the value of '_roleName' as parameter 'RoleName' of the stored procedure.
			oDatabaseHelper.AddParameter("@RoleName", _roleNameNonDefault );
			
			// Pass the value of '_rolePath' as parameter 'RolePath' of the stored procedure.
			oDatabaseHelper.AddParameter("@RolePath", _rolePathNonDefault );
			
			// Pass the value of '_menuButton' as parameter 'MenuButton' of the stored procedure.
			oDatabaseHelper.AddParameter("@MenuButton", _menuButtonNonDefault );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_ADRole_Update", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will Delete one row from the database using the property Information
		/// </summary>
		///
		/// <returns>True if succeeded</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			1/3/2015 2:21:04 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Delete() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_roleID' as parameter 'RoleID' of the stored procedure.
			if(_roleIDNonDefault!=null)
				oDatabaseHelper.AddParameter("@RoleID", _roleIDNonDefault );
			else
				oDatabaseHelper.AddParameter("@RoleID", DBNull.Value );
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_ADRole_Delete", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will Delete one row from the database using the primary key information
		/// </summary>
		///
		/// <param name="pk" type="ADRolePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>True if succeeded</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			1/3/2015 2:21:04 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static bool Delete(ADRolePrimaryKey pk) 
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
   
			oDatabaseHelper.ExecuteScalar("gsp_ADRole_Delete", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="ADRoleFields">Field of the class ADRole</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		///
		/// <returns>True if succeeded</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			1/3/2015 2:21:04 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static bool DeleteByField(string field, object fieldValue)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// Pass the specified field and its value to the stored procedure.
			oDatabaseHelper.AddParameter("@Field",field);
			oDatabaseHelper.AddParameter("@Value", fieldValue );
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_ADRole_DeleteByField", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="ADRolePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class ADRole</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			1/3/2015 2:21:04 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static ADRole SelectOne(ADRolePrimaryKey pk)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_ADRole_SelectbyPrimaryKey", ref ExecutionState);
			if (dr.Read())
			{
				ADRole obj=new ADRole();	
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
		/// <returns>list of objects of class ADRole in the form of object of ADRoleCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			1/3/2015 2:21:04 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static ADRoleCollection SelectAll()
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_ADRole_SelectAll", ref ExecutionState);
			ADRoleCollection ADRoleCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return ADRoleCollection;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class ADRole</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class ADRole in the form of an object of class ADRoleCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			1/3/2015 2:21:04 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static ADRoleCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_ADRole_SelectByField", ref ExecutionState);
			ADRoleCollection ADRoleCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return ADRoleCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number</param>
		///
		/// <returns>list of objects of class ADRole in the form of object of ADRoleCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			1/3/2015 2:21:04 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static ADRoleCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// Pass the specified field and its value to the stored procedure.
			oDatabaseHelper.AddParameter("@PageSize",pageSize);
			oDatabaseHelper.AddParameter("@SkipPages", skipPages);
			oDatabaseHelper.AddParameter("@OrderByStatement", orderByStatement );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_ADRole_SelectAllPaged", ref ExecutionState);
			ADRoleCollection ADRoleCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return ADRoleCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class ADRole</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class ADRole in the form of an object of class ADRoleCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			1/3/2015 2:21:04 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static ADRoleCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_ADRole_SelectByFieldPaged", ref ExecutionState);
			ADRoleCollection ADRoleCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return ADRoleCollection;
			
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
		/// DLGenerator			1/3/2015 2:21:04 AM		Created function
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
			
			Object dr=oDatabaseHelper.ExecuteScalar("gsp_ADRole_SelectAllCount");
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
		/// DLGenerator			1/3/2015 2:21:04 AM		Created function
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
		/// <param name="obj" type="ADRole">Object of ADRole to populate</param>
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			1/3/2015 2:21:04 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static void PopulateObjectFromReader(ADRoleBase obj,IDataReader rdr) 
		{

			obj.RoleID = rdr.GetInt32(rdr.GetOrdinal(ADRoleFields.RoleID));
			obj.RoleName = rdr.GetString(rdr.GetOrdinal(ADRoleFields.RoleName));
			obj.RolePath = rdr.GetString(rdr.GetOrdinal(ADRoleFields.RolePath));
			obj.MenuButton = rdr.GetString(rdr.GetOrdinal(ADRoleFields.MenuButton));

		}

		/// <summary>
		/// Populates the fields for multiple objects from the columns found in an open reader.
		/// </summary>
		///
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <returns>Object of ADRoleCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			1/3/2015 2:21:04 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static ADRoleCollection PopulateObjectsFromReader(IDataReader rdr) 
		{
			ADRoleCollection list = new ADRoleCollection();
			
			while (rdr.Read())
			{
				ADRole obj = new ADRole();
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
		/// <returns>Object of ADRoleCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			1/3/2015 2:21:04 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static ADRoleCollection PopulateObjectsFromReaderWithCheckingReader(IDataReader rdr, DatabaseHelper oDatabaseHelper) 
		{

			ADRoleCollection list = new ADRoleCollection();
			
            if (rdr.Read())
			{
				ADRole obj = new ADRole();
				PopulateObjectFromReader(obj, rdr);
				list.Add(obj);
				while (rdr.Read())
				{
					obj = new ADRole();
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
