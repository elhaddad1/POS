//
// Class	:	INVAdjustStockBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	4/4/2015 12:03:46 AM
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
	public class INVAdjustStockFields
	{
		public const string AdjustStockID             = "AdjustStockID";
		public const string ProductID                 = "ProductID";
		public const string BatchID                   = "BatchID";
		public const string Qty                       = "Qty";
		public const string AdjustReasonID            = "AdjustReasonID";
		public const string CreatedBy                 = "CreatedBy";
		public const string CredateDate               = "CredateDate";
		public const string UpdatedBy                 = "UpdatedBy";
		public const string UpdateDate                = "UpdateDate";
		public const string StockTypeID               = "StockTypeID";
		public const string InventoryID               = "InventoryID";
		public const string ExpiryDate                = "ExpiryDate";
		public const string BatchNumber               = "BatchNumber";
	}
	
	/// <summary>
	/// Data access class for the "INVAdjustStock" table.
	/// </summary>
	[Serializable]
	public class INVAdjustStockBase
	{
		
		#region Class Level Variables
		
		private DatabaseHelper oDatabaseHelper = new DatabaseHelper();

		private int?           	_adjustStockIDNonDefault 	= null;
		private int?           	_productIDNonDefault     	= null;
		private int?           	_batchIDNonDefault       	= null;
		private decimal?       	_qtyNonDefault           	= 0;
		private int?           	_adjustReasonIDNonDefault	= null;
		private int?           	_createdByNonDefault     	= null;
		private DateTime?      	_credateDateNonDefault   	= null;
		private int?           	_updatedByNonDefault     	= null;
		private DateTime?      	_updateDateNonDefault    	= null;
		private int?           	_stockTypeIDNonDefault   	= null;
		private int?           	_inventoryIDNonDefault   	= null;
		private DateTime?      	_expiryDateNonDefault    	= null;
		private string         	_batchNumberNonDefault   	= null;
		
		#endregion
		
		#region Constants
		
		#endregion
		
		#region Constructors / Destructors

		/// <summary>
		/// Class Constructor
		///</summary>
		public INVAdjustStockBase() { }
					
		#endregion
		
		#region Properties

		/// <summary>
		/// Returns the identifier of the persistent object. Don't set it manually!
		/// </summary>
		public int? AdjustStockID
		{
			get 
			{ 
				return _adjustStockIDNonDefault;
			}
			set 
			{
			
				_adjustStockIDNonDefault = value; 
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
		/// This property is mapped to the "BatchID" field.  
		/// </summary>
		public int? BatchID
		{
			get 
			{ 
				return _batchIDNonDefault;
			}
			set 
			{
			
				_batchIDNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "Qty" field.  Mandatory.
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
		/// This property is mapped to the "AdjustReasonID" field.  
		/// </summary>
		public int? AdjustReasonID
		{
			get 
			{ 
				return _adjustReasonIDNonDefault;
			}
			set 
			{
			
				_adjustReasonIDNonDefault = value; 
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
		/// This property is mapped to the "CredateDate" field.  
		/// </summary>
		public DateTime? CredateDate
		{
			get 
			{ 
				return _credateDateNonDefault;
			}
			set 
			{
			
				_credateDateNonDefault = value; 
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
		/// This property is mapped to the "StockTypeID" field.  Mandatory.
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
		/// This property is mapped to the "InventoryID" field.  Mandatory.
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
		/// This property is mapped to the "ExpiryDate" field.  
		/// </summary>
		public DateTime? ExpiryDate
		{
			get 
			{ 
				return _expiryDateNonDefault;
			}
			set 
			{
			
				_expiryDateNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "BatchNumber" field. Length must be between 0 and 2147483647 characters. 
		/// </summary>
		public string BatchNumber
		{
			get 
			{ 
				if(_batchNumberNonDefault==null)return _batchNumberNonDefault;
				else return _batchNumberNonDefault.Trim(); 
			}
			set 
			{
			    if (value != null && value.Length > 2147483647)
					throw new ArgumentException("BatchNumber length must be between 0 and 2147483647 characters.");

				
				if(value ==null)
				{
					_batchNumberNonDefault =null;//null value 
				}
				else
				{		           
					_batchNumberNonDefault = value.Trim(); 
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
		/// DLGenerator			4/4/2015 12:03:46 AM		Created function
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
			  
			// Pass the value of '_batchID' as parameter 'BatchID' of the stored procedure.
			if(_batchIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@BatchID", _batchIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@BatchID", DBNull.Value );
			  
			// Pass the value of '_qty' as parameter 'Qty' of the stored procedure.
			if(_qtyNonDefault!=null)
			  oDatabaseHelper.AddParameter("@Qty", _qtyNonDefault);
			else
			  oDatabaseHelper.AddParameter("@Qty", DBNull.Value );
			  
			// Pass the value of '_adjustReasonID' as parameter 'AdjustReasonID' of the stored procedure.
			if(_adjustReasonIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@AdjustReasonID", _adjustReasonIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@AdjustReasonID", DBNull.Value );
			  
			// Pass the value of '_createdBy' as parameter 'CreatedBy' of the stored procedure.
			if(_createdByNonDefault!=null)
			  oDatabaseHelper.AddParameter("@CreatedBy", _createdByNonDefault);
			else
			  oDatabaseHelper.AddParameter("@CreatedBy", DBNull.Value );
			  
			// Pass the value of '_credateDate' as parameter 'CredateDate' of the stored procedure.
			if(_credateDateNonDefault!=null)
			  oDatabaseHelper.AddParameter("@CredateDate", _credateDateNonDefault);
			else
			  oDatabaseHelper.AddParameter("@CredateDate", DBNull.Value );
			  
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
			  
			// Pass the value of '_stockTypeID' as parameter 'StockTypeID' of the stored procedure.
			if(_stockTypeIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@StockTypeID", _stockTypeIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@StockTypeID", DBNull.Value );
			  
			// Pass the value of '_inventoryID' as parameter 'InventoryID' of the stored procedure.
			if(_inventoryIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@InventoryID", _inventoryIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@InventoryID", DBNull.Value );
			  
			// Pass the value of '_expiryDate' as parameter 'ExpiryDate' of the stored procedure.
			if(_expiryDateNonDefault!=null)
			  oDatabaseHelper.AddParameter("@ExpiryDate", _expiryDateNonDefault);
			else
			  oDatabaseHelper.AddParameter("@ExpiryDate", DBNull.Value );
			  
			// Pass the value of '_batchNumber' as parameter 'BatchNumber' of the stored procedure.
			if(_batchNumberNonDefault!=null)
			  oDatabaseHelper.AddParameter("@BatchNumber", _batchNumberNonDefault);
			else
			  oDatabaseHelper.AddParameter("@BatchNumber", DBNull.Value );
			  
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			if(!getBackValues )
			{
				oDatabaseHelper.ExecuteScalar("gsp_INVAdjustStock_Insert_WithDefaultValues", ref ExecutionState);
			}
			else
			{
				IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_INVAdjustStock_Insert_WithDefaultValues_AndReturn", ref ExecutionState);
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
		/// DLGenerator			4/4/2015 12:03:46 AM		Created function
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
			// Pass the value of '_batchID' as parameter 'BatchID' of the stored procedure.
			if(_batchIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@BatchID", _batchIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@BatchID", DBNull.Value );
			// Pass the value of '_qty' as parameter 'Qty' of the stored procedure.
			if(_qtyNonDefault!=null)
			  oDatabaseHelper.AddParameter("@Qty", _qtyNonDefault);
			else
			  oDatabaseHelper.AddParameter("@Qty", DBNull.Value );
			// Pass the value of '_adjustReasonID' as parameter 'AdjustReasonID' of the stored procedure.
			if(_adjustReasonIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@AdjustReasonID", _adjustReasonIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@AdjustReasonID", DBNull.Value );
			// Pass the value of '_createdBy' as parameter 'CreatedBy' of the stored procedure.
			if(_createdByNonDefault!=null)
			  oDatabaseHelper.AddParameter("@CreatedBy", _createdByNonDefault);
			else
			  oDatabaseHelper.AddParameter("@CreatedBy", DBNull.Value );
			// Pass the value of '_credateDate' as parameter 'CredateDate' of the stored procedure.
			if(_credateDateNonDefault!=null)
			  oDatabaseHelper.AddParameter("@CredateDate", _credateDateNonDefault);
			else
			  oDatabaseHelper.AddParameter("@CredateDate", DBNull.Value );
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
			// Pass the value of '_stockTypeID' as parameter 'StockTypeID' of the stored procedure.
			if(_stockTypeIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@StockTypeID", _stockTypeIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@StockTypeID", DBNull.Value );
			// Pass the value of '_inventoryID' as parameter 'InventoryID' of the stored procedure.
			if(_inventoryIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@InventoryID", _inventoryIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@InventoryID", DBNull.Value );
			// Pass the value of '_expiryDate' as parameter 'ExpiryDate' of the stored procedure.
			if(_expiryDateNonDefault!=null)
			  oDatabaseHelper.AddParameter("@ExpiryDate", _expiryDateNonDefault);
			else
			  oDatabaseHelper.AddParameter("@ExpiryDate", DBNull.Value );
			// Pass the value of '_batchNumber' as parameter 'BatchNumber' of the stored procedure.
			if(_batchNumberNonDefault!=null)
			  oDatabaseHelper.AddParameter("@BatchNumber", _batchNumberNonDefault);
			else
			  oDatabaseHelper.AddParameter("@BatchNumber", DBNull.Value );
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_INVAdjustStock_Insert", ref ExecutionState);
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
		/// DLGenerator			4/4/2015 12:03:46 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Update() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_adjustStockID' as parameter 'AdjustStockID' of the stored procedure.
			oDatabaseHelper.AddParameter("@AdjustStockID", _adjustStockIDNonDefault );
			
			// Pass the value of '_productID' as parameter 'ProductID' of the stored procedure.
			oDatabaseHelper.AddParameter("@ProductID", _productIDNonDefault );
			
			// Pass the value of '_batchID' as parameter 'BatchID' of the stored procedure.
			oDatabaseHelper.AddParameter("@BatchID", _batchIDNonDefault );
			
			// Pass the value of '_qty' as parameter 'Qty' of the stored procedure.
			oDatabaseHelper.AddParameter("@Qty", _qtyNonDefault );
			
			// Pass the value of '_adjustReasonID' as parameter 'AdjustReasonID' of the stored procedure.
			oDatabaseHelper.AddParameter("@AdjustReasonID", _adjustReasonIDNonDefault );
			
			// Pass the value of '_createdBy' as parameter 'CreatedBy' of the stored procedure.
			oDatabaseHelper.AddParameter("@CreatedBy", _createdByNonDefault );
			
			// Pass the value of '_credateDate' as parameter 'CredateDate' of the stored procedure.
			oDatabaseHelper.AddParameter("@CredateDate", _credateDateNonDefault );
			
			// Pass the value of '_updatedBy' as parameter 'UpdatedBy' of the stored procedure.
			oDatabaseHelper.AddParameter("@UpdatedBy", _updatedByNonDefault );
			
			// Pass the value of '_updateDate' as parameter 'UpdateDate' of the stored procedure.
			oDatabaseHelper.AddParameter("@UpdateDate", _updateDateNonDefault );
			
			// Pass the value of '_stockTypeID' as parameter 'StockTypeID' of the stored procedure.
			oDatabaseHelper.AddParameter("@StockTypeID", _stockTypeIDNonDefault );
			
			// Pass the value of '_inventoryID' as parameter 'InventoryID' of the stored procedure.
			oDatabaseHelper.AddParameter("@InventoryID", _inventoryIDNonDefault );
			
			// Pass the value of '_expiryDate' as parameter 'ExpiryDate' of the stored procedure.
			oDatabaseHelper.AddParameter("@ExpiryDate", _expiryDateNonDefault );
			
			// Pass the value of '_batchNumber' as parameter 'BatchNumber' of the stored procedure.
			oDatabaseHelper.AddParameter("@BatchNumber", _batchNumberNonDefault );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_INVAdjustStock_Update", ref ExecutionState);
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
		/// DLGenerator			4/4/2015 12:03:46 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Delete() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_adjustStockID' as parameter 'AdjustStockID' of the stored procedure.
			if(_adjustStockIDNonDefault!=null)
				oDatabaseHelper.AddParameter("@AdjustStockID", _adjustStockIDNonDefault );
			else
				oDatabaseHelper.AddParameter("@AdjustStockID", DBNull.Value );
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_INVAdjustStock_Delete", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will Delete one row from the database using the primary key information
		/// </summary>
		///
		/// <param name="pk" type="INVAdjustStockPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>True if succeeded</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			4/4/2015 12:03:46 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static bool Delete(INVAdjustStockPrimaryKey pk) 
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
   
			oDatabaseHelper.ExecuteScalar("gsp_INVAdjustStock_Delete", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="INVAdjustStockFields">Field of the class INVAdjustStock</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		///
		/// <returns>True if succeeded</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			4/4/2015 12:03:46 AM		Created function
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
			
			oDatabaseHelper.ExecuteScalar("gsp_INVAdjustStock_DeleteByField", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="INVAdjustStockPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class INVAdjustStock</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			4/4/2015 12:03:46 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static INVAdjustStock SelectOne(INVAdjustStockPrimaryKey pk)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_INVAdjustStock_SelectbyPrimaryKey", ref ExecutionState);
			if (dr.Read())
			{
				INVAdjustStock obj=new INVAdjustStock();	
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
		/// <returns>list of objects of class INVAdjustStock in the form of object of INVAdjustStockCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			4/4/2015 12:03:46 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static INVAdjustStockCollection SelectAll()
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_INVAdjustStock_SelectAll", ref ExecutionState);
			INVAdjustStockCollection INVAdjustStockCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return INVAdjustStockCollection;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class INVAdjustStock</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class INVAdjustStock in the form of an object of class INVAdjustStockCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			4/4/2015 12:03:46 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static INVAdjustStockCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_INVAdjustStock_SelectByField", ref ExecutionState);
			INVAdjustStockCollection INVAdjustStockCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return INVAdjustStockCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number</param>
		///
		/// <returns>list of objects of class INVAdjustStock in the form of object of INVAdjustStockCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			4/4/2015 12:03:46 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static INVAdjustStockCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// Pass the specified field and its value to the stored procedure.
			oDatabaseHelper.AddParameter("@PageSize",pageSize);
			oDatabaseHelper.AddParameter("@SkipPages", skipPages);
			oDatabaseHelper.AddParameter("@OrderByStatement", orderByStatement );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_INVAdjustStock_SelectAllPaged", ref ExecutionState);
			INVAdjustStockCollection INVAdjustStockCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return INVAdjustStockCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class INVAdjustStock</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class INVAdjustStock in the form of an object of class INVAdjustStockCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			4/4/2015 12:03:46 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static INVAdjustStockCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_INVAdjustStock_SelectByFieldPaged", ref ExecutionState);
			INVAdjustStockCollection INVAdjustStockCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return INVAdjustStockCollection;
			
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
		/// DLGenerator			4/4/2015 12:03:46 AM		Created function
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
			
			Object dr=oDatabaseHelper.ExecuteScalar("gsp_INVAdjustStock_SelectAllCount");
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
		/// DLGenerator			4/4/2015 12:03:46 AM		Created function
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
		/// <param name="obj" type="INVAdjustStock">Object of INVAdjustStock to populate</param>
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			4/4/2015 12:03:46 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static void PopulateObjectFromReader(INVAdjustStockBase obj,IDataReader rdr) 
		{

			obj.AdjustStockID = rdr.GetInt32(rdr.GetOrdinal(INVAdjustStockFields.AdjustStockID));
			obj.ProductID = rdr.GetInt32(rdr.GetOrdinal(INVAdjustStockFields.ProductID));
			if (!rdr.IsDBNull(rdr.GetOrdinal(INVAdjustStockFields.BatchID)))
			{
				obj.BatchID = rdr.GetInt32(rdr.GetOrdinal(INVAdjustStockFields.BatchID));
			}
			
			obj.Qty = rdr.GetDecimal(rdr.GetOrdinal(INVAdjustStockFields.Qty));
			if (!rdr.IsDBNull(rdr.GetOrdinal(INVAdjustStockFields.AdjustReasonID)))
			{
				obj.AdjustReasonID = rdr.GetInt32(rdr.GetOrdinal(INVAdjustStockFields.AdjustReasonID));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(INVAdjustStockFields.CreatedBy)))
			{
				obj.CreatedBy = rdr.GetInt32(rdr.GetOrdinal(INVAdjustStockFields.CreatedBy));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(INVAdjustStockFields.CredateDate)))
			{
				obj.CredateDate = rdr.GetDateTime(rdr.GetOrdinal(INVAdjustStockFields.CredateDate));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(INVAdjustStockFields.UpdatedBy)))
			{
				obj.UpdatedBy = rdr.GetInt32(rdr.GetOrdinal(INVAdjustStockFields.UpdatedBy));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(INVAdjustStockFields.UpdateDate)))
			{
				obj.UpdateDate = rdr.GetDateTime(rdr.GetOrdinal(INVAdjustStockFields.UpdateDate));
			}
			
			obj.StockTypeID = rdr.GetInt32(rdr.GetOrdinal(INVAdjustStockFields.StockTypeID));
			obj.InventoryID = rdr.GetInt32(rdr.GetOrdinal(INVAdjustStockFields.InventoryID));
			if (!rdr.IsDBNull(rdr.GetOrdinal(INVAdjustStockFields.ExpiryDate)))
			{
				obj.ExpiryDate = rdr.GetDateTime(rdr.GetOrdinal(INVAdjustStockFields.ExpiryDate));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(INVAdjustStockFields.BatchNumber)))
			{
				obj.BatchNumber = rdr.GetString(rdr.GetOrdinal(INVAdjustStockFields.BatchNumber));
			}
			

		}

		/// <summary>
		/// Populates the fields for multiple objects from the columns found in an open reader.
		/// </summary>
		///
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <returns>Object of INVAdjustStockCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			4/4/2015 12:03:46 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static INVAdjustStockCollection PopulateObjectsFromReader(IDataReader rdr) 
		{
			INVAdjustStockCollection list = new INVAdjustStockCollection();
			
			while (rdr.Read())
			{
				INVAdjustStock obj = new INVAdjustStock();
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
		/// <returns>Object of INVAdjustStockCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			4/4/2015 12:03:46 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static INVAdjustStockCollection PopulateObjectsFromReaderWithCheckingReader(IDataReader rdr, DatabaseHelper oDatabaseHelper) 
		{

			INVAdjustStockCollection list = new INVAdjustStockCollection();
			
            if (rdr.Read())
			{
				INVAdjustStock obj = new INVAdjustStock();
				PopulateObjectFromReader(obj, rdr);
				list.Add(obj);
				while (rdr.Read())
				{
					obj = new INVAdjustStock();
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
