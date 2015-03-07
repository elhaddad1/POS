//
// Class	:	INVProductStockServices.svc.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	3/7/2015 2:37:24 PM
//


using POS.DataLayer;

namespace POS.BusinessLayer
{
	///<summary>
	///WCF service for the INVProductStock
	///</summary>
	public class INVProductStockService 
	{
		private INVProductStock _iNVProductStockWCF;
		private POS.DataLayer.INVProductStock _iNVProductStock;
		
		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="INVProductStockFields">Field of the class INVProductStock</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <returns>True if succeeded</returns>
		public bool DeleteByField(string field, object fieldValue)
		{
			return POS.DataLayer.INVProductStockBase.DeleteByField(field, fieldValue);
		}

		///<summary>
		///This method will Delete the object from the database
		///</summary>
		///<param name="pk" type="INVProductStockPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <returns>True if succeeded</returns>
		public bool Delete(INVProductStockPrimaryKey pk)
		{
			return POS.DataLayer.INVProductStockBase.Delete(new POS.DataLayer.INVProductStockPrimaryKey(pk.ProductStockID));
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="INVProductStockPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class INVProductStock</returns>
		public INVProductStock SelectOne(INVProductStockPrimaryKey pk)
		{
			_iNVProductStockWCF = new INVProductStock();
			_iNVProductStock = POS.DataLayer.INVProductStockBase.SelectOne(new POS.DataLayer.INVProductStockPrimaryKey(pk.ProductStockID));
			
				_iNVProductStockWCF.ProductStockID = _iNVProductStock.ProductStockID;
				_iNVProductStockWCF.ProductID = _iNVProductStock.ProductID;
				_iNVProductStockWCF.TotalQty = _iNVProductStock.TotalQty;
				_iNVProductStockWCF.StockTypeID = _iNVProductStock.StockTypeID;
				_iNVProductStockWCF.OpeningQty = _iNVProductStock.OpeningQty;
				_iNVProductStockWCF.OpennigDate = _iNVProductStock.OpennigDate;
				_iNVProductStockWCF.CreateDate = _iNVProductStock.CreateDate;
				_iNVProductStockWCF.CreatedBy = _iNVProductStock.CreatedBy;
				_iNVProductStockWCF.UpdateDate = _iNVProductStock.UpdateDate;
				_iNVProductStockWCF.UpdatedBy = _iNVProductStock.UpdatedBy;
				_iNVProductStockWCF.InventoryID = _iNVProductStock.InventoryID;
				_iNVProductStockWCF.IsBlocked = _iNVProductStock.IsBlocked;
				
			return _iNVProductStockWCF;
		}

		/// <summary>
		/// This method will return a list of objects representing all records in the table.
		/// </summary>
		///
		/// <returns>list of objects of class INVProductStock in the form of object of INVProductStockCollection </returns>
		public INVProductStockCollection SelectAll()
		{
			INVProductStockCollection iNVProductStockCollection = new INVProductStockCollection();
			foreach (POS.DataLayer.INVProductStock _iNVProductStock in POS.DataLayer.INVProductStockBase.SelectAll())
			{
				_iNVProductStockWCF = new INVProductStock();
				
				_iNVProductStockWCF.ProductStockID = _iNVProductStock.ProductStockID;
				_iNVProductStockWCF.ProductID = _iNVProductStock.ProductID;
				_iNVProductStockWCF.TotalQty = _iNVProductStock.TotalQty;
				_iNVProductStockWCF.StockTypeID = _iNVProductStock.StockTypeID;
				_iNVProductStockWCF.OpeningQty = _iNVProductStock.OpeningQty;
				_iNVProductStockWCF.OpennigDate = _iNVProductStock.OpennigDate;
				_iNVProductStockWCF.CreateDate = _iNVProductStock.CreateDate;
				_iNVProductStockWCF.CreatedBy = _iNVProductStock.CreatedBy;
				_iNVProductStockWCF.UpdateDate = _iNVProductStock.UpdateDate;
				_iNVProductStockWCF.UpdatedBy = _iNVProductStock.UpdatedBy;
				_iNVProductStockWCF.InventoryID = _iNVProductStock.InventoryID;
				_iNVProductStockWCF.IsBlocked = _iNVProductStock.IsBlocked;
				
				iNVProductStockCollection.Add(_iNVProductStockWCF);
			}
			return iNVProductStockCollection;
		}
    
    /// <summary>
		/// This method will return a count all records in the table.
		/// </summary>
		///
		/// <returns>count records</returns>
		public int SelectAllCount()
		{
			return POS.DataLayer.INVProductStockBase.SelectAllCount();			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class INVProductStock</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class INVProductStock in the form of an object of class INVProductStockCollection</returns>
		public INVProductStockCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
		{
			INVProductStockCollection iNVProductStockCollection = new INVProductStockCollection();
			foreach (POS.DataLayer.INVProductStock _iNVProductStock in POS.DataLayer.INVProductStockBase.SelectByField(field, fieldValue, fieldValue2, typeOperation))
			{
				_iNVProductStockWCF = new INVProductStock();
				
				_iNVProductStockWCF.ProductStockID = _iNVProductStock.ProductStockID;
				_iNVProductStockWCF.ProductID = _iNVProductStock.ProductID;
				_iNVProductStockWCF.TotalQty = _iNVProductStock.TotalQty;
				_iNVProductStockWCF.StockTypeID = _iNVProductStock.StockTypeID;
				_iNVProductStockWCF.OpeningQty = _iNVProductStock.OpeningQty;
				_iNVProductStockWCF.OpennigDate = _iNVProductStock.OpennigDate;
				_iNVProductStockWCF.CreateDate = _iNVProductStock.CreateDate;
				_iNVProductStockWCF.CreatedBy = _iNVProductStock.CreatedBy;
				_iNVProductStockWCF.UpdateDate = _iNVProductStock.UpdateDate;
				_iNVProductStockWCF.UpdatedBy = _iNVProductStock.UpdatedBy;
				_iNVProductStockWCF.InventoryID = _iNVProductStock.InventoryID;
				_iNVProductStockWCF.IsBlocked = _iNVProductStock.IsBlocked;
				
				iNVProductStockCollection.Add(_iNVProductStockWCF);
			}
			return iNVProductStockCollection;
		}
		
		/// <summary>
		/// This method will insert one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="iNVProductStock" type="INVProductStock">This INVProductStock  will be inserted in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Insert(INVProductStock iNVProductStock)
		{
			_iNVProductStock = new POS.DataLayer.INVProductStock();
			_iNVProductStock.ProductStockID=iNVProductStock.ProductStockID;
			_iNVProductStock.ProductID=iNVProductStock.ProductID;
			_iNVProductStock.TotalQty=iNVProductStock.TotalQty;
			_iNVProductStock.StockTypeID=iNVProductStock.StockTypeID;
			_iNVProductStock.OpeningQty=iNVProductStock.OpeningQty;
			_iNVProductStock.OpennigDate=iNVProductStock.OpennigDate;
			_iNVProductStock.CreateDate=iNVProductStock.CreateDate;
			_iNVProductStock.CreatedBy=iNVProductStock.CreatedBy;
			_iNVProductStock.UpdateDate=iNVProductStock.UpdateDate;
			_iNVProductStock.UpdatedBy=iNVProductStock.UpdatedBy;
			_iNVProductStock.InventoryID=iNVProductStock.InventoryID;
			_iNVProductStock.IsBlocked=iNVProductStock.IsBlocked;
			
			return _iNVProductStock.Insert();
		}
		
		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>list of objects of class INVProductStock in the form of an object of class INVProductStockCollection </returns>
		public INVProductStockCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			INVProductStockCollection iNVProductStockCollection = new INVProductStockCollection();
			foreach (POS.DataLayer.INVProductStock _iNVProductStock in POS.DataLayer.INVProductStockBase.SelectAllPaged(pageSize, skipPages, orderByStatement))
			{
				_iNVProductStockWCF = new INVProductStock();
				
				_iNVProductStockWCF.ProductStockID = _iNVProductStock.ProductStockID;
				_iNVProductStockWCF.ProductID = _iNVProductStock.ProductID;
				_iNVProductStockWCF.TotalQty = _iNVProductStock.TotalQty;
				_iNVProductStockWCF.StockTypeID = _iNVProductStock.StockTypeID;
				_iNVProductStockWCF.OpeningQty = _iNVProductStock.OpeningQty;
				_iNVProductStockWCF.OpennigDate = _iNVProductStock.OpennigDate;
				_iNVProductStockWCF.CreateDate = _iNVProductStock.CreateDate;
				_iNVProductStockWCF.CreatedBy = _iNVProductStock.CreatedBy;
				_iNVProductStockWCF.UpdateDate = _iNVProductStock.UpdateDate;
				_iNVProductStockWCF.UpdatedBy = _iNVProductStock.UpdatedBy;
				_iNVProductStockWCF.InventoryID = _iNVProductStock.InventoryID;
				_iNVProductStockWCF.IsBlocked = _iNVProductStock.IsBlocked;
				
				iNVProductStockCollection.Add(_iNVProductStockWCF);
			}
			return iNVProductStockCollection;
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class INVProductStock</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class INVProductStock in the form of an object of class INVProductStockCollection</returns>
		public INVProductStockCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
		{
			INVProductStockCollection iNVProductStockCollection = new INVProductStockCollection();
			foreach (POS.DataLayer.INVProductStock _iNVProductStock in POS.DataLayer.INVProductStockBase.SelectByFieldPaged(field, fieldValue, fieldValue2, typeOperation, pageSize, skipPages, orderByStatement))
			{
				_iNVProductStockWCF = new INVProductStock();
				
				_iNVProductStockWCF.ProductStockID = _iNVProductStock.ProductStockID;
				_iNVProductStockWCF.ProductID = _iNVProductStock.ProductID;
				_iNVProductStockWCF.TotalQty = _iNVProductStock.TotalQty;
				_iNVProductStockWCF.StockTypeID = _iNVProductStock.StockTypeID;
				_iNVProductStockWCF.OpeningQty = _iNVProductStock.OpeningQty;
				_iNVProductStockWCF.OpennigDate = _iNVProductStock.OpennigDate;
				_iNVProductStockWCF.CreateDate = _iNVProductStock.CreateDate;
				_iNVProductStockWCF.CreatedBy = _iNVProductStock.CreatedBy;
				_iNVProductStockWCF.UpdateDate = _iNVProductStock.UpdateDate;
				_iNVProductStockWCF.UpdatedBy = _iNVProductStock.UpdatedBy;
				_iNVProductStockWCF.InventoryID = _iNVProductStock.InventoryID;
				_iNVProductStockWCF.IsBlocked = _iNVProductStock.IsBlocked;
				
				iNVProductStockCollection.Add(_iNVProductStockWCF);
			}
			return iNVProductStockCollection;
		}
			///<summary>
		/// This method will update one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="iNVProductStock" type="INVProductStock">This INVProductStock  will be updated in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Update(INVProductStock iNVProductStock)
		{
			_iNVProductStock=POS.DataLayer.INVProductStock.SelectOne(new POS.DataLayer.INVProductStockPrimaryKey(iNVProductStock.ProductStockID));
			
			_iNVProductStock.ProductID=iNVProductStock.ProductID;
			_iNVProductStock.TotalQty=iNVProductStock.TotalQty;
			_iNVProductStock.StockTypeID=iNVProductStock.StockTypeID;
			_iNVProductStock.OpeningQty=iNVProductStock.OpeningQty;
			_iNVProductStock.OpennigDate=iNVProductStock.OpennigDate;
			_iNVProductStock.CreateDate=iNVProductStock.CreateDate;
			_iNVProductStock.CreatedBy=iNVProductStock.CreatedBy;
			_iNVProductStock.UpdateDate=iNVProductStock.UpdateDate;
			_iNVProductStock.UpdatedBy=iNVProductStock.UpdatedBy;
			_iNVProductStock.InventoryID=iNVProductStock.InventoryID;
			_iNVProductStock.IsBlocked=iNVProductStock.IsBlocked;
			
			return _iNVProductStock.Update();
		}
	} 
}
