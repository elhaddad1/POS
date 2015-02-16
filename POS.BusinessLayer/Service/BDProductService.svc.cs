//
// Class	:	BDProductServices.svc.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	2/16/2015 7:27:51 PM
//

using POS.DataLayer;

namespace POS.BusinessLayer
{
	///<summary>
	///WCF service for the BDProduct
	///</summary>
	public class BDProductService 
	{
		private BDProduct _bDProductWCF;
		private POS.DataLayer.BDProduct _bDProduct;
		
		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="BDProductFields">Field of the class BDProduct</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <returns>True if succeeded</returns>
		public bool DeleteByField(string field, object fieldValue)
		{
			return POS.DataLayer.BDProductBase.DeleteByField(field, fieldValue);
		}

		///<summary>
		///This method will Delete the object from the database
		///</summary>
		///<param name="pk" type="BDProductPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <returns>True if succeeded</returns>
		public bool Delete(BDProductPrimaryKey pk)
		{
			return POS.DataLayer.BDProductBase.Delete(new POS.DataLayer.BDProductPrimaryKey(pk.ProductID));
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="BDProductPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class BDProduct</returns>
		public BDProduct SelectOne(BDProductPrimaryKey pk)
		{
			_bDProductWCF = new BDProduct();
			_bDProduct = POS.DataLayer.BDProductBase.SelectOne(new POS.DataLayer.BDProductPrimaryKey(pk.ProductID));
			
				_bDProductWCF.ProductID = _bDProduct.ProductID;
				_bDProductWCF.ProductName = _bDProduct.ProductName;
				_bDProductWCF.ProductGroupID = _bDProduct.ProductGroupID;
				_bDProductWCF.ProductCode = _bDProduct.ProductCode;
				_bDProductWCF.IsAcceptBatch = _bDProduct.IsAcceptBatch;
				_bDProductWCF.ProductPrice = _bDProduct.ProductPrice;
				_bDProductWCF.IsFixedPrice = _bDProduct.IsFixedPrice;
				_bDProductWCF.HasDiscount = _bDProduct.HasDiscount;
				_bDProductWCF.DiscountAmount = _bDProduct.DiscountAmount;
				_bDProductWCF.DescountRatio = _bDProduct.DescountRatio;
				_bDProductWCF.IsActive = _bDProduct.IsActive;
				_bDProductWCF.Notes = _bDProduct.Notes;
				_bDProductWCF.MinPrice = _bDProduct.MinPrice;
				_bDProductWCF.MaxPrice = _bDProduct.MaxPrice;
				
			return _bDProductWCF;
		}

		/// <summary>
		/// This method will return a list of objects representing all records in the table.
		/// </summary>
		///
		/// <returns>list of objects of class BDProduct in the form of object of BDProductCollection </returns>
		public BDProductCollection SelectAll()
		{
			BDProductCollection bDProductCollection = new BDProductCollection();
			foreach (POS.DataLayer.BDProduct _bDProduct in POS.DataLayer.BDProductBase.SelectAll())
			{
				_bDProductWCF = new BDProduct();
				
				_bDProductWCF.ProductID = _bDProduct.ProductID;
				_bDProductWCF.ProductName = _bDProduct.ProductName;
				_bDProductWCF.ProductGroupID = _bDProduct.ProductGroupID;
				_bDProductWCF.ProductCode = _bDProduct.ProductCode;
				_bDProductWCF.IsAcceptBatch = _bDProduct.IsAcceptBatch;
				_bDProductWCF.ProductPrice = _bDProduct.ProductPrice;
				_bDProductWCF.IsFixedPrice = _bDProduct.IsFixedPrice;
				_bDProductWCF.HasDiscount = _bDProduct.HasDiscount;
				_bDProductWCF.DiscountAmount = _bDProduct.DiscountAmount;
				_bDProductWCF.DescountRatio = _bDProduct.DescountRatio;
				_bDProductWCF.IsActive = _bDProduct.IsActive;
				_bDProductWCF.Notes = _bDProduct.Notes;
				_bDProductWCF.MinPrice = _bDProduct.MinPrice;
				_bDProductWCF.MaxPrice = _bDProduct.MaxPrice;
				
				bDProductCollection.Add(_bDProductWCF);
			}
			return bDProductCollection;
		}
    
    /// <summary>
		/// This method will return a count all records in the table.
		/// </summary>
		///
		/// <returns>count records</returns>
		public int SelectAllCount()
		{
			return POS.DataLayer.BDProductBase.SelectAllCount();			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class BDProduct</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class BDProduct in the form of an object of class BDProductCollection</returns>
		public BDProductCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
		{
			BDProductCollection bDProductCollection = new BDProductCollection();
			foreach (POS.DataLayer.BDProduct _bDProduct in POS.DataLayer.BDProductBase.SelectByField(field, fieldValue, fieldValue2, typeOperation))
			{
				_bDProductWCF = new BDProduct();
				
				_bDProductWCF.ProductID = _bDProduct.ProductID;
				_bDProductWCF.ProductName = _bDProduct.ProductName;
				_bDProductWCF.ProductGroupID = _bDProduct.ProductGroupID;
				_bDProductWCF.ProductCode = _bDProduct.ProductCode;
				_bDProductWCF.IsAcceptBatch = _bDProduct.IsAcceptBatch;
				_bDProductWCF.ProductPrice = _bDProduct.ProductPrice;
				_bDProductWCF.IsFixedPrice = _bDProduct.IsFixedPrice;
				_bDProductWCF.HasDiscount = _bDProduct.HasDiscount;
				_bDProductWCF.DiscountAmount = _bDProduct.DiscountAmount;
				_bDProductWCF.DescountRatio = _bDProduct.DescountRatio;
				_bDProductWCF.IsActive = _bDProduct.IsActive;
				_bDProductWCF.Notes = _bDProduct.Notes;
				_bDProductWCF.MinPrice = _bDProduct.MinPrice;
				_bDProductWCF.MaxPrice = _bDProduct.MaxPrice;
				
				bDProductCollection.Add(_bDProductWCF);
			}
			return bDProductCollection;
		}
		
		/// <summary>
		/// This method will insert one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="bDProduct" type="BDProduct">This BDProduct  will be inserted in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Insert(BDProduct bDProduct)
		{
			_bDProduct = new POS.DataLayer.BDProduct();
			_bDProduct.ProductID=bDProduct.ProductID;
			_bDProduct.ProductName=bDProduct.ProductName;
			_bDProduct.ProductGroupID=bDProduct.ProductGroupID;
			_bDProduct.ProductCode=bDProduct.ProductCode;
			_bDProduct.IsAcceptBatch=bDProduct.IsAcceptBatch;
			_bDProduct.ProductPrice=bDProduct.ProductPrice;
			_bDProduct.IsFixedPrice=bDProduct.IsFixedPrice;
			_bDProduct.HasDiscount=bDProduct.HasDiscount;
			_bDProduct.DiscountAmount=bDProduct.DiscountAmount;
			_bDProduct.DescountRatio=bDProduct.DescountRatio;
			_bDProduct.IsActive=bDProduct.IsActive;
			_bDProduct.Notes=bDProduct.Notes;
			_bDProduct.MinPrice=bDProduct.MinPrice;
			_bDProduct.MaxPrice=bDProduct.MaxPrice;
			
			return _bDProduct.Insert();
		}
		/// <summary>
		/// This method will delete row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="BDProductGroupPrimaryKey">Primary Key information based on which data is to be deleted.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool DeleteAllByForeignKeyProductGroupID(BDProductGroupPrimaryKey pk)
		{
			return POS.DataLayer.BDProductBase.DeleteAllByForeignKeyProductGroupID(new POS.DataLayer.BDProductGroupPrimaryKey(pk.ProductGroupID));
		}
		
		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="BDProductGroupPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class BDProductCollection</returns>
		public BDProductCollection SelectAllByForeignKeyProductGroupID(BDProductGroupPrimaryKey pk)
		{
			BDProductCollection bDProductCollection=new BDProductCollection();
			foreach (POS.DataLayer.BDProduct _bDProduct in POS.DataLayer.BDProductBase.SelectAllByForeignKeyProductGroupID(new POS.DataLayer.BDProductGroupPrimaryKey(pk.ProductGroupID)))
			{
				_bDProductWCF = new BDProduct();
				_bDProductWCF.ProductID = _bDProduct.ProductID;
				_bDProductWCF.ProductName = _bDProduct.ProductName;
				_bDProductWCF.ProductGroupID = _bDProduct.ProductGroupID;
				_bDProductWCF.ProductCode = _bDProduct.ProductCode;
				_bDProductWCF.IsAcceptBatch = _bDProduct.IsAcceptBatch;
				_bDProductWCF.ProductPrice = _bDProduct.ProductPrice;
				_bDProductWCF.IsFixedPrice = _bDProduct.IsFixedPrice;
				_bDProductWCF.HasDiscount = _bDProduct.HasDiscount;
				_bDProductWCF.DiscountAmount = _bDProduct.DiscountAmount;
				_bDProductWCF.DescountRatio = _bDProduct.DescountRatio;
				_bDProductWCF.IsActive = _bDProduct.IsActive;
				_bDProductWCF.Notes = _bDProduct.Notes;
				_bDProductWCF.MinPrice = _bDProduct.MinPrice;
				_bDProductWCF.MaxPrice = _bDProduct.MaxPrice;
				
				bDProductCollection.Add(_bDProductWCF);
			}
			return bDProductCollection;
		}
		
		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="BDProductGroupPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>object of class BDProductCollection</returns>
		public BDProductCollection SelectAllByForeignKeyProductGroupIDPaged(BDProductGroupPrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			BDProductCollection bDProductCollection=new BDProductCollection();
			foreach (POS.DataLayer.BDProduct _bDProduct in POS.DataLayer.BDProductBase.SelectAllByForeignKeyProductGroupIDPaged(new POS.DataLayer.BDProductGroupPrimaryKey(pk.ProductGroupID), pageSize, skipPages, orderByStatement))
			{
				_bDProductWCF = new BDProduct();
				_bDProductWCF.ProductID = _bDProduct.ProductID;
				_bDProductWCF.ProductName = _bDProduct.ProductName;
				_bDProductWCF.ProductGroupID = _bDProduct.ProductGroupID;
				_bDProductWCF.ProductCode = _bDProduct.ProductCode;
				_bDProductWCF.IsAcceptBatch = _bDProduct.IsAcceptBatch;
				_bDProductWCF.ProductPrice = _bDProduct.ProductPrice;
				_bDProductWCF.IsFixedPrice = _bDProduct.IsFixedPrice;
				_bDProductWCF.HasDiscount = _bDProduct.HasDiscount;
				_bDProductWCF.DiscountAmount = _bDProduct.DiscountAmount;
				_bDProductWCF.DescountRatio = _bDProduct.DescountRatio;
				_bDProductWCF.IsActive = _bDProduct.IsActive;
				_bDProductWCF.Notes = _bDProduct.Notes;
				_bDProductWCF.MinPrice = _bDProduct.MinPrice;
				_bDProductWCF.MaxPrice = _bDProduct.MaxPrice;
				
				bDProductCollection.Add(_bDProductWCF);
			}
			return bDProductCollection;
		}
		
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>list of objects of class BDProduct in the form of an object of class BDProductCollection </returns>
		public BDProductCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			BDProductCollection bDProductCollection = new BDProductCollection();
			foreach (POS.DataLayer.BDProduct _bDProduct in POS.DataLayer.BDProductBase.SelectAllPaged(pageSize, skipPages, orderByStatement))
			{
				_bDProductWCF = new BDProduct();
				
				_bDProductWCF.ProductID = _bDProduct.ProductID;
				_bDProductWCF.ProductName = _bDProduct.ProductName;
				_bDProductWCF.ProductGroupID = _bDProduct.ProductGroupID;
				_bDProductWCF.ProductCode = _bDProduct.ProductCode;
				_bDProductWCF.IsAcceptBatch = _bDProduct.IsAcceptBatch;
				_bDProductWCF.ProductPrice = _bDProduct.ProductPrice;
				_bDProductWCF.IsFixedPrice = _bDProduct.IsFixedPrice;
				_bDProductWCF.HasDiscount = _bDProduct.HasDiscount;
				_bDProductWCF.DiscountAmount = _bDProduct.DiscountAmount;
				_bDProductWCF.DescountRatio = _bDProduct.DescountRatio;
				_bDProductWCF.IsActive = _bDProduct.IsActive;
				_bDProductWCF.Notes = _bDProduct.Notes;
				_bDProductWCF.MinPrice = _bDProduct.MinPrice;
				_bDProductWCF.MaxPrice = _bDProduct.MaxPrice;
				
				bDProductCollection.Add(_bDProductWCF);
			}
			return bDProductCollection;
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class BDProduct</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class BDProduct in the form of an object of class BDProductCollection</returns>
		public BDProductCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
		{
			BDProductCollection bDProductCollection = new BDProductCollection();
			foreach (POS.DataLayer.BDProduct _bDProduct in POS.DataLayer.BDProductBase.SelectByFieldPaged(field, fieldValue, fieldValue2, typeOperation, pageSize, skipPages, orderByStatement))
			{
				_bDProductWCF = new BDProduct();
				
				_bDProductWCF.ProductID = _bDProduct.ProductID;
				_bDProductWCF.ProductName = _bDProduct.ProductName;
				_bDProductWCF.ProductGroupID = _bDProduct.ProductGroupID;
				_bDProductWCF.ProductCode = _bDProduct.ProductCode;
				_bDProductWCF.IsAcceptBatch = _bDProduct.IsAcceptBatch;
				_bDProductWCF.ProductPrice = _bDProduct.ProductPrice;
				_bDProductWCF.IsFixedPrice = _bDProduct.IsFixedPrice;
				_bDProductWCF.HasDiscount = _bDProduct.HasDiscount;
				_bDProductWCF.DiscountAmount = _bDProduct.DiscountAmount;
				_bDProductWCF.DescountRatio = _bDProduct.DescountRatio;
				_bDProductWCF.IsActive = _bDProduct.IsActive;
				_bDProductWCF.Notes = _bDProduct.Notes;
				_bDProductWCF.MinPrice = _bDProduct.MinPrice;
				_bDProductWCF.MaxPrice = _bDProduct.MaxPrice;
				
				bDProductCollection.Add(_bDProductWCF);
			}
			return bDProductCollection;
		}
			///<summary>
		/// This method will update one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="bDProduct" type="BDProduct">This BDProduct  will be updated in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Update(BDProduct bDProduct)
		{
			_bDProduct=POS.DataLayer.BDProduct.SelectOne(new POS.DataLayer.BDProductPrimaryKey(bDProduct.ProductID));
			
			_bDProduct.ProductName=bDProduct.ProductName;
			_bDProduct.ProductGroupID=bDProduct.ProductGroupID;
			_bDProduct.ProductCode=bDProduct.ProductCode;
			_bDProduct.IsAcceptBatch=bDProduct.IsAcceptBatch;
			_bDProduct.ProductPrice=bDProduct.ProductPrice;
			_bDProduct.IsFixedPrice=bDProduct.IsFixedPrice;
			_bDProduct.HasDiscount=bDProduct.HasDiscount;
			_bDProduct.DiscountAmount=bDProduct.DiscountAmount;
			_bDProduct.DescountRatio=bDProduct.DescountRatio;
			_bDProduct.IsActive=bDProduct.IsActive;
			_bDProduct.Notes=bDProduct.Notes;
			_bDProduct.MinPrice=bDProduct.MinPrice;
			_bDProduct.MaxPrice=bDProduct.MaxPrice;
			
			return _bDProduct.Update();
		}
	} 
}
