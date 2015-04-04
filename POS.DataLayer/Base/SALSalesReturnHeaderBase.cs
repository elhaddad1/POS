//
// Class	:	SALSalesReturnHeaderBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	4/4/2015 6:56:38 PM
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
	public class SALSalesReturnHeaderFields
	{
		public const string SlaesReturnHeaderID       = "SlaesReturnHeaderID";
		public const string ReturnDate                = "ReturnDate";
		public const string OriginalSalesHeadeID      = "OriginalSalesHeadeID";
		public const string CreatedBy                 = "CreatedBy";
		public const string CreateDate                = "CreateDate";
		public const string UpdatedBy                 = "UpdatedBy";
		public const string UpdateDate                = "UpdateDate";
		public const string IsDeleted                 = "IsDeleted";
		public const string DeletedBy                 = "DeletedBy";
		public const string DeleteDate                = "DeleteDate";
		public const string IsClosed                  = "IsClosed";
		public const string IsVoid                    = "IsVoid";
		public const string InventoryID               = "InventoryID";
		public const string ReturnMoney               = "ReturnMoney";
	}
	
	/// <summary>
	/// Data access class for the "SALSalesReturnHeader" table.
	/// </summary>
	[Serializable]
	public class SALSalesReturnHeaderBase
	{
		
		#region Class Level Variables
		
		private DatabaseHelper oDatabaseHelper = new DatabaseHelper();

		private int?           	_slaesReturnHeaderIDNonDefault	= null;
		private DateTime?      	_returnDateNonDefault    	= null;
		private int?           	_originalSalesHeadeIDNonDefault	= null;
		private int?           	_createdByNonDefault     	= null;
		private DateTime?      	_createDateNonDefault    	= null;
		private int?           	_updatedByNonDefault     	= null;
		private DateTime?      	_updateDateNonDefault    	= null;
		private bool?          	_isDeletedNonDefault     	= false;
		private string         	_deletedByNonDefault     	= null;
		private DateTime?      	_deleteDateNonDefault    	= null;
		private bool?          	_isClosedNonDefault      	= null;
		private bool?          	_isVoidNonDefault        	= null;
		private int?           	_inventoryIDNonDefault   	= null;
		private decimal?       	_returnMoneyNonDefault   	= null;

		private SALSalesReturnLineCollection _sALSalesReturnLineCollectionSalesReturnHeaderID = null;
		
		#endregion
		
		#region Constants
		
		#endregion
		
		#region Constructors / Destructors

		/// <summary>
		/// Class Constructor
		///</summary>
		public SALSalesReturnHeaderBase() { }
					
		#endregion
		
		#region Properties

		/// <summary>
		/// Returns the identifier of the persistent object. Don't set it manually!
		/// </summary>
		public int? SlaesReturnHeaderID
		{
			get 
			{ 
				return _slaesReturnHeaderIDNonDefault;
			}
			set 
			{
			
				_slaesReturnHeaderIDNonDefault = value; 
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
		/// This property is mapped to the "OriginalSalesHeadeID" field.  
		/// </summary>
		public int? OriginalSalesHeadeID
		{
			get 
			{ 
				return _originalSalesHeadeIDNonDefault;
			}
			set 
			{
			
				_originalSalesHeadeIDNonDefault = value; 
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

		/// <summary>
		/// This property is mapped to the "IsClosed" field.  Mandatory.
		/// </summary>
		public bool? IsClosed
		{
			get 
			{ 
				return _isClosedNonDefault;
			}
			set 
			{
			
				_isClosedNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "IsVoid" field.  Mandatory.
		/// </summary>
		public bool? IsVoid
		{
			get 
			{ 
				return _isVoidNonDefault;
			}
			set 
			{
			
				_isVoidNonDefault = value; 
			}
		}

		/// <summary>
		/// The foreign key connected with another persistent object.
		/// </summary>
		public int? InventoryID
		{
			get 
			{ 
				return _inventoryIDNonDefault;
			}
			set 
			{
			
				_inventoryIDNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "ReturnMoney" field.  Mandatory.
		/// </summary>
		public decimal? ReturnMoney
		{
			get 
			{ 
				return _returnMoneyNonDefault;
			}
			set 
			{
			
				_returnMoneyNonDefault = value; 
			}
		}

		/// <summary>
		/// Provides access to the related table 'SALSalesReturnLine'
		/// </summary>
		public SALSalesReturnLineCollection SALSalesReturnLineCollectionUsingSalesReturnHeaderID
		{
			get 
			{
				if (_sALSalesReturnLineCollectionSalesReturnHeaderID == null)
				{
					_sALSalesReturnLineCollectionSalesReturnHeaderID = new SALSalesReturnLineCollection();
					_sALSalesReturnLineCollectionSalesReturnHeaderID = SALSalesReturnLine.SelectByField("SalesReturnHeaderID",SlaesReturnHeaderID, null, TypeOperation.Equal);
				}                
				return _sALSalesReturnLineCollectionSalesReturnHeaderID; 
			}
			set 
			{
				  _sALSalesReturnLineCollectionSalesReturnHeaderID = value;
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
		/// DLGenerator			4/4/2015 6:56:38 PM		Created function
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
			  
			// Pass the value of '_originalSalesHeadeID' as parameter 'OriginalSalesHeadeID' of the stored procedure.
			if(_originalSalesHeadeIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@OriginalSalesHeadeID", _originalSalesHeadeIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@OriginalSalesHeadeID", DBNull.Value );
			  
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
			  
			// Pass the value of '_isClosed' as parameter 'IsClosed' of the stored procedure.
			if(_isClosedNonDefault!=null)
			  oDatabaseHelper.AddParameter("@IsClosed", _isClosedNonDefault);
			else
			  oDatabaseHelper.AddParameter("@IsClosed", DBNull.Value );
			  
			// Pass the value of '_isVoid' as parameter 'IsVoid' of the stored procedure.
			if(_isVoidNonDefault!=null)
			  oDatabaseHelper.AddParameter("@IsVoid", _isVoidNonDefault);
			else
			  oDatabaseHelper.AddParameter("@IsVoid", DBNull.Value );
			  
			// Pass the value of '_inventoryID' as parameter 'InventoryID' of the stored procedure.
			if(_inventoryIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@InventoryID", _inventoryIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@InventoryID", DBNull.Value );
			  
			// Pass the value of '_returnMoney' as parameter 'ReturnMoney' of the stored procedure.
			if(_returnMoneyNonDefault!=null)
			  oDatabaseHelper.AddParameter("@ReturnMoney", _returnMoneyNonDefault);
			else
			  oDatabaseHelper.AddParameter("@ReturnMoney", DBNull.Value );
			  
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			if(!getBackValues )
			{
				oDatabaseHelper.ExecuteScalar("gsp_SALSalesReturnHeader_Insert_WithDefaultValues", ref ExecutionState);
			}
			else
			{
				IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_SALSalesReturnHeader_Insert_WithDefaultValues_AndReturn", ref ExecutionState);
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
		/// DLGenerator			4/4/2015 6:56:38 PM		Created function
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
			// Pass the value of '_originalSalesHeadeID' as parameter 'OriginalSalesHeadeID' of the stored procedure.
			if(_originalSalesHeadeIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@OriginalSalesHeadeID", _originalSalesHeadeIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@OriginalSalesHeadeID", DBNull.Value );
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
			// Pass the value of '_isClosed' as parameter 'IsClosed' of the stored procedure.
			if(_isClosedNonDefault!=null)
			  oDatabaseHelper.AddParameter("@IsClosed", _isClosedNonDefault);
			else
			  oDatabaseHelper.AddParameter("@IsClosed", DBNull.Value );
			// Pass the value of '_isVoid' as parameter 'IsVoid' of the stored procedure.
			if(_isVoidNonDefault!=null)
			  oDatabaseHelper.AddParameter("@IsVoid", _isVoidNonDefault);
			else
			  oDatabaseHelper.AddParameter("@IsVoid", DBNull.Value );
			// Pass the value of '_inventoryID' as parameter 'InventoryID' of the stored procedure.
			if(_inventoryIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@InventoryID", _inventoryIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@InventoryID", DBNull.Value );
			// Pass the value of '_returnMoney' as parameter 'ReturnMoney' of the stored procedure.
			if(_returnMoneyNonDefault!=null)
			  oDatabaseHelper.AddParameter("@ReturnMoney", _returnMoneyNonDefault);
			else
			  oDatabaseHelper.AddParameter("@ReturnMoney", DBNull.Value );
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_SALSalesReturnHeader_Insert", ref ExecutionState);
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
		/// DLGenerator			4/4/2015 6:56:38 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Update() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_slaesReturnHeaderID' as parameter 'SlaesReturnHeaderID' of the stored procedure.
			oDatabaseHelper.AddParameter("@SlaesReturnHeaderID", _slaesReturnHeaderIDNonDefault );
			
			// Pass the value of '_returnDate' as parameter 'ReturnDate' of the stored procedure.
			oDatabaseHelper.AddParameter("@ReturnDate", _returnDateNonDefault );
			
			// Pass the value of '_originalSalesHeadeID' as parameter 'OriginalSalesHeadeID' of the stored procedure.
			oDatabaseHelper.AddParameter("@OriginalSalesHeadeID", _originalSalesHeadeIDNonDefault );
			
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
			
			// Pass the value of '_isClosed' as parameter 'IsClosed' of the stored procedure.
			oDatabaseHelper.AddParameter("@IsClosed", _isClosedNonDefault );
			
			// Pass the value of '_isVoid' as parameter 'IsVoid' of the stored procedure.
			oDatabaseHelper.AddParameter("@IsVoid", _isVoidNonDefault );
			
			// Pass the value of '_inventoryID' as parameter 'InventoryID' of the stored procedure.
			oDatabaseHelper.AddParameter("@InventoryID", _inventoryIDNonDefault );
			
			// Pass the value of '_returnMoney' as parameter 'ReturnMoney' of the stored procedure.
			oDatabaseHelper.AddParameter("@ReturnMoney", _returnMoneyNonDefault );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_SALSalesReturnHeader_Update", ref ExecutionState);
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
		/// DLGenerator			4/4/2015 6:56:38 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Delete() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_slaesReturnHeaderID' as parameter 'SlaesReturnHeaderID' of the stored procedure.
			if(_slaesReturnHeaderIDNonDefault!=null)
				oDatabaseHelper.AddParameter("@SlaesReturnHeaderID", _slaesReturnHeaderIDNonDefault );
			else
				oDatabaseHelper.AddParameter("@SlaesReturnHeaderID", DBNull.Value );
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_SALSalesReturnHeader_Delete", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will Delete one row from the database using the primary key information
		/// </summary>
		///
		/// <param name="pk" type="SALSalesReturnHeaderPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>True if succeeded</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			4/4/2015 6:56:38 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static bool Delete(SALSalesReturnHeaderPrimaryKey pk) 
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
   
			oDatabaseHelper.ExecuteScalar("gsp_SALSalesReturnHeader_Delete", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="SALSalesReturnHeaderFields">Field of the class SALSalesReturnHeader</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		///
		/// <returns>True if succeeded</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			4/4/2015 6:56:38 PM		Created function
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
			
			oDatabaseHelper.ExecuteScalar("gsp_SALSalesReturnHeader_DeleteByField", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="SALSalesReturnHeaderPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class SALSalesReturnHeader</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			4/4/2015 6:56:38 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static SALSalesReturnHeader SelectOne(SALSalesReturnHeaderPrimaryKey pk)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_SALSalesReturnHeader_SelectbyPrimaryKey", ref ExecutionState);
			if (dr.Read())
			{
				SALSalesReturnHeader obj=new SALSalesReturnHeader();	
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
		/// <returns>list of objects of class SALSalesReturnHeader in the form of object of SALSalesReturnHeaderCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			4/4/2015 6:56:38 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static SALSalesReturnHeaderCollection SelectAll()
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_SALSalesReturnHeader_SelectAll", ref ExecutionState);
			SALSalesReturnHeaderCollection SALSalesReturnHeaderCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return SALSalesReturnHeaderCollection;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class SALSalesReturnHeader</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class SALSalesReturnHeader in the form of an object of class SALSalesReturnHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			4/4/2015 6:56:38 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static SALSalesReturnHeaderCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_SALSalesReturnHeader_SelectByField", ref ExecutionState);
			SALSalesReturnHeaderCollection SALSalesReturnHeaderCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return SALSalesReturnHeaderCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number</param>
		///
		/// <returns>list of objects of class SALSalesReturnHeader in the form of object of SALSalesReturnHeaderCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			4/4/2015 6:56:38 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static SALSalesReturnHeaderCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// Pass the specified field and its value to the stored procedure.
			oDatabaseHelper.AddParameter("@PageSize",pageSize);
			oDatabaseHelper.AddParameter("@SkipPages", skipPages);
			oDatabaseHelper.AddParameter("@OrderByStatement", orderByStatement );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_SALSalesReturnHeader_SelectAllPaged", ref ExecutionState);
			SALSalesReturnHeaderCollection SALSalesReturnHeaderCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return SALSalesReturnHeaderCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class SALSalesReturnHeader</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class SALSalesReturnHeader in the form of an object of class SALSalesReturnHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			4/4/2015 6:56:38 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static SALSalesReturnHeaderCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_SALSalesReturnHeader_SelectByFieldPaged", ref ExecutionState);
			SALSalesReturnHeaderCollection SALSalesReturnHeaderCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return SALSalesReturnHeaderCollection;
			
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
		/// DLGenerator			4/4/2015 6:56:38 PM		Created function
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
			
			Object dr=oDatabaseHelper.ExecuteScalar("gsp_SALSalesReturnHeader_SelectAllCount");
			int count = Convert.ToInt32(dr);		
			oDatabaseHelper.Dispose();
			return count;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="SALSalesReturnHeaderPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class SALSalesReturnHeader</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			4/4/2015 6:56:38 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static SALSalesReturnHeader SelectOneWithSALSalesReturnLineUsingSalesReturnHeaderID(SALSalesReturnHeaderPrimaryKey pk)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			SALSalesReturnHeader obj=null;
			
			// Pass the values of all key parameters to the stored procedure.
			System.Collections.Specialized.NameValueCollection nvc = pk.GetKeysAndValues();
			foreach (string key in nvc.Keys)
			{
				oDatabaseHelper.AddParameter("@" + key,nvc[key] );
			}
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_SALSalesReturnHeader_SelectOneWithSALSalesReturnLineUsingSalesReturnHeaderID", ref ExecutionState);
			if (dr.Read())
			{
				obj= new SALSalesReturnHeader();
				PopulateObjectFromReader(obj,dr);
				
				dr.NextResult();
				
				//Get the child records.
				obj.SALSalesReturnLineCollectionUsingSalesReturnHeaderID=SALSalesReturnLine.PopulateObjectsFromReader(dr);
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
		/// <param name="pk" type="INVInventoryPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class SALSalesReturnHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			4/4/2015 6:56:38 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static SALSalesReturnHeaderCollection SelectAllByForeignKeyInventoryID(INVInventoryPrimaryKey pk)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			SALSalesReturnHeaderCollection obj = null;
			
			// Pass the values of all key parameters to the stored procedure.
			System.Collections.Specialized.NameValueCollection nvc = pk.GetKeysAndValues();
			foreach (string key in nvc.Keys)
			{
				oDatabaseHelper.AddParameter("@" + key,nvc[key] );
			}
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_SALSalesReturnHeader_SelectAllByForeignKeyInventoryID", ref ExecutionState);
			obj = new SALSalesReturnHeaderCollection();
			obj = SALSalesReturnHeader.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
			dr.Close();  
			oDatabaseHelper.Dispose();
			return obj;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="INVInventoryPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number</param>
		///
		/// <returns>object of class SALSalesReturnHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			4/4/2015 6:56:38 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static SALSalesReturnHeaderCollection SelectAllByForeignKeyInventoryIDPaged(INVInventoryPrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			SALSalesReturnHeaderCollection obj = null;
			
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_SALSalesReturnHeader_SelectAllByForeignKeyInventoryIDPaged", ref ExecutionState);
			obj = new SALSalesReturnHeaderCollection();
			obj = SALSalesReturnHeader.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
			dr.Close();  
			oDatabaseHelper.Dispose();
			return obj;
			
		}

		/// <summary>
		/// This method will delete row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="INVInventoryPrimaryKey">Primary Key information based on which data is to be deleted.</param>
		///
		/// <returns>object of boolean type as an indicator for operation success .</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			4/4/2015 6:56:38 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static bool DeleteAllByForeignKeyInventoryID(INVInventoryPrimaryKey pk)
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
			
			oDatabaseHelper.ExecuteNonQuery("gsp_SALSalesReturnHeader_DeleteAllByForeignKeyInventoryID", ref ExecutionState);
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
		/// DLGenerator			4/4/2015 6:56:38 PM		Created function
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
		/// <param name="obj" type="SALSalesReturnHeader">Object of SALSalesReturnHeader to populate</param>
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			4/4/2015 6:56:38 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static void PopulateObjectFromReader(SALSalesReturnHeaderBase obj,IDataReader rdr) 
		{

			obj.SlaesReturnHeaderID = rdr.GetInt32(rdr.GetOrdinal(SALSalesReturnHeaderFields.SlaesReturnHeaderID));
			obj.ReturnDate = rdr.GetDateTime(rdr.GetOrdinal(SALSalesReturnHeaderFields.ReturnDate));
			if (!rdr.IsDBNull(rdr.GetOrdinal(SALSalesReturnHeaderFields.OriginalSalesHeadeID)))
			{
				obj.OriginalSalesHeadeID = rdr.GetInt32(rdr.GetOrdinal(SALSalesReturnHeaderFields.OriginalSalesHeadeID));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(SALSalesReturnHeaderFields.CreatedBy)))
			{
				obj.CreatedBy = rdr.GetInt32(rdr.GetOrdinal(SALSalesReturnHeaderFields.CreatedBy));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(SALSalesReturnHeaderFields.CreateDate)))
			{
				obj.CreateDate = rdr.GetDateTime(rdr.GetOrdinal(SALSalesReturnHeaderFields.CreateDate));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(SALSalesReturnHeaderFields.UpdatedBy)))
			{
				obj.UpdatedBy = rdr.GetInt32(rdr.GetOrdinal(SALSalesReturnHeaderFields.UpdatedBy));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(SALSalesReturnHeaderFields.UpdateDate)))
			{
				obj.UpdateDate = rdr.GetDateTime(rdr.GetOrdinal(SALSalesReturnHeaderFields.UpdateDate));
			}
			
			obj.IsDeleted = rdr.GetBoolean(rdr.GetOrdinal(SALSalesReturnHeaderFields.IsDeleted));
			if (!rdr.IsDBNull(rdr.GetOrdinal(SALSalesReturnHeaderFields.DeletedBy)))
			{
				obj.DeletedBy = rdr.GetString(rdr.GetOrdinal(SALSalesReturnHeaderFields.DeletedBy));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(SALSalesReturnHeaderFields.DeleteDate)))
			{
				obj.DeleteDate = rdr.GetDateTime(rdr.GetOrdinal(SALSalesReturnHeaderFields.DeleteDate));
			}
			
			obj.IsClosed = rdr.GetBoolean(rdr.GetOrdinal(SALSalesReturnHeaderFields.IsClosed));
			obj.IsVoid = rdr.GetBoolean(rdr.GetOrdinal(SALSalesReturnHeaderFields.IsVoid));
			obj.InventoryID = rdr.GetInt32(rdr.GetOrdinal(SALSalesReturnHeaderFields.InventoryID));
			obj.ReturnMoney = rdr.GetDecimal(rdr.GetOrdinal(SALSalesReturnHeaderFields.ReturnMoney));

		}

		/// <summary>
		/// Populates the fields for multiple objects from the columns found in an open reader.
		/// </summary>
		///
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <returns>Object of SALSalesReturnHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			4/4/2015 6:56:38 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static SALSalesReturnHeaderCollection PopulateObjectsFromReader(IDataReader rdr) 
		{
			SALSalesReturnHeaderCollection list = new SALSalesReturnHeaderCollection();
			
			while (rdr.Read())
			{
				SALSalesReturnHeader obj = new SALSalesReturnHeader();
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
		/// <returns>Object of SALSalesReturnHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			4/4/2015 6:56:38 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static SALSalesReturnHeaderCollection PopulateObjectsFromReaderWithCheckingReader(IDataReader rdr, DatabaseHelper oDatabaseHelper) 
		{

			SALSalesReturnHeaderCollection list = new SALSalesReturnHeaderCollection();
			
            if (rdr.Read())
			{
				SALSalesReturnHeader obj = new SALSalesReturnHeader();
				PopulateObjectFromReader(obj, rdr);
				list.Add(obj);
				while (rdr.Read())
				{
					obj = new SALSalesReturnHeader();
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
