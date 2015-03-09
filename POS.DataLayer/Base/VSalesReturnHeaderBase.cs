//
// Class	:	VSalesReturnHeaderBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	3/9/2015 4:39:22 PM
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
	public class VSalesReturnHeaderFields
	{
		public const string SlaesReturnHeaderID       = "SlaesReturnHeaderID";
		public const string ReturnDate                = "ReturnDate";
		public const string IsClosed                  = "IsClosed";
		public const string InvoiceNumber             = "InvoiceNumber";
		public const string CustomerName              = "CustomerName";
		public const string SalesHeaderID             = "SalesHeaderID";
	}
	
	/// <summary>
	/// Data access class for the "VSalesReturnHeader" table.
	/// </summary>
	[Serializable]
	public class VSalesReturnHeaderBase
	{
		
		#region Class Level Variables
		
		private DatabaseHelper oDatabaseHelper = new DatabaseHelper();

		private int?           	_slaesReturnHeaderIDNonDefault	= null;
		private DateTime?      	_returnDateNonDefault    	= null;
		private bool?          	_isClosedNonDefault      	= null;
		private string         	_invoiceNumberNonDefault 	= null;
		private string         	_customerNameNonDefault  	= null;
		private int?           	_salesHeaderIDNonDefault 	= null;
		
		#endregion
		
		#region Constants
		
		#endregion
		
		#region Constructors / Destructors

		/// <summary>
		/// Class Constructor
		///</summary>
		public VSalesReturnHeaderBase() { }
					
		#endregion
		
		#region Properties

		/// <summary>
		/// Returns the identifier of the persistent object. Mandatory.
		/// </summary>
		public int? SlaesReturnHeaderID
		{
			get 
			{ 
				return _slaesReturnHeaderIDNonDefault;
			}
			set 
			{
			
				_slaesReturnHeaderIDNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "ReturnDate" field.  Mandatory.
		/// </summary>
		public DateTime? ReturnDate
		{
			get 
			{ 
				return _returnDateNonDefault;
			}
			set 
			{
			
				_returnDateNonDefault = value; 
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
		/// This property is mapped to the "CustomerName" field. Length must be between 0 and 50 characters. Mandatory.
		/// </summary>
		public string CustomerName
		{
			get 
			{ 
				if(_customerNameNonDefault==null)return _customerNameNonDefault;
				else return _customerNameNonDefault.Trim(); 
			}
			set 
			{
			    if (value == null)
					throw new ArgumentNullException("value", "Value is null.");
				   if (value != null && value.Length > 50)
					throw new ArgumentException("CustomerName length must be between 0 and 50 characters.");

				
				if(value ==null)
				{
					_customerNameNonDefault =null;//null value 
				}
				else
				{		           
					_customerNameNonDefault = value.Trim(); 
				}
			}
		}

		/// <summary>
		/// Returns the identifier of the persistent object. Mandatory.
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

		#endregion
		
		#region Methods (Public)

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="VSalesReturnHeaderPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class VSalesReturnHeader</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/9/2015 4:39:22 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static VSalesReturnHeader SelectOne(VSalesReturnHeaderPrimaryKey pk)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_VSalesReturnHeader_SelectbyPrimaryKey", ref ExecutionState);
			if (dr.Read())
			{
				VSalesReturnHeader obj=new VSalesReturnHeader();	
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
		/// <returns>list of objects of class VSalesReturnHeader in the form of object of VSalesReturnHeaderCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/9/2015 4:39:22 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static VSalesReturnHeaderCollection SelectAll()
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_VSalesReturnHeader_SelectAll", ref ExecutionState);
			VSalesReturnHeaderCollection VSalesReturnHeaderCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return VSalesReturnHeaderCollection;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class VSalesReturnHeader</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class VSalesReturnHeader in the form of an object of class VSalesReturnHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/9/2015 4:39:22 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static VSalesReturnHeaderCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_VSalesReturnHeader_SelectByField", ref ExecutionState);
			VSalesReturnHeaderCollection VSalesReturnHeaderCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return VSalesReturnHeaderCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number</param>
		///
		/// <returns>list of objects of class VSalesReturnHeader in the form of object of VSalesReturnHeaderCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/9/2015 4:39:22 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static VSalesReturnHeaderCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// Pass the specified field and its value to the stored procedure.
			oDatabaseHelper.AddParameter("@PageSize",pageSize);
			oDatabaseHelper.AddParameter("@SkipPages", skipPages);
			oDatabaseHelper.AddParameter("@OrderByStatement", orderByStatement );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_VSalesReturnHeader_SelectAllPaged", ref ExecutionState);
			VSalesReturnHeaderCollection VSalesReturnHeaderCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return VSalesReturnHeaderCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class VSalesReturnHeader</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class VSalesReturnHeader in the form of an object of class VSalesReturnHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/9/2015 4:39:22 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static VSalesReturnHeaderCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_VSalesReturnHeader_SelectByFieldPaged", ref ExecutionState);
			VSalesReturnHeaderCollection VSalesReturnHeaderCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return VSalesReturnHeaderCollection;
			
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
		/// DLGenerator			3/9/2015 4:39:22 PM		Created function
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
			
			Object dr=oDatabaseHelper.ExecuteScalar("gsp_VSalesReturnHeader_SelectAllCount");
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
		/// DLGenerator			3/9/2015 4:39:22 PM		Created function
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
		/// <param name="obj" type="VSalesReturnHeader">Object of VSalesReturnHeader to populate</param>
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/9/2015 4:39:22 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static void PopulateObjectFromReader(VSalesReturnHeaderBase obj,IDataReader rdr) 
		{

			obj.SlaesReturnHeaderID = rdr.GetInt32(rdr.GetOrdinal(VSalesReturnHeaderFields.SlaesReturnHeaderID));
			obj.ReturnDate = rdr.GetDateTime(rdr.GetOrdinal(VSalesReturnHeaderFields.ReturnDate));
			obj.IsClosed = rdr.GetBoolean(rdr.GetOrdinal(VSalesReturnHeaderFields.IsClosed));
			if (!rdr.IsDBNull(rdr.GetOrdinal(VSalesReturnHeaderFields.InvoiceNumber)))
			{
				obj.InvoiceNumber = rdr.GetString(rdr.GetOrdinal(VSalesReturnHeaderFields.InvoiceNumber));
			}
			
			obj.CustomerName = rdr.GetString(rdr.GetOrdinal(VSalesReturnHeaderFields.CustomerName));
			obj.SalesHeaderID = rdr.GetInt32(rdr.GetOrdinal(VSalesReturnHeaderFields.SalesHeaderID));

		}

		/// <summary>
		/// Populates the fields for multiple objects from the columns found in an open reader.
		/// </summary>
		///
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <returns>Object of VSalesReturnHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/9/2015 4:39:22 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static VSalesReturnHeaderCollection PopulateObjectsFromReader(IDataReader rdr) 
		{
			VSalesReturnHeaderCollection list = new VSalesReturnHeaderCollection();
			
			while (rdr.Read())
			{
				VSalesReturnHeader obj = new VSalesReturnHeader();
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
		/// <returns>Object of VSalesReturnHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			3/9/2015 4:39:22 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static VSalesReturnHeaderCollection PopulateObjectsFromReaderWithCheckingReader(IDataReader rdr, DatabaseHelper oDatabaseHelper) 
		{

			VSalesReturnHeaderCollection list = new VSalesReturnHeaderCollection();
			
            if (rdr.Read())
			{
				VSalesReturnHeader obj = new VSalesReturnHeader();
				PopulateObjectFromReader(obj, rdr);
				list.Add(obj);
				while (rdr.Read())
				{
					obj = new VSalesReturnHeader();
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
