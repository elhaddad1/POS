//
// Class	:	PURPurchaseReturnHeaderServices.svc.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:56:12 PM
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using POS.DataLayer;

namespace POS.BusinessLayer
{
	///<summary>
	///WCF service for the PURPurchaseReturnHeader
	///</summary>
	public class PURPurchaseReturnHeaderService : IPURPurchaseReturnHeaderService
	{
		private PURPurchaseReturnHeader _pURPurchaseReturnHeaderWCF;
		private POS.DataLayer.PURPurchaseReturnHeader _pURPurchaseReturnHeader;
		
		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="PURPurchaseReturnHeaderFields">Field of the class PURPurchaseReturnHeader</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <returns>True if succeeded</returns>
		public bool DeleteByField(string field, object fieldValue)
		{
			return POS.DataLayer.PURPurchaseReturnHeaderBase.DeleteByField(field, fieldValue);
		}

		///<summary>
		///This method will Delete the object from the database
		///</summary>
		///<param name="pk" type="PURPurchaseReturnHeaderPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <returns>True if succeeded</returns>
		public bool Delete(PURPurchaseReturnHeaderPrimaryKey pk)
		{
			return POS.DataLayer.PURPurchaseReturnHeaderBase.Delete(new POS.DataLayer.PURPurchaseReturnHeaderPrimaryKey(pk.PurchaseReturnID));
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="PURPurchaseReturnHeaderPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class PURPurchaseReturnHeader</returns>
		public PURPurchaseReturnHeader SelectOne(PURPurchaseReturnHeaderPrimaryKey pk)
		{
			_pURPurchaseReturnHeaderWCF = new PURPurchaseReturnHeader();
			_pURPurchaseReturnHeader = POS.DataLayer.PURPurchaseReturnHeaderBase.SelectOne(new POS.DataLayer.PURPurchaseReturnHeaderPrimaryKey(pk.PurchaseReturnID));
			
				_pURPurchaseReturnHeaderWCF.PurchaseReturnID = _pURPurchaseReturnHeader.PurchaseReturnID;
				_pURPurchaseReturnHeaderWCF.ReturnDate = _pURPurchaseReturnHeader.ReturnDate;
				_pURPurchaseReturnHeaderWCF.OriginalHeaderID = _pURPurchaseReturnHeader.OriginalHeaderID;
				_pURPurchaseReturnHeaderWCF.CreatedBy = _pURPurchaseReturnHeader.CreatedBy;
				_pURPurchaseReturnHeaderWCF.CreateDate = _pURPurchaseReturnHeader.CreateDate;
				_pURPurchaseReturnHeaderWCF.UpdatedBy = _pURPurchaseReturnHeader.UpdatedBy;
				_pURPurchaseReturnHeaderWCF.UpdateDate = _pURPurchaseReturnHeader.UpdateDate;
				_pURPurchaseReturnHeaderWCF.IsDeleted = _pURPurchaseReturnHeader.IsDeleted;
				_pURPurchaseReturnHeaderWCF.DeletedBy = _pURPurchaseReturnHeader.DeletedBy;
				_pURPurchaseReturnHeaderWCF.DeleteDate = _pURPurchaseReturnHeader.DeleteDate;
				
			return _pURPurchaseReturnHeaderWCF;
		}

		/// <summary>
		/// This method will return a list of objects representing all records in the table.
		/// </summary>
		///
		/// <returns>list of objects of class PURPurchaseReturnHeader in the form of object of PURPurchaseReturnHeaderCollection </returns>
		public PURPurchaseReturnHeaderCollection SelectAll()
		{
			PURPurchaseReturnHeaderCollection pURPurchaseReturnHeaderCollection = new PURPurchaseReturnHeaderCollection();
			foreach (POS.DataLayer.PURPurchaseReturnHeader _pURPurchaseReturnHeader in POS.DataLayer.PURPurchaseReturnHeaderBase.SelectAll())
			{
				_pURPurchaseReturnHeaderWCF = new PURPurchaseReturnHeader();
				
				_pURPurchaseReturnHeaderWCF.PurchaseReturnID = _pURPurchaseReturnHeader.PurchaseReturnID;
				_pURPurchaseReturnHeaderWCF.ReturnDate = _pURPurchaseReturnHeader.ReturnDate;
				_pURPurchaseReturnHeaderWCF.OriginalHeaderID = _pURPurchaseReturnHeader.OriginalHeaderID;
				_pURPurchaseReturnHeaderWCF.CreatedBy = _pURPurchaseReturnHeader.CreatedBy;
				_pURPurchaseReturnHeaderWCF.CreateDate = _pURPurchaseReturnHeader.CreateDate;
				_pURPurchaseReturnHeaderWCF.UpdatedBy = _pURPurchaseReturnHeader.UpdatedBy;
				_pURPurchaseReturnHeaderWCF.UpdateDate = _pURPurchaseReturnHeader.UpdateDate;
				_pURPurchaseReturnHeaderWCF.IsDeleted = _pURPurchaseReturnHeader.IsDeleted;
				_pURPurchaseReturnHeaderWCF.DeletedBy = _pURPurchaseReturnHeader.DeletedBy;
				_pURPurchaseReturnHeaderWCF.DeleteDate = _pURPurchaseReturnHeader.DeleteDate;
				
				pURPurchaseReturnHeaderCollection.Add(_pURPurchaseReturnHeaderWCF);
			}
			return pURPurchaseReturnHeaderCollection;
		}
    
    /// <summary>
		/// This method will return a count all records in the table.
		/// </summary>
		///
		/// <returns>count records</returns>
		public int SelectAllCount()
		{
			return POS.DataLayer.PURPurchaseReturnHeaderBase.SelectAllCount();			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class PURPurchaseReturnHeader</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class PURPurchaseReturnHeader in the form of an object of class PURPurchaseReturnHeaderCollection</returns>
		public PURPurchaseReturnHeaderCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
		{
			PURPurchaseReturnHeaderCollection pURPurchaseReturnHeaderCollection = new PURPurchaseReturnHeaderCollection();
			foreach (POS.DataLayer.PURPurchaseReturnHeader _pURPurchaseReturnHeader in POS.DataLayer.PURPurchaseReturnHeaderBase.SelectByField(field, fieldValue, fieldValue2, typeOperation))
			{
				_pURPurchaseReturnHeaderWCF = new PURPurchaseReturnHeader();
				
				_pURPurchaseReturnHeaderWCF.PurchaseReturnID = _pURPurchaseReturnHeader.PurchaseReturnID;
				_pURPurchaseReturnHeaderWCF.ReturnDate = _pURPurchaseReturnHeader.ReturnDate;
				_pURPurchaseReturnHeaderWCF.OriginalHeaderID = _pURPurchaseReturnHeader.OriginalHeaderID;
				_pURPurchaseReturnHeaderWCF.CreatedBy = _pURPurchaseReturnHeader.CreatedBy;
				_pURPurchaseReturnHeaderWCF.CreateDate = _pURPurchaseReturnHeader.CreateDate;
				_pURPurchaseReturnHeaderWCF.UpdatedBy = _pURPurchaseReturnHeader.UpdatedBy;
				_pURPurchaseReturnHeaderWCF.UpdateDate = _pURPurchaseReturnHeader.UpdateDate;
				_pURPurchaseReturnHeaderWCF.IsDeleted = _pURPurchaseReturnHeader.IsDeleted;
				_pURPurchaseReturnHeaderWCF.DeletedBy = _pURPurchaseReturnHeader.DeletedBy;
				_pURPurchaseReturnHeaderWCF.DeleteDate = _pURPurchaseReturnHeader.DeleteDate;
				
				pURPurchaseReturnHeaderCollection.Add(_pURPurchaseReturnHeaderWCF);
			}
			return pURPurchaseReturnHeaderCollection;
		}
		
		/// <summary>
		/// This method will insert one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="pURPurchaseReturnHeader" type="PURPurchaseReturnHeader">This PURPurchaseReturnHeader  will be inserted in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Insert(PURPurchaseReturnHeader pURPurchaseReturnHeader)
		{
			_pURPurchaseReturnHeader = new POS.DataLayer.PURPurchaseReturnHeader();
			_pURPurchaseReturnHeader.PurchaseReturnID=pURPurchaseReturnHeader.PurchaseReturnID;
			_pURPurchaseReturnHeader.ReturnDate=pURPurchaseReturnHeader.ReturnDate;
			_pURPurchaseReturnHeader.OriginalHeaderID=pURPurchaseReturnHeader.OriginalHeaderID;
			_pURPurchaseReturnHeader.CreatedBy=pURPurchaseReturnHeader.CreatedBy;
			_pURPurchaseReturnHeader.CreateDate=pURPurchaseReturnHeader.CreateDate;
			_pURPurchaseReturnHeader.UpdatedBy=pURPurchaseReturnHeader.UpdatedBy;
			_pURPurchaseReturnHeader.UpdateDate=pURPurchaseReturnHeader.UpdateDate;
			_pURPurchaseReturnHeader.IsDeleted=pURPurchaseReturnHeader.IsDeleted;
			_pURPurchaseReturnHeader.DeletedBy=pURPurchaseReturnHeader.DeletedBy;
			_pURPurchaseReturnHeader.DeleteDate=pURPurchaseReturnHeader.DeleteDate;
			
			return _pURPurchaseReturnHeader.Insert();
		}
		/// <summary>
		/// This method will delete row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="PURPurchaseHeaderPrimaryKey">Primary Key information based on which data is to be deleted.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool DeleteAllByForeignKeyOriginalHeaderID(PURPurchaseHeaderPrimaryKey pk)
		{
			return POS.DataLayer.PURPurchaseReturnHeaderBase.DeleteAllByForeignKeyOriginalHeaderID(new POS.DataLayer.PURPurchaseHeaderPrimaryKey(pk.PurcaseHeaderID));
		}
		
		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="PURPurchaseHeaderPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class PURPurchaseReturnHeaderCollection</returns>
		public PURPurchaseReturnHeaderCollection SelectAllByForeignKeyOriginalHeaderID(PURPurchaseHeaderPrimaryKey pk)
		{
			PURPurchaseReturnHeaderCollection pURPurchaseReturnHeaderCollection=new PURPurchaseReturnHeaderCollection();
			foreach (POS.DataLayer.PURPurchaseReturnHeader _pURPurchaseReturnHeader in POS.DataLayer.PURPurchaseReturnHeaderBase.SelectAllByForeignKeyOriginalHeaderID(new POS.DataLayer.PURPurchaseHeaderPrimaryKey(pk.PurcaseHeaderID)))
			{
				_pURPurchaseReturnHeaderWCF = new PURPurchaseReturnHeader();
				_pURPurchaseReturnHeaderWCF.PurchaseReturnID = _pURPurchaseReturnHeader.PurchaseReturnID;
				_pURPurchaseReturnHeaderWCF.ReturnDate = _pURPurchaseReturnHeader.ReturnDate;
				_pURPurchaseReturnHeaderWCF.OriginalHeaderID = _pURPurchaseReturnHeader.OriginalHeaderID;
				_pURPurchaseReturnHeaderWCF.CreatedBy = _pURPurchaseReturnHeader.CreatedBy;
				_pURPurchaseReturnHeaderWCF.CreateDate = _pURPurchaseReturnHeader.CreateDate;
				_pURPurchaseReturnHeaderWCF.UpdatedBy = _pURPurchaseReturnHeader.UpdatedBy;
				_pURPurchaseReturnHeaderWCF.UpdateDate = _pURPurchaseReturnHeader.UpdateDate;
				_pURPurchaseReturnHeaderWCF.IsDeleted = _pURPurchaseReturnHeader.IsDeleted;
				_pURPurchaseReturnHeaderWCF.DeletedBy = _pURPurchaseReturnHeader.DeletedBy;
				_pURPurchaseReturnHeaderWCF.DeleteDate = _pURPurchaseReturnHeader.DeleteDate;
				
				pURPurchaseReturnHeaderCollection.Add(_pURPurchaseReturnHeaderWCF);
			}
			return pURPurchaseReturnHeaderCollection;
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
		/// <returns>object of class PURPurchaseReturnHeaderCollection</returns>
		public PURPurchaseReturnHeaderCollection SelectAllByForeignKeyOriginalHeaderIDPaged(PURPurchaseHeaderPrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			PURPurchaseReturnHeaderCollection pURPurchaseReturnHeaderCollection=new PURPurchaseReturnHeaderCollection();
			foreach (POS.DataLayer.PURPurchaseReturnHeader _pURPurchaseReturnHeader in POS.DataLayer.PURPurchaseReturnHeaderBase.SelectAllByForeignKeyOriginalHeaderIDPaged(new POS.DataLayer.PURPurchaseHeaderPrimaryKey(pk.PurcaseHeaderID), pageSize, skipPages, orderByStatement))
			{
				_pURPurchaseReturnHeaderWCF = new PURPurchaseReturnHeader();
				_pURPurchaseReturnHeaderWCF.PurchaseReturnID = _pURPurchaseReturnHeader.PurchaseReturnID;
				_pURPurchaseReturnHeaderWCF.ReturnDate = _pURPurchaseReturnHeader.ReturnDate;
				_pURPurchaseReturnHeaderWCF.OriginalHeaderID = _pURPurchaseReturnHeader.OriginalHeaderID;
				_pURPurchaseReturnHeaderWCF.CreatedBy = _pURPurchaseReturnHeader.CreatedBy;
				_pURPurchaseReturnHeaderWCF.CreateDate = _pURPurchaseReturnHeader.CreateDate;
				_pURPurchaseReturnHeaderWCF.UpdatedBy = _pURPurchaseReturnHeader.UpdatedBy;
				_pURPurchaseReturnHeaderWCF.UpdateDate = _pURPurchaseReturnHeader.UpdateDate;
				_pURPurchaseReturnHeaderWCF.IsDeleted = _pURPurchaseReturnHeader.IsDeleted;
				_pURPurchaseReturnHeaderWCF.DeletedBy = _pURPurchaseReturnHeader.DeletedBy;
				_pURPurchaseReturnHeaderWCF.DeleteDate = _pURPurchaseReturnHeader.DeleteDate;
				
				pURPurchaseReturnHeaderCollection.Add(_pURPurchaseReturnHeaderWCF);
			}
			return pURPurchaseReturnHeaderCollection;
		}
			
		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>list of objects of class PURPurchaseReturnHeader in the form of an object of class PURPurchaseReturnHeaderCollection </returns>
		public PURPurchaseReturnHeaderCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			PURPurchaseReturnHeaderCollection pURPurchaseReturnHeaderCollection = new PURPurchaseReturnHeaderCollection();
			foreach (POS.DataLayer.PURPurchaseReturnHeader _pURPurchaseReturnHeader in POS.DataLayer.PURPurchaseReturnHeaderBase.SelectAllPaged(pageSize, skipPages, orderByStatement))
			{
				_pURPurchaseReturnHeaderWCF = new PURPurchaseReturnHeader();
				
				_pURPurchaseReturnHeaderWCF.PurchaseReturnID = _pURPurchaseReturnHeader.PurchaseReturnID;
				_pURPurchaseReturnHeaderWCF.ReturnDate = _pURPurchaseReturnHeader.ReturnDate;
				_pURPurchaseReturnHeaderWCF.OriginalHeaderID = _pURPurchaseReturnHeader.OriginalHeaderID;
				_pURPurchaseReturnHeaderWCF.CreatedBy = _pURPurchaseReturnHeader.CreatedBy;
				_pURPurchaseReturnHeaderWCF.CreateDate = _pURPurchaseReturnHeader.CreateDate;
				_pURPurchaseReturnHeaderWCF.UpdatedBy = _pURPurchaseReturnHeader.UpdatedBy;
				_pURPurchaseReturnHeaderWCF.UpdateDate = _pURPurchaseReturnHeader.UpdateDate;
				_pURPurchaseReturnHeaderWCF.IsDeleted = _pURPurchaseReturnHeader.IsDeleted;
				_pURPurchaseReturnHeaderWCF.DeletedBy = _pURPurchaseReturnHeader.DeletedBy;
				_pURPurchaseReturnHeaderWCF.DeleteDate = _pURPurchaseReturnHeader.DeleteDate;
				
				pURPurchaseReturnHeaderCollection.Add(_pURPurchaseReturnHeaderWCF);
			}
			return pURPurchaseReturnHeaderCollection;
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class PURPurchaseReturnHeader</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class PURPurchaseReturnHeader in the form of an object of class PURPurchaseReturnHeaderCollection</returns>
		public PURPurchaseReturnHeaderCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
		{
			PURPurchaseReturnHeaderCollection pURPurchaseReturnHeaderCollection = new PURPurchaseReturnHeaderCollection();
			foreach (POS.DataLayer.PURPurchaseReturnHeader _pURPurchaseReturnHeader in POS.DataLayer.PURPurchaseReturnHeaderBase.SelectByFieldPaged(field, fieldValue, fieldValue2, typeOperation, pageSize, skipPages, orderByStatement))
			{
				_pURPurchaseReturnHeaderWCF = new PURPurchaseReturnHeader();
				
				_pURPurchaseReturnHeaderWCF.PurchaseReturnID = _pURPurchaseReturnHeader.PurchaseReturnID;
				_pURPurchaseReturnHeaderWCF.ReturnDate = _pURPurchaseReturnHeader.ReturnDate;
				_pURPurchaseReturnHeaderWCF.OriginalHeaderID = _pURPurchaseReturnHeader.OriginalHeaderID;
				_pURPurchaseReturnHeaderWCF.CreatedBy = _pURPurchaseReturnHeader.CreatedBy;
				_pURPurchaseReturnHeaderWCF.CreateDate = _pURPurchaseReturnHeader.CreateDate;
				_pURPurchaseReturnHeaderWCF.UpdatedBy = _pURPurchaseReturnHeader.UpdatedBy;
				_pURPurchaseReturnHeaderWCF.UpdateDate = _pURPurchaseReturnHeader.UpdateDate;
				_pURPurchaseReturnHeaderWCF.IsDeleted = _pURPurchaseReturnHeader.IsDeleted;
				_pURPurchaseReturnHeaderWCF.DeletedBy = _pURPurchaseReturnHeader.DeletedBy;
				_pURPurchaseReturnHeaderWCF.DeleteDate = _pURPurchaseReturnHeader.DeleteDate;
				
				pURPurchaseReturnHeaderCollection.Add(_pURPurchaseReturnHeaderWCF);
			}
			return pURPurchaseReturnHeaderCollection;
		}
			///<summary>
		/// This method will update one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="pURPurchaseReturnHeader" type="PURPurchaseReturnHeader">This PURPurchaseReturnHeader  will be updated in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Update(PURPurchaseReturnHeader pURPurchaseReturnHeader)
		{
			_pURPurchaseReturnHeader=POS.DataLayer.PURPurchaseReturnHeader.SelectOne(new POS.DataLayer.PURPurchaseReturnHeaderPrimaryKey(pURPurchaseReturnHeader.PurchaseReturnID));
			
			_pURPurchaseReturnHeader.ReturnDate=pURPurchaseReturnHeader.ReturnDate;
			_pURPurchaseReturnHeader.OriginalHeaderID=pURPurchaseReturnHeader.OriginalHeaderID;
			_pURPurchaseReturnHeader.CreatedBy=pURPurchaseReturnHeader.CreatedBy;
			_pURPurchaseReturnHeader.CreateDate=pURPurchaseReturnHeader.CreateDate;
			_pURPurchaseReturnHeader.UpdatedBy=pURPurchaseReturnHeader.UpdatedBy;
			_pURPurchaseReturnHeader.UpdateDate=pURPurchaseReturnHeader.UpdateDate;
			_pURPurchaseReturnHeader.IsDeleted=pURPurchaseReturnHeader.IsDeleted;
			_pURPurchaseReturnHeader.DeletedBy=pURPurchaseReturnHeader.DeletedBy;
			_pURPurchaseReturnHeader.DeleteDate=pURPurchaseReturnHeader.DeleteDate;
			
			return _pURPurchaseReturnHeader.Update();
		}
	} 
}
