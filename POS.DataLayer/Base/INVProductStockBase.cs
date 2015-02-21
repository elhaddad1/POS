//
// Class	:	INVProductStockBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	2/20/2015 7:03:50 PM
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
	public class INVProductStockFields
	{
		public const string ProductStockID            = "ProductStockID";
		public const string ProductID                 = "ProductID";
		public const string TotalQty                  = "TotalQty";
		public const string StockTypeID               = "StockTypeID";
		public const string OpeningQty                = "OpeningQty";
		public const string OpennigDate               = "OpennigDate";
		public const string CreateDate                = "CreateDate";
		public const string CreatedBy                 = "CreatedBy";
		public const string UpdateDate                = "UpdateDate";
		public const string UpdatedBy                 = "UpdatedBy";
		public const string InventoryID               = "InventoryID";
		public const string IsBlocked                 = "IsBlocked";
	}
	
	/// <summary>
	/// Data access class for the "INVProductStock" table.
	/// </summary>
	[Serializable]
	public class INVProductStockBase
	{
		
		#region Class Level Variables
		
		private DatabaseHelper oDatabaseHelper = new DatabaseHelper();

		private int?           	_productStockIDNonDefault	= null;
		private int?           	_productIDNonDefault     	= null;
		private decimal?       	_totalQtyNonDefault      	= 0;
		private int?           	_stockTypeIDNonDefault   	= null;
		private decimal?       	_openingQtyNonDefault    	= 0;
		private DateTime?      	_opennigDateNonDefault   	= null;
		private DateTime?      	_createDateNonDefault    	= null;
		private int?           	_createdByNonDefault     	= null;
		private DateTime?      	_updateDateNonDefault    	= null;
		private int?           	_updatedByNonDefault     	= null;
		private int?           	_inventoryIDNonDefault   	= null;
		private bool?          	_isBlockedNonDefault     	= null;

		private INVProductStockBatchCollection _iNVProductStockBatchCollectionProductStockID = null;
		
		#endregion
		
		#region Constants
		
		#endregion
		
		#region Constructors / Destructors

		/// <summary>
		/// Class Constructor
		///</summary>
		public INVProductStockBase() { }
					
		#endregion
		
		#region Properties

		/// <summary>
		/// Returns the identifier of the persistent object. Don't set it manually!
		/// </summary>
		public int? ProductStockID
		{
			get 
			{ 
				return _productStockIDNonDefault;
			}
			set 
			{
			
				_productStockIDNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "ProductID" field.  Mandatory.
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
		/// This property is mapped to the "TotalQty" field.  Mandatory.
		/// </summary>
		public decimal? TotalQty
		{
			get 
			{ 
				return _totalQtyNonDefault;
			}
			set 
			{
			
				_totalQtyNonDefault = value; 
			}
		}

		/// <summary>
		/// The foreign key connected with another persistent object.
		/// </summary>
		public int? StockTypeID
		{
			get 
			{ 
				return _stockTypeIDNonDefault;
			}
			set 
			{
			
				_stockTypeIDNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "OpeningQty" field.  Mandatory.
		/// </summary>
		public decimal? OpeningQty
		{
			get 
			{ 
				return _openingQtyNonDefault;
			}
			set 
			{
			
				_openingQtyNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "OpennigDate" field.  
		/// </summary>
		public DateTime? OpennigDate
		{
			get 
			{ 
				return _opennigDateNonDefault;
			}
			set 
			{
			
				_opennigDateNonDefault = value; 
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
		/// This property is mapped to the "IsBlocked" field.  
		/// </summary>
		public bool? IsBlocked
		{
			get 
			{ 
				return _isBlockedNonDefault;
			}
			set 
			{
			
				_isBlockedNonDefault = value; 
			}
		}

		/// <summary>
		/// Provides access to the related table 'INVProductStockBatch'
		/// </summary>
		public INVProductStockBatchCollection INVProductStockBatchCollectionUsingProductStockID
		{
			get 
			{
				if (_iNVProductStockBatchCollectionProductStockID == null)
				{
					_iNVProductStockBatchCollectionProductStockID = new INVProductStockBatchCollection();
					_iNVProductStockBatchCollectionProductStockID = INVProductStockBatch.SelectByField("ProductStockID",ProductStockID, null, TypeOperation.Equal);
				}                
				return _iNVProductStockBatchCollectionProductStockID; 
			}
			set 
			{
				  _iNVProductStockBatchCollectionProductStockID = value;
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
		/// DLGenerator			2/20/2015 7:03:50 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool InsertWithDefaultValues(bool getBackValues) 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_productID' as parameter 'ProductID' of the stored procedure.
			if(_productIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@ProductID", _productIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@ProductID", DBNull.Value );
			  
			// Pass the value of '_totalQty' as parameter 'TotalQty' of the stored procedure.
			if(_totalQtyNonDefault!=null)
			  oDatabaseHelper.AddParameter("@TotalQty", _totalQtyNonDefault);
			else
			  oDatabaseHelper.AddParameter("@TotalQty", DBNull.Value );
			  
			// Pass the value of '_stockTypeID' as parameter 'StockTypeID' of the stored procedure.
			if(_stockTypeIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@StockTypeID", _stockTypeIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@StockTypeID", DBNull.Value );
			  
			// Pass the value of '_openingQty' as parameter 'OpeningQty' of the stored procedure.
			if(_openingQtyNonDefault!=null)
			  oDatabaseHelper.AddParameter("@OpeningQty", _openingQtyNonDefault);
			else
			  oDatabaseHelper.AddParameter("@OpeningQty", DBNull.Value );
			  
			// Pass the value of '_opennigDate' as parameter 'OpennigDate' of the stored procedure.
			if(_opennigDateNonDefault!=null)
			  oDatabaseHelper.AddParameter("@OpennigDate", _opennigDateNonDefault);
			else
			  oDatabaseHelper.AddParameter("@OpennigDate", DBNull.Value );
			  
			// Pass the value of '_createDate' as parameter 'CreateDate' of the stored procedure.
			if(_createDateNonDefault!=null)
			  oDatabaseHelper.AddParameter("@CreateDate", _createDateNonDefault);
			else
			  oDatabaseHelper.AddParameter("@CreateDate", DBNull.Value );
			  
			// Pass the value of '_createdBy' as parameter 'CreatedBy' of the stored procedure.
			if(_createdByNonDefault!=null)
			  oDatabaseHelper.AddParameter("@CreatedBy", _createdByNonDefault);
			else
			  oDatabaseHelper.AddParameter("@CreatedBy", DBNull.Value );
			  
			// Pass the value of '_updateDate' as parameter 'UpdateDate' of the stored procedure.
			if(_updateDateNonDefault!=null)
			  oDatabaseHelper.AddParameter("@UpdateDate", _updateDateNonDefault);
			else
			  oDatabaseHelper.AddParameter("@UpdateDate", DBNull.Value );
			  
			// Pass the value of '_updatedBy' as parameter 'UpdatedBy' of the stored procedure.
			if(_updatedByNonDefault!=null)
			  oDatabaseHelper.AddParameter("@UpdatedBy", _updatedByNonDefault);
			else
			  oDatabaseHelper.AddParameter("@UpdatedBy", DBNull.Value );
			  
			// Pass the value of '_inventoryID' as parameter 'InventoryID' of the stored procedure.
			if(_inventoryIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@InventoryID", _inventoryIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@InventoryID", DBNull.Value );
			  
			// Pass the value of '_isBlocked' as parameter 'IsBlocked' of the stored procedure.
			if(_isBlockedNonDefault!=null)
			  oDatabaseHelper.AddParameter("@IsBlocked", _isBlockedNonDefault);
			else
			  oDatabaseHelper.AddParameter("@IsBlocked", DBNull.Value );
			  
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			if(!getBackValues )
			{
				oDatabaseHelper.ExecuteScalar("gsp_INVProductStock_Insert_WithDefaultValues", ref ExecutionState);
			}
			else
			{
				IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_INVProductStock_Insert_WithDefaultValues_AndReturn", ref ExecutionState);
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
		/// DLGenerator			2/20/2015 7:03:50 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Insert() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_productID' as parameter 'ProductID' of the stored procedure.
			if(_productIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@ProductID", _productIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@ProductID", DBNull.Value );
			// Pass the value of '_totalQty' as parameter 'TotalQty' of the stored procedure.
			if(_totalQtyNonDefault!=null)
			  oDatabaseHelper.AddParameter("@TotalQty", _totalQtyNonDefault);
			else
			  oDatabaseHelper.AddParameter("@TotalQty", DBNull.Value );
			// Pass the value of '_stockTypeID' as parameter 'StockTypeID' of the stored procedure.
			if(_stockTypeIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@StockTypeID", _stockTypeIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@StockTypeID", DBNull.Value );
			// Pass the value of '_openingQty' as parameter 'OpeningQty' of the stored procedure.
			if(_openingQtyNonDefault!=null)
			  oDatabaseHelper.AddParameter("@OpeningQty", _openingQtyNonDefault);
			else
			  oDatabaseHelper.AddParameter("@OpeningQty", DBNull.Value );
			// Pass the value of '_opennigDate' as parameter 'OpennigDate' of the stored procedure.
			if(_opennigDateNonDefault!=null)
			  oDatabaseHelper.AddParameter("@OpennigDate", _opennigDateNonDefault);
			else
			  oDatabaseHelper.AddParameter("@OpennigDate", DBNull.Value );
			// Pass the value of '_createDate' as parameter 'CreateDate' of the stored procedure.
			if(_createDateNonDefault!=null)
			  oDatabaseHelper.AddParameter("@CreateDate", _createDateNonDefault);
			else
			  oDatabaseHelper.AddParameter("@CreateDate", DBNull.Value );
			// Pass the value of '_createdBy' as parameter 'CreatedBy' of the stored procedure.
			if(_createdByNonDefault!=null)
			  oDatabaseHelper.AddParameter("@CreatedBy", _createdByNonDefault);
			else
			  oDatabaseHelper.AddParameter("@CreatedBy", DBNull.Value );
			// Pass the value of '_updateDate' as parameter 'UpdateDate' of the stored procedure.
			if(_updateDateNonDefault!=null)
			  oDatabaseHelper.AddParameter("@UpdateDate", _updateDateNonDefault);
			else
			  oDatabaseHelper.AddParameter("@UpdateDate", DBNull.Value );
			// Pass the value of '_updatedBy' as parameter 'UpdatedBy' of the stored procedure.
			if(_updatedByNonDefault!=null)
			  oDatabaseHelper.AddParameter("@UpdatedBy", _updatedByNonDefault);
			else
			  oDatabaseHelper.AddParameter("@UpdatedBy", DBNull.Value );
			// Pass the value of '_inventoryID' as parameter 'InventoryID' of the stored procedure.
			if(_inventoryIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@InventoryID", _inventoryIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@InventoryID", DBNull.Value );
			// Pass the value of '_isBlocked' as parameter 'IsBlocked' of the stored procedure.
			if(_isBlockedNonDefault!=null)
			  oDatabaseHelper.AddParameter("@IsBlocked", _isBlockedNonDefault);
			else
			  oDatabaseHelper.AddParameter("@IsBlocked", DBNull.Value );
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_INVProductStock_Insert", ref ExecutionState);
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
		/// DLGenerator			2/20/2015 7:03:50 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Update() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_productStockID' as parameter 'ProductStockID' of the stored procedure.
			oDatabaseHelper.AddParameter("@ProductStockID", _productStockIDNonDefault );
			
			// Pass the value of '_productID' as parameter 'ProductID' of the stored procedure.
			oDatabaseHelper.AddParameter("@ProductID", _productIDNonDefault );
			
			// Pass the value of '_totalQty' as parameter 'TotalQty' of the stored procedure.
			oDatabaseHelper.AddParameter("@TotalQty", _totalQtyNonDefault );
			
			// Pass the value of '_stockTypeID' as parameter 'StockTypeID' of the stored procedure.
			oDatabaseHelper.AddParameter("@StockTypeID", _stockTypeIDNonDefault );
			
			// Pass the value of '_openingQty' as parameter 'OpeningQty' of the stored procedure.
			oDatabaseHelper.AddParameter("@OpeningQty", _openingQtyNonDefault );
			
			// Pass the value of '_opennigDate' as parameter 'OpennigDate' of the stored procedure.
			oDatabaseHelper.AddParameter("@OpennigDate", _opennigDateNonDefault );
			
			// Pass the value of '_createDate' as parameter 'CreateDate' of the stored procedure.
			oDatabaseHelper.AddParameter("@CreateDate", _createDateNonDefault );
			
			// Pass the value of '_createdBy' as parameter 'CreatedBy' of the stored procedure.
			oDatabaseHelper.AddParameter("@CreatedBy", _createdByNonDefault );
			
			// Pass the value of '_updateDate' as parameter 'UpdateDate' of the stored procedure.
			oDatabaseHelper.AddParameter("@UpdateDate", _updateDateNonDefault );
			
			// Pass the value of '_updatedBy' as parameter 'UpdatedBy' of the stored procedure.
			oDatabaseHelper.AddParameter("@UpdatedBy", _updatedByNonDefault );
			
			// Pass the value of '_inventoryID' as parameter 'InventoryID' of the stored procedure.
			oDatabaseHelper.AddParameter("@InventoryID", _inventoryIDNonDefault );
			
			// Pass the value of '_isBlocked' as parameter 'IsBlocked' of the stored procedure.
			oDatabaseHelper.AddParameter("@IsBlocked", _isBlockedNonDefault );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_INVProductStock_Update", ref ExecutionState);
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
		/// DLGenerator			2/20/2015 7:03:50 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Delete() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_productStockID' as parameter 'ProductStockID' of the stored procedure.
			if(_productStockIDNonDefault!=null)
				oDatabaseHelper.AddParameter("@ProductStockID", _productStockIDNonDefault );
			else
				oDatabaseHelper.AddParameter("@ProductStockID", DBNull.Value );
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_INVProductStock_Delete", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will Delete one row from the database using the primary key information
		/// </summary>
		///
		/// <param name="pk" type="INVProductStockPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>True if succeeded</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/20/2015 7:03:50 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static bool Delete(INVProductStockPrimaryKey pk) 
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
   
			oDatabaseHelper.ExecuteScalar("gsp_INVProductStock_Delete", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="INVProductStockFields">Field of the class INVProductStock</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		///
		/// <returns>True if succeeded</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/20/2015 7:03:50 PM		Created function
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
			
			oDatabaseHelper.ExecuteScalar("gsp_INVProductStock_DeleteByField", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="INVProductStockPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class INVProductStock</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/20/2015 7:03:50 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static INVProductStock SelectOne(INVProductStockPrimaryKey pk)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_INVProductStock_SelectbyPrimaryKey", ref ExecutionState);
			if (dr.Read())
			{
				INVProductStock obj=new INVProductStock();	
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
		/// <returns>list of objects of class INVProductStock in the form of object of INVProductStockCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/20/2015 7:03:50 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static INVProductStockCollection SelectAll()
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_INVProductStock_SelectAll", ref ExecutionState);
			INVProductStockCollection INVProductStockCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return INVProductStockCollection;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class INVProductStock</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class INVProductStock in the form of an object of class INVProductStockCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/20/2015 7:03:50 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static INVProductStockCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_INVProductStock_SelectByField", ref ExecutionState);
			INVProductStockCollection INVProductStockCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return INVProductStockCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number</param>
		///
		/// <returns>list of objects of class INVProductStock in the form of object of INVProductStockCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/20/2015 7:03:50 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static INVProductStockCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// Pass the specified field and its value to the stored procedure.
			oDatabaseHelper.AddParameter("@PageSize",pageSize);
			oDatabaseHelper.AddParameter("@SkipPages", skipPages);
			oDatabaseHelper.AddParameter("@OrderByStatement", orderByStatement );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_INVProductStock_SelectAllPaged", ref ExecutionState);
			INVProductStockCollection INVProductStockCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return INVProductStockCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class INVProductStock</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class INVProductStock in the form of an object of class INVProductStockCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/20/2015 7:03:50 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static INVProductStockCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_INVProductStock_SelectByFieldPaged", ref ExecutionState);
			INVProductStockCollection INVProductStockCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return INVProductStockCollection;
			
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
		/// DLGenerator			2/20/2015 7:03:50 PM		Created function
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
			
			Object dr=oDatabaseHelper.ExecuteScalar("gsp_INVProductStock_SelectAllCount");
			int count = Convert.ToInt32(dr);		
			oDatabaseHelper.Dispose();
			return count;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="INVProductStockPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class INVProductStock</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/20/2015 7:03:50 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static INVProductStock SelectOneWithINVProductStockBatchUsingProductStockID(INVProductStockPrimaryKey pk)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			INVProductStock obj=null;
			
			// Pass the values of all key parameters to the stored procedure.
			System.Collections.Specialized.NameValueCollection nvc = pk.GetKeysAndValues();
			foreach (string key in nvc.Keys)
			{
				oDatabaseHelper.AddParameter("@" + key,nvc[key] );
			}
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_INVProductStock_SelectOneWithINVProductStockBatchUsingProductStockID", ref ExecutionState);
			if (dr.Read())
			{
				obj= new INVProductStock();
				PopulateObjectFromReader(obj,dr);
				
				dr.NextResult();
				
				//Get the child records.
				obj.INVProductStockBatchCollectionUsingProductStockID=INVProductStockBatch.PopulateObjectsFromReader(dr);
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
		/// <returns>object of class INVProductStockCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/20/2015 7:03:50 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static INVProductStockCollection SelectAllByForeignKeyInventoryID(INVInventoryPrimaryKey pk)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			INVProductStockCollection obj = null;
			
			// Pass the values of all key parameters to the stored procedure.
			System.Collections.Specialized.NameValueCollection nvc = pk.GetKeysAndValues();
			foreach (string key in nvc.Keys)
			{
				oDatabaseHelper.AddParameter("@" + key,nvc[key] );
			}
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_INVProductStock_SelectAllByForeignKeyInventoryID", ref ExecutionState);
			obj = new INVProductStockCollection();
			obj = INVProductStock.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
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
		/// <returns>object of class INVProductStockCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/20/2015 7:03:50 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static INVProductStockCollection SelectAllByForeignKeyInventoryIDPaged(INVInventoryPrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			INVProductStockCollection obj = null;
			
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_INVProductStock_SelectAllByForeignKeyInventoryIDPaged", ref ExecutionState);
			obj = new INVProductStockCollection();
			obj = INVProductStock.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
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
		/// DLGenerator			2/20/2015 7:03:50 PM				Created function
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
			
			oDatabaseHelper.ExecuteNonQuery("gsp_INVProductStock_DeleteAllByForeignKeyInventoryID", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}



		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="INVStockTypePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class INVProductStockCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/20/2015 7:03:50 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static INVProductStockCollection SelectAllByForeignKeyStockTypeID(INVStockTypePrimaryKey pk)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			INVProductStockCollection obj = null;
			
			// Pass the values of all key parameters to the stored procedure.
			System.Collections.Specialized.NameValueCollection nvc = pk.GetKeysAndValues();
			foreach (string key in nvc.Keys)
			{
				oDatabaseHelper.AddParameter("@" + key,nvc[key] );
			}
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_INVProductStock_SelectAllByForeignKeyStockTypeID", ref ExecutionState);
			obj = new INVProductStockCollection();
			obj = INVProductStock.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
			dr.Close();  
			oDatabaseHelper.Dispose();
			return obj;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="INVStockTypePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number</param>
		///
		/// <returns>object of class INVProductStockCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/20/2015 7:03:50 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static INVProductStockCollection SelectAllByForeignKeyStockTypeIDPaged(INVStockTypePrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			INVProductStockCollection obj = null;
			
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_INVProductStock_SelectAllByForeignKeyStockTypeIDPaged", ref ExecutionState);
			obj = new INVProductStockCollection();
			obj = INVProductStock.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
			dr.Close();  
			oDatabaseHelper.Dispose();
			return obj;
			
		}

		/// <summary>
		/// This method will delete row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="INVStockTypePrimaryKey">Primary Key information based on which data is to be deleted.</param>
		///
		/// <returns>object of boolean type as an indicator for operation success .</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/20/2015 7:03:50 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static bool DeleteAllByForeignKeyStockTypeID(INVStockTypePrimaryKey pk)
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
			
			oDatabaseHelper.ExecuteNonQuery("gsp_INVProductStock_DeleteAllByForeignKeyStockTypeID", ref ExecutionState);
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
		/// DLGenerator			2/20/2015 7:03:50 PM		Created function
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
		/// <param name="obj" type="INVProductStock">Object of INVProductStock to populate</param>
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/20/2015 7:03:50 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static void PopulateObjectFromReader(INVProductStockBase obj,IDataReader rdr) 
		{

			obj.ProductStockID = rdr.GetInt32(rdr.GetOrdinal(INVProductStockFields.ProductStockID));
			obj.ProductID = rdr.GetInt32(rdr.GetOrdinal(INVProductStockFields.ProductID));
			obj.TotalQty = rdr.GetDecimal(rdr.GetOrdinal(INVProductStockFields.TotalQty));
			obj.StockTypeID = rdr.GetInt32(rdr.GetOrdinal(INVProductStockFields.StockTypeID));
			obj.OpeningQty = rdr.GetDecimal(rdr.GetOrdinal(INVProductStockFields.OpeningQty));
			if (!rdr.IsDBNull(rdr.GetOrdinal(INVProductStockFields.OpennigDate)))
			{
				obj.OpennigDate = rdr.GetDateTime(rdr.GetOrdinal(INVProductStockFields.OpennigDate));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(INVProductStockFields.CreateDate)))
			{
				obj.CreateDate = rdr.GetDateTime(rdr.GetOrdinal(INVProductStockFields.CreateDate));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(INVProductStockFields.CreatedBy)))
			{
				obj.CreatedBy = rdr.GetInt32(rdr.GetOrdinal(INVProductStockFields.CreatedBy));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(INVProductStockFields.UpdateDate)))
			{
				obj.UpdateDate = rdr.GetDateTime(rdr.GetOrdinal(INVProductStockFields.UpdateDate));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(INVProductStockFields.UpdatedBy)))
			{
				obj.UpdatedBy = rdr.GetInt32(rdr.GetOrdinal(INVProductStockFields.UpdatedBy));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(INVProductStockFields.InventoryID)))
			{
				obj.InventoryID = rdr.GetInt32(rdr.GetOrdinal(INVProductStockFields.InventoryID));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(INVProductStockFields.IsBlocked)))
			{
				obj.IsBlocked = rdr.GetBoolean(rdr.GetOrdinal(INVProductStockFields.IsBlocked));
			}
			

		}

		/// <summary>
		/// Populates the fields for multiple objects from the columns found in an open reader.
		/// </summary>
		///
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <returns>Object of INVProductStockCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/20/2015 7:03:50 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static INVProductStockCollection PopulateObjectsFromReader(IDataReader rdr) 
		{
			INVProductStockCollection list = new INVProductStockCollection();
			
			while (rdr.Read())
			{
				INVProductStock obj = new INVProductStock();
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
		/// <returns>Object of INVProductStockCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/20/2015 7:03:50 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static INVProductStockCollection PopulateObjectsFromReaderWithCheckingReader(IDataReader rdr, DatabaseHelper oDatabaseHelper) 
		{

			INVProductStockCollection list = new INVProductStockCollection();
			
            if (rdr.Read())
			{
				INVProductStock obj = new INVProductStock();
				PopulateObjectFromReader(obj, rdr);
				list.Add(obj);
				while (rdr.Read())
				{
					obj = new INVProductStock();
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
