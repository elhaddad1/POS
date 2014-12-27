//
// Class	:	PURPurchaseLineBatchServices.svc.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:56:15 PM
//


using POS.DataLayer;

namespace POS.BusinessLayer
{
	///<summary>
	///WCF service for the PURPurchaseLineBatch
	///</summary>
	public class PURPurchaseLineBatchService 
	{
		private PURPurchaseLineBatch _pURPurchaseLineBatchWCF;
		private POS.DataLayer.PURPurchaseLineBatch _pURPurchaseLineBatch;
		
		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="PURPurchaseLineBatchFields">Field of the class PURPurchaseLineBatch</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <returns>True if succeeded</returns>
		public bool DeleteByField(string field, object fieldValue)
		{
			return POS.DataLayer.PURPurchaseLineBatchBase.DeleteByField(field, fieldValue);
		}

		///<summary>
		///This method will Delete the object from the database
		///</summary>
		///<param name="pk" type="PURPurchaseLineBatchPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <returns>True if succeeded</returns>
		public bool Delete(PURPurchaseLineBatchPrimaryKey pk)
		{
			return POS.DataLayer.PURPurchaseLineBatchBase.Delete(new POS.DataLayer.PURPurchaseLineBatchPrimaryKey(pk.PurchaseLineBatchID));
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="PURPurchaseLineBatchPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class PURPurchaseLineBatch</returns>
		public PURPurchaseLineBatch SelectOne(PURPurchaseLineBatchPrimaryKey pk)
		{
			_pURPurchaseLineBatchWCF = new PURPurchaseLineBatch();
			_pURPurchaseLineBatch = POS.DataLayer.PURPurchaseLineBatchBase.SelectOne(new POS.DataLayer.PURPurchaseLineBatchPrimaryKey(pk.PurchaseLineBatchID));
			
				_pURPurchaseLineBatchWCF.PurchaseLineBatchID = _pURPurchaseLineBatch.PurchaseLineBatchID;
				_pURPurchaseLineBatchWCF.PurchaseLineID = _pURPurchaseLineBatch.PurchaseLineID;
				_pURPurchaseLineBatchWCF.BatchID = _pURPurchaseLineBatch.BatchID;
				
			return _pURPurchaseLineBatchWCF;
		}

		/// <summary>
		/// This method will return a list of objects representing all records in the table.
		/// </summary>
		///
		/// <returns>list of objects of class PURPurchaseLineBatch in the form of object of PURPurchaseLineBatchCollection </returns>
		public PURPurchaseLineBatchCollection SelectAll()
		{
			PURPurchaseLineBatchCollection pURPurchaseLineBatchCollection = new PURPurchaseLineBatchCollection();
			foreach (POS.DataLayer.PURPurchaseLineBatch _pURPurchaseLineBatch in POS.DataLayer.PURPurchaseLineBatchBase.SelectAll())
			{
				_pURPurchaseLineBatchWCF = new PURPurchaseLineBatch();
				
				_pURPurchaseLineBatchWCF.PurchaseLineBatchID = _pURPurchaseLineBatch.PurchaseLineBatchID;
				_pURPurchaseLineBatchWCF.PurchaseLineID = _pURPurchaseLineBatch.PurchaseLineID;
				_pURPurchaseLineBatchWCF.BatchID = _pURPurchaseLineBatch.BatchID;
				
				pURPurchaseLineBatchCollection.Add(_pURPurchaseLineBatchWCF);
			}
			return pURPurchaseLineBatchCollection;
		}
    
    /// <summary>
		/// This method will return a count all records in the table.
		/// </summary>
		///
		/// <returns>count records</returns>
		public int SelectAllCount()
		{
			return POS.DataLayer.PURPurchaseLineBatchBase.SelectAllCount();			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class PURPurchaseLineBatch</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class PURPurchaseLineBatch in the form of an object of class PURPurchaseLineBatchCollection</returns>
		public PURPurchaseLineBatchCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
		{
			PURPurchaseLineBatchCollection pURPurchaseLineBatchCollection = new PURPurchaseLineBatchCollection();
			foreach (POS.DataLayer.PURPurchaseLineBatch _pURPurchaseLineBatch in POS.DataLayer.PURPurchaseLineBatchBase.SelectByField(field, fieldValue, fieldValue2, typeOperation))
			{
				_pURPurchaseLineBatchWCF = new PURPurchaseLineBatch();
				
				_pURPurchaseLineBatchWCF.PurchaseLineBatchID = _pURPurchaseLineBatch.PurchaseLineBatchID;
				_pURPurchaseLineBatchWCF.PurchaseLineID = _pURPurchaseLineBatch.PurchaseLineID;
				_pURPurchaseLineBatchWCF.BatchID = _pURPurchaseLineBatch.BatchID;
				
				pURPurchaseLineBatchCollection.Add(_pURPurchaseLineBatchWCF);
			}
			return pURPurchaseLineBatchCollection;
		}
		
		/// <summary>
		/// This method will insert one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="pURPurchaseLineBatch" type="PURPurchaseLineBatch">This PURPurchaseLineBatch  will be inserted in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Insert(PURPurchaseLineBatch pURPurchaseLineBatch)
		{
			_pURPurchaseLineBatch = new POS.DataLayer.PURPurchaseLineBatch();
			_pURPurchaseLineBatch.PurchaseLineBatchID=pURPurchaseLineBatch.PurchaseLineBatchID;
			_pURPurchaseLineBatch.PurchaseLineID=pURPurchaseLineBatch.PurchaseLineID;
			_pURPurchaseLineBatch.BatchID=pURPurchaseLineBatch.BatchID;
			
			return _pURPurchaseLineBatch.Insert();
		}
		/// <summary>
		/// This method will delete row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="INVBatchPrimaryKey">Primary Key information based on which data is to be deleted.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool DeleteAllByForeignKeyBatchID(INVBatchPrimaryKey pk)
		{
			return POS.DataLayer.PURPurchaseLineBatchBase.DeleteAllByForeignKeyBatchID(new POS.DataLayer.INVBatchPrimaryKey(pk.BatchID));
		}
		
		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="INVBatchPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class PURPurchaseLineBatchCollection</returns>
		public PURPurchaseLineBatchCollection SelectAllByForeignKeyBatchID(INVBatchPrimaryKey pk)
		{
			PURPurchaseLineBatchCollection pURPurchaseLineBatchCollection=new PURPurchaseLineBatchCollection();
			foreach (POS.DataLayer.PURPurchaseLineBatch _pURPurchaseLineBatch in POS.DataLayer.PURPurchaseLineBatchBase.SelectAllByForeignKeyBatchID(new POS.DataLayer.INVBatchPrimaryKey(pk.BatchID)))
			{
				_pURPurchaseLineBatchWCF = new PURPurchaseLineBatch();
				_pURPurchaseLineBatchWCF.PurchaseLineBatchID = _pURPurchaseLineBatch.PurchaseLineBatchID;
				_pURPurchaseLineBatchWCF.PurchaseLineID = _pURPurchaseLineBatch.PurchaseLineID;
				_pURPurchaseLineBatchWCF.BatchID = _pURPurchaseLineBatch.BatchID;
				
				pURPurchaseLineBatchCollection.Add(_pURPurchaseLineBatchWCF);
			}
			return pURPurchaseLineBatchCollection;
		}
		
		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="INVBatchPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>object of class PURPurchaseLineBatchCollection</returns>
		public PURPurchaseLineBatchCollection SelectAllByForeignKeyBatchIDPaged(INVBatchPrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			PURPurchaseLineBatchCollection pURPurchaseLineBatchCollection=new PURPurchaseLineBatchCollection();
			foreach (POS.DataLayer.PURPurchaseLineBatch _pURPurchaseLineBatch in POS.DataLayer.PURPurchaseLineBatchBase.SelectAllByForeignKeyBatchIDPaged(new POS.DataLayer.INVBatchPrimaryKey(pk.BatchID), pageSize, skipPages, orderByStatement))
			{
				_pURPurchaseLineBatchWCF = new PURPurchaseLineBatch();
				_pURPurchaseLineBatchWCF.PurchaseLineBatchID = _pURPurchaseLineBatch.PurchaseLineBatchID;
				_pURPurchaseLineBatchWCF.PurchaseLineID = _pURPurchaseLineBatch.PurchaseLineID;
				_pURPurchaseLineBatchWCF.BatchID = _pURPurchaseLineBatch.BatchID;
				
				pURPurchaseLineBatchCollection.Add(_pURPurchaseLineBatchWCF);
			}
			return pURPurchaseLineBatchCollection;
		}
			/// <summary>
		/// This method will delete row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="PURPurchaseLinePrimaryKey">Primary Key information based on which data is to be deleted.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool DeleteAllByForeignKeyPurchaseLineID(PURPurchaseLinePrimaryKey pk)
		{
			return POS.DataLayer.PURPurchaseLineBatchBase.DeleteAllByForeignKeyPurchaseLineID(new POS.DataLayer.PURPurchaseLinePrimaryKey(pk.PurchaseLineID));
		}
		
		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="PURPurchaseLinePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class PURPurchaseLineBatchCollection</returns>
		public PURPurchaseLineBatchCollection SelectAllByForeignKeyPurchaseLineID(PURPurchaseLinePrimaryKey pk)
		{
			PURPurchaseLineBatchCollection pURPurchaseLineBatchCollection=new PURPurchaseLineBatchCollection();
			foreach (POS.DataLayer.PURPurchaseLineBatch _pURPurchaseLineBatch in POS.DataLayer.PURPurchaseLineBatchBase.SelectAllByForeignKeyPurchaseLineID(new POS.DataLayer.PURPurchaseLinePrimaryKey(pk.PurchaseLineID)))
			{
				_pURPurchaseLineBatchWCF = new PURPurchaseLineBatch();
				_pURPurchaseLineBatchWCF.PurchaseLineBatchID = _pURPurchaseLineBatch.PurchaseLineBatchID;
				_pURPurchaseLineBatchWCF.PurchaseLineID = _pURPurchaseLineBatch.PurchaseLineID;
				_pURPurchaseLineBatchWCF.BatchID = _pURPurchaseLineBatch.BatchID;
				
				pURPurchaseLineBatchCollection.Add(_pURPurchaseLineBatchWCF);
			}
			return pURPurchaseLineBatchCollection;
		}
		
		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="PURPurchaseLinePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>object of class PURPurchaseLineBatchCollection</returns>
		public PURPurchaseLineBatchCollection SelectAllByForeignKeyPurchaseLineIDPaged(PURPurchaseLinePrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			PURPurchaseLineBatchCollection pURPurchaseLineBatchCollection=new PURPurchaseLineBatchCollection();
			foreach (POS.DataLayer.PURPurchaseLineBatch _pURPurchaseLineBatch in POS.DataLayer.PURPurchaseLineBatchBase.SelectAllByForeignKeyPurchaseLineIDPaged(new POS.DataLayer.PURPurchaseLinePrimaryKey(pk.PurchaseLineID), pageSize, skipPages, orderByStatement))
			{
				_pURPurchaseLineBatchWCF = new PURPurchaseLineBatch();
				_pURPurchaseLineBatchWCF.PurchaseLineBatchID = _pURPurchaseLineBatch.PurchaseLineBatchID;
				_pURPurchaseLineBatchWCF.PurchaseLineID = _pURPurchaseLineBatch.PurchaseLineID;
				_pURPurchaseLineBatchWCF.BatchID = _pURPurchaseLineBatch.BatchID;
				
				pURPurchaseLineBatchCollection.Add(_pURPurchaseLineBatchWCF);
			}
			return pURPurchaseLineBatchCollection;
		}
			
		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>list of objects of class PURPurchaseLineBatch in the form of an object of class PURPurchaseLineBatchCollection </returns>
		public PURPurchaseLineBatchCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			PURPurchaseLineBatchCollection pURPurchaseLineBatchCollection = new PURPurchaseLineBatchCollection();
			foreach (POS.DataLayer.PURPurchaseLineBatch _pURPurchaseLineBatch in POS.DataLayer.PURPurchaseLineBatchBase.SelectAllPaged(pageSize, skipPages, orderByStatement))
			{
				_pURPurchaseLineBatchWCF = new PURPurchaseLineBatch();
				
				_pURPurchaseLineBatchWCF.PurchaseLineBatchID = _pURPurchaseLineBatch.PurchaseLineBatchID;
				_pURPurchaseLineBatchWCF.PurchaseLineID = _pURPurchaseLineBatch.PurchaseLineID;
				_pURPurchaseLineBatchWCF.BatchID = _pURPurchaseLineBatch.BatchID;
				
				pURPurchaseLineBatchCollection.Add(_pURPurchaseLineBatchWCF);
			}
			return pURPurchaseLineBatchCollection;
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class PURPurchaseLineBatch</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class PURPurchaseLineBatch in the form of an object of class PURPurchaseLineBatchCollection</returns>
		public PURPurchaseLineBatchCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
		{
			PURPurchaseLineBatchCollection pURPurchaseLineBatchCollection = new PURPurchaseLineBatchCollection();
			foreach (POS.DataLayer.PURPurchaseLineBatch _pURPurchaseLineBatch in POS.DataLayer.PURPurchaseLineBatchBase.SelectByFieldPaged(field, fieldValue, fieldValue2, typeOperation, pageSize, skipPages, orderByStatement))
			{
				_pURPurchaseLineBatchWCF = new PURPurchaseLineBatch();
				
				_pURPurchaseLineBatchWCF.PurchaseLineBatchID = _pURPurchaseLineBatch.PurchaseLineBatchID;
				_pURPurchaseLineBatchWCF.PurchaseLineID = _pURPurchaseLineBatch.PurchaseLineID;
				_pURPurchaseLineBatchWCF.BatchID = _pURPurchaseLineBatch.BatchID;
				
				pURPurchaseLineBatchCollection.Add(_pURPurchaseLineBatchWCF);
			}
			return pURPurchaseLineBatchCollection;
		}
			///<summary>
		/// This method will update one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="pURPurchaseLineBatch" type="PURPurchaseLineBatch">This PURPurchaseLineBatch  will be updated in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Update(PURPurchaseLineBatch pURPurchaseLineBatch)
		{
			_pURPurchaseLineBatch=POS.DataLayer.PURPurchaseLineBatch.SelectOne(new POS.DataLayer.PURPurchaseLineBatchPrimaryKey(pURPurchaseLineBatch.PurchaseLineBatchID));
			
			_pURPurchaseLineBatch.PurchaseLineID=pURPurchaseLineBatch.PurchaseLineID;
			_pURPurchaseLineBatch.BatchID=pURPurchaseLineBatch.BatchID;
			
			return _pURPurchaseLineBatch.Update();
		}
	} 
}
