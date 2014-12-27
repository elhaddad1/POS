//
// Class	:	SALSalesLineBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:56:03 PM
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
	public class SALSalesLineFields
	{
		public const string SalesLineID               = "SalesLineID";
		public const string SalesHeaderID             = "SalesHeaderID";
		public const string ProductID                 = "ProductID";
		public const string TotalQty                  = "TotalQty";
		public const string TotalBonus                = "TotalBonus";
		public const string DiscountAmount            = "DiscountAmount";
		public const string DiscountRatio             = "DiscountRatio";
		public const string UnitPrice                 = "UnitPrice";
		public const string CreatedBy                 = "CreatedBy";
		public const string CreateDate                = "CreateDate";
		public const string UpdatedBy                 = "UpdatedBy";
		public const string UpdateDate                = "UpdateDate";
		public const string IsDeleted                 = "IsDeleted";
		public const string DeletedBy                 = "DeletedBy";
		public const string DeleteDate                = "DeleteDate";
	}
	
	/// <summary>
	/// Data access class for the "SALSalesLine" table.
	/// </summary>
	[Serializable]
	public class SALSalesLineBase
	{
		
		#region Class Level Variables
		
		private DatabaseHelper oDatabaseHelper = new DatabaseHelper();

		private int?           	_salesLineIDNonDefault   	= null;
		private int?           	_salesHeaderIDNonDefault 	= null;
		private int?           	_productIDNonDefault     	= null;
		private decimal?       	_totalQtyNonDefault      	= 0;
		private decimal?       	_totalBonusNonDefault    	= 0;
		private decimal?       	_discountAmountNonDefault	= null;
		private decimal?       	_discountRatioNonDefault 	= 0;
		private decimal?       	_unitPriceNonDefault     	= 0;
		private int?           	_createdByNonDefault     	= null;
		private DateTime?      	_createDateNonDefault    	= null;
		private int?           	_updatedByNonDefault     	= null;
		private DateTime?      	_updateDateNonDefault    	= null;
		private bool?          	_isDeletedNonDefault     	= false;
		private int?           	_deletedByNonDefault     	= null;
		private DateTime?      	_deleteDateNonDefault    	= null;

		private SALSalesLineBatchCollection _sALSalesLineBatchCollectionSalesLineID = null;
		
		#endregion
		
		#region Constants
		
		#endregion
		
		#region Constructors / Destructors

		/// <summary>
		/// Class Constructor
		///</summary>
		public SALSalesLineBase() { }
					
		#endregion
		
		#region Properties

		/// <summary>
		/// Returns the identifier of the persistent object. Don't set it manually!
		/// </summary>
		public int? SalesLineID
		{
			get 
			{ 
				return _salesLineIDNonDefault;
			}
			set 
			{
			
				_salesLineIDNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "SalesHeaderID" field.  Mandatory.
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
		/// This property is mapped to the "TotalBonus" field.  Mandatory.
		/// </summary>
		public decimal? TotalBonus
		{
			get 
			{ 
				return _totalBonusNonDefault;
			}
			set 
			{
			
				_totalBonusNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "DiscountAmount" field.  
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
		/// This property is mapped to the "UnitPrice" field.  Mandatory.
		/// </summary>
		public decimal? UnitPrice
		{
			get 
			{ 
				return _unitPriceNonDefault;
			}
			set 
			{
			
				_unitPriceNonDefault = value; 
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
		/// Provides access to the related table 'SALSalesLineBatch'
		/// </summary>
		public SALSalesLineBatchCollection SALSalesLineBatchCollectionUsingSalesLineID
		{
			get 
			{
				if (_sALSalesLineBatchCollectionSalesLineID == null)
				{
					_sALSalesLineBatchCollectionSalesLineID = new SALSalesLineBatchCollection();
					_sALSalesLineBatchCollectionSalesLineID = SALSalesLineBatch.SelectByField("SalesLineID",SalesLineID, null, TypeOperation.Equal);
				}                
				return _sALSalesLineBatchCollectionSalesLineID; 
			}
			set 
			{
				  _sALSalesLineBatchCollectionSalesLineID = value;
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
		/// DLGenerator			12/27/2014 6:56:03 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool InsertWithDefaultValues(bool getBackValues) 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_salesHeaderID' as parameter 'SalesHeaderID' of the stored procedure.
			if(_salesHeaderIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@SalesHeaderID", _salesHeaderIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@SalesHeaderID", DBNull.Value );
			  
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
			  
			// Pass the value of '_totalBonus' as parameter 'TotalBonus' of the stored procedure.
			if(_totalBonusNonDefault!=null)
			  oDatabaseHelper.AddParameter("@TotalBonus", _totalBonusNonDefault);
			else
			  oDatabaseHelper.AddParameter("@TotalBonus", DBNull.Value );
			  
			// Pass the value of '_discountAmount' as parameter 'DiscountAmount' of the stored procedure.
			if(_discountAmountNonDefault!=null)
			  oDatabaseHelper.AddParameter("@DiscountAmount", _discountAmountNonDefault);
			else
			  oDatabaseHelper.AddParameter("@DiscountAmount", DBNull.Value );
			  
			// Pass the value of '_discountRatio' as parameter 'DiscountRatio' of the stored procedure.
			if(_discountRatioNonDefault!=null)
			  oDatabaseHelper.AddParameter("@DiscountRatio", _discountRatioNonDefault);
			else
			  oDatabaseHelper.AddParameter("@DiscountRatio", DBNull.Value );
			  
			// Pass the value of '_unitPrice' as parameter 'UnitPrice' of the stored procedure.
			if(_unitPriceNonDefault!=null)
			  oDatabaseHelper.AddParameter("@UnitPrice", _unitPriceNonDefault);
			else
			  oDatabaseHelper.AddParameter("@UnitPrice", DBNull.Value );
			  
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
			  
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			if(!getBackValues )
			{
				oDatabaseHelper.ExecuteScalar("gsp_SALSalesLine_Insert_WithDefaultValues", ref ExecutionState);
			}
			else
			{
				IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_SALSalesLine_Insert_WithDefaultValues_AndReturn", ref ExecutionState);
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
		/// DLGenerator			12/27/2014 6:56:03 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Insert() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_salesHeaderID' as parameter 'SalesHeaderID' of the stored procedure.
			if(_salesHeaderIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@SalesHeaderID", _salesHeaderIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@SalesHeaderID", DBNull.Value );
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
			// Pass the value of '_totalBonus' as parameter 'TotalBonus' of the stored procedure.
			if(_totalBonusNonDefault!=null)
			  oDatabaseHelper.AddParameter("@TotalBonus", _totalBonusNonDefault);
			else
			  oDatabaseHelper.AddParameter("@TotalBonus", DBNull.Value );
			// Pass the value of '_discountAmount' as parameter 'DiscountAmount' of the stored procedure.
			if(_discountAmountNonDefault!=null)
			  oDatabaseHelper.AddParameter("@DiscountAmount", _discountAmountNonDefault);
			else
			  oDatabaseHelper.AddParameter("@DiscountAmount", DBNull.Value );
			// Pass the value of '_discountRatio' as parameter 'DiscountRatio' of the stored procedure.
			if(_discountRatioNonDefault!=null)
			  oDatabaseHelper.AddParameter("@DiscountRatio", _discountRatioNonDefault);
			else
			  oDatabaseHelper.AddParameter("@DiscountRatio", DBNull.Value );
			// Pass the value of '_unitPrice' as parameter 'UnitPrice' of the stored procedure.
			if(_unitPriceNonDefault!=null)
			  oDatabaseHelper.AddParameter("@UnitPrice", _unitPriceNonDefault);
			else
			  oDatabaseHelper.AddParameter("@UnitPrice", DBNull.Value );
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
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_SALSalesLine_Insert", ref ExecutionState);
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
		/// DLGenerator			12/27/2014 6:56:03 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Update() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_salesLineID' as parameter 'SalesLineID' of the stored procedure.
			oDatabaseHelper.AddParameter("@SalesLineID", _salesLineIDNonDefault );
			
			// Pass the value of '_salesHeaderID' as parameter 'SalesHeaderID' of the stored procedure.
			oDatabaseHelper.AddParameter("@SalesHeaderID", _salesHeaderIDNonDefault );
			
			// Pass the value of '_productID' as parameter 'ProductID' of the stored procedure.
			oDatabaseHelper.AddParameter("@ProductID", _productIDNonDefault );
			
			// Pass the value of '_totalQty' as parameter 'TotalQty' of the stored procedure.
			oDatabaseHelper.AddParameter("@TotalQty", _totalQtyNonDefault );
			
			// Pass the value of '_totalBonus' as parameter 'TotalBonus' of the stored procedure.
			oDatabaseHelper.AddParameter("@TotalBonus", _totalBonusNonDefault );
			
			// Pass the value of '_discountAmount' as parameter 'DiscountAmount' of the stored procedure.
			oDatabaseHelper.AddParameter("@DiscountAmount", _discountAmountNonDefault );
			
			// Pass the value of '_discountRatio' as parameter 'DiscountRatio' of the stored procedure.
			oDatabaseHelper.AddParameter("@DiscountRatio", _discountRatioNonDefault );
			
			// Pass the value of '_unitPrice' as parameter 'UnitPrice' of the stored procedure.
			oDatabaseHelper.AddParameter("@UnitPrice", _unitPriceNonDefault );
			
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
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_SALSalesLine_Update", ref ExecutionState);
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
		/// DLGenerator			12/27/2014 6:56:03 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Delete() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_salesLineID' as parameter 'SalesLineID' of the stored procedure.
			if(_salesLineIDNonDefault!=null)
				oDatabaseHelper.AddParameter("@SalesLineID", _salesLineIDNonDefault );
			else
				oDatabaseHelper.AddParameter("@SalesLineID", DBNull.Value );
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_SALSalesLine_Delete", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will Delete one row from the database using the primary key information
		/// </summary>
		///
		/// <param name="pk" type="SALSalesLinePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>True if succeeded</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:03 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static bool Delete(SALSalesLinePrimaryKey pk) 
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
   
			oDatabaseHelper.ExecuteScalar("gsp_SALSalesLine_Delete", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="SALSalesLineFields">Field of the class SALSalesLine</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		///
		/// <returns>True if succeeded</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:03 PM		Created function
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
			
			oDatabaseHelper.ExecuteScalar("gsp_SALSalesLine_DeleteByField", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="SALSalesLinePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class SALSalesLine</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:03 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static SALSalesLine SelectOne(SALSalesLinePrimaryKey pk)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_SALSalesLine_SelectbyPrimaryKey", ref ExecutionState);
			if (dr.Read())
			{
				SALSalesLine obj=new SALSalesLine();	
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
		/// <returns>list of objects of class SALSalesLine in the form of object of SALSalesLineCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:03 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static SALSalesLineCollection SelectAll()
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_SALSalesLine_SelectAll", ref ExecutionState);
			SALSalesLineCollection SALSalesLineCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return SALSalesLineCollection;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class SALSalesLine</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class SALSalesLine in the form of an object of class SALSalesLineCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:03 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static SALSalesLineCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_SALSalesLine_SelectByField", ref ExecutionState);
			SALSalesLineCollection SALSalesLineCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return SALSalesLineCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number</param>
		///
		/// <returns>list of objects of class SALSalesLine in the form of object of SALSalesLineCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:03 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static SALSalesLineCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// Pass the specified field and its value to the stored procedure.
			oDatabaseHelper.AddParameter("@PageSize",pageSize);
			oDatabaseHelper.AddParameter("@SkipPages", skipPages);
			oDatabaseHelper.AddParameter("@OrderByStatement", orderByStatement );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_SALSalesLine_SelectAllPaged", ref ExecutionState);
			SALSalesLineCollection SALSalesLineCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return SALSalesLineCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class SALSalesLine</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class SALSalesLine in the form of an object of class SALSalesLineCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:03 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static SALSalesLineCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_SALSalesLine_SelectByFieldPaged", ref ExecutionState);
			SALSalesLineCollection SALSalesLineCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return SALSalesLineCollection;
			
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
		/// DLGenerator			12/27/2014 6:56:03 PM		Created function
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
			
			Object dr=oDatabaseHelper.ExecuteScalar("gsp_SALSalesLine_SelectAllCount");
			int count = Convert.ToInt32(dr);		
			oDatabaseHelper.Dispose();
			return count;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="SALSalesLinePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class SALSalesLine</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:03 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static SALSalesLine SelectOneWithSALSalesLineBatchUsingSalesLineID(SALSalesLinePrimaryKey pk)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			SALSalesLine obj=null;
			
			// Pass the values of all key parameters to the stored procedure.
			System.Collections.Specialized.NameValueCollection nvc = pk.GetKeysAndValues();
			foreach (string key in nvc.Keys)
			{
				oDatabaseHelper.AddParameter("@" + key,nvc[key] );
			}
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_SALSalesLine_SelectOneWithSALSalesLineBatchUsingSalesLineID", ref ExecutionState);
			if (dr.Read())
			{
				obj= new SALSalesLine();
				PopulateObjectFromReader(obj,dr);
				
				dr.NextResult();
				
				//Get the child records.
				obj.SALSalesLineBatchCollectionUsingSalesLineID=SALSalesLineBatch.PopulateObjectsFromReader(dr);
			}
			dr.Close();  
			oDatabaseHelper.Dispose();
			return obj;
			
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
		/// DLGenerator			12/27/2014 6:56:03 PM		Created function
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
		/// <param name="obj" type="SALSalesLine">Object of SALSalesLine to populate</param>
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:03 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static void PopulateObjectFromReader(SALSalesLineBase obj,IDataReader rdr) 
		{

			obj.SalesLineID = rdr.GetInt32(rdr.GetOrdinal(SALSalesLineFields.SalesLineID));
			obj.SalesHeaderID = rdr.GetInt32(rdr.GetOrdinal(SALSalesLineFields.SalesHeaderID));
			obj.ProductID = rdr.GetInt32(rdr.GetOrdinal(SALSalesLineFields.ProductID));
			obj.TotalQty = rdr.GetDecimal(rdr.GetOrdinal(SALSalesLineFields.TotalQty));
			obj.TotalBonus = rdr.GetDecimal(rdr.GetOrdinal(SALSalesLineFields.TotalBonus));
			if (!rdr.IsDBNull(rdr.GetOrdinal(SALSalesLineFields.DiscountAmount)))
			{
				obj.DiscountAmount = rdr.GetDecimal(rdr.GetOrdinal(SALSalesLineFields.DiscountAmount));
			}
			
			obj.DiscountRatio = rdr.GetDecimal(rdr.GetOrdinal(SALSalesLineFields.DiscountRatio));
			obj.UnitPrice = rdr.GetDecimal(rdr.GetOrdinal(SALSalesLineFields.UnitPrice));
			if (!rdr.IsDBNull(rdr.GetOrdinal(SALSalesLineFields.CreatedBy)))
			{
				obj.CreatedBy = rdr.GetInt32(rdr.GetOrdinal(SALSalesLineFields.CreatedBy));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(SALSalesLineFields.CreateDate)))
			{
				obj.CreateDate = rdr.GetDateTime(rdr.GetOrdinal(SALSalesLineFields.CreateDate));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(SALSalesLineFields.UpdatedBy)))
			{
				obj.UpdatedBy = rdr.GetInt32(rdr.GetOrdinal(SALSalesLineFields.UpdatedBy));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(SALSalesLineFields.UpdateDate)))
			{
				obj.UpdateDate = rdr.GetDateTime(rdr.GetOrdinal(SALSalesLineFields.UpdateDate));
			}
			
			obj.IsDeleted = rdr.GetBoolean(rdr.GetOrdinal(SALSalesLineFields.IsDeleted));
			if (!rdr.IsDBNull(rdr.GetOrdinal(SALSalesLineFields.DeletedBy)))
			{
				obj.DeletedBy = rdr.GetInt32(rdr.GetOrdinal(SALSalesLineFields.DeletedBy));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(SALSalesLineFields.DeleteDate)))
			{
				obj.DeleteDate = rdr.GetDateTime(rdr.GetOrdinal(SALSalesLineFields.DeleteDate));
			}
			

		}

		/// <summary>
		/// Populates the fields for multiple objects from the columns found in an open reader.
		/// </summary>
		///
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <returns>Object of SALSalesLineCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:03 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static SALSalesLineCollection PopulateObjectsFromReader(IDataReader rdr) 
		{
			SALSalesLineCollection list = new SALSalesLineCollection();
			
			while (rdr.Read())
			{
				SALSalesLine obj = new SALSalesLine();
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
		/// <returns>Object of SALSalesLineCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:56:03 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static SALSalesLineCollection PopulateObjectsFromReaderWithCheckingReader(IDataReader rdr, DatabaseHelper oDatabaseHelper) 
		{

			SALSalesLineCollection list = new SALSalesLineCollection();
			
            if (rdr.Read())
			{
				SALSalesLine obj = new SALSalesLine();
				PopulateObjectFromReader(obj, rdr);
				list.Add(obj);
				while (rdr.Read())
				{
					obj = new SALSalesLine();
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
