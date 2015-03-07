//
// Class	:	INVAdjustStockServices.svc.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	3/7/2015 2:37:16 PM
//


using POS.DataLayer;

namespace POS.BusinessLayer
{
	///<summary>
	///WCF service for the INVAdjustStock
	///</summary>
	public class INVAdjustStockService 
	{
		private INVAdjustStock _iNVAdjustStockWCF;
		private POS.DataLayer.INVAdjustStock _iNVAdjustStock;
		
		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="INVAdjustStockFields">Field of the class INVAdjustStock</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <returns>True if succeeded</returns>
		public bool DeleteByField(string field, object fieldValue)
		{
			return POS.DataLayer.INVAdjustStockBase.DeleteByField(field, fieldValue);
		}

		///<summary>
		///This method will Delete the object from the database
		///</summary>
		///<param name="pk" type="INVAdjustStockPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <returns>True if succeeded</returns>
		public bool Delete(INVAdjustStockPrimaryKey pk)
		{
			return POS.DataLayer.INVAdjustStockBase.Delete(new POS.DataLayer.INVAdjustStockPrimaryKey(pk.AdjustStockID));
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="INVAdjustStockPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class INVAdjustStock</returns>
		public INVAdjustStock SelectOne(INVAdjustStockPrimaryKey pk)
		{
			_iNVAdjustStockWCF = new INVAdjustStock();
			_iNVAdjustStock = POS.DataLayer.INVAdjustStockBase.SelectOne(new POS.DataLayer.INVAdjustStockPrimaryKey(pk.AdjustStockID));
			
				_iNVAdjustStockWCF.AdjustStockID = _iNVAdjustStock.AdjustStockID;
				_iNVAdjustStockWCF.ProductID = _iNVAdjustStock.ProductID;
				_iNVAdjustStockWCF.BatchID = _iNVAdjustStock.BatchID;
				_iNVAdjustStockWCF.Qty = _iNVAdjustStock.Qty;
				_iNVAdjustStockWCF.AdjustReasonID = _iNVAdjustStock.AdjustReasonID;
				_iNVAdjustStockWCF.CreatedBy = _iNVAdjustStock.CreatedBy;
				_iNVAdjustStockWCF.CredateDate = _iNVAdjustStock.CredateDate;
				_iNVAdjustStockWCF.UpdatedBy = _iNVAdjustStock.UpdatedBy;
				_iNVAdjustStockWCF.UpdateDate = _iNVAdjustStock.UpdateDate;
				
			return _iNVAdjustStockWCF;
		}

		/// <summary>
		/// This method will return a list of objects representing all records in the table.
		/// </summary>
		///
		/// <returns>list of objects of class INVAdjustStock in the form of object of INVAdjustStockCollection </returns>
		public INVAdjustStockCollection SelectAll()
		{
			INVAdjustStockCollection iNVAdjustStockCollection = new INVAdjustStockCollection();
			foreach (POS.DataLayer.INVAdjustStock _iNVAdjustStock in POS.DataLayer.INVAdjustStockBase.SelectAll())
			{
				_iNVAdjustStockWCF = new INVAdjustStock();
				
				_iNVAdjustStockWCF.AdjustStockID = _iNVAdjustStock.AdjustStockID;
				_iNVAdjustStockWCF.ProductID = _iNVAdjustStock.ProductID;
				_iNVAdjustStockWCF.BatchID = _iNVAdjustStock.BatchID;
				_iNVAdjustStockWCF.Qty = _iNVAdjustStock.Qty;
				_iNVAdjustStockWCF.AdjustReasonID = _iNVAdjustStock.AdjustReasonID;
				_iNVAdjustStockWCF.CreatedBy = _iNVAdjustStock.CreatedBy;
				_iNVAdjustStockWCF.CredateDate = _iNVAdjustStock.CredateDate;
				_iNVAdjustStockWCF.UpdatedBy = _iNVAdjustStock.UpdatedBy;
				_iNVAdjustStockWCF.UpdateDate = _iNVAdjustStock.UpdateDate;
				
				iNVAdjustStockCollection.Add(_iNVAdjustStockWCF);
			}
			return iNVAdjustStockCollection;
		}
    
    /// <summary>
		/// This method will return a count all records in the table.
		/// </summary>
		///
		/// <returns>count records</returns>
		public int SelectAllCount()
		{
			return POS.DataLayer.INVAdjustStockBase.SelectAllCount();			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class INVAdjustStock</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class INVAdjustStock in the form of an object of class INVAdjustStockCollection</returns>
		public INVAdjustStockCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
		{
			INVAdjustStockCollection iNVAdjustStockCollection = new INVAdjustStockCollection();
			foreach (POS.DataLayer.INVAdjustStock _iNVAdjustStock in POS.DataLayer.INVAdjustStockBase.SelectByField(field, fieldValue, fieldValue2, typeOperation))
			{
				_iNVAdjustStockWCF = new INVAdjustStock();
				
				_iNVAdjustStockWCF.AdjustStockID = _iNVAdjustStock.AdjustStockID;
				_iNVAdjustStockWCF.ProductID = _iNVAdjustStock.ProductID;
				_iNVAdjustStockWCF.BatchID = _iNVAdjustStock.BatchID;
				_iNVAdjustStockWCF.Qty = _iNVAdjustStock.Qty;
				_iNVAdjustStockWCF.AdjustReasonID = _iNVAdjustStock.AdjustReasonID;
				_iNVAdjustStockWCF.CreatedBy = _iNVAdjustStock.CreatedBy;
				_iNVAdjustStockWCF.CredateDate = _iNVAdjustStock.CredateDate;
				_iNVAdjustStockWCF.UpdatedBy = _iNVAdjustStock.UpdatedBy;
				_iNVAdjustStockWCF.UpdateDate = _iNVAdjustStock.UpdateDate;
				
				iNVAdjustStockCollection.Add(_iNVAdjustStockWCF);
			}
			return iNVAdjustStockCollection;
		}
		
		/// <summary>
		/// This method will insert one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="iNVAdjustStock" type="INVAdjustStock">This INVAdjustStock  will be inserted in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Insert(INVAdjustStock iNVAdjustStock)
		{
			_iNVAdjustStock = new POS.DataLayer.INVAdjustStock();
			_iNVAdjustStock.AdjustStockID=iNVAdjustStock.AdjustStockID;
			_iNVAdjustStock.ProductID=iNVAdjustStock.ProductID;
			_iNVAdjustStock.BatchID=iNVAdjustStock.BatchID;
			_iNVAdjustStock.Qty=iNVAdjustStock.Qty;
			_iNVAdjustStock.AdjustReasonID=iNVAdjustStock.AdjustReasonID;
			_iNVAdjustStock.CreatedBy=iNVAdjustStock.CreatedBy;
			_iNVAdjustStock.CredateDate=iNVAdjustStock.CredateDate;
			_iNVAdjustStock.UpdatedBy=iNVAdjustStock.UpdatedBy;
			_iNVAdjustStock.UpdateDate=iNVAdjustStock.UpdateDate;
			
			return _iNVAdjustStock.Insert();
		}
		
		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>list of objects of class INVAdjustStock in the form of an object of class INVAdjustStockCollection </returns>
		public INVAdjustStockCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			INVAdjustStockCollection iNVAdjustStockCollection = new INVAdjustStockCollection();
			foreach (POS.DataLayer.INVAdjustStock _iNVAdjustStock in POS.DataLayer.INVAdjustStockBase.SelectAllPaged(pageSize, skipPages, orderByStatement))
			{
				_iNVAdjustStockWCF = new INVAdjustStock();
				
				_iNVAdjustStockWCF.AdjustStockID = _iNVAdjustStock.AdjustStockID;
				_iNVAdjustStockWCF.ProductID = _iNVAdjustStock.ProductID;
				_iNVAdjustStockWCF.BatchID = _iNVAdjustStock.BatchID;
				_iNVAdjustStockWCF.Qty = _iNVAdjustStock.Qty;
				_iNVAdjustStockWCF.AdjustReasonID = _iNVAdjustStock.AdjustReasonID;
				_iNVAdjustStockWCF.CreatedBy = _iNVAdjustStock.CreatedBy;
				_iNVAdjustStockWCF.CredateDate = _iNVAdjustStock.CredateDate;
				_iNVAdjustStockWCF.UpdatedBy = _iNVAdjustStock.UpdatedBy;
				_iNVAdjustStockWCF.UpdateDate = _iNVAdjustStock.UpdateDate;
				
				iNVAdjustStockCollection.Add(_iNVAdjustStockWCF);
			}
			return iNVAdjustStockCollection;
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class INVAdjustStock</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class INVAdjustStock in the form of an object of class INVAdjustStockCollection</returns>
		public INVAdjustStockCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
		{
			INVAdjustStockCollection iNVAdjustStockCollection = new INVAdjustStockCollection();
			foreach (POS.DataLayer.INVAdjustStock _iNVAdjustStock in POS.DataLayer.INVAdjustStockBase.SelectByFieldPaged(field, fieldValue, fieldValue2, typeOperation, pageSize, skipPages, orderByStatement))
			{
				_iNVAdjustStockWCF = new INVAdjustStock();
				
				_iNVAdjustStockWCF.AdjustStockID = _iNVAdjustStock.AdjustStockID;
				_iNVAdjustStockWCF.ProductID = _iNVAdjustStock.ProductID;
				_iNVAdjustStockWCF.BatchID = _iNVAdjustStock.BatchID;
				_iNVAdjustStockWCF.Qty = _iNVAdjustStock.Qty;
				_iNVAdjustStockWCF.AdjustReasonID = _iNVAdjustStock.AdjustReasonID;
				_iNVAdjustStockWCF.CreatedBy = _iNVAdjustStock.CreatedBy;
				_iNVAdjustStockWCF.CredateDate = _iNVAdjustStock.CredateDate;
				_iNVAdjustStockWCF.UpdatedBy = _iNVAdjustStock.UpdatedBy;
				_iNVAdjustStockWCF.UpdateDate = _iNVAdjustStock.UpdateDate;
				
				iNVAdjustStockCollection.Add(_iNVAdjustStockWCF);
			}
			return iNVAdjustStockCollection;
		}
			///<summary>
		/// This method will update one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="iNVAdjustStock" type="INVAdjustStock">This INVAdjustStock  will be updated in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Update(INVAdjustStock iNVAdjustStock)
		{
			_iNVAdjustStock=POS.DataLayer.INVAdjustStock.SelectOne(new POS.DataLayer.INVAdjustStockPrimaryKey(iNVAdjustStock.AdjustStockID));
			
			_iNVAdjustStock.ProductID=iNVAdjustStock.ProductID;
			_iNVAdjustStock.BatchID=iNVAdjustStock.BatchID;
			_iNVAdjustStock.Qty=iNVAdjustStock.Qty;
			_iNVAdjustStock.AdjustReasonID=iNVAdjustStock.AdjustReasonID;
			_iNVAdjustStock.CreatedBy=iNVAdjustStock.CreatedBy;
			_iNVAdjustStock.CredateDate=iNVAdjustStock.CredateDate;
			_iNVAdjustStock.UpdatedBy=iNVAdjustStock.UpdatedBy;
			_iNVAdjustStock.UpdateDate=iNVAdjustStock.UpdateDate;
			
			return _iNVAdjustStock.Update();
		}
	} 
}
