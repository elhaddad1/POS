//
// Class	:	BDSupplierServices.svc.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	3/7/2015 2:37:05 PM
//


using POS.DataLayer;

namespace POS.BusinessLayer
{
	///<summary>
	///WCF service for the BDSupplier
	///</summary>
	public class BDSupplierService 
	{
		private BDSupplier _bDSupplierWCF;
		private POS.DataLayer.BDSupplier _bDSupplier;
		
		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="BDSupplierFields">Field of the class BDSupplier</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <returns>True if succeeded</returns>
		public bool DeleteByField(string field, object fieldValue)
		{
			return POS.DataLayer.BDSupplierBase.DeleteByField(field, fieldValue);
		}

		///<summary>
		///This method will Delete the object from the database
		///</summary>
		///<param name="pk" type="BDSupplierPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <returns>True if succeeded</returns>
		public bool Delete(BDSupplierPrimaryKey pk)
		{
			return POS.DataLayer.BDSupplierBase.Delete(new POS.DataLayer.BDSupplierPrimaryKey(pk.SupplierID));
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="BDSupplierPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class BDSupplier</returns>
		public BDSupplier SelectOne(BDSupplierPrimaryKey pk)
		{
			_bDSupplierWCF = new BDSupplier();
			_bDSupplier = POS.DataLayer.BDSupplierBase.SelectOne(new POS.DataLayer.BDSupplierPrimaryKey(pk.SupplierID));
			
				_bDSupplierWCF.SupplierID = _bDSupplier.SupplierID;
				_bDSupplierWCF.SupplierCode = _bDSupplier.SupplierCode;
				_bDSupplierWCF.SupplierName = _bDSupplier.SupplierName;
				_bDSupplierWCF.Address = _bDSupplier.Address;
				_bDSupplierWCF.Phone1 = _bDSupplier.Phone1;
				_bDSupplierWCF.phone2 = _bDSupplier.Phone2;
				_bDSupplierWCF.Mobile1 = _bDSupplier.Mobile1;
				_bDSupplierWCF.Mobile2 = _bDSupplier.Mobile2;
				_bDSupplierWCF.Email = _bDSupplier.Email;
				_bDSupplierWCF.IsActive = _bDSupplier.IsActive;
				_bDSupplierWCF.Debit = _bDSupplier.Debit;
				_bDSupplierWCF.Credit = _bDSupplier.Credit;
				
			return _bDSupplierWCF;
		}

		/// <summary>
		/// This method will return a list of objects representing all records in the table.
		/// </summary>
		///
		/// <returns>list of objects of class BDSupplier in the form of object of BDSupplierCollection </returns>
		public BDSupplierCollection SelectAll()
		{
			BDSupplierCollection bDSupplierCollection = new BDSupplierCollection();
			foreach (POS.DataLayer.BDSupplier _bDSupplier in POS.DataLayer.BDSupplierBase.SelectAll())
			{
				_bDSupplierWCF = new BDSupplier();
				
				_bDSupplierWCF.SupplierID = _bDSupplier.SupplierID;
				_bDSupplierWCF.SupplierCode = _bDSupplier.SupplierCode;
				_bDSupplierWCF.SupplierName = _bDSupplier.SupplierName;
				_bDSupplierWCF.Address = _bDSupplier.Address;
				_bDSupplierWCF.Phone1 = _bDSupplier.Phone1;
				_bDSupplierWCF.phone2 = _bDSupplier.Phone2;
				_bDSupplierWCF.Mobile1 = _bDSupplier.Mobile1;
				_bDSupplierWCF.Mobile2 = _bDSupplier.Mobile2;
				_bDSupplierWCF.Email = _bDSupplier.Email;
				_bDSupplierWCF.IsActive = _bDSupplier.IsActive;
				_bDSupplierWCF.Debit = _bDSupplier.Debit;
				_bDSupplierWCF.Credit = _bDSupplier.Credit;
				
				bDSupplierCollection.Add(_bDSupplierWCF);
			}
			return bDSupplierCollection;
		}
    
    /// <summary>
		/// This method will return a count all records in the table.
		/// </summary>
		///
		/// <returns>count records</returns>
		public int SelectAllCount()
		{
			return POS.DataLayer.BDSupplierBase.SelectAllCount();			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class BDSupplier</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class BDSupplier in the form of an object of class BDSupplierCollection</returns>
		public BDSupplierCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
		{
			BDSupplierCollection bDSupplierCollection = new BDSupplierCollection();
			foreach (POS.DataLayer.BDSupplier _bDSupplier in POS.DataLayer.BDSupplierBase.SelectByField(field, fieldValue, fieldValue2, typeOperation))
			{
				_bDSupplierWCF = new BDSupplier();
				
				_bDSupplierWCF.SupplierID = _bDSupplier.SupplierID;
				_bDSupplierWCF.SupplierCode = _bDSupplier.SupplierCode;
				_bDSupplierWCF.SupplierName = _bDSupplier.SupplierName;
				_bDSupplierWCF.Address = _bDSupplier.Address;
				_bDSupplierWCF.Phone1 = _bDSupplier.Phone1;
				_bDSupplierWCF.phone2 = _bDSupplier.Phone2;
				_bDSupplierWCF.Mobile1 = _bDSupplier.Mobile1;
				_bDSupplierWCF.Mobile2 = _bDSupplier.Mobile2;
				_bDSupplierWCF.Email = _bDSupplier.Email;
				_bDSupplierWCF.IsActive = _bDSupplier.IsActive;
				_bDSupplierWCF.Debit = _bDSupplier.Debit;
				_bDSupplierWCF.Credit = _bDSupplier.Credit;
				
				bDSupplierCollection.Add(_bDSupplierWCF);
			}
			return bDSupplierCollection;
		}
		
		/// <summary>
		/// This method will insert one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="bDSupplier" type="BDSupplier">This BDSupplier  will be inserted in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Insert(BDSupplier bDSupplier)
		{
			_bDSupplier = new POS.DataLayer.BDSupplier();
			_bDSupplier.SupplierID=bDSupplier.SupplierID;
			_bDSupplier.SupplierCode=bDSupplier.SupplierCode;
			_bDSupplier.SupplierName=bDSupplier.SupplierName;
			_bDSupplier.Address=bDSupplier.Address;
			_bDSupplier.Phone1=bDSupplier.Phone1;
			_bDSupplier.Phone2=bDSupplier.phone2;
			_bDSupplier.Mobile1=bDSupplier.Mobile1;
			_bDSupplier.Mobile2=bDSupplier.Mobile2;
			_bDSupplier.Email=bDSupplier.Email;
			_bDSupplier.IsActive=bDSupplier.IsActive;
			_bDSupplier.Debit=bDSupplier.Debit;
			_bDSupplier.Credit=bDSupplier.Credit;
			
			return _bDSupplier.Insert();
		}
		
		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>list of objects of class BDSupplier in the form of an object of class BDSupplierCollection </returns>
		public BDSupplierCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			BDSupplierCollection bDSupplierCollection = new BDSupplierCollection();
			foreach (POS.DataLayer.BDSupplier _bDSupplier in POS.DataLayer.BDSupplierBase.SelectAllPaged(pageSize, skipPages, orderByStatement))
			{
				_bDSupplierWCF = new BDSupplier();
				
				_bDSupplierWCF.SupplierID = _bDSupplier.SupplierID;
				_bDSupplierWCF.SupplierCode = _bDSupplier.SupplierCode;
				_bDSupplierWCF.SupplierName = _bDSupplier.SupplierName;
				_bDSupplierWCF.Address = _bDSupplier.Address;
				_bDSupplierWCF.Phone1 = _bDSupplier.Phone1;
				_bDSupplierWCF.phone2 = _bDSupplier.Phone2;
				_bDSupplierWCF.Mobile1 = _bDSupplier.Mobile1;
				_bDSupplierWCF.Mobile2 = _bDSupplier.Mobile2;
				_bDSupplierWCF.Email = _bDSupplier.Email;
				_bDSupplierWCF.IsActive = _bDSupplier.IsActive;
				_bDSupplierWCF.Debit = _bDSupplier.Debit;
				_bDSupplierWCF.Credit = _bDSupplier.Credit;
				
				bDSupplierCollection.Add(_bDSupplierWCF);
			}
			return bDSupplierCollection;
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class BDSupplier</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class BDSupplier in the form of an object of class BDSupplierCollection</returns>
		public BDSupplierCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
		{
			BDSupplierCollection bDSupplierCollection = new BDSupplierCollection();
			foreach (POS.DataLayer.BDSupplier _bDSupplier in POS.DataLayer.BDSupplierBase.SelectByFieldPaged(field, fieldValue, fieldValue2, typeOperation, pageSize, skipPages, orderByStatement))
			{
				_bDSupplierWCF = new BDSupplier();
				
				_bDSupplierWCF.SupplierID = _bDSupplier.SupplierID;
				_bDSupplierWCF.SupplierCode = _bDSupplier.SupplierCode;
				_bDSupplierWCF.SupplierName = _bDSupplier.SupplierName;
				_bDSupplierWCF.Address = _bDSupplier.Address;
				_bDSupplierWCF.Phone1 = _bDSupplier.Phone1;
				_bDSupplierWCF.phone2 = _bDSupplier.Phone2;
				_bDSupplierWCF.Mobile1 = _bDSupplier.Mobile1;
				_bDSupplierWCF.Mobile2 = _bDSupplier.Mobile2;
				_bDSupplierWCF.Email = _bDSupplier.Email;
				_bDSupplierWCF.IsActive = _bDSupplier.IsActive;
				_bDSupplierWCF.Debit = _bDSupplier.Debit;
				_bDSupplierWCF.Credit = _bDSupplier.Credit;
				
				bDSupplierCollection.Add(_bDSupplierWCF);
			}
			return bDSupplierCollection;
		}
			///<summary>
		/// This method will update one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="bDSupplier" type="BDSupplier">This BDSupplier  will be updated in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Update(BDSupplier bDSupplier)
		{
			_bDSupplier=POS.DataLayer.BDSupplier.SelectOne(new POS.DataLayer.BDSupplierPrimaryKey(bDSupplier.SupplierID));
			
			_bDSupplier.SupplierCode=bDSupplier.SupplierCode;
			_bDSupplier.SupplierName=bDSupplier.SupplierName;
			_bDSupplier.Address=bDSupplier.Address;
			_bDSupplier.Phone1=bDSupplier.Phone1;
			_bDSupplier.Phone2=bDSupplier.phone2;
			_bDSupplier.Mobile1=bDSupplier.Mobile1;
			_bDSupplier.Mobile2=bDSupplier.Mobile2;
			_bDSupplier.Email=bDSupplier.Email;
			_bDSupplier.IsActive=bDSupplier.IsActive;
			_bDSupplier.Debit=bDSupplier.Debit;
			_bDSupplier.Credit=bDSupplier.Credit;
			
			return _bDSupplier.Update();
		}
	} 
}
