//
// Class	:	INVProductStockBatchServices.svc.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:56:11 PM
//

  
using POS.DataLayer;

namespace POS.BusinessLayer
{
	///<summary>
	///WCF service for the INVProductStockBatch
	///</summary>
	public class INVProductStockBatchService 
	{
		private INVProductStockBatch _iNVProductStockBatchWCF;
		private POS.DataLayer.INVProductStockBatch _iNVProductStockBatch;
		
		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="INVProductStockBatchFields">Field of the class INVProductStockBatch</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <returns>True if succeeded</returns>
		public bool DeleteByField(string field, object fieldValue)
		{
			return POS.DataLayer.INVProductStockBatchBase.DeleteByField(field, fieldValue);
		}

		///<summary>
		///This method will Delete the object from the database
		///</summary>
		///<param name="pk" type="INVProductStockBatchPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <returns>True if succeeded</returns>
		public bool Delete(INVProductStockBatchPrimaryKey pk)
		{
			return POS.DataLayer.INVProductStockBatchBase.Delete(new POS.DataLayer.INVProductStockBatchPrimaryKey(pk.ProductStockBatchID));
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="INVProductStockBatchPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class INVProductStockBatch</returns>
		public INVProductStockBatch SelectOne(INVProductStockBatchPrimaryKey pk)
		{
			_iNVProductStockBatchWCF = new INVProductStockBatch();
			_iNVProductStockBatch = POS.DataLayer.INVProductStockBatchBase.SelectOne(new POS.DataLayer.INVProductStockBatchPrimaryKey(pk.ProductStockBatchID));
			
				_iNVProductStockBatchWCF.ProductStockBatchID = _iNVProductStockBatch.ProductStockBatchID;
				_iNVProductStockBatchWCF.ProductStockID = _iNVProductStockBatch.ProductStockID;
				_iNVProductStockBatchWCF.BatchID = _iNVProductStockBatch.BatchID;
				_iNVProductStockBatchWCF.Qty = _iNVProductStockBatch.Qty;
				
			return _iNVProductStockBatchWCF;
		}

		/// <summary>
		/// This method will return a list of objects representing all records in the table.
		/// </summary>
		///
		/// <returns>list of objects of class INVProductStockBatch in the form of object of INVProductStockBatchCollection </returns>
		public INVProductStockBatchCollection SelectAll()
		{
			INVProductStockBatchCollection iNVProductStockBatchCollection = new INVProductStockBatchCollection();
			foreach (POS.DataLayer.INVProductStockBatch _iNVProductStockBatch in POS.DataLayer.INVProductStockBatchBase.SelectAll())
			{
				_iNVProductStockBatchWCF = new INVProductStockBatch();
				
				_iNVProductStockBatchWCF.ProductStockBatchID = _iNVProductStockBatch.ProductStockBatchID;
				_iNVProductStockBatchWCF.ProductStockID = _iNVProductStockBatch.ProductStockID;
				_iNVProductStockBatchWCF.BatchID = _iNVProductStockBatch.BatchID;
				_iNVProductStockBatchWCF.Qty = _iNVProductStockBatch.Qty;
				
				iNVProductStockBatchCollection.Add(_iNVProductStockBatchWCF);
			}
			return iNVProductStockBatchCollection;
		}
    
    /// <summary>
		/// This method will return a count all records in the table.
		/// </summary>
		///
		/// <returns>count records</returns>
		public int SelectAllCount()
		{
			return POS.DataLayer.INVProductStockBatchBase.SelectAllCount();			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class INVProductStockBatch</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class INVProductStockBatch in the form of an object of class INVProductStockBatchCollection</returns>
		public INVProductStockBatchCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
		{
			INVProductStockBatchCollection iNVProductStockBatchCollection = new INVProductStockBatchCollection();
			foreach (POS.DataLayer.INVProductStockBatch _iNVProductStockBatch in POS.DataLayer.INVProductStockBatchBase.SelectByField(field, fieldValue, fieldValue2, typeOperation))
			{
				_iNVProductStockBatchWCF = new INVProductStockBatch();
				
				_iNVProductStockBatchWCF.ProductStockBatchID = _iNVProductStockBatch.ProductStockBatchID;
				_iNVProductStockBatchWCF.ProductStockID = _iNVProductStockBatch.ProductStockID;
				_iNVProductStockBatchWCF.BatchID = _iNVProductStockBatch.BatchID;
				_iNVProductStockBatchWCF.Qty = _iNVProductStockBatch.Qty;
				
				iNVProductStockBatchCollection.Add(_iNVProductStockBatchWCF);
			}
			return iNVProductStockBatchCollection;
		}
		
		/// <summary>
		/// This method will insert one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="iNVProductStockBatch" type="INVProductStockBatch">This INVProductStockBatch  will be inserted in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Insert(INVProductStockBatch iNVProductStockBatch)
		{
			_iNVProductStockBatch = new POS.DataLayer.INVProductStockBatch();
			_iNVProductStockBatch.ProductStockBatchID=iNVProductStockBatch.ProductStockBatchID;
			_iNVProductStockBatch.ProductStockID=iNVProductStockBatch.ProductStockID;
			_iNVProductStockBatch.BatchID=iNVProductStockBatch.BatchID;
			_iNVProductStockBatch.Qty=iNVProductStockBatch.Qty;
			
			return _iNVProductStockBatch.Insert();
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
			return POS.DataLayer.INVProductStockBatchBase.DeleteAllByForeignKeyBatchID(new POS.DataLayer.INVBatchPrimaryKey(pk.BatchID));
		}
		
		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="INVBatchPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class INVProductStockBatchCollection</returns>
		public INVProductStockBatchCollection SelectAllByForeignKeyBatchID(INVBatchPrimaryKey pk)
		{
			INVProductStockBatchCollection iNVProductStockBatchCollection=new INVProductStockBatchCollection();
			foreach (POS.DataLayer.INVProductStockBatch _iNVProductStockBatch in POS.DataLayer.INVProductStockBatchBase.SelectAllByForeignKeyBatchID(new POS.DataLayer.INVBatchPrimaryKey(pk.BatchID)))
			{
				_iNVProductStockBatchWCF = new INVProductStockBatch();
				_iNVProductStockBatchWCF.ProductStockBatchID = _iNVProductStockBatch.ProductStockBatchID;
				_iNVProductStockBatchWCF.ProductStockID = _iNVProductStockBatch.ProductStockID;
				_iNVProductStockBatchWCF.BatchID = _iNVProductStockBatch.BatchID;
				_iNVProductStockBatchWCF.Qty = _iNVProductStockBatch.Qty;
				
				iNVProductStockBatchCollection.Add(_iNVProductStockBatchWCF);
			}
			return iNVProductStockBatchCollection;
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
		/// <returns>object of class INVProductStockBatchCollection</returns>
		public INVProductStockBatchCollection SelectAllByForeignKeyBatchIDPaged(INVBatchPrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			INVProductStockBatchCollection iNVProductStockBatchCollection=new INVProductStockBatchCollection();
			foreach (POS.DataLayer.INVProductStockBatch _iNVProductStockBatch in POS.DataLayer.INVProductStockBatchBase.SelectAllByForeignKeyBatchIDPaged(new POS.DataLayer.INVBatchPrimaryKey(pk.BatchID), pageSize, skipPages, orderByStatement))
			{
				_iNVProductStockBatchWCF = new INVProductStockBatch();
				_iNVProductStockBatchWCF.ProductStockBatchID = _iNVProductStockBatch.ProductStockBatchID;
				_iNVProductStockBatchWCF.ProductStockID = _iNVProductStockBatch.ProductStockID;
				_iNVProductStockBatchWCF.BatchID = _iNVProductStockBatch.BatchID;
				_iNVProductStockBatchWCF.Qty = _iNVProductStockBatch.Qty;
				
				iNVProductStockBatchCollection.Add(_iNVProductStockBatchWCF);
			}
			return iNVProductStockBatchCollection;
		}
			/// <summary>
		/// This method will delete row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="INVProductStockPrimaryKey">Primary Key information based on which data is to be deleted.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool DeleteAllByForeignKeyProductStockID(INVProductStockPrimaryKey pk)
		{
			return POS.DataLayer.INVProductStockBatchBase.DeleteAllByForeignKeyProductStockID(new POS.DataLayer.INVProductStockPrimaryKey(pk.ProductStockID));
		}
		
		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="INVProductStockPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class INVProductStockBatchCollection</returns>
		public INVProductStockBatchCollection SelectAllByForeignKeyProductStockID(INVProductStockPrimaryKey pk)
		{
			INVProductStockBatchCollection iNVProductStockBatchCollection=new INVProductStockBatchCollection();
			foreach (POS.DataLayer.INVProductStockBatch _iNVProductStockBatch in POS.DataLayer.INVProductStockBatchBase.SelectAllByForeignKeyProductStockID(new POS.DataLayer.INVProductStockPrimaryKey(pk.ProductStockID)))
			{
				_iNVProductStockBatchWCF = new INVProductStockBatch();
				_iNVProductStockBatchWCF.ProductStockBatchID = _iNVProductStockBatch.ProductStockBatchID;
				_iNVProductStockBatchWCF.ProductStockID = _iNVProductStockBatch.ProductStockID;
				_iNVProductStockBatchWCF.BatchID = _iNVProductStockBatch.BatchID;
				_iNVProductStockBatchWCF.Qty = _iNVProductStockBatch.Qty;
				
				iNVProductStockBatchCollection.Add(_iNVProductStockBatchWCF);
			}
			return iNVProductStockBatchCollection;
		}
		
		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="INVProductStockPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>object of class INVProductStockBatchCollection</returns>
		public INVProductStockBatchCollection SelectAllByForeignKeyProductStockIDPaged(INVProductStockPrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			INVProductStockBatchCollection iNVProductStockBatchCollection=new INVProductStockBatchCollection();
			foreach (POS.DataLayer.INVProductStockBatch _iNVProductStockBatch in POS.DataLayer.INVProductStockBatchBase.SelectAllByForeignKeyProductStockIDPaged(new POS.DataLayer.INVProductStockPrimaryKey(pk.ProductStockID), pageSize, skipPages, orderByStatement))
			{
				_iNVProductStockBatchWCF = new INVProductStockBatch();
				_iNVProductStockBatchWCF.ProductStockBatchID = _iNVProductStockBatch.ProductStockBatchID;
				_iNVProductStockBatchWCF.ProductStockID = _iNVProductStockBatch.ProductStockID;
				_iNVProductStockBatchWCF.BatchID = _iNVProductStockBatch.BatchID;
				_iNVProductStockBatchWCF.Qty = _iNVProductStockBatch.Qty;
				
				iNVProductStockBatchCollection.Add(_iNVProductStockBatchWCF);
			}
			return iNVProductStockBatchCollection;
		}
			
		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>list of objects of class INVProductStockBatch in the form of an object of class INVProductStockBatchCollection </returns>
		public INVProductStockBatchCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			INVProductStockBatchCollection iNVProductStockBatchCollection = new INVProductStockBatchCollection();
			foreach (POS.DataLayer.INVProductStockBatch _iNVProductStockBatch in POS.DataLayer.INVProductStockBatchBase.SelectAllPaged(pageSize, skipPages, orderByStatement))
			{
				_iNVProductStockBatchWCF = new INVProductStockBatch();
				
				_iNVProductStockBatchWCF.ProductStockBatchID = _iNVProductStockBatch.ProductStockBatchID;
				_iNVProductStockBatchWCF.ProductStockID = _iNVProductStockBatch.ProductStockID;
				_iNVProductStockBatchWCF.BatchID = _iNVProductStockBatch.BatchID;
				_iNVProductStockBatchWCF.Qty = _iNVProductStockBatch.Qty;
				
				iNVProductStockBatchCollection.Add(_iNVProductStockBatchWCF);
			}
			return iNVProductStockBatchCollection;
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class INVProductStockBatch</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class INVProductStockBatch in the form of an object of class INVProductStockBatchCollection</returns>
		public INVProductStockBatchCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
		{
			INVProductStockBatchCollection iNVProductStockBatchCollection = new INVProductStockBatchCollection();
			foreach (POS.DataLayer.INVProductStockBatch _iNVProductStockBatch in POS.DataLayer.INVProductStockBatchBase.SelectByFieldPaged(field, fieldValue, fieldValue2, typeOperation, pageSize, skipPages, orderByStatement))
			{
				_iNVProductStockBatchWCF = new INVProductStockBatch();
				
				_iNVProductStockBatchWCF.ProductStockBatchID = _iNVProductStockBatch.ProductStockBatchID;
				_iNVProductStockBatchWCF.ProductStockID = _iNVProductStockBatch.ProductStockID;
				_iNVProductStockBatchWCF.BatchID = _iNVProductStockBatch.BatchID;
				_iNVProductStockBatchWCF.Qty = _iNVProductStockBatch.Qty;
				
				iNVProductStockBatchCollection.Add(_iNVProductStockBatchWCF);
			}
			return iNVProductStockBatchCollection;
		}
			///<summary>
		/// This method will update one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="iNVProductStockBatch" type="INVProductStockBatch">This INVProductStockBatch  will be updated in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Update(INVProductStockBatch iNVProductStockBatch)
		{
			_iNVProductStockBatch=POS.DataLayer.INVProductStockBatch.SelectOne(new POS.DataLayer.INVProductStockBatchPrimaryKey(iNVProductStockBatch.ProductStockBatchID));
			
			_iNVProductStockBatch.ProductStockID=iNVProductStockBatch.ProductStockID;
			_iNVProductStockBatch.BatchID=iNVProductStockBatch.BatchID;
			_iNVProductStockBatch.Qty=iNVProductStockBatch.Qty;
			
			return _iNVProductStockBatch.Update();
		}
	} 
}
