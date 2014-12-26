//
// Class	:	PURPurchaseHeaderBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	12/26/2014 2:45:58 AM
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
	public class PURPurchaseHeaderFields
	{
		public const string PurcaseHeaderID           = "PurcaseHeaderID";
		public const string PurchaseDate              = "PurchaseDate";
		public const string PaymentTypeID             = "PaymentTypeID";
		public const string SupplierID                = "SupplierID";
		public const string InvoiceNumber             = "InvoiceNumber";
		public const string CreateDate                = "CreateDate";
		public const string CreatedBy                 = "CreatedBy";
		public const string updateDate                = "updateDate";
		public const string UpdatedBy                 = "UpdatedBy";
		public const string IsDeleted                 = "IsDeleted";
		public const string DeleteDate                = "DeleteDate";
		public const string TotalPrice                = "TotalPrice";
		public const string ServicePrice              = "ServicePrice";
		public const string PaidAmount                = "PaidAmount";
		public const string IsClosed                  = "IsClosed";
		public const string IsVoid                    = "IsVoid";
		public const string IsPrinted                 = "IsPrinted";
		public const string RefuseReasonID            = "RefuseReasonID";
		public const string TotalDiscountAmount       = "TotalDiscountAmount";
		public const string TotalDiscountRatio        = "TotalDiscountRatio";
		public const string TaxTypeID                 = "TaxTypeID";
		public const string RenainingAmount           = "RenainingAmount";
		public const string LastDayToPay              = "LastDayToPay";
		public const string DeletedBy                 = "DeletedBy";
		public const string Notes                     = "Notes";
	}
	
	/// <summary>
	/// Data access class for the "PURPurchaseHeader" table.
	/// </summary>
	[Serializable]
	public class PURPurchaseHeaderBase
	{
		
		#region Class Level Variables
		
		private DatabaseHelper oDatabaseHelper = new DatabaseHelper();

		private int?           	_purcaseHeaderIDNonDefault	= null;
		private DateTime?      	_purchaseDateNonDefault  	= null;
		private int?           	_paymentTypeIDNonDefault 	= null;
		private int?           	_supplierIDNonDefault    	= null;
		private string         	_invoiceNumberNonDefault 	= null;
		private DateTime?      	_createDateNonDefault    	= null;
		private int?           	_createdByNonDefault     	= null;
		private DateTime?      	_updateDateNonDefault    	= null;
		private int?           	_updatedByNonDefault     	= null;
		private bool?          	_isDeletedNonDefault     	= false;
		private DateTime?      	_deleteDateNonDefault    	= null;
		private decimal?       	_totalPriceNonDefault    	= 0;
		private decimal?       	_servicePriceNonDefault  	= 0;
		private decimal?       	_paidAmountNonDefault    	= 0;
		private bool?          	_isClosedNonDefault      	= false;
		private bool?          	_isVoidNonDefault        	= false;
		private bool?          	_isPrintedNonDefault     	= false;
		private int?           	_refuseReasonIDNonDefault	= null;
		private decimal?       	_totalDiscountAmountNonDefault	= 0;
		private double?        	_totalDiscountRatioNonDefault	= 0;
		private int?           	_taxTypeIDNonDefault     	= null;
		private decimal?       	_renainingAmountNonDefault	= 0;
		private DateTime?      	_lastDayToPayNonDefault  	= null;
		private int?           	_deletedByNonDefault     	= null;
		private string         	_notesNonDefault         	= null;

		private PURPurchaseLineCollection _pURPurchaseLineCollectionPurchaseHeaderID = null;
		private PURPurchaseReturnHeaderCollection _pURPurchaseReturnHeaderCollectionOriginalHeaderID = null;
		
		#endregion
		
		#region Constants
		
		#endregion
		
		#region Constructors / Destructors

		/// <summary>
		/// Class Constructor
		///</summary>
		public PURPurchaseHeaderBase() { }
					
		#endregion
		
		#region Properties

		/// <summary>
		/// Returns the identifier of the persistent object. Don't set it manually!
		/// </summary>
		public int? PurcaseHeaderID
		{
			get 
			{ 
				return _purcaseHeaderIDNonDefault;
			}
			set 
			{
			
				_purcaseHeaderIDNonDefault = value; 
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
		/// This property is mapped to the "RenainingAmount" field.  Mandatory.
		/// </summary>
		public decimal? RenainingAmount
		{
			get 
			{ 
				return _renainingAmountNonDefault;
			}
			set 
			{
			
				_renainingAmountNonDefault = value; 
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
		/// This property is mapped to the "Notes" field. Length must be between 0 and 2147483647 characters. 
		/// </summary>
		public string Notes
		{
			get 
			{ 
				if(_notesNonDefault==null)return _notesNonDefault;
				else return _notesNonDefault.Trim(); 
			}
			set 
			{
			    if (value != null && value.Length > 2147483647)
					throw new ArgumentException("Notes length must be between 0 and 2147483647 characters.");

				
				if(value ==null)
				{
					_notesNonDefault =null;//null value 
				}
				else
				{		           
					_notesNonDefault = value.Trim(); 
				}
			}
		}

		/// <summary>
		/// Provides access to the related table 'PURPurchaseLine'
		/// </summary>
		public PURPurchaseLineCollection PURPurchaseLineCollectionUsingPurchaseHeaderID
		{
			get 
			{
				if (_pURPurchaseLineCollectionPurchaseHeaderID == null)
				{
					_pURPurchaseLineCollectionPurchaseHeaderID = new PURPurchaseLineCollection();
					_pURPurchaseLineCollectionPurchaseHeaderID = PURPurchaseLine.SelectByField("PurchaseHeaderID",PurcaseHeaderID, null, TypeOperation.Equal);
				}                
				return _pURPurchaseLineCollectionPurchaseHeaderID; 
			}
			set 
			{
				  _pURPurchaseLineCollectionPurchaseHeaderID = value;
			}
		}

		/// <summary>
		/// Provides access to the related table 'PURPurchaseReturnHeader'
		/// </summary>
		public PURPurchaseReturnHeaderCollection PURPurchaseReturnHeaderCollectionUsingOriginalHeaderID
		{
			get 
			{
				if (_pURPurchaseReturnHeaderCollectionOriginalHeaderID == null)
				{
					_pURPurchaseReturnHeaderCollectionOriginalHeaderID = new PURPurchaseReturnHeaderCollection();
					_pURPurchaseReturnHeaderCollectionOriginalHeaderID = PURPurchaseReturnHeader.SelectByField("OriginalHeaderID",PurcaseHeaderID, null, TypeOperation.Equal);
				}                
				return _pURPurchaseReturnHeaderCollectionOriginalHeaderID; 
			}
			set 
			{
				  _pURPurchaseReturnHeaderCollectionOriginalHeaderID = value;
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
		/// DLGenerator			12/26/2014 2:45:58 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool InsertWithDefaultValues(bool getBackValues) 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_purchaseDate' as parameter 'PurchaseDate' of the stored procedure.
			if(_purchaseDateNonDefault!=null)
			  oDatabaseHelper.AddParameter("@PurchaseDate", _purchaseDateNonDefault);
			else
			  oDatabaseHelper.AddParameter("@PurchaseDate", DBNull.Value );
			  
			// Pass the value of '_paymentTypeID' as parameter 'PaymentTypeID' of the stored procedure.
			if(_paymentTypeIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@PaymentTypeID", _paymentTypeIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@PaymentTypeID", DBNull.Value );
			  
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
			  
			// Pass the value of '_totalPrice' as parameter 'TotalPrice' of the stored procedure.
			if(_totalPriceNonDefault!=null)
			  oDatabaseHelper.AddParameter("@TotalPrice", _totalPriceNonDefault);
			else
			  oDatabaseHelper.AddParameter("@TotalPrice", DBNull.Value );
			  
			// Pass the value of '_servicePrice' as parameter 'ServicePrice' of the stored procedure.
			if(_servicePriceNonDefault!=null)
			  oDatabaseHelper.AddParameter("@ServicePrice", _servicePriceNonDefault);
			else
			  oDatabaseHelper.AddParameter("@ServicePrice", DBNull.Value );
			  
			// Pass the value of '_paidAmount' as parameter 'PaidAmount' of the stored procedure.
			if(_paidAmountNonDefault!=null)
			  oDatabaseHelper.AddParameter("@PaidAmount", _paidAmountNonDefault);
			else
			  oDatabaseHelper.AddParameter("@PaidAmount", DBNull.Value );
			  
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
			  
			// Pass the value of '_refuseReasonID' as parameter 'RefuseReasonID' of the stored procedure.
			if(_refuseReasonIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@RefuseReasonID", _refuseReasonIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@RefuseReasonID", DBNull.Value );
			  
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
			  
			// Pass the value of '_taxTypeID' as parameter 'TaxTypeID' of the stored procedure.
			if(_taxTypeIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@TaxTypeID", _taxTypeIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@TaxTypeID", DBNull.Value );
			  
			// Pass the value of '_renainingAmount' as parameter 'RenainingAmount' of the stored procedure.
			if(_renainingAmountNonDefault!=null)
			  oDatabaseHelper.AddParameter("@RenainingAmount", _renainingAmountNonDefault);
			else
			  oDatabaseHelper.AddParameter("@RenainingAmount", DBNull.Value );
			  
			// Pass the value of '_lastDayToPay' as parameter 'LastDayToPay' of the stored procedure.
			if(_lastDayToPayNonDefault!=null)
			  oDatabaseHelper.AddParameter("@LastDayToPay", _lastDayToPayNonDefault);
			else
			  oDatabaseHelper.AddParameter("@LastDayToPay", DBNull.Value );
			  
			// Pass the value of '_deletedBy' as parameter 'DeletedBy' of the stored procedure.
			if(_deletedByNonDefault!=null)
			  oDatabaseHelper.AddParameter("@DeletedBy", _deletedByNonDefault);
			else
			  oDatabaseHelper.AddParameter("@DeletedBy", DBNull.Value );
			  
			// Pass the value of '_notes' as parameter 'Notes' of the stored procedure.
			if(_notesNonDefault!=null)
			  oDatabaseHelper.AddParameter("@Notes", _notesNonDefault);
			else
			  oDatabaseHelper.AddParameter("@Notes", DBNull.Value );
			  
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			if(!getBackValues )
			{
				oDatabaseHelper.ExecuteScalar("gsp_PURPurchaseHeader_Insert_WithDefaultValues", ref ExecutionState);
			}
			else
			{
				IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseHeader_Insert_WithDefaultValues_AndReturn", ref ExecutionState);
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
		/// DLGenerator			12/26/2014 2:45:58 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Insert() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_purchaseDate' as parameter 'PurchaseDate' of the stored procedure.
			if(_purchaseDateNonDefault!=null)
			  oDatabaseHelper.AddParameter("@PurchaseDate", _purchaseDateNonDefault);
			else
			  oDatabaseHelper.AddParameter("@PurchaseDate", DBNull.Value );
			// Pass the value of '_paymentTypeID' as parameter 'PaymentTypeID' of the stored procedure.
			if(_paymentTypeIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@PaymentTypeID", _paymentTypeIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@PaymentTypeID", DBNull.Value );
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
			// Pass the value of '_totalPrice' as parameter 'TotalPrice' of the stored procedure.
			if(_totalPriceNonDefault!=null)
			  oDatabaseHelper.AddParameter("@TotalPrice", _totalPriceNonDefault);
			else
			  oDatabaseHelper.AddParameter("@TotalPrice", DBNull.Value );
			// Pass the value of '_servicePrice' as parameter 'ServicePrice' of the stored procedure.
			if(_servicePriceNonDefault!=null)
			  oDatabaseHelper.AddParameter("@ServicePrice", _servicePriceNonDefault);
			else
			  oDatabaseHelper.AddParameter("@ServicePrice", DBNull.Value );
			// Pass the value of '_paidAmount' as parameter 'PaidAmount' of the stored procedure.
			if(_paidAmountNonDefault!=null)
			  oDatabaseHelper.AddParameter("@PaidAmount", _paidAmountNonDefault);
			else
			  oDatabaseHelper.AddParameter("@PaidAmount", DBNull.Value );
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
			// Pass the value of '_refuseReasonID' as parameter 'RefuseReasonID' of the stored procedure.
			if(_refuseReasonIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@RefuseReasonID", _refuseReasonIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@RefuseReasonID", DBNull.Value );
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
			// Pass the value of '_taxTypeID' as parameter 'TaxTypeID' of the stored procedure.
			if(_taxTypeIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@TaxTypeID", _taxTypeIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@TaxTypeID", DBNull.Value );
			// Pass the value of '_renainingAmount' as parameter 'RenainingAmount' of the stored procedure.
			if(_renainingAmountNonDefault!=null)
			  oDatabaseHelper.AddParameter("@RenainingAmount", _renainingAmountNonDefault);
			else
			  oDatabaseHelper.AddParameter("@RenainingAmount", DBNull.Value );
			// Pass the value of '_lastDayToPay' as parameter 'LastDayToPay' of the stored procedure.
			if(_lastDayToPayNonDefault!=null)
			  oDatabaseHelper.AddParameter("@LastDayToPay", _lastDayToPayNonDefault);
			else
			  oDatabaseHelper.AddParameter("@LastDayToPay", DBNull.Value );
			// Pass the value of '_deletedBy' as parameter 'DeletedBy' of the stored procedure.
			if(_deletedByNonDefault!=null)
			  oDatabaseHelper.AddParameter("@DeletedBy", _deletedByNonDefault);
			else
			  oDatabaseHelper.AddParameter("@DeletedBy", DBNull.Value );
			// Pass the value of '_notes' as parameter 'Notes' of the stored procedure.
			if(_notesNonDefault!=null)
			  oDatabaseHelper.AddParameter("@Notes", _notesNonDefault);
			else
			  oDatabaseHelper.AddParameter("@Notes", DBNull.Value );
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_PURPurchaseHeader_Insert", ref ExecutionState);
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
		/// DLGenerator			12/26/2014 2:45:58 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Update() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_purcaseHeaderID' as parameter 'PurcaseHeaderID' of the stored procedure.
			oDatabaseHelper.AddParameter("@PurcaseHeaderID", _purcaseHeaderIDNonDefault );
			
			// Pass the value of '_purchaseDate' as parameter 'PurchaseDate' of the stored procedure.
			oDatabaseHelper.AddParameter("@PurchaseDate", _purchaseDateNonDefault );
			
			// Pass the value of '_paymentTypeID' as parameter 'PaymentTypeID' of the stored procedure.
			oDatabaseHelper.AddParameter("@PaymentTypeID", _paymentTypeIDNonDefault );
			
			// Pass the value of '_supplierID' as parameter 'SupplierID' of the stored procedure.
			oDatabaseHelper.AddParameter("@SupplierID", _supplierIDNonDefault );
			
			// Pass the value of '_invoiceNumber' as parameter 'InvoiceNumber' of the stored procedure.
			oDatabaseHelper.AddParameter("@InvoiceNumber", _invoiceNumberNonDefault );
			
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
			
			// Pass the value of '_totalPrice' as parameter 'TotalPrice' of the stored procedure.
			oDatabaseHelper.AddParameter("@TotalPrice", _totalPriceNonDefault );
			
			// Pass the value of '_servicePrice' as parameter 'ServicePrice' of the stored procedure.
			oDatabaseHelper.AddParameter("@ServicePrice", _servicePriceNonDefault );
			
			// Pass the value of '_paidAmount' as parameter 'PaidAmount' of the stored procedure.
			oDatabaseHelper.AddParameter("@PaidAmount", _paidAmountNonDefault );
			
			// Pass the value of '_isClosed' as parameter 'IsClosed' of the stored procedure.
			oDatabaseHelper.AddParameter("@IsClosed", _isClosedNonDefault );
			
			// Pass the value of '_isVoid' as parameter 'IsVoid' of the stored procedure.
			oDatabaseHelper.AddParameter("@IsVoid", _isVoidNonDefault );
			
			// Pass the value of '_isPrinted' as parameter 'IsPrinted' of the stored procedure.
			oDatabaseHelper.AddParameter("@IsPrinted", _isPrintedNonDefault );
			
			// Pass the value of '_refuseReasonID' as parameter 'RefuseReasonID' of the stored procedure.
			oDatabaseHelper.AddParameter("@RefuseReasonID", _refuseReasonIDNonDefault );
			
			// Pass the value of '_totalDiscountAmount' as parameter 'TotalDiscountAmount' of the stored procedure.
			oDatabaseHelper.AddParameter("@TotalDiscountAmount", _totalDiscountAmountNonDefault );
			
			// Pass the value of '_totalDiscountRatio' as parameter 'TotalDiscountRatio' of the stored procedure.
			oDatabaseHelper.AddParameter("@TotalDiscountRatio", _totalDiscountRatioNonDefault );
			
			// Pass the value of '_taxTypeID' as parameter 'TaxTypeID' of the stored procedure.
			oDatabaseHelper.AddParameter("@TaxTypeID", _taxTypeIDNonDefault );
			
			// Pass the value of '_renainingAmount' as parameter 'RenainingAmount' of the stored procedure.
			oDatabaseHelper.AddParameter("@RenainingAmount", _renainingAmountNonDefault );
			
			// Pass the value of '_lastDayToPay' as parameter 'LastDayToPay' of the stored procedure.
			oDatabaseHelper.AddParameter("@LastDayToPay", _lastDayToPayNonDefault );
			
			// Pass the value of '_deletedBy' as parameter 'DeletedBy' of the stored procedure.
			oDatabaseHelper.AddParameter("@DeletedBy", _deletedByNonDefault );
			
			// Pass the value of '_notes' as parameter 'Notes' of the stored procedure.
			oDatabaseHelper.AddParameter("@Notes", _notesNonDefault );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_PURPurchaseHeader_Update", ref ExecutionState);
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
		/// DLGenerator			12/26/2014 2:45:58 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Delete() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_purcaseHeaderID' as parameter 'PurcaseHeaderID' of the stored procedure.
			if(_purcaseHeaderIDNonDefault!=null)
				oDatabaseHelper.AddParameter("@PurcaseHeaderID", _purcaseHeaderIDNonDefault );
			else
				oDatabaseHelper.AddParameter("@PurcaseHeaderID", DBNull.Value );
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_PURPurchaseHeader_Delete", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will Delete one row from the database using the primary key information
		/// </summary>
		///
		/// <param name="pk" type="PURPurchaseHeaderPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>True if succeeded</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:58 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static bool Delete(PURPurchaseHeaderPrimaryKey pk) 
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
   
			oDatabaseHelper.ExecuteScalar("gsp_PURPurchaseHeader_Delete", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="PURPurchaseHeaderFields">Field of the class PURPurchaseHeader</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		///
		/// <returns>True if succeeded</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:58 AM		Created function
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
			
			oDatabaseHelper.ExecuteScalar("gsp_PURPurchaseHeader_DeleteByField", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="PURPurchaseHeaderPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class PURPurchaseHeader</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:58 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static PURPurchaseHeader SelectOne(PURPurchaseHeaderPrimaryKey pk)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseHeader_SelectbyPrimaryKey", ref ExecutionState);
			if (dr.Read())
			{
				PURPurchaseHeader obj=new PURPurchaseHeader();	
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
		/// <returns>list of objects of class PURPurchaseHeader in the form of object of PURPurchaseHeaderCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:58 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static PURPurchaseHeaderCollection SelectAll()
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseHeader_SelectAll", ref ExecutionState);
			PURPurchaseHeaderCollection PURPurchaseHeaderCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return PURPurchaseHeaderCollection;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class PURPurchaseHeader</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class PURPurchaseHeader in the form of an object of class PURPurchaseHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:58 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static PURPurchaseHeaderCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseHeader_SelectByField", ref ExecutionState);
			PURPurchaseHeaderCollection PURPurchaseHeaderCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return PURPurchaseHeaderCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number</param>
		///
		/// <returns>list of objects of class PURPurchaseHeader in the form of object of PURPurchaseHeaderCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:58 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static PURPurchaseHeaderCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// Pass the specified field and its value to the stored procedure.
			oDatabaseHelper.AddParameter("@PageSize",pageSize);
			oDatabaseHelper.AddParameter("@SkipPages", skipPages);
			oDatabaseHelper.AddParameter("@OrderByStatement", orderByStatement );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseHeader_SelectAllPaged", ref ExecutionState);
			PURPurchaseHeaderCollection PURPurchaseHeaderCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return PURPurchaseHeaderCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class PURPurchaseHeader</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class PURPurchaseHeader in the form of an object of class PURPurchaseHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:58 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static PURPurchaseHeaderCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseHeader_SelectByFieldPaged", ref ExecutionState);
			PURPurchaseHeaderCollection PURPurchaseHeaderCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return PURPurchaseHeaderCollection;
			
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
		/// DLGenerator			12/26/2014 2:45:58 AM		Created function
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
			
			Object dr=oDatabaseHelper.ExecuteScalar("gsp_PURPurchaseHeader_SelectAllCount");
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
		/// <returns>object of class PURPurchaseHeader</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:58 AM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static PURPurchaseHeader SelectOneWithPURPurchaseLineUsingPurchaseHeaderID(PURPurchaseHeaderPrimaryKey pk)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			PURPurchaseHeader obj=null;
			
			// Pass the values of all key parameters to the stored procedure.
			System.Collections.Specialized.NameValueCollection nvc = pk.GetKeysAndValues();
			foreach (string key in nvc.Keys)
			{
				oDatabaseHelper.AddParameter("@" + key,nvc[key] );
			}
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseHeader_SelectOneWithPURPurchaseLineUsingPurchaseHeaderID", ref ExecutionState);
			if (dr.Read())
			{
				obj= new PURPurchaseHeader();
				PopulateObjectFromReader(obj,dr);
				
				dr.NextResult();
				
				//Get the child records.
				obj.PURPurchaseLineCollectionUsingPurchaseHeaderID=PURPurchaseLine.PopulateObjectsFromReader(dr);
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
		/// <param name="pk" type="PURPurchaseHeaderPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class PURPurchaseHeader</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:58 AM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static PURPurchaseHeader SelectOneWithPURPurchaseReturnHeaderUsingOriginalHeaderID(PURPurchaseHeaderPrimaryKey pk)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			PURPurchaseHeader obj=null;
			
			// Pass the values of all key parameters to the stored procedure.
			System.Collections.Specialized.NameValueCollection nvc = pk.GetKeysAndValues();
			foreach (string key in nvc.Keys)
			{
				oDatabaseHelper.AddParameter("@" + key,nvc[key] );
			}
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseHeader_SelectOneWithPURPurchaseReturnHeaderUsingOriginalHeaderID", ref ExecutionState);
			if (dr.Read())
			{
				obj= new PURPurchaseHeader();
				PopulateObjectFromReader(obj,dr);
				
				dr.NextResult();
				
				//Get the child records.
				obj.PURPurchaseReturnHeaderCollectionUsingOriginalHeaderID=PURPurchaseReturnHeader.PopulateObjectsFromReader(dr);
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
		/// <param name="pk" type="BDRefuseReasonPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class PURPurchaseHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:58 AM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static PURPurchaseHeaderCollection SelectAllByForeignKeyRefuseReasonID(BDRefuseReasonPrimaryKey pk)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			PURPurchaseHeaderCollection obj = null;
			
			// Pass the values of all key parameters to the stored procedure.
			System.Collections.Specialized.NameValueCollection nvc = pk.GetKeysAndValues();
			foreach (string key in nvc.Keys)
			{
				oDatabaseHelper.AddParameter("@" + key,nvc[key] );
			}
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseHeader_SelectAllByForeignKeyRefuseReasonID", ref ExecutionState);
			obj = new PURPurchaseHeaderCollection();
			obj = PURPurchaseHeader.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
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
		/// <returns>object of class PURPurchaseHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:58 AM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static PURPurchaseHeaderCollection SelectAllByForeignKeyRefuseReasonIDPaged(BDRefuseReasonPrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			PURPurchaseHeaderCollection obj = null;
			
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseHeader_SelectAllByForeignKeyRefuseReasonIDPaged", ref ExecutionState);
			obj = new PURPurchaseHeaderCollection();
			obj = PURPurchaseHeader.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
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
		/// DLGenerator			12/26/2014 2:45:58 AM				Created function
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
			
			oDatabaseHelper.ExecuteNonQuery("gsp_PURPurchaseHeader_DeleteAllByForeignKeyRefuseReasonID", ref ExecutionState);
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
		/// <returns>object of class PURPurchaseHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:58 AM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static PURPurchaseHeaderCollection SelectAllByForeignKeySupplierID(BDSupplierPrimaryKey pk)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			PURPurchaseHeaderCollection obj = null;
			
			// Pass the values of all key parameters to the stored procedure.
			System.Collections.Specialized.NameValueCollection nvc = pk.GetKeysAndValues();
			foreach (string key in nvc.Keys)
			{
				oDatabaseHelper.AddParameter("@" + key,nvc[key] );
			}
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseHeader_SelectAllByForeignKeySupplierID", ref ExecutionState);
			obj = new PURPurchaseHeaderCollection();
			obj = PURPurchaseHeader.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
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
		/// <returns>object of class PURPurchaseHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:58 AM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static PURPurchaseHeaderCollection SelectAllByForeignKeySupplierIDPaged(BDSupplierPrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			PURPurchaseHeaderCollection obj = null;
			
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseHeader_SelectAllByForeignKeySupplierIDPaged", ref ExecutionState);
			obj = new PURPurchaseHeaderCollection();
			obj = PURPurchaseHeader.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
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
		/// DLGenerator			12/26/2014 2:45:58 AM				Created function
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
			
			oDatabaseHelper.ExecuteNonQuery("gsp_PURPurchaseHeader_DeleteAllByForeignKeySupplierID", ref ExecutionState);
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
		/// <returns>object of class PURPurchaseHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:58 AM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static PURPurchaseHeaderCollection SelectAllByForeignKeyTaxTypeID(BDTaxTypePrimaryKey pk)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			PURPurchaseHeaderCollection obj = null;
			
			// Pass the values of all key parameters to the stored procedure.
			System.Collections.Specialized.NameValueCollection nvc = pk.GetKeysAndValues();
			foreach (string key in nvc.Keys)
			{
				oDatabaseHelper.AddParameter("@" + key,nvc[key] );
			}
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseHeader_SelectAllByForeignKeyTaxTypeID", ref ExecutionState);
			obj = new PURPurchaseHeaderCollection();
			obj = PURPurchaseHeader.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
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
		/// <returns>object of class PURPurchaseHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:58 AM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static PURPurchaseHeaderCollection SelectAllByForeignKeyTaxTypeIDPaged(BDTaxTypePrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			PURPurchaseHeaderCollection obj = null;
			
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseHeader_SelectAllByForeignKeyTaxTypeIDPaged", ref ExecutionState);
			obj = new PURPurchaseHeaderCollection();
			obj = PURPurchaseHeader.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
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
		/// DLGenerator			12/26/2014 2:45:58 AM				Created function
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
			
			oDatabaseHelper.ExecuteNonQuery("gsp_PURPurchaseHeader_DeleteAllByForeignKeyTaxTypeID", ref ExecutionState);
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
		/// <returns>object of class PURPurchaseHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:58 AM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static PURPurchaseHeaderCollection SelectAllByForeignKeyPaymentTypeID(PaymentTypePrimaryKey pk)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			PURPurchaseHeaderCollection obj = null;
			
			// Pass the values of all key parameters to the stored procedure.
			System.Collections.Specialized.NameValueCollection nvc = pk.GetKeysAndValues();
			foreach (string key in nvc.Keys)
			{
				oDatabaseHelper.AddParameter("@" + key,nvc[key] );
			}
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseHeader_SelectAllByForeignKeyPaymentTypeID", ref ExecutionState);
			obj = new PURPurchaseHeaderCollection();
			obj = PURPurchaseHeader.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
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
		/// <returns>object of class PURPurchaseHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:58 AM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static PURPurchaseHeaderCollection SelectAllByForeignKeyPaymentTypeIDPaged(PaymentTypePrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			PURPurchaseHeaderCollection obj = null;
			
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseHeader_SelectAllByForeignKeyPaymentTypeIDPaged", ref ExecutionState);
			obj = new PURPurchaseHeaderCollection();
			obj = PURPurchaseHeader.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
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
		/// DLGenerator			12/26/2014 2:45:58 AM				Created function
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
			
			oDatabaseHelper.ExecuteNonQuery("gsp_PURPurchaseHeader_DeleteAllByForeignKeyPaymentTypeID", ref ExecutionState);
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
		/// DLGenerator			12/26/2014 2:45:58 AM		Created function
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
		/// <param name="obj" type="PURPurchaseHeader">Object of PURPurchaseHeader to populate</param>
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:58 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static void PopulateObjectFromReader(PURPurchaseHeaderBase obj,IDataReader rdr) 
		{

			obj.PurcaseHeaderID = rdr.GetInt32(rdr.GetOrdinal(PURPurchaseHeaderFields.PurcaseHeaderID));
			obj.PurchaseDate = rdr.GetDateTime(rdr.GetOrdinal(PURPurchaseHeaderFields.PurchaseDate));
			if (!rdr.IsDBNull(rdr.GetOrdinal(PURPurchaseHeaderFields.PaymentTypeID)))
			{
				obj.PaymentTypeID = rdr.GetInt32(rdr.GetOrdinal(PURPurchaseHeaderFields.PaymentTypeID));
			}
			
			obj.SupplierID = rdr.GetInt32(rdr.GetOrdinal(PURPurchaseHeaderFields.SupplierID));
			if (!rdr.IsDBNull(rdr.GetOrdinal(PURPurchaseHeaderFields.InvoiceNumber)))
			{
				obj.InvoiceNumber = rdr.GetString(rdr.GetOrdinal(PURPurchaseHeaderFields.InvoiceNumber));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(PURPurchaseHeaderFields.CreateDate)))
			{
				obj.CreateDate = rdr.GetDateTime(rdr.GetOrdinal(PURPurchaseHeaderFields.CreateDate));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(PURPurchaseHeaderFields.CreatedBy)))
			{
				obj.CreatedBy = rdr.GetInt32(rdr.GetOrdinal(PURPurchaseHeaderFields.CreatedBy));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(PURPurchaseHeaderFields.updateDate)))
			{
				obj.updateDate = rdr.GetDateTime(rdr.GetOrdinal(PURPurchaseHeaderFields.updateDate));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(PURPurchaseHeaderFields.UpdatedBy)))
			{
				obj.UpdatedBy = rdr.GetInt32(rdr.GetOrdinal(PURPurchaseHeaderFields.UpdatedBy));
			}
			
			obj.IsDeleted = rdr.GetBoolean(rdr.GetOrdinal(PURPurchaseHeaderFields.IsDeleted));
			if (!rdr.IsDBNull(rdr.GetOrdinal(PURPurchaseHeaderFields.DeleteDate)))
			{
				obj.DeleteDate = rdr.GetDateTime(rdr.GetOrdinal(PURPurchaseHeaderFields.DeleteDate));
			}
			
			obj.TotalPrice = rdr.GetDecimal(rdr.GetOrdinal(PURPurchaseHeaderFields.TotalPrice));
			obj.ServicePrice = rdr.GetDecimal(rdr.GetOrdinal(PURPurchaseHeaderFields.ServicePrice));
			obj.PaidAmount = rdr.GetDecimal(rdr.GetOrdinal(PURPurchaseHeaderFields.PaidAmount));
			obj.IsClosed = rdr.GetBoolean(rdr.GetOrdinal(PURPurchaseHeaderFields.IsClosed));
			obj.IsVoid = rdr.GetBoolean(rdr.GetOrdinal(PURPurchaseHeaderFields.IsVoid));
			obj.IsPrinted = rdr.GetBoolean(rdr.GetOrdinal(PURPurchaseHeaderFields.IsPrinted));
			if (!rdr.IsDBNull(rdr.GetOrdinal(PURPurchaseHeaderFields.RefuseReasonID)))
			{
				obj.RefuseReasonID = rdr.GetInt32(rdr.GetOrdinal(PURPurchaseHeaderFields.RefuseReasonID));
			}
			
			obj.TotalDiscountAmount = rdr.GetDecimal(rdr.GetOrdinal(PURPurchaseHeaderFields.TotalDiscountAmount));
			obj.TotalDiscountRatio = rdr.GetDouble(rdr.GetOrdinal(PURPurchaseHeaderFields.TotalDiscountRatio));
			if (!rdr.IsDBNull(rdr.GetOrdinal(PURPurchaseHeaderFields.TaxTypeID)))
			{
				obj.TaxTypeID = rdr.GetInt32(rdr.GetOrdinal(PURPurchaseHeaderFields.TaxTypeID));
			}
			
			obj.RenainingAmount = rdr.GetDecimal(rdr.GetOrdinal(PURPurchaseHeaderFields.RenainingAmount));
			if (!rdr.IsDBNull(rdr.GetOrdinal(PURPurchaseHeaderFields.LastDayToPay)))
			{
				obj.LastDayToPay = rdr.GetDateTime(rdr.GetOrdinal(PURPurchaseHeaderFields.LastDayToPay));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(PURPurchaseHeaderFields.DeletedBy)))
			{
				obj.DeletedBy = rdr.GetInt32(rdr.GetOrdinal(PURPurchaseHeaderFields.DeletedBy));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(PURPurchaseHeaderFields.Notes)))
			{
				obj.Notes = rdr.GetString(rdr.GetOrdinal(PURPurchaseHeaderFields.Notes));
			}
			

		}

		/// <summary>
		/// Populates the fields for multiple objects from the columns found in an open reader.
		/// </summary>
		///
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <returns>Object of PURPurchaseHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:58 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static PURPurchaseHeaderCollection PopulateObjectsFromReader(IDataReader rdr) 
		{
			PURPurchaseHeaderCollection list = new PURPurchaseHeaderCollection();
			
			while (rdr.Read())
			{
				PURPurchaseHeader obj = new PURPurchaseHeader();
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
		/// <returns>Object of PURPurchaseHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:58 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static PURPurchaseHeaderCollection PopulateObjectsFromReaderWithCheckingReader(IDataReader rdr, DatabaseHelper oDatabaseHelper) 
		{

			PURPurchaseHeaderCollection list = new PURPurchaseHeaderCollection();
			
            if (rdr.Read())
			{
				PURPurchaseHeader obj = new PURPurchaseHeader();
				PopulateObjectFromReader(obj, rdr);
				list.Add(obj);
				while (rdr.Read())
				{
					obj = new PURPurchaseHeader();
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
