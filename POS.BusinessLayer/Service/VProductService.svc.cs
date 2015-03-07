//
// Class	:	VProductServices.svc.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	3/7/2015 2:37:31 PM
//

using POS.DataLayer;

namespace POS.BusinessLayer
{
	///<summary>
	///WCF service for the VProduct
	///</summary>
	public class VProductService 
	{
		private VProduct _vProductWCF;
		private POS.DataLayer.VProduct _vProduct;
		
	

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="VProductPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class VProduct</returns>
		public VProduct SelectOne(VProductPrimaryKey pk)
		{
			_vProductWCF = new VProduct();
			_vProduct = POS.DataLayer.VProductBase.SelectOne(new POS.DataLayer.VProductPrimaryKey(pk.ProductID));
			
				_vProductWCF.ProductID = _vProduct.ProductID;
				_vProductWCF.ProductName = _vProduct.ProductName;
				_vProductWCF.ProductGroupID = _vProduct.ProductGroupID;
				_vProductWCF.ProductCode = _vProduct.ProductCode;
				_vProductWCF.IsAcceptBatch = _vProduct.IsAcceptBatch;
				_vProductWCF.ProductPrice = _vProduct.ProductPrice;
				_vProductWCF.IsFixedPrice = _vProduct.IsFixedPrice;
				_vProductWCF.HasDiscount = _vProduct.HasDiscount;
				_vProductWCF.DiscountAmount = _vProduct.DiscountAmount;
				_vProductWCF.DescountRatio = _vProduct.DescountRatio;
				_vProductWCF.IsActive = _vProduct.IsActive;
				_vProductWCF.Notes = _vProduct.Notes;
				_vProductWCF.ProductGroupName = _vProduct.ProductGroupName;
				_vProductWCF.Expr1 = _vProduct.Expr1;
				
			return _vProductWCF;
		}

		/// <summary>
		/// This method will return a list of objects representing all records in the table.
		/// </summary>
		///
		/// <returns>list of objects of class VProduct in the form of object of VProductCollection </returns>
		public VProductCollection SelectAll()
		{
			VProductCollection vProductCollection = new VProductCollection();
			foreach (POS.DataLayer.VProduct _vProduct in POS.DataLayer.VProductBase.SelectAll())
			{
				_vProductWCF = new VProduct();
				
				_vProductWCF.ProductID = _vProduct.ProductID;
				_vProductWCF.ProductName = _vProduct.ProductName;
				_vProductWCF.ProductGroupID = _vProduct.ProductGroupID;
				_vProductWCF.ProductCode = _vProduct.ProductCode;
				_vProductWCF.IsAcceptBatch = _vProduct.IsAcceptBatch;
				_vProductWCF.ProductPrice = _vProduct.ProductPrice;
				_vProductWCF.IsFixedPrice = _vProduct.IsFixedPrice;
				_vProductWCF.HasDiscount = _vProduct.HasDiscount;
				_vProductWCF.DiscountAmount = _vProduct.DiscountAmount;
				_vProductWCF.DescountRatio = _vProduct.DescountRatio;
				_vProductWCF.IsActive = _vProduct.IsActive;
				_vProductWCF.Notes = _vProduct.Notes;
				_vProductWCF.ProductGroupName = _vProduct.ProductGroupName;
				_vProductWCF.Expr1 = _vProduct.Expr1;
				
				vProductCollection.Add(_vProductWCF);
			}
			return vProductCollection;
		}
    
