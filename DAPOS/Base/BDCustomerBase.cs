//
// Class	:	BDCustomerBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	12/26/2014 2:45:55 AM
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

namespace DAPOS
{

	/// <summary>
	/// Class for the properties of the object
	/// </summary>
	public class BDCustomerFields
	{
		public const string CustomerID                = "CustomerID";
		public const string CustomerName              = "CustomerName";
		public const string CustomerCode              = "CustomerCode";
		public const string Address                   = "Address";
		public const string Phone1                    = "Phone1";
		public const string Phone2                    = "Phone2";
		public const string Mobile1                   = "Mobile1";
		public const string Mobile2                   = "Mobile2";
		public const string Email                     = "Email";
		public const string IsActive                  = "IsActive";
	}
	
	/// <summary>
	/// Data access class for the "BDCustomer" table.
	/// </summary>
	[Serializable]
	public class BDCustomerBase
	{
		
		#region Class Level Variables
		
		private DatabaseHelper oDatabaseHelper = new DatabaseHelper();

		private int?           	_customerIDNonDefault    	= null;
		private string         	_customerNameNonDefault  	= null;
		private string         	_customerCodeNonDefault  	= null;
		private string         	_addressNonDefault       	= null;
		private string         	_phone1NonDefault        	= null;
		private string         	_phone2NonDefault        	= null;
		private string         	_mobile1NonDefault       	= null;
		private string         	_mobile2NonDefault       	= null;
		private string         	_emailNonDefault         	= null;
		private bool?          	_isActiveNonDefault      	= null;

		private SALSalesHeaderCollection _sALSalesHeaderCollectionCustomerID = null;
		
		#endregion
		
		#region Constants
		
		#endregion
		
		#region Constructors / Destructors

		/// <summary>
		/// Class Constructor
		///</summary>
		public BDCustomerBase() { }
					
		#endregion
		
		#region Properties

