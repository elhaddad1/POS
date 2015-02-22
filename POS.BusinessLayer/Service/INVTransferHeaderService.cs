//
// Class	:	INVTransferHeaderServices.svc.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	2/22/2015 7:27:20 PM
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using POS.DataLayer;

namespace POS.BusinessLayer
{
	///<summary>
	///WCF service for the INVTransferHeader
	///</summary>
	public class INVTransferHeaderService 
	{
		private INVTransferHeader _iNVTransferHeaderWCF;
		private POS.DataLayer.INVTransferHeader _iNVTransferHeader;
		
		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="INVTransferHeaderFields">Field of the class INVTransferHeader</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <returns>True if succeeded</returns>
		public bool DeleteByField(string field, object fieldValue)
		{
			return POS.DataLayer.INVTransferHeaderBase.DeleteByField(field, fieldValue);
		}

		///<summary>
		///This method will Delete the object from the database
		///</summary>
		///<param name="pk" type="INVTransferHeaderPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <returns>True if succeeded</returns>
		public bool Delete(INVTransferHeaderPrimaryKey pk)
		{
			return POS.DataLayer.INVTransferHeaderBase.Delete(new POS.DataLayer.INVTransferHeaderPrimaryKey(pk.INVTransferHeaderID));
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="INVTransferHeaderPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class INVTransferHeader</returns>
		public INVTransferHeader SelectOne(INVTransferHeaderPrimaryKey pk)
		{
			_iNVTransferHeaderWCF = new INVTransferHeader();
			_iNVTransferHeader = POS.DataLayer.INVTransferHeaderBase.SelectOne(new POS.DataLayer.INVTransferHeaderPrimaryKey(pk.INVTransferHeaderID));
			
				_iNVTransferHeaderWCF.INVTransferHeaderID = _iNVTransferHeader.INVTransferHeaderID;
				_iNVTransferHeaderWCF.TransferDate = _iNVTransferHeader.TransferDate;
				_iNVTransferHeaderWCF.FromInventoryID = _iNVTransferHeader.FromInventoryID;
				_iNVTransferHeaderWCF.ToInventoryID = _iNVTransferHeader.ToInventoryID;
				_iNVTransferHeaderWCF.InvoiceNumber = _iNVTransferHeader.InvoiceNumber;
				_iNVTransferHeaderWCF.InvoiceDate = _iNVTransferHeader.InvoiceDate;
				_iNVTransferHeaderWCF.IsVoid = _iNVTransferHeader.IsVoid;
				_iNVTransferHeaderWCF.IsPrinted = _iNVTransferHeader.IsPrinted;
				_iNVTransferHeaderWCF.IsClosed = _iNVTransferHeader.IsClosed;
				_iNVTransferHeaderWCF.CreatedBy = _iNVTransferHeader.CreatedBy;
				_iNVTransferHeaderWCF.CreateDate = _iNVTransferHeader.CreateDate;
				_iNVTransferHeaderWCF.UpdatedBy = _iNVTransferHeader.UpdatedBy;
				_iNVTransferHeaderWCF.UpdateDate = _iNVTransferHeader.UpdateDate;
				_iNVTransferHeaderWCF.IsDeleted = _iNVTransferHeader.IsDeleted;
				_iNVTransferHeaderWCF.DeletedBy = _iNVTransferHeader.DeletedBy;
				_iNVTransferHeaderWCF.DeletedDate = _iNVTransferHeader.DeletedDate;
				
			return _iNVTransferHeaderWCF;
		}

		/// <summary>
		/// This method will return a list of objects representing all records in the table.
		/// </summary>
		///
		/// <returns>list of objects of class INVTransferHeader in the form of object of INVTransferHeaderCollection </returns>
		public INVTransferHeaderCollection SelectAll()
		{
			INVTransferHeaderCollection iNVTransferHeaderCollection = new INVTransferHeaderCollection();
			foreach (POS.DataLayer.INVTransferHeader _iNVTransferHeader in POS.DataLayer.INVTransferHeaderBase.SelectAll())
			{
				_iNVTransferHeaderWCF = new INVTransferHeader();
				
				_iNVTransferHeaderWCF.INVTransferHeaderID = _iNVTransferHeader.INVTransferHeaderID;
				_iNVTransferHeaderWCF.TransferDate = _iNVTransferHeader.TransferDate;
				_iNVTransferHeaderWCF.FromInventoryID = _iNVTransferHeader.FromInventoryID;
				_iNVTransferHeaderWCF.ToInventoryID = _iNVTransferHeader.ToInventoryID;
				_iNVTransferHeaderWCF.InvoiceNumber = _iNVTransferHeader.InvoiceNumber;
				_iNVTransferHeaderWCF.InvoiceDate = _iNVTransferHeader.InvoiceDate;
				_iNVTransferHeaderWCF.IsVoid = _iNVTransferHeader.IsVoid;
				_iNVTransferHeaderWCF.IsPrinted = _iNVTransferHeader.IsPrinted;
				_iNVTransferHeaderWCF.IsClosed = _iNVTransferHeader.IsClosed;
				_iNVTransferHeaderWCF.CreatedBy = _iNVTransferHeader.CreatedBy;
				_iNVTransferHeaderWCF.CreateDate = _iNVTransferHeader.CreateDate;
				_iNVTransferHeaderWCF.UpdatedBy = _iNVTransferHeader.UpdatedBy;
				_iNVTransferHeaderWCF.UpdateDate = _iNVTransferHeader.UpdateDate;
				_iNVTransferHeaderWCF.IsDeleted = _iNVTransferHeader.IsDeleted;
				_iNVTransferHeaderWCF.DeletedBy = _iNVTransferHeader.DeletedBy;
				_iNVTransferHeaderWCF.DeletedDate = _iNVTransferHeader.DeletedDate;
				
				iNVTransferHeaderCollection.Add(_iNVTransferHeaderWCF);
			}
			return iNVTransferHeaderCollection;
		}
    
    /// <summary>
		/// This method will return a count all records in the table.
		/// </summary>
		///
		/// <returns>count records</returns>
		public int SelectAllCount()
		{
			return POS.DataLayer.INVTransferHeaderBase.SelectAllCount();			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class INVTransferHeader</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class INVTransferHeader in the form of an object of class INVTransferHeaderCollection</returns>
		public INVTransferHeaderCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
		{
			INVTransferHeaderCollection iNVTransferHeaderCollection = new INVTransferHeaderCollection();
			foreach (POS.DataLayer.INVTransferHeader _iNVTransferHeader in POS.DataLayer.INVTransferHeaderBase.SelectByField(field, fieldValue, fieldValue2, typeOperation))
			{
				_iNVTransferHeaderWCF = new INVTransferHeader();
				
				_iNVTransferHeaderWCF.INVTransferHeaderID = _iNVTransferHeader.INVTransferHeaderID;
				_iNVTransferHeaderWCF.TransferDate = _iNVTransferHeader.TransferDate;
				_iNVTransferHeaderWCF.FromInventoryID = _iNVTransferHeader.FromInventoryID;
				_iNVTransferHeaderWCF.ToInventoryID = _iNVTransferHeader.ToInventoryID;
				_iNVTransferHeaderWCF.InvoiceNumber = _iNVTransferHeader.InvoiceNumber;
				_iNVTransferHeaderWCF.InvoiceDate = _iNVTransferHeader.InvoiceDate;
				_iNVTransferHeaderWCF.IsVoid = _iNVTransferHeader.IsVoid;
				_iNVTransferHeaderWCF.IsPrinted = _iNVTransferHeader.IsPrinted;
				_iNVTransferHeaderWCF.IsClosed = _iNVTransferHeader.IsClosed;
				_iNVTransferHeaderWCF.CreatedBy = _iNVTransferHeader.CreatedBy;
				_iNVTransferHeaderWCF.CreateDate = _iNVTransferHeader.CreateDate;
				_iNVTransferHeaderWCF.UpdatedBy = _iNVTransferHeader.UpdatedBy;
				_iNVTransferHeaderWCF.UpdateDate = _iNVTransferHeader.UpdateDate;
				_iNVTransferHeaderWCF.IsDeleted = _iNVTransferHeader.IsDeleted;
				_iNVTransferHeaderWCF.DeletedBy = _iNVTransferHeader.DeletedBy;
				_iNVTransferHeaderWCF.DeletedDate = _iNVTransferHeader.DeletedDate;
				
				iNVTransferHeaderCollection.Add(_iNVTransferHeaderWCF);
			}
			return iNVTransferHeaderCollection;
		}
		
		/// <summary>
		/// This method will insert one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="iNVTransferHeader" type="INVTransferHeader">This INVTransferHeader  will be inserted in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Insert(INVTransferHeader iNVTransferHeader)
		{
			_iNVTransferHeader = new POS.DataLayer.INVTransferHeader();
			_iNVTransferHeader.INVTransferHeaderID=iNVTransferHeader.INVTransferHeaderID;
			_iNVTransferHeader.TransferDate=iNVTransferHeader.TransferDate;
			_iNVTransferHeader.FromInventoryID=iNVTransferHeader.FromInventoryID;
			_iNVTransferHeader.ToInventoryID=iNVTransferHeader.ToInventoryID;
			_iNVTransferHeader.InvoiceNumber=iNVTransferHeader.InvoiceNumber;
			_iNVTransferHeader.InvoiceDate=iNVTransferHeader.InvoiceDate;
			_iNVTransferHeader.IsVoid=iNVTransferHeader.IsVoid;
			_iNVTransferHeader.IsPrinted=iNVTransferHeader.IsPrinted;
			_iNVTransferHeader.IsClosed=iNVTransferHeader.IsClosed;
			_iNVTransferHeader.CreatedBy=iNVTransferHeader.CreatedBy;
			_iNVTransferHeader.CreateDate=iNVTransferHeader.CreateDate;
			_iNVTransferHeader.UpdatedBy=iNVTransferHeader.UpdatedBy;
			_iNVTransferHeader.UpdateDate=iNVTransferHeader.UpdateDate;
			_iNVTransferHeader.IsDeleted=iNVTransferHeader.IsDeleted;
			_iNVTransferHeader.DeletedBy=iNVTransferHeader.DeletedBy;
			_iNVTransferHeader.DeletedDate=iNVTransferHeader.DeletedDate;
			
			return _iNVTransferHeader.Insert();
		}
		
		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>list of objects of class INVTransferHeader in the form of an object of class INVTransferHeaderCollection </returns>
		public INVTransferHeaderCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			INVTransferHeaderCollection iNVTransferHeaderCollection = new INVTransferHeaderCollection();
			foreach (POS.DataLayer.INVTransferHeader _iNVTransferHeader in POS.DataLayer.INVTransferHeaderBase.SelectAllPaged(pageSize, skipPages, orderByStatement))
			{
				_iNVTransferHeaderWCF = new INVTransferHeader();
				
				_iNVTransferHeaderWCF.INVTransferHeaderID = _iNVTransferHeader.INVTransferHeaderID;
				_iNVTransferHeaderWCF.TransferDate = _iNVTransferHeader.TransferDate;
				_iNVTransferHeaderWCF.FromInventoryID = _iNVTransferHeader.FromInventoryID;
				_iNVTransferHeaderWCF.ToInventoryID = _iNVTransferHeader.ToInventoryID;
				_iNVTransferHeaderWCF.InvoiceNumber = _iNVTransferHeader.InvoiceNumber;
				_iNVTransferHeaderWCF.InvoiceDate = _iNVTransferHeader.InvoiceDate;
				_iNVTransferHeaderWCF.IsVoid = _iNVTransferHeader.IsVoid;
				_iNVTransferHeaderWCF.IsPrinted = _iNVTransferHeader.IsPrinted;
				_iNVTransferHeaderWCF.IsClosed = _iNVTransferHeader.IsClosed;
				_iNVTransferHeaderWCF.CreatedBy = _iNVTransferHeader.CreatedBy;
				_iNVTransferHeaderWCF.CreateDate = _iNVTransferHeader.CreateDate;
				_iNVTransferHeaderWCF.UpdatedBy = _iNVTransferHeader.UpdatedBy;
				_iNVTransferHeaderWCF.UpdateDate = _iNVTransferHeader.UpdateDate;
				_iNVTransferHeaderWCF.IsDeleted = _iNVTransferHeader.IsDeleted;
				_iNVTransferHeaderWCF.DeletedBy = _iNVTransferHeader.DeletedBy;
				_iNVTransferHeaderWCF.DeletedDate = _iNVTransferHeader.DeletedDate;
				
				iNVTransferHeaderCollection.Add(_iNVTransferHeaderWCF);
			}
			return iNVTransferHeaderCollection;
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class INVTransferHeader</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class INVTransferHeader in the form of an object of class INVTransferHeaderCollection</returns>
		public INVTransferHeaderCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
		{
			INVTransferHeaderCollection iNVTransferHeaderCollection = new INVTransferHeaderCollection();
			foreach (POS.DataLayer.INVTransferHeader _iNVTransferHeader in POS.DataLayer.INVTransferHeaderBase.SelectByFieldPaged(field, fieldValue, fieldValue2, typeOperation, pageSize, skipPages, orderByStatement))
			{
				_iNVTransferHeaderWCF = new INVTransferHeader();
				
				_iNVTransferHeaderWCF.INVTransferHeaderID = _iNVTransferHeader.INVTransferHeaderID;
				_iNVTransferHeaderWCF.TransferDate = _iNVTransferHeader.TransferDate;
				_iNVTransferHeaderWCF.FromInventoryID = _iNVTransferHeader.FromInventoryID;
				_iNVTransferHeaderWCF.ToInventoryID = _iNVTransferHeader.ToInventoryID;
				_iNVTransferHeaderWCF.InvoiceNumber = _iNVTransferHeader.InvoiceNumber;
				_iNVTransferHeaderWCF.InvoiceDate = _iNVTransferHeader.InvoiceDate;
				_iNVTransferHeaderWCF.IsVoid = _iNVTransferHeader.IsVoid;
				_iNVTransferHeaderWCF.IsPrinted = _iNVTransferHeader.IsPrinted;
				_iNVTransferHeaderWCF.IsClosed = _iNVTransferHeader.IsClosed;
				_iNVTransferHeaderWCF.CreatedBy = _iNVTransferHeader.CreatedBy;
				_iNVTransferHeaderWCF.CreateDate = _iNVTransferHeader.CreateDate;
				_iNVTransferHeaderWCF.UpdatedBy = _iNVTransferHeader.UpdatedBy;
				_iNVTransferHeaderWCF.UpdateDate = _iNVTransferHeader.UpdateDate;
				_iNVTransferHeaderWCF.IsDeleted = _iNVTransferHeader.IsDeleted;
				_iNVTransferHeaderWCF.DeletedBy = _iNVTransferHeader.DeletedBy;
				_iNVTransferHeaderWCF.DeletedDate = _iNVTransferHeader.DeletedDate;
				
				iNVTransferHeaderCollection.Add(_iNVTransferHeaderWCF);
			}
			return iNVTransferHeaderCollection;
		}
			///<summary>
		/// This method will update one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="iNVTransferHeader" type="INVTransferHeader">This INVTransferHeader  will be updated in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Update(INVTransferHeader iNVTransferHeader)
		{
			_iNVTransferHeader=POS.DataLayer.INVTransferHeader.SelectOne(new POS.DataLayer.INVTransferHeaderPrimaryKey(iNVTransferHeader.INVTransferHeaderID));
			
			_iNVTransferHeader.TransferDate=iNVTransferHeader.TransferDate;
			_iNVTransferHeader.FromInventoryID=iNVTransferHeader.FromInventoryID;
			_iNVTransferHeader.ToInventoryID=iNVTransferHeader.ToInventoryID;
			_iNVTransferHeader.InvoiceNumber=iNVTransferHeader.InvoiceNumber;
			_iNVTransferHeader.InvoiceDate=iNVTransferHeader.InvoiceDate;
			_iNVTransferHeader.IsVoid=iNVTransferHeader.IsVoid;
			_iNVTransferHeader.IsPrinted=iNVTransferHeader.IsPrinted;
			_iNVTransferHeader.IsClosed=iNVTransferHeader.IsClosed;
			_iNVTransferHeader.CreatedBy=iNVTransferHeader.CreatedBy;
			_iNVTransferHeader.CreateDate=iNVTransferHeader.CreateDate;
			_iNVTransferHeader.UpdatedBy=iNVTransferHeader.UpdatedBy;
			_iNVTransferHeader.UpdateDate=iNVTransferHeader.UpdateDate;
			_iNVTransferHeader.IsDeleted=iNVTransferHeader.IsDeleted;
			_iNVTransferHeader.DeletedBy=iNVTransferHeader.DeletedBy;
			_iNVTransferHeader.DeletedDate=iNVTransferHeader.DeletedDate;
			
			return _iNVTransferHeader.Update();
		}
	} 
}
