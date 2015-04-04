//
// Class	:	BDSupplierAccountBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	4/4/2015 12:03:47 AM
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
	public class BDSupplierAccountFields
	{
		public const string SupplierAccountId         = "SupplierAccountId";
		public const string PurcaseInvoiceID          = "PurcaseInvoiceID";
		public const string PurchaseDate              = "PurchaseDate";
		public const string SupplierID                = "SupplierID";
		public const string InvoiceNumber             = "InvoiceNumber";
		public const string TotalPrice                = "TotalPrice";
		public const string PaidAmount                = "PaidAmount";
		public const string IsVoid                    = "IsVoid";
		public const string RemainingAmount           = "RemainingAmount";
		public const string CreateDate                = "CreateDate";
		public const string CreatedBy                 = "CreatedBy";
		public const string updateDate                = "updateDate";
		public const string UpdatedBy                 = "UpdatedBy";
		public const string IsDeleted                 = "IsDeleted";
		public const string DeleteDate                = "DeleteDate";
		public const string DeletedBy                 = "DeletedBy";
		public const string InvoiceType               = "InvoiceType";
	}
	
	/// <summary>
	/// Data access class for the "BDSupplierAccounts" table.
	/// </summary>
	[Serializable]
	public class BDSupplierAccountBase
	{
		
		#region Class Level Variables
		
		private DatabaseHelper oDatabaseHelper = new DatabaseHelper();

		private int?           	_supplierAccountIdNonDefault	= null;
		private int?           	_purcaseInvoiceIDNonDefault	= null;
		private DateTime?      	_purchaseDateNonDefault  	= null;
		private int?           	_supplierIDNonDefault    	= null;
		private string         	_invoiceNumberNonDefault 	= null;
		private decimal?       	_totalPriceNonDefault    	= 0;
		private decimal?       	_paidAmountNonDefault    	= 0;
		private bool?          	_isVoidNonDefault        	= false;
		private decimal?       	_remainingAmountNonDefault	= 0;
		private DateTime?      	_createDateNonDefault    	= null;
		private int?           	_createdByNonDefault     	= null;
		private DateTime?      	_updateDateNonDefault    	= null;
		private int?           	_updatedByNonDefault     	= null;
		private bool?          	_isDeletedNonDefault     	= false;
		private DateTime?      	_deleteDateNonDefault    	= null;
		private int?           	_deletedByNonDefault     	= null;
		private int?           	_invoiceTypeNonDefault   	= null;
		
		#endregion
		
		#region Constants
		
		#endregion
		
		#region Constructors / Destructors

		/// <summary>
		/// Class Constructor
		///</summary>
		public BDSupplierAccountBase() { }
					
		#endregion
		
		#region Properties

		/// <summary>
		/// Returns the identifier of the persistent object. Don't set it manually!
		/// </summary>
		public int? SupplierAccountId
		{
			get 
			{ 
				return _supplierAccountIdNonDefault;
			}
			set 
			{
			
				_supplierAccountIdNonDefault = value; 
			}
		}

		/// <summary>
		/// The foreign key connected with another persistent object.
		/// </summary>
		public int? PurcaseInvoiceID
		{
			get 
			{ 
				return _purcaseInvoiceIDNonDefault;
			}
			set 
			{
			
				_purcaseInvoiceIDNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "PurchaseDate" field.  Mandatory.
		/// </summary>
		public DateTime? PurchaseDate
		{
			get 
			{ 
				return _purchaseDateNonDefault;
			}
			set 
			{
			
				_purchaseDateNonDefault = value; 
			}
		}

		/// <summary>
		/// The foreign key connected with another persistent object.
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
		/// This property is mapped to the "InvoiceNumber" field. Length must be between 0 and 50 characters. 
		/// </summary>
		public string InvoiceNumber
		{
			get 
			{ 
				if(_invoiceNumberNonDefault==null)return _invoiceNumberNonDefault;
				else return _invoiceNumberNonDefault.Trim(); 
			}
			set 
			{
			    if (value != null && value.Length > 50)
					throw new ArgumentException("InvoiceNumber length must be between 0 and 50 characters.");

				
				if(value ==null)
				{
					_invoiceNumberNonDefault =null;//null value 
				}
				else
				{		           
					_invoiceNumberNonDefault = value.Trim(); 
				}
			}
		}

		/// <summary>
		/// This property is mapped to the "TotalPrice" field.  Mandatory.
		/// </summary>
		public decimal? TotalPrice
		{
			get 
			{ 
				return _totalPriceNonDefault;
			}
			set 
			{
			
				_totalPriceNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "PaidAmount" field.  Mandatory.
		/// </summary>
		public decimal? PaidAmount
		{
			get 
			{ 
				return _paidAmountNonDefault;
			}
			set 
			{
			
				_paidAmountNonDefault = value; 
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
		/// This property is mapped to the "RemainingAmount" field.  Mandatory.
		/// </summary>
		public decimal? RemainingAmount
		{
			get 
			{ 
				return _remainingAmountNonDefault;
			}
			set 
			{
			
				_remainingAmountNonDefault = value; 
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
		/// The foreign key connected with another persistent object.
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
		/// This property is mapped to the "updateDate" field.  
		/// </summary>
		public DateTime? updateDate
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
		/// This property is mapped to the "InvoiceType" field.  
		/// </summary>
		public int? InvoiceType
		{
			get 
			{ 
				return _invoiceTypeNonDefault;
			}
			set 
			{
			
				_invoiceTypeNonDefault = value; 
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
			
			// Pass the value of '_purcaseInvoiceID' as parameter 'PurcaseInvoiceID' of the stored procedure.
			if(_purcaseInvoiceIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@PurcaseInvoiceID", _purcaseInvoiceIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@PurcaseInvoiceID", DBNull.Value );
			  
			// Pass the value of '_purchaseDate' as parameter 'PurchaseDate' of the stored procedure.
			if(_purchaseDateNonDefault!=null)
			  oDatabaseHelper.AddParameter("@PurchaseDate", _purchaseDateNonDefault);
			else
			  oDatabaseHelper.AddParameter("@PurchaseDate", DBNull.Value );
			  
			// Pass the value of '_supplierID' as parameter 'SupplierID' of the stored procedure.
			if(_supplierIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@SupplierID", _supplierIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@SupplierID", DBNull.Value );
			  
			// Pass the value of '_invoiceNumber' as parameter 'InvoiceNumber' of the stored procedure.
			if(_invoiceNumberNonDefault!=null)
			  oDatabaseHelper.AddParameter("@InvoiceNumber", _invoiceNumberNonDefault);
			else
			  oDatabaseHelper.AddParameter("@InvoiceNumber", DBNull.Value );
			  
			// Pass the value of '_totalPrice' as parameter 'TotalPrice' of the stored procedure.
			if(_totalPriceNonDefault!=null)
			  oDatabaseHelper.AddParameter("@TotalPrice", _totalPriceNonDefault);
			else
			  oDatabaseHelper.AddParameter("@TotalPrice", DBNull.Value );
			  
			// Pass the value of '_paidAmount' as parameter 'PaidAmount' of the stored procedure.
			if(_paidAmountNonDefault!=null)
			  oDatabaseHelper.AddParameter("@PaidAmount", _paidAmountNonDefault);
			else
			  oDatabaseHelper.AddParameter("@PaidAmount", DBNull.Value );
			  
			// Pass the value of '_isVoid' as parameter 'IsVoid' of the stored procedure.
			if(_isVoidNonDefault!=null)
			  oDatabaseHelper.AddParameter("@IsVoid", _isVoidNonDefault);
			else
			  oDatabaseHelper.AddParameter("@IsVoid", DBNull.Value );
			  
			// Pass the value of '_remainingAmount' as parameter 'RemainingAmount' of the stored procedure.
			if(_remainingAmountNonDefault!=null)
			  oDatabaseHelper.AddParameter("@RemainingAmount", _remainingAmountNonDefault);
			else
			  oDatabaseHelper.AddParameter("@RemainingAmount", DBNull.Value );
			  
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
			  
			// Pass the value of '_updateDate' as parameter 'updateDate' of the stored procedure.
			if(_updateDateNonDefault!=null)
			  oDatabaseHelper.AddParameter("@updateDate", _updateDateNonDefault);
			else
			  oDatabaseHelper.AddParameter("@updateDate", DBNull.Value );
			  
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
			  
			// Pass the value of '_deleteDate' as parameter 'DeleteDate' of the stored procedure.
			if(_deleteDateNonDefault!=null)
			  oDatabaseHelper.AddParameter("@DeleteDate", _deleteDateNonDefault);
			else
			  oDatabaseHelper.AddParameter("@DeleteDate", DBNull.Value );
			  
			// Pass the value of '_deletedBy' as parameter 'DeletedBy' of the stored procedure.
			if(_deletedByNonDefault!=null)
			  oDatabaseHelper.AddParameter("@DeletedBy", _deletedByNonDefault);
			else
			  oDatabaseHelper.AddParameter("@DeletedBy", DBNull.Value );
			  
			// Pass the value of '_invoiceType' as parameter 'InvoiceType' of the stored procedure.
			if(_invoiceTypeNonDefault!=null)
			  oDatabaseHelper.AddParameter("@InvoiceType", _invoiceTypeNonDefault);
			else
			  oDatabaseHelper.AddParameter("@InvoiceType", DBNull.Value );
			  
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			if(!getBackValues )
			{
				oDatabaseHelper.ExecuteScalar("gsp_BDSupplierAccounts_Insert_WithDefaultValues", ref ExecutionState);
			}
			else
			{
				IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDSupplierAccounts_Insert_WithDefaultValues_AndReturn", ref ExecutionState);
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
			
			// Pass the value of '_purcaseInvoiceID' as parameter 'PurcaseInvoiceID' of the stored procedure.
			if(_purcaseInvoiceIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@PurcaseInvoiceID", _purcaseInvoiceIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@PurcaseInvoiceID", DBNull.Value );
			// Pass the value of '_purchaseDate' as parameter 'PurchaseDate' of the stored procedure.
			if(_purchaseDateNonDefault!=null)
			  oDatabaseHelper.AddParameter("@PurchaseDate", _purchaseDateNonDefault);
			else
			  oDatabaseHelper.AddParameter("@PurchaseDate", DBNull.Value );
			// Pass the value of '_supplierID' as parameter 'SupplierID' of the stored procedure.
			if(_supplierIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@SupplierID", _supplierIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@SupplierID", DBNull.Value );
			// Pass the value of '_invoiceNumber' as parameter 'InvoiceNumber' of the stored procedure.
			if(_invoiceNumberNonDefault!=null)
			  oDatabaseHelper.AddParameter("@InvoiceNumber", _invoiceNumberNonDefault);
			else
			  oDatabaseHelper.AddParameter("@InvoiceNumber", DBNull.Value );
			// Pass the value of '_totalPrice' as parameter 'TotalPrice' of the stored procedure.
			if(_totalPriceNonDefault!=null)
			  oDatabaseHelper.AddParameter("@TotalPrice", _totalPriceNonDefault);
			else
			  oDatabaseHelper.AddParameter("@TotalPrice", DBNull.Value );
			// Pass the value of '_paidAmount' as parameter 'PaidAmount' of the stored procedure.
			if(_paidAmountNonDefault!=null)
			  oDatabaseHelper.AddParameter("@PaidAmount", _paidAmountNonDefault);
			else
			  oDatabaseHelper.AddParameter("@PaidAmount", DBNull.Value );
			// Pass the value of '_isVoid' as parameter 'IsVoid' of the stored procedure.
			if(_isVoidNonDefault!=null)
			  oDatabaseHelper.AddParameter("@IsVoid", _isVoidNonDefault);
			else
			  oDatabaseHelper.AddParameter("@IsVoid", DBNull.Value );
			// Pass the value of '_remainingAmount' as parameter 'RemainingAmount' of the stored procedure.
			if(_remainingAmountNonDefault!=null)
			  oDatabaseHelper.AddParameter("@RemainingAmount", _remainingAmountNonDefault);
			else
			  oDatabaseHelper.AddParameter("@RemainingAmount", DBNull.Value );
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
			// Pass the value of '_updateDate' as parameter 'updateDate' of the stored procedure.
			if(_updateDateNonDefault!=null)
			  oDatabaseHelper.AddParameter("@updateDate", _updateDateNonDefault);
			else
			  oDatabaseHelper.AddParameter("@updateDate", DBNull.Value );
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
			// Pass the value of '_deleteDate' as parameter 'DeleteDate' of the stored procedure.
			if(_deleteDateNonDefault!=null)
			  oDatabaseHelper.AddParameter("@DeleteDate", _deleteDateNonDefault);
			else
			  oDatabaseHelper.AddParameter("@DeleteDate", DBNull.Value );
			// Pass the value of '_deletedBy' as parameter 'DeletedBy' of the stored procedure.
			if(_deletedByNonDefault!=null)
			  oDatabaseHelper.AddParameter("@DeletedBy", _deletedByNonDefault);
			else
			  oDatabaseHelper.AddParameter("@DeletedBy", DBNull.Value );
			// Pass the value of '_invoiceType' as parameter 'InvoiceType' of the stored procedure.
			if(_invoiceTypeNonDefault!=null)
			  oDatabaseHelper.AddParameter("@InvoiceType", _invoiceTypeNonDefault);
			else
			  oDatabaseHelper.AddParameter("@InvoiceType", DBNull.Value );
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_BDSupplierAccounts_Insert", ref ExecutionState);
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
			
			// Pass the value of '_supplierAccountId' as parameter 'SupplierAccountId' of the stored procedure.
			oDatabaseHelper.AddParameter("@SupplierAccountId", _supplierAccountIdNonDefault );
			
			// Pass the value of '_purcaseInvoiceID' as parameter 'PurcaseInvoiceID' of the stored procedure.
			oDatabaseHelper.AddParameter("@PurcaseInvoiceID", _purcaseInvoiceIDNonDefault );
			
			// Pass the value of '_purchaseDate' as parameter 'PurchaseDate' of the stored procedure.
			oDatabaseHelper.AddParameter("@PurchaseDate", _purchaseDateNonDefault );
			
			// Pass the value of '_supplierID' as parameter 'SupplierID' of the stored procedure.
			oDatabaseHelper.AddParameter("@SupplierID", _supplierIDNonDefault );
			
			// Pass the value of '_invoiceNumber' as parameter 'InvoiceNumber' of the stored procedure.
			oDatabaseHelper.AddParameter("@InvoiceNumber", _invoiceNumberNonDefault );
			
			// Pass the value of '_totalPrice' as parameter 'TotalPrice' of the stored procedure.
			oDatabaseHelper.AddParameter("@TotalPrice", _totalPriceNonDefault );
			
			// Pass the value of '_paidAmount' as parameter 'PaidAmount' of the stored procedure.
			oDatabaseHelper.AddParameter("@PaidAmount", _paidAmountNonDefault );
			
			// Pass the value of '_isVoid' as parameter 'IsVoid' of the stored procedure.
			oDatabaseHelper.AddParameter("@IsVoid", _isVoidNonDefault );
			
			// Pass the value of '_remainingAmount' as parameter 'RemainingAmount' of the stored procedure.
			oDatabaseHelper.AddParameter("@RemainingAmount", _remainingAmountNonDefault );
			
			// Pass the value of '_createDate' as parameter 'CreateDate' of the stored procedure.
			oDatabaseHelper.AddParameter("@CreateDate", _createDateNonDefault );
			
			// Pass the value of '_createdBy' as parameter 'CreatedBy' of the stored procedure.
			oDatabaseHelper.AddParameter("@CreatedBy", _createdByNonDefault );
			
			// Pass the value of '_updateDate' as parameter 'updateDate' of the stored procedure.
			oDatabaseHelper.AddParameter("@updateDate", _updateDateNonDefault );
			
			// Pass the value of '_updatedBy' as parameter 'UpdatedBy' of the stored procedure.
			oDatabaseHelper.AddParameter("@UpdatedBy", _updatedByNonDefault );
			
			// Pass the value of '_isDeleted' as parameter 'IsDeleted' of the stored procedure.
			oDatabaseHelper.AddParameter("@IsDeleted", _isDeletedNonDefault );
			
			// Pass the value of '_deleteDate' as parameter 'DeleteDate' of the stored procedure.
			oDatabaseHelper.AddParameter("@DeleteDate", _deleteDateNonDefault );
			
			// Pass the value of '_deletedBy' as parameter 'DeletedBy' of the stored procedure.
			oDatabaseHelper.AddParameter("@DeletedBy", _deletedByNonDefault );
			
			// Pass the value of '_invoiceType' as parameter 'InvoiceType' of the stored procedure.
			oDatabaseHelper.AddParameter("@InvoiceType", _invoiceTypeNonDefault );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_BDSupplierAccounts_Update", ref ExecutionState);
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
			
			// Pass the value of '_supplierAccountId' as parameter 'SupplierAccountId' of the stored procedure.
			if(_supplierAccountIdNonDefault!=null)
				oDatabaseHelper.AddParameter("@SupplierAccountId", _supplierAccountIdNonDefault );
			else
				oDatabaseHelper.AddParameter("@SupplierAccountId", DBNull.Value );
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_BDSupplierAccounts_Delete", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will Delete one row from the database using the primary key information
		/// </summary>
		///
		/// <param name="pk" type="BDSupplierAccountPrimaryKey">Primary Key information based on which data is to be fetched.</param>
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
		public static bool Delete(BDSupplierAccountPrimaryKey pk) 
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
   
			oDatabaseHelper.ExecuteScalar("gsp_BDSupplierAccounts_Delete", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="BDSupplierAccountFields">Field of the class BDSupplierAccount</param>
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
			
			oDatabaseHelper.ExecuteScalar("gsp_BDSupplierAccounts_DeleteByField", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="BDSupplierAccountPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class BDSupplierAccount</returns>
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
		public static BDSupplierAccount SelectOne(BDSupplierAccountPrimaryKey pk)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDSupplierAccounts_SelectbyPrimaryKey", ref ExecutionState);
			if (dr.Read())
			{
				BDSupplierAccount obj=new BDSupplierAccount();	
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
		/// <returns>list of objects of class BDSupplierAccount in the form of object of BDSupplierAccountCollection </returns>
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
		public static BDSupplierAccountCollection SelectAll()
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDSupplierAccounts_SelectAll", ref ExecutionState);
			BDSupplierAccountCollection BDSupplierAccountCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return BDSupplierAccountCollection;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class BDSupplierAccount</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class BDSupplierAccount in the form of an object of class BDSupplierAccountCollection</returns>
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
		public static BDSupplierAccountCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDSupplierAccounts_SelectByField", ref ExecutionState);
			BDSupplierAccountCollection BDSupplierAccountCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return BDSupplierAccountCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number</param>
		///
		/// <returns>list of objects of class BDSupplierAccount in the form of object of BDSupplierAccountCollection </returns>
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
		public static BDSupplierAccountCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// Pass the specified field and its value to the stored procedure.
			oDatabaseHelper.AddParameter("@PageSize",pageSize);
			oDatabaseHelper.AddParameter("@SkipPages", skipPages);
			oDatabaseHelper.AddParameter("@OrderByStatement", orderByStatement );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDSupplierAccounts_SelectAllPaged", ref ExecutionState);
			BDSupplierAccountCollection BDSupplierAccountCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return BDSupplierAccountCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class BDSupplierAccount</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class BDSupplierAccount in the form of an object of class BDSupplierAccountCollection</returns>
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
		public static BDSupplierAccountCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDSupplierAccounts_SelectByFieldPaged", ref ExecutionState);
			BDSupplierAccountCollection BDSupplierAccountCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return BDSupplierAccountCollection;
			
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
			
			Object dr=oDatabaseHelper.ExecuteScalar("gsp_BDSupplierAccounts_SelectAllCount");
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
		/// <returns>object of class BDSupplierAccountCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			4/4/2015 12:03:46 AM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static BDSupplierAccountCollection SelectAllByForeignKeyCreatedBy(ADUserPrimaryKey pk)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			BDSupplierAccountCollection obj = null;
			
			// Pass the values of all key parameters to the stored procedure.
			System.Collections.Specialized.NameValueCollection nvc = pk.GetKeysAndValues();
			foreach (string key in nvc.Keys)
			{
				oDatabaseHelper.AddParameter("@" + key,nvc[key] );
			}
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDSupplierAccounts_SelectAllByForeignKeyCreatedBy", ref ExecutionState);
			obj = new BDSupplierAccountCollection();
			obj = BDSupplierAccount.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
			dr.Close();  
			oDatabaseHelper.Dispose();
			return obj;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="ADUserPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number</param>
		///
		/// <returns>object of class BDSupplierAccountCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			4/4/2015 12:03:46 AM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static BDSupplierAccountCollection SelectAllByForeignKeyCreatedByPaged(ADUserPrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			BDSupplierAccountCollection obj = null;
			
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDSupplierAccounts_SelectAllByForeignKeyCreatedByPaged", ref ExecutionState);
			obj = new BDSupplierAccountCollection();
			obj = BDSupplierAccount.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
			dr.Close();  
			oDatabaseHelper.Dispose();
			return obj;
			
		}

		/// <summary>
		/// This method will delete row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="ADUserPrimaryKey">Primary Key information based on which data is to be deleted.</param>
		///
		/// <returns>object of boolean type as an indicator for operation success .</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			4/4/2015 12:03:46 AM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static bool DeleteAllByForeignKeyCreatedBy(ADUserPrimaryKey pk)
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
			
			oDatabaseHelper.ExecuteNonQuery("gsp_BDSupplierAccounts_DeleteAllByForeignKeyCreatedBy", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}



		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="BDSupplierPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class BDSupplierAccountCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			4/4/2015 12:03:46 AM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static BDSupplierAccountCollection SelectAllByForeignKeySupplierID(BDSupplierPrimaryKey pk)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			BDSupplierAccountCollection obj = null;
			
			// Pass the values of all key parameters to the stored procedure.
			System.Collections.Specialized.NameValueCollection nvc = pk.GetKeysAndValues();
			foreach (string key in nvc.Keys)
			{
				oDatabaseHelper.AddParameter("@" + key,nvc[key] );
			}
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDSupplierAccounts_SelectAllByForeignKeySupplierID", ref ExecutionState);
			obj = new BDSupplierAccountCollection();
			obj = BDSupplierAccount.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
			dr.Close();  
			oDatabaseHelper.Dispose();
			return obj;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="BDSupplierPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number</param>
		///
		/// <returns>object of class BDSupplierAccountCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			4/4/2015 12:03:46 AM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static BDSupplierAccountCollection SelectAllByForeignKeySupplierIDPaged(BDSupplierPrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			BDSupplierAccountCollection obj = null;
			
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDSupplierAccounts_SelectAllByForeignKeySupplierIDPaged", ref ExecutionState);
			obj = new BDSupplierAccountCollection();
			obj = BDSupplierAccount.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
			dr.Close();  
			oDatabaseHelper.Dispose();
			return obj;
			
		}

		/// <summary>
		/// This method will delete row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="BDSupplierPrimaryKey">Primary Key information based on which data is to be deleted.</param>
		///
		/// <returns>object of boolean type as an indicator for operation success .</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			4/4/2015 12:03:46 AM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static bool DeleteAllByForeignKeySupplierID(BDSupplierPrimaryKey pk)
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
			
			oDatabaseHelper.ExecuteNonQuery("gsp_BDSupplierAccounts_DeleteAllByForeignKeySupplierID", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}



		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="PURPurchaseHeaderPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class BDSupplierAccountCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			4/4/2015 12:03:46 AM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static BDSupplierAccountCollection SelectAllByForeignKeyPurcaseInvoiceID(PURPurchaseHeaderPrimaryKey pk)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			BDSupplierAccountCollection obj = null;
			
			// Pass the values of all key parameters to the stored procedure.
			System.Collections.Specialized.NameValueCollection nvc = pk.GetKeysAndValues();
			foreach (string key in nvc.Keys)
			{
				oDatabaseHelper.AddParameter("@" + key,nvc[key] );
			}
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDSupplierAccounts_SelectAllByForeignKeyPurcaseInvoiceID", ref ExecutionState);
			obj = new BDSupplierAccountCollection();
			obj = BDSupplierAccount.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
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
		/// <returns>object of class BDSupplierAccountCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			4/4/2015 12:03:46 AM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static BDSupplierAccountCollection SelectAllByForeignKeyPurcaseInvoiceIDPaged(PURPurchaseHeaderPrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			BDSupplierAccountCollection obj = null;
			
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDSupplierAccounts_SelectAllByForeignKeyPurcaseInvoiceIDPaged", ref ExecutionState);
			obj = new BDSupplierAccountCollection();
			obj = BDSupplierAccount.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
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
		/// DLGenerator			4/4/2015 12:03:46 AM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static bool DeleteAllByForeignKeyPurcaseInvoiceID(PURPurchaseHeaderPrimaryKey pk)
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
			
			oDatabaseHelper.ExecuteNonQuery("gsp_BDSupplierAccounts_DeleteAllByForeignKeyPurcaseInvoiceID", ref ExecutionState);
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
		/// <param name="obj" type="BDSupplierAccounts">Object of BDSupplierAccounts to populate</param>
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
		internal static void PopulateObjectFromReader(BDSupplierAccountBase obj,IDataReader rdr) 
		{

			obj.SupplierAccountId = rdr.GetInt32(rdr.GetOrdinal(BDSupplierAccountFields.SupplierAccountId));
			obj.PurcaseInvoiceID = rdr.GetInt32(rdr.GetOrdinal(BDSupplierAccountFields.PurcaseInvoiceID));
			obj.PurchaseDate = rdr.GetDateTime(rdr.GetOrdinal(BDSupplierAccountFields.PurchaseDate));
			obj.SupplierID = rdr.GetInt32(rdr.GetOrdinal(BDSupplierAccountFields.SupplierID));
			if (!rdr.IsDBNull(rdr.GetOrdinal(BDSupplierAccountFields.InvoiceNumber)))
			{
				obj.InvoiceNumber = rdr.GetString(rdr.GetOrdinal(BDSupplierAccountFields.InvoiceNumber));
			}
			
			obj.TotalPrice = rdr.GetDecimal(rdr.GetOrdinal(BDSupplierAccountFields.TotalPrice));
			obj.PaidAmount = rdr.GetDecimal(rdr.GetOrdinal(BDSupplierAccountFields.PaidAmount));
			obj.IsVoid = rdr.GetBoolean(rdr.GetOrdinal(BDSupplierAccountFields.IsVoid));
			obj.RemainingAmount = rdr.GetDecimal(rdr.GetOrdinal(BDSupplierAccountFields.RemainingAmount));
			if (!rdr.IsDBNull(rdr.GetOrdinal(BDSupplierAccountFields.CreateDate)))
			{
				obj.CreateDate = rdr.GetDateTime(rdr.GetOrdinal(BDSupplierAccountFields.CreateDate));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(BDSupplierAccountFields.CreatedBy)))
			{
				obj.CreatedBy = rdr.GetInt32(rdr.GetOrdinal(BDSupplierAccountFields.CreatedBy));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(BDSupplierAccountFields.updateDate)))
			{
				obj.updateDate = rdr.GetDateTime(rdr.GetOrdinal(BDSupplierAccountFields.updateDate));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(BDSupplierAccountFields.UpdatedBy)))
			{
				obj.UpdatedBy = rdr.GetInt32(rdr.GetOrdinal(BDSupplierAccountFields.UpdatedBy));
			}
			
			obj.IsDeleted = rdr.GetBoolean(rdr.GetOrdinal(BDSupplierAccountFields.IsDeleted));
			if (!rdr.IsDBNull(rdr.GetOrdinal(BDSupplierAccountFields.DeleteDate)))
			{
				obj.DeleteDate = rdr.GetDateTime(rdr.GetOrdinal(BDSupplierAccountFields.DeleteDate));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(BDSupplierAccountFields.DeletedBy)))
			{
				obj.DeletedBy = rdr.GetInt32(rdr.GetOrdinal(BDSupplierAccountFields.DeletedBy));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(BDSupplierAccountFields.InvoiceType)))
			{
				obj.InvoiceType = rdr.GetInt32(rdr.GetOrdinal(BDSupplierAccountFields.InvoiceType));
			}
			

		}

		/// <summary>
		/// Populates the fields for multiple objects from the columns found in an open reader.
		/// </summary>
		///
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <returns>Object of BDSupplierAccountCollection</returns>
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
		internal static BDSupplierAccountCollection PopulateObjectsFromReader(IDataReader rdr) 
		{
			BDSupplierAccountCollection list = new BDSupplierAccountCollection();
			
			while (rdr.Read())
			{
				BDSupplierAccount obj = new BDSupplierAccount();
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
		/// <returns>Object of BDSupplierAccountCollection</returns>
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
		internal static BDSupplierAccountCollection PopulateObjectsFromReaderWithCheckingReader(IDataReader rdr, DatabaseHelper oDatabaseHelper) 
		{

			BDSupplierAccountCollection list = new BDSupplierAccountCollection();
			
            if (rdr.Read())
			{
				BDSupplierAccount obj = new BDSupplierAccount();
				PopulateObjectFromReader(obj, rdr);
				list.Add(obj);
				while (rdr.Read())
				{
					obj = new BDSupplierAccount();
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
