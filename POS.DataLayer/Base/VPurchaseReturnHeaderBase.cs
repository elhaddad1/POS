//
// Class	:	VPurchaseReturnHeaderBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	11/4/2015 9:57:48 PM
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
	public class VPurchaseReturnHeaderFields
	{
		public const string PurchaseReturnID          = "PurchaseReturnID";
		public const string ReturnDate                = "ReturnDate";
		public const string IsClosed                  = "IsClosed";
		public const string InvoiceNumber             = "InvoiceNumber";
		public const string SupplierName              = "SupplierName";
		public const string PurcaseHeaderID           = "PurcaseHeaderID";
	}
	
	/// <summary>
	/// Data access class for the "VPurchaseReturnHeader" table.
	/// </summary>
	[Serializable]
	public class VPurchaseReturnHeaderBase
	{
		
		#region Class Level Variables
		
		private DatabaseHelper oDatabaseHelper = new DatabaseHelper();

		private int?           	_purchaseReturnIDNonDefault	= null;
		private DateTime?      	_returnDateNonDefault    	= null;
		private bool?          	_isClosedNonDefault      	= null;
		private string         	_invoiceNumberNonDefault 	= null;
		private string         	_supplierNameNonDefault  	= null;
		private int?           	_purcaseHeaderIDNonDefault	= null;
		
		#endregion
		
		#region Constants
		
		#endregion
		
		#region Constructors / Destructors

		/// <summary>
		/// Class Constructor
		///</summary>
		public VPurchaseReturnHeaderBase() { }
					
		#endregion
		
		#region Properties

		/// <summary>
		/// Returns the identifier of the persistent object. Mandatory.
		/// </summary>
		public int? PurchaseReturnID
		{
			get 
			{ 
				return _purchaseReturnIDNonDefault;
			}
			set 
			{
			
				_purchaseReturnIDNonDefault = value; 
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

		#endregion
		
		#region Methods (Public)

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="VPurchaseReturnHeaderPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class VPurchaseReturnHeader</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			11/4/2015 9:57:48 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static VPurchaseReturnHeader SelectOne(VPurchaseReturnHeaderPrimaryKey pk)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_VPurchaseReturnHeader_SelectbyPrimaryKey", ref ExecutionState);
			if (dr.Read())
			{
				VPurchaseReturnHeader obj=new VPurchaseReturnHeader();	
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
		/// <returns>list of objects of class VPurchaseReturnHeader in the form of object of VPurchaseReturnHeaderCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			11/4/2015 9:57:48 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static VPurchaseReturnHeaderCollection SelectAll()
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_VPurchaseReturnHeader_SelectAll", ref ExecutionState);
			VPurchaseReturnHeaderCollection VPurchaseReturnHeaderCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return VPurchaseReturnHeaderCollection;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class VPurchaseReturnHeader</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class VPurchaseReturnHeader in the form of an object of class VPurchaseReturnHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			11/4/2015 9:57:48 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static VPurchaseReturnHeaderCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_VPurchaseReturnHeader_SelectByField", ref ExecutionState);
			VPurchaseReturnHeaderCollection VPurchaseReturnHeaderCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return VPurchaseReturnHeaderCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number</param>
		///
		/// <returns>list of objects of class VPurchaseReturnHeader in the form of object of VPurchaseReturnHeaderCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			11/4/2015 9:57:48 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static VPurchaseReturnHeaderCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// Pass the specified field and its value to the stored procedure.
			oDatabaseHelper.AddParameter("@PageSize",pageSize);
			oDatabaseHelper.AddParameter("@SkipPages", skipPages);
			oDatabaseHelper.AddParameter("@OrderByStatement", orderByStatement );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_VPurchaseReturnHeader_SelectAllPaged", ref ExecutionState);
			VPurchaseReturnHeaderCollection VPurchaseReturnHeaderCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return VPurchaseReturnHeaderCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class VPurchaseReturnHeader</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class VPurchaseReturnHeader in the form of an object of class VPurchaseReturnHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			11/4/2015 9:57:48 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static VPurchaseReturnHeaderCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_VPurchaseReturnHeader_SelectByFieldPaged", ref ExecutionState);
			VPurchaseReturnHeaderCollection VPurchaseReturnHeaderCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return VPurchaseReturnHeaderCollection;
			
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
		/// DLGenerator			11/4/2015 9:57:48 PM		Created function
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
			
			Object dr=oDatabaseHelper.ExecuteScalar("gsp_VPurchaseReturnHeader_SelectAllCount");
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
		/// DLGenerator			11/4/2015 9:57:48 PM		Created function
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
		/// <param name="obj" type="VPurchaseReturnHeader">Object of VPurchaseReturnHeader to populate</param>
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			11/4/2015 9:57:48 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static void PopulateObjectFromReader(VPurchaseReturnHeaderBase obj,IDataReader rdr) 
		{

			obj.PurchaseReturnID = rdr.GetInt32(rdr.GetOrdinal(VPurchaseReturnHeaderFields.PurchaseReturnID));
			obj.ReturnDate = rdr.GetDateTime(rdr.GetOrdinal(VPurchaseReturnHeaderFields.ReturnDate));
			obj.IsClosed = rdr.GetBoolean(rdr.GetOrdinal(VPurchaseReturnHeaderFields.IsClosed));
			if (!rdr.IsDBNull(rdr.GetOrdinal(VPurchaseReturnHeaderFields.InvoiceNumber)))
			{
				obj.InvoiceNumber = rdr.GetString(rdr.GetOrdinal(VPurchaseReturnHeaderFields.InvoiceNumber));
			}
			
			obj.SupplierName = rdr.GetString(rdr.GetOrdinal(VPurchaseReturnHeaderFields.SupplierName));
			obj.PurcaseHeaderID = rdr.GetInt32(rdr.GetOrdinal(VPurchaseReturnHeaderFields.PurcaseHeaderID));

		}

		/// <summary>
		/// Populates the fields for multiple objects from the columns found in an open reader.
		/// </summary>
		///
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <returns>Object of VPurchaseReturnHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			11/4/2015 9:57:48 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static VPurchaseReturnHeaderCollection PopulateObjectsFromReader(IDataReader rdr) 
		{
			VPurchaseReturnHeaderCollection list = new VPurchaseReturnHeaderCollection();
			
			while (rdr.Read())
			{
				VPurchaseReturnHeader obj = new VPurchaseReturnHeader();
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
		/// <returns>Object of VPurchaseReturnHeaderCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			11/4/2015 9:57:48 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static VPurchaseReturnHeaderCollection PopulateObjectsFromReaderWithCheckingReader(IDataReader rdr, DatabaseHelper oDatabaseHelper) 
		{

			VPurchaseReturnHeaderCollection list = new VPurchaseReturnHeaderCollection();
			
            if (rdr.Read())
			{
				VPurchaseReturnHeader obj = new VPurchaseReturnHeader();
				PopulateObjectFromReader(obj, rdr);
				list.Add(obj);
				while (rdr.Read())
				{
					obj = new VPurchaseReturnHeader();
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
