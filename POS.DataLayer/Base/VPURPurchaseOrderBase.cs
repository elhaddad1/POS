//
// Class	:	VPURPurchaseOrderBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	11/4/2015 9:57:47 PM
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
	public class VPURPurchaseOrderFields
	{
		public const string SupplierID                = "SupplierID";
		public const string SupplierName              = "SupplierName";
		public const string Qty                       = "Qty";
		public const string PurchaseLineID            = "PurchaseLineID";
		public const string TotalQty                  = "TotalQty";
		public const string UnitPrice                 = "UnitPrice";
		public const string BatchNumber               = "BatchNumber";
		public const string ExpiryDate                = "ExpiryDate";
		public const string TaxValue                  = "TaxValue";
		public const string PurcaseHeaderID           = "PurcaseHeaderID";
		public const string PurchaseDate              = "PurchaseDate";
		public const string InvoiceNumber             = "InvoiceNumber";
		public const string InvoiceDate               = "InvoiceDate";
		public const string PaymentTypeID             = "PaymentTypeID";
		public const string TotalDiscountRatio        = "TotalDiscountRatio";
		public const string TaxTypeName               = "TaxTypeName";
		public const string IsClosed                  = "IsClosed";
		public const string IsVoid                    = "IsVoid";
		public const string ChequeNumber              = "ChequeNumber";
		public const string ProductName               = "ProductName";
		public const string ProductCode               = "ProductCode";
		public const string IsAcceptBatch             = "IsAcceptBatch";
		public const string UserFullName              = "UserFullName";
		public const string ProductID                 = "ProductID";
	}
	
	/// <summary>
	/// Data access class for the "VPURPurchaseOrder" table.
	/// </summary>
	[Serializable]
	public class VPURPurchaseOrderBase
	{
		
		#region Class Level Variables
		
		private DatabaseHelper oDatabaseHelper = new DatabaseHelper();

		private int?           	_supplierIDNonDefault    	= null;
		private string         	_supplierNameNonDefault  	= null;
		private decimal?       	_qtyNonDefault           	= null;
		private int?           	_purchaseLineIDNonDefault	= null;
		private decimal?       	_totalQtyNonDefault      	= null;
		private decimal?       	_unitPriceNonDefault     	= null;
		private string         	_batchNumberNonDefault   	= null;
		private DateTime?      	_expiryDateNonDefault    	= null;
		private decimal?       	_taxValueNonDefault      	= null;
		private int?           	_purcaseHeaderIDNonDefault	= null;
		private DateTime?      	_purchaseDateNonDefault  	= null;
		private string         	_invoiceNumberNonDefault 	= null;
		private DateTime?      	_invoiceDateNonDefault   	= null;
		private int?           	_paymentTypeIDNonDefault 	= null;
		private double?        	_totalDiscountRatioNonDefault	= null;
		private string         	_taxTypeNameNonDefault   	= null;
		private bool?          	_isClosedNonDefault      	= null;
		private bool?          	_isVoidNonDefault        	= null;
		private decimal?       	_chequeNumberNonDefault  	= null;
		private string         	_productNameNonDefault   	= null;
		private string         	_productCodeNonDefault   	= null;
		private bool?          	_isAcceptBatchNonDefault 	= null;
		private string         	_userFullNameNonDefault  	= null;
		private int?           	_productIDNonDefault     	= null;
		
		#endregion
		
		#region Constants
		
		#endregion
		
		#region Constructors / Destructors

		/// <summary>
		/// Class Constructor
		///</summary>
		public VPURPurchaseOrderBase() { }
					
		#endregion
		
		#region Properties

		/// <summary>
		/// Returns the identifier of the persistent object. Mandatory.
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
		/// This property is mapped to the "SupplierName" field. Length must be between 0 and 255 characters. Mandatory.
		/// </summary>
		public string SupplierName
		{
			get 
			{ 
				if(_supplierNameNonDefault==null)return _supplierNameNonDefault;
				else return _supplierNameNonDefault.Trim(); 
			}
			set 
			{
			    if (value == null)
					throw new ArgumentNullException("value", "Value is null.");
				   if (value != null && value.Length > 255)
					throw new ArgumentException("SupplierName length must be between 0 and 255 characters.");

				
				if(value ==null)
				{
					_supplierNameNonDefault =null;//null value 
				}
				else
				{		           
					_supplierNameNonDefault = value.Trim(); 
				}
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
		/// Returns the identifier of the persistent object. Mandatory.
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
		/// This property is mapped to the "BatchNumber" field. Length must be between 0 and 50 characters. Mandatory.
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
			    if (value == null)
					throw new ArgumentNullException("value", "Value is null.");
				   if (value != null && value.Length > 50)
					throw new ArgumentException("BatchNumber length must be between 0 and 50 characters.");

				
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

		/// <summary>
		/// This property is mapped to the "ExpiryDate" field.  Mandatory.
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
		/// This property is mapped to the "TaxValue" field.  
		/// </summary>
		public decimal? TaxValue
		{
			get 
			{ 
				return _taxValueNonDefault;
			}
			set 
			{
			
				_taxValueNonDefault = value; 
			}
		}

		/// <summary>
		/// Returns the identifier of the persistent object. Mandatory.
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
		/// This property is mapped to the "PaymentTypeID" field.  
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
		/// This property is mapped to the "TaxTypeName" field. Length must be between 0 and 50 characters. 
		/// </summary>
		public string TaxTypeName
		{
			get 
			{ 
				if(_taxTypeNameNonDefault==null)return _taxTypeNameNonDefault;
				else return _taxTypeNameNonDefault.Trim(); 
			}
			set 
			{
			    if (value != null && value.Length > 50)
					throw new ArgumentException("TaxTypeName length must be between 0 and 50 characters.");

				
				if(value ==null)
				{
					_taxTypeNameNonDefault =null;//null value 
				}
				else
				{		           
					_taxTypeNameNonDefault = value.Trim(); 
				}
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
		/// This property is mapped to the "ChequeNumber" field.  
		/// </summary>
		public decimal? ChequeNumber
		{
			get 
			{ 
				return _chequeNumberNonDefault;
			}
			set 
			{
			
				_chequeNumberNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "ProductName" field. Length must be between 0 and 255 characters. Mandatory.
		/// </summary>
		public string ProductName
		{
			get 
			{ 
				if(_productNameNonDefault==null)return _productNameNonDefault;
				else return _productNameNonDefault.Trim(); 
			}
			set 
			{
			    if (value == null)
					throw new ArgumentNullException("value", "Value is null.");
				   if (value != null && value.Length > 255)
					throw new ArgumentException("ProductName length must be between 0 and 255 characters.");

				
				if(value ==null)
				{
					_productNameNonDefault =null;//null value 
				}
				else
				{		           
					_productNameNonDefault = value.Trim(); 
				}
			}
		}

		/// <summary>
		/// This property is mapped to the "ProductCode" field. Length must be between 0 and 50 characters. 
		/// </summary>
		public string ProductCode
		{
			get 
			{ 
				if(_productCodeNonDefault==null)return _productCodeNonDefault;
				else return _productCodeNonDefault.Trim(); 
			}
			set 
			{
			    if (value != null && value.Length > 50)
					throw new ArgumentException("ProductCode length must be between 0 and 50 characters.");

				
				if(value ==null)
				{
					_productCodeNonDefault =null;//null value 
				}
				else
				{		           
					_productCodeNonDefault = value.Trim(); 
				}
			}
		}

		/// <summary>
		/// This property is mapped to the "IsAcceptBatch" field.  Mandatory.
		/// </summary>
		public bool? IsAcceptBatch
		{
			get 
			{ 
				return _isAcceptBatchNonDefault;
			}
			set 
			{
			
				_isAcceptBatchNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "UserFullName" field. Length must be between 0 and 255 characters. Mandatory.
		/// </summary>
		public string UserFullName
		{
			get 
			{ 
				if(_userFullNameNonDefault==null)return _userFullNameNonDefault;
				else return _userFullNameNonDefault.Trim(); 
			}
			set 
			{
			    if (value == null)
					throw new ArgumentNullException("value", "Value is null.");
				   if (value != null && value.Length > 255)
					throw new ArgumentException("UserFullName length must be between 0 and 255 characters.");

				
				if(value ==null)
				{
					_userFullNameNonDefault =null;//null value 
				}
				else
				{		           
					_userFullNameNonDefault = value.Trim(); 
				}
			}
		}

		/// <summary>
		/// Returns the identifier of the persistent object. Mandatory.
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

		#endregion
		
		#region Methods (Public)

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="VPURPurchaseOrderPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class VPURPurchaseOrder</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			11/4/2015 9:57:47 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static VPURPurchaseOrder SelectOne(VPURPurchaseOrderPrimaryKey pk)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_VPURPurchaseOrder_SelectbyPrimaryKey", ref ExecutionState);
			if (dr.Read())
			{
				VPURPurchaseOrder obj=new VPURPurchaseOrder();	
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
		/// <returns>list of objects of class VPURPurchaseOrder in the form of object of VPURPurchaseOrderCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			11/4/2015 9:57:47 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static VPURPurchaseOrderCollection SelectAll()
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_VPURPurchaseOrder_SelectAll", ref ExecutionState);
			VPURPurchaseOrderCollection VPURPurchaseOrderCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return VPURPurchaseOrderCollection;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class VPURPurchaseOrder</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class VPURPurchaseOrder in the form of an object of class VPURPurchaseOrderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			11/4/2015 9:57:47 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static VPURPurchaseOrderCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_VPURPurchaseOrder_SelectByField", ref ExecutionState);
			VPURPurchaseOrderCollection VPURPurchaseOrderCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return VPURPurchaseOrderCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number</param>
		///
		/// <returns>list of objects of class VPURPurchaseOrder in the form of object of VPURPurchaseOrderCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			11/4/2015 9:57:47 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static VPURPurchaseOrderCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// Pass the specified field and its value to the stored procedure.
			oDatabaseHelper.AddParameter("@PageSize",pageSize);
			oDatabaseHelper.AddParameter("@SkipPages", skipPages);
			oDatabaseHelper.AddParameter("@OrderByStatement", orderByStatement );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_VPURPurchaseOrder_SelectAllPaged", ref ExecutionState);
			VPURPurchaseOrderCollection VPURPurchaseOrderCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return VPURPurchaseOrderCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class VPURPurchaseOrder</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class VPURPurchaseOrder in the form of an object of class VPURPurchaseOrderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			11/4/2015 9:57:47 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static VPURPurchaseOrderCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_VPURPurchaseOrder_SelectByFieldPaged", ref ExecutionState);
			VPURPurchaseOrderCollection VPURPurchaseOrderCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return VPURPurchaseOrderCollection;
			
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
		/// DLGenerator			11/4/2015 9:57:47 PM		Created function
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
			
			Object dr=oDatabaseHelper.ExecuteScalar("gsp_VPURPurchaseOrder_SelectAllCount");
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
		/// DLGenerator			11/4/2015 9:57:47 PM		Created function
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
		/// <param name="obj" type="VPURPurchaseOrder">Object of VPURPurchaseOrder to populate</param>
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			11/4/2015 9:57:47 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static void PopulateObjectFromReader(VPURPurchaseOrderBase obj,IDataReader rdr) 
		{

			obj.SupplierID = rdr.GetInt32(rdr.GetOrdinal(VPURPurchaseOrderFields.SupplierID));
			obj.SupplierName = rdr.GetString(rdr.GetOrdinal(VPURPurchaseOrderFields.SupplierName));
			obj.Qty = rdr.GetDecimal(rdr.GetOrdinal(VPURPurchaseOrderFields.Qty));
			obj.PurchaseLineID = rdr.GetInt32(rdr.GetOrdinal(VPURPurchaseOrderFields.PurchaseLineID));
			obj.TotalQty = rdr.GetDecimal(rdr.GetOrdinal(VPURPurchaseOrderFields.TotalQty));
			obj.UnitPrice = rdr.GetDecimal(rdr.GetOrdinal(VPURPurchaseOrderFields.UnitPrice));
			obj.BatchNumber = rdr.GetString(rdr.GetOrdinal(VPURPurchaseOrderFields.BatchNumber));
			obj.ExpiryDate = rdr.GetDateTime(rdr.GetOrdinal(VPURPurchaseOrderFields.ExpiryDate));
			if (!rdr.IsDBNull(rdr.GetOrdinal(VPURPurchaseOrderFields.TaxValue)))
			{
				obj.TaxValue = rdr.GetDecimal(rdr.GetOrdinal(VPURPurchaseOrderFields.TaxValue));
			}
			
			obj.PurcaseHeaderID = rdr.GetInt32(rdr.GetOrdinal(VPURPurchaseOrderFields.PurcaseHeaderID));
			obj.PurchaseDate = rdr.GetDateTime(rdr.GetOrdinal(VPURPurchaseOrderFields.PurchaseDate));
			if (!rdr.IsDBNull(rdr.GetOrdinal(VPURPurchaseOrderFields.InvoiceNumber)))
			{
				obj.InvoiceNumber = rdr.GetString(rdr.GetOrdinal(VPURPurchaseOrderFields.InvoiceNumber));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(VPURPurchaseOrderFields.InvoiceDate)))
			{
				obj.InvoiceDate = rdr.GetDateTime(rdr.GetOrdinal(VPURPurchaseOrderFields.InvoiceDate));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(VPURPurchaseOrderFields.PaymentTypeID)))
			{
				obj.PaymentTypeID = rdr.GetInt32(rdr.GetOrdinal(VPURPurchaseOrderFields.PaymentTypeID));
			}
			
			obj.TotalDiscountRatio = rdr.GetDouble(rdr.GetOrdinal(VPURPurchaseOrderFields.TotalDiscountRatio));
			if (!rdr.IsDBNull(rdr.GetOrdinal(VPURPurchaseOrderFields.TaxTypeName)))
			{
				obj.TaxTypeName = rdr.GetString(rdr.GetOrdinal(VPURPurchaseOrderFields.TaxTypeName));
			}
			
			obj.IsClosed = rdr.GetBoolean(rdr.GetOrdinal(VPURPurchaseOrderFields.IsClosed));
			obj.IsVoid = rdr.GetBoolean(rdr.GetOrdinal(VPURPurchaseOrderFields.IsVoid));
			if (!rdr.IsDBNull(rdr.GetOrdinal(VPURPurchaseOrderFields.ChequeNumber)))
			{
				obj.ChequeNumber = rdr.GetDecimal(rdr.GetOrdinal(VPURPurchaseOrderFields.ChequeNumber));
			}
			
			obj.ProductName = rdr.GetString(rdr.GetOrdinal(VPURPurchaseOrderFields.ProductName));
			if (!rdr.IsDBNull(rdr.GetOrdinal(VPURPurchaseOrderFields.ProductCode)))
			{
				obj.ProductCode = rdr.GetString(rdr.GetOrdinal(VPURPurchaseOrderFields.ProductCode));
			}
			
			obj.IsAcceptBatch = rdr.GetBoolean(rdr.GetOrdinal(VPURPurchaseOrderFields.IsAcceptBatch));
			obj.UserFullName = rdr.GetString(rdr.GetOrdinal(VPURPurchaseOrderFields.UserFullName));
			obj.ProductID = rdr.GetInt32(rdr.GetOrdinal(VPURPurchaseOrderFields.ProductID));

		}

		/// <summary>
		/// Populates the fields for multiple objects from the columns found in an open reader.
		/// </summary>
		///
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <returns>Object of VPURPurchaseOrderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			11/4/2015 9:57:47 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static VPURPurchaseOrderCollection PopulateObjectsFromReader(IDataReader rdr) 
		{
			VPURPurchaseOrderCollection list = new VPURPurchaseOrderCollection();
			
			while (rdr.Read())
			{
				VPURPurchaseOrder obj = new VPURPurchaseOrder();
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
		/// <returns>Object of VPURPurchaseOrderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			11/4/2015 9:57:47 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static VPURPurchaseOrderCollection PopulateObjectsFromReaderWithCheckingReader(IDataReader rdr, DatabaseHelper oDatabaseHelper) 
		{

			VPURPurchaseOrderCollection list = new VPURPurchaseOrderCollection();
			
            if (rdr.Read())
			{
				VPURPurchaseOrder obj = new VPURPurchaseOrder();
				PopulateObjectFromReader(obj, rdr);
				list.Add(obj);
				while (rdr.Read())
				{
					obj = new VPURPurchaseOrder();
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
