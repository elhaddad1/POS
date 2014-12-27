//
// Class	:	BDTaxTypeBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	12/26/2014 2:45:51 AM
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
	public class BDTaxTypeFields
	{
		public const string TaxTypeID                 = "TaxTypeID";
		public const string TaxTypeName               = "TaxTypeName";
	}
	
	/// <summary>
	/// Data access class for the "BDTaxType" table.
	/// </summary>
	[Serializable]
	public class BDTaxTypeBase
	{
		
		#region Class Level Variables
		
		private DatabaseHelper oDatabaseHelper = new DatabaseHelper();

		private int?           	_taxTypeIDNonDefault     	= null;
		private string         	_taxTypeNameNonDefault   	= null;

		private PURPurchaseHeaderCollection _pURPurchaseHeaderCollectionTaxTypeID = null;
		private SALSalesHeaderCollection _sALSalesHeaderCollectionTaxTypeID = null;
		
		#endregion
		
		#region Constants
		
		#endregion
		
		#region Constructors / Destructors

		/// <summary>
		/// Class Constructor
		///</summary>
		public BDTaxTypeBase() { }
					
		#endregion
		
		#region Properties

		/// <summary>
		/// Returns the identifier of the persistent object. Don't set it manually!
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
		/// Provides access to the related table 'PURPurchaseHeader'
		/// </summary>
		public PURPurchaseHeaderCollection PURPurchaseHeaderCollectionUsingTaxTypeID
		{
			get 
			{
				if (_pURPurchaseHeaderCollectionTaxTypeID == null)
				{
					_pURPurchaseHeaderCollectionTaxTypeID = new PURPurchaseHeaderCollection();
					_pURPurchaseHeaderCollectionTaxTypeID = PURPurchaseHeader.SelectByField("TaxTypeID",TaxTypeID, null, TypeOperation.Equal);
				}                
				return _pURPurchaseHeaderCollectionTaxTypeID; 
			}
			set 
			{
				  _pURPurchaseHeaderCollectionTaxTypeID = value;
			}
		}

		/// <summary>
		/// Provides access to the related table 'SALSalesHeader'
		/// </summary>
		public SALSalesHeaderCollection SALSalesHeaderCollectionUsingTaxTypeID
		{
			get 
			{
				if (_sALSalesHeaderCollectionTaxTypeID == null)
				{
					_sALSalesHeaderCollectionTaxTypeID = new SALSalesHeaderCollection();
					_sALSalesHeaderCollectionTaxTypeID = SALSalesHeader.SelectByField("TaxTypeID",TaxTypeID, null, TypeOperation.Equal);
				}                
				return _sALSalesHeaderCollectionTaxTypeID; 
			}
			set 
			{
				  _sALSalesHeaderCollectionTaxTypeID = value;
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
		/// DLGenerator			12/26/2014 2:45:51 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool InsertWithDefaultValues(bool getBackValues) 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_taxTypeName' as parameter 'TaxTypeName' of the stored procedure.
			if(_taxTypeNameNonDefault!=null)
			  oDatabaseHelper.AddParameter("@TaxTypeName", _taxTypeNameNonDefault);
			else
			  oDatabaseHelper.AddParameter("@TaxTypeName", DBNull.Value );
			  
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			if(!getBackValues )
			{
				oDatabaseHelper.ExecuteScalar("gsp_BDTaxType_Insert_WithDefaultValues", ref ExecutionState);
			}
			else
			{
				IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDTaxType_Insert_WithDefaultValues_AndReturn", ref ExecutionState);
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
		/// DLGenerator			12/26/2014 2:45:51 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Insert() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_taxTypeName' as parameter 'TaxTypeName' of the stored procedure.
			if(_taxTypeNameNonDefault!=null)
			  oDatabaseHelper.AddParameter("@TaxTypeName", _taxTypeNameNonDefault);
			else
			  oDatabaseHelper.AddParameter("@TaxTypeName", DBNull.Value );
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_BDTaxType_Insert", ref ExecutionState);
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
		/// DLGenerator			12/26/2014 2:45:51 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Update() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_taxTypeID' as parameter 'TaxTypeID' of the stored procedure.
			oDatabaseHelper.AddParameter("@TaxTypeID", _taxTypeIDNonDefault );
			
			// Pass the value of '_taxTypeName' as parameter 'TaxTypeName' of the stored procedure.
			oDatabaseHelper.AddParameter("@TaxTypeName", _taxTypeNameNonDefault );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_BDTaxType_Update", ref ExecutionState);
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
		/// DLGenerator			12/26/2014 2:45:51 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public bool Delete() 
		{
			bool ExecutionState = false;
			oDatabaseHelper = new DatabaseHelper();
			
			// Pass the value of '_taxTypeID' as parameter 'TaxTypeID' of the stored procedure.
			if(_taxTypeIDNonDefault!=null)
				oDatabaseHelper.AddParameter("@TaxTypeID", _taxTypeIDNonDefault );
			else
				oDatabaseHelper.AddParameter("@TaxTypeID", DBNull.Value );
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			oDatabaseHelper.ExecuteScalar("gsp_BDTaxType_Delete", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will Delete one row from the database using the primary key information
		/// </summary>
		///
		/// <param name="pk" type="BDTaxTypePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>True if succeeded</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:51 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static bool Delete(BDTaxTypePrimaryKey pk) 
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
   
			oDatabaseHelper.ExecuteScalar("gsp_BDTaxType_Delete", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="BDTaxTypeFields">Field of the class BDTaxType</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		///
		/// <returns>True if succeeded</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:51 AM		Created function
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
			
			oDatabaseHelper.ExecuteScalar("gsp_BDTaxType_DeleteByField", ref ExecutionState);
			oDatabaseHelper.Dispose();
			return ExecutionState;
			
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="BDTaxTypePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class BDTaxType</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:51 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static BDTaxType SelectOne(BDTaxTypePrimaryKey pk)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDTaxType_SelectbyPrimaryKey", ref ExecutionState);
			if (dr.Read())
			{
				BDTaxType obj=new BDTaxType();	
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
		/// <returns>list of objects of class BDTaxType in the form of object of BDTaxTypeCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:51 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static BDTaxTypeCollection SelectAll()
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDTaxType_SelectAll", ref ExecutionState);
			BDTaxTypeCollection BDTaxTypeCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return BDTaxTypeCollection;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class BDTaxType</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class BDTaxType in the form of an object of class BDTaxTypeCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:51 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static BDTaxTypeCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDTaxType_SelectByField", ref ExecutionState);
			BDTaxTypeCollection BDTaxTypeCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return BDTaxTypeCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number</param>
		///
		/// <returns>list of objects of class BDTaxType in the form of object of BDTaxTypeCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:51 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static BDTaxTypeCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// Pass the specified field and its value to the stored procedure.
			oDatabaseHelper.AddParameter("@PageSize",pageSize);
			oDatabaseHelper.AddParameter("@SkipPages", skipPages);
			oDatabaseHelper.AddParameter("@OrderByStatement", orderByStatement );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDTaxType_SelectAllPaged", ref ExecutionState);
			BDTaxTypeCollection BDTaxTypeCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return BDTaxTypeCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class BDTaxType</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class BDTaxType in the form of an object of class BDTaxTypeCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:51 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static BDTaxTypeCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDTaxType_SelectByFieldPaged", ref ExecutionState);
			BDTaxTypeCollection BDTaxTypeCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return BDTaxTypeCollection;
			
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
		/// DLGenerator			12/26/2014 2:45:51 AM		Created function
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
			
			Object dr=oDatabaseHelper.ExecuteScalar("gsp_BDTaxType_SelectAllCount");
			int count = Convert.ToInt32(dr);		
			oDatabaseHelper.Dispose();
			return count;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="BDTaxTypePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class BDTaxType</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:51 AM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static BDTaxType SelectOneWithPURPurchaseHeaderUsingTaxTypeID(BDTaxTypePrimaryKey pk)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			BDTaxType obj=null;
			
			// Pass the values of all key parameters to the stored procedure.
			System.Collections.Specialized.NameValueCollection nvc = pk.GetKeysAndValues();
			foreach (string key in nvc.Keys)
			{
				oDatabaseHelper.AddParameter("@" + key,nvc[key] );
			}
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDTaxType_SelectOneWithPURPurchaseHeaderUsingTaxTypeID", ref ExecutionState);
			if (dr.Read())
			{
				obj= new BDTaxType();
				PopulateObjectFromReader(obj,dr);
				
				dr.NextResult();
				
				//Get the child records.
				obj.PURPurchaseHeaderCollectionUsingTaxTypeID=PURPurchaseHeader.PopulateObjectsFromReader(dr);
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
		/// <param name="pk" type="BDTaxTypePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class BDTaxType</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:51 AM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static BDTaxType SelectOneWithSALSalesHeaderUsingTaxTypeID(BDTaxTypePrimaryKey pk)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			BDTaxType obj=null;
			
			// Pass the values of all key parameters to the stored procedure.
			System.Collections.Specialized.NameValueCollection nvc = pk.GetKeysAndValues();
			foreach (string key in nvc.Keys)
			{
				oDatabaseHelper.AddParameter("@" + key,nvc[key] );
			}
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_BDTaxType_SelectOneWithSALSalesHeaderUsingTaxTypeID", ref ExecutionState);
			if (dr.Read())
			{
				obj= new BDTaxType();
				PopulateObjectFromReader(obj,dr);
				
				dr.NextResult();
				
				//Get the child records.
				obj.SALSalesHeaderCollectionUsingTaxTypeID=SALSalesHeader.PopulateObjectsFromReader(dr);
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
		/// DLGenerator			12/26/2014 2:45:51 AM		Created function
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
		/// <param name="obj" type="BDTaxType">Object of BDTaxType to populate</param>
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:51 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static void PopulateObjectFromReader(BDTaxTypeBase obj,IDataReader rdr) 
		{

			obj.TaxTypeID = rdr.GetInt32(rdr.GetOrdinal(BDTaxTypeFields.TaxTypeID));
			if (!rdr.IsDBNull(rdr.GetOrdinal(BDTaxTypeFields.TaxTypeName)))
			{
				obj.TaxTypeName = rdr.GetString(rdr.GetOrdinal(BDTaxTypeFields.TaxTypeName));
			}
			

		}

		/// <summary>
		/// Populates the fields for multiple objects from the columns found in an open reader.
		/// </summary>
		///
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <returns>Object of BDTaxTypeCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:51 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static BDTaxTypeCollection PopulateObjectsFromReader(IDataReader rdr) 
		{
			BDTaxTypeCollection list = new BDTaxTypeCollection();
			
			while (rdr.Read())
			{
				BDTaxType obj = new BDTaxType();
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
		/// <returns>Object of BDTaxTypeCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			12/26/2014 2:45:51 AM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static BDTaxTypeCollection PopulateObjectsFromReaderWithCheckingReader(IDataReader rdr, DatabaseHelper oDatabaseHelper) 
		{

			BDTaxTypeCollection list = new BDTaxTypeCollection();
			
            if (rdr.Read())
			{
				BDTaxType obj = new BDTaxType();
				PopulateObjectFromReader(obj, rdr);
				list.Add(obj);
				while (rdr.Read())
				{
					obj = new BDTaxType();
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
