//
// Class	:	SALSalesReturnHeaderServices.svc.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:56:05 PM
//


using POS.DataLayer;

namespace POS.BusinessLayer
{
	///<summary>
	///WCF service for the SALSalesReturnHeader
	///</summary>
	public class SALSalesReturnHeaderService 
	{
		private SALSalesReturnHeader _sALSalesReturnHeaderWCF;
		private POS.DataLayer.SALSalesReturnHeader _sALSalesReturnHeader;
		
		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="SALSalesReturnHeaderFields">Field of the class SALSalesReturnHeader</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <returns>True if succeeded</returns>
		public bool DeleteByField(string field, object fieldValue)
		{
			return POS.DataLayer.SALSalesReturnHeaderBase.DeleteByField(field, fieldValue);
		}

		///<summary>
		///This method will Delete the object from the database
		///</summary>
		///<param name="pk" type="SALSalesReturnHeaderPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <returns>True if succeeded</returns>
		public bool Delete(SALSalesReturnHeaderPrimaryKey pk)
		{
			return POS.DataLayer.SALSalesReturnHeaderBase.Delete(new POS.DataLayer.SALSalesReturnHeaderPrimaryKey(pk.SlaesReturnHeaderID));
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="SALSalesReturnHeaderPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class SALSalesReturnHeader</returns>
		public SALSalesReturnHeader SelectOne(SALSalesReturnHeaderPrimaryKey pk)
		{
			_sALSalesReturnHeaderWCF = new SALSalesReturnHeader();
			_sALSalesReturnHeader = POS.DataLayer.SALSalesReturnHeaderBase.SelectOne(new POS.DataLayer.SALSalesReturnHeaderPrimaryKey(pk.SlaesReturnHeaderID));
			
				_sALSalesReturnHeaderWCF.SlaesReturnHeaderID = _sALSalesReturnHeader.SlaesReturnHeaderID;
				_sALSalesReturnHeaderWCF.ReturnDate = _sALSalesReturnHeader.ReturnDate;
				_sALSalesReturnHeaderWCF.OriginalSalesHeadeID = _sALSalesReturnHeader.OriginalSalesHeadeID;
				_sALSalesReturnHeaderWCF.CreatedBy = _sALSalesReturnHeader.CreatedBy;
				_sALSalesReturnHeaderWCF.CreateDate = _sALSalesReturnHeader.CreateDate;
				_sALSalesReturnHeaderWCF.UpdatedBy = _sALSalesReturnHeader.UpdatedBy;
				_sALSalesReturnHeaderWCF.UpdateDate = _sALSalesReturnHeader.UpdateDate;
				_sALSalesReturnHeaderWCF.IsDeleted = _sALSalesReturnHeader.IsDeleted;
				_sALSalesReturnHeaderWCF.DeletedBy = _sALSalesReturnHeader.DeletedBy;
				_sALSalesReturnHeaderWCF.DeleteDate = _sALSalesReturnHeader.DeleteDate;
				
			return _sALSalesReturnHeaderWCF;
		}

		/// <summary>
		/// This method will return a list of objects representing all records in the table.
		/// </summary>
		///
		/// <returns>list of objects of class SALSalesReturnHeader in the form of object of SALSalesReturnHeaderCollection </returns>
		public SALSalesReturnHeaderCollection SelectAll()
		{
			SALSalesReturnHeaderCollection sALSalesReturnHeaderCollection = new SALSalesReturnHeaderCollection();
			foreach (POS.DataLayer.SALSalesReturnHeader _sALSalesReturnHeader in POS.DataLayer.SALSalesReturnHeaderBase.SelectAll())
			{
				_sALSalesReturnHeaderWCF = new SALSalesReturnHeader();
				
				_sALSalesReturnHeaderWCF.SlaesReturnHeaderID = _sALSalesReturnHeader.SlaesReturnHeaderID;
				_sALSalesReturnHeaderWCF.ReturnDate = _sALSalesReturnHeader.ReturnDate;
				_sALSalesReturnHeaderWCF.OriginalSalesHeadeID = _sALSalesReturnHeader.OriginalSalesHeadeID;
				_sALSalesReturnHeaderWCF.CreatedBy = _sALSalesReturnHeader.CreatedBy;
				_sALSalesReturnHeaderWCF.CreateDate = _sALSalesReturnHeader.CreateDate;
				_sALSalesReturnHeaderWCF.UpdatedBy = _sALSalesReturnHeader.UpdatedBy;
				_sALSalesReturnHeaderWCF.UpdateDate = _sALSalesReturnHeader.UpdateDate;
				_sALSalesReturnHeaderWCF.IsDeleted = _sALSalesReturnHeader.IsDeleted;
				_sALSalesReturnHeaderWCF.DeletedBy = _sALSalesReturnHeader.DeletedBy;
				_sALSalesReturnHeaderWCF.DeleteDate = _sALSalesReturnHeader.DeleteDate;
				
				sALSalesReturnHeaderCollection.Add(_sALSalesReturnHeaderWCF);
			}
			return sALSalesReturnHeaderCollection;
		}
    
    /// <summary>
		/// This method will return a count all records in the table.
		/// </summary>
		///
		/// <returns>count records</returns>
		public int SelectAllCount()
		{
			return POS.DataLayer.SALSalesReturnHeaderBase.SelectAllCount();			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class SALSalesReturnHeader</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class SALSalesReturnHeader in the form of an object of class SALSalesReturnHeaderCollection</returns>
		public SALSalesReturnHeaderCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
		{
			SALSalesReturnHeaderCollection sALSalesReturnHeaderCollection = new SALSalesReturnHeaderCollection();
			foreach (POS.DataLayer.SALSalesReturnHeader _sALSalesReturnHeader in POS.DataLayer.SALSalesReturnHeaderBase.SelectByField(field, fieldValue, fieldValue2, typeOperation))
			{
				_sALSalesReturnHeaderWCF = new SALSalesReturnHeader();
				
				_sALSalesReturnHeaderWCF.SlaesReturnHeaderID = _sALSalesReturnHeader.SlaesReturnHeaderID;
				_sALSalesReturnHeaderWCF.ReturnDate = _sALSalesReturnHeader.ReturnDate;
				_sALSalesReturnHeaderWCF.OriginalSalesHeadeID = _sALSalesReturnHeader.OriginalSalesHeadeID;
				_sALSalesReturnHeaderWCF.CreatedBy = _sALSalesReturnHeader.CreatedBy;
				_sALSalesReturnHeaderWCF.CreateDate = _sALSalesReturnHeader.CreateDate;
				_sALSalesReturnHeaderWCF.UpdatedBy = _sALSalesReturnHeader.UpdatedBy;
				_sALSalesReturnHeaderWCF.UpdateDate = _sALSalesReturnHeader.UpdateDate;
				_sALSalesReturnHeaderWCF.IsDeleted = _sALSalesReturnHeader.IsDeleted;
				_sALSalesReturnHeaderWCF.DeletedBy = _sALSalesReturnHeader.DeletedBy;
				_sALSalesReturnHeaderWCF.DeleteDate = _sALSalesReturnHeader.DeleteDate;
				
				sALSalesReturnHeaderCollection.Add(_sALSalesReturnHeaderWCF);
			}
			return sALSalesReturnHeaderCollection;
		}
		
		/// <summary>
		/// This method will insert one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="sALSalesReturnHeader" type="SALSalesReturnHeader">This SALSalesReturnHeader  will be inserted in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Insert(SALSalesReturnHeader sALSalesReturnHeader)
		{
			_sALSalesReturnHeader = new POS.DataLayer.SALSalesReturnHeader();
			_sALSalesReturnHeader.SlaesReturnHeaderID=sALSalesReturnHeader.SlaesReturnHeaderID;
			_sALSalesReturnHeader.ReturnDate=sALSalesReturnHeader.ReturnDate;
			_sALSalesReturnHeader.OriginalSalesHeadeID=sALSalesReturnHeader.OriginalSalesHeadeID;
			_sALSalesReturnHeader.CreatedBy=sALSalesReturnHeader.CreatedBy;
			_sALSalesReturnHeader.CreateDate=sALSalesReturnHeader.CreateDate;
			_sALSalesReturnHeader.UpdatedBy=sALSalesReturnHeader.UpdatedBy;
			_sALSalesReturnHeader.UpdateDate=sALSalesReturnHeader.UpdateDate;
			_sALSalesReturnHeader.IsDeleted=sALSalesReturnHeader.IsDeleted;
			_sALSalesReturnHeader.DeletedBy=sALSalesReturnHeader.DeletedBy;
			_sALSalesReturnHeader.DeleteDate=sALSalesReturnHeader.DeleteDate;
			
			return _sALSalesReturnHeader.Insert();
		}
		
		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>list of objects of class SALSalesReturnHeader in the form of an object of class SALSalesReturnHeaderCollection </returns>
		public SALSalesReturnHeaderCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			SALSalesReturnHeaderCollection sALSalesReturnHeaderCollection = new SALSalesReturnHeaderCollection();
			foreach (POS.DataLayer.SALSalesReturnHeader _sALSalesReturnHeader in POS.DataLayer.SALSalesReturnHeaderBase.SelectAllPaged(pageSize, skipPages, orderByStatement))
			{
				_sALSalesReturnHeaderWCF = new SALSalesReturnHeader();
				
				_sALSalesReturnHeaderWCF.SlaesReturnHeaderID = _sALSalesReturnHeader.SlaesReturnHeaderID;
				_sALSalesReturnHeaderWCF.ReturnDate = _sALSalesReturnHeader.ReturnDate;
				_sALSalesReturnHeaderWCF.OriginalSalesHeadeID = _sALSalesReturnHeader.OriginalSalesHeadeID;
				_sALSalesReturnHeaderWCF.CreatedBy = _sALSalesReturnHeader.CreatedBy;
				_sALSalesReturnHeaderWCF.CreateDate = _sALSalesReturnHeader.CreateDate;
				_sALSalesReturnHeaderWCF.UpdatedBy = _sALSalesReturnHeader.UpdatedBy;
				_sALSalesReturnHeaderWCF.UpdateDate = _sALSalesReturnHeader.UpdateDate;
				_sALSalesReturnHeaderWCF.IsDeleted = _sALSalesReturnHeader.IsDeleted;
				_sALSalesReturnHeaderWCF.DeletedBy = _sALSalesReturnHeader.DeletedBy;
				_sALSalesReturnHeaderWCF.DeleteDate = _sALSalesReturnHeader.DeleteDate;
				
				sALSalesReturnHeaderCollection.Add(_sALSalesReturnHeaderWCF);
			}
			return sALSalesReturnHeaderCollection;
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class SALSalesReturnHeader</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class SALSalesReturnHeader in the form of an object of class SALSalesReturnHeaderCollection</returns>
		public SALSalesReturnHeaderCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
		{
			SALSalesReturnHeaderCollection sALSalesReturnHeaderCollection = new SALSalesReturnHeaderCollection();
			foreach (POS.DataLayer.SALSalesReturnHeader _sALSalesReturnHeader in POS.DataLayer.SALSalesReturnHeaderBase.SelectByFieldPaged(field, fieldValue, fieldValue2, typeOperation, pageSize, skipPages, orderByStatement))
			{
				_sALSalesReturnHeaderWCF = new SALSalesReturnHeader();
				
				_sALSalesReturnHeaderWCF.SlaesReturnHeaderID = _sALSalesReturnHeader.SlaesReturnHeaderID;
				_sALSalesReturnHeaderWCF.ReturnDate = _sALSalesReturnHeader.ReturnDate;
				_sALSalesReturnHeaderWCF.OriginalSalesHeadeID = _sALSalesReturnHeader.OriginalSalesHeadeID;
				_sALSalesReturnHeaderWCF.CreatedBy = _sALSalesReturnHeader.CreatedBy;
				_sALSalesReturnHeaderWCF.CreateDate = _sALSalesReturnHeader.CreateDate;
				_sALSalesReturnHeaderWCF.UpdatedBy = _sALSalesReturnHeader.UpdatedBy;
				_sALSalesReturnHeaderWCF.UpdateDate = _sALSalesReturnHeader.UpdateDate;
				_sALSalesReturnHeaderWCF.IsDeleted = _sALSalesReturnHeader.IsDeleted;
				_sALSalesReturnHeaderWCF.DeletedBy = _sALSalesReturnHeader.DeletedBy;
				_sALSalesReturnHeaderWCF.DeleteDate = _sALSalesReturnHeader.DeleteDate;
				
				sALSalesReturnHeaderCollection.Add(_sALSalesReturnHeaderWCF);
			}
			return sALSalesReturnHeaderCollection;
		}
			///<summary>
		/// This method will update one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="sALSalesReturnHeader" type="SALSalesReturnHeader">This SALSalesReturnHeader  will be updated in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Update(SALSalesReturnHeader sALSalesReturnHeader)
		{
			_sALSalesReturnHeader=POS.DataLayer.SALSalesReturnHeader.SelectOne(new POS.DataLayer.SALSalesReturnHeaderPrimaryKey(sALSalesReturnHeader.SlaesReturnHeaderID));
			
			_sALSalesReturnHeader.ReturnDate=sALSalesReturnHeader.ReturnDate;
			_sALSalesReturnHeader.OriginalSalesHeadeID=sALSalesReturnHeader.OriginalSalesHeadeID;
			_sALSalesReturnHeader.CreatedBy=sALSalesReturnHeader.CreatedBy;
			_sALSalesReturnHeader.CreateDate=sALSalesReturnHeader.CreateDate;
			_sALSalesReturnHeader.UpdatedBy=sALSalesReturnHeader.UpdatedBy;
			_sALSalesReturnHeader.UpdateDate=sALSalesReturnHeader.UpdateDate;
			_sALSalesReturnHeader.IsDeleted=sALSalesReturnHeader.IsDeleted;
			_sALSalesReturnHeader.DeletedBy=sALSalesReturnHeader.DeletedBy;
			_sALSalesReturnHeader.DeleteDate=sALSalesReturnHeader.DeleteDate;
			
			return _sALSalesReturnHeader.Update();
		}
	} 
}
