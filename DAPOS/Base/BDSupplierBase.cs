//
// Class	:	BDSupplierBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	12/26/2014 2:45:52 AM
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
	public class BDSupplierFields
	{
		public const string SupplierID                = "SupplierID";
		public const string SupplierCode              = "SupplierCode";
		public const string SupplierName              = "SupplierName";
		public const string Address                   = "Address";
		public const string Phone1                    = "Phone1";
		public const string Phone2                    = "phone2";
		public const string Mobile1                   = "Mobile1";
		public const string Mobile2                   = "Mobile2";
		public const string Email                     = "Email";
		public const string IsActive                  = "IsActive";
	}
	
	/// <summary>
	/// Data access class for the "BDSupplier" table.
	/// </summary>
	[Serializable]
	public class BDSupplierBase
	{
		
		#region Class Level Variables
		
		private DatabaseHelper oDatabaseHelper = new DatabaseHelper();

		private int?           	_supplierIDNonDefault    	= null;
		private string         	_supplierCodeNonDefault  	= null;
		private string         	_supplierNameNonDefault  	= null;
		private string         	_addressNonDefault       	= null;
		private string         	_phone1NonDefault        	= null;
		private string         	_phone2NonDefault        	= null;
		private string         	_mobile1NonDefault       	= null;
		private string         	_mobile2NonDefault       	= null;
		private string         	_emailNonDefault         	= null;
		private bool?          	_isActiveNonDefault      	= null;

		private PURPurchaseHeaderCollection _pURPurchaseHeaderCollectionSupplierID = null;
		
		#endregion
		
		#region Constants
		
		#endregion
		
		#region Constructors / Destructors

		/// <summary>
		/// Class Constructor
		///</summary>
		public BDSupplierBase() { }
					
		#endregion
		
		#region Properties

		/// <summary>
		/// Returns the identifier of the persistent object. Don't set it manually!
		/// </summary>
		public int? SupplierID
		{
			get 
			{ 
				return _supplierIDNonDefault;
			}
			set 
			{
			
				_supplierIDNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "SupplierCode" field. Length must be between 0 and 50 characters. 
		/// </summary>
		public string SupplierCode
		{
			get 
			{ 
				if(_supplierCodeNonDefault==null)return _supplierCodeNonDefault;
				else return _supplierCodeNonDefault.Trim(); 
			}
			set 
			{
			    if (value != null && value.Length > 50)
					throw new ArgumentException("SupplierCode length must be between 0 and 50 characters.");

				
				if(value ==null)
				{
					_supplierCodeNonDefault =null;//null value 
				}
				else
				{		           
					_supplierCodeNonDefault = value.Trim(); 
				}
			}
		}

		/// <summary>
		/// This property is mapped to the "SupplierName" field. Length must be between 0 and 255 characters. Mandatory.
		/// </summary>
		public string SupplierName
		{
			get 
			{ 
				if(_supplierNameNonDefault==null)return _supplierNameNonDefault;
				else return _supplierNameNonDefault.Trim(); 
			}
			set 
			{
			    if (value == null)
					throw new ArgumentNullException("value", "Value is null.");
				   if (value != null && value.Length > 255)
					throw new ArgumentException("SupplierName length must be between 0 and 255 characters.");

				
				if(value ==null)
				{
					_supplierNameNonDefault =null;//null value 
				}
				else
				{		           
					_supplierNameNonDefault = value.Trim(); 
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
		/// This property is mapped to the "phone2" field. Length must be between 0 and 50 characters. 
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
		/// Provides access to the related table 'PURPurchaseHeader'
		/// </summary>
		public PURPurchaseHeaderCollection PURPurchaseHeaderCollectionUsingSupplierID
		{
			get 
			{
				if (_pURPurchaseHeaderCollectionSupplierID == null)
				{
					_pURPurchaseHeaderCollectionSupplierID = new PURPurchaseHeaderCollection();
					_pURPurchaseHeaderCollectionSupplierID = PURPurchaseHeader.SelectByField("SupplierID",SupplierID, null, TypeOperation.Equal);
				}                
				return _pURPurchaseHeaderCollectionSupplierID; 
			}
			set 
			{
				  _pURPurchaseHeaderCollectionSupplierID = value;
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
		/// DLGenerator			12/26/2014 2:45:52 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool InsertWithDefaultValues(bool getBackValues) 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_supplierCode' as parameter 'SupplierCode' of the stored procedure.
			if(_supplierCodeNonDefault!=null)
			  oDatabaseHelper.AddParameter("@SupplierCode", _supplierCodeNonDefault);
			else
			  oDatabaseHelper.AddParameter("@SupplierCode", DBNull.Value );
			  
			// Pass the value of '_supplierName' as parameter 'SupplierName' of the stored procedure.
			if(_supplierNameNonDefault!=null)
			  oDatabaseHelper.AddParameter("@SupplierName", _supplierNameNonDefault);
			else
			  oDatabaseHelper.AddParameter("@SupplierName", DBNull.Value );
			  
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
				oDatabaseHelper.ExecuteScalar("gsp_BDSupplier_Insert_WithDefaultValues", ref ExecutionState);
			}
			else
			{
				IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDSupplier_Insert_WithDefaultValues_AndReturn", ref ExecutionState);
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
		/// DLGenerator			12/26/2014 2:45:52 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Insert() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_supplierCode' as parameter 'SupplierCode' of the stored procedure.
			if(_supplierCodeNonDefault!=null)
			  oDatabaseHelper.AddParameter("@SupplierCode", _supplierCodeNonDefault);
			else
			  oDatabaseHelper.AddParameter("@SupplierCode", DBNull.Value );
			// Pass the value of '_supplierName' as parameter 'SupplierName' of the stored procedure.
			if(_supplierNameNonDefault!=null)
			  oDatabaseHelper.AddParameter("@SupplierName", _supplierNameNonDefault);
			else
			  oDatabaseHelper.AddParameter("@SupplierName", DBNull.Value );
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
			
			oDatabaseHelper.ExecuteScalar("gsp_BDSupplier_Insert", ref ExecutionState);
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
		/// DLGenerator			12/26/2014 2:45:52 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Update() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_supplierID' as parameter 'SupplierID' of the stored procedure.
			oDatabaseHelper.AddParameter("@SupplierID", _supplierIDNonDefault );
			
			// Pass the value of '_supplierCode' as parameter 'SupplierCode' of the stored procedure.
			oDatabaseHelper.AddParameter("@SupplierCode", _supplierCodeNonDefault );
			
			// Pass the value of '_supplierName' as parameter 'SupplierName' of the stored procedure.
			oDatabaseHelper.AddParameter("@SupplierName", _supplierNameNonDefault );
			
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
			
			oDatabaseHelper.ExecuteScalar("gsp_BDSupplier_Update", ref ExecutionState);
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
		/// DLGenerator			12/26/2014 2:45:52 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Delete() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_supplierID' as parameter 'SupplierID' of the stored procedure.
			if(_supplierIDNonDefault!=null)
				oDatabaseHelper.AddParameter("@SupplierID", _supplierIDNonDefault );
			else
				oDatabaseHelper.AddParameter("@SupplierID", DBNull.Value );
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_BDSupplier_Delete", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will Delete one row from the database using the primary key information
		/// </summary>
		///
		/// <param name="pk" type="BDSupplierPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>True if succeeded</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:52 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static bool Delete(BDSupplierPrimaryKey pk) 
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
   
			oDatabaseHelper.ExecuteScalar("gsp_BDSupplier_Delete", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="BDSupplierFields">Field of the class BDSupplier</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		///
		/// <returns>True if succeeded</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:52 AM		Created function
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
			
			oDatabaseHelper.ExecuteScalar("gsp_BDSupplier_DeleteByField", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="BDSupplierPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class BDSupplier</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:52 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static BDSupplier SelectOne(BDSupplierPrimaryKey pk)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDSupplier_SelectbyPrimaryKey", ref ExecutionState);
			if (dr.Read())
			{
				BDSupplier obj=new BDSupplier();	
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
		/// <returns>list of objects of class BDSupplier in the form of object of BDSupplierCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:52 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static BDSupplierCollection SelectAll()
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDSupplier_SelectAll", ref ExecutionState);
			BDSupplierCollection BDSupplierCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return BDSupplierCollection;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class BDSupplier</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class BDSupplier in the form of an object of class BDSupplierCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:52 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static BDSupplierCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDSupplier_SelectByField", ref ExecutionState);
			BDSupplierCollection BDSupplierCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return BDSupplierCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number</param>
		///
		/// <returns>list of objects of class BDSupplier in the form of object of BDSupplierCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:52 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static BDSupplierCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// Pass the specified field and its value to the stored procedure.
			oDatabaseHelper.AddParameter("@PageSize",pageSize);
			oDatabaseHelper.AddParameter("@SkipPages", skipPages);
			oDatabaseHelper.AddParameter("@OrderByStatement", orderByStatement );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDSupplier_SelectAllPaged", ref ExecutionState);
			BDSupplierCollection BDSupplierCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return BDSupplierCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class BDSupplier</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class BDSupplier in the form of an object of class BDSupplierCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:52 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static BDSupplierCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDSupplier_SelectByFieldPaged", ref ExecutionState);
			BDSupplierCollection BDSupplierCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return BDSupplierCollection;
			
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
		/// DLGenerator			12/26/2014 2:45:52 AM		Created function
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
			
			Object dr=oDatabaseHelper.ExecuteScalar("gsp_BDSupplier_SelectAllCount");
			int count = Convert.ToInt32(dr);		
			oDatabaseHelper.Dispose();
			return count;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="BDSupplierPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class BDSupplier</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:52 AM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static BDSupplier SelectOneWithPURPurchaseHeaderUsingSupplierID(BDSupplierPrimaryKey pk)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			BDSupplier obj=null;
			
			// Pass the values of all key parameters to the stored procedure.
			System.Collections.Specialized.NameValueCollection nvc = pk.GetKeysAndValues();
			foreach (string key in nvc.Keys)
			{
				oDatabaseHelper.AddParameter("@" + key,nvc[key] );
			}
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDSupplier_SelectOneWithPURPurchaseHeaderUsingSupplierID", ref ExecutionState);
			if (dr.Read())
			{
				obj= new BDSupplier();
				PopulateObjectFromReader(obj,dr);
				
				dr.NextResult();
				
				//Get the child records.
				obj.PURPurchaseHeaderCollectionUsingSupplierID=PURPurchaseHeader.PopulateObjectsFromReader(dr);
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
		/// DLGenerator			12/26/2014 2:45:52 AM		Created function
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
		/// <param name="obj" type="BDSupplier">Object of BDSupplier to populate</param>
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:52 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static void PopulateObjectFromReader(BDSupplierBase obj,IDataReader rdr) 
		{

			obj.SupplierID = rdr.GetInt32(rdr.GetOrdinal(BDSupplierFields.SupplierID));
			if (!rdr.IsDBNull(rdr.GetOrdinal(BDSupplierFields.SupplierCode)))
			{
				obj.SupplierCode = rdr.GetString(rdr.GetOrdinal(BDSupplierFields.SupplierCode));
			}
			
			obj.SupplierName = rdr.GetString(rdr.GetOrdinal(BDSupplierFields.SupplierName));
			if (!rdr.IsDBNull(rdr.GetOrdinal(BDSupplierFields.Address)))
			{
				obj.Address = rdr.GetString(rdr.GetOrdinal(BDSupplierFields.Address));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(BDSupplierFields.Phone1)))
			{
				obj.Phone1 = rdr.GetString(rdr.GetOrdinal(BDSupplierFields.Phone1));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(BDSupplierFields.Phone2)))
			{
				obj.Phone2 = rdr.GetString(rdr.GetOrdinal(BDSupplierFields.Phone2));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(BDSupplierFields.Mobile1)))
			{
				obj.Mobile1 = rdr.GetString(rdr.GetOrdinal(BDSupplierFields.Mobile1));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(BDSupplierFields.Mobile2)))
			{
				obj.Mobile2 = rdr.GetString(rdr.GetOrdinal(BDSupplierFields.Mobile2));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(BDSupplierFields.Email)))
			{
				obj.Email = rdr.GetString(rdr.GetOrdinal(BDSupplierFields.Email));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(BDSupplierFields.IsActive)))
			{
				obj.IsActive = rdr.GetBoolean(rdr.GetOrdinal(BDSupplierFields.IsActive));
			}
			

		}

		/// <summary>
		/// Populates the fields for multiple objects from the columns found in an open reader.
		/// </summary>
		///
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <returns>Object of BDSupplierCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:52 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static BDSupplierCollection PopulateObjectsFromReader(IDataReader rdr) 
		{
			BDSupplierCollection list = new BDSupplierCollection();
			
			while (rdr.Read())
			{
				BDSupplier obj = new BDSupplier();
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
		/// <returns>Object of BDSupplierCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:52 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static BDSupplierCollection PopulateObjectsFromReaderWithCheckingReader(IDataReader rdr, DatabaseHelper oDatabaseHelper) 
		{

			BDSupplierCollection list = new BDSupplierCollection();
			
            if (rdr.Read())
			{
				BDSupplier obj = new BDSupplier();
				PopulateObjectFromReader(obj, rdr);
				list.Add(obj);
				while (rdr.Read())
				{
					obj = new BDSupplier();
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
