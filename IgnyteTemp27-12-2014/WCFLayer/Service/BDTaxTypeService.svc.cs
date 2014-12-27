//
// Class	:	BDTaxTypeServices.svc.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:55:53 PM
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
	///WCF service for the BDTaxType
	///</summary>
	public class BDTaxTypeService : IBDTaxTypeService
	{
		private BDTaxType _bDTaxTypeWCF;
		private POS.DataLayer.BDTaxType _bDTaxType;
		
		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="BDTaxTypeFields">Field of the class BDTaxType</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <returns>True if succeeded</returns>
		public bool DeleteByField(string field, object fieldValue)
		{
			return POS.DataLayer.BDTaxTypeBase.DeleteByField(field, fieldValue);
		}

		///<summary>
		///This method will Delete the object from the database
		///</summary>
		///<param name="pk" type="BDTaxTypePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <returns>True if succeeded</returns>
		public bool Delete(BDTaxTypePrimaryKey pk)
		{
			return POS.DataLayer.BDTaxTypeBase.Delete(new POS.DataLayer.BDTaxTypePrimaryKey(pk.TaxTypeID));
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="BDTaxTypePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class BDTaxType</returns>
		public BDTaxType SelectOne(BDTaxTypePrimaryKey pk)
		{
			_bDTaxTypeWCF = new BDTaxType();
			_bDTaxType = POS.DataLayer.BDTaxTypeBase.SelectOne(new POS.DataLayer.BDTaxTypePrimaryKey(pk.TaxTypeID));
			
				_bDTaxTypeWCF.TaxTypeID = _bDTaxType.TaxTypeID;
				_bDTaxTypeWCF.TaxTypeName = _bDTaxType.TaxTypeName;
				
			return _bDTaxTypeWCF;
		}

		/// <summary>
		/// This method will return a list of objects representing all records in the table.
		/// </summary>
		///
		/// <returns>list of objects of class BDTaxType in the form of object of BDTaxTypeCollection </returns>
		public BDTaxTypeCollection SelectAll()
		{
			BDTaxTypeCollection bDTaxTypeCollection = new BDTaxTypeCollection();
			foreach (POS.DataLayer.BDTaxType _bDTaxType in POS.DataLayer.BDTaxTypeBase.SelectAll())
			{
				_bDTaxTypeWCF = new BDTaxType();
				
				_bDTaxTypeWCF.TaxTypeID = _bDTaxType.TaxTypeID;
				_bDTaxTypeWCF.TaxTypeName = _bDTaxType.TaxTypeName;
				
				bDTaxTypeCollection.Add(_bDTaxTypeWCF);
			}
			return bDTaxTypeCollection;
		}
    
    /// <summary>
		/// This method will return a count all records in the table.
		/// </summary>
		///
		/// <returns>count records</returns>
		public int SelectAllCount()
		{
			return POS.DataLayer.BDTaxTypeBase.SelectAllCount();			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class BDTaxType</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class BDTaxType in the form of an object of class BDTaxTypeCollection</returns>
		public BDTaxTypeCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
		{
			BDTaxTypeCollection bDTaxTypeCollection = new BDTaxTypeCollection();
			foreach (POS.DataLayer.BDTaxType _bDTaxType in POS.DataLayer.BDTaxTypeBase.SelectByField(field, fieldValue, fieldValue2, typeOperation))
			{
				_bDTaxTypeWCF = new BDTaxType();
				
				_bDTaxTypeWCF.TaxTypeID = _bDTaxType.TaxTypeID;
				_bDTaxTypeWCF.TaxTypeName = _bDTaxType.TaxTypeName;
				
				bDTaxTypeCollection.Add(_bDTaxTypeWCF);
			}
			return bDTaxTypeCollection;
		}
		
		/// <summary>
		/// This method will insert one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="bDTaxType" type="BDTaxType">This BDTaxType  will be inserted in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Insert(BDTaxType bDTaxType)
		{
			_bDTaxType = new POS.DataLayer.BDTaxType();
			_bDTaxType.TaxTypeID=bDTaxType.TaxTypeID;
			_bDTaxType.TaxTypeName=bDTaxType.TaxTypeName;
			
			return _bDTaxType.Insert();
		}
		
		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>list of objects of class BDTaxType in the form of an object of class BDTaxTypeCollection </returns>
		public BDTaxTypeCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			BDTaxTypeCollection bDTaxTypeCollection = new BDTaxTypeCollection();
			foreach (POS.DataLayer.BDTaxType _bDTaxType in POS.DataLayer.BDTaxTypeBase.SelectAllPaged(pageSize, skipPages, orderByStatement))
			{
				_bDTaxTypeWCF = new BDTaxType();
				
				_bDTaxTypeWCF.TaxTypeID = _bDTaxType.TaxTypeID;
				_bDTaxTypeWCF.TaxTypeName = _bDTaxType.TaxTypeName;
				
				bDTaxTypeCollection.Add(_bDTaxTypeWCF);
			}
			return bDTaxTypeCollection;
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class BDTaxType</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class BDTaxType in the form of an object of class BDTaxTypeCollection</returns>
		public BDTaxTypeCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
		{
			BDTaxTypeCollection bDTaxTypeCollection = new BDTaxTypeCollection();
			foreach (POS.DataLayer.BDTaxType _bDTaxType in POS.DataLayer.BDTaxTypeBase.SelectByFieldPaged(field, fieldValue, fieldValue2, typeOperation, pageSize, skipPages, orderByStatement))
			{
				_bDTaxTypeWCF = new BDTaxType();
				
				_bDTaxTypeWCF.TaxTypeID = _bDTaxType.TaxTypeID;
				_bDTaxTypeWCF.TaxTypeName = _bDTaxType.TaxTypeName;
				
				bDTaxTypeCollection.Add(_bDTaxTypeWCF);
			}
			return bDTaxTypeCollection;
		}
			///<summary>
		/// This method will update one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="bDTaxType" type="BDTaxType">This BDTaxType  will be updated in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Update(BDTaxType bDTaxType)
		{
			_bDTaxType=POS.DataLayer.BDTaxType.SelectOne(new POS.DataLayer.BDTaxTypePrimaryKey(bDTaxType.TaxTypeID));
			
			_bDTaxType.TaxTypeName=bDTaxType.TaxTypeName;
			
			return _bDTaxType.Update();
		}
	} 
}
