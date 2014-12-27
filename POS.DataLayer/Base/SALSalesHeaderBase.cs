//
// Class	:	SALSalesHeaderBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:56:13 PM
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
	public class SALSalesHeaderFields
	{
		public const string SalesHeaderID             = "SalesHeaderID";
		public const string SalesDate                 = "SalesDate";
		public const string CustomerID                = "CustomerID";
		public const string InvoiceNumber             = "InvoiceNumber";
		public const string InvoiceDate               = "InvoiceDate";
		public const string SellerID                  = "SellerID";
		public const string PaymentTypeID             = "PaymentTypeID";
		public const string TotalPrice                = "TotalPrice";
		public const string PaidAmount                = "PaidAmount";
		public const string RemainingAmount           = "RemainingAmount";
		public const string LastDayToPay              = "LastDayToPay";
		public const string TotalDiscountAmount       = "TotalDiscountAmount";
		public const string TotalDiscountRatio        = "TotalDiscountRatio";
		public const string IsClosed                  = "IsClosed";
		public const string IsVoid                    = "IsVoid";
		public const string IsPrinted                 = "IsPrinted";
		public const string ServicePrice              = "ServicePrice";
		public const string TaxTypeID                 = "TaxTypeID";
		public const string RefuseReasonID            = "RefuseReasonID";
		public const string CreatedBy                 = "CreatedBy";
		public const string CreateDate                = "CreateDate";
		public const string UpdatedBy                 = "UpdatedBy";
		public const string UpdateDate                = "UpdateDate";
		public const string IsDeleted                 = "IsDeleted";
		public const string DeletedBy                 = "DeletedBy";
		public const string DeletDate                 = "DeletDate";
	}
	
	/// <summary>
	/// Data access class for the "SALSalesHeader" table.
	/// </summary>
	[Serializable]
	public class SALSalesHeaderBase
	{
		
		#region Class Level Variables
		
		private DatabaseHelper oDatabaseHelper = new DatabaseHelper();

		private int?           	_salesHeaderIDNonDefault 	= null;
		private DateTime?      	_salesDateNonDefault     	= null;
		private int?           	_customerIDNonDefault    	= null;
		private string         	_invoiceNumberNonDefault 	= null;
		private DateTime?      	_invoiceDateNonDefault   	= null;
		private int?           	_sellerIDNonDefault      	= null;
		private int?           	_paymentTypeIDNonDefault 	= null;
		private decimal?       	_totalPriceNonDefault    	= 0;
		private decimal?       	_paidAmountNonDefault    	= 0;
		private decimal?       	_remainingAmountNonDefault	= 0;
		private DateTime?      	_lastDayToPayNonDefault  	= null;
		private decimal?       	_totalDiscountAmountNonDefault	= 0;
		private double?        	_totalDiscountRatioNonDefault	= 0;
		private bool?          	_isClosedNonDefault      	= false;
		private bool?          	_isVoidNonDefault        	= false;
		private bool?          	_isPrintedNonDefault     	= false;
		private decimal?       	_servicePriceNonDefault  	= 0;
		private int?           	_taxTypeIDNonDefault     	= null;
		private int?           	_refuseReasonIDNonDefault	= null;
		private int?           	_createdByNonDefault     	= null;
		private DateTime?      	_createDateNonDefault    	= null;
		private int?           	_updatedByNonDefault     	= null;
		private DateTime?      	_updateDateNonDefault    	= null;
		private bool?          	_isDeletedNonDefault     	= false;
		private int?           	_deletedByNonDefault     	= null;
		private DateTime?      	_deletDateNonDefault     	= null;
		
		#endregion
		
		#region Constants
		
		#endregion
		
		#region Constructors / Destructors

		/// <summary>
		/// Class Constructor
		///</summary>
		public SALSalesHeaderBase() { }
					
		#endregion
		
		#region Properties

		/// <summary>
		/// Returns the identifier of the persistent object. Don't set it manually!
		/// </summary>
		public int? SalesHeaderID
		{
			get 
			{ 
				return _salesHeaderIDNonDefault;
			}
			set 
			{
			
				_salesHeaderIDNonDefault = value; 
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
		/// This property is mapped to the "InvoiceDate" field.  
		/// </summary>
		public DateTime? InvoiceDate
		{
			get 
			{ 
				return _invoiceDateNonDefault;
			}
			set 
			{
			
				_invoiceDateNonDefault = value; 
			}
		}

		/// <summary>
		/// The foreign key connected with another persistent object.
		/// </summary>
		public int? SellerID
		{
			get 
			{ 
				return _sellerIDNonDefault;
			}
			set 
			{
			
				_sellerIDNonDefault = value; 
			}
		}

		/// <summary>
		/// The foreign key connected with another persistent object.
		/// </summary>
		public int? PaymentTypeID
		{
			get 
			{ 
				return _paymentTypeIDNonDefault;
			}
			set 
			{
			
				_paymentTypeIDNonDefault = value; 
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
		/// This property is mapped to the "LastDayToPay" field.  
		/// </summary>
		public DateTime? LastDayToPay
		{
			get 
			{ 
				return _lastDayToPayNonDefault;
			}
			set 
			{
			
				_lastDayToPayNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "TotalDiscountAmount" field.  Mandatory.
		/// </summary>
		public decimal? TotalDiscountAmount
		{
			get 
			{ 
				return _totalDiscountAmountNonDefault;
			}
			set 
			{
			
				_totalDiscountAmountNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "TotalDiscountRatio" field.  Mandatory.
		/// </summary>
		public double? TotalDiscountRatio
		{
			get 
			{ 
				return _totalDiscountRatioNonDefault;
			}
			set 
			{
			
				_totalDiscountRatioNonDefault = value; 
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
		/// This property is mapped to the "IsPrinted" field.  Mandatory.
		/// </summary>
		public bool? IsPrinted
		{
			get 
			{ 
				return _isPrintedNonDefault;
			}
			set 
			{
			
				_isPrintedNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "ServicePrice" field.  Mandatory.
		/// </summary>
		public decimal? ServicePrice
		{
			get 
			{ 
				return _servicePriceNonDefault;
			}
			set 
			{
			
				_servicePriceNonDefault = value; 
			}
		}

		/// <summary>
		/// The foreign key connected with another persistent object.
		/// </summary>
		public int? TaxTypeID
		{
			get 
			{ 
				return _taxTypeIDNonDefault;
			}
			set 
			{
			
				_taxTypeIDNonDefault = value; 
			}
		}

		/// <summary>
		/// The foreign key connected with another persistent object.
		/// </summary>
		public int? RefuseReasonID
		{
			get 
			{ 
				return _refuseReasonIDNonDefault;
			}
			set 
			{
			
				_refuseReasonIDNonDefault = value; 
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
		/// This property is mapped to the "DeletDate" field.  
		/// </summary>
		public DateTime? DeletDate
		{
			get 
			{ 
				return _deletDateNonDefault;
			}
			set 
			{
			
				_deletDateNonDefault = value; 
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
		/// DLGenerator			12/27/2014 6:56:13 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool InsertWithDefaultValues(bool getBackValues) 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_salesDate' as parameter 'SalesDate' of the stored procedure.
			if(_salesDateNonDefault!=null)
			  oDatabaseHelper.AddParameter("@SalesDate", _salesDateNonDefault);
			else
			  oDatabaseHelper.AddParameter("@SalesDate", DBNull.Value );
			  
			// Pass the value of '_customerID' as parameter 'CustomerID' of the stored procedure.
			if(_customerIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@CustomerID", _customerIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@CustomerID", DBNull.Value );
			  
			// Pass the value of '_invoiceNumber' as parameter 'InvoiceNumber' of the stored procedure.
			if(_invoiceNumberNonDefault!=null)
			  oDatabaseHelper.AddParameter("@InvoiceNumber", _invoiceNumberNonDefault);
			else
			  oDatabaseHelper.AddParameter("@InvoiceNumber", DBNull.Value );
			  
			// Pass the value of '_invoiceDate' as parameter 'InvoiceDate' of the stored procedure.
			if(_invoiceDateNonDefault!=null)
			  oDatabaseHelper.AddParameter("@InvoiceDate", _invoiceDateNonDefault);
			else
			  oDatabaseHelper.AddParameter("@InvoiceDate", DBNull.Value );
			  
			// Pass the value of '_sellerID' as parameter 'SellerID' of the stored procedure.
			if(_sellerIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@SellerID", _sellerIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@SellerID", DBNull.Value );
			  
			// Pass the value of '_paymentTypeID' as parameter 'PaymentTypeID' of the stored procedure.
			if(_paymentTypeIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@PaymentTypeID", _paymentTypeIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@PaymentTypeID", DBNull.Value );
			  
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
			  
			// Pass the value of '_lastDayToPay' as parameter 'LastDayToPay' of the stored procedure.
			if(_lastDayToPayNonDefault!=null)
			  oDatabaseHelper.AddParameter("@LastDayToPay", _lastDayToPayNonDefault);
			else
			  oDatabaseHelper.AddParameter("@LastDayToPay", DBNull.Value );
			  
			// Pass the value of '_totalDiscountAmount' as parameter 'TotalDiscountAmount' of the stored procedure.
			if(_totalDiscountAmountNonDefault!=null)
			  oDatabaseHelper.AddParameter("@TotalDiscountAmount", _totalDiscountAmountNonDefault);
			else
			  oDatabaseHelper.AddParameter("@TotalDiscountAmount", DBNull.Value );
			  
			// Pass the value of '_totalDiscountRatio' as parameter 'TotalDiscountRatio' of the stored procedure.
			if(_totalDiscountRatioNonDefault!=null)
			  oDatabaseHelper.AddParameter("@TotalDiscountRatio", _totalDiscountRatioNonDefault);
			else
			  oDatabaseHelper.AddParameter("@TotalDiscountRatio", DBNull.Value );
			  
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
			  
			// Pass the value of '_isPrinted' as parameter 'IsPrinted' of the stored procedure.
			if(_isPrintedNonDefault!=null)
			  oDatabaseHelper.AddParameter("@IsPrinted", _isPrintedNonDefault);
			else
			  oDatabaseHelper.AddParameter("@IsPrinted", DBNull.Value );
			  
			// Pass the value of '_servicePrice' as parameter 'ServicePrice' of the stored procedure.
			if(_servicePriceNonDefault!=null)
			  oDatabaseHelper.AddParameter("@ServicePrice", _servicePriceNonDefault);
			else
			  oDatabaseHelper.AddParameter("@ServicePrice", DBNull.Value );
			  
			// Pass the value of '_taxTypeID' as parameter 'TaxTypeID' of the stored procedure.
			if(_taxTypeIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@TaxTypeID", _taxTypeIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@TaxTypeID", DBNull.Value );
			  
			// Pass the value of '_refuseReasonID' as parameter 'RefuseReasonID' of the stored procedure.
			if(_refuseReasonIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@RefuseReasonID", _refuseReasonIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@RefuseReasonID", DBNull.Value );
			  
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
			  
			// Pass the value of '_deletDate' as parameter 'DeletDate' of the stored procedure.
			if(_deletDateNonDefault!=null)
			  oDatabaseHelper.AddParameter("@DeletDate", _deletDateNonDefault);
			else
			  oDatabaseHelper.AddParameter("@DeletDate", DBNull.Value );
			  
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			if(!getBackValues )
			{
				oDatabaseHelper.ExecuteScalar("gsp_SALSalesHeader_Insert_WithDefaultValues", ref ExecutionState);
			}
			else
			{
				IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_SALSalesHeader_Insert_WithDefaultValues_AndReturn", ref ExecutionState);
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
		/// DLGenerator			12/27/2014 6:56:13 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Insert() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_salesDate' as parameter 'SalesDate' of the stored procedure.
			if(_salesDateNonDefault!=null)
			  oDatabaseHelper.AddParameter("@SalesDate", _salesDateNonDefault);
			else
			  oDatabaseHelper.AddParameter("@SalesDate", DBNull.Value );
			// Pass the value of '_customerID' as parameter 'CustomerID' of the stored procedure.
			if(_customerIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@CustomerID", _customerIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@CustomerID", DBNull.Value );
			// Pass the value of '_invoiceNumber' as parameter 'InvoiceNumber' of the stored procedure.
			if(_invoiceNumberNonDefault!=null)
			  oDatabaseHelper.AddParameter("@InvoiceNumber", _invoiceNumberNonDefault);
			else
			  oDatabaseHelper.AddParameter("@InvoiceNumber", DBNull.Value );
			// Pass the value of '_invoiceDate' as parameter 'InvoiceDate' of the stored procedure.
			if(_invoiceDateNonDefault!=null)
			  oDatabaseHelper.AddParameter("@InvoiceDate", _invoiceDateNonDefault);
			else
			  oDatabaseHelper.AddParameter("@InvoiceDate", DBNull.Value );
			// Pass the value of '_sellerID' as parameter 'SellerID' of the stored procedure.
			if(_sellerIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@SellerID", _sellerIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@SellerID", DBNull.Value );
			// Pass the value of '_paymentTypeID' as parameter 'PaymentTypeID' of the stored procedure.
			if(_paymentTypeIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@PaymentTypeID", _paymentTypeIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@PaymentTypeID", DBNull.Value );
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
			// Pass the value of '_lastDayToPay' as parameter 'LastDayToPay' of the stored procedure.
			if(_lastDayToPayNonDefault!=null)
			  oDatabaseHelper.AddParameter("@LastDayToPay", _lastDayToPayNonDefault);
			else
			  oDatabaseHelper.AddParameter("@LastDayToPay", DBNull.Value );
			// Pass the value of '_totalDiscountAmount' as parameter 'TotalDiscountAmount' of the stored procedure.
			if(_totalDiscountAmountNonDefault!=null)
			  oDatabaseHelper.AddParameter("@TotalDiscountAmount", _totalDiscountAmountNonDefault);
			else
			  oDatabaseHelper.AddParameter("@TotalDiscountAmount", DBNull.Value );
			// Pass the value of '_totalDiscountRatio' as parameter 'TotalDiscountRatio' of the stored procedure.
			if(_totalDiscountRatioNonDefault!=null)
			  oDatabaseHelper.AddParameter("@TotalDiscountRatio", _totalDiscountRatioNonDefault);
			else
			  oDatabaseHelper.AddParameter("@TotalDiscountRatio", DBNull.Value );
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
			// Pass the value of '_isPrinted' as parameter 'IsPrinted' of the stored procedure.
			if(_isPrintedNonDefault!=null)
			  oDatabaseHelper.AddParameter("@IsPrinted", _isPrintedNonDefault);
			else
			  oDatabaseHelper.AddParameter("@IsPrinted", DBNull.Value );
			// Pass the value of '_servicePrice' as parameter 'ServicePrice' of the stored procedure.
			if(_servicePriceNonDefault!=null)
			  oDatabaseHelper.AddParameter("@ServicePrice", _servicePriceNonDefault);
			else
			  oDatabaseHelper.AddParameter("@ServicePrice", DBNull.Value );
			// Pass the value of '_taxTypeID' as parameter 'TaxTypeID' of the stored procedure.
			if(_taxTypeIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@TaxTypeID", _taxTypeIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@TaxTypeID", DBNull.Value );
			// Pass the value of '_refuseReasonID' as parameter 'RefuseReasonID' of the stored procedure.
			if(_refuseReasonIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@RefuseReasonID", _refuseReasonIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@RefuseReasonID", DBNull.Value );
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
			// Pass the value of '_deletDate' as parameter 'DeletDate' of the stored procedure.
			if(_deletDateNonDefault!=null)
			  oDatabaseHelper.AddParameter("@DeletDate", _deletDateNonDefault);
			else
			  oDatabaseHelper.AddParameter("@DeletDate", DBNull.Value );
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_SALSalesHeader_Insert", ref ExecutionState);
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
		/// DLGenerator			12/27/2014 6:56:13 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Update() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_salesHeaderID' as parameter 'SalesHeaderID' of the stored procedure.
			oDatabaseHelper.AddParameter("@SalesHeaderID", _salesHeaderIDNonDefault );
			
			// Pass the value of '_salesDate' as parameter 'SalesDate' of the stored procedure.
			oDatabaseHelper.AddParameter("@SalesDate", _salesDateNonDefault );
			
			// Pass the value of '_customerID' as parameter 'CustomerID' of the stored procedure.
			oDatabaseHelper.AddParameter("@CustomerID", _customerIDNonDefault );
			
			// Pass the value of '_invoiceNumber' as parameter 'InvoiceNumber' of the stored procedure.
			oDatabaseHelper.AddParameter("@InvoiceNumber", _invoiceNumberNonDefault );
			
			// Pass the value of '_invoiceDate' as parameter 'InvoiceDate' of the stored procedure.
			oDatabaseHelper.AddParameter("@InvoiceDate", _invoiceDateNonDefault );
			
			// Pass the value of '_sellerID' as parameter 'SellerID' of the stored procedure.
			oDatabaseHelper.AddParameter("@SellerID", _sellerIDNonDefault );
			
			// Pass the value of '_paymentTypeID' as parameter 'PaymentTypeID' of the stored procedure.
			oDatabaseHelper.AddParameter("@PaymentTypeID", _paymentTypeIDNonDefault );
			
			// Pass the value of '_totalPrice' as parameter 'TotalPrice' of the stored procedure.
			oDatabaseHelper.AddParameter("@TotalPrice", _totalPriceNonDefault );
			
			// Pass the value of '_paidAmount' as parameter 'PaidAmount' of the stored procedure.
			oDatabaseHelper.AddParameter("@PaidAmount", _paidAmountNonDefault );
			
			// Pass the value of '_remainingAmount' as parameter 'RemainingAmount' of the stored procedure.
			oDatabaseHelper.AddParameter("@RemainingAmount", _remainingAmountNonDefault );
			
			// Pass the value of '_lastDayToPay' as parameter 'LastDayToPay' of the stored procedure.
			oDatabaseHelper.AddParameter("@LastDayToPay", _lastDayToPayNonDefault );
			
			// Pass the value of '_totalDiscountAmount' as parameter 'TotalDiscountAmount' of the stored procedure.
			oDatabaseHelper.AddParameter("@TotalDiscountAmount", _totalDiscountAmountNonDefault );
			
			// Pass the value of '_totalDiscountRatio' as parameter 'TotalDiscountRatio' of the stored procedure.
			oDatabaseHelper.AddParameter("@TotalDiscountRatio", _totalDiscountRatioNonDefault );
			
			// Pass the value of '_isClosed' as parameter 'IsClosed' of the stored procedure.
			oDatabaseHelper.AddParameter("@IsClosed", _isClosedNonDefault );
			
			// Pass the value of '_isVoid' as parameter 'IsVoid' of the stored procedure.
			oDatabaseHelper.AddParameter("@IsVoid", _isVoidNonDefault );
			
			// Pass the value of '_isPrinted' as parameter 'IsPrinted' of the stored procedure.
			oDatabaseHelper.AddParameter("@IsPrinted", _isPrintedNonDefault );
			
			// Pass the value of '_servicePrice' as parameter 'ServicePrice' of the stored procedure.
			oDatabaseHelper.AddParameter("@ServicePrice", _servicePriceNonDefault );
			
			// Pass the value of '_taxTypeID' as parameter 'TaxTypeID' of the stored procedure.
			oDatabaseHelper.AddParameter("@TaxTypeID", _taxTypeIDNonDefault );
			
			// Pass the value of '_refuseReasonID' as parameter 'RefuseReasonID' of the stored procedure.
			oDatabaseHelper.AddParameter("@RefuseReasonID", _refuseReasonIDNonDefault );
			
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
			
			// Pass the value of '_deletDate' as parameter 'DeletDate' of the stored procedure.
			oDatabaseHelper.AddParameter("@DeletDate", _deletDateNonDefault );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_SALSalesHeader_Update", ref ExecutionState);
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
		/// DLGenerator			12/27/2014 6:56:13 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Delete() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_salesHeaderID' as parameter 'SalesHeaderID' of the stored procedure.
			if(_salesHeaderIDNonDefault!=null)
				oDatabaseHelper.AddParameter("@SalesHeaderID", _salesHeaderIDNonDefault );
			else
				oDatabaseHelper.AddParameter("@SalesHeaderID", DBNull.Value );
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_SALSalesHeader_Delete", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will Delete one row from the database using the primary key information
		/// </summary>
		///
		/// <param name="pk" type="SALSalesHeaderPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>True if succeeded</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:13 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static bool Delete(SALSalesHeaderPrimaryKey pk) 
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
   
			oDatabaseHelper.ExecuteScalar("gsp_SALSalesHeader_Delete", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="SALSalesHeaderFields">Field of the class SALSalesHeader</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		///
		/// <returns>True if succeeded</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:13 PM		Created function
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
			
			oDatabaseHelper.ExecuteScalar("gsp_SALSalesHeader_DeleteByField", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="SALSalesHeaderPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class SALSalesHeader</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:13 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static SALSalesHeader SelectOne(SALSalesHeaderPrimaryKey pk)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_SALSalesHeader_SelectbyPrimaryKey", ref ExecutionState);
			if (dr.Read())
			{
				SALSalesHeader obj=new SALSalesHeader();	
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
		/// <returns>list of objects of class SALSalesHeader in the form of object of SALSalesHeaderCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:13 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static SALSalesHeaderCollection SelectAll()
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_SALSalesHeader_SelectAll", ref ExecutionState);
			SALSalesHeaderCollection SALSalesHeaderCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return SALSalesHeaderCollection;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class SALSalesHeader</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class SALSalesHeader in the form of an object of class SALSalesHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:13 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static SALSalesHeaderCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_SALSalesHeader_SelectByField", ref ExecutionState);
			SALSalesHeaderCollection SALSalesHeaderCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return SALSalesHeaderCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number</param>
		///
		/// <returns>list of objects of class SALSalesHeader in the form of object of SALSalesHeaderCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:13 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static SALSalesHeaderCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// Pass the specified field and its value to the stored procedure.
			oDatabaseHelper.AddParameter("@PageSize",pageSize);
			oDatabaseHelper.AddParameter("@SkipPages", skipPages);
			oDatabaseHelper.AddParameter("@OrderByStatement", orderByStatement );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_SALSalesHeader_SelectAllPaged", ref ExecutionState);
			SALSalesHeaderCollection SALSalesHeaderCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return SALSalesHeaderCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class SALSalesHeader</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class SALSalesHeader in the form of an object of class SALSalesHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:13 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static SALSalesHeaderCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_SALSalesHeader_SelectByFieldPaged", ref ExecutionState);
			SALSalesHeaderCollection SALSalesHeaderCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return SALSalesHeaderCollection;
			
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
		/// DLGenerator			12/27/2014 6:56:13 PM		Created function
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
			
			Object dr=oDatabaseHelper.ExecuteScalar("gsp_SALSalesHeader_SelectAllCount");
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
		/// <returns>object of class SALSalesHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:13 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static SALSalesHeaderCollection SelectAllByForeignKeySellerID(ADUserPrimaryKey pk)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			SALSalesHeaderCollection obj = null;
			
			// Pass the values of all key parameters to the stored procedure.
			System.Collections.Specialized.NameValueCollection nvc = pk.GetKeysAndValues();
			foreach (string key in nvc.Keys)
			{
				oDatabaseHelper.AddParameter("@" + key,nvc[key] );
			}
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_SALSalesHeader_SelectAllByForeignKeySellerID", ref ExecutionState);
			obj = new SALSalesHeaderCollection();
			obj = SALSalesHeader.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
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
		/// <returns>object of class SALSalesHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:13 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static SALSalesHeaderCollection SelectAllByForeignKeySellerIDPaged(ADUserPrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			SALSalesHeaderCollection obj = null;
			
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_SALSalesHeader_SelectAllByForeignKeySellerIDPaged", ref ExecutionState);
			obj = new SALSalesHeaderCollection();
			obj = SALSalesHeader.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
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
		/// DLGenerator			12/27/2014 6:56:13 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static bool DeleteAllByForeignKeySellerID(ADUserPrimaryKey pk)
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
			
			oDatabaseHelper.ExecuteNonQuery("gsp_SALSalesHeader_DeleteAllByForeignKeySellerID", ref ExecutionState);
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
		/// <returns>object of class SALSalesHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:13 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static SALSalesHeaderCollection SelectAllByForeignKeyCustomerID(BDCustomerPrimaryKey pk)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			SALSalesHeaderCollection obj = null;
			
			// Pass the values of all key parameters to the stored procedure.
			System.Collections.Specialized.NameValueCollection nvc = pk.GetKeysAndValues();
			foreach (string key in nvc.Keys)
			{
				oDatabaseHelper.AddParameter("@" + key,nvc[key] );
			}
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_SALSalesHeader_SelectAllByForeignKeyCustomerID", ref ExecutionState);
			obj = new SALSalesHeaderCollection();
			obj = SALSalesHeader.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
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
		/// <returns>object of class SALSalesHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:13 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static SALSalesHeaderCollection SelectAllByForeignKeyCustomerIDPaged(BDCustomerPrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			SALSalesHeaderCollection obj = null;
			
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_SALSalesHeader_SelectAllByForeignKeyCustomerIDPaged", ref ExecutionState);
			obj = new SALSalesHeaderCollection();
			obj = SALSalesHeader.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
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
		/// DLGenerator			12/27/2014 6:56:13 PM				Created function
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
			
			oDatabaseHelper.ExecuteNonQuery("gsp_SALSalesHeader_DeleteAllByForeignKeyCustomerID", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}



		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="BDRefuseReasonPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class SALSalesHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:13 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static SALSalesHeaderCollection SelectAllByForeignKeyRefuseReasonID(BDRefuseReasonPrimaryKey pk)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			SALSalesHeaderCollection obj = null;
			
			// Pass the values of all key parameters to the stored procedure.
			System.Collections.Specialized.NameValueCollection nvc = pk.GetKeysAndValues();
			foreach (string key in nvc.Keys)
			{
				oDatabaseHelper.AddParameter("@" + key,nvc[key] );
			}
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_SALSalesHeader_SelectAllByForeignKeyRefuseReasonID", ref ExecutionState);
			obj = new SALSalesHeaderCollection();
			obj = SALSalesHeader.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
			dr.Close();  
			oDatabaseHelper.Dispose();
			return obj;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="BDRefuseReasonPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number</param>
		///
		/// <returns>object of class SALSalesHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:13 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static SALSalesHeaderCollection SelectAllByForeignKeyRefuseReasonIDPaged(BDRefuseReasonPrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			SALSalesHeaderCollection obj = null;
			
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_SALSalesHeader_SelectAllByForeignKeyRefuseReasonIDPaged", ref ExecutionState);
			obj = new SALSalesHeaderCollection();
			obj = SALSalesHeader.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
			dr.Close();  
			oDatabaseHelper.Dispose();
			return obj;
			
		}

		/// <summary>
		/// This method will delete row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="BDRefuseReasonPrimaryKey">Primary Key information based on which data is to be deleted.</param>
		///
		/// <returns>object of boolean type as an indicator for operation success .</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:13 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static bool DeleteAllByForeignKeyRefuseReasonID(BDRefuseReasonPrimaryKey pk)
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
			
			oDatabaseHelper.ExecuteNonQuery("gsp_SALSalesHeader_DeleteAllByForeignKeyRefuseReasonID", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}



		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="BDTaxTypePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class SALSalesHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:13 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static SALSalesHeaderCollection SelectAllByForeignKeyTaxTypeID(BDTaxTypePrimaryKey pk)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			SALSalesHeaderCollection obj = null;
			
			// Pass the values of all key parameters to the stored procedure.
			System.Collections.Specialized.NameValueCollection nvc = pk.GetKeysAndValues();
			foreach (string key in nvc.Keys)
			{
				oDatabaseHelper.AddParameter("@" + key,nvc[key] );
			}
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_SALSalesHeader_SelectAllByForeignKeyTaxTypeID", ref ExecutionState);
			obj = new SALSalesHeaderCollection();
			obj = SALSalesHeader.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
			dr.Close();  
			oDatabaseHelper.Dispose();
			return obj;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="BDTaxTypePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number</param>
		///
		/// <returns>object of class SALSalesHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:13 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static SALSalesHeaderCollection SelectAllByForeignKeyTaxTypeIDPaged(BDTaxTypePrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			SALSalesHeaderCollection obj = null;
			
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_SALSalesHeader_SelectAllByForeignKeyTaxTypeIDPaged", ref ExecutionState);
			obj = new SALSalesHeaderCollection();
			obj = SALSalesHeader.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
			dr.Close();  
			oDatabaseHelper.Dispose();
			return obj;
			
		}

		/// <summary>
		/// This method will delete row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="BDTaxTypePrimaryKey">Primary Key information based on which data is to be deleted.</param>
		///
		/// <returns>object of boolean type as an indicator for operation success .</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:13 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static bool DeleteAllByForeignKeyTaxTypeID(BDTaxTypePrimaryKey pk)
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
			
			oDatabaseHelper.ExecuteNonQuery("gsp_SALSalesHeader_DeleteAllByForeignKeyTaxTypeID", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}



		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="PaymentTypePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class SALSalesHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:13 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static SALSalesHeaderCollection SelectAllByForeignKeyPaymentTypeID(PaymentTypePrimaryKey pk)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			SALSalesHeaderCollection obj = null;
			
			// Pass the values of all key parameters to the stored procedure.
			System.Collections.Specialized.NameValueCollection nvc = pk.GetKeysAndValues();
			foreach (string key in nvc.Keys)
			{
				oDatabaseHelper.AddParameter("@" + key,nvc[key] );
			}
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_SALSalesHeader_SelectAllByForeignKeyPaymentTypeID", ref ExecutionState);
			obj = new SALSalesHeaderCollection();
			obj = SALSalesHeader.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
			dr.Close();  
			oDatabaseHelper.Dispose();
			return obj;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="PaymentTypePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number</param>
		///
		/// <returns>object of class SALSalesHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:13 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static SALSalesHeaderCollection SelectAllByForeignKeyPaymentTypeIDPaged(PaymentTypePrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			SALSalesHeaderCollection obj = null;
			
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_SALSalesHeader_SelectAllByForeignKeyPaymentTypeIDPaged", ref ExecutionState);
			obj = new SALSalesHeaderCollection();
			obj = SALSalesHeader.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
			dr.Close();  
			oDatabaseHelper.Dispose();
			return obj;
			
		}

		/// <summary>
		/// This method will delete row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="PaymentTypePrimaryKey">Primary Key information based on which data is to be deleted.</param>
		///
		/// <returns>object of boolean type as an indicator for operation success .</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:13 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static bool DeleteAllByForeignKeyPaymentTypeID(PaymentTypePrimaryKey pk)
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
			
			oDatabaseHelper.ExecuteNonQuery("gsp_SALSalesHeader_DeleteAllByForeignKeyPaymentTypeID", ref ExecutionState);
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
		/// DLGenerator			12/27/2014 6:56:13 PM		Created function
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
		/// <param name="obj" type="SALSalesHeader">Object of SALSalesHeader to populate</param>
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:13 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static void PopulateObjectFromReader(SALSalesHeaderBase obj,IDataReader rdr) 
		{

			obj.SalesHeaderID = rdr.GetInt32(rdr.GetOrdinal(SALSalesHeaderFields.SalesHeaderID));
			obj.SalesDate = rdr.GetDateTime(rdr.GetOrdinal(SALSalesHeaderFields.SalesDate));
			obj.CustomerID = rdr.GetInt32(rdr.GetOrdinal(SALSalesHeaderFields.CustomerID));
			if (!rdr.IsDBNull(rdr.GetOrdinal(SALSalesHeaderFields.InvoiceNumber)))
			{
				obj.InvoiceNumber = rdr.GetString(rdr.GetOrdinal(SALSalesHeaderFields.InvoiceNumber));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(SALSalesHeaderFields.InvoiceDate)))
			{
				obj.InvoiceDate = rdr.GetDateTime(rdr.GetOrdinal(SALSalesHeaderFields.InvoiceDate));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(SALSalesHeaderFields.SellerID)))
			{
				obj.SellerID = rdr.GetInt32(rdr.GetOrdinal(SALSalesHeaderFields.SellerID));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(SALSalesHeaderFields.PaymentTypeID)))
			{
				obj.PaymentTypeID = rdr.GetInt32(rdr.GetOrdinal(SALSalesHeaderFields.PaymentTypeID));
			}
			
			obj.TotalPrice = rdr.GetDecimal(rdr.GetOrdinal(SALSalesHeaderFields.TotalPrice));
			obj.PaidAmount = rdr.GetDecimal(rdr.GetOrdinal(SALSalesHeaderFields.PaidAmount));
			obj.RemainingAmount = rdr.GetDecimal(rdr.GetOrdinal(SALSalesHeaderFields.RemainingAmount));
			if (!rdr.IsDBNull(rdr.GetOrdinal(SALSalesHeaderFields.LastDayToPay)))
			{
				obj.LastDayToPay = rdr.GetDateTime(rdr.GetOrdinal(SALSalesHeaderFields.LastDayToPay));
			}
			
			obj.TotalDiscountAmount = rdr.GetDecimal(rdr.GetOrdinal(SALSalesHeaderFields.TotalDiscountAmount));
			obj.TotalDiscountRatio = rdr.GetDouble(rdr.GetOrdinal(SALSalesHeaderFields.TotalDiscountRatio));
			obj.IsClosed = rdr.GetBoolean(rdr.GetOrdinal(SALSalesHeaderFields.IsClosed));
			obj.IsVoid = rdr.GetBoolean(rdr.GetOrdinal(SALSalesHeaderFields.IsVoid));
			obj.IsPrinted = rdr.GetBoolean(rdr.GetOrdinal(SALSalesHeaderFields.IsPrinted));
			obj.ServicePrice = rdr.GetDecimal(rdr.GetOrdinal(SALSalesHeaderFields.ServicePrice));
			if (!rdr.IsDBNull(rdr.GetOrdinal(SALSalesHeaderFields.TaxTypeID)))
			{
				obj.TaxTypeID = rdr.GetInt32(rdr.GetOrdinal(SALSalesHeaderFields.TaxTypeID));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(SALSalesHeaderFields.RefuseReasonID)))
			{
				obj.RefuseReasonID = rdr.GetInt32(rdr.GetOrdinal(SALSalesHeaderFields.RefuseReasonID));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(SALSalesHeaderFields.CreatedBy)))
			{
				obj.CreatedBy = rdr.GetInt32(rdr.GetOrdinal(SALSalesHeaderFields.CreatedBy));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(SALSalesHeaderFields.CreateDate)))
			{
				obj.CreateDate = rdr.GetDateTime(rdr.GetOrdinal(SALSalesHeaderFields.CreateDate));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(SALSalesHeaderFields.UpdatedBy)))
			{
				obj.UpdatedBy = rdr.GetInt32(rdr.GetOrdinal(SALSalesHeaderFields.UpdatedBy));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(SALSalesHeaderFields.UpdateDate)))
			{
				obj.UpdateDate = rdr.GetDateTime(rdr.GetOrdinal(SALSalesHeaderFields.UpdateDate));
			}
			
			obj.IsDeleted = rdr.GetBoolean(rdr.GetOrdinal(SALSalesHeaderFields.IsDeleted));
			if (!rdr.IsDBNull(rdr.GetOrdinal(SALSalesHeaderFields.DeletedBy)))
			{
				obj.DeletedBy = rdr.GetInt32(rdr.GetOrdinal(SALSalesHeaderFields.DeletedBy));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(SALSalesHeaderFields.DeletDate)))
			{
				obj.DeletDate = rdr.GetDateTime(rdr.GetOrdinal(SALSalesHeaderFields.DeletDate));
			}
			

		}

		/// <summary>
		/// Populates the fields for multiple objects from the columns found in an open reader.
		/// </summary>
		///
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <returns>Object of SALSalesHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:13 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static SALSalesHeaderCollection PopulateObjectsFromReader(IDataReader rdr) 
		{
			SALSalesHeaderCollection list = new SALSalesHeaderCollection();
			
			while (rdr.Read())
			{
				SALSalesHeader obj = new SALSalesHeader();
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
		/// <returns>Object of SALSalesHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:13 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static SALSalesHeaderCollection PopulateObjectsFromReaderWithCheckingReader(IDataReader rdr, DatabaseHelper oDatabaseHelper) 
		{

			SALSalesHeaderCollection list = new SALSalesHeaderCollection();
			
            if (rdr.Read())
			{
				SALSalesHeader obj = new SALSalesHeader();
				PopulateObjectFromReader(obj, rdr);
				list.Add(obj);
				while (rdr.Read())
				{
					obj = new SALSalesHeader();
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
