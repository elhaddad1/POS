//
// Class	:	PURPurchaseReturnHeaderBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	12/26/2014 2:46:01 AM
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
	public class PURPurchaseReturnHeaderFields
	{
		public const string PurchaseReturnID          = "PurchaseReturnID";
		public const string ReturnDate                = "ReturnDate";
		public const string OriginalHeaderID          = "OriginalHeaderID";
		public const string CreatedBy                 = "CreatedBy";
		public const string CreateDate                = "CreateDate";
		public const string UpdatedBy                 = "UpdatedBy";
		public const string UpdateDate                = "UpdateDate";
		public const string IsDeleted                 = "IsDeleted";
		public const string DeletedBy                 = "DeletedBy";
		public const string DeleteDate                = "DeleteDate";
	}
	
	/// <summary>
	/// Data access class for the "PURPurchaseReturnHeader" table.
	/// </summary>
	[Serializable]
	public class PURPurchaseReturnHeaderBase
	{
		
		#region Class Level Variables
		
		private DatabaseHelper oDatabaseHelper = new DatabaseHelper();

		private int?           	_purchaseReturnIDNonDefault	= null;
		private DateTime?      	_returnDateNonDefault    	= null;
		private int?           	_originalHeaderIDNonDefault	= null;
		private int?           	_createdByNonDefault     	= null;
		private DateTime?      	_createDateNonDefault    	= null;
		private int?           	_updatedByNonDefault     	= null;
		private DateTime?      	_updateDateNonDefault    	= null;
		private bool?          	_isDeletedNonDefault     	= false;
		private string         	_deletedByNonDefault     	= null;
		private DateTime?      	_deleteDateNonDefault    	= null;
		
		#endregion
		
		#region Constants
		
		#endregion
		
		#region Constructors / Destructors

		/// <summary>
		/// Class Constructor
		///</summary>
		public PURPurchaseReturnHeaderBase() { }
					
		#endregion
		
		#region Properties

		/// <summary>
		/// Returns the identifier of the persistent object. Don't set it manually!
		/// </summary>
		public int? PurchaseReturnID
		{
			get 
			{ 
				return _purchaseReturnIDNonDefault;
			}
			set 
			{
			
				_purchaseReturnIDNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "ReturnDate" field.  Mandatory.
		/// </summary>
		public DateTime? ReturnDate
		{
			get 
			{ 
				return _returnDateNonDefault;
			}
			set 
			{
			
				_returnDateNonDefault = value; 
			}
		}

		/// <summary>
		/// The foreign key connected with another persistent object.
		/// </summary>
		public int? OriginalHeaderID
		{
			get 
			{ 
				return _originalHeaderIDNonDefault;
			}
			set 
			{
			
				_originalHeaderIDNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "CreatedBy" field.  
		/// </summary>
		public int? CreatedBy
		{
			get 
			{ 
				return _createdByNonDefault;
			}
			set 
			{
			
				_createdByNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "CreateDate" field.  
		/// </summary>
		public DateTime? CreateDate
		{
			get 
			{ 
				return _createDateNonDefault;
			}
			set 
			{
			
				_createDateNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "UpdatedBy" field.  
		/// </summary>
		public int? UpdatedBy
		{
			get 
			{ 
				return _updatedByNonDefault;
			}
			set 
			{
			
				_updatedByNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "UpdateDate" field.  
		/// </summary>
		public DateTime? UpdateDate
		{
			get 
			{ 
				return _updateDateNonDefault;
			}
			set 
			{
			
				_updateDateNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "IsDeleted" field.  Mandatory.
		/// </summary>
		public bool? IsDeleted
		{
			get 
			{ 
				return _isDeletedNonDefault;
			}
			set 
			{
			
				_isDeletedNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "DeletedBy" field. Length must be between 0 and 10 characters. 
		/// </summary>
		public string DeletedBy
		{
			get 
			{ 
				if(_deletedByNonDefault==null)return _deletedByNonDefault;
				else return _deletedByNonDefault.Trim(); 
			}
			set 
			{
			    if (value != null && value.Length > 10)
					throw new ArgumentException("DeletedBy length must be between 0 and 10 characters.");

				
				if(value ==null)
				{
					_deletedByNonDefault =null;//null value 
				}
				else
				{		           
					_deletedByNonDefault = value.Trim(); 
				}
			}
		}

		/// <summary>
		/// This property is mapped to the "DeleteDate" field.  
		/// </summary>
		public DateTime? DeleteDate
		{
			get 
			{ 
				return _deleteDateNonDefault;
			}
			set 
			{
			
				_deleteDateNonDefault = value; 
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
		/// DLGenerator			12/26/2014 2:46:01 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool InsertWithDefaultValues(bool getBackValues) 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_returnDate' as parameter 'ReturnDate' of the stored procedure.
			if(_returnDateNonDefault!=null)
			  oDatabaseHelper.AddParameter("@ReturnDate", _returnDateNonDefault);
			else
			  oDatabaseHelper.AddParameter("@ReturnDate", DBNull.Value );
			  
			// Pass the value of '_originalHeaderID' as parameter 'OriginalHeaderID' of the stored procedure.
			if(_originalHeaderIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@OriginalHeaderID", _originalHeaderIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@OriginalHeaderID", DBNull.Value );
			  
			// Pass the value of '_createdBy' as parameter 'CreatedBy' of the stored procedure.
			if(_createdByNonDefault!=null)
			  oDatabaseHelper.AddParameter("@CreatedBy", _createdByNonDefault);
			else
			  oDatabaseHelper.AddParameter("@CreatedBy", DBNull.Value );
			  
			// Pass the value of '_createDate' as parameter 'CreateDate' of the stored procedure.
			if(_createDateNonDefault!=null)
			  oDatabaseHelper.AddParameter("@CreateDate", _createDateNonDefault);
			else
			  oDatabaseHelper.AddParameter("@CreateDate", DBNull.Value );
			  
			// Pass the value of '_updatedBy' as parameter 'UpdatedBy' of the stored procedure.
			if(_updatedByNonDefault!=null)
			  oDatabaseHelper.AddParameter("@UpdatedBy", _updatedByNonDefault);
			else
			  oDatabaseHelper.AddParameter("@UpdatedBy", DBNull.Value );
			  
			// Pass the value of '_updateDate' as parameter 'UpdateDate' of the stored procedure.
			if(_updateDateNonDefault!=null)
			  oDatabaseHelper.AddParameter("@UpdateDate", _updateDateNonDefault);
			else
			  oDatabaseHelper.AddParameter("@UpdateDate", DBNull.Value );
			  
			// Pass the value of '_isDeleted' as parameter 'IsDeleted' of the stored procedure.
			if(_isDeletedNonDefault!=null)
			  oDatabaseHelper.AddParameter("@IsDeleted", _isDeletedNonDefault);
			else
			  oDatabaseHelper.AddParameter("@IsDeleted", DBNull.Value );
			  
			// Pass the value of '_deletedBy' as parameter 'DeletedBy' of the stored procedure.
			if(_deletedByNonDefault!=null)
			  oDatabaseHelper.AddParameter("@DeletedBy", _deletedByNonDefault);
			else
			  oDatabaseHelper.AddParameter("@DeletedBy", DBNull.Value );
			  
			// Pass the value of '_deleteDate' as parameter 'DeleteDate' of the stored procedure.
			if(_deleteDateNonDefault!=null)
			  oDatabaseHelper.AddParameter("@DeleteDate", _deleteDateNonDefault);
			else
			  oDatabaseHelper.AddParameter("@DeleteDate", DBNull.Value );
			  
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			if(!getBackValues )
			{
				oDatabaseHelper.ExecuteScalar("gsp_PURPurchaseReturnHeader_Insert_WithDefaultValues", ref ExecutionState);
			}
			else
			{
				IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseReturnHeader_Insert_WithDefaultValues_AndReturn", ref ExecutionState);
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
		/// DLGenerator			12/26/2014 2:46:01 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Insert() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_returnDate' as parameter 'ReturnDate' of the stored procedure.
			if(_returnDateNonDefault!=null)
			  oDatabaseHelper.AddParameter("@ReturnDate", _returnDateNonDefault);
			else
			  oDatabaseHelper.AddParameter("@ReturnDate", DBNull.Value );
			// Pass the value of '_originalHeaderID' as parameter 'OriginalHeaderID' of the stored procedure.
			if(_originalHeaderIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@OriginalHeaderID", _originalHeaderIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@OriginalHeaderID", DBNull.Value );
			// Pass the value of '_createdBy' as parameter 'CreatedBy' of the stored procedure.
			if(_createdByNonDefault!=null)
			  oDatabaseHelper.AddParameter("@CreatedBy", _createdByNonDefault);
			else
			  oDatabaseHelper.AddParameter("@CreatedBy", DBNull.Value );
			// Pass the value of '_createDate' as parameter 'CreateDate' of the stored procedure.
			if(_createDateNonDefault!=null)
			  oDatabaseHelper.AddParameter("@CreateDate", _createDateNonDefault);
			else
			  oDatabaseHelper.AddParameter("@CreateDate", DBNull.Value );
			// Pass the value of '_updatedBy' as parameter 'UpdatedBy' of the stored procedure.
			if(_updatedByNonDefault!=null)
			  oDatabaseHelper.AddParameter("@UpdatedBy", _updatedByNonDefault);
			else
			  oDatabaseHelper.AddParameter("@UpdatedBy", DBNull.Value );
			// Pass the value of '_updateDate' as parameter 'UpdateDate' of the stored procedure.
			if(_updateDateNonDefault!=null)
			  oDatabaseHelper.AddParameter("@UpdateDate", _updateDateNonDefault);
			else
			  oDatabaseHelper.AddParameter("@UpdateDate", DBNull.Value );
			// Pass the value of '_isDeleted' as parameter 'IsDeleted' of the stored procedure.
			if(_isDeletedNonDefault!=null)
			  oDatabaseHelper.AddParameter("@IsDeleted", _isDeletedNonDefault);
			else
			  oDatabaseHelper.AddParameter("@IsDeleted", DBNull.Value );
			// Pass the value of '_deletedBy' as parameter 'DeletedBy' of the stored procedure.
			if(_deletedByNonDefault!=null)
			  oDatabaseHelper.AddParameter("@DeletedBy", _deletedByNonDefault);
			else
			  oDatabaseHelper.AddParameter("@DeletedBy", DBNull.Value );
			// Pass the value of '_deleteDate' as parameter 'DeleteDate' of the stored procedure.
			if(_deleteDateNonDefault!=null)
			  oDatabaseHelper.AddParameter("@DeleteDate", _deleteDateNonDefault);
			else
			  oDatabaseHelper.AddParameter("@DeleteDate", DBNull.Value );
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_PURPurchaseReturnHeader_Insert", ref ExecutionState);
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
		/// DLGenerator			12/26/2014 2:46:01 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Update() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_purchaseReturnID' as parameter 'PurchaseReturnID' of the stored procedure.
			oDatabaseHelper.AddParameter("@PurchaseReturnID", _purchaseReturnIDNonDefault );
			
			// Pass the value of '_returnDate' as parameter 'ReturnDate' of the stored procedure.
			oDatabaseHelper.AddParameter("@ReturnDate", _returnDateNonDefault );
			
			// Pass the value of '_originalHeaderID' as parameter 'OriginalHeaderID' of the stored procedure.
			oDatabaseHelper.AddParameter("@OriginalHeaderID", _originalHeaderIDNonDefault );
			
			// Pass the value of '_createdBy' as parameter 'CreatedBy' of the stored procedure.
			oDatabaseHelper.AddParameter("@CreatedBy", _createdByNonDefault );
			
			// Pass the value of '_createDate' as parameter 'CreateDate' of the stored procedure.
			oDatabaseHelper.AddParameter("@CreateDate", _createDateNonDefault );
			
			// Pass the value of '_updatedBy' as parameter 'UpdatedBy' of the stored procedure.
			oDatabaseHelper.AddParameter("@UpdatedBy", _updatedByNonDefault );
			
			// Pass the value of '_updateDate' as parameter 'UpdateDate' of the stored procedure.
			oDatabaseHelper.AddParameter("@UpdateDate", _updateDateNonDefault );
			
			// Pass the value of '_isDeleted' as parameter 'IsDeleted' of the stored procedure.
			oDatabaseHelper.AddParameter("@IsDeleted", _isDeletedNonDefault );
			
			// Pass the value of '_deletedBy' as parameter 'DeletedBy' of the stored procedure.
			oDatabaseHelper.AddParameter("@DeletedBy", _deletedByNonDefault );
			
			// Pass the value of '_deleteDate' as parameter 'DeleteDate' of the stored procedure.
			oDatabaseHelper.AddParameter("@DeleteDate", _deleteDateNonDefault );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_PURPurchaseReturnHeader_Update", ref ExecutionState);
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
		/// DLGenerator			12/26/2014 2:46:01 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Delete() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_purchaseReturnID' as parameter 'PurchaseReturnID' of the stored procedure.
			if(_purchaseReturnIDNonDefault!=null)
				oDatabaseHelper.AddParameter("@PurchaseReturnID", _purchaseReturnIDNonDefault );
			else
				oDatabaseHelper.AddParameter("@PurchaseReturnID", DBNull.Value );
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_PURPurchaseReturnHeader_Delete", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will Delete one row from the database using the primary key information
		/// </summary>
		///
		/// <param name="pk" type="PURPurchaseReturnHeaderPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>True if succeeded</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:46:01 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static bool Delete(PURPurchaseReturnHeaderPrimaryKey pk) 
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
   
			oDatabaseHelper.ExecuteScalar("gsp_PURPurchaseReturnHeader_Delete", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="PURPurchaseReturnHeaderFields">Field of the class PURPurchaseReturnHeader</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		///
		/// <returns>True if succeeded</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:46:01 AM		Created function
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
			
			oDatabaseHelper.ExecuteScalar("gsp_PURPurchaseReturnHeader_DeleteByField", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="PURPurchaseReturnHeaderPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class PURPurchaseReturnHeader</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:46:01 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static PURPurchaseReturnHeader SelectOne(PURPurchaseReturnHeaderPrimaryKey pk)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseReturnHeader_SelectbyPrimaryKey", ref ExecutionState);
			if (dr.Read())
			{
				PURPurchaseReturnHeader obj=new PURPurchaseReturnHeader();	
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
		/// <returns>list of objects of class PURPurchaseReturnHeader in the form of object of PURPurchaseReturnHeaderCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:46:01 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static PURPurchaseReturnHeaderCollection SelectAll()
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseReturnHeader_SelectAll", ref ExecutionState);
			PURPurchaseReturnHeaderCollection PURPurchaseReturnHeaderCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return PURPurchaseReturnHeaderCollection;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class PURPurchaseReturnHeader</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class PURPurchaseReturnHeader in the form of an object of class PURPurchaseReturnHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:46:01 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static PURPurchaseReturnHeaderCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseReturnHeader_SelectByField", ref ExecutionState);
			PURPurchaseReturnHeaderCollection PURPurchaseReturnHeaderCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return PURPurchaseReturnHeaderCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number</param>
		///
		/// <returns>list of objects of class PURPurchaseReturnHeader in the form of object of PURPurchaseReturnHeaderCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:46:01 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static PURPurchaseReturnHeaderCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// Pass the specified field and its value to the stored procedure.
			oDatabaseHelper.AddParameter("@PageSize",pageSize);
			oDatabaseHelper.AddParameter("@SkipPages", skipPages);
			oDatabaseHelper.AddParameter("@OrderByStatement", orderByStatement );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseReturnHeader_SelectAllPaged", ref ExecutionState);
			PURPurchaseReturnHeaderCollection PURPurchaseReturnHeaderCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return PURPurchaseReturnHeaderCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class PURPurchaseReturnHeader</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class PURPurchaseReturnHeader in the form of an object of class PURPurchaseReturnHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:46:01 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static PURPurchaseReturnHeaderCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseReturnHeader_SelectByFieldPaged", ref ExecutionState);
			PURPurchaseReturnHeaderCollection PURPurchaseReturnHeaderCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return PURPurchaseReturnHeaderCollection;
			
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
		/// DLGenerator			12/26/2014 2:46:01 AM		Created function
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
			
			Object dr=oDatabaseHelper.ExecuteScalar("gsp_PURPurchaseReturnHeader_SelectAllCount");
			int count = Convert.ToInt32(dr);		
			oDatabaseHelper.Dispose();
			return count;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="PURPurchaseHeaderPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class PURPurchaseReturnHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:46:01 AM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static PURPurchaseReturnHeaderCollection SelectAllByForeignKeyOriginalHeaderID(PURPurchaseHeaderPrimaryKey pk)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			PURPurchaseReturnHeaderCollection obj = null;
			
			// Pass the values of all key parameters to the stored procedure.
			System.Collections.Specialized.NameValueCollection nvc = pk.GetKeysAndValues();
			foreach (string key in nvc.Keys)
			{
				oDatabaseHelper.AddParameter("@" + key,nvc[key] );
			}
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseReturnHeader_SelectAllByForeignKeyOriginalHeaderID", ref ExecutionState);
			obj = new PURPurchaseReturnHeaderCollection();
			obj = PURPurchaseReturnHeader.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
			dr.Close();  
			oDatabaseHelper.Dispose();
			return obj;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="PURPurchaseHeaderPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number</param>
		///
		/// <returns>object of class PURPurchaseReturnHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:46:01 AM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static PURPurchaseReturnHeaderCollection SelectAllByForeignKeyOriginalHeaderIDPaged(PURPurchaseHeaderPrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			PURPurchaseReturnHeaderCollection obj = null;
			
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseReturnHeader_SelectAllByForeignKeyOriginalHeaderIDPaged", ref ExecutionState);
			obj = new PURPurchaseReturnHeaderCollection();
			obj = PURPurchaseReturnHeader.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
			dr.Close();  
			oDatabaseHelper.Dispose();
			return obj;
			
		}

		/// <summary>
		/// This method will delete row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="PURPurchaseHeaderPrimaryKey">Primary Key information based on which data is to be deleted.</param>
		///
		/// <returns>object of boolean type as an indicator for operation success .</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:46:01 AM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static bool DeleteAllByForeignKeyOriginalHeaderID(PURPurchaseHeaderPrimaryKey pk)
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
			
			oDatabaseHelper.ExecuteNonQuery("gsp_PURPurchaseReturnHeader_DeleteAllByForeignKeyOriginalHeaderID", ref ExecutionState);
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
		/// DLGenerator			12/26/2014 2:46:01 AM		Created function
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
		/// <param name="obj" type="PURPurchaseReturnHeader">Object of PURPurchaseReturnHeader to populate</param>
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:46:01 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static void PopulateObjectFromReader(PURPurchaseReturnHeaderBase obj,IDataReader rdr) 
		{

			obj.PurchaseReturnID = rdr.GetInt32(rdr.GetOrdinal(PURPurchaseReturnHeaderFields.PurchaseReturnID));
			obj.ReturnDate = rdr.GetDateTime(rdr.GetOrdinal(PURPurchaseReturnHeaderFields.ReturnDate));
			if (!rdr.IsDBNull(rdr.GetOrdinal(PURPurchaseReturnHeaderFields.OriginalHeaderID)))
			{
				obj.OriginalHeaderID = rdr.GetInt32(rdr.GetOrdinal(PURPurchaseReturnHeaderFields.OriginalHeaderID));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(PURPurchaseReturnHeaderFields.CreatedBy)))
			{
				obj.CreatedBy = rdr.GetInt32(rdr.GetOrdinal(PURPurchaseReturnHeaderFields.CreatedBy));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(PURPurchaseReturnHeaderFields.CreateDate)))
			{
				obj.CreateDate = rdr.GetDateTime(rdr.GetOrdinal(PURPurchaseReturnHeaderFields.CreateDate));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(PURPurchaseReturnHeaderFields.UpdatedBy)))
			{
				obj.UpdatedBy = rdr.GetInt32(rdr.GetOrdinal(PURPurchaseReturnHeaderFields.UpdatedBy));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(PURPurchaseReturnHeaderFields.UpdateDate)))
			{
				obj.UpdateDate = rdr.GetDateTime(rdr.GetOrdinal(PURPurchaseReturnHeaderFields.UpdateDate));
			}
			
			obj.IsDeleted = rdr.GetBoolean(rdr.GetOrdinal(PURPurchaseReturnHeaderFields.IsDeleted));
			if (!rdr.IsDBNull(rdr.GetOrdinal(PURPurchaseReturnHeaderFields.DeletedBy)))
			{
				obj.DeletedBy = rdr.GetString(rdr.GetOrdinal(PURPurchaseReturnHeaderFields.DeletedBy));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(PURPurchaseReturnHeaderFields.DeleteDate)))
			{
				obj.DeleteDate = rdr.GetDateTime(rdr.GetOrdinal(PURPurchaseReturnHeaderFields.DeleteDate));
			}
			

		}

		/// <summary>
		/// Populates the fields for multiple objects from the columns found in an open reader.
		/// </summary>
		///
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <returns>Object of PURPurchaseReturnHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:46:01 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static PURPurchaseReturnHeaderCollection PopulateObjectsFromReader(IDataReader rdr) 
		{
			PURPurchaseReturnHeaderCollection list = new PURPurchaseReturnHeaderCollection();
			
			while (rdr.Read())
			{
				PURPurchaseReturnHeader obj = new PURPurchaseReturnHeader();
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
		/// <returns>Object of PURPurchaseReturnHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:46:01 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static PURPurchaseReturnHeaderCollection PopulateObjectsFromReaderWithCheckingReader(IDataReader rdr, DatabaseHelper oDatabaseHelper) 
		{

			PURPurchaseReturnHeaderCollection list = new PURPurchaseReturnHeaderCollection();
			
            if (rdr.Read())
			{
				PURPurchaseReturnHeader obj = new PURPurchaseReturnHeader();
				PopulateObjectFromReader(obj, rdr);
				list.Add(obj);
				while (rdr.Read())
				{
					obj = new PURPurchaseReturnHeader();
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
