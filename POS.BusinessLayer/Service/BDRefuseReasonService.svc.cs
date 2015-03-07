//
// Class	:	BDRefuseReasonServices.svc.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	3/7/2015 2:37:06 PM
//


using POS.DataLayer;

namespace POS.BusinessLayer
{
	///<summary>
	///WCF service for the BDRefuseReason
	///</summary>
	public class BDRefuseReasonService 
	{
		private BDRefuseReason _bDRefuseReasonWCF;
		private POS.DataLayer.BDRefuseReason _bDRefuseReason;
		
		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="BDRefuseReasonFields">Field of the class BDRefuseReason</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <returns>True if succeeded</returns>
		public bool DeleteByField(string field, object fieldValue)
		{
			return POS.DataLayer.BDRefuseReasonBase.DeleteByField(field, fieldValue);
		}

		///<summary>
		///This method will Delete the object from the database
		///</summary>
		///<param name="pk" type="BDRefuseReasonPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <returns>True if succeeded</returns>
		public bool Delete(BDRefuseReasonPrimaryKey pk)
		{
			return POS.DataLayer.BDRefuseReasonBase.Delete(new POS.DataLayer.BDRefuseReasonPrimaryKey(pk.RefuseReasonID));
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="BDRefuseReasonPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class BDRefuseReason</returns>
		public BDRefuseReason SelectOne(BDRefuseReasonPrimaryKey pk)
		{
			_bDRefuseReasonWCF = new BDRefuseReason();
			_bDRefuseReason = POS.DataLayer.BDRefuseReasonBase.SelectOne(new POS.DataLayer.BDRefuseReasonPrimaryKey(pk.RefuseReasonID));
			
				_bDRefuseReasonWCF.RefuseReasonID = _bDRefuseReason.RefuseReasonID;
				_bDRefuseReasonWCF.RefuseReasonName = _bDRefuseReason.RefuseReasonName;
				
			return _bDRefuseReasonWCF;
		}

		/// <summary>
		/// This method will return a list of objects representing all records in the table.
		/// </summary>
		///
		/// <returns>list of objects of class BDRefuseReason in the form of object of BDRefuseReasonCollection </returns>
		public BDRefuseReasonCollection SelectAll()
		{
			BDRefuseReasonCollection bDRefuseReasonCollection = new BDRefuseReasonCollection();
			foreach (POS.DataLayer.BDRefuseReason _bDRefuseReason in POS.DataLayer.BDRefuseReasonBase.SelectAll())
			{
				_bDRefuseReasonWCF = new BDRefuseReason();
				
				_bDRefuseReasonWCF.RefuseReasonID = _bDRefuseReason.RefuseReasonID;
				_bDRefuseReasonWCF.RefuseReasonName = _bDRefuseReason.RefuseReasonName;
				
				bDRefuseReasonCollection.Add(_bDRefuseReasonWCF);
			}
			return bDRefuseReasonCollection;
		}
    
    /// <summary>
		/// This method will return a count all records in the table.
		/// </summary>
		///
		/// <returns>count records</returns>
		public int SelectAllCount()
		{
			return POS.DataLayer.BDRefuseReasonBase.SelectAllCount();			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class BDRefuseReason</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class BDRefuseReason in the form of an object of class BDRefuseReasonCollection</returns>
		public BDRefuseReasonCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
		{
			BDRefuseReasonCollection bDRefuseReasonCollection = new BDRefuseReasonCollection();
			foreach (POS.DataLayer.BDRefuseReason _bDRefuseReason in POS.DataLayer.BDRefuseReasonBase.SelectByField(field, fieldValue, fieldValue2, typeOperation))
			{
				_bDRefuseReasonWCF = new BDRefuseReason();
				
				_bDRefuseReasonWCF.RefuseReasonID = _bDRefuseReason.RefuseReasonID;
				_bDRefuseReasonWCF.RefuseReasonName = _bDRefuseReason.RefuseReasonName;
				
				bDRefuseReasonCollection.Add(_bDRefuseReasonWCF);
			}
			return bDRefuseReasonCollection;
		}
		
		/// <summary>
		/// This method will insert one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="bDRefuseReason" type="BDRefuseReason">This BDRefuseReason  will be inserted in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Insert(BDRefuseReason bDRefuseReason)
		{
			_bDRefuseReason = new POS.DataLayer.BDRefuseReason();
			_bDRefuseReason.RefuseReasonID=bDRefuseReason.RefuseReasonID;
			_bDRefuseReason.RefuseReasonName=bDRefuseReason.RefuseReasonName;
			
			return _bDRefuseReason.Insert();
		}
		
		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>list of objects of class BDRefuseReason in the form of an object of class BDRefuseReasonCollection </returns>
		public BDRefuseReasonCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			BDRefuseReasonCollection bDRefuseReasonCollection = new BDRefuseReasonCollection();
			foreach (POS.DataLayer.BDRefuseReason _bDRefuseReason in POS.DataLayer.BDRefuseReasonBase.SelectAllPaged(pageSize, skipPages, orderByStatement))
			{
				_bDRefuseReasonWCF = new BDRefuseReason();
				
				_bDRefuseReasonWCF.RefuseReasonID = _bDRefuseReason.RefuseReasonID;
				_bDRefuseReasonWCF.RefuseReasonName = _bDRefuseReason.RefuseReasonName;
				
				bDRefuseReasonCollection.Add(_bDRefuseReasonWCF);
			}
			return bDRefuseReasonCollection;
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class BDRefuseReason</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class BDRefuseReason in the form of an object of class BDRefuseReasonCollection</returns>
		public BDRefuseReasonCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
		{
			BDRefuseReasonCollection bDRefuseReasonCollection = new BDRefuseReasonCollection();
			foreach (POS.DataLayer.BDRefuseReason _bDRefuseReason in POS.DataLayer.BDRefuseReasonBase.SelectByFieldPaged(field, fieldValue, fieldValue2, typeOperation, pageSize, skipPages, orderByStatement))
			{
				_bDRefuseReasonWCF = new BDRefuseReason();
				
				_bDRefuseReasonWCF.RefuseReasonID = _bDRefuseReason.RefuseReasonID;
				_bDRefuseReasonWCF.RefuseReasonName = _bDRefuseReason.RefuseReasonName;
				
				bDRefuseReasonCollection.Add(_bDRefuseReasonWCF);
			}
			return bDRefuseReasonCollection;
		}
			///<summary>
		/// This method will update one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="bDRefuseReason" type="BDRefuseReason">This BDRefuseReason  will be updated in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Update(BDRefuseReason bDRefuseReason)
		{
			_bDRefuseReason=POS.DataLayer.BDRefuseReason.SelectOne(new POS.DataLayer.BDRefuseReasonPrimaryKey(bDRefuseReason.RefuseReasonID));
			
			_bDRefuseReason.RefuseReasonName=bDRefuseReason.RefuseReasonName;
			
			return _bDRefuseReason.Update();
		}
	} 
}