		/// <summary>
		/// Returns the identifier of the persistent object. Don't set it manually!
		/// </summary>
		public int? CustomerID
		{
			get 
			{ 
				return _customerIDNonDefault;
			}
			set 
			{
			
				_customerIDNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "CustomerName" field. Length must be between 0 and 50 characters. Mandatory.
		/// </summary>
		public string CustomerName
		{
			get 
			{ 
				if(_customerNameNonDefault==null)return _customerNameNonDefault;
				else return _customerNameNonDefault.Trim(); 
			}
			set 
			{
			    if (value == null)
					throw new ArgumentNullException("value", "Value is null.");
				   if (value != null && value.Length > 50)
					throw new ArgumentException("CustomerName length must be between 0 and 50 characters.");

				
				if(value ==null)
				{
					_customerNameNonDefault =null;//null value 
				}
				else
				{		           
					_customerNameNonDefault = value.Trim(); 
				}
			}
		}

		/// <summary>
		/// This property is mapped to the "CustomerCode" field. Length must be between 0 and 50 characters. 
		/// </summary>
		public string CustomerCode
		{
			get 
			{ 
				if(_customerCodeNonDefault==null)return _customerCodeNonDefault;
				else return _customerCodeNonDefault.Trim(); 
			}
			set 
			{
			    if (value != null && value.Length > 50)
					throw new ArgumentException("CustomerCode length must be between 0 and 50 characters.");

				
				if(value ==null)
				{
					_customerCodeNonDefault =null;//null value 
				}
				else
				{		           
					_customerCodeNonDefault = value.Trim(); 
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
		/// This property is mapped to the "Phone1" field. Length must be between 0 and 50 characters. 
		/// </summary>
		public string Phone1
		{
			get 
			{ 
				if(_phone1NonDefault==null)return _phone1NonDefault;
				else return _phone1NonDefault.Trim(); 
			}
			set 
			{
			    if (value != null && value.Length > 50)
					throw new ArgumentException("Phone1 length must be between 0 and 50 characters.");

				
				if(value ==null)
				{
					_phone1NonDefault =null;//null value 
				}
				else
				{		           
					_phone1NonDefault = value.Trim(); 
				}
			}
		}

		/// <summary>
		/// This property is mapped to the "Phone2" field. Length must be between 0 and 50 characters. 
		/// </summary>
		public string Phone2
		{
			get 
			{ 
				if(_phone2NonDefault==null)return _phone2NonDefault;
				else return _phone2NonDefault.Trim(); 
			}
			set 
			{
			    if (value != null && value.Length > 50)
					throw new ArgumentException("Phone2 length must be between 0 and 50 characters.");

				
				if(value ==null)
				{
					_phone2NonDefault =null;//null value 
				}
				else
				{		           
					_phone2NonDefault = value.Trim(); 
				}
			}
		}

		/// <summary>
		/// This property is mapped to the "Mobile1" field. Length must be between 0 and 50 characters. 
		/// </summary>
		public string Mobile1
		{
			get 
			{ 
				if(_mobile1NonDefault==null)return _mobile1NonDefault;
				else return _mobile1NonDefault.Trim(); 
			}
			set 
			{
			    if (value != null && value.Length > 50)
					throw new ArgumentException("Mobile1 length must be between 0 and 50 characters.");

				
				if(value ==null)
				{
					_mobile1NonDefault =null;//null value 
				}
				else
				{		           
					_mobile1NonDefault = value.Trim(); 
				}
			}
		}

		/// <summary>
		/// This property is mapped to the "Mobile2" field. Length must be between 0 and 50 characters. 
		/// </summary>
		public string Mobile2
		{
			get 
			{ 
				if(_mobile2NonDefault==null)return _mobile2NonDefault;
				else return _mobile2NonDefault.Trim(); 
			}
			set 
			{
			    if (value != null && value.Length > 50)
					throw new ArgumentException("Mobile2 length must be between 0 and 50 characters.");

				
				if(value ==null)
				{
					_mobile2NonDefault =null;//null value 
				}
				else
				{		           
					_mobile2NonDefault = value.Trim(); 
				}
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
		/// This property is mapped to the "IsActive" field.  
		/// </summary>
		public bool? IsActive
		{
			get 
			{ 
				return _isActiveNonDefault;
			}
			set 
			{
			
				_isActiveNonDefault = value; 
			}
		}

		/// <summary>
		/// Provides access to the related table 'SALSalesHeader'
		/// </summary>
		public SALSalesHeaderCollection SALSalesHeaderCollectionUsingCustomerID
		{
			get 
			{
				if (_sALSalesHeaderCollectionCustomerID == null)
				{
					_sALSalesHeaderCollectionCustomerID = new SALSalesHeaderCollection();
					_sALSalesHeaderCollectionCustomerID = SALSalesHeader.SelectByField("CustomerID",CustomerID, null, TypeOperation.Equal);
				}                
				return _sALSalesHeaderCollectionCustomerID; 
			}
			set 
			{
				  _sALSalesHeaderCollectionCustomerID = value;
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
		/// DLGenerator			12/26/2014 2:45:55 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool InsertWithDefaultValues(bool getBackValues) 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_customerName' as parameter 'CustomerName' of the stored procedure.
			if(_customerNameNonDefault!=null)
			  oDatabaseHelper.AddParameter("@CustomerName", _customerNameNonDefault);
			else
			  oDatabaseHelper.AddParameter("@CustomerName", DBNull.Value );
			  
			// Pass the value of '_customerCode' as parameter 'CustomerCode' of the stored procedure.
			if(_customerCodeNonDefault!=null)
			  oDatabaseHelper.AddParameter("@CustomerCode", _customerCodeNonDefault);
			else
			  oDatabaseHelper.AddParameter("@CustomerCode", DBNull.Value );
			  
			// Pass the value of '_address' as parameter 'Address' of the stored procedure.
			if(_addressNonDefault!=null)
			  oDatabaseHelper.AddParameter("@Address", _addressNonDefault);
			else
			  oDatabaseHelper.AddParameter("@Address", DBNull.Value );
			  
			// Pass the value of '_phone1' as parameter 'Phone1' of the stored procedure.
			if(_phone1NonDefault!=null)
			  oDatabaseHelper.AddParameter("@Phone1", _phone1NonDefault);
			else
			  oDatabaseHelper.AddParameter("@Phone1", DBNull.Value );
			  
			// Pass the value of '_phone2' as parameter 'Phone2' of the stored procedure.
			if(_phone2NonDefault!=null)
			  oDatabaseHelper.AddParameter("@Phone2", _phone2NonDefault);
			else
			  oDatabaseHelper.AddParameter("@Phone2", DBNull.Value );
			  
			// Pass the value of '_mobile1' as parameter 'Mobile1' of the stored procedure.
			if(_mobile1NonDefault!=null)
			  oDatabaseHelper.AddParameter("@Mobile1", _mobile1NonDefault);
			else
			  oDatabaseHelper.AddParameter("@Mobile1", DBNull.Value );
			  
			// Pass the value of '_mobile2' as parameter 'Mobile2' of the stored procedure.
			if(_mobile2NonDefault!=null)
			  oDatabaseHelper.AddParameter("@Mobile2", _mobile2NonDefault);
			else
			  oDatabaseHelper.AddParameter("@Mobile2", DBNull.Value );
			  
			// Pass the value of '_email' as parameter 'Email' of the stored procedure.
			if(_emailNonDefault!=null)
			  oDatabaseHelper.AddParameter("@Email", _emailNonDefault);
			else
			  oDatabaseHelper.AddParameter("@Email", DBNull.Value );
			  
			// Pass the value of '_isActive' as parameter 'IsActive' of the stored procedure.
			if(_isActiveNonDefault!=null)
			  oDatabaseHelper.AddParameter("@IsActive", _isActiveNonDefault);
			else
			  oDatabaseHelper.AddParameter("@IsActive", DBNull.Value );
			  
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			if(!getBackValues )
			{
				oDatabaseHelper.ExecuteScalar("gsp_BDCustomer_Insert_WithDefaultValues", ref ExecutionState);
			}
			else
			{
				IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDCustomer_Insert_WithDefaultValues_AndReturn", ref ExecutionState);
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
		/// DLGenerator			12/26/2014 2:45:55 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Insert() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_customerName' as parameter 'CustomerName' of the stored procedure.
			if(_customerNameNonDefault!=null)
			  oDatabaseHelper.AddParameter("@CustomerName", _customerNameNonDefault);
			else
			  oDatabaseHelper.AddParameter("@CustomerName", DBNull.Value );
			// Pass the value of '_customerCode' as parameter 'CustomerCode' of the stored procedure.
			if(_customerCodeNonDefault!=null)
			  oDatabaseHelper.AddParameter("@CustomerCode", _customerCodeNonDefault);
			else
			  oDatabaseHelper.AddParameter("@CustomerCode", DBNull.Value );
			// Pass the value of '_address' as parameter 'Address' of the stored procedure.
			if(_addressNonDefault!=null)
			  oDatabaseHelper.AddParameter("@Address", _addressNonDefault);
			else
			  oDatabaseHelper.AddParameter("@Address", DBNull.Value );
			// Pass the value of '_phone1' as parameter 'Phone1' of the stored procedure.
			if(_phone1NonDefault!=null)
			  oDatabaseHelper.AddParameter("@Phone1", _phone1NonDefault);
			else
			  oDatabaseHelper.AddParameter("@Phone1", DBNull.Value );
			// Pass the value of '_phone2' as parameter 'Phone2' of the stored procedure.
			if(_phone2NonDefault!=null)
			  oDatabaseHelper.AddParameter("@Phone2", _phone2NonDefault);
			else
			  oDatabaseHelper.AddParameter("@Phone2", DBNull.Value );
			// Pass the value of '_mobile1' as parameter 'Mobile1' of the stored procedure.
			if(_mobile1NonDefault!=null)
			  oDatabaseHelper.AddParameter("@Mobile1", _mobile1NonDefault);
			else
			  oDatabaseHelper.AddParameter("@Mobile1", DBNull.Value );
			// Pass the value of '_mobile2' as parameter 'Mobile2' of the stored procedure.
			if(_mobile2NonDefault!=null)
			  oDatabaseHelper.AddParameter("@Mobile2", _mobile2NonDefault);
			else
			  oDatabaseHelper.AddParameter("@Mobile2", DBNull.Value );
			// Pass the value of '_email' as parameter 'Email' of the stored procedure.
			if(_emailNonDefault!=null)
			  oDatabaseHelper.AddParameter("@Email", _emailNonDefault);
			else
			  oDatabaseHelper.AddParameter("@Email", DBNull.Value );
			// Pass the value of '_isActive' as parameter 'IsActive' of the stored procedure.
			if(_isActiveNonDefault!=null)
			  oDatabaseHelper.AddParameter("@IsActive", _isActiveNonDefault);
			else
			  oDatabaseHelper.AddParameter("@IsActive", DBNull.Value );
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_BDCustomer_Insert", ref ExecutionState);
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
		/// DLGenerator			12/26/2014 2:45:55 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Update() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_customerID' as parameter 'CustomerID' of the stored procedure.
			oDatabaseHelper.AddParameter("@CustomerID", _customerIDNonDefault );
			
			// Pass the value of '_customerName' as parameter 'CustomerName' of the stored procedure.
			oDatabaseHelper.AddParameter("@CustomerName", _customerNameNonDefault );
			
			// Pass the value of '_customerCode' as parameter 'CustomerCode' of the stored procedure.
			oDatabaseHelper.AddParameter("@CustomerCode", _customerCodeNonDefault );
			
			// Pass the value of '_address' as parameter 'Address' of the stored procedure.
			oDatabaseHelper.AddParameter("@Address", _addressNonDefault );
			
			// Pass the value of '_phone1' as parameter 'Phone1' of the stored procedure.
			oDatabaseHelper.AddParameter("@Phone1", _phone1NonDefault );
			
			// Pass the value of '_phone2' as parameter 'Phone2' of the stored procedure.
			oDatabaseHelper.AddParameter("@Phone2", _phone2NonDefault );
			
			// Pass the value of '_mobile1' as parameter 'Mobile1' of the stored procedure.
			oDatabaseHelper.AddParameter("@Mobile1", _mobile1NonDefault );
			
			// Pass the value of '_mobile2' as parameter 'Mobile2' of the stored procedure.
			oDatabaseHelper.AddParameter("@Mobile2", _mobile2NonDefault );
			
			// Pass the value of '_email' as parameter 'Email' of the stored procedure.
			oDatabaseHelper.AddParameter("@Email", _emailNonDefault );
			
			// Pass the value of '_isActive' as parameter 'IsActive' of the stored procedure.
			oDatabaseHelper.AddParameter("@IsActive", _isActiveNonDefault );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_BDCustomer_Update", ref ExecutionState);
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
		/// DLGenerator			12/26/2014 2:45:55 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Delete() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_customerID' as parameter 'CustomerID' of the stored procedure.
			if(_customerIDNonDefault!=null)
				oDatabaseHelper.AddParameter("@CustomerID", _customerIDNonDefault );
			else
				oDatabaseHelper.AddParameter("@CustomerID", DBNull.Value );
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_BDCustomer_Delete", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will Delete one row from the database using the primary key information
		/// </summary>
		///
		/// <param name="pk" type="BDCustomerPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>True if succeeded</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:55 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static bool Delete(BDCustomerPrimaryKey pk) 
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
   
			oDatabaseHelper.ExecuteScalar("gsp_BDCustomer_Delete", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="BDCustomerFields">Field of the class BDCustomer</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		///
		/// <returns>True if succeeded</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:55 AM		Created function
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
			
			oDatabaseHelper.ExecuteScalar("gsp_BDCustomer_DeleteByField", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="BDCustomerPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class BDCustomer</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:55 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static BDCustomer SelectOne(BDCustomerPrimaryKey pk)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDCustomer_SelectbyPrimaryKey", ref ExecutionState);
			if (dr.Read())
			{
				BDCustomer obj=new BDCustomer();	
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
		/// <returns>list of objects of class BDCustomer in the form of object of BDCustomerCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:55 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static BDCustomerCollection SelectAll()
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDCustomer_SelectAll", ref ExecutionState);
			BDCustomerCollection BDCustomerCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return BDCustomerCollection;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class BDCustomer</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class BDCustomer in the form of an object of class BDCustomerCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:55 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static BDCustomerCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDCustomer_SelectByField", ref ExecutionState);
			BDCustomerCollection BDCustomerCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return BDCustomerCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number</param>
		///
		/// <returns>list of objects of class BDCustomer in the form of object of BDCustomerCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:55 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static BDCustomerCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// Pass the specified field and its value to the stored procedure.
			oDatabaseHelper.AddParameter("@PageSize",pageSize);
			oDatabaseHelper.AddParameter("@SkipPages", skipPages);
			oDatabaseHelper.AddParameter("@OrderByStatement", orderByStatement );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDCustomer_SelectAllPaged", ref ExecutionState);
			BDCustomerCollection BDCustomerCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return BDCustomerCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class BDCustomer</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class BDCustomer in the form of an object of class BDCustomerCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:55 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static BDCustomerCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDCustomer_SelectByFieldPaged", ref ExecutionState);
			BDCustomerCollection BDCustomerCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return BDCustomerCollection;
			
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
		/// DLGenerator			12/26/2014 2:45:55 AM		Created function
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
			
			Object dr=oDatabaseHelper.ExecuteScalar("gsp_BDCustomer_SelectAllCount");
			int count = Convert.ToInt32(dr);		
			oDatabaseHelper.Dispose();
			return count;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="BDCustomerPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class BDCustomer</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:55 AM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static BDCustomer SelectOneWithSALSalesHeaderUsingCustomerID(BDCustomerPrimaryKey pk)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			BDCustomer obj=null;
			
			// Pass the values of all key parameters to the stored procedure.
			System.Collections.Specialized.NameValueCollection nvc = pk.GetKeysAndValues();
			foreach (string key in nvc.Keys)
			{
				oDatabaseHelper.AddParameter("@" + key,nvc[key] );
			}
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDCustomer_SelectOneWithSALSalesHeaderUsingCustomerID", ref ExecutionState);
			if (dr.Read())
			{
				obj= new BDCustomer();
				PopulateObjectFromReader(obj,dr);
				
				dr.NextResult();
				
				//Get the child records.
				obj.SALSalesHeaderCollectionUsingCustomerID=SALSalesHeader.PopulateObjectsFromReader(dr);
			}
			dr.Close();  
			oDatabaseHelper.Dispose();
			return obj;
			
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
		/// DLGenerator			12/26/2014 2:45:55 AM		Created function
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
		/// <param name="obj" type="BDCustomer">Object of BDCustomer to populate</param>
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:55 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static void PopulateObjectFromReader(BDCustomerBase obj,IDataReader rdr) 
		{

			obj.CustomerID = rdr.GetInt32(rdr.GetOrdinal(BDCustomerFields.CustomerID));
			obj.CustomerName = rdr.GetString(rdr.GetOrdinal(BDCustomerFields.CustomerName));
			if (!rdr.IsDBNull(rdr.GetOrdinal(BDCustomerFields.CustomerCode)))
			{
				obj.CustomerCode = rdr.GetString(rdr.GetOrdinal(BDCustomerFields.CustomerCode));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(BDCustomerFields.Address)))
			{
				obj.Address = rdr.GetString(rdr.GetOrdinal(BDCustomerFields.Address));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(BDCustomerFields.Phone1)))
			{
				obj.Phone1 = rdr.GetString(rdr.GetOrdinal(BDCustomerFields.Phone1));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(BDCustomerFields.Phone2)))
			{
				obj.Phone2 = rdr.GetString(rdr.GetOrdinal(BDCustomerFields.Phone2));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(BDCustomerFields.Mobile1)))
			{
				obj.Mobile1 = rdr.GetString(rdr.GetOrdinal(BDCustomerFields.Mobile1));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(BDCustomerFields.Mobile2)))
			{
				obj.Mobile2 = rdr.GetString(rdr.GetOrdinal(BDCustomerFields.Mobile2));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(BDCustomerFields.Email)))
			{
				obj.Email = rdr.GetString(rdr.GetOrdinal(BDCustomerFields.Email));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(BDCustomerFields.IsActive)))
			{
				obj.IsActive = rdr.GetBoolean(rdr.GetOrdinal(BDCustomerFields.IsActive));
			}
			

		}

		/// <summary>
		/// Populates the fields for multiple objects from the columns found in an open reader.
		/// </summary>
		///
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <returns>Object of BDCustomerCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:55 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static BDCustomerCollection PopulateObjectsFromReader(IDataReader rdr) 
		{
			BDCustomerCollection list = new BDCustomerCollection();
			
			while (rdr.Read())
			{
				BDCustomer obj = new BDCustomer();
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
		/// <returns>Object of BDCustomerCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:55 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static BDCustomerCollection PopulateObjectsFromReaderWithCheckingReader(IDataReader rdr, DatabaseHelper oDatabaseHelper) 
		{

			BDCustomerCollection list = new BDCustomerCollection();
			
            if (rdr.Read())
			{
				BDCustomer obj = new BDCustomer();
				PopulateObjectFromReader(obj, rdr);
				list.Add(obj);
				while (rdr.Read())
				{
					obj = new BDCustomer();
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
