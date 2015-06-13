//
// Class	:	BDCustomerAccountServices.svc.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	6/13/2015 10:16:23 AM
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
	///WCF service for the BDCustomerAccount
	///</summary>
	public class BDCustomerAccountService 
	{
		private BDCustomerAccount _bDCustomerAccountWCF;
		private POS.DataLayer.BDCustomerAccount _bDCustomerAccount;
		
		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="BDCustomerAccountFields">Field of the class BDCustomerAccount</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <returns>True if succeeded</returns>
		public bool DeleteByField(string field, object fieldValue)
		{
			return POS.DataLayer.BDCustomerAccountBase.DeleteByField(field, fieldValue);
		}

		///<summary>
		///This method will Delete the object from the database
		///</summary>
		///<param name="pk" type="BDCustomerAccountPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <returns>True if succeeded</returns>
		public bool Delete(BDCustomerAccountPrimaryKey pk)
		{
			return POS.DataLayer.BDCustomerAccountBase.Delete(new POS.DataLayer.BDCustomerAccountPrimaryKey(pk.CustomerAccountNumber));
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="BDCustomerAccountPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class BDCustomerAccount</returns>
		public BDCustomerAccount SelectOne(BDCustomerAccountPrimaryKey pk)
		{
			_bDCustomerAccountWCF = new BDCustomerAccount();
			_bDCustomerAccount = POS.DataLayer.BDCustomerAccountBase.SelectOne(new POS.DataLayer.BDCustomerAccountPrimaryKey(pk.CustomerAccountNumber));
			
				_bDCustomerAccountWCF.CustomerAccountNumber = _bDCustomerAccount.CustomerAccountNumber;
				_bDCustomerAccountWCF.CustomerID = _bDCustomerAccount.CustomerID;
				_bDCustomerAccountWCF.SalesInvoiceId = _bDCustomerAccount.SalesInvoiceId;
				_bDCustomerAccountWCF.SalesDate = _bDCustomerAccount.SalesDate;
				_bDCustomerAccountWCF.InvoiceNumber = _bDCustomerAccount.InvoiceNumber;
				_bDCustomerAccountWCF.TotalPrice = _bDCustomerAccount.TotalPrice;
				_bDCustomerAccountWCF.PaidAmount = _bDCustomerAccount.PaidAmount;
				_bDCustomerAccountWCF.RemainingAmount = _bDCustomerAccount.RemainingAmount;
				_bDCustomerAccountWCF.IsVoid = _bDCustomerAccount.IsVoid;
				_bDCustomerAccountWCF.CreatedBy = _bDCustomerAccount.CreatedBy;
				_bDCustomerAccountWCF.CreateDate = _bDCustomerAccount.CreateDate;
				_bDCustomerAccountWCF.UpdatedBy = _bDCustomerAccount.UpdatedBy;
				_bDCustomerAccountWCF.UpdateDate = _bDCustomerAccount.UpdateDate;
				_bDCustomerAccountWCF.IsDeleted = _bDCustomerAccount.IsDeleted;
				_bDCustomerAccountWCF.DeletedBy = _bDCustomerAccount.DeletedBy;
				_bDCustomerAccountWCF.DeletedDate = _bDCustomerAccount.DeletedDate;
				_bDCustomerAccountWCF.Depit = _bDCustomerAccount.Depit;
				_bDCustomerAccountWCF.Credit = _bDCustomerAccount.Credit;
				_bDCustomerAccountWCF.ChequeNumber = _bDCustomerAccount.ChequeNumber;
				_bDCustomerAccountWCF.InvoiceType = _bDCustomerAccount.InvoiceType;
				_bDCustomerAccountWCF.LstDayToPay = _bDCustomerAccount.LstDayToPay;
				
			return _bDCustomerAccountWCF;
		}

		/// <summary>
		/// This method will return a list of objects representing all records in the table.
		/// </summary>
		///
		/// <returns>list of objects of class BDCustomerAccount in the form of object of BDCustomerAccountCollection </returns>
		public BDCustomerAccountCollection SelectAll()
		{
			BDCustomerAccountCollection bDCustomerAccountCollection = new BDCustomerAccountCollection();
			foreach (POS.DataLayer.BDCustomerAccount _bDCustomerAccount in POS.DataLayer.BDCustomerAccountBase.SelectAll())
			{
				_bDCustomerAccountWCF = new BDCustomerAccount();
				
				_bDCustomerAccountWCF.CustomerAccountNumber = _bDCustomerAccount.CustomerAccountNumber;
				_bDCustomerAccountWCF.CustomerID = _bDCustomerAccount.CustomerID;
				_bDCustomerAccountWCF.SalesInvoiceId = _bDCustomerAccount.SalesInvoiceId;
				_bDCustomerAccountWCF.SalesDate = _bDCustomerAccount.SalesDate;
				_bDCustomerAccountWCF.InvoiceNumber = _bDCustomerAccount.InvoiceNumber;
				_bDCustomerAccountWCF.TotalPrice = _bDCustomerAccount.TotalPrice;
				_bDCustomerAccountWCF.PaidAmount = _bDCustomerAccount.PaidAmount;
				_bDCustomerAccountWCF.RemainingAmount = _bDCustomerAccount.RemainingAmount;
				_bDCustomerAccountWCF.IsVoid = _bDCustomerAccount.IsVoid;
				_bDCustomerAccountWCF.CreatedBy = _bDCustomerAccount.CreatedBy;
				_bDCustomerAccountWCF.CreateDate = _bDCustomerAccount.CreateDate;
				_bDCustomerAccountWCF.UpdatedBy = _bDCustomerAccount.UpdatedBy;
				_bDCustomerAccountWCF.UpdateDate = _bDCustomerAccount.UpdateDate;
				_bDCustomerAccountWCF.IsDeleted = _bDCustomerAccount.IsDeleted;
				_bDCustomerAccountWCF.DeletedBy = _bDCustomerAccount.DeletedBy;
				_bDCustomerAccountWCF.DeletedDate = _bDCustomerAccount.DeletedDate;
				_bDCustomerAccountWCF.Depit = _bDCustomerAccount.Depit;
				_bDCustomerAccountWCF.Credit = _bDCustomerAccount.Credit;
				_bDCustomerAccountWCF.ChequeNumber = _bDCustomerAccount.ChequeNumber;
				_bDCustomerAccountWCF.InvoiceType = _bDCustomerAccount.InvoiceType;
				_bDCustomerAccountWCF.LstDayToPay = _bDCustomerAccount.LstDayToPay;
				
				bDCustomerAccountCollection.Add(_bDCustomerAccountWCF);
			}
			return bDCustomerAccountCollection;
		}
    
    /// <summary>
		/// This method will return a count all records in the table.
		/// </summary>
		///
		/// <returns>count records</returns>
		public int SelectAllCount()
		{
			return POS.DataLayer.BDCustomerAccountBase.SelectAllCount();			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class BDCustomerAccount</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class BDCustomerAccount in the form of an object of class BDCustomerAccountCollection</returns>
		public BDCustomerAccountCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
		{
			BDCustomerAccountCollection bDCustomerAccountCollection = new BDCustomerAccountCollection();
			foreach (POS.DataLayer.BDCustomerAccount _bDCustomerAccount in POS.DataLayer.BDCustomerAccountBase.SelectByField(field, fieldValue, fieldValue2, typeOperation))
			{
				_bDCustomerAccountWCF = new BDCustomerAccount();
				
				_bDCustomerAccountWCF.CustomerAccountNumber = _bDCustomerAccount.CustomerAccountNumber;
				_bDCustomerAccountWCF.CustomerID = _bDCustomerAccount.CustomerID;
				_bDCustomerAccountWCF.SalesInvoiceId = _bDCustomerAccount.SalesInvoiceId;
				_bDCustomerAccountWCF.SalesDate = _bDCustomerAccount.SalesDate;
				_bDCustomerAccountWCF.InvoiceNumber = _bDCustomerAccount.InvoiceNumber;
				_bDCustomerAccountWCF.TotalPrice = _bDCustomerAccount.TotalPrice;
				_bDCustomerAccountWCF.PaidAmount = _bDCustomerAccount.PaidAmount;
				_bDCustomerAccountWCF.RemainingAmount = _bDCustomerAccount.RemainingAmount;
				_bDCustomerAccountWCF.IsVoid = _bDCustomerAccount.IsVoid;
				_bDCustomerAccountWCF.CreatedBy = _bDCustomerAccount.CreatedBy;
				_bDCustomerAccountWCF.CreateDate = _bDCustomerAccount.CreateDate;
				_bDCustomerAccountWCF.UpdatedBy = _bDCustomerAccount.UpdatedBy;
				_bDCustomerAccountWCF.UpdateDate = _bDCustomerAccount.UpdateDate;
				_bDCustomerAccountWCF.IsDeleted = _bDCustomerAccount.IsDeleted;
				_bDCustomerAccountWCF.DeletedBy = _bDCustomerAccount.DeletedBy;
				_bDCustomerAccountWCF.DeletedDate = _bDCustomerAccount.DeletedDate;
				_bDCustomerAccountWCF.Depit = _bDCustomerAccount.Depit;
				_bDCustomerAccountWCF.Credit = _bDCustomerAccount.Credit;
				_bDCustomerAccountWCF.ChequeNumber = _bDCustomerAccount.ChequeNumber;
				_bDCustomerAccountWCF.InvoiceType = _bDCustomerAccount.InvoiceType;
				_bDCustomerAccountWCF.LstDayToPay = _bDCustomerAccount.LstDayToPay;
				
				bDCustomerAccountCollection.Add(_bDCustomerAccountWCF);
			}
			return bDCustomerAccountCollection;
		}
		
		/// <summary>
		/// This method will insert one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="bDCustomerAccount" type="BDCustomerAccount">This BDCustomerAccount  will be inserted in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Insert(BDCustomerAccount bDCustomerAccount)
		{
			_bDCustomerAccount = new POS.DataLayer.BDCustomerAccount();
			_bDCustomerAccount.CustomerAccountNumber=bDCustomerAccount.CustomerAccountNumber;
			_bDCustomerAccount.CustomerID=bDCustomerAccount.CustomerID;
			_bDCustomerAccount.SalesInvoiceId=bDCustomerAccount.SalesInvoiceId;
			_bDCustomerAccount.SalesDate=bDCustomerAccount.SalesDate;
			_bDCustomerAccount.InvoiceNumber=bDCustomerAccount.InvoiceNumber;
			_bDCustomerAccount.TotalPrice=bDCustomerAccount.TotalPrice;
			_bDCustomerAccount.PaidAmount=bDCustomerAccount.PaidAmount;
			_bDCustomerAccount.RemainingAmount=bDCustomerAccount.RemainingAmount;
			_bDCustomerAccount.IsVoid=bDCustomerAccount.IsVoid;
			_bDCustomerAccount.CreatedBy=bDCustomerAccount.CreatedBy;
			_bDCustomerAccount.CreateDate=bDCustomerAccount.CreateDate;
			_bDCustomerAccount.UpdatedBy=bDCustomerAccount.UpdatedBy;
			_bDCustomerAccount.UpdateDate=bDCustomerAccount.UpdateDate;
			_bDCustomerAccount.IsDeleted=bDCustomerAccount.IsDeleted;
			_bDCustomerAccount.DeletedBy=bDCustomerAccount.DeletedBy;
			_bDCustomerAccount.DeletedDate=bDCustomerAccount.DeletedDate;
			_bDCustomerAccount.Depit=bDCustomerAccount.Depit;
			_bDCustomerAccount.Credit=bDCustomerAccount.Credit;
			_bDCustomerAccount.ChequeNumber=bDCustomerAccount.ChequeNumber;
			_bDCustomerAccount.InvoiceType=bDCustomerAccount.InvoiceType;
			_bDCustomerAccount.LstDayToPay=bDCustomerAccount.LstDayToPay;
			
			return _bDCustomerAccount.Insert();
		}
		/// <summary>
		/// This method will delete row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="ADUserPrimaryKey">Primary Key information based on which data is to be deleted.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool DeleteAllByForeignKeyCreatedBy(ADUserPrimaryKey pk)
		{
			return POS.DataLayer.BDCustomerAccountBase.DeleteAllByForeignKeyCreatedBy(new POS.DataLayer.ADUserPrimaryKey(pk.UserID));
		}
		
		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="ADUserPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class BDCustomerAccountCollection</returns>
		public BDCustomerAccountCollection SelectAllByForeignKeyCreatedBy(ADUserPrimaryKey pk)
		{
			BDCustomerAccountCollection bDCustomerAccountCollection=new BDCustomerAccountCollection();
			foreach (POS.DataLayer.BDCustomerAccount _bDCustomerAccount in POS.DataLayer.BDCustomerAccountBase.SelectAllByForeignKeyCreatedBy(new POS.DataLayer.ADUserPrimaryKey(pk.UserID)))
			{
				_bDCustomerAccountWCF = new BDCustomerAccount();
				_bDCustomerAccountWCF.CustomerAccountNumber = _bDCustomerAccount.CustomerAccountNumber;
				_bDCustomerAccountWCF.CustomerID = _bDCustomerAccount.CustomerID;
				_bDCustomerAccountWCF.SalesInvoiceId = _bDCustomerAccount.SalesInvoiceId;
				_bDCustomerAccountWCF.SalesDate = _bDCustomerAccount.SalesDate;
				_bDCustomerAccountWCF.InvoiceNumber = _bDCustomerAccount.InvoiceNumber;
				_bDCustomerAccountWCF.TotalPrice = _bDCustomerAccount.TotalPrice;
				_bDCustomerAccountWCF.PaidAmount = _bDCustomerAccount.PaidAmount;
				_bDCustomerAccountWCF.RemainingAmount = _bDCustomerAccount.RemainingAmount;
				_bDCustomerAccountWCF.IsVoid = _bDCustomerAccount.IsVoid;
				_bDCustomerAccountWCF.CreatedBy = _bDCustomerAccount.CreatedBy;
				_bDCustomerAccountWCF.CreateDate = _bDCustomerAccount.CreateDate;
				_bDCustomerAccountWCF.UpdatedBy = _bDCustomerAccount.UpdatedBy;
				_bDCustomerAccountWCF.UpdateDate = _bDCustomerAccount.UpdateDate;
				_bDCustomerAccountWCF.IsDeleted = _bDCustomerAccount.IsDeleted;
				_bDCustomerAccountWCF.DeletedBy = _bDCustomerAccount.DeletedBy;
				_bDCustomerAccountWCF.DeletedDate = _bDCustomerAccount.DeletedDate;
				_bDCustomerAccountWCF.Depit = _bDCustomerAccount.Depit;
				_bDCustomerAccountWCF.Credit = _bDCustomerAccount.Credit;
				_bDCustomerAccountWCF.ChequeNumber = _bDCustomerAccount.ChequeNumber;
				_bDCustomerAccountWCF.InvoiceType = _bDCustomerAccount.InvoiceType;
				_bDCustomerAccountWCF.LstDayToPay = _bDCustomerAccount.LstDayToPay;
				
				bDCustomerAccountCollection.Add(_bDCustomerAccountWCF);
			}
			return bDCustomerAccountCollection;
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
		/// <returns>object of class BDCustomerAccountCollection</returns>
		public BDCustomerAccountCollection SelectAllByForeignKeyCreatedByPaged(ADUserPrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			BDCustomerAccountCollection bDCustomerAccountCollection=new BDCustomerAccountCollection();
			foreach (POS.DataLayer.BDCustomerAccount _bDCustomerAccount in POS.DataLayer.BDCustomerAccountBase.SelectAllByForeignKeyCreatedByPaged(new POS.DataLayer.ADUserPrimaryKey(pk.UserID), pageSize, skipPages, orderByStatement))
			{
				_bDCustomerAccountWCF = new BDCustomerAccount();
				_bDCustomerAccountWCF.CustomerAccountNumber = _bDCustomerAccount.CustomerAccountNumber;
				_bDCustomerAccountWCF.CustomerID = _bDCustomerAccount.CustomerID;
				_bDCustomerAccountWCF.SalesInvoiceId = _bDCustomerAccount.SalesInvoiceId;
				_bDCustomerAccountWCF.SalesDate = _bDCustomerAccount.SalesDate;
				_bDCustomerAccountWCF.InvoiceNumber = _bDCustomerAccount.InvoiceNumber;
				_bDCustomerAccountWCF.TotalPrice = _bDCustomerAccount.TotalPrice;
				_bDCustomerAccountWCF.PaidAmount = _bDCustomerAccount.PaidAmount;
				_bDCustomerAccountWCF.RemainingAmount = _bDCustomerAccount.RemainingAmount;
				_bDCustomerAccountWCF.IsVoid = _bDCustomerAccount.IsVoid;
				_bDCustomerAccountWCF.CreatedBy = _bDCustomerAccount.CreatedBy;
				_bDCustomerAccountWCF.CreateDate = _bDCustomerAccount.CreateDate;
				_bDCustomerAccountWCF.UpdatedBy = _bDCustomerAccount.UpdatedBy;
				_bDCustomerAccountWCF.UpdateDate = _bDCustomerAccount.UpdateDate;
				_bDCustomerAccountWCF.IsDeleted = _bDCustomerAccount.IsDeleted;
				_bDCustomerAccountWCF.DeletedBy = _bDCustomerAccount.DeletedBy;
				_bDCustomerAccountWCF.DeletedDate = _bDCustomerAccount.DeletedDate;
				_bDCustomerAccountWCF.Depit = _bDCustomerAccount.Depit;
				_bDCustomerAccountWCF.Credit = _bDCustomerAccount.Credit;
				_bDCustomerAccountWCF.ChequeNumber = _bDCustomerAccount.ChequeNumber;
				_bDCustomerAccountWCF.InvoiceType = _bDCustomerAccount.InvoiceType;
				_bDCustomerAccountWCF.LstDayToPay = _bDCustomerAccount.LstDayToPay;
				
				bDCustomerAccountCollection.Add(_bDCustomerAccountWCF);
			}
			return bDCustomerAccountCollection;
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
			return POS.DataLayer.BDCustomerAccountBase.DeleteAllByForeignKeyCustomerID(new POS.DataLayer.BDCustomerPrimaryKey(pk.CustomerID));
		}
		
		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="BDCustomerPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class BDCustomerAccountCollection</returns>
		public BDCustomerAccountCollection SelectAllByForeignKeyCustomerID(BDCustomerPrimaryKey pk)
		{
			BDCustomerAccountCollection bDCustomerAccountCollection=new BDCustomerAccountCollection();
			foreach (POS.DataLayer.BDCustomerAccount _bDCustomerAccount in POS.DataLayer.BDCustomerAccountBase.SelectAllByForeignKeyCustomerID(new POS.DataLayer.BDCustomerPrimaryKey(pk.CustomerID)))
			{
				_bDCustomerAccountWCF = new BDCustomerAccount();
				_bDCustomerAccountWCF.CustomerAccountNumber = _bDCustomerAccount.CustomerAccountNumber;
				_bDCustomerAccountWCF.CustomerID = _bDCustomerAccount.CustomerID;
				_bDCustomerAccountWCF.SalesInvoiceId = _bDCustomerAccount.SalesInvoiceId;
				_bDCustomerAccountWCF.SalesDate = _bDCustomerAccount.SalesDate;
				_bDCustomerAccountWCF.InvoiceNumber = _bDCustomerAccount.InvoiceNumber;
				_bDCustomerAccountWCF.TotalPrice = _bDCustomerAccount.TotalPrice;
				_bDCustomerAccountWCF.PaidAmount = _bDCustomerAccount.PaidAmount;
				_bDCustomerAccountWCF.RemainingAmount = _bDCustomerAccount.RemainingAmount;
				_bDCustomerAccountWCF.IsVoid = _bDCustomerAccount.IsVoid;
				_bDCustomerAccountWCF.CreatedBy = _bDCustomerAccount.CreatedBy;
				_bDCustomerAccountWCF.CreateDate = _bDCustomerAccount.CreateDate;
				_bDCustomerAccountWCF.UpdatedBy = _bDCustomerAccount.UpdatedBy;
				_bDCustomerAccountWCF.UpdateDate = _bDCustomerAccount.UpdateDate;
				_bDCustomerAccountWCF.IsDeleted = _bDCustomerAccount.IsDeleted;
				_bDCustomerAccountWCF.DeletedBy = _bDCustomerAccount.DeletedBy;
				_bDCustomerAccountWCF.DeletedDate = _bDCustomerAccount.DeletedDate;
				_bDCustomerAccountWCF.Depit = _bDCustomerAccount.Depit;
				_bDCustomerAccountWCF.Credit = _bDCustomerAccount.Credit;
				_bDCustomerAccountWCF.ChequeNumber = _bDCustomerAccount.ChequeNumber;
				_bDCustomerAccountWCF.InvoiceType = _bDCustomerAccount.InvoiceType;
				_bDCustomerAccountWCF.LstDayToPay = _bDCustomerAccount.LstDayToPay;
				
				bDCustomerAccountCollection.Add(_bDCustomerAccountWCF);
			}
			return bDCustomerAccountCollection;
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
		/// <returns>object of class BDCustomerAccountCollection</returns>
		public BDCustomerAccountCollection SelectAllByForeignKeyCustomerIDPaged(BDCustomerPrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			BDCustomerAccountCollection bDCustomerAccountCollection=new BDCustomerAccountCollection();
			foreach (POS.DataLayer.BDCustomerAccount _bDCustomerAccount in POS.DataLayer.BDCustomerAccountBase.SelectAllByForeignKeyCustomerIDPaged(new POS.DataLayer.BDCustomerPrimaryKey(pk.CustomerID), pageSize, skipPages, orderByStatement))
			{
				_bDCustomerAccountWCF = new BDCustomerAccount();
				_bDCustomerAccountWCF.CustomerAccountNumber = _bDCustomerAccount.CustomerAccountNumber;
				_bDCustomerAccountWCF.CustomerID = _bDCustomerAccount.CustomerID;
				_bDCustomerAccountWCF.SalesInvoiceId = _bDCustomerAccount.SalesInvoiceId;
				_bDCustomerAccountWCF.SalesDate = _bDCustomerAccount.SalesDate;
				_bDCustomerAccountWCF.InvoiceNumber = _bDCustomerAccount.InvoiceNumber;
				_bDCustomerAccountWCF.TotalPrice = _bDCustomerAccount.TotalPrice;
				_bDCustomerAccountWCF.PaidAmount = _bDCustomerAccount.PaidAmount;
				_bDCustomerAccountWCF.RemainingAmount = _bDCustomerAccount.RemainingAmount;
				_bDCustomerAccountWCF.IsVoid = _bDCustomerAccount.IsVoid;
				_bDCustomerAccountWCF.CreatedBy = _bDCustomerAccount.CreatedBy;
				_bDCustomerAccountWCF.CreateDate = _bDCustomerAccount.CreateDate;
				_bDCustomerAccountWCF.UpdatedBy = _bDCustomerAccount.UpdatedBy;
				_bDCustomerAccountWCF.UpdateDate = _bDCustomerAccount.UpdateDate;
				_bDCustomerAccountWCF.IsDeleted = _bDCustomerAccount.IsDeleted;
				_bDCustomerAccountWCF.DeletedBy = _bDCustomerAccount.DeletedBy;
				_bDCustomerAccountWCF.DeletedDate = _bDCustomerAccount.DeletedDate;
				_bDCustomerAccountWCF.Depit = _bDCustomerAccount.Depit;
				_bDCustomerAccountWCF.Credit = _bDCustomerAccount.Credit;
				_bDCustomerAccountWCF.ChequeNumber = _bDCustomerAccount.ChequeNumber;
				_bDCustomerAccountWCF.InvoiceType = _bDCustomerAccount.InvoiceType;
				_bDCustomerAccountWCF.LstDayToPay = _bDCustomerAccount.LstDayToPay;
				
				bDCustomerAccountCollection.Add(_bDCustomerAccountWCF);
			}
			return bDCustomerAccountCollection;
		}
			/// <summary>
		/// This method will delete row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="SALSalesHeaderPrimaryKey">Primary Key information based on which data is to be deleted.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool DeleteAllByForeignKeySalesInvoiceId(SALSalesHeaderPrimaryKey pk)
		{
			return POS.DataLayer.BDCustomerAccountBase.DeleteAllByForeignKeySalesInvoiceId(new POS.DataLayer.SALSalesHeaderPrimaryKey(pk.SalesHeaderID));
		}
		
		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="SALSalesHeaderPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class BDCustomerAccountCollection</returns>
		public BDCustomerAccountCollection SelectAllByForeignKeySalesInvoiceId(SALSalesHeaderPrimaryKey pk)
		{
			BDCustomerAccountCollection bDCustomerAccountCollection=new BDCustomerAccountCollection();
			foreach (POS.DataLayer.BDCustomerAccount _bDCustomerAccount in POS.DataLayer.BDCustomerAccountBase.SelectAllByForeignKeySalesInvoiceId(new POS.DataLayer.SALSalesHeaderPrimaryKey(pk.SalesHeaderID)))
			{
				_bDCustomerAccountWCF = new BDCustomerAccount();
				_bDCustomerAccountWCF.CustomerAccountNumber = _bDCustomerAccount.CustomerAccountNumber;
				_bDCustomerAccountWCF.CustomerID = _bDCustomerAccount.CustomerID;
				_bDCustomerAccountWCF.SalesInvoiceId = _bDCustomerAccount.SalesInvoiceId;
				_bDCustomerAccountWCF.SalesDate = _bDCustomerAccount.SalesDate;
				_bDCustomerAccountWCF.InvoiceNumber = _bDCustomerAccount.InvoiceNumber;
				_bDCustomerAccountWCF.TotalPrice = _bDCustomerAccount.TotalPrice;
				_bDCustomerAccountWCF.PaidAmount = _bDCustomerAccount.PaidAmount;
				_bDCustomerAccountWCF.RemainingAmount = _bDCustomerAccount.RemainingAmount;
				_bDCustomerAccountWCF.IsVoid = _bDCustomerAccount.IsVoid;
				_bDCustomerAccountWCF.CreatedBy = _bDCustomerAccount.CreatedBy;
				_bDCustomerAccountWCF.CreateDate = _bDCustomerAccount.CreateDate;
				_bDCustomerAccountWCF.UpdatedBy = _bDCustomerAccount.UpdatedBy;
				_bDCustomerAccountWCF.UpdateDate = _bDCustomerAccount.UpdateDate;
				_bDCustomerAccountWCF.IsDeleted = _bDCustomerAccount.IsDeleted;
				_bDCustomerAccountWCF.DeletedBy = _bDCustomerAccount.DeletedBy;
				_bDCustomerAccountWCF.DeletedDate = _bDCustomerAccount.DeletedDate;
				_bDCustomerAccountWCF.Depit = _bDCustomerAccount.Depit;
				_bDCustomerAccountWCF.Credit = _bDCustomerAccount.Credit;
				_bDCustomerAccountWCF.ChequeNumber = _bDCustomerAccount.ChequeNumber;
				_bDCustomerAccountWCF.InvoiceType = _bDCustomerAccount.InvoiceType;
				_bDCustomerAccountWCF.LstDayToPay = _bDCustomerAccount.LstDayToPay;
				
				bDCustomerAccountCollection.Add(_bDCustomerAccountWCF);
			}
			return bDCustomerAccountCollection;
		}
		
		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="SALSalesHeaderPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>object of class BDCustomerAccountCollection</returns>
		public BDCustomerAccountCollection SelectAllByForeignKeySalesInvoiceIdPaged(SALSalesHeaderPrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			BDCustomerAccountCollection bDCustomerAccountCollection=new BDCustomerAccountCollection();
			foreach (POS.DataLayer.BDCustomerAccount _bDCustomerAccount in POS.DataLayer.BDCustomerAccountBase.SelectAllByForeignKeySalesInvoiceIdPaged(new POS.DataLayer.SALSalesHeaderPrimaryKey(pk.SalesHeaderID), pageSize, skipPages, orderByStatement))
			{
				_bDCustomerAccountWCF = new BDCustomerAccount();
				_bDCustomerAccountWCF.CustomerAccountNumber = _bDCustomerAccount.CustomerAccountNumber;
				_bDCustomerAccountWCF.CustomerID = _bDCustomerAccount.CustomerID;
				_bDCustomerAccountWCF.SalesInvoiceId = _bDCustomerAccount.SalesInvoiceId;
				_bDCustomerAccountWCF.SalesDate = _bDCustomerAccount.SalesDate;
				_bDCustomerAccountWCF.InvoiceNumber = _bDCustomerAccount.InvoiceNumber;
				_bDCustomerAccountWCF.TotalPrice = _bDCustomerAccount.TotalPrice;
				_bDCustomerAccountWCF.PaidAmount = _bDCustomerAccount.PaidAmount;
				_bDCustomerAccountWCF.RemainingAmount = _bDCustomerAccount.RemainingAmount;
				_bDCustomerAccountWCF.IsVoid = _bDCustomerAccount.IsVoid;
				_bDCustomerAccountWCF.CreatedBy = _bDCustomerAccount.CreatedBy;
				_bDCustomerAccountWCF.CreateDate = _bDCustomerAccount.CreateDate;
				_bDCustomerAccountWCF.UpdatedBy = _bDCustomerAccount.UpdatedBy;
				_bDCustomerAccountWCF.UpdateDate = _bDCustomerAccount.UpdateDate;
				_bDCustomerAccountWCF.IsDeleted = _bDCustomerAccount.IsDeleted;
				_bDCustomerAccountWCF.DeletedBy = _bDCustomerAccount.DeletedBy;
				_bDCustomerAccountWCF.DeletedDate = _bDCustomerAccount.DeletedDate;
				_bDCustomerAccountWCF.Depit = _bDCustomerAccount.Depit;
				_bDCustomerAccountWCF.Credit = _bDCustomerAccount.Credit;
				_bDCustomerAccountWCF.ChequeNumber = _bDCustomerAccount.ChequeNumber;
				_bDCustomerAccountWCF.InvoiceType = _bDCustomerAccount.InvoiceType;
				_bDCustomerAccountWCF.LstDayToPay = _bDCustomerAccount.LstDayToPay;
				
				bDCustomerAccountCollection.Add(_bDCustomerAccountWCF);
			}
			return bDCustomerAccountCollection;
		}
			
		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>list of objects of class BDCustomerAccount in the form of an object of class BDCustomerAccountCollection </returns>
		public BDCustomerAccountCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			BDCustomerAccountCollection bDCustomerAccountCollection = new BDCustomerAccountCollection();
			foreach (POS.DataLayer.BDCustomerAccount _bDCustomerAccount in POS.DataLayer.BDCustomerAccountBase.SelectAllPaged(pageSize, skipPages, orderByStatement))
			{
				_bDCustomerAccountWCF = new BDCustomerAccount();
				
				_bDCustomerAccountWCF.CustomerAccountNumber = _bDCustomerAccount.CustomerAccountNumber;
				_bDCustomerAccountWCF.CustomerID = _bDCustomerAccount.CustomerID;
				_bDCustomerAccountWCF.SalesInvoiceId = _bDCustomerAccount.SalesInvoiceId;
				_bDCustomerAccountWCF.SalesDate = _bDCustomerAccount.SalesDate;
				_bDCustomerAccountWCF.InvoiceNumber = _bDCustomerAccount.InvoiceNumber;
				_bDCustomerAccountWCF.TotalPrice = _bDCustomerAccount.TotalPrice;
				_bDCustomerAccountWCF.PaidAmount = _bDCustomerAccount.PaidAmount;
				_bDCustomerAccountWCF.RemainingAmount = _bDCustomerAccount.RemainingAmount;
				_bDCustomerAccountWCF.IsVoid = _bDCustomerAccount.IsVoid;
				_bDCustomerAccountWCF.CreatedBy = _bDCustomerAccount.CreatedBy;
				_bDCustomerAccountWCF.CreateDate = _bDCustomerAccount.CreateDate;
				_bDCustomerAccountWCF.UpdatedBy = _bDCustomerAccount.UpdatedBy;
				_bDCustomerAccountWCF.UpdateDate = _bDCustomerAccount.UpdateDate;
				_bDCustomerAccountWCF.IsDeleted = _bDCustomerAccount.IsDeleted;
				_bDCustomerAccountWCF.DeletedBy = _bDCustomerAccount.DeletedBy;
				_bDCustomerAccountWCF.DeletedDate = _bDCustomerAccount.DeletedDate;
				_bDCustomerAccountWCF.Depit = _bDCustomerAccount.Depit;
				_bDCustomerAccountWCF.Credit = _bDCustomerAccount.Credit;
				_bDCustomerAccountWCF.ChequeNumber = _bDCustomerAccount.ChequeNumber;
				_bDCustomerAccountWCF.InvoiceType = _bDCustomerAccount.InvoiceType;
				_bDCustomerAccountWCF.LstDayToPay = _bDCustomerAccount.LstDayToPay;
				
				bDCustomerAccountCollection.Add(_bDCustomerAccountWCF);
			}
			return bDCustomerAccountCollection;
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class BDCustomerAccount</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class BDCustomerAccount in the form of an object of class BDCustomerAccountCollection</returns>
		public BDCustomerAccountCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
		{
			BDCustomerAccountCollection bDCustomerAccountCollection = new BDCustomerAccountCollection();
			foreach (POS.DataLayer.BDCustomerAccount _bDCustomerAccount in POS.DataLayer.BDCustomerAccountBase.SelectByFieldPaged(field, fieldValue, fieldValue2, typeOperation, pageSize, skipPages, orderByStatement))
			{
				_bDCustomerAccountWCF = new BDCustomerAccount();
				
				_bDCustomerAccountWCF.CustomerAccountNumber = _bDCustomerAccount.CustomerAccountNumber;
				_bDCustomerAccountWCF.CustomerID = _bDCustomerAccount.CustomerID;
				_bDCustomerAccountWCF.SalesInvoiceId = _bDCustomerAccount.SalesInvoiceId;
				_bDCustomerAccountWCF.SalesDate = _bDCustomerAccount.SalesDate;
				_bDCustomerAccountWCF.InvoiceNumber = _bDCustomerAccount.InvoiceNumber;
				_bDCustomerAccountWCF.TotalPrice = _bDCustomerAccount.TotalPrice;
				_bDCustomerAccountWCF.PaidAmount = _bDCustomerAccount.PaidAmount;
				_bDCustomerAccountWCF.RemainingAmount = _bDCustomerAccount.RemainingAmount;
				_bDCustomerAccountWCF.IsVoid = _bDCustomerAccount.IsVoid;
				_bDCustomerAccountWCF.CreatedBy = _bDCustomerAccount.CreatedBy;
				_bDCustomerAccountWCF.CreateDate = _bDCustomerAccount.CreateDate;
				_bDCustomerAccountWCF.UpdatedBy = _bDCustomerAccount.UpdatedBy;
				_bDCustomerAccountWCF.UpdateDate = _bDCustomerAccount.UpdateDate;
				_bDCustomerAccountWCF.IsDeleted = _bDCustomerAccount.IsDeleted;
				_bDCustomerAccountWCF.DeletedBy = _bDCustomerAccount.DeletedBy;
				_bDCustomerAccountWCF.DeletedDate = _bDCustomerAccount.DeletedDate;
				_bDCustomerAccountWCF.Depit = _bDCustomerAccount.Depit;
				_bDCustomerAccountWCF.Credit = _bDCustomerAccount.Credit;
				_bDCustomerAccountWCF.ChequeNumber = _bDCustomerAccount.ChequeNumber;
				_bDCustomerAccountWCF.InvoiceType = _bDCustomerAccount.InvoiceType;
				_bDCustomerAccountWCF.LstDayToPay = _bDCustomerAccount.LstDayToPay;
				
				bDCustomerAccountCollection.Add(_bDCustomerAccountWCF);
			}
			return bDCustomerAccountCollection;
		}
			///<summary>
		/// This method will update one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="bDCustomerAccount" type="BDCustomerAccount">This BDCustomerAccount  will be updated in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Update(BDCustomerAccount bDCustomerAccount)
		{
			_bDCustomerAccount=POS.DataLayer.BDCustomerAccount.SelectOne(new POS.DataLayer.BDCustomerAccountPrimaryKey(bDCustomerAccount.CustomerAccountNumber));
			
			_bDCustomerAccount.CustomerID=bDCustomerAccount.CustomerID;
			_bDCustomerAccount.SalesInvoiceId=bDCustomerAccount.SalesInvoiceId;
			_bDCustomerAccount.SalesDate=bDCustomerAccount.SalesDate;
			_bDCustomerAccount.InvoiceNumber=bDCustomerAccount.InvoiceNumber;
			_bDCustomerAccount.TotalPrice=bDCustomerAccount.TotalPrice;
			_bDCustomerAccount.PaidAmount=bDCustomerAccount.PaidAmount;
			_bDCustomerAccount.RemainingAmount=bDCustomerAccount.RemainingAmount;
			_bDCustomerAccount.IsVoid=bDCustomerAccount.IsVoid;
			_bDCustomerAccount.CreatedBy=bDCustomerAccount.CreatedBy;
			_bDCustomerAccount.CreateDate=bDCustomerAccount.CreateDate;
			_bDCustomerAccount.UpdatedBy=bDCustomerAccount.UpdatedBy;
			_bDCustomerAccount.UpdateDate=bDCustomerAccount.UpdateDate;
			_bDCustomerAccount.IsDeleted=bDCustomerAccount.IsDeleted;
			_bDCustomerAccount.DeletedBy=bDCustomerAccount.DeletedBy;
			_bDCustomerAccount.DeletedDate=bDCustomerAccount.DeletedDate;
			_bDCustomerAccount.Depit=bDCustomerAccount.Depit;
			_bDCustomerAccount.Credit=bDCustomerAccount.Credit;
			_bDCustomerAccount.ChequeNumber=bDCustomerAccount.ChequeNumber;
			_bDCustomerAccount.InvoiceType=bDCustomerAccount.InvoiceType;
			_bDCustomerAccount.LstDayToPay=bDCustomerAccount.LstDayToPay;
			
			return _bDCustomerAccount.Update();
		}
	} 
}
