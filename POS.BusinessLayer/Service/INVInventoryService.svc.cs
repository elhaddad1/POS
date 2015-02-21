//
// Class	:	INVInventoryServices.svc.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	2/20/2015 7:03:50 PM
//

using POS.DataLayer;

namespace POS.BusinessLayer
{
	///<summary>
	///WCF service for the INVInventory
	///</summary>
	public class INVInventoryService 
	{
		private INVInventory _iNVInventoryWCF;
		private POS.DataLayer.INVInventory _iNVInventory;
		
		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="INVInventoryFields">Field of the class INVInventory</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <returns>True if succeeded</returns>
		public bool DeleteByField(string field, object fieldValue)
		{
			return POS.DataLayer.INVInventoryBase.DeleteByField(field, fieldValue);
		}

		///<summary>
		///This method will Delete the object from the database
		///</summary>
		///<param name="pk" type="INVInventoryPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <returns>True if succeeded</returns>
		public bool Delete(INVInventoryPrimaryKey pk)
		{
			return POS.DataLayer.INVInventoryBase.Delete(new POS.DataLayer.INVInventoryPrimaryKey(pk.InventoryID));
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="INVInventoryPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class INVInventory</returns>
		public INVInventory SelectOne(INVInventoryPrimaryKey pk)
		{
			_iNVInventoryWCF = new INVInventory();
			_iNVInventory = POS.DataLayer.INVInventoryBase.SelectOne(new POS.DataLayer.INVInventoryPrimaryKey(pk.InventoryID));
			
				_iNVInventoryWCF.InventoryID = _iNVInventory.InventoryID;
				_iNVInventoryWCF.InventoryName = _iNVInventory.InventoryName;
				_iNVInventoryWCF.Notes = _iNVInventory.Notes;
				_iNVInventoryWCF.IsBasic = _iNVInventory.IsBasic;
				
			return _iNVInventoryWCF;
		}

		/// <summary>
		/// This method will return a list of objects representing all records in the table.
		/// </summary>
		///
		/// <returns>list of objects of class INVInventory in the form of object of INVInventoryCollection </returns>
		public INVInventoryCollection SelectAll()
		{
			INVInventoryCollection iNVInventoryCollection = new INVInventoryCollection();
			foreach (POS.DataLayer.INVInventory _iNVInventory in POS.DataLayer.INVInventoryBase.SelectAll())
			{
				_iNVInventoryWCF = new INVInventory();
				
				_iNVInventoryWCF.InventoryID = _iNVInventory.InventoryID;
				_iNVInventoryWCF.InventoryName = _iNVInventory.InventoryName;
				_iNVInventoryWCF.Notes = _iNVInventory.Notes;
				_iNVInventoryWCF.IsBasic = _iNVInventory.IsBasic;
				
				iNVInventoryCollection.Add(_iNVInventoryWCF);
			}
			return iNVInventoryCollection;
		}
    
    /// <summary>
		/// This method will return a count all records in the table.
		/// </summary>
		///
		/// <returns>count records</returns>
		public int SelectAllCount()
		{
			return POS.DataLayer.INVInventoryBase.SelectAllCount();			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class INVInventory</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class INVInventory in the form of an object of class INVInventoryCollection</returns>
		public INVInventoryCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
		{
			INVInventoryCollection iNVInventoryCollection = new INVInventoryCollection();
			foreach (POS.DataLayer.INVInventory _iNVInventory in POS.DataLayer.INVInventoryBase.SelectByField(field, fieldValue, fieldValue2, typeOperation))
			{
				_iNVInventoryWCF = new INVInventory();
				
				_iNVInventoryWCF.InventoryID = _iNVInventory.InventoryID;
				_iNVInventoryWCF.InventoryName = _iNVInventory.InventoryName;
				_iNVInventoryWCF.Notes = _iNVInventory.Notes;
				_iNVInventoryWCF.IsBasic = _iNVInventory.IsBasic;
				
				iNVInventoryCollection.Add(_iNVInventoryWCF);
			}
			return iNVInventoryCollection;
		}
		
		/// <summary>
		/// This method will insert one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="iNVInventory" type="INVInventory">This INVInventory  will be inserted in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Insert(INVInventory iNVInventory)
		{
			_iNVInventory = new POS.DataLayer.INVInventory();
			_iNVInventory.InventoryID=iNVInventory.InventoryID;
			_iNVInventory.InventoryName=iNVInventory.InventoryName;
			_iNVInventory.Notes=iNVInventory.Notes;
			_iNVInventory.IsBasic=iNVInventory.IsBasic;
			
			return _iNVInventory.Insert();
		}
		
		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>list of objects of class INVInventory in the form of an object of class INVInventoryCollection </returns>
		public INVInventoryCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			INVInventoryCollection iNVInventoryCollection = new INVInventoryCollection();
			foreach (POS.DataLayer.INVInventory _iNVInventory in POS.DataLayer.INVInventoryBase.SelectAllPaged(pageSize, skipPages, orderByStatement))
			{
				_iNVInventoryWCF = new INVInventory();
				
				_iNVInventoryWCF.InventoryID = _iNVInventory.InventoryID;
				_iNVInventoryWCF.InventoryName = _iNVInventory.InventoryName;
				_iNVInventoryWCF.Notes = _iNVInventory.Notes;
				_iNVInventoryWCF.IsBasic = _iNVInventory.IsBasic;
				
				iNVInventoryCollection.Add(_iNVInventoryWCF);
			}
			return iNVInventoryCollection;
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class INVInventory</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class INVInventory in the form of an object of class INVInventoryCollection</returns>
		public INVInventoryCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
		{
			INVInventoryCollection iNVInventoryCollection = new INVInventoryCollection();
			foreach (POS.DataLayer.INVInventory _iNVInventory in POS.DataLayer.INVInventoryBase.SelectByFieldPaged(field, fieldValue, fieldValue2, typeOperation, pageSize, skipPages, orderByStatement))
			{
				_iNVInventoryWCF = new INVInventory();
				
				_iNVInventoryWCF.InventoryID = _iNVInventory.InventoryID;
				_iNVInventoryWCF.InventoryName = _iNVInventory.InventoryName;
				_iNVInventoryWCF.Notes = _iNVInventory.Notes;
				_iNVInventoryWCF.IsBasic = _iNVInventory.IsBasic;
				
				iNVInventoryCollection.Add(_iNVInventoryWCF);
			}
			return iNVInventoryCollection;
		}
			///<summary>
		/// This method will update one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="iNVInventory" type="INVInventory">This INVInventory  will be updated in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Update(INVInventory iNVInventory)
		{
			_iNVInventory=POS.DataLayer.INVInventory.SelectOne(new POS.DataLayer.INVInventoryPrimaryKey(iNVInventory.InventoryID));
			
			_iNVInventory.InventoryName=iNVInventory.InventoryName;
			_iNVInventory.Notes=iNVInventory.Notes;
			_iNVInventory.IsBasic=iNVInventory.IsBasic;
			
			return _iNVInventory.Update();
		}
	} 
}
