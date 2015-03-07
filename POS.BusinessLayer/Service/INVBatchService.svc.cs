//
// Class	:	INVBatchServices.svc.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	3/7/2015 2:37:09 PM
//


using POS.DataLayer;

namespace POS.BusinessLayer
{
	///<summary>
	///WCF service for the INVBatch
	///</summary>
	public class INVBatchService 
	{
		private INVBatch _iNVBatchWCF;
		private POS.DataLayer.INVBatch _iNVBatch;
		
		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="INVBatchFields">Field of the class INVBatch</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <returns>True if succeeded</returns>
		public bool DeleteByField(string field, object fieldValue)
		{
			return POS.DataLayer.INVBatchBase.DeleteByField(field, fieldValue);
		}

		///<summary>
		///This method will Delete the object from the database
		///</summary>
		///<param name="pk" type="INVBatchPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <returns>True if succeeded</returns>
		public bool Delete(INVBatchPrimaryKey pk)
		{
			return POS.DataLayer.INVBatchBase.Delete(new POS.DataLayer.INVBatchPrimaryKey(pk.BatchID));
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="INVBatchPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class INVBatch</returns>
		public INVBatch SelectOne(INVBatchPrimaryKey pk)
		{
			_iNVBatchWCF = new INVBatch();
			_iNVBatch = POS.DataLayer.INVBatchBase.SelectOne(new POS.DataLayer.INVBatchPrimaryKey(pk.BatchID));
			
				_iNVBatchWCF.BatchID = _iNVBatch.BatchID;
				_iNVBatchWCF.BatchNumber = _iNVBatch.BatchNumber;
				_iNVBatchWCF.ExpiryDate = _iNVBatch.ExpiryDate;
				
			return _iNVBatchWCF;
		}

		/// <summary>
		/// This method will return a list of objects representing all records in the table.
		/// </summary>
		///
		/// <returns>list of objects of class INVBatch in the form of object of INVBatchCollection </returns>
		public INVBatchCollection SelectAll()
		{
			INVBatchCollection iNVBatchCollection = new INVBatchCollection();
			foreach (POS.DataLayer.INVBatch _iNVBatch in POS.DataLayer.INVBatchBase.SelectAll())
			{
				_iNVBatchWCF = new INVBatch();
				
				_iNVBatchWCF.BatchID = _iNVBatch.BatchID;
				_iNVBatchWCF.BatchNumber = _iNVBatch.BatchNumber;
				_iNVBatchWCF.ExpiryDate = _iNVBatch.ExpiryDate;
				
				iNVBatchCollection.Add(_iNVBatchWCF);
			}
			return iNVBatchCollection;
		}
    
    /// <summary>
		/// This method will return a count all records in the table.
		/// </summary>
		///
		/// <returns>count records</returns>
		public int SelectAllCount()
		{
			return POS.DataLayer.INVBatchBase.SelectAllCount();			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class INVBatch</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class INVBatch in the form of an object of class INVBatchCollection</returns>
		public INVBatchCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
		{
			INVBatchCollection iNVBatchCollection = new INVBatchCollection();
			foreach (POS.DataLayer.INVBatch _iNVBatch in POS.DataLayer.INVBatchBase.SelectByField(field, fieldValue, fieldValue2, typeOperation))
			{
				_iNVBatchWCF = new INVBatch();
				
				_iNVBatchWCF.BatchID = _iNVBatch.BatchID;
				_iNVBatchWCF.BatchNumber = _iNVBatch.BatchNumber;
				_iNVBatchWCF.ExpiryDate = _iNVBatch.ExpiryDate;
				
				iNVBatchCollection.Add(_iNVBatchWCF);
			}
			return iNVBatchCollection;
		}
		
		/// <summary>
		/// This method will insert one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="iNVBatch" type="INVBatch">This INVBatch  will be inserted in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Insert(INVBatch iNVBatch)
		{
			_iNVBatch = new POS.DataLayer.INVBatch();
			_iNVBatch.BatchID=iNVBatch.BatchID;
			_iNVBatch.BatchNumber=iNVBatch.BatchNumber;
			_iNVBatch.ExpiryDate=iNVBatch.ExpiryDate;
			
			return _iNVBatch.Insert();
		}
		
		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>list of objects of class INVBatch in the form of an object of class INVBatchCollection </returns>
		public INVBatchCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			INVBatchCollection iNVBatchCollection = new INVBatchCollection();
			foreach (POS.DataLayer.INVBatch _iNVBatch in POS.DataLayer.INVBatchBase.SelectAllPaged(pageSize, skipPages, orderByStatement))
			{
				_iNVBatchWCF = new INVBatch();
				
				_iNVBatchWCF.BatchID = _iNVBatch.BatchID;
				_iNVBatchWCF.BatchNumber = _iNVBatch.BatchNumber;
				_iNVBatchWCF.ExpiryDate = _iNVBatch.ExpiryDate;
				
				iNVBatchCollection.Add(_iNVBatchWCF);
			}
			return iNVBatchCollection;
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class INVBatch</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class INVBatch in the form of an object of class INVBatchCollection</returns>
		public INVBatchCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
		{
			INVBatchCollection iNVBatchCollection = new INVBatchCollection();
			foreach (POS.DataLayer.INVBatch _iNVBatch in POS.DataLayer.INVBatchBase.SelectByFieldPaged(field, fieldValue, fieldValue2, typeOperation, pageSize, skipPages, orderByStatement))
			{
				_iNVBatchWCF = new INVBatch();
				
				_iNVBatchWCF.BatchID = _iNVBatch.BatchID;
				_iNVBatchWCF.BatchNumber = _iNVBatch.BatchNumber;
				_iNVBatchWCF.ExpiryDate = _iNVBatch.ExpiryDate;
				
				iNVBatchCollection.Add(_iNVBatchWCF);
			}
			return iNVBatchCollection;
		}
			///<summary>
		/// This method will update one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="iNVBatch" type="INVBatch">This INVBatch  will be updated in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Update(INVBatch iNVBatch)
		{
			_iNVBatch=POS.DataLayer.INVBatch.SelectOne(new POS.DataLayer.INVBatchPrimaryKey(iNVBatch.BatchID));
			
			_iNVBatch.BatchNumber=iNVBatch.BatchNumber;
			_iNVBatch.ExpiryDate=iNVBatch.ExpiryDate;
			
			return _iNVBatch.Update();
		}
	} 
}
