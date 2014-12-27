//
// Class	:	INVTransferHeaderBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:55:57 PM
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
	public class INVTransferHeaderFields
	{
		public const string INVTransferHeaderID       = "INVTransferHeaderID";
		public const string TransferDate              = "TransferDate";
		public const string FromInventoryID           = "FromInventoryID";
		public const string ToInventoryID             = "ToInventoryID";
		public const string CreatedBy                 = "CreatedBy";
		public const string CreateDate                = "CreateDate";
		public const string UpdatedBy                 = "UpdatedBy";
		public const string IsDeleted                 = "IsDeleted";
		public const string DeletedBy                 = "DeletedBy";
		public const string DeletedDate               = "DeletedDate";
	}
	
	/// <summary>
	/// Data access class for the "INVTransferHeader" table.
	/// </summary>
	[Serializable]
	public class INVTransferHeaderBase
	{
		
		#region Class Level Variables
		
		private DatabaseHelper oDatabaseHelper = new DatabaseHelper();

		private int?           	_iNVTransferHeaderIDNonDefault	= null;
		private DateTime?      	_transferDateNonDefault  	= null;
		private int?           	_fromInventoryIDNonDefault	= null;
		private int?           	_toInventoryIDNonDefault 	= null;
		private int?           	_createdByNonDefault     	= null;
		private DateTime?      	_createDateNonDefault    	= null;
		private int?           	_updatedByNonDefault     	= null;
		private bool?          	_isDeletedNonDefault     	= false;
		private int?           	_deletedByNonDefault     	= null;
		private DateTime?      	_deletedDateNonDefault   	= null;
		
		#endregion
		
		#region Constants
		
		#endregion
		
		#region Constructors / Destructors

		/// <summary>
		/// Class Constructor
		///</summary>
		public INVTransferHeaderBase() { }
					
		#endregion
		
		#region Properties

		/// <summary>
		/// Returns the identifier of the persistent object. Don't set it manually!
		/// </summary>
		public int? INVTransferHeaderID
		{
			get 
			{ 
				return _iNVTransferHeaderIDNonDefault;
			}
			set 
			{
			
				_iNVTransferHeaderIDNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "TransferDate" field.  Mandatory.
		/// </summary>
		public DateTime? TransferDate
		{
			get 
			{ 
				return _transferDateNonDefault;
			}
			set 
			{
			
				_transferDateNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "FromInventoryID" field.  Mandatory.
		/// </summary>
		public int? FromInventoryID
		{
			get 
			{ 
				return _fromInventoryIDNonDefault;
			}
			set 
			{
			
				_fromInventoryIDNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "ToInventoryID" field.  Mandatory.
		/// </summary>
		public int? ToInventoryID
		{
			get 
			{ 
				return _toInventoryIDNonDefault;
			}
			set 
			{
			
				_toInventoryIDNonDefault = value; 
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
		/// This property is mapped to the "DeletedBy" field.  
		/// </summary>
		public int? DeletedBy
		{
			get 
			{ 
				return _deletedByNonDefault;
			}
			set 
			{
			
				_deletedByNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "DeletedDate" field.  
		/// </summary>
		public DateTime? DeletedDate
		{
			get 
			{ 
				return _deletedDateNonDefault;
			}
			set 
			{
			
				_deletedDateNonDefault = value; 
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
		/// DLGenerator			12/27/2014 6:55:57 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool InsertWithDefaultValues(bool getBackValues) 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_transferDate' as parameter 'TransferDate' of the stored procedure.
			if(_transferDateNonDefault!=null)
			  oDatabaseHelper.AddParameter("@TransferDate", _transferDateNonDefault);
			else
			  oDatabaseHelper.AddParameter("@TransferDate", DBNull.Value );
			  
			// Pass the value of '_fromInventoryID' as parameter 'FromInventoryID' of the stored procedure.
			if(_fromInventoryIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@FromInventoryID", _fromInventoryIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@FromInventoryID", DBNull.Value );
			  
			// Pass the value of '_toInventoryID' as parameter 'ToInventoryID' of the stored procedure.
			if(_toInventoryIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@ToInventoryID", _toInventoryIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@ToInventoryID", DBNull.Value );
			  
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
			  
			// Pass the value of '_deletedDate' as parameter 'DeletedDate' of the stored procedure.
			if(_deletedDateNonDefault!=null)
			  oDatabaseHelper.AddParameter("@DeletedDate", _deletedDateNonDefault);
			else
			  oDatabaseHelper.AddParameter("@DeletedDate", DBNull.Value );
			  
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			if(!getBackValues )
			{
				oDatabaseHelper.ExecuteScalar("gsp_INVTransferHeader_Insert_WithDefaultValues", ref ExecutionState);
			}
			else
			{
				IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_INVTransferHeader_Insert_WithDefaultValues_AndReturn", ref ExecutionState);
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
		/// DLGenerator			12/27/2014 6:55:57 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Insert() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_transferDate' as parameter 'TransferDate' of the stored procedure.
			if(_transferDateNonDefault!=null)
			  oDatabaseHelper.AddParameter("@TransferDate", _transferDateNonDefault);
			else
			  oDatabaseHelper.AddParameter("@TransferDate", DBNull.Value );
			// Pass the value of '_fromInventoryID' as parameter 'FromInventoryID' of the stored procedure.
			if(_fromInventoryIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@FromInventoryID", _fromInventoryIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@FromInventoryID", DBNull.Value );
			// Pass the value of '_toInventoryID' as parameter 'ToInventoryID' of the stored procedure.
			if(_toInventoryIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@ToInventoryID", _toInventoryIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@ToInventoryID", DBNull.Value );
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
			// Pass the value of '_deletedDate' as parameter 'DeletedDate' of the stored procedure.
			if(_deletedDateNonDefault!=null)
			  oDatabaseHelper.AddParameter("@DeletedDate", _deletedDateNonDefault);
			else
			  oDatabaseHelper.AddParameter("@DeletedDate", DBNull.Value );
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_INVTransferHeader_Insert", ref ExecutionState);
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
		/// DLGenerator			12/27/2014 6:55:57 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Update() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_iNVTransferHeaderID' as parameter 'INVTransferHeaderID' of the stored procedure.
			oDatabaseHelper.AddParameter("@INVTransferHeaderID", _iNVTransferHeaderIDNonDefault );
			
			// Pass the value of '_transferDate' as parameter 'TransferDate' of the stored procedure.
			oDatabaseHelper.AddParameter("@TransferDate", _transferDateNonDefault );
			
			// Pass the value of '_fromInventoryID' as parameter 'FromInventoryID' of the stored procedure.
			oDatabaseHelper.AddParameter("@FromInventoryID", _fromInventoryIDNonDefault );
			
			// Pass the value of '_toInventoryID' as parameter 'ToInventoryID' of the stored procedure.
			oDatabaseHelper.AddParameter("@ToInventoryID", _toInventoryIDNonDefault );
			
			// Pass the value of '_createdBy' as parameter 'CreatedBy' of the stored procedure.
			oDatabaseHelper.AddParameter("@CreatedBy", _createdByNonDefault );
			
			// Pass the value of '_createDate' as parameter 'CreateDate' of the stored procedure.
			oDatabaseHelper.AddParameter("@CreateDate", _createDateNonDefault );
			
			// Pass the value of '_updatedBy' as parameter 'UpdatedBy' of the stored procedure.
			oDatabaseHelper.AddParameter("@UpdatedBy", _updatedByNonDefault );
			
			// Pass the value of '_isDeleted' as parameter 'IsDeleted' of the stored procedure.
			oDatabaseHelper.AddParameter("@IsDeleted", _isDeletedNonDefault );
			
			// Pass the value of '_deletedBy' as parameter 'DeletedBy' of the stored procedure.
			oDatabaseHelper.AddParameter("@DeletedBy", _deletedByNonDefault );
			
			// Pass the value of '_deletedDate' as parameter 'DeletedDate' of the stored procedure.
			oDatabaseHelper.AddParameter("@DeletedDate", _deletedDateNonDefault );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_INVTransferHeader_Update", ref ExecutionState);
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
		/// DLGenerator			12/27/2014 6:55:57 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Delete() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_iNVTransferHeaderID' as parameter 'INVTransferHeaderID' of the stored procedure.
			if(_iNVTransferHeaderIDNonDefault!=null)
				oDatabaseHelper.AddParameter("@INVTransferHeaderID", _iNVTransferHeaderIDNonDefault );
			else
				oDatabaseHelper.AddParameter("@INVTransferHeaderID", DBNull.Value );
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_INVTransferHeader_Delete", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will Delete one row from the database using the primary key information
		/// </summary>
		///
		/// <param name="pk" type="INVTransferHeaderPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>True if succeeded</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:55:57 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static bool Delete(INVTransferHeaderPrimaryKey pk) 
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
   
			oDatabaseHelper.ExecuteScalar("gsp_INVTransferHeader_Delete", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="INVTransferHeaderFields">Field of the class INVTransferHeader</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		///
		/// <returns>True if succeeded</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:55:57 PM		Created function
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
			
			oDatabaseHelper.ExecuteScalar("gsp_INVTransferHeader_DeleteByField", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="INVTransferHeaderPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class INVTransferHeader</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:55:57 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static INVTransferHeader SelectOne(INVTransferHeaderPrimaryKey pk)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_INVTransferHeader_SelectbyPrimaryKey", ref ExecutionState);
			if (dr.Read())
			{
				INVTransferHeader obj=new INVTransferHeader();	
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
		/// <returns>list of objects of class INVTransferHeader in the form of object of INVTransferHeaderCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:55:57 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static INVTransferHeaderCollection SelectAll()
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_INVTransferHeader_SelectAll", ref ExecutionState);
			INVTransferHeaderCollection INVTransferHeaderCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return INVTransferHeaderCollection;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class INVTransferHeader</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class INVTransferHeader in the form of an object of class INVTransferHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:55:57 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static INVTransferHeaderCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_INVTransferHeader_SelectByField", ref ExecutionState);
			INVTransferHeaderCollection INVTransferHeaderCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return INVTransferHeaderCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number</param>
		///
		/// <returns>list of objects of class INVTransferHeader in the form of object of INVTransferHeaderCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:55:57 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static INVTransferHeaderCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// Pass the specified field and its value to the stored procedure.
			oDatabaseHelper.AddParameter("@PageSize",pageSize);
			oDatabaseHelper.AddParameter("@SkipPages", skipPages);
			oDatabaseHelper.AddParameter("@OrderByStatement", orderByStatement );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_INVTransferHeader_SelectAllPaged", ref ExecutionState);
			INVTransferHeaderCollection INVTransferHeaderCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return INVTransferHeaderCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class INVTransferHeader</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class INVTransferHeader in the form of an object of class INVTransferHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:55:57 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static INVTransferHeaderCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_INVTransferHeader_SelectByFieldPaged", ref ExecutionState);
			INVTransferHeaderCollection INVTransferHeaderCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return INVTransferHeaderCollection;
			
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
		/// DLGenerator			12/27/2014 6:55:57 PM		Created function
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
			
			Object dr=oDatabaseHelper.ExecuteScalar("gsp_INVTransferHeader_SelectAllCount");
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
		/// DLGenerator			12/27/2014 6:55:57 PM		Created function
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
		/// <param name="obj" type="INVTransferHeader">Object of INVTransferHeader to populate</param>
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:55:57 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static void PopulateObjectFromReader(INVTransferHeaderBase obj,IDataReader rdr) 
		{

			obj.INVTransferHeaderID = rdr.GetInt32(rdr.GetOrdinal(INVTransferHeaderFields.INVTransferHeaderID));
			obj.TransferDate = rdr.GetDateTime(rdr.GetOrdinal(INVTransferHeaderFields.TransferDate));
			obj.FromInventoryID = rdr.GetInt32(rdr.GetOrdinal(INVTransferHeaderFields.FromInventoryID));
			obj.ToInventoryID = rdr.GetInt32(rdr.GetOrdinal(INVTransferHeaderFields.ToInventoryID));
			if (!rdr.IsDBNull(rdr.GetOrdinal(INVTransferHeaderFields.CreatedBy)))
			{
				obj.CreatedBy = rdr.GetInt32(rdr.GetOrdinal(INVTransferHeaderFields.CreatedBy));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(INVTransferHeaderFields.CreateDate)))
			{
				obj.CreateDate = rdr.GetDateTime(rdr.GetOrdinal(INVTransferHeaderFields.CreateDate));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(INVTransferHeaderFields.UpdatedBy)))
			{
				obj.UpdatedBy = rdr.GetInt32(rdr.GetOrdinal(INVTransferHeaderFields.UpdatedBy));
			}
			
			obj.IsDeleted = rdr.GetBoolean(rdr.GetOrdinal(INVTransferHeaderFields.IsDeleted));
			if (!rdr.IsDBNull(rdr.GetOrdinal(INVTransferHeaderFields.DeletedBy)))
			{
				obj.DeletedBy = rdr.GetInt32(rdr.GetOrdinal(INVTransferHeaderFields.DeletedBy));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(INVTransferHeaderFields.DeletedDate)))
			{
				obj.DeletedDate = rdr.GetDateTime(rdr.GetOrdinal(INVTransferHeaderFields.DeletedDate));
			}
			

		}

		/// <summary>
		/// Populates the fields for multiple objects from the columns found in an open reader.
		/// </summary>
		///
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <returns>Object of INVTransferHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:55:57 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static INVTransferHeaderCollection PopulateObjectsFromReader(IDataReader rdr) 
		{
			INVTransferHeaderCollection list = new INVTransferHeaderCollection();
			
			while (rdr.Read())
			{
				INVTransferHeader obj = new INVTransferHeader();
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
		/// <returns>Object of INVTransferHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:55:57 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static INVTransferHeaderCollection PopulateObjectsFromReaderWithCheckingReader(IDataReader rdr, DatabaseHelper oDatabaseHelper) 
		{

			INVTransferHeaderCollection list = new INVTransferHeaderCollection();
			
            if (rdr.Read())
			{
				INVTransferHeader obj = new INVTransferHeader();
				PopulateObjectFromReader(obj, rdr);
				list.Add(obj);
				while (rdr.Read())
				{
					obj = new INVTransferHeader();
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
