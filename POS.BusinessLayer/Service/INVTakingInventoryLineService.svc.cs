//
// Class	:	INVTakingInventoryLineServices.svc.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:55:58 PM
//

using POS.DataLayer;

namespace POS.BusinessLayer
{
	///<summary>
	///WCF service for the INVTakingInventoryLine
	///</summary>
	public class INVTakingInventoryLineService 
	{
		private INVTakingInventoryLine _iNVTakingInventoryLineWCF;
		private POS.DataLayer.INVTakingInventoryLine _iNVTakingInventoryLine;
		
		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="INVTakingInventoryLineFields">Field of the class INVTakingInventoryLine</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <returns>True if succeeded</returns>
		public bool DeleteByField(string field, object fieldValue)
		{
			return POS.DataLayer.INVTakingInventoryLineBase.DeleteByField(field, fieldValue);
		}

		///<summary>
		///This method will Delete the object from the database
		///</summary>
		///<param name="pk" type="INVTakingInventoryLinePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <returns>True if succeeded</returns>
		public bool Delete(INVTakingInventoryLinePrimaryKey pk)
		{
			return POS.DataLayer.INVTakingInventoryLineBase.Delete(new POS.DataLayer.INVTakingInventoryLinePrimaryKey(pk.TakingLineID));
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="INVTakingInventoryLinePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class INVTakingInventoryLine</returns>
		public INVTakingInventoryLine SelectOne(INVTakingInventoryLinePrimaryKey pk)
		{
			_iNVTakingInventoryLineWCF = new INVTakingInventoryLine();
			_iNVTakingInventoryLine = POS.DataLayer.INVTakingInventoryLineBase.SelectOne(new POS.DataLayer.INVTakingInventoryLinePrimaryKey(pk.TakingLineID));
			
				_iNVTakingInventoryLineWCF.TakingLineID = _iNVTakingInventoryLine.TakingLineID;
				_iNVTakingInventoryLineWCF.TakingHeaderID = _iNVTakingInventoryLine.TakingHeaderID;
				_iNVTakingInventoryLineWCF.ProductID = _iNVTakingInventoryLine.ProductID;
				_iNVTakingInventoryLineWCF.ActualQty = _iNVTakingInventoryLine.ActualQty;
				_iNVTakingInventoryLineWCF.ExpectedQty = _iNVTakingInventoryLine.ExpectedQty;
				_iNVTakingInventoryLineWCF.CreatedBy = _iNVTakingInventoryLine.CreatedBy;
				_iNVTakingInventoryLineWCF.CreateDate = _iNVTakingInventoryLine.CreateDate;
				_iNVTakingInventoryLineWCF.UpdatedBy = _iNVTakingInventoryLine.UpdatedBy;
				_iNVTakingInventoryLineWCF.UpdateDate = _iNVTakingInventoryLine.UpdateDate;
				_iNVTakingInventoryLineWCF.IsDeleted = _iNVTakingInventoryLine.IsDeleted;
				_iNVTakingInventoryLineWCF.DeletedBy = _iNVTakingInventoryLine.DeletedBy;
				_iNVTakingInventoryLineWCF.DeleteDate = _iNVTakingInventoryLine.DeleteDate;
				
			return _iNVTakingInventoryLineWCF;
		}

		/// <summary>
		/// This method will return a list of objects representing all records in the table.
		/// </summary>
		///
		/// <returns>list of objects of class INVTakingInventoryLine in the form of object of INVTakingInventoryLineCollection </returns>
		public INVTakingInventoryLineCollection SelectAll()
		{
			INVTakingInventoryLineCollection iNVTakingInventoryLineCollection = new INVTakingInventoryLineCollection();
			foreach (POS.DataLayer.INVTakingInventoryLine _iNVTakingInventoryLine in POS.DataLayer.INVTakingInventoryLineBase.SelectAll())
			{
				_iNVTakingInventoryLineWCF = new INVTakingInventoryLine();
				
				_iNVTakingInventoryLineWCF.TakingLineID = _iNVTakingInventoryLine.TakingLineID;
				_iNVTakingInventoryLineWCF.TakingHeaderID = _iNVTakingInventoryLine.TakingHeaderID;
				_iNVTakingInventoryLineWCF.ProductID = _iNVTakingInventoryLine.ProductID;
				_iNVTakingInventoryLineWCF.ActualQty = _iNVTakingInventoryLine.ActualQty;
				_iNVTakingInventoryLineWCF.ExpectedQty = _iNVTakingInventoryLine.ExpectedQty;
				_iNVTakingInventoryLineWCF.CreatedBy = _iNVTakingInventoryLine.CreatedBy;
				_iNVTakingInventoryLineWCF.CreateDate = _iNVTakingInventoryLine.CreateDate;
				_iNVTakingInventoryLineWCF.UpdatedBy = _iNVTakingInventoryLine.UpdatedBy;
				_iNVTakingInventoryLineWCF.UpdateDate = _iNVTakingInventoryLine.UpdateDate;
				_iNVTakingInventoryLineWCF.IsDeleted = _iNVTakingInventoryLine.IsDeleted;
				_iNVTakingInventoryLineWCF.DeletedBy = _iNVTakingInventoryLine.DeletedBy;
				_iNVTakingInventoryLineWCF.DeleteDate = _iNVTakingInventoryLine.DeleteDate;
				
				iNVTakingInventoryLineCollection.Add(_iNVTakingInventoryLineWCF);
			}
			return iNVTakingInventoryLineCollection;
		}
    
    /// <summary>
		/// This method will return a count all records in the table.
		/// </summary>
		///
		/// <returns>count records</returns>
		public int SelectAllCount()
		{
			return POS.DataLayer.INVTakingInventoryLineBase.SelectAllCount();			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class INVTakingInventoryLine</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class INVTakingInventoryLine in the form of an object of class INVTakingInventoryLineCollection</returns>
		public INVTakingInventoryLineCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
		{
			INVTakingInventoryLineCollection iNVTakingInventoryLineCollection = new INVTakingInventoryLineCollection();
			foreach (POS.DataLayer.INVTakingInventoryLine _iNVTakingInventoryLine in POS.DataLayer.INVTakingInventoryLineBase.SelectByField(field, fieldValue, fieldValue2, typeOperation))
			{
				_iNVTakingInventoryLineWCF = new INVTakingInventoryLine();
				
				_iNVTakingInventoryLineWCF.TakingLineID = _iNVTakingInventoryLine.TakingLineID;
				_iNVTakingInventoryLineWCF.TakingHeaderID = _iNVTakingInventoryLine.TakingHeaderID;
				_iNVTakingInventoryLineWCF.ProductID = _iNVTakingInventoryLine.ProductID;
				_iNVTakingInventoryLineWCF.ActualQty = _iNVTakingInventoryLine.ActualQty;
				_iNVTakingInventoryLineWCF.ExpectedQty = _iNVTakingInventoryLine.ExpectedQty;
				_iNVTakingInventoryLineWCF.CreatedBy = _iNVTakingInventoryLine.CreatedBy;
				_iNVTakingInventoryLineWCF.CreateDate = _iNVTakingInventoryLine.CreateDate;
				_iNVTakingInventoryLineWCF.UpdatedBy = _iNVTakingInventoryLine.UpdatedBy;
				_iNVTakingInventoryLineWCF.UpdateDate = _iNVTakingInventoryLine.UpdateDate;
				_iNVTakingInventoryLineWCF.IsDeleted = _iNVTakingInventoryLine.IsDeleted;
				_iNVTakingInventoryLineWCF.DeletedBy = _iNVTakingInventoryLine.DeletedBy;
				_iNVTakingInventoryLineWCF.DeleteDate = _iNVTakingInventoryLine.DeleteDate;
				
				iNVTakingInventoryLineCollection.Add(_iNVTakingInventoryLineWCF);
			}
			return iNVTakingInventoryLineCollection;
		}
		
		/// <summary>
		/// This method will insert one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="iNVTakingInventoryLine" type="INVTakingInventoryLine">This INVTakingInventoryLine  will be inserted in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Insert(INVTakingInventoryLine iNVTakingInventoryLine)
		{
			_iNVTakingInventoryLine = new POS.DataLayer.INVTakingInventoryLine();
			_iNVTakingInventoryLine.TakingLineID=iNVTakingInventoryLine.TakingLineID;
			_iNVTakingInventoryLine.TakingHeaderID=iNVTakingInventoryLine.TakingHeaderID;
			_iNVTakingInventoryLine.ProductID=iNVTakingInventoryLine.ProductID;
			_iNVTakingInventoryLine.ActualQty=iNVTakingInventoryLine.ActualQty;
			_iNVTakingInventoryLine.ExpectedQty=iNVTakingInventoryLine.ExpectedQty;
			_iNVTakingInventoryLine.CreatedBy=iNVTakingInventoryLine.CreatedBy;
			_iNVTakingInventoryLine.CreateDate=iNVTakingInventoryLine.CreateDate;
			_iNVTakingInventoryLine.UpdatedBy=iNVTakingInventoryLine.UpdatedBy;
			_iNVTakingInventoryLine.UpdateDate=iNVTakingInventoryLine.UpdateDate;
			_iNVTakingInventoryLine.IsDeleted=iNVTakingInventoryLine.IsDeleted;
			_iNVTakingInventoryLine.DeletedBy=iNVTakingInventoryLine.DeletedBy;
			_iNVTakingInventoryLine.DeleteDate=iNVTakingInventoryLine.DeleteDate;
			
			return _iNVTakingInventoryLine.Insert();
		}
		
		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>list of objects of class INVTakingInventoryLine in the form of an object of class INVTakingInventoryLineCollection </returns>
		public INVTakingInventoryLineCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			INVTakingInventoryLineCollection iNVTakingInventoryLineCollection = new INVTakingInventoryLineCollection();
			foreach (POS.DataLayer.INVTakingInventoryLine _iNVTakingInventoryLine in POS.DataLayer.INVTakingInventoryLineBase.SelectAllPaged(pageSize, skipPages, orderByStatement))
			{
				_iNVTakingInventoryLineWCF = new INVTakingInventoryLine();
				
				_iNVTakingInventoryLineWCF.TakingLineID = _iNVTakingInventoryLine.TakingLineID;
				_iNVTakingInventoryLineWCF.TakingHeaderID = _iNVTakingInventoryLine.TakingHeaderID;
				_iNVTakingInventoryLineWCF.ProductID = _iNVTakingInventoryLine.ProductID;
				_iNVTakingInventoryLineWCF.ActualQty = _iNVTakingInventoryLine.ActualQty;
				_iNVTakingInventoryLineWCF.ExpectedQty = _iNVTakingInventoryLine.ExpectedQty;
				_iNVTakingInventoryLineWCF.CreatedBy = _iNVTakingInventoryLine.CreatedBy;
				_iNVTakingInventoryLineWCF.CreateDate = _iNVTakingInventoryLine.CreateDate;
				_iNVTakingInventoryLineWCF.UpdatedBy = _iNVTakingInventoryLine.UpdatedBy;
				_iNVTakingInventoryLineWCF.UpdateDate = _iNVTakingInventoryLine.UpdateDate;
				_iNVTakingInventoryLineWCF.IsDeleted = _iNVTakingInventoryLine.IsDeleted;
				_iNVTakingInventoryLineWCF.DeletedBy = _iNVTakingInventoryLine.DeletedBy;
				_iNVTakingInventoryLineWCF.DeleteDate = _iNVTakingInventoryLine.DeleteDate;
				
				iNVTakingInventoryLineCollection.Add(_iNVTakingInventoryLineWCF);
			}
			return iNVTakingInventoryLineCollection;
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class INVTakingInventoryLine</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class INVTakingInventoryLine in the form of an object of class INVTakingInventoryLineCollection</returns>
		public INVTakingInventoryLineCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
		{
			INVTakingInventoryLineCollection iNVTakingInventoryLineCollection = new INVTakingInventoryLineCollection();
			foreach (POS.DataLayer.INVTakingInventoryLine _iNVTakingInventoryLine in POS.DataLayer.INVTakingInventoryLineBase.SelectByFieldPaged(field, fieldValue, fieldValue2, typeOperation, pageSize, skipPages, orderByStatement))
			{
				_iNVTakingInventoryLineWCF = new INVTakingInventoryLine();
				
				_iNVTakingInventoryLineWCF.TakingLineID = _iNVTakingInventoryLine.TakingLineID;
				_iNVTakingInventoryLineWCF.TakingHeaderID = _iNVTakingInventoryLine.TakingHeaderID;
				_iNVTakingInventoryLineWCF.ProductID = _iNVTakingInventoryLine.ProductID;
				_iNVTakingInventoryLineWCF.ActualQty = _iNVTakingInventoryLine.ActualQty;
				_iNVTakingInventoryLineWCF.ExpectedQty = _iNVTakingInventoryLine.ExpectedQty;
				_iNVTakingInventoryLineWCF.CreatedBy = _iNVTakingInventoryLine.CreatedBy;
				_iNVTakingInventoryLineWCF.CreateDate = _iNVTakingInventoryLine.CreateDate;
				_iNVTakingInventoryLineWCF.UpdatedBy = _iNVTakingInventoryLine.UpdatedBy;
				_iNVTakingInventoryLineWCF.UpdateDate = _iNVTakingInventoryLine.UpdateDate;
				_iNVTakingInventoryLineWCF.IsDeleted = _iNVTakingInventoryLine.IsDeleted;
				_iNVTakingInventoryLineWCF.DeletedBy = _iNVTakingInventoryLine.DeletedBy;
				_iNVTakingInventoryLineWCF.DeleteDate = _iNVTakingInventoryLine.DeleteDate;
				
				iNVTakingInventoryLineCollection.Add(_iNVTakingInventoryLineWCF);
			}
			return iNVTakingInventoryLineCollection;
		}
			///<summary>
		/// This method will update one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="iNVTakingInventoryLine" type="INVTakingInventoryLine">This INVTakingInventoryLine  will be updated in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Update(INVTakingInventoryLine iNVTakingInventoryLine)
		{
			_iNVTakingInventoryLine=POS.DataLayer.INVTakingInventoryLine.SelectOne(new POS.DataLayer.INVTakingInventoryLinePrimaryKey(iNVTakingInventoryLine.TakingLineID));
			
			_iNVTakingInventoryLine.TakingHeaderID=iNVTakingInventoryLine.TakingHeaderID;
			_iNVTakingInventoryLine.ProductID=iNVTakingInventoryLine.ProductID;
			_iNVTakingInventoryLine.ActualQty=iNVTakingInventoryLine.ActualQty;
			_iNVTakingInventoryLine.ExpectedQty=iNVTakingInventoryLine.ExpectedQty;
			_iNVTakingInventoryLine.CreatedBy=iNVTakingInventoryLine.CreatedBy;
			_iNVTakingInventoryLine.CreateDate=iNVTakingInventoryLine.CreateDate;
			_iNVTakingInventoryLine.UpdatedBy=iNVTakingInventoryLine.UpdatedBy;
			_iNVTakingInventoryLine.UpdateDate=iNVTakingInventoryLine.UpdateDate;
			_iNVTakingInventoryLine.IsDeleted=iNVTakingInventoryLine.IsDeleted;
			_iNVTakingInventoryLine.DeletedBy=iNVTakingInventoryLine.DeletedBy;
			_iNVTakingInventoryLine.DeleteDate=iNVTakingInventoryLine.DeleteDate;
			
			return _iNVTakingInventoryLine.Update();
		}
	} 
}
