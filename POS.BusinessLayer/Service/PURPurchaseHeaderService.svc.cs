//
// Class	:	PURPurchaseHeaderServices.svc.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	3/7/2015 2:37:26 PM
//


using POS.DataLayer;

namespace POS.BusinessLayer
{
	///<summary>
	///WCF service for the PURPurchaseHeader
	///</summary>
	public class PURPurchaseHeaderService 
	{
		private PURPurchaseHeader _pURPurchaseHeaderWCF;
		private POS.DataLayer.PURPurchaseHeader _pURPurchaseHeader;
		
		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="PURPurchaseHeaderFields">Field of the class PURPurchaseHeader</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <returns>True if succeeded</returns>
		public bool DeleteByField(string field, object fieldValue)
		{
			return POS.DataLayer.PURPurchaseHeaderBase.DeleteByField(field, fieldValue);
		}

		///<summary>
		///This method will Delete the object from the database
		///</summary>
		///<param name="pk" type="PURPurchaseHeaderPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <returns>True if succeeded</returns>
		public bool Delete(PURPurchaseHeaderPrimaryKey pk)
		{
			return POS.DataLayer.PURPurchaseHeaderBase.Delete(new POS.DataLayer.PURPurchaseHeaderPrimaryKey(pk.PurcaseHeaderID));
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="PURPurchaseHeaderPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class PURPurchaseHeader</returns>
		public PURPurchaseHeader SelectOne(PURPurchaseHeaderPrimaryKey pk)
		{
			_pURPurchaseHeaderWCF = new PURPurchaseHeader();
			_pURPurchaseHeader = POS.DataLayer.PURPurchaseHeaderBase.SelectOne(new POS.DataLayer.PURPurchaseHeaderPrimaryKey(pk.PurcaseHeaderID));
			
				_pURPurchaseHeaderWCF.PurcaseHeaderID = _pURPurchaseHeader.PurcaseHeaderID;
				_pURPurchaseHeaderWCF.PurchaseDate = _pURPurchaseHeader.PurchaseDate;
				_pURPurchaseHeaderWCF.PaymentTypeID = _pURPurchaseHeader.PaymentTypeID;
				_pURPurchaseHeaderWCF.SupplierID = _pURPurchaseHeader.SupplierID;
				_pURPurchaseHeaderWCF.InvoiceNumber = _pURPurchaseHeader.InvoiceNumber;
				_pURPurchaseHeaderWCF.CreateDate = _pURPurchaseHeader.CreateDate;
				_pURPurchaseHeaderWCF.CreatedBy = _pURPurchaseHeader.CreatedBy;
				_pURPurchaseHeaderWCF.updateDate = _pURPurchaseHeader.updateDate;
				_pURPurchaseHeaderWCF.UpdatedBy = _pURPurchaseHeader.UpdatedBy;
				_pURPurchaseHeaderWCF.IsDeleted = _pURPurchaseHeader.IsDeleted;
				_pURPurchaseHeaderWCF.DeleteDate = _pURPurchaseHeader.DeleteDate;
				_pURPurchaseHeaderWCF.TotalPrice = _pURPurchaseHeader.TotalPrice;
				_pURPurchaseHeaderWCF.ServicePrice = _pURPurchaseHeader.ServicePrice;
				_pURPurchaseHeaderWCF.PaidAmount = _pURPurchaseHeader.PaidAmount;
				_pURPurchaseHeaderWCF.IsClosed = _pURPurchaseHeader.IsClosed;
				_pURPurchaseHeaderWCF.IsVoid = _pURPurchaseHeader.IsVoid;
				_pURPurchaseHeaderWCF.IsPrinted = _pURPurchaseHeader.IsPrinted;
				_pURPurchaseHeaderWCF.RefuseReasonID = _pURPurchaseHeader.RefuseReasonID;
				_pURPurchaseHeaderWCF.TotalDiscountAmount = _pURPurchaseHeader.TotalDiscountAmount;
				_pURPurchaseHeaderWCF.TotalDiscountRatio = _pURPurchaseHeader.TotalDiscountRatio;
				_pURPurchaseHeaderWCF.TaxTypeID = _pURPurchaseHeader.TaxTypeID;
				_pURPurchaseHeaderWCF.RemainingAmount = _pURPurchaseHeader.RemainingAmount;
				_pURPurchaseHeaderWCF.LastDayToPay = _pURPurchaseHeader.LastDayToPay;
				_pURPurchaseHeaderWCF.DeletedBy = _pURPurchaseHeader.DeletedBy;
				_pURPurchaseHeaderWCF.Notes = _pURPurchaseHeader.Notes;
				_pURPurchaseHeaderWCF.InventoryID = _pURPurchaseHeader.InventoryID;
				_pURPurchaseHeaderWCF.InvoiceDate = _pURPurchaseHeader.InvoiceDate;
				
			return _pURPurchaseHeaderWCF;
		}

		/// <summary>
		/// This method will return a list of objects representing all records in the table.
		/// </summary>
		///
		/// <returns>list of objects of class PURPurchaseHeader in the form of object of PURPurchaseHeaderCollection </returns>
		public PURPurchaseHeaderCollection SelectAll()
		{
			PURPurchaseHeaderCollection pURPurchaseHeaderCollection = new PURPurchaseHeaderCollection();
			foreach (POS.DataLayer.PURPurchaseHeader _pURPurchaseHeader in POS.DataLayer.PURPurchaseHeaderBase.SelectAll())
			{
				_pURPurchaseHeaderWCF = new PURPurchaseHeader();
				
				_pURPurchaseHeaderWCF.PurcaseHeaderID = _pURPurchaseHeader.PurcaseHeaderID;
				_pURPurchaseHeaderWCF.PurchaseDate = _pURPurchaseHeader.PurchaseDate;
				_pURPurchaseHeaderWCF.PaymentTypeID = _pURPurchaseHeader.PaymentTypeID;
				_pURPurchaseHeaderWCF.SupplierID = _pURPurchaseHeader.SupplierID;
				_pURPurchaseHeaderWCF.InvoiceNumber = _pURPurchaseHeader.InvoiceNumber;
				_pURPurchaseHeaderWCF.CreateDate = _pURPurchaseHeader.CreateDate;
				_pURPurchaseHeaderWCF.CreatedBy = _pURPurchaseHeader.CreatedBy;
				_pURPurchaseHeaderWCF.updateDate = _pURPurchaseHeader.updateDate;
				_pURPurchaseHeaderWCF.UpdatedBy = _pURPurchaseHeader.UpdatedBy;
				_pURPurchaseHeaderWCF.IsDeleted = _pURPurchaseHeader.IsDeleted;
				_pURPurchaseHeaderWCF.DeleteDate = _pURPurchaseHeader.DeleteDate;
				_pURPurchaseHeaderWCF.TotalPrice = _pURPurchaseHeader.TotalPrice;
				_pURPurchaseHeaderWCF.ServicePrice = _pURPurchaseHeader.ServicePrice;
				_pURPurchaseHeaderWCF.PaidAmount = _pURPurchaseHeader.PaidAmount;
				_pURPurchaseHeaderWCF.IsClosed = _pURPurchaseHeader.IsClosed;
				_pURPurchaseHeaderWCF.IsVoid = _pURPurchaseHeader.IsVoid;
				_pURPurchaseHeaderWCF.IsPrinted = _pURPurchaseHeader.IsPrinted;
				_pURPurchaseHeaderWCF.RefuseReasonID = _pURPurchaseHeader.RefuseReasonID;
				_pURPurchaseHeaderWCF.TotalDiscountAmount = _pURPurchaseHeader.TotalDiscountAmount;
				_pURPurchaseHeaderWCF.TotalDiscountRatio = _pURPurchaseHeader.TotalDiscountRatio;
				_pURPurchaseHeaderWCF.TaxTypeID = _pURPurchaseHeader.TaxTypeID;
				_pURPurchaseHeaderWCF.RemainingAmount = _pURPurchaseHeader.RemainingAmount;
				_pURPurchaseHeaderWCF.LastDayToPay = _pURPurchaseHeader.LastDayToPay;
				_pURPurchaseHeaderWCF.DeletedBy = _pURPurchaseHeader.DeletedBy;
				_pURPurchaseHeaderWCF.Notes = _pURPurchaseHeader.Notes;
				_pURPurchaseHeaderWCF.InventoryID = _pURPurchaseHeader.InventoryID;
				_pURPurchaseHeaderWCF.InvoiceDate = _pURPurchaseHeader.InvoiceDate;
				
				pURPurchaseHeaderCollection.Add(_pURPurchaseHeaderWCF);
			}
			return pURPurchaseHeaderCollection;
		}
    
    /// <summary>
		/// This method will return a count all records in the table.
		/// </summary>
		///
		/// <returns>count records</returns>
		public int SelectAllCount()
		{
			return POS.DataLayer.PURPurchaseHeaderBase.SelectAllCount();			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class PURPurchaseHeader</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class PURPurchaseHeader in the form of an object of class PURPurchaseHeaderCollection</returns>
		public PURPurchaseHeaderCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
		{
			PURPurchaseHeaderCollection pURPurchaseHeaderCollection = new PURPurchaseHeaderCollection();
			foreach (POS.DataLayer.PURPurchaseHeader _pURPurchaseHeader in POS.DataLayer.PURPurchaseHeaderBase.SelectByField(field, fieldValue, fieldValue2, typeOperation))
			{
				_pURPurchaseHeaderWCF = new PURPurchaseHeader();
				
				_pURPurchaseHeaderWCF.PurcaseHeaderID = _pURPurchaseHeader.PurcaseHeaderID;
				_pURPurchaseHeaderWCF.PurchaseDate = _pURPurchaseHeader.PurchaseDate;
				_pURPurchaseHeaderWCF.PaymentTypeID = _pURPurchaseHeader.PaymentTypeID;
				_pURPurchaseHeaderWCF.SupplierID = _pURPurchaseHeader.SupplierID;
				_pURPurchaseHeaderWCF.InvoiceNumber = _pURPurchaseHeader.InvoiceNumber;
				_pURPurchaseHeaderWCF.CreateDate = _pURPurchaseHeader.CreateDate;
				_pURPurchaseHeaderWCF.CreatedBy = _pURPurchaseHeader.CreatedBy;
				_pURPurchaseHeaderWCF.updateDate = _pURPurchaseHeader.updateDate;
				_pURPurchaseHeaderWCF.UpdatedBy = _pURPurchaseHeader.UpdatedBy;
				_pURPurchaseHeaderWCF.IsDeleted = _pURPurchaseHeader.IsDeleted;
				_pURPurchaseHeaderWCF.DeleteDate = _pURPurchaseHeader.DeleteDate;
				_pURPurchaseHeaderWCF.TotalPrice = _pURPurchaseHeader.TotalPrice;
				_pURPurchaseHeaderWCF.ServicePrice = _pURPurchaseHeader.ServicePrice;
				_pURPurchaseHeaderWCF.PaidAmount = _pURPurchaseHeader.PaidAmount;
				_pURPurchaseHeaderWCF.IsClosed = _pURPurchaseHeader.IsClosed;
				_pURPurchaseHeaderWCF.IsVoid = _pURPurchaseHeader.IsVoid;
				_pURPurchaseHeaderWCF.IsPrinted = _pURPurchaseHeader.IsPrinted;
				_pURPurchaseHeaderWCF.RefuseReasonID = _pURPurchaseHeader.RefuseReasonID;
				_pURPurchaseHeaderWCF.TotalDiscountAmount = _pURPurchaseHeader.TotalDiscountAmount;
				_pURPurchaseHeaderWCF.TotalDiscountRatio = _pURPurchaseHeader.TotalDiscountRatio;
				_pURPurchaseHeaderWCF.TaxTypeID = _pURPurchaseHeader.TaxTypeID;
				_pURPurchaseHeaderWCF.RemainingAmount = _pURPurchaseHeader.RemainingAmount;
				_pURPurchaseHeaderWCF.LastDayToPay = _pURPurchaseHeader.LastDayToPay;
				_pURPurchaseHeaderWCF.DeletedBy = _pURPurchaseHeader.DeletedBy;
				_pURPurchaseHeaderWCF.Notes = _pURPurchaseHeader.Notes;
				_pURPurchaseHeaderWCF.InventoryID = _pURPurchaseHeader.InventoryID;
				_pURPurchaseHeaderWCF.InvoiceDate = _pURPurchaseHeader.InvoiceDate;
				
				pURPurchaseHeaderCollection.Add(_pURPurchaseHeaderWCF);
			}
			return pURPurchaseHeaderCollection;
		}
		
		/// <summary>
		/// This method will insert one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="pURPurchaseHeader" type="PURPurchaseHeader">This PURPurchaseHeader  will be inserted in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Insert(PURPurchaseHeader pURPurchaseHeader)
		{
			_pURPurchaseHeader = new POS.DataLayer.PURPurchaseHeader();
			_pURPurchaseHeader.PurcaseHeaderID=pURPurchaseHeader.PurcaseHeaderID;
			_pURPurchaseHeader.PurchaseDate=pURPurchaseHeader.PurchaseDate;
			_pURPurchaseHeader.PaymentTypeID=pURPurchaseHeader.PaymentTypeID;
			_pURPurchaseHeader.SupplierID=pURPurchaseHeader.SupplierID;
			_pURPurchaseHeader.InvoiceNumber=pURPurchaseHeader.InvoiceNumber;
			_pURPurchaseHeader.CreateDate=pURPurchaseHeader.CreateDate;
			_pURPurchaseHeader.CreatedBy=pURPurchaseHeader.CreatedBy;
			_pURPurchaseHeader.updateDate=pURPurchaseHeader.updateDate;
			_pURPurchaseHeader.UpdatedBy=pURPurchaseHeader.UpdatedBy;
			_pURPurchaseHeader.IsDeleted=pURPurchaseHeader.IsDeleted;
			_pURPurchaseHeader.DeleteDate=pURPurchaseHeader.DeleteDate;
			_pURPurchaseHeader.TotalPrice=pURPurchaseHeader.TotalPrice;
			_pURPurchaseHeader.ServicePrice=pURPurchaseHeader.ServicePrice;
			_pURPurchaseHeader.PaidAmount=pURPurchaseHeader.PaidAmount;
			_pURPurchaseHeader.IsClosed=pURPurchaseHeader.IsClosed;
			_pURPurchaseHeader.IsVoid=pURPurchaseHeader.IsVoid;
			_pURPurchaseHeader.IsPrinted=pURPurchaseHeader.IsPrinted;
			_pURPurchaseHeader.RefuseReasonID=pURPurchaseHeader.RefuseReasonID;
			_pURPurchaseHeader.TotalDiscountAmount=pURPurchaseHeader.TotalDiscountAmount;
			_pURPurchaseHeader.TotalDiscountRatio=pURPurchaseHeader.TotalDiscountRatio;
			_pURPurchaseHeader.TaxTypeID=pURPurchaseHeader.TaxTypeID;
			_pURPurchaseHeader.RemainingAmount=pURPurchaseHeader.RemainingAmount;
			_pURPurchaseHeader.LastDayToPay=pURPurchaseHeader.LastDayToPay;
			_pURPurchaseHeader.DeletedBy=pURPurchaseHeader.DeletedBy;
			_pURPurchaseHeader.Notes=pURPurchaseHeader.Notes;
			_pURPurchaseHeader.InventoryID=pURPurchaseHeader.InventoryID;
			_pURPurchaseHeader.InvoiceDate=pURPurchaseHeader.InvoiceDate;
			
			return _pURPurchaseHeader.Insert();
		}
		
		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>list of objects of class PURPurchaseHeader in the form of an object of class PURPurchaseHeaderCollection </returns>
		public PURPurchaseHeaderCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			PURPurchaseHeaderCollection pURPurchaseHeaderCollection = new PURPurchaseHeaderCollection();
			foreach (POS.DataLayer.PURPurchaseHeader _pURPurchaseHeader in POS.DataLayer.PURPurchaseHeaderBase.SelectAllPaged(pageSize, skipPages, orderByStatement))
			{
				_pURPurchaseHeaderWCF = new PURPurchaseHeader();
				
				_pURPurchaseHeaderWCF.PurcaseHeaderID = _pURPurchaseHeader.PurcaseHeaderID;
				_pURPurchaseHeaderWCF.PurchaseDate = _pURPurchaseHeader.PurchaseDate;
				_pURPurchaseHeaderWCF.PaymentTypeID = _pURPurchaseHeader.PaymentTypeID;
				_pURPurchaseHeaderWCF.SupplierID = _pURPurchaseHeader.SupplierID;
				_pURPurchaseHeaderWCF.InvoiceNumber = _pURPurchaseHeader.InvoiceNumber;
				_pURPurchaseHeaderWCF.CreateDate = _pURPurchaseHeader.CreateDate;
				_pURPurchaseHeaderWCF.CreatedBy = _pURPurchaseHeader.CreatedBy;
				_pURPurchaseHeaderWCF.updateDate = _pURPurchaseHeader.updateDate;
				_pURPurchaseHeaderWCF.UpdatedBy = _pURPurchaseHeader.UpdatedBy;
				_pURPurchaseHeaderWCF.IsDeleted = _pURPurchaseHeader.IsDeleted;
				_pURPurchaseHeaderWCF.DeleteDate = _pURPurchaseHeader.DeleteDate;
				_pURPurchaseHeaderWCF.TotalPrice = _pURPurchaseHeader.TotalPrice;
				_pURPurchaseHeaderWCF.ServicePrice = _pURPurchaseHeader.ServicePrice;
				_pURPurchaseHeaderWCF.PaidAmount = _pURPurchaseHeader.PaidAmount;
				_pURPurchaseHeaderWCF.IsClosed = _pURPurchaseHeader.IsClosed;
				_pURPurchaseHeaderWCF.IsVoid = _pURPurchaseHeader.IsVoid;
				_pURPurchaseHeaderWCF.IsPrinted = _pURPurchaseHeader.IsPrinted;
				_pURPurchaseHeaderWCF.RefuseReasonID = _pURPurchaseHeader.RefuseReasonID;
				_pURPurchaseHeaderWCF.TotalDiscountAmount = _pURPurchaseHeader.TotalDiscountAmount;
				_pURPurchaseHeaderWCF.TotalDiscountRatio = _pURPurchaseHeader.TotalDiscountRatio;
				_pURPurchaseHeaderWCF.TaxTypeID = _pURPurchaseHeader.TaxTypeID;
				_pURPurchaseHeaderWCF.RemainingAmount = _pURPurchaseHeader.RemainingAmount;
				_pURPurchaseHeaderWCF.LastDayToPay = _pURPurchaseHeader.LastDayToPay;
				_pURPurchaseHeaderWCF.DeletedBy = _pURPurchaseHeader.DeletedBy;
				_pURPurchaseHeaderWCF.Notes = _pURPurchaseHeader.Notes;
				_pURPurchaseHeaderWCF.InventoryID = _pURPurchaseHeader.InventoryID;
				_pURPurchaseHeaderWCF.InvoiceDate = _pURPurchaseHeader.InvoiceDate;
				
				pURPurchaseHeaderCollection.Add(_pURPurchaseHeaderWCF);
			}
			return pURPurchaseHeaderCollection;
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class PURPurchaseHeader</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class PURPurchaseHeader in the form of an object of class PURPurchaseHeaderCollection</returns>
		public PURPurchaseHeaderCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
		{
			PURPurchaseHeaderCollection pURPurchaseHeaderCollection = new PURPurchaseHeaderCollection();
			foreach (POS.DataLayer.PURPurchaseHeader _pURPurchaseHeader in POS.DataLayer.PURPurchaseHeaderBase.SelectByFieldPaged(field, fieldValue, fieldValue2, typeOperation, pageSize, skipPages, orderByStatement))
			{
				_pURPurchaseHeaderWCF = new PURPurchaseHeader();
				
				_pURPurchaseHeaderWCF.PurcaseHeaderID = _pURPurchaseHeader.PurcaseHeaderID;
				_pURPurchaseHeaderWCF.PurchaseDate = _pURPurchaseHeader.PurchaseDate;
				_pURPurchaseHeaderWCF.PaymentTypeID = _pURPurchaseHeader.PaymentTypeID;
				_pURPurchaseHeaderWCF.SupplierID = _pURPurchaseHeader.SupplierID;
				_pURPurchaseHeaderWCF.InvoiceNumber = _pURPurchaseHeader.InvoiceNumber;
				_pURPurchaseHeaderWCF.CreateDate = _pURPurchaseHeader.CreateDate;
				_pURPurchaseHeaderWCF.CreatedBy = _pURPurchaseHeader.CreatedBy;
				_pURPurchaseHeaderWCF.updateDate = _pURPurchaseHeader.updateDate;
				_pURPurchaseHeaderWCF.UpdatedBy = _pURPurchaseHeader.UpdatedBy;
				_pURPurchaseHeaderWCF.IsDeleted = _pURPurchaseHeader.IsDeleted;
				_pURPurchaseHeaderWCF.DeleteDate = _pURPurchaseHeader.DeleteDate;
				_pURPurchaseHeaderWCF.TotalPrice = _pURPurchaseHeader.TotalPrice;
				_pURPurchaseHeaderWCF.ServicePrice = _pURPurchaseHeader.ServicePrice;
				_pURPurchaseHeaderWCF.PaidAmount = _pURPurchaseHeader.PaidAmount;
				_pURPurchaseHeaderWCF.IsClosed = _pURPurchaseHeader.IsClosed;
				_pURPurchaseHeaderWCF.IsVoid = _pURPurchaseHeader.IsVoid;
				_pURPurchaseHeaderWCF.IsPrinted = _pURPurchaseHeader.IsPrinted;
				_pURPurchaseHeaderWCF.RefuseReasonID = _pURPurchaseHeader.RefuseReasonID;
				_pURPurchaseHeaderWCF.TotalDiscountAmount = _pURPurchaseHeader.TotalDiscountAmount;
				_pURPurchaseHeaderWCF.TotalDiscountRatio = _pURPurchaseHeader.TotalDiscountRatio;
				_pURPurchaseHeaderWCF.TaxTypeID = _pURPurchaseHeader.TaxTypeID;
				_pURPurchaseHeaderWCF.RemainingAmount = _pURPurchaseHeader.RemainingAmount;
				_pURPurchaseHeaderWCF.LastDayToPay = _pURPurchaseHeader.LastDayToPay;
				_pURPurchaseHeaderWCF.DeletedBy = _pURPurchaseHeader.DeletedBy;
				_pURPurchaseHeaderWCF.Notes = _pURPurchaseHeader.Notes;
				_pURPurchaseHeaderWCF.InventoryID = _pURPurchaseHeader.InventoryID;
				_pURPurchaseHeaderWCF.InvoiceDate = _pURPurchaseHeader.InvoiceDate;
				
				pURPurchaseHeaderCollection.Add(_pURPurchaseHeaderWCF);
			}
			return pURPurchaseHeaderCollection;
		}
			///<summary>
		/// This method will update one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="pURPurchaseHeader" type="PURPurchaseHeader">This PURPurchaseHeader  will be updated in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Update(PURPurchaseHeader pURPurchaseHeader)
		{
			_pURPurchaseHeader=POS.DataLayer.PURPurchaseHeader.SelectOne(new POS.DataLayer.PURPurchaseHeaderPrimaryKey(pURPurchaseHeader.PurcaseHeaderID));
			
			_pURPurchaseHeader.PurchaseDate=pURPurchaseHeader.PurchaseDate;
			_pURPurchaseHeader.PaymentTypeID=pURPurchaseHeader.PaymentTypeID;
			_pURPurchaseHeader.SupplierID=pURPurchaseHeader.SupplierID;
			_pURPurchaseHeader.InvoiceNumber=pURPurchaseHeader.InvoiceNumber;
			_pURPurchaseHeader.CreateDate=pURPurchaseHeader.CreateDate;
			_pURPurchaseHeader.CreatedBy=pURPurchaseHeader.CreatedBy;
			_pURPurchaseHeader.updateDate=pURPurchaseHeader.updateDate;
			_pURPurchaseHeader.UpdatedBy=pURPurchaseHeader.UpdatedBy;
			_pURPurchaseHeader.IsDeleted=pURPurchaseHeader.IsDeleted;
			_pURPurchaseHeader.DeleteDate=pURPurchaseHeader.DeleteDate;
			_pURPurchaseHeader.TotalPrice=pURPurchaseHeader.TotalPrice;
			_pURPurchaseHeader.ServicePrice=pURPurchaseHeader.ServicePrice;
			_pURPurchaseHeader.PaidAmount=pURPurchaseHeader.PaidAmount;
			_pURPurchaseHeader.IsClosed=pURPurchaseHeader.IsClosed;
			_pURPurchaseHeader.IsVoid=pURPurchaseHeader.IsVoid;
			_pURPurchaseHeader.IsPrinted=pURPurchaseHeader.IsPrinted;
			_pURPurchaseHeader.RefuseReasonID=pURPurchaseHeader.RefuseReasonID;
			_pURPurchaseHeader.TotalDiscountAmount=pURPurchaseHeader.TotalDiscountAmount;
			_pURPurchaseHeader.TotalDiscountRatio=pURPurchaseHeader.TotalDiscountRatio;
			_pURPurchaseHeader.TaxTypeID=pURPurchaseHeader.TaxTypeID;
			_pURPurchaseHeader.RemainingAmount=pURPurchaseHeader.RemainingAmount;
			_pURPurchaseHeader.LastDayToPay=pURPurchaseHeader.LastDayToPay;
			_pURPurchaseHeader.DeletedBy=pURPurchaseHeader.DeletedBy;
			_pURPurchaseHeader.Notes=pURPurchaseHeader.Notes;
			_pURPurchaseHeader.InventoryID=pURPurchaseHeader.InventoryID;
			_pURPurchaseHeader.InvoiceDate=pURPurchaseHeader.InvoiceDate;
			
			return _pURPurchaseHeader.Update();
		}
	} 
}
