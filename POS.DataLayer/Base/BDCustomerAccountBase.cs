//
// Class	:	BDCustomerAccountBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	3/7/2015 2:36:56 PM
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
	public class BDCustomerAccountFields
	{
		public const string CustomerAccountNumber     = "CustomerAccountNumber";
		public const string CustomerID                = "CustomerID";
		public const string SalesInvoiceId            = "SalesInvoiceId";
		public const string SalesDate                 = "SalesDate";
		public const string InvoiceNumber             = "InvoiceNumber";
		public const string TotalPrice                = "TotalPrice";
		public const string PaidAmount                = "PaidAmount";
		public const string RemainingAmount           = "RemainingAmount";
		public const string IsVoid                    = "IsVoid";
		public const string CreatedBy                 = "CreatedBy";
		public const string CreateDate                = "CreateDate";
		public const string UpdatedBy                 = "UpdatedBy";
		public const string UpdateDate                = "UpdateDate";
		public const string IsDeleted                 = "IsDeleted";
		public const string DeletedBy                 = "DeletedBy";
		public const string DeletedDate               = "DeletedDate";
	}
	
	/// <summary>
	/// Data access class for the "BDCustomerAccounts" table.
	/// </summary>
	[Serializable]
	public class BDCustomerAccountBase
	{
		
		#region Class Level Variables
		
		private DatabaseHelper oDatabaseHelper = new DatabaseHelper();

		private int?           	_customerAccountNumberNonDefault	= null;
		private int?           	_customerIDNonDefault    	= null;
		private int?           	_salesInvoiceIdNonDefault	= null;
		private DateTime?      	_salesDateNonDefault     	= null;
		private string         	_invoiceNumberNonDefault 	= null;
		private decimal?       	_totalPriceNonDefault    	= 0;
		private decimal?       	_paidAmountNonDefault    	= 0;
		private decimal?       	_remainingAmountNonDefault	= 0;
		private bool?          	_isVoidNonDefault        	= false;
		private int?           	_createdByNonDefault     	= null;
		private DateTime?      	_createDateNonDefault    	= null;
		private int?           	_updatedByNonDefault     	= null;
		private DateTime?      	_updateDateNonDefault    	= null;
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
		public BDCustomerAccountBase() { }
					
		#endregion
		
		#region Properties

		/// <summary>
		/// Returns the identifier of the persistent object. Don't set it manually!
		/// </summary>
		public int? CustomerAccountNumber
		{
			get 
			{ 
				return _customerAccountNumberNonDefault;
			}
			set 
			{
			
				_customerAccountNumberNonDefault = value; 
			}
		}

		/// <summary>
		/// The foreign key connected with another persistent object.
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
		/// The foreign key connected with another persistent object.
		/// </summary>
		public int? SalesInvoiceId
		{
			get 
			{ 
				return _salesInvoiceIdNonDefault;
			}
			set 
			{
			
				_salesInvoiceIdNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "SalesDate" field.  Mandatory.
		/// </summary>
		public DateTime? SalesDate
		{
			get 
			{ 
				return _salesDateNonDefault;
			}
			set 
			{
			
				_salesDateNonDefault = value; 
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
		/// This property is mapped to the "CreateDate" field.  Mandatory.
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
		/// DLGenerator			3/7/2015 2:36:56 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool InsertWithDefaultValues(bool getBackValues) 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_customerID' as parameter 'CustomerID' of the stored procedure.
			if(_customerIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@CustomerID", _customerIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@CustomerID", DBNull.Value );
			  
			// Pass the value of '_salesInvoiceId' as parameter 'SalesInvoiceId' of the stored procedure.
			if(_salesInvoiceIdNonDefault!=null)
			  oDatabaseHelper.AddParameter("@SalesInvoiceId", _salesInvoiceIdNonDefault);
			else
			  oDatabaseHelper.AddParameter("@SalesInvoiceId", DBNull.Value );
			  
			// Pass the value of '_salesDate' as parameter 'SalesDate' of the stored procedure.
			if(_salesDateNonDefault!=null)
			  oDatabaseHelper.AddParameter("@SalesDate", _salesDateNonDefault);
			else
			  oDatabaseHelper.AddParameter("@SalesDate", DBNull.Value );
			  
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
			  
			// Pass the value of '_remainingAmount' as parameter 'RemainingAmount' of the stored procedure.
			if(_remainingAmountNonDefault!=null)
			  oDatabaseHelper.AddParameter("@RemainingAmount", _remainingAmountNonDefault);
			else
			  oDatabaseHelper.AddParameter("@RemainingAmount", DBNull.Value );
			  
			// Pass the value of '_isVoid' as parameter 'IsVoid' of the stored procedure.
			if(_isVoidNonDefault!=null)
			  oDatabaseHelper.AddParameter("@IsVoid", _isVoidNonDefault);
			else
			  oDatabaseHelper.AddParameter("@IsVoid", DBNull.Value );
			  
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
			  
			// Pass the value of '_deletedDate' as parameter 'DeletedDate' of the stored procedure.
			if(_deletedDateNonDefault!=null)
			  oDatabaseHelper.AddParameter("@DeletedDate", _deletedDateNonDefault);
			else
			  oDatabaseHelper.AddParameter("@DeletedDate", DBNull.Value );
			  
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			if(!getBackValues )
			{
				oDatabaseHelper.ExecuteScalar("gsp_BDCustomerAccounts_Insert_WithDefaultValues", ref ExecutionState);
			}
			else
			{
				IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDCustomerAccounts_Insert_WithDefaultValues_AndReturn", ref ExecutionState);
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
		/// DLGenerator			3/7/2015 2:36:56 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Insert() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_customerID' as parameter 'CustomerID' of the stored procedure.
			if(_customerIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@CustomerID", _customerIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@CustomerID", DBNull.Value );
			// Pass the value of '_salesInvoiceId' as parameter 'SalesInvoiceId' of the stored procedure.
			if(_salesInvoiceIdNonDefault!=null)
			  oDatabaseHelper.AddParameter("@SalesInvoiceId", _salesInvoiceIdNonDefault);
			else
			  oDatabaseHelper.AddParameter("@SalesInvoiceId", DBNull.Value );
			// Pass the value of '_salesDate' as parameter 'SalesDate' of the stored procedure.
			if(_salesDateNonDefault!=null)
			  oDatabaseHelper.AddParameter("@SalesDate", _salesDateNonDefault);
			else
			  oDatabaseHelper.AddParameter("@SalesDate", DBNull.Value );
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
			// Pass the value of '_remainingAmount' as parameter 'RemainingAmount' of the stored procedure.
			if(_remainingAmountNonDefault!=null)
			  oDatabaseHelper.AddParameter("@RemainingAmount", _remainingAmountNonDefault);
			else
			  oDatabaseHelper.AddParameter("@RemainingAmount", DBNull.Value );
			// Pass the value of '_isVoid' as parameter 'IsVoid' of the stored procedure.
			if(_isVoidNonDefault!=null)
			  oDatabaseHelper.AddParameter("@IsVoid", _isVoidNonDefault);
			else
			  oDatabaseHelper.AddParameter("@IsVoid", DBNull.Value );
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
			// Pass the value of '_deletedDate' as parameter 'DeletedDate' of the stored procedure.
			if(_deletedDateNonDefault!=null)
			  oDatabaseHelper.AddParameter("@DeletedDate", _deletedDateNonDefault);
			else
			  oDatabaseHelper.AddParameter("@DeletedDate", DBNull.Value );
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_BDCustomerAccounts_Insert", ref ExecutionState);
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
		/// DLGenerator			3/7/2015 2:36:56 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Update() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_customerAccountNumber' as parameter 'CustomerAccountNumber' of the stored procedure.
			oDatabaseHelper.AddParameter("@CustomerAccountNumber", _customerAccountNumberNonDefault );
			
			// Pass the value of '_customerID' as parameter 'CustomerID' of the stored procedure.
			oDatabaseHelper.AddParameter("@CustomerID", _customerIDNonDefault );
			
			// Pass the value of '_salesInvoiceId' as parameter 'SalesInvoiceId' of the stored procedure.
			oDatabaseHelper.AddParameter("@SalesInvoiceId", _salesInvoiceIdNonDefault );
			
			// Pass the value of '_salesDate' as parameter 'SalesDate' of the stored procedure.
			oDatabaseHelper.AddParameter("@SalesDate", _salesDateNonDefault );
			
			// Pass the value of '_invoiceNumber' as parameter 'InvoiceNumber' of the stored procedure.
			oDatabaseHelper.AddParameter("@InvoiceNumber", _invoiceNumberNonDefault );
			
			// Pass the value of '_totalPrice' as parameter 'TotalPrice' of the stored procedure.
			oDatabaseHelper.AddParameter("@TotalPrice", _totalPriceNonDefault );
			
			// Pass the value of '_paidAmount' as parameter 'PaidAmount' of the stored procedure.
			oDatabaseHelper.AddParameter("@PaidAmount", _paidAmountNonDefault );
			
			// Pass the value of '_remainingAmount' as parameter 'RemainingAmount' of the stored procedure.
			oDatabaseHelper.AddParameter("@RemainingAmount", _remainingAmountNonDefault );
			
			// Pass the value of '_isVoid' as parameter 'IsVoid' of the stored procedure.
			oDatabaseHelper.AddParameter("@IsVoid", _isVoidNonDefault );
			
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
			
			// Pass the value of '_deletedDate' as parameter 'DeletedDate' of the stored procedure.
			oDatabaseHelper.AddParameter("@DeletedDate", _deletedDateNonDefault );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_BDCustomerAccounts_Update", ref ExecutionState);
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
		/// DLGenerator			3/7/2015 2:36:56 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Delete() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_customerAccountNumber' as parameter 'CustomerAccountNumber' of the stored procedure.
			if(_customerAccountNumberNonDefault!=null)
				oDatabaseHelper.AddParameter("@CustomerAccountNumber", _customerAccountNumberNonDefault );
			else
				oDatabaseHelper.AddParameter("@CustomerAccountNumber", DBNull.Value );
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_BDCustomerAccounts_Delete", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will Delete one row from the database using the primary key information
		/// </summary>
		///
		/// <param name="pk" type="BDCustomerAccountPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>True if succeeded</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/7/2015 2:36:56 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static bool Delete(BDCustomerAccountPrimaryKey pk) 
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
   
			oDatabaseHelper.ExecuteScalar("gsp_BDCustomerAccounts_Delete", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="BDCustomerAccountFields">Field of the class BDCustomerAccount</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		///
		/// <returns>True if succeeded</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/7/2015 2:36:56 PM		Created function
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
			
			oDatabaseHelper.ExecuteScalar("gsp_BDCustomerAccounts_DeleteByField", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="BDCustomerAccountPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class BDCustomerAccount</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/7/2015 2:36:56 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static BDCustomerAccount SelectOne(BDCustomerAccountPrimaryKey pk)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDCustomerAccounts_SelectbyPrimaryKey", ref ExecutionState);
			if (dr.Read())
			{
				BDCustomerAccount obj=new BDCustomerAccount();	
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
		/// <returns>list of objects of class BDCustomerAccount in the form of object of BDCustomerAccountCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/7/2015 2:36:56 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static BDCustomerAccountCollection SelectAll()
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDCustomerAccounts_SelectAll", ref ExecutionState);
			BDCustomerAccountCollection BDCustomerAccountCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return BDCustomerAccountCollection;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class BDCustomerAccount</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class BDCustomerAccount in the form of an object of class BDCustomerAccountCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/7/2015 2:36:56 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static BDCustomerAccountCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDCustomerAccounts_SelectByField", ref ExecutionState);
			BDCustomerAccountCollection BDCustomerAccountCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return BDCustomerAccountCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number</param>
		///
		/// <returns>list of objects of class BDCustomerAccount in the form of object of BDCustomerAccountCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/7/2015 2:36:56 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static BDCustomerAccountCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// Pass the specified field and its value to the stored procedure.
			oDatabaseHelper.AddParameter("@PageSize",pageSize);
			oDatabaseHelper.AddParameter("@SkipPages", skipPages);
			oDatabaseHelper.AddParameter("@OrderByStatement", orderByStatement );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDCustomerAccounts_SelectAllPaged", ref ExecutionState);
			BDCustomerAccountCollection BDCustomerAccountCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return BDCustomerAccountCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class BDCustomerAccount</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class BDCustomerAccount in the form of an object of class BDCustomerAccountCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/7/2015 2:36:56 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static BDCustomerAccountCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDCustomerAccounts_SelectByFieldPaged", ref ExecutionState);
			BDCustomerAccountCollection BDCustomerAccountCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return BDCustomerAccountCollection;
			
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
		/// DLGenerator			3/7/2015 2:36:56 PM		Created function
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
			
			Object dr=oDatabaseHelper.ExecuteScalar("gsp_BDCustomerAccounts_SelectAllCount");
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
		/// <returns>object of class BDCustomerAccountCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/7/2015 2:36:56 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static BDCustomerAccountCollection SelectAllByForeignKeyCreatedBy(ADUserPrimaryKey pk)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			BDCustomerAccountCollection obj = null;
			
			// Pass the values of all key parameters to the stored procedure.
			System.Collections.Specialized.NameValueCollection nvc = pk.GetKeysAndValues();
			foreach (string key in nvc.Keys)
			{
				oDatabaseHelper.AddParameter("@" + key,nvc[key] );
			}
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDCustomerAccounts_SelectAllByForeignKeyCreatedBy", ref ExecutionState);
			obj = new BDCustomerAccountCollection();
			obj = BDCustomerAccount.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
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
		/// <returns>object of class BDCustomerAccountCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/7/2015 2:36:56 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static BDCustomerAccountCollection SelectAllByForeignKeyCreatedByPaged(ADUserPrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			BDCustomerAccountCollection obj = null;
			
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDCustomerAccounts_SelectAllByForeignKeyCreatedByPaged", ref ExecutionState);
			obj = new BDCustomerAccountCollection();
			obj = BDCustomerAccount.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
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
		/// DLGenerator			3/7/2015 2:36:56 PM				Created function
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
			
			oDatabaseHelper.ExecuteNonQuery("gsp_BDCustomerAccounts_DeleteAllByForeignKeyCreatedBy", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}



		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="BDCustomerPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class BDCustomerAccountCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/7/2015 2:36:56 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static BDCustomerAccountCollection SelectAllByForeignKeyCustomerID(BDCustomerPrimaryKey pk)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			BDCustomerAccountCollection obj = null;
			
			// Pass the values of all key parameters to the stored procedure.
			System.Collections.Specialized.NameValueCollection nvc = pk.GetKeysAndValues();
			foreach (string key in nvc.Keys)
			{
				oDatabaseHelper.AddParameter("@" + key,nvc[key] );
			}
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDCustomerAccounts_SelectAllByForeignKeyCustomerID", ref ExecutionState);
			obj = new BDCustomerAccountCollection();
			obj = BDCustomerAccount.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
			dr.Close();  
			oDatabaseHelper.Dispose();
			return obj;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="BDCustomerPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number</param>
		///
		/// <returns>object of class BDCustomerAccountCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/7/2015 2:36:56 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static BDCustomerAccountCollection SelectAllByForeignKeyCustomerIDPaged(BDCustomerPrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			BDCustomerAccountCollection obj = null;
			
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDCustomerAccounts_SelectAllByForeignKeyCustomerIDPaged", ref ExecutionState);
			obj = new BDCustomerAccountCollection();
			obj = BDCustomerAccount.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
			dr.Close();  
			oDatabaseHelper.Dispose();
			return obj;
			
		}

		/// <summary>
		/// This method will delete row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="BDCustomerPrimaryKey">Primary Key information based on which data is to be deleted.</param>
		///
		/// <returns>object of boolean type as an indicator for operation success .</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/7/2015 2:36:56 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static bool DeleteAllByForeignKeyCustomerID(BDCustomerPrimaryKey pk)
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
			
			oDatabaseHelper.ExecuteNonQuery("gsp_BDCustomerAccounts_DeleteAllByForeignKeyCustomerID", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}



		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="SALSalesHeaderPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class BDCustomerAccountCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/7/2015 2:36:56 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static BDCustomerAccountCollection SelectAllByForeignKeySalesInvoiceId(SALSalesHeaderPrimaryKey pk)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			BDCustomerAccountCollection obj = null;
			
			// Pass the values of all key parameters to the stored procedure.
			System.Collections.Specialized.NameValueCollection nvc = pk.GetKeysAndValues();
			foreach (string key in nvc.Keys)
			{
				oDatabaseHelper.AddParameter("@" + key,nvc[key] );
			}
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDCustomerAccounts_SelectAllByForeignKeySalesInvoiceId", ref ExecutionState);
			obj = new BDCustomerAccountCollection();
			obj = BDCustomerAccount.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
			dr.Close();  
			oDatabaseHelper.Dispose();
			return obj;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="SALSalesHeaderPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number</param>
		///
		/// <returns>object of class BDCustomerAccountCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/7/2015 2:36:56 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static BDCustomerAccountCollection SelectAllByForeignKeySalesInvoiceIdPaged(SALSalesHeaderPrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			BDCustomerAccountCollection obj = null;
			
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDCustomerAccounts_SelectAllByForeignKeySalesInvoiceIdPaged", ref ExecutionState);
			obj = new BDCustomerAccountCollection();
			obj = BDCustomerAccount.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
			dr.Close();  
			oDatabaseHelper.Dispose();
			return obj;
			
		}

		/// <summary>
		/// This method will delete row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="SALSalesHeaderPrimaryKey">Primary Key information based on which data is to be deleted.</param>
		///
		/// <returns>object of boolean type as an indicator for operation success .</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/7/2015 2:36:56 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static bool DeleteAllByForeignKeySalesInvoiceId(SALSalesHeaderPrimaryKey pk)
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
			
			oDatabaseHelper.ExecuteNonQuery("gsp_BDCustomerAccounts_DeleteAllByForeignKeySalesInvoiceId", ref ExecutionState);
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
		/// DLGenerator			3/7/2015 2:36:56 PM		Created function
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
		/// <param name="obj" type="BDCustomerAccounts">Object of BDCustomerAccounts to populate</param>
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/7/2015 2:36:56 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static void PopulateObjectFromReader(BDCustomerAccountBase obj,IDataReader rdr) 
		{

			obj.CustomerAccountNumber = rdr.GetInt32(rdr.GetOrdinal(BDCustomerAccountFields.CustomerAccountNumber));
			obj.CustomerID = rdr.GetInt32(rdr.GetOrdinal(BDCustomerAccountFields.CustomerID));
			obj.SalesInvoiceId = rdr.GetInt32(rdr.GetOrdinal(BDCustomerAccountFields.SalesInvoiceId));
			obj.SalesDate = rdr.GetDateTime(rdr.GetOrdinal(BDCustomerAccountFields.SalesDate));
			if (!rdr.IsDBNull(rdr.GetOrdinal(BDCustomerAccountFields.InvoiceNumber)))
			{
				obj.InvoiceNumber = rdr.GetString(rdr.GetOrdinal(BDCustomerAccountFields.InvoiceNumber));
			}
			
			obj.TotalPrice = rdr.GetDecimal(rdr.GetOrdinal(BDCustomerAccountFields.TotalPrice));
			obj.PaidAmount = rdr.GetDecimal(rdr.GetOrdinal(BDCustomerAccountFields.PaidAmount));
			obj.RemainingAmount = rdr.GetDecimal(rdr.GetOrdinal(BDCustomerAccountFields.RemainingAmount));
			obj.IsVoid = rdr.GetBoolean(rdr.GetOrdinal(BDCustomerAccountFields.IsVoid));
			if (!rdr.IsDBNull(rdr.GetOrdinal(BDCustomerAccountFields.CreatedBy)))
			{
				obj.CreatedBy = rdr.GetInt32(rdr.GetOrdinal(BDCustomerAccountFields.CreatedBy));
			}
			
			obj.CreateDate = rdr.GetDateTime(rdr.GetOrdinal(BDCustomerAccountFields.CreateDate));
			if (!rdr.IsDBNull(rdr.GetOrdinal(BDCustomerAccountFields.UpdatedBy)))
			{
				obj.UpdatedBy = rdr.GetInt32(rdr.GetOrdinal(BDCustomerAccountFields.UpdatedBy));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(BDCustomerAccountFields.UpdateDate)))
			{
				obj.UpdateDate = rdr.GetDateTime(rdr.GetOrdinal(BDCustomerAccountFields.UpdateDate));
			}
			
			obj.IsDeleted = rdr.GetBoolean(rdr.GetOrdinal(BDCustomerAccountFields.IsDeleted));
			if (!rdr.IsDBNull(rdr.GetOrdinal(BDCustomerAccountFields.DeletedBy)))
			{
				obj.DeletedBy = rdr.GetInt32(rdr.GetOrdinal(BDCustomerAccountFields.DeletedBy));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(BDCustomerAccountFields.DeletedDate)))
			{
				obj.DeletedDate = rdr.GetDateTime(rdr.GetOrdinal(BDCustomerAccountFields.DeletedDate));
			}
			

		}

		/// <summary>
		/// Populates the fields for multiple objects from the columns found in an open reader.
		/// </summary>
		///
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <returns>Object of BDCustomerAccountCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/7/2015 2:36:56 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static BDCustomerAccountCollection PopulateObjectsFromReader(IDataReader rdr) 
		{
			BDCustomerAccountCollection list = new BDCustomerAccountCollection();
			
			while (rdr.Read())
			{
				BDCustomerAccount obj = new BDCustomerAccount();
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
		/// <returns>Object of BDCustomerAccountCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/7/2015 2:36:56 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static BDCustomerAccountCollection PopulateObjectsFromReaderWithCheckingReader(IDataReader rdr, DatabaseHelper oDatabaseHelper) 
		{

			BDCustomerAccountCollection list = new BDCustomerAccountCollection();
			
            if (rdr.Read())
			{
				BDCustomerAccount obj = new BDCustomerAccount();
				PopulateObjectFromReader(obj, rdr);
				list.Add(obj);
				while (rdr.Read())
				{
					obj = new BDCustomerAccount();
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
