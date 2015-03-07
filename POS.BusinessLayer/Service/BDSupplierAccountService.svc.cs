//
// Class	:	BDSupplierAccountServices.svc.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	3/7/2015 2:36:57 PM
//


using POS.DataLayer;

namespace POS.BusinessLayer
{
	///<summary>
	///WCF service for the BDSupplierAccount
	///</summary>
	public class BDSupplierAccountService 
	{
		private BDSupplierAccount _bDSupplierAccountWCF;
		private POS.DataLayer.BDSupplierAccount _bDSupplierAccount;
		
		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="BDSupplierAccountFields">Field of the class BDSupplierAccount</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <returns>True if succeeded</returns>
		public bool DeleteByField(string field, object fieldValue)
		{
			return POS.DataLayer.BDSupplierAccountBase.DeleteByField(field, fieldValue);
		}

		///<summary>
		///This method will Delete the object from the database
		///</summary>
		///<param name="pk" type="BDSupplierAccountPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <returns>True if succeeded</returns>
		public bool Delete(BDSupplierAccountPrimaryKey pk)
		{
			return POS.DataLayer.BDSupplierAccountBase.Delete(new POS.DataLayer.BDSupplierAccountPrimaryKey(pk.SupplierAccountId));
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="BDSupplierAccountPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class BDSupplierAccount</returns>
		public BDSupplierAccount SelectOne(BDSupplierAccountPrimaryKey pk)
		{
			_bDSupplierAccountWCF = new BDSupplierAccount();
			_bDSupplierAccount = POS.DataLayer.BDSupplierAccountBase.SelectOne(new POS.DataLayer.BDSupplierAccountPrimaryKey(pk.SupplierAccountId));
			
				_bDSupplierAccountWCF.SupplierAccountId = _bDSupplierAccount.SupplierAccountId;
				_bDSupplierAccountWCF.PurcaseInvoiceID = _bDSupplierAccount.PurcaseInvoiceID;
				_bDSupplierAccountWCF.PurchaseDate = _bDSupplierAccount.PurchaseDate;
				_bDSupplierAccountWCF.SupplierID = _bDSupplierAccount.SupplierID;
				_bDSupplierAccountWCF.InvoiceNumber = _bDSupplierAccount.InvoiceNumber;
				_bDSupplierAccountWCF.TotalPrice = _bDSupplierAccount.TotalPrice;
				_bDSupplierAccountWCF.PaidAmount = _bDSupplierAccount.PaidAmount;
				_bDSupplierAccountWCF.IsVoid = _bDSupplierAccount.IsVoid;
				_bDSupplierAccountWCF.RemainingAmount = _bDSupplierAccount.RemainingAmount;
				_bDSupplierAccountWCF.CreateDate = _bDSupplierAccount.CreateDate;
				_bDSupplierAccountWCF.CreatedBy = _bDSupplierAccount.CreatedBy;
				_bDSupplierAccountWCF.updateDate = _bDSupplierAccount.updateDate;
				_bDSupplierAccountWCF.UpdatedBy = _bDSupplierAccount.UpdatedBy;
				_bDSupplierAccountWCF.IsDeleted = _bDSupplierAccount.IsDeleted;
				_bDSupplierAccountWCF.DeleteDate = _bDSupplierAccount.DeleteDate;
				_bDSupplierAccountWCF.DeletedBy = _bDSupplierAccount.DeletedBy;
				
			return _bDSupplierAccountWCF;
		}

		/// <summary>
		/// This method will return a list of objects representing all records in the table.
		/// </summary>
		///
		/// <returns>list of objects of class BDSupplierAccount in the form of object of BDSupplierAccountCollection </returns>
		public BDSupplierAccountCollection SelectAll()
		{
			BDSupplierAccountCollection bDSupplierAccountCollection = new BDSupplierAccountCollection();
			foreach (POS.DataLayer.BDSupplierAccount _bDSupplierAccount in POS.DataLayer.BDSupplierAccountBase.SelectAll())
			{
				_bDSupplierAccountWCF = new BDSupplierAccount();
				
				_bDSupplierAccountWCF.SupplierAccountId = _bDSupplierAccount.SupplierAccountId;
				_bDSupplierAccountWCF.PurcaseInvoiceID = _bDSupplierAccount.PurcaseInvoiceID;
				_bDSupplierAccountWCF.PurchaseDate = _bDSupplierAccount.PurchaseDate;
				_bDSupplierAccountWCF.SupplierID = _bDSupplierAccount.SupplierID;
				_bDSupplierAccountWCF.InvoiceNumber = _bDSupplierAccount.InvoiceNumber;
				_bDSupplierAccountWCF.TotalPrice = _bDSupplierAccount.TotalPrice;
				_bDSupplierAccountWCF.PaidAmount = _bDSupplierAccount.PaidAmount;
				_bDSupplierAccountWCF.IsVoid = _bDSupplierAccount.IsVoid;
				_bDSupplierAccountWCF.RemainingAmount = _bDSupplierAccount.RemainingAmount;
				_bDSupplierAccountWCF.CreateDate = _bDSupplierAccount.CreateDate;
				_bDSupplierAccountWCF.CreatedBy = _bDSupplierAccount.CreatedBy;
				_bDSupplierAccountWCF.updateDate = _bDSupplierAccount.updateDate;
				_bDSupplierAccountWCF.UpdatedBy = _bDSupplierAccount.UpdatedBy;
				_bDSupplierAccountWCF.IsDeleted = _bDSupplierAccount.IsDeleted;
				_bDSupplierAccountWCF.DeleteDate = _bDSupplierAccount.DeleteDate;
				_bDSupplierAccountWCF.DeletedBy = _bDSupplierAccount.DeletedBy;
				
				bDSupplierAccountCollection.Add(_bDSupplierAccountWCF);
			}
			return bDSupplierAccountCollection;
		}
    
    /// <summary>
		/// This method will return a count all records in the table.
		/// </summary>
		///
		/// <returns>count records</returns>
		public int SelectAllCount()
		{
			return POS.DataLayer.BDSupplierAccountBase.SelectAllCount();			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class BDSupplierAccount</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class BDSupplierAccount in the form of an object of class BDSupplierAccountCollection</returns>
		public BDSupplierAccountCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
		{
			BDSupplierAccountCollection bDSupplierAccountCollection = new BDSupplierAccountCollection();
			foreach (POS.DataLayer.BDSupplierAccount _bDSupplierAccount in POS.DataLayer.BDSupplierAccountBase.SelectByField(field, fieldValue, fieldValue2, typeOperation))
			{
				_bDSupplierAccountWCF = new BDSupplierAccount();
				
				_bDSupplierAccountWCF.SupplierAccountId = _bDSupplierAccount.SupplierAccountId;
				_bDSupplierAccountWCF.PurcaseInvoiceID = _bDSupplierAccount.PurcaseInvoiceID;
				_bDSupplierAccountWCF.PurchaseDate = _bDSupplierAccount.PurchaseDate;
				_bDSupplierAccountWCF.SupplierID = _bDSupplierAccount.SupplierID;
				_bDSupplierAccountWCF.InvoiceNumber = _bDSupplierAccount.InvoiceNumber;
				_bDSupplierAccountWCF.TotalPrice = _bDSupplierAccount.TotalPrice;
				_bDSupplierAccountWCF.PaidAmount = _bDSupplierAccount.PaidAmount;
				_bDSupplierAccountWCF.IsVoid = _bDSupplierAccount.IsVoid;
				_bDSupplierAccountWCF.RemainingAmount = _bDSupplierAccount.RemainingAmount;
				_bDSupplierAccountWCF.CreateDate = _bDSupplierAccount.CreateDate;
				_bDSupplierAccountWCF.CreatedBy = _bDSupplierAccount.CreatedBy;
				_bDSupplierAccountWCF.updateDate = _bDSupplierAccount.updateDate;
				_bDSupplierAccountWCF.UpdatedBy = _bDSupplierAccount.UpdatedBy;
				_bDSupplierAccountWCF.IsDeleted = _bDSupplierAccount.IsDeleted;
				_bDSupplierAccountWCF.DeleteDate = _bDSupplierAccount.DeleteDate;
				_bDSupplierAccountWCF.DeletedBy = _bDSupplierAccount.DeletedBy;
				
				bDSupplierAccountCollection.Add(_bDSupplierAccountWCF);
			}
			return bDSupplierAccountCollection;
		}
		
		/// <summary>
		/// This method will insert one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="bDSupplierAccount" type="BDSupplierAccount">This BDSupplierAccount  will be inserted in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Insert(BDSupplierAccount bDSupplierAccount)
		{
			_bDSupplierAccount = new POS.DataLayer.BDSupplierAccount();
			_bDSupplierAccount.SupplierAccountId=bDSupplierAccount.SupplierAccountId;
			_bDSupplierAccount.PurcaseInvoiceID=bDSupplierAccount.PurcaseInvoiceID;
			_bDSupplierAccount.PurchaseDate=bDSupplierAccount.PurchaseDate;
			_bDSupplierAccount.SupplierID=bDSupplierAccount.SupplierID;
			_bDSupplierAccount.InvoiceNumber=bDSupplierAccount.InvoiceNumber;
			_bDSupplierAccount.TotalPrice=bDSupplierAccount.TotalPrice;
			_bDSupplierAccount.PaidAmount=bDSupplierAccount.PaidAmount;
			_bDSupplierAccount.IsVoid=bDSupplierAccount.IsVoid;
			_bDSupplierAccount.RemainingAmount=bDSupplierAccount.RemainingAmount;
			_bDSupplierAccount.CreateDate=bDSupplierAccount.CreateDate;
			_bDSupplierAccount.CreatedBy=bDSupplierAccount.CreatedBy;
			_bDSupplierAccount.updateDate=bDSupplierAccount.updateDate;
			_bDSupplierAccount.UpdatedBy=bDSupplierAccount.UpdatedBy;
			_bDSupplierAccount.IsDeleted=bDSupplierAccount.IsDeleted;
			_bDSupplierAccount.DeleteDate=bDSupplierAccount.DeleteDate;
			_bDSupplierAccount.DeletedBy=bDSupplierAccount.DeletedBy;
			
			return _bDSupplierAccount.Insert();
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
			return POS.DataLayer.BDSupplierAccountBase.DeleteAllByForeignKeyCreatedBy(new POS.DataLayer.ADUserPrimaryKey(pk.UserID));
		}
		
		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="ADUserPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class BDSupplierAccountCollection</returns>
		public BDSupplierAccountCollection SelectAllByForeignKeyCreatedBy(ADUserPrimaryKey pk)
		{
			BDSupplierAccountCollection bDSupplierAccountCollection=new BDSupplierAccountCollection();
			foreach (POS.DataLayer.BDSupplierAccount _bDSupplierAccount in POS.DataLayer.BDSupplierAccountBase.SelectAllByForeignKeyCreatedBy(new POS.DataLayer.ADUserPrimaryKey(pk.UserID)))
			{
				_bDSupplierAccountWCF = new BDSupplierAccount();
				_bDSupplierAccountWCF.SupplierAccountId = _bDSupplierAccount.SupplierAccountId;
				_bDSupplierAccountWCF.PurcaseInvoiceID = _bDSupplierAccount.PurcaseInvoiceID;
				_bDSupplierAccountWCF.PurchaseDate = _bDSupplierAccount.PurchaseDate;
				_bDSupplierAccountWCF.SupplierID = _bDSupplierAccount.SupplierID;
				_bDSupplierAccountWCF.InvoiceNumber = _bDSupplierAccount.InvoiceNumber;
				_bDSupplierAccountWCF.TotalPrice = _bDSupplierAccount.TotalPrice;
				_bDSupplierAccountWCF.PaidAmount = _bDSupplierAccount.PaidAmount;
				_bDSupplierAccountWCF.IsVoid = _bDSupplierAccount.IsVoid;
				_bDSupplierAccountWCF.RemainingAmount = _bDSupplierAccount.RemainingAmount;
				_bDSupplierAccountWCF.CreateDate = _bDSupplierAccount.CreateDate;
				_bDSupplierAccountWCF.CreatedBy = _bDSupplierAccount.CreatedBy;
				_bDSupplierAccountWCF.updateDate = _bDSupplierAccount.updateDate;
				_bDSupplierAccountWCF.UpdatedBy = _bDSupplierAccount.UpdatedBy;
				_bDSupplierAccountWCF.IsDeleted = _bDSupplierAccount.IsDeleted;
				_bDSupplierAccountWCF.DeleteDate = _bDSupplierAccount.DeleteDate;
				_bDSupplierAccountWCF.DeletedBy = _bDSupplierAccount.DeletedBy;
				
				bDSupplierAccountCollection.Add(_bDSupplierAccountWCF);
			}
			return bDSupplierAccountCollection;
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
		/// <returns>object of class BDSupplierAccountCollection</returns>
		public BDSupplierAccountCollection SelectAllByForeignKeyCreatedByPaged(ADUserPrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			BDSupplierAccountCollection bDSupplierAccountCollection=new BDSupplierAccountCollection();
			foreach (POS.DataLayer.BDSupplierAccount _bDSupplierAccount in POS.DataLayer.BDSupplierAccountBase.SelectAllByForeignKeyCreatedByPaged(new POS.DataLayer.ADUserPrimaryKey(pk.UserID), pageSize, skipPages, orderByStatement))
			{
				_bDSupplierAccountWCF = new BDSupplierAccount();
				_bDSupplierAccountWCF.SupplierAccountId = _bDSupplierAccount.SupplierAccountId;
				_bDSupplierAccountWCF.PurcaseInvoiceID = _bDSupplierAccount.PurcaseInvoiceID;
				_bDSupplierAccountWCF.PurchaseDate = _bDSupplierAccount.PurchaseDate;
				_bDSupplierAccountWCF.SupplierID = _bDSupplierAccount.SupplierID;
				_bDSupplierAccountWCF.InvoiceNumber = _bDSupplierAccount.InvoiceNumber;
				_bDSupplierAccountWCF.TotalPrice = _bDSupplierAccount.TotalPrice;
				_bDSupplierAccountWCF.PaidAmount = _bDSupplierAccount.PaidAmount;
				_bDSupplierAccountWCF.IsVoid = _bDSupplierAccount.IsVoid;
				_bDSupplierAccountWCF.RemainingAmount = _bDSupplierAccount.RemainingAmount;
				_bDSupplierAccountWCF.CreateDate = _bDSupplierAccount.CreateDate;
				_bDSupplierAccountWCF.CreatedBy = _bDSupplierAccount.CreatedBy;
				_bDSupplierAccountWCF.updateDate = _bDSupplierAccount.updateDate;
				_bDSupplierAccountWCF.UpdatedBy = _bDSupplierAccount.UpdatedBy;
				_bDSupplierAccountWCF.IsDeleted = _bDSupplierAccount.IsDeleted;
				_bDSupplierAccountWCF.DeleteDate = _bDSupplierAccount.DeleteDate;
				_bDSupplierAccountWCF.DeletedBy = _bDSupplierAccount.DeletedBy;
				
				bDSupplierAccountCollection.Add(_bDSupplierAccountWCF);
			}
			return bDSupplierAccountCollection;
		}
			/// <summary>
		/// This method will delete row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="BDSupplierPrimaryKey">Primary Key information based on which data is to be deleted.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool DeleteAllByForeignKeySupplierID(BDSupplierPrimaryKey pk)
		{
			return POS.DataLayer.BDSupplierAccountBase.DeleteAllByForeignKeySupplierID(new POS.DataLayer.BDSupplierPrimaryKey(pk.SupplierID));
		}
		
		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="BDSupplierPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class BDSupplierAccountCollection</returns>
		public BDSupplierAccountCollection SelectAllByForeignKeySupplierID(BDSupplierPrimaryKey pk)
		{
			BDSupplierAccountCollection bDSupplierAccountCollection=new BDSupplierAccountCollection();
			foreach (POS.DataLayer.BDSupplierAccount _bDSupplierAccount in POS.DataLayer.BDSupplierAccountBase.SelectAllByForeignKeySupplierID(new POS.DataLayer.BDSupplierPrimaryKey(pk.SupplierID)))
			{
				_bDSupplierAccountWCF = new BDSupplierAccount();
				_bDSupplierAccountWCF.SupplierAccountId = _bDSupplierAccount.SupplierAccountId;
				_bDSupplierAccountWCF.PurcaseInvoiceID = _bDSupplierAccount.PurcaseInvoiceID;
				_bDSupplierAccountWCF.PurchaseDate = _bDSupplierAccount.PurchaseDate;
				_bDSupplierAccountWCF.SupplierID = _bDSupplierAccount.SupplierID;
				_bDSupplierAccountWCF.InvoiceNumber = _bDSupplierAccount.InvoiceNumber;
				_bDSupplierAccountWCF.TotalPrice = _bDSupplierAccount.TotalPrice;
				_bDSupplierAccountWCF.PaidAmount = _bDSupplierAccount.PaidAmount;
				_bDSupplierAccountWCF.IsVoid = _bDSupplierAccount.IsVoid;
				_bDSupplierAccountWCF.RemainingAmount = _bDSupplierAccount.RemainingAmount;
				_bDSupplierAccountWCF.CreateDate = _bDSupplierAccount.CreateDate;
				_bDSupplierAccountWCF.CreatedBy = _bDSupplierAccount.CreatedBy;
				_bDSupplierAccountWCF.updateDate = _bDSupplierAccount.updateDate;
				_bDSupplierAccountWCF.UpdatedBy = _bDSupplierAccount.UpdatedBy;
				_bDSupplierAccountWCF.IsDeleted = _bDSupplierAccount.IsDeleted;
				_bDSupplierAccountWCF.DeleteDate = _bDSupplierAccount.DeleteDate;
				_bDSupplierAccountWCF.DeletedBy = _bDSupplierAccount.DeletedBy;
				
				bDSupplierAccountCollection.Add(_bDSupplierAccountWCF);
			}
			return bDSupplierAccountCollection;
		}
		
		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="BDSupplierPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>object of class BDSupplierAccountCollection</returns>
		public BDSupplierAccountCollection SelectAllByForeignKeySupplierIDPaged(BDSupplierPrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			BDSupplierAccountCollection bDSupplierAccountCollection=new BDSupplierAccountCollection();
			foreach (POS.DataLayer.BDSupplierAccount _bDSupplierAccount in POS.DataLayer.BDSupplierAccountBase.SelectAllByForeignKeySupplierIDPaged(new POS.DataLayer.BDSupplierPrimaryKey(pk.SupplierID), pageSize, skipPages, orderByStatement))
			{
				_bDSupplierAccountWCF = new BDSupplierAccount();
				_bDSupplierAccountWCF.SupplierAccountId = _bDSupplierAccount.SupplierAccountId;
				_bDSupplierAccountWCF.PurcaseInvoiceID = _bDSupplierAccount.PurcaseInvoiceID;
				_bDSupplierAccountWCF.PurchaseDate = _bDSupplierAccount.PurchaseDate;
				_bDSupplierAccountWCF.SupplierID = _bDSupplierAccount.SupplierID;
				_bDSupplierAccountWCF.InvoiceNumber = _bDSupplierAccount.InvoiceNumber;
				_bDSupplierAccountWCF.TotalPrice = _bDSupplierAccount.TotalPrice;
				_bDSupplierAccountWCF.PaidAmount = _bDSupplierAccount.PaidAmount;
				_bDSupplierAccountWCF.IsVoid = _bDSupplierAccount.IsVoid;
				_bDSupplierAccountWCF.RemainingAmount = _bDSupplierAccount.RemainingAmount;
				_bDSupplierAccountWCF.CreateDate = _bDSupplierAccount.CreateDate;
				_bDSupplierAccountWCF.CreatedBy = _bDSupplierAccount.CreatedBy;
				_bDSupplierAccountWCF.updateDate = _bDSupplierAccount.updateDate;
				_bDSupplierAccountWCF.UpdatedBy = _bDSupplierAccount.UpdatedBy;
				_bDSupplierAccountWCF.IsDeleted = _bDSupplierAccount.IsDeleted;
				_bDSupplierAccountWCF.DeleteDate = _bDSupplierAccount.DeleteDate;
				_bDSupplierAccountWCF.DeletedBy = _bDSupplierAccount.DeletedBy;
				
				bDSupplierAccountCollection.Add(_bDSupplierAccountWCF);
			}
			return bDSupplierAccountCollection;
		}
			/// <summary>
		/// This method will delete row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="PURPurchaseHeaderPrimaryKey">Primary Key information based on which data is to be deleted.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool DeleteAllByForeignKeyPurcaseInvoiceID(PURPurchaseHeaderPrimaryKey pk)
		{
			return POS.DataLayer.BDSupplierAccountBase.DeleteAllByForeignKeyPurcaseInvoiceID(new POS.DataLayer.PURPurchaseHeaderPrimaryKey(pk.PurcaseHeaderID));
		}
		
		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="PURPurchaseHeaderPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class BDSupplierAccountCollection</returns>
		public BDSupplierAccountCollection SelectAllByForeignKeyPurcaseInvoiceID(PURPurchaseHeaderPrimaryKey pk)
		{
			BDSupplierAccountCollection bDSupplierAccountCollection=new BDSupplierAccountCollection();
			foreach (POS.DataLayer.BDSupplierAccount _bDSupplierAccount in POS.DataLayer.BDSupplierAccountBase.SelectAllByForeignKeyPurcaseInvoiceID(new POS.DataLayer.PURPurchaseHeaderPrimaryKey(pk.PurcaseHeaderID)))
			{
				_bDSupplierAccountWCF = new BDSupplierAccount();
				_bDSupplierAccountWCF.SupplierAccountId = _bDSupplierAccount.SupplierAccountId;
				_bDSupplierAccountWCF.PurcaseInvoiceID = _bDSupplierAccount.PurcaseInvoiceID;
				_bDSupplierAccountWCF.PurchaseDate = _bDSupplierAccount.PurchaseDate;
				_bDSupplierAccountWCF.SupplierID = _bDSupplierAccount.SupplierID;
				_bDSupplierAccountWCF.InvoiceNumber = _bDSupplierAccount.InvoiceNumber;
				_bDSupplierAccountWCF.TotalPrice = _bDSupplierAccount.TotalPrice;
				_bDSupplierAccountWCF.PaidAmount = _bDSupplierAccount.PaidAmount;
				_bDSupplierAccountWCF.IsVoid = _bDSupplierAccount.IsVoid;
				_bDSupplierAccountWCF.RemainingAmount = _bDSupplierAccount.RemainingAmount;
				_bDSupplierAccountWCF.CreateDate = _bDSupplierAccount.CreateDate;
				_bDSupplierAccountWCF.CreatedBy = _bDSupplierAccount.CreatedBy;
				_bDSupplierAccountWCF.updateDate = _bDSupplierAccount.updateDate;
				_bDSupplierAccountWCF.UpdatedBy = _bDSupplierAccount.UpdatedBy;
				_bDSupplierAccountWCF.IsDeleted = _bDSupplierAccount.IsDeleted;
				_bDSupplierAccountWCF.DeleteDate = _bDSupplierAccount.DeleteDate;
				_bDSupplierAccountWCF.DeletedBy = _bDSupplierAccount.DeletedBy;
				
				bDSupplierAccountCollection.Add(_bDSupplierAccountWCF);
			}
			return bDSupplierAccountCollection;
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
		/// <returns>object of class BDSupplierAccountCollection</returns>
		public BDSupplierAccountCollection SelectAllByForeignKeyPurcaseInvoiceIDPaged(PURPurchaseHeaderPrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			BDSupplierAccountCollection bDSupplierAccountCollection=new BDSupplierAccountCollection();
			foreach (POS.DataLayer.BDSupplierAccount _bDSupplierAccount in POS.DataLayer.BDSupplierAccountBase.SelectAllByForeignKeyPurcaseInvoiceIDPaged(new POS.DataLayer.PURPurchaseHeaderPrimaryKey(pk.PurcaseHeaderID), pageSize, skipPages, orderByStatement))
			{
				_bDSupplierAccountWCF = new BDSupplierAccount();
				_bDSupplierAccountWCF.SupplierAccountId = _bDSupplierAccount.SupplierAccountId;
				_bDSupplierAccountWCF.PurcaseInvoiceID = _bDSupplierAccount.PurcaseInvoiceID;
				_bDSupplierAccountWCF.PurchaseDate = _bDSupplierAccount.PurchaseDate;
				_bDSupplierAccountWCF.SupplierID = _bDSupplierAccount.SupplierID;
				_bDSupplierAccountWCF.InvoiceNumber = _bDSupplierAccount.InvoiceNumber;
				_bDSupplierAccountWCF.TotalPrice = _bDSupplierAccount.TotalPrice;
				_bDSupplierAccountWCF.PaidAmount = _bDSupplierAccount.PaidAmount;
				_bDSupplierAccountWCF.IsVoid = _bDSupplierAccount.IsVoid;
				_bDSupplierAccountWCF.RemainingAmount = _bDSupplierAccount.RemainingAmount;
				_bDSupplierAccountWCF.CreateDate = _bDSupplierAccount.CreateDate;
				_bDSupplierAccountWCF.CreatedBy = _bDSupplierAccount.CreatedBy;
				_bDSupplierAccountWCF.updateDate = _bDSupplierAccount.updateDate;
				_bDSupplierAccountWCF.UpdatedBy = _bDSupplierAccount.UpdatedBy;
				_bDSupplierAccountWCF.IsDeleted = _bDSupplierAccount.IsDeleted;
				_bDSupplierAccountWCF.DeleteDate = _bDSupplierAccount.DeleteDate;
				_bDSupplierAccountWCF.DeletedBy = _bDSupplierAccount.DeletedBy;
				
				bDSupplierAccountCollection.Add(_bDSupplierAccountWCF);
			}
			return bDSupplierAccountCollection;
		}
			
		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>list of objects of class BDSupplierAccount in the form of an object of class BDSupplierAccountCollection </returns>
		public BDSupplierAccountCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			BDSupplierAccountCollection bDSupplierAccountCollection = new BDSupplierAccountCollection();
			foreach (POS.DataLayer.BDSupplierAccount _bDSupplierAccount in POS.DataLayer.BDSupplierAccountBase.SelectAllPaged(pageSize, skipPages, orderByStatement))
			{
				_bDSupplierAccountWCF = new BDSupplierAccount();
				
				_bDSupplierAccountWCF.SupplierAccountId = _bDSupplierAccount.SupplierAccountId;
				_bDSupplierAccountWCF.PurcaseInvoiceID = _bDSupplierAccount.PurcaseInvoiceID;
				_bDSupplierAccountWCF.PurchaseDate = _bDSupplierAccount.PurchaseDate;
				_bDSupplierAccountWCF.SupplierID = _bDSupplierAccount.SupplierID;
				_bDSupplierAccountWCF.InvoiceNumber = _bDSupplierAccount.InvoiceNumber;
				_bDSupplierAccountWCF.TotalPrice = _bDSupplierAccount.TotalPrice;
				_bDSupplierAccountWCF.PaidAmount = _bDSupplierAccount.PaidAmount;
				_bDSupplierAccountWCF.IsVoid = _bDSupplierAccount.IsVoid;
				_bDSupplierAccountWCF.RemainingAmount = _bDSupplierAccount.RemainingAmount;
				_bDSupplierAccountWCF.CreateDate = _bDSupplierAccount.CreateDate;
				_bDSupplierAccountWCF.CreatedBy = _bDSupplierAccount.CreatedBy;
				_bDSupplierAccountWCF.updateDate = _bDSupplierAccount.updateDate;
				_bDSupplierAccountWCF.UpdatedBy = _bDSupplierAccount.UpdatedBy;
				_bDSupplierAccountWCF.IsDeleted = _bDSupplierAccount.IsDeleted;
				_bDSupplierAccountWCF.DeleteDate = _bDSupplierAccount.DeleteDate;
				_bDSupplierAccountWCF.DeletedBy = _bDSupplierAccount.DeletedBy;
				
				bDSupplierAccountCollection.Add(_bDSupplierAccountWCF);
			}
			return bDSupplierAccountCollection;
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class BDSupplierAccount</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class BDSupplierAccount in the form of an object of class BDSupplierAccountCollection</returns>
		public BDSupplierAccountCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
		{
			BDSupplierAccountCollection bDSupplierAccountCollection = new BDSupplierAccountCollection();
			foreach (POS.DataLayer.BDSupplierAccount _bDSupplierAccount in POS.DataLayer.BDSupplierAccountBase.SelectByFieldPaged(field, fieldValue, fieldValue2, typeOperation, pageSize, skipPages, orderByStatement))
			{
				_bDSupplierAccountWCF = new BDSupplierAccount();
				
				_bDSupplierAccountWCF.SupplierAccountId = _bDSupplierAccount.SupplierAccountId;
				_bDSupplierAccountWCF.PurcaseInvoiceID = _bDSupplierAccount.PurcaseInvoiceID;
				_bDSupplierAccountWCF.PurchaseDate = _bDSupplierAccount.PurchaseDate;
				_bDSupplierAccountWCF.SupplierID = _bDSupplierAccount.SupplierID;
				_bDSupplierAccountWCF.InvoiceNumber = _bDSupplierAccount.InvoiceNumber;
				_bDSupplierAccountWCF.TotalPrice = _bDSupplierAccount.TotalPrice;
				_bDSupplierAccountWCF.PaidAmount = _bDSupplierAccount.PaidAmount;
				_bDSupplierAccountWCF.IsVoid = _bDSupplierAccount.IsVoid;
				_bDSupplierAccountWCF.RemainingAmount = _bDSupplierAccount.RemainingAmount;
				_bDSupplierAccountWCF.CreateDate = _bDSupplierAccount.CreateDate;
				_bDSupplierAccountWCF.CreatedBy = _bDSupplierAccount.CreatedBy;
				_bDSupplierAccountWCF.updateDate = _bDSupplierAccount.updateDate;
				_bDSupplierAccountWCF.UpdatedBy = _bDSupplierAccount.UpdatedBy;
				_bDSupplierAccountWCF.IsDeleted = _bDSupplierAccount.IsDeleted;
				_bDSupplierAccountWCF.DeleteDate = _bDSupplierAccount.DeleteDate;
				_bDSupplierAccountWCF.DeletedBy = _bDSupplierAccount.DeletedBy;
				
				bDSupplierAccountCollection.Add(_bDSupplierAccountWCF);
			}
			return bDSupplierAccountCollection;
		}
			///<summary>
		/// This method will update one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="bDSupplierAccount" type="BDSupplierAccount">This BDSupplierAccount  will be updated in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Update(BDSupplierAccount bDSupplierAccount)
		{
			_bDSupplierAccount=POS.DataLayer.BDSupplierAccount.SelectOne(new POS.DataLayer.BDSupplierAccountPrimaryKey(bDSupplierAccount.SupplierAccountId));
			
			_bDSupplierAccount.PurcaseInvoiceID=bDSupplierAccount.PurcaseInvoiceID;
			_bDSupplierAccount.PurchaseDate=bDSupplierAccount.PurchaseDate;
			_bDSupplierAccount.SupplierID=bDSupplierAccount.SupplierID;
			_bDSupplierAccount.InvoiceNumber=bDSupplierAccount.InvoiceNumber;
			_bDSupplierAccount.TotalPrice=bDSupplierAccount.TotalPrice;
			_bDSupplierAccount.PaidAmount=bDSupplierAccount.PaidAmount;
			_bDSupplierAccount.IsVoid=bDSupplierAccount.IsVoid;
			_bDSupplierAccount.RemainingAmount=bDSupplierAccount.RemainingAmount;
			_bDSupplierAccount.CreateDate=bDSupplierAccount.CreateDate;
			_bDSupplierAccount.CreatedBy=bDSupplierAccount.CreatedBy;
			_bDSupplierAccount.updateDate=bDSupplierAccount.updateDate;
			_bDSupplierAccount.UpdatedBy=bDSupplierAccount.UpdatedBy;
			_bDSupplierAccount.IsDeleted=bDSupplierAccount.IsDeleted;
			_bDSupplierAccount.DeleteDate=bDSupplierAccount.DeleteDate;
			_bDSupplierAccount.DeletedBy=bDSupplierAccount.DeletedBy;
			
			return _bDSupplierAccount.Update();
		}
	} 
}
