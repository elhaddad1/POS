//
// Class	:	INVTransferLineBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	2/16/2015 7:27:49 PM
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
	public class INVTransferLineFields
	{
		public const string TransferLineID            = "TransferLineID";
		public const string TransferHeaderID          = "TransferHeaderID";
		public const string ProductID                 = "ProductID";
		public const string Qty                       = "Qty";
		public const string CreatedBy                 = "CreatedBy";
		public const string CreateDate                = "CreateDate";
		public const string UpdatedBy                 = "UpdatedBy";
		public const string IsDeleted                 = "IsDeleted";
		public const string DeletedBy                 = "DeletedBy";
		public const string DeletedDate               = "DeletedDate";
	}
	
	/// <summary>
	/// Data access class for the "INVTransferLine" table.
	/// </summary>
	[Serializable]
	public class INVTransferLineBase
	{
		
		#region Class Level Variables
		
		private DatabaseHelper oDatabaseHelper = new DatabaseHelper();

		private int?           	_transferLineIDNonDefault	= null;
		private int?           	_transferHeaderIDNonDefault	= null;
		private int?           	_productIDNonDefault     	= null;
		private decimal?       	_qtyNonDefault           	= null;
		private int?           	_createdByNonDefault     	= null;
		private DateTime?      	_createDateNonDefault    	= null;
		private int?           	_updatedByNonDefault     	= null;
		private bool?          	_isDeletedNonDefault     	= null;
		private int?           	_deletedByNonDefault     	= null;
		private DateTime?      	_deletedDateNonDefault   	= null;
		
		#endregion
		
		#region Constants
		
		#endregion
		
		#region Constructors / Destructors

		/// <summary>
		/// Class Constructor
		///</summary>
		public INVTransferLineBase() { }
					
		#endregion
		
		#region Properties

		/// <summary>
		/// Returns the identifier of the persistent object. Don't set it manually!
		/// </summary>
		public int? TransferLineID
		{
			get 
			{ 
				return _transferLineIDNonDefault;
			}
			set 
			{
			
				_transferLineIDNonDefault = value; 
			}
		}

		/// <summary>
		/// The foreign key connected with another persistent object.
		/// </summary>
		public int? TransferHeaderID
		{
			get 
			{ 
				return _transferHeaderIDNonDefault;
			}
			set 
			{
			
				_transferHeaderIDNonDefault = value; 
			}
		}

		/// <summary>
		/// The foreign key connected with another persistent object.
		/// </summary>
		public int? ProductID
		{
			get 
			{ 
				return _productIDNonDefault;
			}
			set 
			{
			
				_productIDNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "Qty" field.  
		/// </summary>
		public decimal? Qty
		{
			get 
			{ 
				return _qtyNonDefault;
			}
			set 
			{
			
				_qtyNonDefault = value; 
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
		/// This property is mapped to the "IsDeleted" field.  
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
		/// DLGenerator			2/16/2015 7:27:49 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool InsertWithDefaultValues(bool getBackValues) 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_transferHeaderID' as parameter 'TransferHeaderID' of the stored procedure.
			if(_transferHeaderIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@TransferHeaderID", _transferHeaderIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@TransferHeaderID", DBNull.Value );
			  
			// Pass the value of '_productID' as parameter 'ProductID' of the stored procedure.
			if(_productIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@ProductID", _productIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@ProductID", DBNull.Value );
			  
			// Pass the value of '_qty' as parameter 'Qty' of the stored procedure.
			if(_qtyNonDefault!=null)
			  oDatabaseHelper.AddParameter("@Qty", _qtyNonDefault);
			else
			  oDatabaseHelper.AddParameter("@Qty", DBNull.Value );
			  
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
				oDatabaseHelper.ExecuteScalar("gsp_INVTransferLine_Insert_WithDefaultValues", ref ExecutionState);
			}
			else
			{
				IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_INVTransferLine_Insert_WithDefaultValues_AndReturn", ref ExecutionState);
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
		/// DLGenerator			2/16/2015 7:27:49 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Insert() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_transferHeaderID' as parameter 'TransferHeaderID' of the stored procedure.
			if(_transferHeaderIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@TransferHeaderID", _transferHeaderIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@TransferHeaderID", DBNull.Value );
			// Pass the value of '_productID' as parameter 'ProductID' of the stored procedure.
			if(_productIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@ProductID", _productIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@ProductID", DBNull.Value );
			// Pass the value of '_qty' as parameter 'Qty' of the stored procedure.
			if(_qtyNonDefault!=null)
			  oDatabaseHelper.AddParameter("@Qty", _qtyNonDefault);
			else
			  oDatabaseHelper.AddParameter("@Qty", DBNull.Value );
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
			
			oDatabaseHelper.ExecuteScalar("gsp_INVTransferLine_Insert", ref ExecutionState);
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
		/// DLGenerator			2/16/2015 7:27:49 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Update() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_transferLineID' as parameter 'TransferLineID' of the stored procedure.
			oDatabaseHelper.AddParameter("@TransferLineID", _transferLineIDNonDefault );
			
			// Pass the value of '_transferHeaderID' as parameter 'TransferHeaderID' of the stored procedure.
			oDatabaseHelper.AddParameter("@TransferHeaderID", _transferHeaderIDNonDefault );
			
			// Pass the value of '_productID' as parameter 'ProductID' of the stored procedure.
			oDatabaseHelper.AddParameter("@ProductID", _productIDNonDefault );
			
			// Pass the value of '_qty' as parameter 'Qty' of the stored procedure.
			oDatabaseHelper.AddParameter("@Qty", _qtyNonDefault );
			
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
			
			oDatabaseHelper.ExecuteScalar("gsp_INVTransferLine_Update", ref ExecutionState);
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
		/// DLGenerator			2/16/2015 7:27:49 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Delete() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_transferLineID' as parameter 'TransferLineID' of the stored procedure.
			if(_transferLineIDNonDefault!=null)
				oDatabaseHelper.AddParameter("@TransferLineID", _transferLineIDNonDefault );
			else
				oDatabaseHelper.AddParameter("@TransferLineID", DBNull.Value );
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_INVTransferLine_Delete", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will Delete one row from the database using the primary key information
		/// </summary>
		///
		/// <param name="pk" type="INVTransferLinePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>True if succeeded</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/16/2015 7:27:49 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static bool Delete(INVTransferLinePrimaryKey pk) 
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
   
			oDatabaseHelper.ExecuteScalar("gsp_INVTransferLine_Delete", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="INVTransferLineFields">Field of the class INVTransferLine</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		///
		/// <returns>True if succeeded</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/16/2015 7:27:49 PM		Created function
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
			
			oDatabaseHelper.ExecuteScalar("gsp_INVTransferLine_DeleteByField", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="INVTransferLinePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class INVTransferLine</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/16/2015 7:27:49 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static INVTransferLine SelectOne(INVTransferLinePrimaryKey pk)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_INVTransferLine_SelectbyPrimaryKey", ref ExecutionState);
			if (dr.Read())
			{
				INVTransferLine obj=new INVTransferLine();	
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
		/// <returns>list of objects of class INVTransferLine in the form of object of INVTransferLineCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/16/2015 7:27:49 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static INVTransferLineCollection SelectAll()
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_INVTransferLine_SelectAll", ref ExecutionState);
			INVTransferLineCollection INVTransferLineCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return INVTransferLineCollection;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class INVTransferLine</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class INVTransferLine in the form of an object of class INVTransferLineCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/16/2015 7:27:49 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static INVTransferLineCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_INVTransferLine_SelectByField", ref ExecutionState);
			INVTransferLineCollection INVTransferLineCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return INVTransferLineCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number</param>
		///
		/// <returns>list of objects of class INVTransferLine in the form of object of INVTransferLineCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/16/2015 7:27:49 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static INVTransferLineCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// Pass the specified field and its value to the stored procedure.
			oDatabaseHelper.AddParameter("@PageSize",pageSize);
			oDatabaseHelper.AddParameter("@SkipPages", skipPages);
			oDatabaseHelper.AddParameter("@OrderByStatement", orderByStatement );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_INVTransferLine_SelectAllPaged", ref ExecutionState);
			INVTransferLineCollection INVTransferLineCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return INVTransferLineCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class INVTransferLine</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class INVTransferLine in the form of an object of class INVTransferLineCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/16/2015 7:27:49 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static INVTransferLineCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_INVTransferLine_SelectByFieldPaged", ref ExecutionState);
			INVTransferLineCollection INVTransferLineCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return INVTransferLineCollection;
			
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
		/// DLGenerator			2/16/2015 7:27:49 PM		Created function
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
			
			Object dr=oDatabaseHelper.ExecuteScalar("gsp_INVTransferLine_SelectAllCount");
			int count = Convert.ToInt32(dr);		
			oDatabaseHelper.Dispose();
			return count;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="BDProductPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class INVTransferLineCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/16/2015 7:27:49 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static INVTransferLineCollection SelectAllByForeignKeyProductID(BDProductPrimaryKey pk)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			INVTransferLineCollection obj = null;
			
			// Pass the values of all key parameters to the stored procedure.
			System.Collections.Specialized.NameValueCollection nvc = pk.GetKeysAndValues();
			foreach (string key in nvc.Keys)
			{
				oDatabaseHelper.AddParameter("@" + key,nvc[key] );
			}
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_INVTransferLine_SelectAllByForeignKeyProductID", ref ExecutionState);
			obj = new INVTransferLineCollection();
			obj = INVTransferLine.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
			dr.Close();  
			oDatabaseHelper.Dispose();
			return obj;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="BDProductPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number</param>
		///
		/// <returns>object of class INVTransferLineCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/16/2015 7:27:49 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static INVTransferLineCollection SelectAllByForeignKeyProductIDPaged(BDProductPrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			INVTransferLineCollection obj = null;
			
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_INVTransferLine_SelectAllByForeignKeyProductIDPaged", ref ExecutionState);
			obj = new INVTransferLineCollection();
			obj = INVTransferLine.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
			dr.Close();  
			oDatabaseHelper.Dispose();
			return obj;
			
		}

		/// <summary>
		/// This method will delete row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="BDProductPrimaryKey">Primary Key information based on which data is to be deleted.</param>
		///
		/// <returns>object of boolean type as an indicator for operation success .</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/16/2015 7:27:49 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static bool DeleteAllByForeignKeyProductID(BDProductPrimaryKey pk)
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
			
			oDatabaseHelper.ExecuteNonQuery("gsp_INVTransferLine_DeleteAllByForeignKeyProductID", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}



		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="INVTransferHeaderPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class INVTransferLineCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/16/2015 7:27:49 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static INVTransferLineCollection SelectAllByForeignKeyTransferHeaderID(INVTransferHeaderPrimaryKey pk)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			INVTransferLineCollection obj = null;
			
			// Pass the values of all key parameters to the stored procedure.
			System.Collections.Specialized.NameValueCollection nvc = pk.GetKeysAndValues();
			foreach (string key in nvc.Keys)
			{
				oDatabaseHelper.AddParameter("@" + key,nvc[key] );
			}
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_INVTransferLine_SelectAllByForeignKeyTransferHeaderID", ref ExecutionState);
			obj = new INVTransferLineCollection();
			obj = INVTransferLine.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
			dr.Close();  
			oDatabaseHelper.Dispose();
			return obj;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="INVTransferHeaderPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number</param>
		///
		/// <returns>object of class INVTransferLineCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/16/2015 7:27:49 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static INVTransferLineCollection SelectAllByForeignKeyTransferHeaderIDPaged(INVTransferHeaderPrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			INVTransferLineCollection obj = null;
			
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_INVTransferLine_SelectAllByForeignKeyTransferHeaderIDPaged", ref ExecutionState);
			obj = new INVTransferLineCollection();
			obj = INVTransferLine.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
			dr.Close();  
			oDatabaseHelper.Dispose();
			return obj;
			
		}

		/// <summary>
		/// This method will delete row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="INVTransferHeaderPrimaryKey">Primary Key information based on which data is to be deleted.</param>
		///
		/// <returns>object of boolean type as an indicator for operation success .</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/16/2015 7:27:49 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static bool DeleteAllByForeignKeyTransferHeaderID(INVTransferHeaderPrimaryKey pk)
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
			
			oDatabaseHelper.ExecuteNonQuery("gsp_INVTransferLine_DeleteAllByForeignKeyTransferHeaderID", ref ExecutionState);
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
		/// DLGenerator			2/16/2015 7:27:49 PM		Created function
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
		/// <param name="obj" type="INVTransferLine">Object of INVTransferLine to populate</param>
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/16/2015 7:27:49 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static void PopulateObjectFromReader(INVTransferLineBase obj,IDataReader rdr) 
		{

			obj.TransferLineID = rdr.GetInt32(rdr.GetOrdinal(INVTransferLineFields.TransferLineID));
			if (!rdr.IsDBNull(rdr.GetOrdinal(INVTransferLineFields.TransferHeaderID)))
			{
				obj.TransferHeaderID = rdr.GetInt32(rdr.GetOrdinal(INVTransferLineFields.TransferHeaderID));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(INVTransferLineFields.ProductID)))
			{
				obj.ProductID = rdr.GetInt32(rdr.GetOrdinal(INVTransferLineFields.ProductID));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(INVTransferLineFields.Qty)))
			{
				obj.Qty = rdr.GetDecimal(rdr.GetOrdinal(INVTransferLineFields.Qty));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(INVTransferLineFields.CreatedBy)))
			{
				obj.CreatedBy = rdr.GetInt32(rdr.GetOrdinal(INVTransferLineFields.CreatedBy));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(INVTransferLineFields.CreateDate)))
			{
				obj.CreateDate = rdr.GetDateTime(rdr.GetOrdinal(INVTransferLineFields.CreateDate));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(INVTransferLineFields.UpdatedBy)))
			{
				obj.UpdatedBy = rdr.GetInt32(rdr.GetOrdinal(INVTransferLineFields.UpdatedBy));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(INVTransferLineFields.IsDeleted)))
			{
				obj.IsDeleted = rdr.GetBoolean(rdr.GetOrdinal(INVTransferLineFields.IsDeleted));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(INVTransferLineFields.DeletedBy)))
			{
				obj.DeletedBy = rdr.GetInt32(rdr.GetOrdinal(INVTransferLineFields.DeletedBy));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(INVTransferLineFields.DeletedDate)))
			{
				obj.DeletedDate = rdr.GetDateTime(rdr.GetOrdinal(INVTransferLineFields.DeletedDate));
			}
			

		}

		/// <summary>
		/// Populates the fields for multiple objects from the columns found in an open reader.
		/// </summary>
		///
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <returns>Object of INVTransferLineCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/16/2015 7:27:49 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static INVTransferLineCollection PopulateObjectsFromReader(IDataReader rdr) 
		{
			INVTransferLineCollection list = new INVTransferLineCollection();
			
			while (rdr.Read())
			{
				INVTransferLine obj = new INVTransferLine();
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
		/// <returns>Object of INVTransferLineCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/16/2015 7:27:49 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static INVTransferLineCollection PopulateObjectsFromReaderWithCheckingReader(IDataReader rdr, DatabaseHelper oDatabaseHelper) 
		{

			INVTransferLineCollection list = new INVTransferLineCollection();
			
            if (rdr.Read())
			{
				INVTransferLine obj = new INVTransferLine();
				PopulateObjectFromReader(obj, rdr);
				list.Add(obj);
				while (rdr.Read())
				{
					obj = new INVTransferLine();
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
