//
// Class	:	INVTakingInventoryLineBatchServices.svc.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:56:16 PM
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
	///WCF service for the INVTakingInventoryLineBatch
	///</summary>
	public class INVTakingInventoryLineBatchService : IINVTakingInventoryLineBatchService
	{
		private INVTakingInventoryLineBatch _iNVTakingInventoryLineBatchWCF;
		private POS.DataLayer.INVTakingInventoryLineBatch _iNVTakingInventoryLineBatch;
		
		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="INVTakingInventoryLineBatchFields">Field of the class INVTakingInventoryLineBatch</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <returns>True if succeeded</returns>
		public bool DeleteByField(string field, object fieldValue)
		{
			return POS.DataLayer.INVTakingInventoryLineBatchBase.DeleteByField(field, fieldValue);
		}

		///<summary>
		///This method will Delete the object from the database
		///</summary>
		///<param name="pk" type="INVTakingInventoryLineBatchPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <returns>True if succeeded</returns>
		public bool Delete(INVTakingInventoryLineBatchPrimaryKey pk)
		{
			return POS.DataLayer.INVTakingInventoryLineBatchBase.Delete(new POS.DataLayer.INVTakingInventoryLineBatchPrimaryKey(pk.TakingLineBatchID));
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="INVTakingInventoryLineBatchPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class INVTakingInventoryLineBatch</returns>
		public INVTakingInventoryLineBatch SelectOne(INVTakingInventoryLineBatchPrimaryKey pk)
		{
			_iNVTakingInventoryLineBatchWCF = new INVTakingInventoryLineBatch();
			_iNVTakingInventoryLineBatch = POS.DataLayer.INVTakingInventoryLineBatchBase.SelectOne(new POS.DataLayer.INVTakingInventoryLineBatchPrimaryKey(pk.TakingLineBatchID));
			
				_iNVTakingInventoryLineBatchWCF.TakingLineBatchID = _iNVTakingInventoryLineBatch.TakingLineBatchID;
				_iNVTakingInventoryLineBatchWCF.TakingLineID = _iNVTakingInventoryLineBatch.TakingLineID;
				_iNVTakingInventoryLineBatchWCF.BatchID = _iNVTakingInventoryLineBatch.BatchID;
				
			return _iNVTakingInventoryLineBatchWCF;
		}

		/// <summary>
		/// This method will return a list of objects representing all records in the table.
		/// </summary>
		///
		/// <returns>list of objects of class INVTakingInventoryLineBatch in the form of object of INVTakingInventoryLineBatchCollection </returns>
		public INVTakingInventoryLineBatchCollection SelectAll()
		{
			INVTakingInventoryLineBatchCollection iNVTakingInventoryLineBatchCollection = new INVTakingInventoryLineBatchCollection();
			foreach (POS.DataLayer.INVTakingInventoryLineBatch _iNVTakingInventoryLineBatch in POS.DataLayer.INVTakingInventoryLineBatchBase.SelectAll())
			{
				_iNVTakingInventoryLineBatchWCF = new INVTakingInventoryLineBatch();
				
				_iNVTakingInventoryLineBatchWCF.TakingLineBatchID = _iNVTakingInventoryLineBatch.TakingLineBatchID;
				_iNVTakingInventoryLineBatchWCF.TakingLineID = _iNVTakingInventoryLineBatch.TakingLineID;
				_iNVTakingInventoryLineBatchWCF.BatchID = _iNVTakingInventoryLineBatch.BatchID;
				
				iNVTakingInventoryLineBatchCollection.Add(_iNVTakingInventoryLineBatchWCF);
			}
			return iNVTakingInventoryLineBatchCollection;
		}
    
    /// <summary>
		/// This method will return a count all records in the table.
		/// </summary>
		///
		/// <returns>count records</returns>
		public int SelectAllCount()
		{
			return POS.DataLayer.INVTakingInventoryLineBatchBase.SelectAllCount();			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class INVTakingInventoryLineBatch</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class INVTakingInventoryLineBatch in the form of an object of class INVTakingInventoryLineBatchCollection</returns>
		public INVTakingInventoryLineBatchCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
		{
			INVTakingInventoryLineBatchCollection iNVTakingInventoryLineBatchCollection = new INVTakingInventoryLineBatchCollection();
			foreach (POS.DataLayer.INVTakingInventoryLineBatch _iNVTakingInventoryLineBatch in POS.DataLayer.INVTakingInventoryLineBatchBase.SelectByField(field, fieldValue, fieldValue2, typeOperation))
			{
				_iNVTakingInventoryLineBatchWCF = new INVTakingInventoryLineBatch();
				
				_iNVTakingInventoryLineBatchWCF.TakingLineBatchID = _iNVTakingInventoryLineBatch.TakingLineBatchID;
				_iNVTakingInventoryLineBatchWCF.TakingLineID = _iNVTakingInventoryLineBatch.TakingLineID;
				_iNVTakingInventoryLineBatchWCF.BatchID = _iNVTakingInventoryLineBatch.BatchID;
				
				iNVTakingInventoryLineBatchCollection.Add(_iNVTakingInventoryLineBatchWCF);
			}
			return iNVTakingInventoryLineBatchCollection;
		}
		
		/// <summary>
		/// This method will insert one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="iNVTakingInventoryLineBatch" type="INVTakingInventoryLineBatch">This INVTakingInventoryLineBatch  will be inserted in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Insert(INVTakingInventoryLineBatch iNVTakingInventoryLineBatch)
		{
			_iNVTakingInventoryLineBatch = new POS.DataLayer.INVTakingInventoryLineBatch();
			_iNVTakingInventoryLineBatch.TakingLineBatchID=iNVTakingInventoryLineBatch.TakingLineBatchID;
			_iNVTakingInventoryLineBatch.TakingLineID=iNVTakingInventoryLineBatch.TakingLineID;
			_iNVTakingInventoryLineBatch.BatchID=iNVTakingInventoryLineBatch.BatchID;
			
			return _iNVTakingInventoryLineBatch.Insert();
		}
		/// <summary>
		/// This method will delete row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="PURPurchaseLinePrimaryKey">Primary Key information based on which data is to be deleted.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool DeleteAllByForeignKeyTakingLineID(PURPurchaseLinePrimaryKey pk)
		{
			return POS.DataLayer.INVTakingInventoryLineBatchBase.DeleteAllByForeignKeyTakingLineID(new POS.DataLayer.PURPurchaseLinePrimaryKey(pk.PurchaseLineID));
		}
		
		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="PURPurchaseLinePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class INVTakingInventoryLineBatchCollection</returns>
		public INVTakingInventoryLineBatchCollection SelectAllByForeignKeyTakingLineID(PURPurchaseLinePrimaryKey pk)
		{
			INVTakingInventoryLineBatchCollection iNVTakingInventoryLineBatchCollection=new INVTakingInventoryLineBatchCollection();
			foreach (POS.DataLayer.INVTakingInventoryLineBatch _iNVTakingInventoryLineBatch in POS.DataLayer.INVTakingInventoryLineBatchBase.SelectAllByForeignKeyTakingLineID(new POS.DataLayer.PURPurchaseLinePrimaryKey(pk.PurchaseLineID)))
			{
				_iNVTakingInventoryLineBatchWCF = new INVTakingInventoryLineBatch();
				_iNVTakingInventoryLineBatchWCF.TakingLineBatchID = _iNVTakingInventoryLineBatch.TakingLineBatchID;
				_iNVTakingInventoryLineBatchWCF.TakingLineID = _iNVTakingInventoryLineBatch.TakingLineID;
				_iNVTakingInventoryLineBatchWCF.BatchID = _iNVTakingInventoryLineBatch.BatchID;
				
				iNVTakingInventoryLineBatchCollection.Add(_iNVTakingInventoryLineBatchWCF);
			}
			return iNVTakingInventoryLineBatchCollection;
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
		/// <returns>object of class INVTakingInventoryLineBatchCollection</returns>
		public INVTakingInventoryLineBatchCollection SelectAllByForeignKeyTakingLineIDPaged(PURPurchaseLinePrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			INVTakingInventoryLineBatchCollection iNVTakingInventoryLineBatchCollection=new INVTakingInventoryLineBatchCollection();
			foreach (POS.DataLayer.INVTakingInventoryLineBatch _iNVTakingInventoryLineBatch in POS.DataLayer.INVTakingInventoryLineBatchBase.SelectAllByForeignKeyTakingLineIDPaged(new POS.DataLayer.PURPurchaseLinePrimaryKey(pk.PurchaseLineID), pageSize, skipPages, orderByStatement))
			{
				_iNVTakingInventoryLineBatchWCF = new INVTakingInventoryLineBatch();
				_iNVTakingInventoryLineBatchWCF.TakingLineBatchID = _iNVTakingInventoryLineBatch.TakingLineBatchID;
				_iNVTakingInventoryLineBatchWCF.TakingLineID = _iNVTakingInventoryLineBatch.TakingLineID;
				_iNVTakingInventoryLineBatchWCF.BatchID = _iNVTakingInventoryLineBatch.BatchID;
				
				iNVTakingInventoryLineBatchCollection.Add(_iNVTakingInventoryLineBatchWCF);
			}
			return iNVTakingInventoryLineBatchCollection;
		}
			
		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>list of objects of class INVTakingInventoryLineBatch in the form of an object of class INVTakingInventoryLineBatchCollection </returns>
		public INVTakingInventoryLineBatchCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			INVTakingInventoryLineBatchCollection iNVTakingInventoryLineBatchCollection = new INVTakingInventoryLineBatchCollection();
			foreach (POS.DataLayer.INVTakingInventoryLineBatch _iNVTakingInventoryLineBatch in POS.DataLayer.INVTakingInventoryLineBatchBase.SelectAllPaged(pageSize, skipPages, orderByStatement))
			{
				_iNVTakingInventoryLineBatchWCF = new INVTakingInventoryLineBatch();
				
				_iNVTakingInventoryLineBatchWCF.TakingLineBatchID = _iNVTakingInventoryLineBatch.TakingLineBatchID;
				_iNVTakingInventoryLineBatchWCF.TakingLineID = _iNVTakingInventoryLineBatch.TakingLineID;
				_iNVTakingInventoryLineBatchWCF.BatchID = _iNVTakingInventoryLineBatch.BatchID;
				
				iNVTakingInventoryLineBatchCollection.Add(_iNVTakingInventoryLineBatchWCF);
			}
			return iNVTakingInventoryLineBatchCollection;
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class INVTakingInventoryLineBatch</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class INVTakingInventoryLineBatch in the form of an object of class INVTakingInventoryLineBatchCollection</returns>
		public INVTakingInventoryLineBatchCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
		{
			INVTakingInventoryLineBatchCollection iNVTakingInventoryLineBatchCollection = new INVTakingInventoryLineBatchCollection();
			foreach (POS.DataLayer.INVTakingInventoryLineBatch _iNVTakingInventoryLineBatch in POS.DataLayer.INVTakingInventoryLineBatchBase.SelectByFieldPaged(field, fieldValue, fieldValue2, typeOperation, pageSize, skipPages, orderByStatement))
			{
				_iNVTakingInventoryLineBatchWCF = new INVTakingInventoryLineBatch();
				
				_iNVTakingInventoryLineBatchWCF.TakingLineBatchID = _iNVTakingInventoryLineBatch.TakingLineBatchID;
				_iNVTakingInventoryLineBatchWCF.TakingLineID = _iNVTakingInventoryLineBatch.TakingLineID;
				_iNVTakingInventoryLineBatchWCF.BatchID = _iNVTakingInventoryLineBatch.BatchID;
				
				iNVTakingInventoryLineBatchCollection.Add(_iNVTakingInventoryLineBatchWCF);
			}
			return iNVTakingInventoryLineBatchCollection;
		}
			///<summary>
		/// This method will update one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="iNVTakingInventoryLineBatch" type="INVTakingInventoryLineBatch">This INVTakingInventoryLineBatch  will be updated in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Update(INVTakingInventoryLineBatch iNVTakingInventoryLineBatch)
		{
			_iNVTakingInventoryLineBatch=POS.DataLayer.INVTakingInventoryLineBatch.SelectOne(new POS.DataLayer.INVTakingInventoryLineBatchPrimaryKey(iNVTakingInventoryLineBatch.TakingLineBatchID));
			
			_iNVTakingInventoryLineBatch.TakingLineID=iNVTakingInventoryLineBatch.TakingLineID;
			_iNVTakingInventoryLineBatch.BatchID=iNVTakingInventoryLineBatch.BatchID;
			
			return _iNVTakingInventoryLineBatch.Update();
		}
	} 
}
