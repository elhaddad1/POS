//
// Class	:	PURPurchaseLineServices.svc.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:56:12 PM
//


using POS.DataLayer;

namespace POS.BusinessLayer
{
	///<summary>
	///WCF service for the PURPurchaseLine
	///</summary>
	public class PURPurchaseLineService 
	{
		private PURPurchaseLine _pURPurchaseLineWCF;
		private POS.DataLayer.PURPurchaseLine _pURPurchaseLine;
		
		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="PURPurchaseLineFields">Field of the class PURPurchaseLine</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <returns>True if succeeded</returns>
		public bool DeleteByField(string field, object fieldValue)
		{
			return POS.DataLayer.PURPurchaseLineBase.DeleteByField(field, fieldValue);
		}

		///<summary>
		///This method will Delete the object from the database
		///</summary>
		///<param name="pk" type="PURPurchaseLinePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <returns>True if succeeded</returns>
		public bool Delete(PURPurchaseLinePrimaryKey pk)
		{
			return POS.DataLayer.PURPurchaseLineBase.Delete(new POS.DataLayer.PURPurchaseLinePrimaryKey(pk.PurchaseLineID));
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="PURPurchaseLinePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class PURPurchaseLine</returns>
		public PURPurchaseLine SelectOne(PURPurchaseLinePrimaryKey pk)
		{
			_pURPurchaseLineWCF = new PURPurchaseLine();
			_pURPurchaseLine = POS.DataLayer.PURPurchaseLineBase.SelectOne(new POS.DataLayer.PURPurchaseLinePrimaryKey(pk.PurchaseLineID));
			
				_pURPurchaseLineWCF.PurchaseLineID = _pURPurchaseLine.PurchaseLineID;
				_pURPurchaseLineWCF.PurchaseHeaderID = _pURPurchaseLine.PurchaseHeaderID;
				_pURPurchaseLineWCF.ProductID = _pURPurchaseLine.ProductID;
				_pURPurchaseLineWCF.TotalQty = _pURPurchaseLine.TotalQty;
				_pURPurchaseLineWCF.BonusQty = _pURPurchaseLine.BonusQty;
				_pURPurchaseLineWCF.DiscountRatio = _pURPurchaseLine.DiscountRatio;
				_pURPurchaseLineWCF.DiscountAmount = _pURPurchaseLine.DiscountAmount;
				_pURPurchaseLineWCF.Unitprice = _pURPurchaseLine.Unitprice;
				_pURPurchaseLineWCF.CreatedDate = _pURPurchaseLine.CreatedDate;
				_pURPurchaseLineWCF.CreatedBy = _pURPurchaseLine.CreatedBy;
				_pURPurchaseLineWCF.UpdateDate = _pURPurchaseLine.UpdateDate;
				_pURPurchaseLineWCF.UpdatedBy = _pURPurchaseLine.UpdatedBy;
				_pURPurchaseLineWCF.IsDeleted = _pURPurchaseLine.IsDeleted;
				_pURPurchaseLineWCF.DeleteDate = _pURPurchaseLine.DeleteDate;
				_pURPurchaseLineWCF.DeletedBy = _pURPurchaseLine.DeletedBy;
				
			return _pURPurchaseLineWCF;
		}

		/// <summary>
		/// This method will return a list of objects representing all records in the table.
		/// </summary>
		///
		/// <returns>list of objects of class PURPurchaseLine in the form of object of PURPurchaseLineCollection </returns>
		public PURPurchaseLineCollection SelectAll()
		{
			PURPurchaseLineCollection pURPurchaseLineCollection = new PURPurchaseLineCollection();
			foreach (POS.DataLayer.PURPurchaseLine _pURPurchaseLine in POS.DataLayer.PURPurchaseLineBase.SelectAll())
			{
				_pURPurchaseLineWCF = new PURPurchaseLine();
				
				_pURPurchaseLineWCF.PurchaseLineID = _pURPurchaseLine.PurchaseLineID;
				_pURPurchaseLineWCF.PurchaseHeaderID = _pURPurchaseLine.PurchaseHeaderID;
				_pURPurchaseLineWCF.ProductID = _pURPurchaseLine.ProductID;
				_pURPurchaseLineWCF.TotalQty = _pURPurchaseLine.TotalQty;
				_pURPurchaseLineWCF.BonusQty = _pURPurchaseLine.BonusQty;
				_pURPurchaseLineWCF.DiscountRatio = _pURPurchaseLine.DiscountRatio;
				_pURPurchaseLineWCF.DiscountAmount = _pURPurchaseLine.DiscountAmount;
				_pURPurchaseLineWCF.Unitprice = _pURPurchaseLine.Unitprice;
				_pURPurchaseLineWCF.CreatedDate = _pURPurchaseLine.CreatedDate;
				_pURPurchaseLineWCF.CreatedBy = _pURPurchaseLine.CreatedBy;
				_pURPurchaseLineWCF.UpdateDate = _pURPurchaseLine.UpdateDate;
				_pURPurchaseLineWCF.UpdatedBy = _pURPurchaseLine.UpdatedBy;
				_pURPurchaseLineWCF.IsDeleted = _pURPurchaseLine.IsDeleted;
				_pURPurchaseLineWCF.DeleteDate = _pURPurchaseLine.DeleteDate;
				_pURPurchaseLineWCF.DeletedBy = _pURPurchaseLine.DeletedBy;
				
				pURPurchaseLineCollection.Add(_pURPurchaseLineWCF);
			}
			return pURPurchaseLineCollection;
		}
    
    /// <summary>
		/// This method will return a count all records in the table.
		/// </summary>
		///
		/// <returns>count records</returns>
		public int SelectAllCount()
		{
			return POS.DataLayer.PURPurchaseLineBase.SelectAllCount();			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class PURPurchaseLine</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class PURPurchaseLine in the form of an object of class PURPurchaseLineCollection</returns>
		public PURPurchaseLineCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
		{
			PURPurchaseLineCollection pURPurchaseLineCollection = new PURPurchaseLineCollection();
			foreach (POS.DataLayer.PURPurchaseLine _pURPurchaseLine in POS.DataLayer.PURPurchaseLineBase.SelectByField(field, fieldValue, fieldValue2, typeOperation))
			{
				_pURPurchaseLineWCF = new PURPurchaseLine();
				
				_pURPurchaseLineWCF.PurchaseLineID = _pURPurchaseLine.PurchaseLineID;
				_pURPurchaseLineWCF.PurchaseHeaderID = _pURPurchaseLine.PurchaseHeaderID;
				_pURPurchaseLineWCF.ProductID = _pURPurchaseLine.ProductID;
				_pURPurchaseLineWCF.TotalQty = _pURPurchaseLine.TotalQty;
				_pURPurchaseLineWCF.BonusQty = _pURPurchaseLine.BonusQty;
				_pURPurchaseLineWCF.DiscountRatio = _pURPurchaseLine.DiscountRatio;
				_pURPurchaseLineWCF.DiscountAmount = _pURPurchaseLine.DiscountAmount;
				_pURPurchaseLineWCF.Unitprice = _pURPurchaseLine.Unitprice;
				_pURPurchaseLineWCF.CreatedDate = _pURPurchaseLine.CreatedDate;
				_pURPurchaseLineWCF.CreatedBy = _pURPurchaseLine.CreatedBy;
				_pURPurchaseLineWCF.UpdateDate = _pURPurchaseLine.UpdateDate;
				_pURPurchaseLineWCF.UpdatedBy = _pURPurchaseLine.UpdatedBy;
				_pURPurchaseLineWCF.IsDeleted = _pURPurchaseLine.IsDeleted;
				_pURPurchaseLineWCF.DeleteDate = _pURPurchaseLine.DeleteDate;
				_pURPurchaseLineWCF.DeletedBy = _pURPurchaseLine.DeletedBy;
				
				pURPurchaseLineCollection.Add(_pURPurchaseLineWCF);
			}
			return pURPurchaseLineCollection;
		}
		
		/// <summary>
		/// This method will insert one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="pURPurchaseLine" type="PURPurchaseLine">This PURPurchaseLine  will be inserted in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Insert(PURPurchaseLine pURPurchaseLine)
		{
			_pURPurchaseLine = new POS.DataLayer.PURPurchaseLine();
			_pURPurchaseLine.PurchaseLineID=pURPurchaseLine.PurchaseLineID;
			_pURPurchaseLine.PurchaseHeaderID=pURPurchaseLine.PurchaseHeaderID;
			_pURPurchaseLine.ProductID=pURPurchaseLine.ProductID;
			_pURPurchaseLine.TotalQty=pURPurchaseLine.TotalQty;
			_pURPurchaseLine.BonusQty=pURPurchaseLine.BonusQty;
			_pURPurchaseLine.DiscountRatio=pURPurchaseLine.DiscountRatio;
			_pURPurchaseLine.DiscountAmount=pURPurchaseLine.DiscountAmount;
			_pURPurchaseLine.Unitprice=pURPurchaseLine.Unitprice;
			_pURPurchaseLine.CreatedDate=pURPurchaseLine.CreatedDate;
			_pURPurchaseLine.CreatedBy=pURPurchaseLine.CreatedBy;
			_pURPurchaseLine.UpdateDate=pURPurchaseLine.UpdateDate;
			_pURPurchaseLine.UpdatedBy=pURPurchaseLine.UpdatedBy;
			_pURPurchaseLine.IsDeleted=pURPurchaseLine.IsDeleted;
			_pURPurchaseLine.DeleteDate=pURPurchaseLine.DeleteDate;
			_pURPurchaseLine.DeletedBy=pURPurchaseLine.DeletedBy;
			
			return _pURPurchaseLine.Insert();
		}
		/// <summary>
		/// This method will delete row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="BDProductPrimaryKey">Primary Key information based on which data is to be deleted.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool DeleteAllByForeignKeyProductID(BDProductPrimaryKey pk)
		{
			return POS.DataLayer.PURPurchaseLineBase.DeleteAllByForeignKeyProductID(new POS.DataLayer.BDProductPrimaryKey(pk.ProductID));
		}
		
		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="BDProductPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class PURPurchaseLineCollection</returns>
		public PURPurchaseLineCollection SelectAllByForeignKeyProductID(BDProductPrimaryKey pk)
		{
			PURPurchaseLineCollection pURPurchaseLineCollection=new PURPurchaseLineCollection();
			foreach (POS.DataLayer.PURPurchaseLine _pURPurchaseLine in POS.DataLayer.PURPurchaseLineBase.SelectAllByForeignKeyProductID(new POS.DataLayer.BDProductPrimaryKey(pk.ProductID)))
			{
				_pURPurchaseLineWCF = new PURPurchaseLine();
				_pURPurchaseLineWCF.PurchaseLineID = _pURPurchaseLine.PurchaseLineID;
				_pURPurchaseLineWCF.PurchaseHeaderID = _pURPurchaseLine.PurchaseHeaderID;
				_pURPurchaseLineWCF.ProductID = _pURPurchaseLine.ProductID;
				_pURPurchaseLineWCF.TotalQty = _pURPurchaseLine.TotalQty;
				_pURPurchaseLineWCF.BonusQty = _pURPurchaseLine.BonusQty;
				_pURPurchaseLineWCF.DiscountRatio = _pURPurchaseLine.DiscountRatio;
				_pURPurchaseLineWCF.DiscountAmount = _pURPurchaseLine.DiscountAmount;
				_pURPurchaseLineWCF.Unitprice = _pURPurchaseLine.Unitprice;
				_pURPurchaseLineWCF.CreatedDate = _pURPurchaseLine.CreatedDate;
				_pURPurchaseLineWCF.CreatedBy = _pURPurchaseLine.CreatedBy;
				_pURPurchaseLineWCF.UpdateDate = _pURPurchaseLine.UpdateDate;
				_pURPurchaseLineWCF.UpdatedBy = _pURPurchaseLine.UpdatedBy;
				_pURPurchaseLineWCF.IsDeleted = _pURPurchaseLine.IsDeleted;
				_pURPurchaseLineWCF.DeleteDate = _pURPurchaseLine.DeleteDate;
				_pURPurchaseLineWCF.DeletedBy = _pURPurchaseLine.DeletedBy;
				
				pURPurchaseLineCollection.Add(_pURPurchaseLineWCF);
			}
			return pURPurchaseLineCollection;
		}
		
		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="BDProductPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>object of class PURPurchaseLineCollection</returns>
		public PURPurchaseLineCollection SelectAllByForeignKeyProductIDPaged(BDProductPrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			PURPurchaseLineCollection pURPurchaseLineCollection=new PURPurchaseLineCollection();
			foreach (POS.DataLayer.PURPurchaseLine _pURPurchaseLine in POS.DataLayer.PURPurchaseLineBase.SelectAllByForeignKeyProductIDPaged(new POS.DataLayer.BDProductPrimaryKey(pk.ProductID), pageSize, skipPages, orderByStatement))
			{
				_pURPurchaseLineWCF = new PURPurchaseLine();
				_pURPurchaseLineWCF.PurchaseLineID = _pURPurchaseLine.PurchaseLineID;
				_pURPurchaseLineWCF.PurchaseHeaderID = _pURPurchaseLine.PurchaseHeaderID;
				_pURPurchaseLineWCF.ProductID = _pURPurchaseLine.ProductID;
				_pURPurchaseLineWCF.TotalQty = _pURPurchaseLine.TotalQty;
				_pURPurchaseLineWCF.BonusQty = _pURPurchaseLine.BonusQty;
				_pURPurchaseLineWCF.DiscountRatio = _pURPurchaseLine.DiscountRatio;
				_pURPurchaseLineWCF.DiscountAmount = _pURPurchaseLine.DiscountAmount;
				_pURPurchaseLineWCF.Unitprice = _pURPurchaseLine.Unitprice;
				_pURPurchaseLineWCF.CreatedDate = _pURPurchaseLine.CreatedDate;
				_pURPurchaseLineWCF.CreatedBy = _pURPurchaseLine.CreatedBy;
				_pURPurchaseLineWCF.UpdateDate = _pURPurchaseLine.UpdateDate;
				_pURPurchaseLineWCF.UpdatedBy = _pURPurchaseLine.UpdatedBy;
				_pURPurchaseLineWCF.IsDeleted = _pURPurchaseLine.IsDeleted;
				_pURPurchaseLineWCF.DeleteDate = _pURPurchaseLine.DeleteDate;
				_pURPurchaseLineWCF.DeletedBy = _pURPurchaseLine.DeletedBy;
				
				pURPurchaseLineCollection.Add(_pURPurchaseLineWCF);
			}
			return pURPurchaseLineCollection;
		}
			/// <summary>
		/// This method will delete row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="PURPurchaseHeaderPrimaryKey">Primary Key information based on which data is to be deleted.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool DeleteAllByForeignKeyPurchaseHeaderID(PURPurchaseHeaderPrimaryKey pk)
		{
			return POS.DataLayer.PURPurchaseLineBase.DeleteAllByForeignKeyPurchaseHeaderID(new POS.DataLayer.PURPurchaseHeaderPrimaryKey(pk.PurcaseHeaderID));
		}
		
		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="PURPurchaseHeaderPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class PURPurchaseLineCollection</returns>
		public PURPurchaseLineCollection SelectAllByForeignKeyPurchaseHeaderID(PURPurchaseHeaderPrimaryKey pk)
		{
			PURPurchaseLineCollection pURPurchaseLineCollection=new PURPurchaseLineCollection();
			foreach (POS.DataLayer.PURPurchaseLine _pURPurchaseLine in POS.DataLayer.PURPurchaseLineBase.SelectAllByForeignKeyPurchaseHeaderID(new POS.DataLayer.PURPurchaseHeaderPrimaryKey(pk.PurcaseHeaderID)))
			{
				_pURPurchaseLineWCF = new PURPurchaseLine();
				_pURPurchaseLineWCF.PurchaseLineID = _pURPurchaseLine.PurchaseLineID;
				_pURPurchaseLineWCF.PurchaseHeaderID = _pURPurchaseLine.PurchaseHeaderID;
				_pURPurchaseLineWCF.ProductID = _pURPurchaseLine.ProductID;
				_pURPurchaseLineWCF.TotalQty = _pURPurchaseLine.TotalQty;
				_pURPurchaseLineWCF.BonusQty = _pURPurchaseLine.BonusQty;
				_pURPurchaseLineWCF.DiscountRatio = _pURPurchaseLine.DiscountRatio;
				_pURPurchaseLineWCF.DiscountAmount = _pURPurchaseLine.DiscountAmount;
				_pURPurchaseLineWCF.Unitprice = _pURPurchaseLine.Unitprice;
				_pURPurchaseLineWCF.CreatedDate = _pURPurchaseLine.CreatedDate;
				_pURPurchaseLineWCF.CreatedBy = _pURPurchaseLine.CreatedBy;
				_pURPurchaseLineWCF.UpdateDate = _pURPurchaseLine.UpdateDate;
				_pURPurchaseLineWCF.UpdatedBy = _pURPurchaseLine.UpdatedBy;
				_pURPurchaseLineWCF.IsDeleted = _pURPurchaseLine.IsDeleted;
				_pURPurchaseLineWCF.DeleteDate = _pURPurchaseLine.DeleteDate;
				_pURPurchaseLineWCF.DeletedBy = _pURPurchaseLine.DeletedBy;
				
				pURPurchaseLineCollection.Add(_pURPurchaseLineWCF);
			}
			return pURPurchaseLineCollection;
		}
		
		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="PURPurchaseHeaderPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>object of class PURPurchaseLineCollection</returns>
		public PURPurchaseLineCollection SelectAllByForeignKeyPurchaseHeaderIDPaged(PURPurchaseHeaderPrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			PURPurchaseLineCollection pURPurchaseLineCollection=new PURPurchaseLineCollection();
			foreach (POS.DataLayer.PURPurchaseLine _pURPurchaseLine in POS.DataLayer.PURPurchaseLineBase.SelectAllByForeignKeyPurchaseHeaderIDPaged(new POS.DataLayer.PURPurchaseHeaderPrimaryKey(pk.PurcaseHeaderID), pageSize, skipPages, orderByStatement))
			{
				_pURPurchaseLineWCF = new PURPurchaseLine();
				_pURPurchaseLineWCF.PurchaseLineID = _pURPurchaseLine.PurchaseLineID;
				_pURPurchaseLineWCF.PurchaseHeaderID = _pURPurchaseLine.PurchaseHeaderID;
				_pURPurchaseLineWCF.ProductID = _pURPurchaseLine.ProductID;
				_pURPurchaseLineWCF.TotalQty = _pURPurchaseLine.TotalQty;
				_pURPurchaseLineWCF.BonusQty = _pURPurchaseLine.BonusQty;
				_pURPurchaseLineWCF.DiscountRatio = _pURPurchaseLine.DiscountRatio;
				_pURPurchaseLineWCF.DiscountAmount = _pURPurchaseLine.DiscountAmount;
				_pURPurchaseLineWCF.Unitprice = _pURPurchaseLine.Unitprice;
				_pURPurchaseLineWCF.CreatedDate = _pURPurchaseLine.CreatedDate;
				_pURPurchaseLineWCF.CreatedBy = _pURPurchaseLine.CreatedBy;
				_pURPurchaseLineWCF.UpdateDate = _pURPurchaseLine.UpdateDate;
				_pURPurchaseLineWCF.UpdatedBy = _pURPurchaseLine.UpdatedBy;
				_pURPurchaseLineWCF.IsDeleted = _pURPurchaseLine.IsDeleted;
				_pURPurchaseLineWCF.DeleteDate = _pURPurchaseLine.DeleteDate;
				_pURPurchaseLineWCF.DeletedBy = _pURPurchaseLine.DeletedBy;
				
				pURPurchaseLineCollection.Add(_pURPurchaseLineWCF);
			}
			return pURPurchaseLineCollection;
		}
			
		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>list of objects of class PURPurchaseLine in the form of an object of class PURPurchaseLineCollection </returns>
		public PURPurchaseLineCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			PURPurchaseLineCollection pURPurchaseLineCollection = new PURPurchaseLineCollection();
			foreach (POS.DataLayer.PURPurchaseLine _pURPurchaseLine in POS.DataLayer.PURPurchaseLineBase.SelectAllPaged(pageSize, skipPages, orderByStatement))
			{
				_pURPurchaseLineWCF = new PURPurchaseLine();
				
				_pURPurchaseLineWCF.PurchaseLineID = _pURPurchaseLine.PurchaseLineID;
				_pURPurchaseLineWCF.PurchaseHeaderID = _pURPurchaseLine.PurchaseHeaderID;
				_pURPurchaseLineWCF.ProductID = _pURPurchaseLine.ProductID;
				_pURPurchaseLineWCF.TotalQty = _pURPurchaseLine.TotalQty;
				_pURPurchaseLineWCF.BonusQty = _pURPurchaseLine.BonusQty;
				_pURPurchaseLineWCF.DiscountRatio = _pURPurchaseLine.DiscountRatio;
				_pURPurchaseLineWCF.DiscountAmount = _pURPurchaseLine.DiscountAmount;
				_pURPurchaseLineWCF.Unitprice = _pURPurchaseLine.Unitprice;
				_pURPurchaseLineWCF.CreatedDate = _pURPurchaseLine.CreatedDate;
				_pURPurchaseLineWCF.CreatedBy = _pURPurchaseLine.CreatedBy;
				_pURPurchaseLineWCF.UpdateDate = _pURPurchaseLine.UpdateDate;
				_pURPurchaseLineWCF.UpdatedBy = _pURPurchaseLine.UpdatedBy;
				_pURPurchaseLineWCF.IsDeleted = _pURPurchaseLine.IsDeleted;
				_pURPurchaseLineWCF.DeleteDate = _pURPurchaseLine.DeleteDate;
				_pURPurchaseLineWCF.DeletedBy = _pURPurchaseLine.DeletedBy;
				
				pURPurchaseLineCollection.Add(_pURPurchaseLineWCF);
			}
			return pURPurchaseLineCollection;
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class PURPurchaseLine</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class PURPurchaseLine in the form of an object of class PURPurchaseLineCollection</returns>
		public PURPurchaseLineCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
		{
			PURPurchaseLineCollection pURPurchaseLineCollection = new PURPurchaseLineCollection();
			foreach (POS.DataLayer.PURPurchaseLine _pURPurchaseLine in POS.DataLayer.PURPurchaseLineBase.SelectByFieldPaged(field, fieldValue, fieldValue2, typeOperation, pageSize, skipPages, orderByStatement))
			{
				_pURPurchaseLineWCF = new PURPurchaseLine();
				
				_pURPurchaseLineWCF.PurchaseLineID = _pURPurchaseLine.PurchaseLineID;
				_pURPurchaseLineWCF.PurchaseHeaderID = _pURPurchaseLine.PurchaseHeaderID;
				_pURPurchaseLineWCF.ProductID = _pURPurchaseLine.ProductID;
				_pURPurchaseLineWCF.TotalQty = _pURPurchaseLine.TotalQty;
				_pURPurchaseLineWCF.BonusQty = _pURPurchaseLine.BonusQty;
				_pURPurchaseLineWCF.DiscountRatio = _pURPurchaseLine.DiscountRatio;
				_pURPurchaseLineWCF.DiscountAmount = _pURPurchaseLine.DiscountAmount;
				_pURPurchaseLineWCF.Unitprice = _pURPurchaseLine.Unitprice;
				_pURPurchaseLineWCF.CreatedDate = _pURPurchaseLine.CreatedDate;
				_pURPurchaseLineWCF.CreatedBy = _pURPurchaseLine.CreatedBy;
				_pURPurchaseLineWCF.UpdateDate = _pURPurchaseLine.UpdateDate;
				_pURPurchaseLineWCF.UpdatedBy = _pURPurchaseLine.UpdatedBy;
				_pURPurchaseLineWCF.IsDeleted = _pURPurchaseLine.IsDeleted;
				_pURPurchaseLineWCF.DeleteDate = _pURPurchaseLine.DeleteDate;
				_pURPurchaseLineWCF.DeletedBy = _pURPurchaseLine.DeletedBy;
				
				pURPurchaseLineCollection.Add(_pURPurchaseLineWCF);
			}
			return pURPurchaseLineCollection;
		}
			///<summary>
		/// This method will update one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="pURPurchaseLine" type="PURPurchaseLine">This PURPurchaseLine  will be updated in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Update(PURPurchaseLine pURPurchaseLine)
		{
			_pURPurchaseLine=POS.DataLayer.PURPurchaseLine.SelectOne(new POS.DataLayer.PURPurchaseLinePrimaryKey(pURPurchaseLine.PurchaseLineID));
			
			_pURPurchaseLine.PurchaseHeaderID=pURPurchaseLine.PurchaseHeaderID;
			_pURPurchaseLine.ProductID=pURPurchaseLine.ProductID;
			_pURPurchaseLine.TotalQty=pURPurchaseLine.TotalQty;
			_pURPurchaseLine.BonusQty=pURPurchaseLine.BonusQty;
			_pURPurchaseLine.DiscountRatio=pURPurchaseLine.DiscountRatio;
			_pURPurchaseLine.DiscountAmount=pURPurchaseLine.DiscountAmount;
			_pURPurchaseLine.Unitprice=pURPurchaseLine.Unitprice;
			_pURPurchaseLine.CreatedDate=pURPurchaseLine.CreatedDate;
			_pURPurchaseLine.CreatedBy=pURPurchaseLine.CreatedBy;
			_pURPurchaseLine.UpdateDate=pURPurchaseLine.UpdateDate;
			_pURPurchaseLine.UpdatedBy=pURPurchaseLine.UpdatedBy;
			_pURPurchaseLine.IsDeleted=pURPurchaseLine.IsDeleted;
			_pURPurchaseLine.DeleteDate=pURPurchaseLine.DeleteDate;
			_pURPurchaseLine.DeletedBy=pURPurchaseLine.DeletedBy;
			
			return _pURPurchaseLine.Update();
		}
	} 
}
