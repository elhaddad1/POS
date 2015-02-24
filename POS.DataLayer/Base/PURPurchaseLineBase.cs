//
// Class	:	PURPurchaseLineBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	2/24/2015 10:40:54 AM
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
	public class PURPurchaseLineFields
	{
		public const string PurchaseLineID            = "PurchaseLineID";
		public const string PurchaseHeaderID          = "PurchaseHeaderID";
		public const string ProductID                 = "ProductID";
		public const string TotalQty                  = "TotalQty";
		public const string BonusQty                  = "BonusQty";
		public const string DiscountRatio             = "DiscountRatio";
		public const string DiscountAmount            = "DiscountAmount";
		public const string Unitprice                 = "Unitprice";
		public const string CreatedDate               = "CreatedDate";
		public const string CreatedBy                 = "CreatedBy";
		public const string UpdateDate                = "UpdateDate";
		public const string UpdatedBy                 = "UpdatedBy";
		public const string IsDeleted                 = "IsDeleted";
		public const string DeleteDate                = "DeleteDate";
		public const string DeletedBy                 = "DeletedBy";
		public const string InvoiceDate               = "InvoiceDate";
	}
	
	/// <summary>
	/// Data access class for the "PURPurchaseLine" table.
	/// </summary>
	[Serializable]
	public class PURPurchaseLineBase
	{
		
		#region Class Level Variables
		
		private DatabaseHelper oDatabaseHelper = new DatabaseHelper();

		private int?           	_purchaseLineIDNonDefault	= null;
		private int?           	_purchaseHeaderIDNonDefault	= null;
		private int?           	_productIDNonDefault     	= null;
		private decimal?       	_totalQtyNonDefault      	= 0;
		private decimal?       	_bonusQtyNonDefault      	= 0;
		private decimal?       	_discountRatioNonDefault 	= 0;
		private decimal?       	_discountAmountNonDefault	= 0;
		private decimal?       	_unitpriceNonDefault     	= 0;
		private DateTime?      	_createdDateNonDefault   	= null;
		private int?           	_createdByNonDefault     	= null;
		private DateTime?      	_updateDateNonDefault    	= null;
		private int?           	_updatedByNonDefault     	= null;
		private bool?          	_isDeletedNonDefault     	= false;
		private DateTime?      	_deleteDateNonDefault    	= null;
		private int?           	_deletedByNonDefault     	= null;
		private DateTime?      	_invoiceDateNonDefault   	= null;

		private INVTakingInventoryLineBatchCollection _iNVTakingInventoryLineBatchCollectionTakingLineID = null;
		private PURPurchaseLineBatchCollection _pURPurchaseLineBatchCollectionPurchaseLineID = null;
		private PURPurchaseReturnLineCollection _pURPurchaseReturnLineCollectionOriginalpurchaseLineID = null;
		
		#endregion
		
		#region Constants
		
		#endregion
		
		#region Constructors / Destructors

		/// <summary>
		/// Class Constructor
		///</summary>
		public PURPurchaseLineBase() { }
					
		#endregion
		
		#region Properties

		/// <summary>
		/// Returns the identifier of the persistent object. Don't set it manually!
		/// </summary>
		public int? PurchaseLineID
		{
			get 
			{ 
				return _purchaseLineIDNonDefault;
			}
			set 
			{
			
				_purchaseLineIDNonDefault = value; 
			}
		}

		/// <summary>
		/// The foreign key connected with another persistent object.
		/// </summary>
		public int? PurchaseHeaderID
		{
			get 
			{ 
				return _purchaseHeaderIDNonDefault;
			}
			set 
			{
			
				_purchaseHeaderIDNonDefault = value; 
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
		/// This property is mapped to the "BonusQty" field.  Mandatory.
		/// </summary>
		public decimal? BonusQty
		{
			get 
			{ 
				return _bonusQtyNonDefault;
			}
			set 
			{
			
				_bonusQtyNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "DiscountRatio" field.  Mandatory.
		/// </summary>
		public decimal? DiscountRatio
		{
			get 
			{ 
				return _discountRatioNonDefault;
			}
			set 
			{
			
				_discountRatioNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "DiscountAmount" field.  Mandatory.
		/// </summary>
		public decimal? DiscountAmount
		{
			get 
			{ 
				return _discountAmountNonDefault;
			}
			set 
			{
			
				_discountAmountNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "Unitprice" field.  Mandatory.
		/// </summary>
		public decimal? Unitprice
		{
			get 
			{ 
				return _unitpriceNonDefault;
			}
			set 
			{
			
				_unitpriceNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "CreatedDate" field.  
		/// </summary>
		public DateTime? CreatedDate
		{
			get 
			{ 
				return _createdDateNonDefault;
			}
			set 
			{
			
				_createdDateNonDefault = value; 
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
		/// Provides access to the related table 'INVTakingInventoryLineBatch'
		/// </summary>
		public INVTakingInventoryLineBatchCollection INVTakingInventoryLineBatchCollectionUsingTakingLineID
		{
			get 
			{
				if (_iNVTakingInventoryLineBatchCollectionTakingLineID == null)
				{
					_iNVTakingInventoryLineBatchCollectionTakingLineID = new INVTakingInventoryLineBatchCollection();
					_iNVTakingInventoryLineBatchCollectionTakingLineID = INVTakingInventoryLineBatch.SelectByField("TakingLineID",PurchaseLineID, null, TypeOperation.Equal);
				}                
				return _iNVTakingInventoryLineBatchCollectionTakingLineID; 
			}
			set 
			{
				  _iNVTakingInventoryLineBatchCollectionTakingLineID = value;
			}
		}

		/// <summary>
		/// Provides access to the related table 'PURPurchaseLineBatch'
		/// </summary>
		public PURPurchaseLineBatchCollection PURPurchaseLineBatchCollectionUsingPurchaseLineID
		{
			get 
			{
				if (_pURPurchaseLineBatchCollectionPurchaseLineID == null)
				{
					_pURPurchaseLineBatchCollectionPurchaseLineID = new PURPurchaseLineBatchCollection();
					_pURPurchaseLineBatchCollectionPurchaseLineID = PURPurchaseLineBatch.SelectByField("PurchaseLineID",PurchaseLineID, null, TypeOperation.Equal);
				}                
				return _pURPurchaseLineBatchCollectionPurchaseLineID; 
			}
			set 
			{
				  _pURPurchaseLineBatchCollectionPurchaseLineID = value;
			}
		}

		/// <summary>
		/// Provides access to the related table 'PURPurchaseReturnLine'
		/// </summary>
		public PURPurchaseReturnLineCollection PURPurchaseReturnLineCollectionUsingOriginalpurchaseLineID
		{
			get 
			{
				if (_pURPurchaseReturnLineCollectionOriginalpurchaseLineID == null)
				{
					_pURPurchaseReturnLineCollectionOriginalpurchaseLineID = new PURPurchaseReturnLineCollection();
					_pURPurchaseReturnLineCollectionOriginalpurchaseLineID = PURPurchaseReturnLine.SelectByField("OriginalpurchaseLineID",PurchaseLineID, null, TypeOperation.Equal);
				}                
				return _pURPurchaseReturnLineCollectionOriginalpurchaseLineID; 
			}
			set 
			{
				  _pURPurchaseReturnLineCollectionOriginalpurchaseLineID = value;
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
		/// DLGenerator			2/24/2015 10:40:54 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool InsertWithDefaultValues(bool getBackValues) 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_purchaseHeaderID' as parameter 'PurchaseHeaderID' of the stored procedure.
			if(_purchaseHeaderIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@PurchaseHeaderID", _purchaseHeaderIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@PurchaseHeaderID", DBNull.Value );
			  
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
			  
			// Pass the value of '_bonusQty' as parameter 'BonusQty' of the stored procedure.
			if(_bonusQtyNonDefault!=null)
			  oDatabaseHelper.AddParameter("@BonusQty", _bonusQtyNonDefault);
			else
			  oDatabaseHelper.AddParameter("@BonusQty", DBNull.Value );
			  
			// Pass the value of '_discountRatio' as parameter 'DiscountRatio' of the stored procedure.
			if(_discountRatioNonDefault!=null)
			  oDatabaseHelper.AddParameter("@DiscountRatio", _discountRatioNonDefault);
			else
			  oDatabaseHelper.AddParameter("@DiscountRatio", DBNull.Value );
			  
			// Pass the value of '_discountAmount' as parameter 'DiscountAmount' of the stored procedure.
			if(_discountAmountNonDefault!=null)
			  oDatabaseHelper.AddParameter("@DiscountAmount", _discountAmountNonDefault);
			else
			  oDatabaseHelper.AddParameter("@DiscountAmount", DBNull.Value );
			  
			// Pass the value of '_unitprice' as parameter 'Unitprice' of the stored procedure.
			if(_unitpriceNonDefault!=null)
			  oDatabaseHelper.AddParameter("@Unitprice", _unitpriceNonDefault);
			else
			  oDatabaseHelper.AddParameter("@Unitprice", DBNull.Value );
			  
			// Pass the value of '_createdDate' as parameter 'CreatedDate' of the stored procedure.
			if(_createdDateNonDefault!=null)
			  oDatabaseHelper.AddParameter("@CreatedDate", _createdDateNonDefault);
			else
			  oDatabaseHelper.AddParameter("@CreatedDate", DBNull.Value );
			  
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
			  
			// Pass the value of '_invoiceDate' as parameter 'InvoiceDate' of the stored procedure.
			if(_invoiceDateNonDefault!=null)
			  oDatabaseHelper.AddParameter("@InvoiceDate", _invoiceDateNonDefault);
			else
			  oDatabaseHelper.AddParameter("@InvoiceDate", DBNull.Value );
			  
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			if(!getBackValues )
			{
				oDatabaseHelper.ExecuteScalar("gsp_PURPurchaseLine_Insert_WithDefaultValues", ref ExecutionState);
			}
			else
			{
				IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseLine_Insert_WithDefaultValues_AndReturn", ref ExecutionState);
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
		/// DLGenerator			2/24/2015 10:40:54 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Insert() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_purchaseHeaderID' as parameter 'PurchaseHeaderID' of the stored procedure.
			if(_purchaseHeaderIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@PurchaseHeaderID", _purchaseHeaderIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@PurchaseHeaderID", DBNull.Value );
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
			// Pass the value of '_bonusQty' as parameter 'BonusQty' of the stored procedure.
			if(_bonusQtyNonDefault!=null)
			  oDatabaseHelper.AddParameter("@BonusQty", _bonusQtyNonDefault);
			else
			  oDatabaseHelper.AddParameter("@BonusQty", DBNull.Value );
			// Pass the value of '_discountRatio' as parameter 'DiscountRatio' of the stored procedure.
			if(_discountRatioNonDefault!=null)
			  oDatabaseHelper.AddParameter("@DiscountRatio", _discountRatioNonDefault);
			else
			  oDatabaseHelper.AddParameter("@DiscountRatio", DBNull.Value );
			// Pass the value of '_discountAmount' as parameter 'DiscountAmount' of the stored procedure.
			if(_discountAmountNonDefault!=null)
			  oDatabaseHelper.AddParameter("@DiscountAmount", _discountAmountNonDefault);
			else
			  oDatabaseHelper.AddParameter("@DiscountAmount", DBNull.Value );
			// Pass the value of '_unitprice' as parameter 'Unitprice' of the stored procedure.
			if(_unitpriceNonDefault!=null)
			  oDatabaseHelper.AddParameter("@Unitprice", _unitpriceNonDefault);
			else
			  oDatabaseHelper.AddParameter("@Unitprice", DBNull.Value );
			// Pass the value of '_createdDate' as parameter 'CreatedDate' of the stored procedure.
			if(_createdDateNonDefault!=null)
			  oDatabaseHelper.AddParameter("@CreatedDate", _createdDateNonDefault);
			else
			  oDatabaseHelper.AddParameter("@CreatedDate", DBNull.Value );
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
			// Pass the value of '_invoiceDate' as parameter 'InvoiceDate' of the stored procedure.
			if(_invoiceDateNonDefault!=null)
			  oDatabaseHelper.AddParameter("@InvoiceDate", _invoiceDateNonDefault);
			else
			  oDatabaseHelper.AddParameter("@InvoiceDate", DBNull.Value );
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_PURPurchaseLine_Insert", ref ExecutionState);
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
		/// DLGenerator			2/24/2015 10:40:54 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Update() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_purchaseLineID' as parameter 'PurchaseLineID' of the stored procedure.
			oDatabaseHelper.AddParameter("@PurchaseLineID", _purchaseLineIDNonDefault );
			
			// Pass the value of '_purchaseHeaderID' as parameter 'PurchaseHeaderID' of the stored procedure.
			oDatabaseHelper.AddParameter("@PurchaseHeaderID", _purchaseHeaderIDNonDefault );
			
			// Pass the value of '_productID' as parameter 'ProductID' of the stored procedure.
			oDatabaseHelper.AddParameter("@ProductID", _productIDNonDefault );
			
			// Pass the value of '_totalQty' as parameter 'TotalQty' of the stored procedure.
			oDatabaseHelper.AddParameter("@TotalQty", _totalQtyNonDefault );
			
			// Pass the value of '_bonusQty' as parameter 'BonusQty' of the stored procedure.
			oDatabaseHelper.AddParameter("@BonusQty", _bonusQtyNonDefault );
			
			// Pass the value of '_discountRatio' as parameter 'DiscountRatio' of the stored procedure.
			oDatabaseHelper.AddParameter("@DiscountRatio", _discountRatioNonDefault );
			
			// Pass the value of '_discountAmount' as parameter 'DiscountAmount' of the stored procedure.
			oDatabaseHelper.AddParameter("@DiscountAmount", _discountAmountNonDefault );
			
			// Pass the value of '_unitprice' as parameter 'Unitprice' of the stored procedure.
			oDatabaseHelper.AddParameter("@Unitprice", _unitpriceNonDefault );
			
			// Pass the value of '_createdDate' as parameter 'CreatedDate' of the stored procedure.
			oDatabaseHelper.AddParameter("@CreatedDate", _createdDateNonDefault );
			
			// Pass the value of '_createdBy' as parameter 'CreatedBy' of the stored procedure.
			oDatabaseHelper.AddParameter("@CreatedBy", _createdByNonDefault );
			
			// Pass the value of '_updateDate' as parameter 'UpdateDate' of the stored procedure.
			oDatabaseHelper.AddParameter("@UpdateDate", _updateDateNonDefault );
			
			// Pass the value of '_updatedBy' as parameter 'UpdatedBy' of the stored procedure.
			oDatabaseHelper.AddParameter("@UpdatedBy", _updatedByNonDefault );
			
			// Pass the value of '_isDeleted' as parameter 'IsDeleted' of the stored procedure.
			oDatabaseHelper.AddParameter("@IsDeleted", _isDeletedNonDefault );
			
			// Pass the value of '_deleteDate' as parameter 'DeleteDate' of the stored procedure.
			oDatabaseHelper.AddParameter("@DeleteDate", _deleteDateNonDefault );
			
			// Pass the value of '_deletedBy' as parameter 'DeletedBy' of the stored procedure.
			oDatabaseHelper.AddParameter("@DeletedBy", _deletedByNonDefault );
			
			// Pass the value of '_invoiceDate' as parameter 'InvoiceDate' of the stored procedure.
			oDatabaseHelper.AddParameter("@InvoiceDate", _invoiceDateNonDefault );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_PURPurchaseLine_Update", ref ExecutionState);
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
		/// DLGenerator			2/24/2015 10:40:54 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Delete() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_purchaseLineID' as parameter 'PurchaseLineID' of the stored procedure.
			if(_purchaseLineIDNonDefault!=null)
				oDatabaseHelper.AddParameter("@PurchaseLineID", _purchaseLineIDNonDefault );
			else
				oDatabaseHelper.AddParameter("@PurchaseLineID", DBNull.Value );
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_PURPurchaseLine_Delete", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will Delete one row from the database using the primary key information
		/// </summary>
		///
		/// <param name="pk" type="PURPurchaseLinePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>True if succeeded</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/24/2015 10:40:54 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static bool Delete(PURPurchaseLinePrimaryKey pk) 
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
   
			oDatabaseHelper.ExecuteScalar("gsp_PURPurchaseLine_Delete", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="PURPurchaseLineFields">Field of the class PURPurchaseLine</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		///
		/// <returns>True if succeeded</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/24/2015 10:40:54 AM		Created function
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
			
			oDatabaseHelper.ExecuteScalar("gsp_PURPurchaseLine_DeleteByField", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="PURPurchaseLinePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class PURPurchaseLine</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/24/2015 10:40:54 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static PURPurchaseLine SelectOne(PURPurchaseLinePrimaryKey pk)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseLine_SelectbyPrimaryKey", ref ExecutionState);
			if (dr.Read())
			{
				PURPurchaseLine obj=new PURPurchaseLine();	
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
		/// <returns>list of objects of class PURPurchaseLine in the form of object of PURPurchaseLineCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/24/2015 10:40:54 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static PURPurchaseLineCollection SelectAll()
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseLine_SelectAll", ref ExecutionState);
			PURPurchaseLineCollection PURPurchaseLineCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return PURPurchaseLineCollection;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class PURPurchaseLine</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class PURPurchaseLine in the form of an object of class PURPurchaseLineCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/24/2015 10:40:54 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static PURPurchaseLineCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseLine_SelectByField", ref ExecutionState);
			PURPurchaseLineCollection PURPurchaseLineCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return PURPurchaseLineCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number</param>
		///
		/// <returns>list of objects of class PURPurchaseLine in the form of object of PURPurchaseLineCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/24/2015 10:40:54 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static PURPurchaseLineCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// Pass the specified field and its value to the stored procedure.
			oDatabaseHelper.AddParameter("@PageSize",pageSize);
			oDatabaseHelper.AddParameter("@SkipPages", skipPages);
			oDatabaseHelper.AddParameter("@OrderByStatement", orderByStatement );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseLine_SelectAllPaged", ref ExecutionState);
			PURPurchaseLineCollection PURPurchaseLineCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return PURPurchaseLineCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class PURPurchaseLine</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class PURPurchaseLine in the form of an object of class PURPurchaseLineCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/24/2015 10:40:54 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static PURPurchaseLineCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseLine_SelectByFieldPaged", ref ExecutionState);
			PURPurchaseLineCollection PURPurchaseLineCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return PURPurchaseLineCollection;
			
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
		/// DLGenerator			2/24/2015 10:40:54 AM		Created function
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
			
			Object dr=oDatabaseHelper.ExecuteScalar("gsp_PURPurchaseLine_SelectAllCount");
			int count = Convert.ToInt32(dr);		
			oDatabaseHelper.Dispose();
			return count;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="PURPurchaseLinePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class PURPurchaseLine</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/24/2015 10:40:54 AM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static PURPurchaseLine SelectOneWithINVTakingInventoryLineBatchUsingTakingLineID(PURPurchaseLinePrimaryKey pk)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			PURPurchaseLine obj=null;
			
			// Pass the values of all key parameters to the stored procedure.
			System.Collections.Specialized.NameValueCollection nvc = pk.GetKeysAndValues();
			foreach (string key in nvc.Keys)
			{
				oDatabaseHelper.AddParameter("@" + key,nvc[key] );
			}
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseLine_SelectOneWithINVTakingInventoryLineBatchUsingTakingLineID", ref ExecutionState);
			if (dr.Read())
			{
				obj= new PURPurchaseLine();
				PopulateObjectFromReader(obj,dr);
				
				dr.NextResult();
				
				//Get the child records.
				obj.INVTakingInventoryLineBatchCollectionUsingTakingLineID=INVTakingInventoryLineBatch.PopulateObjectsFromReader(dr);
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
		/// <param name="pk" type="PURPurchaseLinePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class PURPurchaseLine</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/24/2015 10:40:54 AM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static PURPurchaseLine SelectOneWithPURPurchaseLineBatchUsingPurchaseLineID(PURPurchaseLinePrimaryKey pk)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			PURPurchaseLine obj=null;
			
			// Pass the values of all key parameters to the stored procedure.
			System.Collections.Specialized.NameValueCollection nvc = pk.GetKeysAndValues();
			foreach (string key in nvc.Keys)
			{
				oDatabaseHelper.AddParameter("@" + key,nvc[key] );
			}
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseLine_SelectOneWithPURPurchaseLineBatchUsingPurchaseLineID", ref ExecutionState);
			if (dr.Read())
			{
				obj= new PURPurchaseLine();
				PopulateObjectFromReader(obj,dr);
				
				dr.NextResult();
				
				//Get the child records.
				obj.PURPurchaseLineBatchCollectionUsingPurchaseLineID=PURPurchaseLineBatch.PopulateObjectsFromReader(dr);
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
		/// <param name="pk" type="PURPurchaseLinePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class PURPurchaseLine</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/24/2015 10:40:54 AM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static PURPurchaseLine SelectOneWithPURPurchaseReturnLineUsingOriginalpurchaseLineID(PURPurchaseLinePrimaryKey pk)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			PURPurchaseLine obj=null;
			
			// Pass the values of all key parameters to the stored procedure.
			System.Collections.Specialized.NameValueCollection nvc = pk.GetKeysAndValues();
			foreach (string key in nvc.Keys)
			{
				oDatabaseHelper.AddParameter("@" + key,nvc[key] );
			}
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseLine_SelectOneWithPURPurchaseReturnLineUsingOriginalpurchaseLineID", ref ExecutionState);
			if (dr.Read())
			{
				obj= new PURPurchaseLine();
				PopulateObjectFromReader(obj,dr);
				
				dr.NextResult();
				
				//Get the child records.
				obj.PURPurchaseReturnLineCollectionUsingOriginalpurchaseLineID=PURPurchaseReturnLine.PopulateObjectsFromReader(dr);
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
		/// <param name="pk" type="BDProductPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class PURPurchaseLineCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/24/2015 10:40:54 AM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static PURPurchaseLineCollection SelectAllByForeignKeyProductID(BDProductPrimaryKey pk)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			PURPurchaseLineCollection obj = null;
			
			// Pass the values of all key parameters to the stored procedure.
			System.Collections.Specialized.NameValueCollection nvc = pk.GetKeysAndValues();
			foreach (string key in nvc.Keys)
			{
				oDatabaseHelper.AddParameter("@" + key,nvc[key] );
			}
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseLine_SelectAllByForeignKeyProductID", ref ExecutionState);
			obj = new PURPurchaseLineCollection();
			obj = PURPurchaseLine.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
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
		/// <returns>object of class PURPurchaseLineCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/24/2015 10:40:54 AM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static PURPurchaseLineCollection SelectAllByForeignKeyProductIDPaged(BDProductPrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			PURPurchaseLineCollection obj = null;
			
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseLine_SelectAllByForeignKeyProductIDPaged", ref ExecutionState);
			obj = new PURPurchaseLineCollection();
			obj = PURPurchaseLine.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
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
		/// DLGenerator			2/24/2015 10:40:54 AM				Created function
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
			
			oDatabaseHelper.ExecuteNonQuery("gsp_PURPurchaseLine_DeleteAllByForeignKeyProductID", ref ExecutionState);
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
		/// <returns>object of class PURPurchaseLineCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/24/2015 10:40:54 AM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static PURPurchaseLineCollection SelectAllByForeignKeyPurchaseHeaderID(PURPurchaseHeaderPrimaryKey pk)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			PURPurchaseLineCollection obj = null;
			
			// Pass the values of all key parameters to the stored procedure.
			System.Collections.Specialized.NameValueCollection nvc = pk.GetKeysAndValues();
			foreach (string key in nvc.Keys)
			{
				oDatabaseHelper.AddParameter("@" + key,nvc[key] );
			}
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseLine_SelectAllByForeignKeyPurchaseHeaderID", ref ExecutionState);
			obj = new PURPurchaseLineCollection();
			obj = PURPurchaseLine.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
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
		/// <returns>object of class PURPurchaseLineCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/24/2015 10:40:54 AM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static PURPurchaseLineCollection SelectAllByForeignKeyPurchaseHeaderIDPaged(PURPurchaseHeaderPrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			PURPurchaseLineCollection obj = null;
			
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseLine_SelectAllByForeignKeyPurchaseHeaderIDPaged", ref ExecutionState);
			obj = new PURPurchaseLineCollection();
			obj = PURPurchaseLine.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
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
		/// DLGenerator			2/24/2015 10:40:54 AM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static bool DeleteAllByForeignKeyPurchaseHeaderID(PURPurchaseHeaderPrimaryKey pk)
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
			
			oDatabaseHelper.ExecuteNonQuery("gsp_PURPurchaseLine_DeleteAllByForeignKeyPurchaseHeaderID", ref ExecutionState);
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
		/// DLGenerator			2/24/2015 10:40:54 AM		Created function
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
		/// <param name="obj" type="PURPurchaseLine">Object of PURPurchaseLine to populate</param>
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/24/2015 10:40:54 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static void PopulateObjectFromReader(PURPurchaseLineBase obj,IDataReader rdr) 
		{

			obj.PurchaseLineID = rdr.GetInt32(rdr.GetOrdinal(PURPurchaseLineFields.PurchaseLineID));
			obj.PurchaseHeaderID = rdr.GetInt32(rdr.GetOrdinal(PURPurchaseLineFields.PurchaseHeaderID));
			obj.ProductID = rdr.GetInt32(rdr.GetOrdinal(PURPurchaseLineFields.ProductID));
			obj.TotalQty = rdr.GetDecimal(rdr.GetOrdinal(PURPurchaseLineFields.TotalQty));
			obj.BonusQty = rdr.GetDecimal(rdr.GetOrdinal(PURPurchaseLineFields.BonusQty));
			obj.DiscountRatio = rdr.GetDecimal(rdr.GetOrdinal(PURPurchaseLineFields.DiscountRatio));
			obj.DiscountAmount = rdr.GetDecimal(rdr.GetOrdinal(PURPurchaseLineFields.DiscountAmount));
			obj.Unitprice = rdr.GetDecimal(rdr.GetOrdinal(PURPurchaseLineFields.Unitprice));
			if (!rdr.IsDBNull(rdr.GetOrdinal(PURPurchaseLineFields.CreatedDate)))
			{
				obj.CreatedDate = rdr.GetDateTime(rdr.GetOrdinal(PURPurchaseLineFields.CreatedDate));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(PURPurchaseLineFields.CreatedBy)))
			{
				obj.CreatedBy = rdr.GetInt32(rdr.GetOrdinal(PURPurchaseLineFields.CreatedBy));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(PURPurchaseLineFields.UpdateDate)))
			{
				obj.UpdateDate = rdr.GetDateTime(rdr.GetOrdinal(PURPurchaseLineFields.UpdateDate));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(PURPurchaseLineFields.UpdatedBy)))
			{
				obj.UpdatedBy = rdr.GetInt32(rdr.GetOrdinal(PURPurchaseLineFields.UpdatedBy));
			}
			
			obj.IsDeleted = rdr.GetBoolean(rdr.GetOrdinal(PURPurchaseLineFields.IsDeleted));
			if (!rdr.IsDBNull(rdr.GetOrdinal(PURPurchaseLineFields.DeleteDate)))
			{
				obj.DeleteDate = rdr.GetDateTime(rdr.GetOrdinal(PURPurchaseLineFields.DeleteDate));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(PURPurchaseLineFields.DeletedBy)))
			{
				obj.DeletedBy = rdr.GetInt32(rdr.GetOrdinal(PURPurchaseLineFields.DeletedBy));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(PURPurchaseLineFields.InvoiceDate)))
			{
				obj.InvoiceDate = rdr.GetDateTime(rdr.GetOrdinal(PURPurchaseLineFields.InvoiceDate));
			}
			

		}

		/// <summary>
		/// Populates the fields for multiple objects from the columns found in an open reader.
		/// </summary>
		///
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <returns>Object of PURPurchaseLineCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/24/2015 10:40:54 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static PURPurchaseLineCollection PopulateObjectsFromReader(IDataReader rdr) 
		{
			PURPurchaseLineCollection list = new PURPurchaseLineCollection();
			
			while (rdr.Read())
			{
				PURPurchaseLine obj = new PURPurchaseLine();
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
		/// <returns>Object of PURPurchaseLineCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/24/2015 10:40:54 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static PURPurchaseLineCollection PopulateObjectsFromReaderWithCheckingReader(IDataReader rdr, DatabaseHelper oDatabaseHelper) 
		{

			PURPurchaseLineCollection list = new PURPurchaseLineCollection();
			
            if (rdr.Read())
			{
				PURPurchaseLine obj = new PURPurchaseLine();
				PopulateObjectFromReader(obj, rdr);
				list.Add(obj);
				while (rdr.Read())
				{
					obj = new PURPurchaseLine();
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
