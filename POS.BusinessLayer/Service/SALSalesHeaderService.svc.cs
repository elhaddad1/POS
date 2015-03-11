//
// Class	:	SALSalesHeaderServices.svc.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	3/7/2015 10:40:25 PM
//

using POS.DataLayer;

namespace POS.BusinessLayer
{
	///<summary>
	///WCF service for the SALSalesHeader
	///</summary>
	public class SALSalesHeaderService 
	{
		private SALSalesHeader _sALSalesHeaderWCF;
		private POS.DataLayer.SALSalesHeader _sALSalesHeader;
		
		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="SALSalesHeaderFields">Field of the class SALSalesHeader</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <returns>True if succeeded</returns>
		public bool DeleteByField(string field, object fieldValue)
		{
			return POS.DataLayer.SALSalesHeaderBase.DeleteByField(field, fieldValue);
		}

		///<summary>
		///This method will Delete the object from the database
		///</summary>
		///<param name="pk" type="SALSalesHeaderPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <returns>True if succeeded</returns>
		public bool Delete(SALSalesHeaderPrimaryKey pk)
		{
			return POS.DataLayer.SALSalesHeaderBase.Delete(new POS.DataLayer.SALSalesHeaderPrimaryKey(pk.SalesHeaderID));
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="SALSalesHeaderPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class SALSalesHeader</returns>
		public SALSalesHeader SelectOne(SALSalesHeaderPrimaryKey pk)
		{
			_sALSalesHeaderWCF = new SALSalesHeader();
			_sALSalesHeader = POS.DataLayer.SALSalesHeaderBase.SelectOne(new POS.DataLayer.SALSalesHeaderPrimaryKey(pk.SalesHeaderID));
			
				_sALSalesHeaderWCF.SalesHeaderID = _sALSalesHeader.SalesHeaderID;
				_sALSalesHeaderWCF.SalesDate = _sALSalesHeader.SalesDate;
				_sALSalesHeaderWCF.CustomerID = _sALSalesHeader.CustomerID;
				_sALSalesHeaderWCF.InvoiceNumber = _sALSalesHeader.InvoiceNumber;
				_sALSalesHeaderWCF.InvoiceDate = _sALSalesHeader.InvoiceDate;
				_sALSalesHeaderWCF.SellerID = _sALSalesHeader.SellerID;
				_sALSalesHeaderWCF.PaymentTypeID = _sALSalesHeader.PaymentTypeID;
				_sALSalesHeaderWCF.TotalPrice = _sALSalesHeader.TotalPrice;
				_sALSalesHeaderWCF.PaidAmount = _sALSalesHeader.PaidAmount;
				_sALSalesHeaderWCF.RemainingAmount = _sALSalesHeader.RemainingAmount;
				_sALSalesHeaderWCF.LastDayToPay = _sALSalesHeader.LastDayToPay;
				_sALSalesHeaderWCF.TotalDiscountAmount = _sALSalesHeader.TotalDiscountAmount;
				_sALSalesHeaderWCF.TotalDiscountRatio = _sALSalesHeader.TotalDiscountRatio;
				_sALSalesHeaderWCF.IsClosed = _sALSalesHeader.IsClosed;
				_sALSalesHeaderWCF.IsVoid = _sALSalesHeader.IsVoid;
				_sALSalesHeaderWCF.IsPrinted = _sALSalesHeader.IsPrinted;
				_sALSalesHeaderWCF.ServicePrice = _sALSalesHeader.ServicePrice;
				_sALSalesHeaderWCF.TaxTypeID = _sALSalesHeader.TaxTypeID;
				_sALSalesHeaderWCF.RefuseReasonID = _sALSalesHeader.RefuseReasonID;
				_sALSalesHeaderWCF.CreatedBy = _sALSalesHeader.CreatedBy;
				_sALSalesHeaderWCF.CreateDate = _sALSalesHeader.CreateDate;
				_sALSalesHeaderWCF.UpdatedBy = _sALSalesHeader.UpdatedBy;
				_sALSalesHeaderWCF.UpdateDate = _sALSalesHeader.UpdateDate;
				_sALSalesHeaderWCF.IsDeleted = _sALSalesHeader.IsDeleted;
				_sALSalesHeaderWCF.DeletedBy = _sALSalesHeader.DeletedBy;
				_sALSalesHeaderWCF.DeletDate = _sALSalesHeader.DeletDate;
				_sALSalesHeaderWCF.InventoryID = _sALSalesHeader.InventoryID;
				_sALSalesHeaderWCF.FinalPrice = _sALSalesHeader.FinalPrice;
				_sALSalesHeaderWCF.ChequeNumber = _sALSalesHeader.ChequeNumber;
				
			return _sALSalesHeaderWCF;
		}

		/// <summary>
		/// This method will return a list of objects representing all records in the table.
		/// </summary>
		///
		/// <returns>list of objects of class SALSalesHeader in the form of object of SALSalesHeaderCollection </returns>
		public SALSalesHeaderCollection SelectAll()
		{
			SALSalesHeaderCollection sALSalesHeaderCollection = new SALSalesHeaderCollection();
			foreach (POS.DataLayer.SALSalesHeader _sALSalesHeader in POS.DataLayer.SALSalesHeaderBase.SelectAll())
			{
				_sALSalesHeaderWCF = new SALSalesHeader();
				
				_sALSalesHeaderWCF.SalesHeaderID = _sALSalesHeader.SalesHeaderID;
				_sALSalesHeaderWCF.SalesDate = _sALSalesHeader.SalesDate;
				_sALSalesHeaderWCF.CustomerID = _sALSalesHeader.CustomerID;
				_sALSalesHeaderWCF.InvoiceNumber = _sALSalesHeader.InvoiceNumber;
				_sALSalesHeaderWCF.InvoiceDate = _sALSalesHeader.InvoiceDate;
				_sALSalesHeaderWCF.SellerID = _sALSalesHeader.SellerID;
				_sALSalesHeaderWCF.PaymentTypeID = _sALSalesHeader.PaymentTypeID;
				_sALSalesHeaderWCF.TotalPrice = _sALSalesHeader.TotalPrice;
				_sALSalesHeaderWCF.PaidAmount = _sALSalesHeader.PaidAmount;
				_sALSalesHeaderWCF.RemainingAmount = _sALSalesHeader.RemainingAmount;
				_sALSalesHeaderWCF.LastDayToPay = _sALSalesHeader.LastDayToPay;
				_sALSalesHeaderWCF.TotalDiscountAmount = _sALSalesHeader.TotalDiscountAmount;
				_sALSalesHeaderWCF.TotalDiscountRatio = _sALSalesHeader.TotalDiscountRatio;
				_sALSalesHeaderWCF.IsClosed = _sALSalesHeader.IsClosed;
				_sALSalesHeaderWCF.IsVoid = _sALSalesHeader.IsVoid;
				_sALSalesHeaderWCF.IsPrinted = _sALSalesHeader.IsPrinted;
				_sALSalesHeaderWCF.ServicePrice = _sALSalesHeader.ServicePrice;
				_sALSalesHeaderWCF.TaxTypeID = _sALSalesHeader.TaxTypeID;
				_sALSalesHeaderWCF.RefuseReasonID = _sALSalesHeader.RefuseReasonID;
				_sALSalesHeaderWCF.CreatedBy = _sALSalesHeader.CreatedBy;
				_sALSalesHeaderWCF.CreateDate = _sALSalesHeader.CreateDate;
				_sALSalesHeaderWCF.UpdatedBy = _sALSalesHeader.UpdatedBy;
				_sALSalesHeaderWCF.UpdateDate = _sALSalesHeader.UpdateDate;
				_sALSalesHeaderWCF.IsDeleted = _sALSalesHeader.IsDeleted;
				_sALSalesHeaderWCF.DeletedBy = _sALSalesHeader.DeletedBy;
				_sALSalesHeaderWCF.DeletDate = _sALSalesHeader.DeletDate;
				_sALSalesHeaderWCF.InventoryID = _sALSalesHeader.InventoryID;
				_sALSalesHeaderWCF.FinalPrice = _sALSalesHeader.FinalPrice;
				_sALSalesHeaderWCF.ChequeNumber = _sALSalesHeader.ChequeNumber;
				
				sALSalesHeaderCollection.Add(_sALSalesHeaderWCF);
			}
			return sALSalesHeaderCollection;
		}
    
    /// <summary>
		/// This method will return a count all records in the table.
		/// </summary>
		///
		/// <returns>count records</returns>
		public int SelectAllCount()
		{
			return POS.DataLayer.SALSalesHeaderBase.SelectAllCount();			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class SALSalesHeader</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class SALSalesHeader in the form of an object of class SALSalesHeaderCollection</returns>
		public SALSalesHeaderCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
		{
			SALSalesHeaderCollection sALSalesHeaderCollection = new SALSalesHeaderCollection();
			foreach (POS.DataLayer.SALSalesHeader _sALSalesHeader in POS.DataLayer.SALSalesHeaderBase.SelectByField(field, fieldValue, fieldValue2, typeOperation))
			{
				_sALSalesHeaderWCF = new SALSalesHeader();
				
				_sALSalesHeaderWCF.SalesHeaderID = _sALSalesHeader.SalesHeaderID;
				_sALSalesHeaderWCF.SalesDate = _sALSalesHeader.SalesDate;
				_sALSalesHeaderWCF.CustomerID = _sALSalesHeader.CustomerID;
				_sALSalesHeaderWCF.InvoiceNumber = _sALSalesHeader.InvoiceNumber;
				_sALSalesHeaderWCF.InvoiceDate = _sALSalesHeader.InvoiceDate;
				_sALSalesHeaderWCF.SellerID = _sALSalesHeader.SellerID;
				_sALSalesHeaderWCF.PaymentTypeID = _sALSalesHeader.PaymentTypeID;
				_sALSalesHeaderWCF.TotalPrice = _sALSalesHeader.TotalPrice;
				_sALSalesHeaderWCF.PaidAmount = _sALSalesHeader.PaidAmount;
				_sALSalesHeaderWCF.RemainingAmount = _sALSalesHeader.RemainingAmount;
				_sALSalesHeaderWCF.LastDayToPay = _sALSalesHeader.LastDayToPay;
				_sALSalesHeaderWCF.TotalDiscountAmount = _sALSalesHeader.TotalDiscountAmount;
				_sALSalesHeaderWCF.TotalDiscountRatio = _sALSalesHeader.TotalDiscountRatio;
				_sALSalesHeaderWCF.IsClosed = _sALSalesHeader.IsClosed;
				_sALSalesHeaderWCF.IsVoid = _sALSalesHeader.IsVoid;
				_sALSalesHeaderWCF.IsPrinted = _sALSalesHeader.IsPrinted;
				_sALSalesHeaderWCF.ServicePrice = _sALSalesHeader.ServicePrice;
				_sALSalesHeaderWCF.TaxTypeID = _sALSalesHeader.TaxTypeID;
				_sALSalesHeaderWCF.RefuseReasonID = _sALSalesHeader.RefuseReasonID;
				_sALSalesHeaderWCF.CreatedBy = _sALSalesHeader.CreatedBy;
				_sALSalesHeaderWCF.CreateDate = _sALSalesHeader.CreateDate;
				_sALSalesHeaderWCF.UpdatedBy = _sALSalesHeader.UpdatedBy;
				_sALSalesHeaderWCF.UpdateDate = _sALSalesHeader.UpdateDate;
				_sALSalesHeaderWCF.IsDeleted = _sALSalesHeader.IsDeleted;
				_sALSalesHeaderWCF.DeletedBy = _sALSalesHeader.DeletedBy;
				_sALSalesHeaderWCF.DeletDate = _sALSalesHeader.DeletDate;
				_sALSalesHeaderWCF.InventoryID = _sALSalesHeader.InventoryID;
				_sALSalesHeaderWCF.FinalPrice = _sALSalesHeader.FinalPrice;
				_sALSalesHeaderWCF.ChequeNumber = _sALSalesHeader.ChequeNumber;
				
				sALSalesHeaderCollection.Add(_sALSalesHeaderWCF);
			}
			return sALSalesHeaderCollection;
		}
		
		/// <summary>
		/// This method will insert one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="sALSalesHeader" type="SALSalesHeader">This SALSalesHeader  will be inserted in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Insert(SALSalesHeader sALSalesHeader)
		{
			_sALSalesHeader = new POS.DataLayer.SALSalesHeader();
			_sALSalesHeader.SalesHeaderID=sALSalesHeader.SalesHeaderID;
			_sALSalesHeader.SalesDate=sALSalesHeader.SalesDate;
			_sALSalesHeader.CustomerID=sALSalesHeader.CustomerID;
			_sALSalesHeader.InvoiceNumber=sALSalesHeader.InvoiceNumber;
			_sALSalesHeader.InvoiceDate=sALSalesHeader.InvoiceDate;
			_sALSalesHeader.SellerID=sALSalesHeader.SellerID;
			_sALSalesHeader.PaymentTypeID=sALSalesHeader.PaymentTypeID;
			_sALSalesHeader.TotalPrice=sALSalesHeader.TotalPrice;
			_sALSalesHeader.PaidAmount=sALSalesHeader.PaidAmount;
			_sALSalesHeader.RemainingAmount=sALSalesHeader.RemainingAmount;
			_sALSalesHeader.LastDayToPay=sALSalesHeader.LastDayToPay;
			_sALSalesHeader.TotalDiscountAmount=sALSalesHeader.TotalDiscountAmount;
			_sALSalesHeader.TotalDiscountRatio=sALSalesHeader.TotalDiscountRatio;
			_sALSalesHeader.IsClosed=sALSalesHeader.IsClosed;
			_sALSalesHeader.IsVoid=sALSalesHeader.IsVoid;
			_sALSalesHeader.IsPrinted=sALSalesHeader.IsPrinted;
			_sALSalesHeader.ServicePrice=sALSalesHeader.ServicePrice;
			_sALSalesHeader.TaxTypeID=sALSalesHeader.TaxTypeID;
			_sALSalesHeader.RefuseReasonID=sALSalesHeader.RefuseReasonID;
			_sALSalesHeader.CreatedBy=sALSalesHeader.CreatedBy;
			_sALSalesHeader.CreateDate=sALSalesHeader.CreateDate;
			_sALSalesHeader.UpdatedBy=sALSalesHeader.UpdatedBy;
			_sALSalesHeader.UpdateDate=sALSalesHeader.UpdateDate;
			_sALSalesHeader.IsDeleted=sALSalesHeader.IsDeleted;
			_sALSalesHeader.DeletedBy=sALSalesHeader.DeletedBy;
			_sALSalesHeader.DeletDate=sALSalesHeader.DeletDate;
			_sALSalesHeader.InventoryID=sALSalesHeader.InventoryID;
			_sALSalesHeader.FinalPrice=sALSalesHeader.FinalPrice;
			_sALSalesHeader.ChequeNumber=sALSalesHeader.ChequeNumber;
			
			return _sALSalesHeader.Insert();
		}
		/// <summary>
		/// This method will delete row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="ADUserPrimaryKey">Primary Key information based on which data is to be deleted.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool DeleteAllByForeignKeySellerID(ADUserPrimaryKey pk)
		{
			return POS.DataLayer.SALSalesHeaderBase.DeleteAllByForeignKeySellerID(new POS.DataLayer.ADUserPrimaryKey(pk.UserID));
		}
		
		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="ADUserPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class SALSalesHeaderCollection</returns>
		public SALSalesHeaderCollection SelectAllByForeignKeySellerID(ADUserPrimaryKey pk)
		{
			SALSalesHeaderCollection sALSalesHeaderCollection=new SALSalesHeaderCollection();
			foreach (POS.DataLayer.SALSalesHeader _sALSalesHeader in POS.DataLayer.SALSalesHeaderBase.SelectAllByForeignKeySellerID(new POS.DataLayer.ADUserPrimaryKey(pk.UserID)))
			{
				_sALSalesHeaderWCF = new SALSalesHeader();
				_sALSalesHeaderWCF.SalesHeaderID = _sALSalesHeader.SalesHeaderID;
				_sALSalesHeaderWCF.SalesDate = _sALSalesHeader.SalesDate;
				_sALSalesHeaderWCF.CustomerID = _sALSalesHeader.CustomerID;
				_sALSalesHeaderWCF.InvoiceNumber = _sALSalesHeader.InvoiceNumber;
				_sALSalesHeaderWCF.InvoiceDate = _sALSalesHeader.InvoiceDate;
				_sALSalesHeaderWCF.SellerID = _sALSalesHeader.SellerID;
				_sALSalesHeaderWCF.PaymentTypeID = _sALSalesHeader.PaymentTypeID;
				_sALSalesHeaderWCF.TotalPrice = _sALSalesHeader.TotalPrice;
				_sALSalesHeaderWCF.PaidAmount = _sALSalesHeader.PaidAmount;
				_sALSalesHeaderWCF.RemainingAmount = _sALSalesHeader.RemainingAmount;
				_sALSalesHeaderWCF.LastDayToPay = _sALSalesHeader.LastDayToPay;
				_sALSalesHeaderWCF.TotalDiscountAmount = _sALSalesHeader.TotalDiscountAmount;
				_sALSalesHeaderWCF.TotalDiscountRatio = _sALSalesHeader.TotalDiscountRatio;
				_sALSalesHeaderWCF.IsClosed = _sALSalesHeader.IsClosed;
				_sALSalesHeaderWCF.IsVoid = _sALSalesHeader.IsVoid;
				_sALSalesHeaderWCF.IsPrinted = _sALSalesHeader.IsPrinted;
				_sALSalesHeaderWCF.ServicePrice = _sALSalesHeader.ServicePrice;
				_sALSalesHeaderWCF.TaxTypeID = _sALSalesHeader.TaxTypeID;
				_sALSalesHeaderWCF.RefuseReasonID = _sALSalesHeader.RefuseReasonID;
				_sALSalesHeaderWCF.CreatedBy = _sALSalesHeader.CreatedBy;
				_sALSalesHeaderWCF.CreateDate = _sALSalesHeader.CreateDate;
				_sALSalesHeaderWCF.UpdatedBy = _sALSalesHeader.UpdatedBy;
				_sALSalesHeaderWCF.UpdateDate = _sALSalesHeader.UpdateDate;
				_sALSalesHeaderWCF.IsDeleted = _sALSalesHeader.IsDeleted;
				_sALSalesHeaderWCF.DeletedBy = _sALSalesHeader.DeletedBy;
				_sALSalesHeaderWCF.DeletDate = _sALSalesHeader.DeletDate;
				_sALSalesHeaderWCF.InventoryID = _sALSalesHeader.InventoryID;
				_sALSalesHeaderWCF.FinalPrice = _sALSalesHeader.FinalPrice;
				_sALSalesHeaderWCF.ChequeNumber = _sALSalesHeader.ChequeNumber;
				
				sALSalesHeaderCollection.Add(_sALSalesHeaderWCF);
			}
			return sALSalesHeaderCollection;
		}
		
		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="ADUserPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>object of class SALSalesHeaderCollection</returns>
		public SALSalesHeaderCollection SelectAllByForeignKeySellerIDPaged(ADUserPrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			SALSalesHeaderCollection sALSalesHeaderCollection=new SALSalesHeaderCollection();
			foreach (POS.DataLayer.SALSalesHeader _sALSalesHeader in POS.DataLayer.SALSalesHeaderBase.SelectAllByForeignKeySellerIDPaged(new POS.DataLayer.ADUserPrimaryKey(pk.UserID), pageSize, skipPages, orderByStatement))
			{
				_sALSalesHeaderWCF = new SALSalesHeader();
				_sALSalesHeaderWCF.SalesHeaderID = _sALSalesHeader.SalesHeaderID;
				_sALSalesHeaderWCF.SalesDate = _sALSalesHeader.SalesDate;
				_sALSalesHeaderWCF.CustomerID = _sALSalesHeader.CustomerID;
				_sALSalesHeaderWCF.InvoiceNumber = _sALSalesHeader.InvoiceNumber;
				_sALSalesHeaderWCF.InvoiceDate = _sALSalesHeader.InvoiceDate;
				_sALSalesHeaderWCF.SellerID = _sALSalesHeader.SellerID;
				_sALSalesHeaderWCF.PaymentTypeID = _sALSalesHeader.PaymentTypeID;
				_sALSalesHeaderWCF.TotalPrice = _sALSalesHeader.TotalPrice;
				_sALSalesHeaderWCF.PaidAmount = _sALSalesHeader.PaidAmount;
				_sALSalesHeaderWCF.RemainingAmount = _sALSalesHeader.RemainingAmount;
				_sALSalesHeaderWCF.LastDayToPay = _sALSalesHeader.LastDayToPay;
				_sALSalesHeaderWCF.TotalDiscountAmount = _sALSalesHeader.TotalDiscountAmount;
				_sALSalesHeaderWCF.TotalDiscountRatio = _sALSalesHeader.TotalDiscountRatio;
				_sALSalesHeaderWCF.IsClosed = _sALSalesHeader.IsClosed;
				_sALSalesHeaderWCF.IsVoid = _sALSalesHeader.IsVoid;
				_sALSalesHeaderWCF.IsPrinted = _sALSalesHeader.IsPrinted;
				_sALSalesHeaderWCF.ServicePrice = _sALSalesHeader.ServicePrice;
				_sALSalesHeaderWCF.TaxTypeID = _sALSalesHeader.TaxTypeID;
				_sALSalesHeaderWCF.RefuseReasonID = _sALSalesHeader.RefuseReasonID;
				_sALSalesHeaderWCF.CreatedBy = _sALSalesHeader.CreatedBy;
				_sALSalesHeaderWCF.CreateDate = _sALSalesHeader.CreateDate;
				_sALSalesHeaderWCF.UpdatedBy = _sALSalesHeader.UpdatedBy;
				_sALSalesHeaderWCF.UpdateDate = _sALSalesHeader.UpdateDate;
				_sALSalesHeaderWCF.IsDeleted = _sALSalesHeader.IsDeleted;
				_sALSalesHeaderWCF.DeletedBy = _sALSalesHeader.DeletedBy;
				_sALSalesHeaderWCF.DeletDate = _sALSalesHeader.DeletDate;
				_sALSalesHeaderWCF.InventoryID = _sALSalesHeader.InventoryID;
				_sALSalesHeaderWCF.FinalPrice = _sALSalesHeader.FinalPrice;
				_sALSalesHeaderWCF.ChequeNumber = _sALSalesHeader.ChequeNumber;
				
				sALSalesHeaderCollection.Add(_sALSalesHeaderWCF);
			}
			return sALSalesHeaderCollection;
		}
			/// <summary>
		/// This method will delete row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="BDCustomerPrimaryKey">Primary Key information based on which data is to be deleted.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool DeleteAllByForeignKeyCustomerID(BDCustomerPrimaryKey pk)
		{
			return POS.DataLayer.SALSalesHeaderBase.DeleteAllByForeignKeyCustomerID(new POS.DataLayer.BDCustomerPrimaryKey(pk.CustomerID));
		}
		
		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="BDCustomerPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class SALSalesHeaderCollection</returns>
		public SALSalesHeaderCollection SelectAllByForeignKeyCustomerID(BDCustomerPrimaryKey pk)
		{
			SALSalesHeaderCollection sALSalesHeaderCollection=new SALSalesHeaderCollection();
			foreach (POS.DataLayer.SALSalesHeader _sALSalesHeader in POS.DataLayer.SALSalesHeaderBase.SelectAllByForeignKeyCustomerID(new POS.DataLayer.BDCustomerPrimaryKey(pk.CustomerID)))
			{
				_sALSalesHeaderWCF = new SALSalesHeader();
				_sALSalesHeaderWCF.SalesHeaderID = _sALSalesHeader.SalesHeaderID;
				_sALSalesHeaderWCF.SalesDate = _sALSalesHeader.SalesDate;
				_sALSalesHeaderWCF.CustomerID = _sALSalesHeader.CustomerID;
				_sALSalesHeaderWCF.InvoiceNumber = _sALSalesHeader.InvoiceNumber;
				_sALSalesHeaderWCF.InvoiceDate = _sALSalesHeader.InvoiceDate;
				_sALSalesHeaderWCF.SellerID = _sALSalesHeader.SellerID;
				_sALSalesHeaderWCF.PaymentTypeID = _sALSalesHeader.PaymentTypeID;
				_sALSalesHeaderWCF.TotalPrice = _sALSalesHeader.TotalPrice;
				_sALSalesHeaderWCF.PaidAmount = _sALSalesHeader.PaidAmount;
				_sALSalesHeaderWCF.RemainingAmount = _sALSalesHeader.RemainingAmount;
				_sALSalesHeaderWCF.LastDayToPay = _sALSalesHeader.LastDayToPay;
				_sALSalesHeaderWCF.TotalDiscountAmount = _sALSalesHeader.TotalDiscountAmount;
				_sALSalesHeaderWCF.TotalDiscountRatio = _sALSalesHeader.TotalDiscountRatio;
				_sALSalesHeaderWCF.IsClosed = _sALSalesHeader.IsClosed;
				_sALSalesHeaderWCF.IsVoid = _sALSalesHeader.IsVoid;
				_sALSalesHeaderWCF.IsPrinted = _sALSalesHeader.IsPrinted;
				_sALSalesHeaderWCF.ServicePrice = _sALSalesHeader.ServicePrice;
				_sALSalesHeaderWCF.TaxTypeID = _sALSalesHeader.TaxTypeID;
				_sALSalesHeaderWCF.RefuseReasonID = _sALSalesHeader.RefuseReasonID;
				_sALSalesHeaderWCF.CreatedBy = _sALSalesHeader.CreatedBy;
				_sALSalesHeaderWCF.CreateDate = _sALSalesHeader.CreateDate;
				_sALSalesHeaderWCF.UpdatedBy = _sALSalesHeader.UpdatedBy;
				_sALSalesHeaderWCF.UpdateDate = _sALSalesHeader.UpdateDate;
				_sALSalesHeaderWCF.IsDeleted = _sALSalesHeader.IsDeleted;
				_sALSalesHeaderWCF.DeletedBy = _sALSalesHeader.DeletedBy;
				_sALSalesHeaderWCF.DeletDate = _sALSalesHeader.DeletDate;
				_sALSalesHeaderWCF.InventoryID = _sALSalesHeader.InventoryID;
				_sALSalesHeaderWCF.FinalPrice = _sALSalesHeader.FinalPrice;
				_sALSalesHeaderWCF.ChequeNumber = _sALSalesHeader.ChequeNumber;
				
				sALSalesHeaderCollection.Add(_sALSalesHeaderWCF);
			}
			return sALSalesHeaderCollection;
		}
		
		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="BDCustomerPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>object of class SALSalesHeaderCollection</returns>
		public SALSalesHeaderCollection SelectAllByForeignKeyCustomerIDPaged(BDCustomerPrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			SALSalesHeaderCollection sALSalesHeaderCollection=new SALSalesHeaderCollection();
			foreach (POS.DataLayer.SALSalesHeader _sALSalesHeader in POS.DataLayer.SALSalesHeaderBase.SelectAllByForeignKeyCustomerIDPaged(new POS.DataLayer.BDCustomerPrimaryKey(pk.CustomerID), pageSize, skipPages, orderByStatement))
			{
				_sALSalesHeaderWCF = new SALSalesHeader();
				_sALSalesHeaderWCF.SalesHeaderID = _sALSalesHeader.SalesHeaderID;
				_sALSalesHeaderWCF.SalesDate = _sALSalesHeader.SalesDate;
				_sALSalesHeaderWCF.CustomerID = _sALSalesHeader.CustomerID;
				_sALSalesHeaderWCF.InvoiceNumber = _sALSalesHeader.InvoiceNumber;
				_sALSalesHeaderWCF.InvoiceDate = _sALSalesHeader.InvoiceDate;
				_sALSalesHeaderWCF.SellerID = _sALSalesHeader.SellerID;
				_sALSalesHeaderWCF.PaymentTypeID = _sALSalesHeader.PaymentTypeID;
				_sALSalesHeaderWCF.TotalPrice = _sALSalesHeader.TotalPrice;
				_sALSalesHeaderWCF.PaidAmount = _sALSalesHeader.PaidAmount;
				_sALSalesHeaderWCF.RemainingAmount = _sALSalesHeader.RemainingAmount;
				_sALSalesHeaderWCF.LastDayToPay = _sALSalesHeader.LastDayToPay;
				_sALSalesHeaderWCF.TotalDiscountAmount = _sALSalesHeader.TotalDiscountAmount;
				_sALSalesHeaderWCF.TotalDiscountRatio = _sALSalesHeader.TotalDiscountRatio;
				_sALSalesHeaderWCF.IsClosed = _sALSalesHeader.IsClosed;
				_sALSalesHeaderWCF.IsVoid = _sALSalesHeader.IsVoid;
				_sALSalesHeaderWCF.IsPrinted = _sALSalesHeader.IsPrinted;
				_sALSalesHeaderWCF.ServicePrice = _sALSalesHeader.ServicePrice;
				_sALSalesHeaderWCF.TaxTypeID = _sALSalesHeader.TaxTypeID;
				_sALSalesHeaderWCF.RefuseReasonID = _sALSalesHeader.RefuseReasonID;
				_sALSalesHeaderWCF.CreatedBy = _sALSalesHeader.CreatedBy;
				_sALSalesHeaderWCF.CreateDate = _sALSalesHeader.CreateDate;
				_sALSalesHeaderWCF.UpdatedBy = _sALSalesHeader.UpdatedBy;
				_sALSalesHeaderWCF.UpdateDate = _sALSalesHeader.UpdateDate;
				_sALSalesHeaderWCF.IsDeleted = _sALSalesHeader.IsDeleted;
				_sALSalesHeaderWCF.DeletedBy = _sALSalesHeader.DeletedBy;
				_sALSalesHeaderWCF.DeletDate = _sALSalesHeader.DeletDate;
				_sALSalesHeaderWCF.InventoryID = _sALSalesHeader.InventoryID;
				_sALSalesHeaderWCF.FinalPrice = _sALSalesHeader.FinalPrice;
				_sALSalesHeaderWCF.ChequeNumber = _sALSalesHeader.ChequeNumber;
				
				sALSalesHeaderCollection.Add(_sALSalesHeaderWCF);
			}
			return sALSalesHeaderCollection;
		}
			/// <summary>
		/// This method will delete row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="BDRefuseReasonPrimaryKey">Primary Key information based on which data is to be deleted.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool DeleteAllByForeignKeyRefuseReasonID(BDRefuseReasonPrimaryKey pk)
		{
			return POS.DataLayer.SALSalesHeaderBase.DeleteAllByForeignKeyRefuseReasonID(new POS.DataLayer.BDRefuseReasonPrimaryKey(pk.RefuseReasonID));
		}
		
		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="BDRefuseReasonPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class SALSalesHeaderCollection</returns>
		public SALSalesHeaderCollection SelectAllByForeignKeyRefuseReasonID(BDRefuseReasonPrimaryKey pk)
		{
			SALSalesHeaderCollection sALSalesHeaderCollection=new SALSalesHeaderCollection();
			foreach (POS.DataLayer.SALSalesHeader _sALSalesHeader in POS.DataLayer.SALSalesHeaderBase.SelectAllByForeignKeyRefuseReasonID(new POS.DataLayer.BDRefuseReasonPrimaryKey(pk.RefuseReasonID)))
			{
				_sALSalesHeaderWCF = new SALSalesHeader();
				_sALSalesHeaderWCF.SalesHeaderID = _sALSalesHeader.SalesHeaderID;
				_sALSalesHeaderWCF.SalesDate = _sALSalesHeader.SalesDate;
				_sALSalesHeaderWCF.CustomerID = _sALSalesHeader.CustomerID;
				_sALSalesHeaderWCF.InvoiceNumber = _sALSalesHeader.InvoiceNumber;
				_sALSalesHeaderWCF.InvoiceDate = _sALSalesHeader.InvoiceDate;
				_sALSalesHeaderWCF.SellerID = _sALSalesHeader.SellerID;
				_sALSalesHeaderWCF.PaymentTypeID = _sALSalesHeader.PaymentTypeID;
				_sALSalesHeaderWCF.TotalPrice = _sALSalesHeader.TotalPrice;
				_sALSalesHeaderWCF.PaidAmount = _sALSalesHeader.PaidAmount;
				_sALSalesHeaderWCF.RemainingAmount = _sALSalesHeader.RemainingAmount;
				_sALSalesHeaderWCF.LastDayToPay = _sALSalesHeader.LastDayToPay;
				_sALSalesHeaderWCF.TotalDiscountAmount = _sALSalesHeader.TotalDiscountAmount;
				_sALSalesHeaderWCF.TotalDiscountRatio = _sALSalesHeader.TotalDiscountRatio;
				_sALSalesHeaderWCF.IsClosed = _sALSalesHeader.IsClosed;
				_sALSalesHeaderWCF.IsVoid = _sALSalesHeader.IsVoid;
				_sALSalesHeaderWCF.IsPrinted = _sALSalesHeader.IsPrinted;
				_sALSalesHeaderWCF.ServicePrice = _sALSalesHeader.ServicePrice;
				_sALSalesHeaderWCF.TaxTypeID = _sALSalesHeader.TaxTypeID;
				_sALSalesHeaderWCF.RefuseReasonID = _sALSalesHeader.RefuseReasonID;
				_sALSalesHeaderWCF.CreatedBy = _sALSalesHeader.CreatedBy;
				_sALSalesHeaderWCF.CreateDate = _sALSalesHeader.CreateDate;
				_sALSalesHeaderWCF.UpdatedBy = _sALSalesHeader.UpdatedBy;
				_sALSalesHeaderWCF.UpdateDate = _sALSalesHeader.UpdateDate;
				_sALSalesHeaderWCF.IsDeleted = _sALSalesHeader.IsDeleted;
				_sALSalesHeaderWCF.DeletedBy = _sALSalesHeader.DeletedBy;
				_sALSalesHeaderWCF.DeletDate = _sALSalesHeader.DeletDate;
				_sALSalesHeaderWCF.InventoryID = _sALSalesHeader.InventoryID;
				_sALSalesHeaderWCF.FinalPrice = _sALSalesHeader.FinalPrice;
				_sALSalesHeaderWCF.ChequeNumber = _sALSalesHeader.ChequeNumber;
				
				sALSalesHeaderCollection.Add(_sALSalesHeaderWCF);
			}
			return sALSalesHeaderCollection;
		}
		
		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="BDRefuseReasonPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>object of class SALSalesHeaderCollection</returns>
		public SALSalesHeaderCollection SelectAllByForeignKeyRefuseReasonIDPaged(BDRefuseReasonPrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			SALSalesHeaderCollection sALSalesHeaderCollection=new SALSalesHeaderCollection();
			foreach (POS.DataLayer.SALSalesHeader _sALSalesHeader in POS.DataLayer.SALSalesHeaderBase.SelectAllByForeignKeyRefuseReasonIDPaged(new POS.DataLayer.BDRefuseReasonPrimaryKey(pk.RefuseReasonID), pageSize, skipPages, orderByStatement))
			{
				_sALSalesHeaderWCF = new SALSalesHeader();
				_sALSalesHeaderWCF.SalesHeaderID = _sALSalesHeader.SalesHeaderID;
				_sALSalesHeaderWCF.SalesDate = _sALSalesHeader.SalesDate;
				_sALSalesHeaderWCF.CustomerID = _sALSalesHeader.CustomerID;
				_sALSalesHeaderWCF.InvoiceNumber = _sALSalesHeader.InvoiceNumber;
				_sALSalesHeaderWCF.InvoiceDate = _sALSalesHeader.InvoiceDate;
				_sALSalesHeaderWCF.SellerID = _sALSalesHeader.SellerID;
				_sALSalesHeaderWCF.PaymentTypeID = _sALSalesHeader.PaymentTypeID;
				_sALSalesHeaderWCF.TotalPrice = _sALSalesHeader.TotalPrice;
				_sALSalesHeaderWCF.PaidAmount = _sALSalesHeader.PaidAmount;
				_sALSalesHeaderWCF.RemainingAmount = _sALSalesHeader.RemainingAmount;
				_sALSalesHeaderWCF.LastDayToPay = _sALSalesHeader.LastDayToPay;
				_sALSalesHeaderWCF.TotalDiscountAmount = _sALSalesHeader.TotalDiscountAmount;
				_sALSalesHeaderWCF.TotalDiscountRatio = _sALSalesHeader.TotalDiscountRatio;
				_sALSalesHeaderWCF.IsClosed = _sALSalesHeader.IsClosed;
				_sALSalesHeaderWCF.IsVoid = _sALSalesHeader.IsVoid;
				_sALSalesHeaderWCF.IsPrinted = _sALSalesHeader.IsPrinted;
				_sALSalesHeaderWCF.ServicePrice = _sALSalesHeader.ServicePrice;
				_sALSalesHeaderWCF.TaxTypeID = _sALSalesHeader.TaxTypeID;
				_sALSalesHeaderWCF.RefuseReasonID = _sALSalesHeader.RefuseReasonID;
				_sALSalesHeaderWCF.CreatedBy = _sALSalesHeader.CreatedBy;
				_sALSalesHeaderWCF.CreateDate = _sALSalesHeader.CreateDate;
				_sALSalesHeaderWCF.UpdatedBy = _sALSalesHeader.UpdatedBy;
				_sALSalesHeaderWCF.UpdateDate = _sALSalesHeader.UpdateDate;
				_sALSalesHeaderWCF.IsDeleted = _sALSalesHeader.IsDeleted;
				_sALSalesHeaderWCF.DeletedBy = _sALSalesHeader.DeletedBy;
				_sALSalesHeaderWCF.DeletDate = _sALSalesHeader.DeletDate;
				_sALSalesHeaderWCF.InventoryID = _sALSalesHeader.InventoryID;
				_sALSalesHeaderWCF.FinalPrice = _sALSalesHeader.FinalPrice;
				_sALSalesHeaderWCF.ChequeNumber = _sALSalesHeader.ChequeNumber;
				
				sALSalesHeaderCollection.Add(_sALSalesHeaderWCF);
			}
			return sALSalesHeaderCollection;
		}
			/// <summary>
		/// This method will delete row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="BDTaxTypePrimaryKey">Primary Key information based on which data is to be deleted.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool DeleteAllByForeignKeyTaxTypeID(BDTaxTypePrimaryKey pk)
		{
			return POS.DataLayer.SALSalesHeaderBase.DeleteAllByForeignKeyTaxTypeID(new POS.DataLayer.BDTaxTypePrimaryKey(pk.TaxTypeID));
		}
		
		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="BDTaxTypePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class SALSalesHeaderCollection</returns>
		public SALSalesHeaderCollection SelectAllByForeignKeyTaxTypeID(BDTaxTypePrimaryKey pk)
		{
			SALSalesHeaderCollection sALSalesHeaderCollection=new SALSalesHeaderCollection();
			foreach (POS.DataLayer.SALSalesHeader _sALSalesHeader in POS.DataLayer.SALSalesHeaderBase.SelectAllByForeignKeyTaxTypeID(new POS.DataLayer.BDTaxTypePrimaryKey(pk.TaxTypeID)))
			{
				_sALSalesHeaderWCF = new SALSalesHeader();
				_sALSalesHeaderWCF.SalesHeaderID = _sALSalesHeader.SalesHeaderID;
				_sALSalesHeaderWCF.SalesDate = _sALSalesHeader.SalesDate;
				_sALSalesHeaderWCF.CustomerID = _sALSalesHeader.CustomerID;
				_sALSalesHeaderWCF.InvoiceNumber = _sALSalesHeader.InvoiceNumber;
				_sALSalesHeaderWCF.InvoiceDate = _sALSalesHeader.InvoiceDate;
				_sALSalesHeaderWCF.SellerID = _sALSalesHeader.SellerID;
				_sALSalesHeaderWCF.PaymentTypeID = _sALSalesHeader.PaymentTypeID;
				_sALSalesHeaderWCF.TotalPrice = _sALSalesHeader.TotalPrice;
				_sALSalesHeaderWCF.PaidAmount = _sALSalesHeader.PaidAmount;
				_sALSalesHeaderWCF.RemainingAmount = _sALSalesHeader.RemainingAmount;
				_sALSalesHeaderWCF.LastDayToPay = _sALSalesHeader.LastDayToPay;
				_sALSalesHeaderWCF.TotalDiscountAmount = _sALSalesHeader.TotalDiscountAmount;
				_sALSalesHeaderWCF.TotalDiscountRatio = _sALSalesHeader.TotalDiscountRatio;
				_sALSalesHeaderWCF.IsClosed = _sALSalesHeader.IsClosed;
				_sALSalesHeaderWCF.IsVoid = _sALSalesHeader.IsVoid;
				_sALSalesHeaderWCF.IsPrinted = _sALSalesHeader.IsPrinted;
				_sALSalesHeaderWCF.ServicePrice = _sALSalesHeader.ServicePrice;
				_sALSalesHeaderWCF.TaxTypeID = _sALSalesHeader.TaxTypeID;
				_sALSalesHeaderWCF.RefuseReasonID = _sALSalesHeader.RefuseReasonID;
				_sALSalesHeaderWCF.CreatedBy = _sALSalesHeader.CreatedBy;
				_sALSalesHeaderWCF.CreateDate = _sALSalesHeader.CreateDate;
				_sALSalesHeaderWCF.UpdatedBy = _sALSalesHeader.UpdatedBy;
				_sALSalesHeaderWCF.UpdateDate = _sALSalesHeader.UpdateDate;
				_sALSalesHeaderWCF.IsDeleted = _sALSalesHeader.IsDeleted;
				_sALSalesHeaderWCF.DeletedBy = _sALSalesHeader.DeletedBy;
				_sALSalesHeaderWCF.DeletDate = _sALSalesHeader.DeletDate;
				_sALSalesHeaderWCF.InventoryID = _sALSalesHeader.InventoryID;
				_sALSalesHeaderWCF.FinalPrice = _sALSalesHeader.FinalPrice;
				_sALSalesHeaderWCF.ChequeNumber = _sALSalesHeader.ChequeNumber;
				
				sALSalesHeaderCollection.Add(_sALSalesHeaderWCF);
			}
			return sALSalesHeaderCollection;
		}
		
		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="BDTaxTypePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>object of class SALSalesHeaderCollection</returns>
		public SALSalesHeaderCollection SelectAllByForeignKeyTaxTypeIDPaged(BDTaxTypePrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			SALSalesHeaderCollection sALSalesHeaderCollection=new SALSalesHeaderCollection();
			foreach (POS.DataLayer.SALSalesHeader _sALSalesHeader in POS.DataLayer.SALSalesHeaderBase.SelectAllByForeignKeyTaxTypeIDPaged(new POS.DataLayer.BDTaxTypePrimaryKey(pk.TaxTypeID), pageSize, skipPages, orderByStatement))
			{
				_sALSalesHeaderWCF = new SALSalesHeader();
				_sALSalesHeaderWCF.SalesHeaderID = _sALSalesHeader.SalesHeaderID;
				_sALSalesHeaderWCF.SalesDate = _sALSalesHeader.SalesDate;
				_sALSalesHeaderWCF.CustomerID = _sALSalesHeader.CustomerID;
				_sALSalesHeaderWCF.InvoiceNumber = _sALSalesHeader.InvoiceNumber;
				_sALSalesHeaderWCF.InvoiceDate = _sALSalesHeader.InvoiceDate;
				_sALSalesHeaderWCF.SellerID = _sALSalesHeader.SellerID;
				_sALSalesHeaderWCF.PaymentTypeID = _sALSalesHeader.PaymentTypeID;
				_sALSalesHeaderWCF.TotalPrice = _sALSalesHeader.TotalPrice;
				_sALSalesHeaderWCF.PaidAmount = _sALSalesHeader.PaidAmount;
				_sALSalesHeaderWCF.RemainingAmount = _sALSalesHeader.RemainingAmount;
				_sALSalesHeaderWCF.LastDayToPay = _sALSalesHeader.LastDayToPay;
				_sALSalesHeaderWCF.TotalDiscountAmount = _sALSalesHeader.TotalDiscountAmount;
				_sALSalesHeaderWCF.TotalDiscountRatio = _sALSalesHeader.TotalDiscountRatio;
				_sALSalesHeaderWCF.IsClosed = _sALSalesHeader.IsClosed;
				_sALSalesHeaderWCF.IsVoid = _sALSalesHeader.IsVoid;
				_sALSalesHeaderWCF.IsPrinted = _sALSalesHeader.IsPrinted;
				_sALSalesHeaderWCF.ServicePrice = _sALSalesHeader.ServicePrice;
				_sALSalesHeaderWCF.TaxTypeID = _sALSalesHeader.TaxTypeID;
				_sALSalesHeaderWCF.RefuseReasonID = _sALSalesHeader.RefuseReasonID;
				_sALSalesHeaderWCF.CreatedBy = _sALSalesHeader.CreatedBy;
				_sALSalesHeaderWCF.CreateDate = _sALSalesHeader.CreateDate;
				_sALSalesHeaderWCF.UpdatedBy = _sALSalesHeader.UpdatedBy;
				_sALSalesHeaderWCF.UpdateDate = _sALSalesHeader.UpdateDate;
				_sALSalesHeaderWCF.IsDeleted = _sALSalesHeader.IsDeleted;
				_sALSalesHeaderWCF.DeletedBy = _sALSalesHeader.DeletedBy;
				_sALSalesHeaderWCF.DeletDate = _sALSalesHeader.DeletDate;
				_sALSalesHeaderWCF.InventoryID = _sALSalesHeader.InventoryID;
				_sALSalesHeaderWCF.FinalPrice = _sALSalesHeader.FinalPrice;
				_sALSalesHeaderWCF.ChequeNumber = _sALSalesHeader.ChequeNumber;
				
				sALSalesHeaderCollection.Add(_sALSalesHeaderWCF);
			}
			return sALSalesHeaderCollection;
		}
			/// <summary>
		/// This method will delete row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="INVInventoryPrimaryKey">Primary Key information based on which data is to be deleted.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool DeleteAllByForeignKeyInventoryID(INVInventoryPrimaryKey pk)
		{
			return POS.DataLayer.SALSalesHeaderBase.DeleteAllByForeignKeyInventoryID(new POS.DataLayer.INVInventoryPrimaryKey(pk.InventoryID));
		}
		
		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="INVInventoryPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class SALSalesHeaderCollection</returns>
		public SALSalesHeaderCollection SelectAllByForeignKeyInventoryID(INVInventoryPrimaryKey pk)
		{
			SALSalesHeaderCollection sALSalesHeaderCollection=new SALSalesHeaderCollection();
			foreach (POS.DataLayer.SALSalesHeader _sALSalesHeader in POS.DataLayer.SALSalesHeaderBase.SelectAllByForeignKeyInventoryID(new POS.DataLayer.INVInventoryPrimaryKey(pk.InventoryID)))
			{
				_sALSalesHeaderWCF = new SALSalesHeader();
				_sALSalesHeaderWCF.SalesHeaderID = _sALSalesHeader.SalesHeaderID;
				_sALSalesHeaderWCF.SalesDate = _sALSalesHeader.SalesDate;
				_sALSalesHeaderWCF.CustomerID = _sALSalesHeader.CustomerID;
				_sALSalesHeaderWCF.InvoiceNumber = _sALSalesHeader.InvoiceNumber;
				_sALSalesHeaderWCF.InvoiceDate = _sALSalesHeader.InvoiceDate;
				_sALSalesHeaderWCF.SellerID = _sALSalesHeader.SellerID;
				_sALSalesHeaderWCF.PaymentTypeID = _sALSalesHeader.PaymentTypeID;
				_sALSalesHeaderWCF.TotalPrice = _sALSalesHeader.TotalPrice;
				_sALSalesHeaderWCF.PaidAmount = _sALSalesHeader.PaidAmount;
				_sALSalesHeaderWCF.RemainingAmount = _sALSalesHeader.RemainingAmount;
				_sALSalesHeaderWCF.LastDayToPay = _sALSalesHeader.LastDayToPay;
				_sALSalesHeaderWCF.TotalDiscountAmount = _sALSalesHeader.TotalDiscountAmount;
				_sALSalesHeaderWCF.TotalDiscountRatio = _sALSalesHeader.TotalDiscountRatio;
				_sALSalesHeaderWCF.IsClosed = _sALSalesHeader.IsClosed;
				_sALSalesHeaderWCF.IsVoid = _sALSalesHeader.IsVoid;
				_sALSalesHeaderWCF.IsPrinted = _sALSalesHeader.IsPrinted;
				_sALSalesHeaderWCF.ServicePrice = _sALSalesHeader.ServicePrice;
				_sALSalesHeaderWCF.TaxTypeID = _sALSalesHeader.TaxTypeID;
				_sALSalesHeaderWCF.RefuseReasonID = _sALSalesHeader.RefuseReasonID;
				_sALSalesHeaderWCF.CreatedBy = _sALSalesHeader.CreatedBy;
				_sALSalesHeaderWCF.CreateDate = _sALSalesHeader.CreateDate;
				_sALSalesHeaderWCF.UpdatedBy = _sALSalesHeader.UpdatedBy;
				_sALSalesHeaderWCF.UpdateDate = _sALSalesHeader.UpdateDate;
				_sALSalesHeaderWCF.IsDeleted = _sALSalesHeader.IsDeleted;
				_sALSalesHeaderWCF.DeletedBy = _sALSalesHeader.DeletedBy;
				_sALSalesHeaderWCF.DeletDate = _sALSalesHeader.DeletDate;
				_sALSalesHeaderWCF.InventoryID = _sALSalesHeader.InventoryID;
				_sALSalesHeaderWCF.FinalPrice = _sALSalesHeader.FinalPrice;
				_sALSalesHeaderWCF.ChequeNumber = _sALSalesHeader.ChequeNumber;
				
				sALSalesHeaderCollection.Add(_sALSalesHeaderWCF);
			}
			return sALSalesHeaderCollection;
		}
		
		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="INVInventoryPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>object of class SALSalesHeaderCollection</returns>
		public SALSalesHeaderCollection SelectAllByForeignKeyInventoryIDPaged(INVInventoryPrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			SALSalesHeaderCollection sALSalesHeaderCollection=new SALSalesHeaderCollection();
			foreach (POS.DataLayer.SALSalesHeader _sALSalesHeader in POS.DataLayer.SALSalesHeaderBase.SelectAllByForeignKeyInventoryIDPaged(new POS.DataLayer.INVInventoryPrimaryKey(pk.InventoryID), pageSize, skipPages, orderByStatement))
			{
				_sALSalesHeaderWCF = new SALSalesHeader();
				_sALSalesHeaderWCF.SalesHeaderID = _sALSalesHeader.SalesHeaderID;
				_sALSalesHeaderWCF.SalesDate = _sALSalesHeader.SalesDate;
				_sALSalesHeaderWCF.CustomerID = _sALSalesHeader.CustomerID;
				_sALSalesHeaderWCF.InvoiceNumber = _sALSalesHeader.InvoiceNumber;
				_sALSalesHeaderWCF.InvoiceDate = _sALSalesHeader.InvoiceDate;
				_sALSalesHeaderWCF.SellerID = _sALSalesHeader.SellerID;
				_sALSalesHeaderWCF.PaymentTypeID = _sALSalesHeader.PaymentTypeID;
				_sALSalesHeaderWCF.TotalPrice = _sALSalesHeader.TotalPrice;
				_sALSalesHeaderWCF.PaidAmount = _sALSalesHeader.PaidAmount;
				_sALSalesHeaderWCF.RemainingAmount = _sALSalesHeader.RemainingAmount;
				_sALSalesHeaderWCF.LastDayToPay = _sALSalesHeader.LastDayToPay;
				_sALSalesHeaderWCF.TotalDiscountAmount = _sALSalesHeader.TotalDiscountAmount;
				_sALSalesHeaderWCF.TotalDiscountRatio = _sALSalesHeader.TotalDiscountRatio;
				_sALSalesHeaderWCF.IsClosed = _sALSalesHeader.IsClosed;
				_sALSalesHeaderWCF.IsVoid = _sALSalesHeader.IsVoid;
				_sALSalesHeaderWCF.IsPrinted = _sALSalesHeader.IsPrinted;
				_sALSalesHeaderWCF.ServicePrice = _sALSalesHeader.ServicePrice;
				_sALSalesHeaderWCF.TaxTypeID = _sALSalesHeader.TaxTypeID;
				_sALSalesHeaderWCF.RefuseReasonID = _sALSalesHeader.RefuseReasonID;
				_sALSalesHeaderWCF.CreatedBy = _sALSalesHeader.CreatedBy;
				_sALSalesHeaderWCF.CreateDate = _sALSalesHeader.CreateDate;
				_sALSalesHeaderWCF.UpdatedBy = _sALSalesHeader.UpdatedBy;
				_sALSalesHeaderWCF.UpdateDate = _sALSalesHeader.UpdateDate;
				_sALSalesHeaderWCF.IsDeleted = _sALSalesHeader.IsDeleted;
				_sALSalesHeaderWCF.DeletedBy = _sALSalesHeader.DeletedBy;
				_sALSalesHeaderWCF.DeletDate = _sALSalesHeader.DeletDate;
				_sALSalesHeaderWCF.InventoryID = _sALSalesHeader.InventoryID;
				_sALSalesHeaderWCF.FinalPrice = _sALSalesHeader.FinalPrice;
				_sALSalesHeaderWCF.ChequeNumber = _sALSalesHeader.ChequeNumber;
				
				sALSalesHeaderCollection.Add(_sALSalesHeaderWCF);
			}
			return sALSalesHeaderCollection;
		}
			/// <summary>
		/// This method will delete row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="PaymentTypePrimaryKey">Primary Key information based on which data is to be deleted.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool DeleteAllByForeignKeyPaymentTypeID(PaymentTypePrimaryKey pk)
		{
			return POS.DataLayer.SALSalesHeaderBase.DeleteAllByForeignKeyPaymentTypeID(new POS.DataLayer.PaymentTypePrimaryKey(pk.PaymentTypeID));
		}
		
		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="PaymentTypePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class SALSalesHeaderCollection</returns>
		public SALSalesHeaderCollection SelectAllByForeignKeyPaymentTypeID(PaymentTypePrimaryKey pk)
		{
			SALSalesHeaderCollection sALSalesHeaderCollection=new SALSalesHeaderCollection();
			foreach (POS.DataLayer.SALSalesHeader _sALSalesHeader in POS.DataLayer.SALSalesHeaderBase.SelectAllByForeignKeyPaymentTypeID(new POS.DataLayer.PaymentTypePrimaryKey(pk.PaymentTypeID)))
			{
				_sALSalesHeaderWCF = new SALSalesHeader();
				_sALSalesHeaderWCF.SalesHeaderID = _sALSalesHeader.SalesHeaderID;
				_sALSalesHeaderWCF.SalesDate = _sALSalesHeader.SalesDate;
				_sALSalesHeaderWCF.CustomerID = _sALSalesHeader.CustomerID;
				_sALSalesHeaderWCF.InvoiceNumber = _sALSalesHeader.InvoiceNumber;
				_sALSalesHeaderWCF.InvoiceDate = _sALSalesHeader.InvoiceDate;
				_sALSalesHeaderWCF.SellerID = _sALSalesHeader.SellerID;
				_sALSalesHeaderWCF.PaymentTypeID = _sALSalesHeader.PaymentTypeID;
				_sALSalesHeaderWCF.TotalPrice = _sALSalesHeader.TotalPrice;
				_sALSalesHeaderWCF.PaidAmount = _sALSalesHeader.PaidAmount;
				_sALSalesHeaderWCF.RemainingAmount = _sALSalesHeader.RemainingAmount;
				_sALSalesHeaderWCF.LastDayToPay = _sALSalesHeader.LastDayToPay;
				_sALSalesHeaderWCF.TotalDiscountAmount = _sALSalesHeader.TotalDiscountAmount;
				_sALSalesHeaderWCF.TotalDiscountRatio = _sALSalesHeader.TotalDiscountRatio;
				_sALSalesHeaderWCF.IsClosed = _sALSalesHeader.IsClosed;
				_sALSalesHeaderWCF.IsVoid = _sALSalesHeader.IsVoid;
				_sALSalesHeaderWCF.IsPrinted = _sALSalesHeader.IsPrinted;
				_sALSalesHeaderWCF.ServicePrice = _sALSalesHeader.ServicePrice;
				_sALSalesHeaderWCF.TaxTypeID = _sALSalesHeader.TaxTypeID;
				_sALSalesHeaderWCF.RefuseReasonID = _sALSalesHeader.RefuseReasonID;
				_sALSalesHeaderWCF.CreatedBy = _sALSalesHeader.CreatedBy;
				_sALSalesHeaderWCF.CreateDate = _sALSalesHeader.CreateDate;
				_sALSalesHeaderWCF.UpdatedBy = _sALSalesHeader.UpdatedBy;
				_sALSalesHeaderWCF.UpdateDate = _sALSalesHeader.UpdateDate;
				_sALSalesHeaderWCF.IsDeleted = _sALSalesHeader.IsDeleted;
				_sALSalesHeaderWCF.DeletedBy = _sALSalesHeader.DeletedBy;
				_sALSalesHeaderWCF.DeletDate = _sALSalesHeader.DeletDate;
				_sALSalesHeaderWCF.InventoryID = _sALSalesHeader.InventoryID;
				_sALSalesHeaderWCF.FinalPrice = _sALSalesHeader.FinalPrice;
				_sALSalesHeaderWCF.ChequeNumber = _sALSalesHeader.ChequeNumber;
				
				sALSalesHeaderCollection.Add(_sALSalesHeaderWCF);
			}
			return sALSalesHeaderCollection;
		}
		
		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="PaymentTypePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>object of class SALSalesHeaderCollection</returns>
		public SALSalesHeaderCollection SelectAllByForeignKeyPaymentTypeIDPaged(PaymentTypePrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			SALSalesHeaderCollection sALSalesHeaderCollection=new SALSalesHeaderCollection();
			foreach (POS.DataLayer.SALSalesHeader _sALSalesHeader in POS.DataLayer.SALSalesHeaderBase.SelectAllByForeignKeyPaymentTypeIDPaged(new POS.DataLayer.PaymentTypePrimaryKey(pk.PaymentTypeID), pageSize, skipPages, orderByStatement))
			{
				_sALSalesHeaderWCF = new SALSalesHeader();
				_sALSalesHeaderWCF.SalesHeaderID = _sALSalesHeader.SalesHeaderID;
				_sALSalesHeaderWCF.SalesDate = _sALSalesHeader.SalesDate;
				_sALSalesHeaderWCF.CustomerID = _sALSalesHeader.CustomerID;
				_sALSalesHeaderWCF.InvoiceNumber = _sALSalesHeader.InvoiceNumber;
				_sALSalesHeaderWCF.InvoiceDate = _sALSalesHeader.InvoiceDate;
				_sALSalesHeaderWCF.SellerID = _sALSalesHeader.SellerID;
				_sALSalesHeaderWCF.PaymentTypeID = _sALSalesHeader.PaymentTypeID;
				_sALSalesHeaderWCF.TotalPrice = _sALSalesHeader.TotalPrice;
				_sALSalesHeaderWCF.PaidAmount = _sALSalesHeader.PaidAmount;
				_sALSalesHeaderWCF.RemainingAmount = _sALSalesHeader.RemainingAmount;
				_sALSalesHeaderWCF.LastDayToPay = _sALSalesHeader.LastDayToPay;
				_sALSalesHeaderWCF.TotalDiscountAmount = _sALSalesHeader.TotalDiscountAmount;
				_sALSalesHeaderWCF.TotalDiscountRatio = _sALSalesHeader.TotalDiscountRatio;
				_sALSalesHeaderWCF.IsClosed = _sALSalesHeader.IsClosed;
				_sALSalesHeaderWCF.IsVoid = _sALSalesHeader.IsVoid;
				_sALSalesHeaderWCF.IsPrinted = _sALSalesHeader.IsPrinted;
				_sALSalesHeaderWCF.ServicePrice = _sALSalesHeader.ServicePrice;
				_sALSalesHeaderWCF.TaxTypeID = _sALSalesHeader.TaxTypeID;
				_sALSalesHeaderWCF.RefuseReasonID = _sALSalesHeader.RefuseReasonID;
				_sALSalesHeaderWCF.CreatedBy = _sALSalesHeader.CreatedBy;
				_sALSalesHeaderWCF.CreateDate = _sALSalesHeader.CreateDate;
				_sALSalesHeaderWCF.UpdatedBy = _sALSalesHeader.UpdatedBy;
				_sALSalesHeaderWCF.UpdateDate = _sALSalesHeader.UpdateDate;
				_sALSalesHeaderWCF.IsDeleted = _sALSalesHeader.IsDeleted;
				_sALSalesHeaderWCF.DeletedBy = _sALSalesHeader.DeletedBy;
				_sALSalesHeaderWCF.DeletDate = _sALSalesHeader.DeletDate;
				_sALSalesHeaderWCF.InventoryID = _sALSalesHeader.InventoryID;
				_sALSalesHeaderWCF.FinalPrice = _sALSalesHeader.FinalPrice;
				_sALSalesHeaderWCF.ChequeNumber = _sALSalesHeader.ChequeNumber;
				
				sALSalesHeaderCollection.Add(_sALSalesHeaderWCF);
			}
			return sALSalesHeaderCollection;
		}
			
		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>list of objects of class SALSalesHeader in the form of an object of class SALSalesHeaderCollection </returns>
		public SALSalesHeaderCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			SALSalesHeaderCollection sALSalesHeaderCollection = new SALSalesHeaderCollection();
			foreach (POS.DataLayer.SALSalesHeader _sALSalesHeader in POS.DataLayer.SALSalesHeaderBase.SelectAllPaged(pageSize, skipPages, orderByStatement))
			{
				_sALSalesHeaderWCF = new SALSalesHeader();
				
				_sALSalesHeaderWCF.SalesHeaderID = _sALSalesHeader.SalesHeaderID;
				_sALSalesHeaderWCF.SalesDate = _sALSalesHeader.SalesDate;
				_sALSalesHeaderWCF.CustomerID = _sALSalesHeader.CustomerID;
				_sALSalesHeaderWCF.InvoiceNumber = _sALSalesHeader.InvoiceNumber;
				_sALSalesHeaderWCF.InvoiceDate = _sALSalesHeader.InvoiceDate;
				_sALSalesHeaderWCF.SellerID = _sALSalesHeader.SellerID;
				_sALSalesHeaderWCF.PaymentTypeID = _sALSalesHeader.PaymentTypeID;
				_sALSalesHeaderWCF.TotalPrice = _sALSalesHeader.TotalPrice;
				_sALSalesHeaderWCF.PaidAmount = _sALSalesHeader.PaidAmount;
				_sALSalesHeaderWCF.RemainingAmount = _sALSalesHeader.RemainingAmount;
				_sALSalesHeaderWCF.LastDayToPay = _sALSalesHeader.LastDayToPay;
				_sALSalesHeaderWCF.TotalDiscountAmount = _sALSalesHeader.TotalDiscountAmount;
				_sALSalesHeaderWCF.TotalDiscountRatio = _sALSalesHeader.TotalDiscountRatio;
				_sALSalesHeaderWCF.IsClosed = _sALSalesHeader.IsClosed;
				_sALSalesHeaderWCF.IsVoid = _sALSalesHeader.IsVoid;
				_sALSalesHeaderWCF.IsPrinted = _sALSalesHeader.IsPrinted;
				_sALSalesHeaderWCF.ServicePrice = _sALSalesHeader.ServicePrice;
				_sALSalesHeaderWCF.TaxTypeID = _sALSalesHeader.TaxTypeID;
				_sALSalesHeaderWCF.RefuseReasonID = _sALSalesHeader.RefuseReasonID;
				_sALSalesHeaderWCF.CreatedBy = _sALSalesHeader.CreatedBy;
				_sALSalesHeaderWCF.CreateDate = _sALSalesHeader.CreateDate;
				_sALSalesHeaderWCF.UpdatedBy = _sALSalesHeader.UpdatedBy;
				_sALSalesHeaderWCF.UpdateDate = _sALSalesHeader.UpdateDate;
				_sALSalesHeaderWCF.IsDeleted = _sALSalesHeader.IsDeleted;
				_sALSalesHeaderWCF.DeletedBy = _sALSalesHeader.DeletedBy;
				_sALSalesHeaderWCF.DeletDate = _sALSalesHeader.DeletDate;
				_sALSalesHeaderWCF.InventoryID = _sALSalesHeader.InventoryID;
				_sALSalesHeaderWCF.FinalPrice = _sALSalesHeader.FinalPrice;
				_sALSalesHeaderWCF.ChequeNumber = _sALSalesHeader.ChequeNumber;
				
				sALSalesHeaderCollection.Add(_sALSalesHeaderWCF);
			}
			return sALSalesHeaderCollection;
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class SALSalesHeader</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class SALSalesHeader in the form of an object of class SALSalesHeaderCollection</returns>
		public SALSalesHeaderCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
		{
			SALSalesHeaderCollection sALSalesHeaderCollection = new SALSalesHeaderCollection();
			foreach (POS.DataLayer.SALSalesHeader _sALSalesHeader in POS.DataLayer.SALSalesHeaderBase.SelectByFieldPaged(field, fieldValue, fieldValue2, typeOperation, pageSize, skipPages, orderByStatement))
			{
				_sALSalesHeaderWCF = new SALSalesHeader();
				
				_sALSalesHeaderWCF.SalesHeaderID = _sALSalesHeader.SalesHeaderID;
				_sALSalesHeaderWCF.SalesDate = _sALSalesHeader.SalesDate;
				_sALSalesHeaderWCF.CustomerID = _sALSalesHeader.CustomerID;
				_sALSalesHeaderWCF.InvoiceNumber = _sALSalesHeader.InvoiceNumber;
				_sALSalesHeaderWCF.InvoiceDate = _sALSalesHeader.InvoiceDate;
				_sALSalesHeaderWCF.SellerID = _sALSalesHeader.SellerID;
				_sALSalesHeaderWCF.PaymentTypeID = _sALSalesHeader.PaymentTypeID;
				_sALSalesHeaderWCF.TotalPrice = _sALSalesHeader.TotalPrice;
				_sALSalesHeaderWCF.PaidAmount = _sALSalesHeader.PaidAmount;
				_sALSalesHeaderWCF.RemainingAmount = _sALSalesHeader.RemainingAmount;
				_sALSalesHeaderWCF.LastDayToPay = _sALSalesHeader.LastDayToPay;
				_sALSalesHeaderWCF.TotalDiscountAmount = _sALSalesHeader.TotalDiscountAmount;
				_sALSalesHeaderWCF.TotalDiscountRatio = _sALSalesHeader.TotalDiscountRatio;
				_sALSalesHeaderWCF.IsClosed = _sALSalesHeader.IsClosed;
				_sALSalesHeaderWCF.IsVoid = _sALSalesHeader.IsVoid;
				_sALSalesHeaderWCF.IsPrinted = _sALSalesHeader.IsPrinted;
				_sALSalesHeaderWCF.ServicePrice = _sALSalesHeader.ServicePrice;
				_sALSalesHeaderWCF.TaxTypeID = _sALSalesHeader.TaxTypeID;
				_sALSalesHeaderWCF.RefuseReasonID = _sALSalesHeader.RefuseReasonID;
				_sALSalesHeaderWCF.CreatedBy = _sALSalesHeader.CreatedBy;
				_sALSalesHeaderWCF.CreateDate = _sALSalesHeader.CreateDate;
				_sALSalesHeaderWCF.UpdatedBy = _sALSalesHeader.UpdatedBy;
				_sALSalesHeaderWCF.UpdateDate = _sALSalesHeader.UpdateDate;
				_sALSalesHeaderWCF.IsDeleted = _sALSalesHeader.IsDeleted;
				_sALSalesHeaderWCF.DeletedBy = _sALSalesHeader.DeletedBy;
				_sALSalesHeaderWCF.DeletDate = _sALSalesHeader.DeletDate;
				_sALSalesHeaderWCF.InventoryID = _sALSalesHeader.InventoryID;
				_sALSalesHeaderWCF.FinalPrice = _sALSalesHeader.FinalPrice;
				_sALSalesHeaderWCF.ChequeNumber = _sALSalesHeader.ChequeNumber;
				
				sALSalesHeaderCollection.Add(_sALSalesHeaderWCF);
			}
			return sALSalesHeaderCollection;
		}
			///<summary>
		/// This method will update one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="sALSalesHeader" type="SALSalesHeader">This SALSalesHeader  will be updated in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Update(SALSalesHeader sALSalesHeader)
		{
			_sALSalesHeader=POS.DataLayer.SALSalesHeader.SelectOne(new POS.DataLayer.SALSalesHeaderPrimaryKey(sALSalesHeader.SalesHeaderID));
			
			_sALSalesHeader.SalesDate=sALSalesHeader.SalesDate;
			_sALSalesHeader.CustomerID=sALSalesHeader.CustomerID;
			_sALSalesHeader.InvoiceNumber=sALSalesHeader.InvoiceNumber;
			_sALSalesHeader.InvoiceDate=sALSalesHeader.InvoiceDate;
			_sALSalesHeader.SellerID=sALSalesHeader.SellerID;
			_sALSalesHeader.PaymentTypeID=sALSalesHeader.PaymentTypeID;
			_sALSalesHeader.TotalPrice=sALSalesHeader.TotalPrice;
			_sALSalesHeader.PaidAmount=sALSalesHeader.PaidAmount;
			_sALSalesHeader.RemainingAmount=sALSalesHeader.RemainingAmount;
			_sALSalesHeader.LastDayToPay=sALSalesHeader.LastDayToPay;
			_sALSalesHeader.TotalDiscountAmount=sALSalesHeader.TotalDiscountAmount;
			_sALSalesHeader.TotalDiscountRatio=sALSalesHeader.TotalDiscountRatio;
			_sALSalesHeader.IsClosed=sALSalesHeader.IsClosed;
			_sALSalesHeader.IsVoid=sALSalesHeader.IsVoid;
			_sALSalesHeader.IsPrinted=sALSalesHeader.IsPrinted;
			_sALSalesHeader.ServicePrice=sALSalesHeader.ServicePrice;
			_sALSalesHeader.TaxTypeID=sALSalesHeader.TaxTypeID;
			_sALSalesHeader.RefuseReasonID=sALSalesHeader.RefuseReasonID;
			_sALSalesHeader.CreatedBy=sALSalesHeader.CreatedBy;
			_sALSalesHeader.CreateDate=sALSalesHeader.CreateDate;
			_sALSalesHeader.UpdatedBy=sALSalesHeader.UpdatedBy;
			_sALSalesHeader.UpdateDate=sALSalesHeader.UpdateDate;
			_sALSalesHeader.IsDeleted=sALSalesHeader.IsDeleted;
			_sALSalesHeader.DeletedBy=sALSalesHeader.DeletedBy;
			_sALSalesHeader.DeletDate=sALSalesHeader.DeletDate;
			_sALSalesHeader.InventoryID=sALSalesHeader.InventoryID;
			_sALSalesHeader.FinalPrice=sALSalesHeader.FinalPrice;
			_sALSalesHeader.ChequeNumber=sALSalesHeader.ChequeNumber;
			
			return _sALSalesHeader.Update();
		}
	} 
}
