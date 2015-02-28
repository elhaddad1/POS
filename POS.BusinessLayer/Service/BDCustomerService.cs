//
// Class	:	BDCustomerServices.svc.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	2/28/2015 11:31:47 PM
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
	///WCF service for the BDCustomer
	///</summary>
	public class BDCustomerService 
	{
		private BDCustomer _bDCustomerWCF;
		private POS.DataLayer.BDCustomer _bDCustomer;
		
		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="BDCustomerFields">Field of the class BDCustomer</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <returns>True if succeeded</returns>
		public bool DeleteByField(string field, object fieldValue)
		{
			return POS.DataLayer.BDCustomerBase.DeleteByField(field, fieldValue);
		}

		///<summary>
		///This method will Delete the object from the database
		///</summary>
		///<param name="pk" type="BDCustomerPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <returns>True if succeeded</returns>
		public bool Delete(BDCustomerPrimaryKey pk)
		{
			return POS.DataLayer.BDCustomerBase.Delete(new POS.DataLayer.BDCustomerPrimaryKey(pk.CustomerID));
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="BDCustomerPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class BDCustomer</returns>
		public BDCustomer SelectOne(BDCustomerPrimaryKey pk)
		{
			_bDCustomerWCF = new BDCustomer();
			_bDCustomer = POS.DataLayer.BDCustomerBase.SelectOne(new POS.DataLayer.BDCustomerPrimaryKey(pk.CustomerID));
			
				_bDCustomerWCF.CustomerID = _bDCustomer.CustomerID;
				_bDCustomerWCF.CustomerName = _bDCustomer.CustomerName;
				_bDCustomerWCF.CustomerCode = _bDCustomer.CustomerCode;
				_bDCustomerWCF.Address = _bDCustomer.Address;
				_bDCustomerWCF.Phone1 = _bDCustomer.Phone1;
				_bDCustomerWCF.Phone2 = _bDCustomer.Phone2;
				_bDCustomerWCF.Mobile1 = _bDCustomer.Mobile1;
				_bDCustomerWCF.Mobile2 = _bDCustomer.Mobile2;
				_bDCustomerWCF.Email = _bDCustomer.Email;
				_bDCustomerWCF.IsActive = _bDCustomer.IsActive;
				_bDCustomerWCF.Debit = _bDCustomer.Debit;
				_bDCustomerWCF.Credit = _bDCustomer.Credit;
				
			return _bDCustomerWCF;
		}

		/// <summary>
		/// This method will return a list of objects representing all records in the table.
		/// </summary>
		///
		/// <returns>list of objects of class BDCustomer in the form of object of BDCustomerCollection </returns>
		public BDCustomerCollection SelectAll()
		{
			BDCustomerCollection bDCustomerCollection = new BDCustomerCollection();
			foreach (POS.DataLayer.BDCustomer _bDCustomer in POS.DataLayer.BDCustomerBase.SelectAll())
			{
				_bDCustomerWCF = new BDCustomer();
				
				_bDCustomerWCF.CustomerID = _bDCustomer.CustomerID;
				_bDCustomerWCF.CustomerName = _bDCustomer.CustomerName;
				_bDCustomerWCF.CustomerCode = _bDCustomer.CustomerCode;
				_bDCustomerWCF.Address = _bDCustomer.Address;
				_bDCustomerWCF.Phone1 = _bDCustomer.Phone1;
				_bDCustomerWCF.Phone2 = _bDCustomer.Phone2;
				_bDCustomerWCF.Mobile1 = _bDCustomer.Mobile1;
				_bDCustomerWCF.Mobile2 = _bDCustomer.Mobile2;
				_bDCustomerWCF.Email = _bDCustomer.Email;
				_bDCustomerWCF.IsActive = _bDCustomer.IsActive;
				_bDCustomerWCF.Debit = _bDCustomer.Debit;
				_bDCustomerWCF.Credit = _bDCustomer.Credit;
				
				bDCustomerCollection.Add(_bDCustomerWCF);
			}
			return bDCustomerCollection;
		}
    
    /// <summary>
		/// This method will return a count all records in the table.
		/// </summary>
		///
		/// <returns>count records</returns>
		public int SelectAllCount()
		{
			return POS.DataLayer.BDCustomerBase.SelectAllCount();			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class BDCustomer</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class BDCustomer in the form of an object of class BDCustomerCollection</returns>
		public BDCustomerCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
		{
			BDCustomerCollection bDCustomerCollection = new BDCustomerCollection();
			foreach (POS.DataLayer.BDCustomer _bDCustomer in POS.DataLayer.BDCustomerBase.SelectByField(field, fieldValue, fieldValue2, typeOperation))
			{
				_bDCustomerWCF = new BDCustomer();
				
				_bDCustomerWCF.CustomerID = _bDCustomer.CustomerID;
				_bDCustomerWCF.CustomerName = _bDCustomer.CustomerName;
				_bDCustomerWCF.CustomerCode = _bDCustomer.CustomerCode;
				_bDCustomerWCF.Address = _bDCustomer.Address;
				_bDCustomerWCF.Phone1 = _bDCustomer.Phone1;
				_bDCustomerWCF.Phone2 = _bDCustomer.Phone2;
				_bDCustomerWCF.Mobile1 = _bDCustomer.Mobile1;
				_bDCustomerWCF.Mobile2 = _bDCustomer.Mobile2;
				_bDCustomerWCF.Email = _bDCustomer.Email;
				_bDCustomerWCF.IsActive = _bDCustomer.IsActive;
				_bDCustomerWCF.Debit = _bDCustomer.Debit;
				_bDCustomerWCF.Credit = _bDCustomer.Credit;
				
				bDCustomerCollection.Add(_bDCustomerWCF);
			}
			return bDCustomerCollection;
		}
		
		/// <summary>
		/// This method will insert one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="bDCustomer" type="BDCustomer">This BDCustomer  will be inserted in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Insert(BDCustomer bDCustomer)
		{
			_bDCustomer = new POS.DataLayer.BDCustomer();
			_bDCustomer.CustomerID=bDCustomer.CustomerID;
			_bDCustomer.CustomerName=bDCustomer.CustomerName;
			_bDCustomer.CustomerCode=bDCustomer.CustomerCode;
			_bDCustomer.Address=bDCustomer.Address;
			_bDCustomer.Phone1=bDCustomer.Phone1;
			_bDCustomer.Phone2=bDCustomer.Phone2;
			_bDCustomer.Mobile1=bDCustomer.Mobile1;
			_bDCustomer.Mobile2=bDCustomer.Mobile2;
			_bDCustomer.Email=bDCustomer.Email;
			_bDCustomer.IsActive=bDCustomer.IsActive;
			_bDCustomer.Debit=bDCustomer.Debit;
			_bDCustomer.Credit=bDCustomer.Credit;
			
			return _bDCustomer.Insert();
		}
		
		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>list of objects of class BDCustomer in the form of an object of class BDCustomerCollection </returns>
		public BDCustomerCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			BDCustomerCollection bDCustomerCollection = new BDCustomerCollection();
			foreach (POS.DataLayer.BDCustomer _bDCustomer in POS.DataLayer.BDCustomerBase.SelectAllPaged(pageSize, skipPages, orderByStatement))
			{
				_bDCustomerWCF = new BDCustomer();
				
				_bDCustomerWCF.CustomerID = _bDCustomer.CustomerID;
				_bDCustomerWCF.CustomerName = _bDCustomer.CustomerName;
				_bDCustomerWCF.CustomerCode = _bDCustomer.CustomerCode;
				_bDCustomerWCF.Address = _bDCustomer.Address;
				_bDCustomerWCF.Phone1 = _bDCustomer.Phone1;
				_bDCustomerWCF.Phone2 = _bDCustomer.Phone2;
				_bDCustomerWCF.Mobile1 = _bDCustomer.Mobile1;
				_bDCustomerWCF.Mobile2 = _bDCustomer.Mobile2;
				_bDCustomerWCF.Email = _bDCustomer.Email;
				_bDCustomerWCF.IsActive = _bDCustomer.IsActive;
				_bDCustomerWCF.Debit = _bDCustomer.Debit;
				_bDCustomerWCF.Credit = _bDCustomer.Credit;
				
				bDCustomerCollection.Add(_bDCustomerWCF);
			}
			return bDCustomerCollection;
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class BDCustomer</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class BDCustomer in the form of an object of class BDCustomerCollection</returns>
		public BDCustomerCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
		{
			BDCustomerCollection bDCustomerCollection = new BDCustomerCollection();
			foreach (POS.DataLayer.BDCustomer _bDCustomer in POS.DataLayer.BDCustomerBase.SelectByFieldPaged(field, fieldValue, fieldValue2, typeOperation, pageSize, skipPages, orderByStatement))
			{
				_bDCustomerWCF = new BDCustomer();
				
				_bDCustomerWCF.CustomerID = _bDCustomer.CustomerID;
				_bDCustomerWCF.CustomerName = _bDCustomer.CustomerName;
				_bDCustomerWCF.CustomerCode = _bDCustomer.CustomerCode;
				_bDCustomerWCF.Address = _bDCustomer.Address;
				_bDCustomerWCF.Phone1 = _bDCustomer.Phone1;
				_bDCustomerWCF.Phone2 = _bDCustomer.Phone2;
				_bDCustomerWCF.Mobile1 = _bDCustomer.Mobile1;
				_bDCustomerWCF.Mobile2 = _bDCustomer.Mobile2;
				_bDCustomerWCF.Email = _bDCustomer.Email;
				_bDCustomerWCF.IsActive = _bDCustomer.IsActive;
				_bDCustomerWCF.Debit = _bDCustomer.Debit;
				_bDCustomerWCF.Credit = _bDCustomer.Credit;
				
				bDCustomerCollection.Add(_bDCustomerWCF);
			}
			return bDCustomerCollection;
		}
			///<summary>
		/// This method will update one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="bDCustomer" type="BDCustomer">This BDCustomer  will be updated in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Update(BDCustomer bDCustomer)
		{
			_bDCustomer=POS.DataLayer.BDCustomer.SelectOne(new POS.DataLayer.BDCustomerPrimaryKey(bDCustomer.CustomerID));
			
			_bDCustomer.CustomerName=bDCustomer.CustomerName;
			_bDCustomer.CustomerCode=bDCustomer.CustomerCode;
			_bDCustomer.Address=bDCustomer.Address;
			_bDCustomer.Phone1=bDCustomer.Phone1;
			_bDCustomer.Phone2=bDCustomer.Phone2;
			_bDCustomer.Mobile1=bDCustomer.Mobile1;
			_bDCustomer.Mobile2=bDCustomer.Mobile2;
			_bDCustomer.Email=bDCustomer.Email;
			_bDCustomer.IsActive=bDCustomer.IsActive;
			_bDCustomer.Debit=bDCustomer.Debit;
			_bDCustomer.Credit=bDCustomer.Credit;
			
			return _bDCustomer.Update();
		}
	} 
}
