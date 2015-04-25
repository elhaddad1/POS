//
// Class	:	VProductBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	4/25/2015 1:10:32 PM
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
	public class VProductFields
	{
		public const string ProductID                 = "ProductID";
		public const string ProductName               = "ProductName";
		public const string ProductGroupID            = "ProductGroupID";
		public const string ProductCode               = "ProductCode";
		public const string IsAcceptBatch             = "IsAcceptBatch";
		public const string ProductPrice              = "ProductPrice";
		public const string IsFixedPrice              = "IsFixedPrice";
		public const string HasDiscount               = "HasDiscount";
		public const string DiscountAmount            = "DiscountAmount";
		public const string DescountRatio             = "DescountRatio";
		public const string IsActive                  = "IsActive";
		public const string Notes                     = "Notes";
		public const string MinPrice                  = "MinPrice";
		public const string MaxPrice                  = "MaxPrice";
		public const string ProductGroupName          = "ProductGroupName";
	}
	
	/// <summary>
	/// Data access class for the "VProducts" table.
	/// </summary>
	[Serializable]
	public class VProductBase
	{
		
		#region Class Level Variables
		
		private DatabaseHelper oDatabaseHelper = new DatabaseHelper();

		private int?           	_productIDNonDefault     	= null;
		private string         	_productNameNonDefault   	= null;
		private int?           	_productGroupIDNonDefault	= null;
		private string         	_productCodeNonDefault   	= null;
		private bool?          	_isAcceptBatchNonDefault 	= null;
		private decimal?       	_productPriceNonDefault  	= null;
		private bool?          	_isFixedPriceNonDefault  	= null;
		private bool?          	_hasDiscountNonDefault   	= null;
		private decimal?       	_discountAmountNonDefault	= null;
		private double?        	_descountRatioNonDefault 	= null;
		private bool?          	_isActiveNonDefault      	= null;
		private string         	_notesNonDefault         	= null;
		private decimal?       	_minPriceNonDefault      	= null;
		private decimal?       	_maxPriceNonDefault      	= null;
		private string         	_productGroupNameNonDefault	= null;
		
		#endregion
		
		#region Constants
		
		#endregion
		
		#region Constructors / Destructors

		/// <summary>
		/// Class Constructor
		///</summary>
		public VProductBase() { }
					
		#endregion
		
		#region Properties

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
		/// This property is mapped to the "ProductGroupID" field.  
		/// </summary>
		public int? ProductGroupID
		{
			get 
			{ 
				return _productGroupIDNonDefault;
			}
			set 
			{
			
				_productGroupIDNonDefault = value; 
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
		/// This property is mapped to the "ProductPrice" field.  
		/// </summary>
		public decimal? ProductPrice
		{
			get 
			{ 
				return _productPriceNonDefault;
			}
			set 
			{
			
				_productPriceNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "IsFixedPrice" field.  
		/// </summary>
		public bool? IsFixedPrice
		{
			get 
			{ 
				return _isFixedPriceNonDefault;
			}
			set 
			{
			
				_isFixedPriceNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "HasDiscount" field.  
		/// </summary>
		public bool? HasDiscount
		{
			get 
			{ 
				return _hasDiscountNonDefault;
			}
			set 
			{
			
				_hasDiscountNonDefault = value; 
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
		/// This property is mapped to the "DescountRatio" field.  
		/// </summary>
		public double? DescountRatio
		{
			get 
			{ 
				return _descountRatioNonDefault;
			}
			set 
			{
			
				_descountRatioNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "IsActive" field.  
		/// </summary>
		public bool? IsActive
		{
			get 
			{ 
				return _isActiveNonDefault;
			}
			set 
			{
			
				_isActiveNonDefault = value; 
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
		/// This property is mapped to the "MinPrice" field.  
		/// </summary>
		public decimal? MinPrice
		{
			get 
			{ 
				return _minPriceNonDefault;
			}
			set 
			{
			
				_minPriceNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "MaxPrice" field.  
		/// </summary>
		public decimal? MaxPrice
		{
			get 
			{ 
				return _maxPriceNonDefault;
			}
			set 
			{
			
				_maxPriceNonDefault = value; 
			}
		}

		/// <summary>
		/// This property is mapped to the "ProductGroupName" field. Length must be between 0 and 50 characters. Mandatory.
		/// </summary>
		public string ProductGroupName
		{
			get 
			{ 
				if(_productGroupNameNonDefault==null)return _productGroupNameNonDefault;
				else return _productGroupNameNonDefault.Trim(); 
			}
			set 
			{
			    if (value == null)
					throw new ArgumentNullException("value", "Value is null.");
				   if (value != null && value.Length > 50)
					throw new ArgumentException("ProductGroupName length must be between 0 and 50 characters.");

				
				if(value ==null)
				{
					_productGroupNameNonDefault =null;//null value 
				}
				else
				{		           
					_productGroupNameNonDefault = value.Trim(); 
				}
			}
		}

		#endregion
		
		#region Methods (Public)

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="VProductPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class VProduct</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			4/25/2015 1:10:32 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static VProduct SelectOne(VProductPrimaryKey pk)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_VProducts_SelectbyPrimaryKey", ref ExecutionState);
			if (dr.Read())
			{
				VProduct obj=new VProduct();	
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
		/// <returns>list of objects of class VProduct in the form of object of VProductCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			4/25/2015 1:10:32 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static VProductCollection SelectAll()
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_VProducts_SelectAll", ref ExecutionState);
			VProductCollection VProductCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return VProductCollection;
			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class VProduct</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class VProduct in the form of an object of class VProductCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			4/25/2015 1:10:32 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static VProductCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_VProducts_SelectByField", ref ExecutionState);
			VProductCollection VProductCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return VProductCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number</param>
		///
		/// <returns>list of objects of class VProduct in the form of object of VProductCollection </returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			4/25/2015 1:10:32 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static VProductCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			DatabaseHelper oDatabaseHelper = new DatabaseHelper();
			bool ExecutionState = false;
			
			// Pass the specified field and its value to the stored procedure.
			oDatabaseHelper.AddParameter("@PageSize",pageSize);
			oDatabaseHelper.AddParameter("@SkipPages", skipPages);
			oDatabaseHelper.AddParameter("@OrderByStatement", orderByStatement );
			
			// The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
			oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_VProducts_SelectAllPaged", ref ExecutionState);
			VProductCollection VProductCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return VProductCollection;
			
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class VProduct</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class VProduct in the form of an object of class VProductCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			4/25/2015 1:10:32 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public static VProductCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
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
			
			IDataReader dr=oDatabaseHelper.ExecuteReader("gsp_VProducts_SelectByFieldPaged", ref ExecutionState);
			VProductCollection VProductCollection = PopulateObjectsFromReader(dr);
			dr.Close();
			oDatabaseHelper.Dispose();
			return VProductCollection;
			
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
		/// DLGenerator			4/25/2015 1:10:32 PM		Created function
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
			
			Object dr=oDatabaseHelper.ExecuteScalar("gsp_VProducts_SelectAllCount");
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
		/// DLGenerator			4/25/2015 1:10:32 PM		Created function
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
		/// <param name="obj" type="VProducts">Object of VProducts to populate</param>
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			4/25/2015 1:10:32 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static void PopulateObjectFromReader(VProductBase obj,IDataReader rdr) 
		{

			obj.ProductID = rdr.GetInt32(rdr.GetOrdinal(VProductFields.ProductID));
			obj.ProductName = rdr.GetString(rdr.GetOrdinal(VProductFields.ProductName));
			if (!rdr.IsDBNull(rdr.GetOrdinal(VProductFields.ProductGroupID)))
			{
				obj.ProductGroupID = rdr.GetInt32(rdr.GetOrdinal(VProductFields.ProductGroupID));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(VProductFields.ProductCode)))
			{
				obj.ProductCode = rdr.GetString(rdr.GetOrdinal(VProductFields.ProductCode));
			}
			
			obj.IsAcceptBatch = rdr.GetBoolean(rdr.GetOrdinal(VProductFields.IsAcceptBatch));
			if (!rdr.IsDBNull(rdr.GetOrdinal(VProductFields.ProductPrice)))
			{
				obj.ProductPrice = rdr.GetDecimal(rdr.GetOrdinal(VProductFields.ProductPrice));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(VProductFields.IsFixedPrice)))
			{
				obj.IsFixedPrice = rdr.GetBoolean(rdr.GetOrdinal(VProductFields.IsFixedPrice));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(VProductFields.HasDiscount)))
			{
				obj.HasDiscount = rdr.GetBoolean(rdr.GetOrdinal(VProductFields.HasDiscount));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(VProductFields.DiscountAmount)))
			{
				obj.DiscountAmount = rdr.GetDecimal(rdr.GetOrdinal(VProductFields.DiscountAmount));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(VProductFields.DescountRatio)))
			{
				obj.DescountRatio = rdr.GetDouble(rdr.GetOrdinal(VProductFields.DescountRatio));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(VProductFields.IsActive)))
			{
				obj.IsActive = rdr.GetBoolean(rdr.GetOrdinal(VProductFields.IsActive));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(VProductFields.Notes)))
			{
				obj.Notes = rdr.GetString(rdr.GetOrdinal(VProductFields.Notes));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(VProductFields.MinPrice)))
			{
				obj.MinPrice = rdr.GetDecimal(rdr.GetOrdinal(VProductFields.MinPrice));
			}
			
			if (!rdr.IsDBNull(rdr.GetOrdinal(VProductFields.MaxPrice)))
			{
				obj.MaxPrice = rdr.GetDecimal(rdr.GetOrdinal(VProductFields.MaxPrice));
			}
			
			obj.ProductGroupName = rdr.GetString(rdr.GetOrdinal(VProductFields.ProductGroupName));

		}

		/// <summary>
		/// Populates the fields for multiple objects from the columns found in an open reader.
		/// </summary>
		///
		/// <param name="rdr" type="IDataReader">An object that implements the IDataReader interface</param>
		///
		/// <returns>Object of VProductCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			4/25/2015 1:10:32 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static VProductCollection PopulateObjectsFromReader(IDataReader rdr) 
		{
			VProductCollection list = new VProductCollection();
			
			while (rdr.Read())
			{
				VProduct obj = new VProduct();
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
		/// <returns>Object of VProductCollection</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			4/25/2015 1:10:32 PM		Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		internal static VProductCollection PopulateObjectsFromReaderWithCheckingReader(IDataReader rdr, DatabaseHelper oDatabaseHelper) 
		{

			VProductCollection list = new VProductCollection();
			
            if (rdr.Read())
			{
				VProduct obj = new VProduct();
				PopulateObjectFromReader(obj, rdr);
				list.Add(obj);
				while (rdr.Read())
				{
					obj = new VProduct();
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