    /// <summary>
		/// This method will return a count all records in the table.
		/// </summary>
		///
		/// <returns>count records</returns>
		public int SelectAllCount()
		{
			return POS.DataLayer.VProductBase.SelectAllCount();			
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
		public VProductCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
		{
			VProductCollection vProductCollection = new VProductCollection();
			foreach (POS.DataLayer.VProduct _vProduct in POS.DataLayer.VProductBase.SelectByField(field, fieldValue, fieldValue2, typeOperation))
			{
				_vProductWCF = new VProduct();
				
				_vProductWCF.ProductID = _vProduct.ProductID;
				_vProductWCF.ProductName = _vProduct.ProductName;
				_vProductWCF.ProductGroupID = _vProduct.ProductGroupID;
				_vProductWCF.ProductCode = _vProduct.ProductCode;
				_vProductWCF.IsAcceptBatch = _vProduct.IsAcceptBatch;
				_vProductWCF.ProductPrice = _vProduct.ProductPrice;
				_vProductWCF.IsFixedPrice = _vProduct.IsFixedPrice;
				_vProductWCF.HasDiscount = _vProduct.HasDiscount;
				_vProductWCF.DiscountAmount = _vProduct.DiscountAmount;
				_vProductWCF.DescountRatio = _vProduct.DescountRatio;
				_vProductWCF.IsActive = _vProduct.IsActive;
				_vProductWCF.Notes = _vProduct.Notes;
				_vProductWCF.ProductGroupName = _vProduct.ProductGroupName;
				_vProductWCF.Expr1 = _vProduct.Expr1;
				
				vProductCollection.Add(_vProductWCF);
			}
			return vProductCollection;
		}
	
		
		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>list of objects of class VProduct in the form of an object of class VProductCollection </returns>
		public VProductCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			VProductCollection vProductCollection = new VProductCollection();
			foreach (POS.DataLayer.VProduct _vProduct in POS.DataLayer.VProductBase.SelectAllPaged(pageSize, skipPages, orderByStatement))
			{
				_vProductWCF = new VProduct();
				
				_vProductWCF.ProductID = _vProduct.ProductID;
				_vProductWCF.ProductName = _vProduct.ProductName;
				_vProductWCF.ProductGroupID = _vProduct.ProductGroupID;
				_vProductWCF.ProductCode = _vProduct.ProductCode;
				_vProductWCF.IsAcceptBatch = _vProduct.IsAcceptBatch;
				_vProductWCF.ProductPrice = _vProduct.ProductPrice;
				_vProductWCF.IsFixedPrice = _vProduct.IsFixedPrice;
				_vProductWCF.HasDiscount = _vProduct.HasDiscount;
				_vProductWCF.DiscountAmount = _vProduct.DiscountAmount;
				_vProductWCF.DescountRatio = _vProduct.DescountRatio;
				_vProductWCF.IsActive = _vProduct.IsActive;
				_vProductWCF.Notes = _vProduct.Notes;
				_vProductWCF.ProductGroupName = _vProduct.ProductGroupName;
				_vProductWCF.Expr1 = _vProduct.Expr1;
				
				vProductCollection.Add(_vProductWCF);
			}
			return vProductCollection;
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
		public VProductCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
		{
			VProductCollection vProductCollection = new VProductCollection();
			foreach (POS.DataLayer.VProduct _vProduct in POS.DataLayer.VProductBase.SelectByFieldPaged(field, fieldValue, fieldValue2, typeOperation, pageSize, skipPages, orderByStatement))
			{
				_vProductWCF = new VProduct();
				
				_vProductWCF.ProductID = _vProduct.ProductID;
				_vProductWCF.ProductName = _vProduct.ProductName;
				_vProductWCF.ProductGroupID = _vProduct.ProductGroupID;
				_vProductWCF.ProductCode = _vProduct.ProductCode;
				_vProductWCF.IsAcceptBatch = _vProduct.IsAcceptBatch;
				_vProductWCF.ProductPrice = _vProduct.ProductPrice;
				_vProductWCF.IsFixedPrice = _vProduct.IsFixedPrice;
				_vProductWCF.HasDiscount = _vProduct.HasDiscount;
				_vProductWCF.DiscountAmount = _vProduct.DiscountAmount;
				_vProductWCF.DescountRatio = _vProduct.DescountRatio;
				_vProductWCF.IsActive = _vProduct.IsActive;
				_vProductWCF.Notes = _vProduct.Notes;
				_vProductWCF.ProductGroupName = _vProduct.ProductGroupName;
				_vProductWCF.Expr1 = _vProduct.Expr1;
				
				vProductCollection.Add(_vProductWCF);
			}
			return vProductCollection;
		}
			///<summary>
		/// This method will update one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="vProduct" type="VProduct">This VProduct  will be updated in the database.</param>
		///
		/// <returns>True if succeeded</returns>
	
	} 
}
