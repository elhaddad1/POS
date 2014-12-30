//
// Class	:	ADUserBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:56:08 PM
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
	public class ADUserFields
	{
		public const string UserID                    = "UserID";
		public const string UserFullName              = "UserFullName";
		public const string UserName                  = "UserName";
		public const string Password                  = "Password";
		public const string GroupID                   = "GroupID";
		public const string Email                     = "Email";
		public const string Address                   = "Address";
		public const string Phone                     = "Phone";
		public const string Mobile                    = "Mobile";
	}
	
	/// <summary>
	/// Data access class for the "ADUser" table.
	/// </summary>
	[Serializable]
	public class ADUserBase
	{
		
		#region Class Level Variables
		
		private DatabaseHelper oDatabaseHelper = new DatabaseHelper();

		private int?           	_userIDNonDefault        	= null;
		private string         	_userFullNameNonDefault  	= null;
		private string         	_userNameNonDefault      	= null;
		private string         	_passwordNonDefault      	= null;
		private int?           	_groupIDNonDefault       	= null;
		private string         	_emailNonDefault         	= null;
		private string         	_addressNonDefault       	= null;
		private string         	_phoneNonDefault         	= null;
		private string         	_mobileNonDefault        	= null;

		private SALSalesHeaderCollection _sALSalesHeaderCollectionSellerID = null;
		
		#endregion
		
		#region Constants
		
		#endregion
		
		#region Constructors / Destructors

		/// <summary>
		/// Class Constructor
		///</summary>
		public ADUserBase() { }
					
		#endregion
		
		#region Properties

		/// <summary>
		/// Returns the identifier of the persistent object. Don't set it manually!
		/// </summary>
		public int UserID
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
		/// This property is mapped to the "UserFullName" field. Length must be between 0 and 255 characters. Mandatory.
		/// </summary>
		public string UserFullName
		{
			get 
			{ 
				if(_userFullNameNonDefault==null)return _userFullNameNonDefault;
				else return _userFullNameNonDefault.Trim(); 
			}
			set 
			{
			    if (value == null)
					throw new ArgumentNullException("value", "Value is null.");
				   if (value != null && value.Length > 255)
					throw new ArgumentException("UserFullName length must be between 0 and 255 characters.");

				
				if(value ==null)
				{
					_userFullNameNonDefault =null;//null value 
				}
				else
				{		           
					_userFullNameNonDefault = value.Trim(); 
				}
			}
		}

		/// <summary>
		/// This property is mapped to the "UserName" field. Length must be between 0 and 50 characters. Mandatory.
		/// </summary>
		public string UserName
		{
			get 
			{ 
				if(_userNameNonDefault==null)return _userNameNonDefault;
				else return _userNameNonDefault.Trim(); 
			}
			set 
			{
			    if (value == null)
					throw new ArgumentNullException("value", "Value is null.");
				   if (value != null && value.Length > 50)
					throw new ArgumentException("UserName length must be between 0 and 50 characters.");

				
				if(value ==null)
				{
					_userNameNonDefault =null;//null value 
				}
				else
				{		           
					_userNameNonDefault = value.Trim(); 
				}
			}
		}

		/// <summary>
		/// This property is mapped to the "Password" field. Length must be between 0 and 50 characters. 
		/// </summary>
		public string Password
		{
			get 
			{ 
				if(_passwordNonDefault==null)return _passwordNonDefault;
				else return _passwordNonDefault.Trim(); 
			}
			set 
			{
			    if (value != null && value.Length > 50)
					throw new ArgumentException("Password length must be between 0 and 50 characters.");

				
				if(value ==null)
				{
					_passwordNonDefault =null;//null value 
				}
				else
				{		           
					_passwordNonDefault = value.Trim(); 
				}
			}
		}

		/// <summary>
		/// The foreign key connected with another persistent object.
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
		/// This property is mapped to the "Email" field. Length must be between 0 and 50 characters. 
		/// </summary>
		public string Email
		{
			get 
			{ 
				if(_emailNonDefault==null)return _emailNonDefault;
				else return _emailNonDefault.Trim(); 
			}
			set 
			{
			    if (value != null && value.Length > 50)
					throw new ArgumentException("Email length must be between 0 and 50 characters.");

				
				if(value ==null)
				{
					_emailNonDefault =null;//null value 
				}
				else
				{		           
					_emailNonDefault = value.Trim(); 
				}
			}
		}

		/// <summary>
		/// This property is mapped to the "Address" field. Length must be between 0 and 2147483647 characters. 
		/// </summary>
		public string Address
		{
			get 
			{ 
				if(_addressNonDefault==null)return _addressNonDefault;
				else return _addressNonDefault.Trim(); 
			}
			set 
			{
			    if (value != null && value.Length > 2147483647)
					throw new ArgumentException("Address length must be between 0 and 2147483647 characters.");

				
				if(value ==null)
				{
					_addressNonDefault =null;//null value 
				}
				else
				{		           
					_addressNonDefault = value.Trim(); 
				}
			}
		}

		/// <summary>
		/// This property is mapped to the "Phone" field. Length must be between 0 and 50 characters. 
		/// </summary>
		public string Phone
		{
			get 
			{ 
				if(_phoneNonDefault==null)return _phoneNonDefault;
				else return _phoneNonDefault.Trim(); 
			}
			set 
			{
			    if (value != null && value.Length > 50)
					throw new ArgumentException("Phone length must be between 0 and 50 characters.");

				
				if(value ==null)
				{
					_phoneNonDefault =null;//null value 
				}
				else
				{		           
					_phoneNonDefault = value.Trim(); 
				}
			}
		}

		/// <summary>
		/// This property is mapped to the "Mobile" field. Length must be between 0 and 50 characters. 
		/// </summary>
		public string Mobile
		{
			get 
			{ 
				if(_mobileNonDefault==null)return _mobileNonDefault;
				else return _mobileNonDefault.Trim(); 
			}
			set 
			{
			    if (value != null && value.Length > 50)
					throw new ArgumentException("Mobile length must be between 0 and 50 characters.");

				
				if(value ==null)
				{
					_mobileNonDefault =null;//null value 
				}
				else
				{		           
					_mobileNonDefault = value.Trim(); 
				}
			}
		}

		/// <summary>
		/// Provides access to the related table 'SALSalesHeader'
		/// </summary>
		public SALSalesHeaderCollection SALSalesHeaderCollectionUsingSellerID
		{
			get 
			{
				if (_sALSalesHeaderCollectionSellerID == null)
				{
					_sALSalesHeaderCollectionSellerID = new SALSalesHeaderCollection();
					_sALSalesHeaderCollectionSellerID = SALSalesHeader.SelectByField("SellerID",UserID, null, TypeOperation.Equal);
				}                
				return _sALSalesHeaderCollectionSellerID; 
			}
			set 
			{
				  _sALSalesHeaderCollectionSellerID = value;
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
		/// DLGenerator			12/27/2014 6:56:08 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool InsertWithDefaultValues(bool getBackValues) 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_userFullName' as parameter 'UserFullName' of the stored procedure.
			if(_userFullNameNonDefault!=null)
			  oDatabaseHelper.AddParameter("@UserFullName", _userFullNameNonDefault);
			else
			  oDatabaseHelper.AddParameter("@UserFullName", DBNull.Value );
			  
			// Pass the value of '_userName' as parameter 'UserName' of the stored procedure.
			if(_userNameNonDefault!=null)
			  oDatabaseHelper.AddParameter("@UserName", _userNameNonDefault);
			else
			  oDatabaseHelper.AddParameter("@UserName", DBNull.Value );
			  
			// Pass the value of '_password' as parameter 'Password' of the stored procedure.
			if(_passwordNonDefault!=null)
			  oDatabaseHelper.AddParameter("@Password", _passwordNonDefault);
			else
			  oDatabaseHelper.AddParameter("@Password", DBNull.Value );
			  
			// Pass the value of '_groupID' as parameter 'GroupID' of the stored procedure.
			if(_groupIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@GroupID", _groupIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@GroupID", DBNull.Value );
			  
			// Pass the value of '_email' as parameter 'Email' of the stored procedure.
			if(_emailNonDefault!=null)
			  oDatabaseHelper.AddParameter("@Email", _emailNonDefault);
			else
			  oDatabaseHelper.AddParameter("@Email", DBNull.Value );
			  
			// Pass the value of '_address' as parameter 'Address' of the stored procedure.
			if(_addressNonDefault!=null)
			  oDatabaseHelper.AddParameter("@Address", _addressNonDefault);
			else
			  oDatabaseHelper.AddParameter("@Address", DBNull.Value );
			  
			// Pass the value of '_phone' as parameter 'Phone' of the stored procedure.
			if(_phoneNonDefault!=null)
			  oDatabaseHelper.AddParameter("@Phone", _phoneNonDefault);
			else
			  oDatabaseHelper.AddParameter("@Phone", DBNull.Value );
			  
			// Pass the value of '_mobile' as parameter 'Mobile' of the stored procedure.
			if(_mobileNonDefault!=null)
			  oDatabaseHelper.AddParameter("@Mobile", _mobileNonDefault);
			else
			  oDatabaseHelper.AddParameter("@Mobile", DBNull.Value );
			  
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			if(!getBackValues )
			{
				oDatabaseHelper.ExecuteScalar("gsp_ADUser_Insert_WithDefaultValues", ref ExecutionState);
			}
			else
			{
				IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_ADUser_Insert_WithDefaultValues_AndReturn", ref ExecutionState);
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
		/// DLGenerator			12/27/2014 6:56:08 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Insert() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_userFullName' as parameter 'UserFullName' of the stored procedure.
			if(_userFullNameNonDefault!=null)
			  oDatabaseHelper.AddParameter("@UserFullName", _userFullNameNonDefault);
			else
			  oDatabaseHelper.AddParameter("@UserFullName", DBNull.Value );
			// Pass the value of '_userName' as parameter 'UserName' of the stored procedure.
			if(_userNameNonDefault!=null)
			  oDatabaseHelper.AddParameter("@UserName", _userNameNonDefault);
			else
			  oDatabaseHelper.AddParameter("@UserName", DBNull.Value );
			// Pass the value of '_password' as parameter 'Password' of the stored procedure.
			if(_passwordNonDefault!=null)
			  oDatabaseHelper.AddParameter("@Password", _passwordNonDefault);
			else
			  oDatabaseHelper.AddParameter("@Password", DBNull.Value );
			// Pass the value of '_groupID' as parameter 'GroupID' of the stored procedure.
			if(_groupIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@GroupID", _groupIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@GroupID", DBNull.Value );
			// Pass the value of '_email' as parameter 'Email' of the stored procedure.
			if(_emailNonDefault!=null)
			  oDatabaseHelper.AddParameter("@Email", _emailNonDefault);
			else
			  oDatabaseHelper.AddParameter("@Email", DBNull.Value );
			// Pass the value of '_address' as parameter 'Address' of the stored procedure.
			if(_addressNonDefault!=null)
			  oDatabaseHelper.AddParameter("@Address", _addressNonDefault);
			else
			  oDatabaseHelper.AddParameter("@Address", DBNull.Value );
			// Pass the value of '_phone' as parameter 'Phone' of the stored procedure.
			if(_phoneNonDefault!=null)
			  oDatabaseHelper.AddParameter("@Phone", _phoneNonDefault);
			else
			  oDatabaseHelper.AddParameter("@Phone", DBNull.Value );
			// Pass the value of '_mobile' as parameter 'Mobile' of the stored procedure.
			if(_mobileNonDefault!=null)
			  oDatabaseHelper.AddParameter("@Mobile", _mobileNonDefault);
			else
			  oDatabaseHelper.AddParameter("@Mobile", DBNull.Value );
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_ADUser_Insert", ref ExecutionState);
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
		/// DLGenerator			12/27/2014 6:56:08 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Update() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_userID' as parameter 'UserID' of the stored procedure.
			oDatabaseHelper.AddParameter("@UserID", _userIDNonDefault );
			
			// Pass the value of '_userFullName' as parameter 'UserFullName' of the stored procedure.
			oDatabaseHelper.AddParameter("@UserFullName", _userFullNameNonDefault );
			
			// Pass the value of '_userName' as parameter 'UserName' of the stored procedure.
			oDatabaseHelper.AddParameter("@UserName", _userNameNonDefault );
			
			// Pass the value of '_password' as parameter 'Password' of the stored procedure.
			oDatabaseHelper.AddParameter("@Password", _passwordNonDefault );
			
			// Pass the value of '_groupID' as parameter 'GroupID' of the stored procedure.
			oDatabaseHelper.AddParameter("@GroupID", _groupIDNonDefault );
			
			// Pass the value of '_email' as parameter 'Email' of the stored procedure.
			oDatabaseHelper.AddParameter("@Email", _emailNonDefault );
			
			// Pass the value of '_address' as parameter 'Address' of the stored procedure.
			oDatabaseHelper.AddParameter("@Address", _addressNonDefault );
			
			// Pass the value of '_phone' as parameter 'Phone' of the stored procedure.
			oDatabaseHelper.AddParameter("@Phone", _phoneNonDefault );
			
			// Pass the value of '_mobile' as parameter 'Mobile' of the stored procedure.
			oDatabaseHelper.AddParameter("@Mobile", _mobileNonDefault );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_ADUser_Update", ref ExecutionState);
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
		/// DLGenerator			12/27/2014 6:56:08 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Delete() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_userID' as parameter 'UserID' of the stored procedure.
			if(_userIDNonDefault!=null)
				oDatabaseHelper.AddParameter("@UserID", _userIDNonDefault );
			else
				oDatabaseHelper.AddParameter("@UserID", DBNull.Value );
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_ADUser_Delete", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will Delete one row from the database using the primary key information
		/// </summary>
		///
		/// <param name="pk" type="ADUserPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>True if succeeded</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:08 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static bool Delete(ADUserPrimaryKey pk) 
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
   
			oDatabaseHelper.ExecuteScalar("gsp_ADUser_Delete", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="ADUserFields">Field of the class ADUser</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		///
		/// <returns>True if succeeded</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:08 PM		Created function
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
			
			oDatabaseHelper.ExecuteScalar("gsp_ADUser_DeleteByField", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="ADUserPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class ADUser</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:08 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static ADUser SelectOne(ADUserPrimaryKey pk)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_ADUser_SelectbyPrimaryKey", ref ExecutionState);
			if (dr.Read())
			{
				ADUser obj=new ADUser();	
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
		/// <returns>list of objects of class ADUser in the form of object of ADUserCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:08 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static ADUserCollection SelectAll()
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_ADUser_SelectAll", ref ExecutionState);
			ADUserCollection ADUserCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return ADUserCollection;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class ADUser</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class ADUser in the form of an object of class ADUserCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:08 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static ADUserCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_ADUser_SelectByField", ref ExecutionState);
			ADUserCollection ADUserCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return ADUserCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number</param>
		///
		/// <returns>list of objects of class ADUser in the form of object of ADUserCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:08 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static ADUserCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// Pass the specified field and its value to the stored procedure.
			oDatabaseHelper.AddParameter("@PageSize",pageSize);
			oDatabaseHelper.AddParameter("@SkipPages", skipPages);
			oDatabaseHelper.AddParameter("@OrderByStatement", orderByStatement );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_ADUser_SelectAllPaged", ref ExecutionState);
			ADUserCollection ADUserCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return ADUserCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class ADUser</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class ADUser in the form of an object of class ADUserCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:08 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static ADUserCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_ADUser_SelectByFieldPaged", ref ExecutionState);
			ADUserCollection ADUserCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return ADUserCollection;
			
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
		/// DLGenerator			12/27/2014 6:56:08 PM		Created function
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
			
			Object dr=oDatabaseHelper.ExecuteScalar("gsp_ADUser_SelectAllCount");
			int count = Convert.ToInt32(dr);		
			oDatabaseHelper.Dispose();
			return count;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="ADUserPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class ADUser</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:08 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static ADUser SelectOneWithSALSalesHeaderUsingSellerID(ADUserPrimaryKey pk)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			ADUser obj=null;
			
			// Pass the values of all key parameters to the stored procedure.
			System.Collections.Specialized.NameValueCollection nvc = pk.GetKeysAndValues();
			foreach (string key in nvc.Keys)
			{
				oDatabaseHelper.AddParameter("@" + key,nvc[key] );
			}
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_ADUser_SelectOneWithSALSalesHeaderUsingSellerID", ref ExecutionState);
			if (dr.Read())
			{
				obj= new ADUser();
				PopulateObjectFromReader(obj,dr);
				
				dr.NextResult();
				
				//Get the child records.
				obj.SALSalesHeaderCollectionUsingSellerID=SALSalesHeader.PopulateObjectsFromReader(dr);
			}
			dr.Close();  
			oDatabaseHelper.Dispose();
			return obj;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="ADGroupPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class ADUserCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:08 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static ADUserCollection SelectAllByForeignKeyGroupID(ADGroupPrimaryKey pk)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			ADUserCollection obj = null;
			
			// Pass the values of all key parameters to the stored procedure.
			System.Collections.Specialized.NameValueCollection nvc = pk.GetKeysAndValues();
			foreach (string key in nvc.Keys)
			{
				oDatabaseHelper.AddParameter("@" + key,nvc[key] );
			}
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_ADUser_SelectAllByForeignKeyGroupID", ref ExecutionState);
			obj = new ADUserCollection();
			obj = ADUser.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
			dr.Close();  
			oDatabaseHelper.Dispose();
			return obj;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="ADGroupPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number</param>
		///
		/// <returns>object of class ADUserCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:08 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static ADUserCollection SelectAllByForeignKeyGroupIDPaged(ADGroupPrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			ADUserCollection obj = null;
			
			// Pass the values of all key parameters to the stored procedure.
			System.Collections.Specialized.NameValueCollection nvc = pk.GetKeysAndValues();
			foreach (string key in nvc.Keys)
			{
				oDatabaseHelper.AddParameter("@" + key,nvc[key] );
			}
			oDatabaseHelper.AddParameter("@PageSize",pageSize);
			oDatabaseHelper.AddParameter("@SkipPages", skipPages);
			oDatabaseHelper.AddParameter("@OrderByStatement", orderByStatement );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_ADUser_SelectAllByForeignKeyGroupIDPaged", ref ExecutionState);
			obj = new ADUserCollection();
			obj = ADUser.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
			dr.Close();  
			oDatabaseHelper.Dispose();
			return obj;
			
		}

		/// <summary>
		/// This method will delete row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="ADGroupPrimaryKey">Primary Key information based on which data is to be deleted.</param>
		///
		/// <returns>object of boolean type as an indicator for operation success .</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:08 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static bool DeleteAllByForeignKeyGroupID(ADGroupPrimaryKey pk)
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
			
			oDatabaseHelper.ExecuteNonQuery("gsp_ADUser_DeleteAllByForeignKeyGroupID", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
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
		/// DLGenerator			12/27/2014 6:56:08 PM		Created function
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
		/// <param name="obj" type="ADUser">Object of ADUser to populate</param>
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:08 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static void PopulateObjectFromReader(ADUserBase obj,IDataReader rdr) 
		{

			obj.UserID = rdr.GetInt32(rdr.GetOrdinal(ADUserFields.UserID));
			obj.UserFullName = rdr.GetString(rdr.GetOrdinal(ADUserFields.UserFullName));
			obj.UserName = rdr.GetString(rdr.GetOrdinal(ADUserFields.UserName));
			if (!rdr.IsDBNull(rdr.GetOrdinal(ADUserFields.Password)))
			{
				obj.Password = rdr.GetString(rdr.GetOrdinal(ADUserFields.Password));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(ADUserFields.GroupID)))
			{
				obj.GroupID = rdr.GetInt32(rdr.GetOrdinal(ADUserFields.GroupID));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(ADUserFields.Email)))
			{
				obj.Email = rdr.GetString(rdr.GetOrdinal(ADUserFields.Email));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(ADUserFields.Address)))
			{
				obj.Address = rdr.GetString(rdr.GetOrdinal(ADUserFields.Address));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(ADUserFields.Phone)))
			{
				obj.Phone = rdr.GetString(rdr.GetOrdinal(ADUserFields.Phone));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(ADUserFields.Mobile)))
			{
				obj.Mobile = rdr.GetString(rdr.GetOrdinal(ADUserFields.Mobile));
			}
			

		}

		/// <summary>
		/// Populates the fields for multiple objects from the columns found in an open reader.
		/// </summary>
		///
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <returns>Object of ADUserCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:08 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static ADUserCollection PopulateObjectsFromReader(IDataReader rdr) 
		{
			ADUserCollection list = new ADUserCollection();
			
			while (rdr.Read())
			{
				ADUser obj = new ADUser();
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
		/// <returns>Object of ADUserCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:08 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static ADUserCollection PopulateObjectsFromReaderWithCheckingReader(IDataReader rdr, DatabaseHelper oDatabaseHelper) 
		{

			ADUserCollection list = new ADUserCollection();
			
            if (rdr.Read())
			{
				ADUser obj = new ADUser();
				PopulateObjectFromReader(obj, rdr);
				list.Add(obj);
				while (rdr.Read())
				{
					obj = new ADUser();
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
