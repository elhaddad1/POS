//
// Class	:	SALSalesReturnLineBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	3/7/2015 2:37:19 PM
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
	public class SALSalesReturnLineFields
	{
		public const string SalesReturnLineID         = "SalesReturnLineID";
		public const string Qty                       = "Qty";
		public const string Reason                    = "Reason";
		public const string OriginalSalesLineID       = "OriginalSalesLineID";
		public const string BatchID                   = "BatchID";
		public const string BatchNumber               = "BatchNumber";
		public const string ExpiryDate                = "ExpiryDate";
	}
	
	/// <summary>
	/// Data access class for the "SALSalesReturnLine" table.
	/// </summary>
	[Serializable]
	public class SALSalesReturnLineBase
	{
		
		#region Class Level Variables
		
		private DatabaseHelper oDatabaseHelper = new DatabaseHelper();

		private int?           	_salesReturnLineIDNonDefault	= null;
		private decimal?       	_qtyNonDefault           	= 0;
		private string         	_reasonNonDefault        	= null;
		private int?           	_originalSalesLineIDNonDefault	= null;
		private int?           	_batchIDNonDefault       	= null;
		private string         	_batchNumberNonDefault   	= null;
		private DateTime?      	_expiryDateNonDefault    	= null;
		
		#endregion
		
		#region Constants
		
		#endregion
		
		#region Constructors / Destructors

		/// <summary>
		/// Class Constructor
		///</summary>
		public SALSalesReturnLineBase() { }
					
		#endregion
		
		#region Properties

		/// <summary>
		/// Returns the identifier of the persistent object. Don't set it manually!
		/// </summary>
		public int? SalesReturnLineID
		{
			get 
			{ 
				return _salesReturnLineIDNonDefault;
			}
			set 
			{
			
				_salesReturnLineIDNonDefault = value; 
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
		/// This property is mapped to the "OriginalSalesLineID" field.  
		/// </summary>
		public int? OriginalSalesLineID
		{
			get 
			{ 
				return _originalSalesLineIDNonDefault;
			}
			set 
			{
			
				_originalSalesLineIDNonDefault = value; 
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
		/// DLGenerator			3/7/2015 2:37:19 PM		Created function
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
			  
			// Pass the value of '_originalSalesLineID' as parameter 'OriginalSalesLineID' of the stored procedure.
			if(_originalSalesLineIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@OriginalSalesLineID", _originalSalesLineIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@OriginalSalesLineID", DBNull.Value );
			  
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
			  
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			if(!getBackValues )
			{
				oDatabaseHelper.ExecuteScalar("gsp_SALSalesReturnLine_Insert_WithDefaultValues", ref ExecutionState);
			}
			else
			{
				IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_SALSalesReturnLine_Insert_WithDefaultValues_AndReturn", ref ExecutionState);
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
		/// DLGenerator			3/7/2015 2:37:19 PM		Created function
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
			// Pass the value of '_originalSalesLineID' as parameter 'OriginalSalesLineID' of the stored procedure.
			if(_originalSalesLineIDNonDefault!=null)
			  oDatabaseHelper.AddParameter("@OriginalSalesLineID", _originalSalesLineIDNonDefault);
			else
			  oDatabaseHelper.AddParameter("@OriginalSalesLineID", DBNull.Value );
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
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_SALSalesReturnLine_Insert", ref ExecutionState);
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
		/// DLGenerator			3/7/2015 2:37:19 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Update() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_salesReturnLineID' as parameter 'SalesReturnLineID' of the stored procedure.
			oDatabaseHelper.AddParameter("@SalesReturnLineID", _salesReturnLineIDNonDefault );
			
			// Pass the value of '_qty' as parameter 'Qty' of the stored procedure.
			oDatabaseHelper.AddParameter("@Qty", _qtyNonDefault );
			
			// Pass the value of '_reason' as parameter 'Reason' of the stored procedure.
			oDatabaseHelper.AddParameter("@Reason", _reasonNonDefault );
			
			// Pass the value of '_originalSalesLineID' as parameter 'OriginalSalesLineID' of the stored procedure.
			oDatabaseHelper.AddParameter("@OriginalSalesLineID", _originalSalesLineIDNonDefault );
			
			// Pass the value of '_batchID' as parameter 'BatchID' of the stored procedure.
			oDatabaseHelper.AddParameter("@BatchID", _batchIDNonDefault );
			
			// Pass the value of '_batchNumber' as parameter 'BatchNumber' of the stored procedure.
			oDatabaseHelper.AddParameter("@BatchNumber", _batchNumberNonDefault );
			
			// Pass the value of '_expiryDate' as parameter 'ExpiryDate' of the stored procedure.
			oDatabaseHelper.AddParameter("@ExpiryDate", _expiryDateNonDefault );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_SALSalesReturnLine_Update", ref ExecutionState);
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
		/// DLGenerator			3/7/2015 2:37:19 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Delete() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_salesReturnLineID' as parameter 'SalesReturnLineID' of the stored procedure.
			if(_salesReturnLineIDNonDefault!=null)
				oDatabaseHelper.AddParameter("@SalesReturnLineID", _salesReturnLineIDNonDefault );
			else
				oDatabaseHelper.AddParameter("@SalesReturnLineID", DBNull.Value );
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_SALSalesReturnLine_Delete", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will Delete one row from the database using the primary key information
		/// </summary>
		///
		/// <param name="pk" type="SALSalesReturnLinePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>True if succeeded</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/7/2015 2:37:19 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static bool Delete(SALSalesReturnLinePrimaryKey pk) 
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
   
			oDatabaseHelper.ExecuteScalar("gsp_SALSalesReturnLine_Delete", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="SALSalesReturnLineFields">Field of the class SALSalesReturnLine</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		///
		/// <returns>True if succeeded</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/7/2015 2:37:19 PM		Created function
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
			
			oDatabaseHelper.ExecuteScalar("gsp_SALSalesReturnLine_DeleteByField", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="SALSalesReturnLinePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class SALSalesReturnLine</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/7/2015 2:37:19 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static SALSalesReturnLine SelectOne(SALSalesReturnLinePrimaryKey pk)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_SALSalesReturnLine_SelectbyPrimaryKey", ref ExecutionState);
			if (dr.Read())
			{
				SALSalesReturnLine obj=new SALSalesReturnLine();	
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
		/// <returns>list of objects of class SALSalesReturnLine in the form of object of SALSalesReturnLineCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/7/2015 2:37:19 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static SALSalesReturnLineCollection SelectAll()
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_SALSalesReturnLine_SelectAll", ref ExecutionState);
			SALSalesReturnLineCollection SALSalesReturnLineCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return SALSalesReturnLineCollection;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class SALSalesReturnLine</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class SALSalesReturnLine in the form of an object of class SALSalesReturnLineCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/7/2015 2:37:19 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static SALSalesReturnLineCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_SALSalesReturnLine_SelectByField", ref ExecutionState);
			SALSalesReturnLineCollection SALSalesReturnLineCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return SALSalesReturnLineCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number</param>
		///
		/// <returns>list of objects of class SALSalesReturnLine in the form of object of SALSalesReturnLineCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/7/2015 2:37:19 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static SALSalesReturnLineCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// Pass the specified field and its value to the stored procedure.
			oDatabaseHelper.AddParameter("@PageSize",pageSize);
			oDatabaseHelper.AddParameter("@SkipPages", skipPages);
			oDatabaseHelper.AddParameter("@OrderByStatement", orderByStatement );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_SALSalesReturnLine_SelectAllPaged", ref ExecutionState);
			SALSalesReturnLineCollection SALSalesReturnLineCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return SALSalesReturnLineCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class SALSalesReturnLine</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class SALSalesReturnLine in the form of an object of class SALSalesReturnLineCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/7/2015 2:37:19 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static SALSalesReturnLineCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_SALSalesReturnLine_SelectByFieldPaged", ref ExecutionState);
			SALSalesReturnLineCollection SALSalesReturnLineCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return SALSalesReturnLineCollection;
			
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
		/// DLGenerator			3/7/2015 2:37:19 PM		Created function
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
			
			Object dr=oDatabaseHelper.ExecuteScalar("gsp_SALSalesReturnLine_SelectAllCount");
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
		/// DLGenerator			3/7/2015 2:37:19 PM		Created function
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
		/// <param name="obj" type="SALSalesReturnLine">Object of SALSalesReturnLine to populate</param>
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/7/2015 2:37:19 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static void PopulateObjectFromReader(SALSalesReturnLineBase obj,IDataReader rdr) 
		{

			obj.SalesReturnLineID = rdr.GetInt32(rdr.GetOrdinal(SALSalesReturnLineFields.SalesReturnLineID));
			obj.Qty = rdr.GetDecimal(rdr.GetOrdinal(SALSalesReturnLineFields.Qty));
			if (!rdr.IsDBNull(rdr.GetOrdinal(SALSalesReturnLineFields.Reason)))
			{
				obj.Reason = rdr.GetString(rdr.GetOrdinal(SALSalesReturnLineFields.Reason));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(SALSalesReturnLineFields.OriginalSalesLineID)))
			{
				obj.OriginalSalesLineID = rdr.GetInt32(rdr.GetOrdinal(SALSalesReturnLineFields.OriginalSalesLineID));
			}
			
			obj.BatchID = rdr.GetInt32(rdr.GetOrdinal(SALSalesReturnLineFields.BatchID));
			if (!rdr.IsDBNull(rdr.GetOrdinal(SALSalesReturnLineFields.BatchNumber)))
			{
				obj.BatchNumber = rdr.GetString(rdr.GetOrdinal(SALSalesReturnLineFields.BatchNumber));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(SALSalesReturnLineFields.ExpiryDate)))
			{
				obj.ExpiryDate = rdr.GetDateTime(rdr.GetOrdinal(SALSalesReturnLineFields.ExpiryDate));
			}
			

		}

		/// <summary>
		/// Populates the fields for multiple objects from the columns found in an open reader.
		/// </summary>
		///
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <returns>Object of SALSalesReturnLineCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/7/2015 2:37:19 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static SALSalesReturnLineCollection PopulateObjectsFromReader(IDataReader rdr) 
		{
			SALSalesReturnLineCollection list = new SALSalesReturnLineCollection();
			
			while (rdr.Read())
			{
				SALSalesReturnLine obj = new SALSalesReturnLine();
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
		/// <returns>Object of SALSalesReturnLineCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/7/2015 2:37:19 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static SALSalesReturnLineCollection PopulateObjectsFromReaderWithCheckingReader(IDataReader rdr, DatabaseHelper oDatabaseHelper) 
		{

			SALSalesReturnLineCollection list = new SALSalesReturnLineCollection();
			
            if (rdr.Read())
			{
				SALSalesReturnLine obj = new SALSalesReturnLine();
				PopulateObjectFromReader(obj, rdr);
				list.Add(obj);
				while (rdr.Read())
				{
					obj = new SALSalesReturnLine();
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
