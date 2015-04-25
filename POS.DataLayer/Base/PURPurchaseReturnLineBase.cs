//
// Class	:	PURPurchaseReturnLineBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	11/4/2015 8:46:46 PM
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
	public class PURPurchaseReturnLineFields
	{
		public const string PurchaseReturnLineID      = "PurchaseReturnLineID";
		public const string Qty                       = "Qty";
		public const string Reason                    = "Reason";
		public const string OriginalpurchaseLineID    = "OriginalpurchaseLineID";
		public const string BatchID                   = "BatchID";
		public const string BatchNumber               = "BatchNumber";
		public const string ExpiryDate                = "ExpiryDate";
		public const string PurchaseReturnHeaderID    = "PurchaseReturnHeaderID";
	}
	
	/// <summary>
	/// Data access class for the "PURPurchaseReturnLine" table.
	/// </summary>
	[Serializable]
	public class PURPurchaseReturnLineBase
	{
		
		#region Class Level Variables
		
		private DatabaseHelper oDatabaseHelper = new DatabaseHelper();

		private int?           	_purchaseReturnLineIDNonDefault	= null;
		private decimal?       	_qtyNonDefault           	= null;
		private string         	_reasonNonDefault        	= null;
		private int?           	_originalpurchaseLineIDNonDefault	= null;
		private int?           	_batchIDNonDefault       	= null;
		private string         	_batchNumberNonDefault   	= null;
		private DateTime?      	_expiryDateNonDefault    	= null;
		private int?           	_purchaseReturnHeaderIDNonDefault	= null;
		
		#endregion
		
		#region Constants
		
		#endregion
		
		#region Constructors / Destructors

		/// <summary>
		/// Class Constructor
		///</summary>
		public PURPurchaseReturnLineBase() { }
					
		#endregion
		
		#region Properties

		/// <summary>
		/// Returns the identifier of the persistent object. Don't set it manually!
		/// </summary>
		public int? PurchaseReturnLineID
		{
			get 
			{ 
				return _purchaseReturnLineIDNonDefault;
			}
			set 
			{
			
				_purchaseReturnLineIDNonDefault = value; 
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
		/// This property is mapped to the "Reason" field. Length must be between 0 and 2147483647 characters. 
		/// </summary>
		public string Reason
		{
			get 
			{ 
				if(_reasonNonDefault==null)return _reasonNonDefault;
				else return _reasonNonDefault.Trim(); 
			}
			set 
			{
			    if (value != null && value.Length > 2147483647)
					throw new ArgumentException("Reason length must be between 0 and 2147483647 characters.");

				
				if(value ==null)
				{
					_reasonNonDefault =null;//null value 
				}
				else
				{		           
					_reasonNonDefault = value.Trim(); 
				}
			}
		}

		/// <summary>
		/// The foreign key connected with another persistent object.
		/// </summary>
		public int? OriginalpurchaseLineID
		{
			get 
			{ 
				return _originalpurchaseLineIDNonDefault;
			}
			set 
			{
			
				_originalpurchaseLineIDNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "BatchID" field.  Mandatory.
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
		/// This property is mapped to the "BatchNumber" field. Length must be between 0 and 50 characters. 
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
		/// The foreign key connected with another persistent object.
		/// </summary>
		public int? PurchaseReturnHeaderID
		{
			get 
			{ 
				return _purchaseReturnHeaderIDNonDefault;
			}
			set 
			{
			
				_purchaseReturnHeaderIDNonDefault = value; 
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
		/// DLGenerator			11/4/2015 8:46:46 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool InsertWithDefaultValues(bool getBackValues) 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_qty' as parameter 'Qty' of the stored procedure.
			if(_qtyNonDefault!=null)
			  oDatabaseHelper.AddParameter("@Qty", _qtyNonDefault);
			else
			  oDatabaseHelper.AddParameter("@Qty", DBNull.Value );
			  
			// Pass the value of '_reason' as parameter 'Reason' of the stored procedure.
			if(_reasonNonDefault!=null)
			  oDatabaseHelper.AddParameter("@Reason", _reasonNonDefault);
			else
			  oDatabaseHelper.AddParameter("@Reason", DBNull.Value );
			  
			// Pass the value of '_originalpurchaseLineID' as parameter 'OriginalpurchaseLineID' of the stored procedure.
			if(_originalpurchaseLineIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@OriginalpurchaseLineID", _originalpurchaseLineIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@OriginalpurchaseLineID", DBNull.Value );
			  
			// Pass the value of '_batchID' as parameter 'BatchID' of the stored procedure.
			if(_batchIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@BatchID", _batchIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@BatchID", DBNull.Value );
			  
			// Pass the value of '_batchNumber' as parameter 'BatchNumber' of the stored procedure.
			if(_batchNumberNonDefault!=null)
			  oDatabaseHelper.AddParameter("@BatchNumber", _batchNumberNonDefault);
			else
			  oDatabaseHelper.AddParameter("@BatchNumber", DBNull.Value );
			  
			// Pass the value of '_expiryDate' as parameter 'ExpiryDate' of the stored procedure.
			if(_expiryDateNonDefault!=null)
			  oDatabaseHelper.AddParameter("@ExpiryDate", _expiryDateNonDefault);
			else
			  oDatabaseHelper.AddParameter("@ExpiryDate", DBNull.Value );
			  
			// Pass the value of '_purchaseReturnHeaderID' as parameter 'PurchaseReturnHeaderID' of the stored procedure.
			if(_purchaseReturnHeaderIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@PurchaseReturnHeaderID", _purchaseReturnHeaderIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@PurchaseReturnHeaderID", DBNull.Value );
			  
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			if(!getBackValues )
			{
				oDatabaseHelper.ExecuteScalar("gsp_PURPurchaseReturnLine_Insert_WithDefaultValues", ref ExecutionState);
			}
			else
			{
				IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseReturnLine_Insert_WithDefaultValues_AndReturn", ref ExecutionState);
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
		/// DLGenerator			11/4/2015 8:46:46 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Insert() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_qty' as parameter 'Qty' of the stored procedure.
			if(_qtyNonDefault!=null)
			  oDatabaseHelper.AddParameter("@Qty", _qtyNonDefault);
			else
			  oDatabaseHelper.AddParameter("@Qty", DBNull.Value );
			// Pass the value of '_reason' as parameter 'Reason' of the stored procedure.
			if(_reasonNonDefault!=null)
			  oDatabaseHelper.AddParameter("@Reason", _reasonNonDefault);
			else
			  oDatabaseHelper.AddParameter("@Reason", DBNull.Value );
			// Pass the value of '_originalpurchaseLineID' as parameter 'OriginalpurchaseLineID' of the stored procedure.
			if(_originalpurchaseLineIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@OriginalpurchaseLineID", _originalpurchaseLineIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@OriginalpurchaseLineID", DBNull.Value );
			// Pass the value of '_batchID' as parameter 'BatchID' of the stored procedure.
			if(_batchIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@BatchID", _batchIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@BatchID", DBNull.Value );
			// Pass the value of '_batchNumber' as parameter 'BatchNumber' of the stored procedure.
			if(_batchNumberNonDefault!=null)
			  oDatabaseHelper.AddParameter("@BatchNumber", _batchNumberNonDefault);
			else
			  oDatabaseHelper.AddParameter("@BatchNumber", DBNull.Value );
			// Pass the value of '_expiryDate' as parameter 'ExpiryDate' of the stored procedure.
			if(_expiryDateNonDefault!=null)
			  oDatabaseHelper.AddParameter("@ExpiryDate", _expiryDateNonDefault);
			else
			  oDatabaseHelper.AddParameter("@ExpiryDate", DBNull.Value );
			// Pass the value of '_purchaseReturnHeaderID' as parameter 'PurchaseReturnHeaderID' of the stored procedure.
			if(_purchaseReturnHeaderIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@PurchaseReturnHeaderID", _purchaseReturnHeaderIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@PurchaseReturnHeaderID", DBNull.Value );
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_PURPurchaseReturnLine_Insert", ref ExecutionState);
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
		/// DLGenerator			11/4/2015 8:46:46 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Update() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_purchaseReturnLineID' as parameter 'PurchaseReturnLineID' of the stored procedure.
			oDatabaseHelper.AddParameter("@PurchaseReturnLineID", _purchaseReturnLineIDNonDefault );
			
			// Pass the value of '_qty' as parameter 'Qty' of the stored procedure.
			oDatabaseHelper.AddParameter("@Qty", _qtyNonDefault );
			
			// Pass the value of '_reason' as parameter 'Reason' of the stored procedure.
			oDatabaseHelper.AddParameter("@Reason", _reasonNonDefault );
			
			// Pass the value of '_originalpurchaseLineID' as parameter 'OriginalpurchaseLineID' of the stored procedure.
			oDatabaseHelper.AddParameter("@OriginalpurchaseLineID", _originalpurchaseLineIDNonDefault );
			
			// Pass the value of '_batchID' as parameter 'BatchID' of the stored procedure.
			oDatabaseHelper.AddParameter("@BatchID", _batchIDNonDefault );
			
			// Pass the value of '_batchNumber' as parameter 'BatchNumber' of the stored procedure.
			oDatabaseHelper.AddParameter("@BatchNumber", _batchNumberNonDefault );
			
			// Pass the value of '_expiryDate' as parameter 'ExpiryDate' of the stored procedure.
			oDatabaseHelper.AddParameter("@ExpiryDate", _expiryDateNonDefault );
			
			// Pass the value of '_purchaseReturnHeaderID' as parameter 'PurchaseReturnHeaderID' of the stored procedure.
			oDatabaseHelper.AddParameter("@PurchaseReturnHeaderID", _purchaseReturnHeaderIDNonDefault );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_PURPurchaseReturnLine_Update", ref ExecutionState);
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
		/// DLGenerator			11/4/2015 8:46:46 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Delete() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_purchaseReturnLineID' as parameter 'PurchaseReturnLineID' of the stored procedure.
			if(_purchaseReturnLineIDNonDefault!=null)
				oDatabaseHelper.AddParameter("@PurchaseReturnLineID", _purchaseReturnLineIDNonDefault );
			else
				oDatabaseHelper.AddParameter("@PurchaseReturnLineID", DBNull.Value );
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_PURPurchaseReturnLine_Delete", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will Delete one row from the database using the primary key information
		/// </summary>
		///
		/// <param name="pk" type="PURPurchaseReturnLinePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>True if succeeded</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			11/4/2015 8:46:46 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static bool Delete(PURPurchaseReturnLinePrimaryKey pk) 
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
   
			oDatabaseHelper.ExecuteScalar("gsp_PURPurchaseReturnLine_Delete", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="PURPurchaseReturnLineFields">Field of the class PURPurchaseReturnLine</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		///
		/// <returns>True if succeeded</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			11/4/2015 8:46:46 PM		Created function
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
			
			oDatabaseHelper.ExecuteScalar("gsp_PURPurchaseReturnLine_DeleteByField", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="PURPurchaseReturnLinePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class PURPurchaseReturnLine</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			11/4/2015 8:46:46 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static PURPurchaseReturnLine SelectOne(PURPurchaseReturnLinePrimaryKey pk)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseReturnLine_SelectbyPrimaryKey", ref ExecutionState);
			if (dr.Read())
			{
				PURPurchaseReturnLine obj=new PURPurchaseReturnLine();	
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
		/// <returns>list of objects of class PURPurchaseReturnLine in the form of object of PURPurchaseReturnLineCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			11/4/2015 8:46:46 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static PURPurchaseReturnLineCollection SelectAll()
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseReturnLine_SelectAll", ref ExecutionState);
			PURPurchaseReturnLineCollection PURPurchaseReturnLineCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return PURPurchaseReturnLineCollection;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class PURPurchaseReturnLine</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class PURPurchaseReturnLine in the form of an object of class PURPurchaseReturnLineCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			11/4/2015 8:46:46 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static PURPurchaseReturnLineCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseReturnLine_SelectByField", ref ExecutionState);
			PURPurchaseReturnLineCollection PURPurchaseReturnLineCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return PURPurchaseReturnLineCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number</param>
		///
		/// <returns>list of objects of class PURPurchaseReturnLine in the form of object of PURPurchaseReturnLineCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			11/4/2015 8:46:46 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static PURPurchaseReturnLineCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// Pass the specified field and its value to the stored procedure.
			oDatabaseHelper.AddParameter("@PageSize",pageSize);
			oDatabaseHelper.AddParameter("@SkipPages", skipPages);
			oDatabaseHelper.AddParameter("@OrderByStatement", orderByStatement );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseReturnLine_SelectAllPaged", ref ExecutionState);
			PURPurchaseReturnLineCollection PURPurchaseReturnLineCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return PURPurchaseReturnLineCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class PURPurchaseReturnLine</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class PURPurchaseReturnLine in the form of an object of class PURPurchaseReturnLineCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			11/4/2015 8:46:46 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static PURPurchaseReturnLineCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseReturnLine_SelectByFieldPaged", ref ExecutionState);
			PURPurchaseReturnLineCollection PURPurchaseReturnLineCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return PURPurchaseReturnLineCollection;
			
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
		/// DLGenerator			11/4/2015 8:46:46 PM		Created function
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
			
			Object dr=oDatabaseHelper.ExecuteScalar("gsp_PURPurchaseReturnLine_SelectAllCount");
			int count = Convert.ToInt32(dr);		
			oDatabaseHelper.Dispose();
			return count;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="PURPurchaseReturnHeaderPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class PURPurchaseReturnLineCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			11/4/2015 8:46:46 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static PURPurchaseReturnLineCollection SelectAllByForeignKeyPurchaseReturnHeaderID(PURPurchaseReturnHeaderPrimaryKey pk)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			PURPurchaseReturnLineCollection obj = null;
			
			// Pass the values of all key parameters to the stored procedure.
			System.Collections.Specialized.NameValueCollection nvc = pk.GetKeysAndValues();
			foreach (string key in nvc.Keys)
			{
				oDatabaseHelper.AddParameter("@" + key,nvc[key] );
			}
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseReturnLine_SelectAllByForeignKeyPurchaseReturnHeaderID", ref ExecutionState);
			obj = new PURPurchaseReturnLineCollection();
			obj = PURPurchaseReturnLine.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
			dr.Close();  
			oDatabaseHelper.Dispose();
			return obj;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="PURPurchaseReturnHeaderPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number</param>
		///
		/// <returns>object of class PURPurchaseReturnLineCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			11/4/2015 8:46:46 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static PURPurchaseReturnLineCollection SelectAllByForeignKeyPurchaseReturnHeaderIDPaged(PURPurchaseReturnHeaderPrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			PURPurchaseReturnLineCollection obj = null;
			
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseReturnLine_SelectAllByForeignKeyPurchaseReturnHeaderIDPaged", ref ExecutionState);
			obj = new PURPurchaseReturnLineCollection();
			obj = PURPurchaseReturnLine.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
			dr.Close();  
			oDatabaseHelper.Dispose();
			return obj;
			
		}

		/// <summary>
		/// This method will delete row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="PURPurchaseReturnHeaderPrimaryKey">Primary Key information based on which data is to be deleted.</param>
		///
		/// <returns>object of boolean type as an indicator for operation success .</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			11/4/2015 8:46:46 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static bool DeleteAllByForeignKeyPurchaseReturnHeaderID(PURPurchaseReturnHeaderPrimaryKey pk)
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
			
			oDatabaseHelper.ExecuteNonQuery("gsp_PURPurchaseReturnLine_DeleteAllByForeignKeyPurchaseReturnHeaderID", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}



		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="INVBatchPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class PURPurchaseReturnLineCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			11/4/2015 8:46:46 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static PURPurchaseReturnLineCollection SelectAllByForeignKeyPurchaseReturnLineID(INVBatchPrimaryKey pk)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			PURPurchaseReturnLineCollection obj = null;
			
			// Pass the values of all key parameters to the stored procedure.
			System.Collections.Specialized.NameValueCollection nvc = pk.GetKeysAndValues();
			foreach (string key in nvc.Keys)
			{
				oDatabaseHelper.AddParameter("@" + key,nvc[key] );
			}
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseReturnLine_SelectAllByForeignKeyPurchaseReturnLineID", ref ExecutionState);
			obj = new PURPurchaseReturnLineCollection();
			obj = PURPurchaseReturnLine.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
			dr.Close();  
			oDatabaseHelper.Dispose();
			return obj;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="INVBatchPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number</param>
		///
		/// <returns>object of class PURPurchaseReturnLineCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			11/4/2015 8:46:46 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static PURPurchaseReturnLineCollection SelectAllByForeignKeyPurchaseReturnLineIDPaged(INVBatchPrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			PURPurchaseReturnLineCollection obj = null;
			
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseReturnLine_SelectAllByForeignKeyPurchaseReturnLineIDPaged", ref ExecutionState);
			obj = new PURPurchaseReturnLineCollection();
			obj = PURPurchaseReturnLine.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
			dr.Close();  
			oDatabaseHelper.Dispose();
			return obj;
			
		}

		/// <summary>
		/// This method will delete row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="INVBatchPrimaryKey">Primary Key information based on which data is to be deleted.</param>
		///
		/// <returns>object of boolean type as an indicator for operation success .</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			11/4/2015 8:46:46 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static bool DeleteAllByForeignKeyPurchaseReturnLineID(INVBatchPrimaryKey pk)
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
			
			oDatabaseHelper.ExecuteNonQuery("gsp_PURPurchaseReturnLine_DeleteAllByForeignKeyPurchaseReturnLineID", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}



		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="PURPurchaseLinePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class PURPurchaseReturnLineCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			11/4/2015 8:46:46 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static PURPurchaseReturnLineCollection SelectAllByForeignKeyOriginalpurchaseLineID(PURPurchaseLinePrimaryKey pk)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			PURPurchaseReturnLineCollection obj = null;
			
			// Pass the values of all key parameters to the stored procedure.
			System.Collections.Specialized.NameValueCollection nvc = pk.GetKeysAndValues();
			foreach (string key in nvc.Keys)
			{
				oDatabaseHelper.AddParameter("@" + key,nvc[key] );
			}
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseReturnLine_SelectAllByForeignKeyOriginalpurchaseLineID", ref ExecutionState);
			obj = new PURPurchaseReturnLineCollection();
			obj = PURPurchaseReturnLine.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
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
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number</param>
		///
		/// <returns>object of class PURPurchaseReturnLineCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			11/4/2015 8:46:46 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static PURPurchaseReturnLineCollection SelectAllByForeignKeyOriginalpurchaseLineIDPaged(PURPurchaseLinePrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			PURPurchaseReturnLineCollection obj = null;
			
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_PURPurchaseReturnLine_SelectAllByForeignKeyOriginalpurchaseLineIDPaged", ref ExecutionState);
			obj = new PURPurchaseReturnLineCollection();
			obj = PURPurchaseReturnLine.PopulateObjectsFromReaderWithCheckingReader(dr, oDatabaseHelper);
			
			dr.Close();  
			oDatabaseHelper.Dispose();
			return obj;
			
		}

		/// <summary>
		/// This method will delete row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="PURPurchaseLinePrimaryKey">Primary Key information based on which data is to be deleted.</param>
		///
		/// <returns>object of boolean type as an indicator for operation success .</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			11/4/2015 8:46:46 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static bool DeleteAllByForeignKeyOriginalpurchaseLineID(PURPurchaseLinePrimaryKey pk)
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
			
			oDatabaseHelper.ExecuteNonQuery("gsp_PURPurchaseReturnLine_DeleteAllByForeignKeyOriginalpurchaseLineID", ref ExecutionState);
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
		/// DLGenerator			11/4/2015 8:46:46 PM		Created function
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
		/// <param name="obj" type="PURPurchaseReturnLine">Object of PURPurchaseReturnLine to populate</param>
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			11/4/2015 8:46:46 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static void PopulateObjectFromReader(PURPurchaseReturnLineBase obj,IDataReader rdr) 
		{

			obj.PurchaseReturnLineID = rdr.GetInt32(rdr.GetOrdinal(PURPurchaseReturnLineFields.PurchaseReturnLineID));
			obj.Qty = rdr.GetDecimal(rdr.GetOrdinal(PURPurchaseReturnLineFields.Qty));
			if (!rdr.IsDBNull(rdr.GetOrdinal(PURPurchaseReturnLineFields.Reason)))
			{
				obj.Reason = rdr.GetString(rdr.GetOrdinal(PURPurchaseReturnLineFields.Reason));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(PURPurchaseReturnLineFields.OriginalpurchaseLineID)))
			{
				obj.OriginalpurchaseLineID = rdr.GetInt32(rdr.GetOrdinal(PURPurchaseReturnLineFields.OriginalpurchaseLineID));
			}
			
			obj.BatchID = rdr.GetInt32(rdr.GetOrdinal(PURPurchaseReturnLineFields.BatchID));
			if (!rdr.IsDBNull(rdr.GetOrdinal(PURPurchaseReturnLineFields.BatchNumber)))
			{
				obj.BatchNumber = rdr.GetString(rdr.GetOrdinal(PURPurchaseReturnLineFields.BatchNumber));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(PURPurchaseReturnLineFields.ExpiryDate)))
			{
				obj.ExpiryDate = rdr.GetDateTime(rdr.GetOrdinal(PURPurchaseReturnLineFields.ExpiryDate));
			}
			
			obj.PurchaseReturnHeaderID = rdr.GetInt32(rdr.GetOrdinal(PURPurchaseReturnLineFields.PurchaseReturnHeaderID));

		}

		/// <summary>
		/// Populates the fields for multiple objects from the columns found in an open reader.
		/// </summary>
		///
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <returns>Object of PURPurchaseReturnLineCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			11/4/2015 8:46:46 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static PURPurchaseReturnLineCollection PopulateObjectsFromReader(IDataReader rdr) 
		{
			PURPurchaseReturnLineCollection list = new PURPurchaseReturnLineCollection();
			
			while (rdr.Read())
			{
				PURPurchaseReturnLine obj = new PURPurchaseReturnLine();
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
		/// <returns>Object of PURPurchaseReturnLineCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			11/4/2015 8:46:46 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static PURPurchaseReturnLineCollection PopulateObjectsFromReaderWithCheckingReader(IDataReader rdr, DatabaseHelper oDatabaseHelper) 
		{

			PURPurchaseReturnLineCollection list = new PURPurchaseReturnLineCollection();
			
            if (rdr.Read())
			{
				PURPurchaseReturnLine obj = new PURPurchaseReturnLine();
				PopulateObjectFromReader(obj, rdr);
				list.Add(obj);
				while (rdr.Read())
				{
					obj = new PURPurchaseReturnLine();
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
