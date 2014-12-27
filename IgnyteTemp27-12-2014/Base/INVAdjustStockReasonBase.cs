//
// Class	:	INVAdjustStockReasonBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:55:52 PM
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
	public class INVAdjustStockReasonFields
	{
		public const string AdjustStockReasonID       = "AdjustStockReasonID";
		public const string AdjustStockreasonName     = "AdjustStockreasonName";
	}
	
	/// <summary>
	/// Data access class for the "INVAdjustStockReason" table.
	/// </summary>
	[Serializable]
	public class INVAdjustStockReasonBase
	{
		
		#region Class Level Variables
		
		private DatabaseHelper oDatabaseHelper = new DatabaseHelper();

		private int?           	_adjustStockReasonIDNonDefault	= null;
		private string         	_adjustStockreasonNameNonDefault	= null;

		private INVAdjustStockCollection _iNVAdjustStockCollectionAdjustReasonID = null;
		
		#endregion
		
		#region Constants
		
		#endregion
		
		#region Constructors / Destructors

		/// <summary>
		/// Class Constructor
		///</summary>
		public INVAdjustStockReasonBase() { }
					
		#endregion
		
		#region Properties

		/// <summary>
		/// Returns the identifier of the persistent object. Don't set it manually!
		/// </summary>
		public int? AdjustStockReasonID
		{
			get 
			{ 
				return _adjustStockReasonIDNonDefault;
			}
			set 
			{
			
				_adjustStockReasonIDNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "AdjustStockreasonName" field. Length must be between 0 and 255 characters. Mandatory.
		/// </summary>
		public string AdjustStockreasonName
		{
			get 
			{ 
				if(_adjustStockreasonNameNonDefault==null)return _adjustStockreasonNameNonDefault;
				else return _adjustStockreasonNameNonDefault.Trim(); 
			}
			set 
			{
			    if (value == null)
					throw new ArgumentNullException("value", "Value is null.");
				   if (value != null && value.Length > 255)
					throw new ArgumentException("AdjustStockreasonName length must be between 0 and 255 characters.");

				
				if(value ==null)
				{
					_adjustStockreasonNameNonDefault =null;//null value 
				}
				else
				{		           
					_adjustStockreasonNameNonDefault = value.Trim(); 
				}
			}
		}

		/// <summary>
		/// Provides access to the related table 'INVAdjustStock'
		/// </summary>
		public INVAdjustStockCollection INVAdjustStockCollectionUsingAdjustReasonID
		{
			get 
			{
				if (_iNVAdjustStockCollectionAdjustReasonID == null)
				{
					_iNVAdjustStockCollectionAdjustReasonID = new INVAdjustStockCollection();
					_iNVAdjustStockCollectionAdjustReasonID = INVAdjustStock.SelectByField("AdjustReasonID",AdjustStockReasonID, null, TypeOperation.Equal);
				}                
				return _iNVAdjustStockCollectionAdjustReasonID; 
			}
			set 
			{
				  _iNVAdjustStockCollectionAdjustReasonID = value;
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
		/// DLGenerator			12/27/2014 6:55:52 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool InsertWithDefaultValues(bool getBackValues) 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_adjustStockreasonName' as parameter 'AdjustStockreasonName' of the stored procedure.
			if(_adjustStockreasonNameNonDefault!=null)
			  oDatabaseHelper.AddParameter("@AdjustStockreasonName", _adjustStockreasonNameNonDefault);
			else
			  oDatabaseHelper.AddParameter("@AdjustStockreasonName", DBNull.Value );
			  
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			if(!getBackValues )
			{
				oDatabaseHelper.ExecuteScalar("gsp_INVAdjustStockReason_Insert_WithDefaultValues", ref ExecutionState);
			}
			else
			{
				IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_INVAdjustStockReason_Insert_WithDefaultValues_AndReturn", ref ExecutionState);
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
		/// DLGenerator			12/27/2014 6:55:52 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Insert() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_adjustStockreasonName' as parameter 'AdjustStockreasonName' of the stored procedure.
			if(_adjustStockreasonNameNonDefault!=null)
			  oDatabaseHelper.AddParameter("@AdjustStockreasonName", _adjustStockreasonNameNonDefault);
			else
			  oDatabaseHelper.AddParameter("@AdjustStockreasonName", DBNull.Value );
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_INVAdjustStockReason_Insert", ref ExecutionState);
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
		/// DLGenerator			12/27/2014 6:55:52 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Update() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_adjustStockReasonID' as parameter 'AdjustStockReasonID' of the stored procedure.
			oDatabaseHelper.AddParameter("@AdjustStockReasonID", _adjustStockReasonIDNonDefault );
			
			// Pass the value of '_adjustStockreasonName' as parameter 'AdjustStockreasonName' of the stored procedure.
			oDatabaseHelper.AddParameter("@AdjustStockreasonName", _adjustStockreasonNameNonDefault );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_INVAdjustStockReason_Update", ref ExecutionState);
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
		/// DLGenerator			12/27/2014 6:55:52 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Delete() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_adjustStockReasonID' as parameter 'AdjustStockReasonID' of the stored procedure.
			if(_adjustStockReasonIDNonDefault!=null)
				oDatabaseHelper.AddParameter("@AdjustStockReasonID", _adjustStockReasonIDNonDefault );
			else
				oDatabaseHelper.AddParameter("@AdjustStockReasonID", DBNull.Value );
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_INVAdjustStockReason_Delete", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will Delete one row from the database using the primary key information
		/// </summary>
		///
		/// <param name="pk" type="INVAdjustStockReasonPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>True if succeeded</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:55:52 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static bool Delete(INVAdjustStockReasonPrimaryKey pk) 
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
   
			oDatabaseHelper.ExecuteScalar("gsp_INVAdjustStockReason_Delete", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="INVAdjustStockReasonFields">Field of the class INVAdjustStockReason</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		///
		/// <returns>True if succeeded</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:55:52 PM		Created function
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
			
			oDatabaseHelper.ExecuteScalar("gsp_INVAdjustStockReason_DeleteByField", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="INVAdjustStockReasonPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class INVAdjustStockReason</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:55:52 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static INVAdjustStockReason SelectOne(INVAdjustStockReasonPrimaryKey pk)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_INVAdjustStockReason_SelectbyPrimaryKey", ref ExecutionState);
			if (dr.Read())
			{
				INVAdjustStockReason obj=new INVAdjustStockReason();	
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
		/// <returns>list of objects of class INVAdjustStockReason in the form of object of INVAdjustStockReasonCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:55:52 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static INVAdjustStockReasonCollection SelectAll()
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_INVAdjustStockReason_SelectAll", ref ExecutionState);
			INVAdjustStockReasonCollection INVAdjustStockReasonCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return INVAdjustStockReasonCollection;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class INVAdjustStockReason</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class INVAdjustStockReason in the form of an object of class INVAdjustStockReasonCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:55:52 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static INVAdjustStockReasonCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_INVAdjustStockReason_SelectByField", ref ExecutionState);
			INVAdjustStockReasonCollection INVAdjustStockReasonCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return INVAdjustStockReasonCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number</param>
		///
		/// <returns>list of objects of class INVAdjustStockReason in the form of object of INVAdjustStockReasonCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:55:52 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static INVAdjustStockReasonCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// Pass the specified field and its value to the stored procedure.
			oDatabaseHelper.AddParameter("@PageSize",pageSize);
			oDatabaseHelper.AddParameter("@SkipPages", skipPages);
			oDatabaseHelper.AddParameter("@OrderByStatement", orderByStatement );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_INVAdjustStockReason_SelectAllPaged", ref ExecutionState);
			INVAdjustStockReasonCollection INVAdjustStockReasonCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return INVAdjustStockReasonCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class INVAdjustStockReason</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class INVAdjustStockReason in the form of an object of class INVAdjustStockReasonCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:55:52 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static INVAdjustStockReasonCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_INVAdjustStockReason_SelectByFieldPaged", ref ExecutionState);
			INVAdjustStockReasonCollection INVAdjustStockReasonCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return INVAdjustStockReasonCollection;
			
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
		/// DLGenerator			12/27/2014 6:55:52 PM		Created function
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
			
			Object dr=oDatabaseHelper.ExecuteScalar("gsp_INVAdjustStockReason_SelectAllCount");
			int count = Convert.ToInt32(dr);		
			oDatabaseHelper.Dispose();
			return count;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="INVAdjustStockReasonPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class INVAdjustStockReason</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:55:52 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static INVAdjustStockReason SelectOneWithINVAdjustStockUsingAdjustReasonID(INVAdjustStockReasonPrimaryKey pk)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			INVAdjustStockReason obj=null;
			
			// Pass the values of all key parameters to the stored procedure.
			System.Collections.Specialized.NameValueCollection nvc = pk.GetKeysAndValues();
			foreach (string key in nvc.Keys)
			{
				oDatabaseHelper.AddParameter("@" + key,nvc[key] );
			}
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_INVAdjustStockReason_SelectOneWithINVAdjustStockUsingAdjustReasonID", ref ExecutionState);
			if (dr.Read())
			{
				obj= new INVAdjustStockReason();
				PopulateObjectFromReader(obj,dr);
				
				dr.NextResult();
				
				//Get the child records.
				obj.INVAdjustStockCollectionUsingAdjustReasonID=INVAdjustStock.PopulateObjectsFromReader(dr);
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
		/// DLGenerator			12/27/2014 6:55:52 PM		Created function
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
		/// <param name="obj" type="INVAdjustStockReason">Object of INVAdjustStockReason to populate</param>
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:55:52 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static void PopulateObjectFromReader(INVAdjustStockReasonBase obj,IDataReader rdr) 
		{

			obj.AdjustStockReasonID = rdr.GetInt32(rdr.GetOrdinal(INVAdjustStockReasonFields.AdjustStockReasonID));
			obj.AdjustStockreasonName = rdr.GetString(rdr.GetOrdinal(INVAdjustStockReasonFields.AdjustStockreasonName));

		}

		/// <summary>
		/// Populates the fields for multiple objects from the columns found in an open reader.
		/// </summary>
		///
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <returns>Object of INVAdjustStockReasonCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:55:52 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static INVAdjustStockReasonCollection PopulateObjectsFromReader(IDataReader rdr) 
		{
			INVAdjustStockReasonCollection list = new INVAdjustStockReasonCollection();
			
			while (rdr.Read())
			{
				INVAdjustStockReason obj = new INVAdjustStockReason();
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
		/// <returns>Object of INVAdjustStockReasonCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/27/2014 6:55:52 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static INVAdjustStockReasonCollection PopulateObjectsFromReaderWithCheckingReader(IDataReader rdr, DatabaseHelper oDatabaseHelper) 
		{

			INVAdjustStockReasonCollection list = new INVAdjustStockReasonCollection();
			
            if (rdr.Read())
			{
				INVAdjustStockReason obj = new INVAdjustStockReason();
				PopulateObjectFromReader(obj, rdr);
				list.Add(obj);
				while (rdr.Read())
				{
					obj = new INVAdjustStockReason();
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
