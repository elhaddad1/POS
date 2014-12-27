//
// Class	:	INVStockTypeServices.svc.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:56:00 PM
//


using POS.DataLayer;

namespace POS.BusinessLayer
{
	///<summary>
	///WCF service for the INVStockType
	///</summary>
	public class INVStockTypeService 
	{
		private INVStockType _iNVStockTypeWCF;
		private POS.DataLayer.INVStockType _iNVStockType;
		
		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="INVStockTypeFields">Field of the class INVStockType</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <returns>True if succeeded</returns>
		public bool DeleteByField(string field, object fieldValue)
		{
			return POS.DataLayer.INVStockTypeBase.DeleteByField(field, fieldValue);
		}

		///<summary>
		///This method will Delete the object from the database
		///</summary>
		///<param name="pk" type="INVStockTypePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <returns>True if succeeded</returns>
		public bool Delete(INVStockTypePrimaryKey pk)
		{
			return POS.DataLayer.INVStockTypeBase.Delete(new POS.DataLayer.INVStockTypePrimaryKey(pk.StockTypeID));
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="INVStockTypePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class INVStockType</returns>
		public INVStockType SelectOne(INVStockTypePrimaryKey pk)
		{
			_iNVStockTypeWCF = new INVStockType();
			_iNVStockType = POS.DataLayer.INVStockTypeBase.SelectOne(new POS.DataLayer.INVStockTypePrimaryKey(pk.StockTypeID));
			
				_iNVStockTypeWCF.StockTypeID = _iNVStockType.StockTypeID;
				_iNVStockTypeWCF.StockTypeName = _iNVStockType.StockTypeName;
				
			return _iNVStockTypeWCF;
		}

		/// <summary>
		/// This method will return a list of objects representing all records in the table.
		/// </summary>
		///
		/// <returns>list of objects of class INVStockType in the form of object of INVStockTypeCollection </returns>
		public INVStockTypeCollection SelectAll()
		{
			INVStockTypeCollection iNVStockTypeCollection = new INVStockTypeCollection();
			foreach (POS.DataLayer.INVStockType _iNVStockType in POS.DataLayer.INVStockTypeBase.SelectAll())
			{
				_iNVStockTypeWCF = new INVStockType();
				
				_iNVStockTypeWCF.StockTypeID = _iNVStockType.StockTypeID;
				_iNVStockTypeWCF.StockTypeName = _iNVStockType.StockTypeName;
				
				iNVStockTypeCollection.Add(_iNVStockTypeWCF);
			}
			return iNVStockTypeCollection;
		}
    
    /// <summary>
		/// This method will return a count all records in the table.
		/// </summary>
		///
		/// <returns>count records</returns>
		public int SelectAllCount()
		{
			return POS.DataLayer.INVStockTypeBase.SelectAllCount();			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class INVStockType</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class INVStockType in the form of an object of class INVStockTypeCollection</returns>
		public INVStockTypeCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
		{
			INVStockTypeCollection iNVStockTypeCollection = new INVStockTypeCollection();
			foreach (POS.DataLayer.INVStockType _iNVStockType in POS.DataLayer.INVStockTypeBase.SelectByField(field, fieldValue, fieldValue2, typeOperation))
			{
				_iNVStockTypeWCF = new INVStockType();
				
				_iNVStockTypeWCF.StockTypeID = _iNVStockType.StockTypeID;
				_iNVStockTypeWCF.StockTypeName = _iNVStockType.StockTypeName;
				
				iNVStockTypeCollection.Add(_iNVStockTypeWCF);
			}
			return iNVStockTypeCollection;
		}
		
		/// <summary>
		/// This method will insert one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="iNVStockType" type="INVStockType">This INVStockType  will be inserted in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Insert(INVStockType iNVStockType)
		{
			_iNVStockType = new POS.DataLayer.INVStockType();
			_iNVStockType.StockTypeID=iNVStockType.StockTypeID;
			_iNVStockType.StockTypeName=iNVStockType.StockTypeName;
			
			return _iNVStockType.Insert();
		}
		
		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>list of objects of class INVStockType in the form of an object of class INVStockTypeCollection </returns>
		public INVStockTypeCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			INVStockTypeCollection iNVStockTypeCollection = new INVStockTypeCollection();
			foreach (POS.DataLayer.INVStockType _iNVStockType in POS.DataLayer.INVStockTypeBase.SelectAllPaged(pageSize, skipPages, orderByStatement))
			{
				_iNVStockTypeWCF = new INVStockType();
				
				_iNVStockTypeWCF.StockTypeID = _iNVStockType.StockTypeID;
				_iNVStockTypeWCF.StockTypeName = _iNVStockType.StockTypeName;
				
				iNVStockTypeCollection.Add(_iNVStockTypeWCF);
			}
			return iNVStockTypeCollection;
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class INVStockType</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class INVStockType in the form of an object of class INVStockTypeCollection</returns>
		public INVStockTypeCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
		{
			INVStockTypeCollection iNVStockTypeCollection = new INVStockTypeCollection();
			foreach (POS.DataLayer.INVStockType _iNVStockType in POS.DataLayer.INVStockTypeBase.SelectByFieldPaged(field, fieldValue, fieldValue2, typeOperation, pageSize, skipPages, orderByStatement))
			{
				_iNVStockTypeWCF = new INVStockType();
				
				_iNVStockTypeWCF.StockTypeID = _iNVStockType.StockTypeID;
				_iNVStockTypeWCF.StockTypeName = _iNVStockType.StockTypeName;
				
				iNVStockTypeCollection.Add(_iNVStockTypeWCF);
			}
			return iNVStockTypeCollection;
		}
			///<summary>
		/// This method will update one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="iNVStockType" type="INVStockType">This INVStockType  will be updated in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Update(INVStockType iNVStockType)
		{
			_iNVStockType=POS.DataLayer.INVStockType.SelectOne(new POS.DataLayer.INVStockTypePrimaryKey(iNVStockType.StockTypeID));
			
			_iNVStockType.StockTypeName=iNVStockType.StockTypeName;
			
			return _iNVStockType.Update();
		}
	} 
}
