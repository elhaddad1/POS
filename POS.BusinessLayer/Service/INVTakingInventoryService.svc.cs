//
// Class	:	INVTakingInventoryServices.svc.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	3/7/2015 2:37:12 PM
//

using POS.DataLayer;

namespace POS.BusinessLayer
{
	///<summary>
	///WCF service for the INVTakingInventory
	///</summary>
	public class INVTakingInventoryService 
	{
		private INVTakingInventory _iNVTakingInventoryWCF;
		private POS.DataLayer.INVTakingInventory _iNVTakingInventory;
		
		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="INVTakingInventoryFields">Field of the class INVTakingInventory</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <returns>True if succeeded</returns>
		public bool DeleteByField(string field, object fieldValue)
		{
			return POS.DataLayer.INVTakingInventoryBase.DeleteByField(field, fieldValue);
		}

		///<summary>
		///This method will Delete the object from the database
		///</summary>
		///<param name="pk" type="INVTakingInventoryPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <returns>True if succeeded</returns>
		public bool Delete(INVTakingInventoryPrimaryKey pk)
		{
			return POS.DataLayer.INVTakingInventoryBase.Delete(new POS.DataLayer.INVTakingInventoryPrimaryKey(pk.TakingHeaderID));
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="INVTakingInventoryPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class INVTakingInventory</returns>
		public INVTakingInventory SelectOne(INVTakingInventoryPrimaryKey pk)
		{
			_iNVTakingInventoryWCF = new INVTakingInventory();
			_iNVTakingInventory = POS.DataLayer.INVTakingInventoryBase.SelectOne(new POS.DataLayer.INVTakingInventoryPrimaryKey(pk.TakingHeaderID));
			
				_iNVTakingInventoryWCF.TakingHeaderID = _iNVTakingInventory.TakingHeaderID;
				_iNVTakingInventoryWCF.TakingDate = _iNVTakingInventory.TakingDate;
				_iNVTakingInventoryWCF.TakingName = _iNVTakingInventory.TakingName;
				_iNVTakingInventoryWCF.CreatedBy = _iNVTakingInventory.CreatedBy;
				_iNVTakingInventoryWCF.CreatedDate = _iNVTakingInventory.CreatedDate;
				_iNVTakingInventoryWCF.UpdatedBy = _iNVTakingInventory.UpdatedBy;
				_iNVTakingInventoryWCF.UpdateDate = _iNVTakingInventory.UpdateDate;
				_iNVTakingInventoryWCF.IsDeleted = _iNVTakingInventory.IsDeleted;
				_iNVTakingInventoryWCF.DeletedBy = _iNVTakingInventory.DeletedBy;
				_iNVTakingInventoryWCF.DeletedDate = _iNVTakingInventory.DeletedDate;
				_iNVTakingInventoryWCF.Notes = _iNVTakingInventory.Notes;
				_iNVTakingInventoryWCF.InventoryID = _iNVTakingInventory.InventoryID;
				
			return _iNVTakingInventoryWCF;
		}

		/// <summary>
		/// This method will return a list of objects representing all records in the table.
		/// </summary>
		///
		/// <returns>list of objects of class INVTakingInventory in the form of object of INVTakingInventoryCollection </returns>
		public INVTakingInventoryCollection SelectAll()
		{
			INVTakingInventoryCollection iNVTakingInventoryCollection = new INVTakingInventoryCollection();
			foreach (POS.DataLayer.INVTakingInventory _iNVTakingInventory in POS.DataLayer.INVTakingInventoryBase.SelectAll())
			{
				_iNVTakingInventoryWCF = new INVTakingInventory();
				
				_iNVTakingInventoryWCF.TakingHeaderID = _iNVTakingInventory.TakingHeaderID;
				_iNVTakingInventoryWCF.TakingDate = _iNVTakingInventory.TakingDate;
				_iNVTakingInventoryWCF.TakingName = _iNVTakingInventory.TakingName;
				_iNVTakingInventoryWCF.CreatedBy = _iNVTakingInventory.CreatedBy;
				_iNVTakingInventoryWCF.CreatedDate = _iNVTakingInventory.CreatedDate;
				_iNVTakingInventoryWCF.UpdatedBy = _iNVTakingInventory.UpdatedBy;
				_iNVTakingInventoryWCF.UpdateDate = _iNVTakingInventory.UpdateDate;
				_iNVTakingInventoryWCF.IsDeleted = _iNVTakingInventory.IsDeleted;
				_iNVTakingInventoryWCF.DeletedBy = _iNVTakingInventory.DeletedBy;
				_iNVTakingInventoryWCF.DeletedDate = _iNVTakingInventory.DeletedDate;
				_iNVTakingInventoryWCF.Notes = _iNVTakingInventory.Notes;
				_iNVTakingInventoryWCF.InventoryID = _iNVTakingInventory.InventoryID;
				
				iNVTakingInventoryCollection.Add(_iNVTakingInventoryWCF);
			}
			return iNVTakingInventoryCollection;
		}
    
    /// <summary>
		/// This method will return a count all records in the table.
		/// </summary>
		///
		/// <returns>count records</returns>
		public int SelectAllCount()
		{
			return POS.DataLayer.INVTakingInventoryBase.SelectAllCount();			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class INVTakingInventory</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class INVTakingInventory in the form of an object of class INVTakingInventoryCollection</returns>
		public INVTakingInventoryCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
		{
			INVTakingInventoryCollection iNVTakingInventoryCollection = new INVTakingInventoryCollection();
			foreach (POS.DataLayer.INVTakingInventory _iNVTakingInventory in POS.DataLayer.INVTakingInventoryBase.SelectByField(field, fieldValue, fieldValue2, typeOperation))
			{
				_iNVTakingInventoryWCF = new INVTakingInventory();
				
				_iNVTakingInventoryWCF.TakingHeaderID = _iNVTakingInventory.TakingHeaderID;
				_iNVTakingInventoryWCF.TakingDate = _iNVTakingInventory.TakingDate;
				_iNVTakingInventoryWCF.TakingName = _iNVTakingInventory.TakingName;
				_iNVTakingInventoryWCF.CreatedBy = _iNVTakingInventory.CreatedBy;
				_iNVTakingInventoryWCF.CreatedDate = _iNVTakingInventory.CreatedDate;
				_iNVTakingInventoryWCF.UpdatedBy = _iNVTakingInventory.UpdatedBy;
				_iNVTakingInventoryWCF.UpdateDate = _iNVTakingInventory.UpdateDate;
				_iNVTakingInventoryWCF.IsDeleted = _iNVTakingInventory.IsDeleted;
				_iNVTakingInventoryWCF.DeletedBy = _iNVTakingInventory.DeletedBy;
				_iNVTakingInventoryWCF.DeletedDate = _iNVTakingInventory.DeletedDate;
				_iNVTakingInventoryWCF.Notes = _iNVTakingInventory.Notes;
				_iNVTakingInventoryWCF.InventoryID = _iNVTakingInventory.InventoryID;
				
				iNVTakingInventoryCollection.Add(_iNVTakingInventoryWCF);
			}
			return iNVTakingInventoryCollection;
		}
		
		/// <summary>
		/// This method will insert one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="iNVTakingInventory" type="INVTakingInventory">This INVTakingInventory  will be inserted in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Insert(INVTakingInventory iNVTakingInventory)
		{
			_iNVTakingInventory = new POS.DataLayer.INVTakingInventory();
			_iNVTakingInventory.TakingHeaderID=iNVTakingInventory.TakingHeaderID;
			_iNVTakingInventory.TakingDate=iNVTakingInventory.TakingDate;
			_iNVTakingInventory.TakingName=iNVTakingInventory.TakingName;
			_iNVTakingInventory.CreatedBy=iNVTakingInventory.CreatedBy;
			_iNVTakingInventory.CreatedDate=iNVTakingInventory.CreatedDate;
			_iNVTakingInventory.UpdatedBy=iNVTakingInventory.UpdatedBy;
			_iNVTakingInventory.UpdateDate=iNVTakingInventory.UpdateDate;
			_iNVTakingInventory.IsDeleted=iNVTakingInventory.IsDeleted;
			_iNVTakingInventory.DeletedBy=iNVTakingInventory.DeletedBy;
			_iNVTakingInventory.DeletedDate=iNVTakingInventory.DeletedDate;
			_iNVTakingInventory.Notes=iNVTakingInventory.Notes;
			_iNVTakingInventory.InventoryID=iNVTakingInventory.InventoryID;
			
			return _iNVTakingInventory.Insert();
		}
		
		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>list of objects of class INVTakingInventory in the form of an object of class INVTakingInventoryCollection </returns>
		public INVTakingInventoryCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			INVTakingInventoryCollection iNVTakingInventoryCollection = new INVTakingInventoryCollection();
			foreach (POS.DataLayer.INVTakingInventory _iNVTakingInventory in POS.DataLayer.INVTakingInventoryBase.SelectAllPaged(pageSize, skipPages, orderByStatement))
			{
				_iNVTakingInventoryWCF = new INVTakingInventory();
				
				_iNVTakingInventoryWCF.TakingHeaderID = _iNVTakingInventory.TakingHeaderID;
				_iNVTakingInventoryWCF.TakingDate = _iNVTakingInventory.TakingDate;
				_iNVTakingInventoryWCF.TakingName = _iNVTakingInventory.TakingName;
				_iNVTakingInventoryWCF.CreatedBy = _iNVTakingInventory.CreatedBy;
				_iNVTakingInventoryWCF.CreatedDate = _iNVTakingInventory.CreatedDate;
				_iNVTakingInventoryWCF.UpdatedBy = _iNVTakingInventory.UpdatedBy;
				_iNVTakingInventoryWCF.UpdateDate = _iNVTakingInventory.UpdateDate;
				_iNVTakingInventoryWCF.IsDeleted = _iNVTakingInventory.IsDeleted;
				_iNVTakingInventoryWCF.DeletedBy = _iNVTakingInventory.DeletedBy;
				_iNVTakingInventoryWCF.DeletedDate = _iNVTakingInventory.DeletedDate;
				_iNVTakingInventoryWCF.Notes = _iNVTakingInventory.Notes;
				_iNVTakingInventoryWCF.InventoryID = _iNVTakingInventory.InventoryID;
				
				iNVTakingInventoryCollection.Add(_iNVTakingInventoryWCF);
			}
			return iNVTakingInventoryCollection;
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class INVTakingInventory</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class INVTakingInventory in the form of an object of class INVTakingInventoryCollection</returns>
		public INVTakingInventoryCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
		{
			INVTakingInventoryCollection iNVTakingInventoryCollection = new INVTakingInventoryCollection();
			foreach (POS.DataLayer.INVTakingInventory _iNVTakingInventory in POS.DataLayer.INVTakingInventoryBase.SelectByFieldPaged(field, fieldValue, fieldValue2, typeOperation, pageSize, skipPages, orderByStatement))
			{
				_iNVTakingInventoryWCF = new INVTakingInventory();
				
				_iNVTakingInventoryWCF.TakingHeaderID = _iNVTakingInventory.TakingHeaderID;
				_iNVTakingInventoryWCF.TakingDate = _iNVTakingInventory.TakingDate;
				_iNVTakingInventoryWCF.TakingName = _iNVTakingInventory.TakingName;
				_iNVTakingInventoryWCF.CreatedBy = _iNVTakingInventory.CreatedBy;
				_iNVTakingInventoryWCF.CreatedDate = _iNVTakingInventory.CreatedDate;
				_iNVTakingInventoryWCF.UpdatedBy = _iNVTakingInventory.UpdatedBy;
				_iNVTakingInventoryWCF.UpdateDate = _iNVTakingInventory.UpdateDate;
				_iNVTakingInventoryWCF.IsDeleted = _iNVTakingInventory.IsDeleted;
				_iNVTakingInventoryWCF.DeletedBy = _iNVTakingInventory.DeletedBy;
				_iNVTakingInventoryWCF.DeletedDate = _iNVTakingInventory.DeletedDate;
				_iNVTakingInventoryWCF.Notes = _iNVTakingInventory.Notes;
				_iNVTakingInventoryWCF.InventoryID = _iNVTakingInventory.InventoryID;
				
				iNVTakingInventoryCollection.Add(_iNVTakingInventoryWCF);
			}
			return iNVTakingInventoryCollection;
		}
			///<summary>
		/// This method will update one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="iNVTakingInventory" type="INVTakingInventory">This INVTakingInventory  will be updated in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Update(INVTakingInventory iNVTakingInventory)
		{
			_iNVTakingInventory=POS.DataLayer.INVTakingInventory.SelectOne(new POS.DataLayer.INVTakingInventoryPrimaryKey(iNVTakingInventory.TakingHeaderID));
			
			_iNVTakingInventory.TakingDate=iNVTakingInventory.TakingDate;
			_iNVTakingInventory.TakingName=iNVTakingInventory.TakingName;
			_iNVTakingInventory.CreatedBy=iNVTakingInventory.CreatedBy;
			_iNVTakingInventory.CreatedDate=iNVTakingInventory.CreatedDate;
			_iNVTakingInventory.UpdatedBy=iNVTakingInventory.UpdatedBy;
			_iNVTakingInventory.UpdateDate=iNVTakingInventory.UpdateDate;
			_iNVTakingInventory.IsDeleted=iNVTakingInventory.IsDeleted;
			_iNVTakingInventory.DeletedBy=iNVTakingInventory.DeletedBy;
			_iNVTakingInventory.DeletedDate=iNVTakingInventory.DeletedDate;
			_iNVTakingInventory.Notes=iNVTakingInventory.Notes;
			_iNVTakingInventory.InventoryID=iNVTakingInventory.InventoryID;
			
			return _iNVTakingInventory.Update();
		}
	} 
}
