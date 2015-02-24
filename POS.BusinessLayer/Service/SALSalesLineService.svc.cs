//
// Class	:	SALSalesLineServices.svc.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	2/24/2015 2:25:54 AM
//


using POS.DataLayer;

namespace POS.BusinessLayer
{
	///<summary>
	///WCF service for the SALSalesLine
	///</summary>
	public class SALSalesLineService
	{
		private SALSalesLine _sALSalesLineWCF;
		private POS.DataLayer.SALSalesLine _sALSalesLine;
		
		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="SALSalesLineFields">Field of the class SALSalesLine</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <returns>True if succeeded</returns>
		public bool DeleteByField(string field, object fieldValue)
		{
			return POS.DataLayer.SALSalesLineBase.DeleteByField(field, fieldValue);
		}

		///<summary>
		///This method will Delete the object from the database
		///</summary>
		///<param name="pk" type="SALSalesLinePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <returns>True if succeeded</returns>
		public bool Delete(SALSalesLinePrimaryKey pk)
		{
			return POS.DataLayer.SALSalesLineBase.Delete(new POS.DataLayer.SALSalesLinePrimaryKey(pk.SalesLineID));
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="SALSalesLinePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class SALSalesLine</returns>
		public SALSalesLine SelectOne(SALSalesLinePrimaryKey pk)
		{
			_sALSalesLineWCF = new SALSalesLine();
			_sALSalesLine = POS.DataLayer.SALSalesLineBase.SelectOne(new POS.DataLayer.SALSalesLinePrimaryKey(pk.SalesLineID));
			
				_sALSalesLineWCF.SalesLineID = _sALSalesLine.SalesLineID;
				_sALSalesLineWCF.SalesHeaderID = _sALSalesLine.SalesHeaderID;
				_sALSalesLineWCF.ProductID = _sALSalesLine.ProductID;
				_sALSalesLineWCF.TotalQty = _sALSalesLine.TotalQty;
				_sALSalesLineWCF.TotalBonus = _sALSalesLine.TotalBonus;
				_sALSalesLineWCF.DiscountAmount = _sALSalesLine.DiscountAmount;
				_sALSalesLineWCF.DiscountRatio = _sALSalesLine.DiscountRatio;
				_sALSalesLineWCF.UnitPrice = _sALSalesLine.UnitPrice;
				_sALSalesLineWCF.CreatedBy = _sALSalesLine.CreatedBy;
				_sALSalesLineWCF.CreateDate = _sALSalesLine.CreateDate;
				_sALSalesLineWCF.UpdatedBy = _sALSalesLine.UpdatedBy;
				_sALSalesLineWCF.UpdateDate = _sALSalesLine.UpdateDate;
				_sALSalesLineWCF.IsDeleted = _sALSalesLine.IsDeleted;
				_sALSalesLineWCF.DeletedBy = _sALSalesLine.DeletedBy;
				_sALSalesLineWCF.DeleteDate = _sALSalesLine.DeleteDate;
				
			return _sALSalesLineWCF;
		}

		/// <summary>
		/// This method will return a list of objects representing all records in the table.
		/// </summary>
		///
		/// <returns>list of objects of class SALSalesLine in the form of object of SALSalesLineCollection </returns>
		public SALSalesLineCollection SelectAll()
		{
			SALSalesLineCollection sALSalesLineCollection = new SALSalesLineCollection();
			foreach (POS.DataLayer.SALSalesLine _sALSalesLine in POS.DataLayer.SALSalesLineBase.SelectAll())
			{
				_sALSalesLineWCF = new SALSalesLine();
				
				_sALSalesLineWCF.SalesLineID = _sALSalesLine.SalesLineID;
				_sALSalesLineWCF.SalesHeaderID = _sALSalesLine.SalesHeaderID;
				_sALSalesLineWCF.ProductID = _sALSalesLine.ProductID;
				_sALSalesLineWCF.TotalQty = _sALSalesLine.TotalQty;
				_sALSalesLineWCF.TotalBonus = _sALSalesLine.TotalBonus;
				_sALSalesLineWCF.DiscountAmount = _sALSalesLine.DiscountAmount;
				_sALSalesLineWCF.DiscountRatio = _sALSalesLine.DiscountRatio;
				_sALSalesLineWCF.UnitPrice = _sALSalesLine.UnitPrice;
				_sALSalesLineWCF.CreatedBy = _sALSalesLine.CreatedBy;
				_sALSalesLineWCF.CreateDate = _sALSalesLine.CreateDate;
				_sALSalesLineWCF.UpdatedBy = _sALSalesLine.UpdatedBy;
				_sALSalesLineWCF.UpdateDate = _sALSalesLine.UpdateDate;
				_sALSalesLineWCF.IsDeleted = _sALSalesLine.IsDeleted;
				_sALSalesLineWCF.DeletedBy = _sALSalesLine.DeletedBy;
				_sALSalesLineWCF.DeleteDate = _sALSalesLine.DeleteDate;
				
				sALSalesLineCollection.Add(_sALSalesLineWCF);
			}
			return sALSalesLineCollection;
		}
    
    /// <summary>
		/// This method will return a count all records in the table.
		/// </summary>
		///
		/// <returns>count records</returns>
		public int SelectAllCount()
		{
			return POS.DataLayer.SALSalesLineBase.SelectAllCount();			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class SALSalesLine</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class SALSalesLine in the form of an object of class SALSalesLineCollection</returns>
		public SALSalesLineCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
		{
			SALSalesLineCollection sALSalesLineCollection = new SALSalesLineCollection();
			foreach (POS.DataLayer.SALSalesLine _sALSalesLine in POS.DataLayer.SALSalesLineBase.SelectByField(field, fieldValue, fieldValue2, typeOperation))
			{
				_sALSalesLineWCF = new SALSalesLine();
				
				_sALSalesLineWCF.SalesLineID = _sALSalesLine.SalesLineID;
				_sALSalesLineWCF.SalesHeaderID = _sALSalesLine.SalesHeaderID;
				_sALSalesLineWCF.ProductID = _sALSalesLine.ProductID;
				_sALSalesLineWCF.TotalQty = _sALSalesLine.TotalQty;
				_sALSalesLineWCF.TotalBonus = _sALSalesLine.TotalBonus;
				_sALSalesLineWCF.DiscountAmount = _sALSalesLine.DiscountAmount;
				_sALSalesLineWCF.DiscountRatio = _sALSalesLine.DiscountRatio;
				_sALSalesLineWCF.UnitPrice = _sALSalesLine.UnitPrice;
				_sALSalesLineWCF.CreatedBy = _sALSalesLine.CreatedBy;
				_sALSalesLineWCF.CreateDate = _sALSalesLine.CreateDate;
				_sALSalesLineWCF.UpdatedBy = _sALSalesLine.UpdatedBy;
				_sALSalesLineWCF.UpdateDate = _sALSalesLine.UpdateDate;
				_sALSalesLineWCF.IsDeleted = _sALSalesLine.IsDeleted;
				_sALSalesLineWCF.DeletedBy = _sALSalesLine.DeletedBy;
				_sALSalesLineWCF.DeleteDate = _sALSalesLine.DeleteDate;
				
				sALSalesLineCollection.Add(_sALSalesLineWCF);
			}
			return sALSalesLineCollection;
		}
		
		/// <summary>
		/// This method will insert one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="sALSalesLine" type="SALSalesLine">This SALSalesLine  will be inserted in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Insert(SALSalesLine sALSalesLine)
		{
			_sALSalesLine = new POS.DataLayer.SALSalesLine();
			_sALSalesLine.SalesLineID=sALSalesLine.SalesLineID;
			_sALSalesLine.SalesHeaderID=sALSalesLine.SalesHeaderID;
			_sALSalesLine.ProductID=sALSalesLine.ProductID;
			_sALSalesLine.TotalQty=sALSalesLine.TotalQty;
			_sALSalesLine.TotalBonus=sALSalesLine.TotalBonus;
			_sALSalesLine.DiscountAmount=sALSalesLine.DiscountAmount;
			_sALSalesLine.DiscountRatio=sALSalesLine.DiscountRatio;
			_sALSalesLine.UnitPrice=sALSalesLine.UnitPrice;
			_sALSalesLine.CreatedBy=sALSalesLine.CreatedBy;
			_sALSalesLine.CreateDate=sALSalesLine.CreateDate;
			_sALSalesLine.UpdatedBy=sALSalesLine.UpdatedBy;
			_sALSalesLine.UpdateDate=sALSalesLine.UpdateDate;
			_sALSalesLine.IsDeleted=sALSalesLine.IsDeleted;
			_sALSalesLine.DeletedBy=sALSalesLine.DeletedBy;
			_sALSalesLine.DeleteDate=sALSalesLine.DeleteDate;
			
			return _sALSalesLine.Insert();
		}
		
		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>list of objects of class SALSalesLine in the form of an object of class SALSalesLineCollection </returns>
		public SALSalesLineCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			SALSalesLineCollection sALSalesLineCollection = new SALSalesLineCollection();
			foreach (POS.DataLayer.SALSalesLine _sALSalesLine in POS.DataLayer.SALSalesLineBase.SelectAllPaged(pageSize, skipPages, orderByStatement))
			{
				_sALSalesLineWCF = new SALSalesLine();
				
				_sALSalesLineWCF.SalesLineID = _sALSalesLine.SalesLineID;
				_sALSalesLineWCF.SalesHeaderID = _sALSalesLine.SalesHeaderID;
				_sALSalesLineWCF.ProductID = _sALSalesLine.ProductID;
				_sALSalesLineWCF.TotalQty = _sALSalesLine.TotalQty;
				_sALSalesLineWCF.TotalBonus = _sALSalesLine.TotalBonus;
				_sALSalesLineWCF.DiscountAmount = _sALSalesLine.DiscountAmount;
				_sALSalesLineWCF.DiscountRatio = _sALSalesLine.DiscountRatio;
				_sALSalesLineWCF.UnitPrice = _sALSalesLine.UnitPrice;
				_sALSalesLineWCF.CreatedBy = _sALSalesLine.CreatedBy;
				_sALSalesLineWCF.CreateDate = _sALSalesLine.CreateDate;
				_sALSalesLineWCF.UpdatedBy = _sALSalesLine.UpdatedBy;
				_sALSalesLineWCF.UpdateDate = _sALSalesLine.UpdateDate;
				_sALSalesLineWCF.IsDeleted = _sALSalesLine.IsDeleted;
				_sALSalesLineWCF.DeletedBy = _sALSalesLine.DeletedBy;
				_sALSalesLineWCF.DeleteDate = _sALSalesLine.DeleteDate;
				
				sALSalesLineCollection.Add(_sALSalesLineWCF);
			}
			return sALSalesLineCollection;
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class SALSalesLine</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class SALSalesLine in the form of an object of class SALSalesLineCollection</returns>
		public SALSalesLineCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
		{
			SALSalesLineCollection sALSalesLineCollection = new SALSalesLineCollection();
			foreach (POS.DataLayer.SALSalesLine _sALSalesLine in POS.DataLayer.SALSalesLineBase.SelectByFieldPaged(field, fieldValue, fieldValue2, typeOperation, pageSize, skipPages, orderByStatement))
			{
				_sALSalesLineWCF = new SALSalesLine();
				
				_sALSalesLineWCF.SalesLineID = _sALSalesLine.SalesLineID;
				_sALSalesLineWCF.SalesHeaderID = _sALSalesLine.SalesHeaderID;
				_sALSalesLineWCF.ProductID = _sALSalesLine.ProductID;
				_sALSalesLineWCF.TotalQty = _sALSalesLine.TotalQty;
				_sALSalesLineWCF.TotalBonus = _sALSalesLine.TotalBonus;
				_sALSalesLineWCF.DiscountAmount = _sALSalesLine.DiscountAmount;
				_sALSalesLineWCF.DiscountRatio = _sALSalesLine.DiscountRatio;
				_sALSalesLineWCF.UnitPrice = _sALSalesLine.UnitPrice;
				_sALSalesLineWCF.CreatedBy = _sALSalesLine.CreatedBy;
				_sALSalesLineWCF.CreateDate = _sALSalesLine.CreateDate;
				_sALSalesLineWCF.UpdatedBy = _sALSalesLine.UpdatedBy;
				_sALSalesLineWCF.UpdateDate = _sALSalesLine.UpdateDate;
				_sALSalesLineWCF.IsDeleted = _sALSalesLine.IsDeleted;
				_sALSalesLineWCF.DeletedBy = _sALSalesLine.DeletedBy;
				_sALSalesLineWCF.DeleteDate = _sALSalesLine.DeleteDate;
				
				sALSalesLineCollection.Add(_sALSalesLineWCF);
			}
			return sALSalesLineCollection;
		}
			///<summary>
		/// This method will update one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="sALSalesLine" type="SALSalesLine">This SALSalesLine  will be updated in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Update(SALSalesLine sALSalesLine)
		{
			_sALSalesLine=POS.DataLayer.SALSalesLine.SelectOne(new POS.DataLayer.SALSalesLinePrimaryKey(sALSalesLine.SalesLineID));
			
			_sALSalesLine.SalesHeaderID=sALSalesLine.SalesHeaderID;
			_sALSalesLine.ProductID=sALSalesLine.ProductID;
			_sALSalesLine.TotalQty=sALSalesLine.TotalQty;
			_sALSalesLine.TotalBonus=sALSalesLine.TotalBonus;
			_sALSalesLine.DiscountAmount=sALSalesLine.DiscountAmount;
			_sALSalesLine.DiscountRatio=sALSalesLine.DiscountRatio;
			_sALSalesLine.UnitPrice=sALSalesLine.UnitPrice;
			_sALSalesLine.CreatedBy=sALSalesLine.CreatedBy;
			_sALSalesLine.CreateDate=sALSalesLine.CreateDate;
			_sALSalesLine.UpdatedBy=sALSalesLine.UpdatedBy;
			_sALSalesLine.UpdateDate=sALSalesLine.UpdateDate;
			_sALSalesLine.IsDeleted=sALSalesLine.IsDeleted;
			_sALSalesLine.DeletedBy=sALSalesLine.DeletedBy;
			_sALSalesLine.DeleteDate=sALSalesLine.DeleteDate;
			
			return _sALSalesLine.Update();
		}
	} 
}
