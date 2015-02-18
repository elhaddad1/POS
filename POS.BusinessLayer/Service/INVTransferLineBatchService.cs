//
// Class	:	INVTransferLineBatchServices.svc.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	2/18/2015 10:55:38 PM
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
	///WCF service for the INVTransferLineBatch
	///</summary>
	public class INVTransferLineBatchService 
	{
		private INVTransferLineBatch _iNVTransferLineBatchWCF;
		private POS.DataLayer.INVTransferLineBatch _iNVTransferLineBatch;
		
		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="INVTransferLineBatchFields">Field of the class INVTransferLineBatch</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <returns>True if succeeded</returns>
		public bool DeleteByField(string field, object fieldValue)
		{
			return POS.DataLayer.INVTransferLineBatchBase.DeleteByField(field, fieldValue);
		}

		///<summary>
		///This method will Delete the object from the database
		///</summary>
		///<param name="pk" type="INVTransferLineBatchPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <returns>True if succeeded</returns>
		public bool Delete(INVTransferLineBatchPrimaryKey pk)
		{
			return POS.DataLayer.INVTransferLineBatchBase.Delete(new POS.DataLayer.INVTransferLineBatchPrimaryKey(pk.TransferLineBatchID));
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="INVTransferLineBatchPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class INVTransferLineBatch</returns>
		public INVTransferLineBatch SelectOne(INVTransferLineBatchPrimaryKey pk)
		{
			_iNVTransferLineBatchWCF = new INVTransferLineBatch();
			_iNVTransferLineBatch = POS.DataLayer.INVTransferLineBatchBase.SelectOne(new POS.DataLayer.INVTransferLineBatchPrimaryKey(pk.TransferLineBatchID));
			
				_iNVTransferLineBatchWCF.TransferLineBatchID = _iNVTransferLineBatch.TransferLineBatchID;
				_iNVTransferLineBatchWCF.TransferLineID = _iNVTransferLineBatch.TransferLineID;
				_iNVTransferLineBatchWCF.BatchID = _iNVTransferLineBatch.BatchID;
				
			return _iNVTransferLineBatchWCF;
		}

		/// <summary>
		/// This method will return a list of objects representing all records in the table.
		/// </summary>
		///
		/// <returns>list of objects of class INVTransferLineBatch in the form of object of INVTransferLineBatchCollection </returns>
		public INVTransferLineBatchCollection SelectAll()
		{
			INVTransferLineBatchCollection iNVTransferLineBatchCollection = new INVTransferLineBatchCollection();
			foreach (POS.DataLayer.INVTransferLineBatch _iNVTransferLineBatch in POS.DataLayer.INVTransferLineBatchBase.SelectAll())
			{
				_iNVTransferLineBatchWCF = new INVTransferLineBatch();
				
				_iNVTransferLineBatchWCF.TransferLineBatchID = _iNVTransferLineBatch.TransferLineBatchID;
				_iNVTransferLineBatchWCF.TransferLineID = _iNVTransferLineBatch.TransferLineID;
				_iNVTransferLineBatchWCF.BatchID = _iNVTransferLineBatch.BatchID;
				
				iNVTransferLineBatchCollection.Add(_iNVTransferLineBatchWCF);
			}
			return iNVTransferLineBatchCollection;
		}
    
    /// <summary>
		/// This method will return a count all records in the table.
		/// </summary>
		///
		/// <returns>count records</returns>
		public int SelectAllCount()
		{
			return POS.DataLayer.INVTransferLineBatchBase.SelectAllCount();			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class INVTransferLineBatch</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class INVTransferLineBatch in the form of an object of class INVTransferLineBatchCollection</returns>
		public INVTransferLineBatchCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
		{
			INVTransferLineBatchCollection iNVTransferLineBatchCollection = new INVTransferLineBatchCollection();
			foreach (POS.DataLayer.INVTransferLineBatch _iNVTransferLineBatch in POS.DataLayer.INVTransferLineBatchBase.SelectByField(field, fieldValue, fieldValue2, typeOperation))
			{
				_iNVTransferLineBatchWCF = new INVTransferLineBatch();
				
				_iNVTransferLineBatchWCF.TransferLineBatchID = _iNVTransferLineBatch.TransferLineBatchID;
				_iNVTransferLineBatchWCF.TransferLineID = _iNVTransferLineBatch.TransferLineID;
				_iNVTransferLineBatchWCF.BatchID = _iNVTransferLineBatch.BatchID;
				
				iNVTransferLineBatchCollection.Add(_iNVTransferLineBatchWCF);
			}
			return iNVTransferLineBatchCollection;
		}
		
		/// <summary>
		/// This method will insert one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="iNVTransferLineBatch" type="INVTransferLineBatch">This INVTransferLineBatch  will be inserted in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Insert(INVTransferLineBatch iNVTransferLineBatch)
		{
			_iNVTransferLineBatch = new POS.DataLayer.INVTransferLineBatch();
			_iNVTransferLineBatch.TransferLineBatchID=iNVTransferLineBatch.TransferLineBatchID;
			_iNVTransferLineBatch.TransferLineID=iNVTransferLineBatch.TransferLineID;
			_iNVTransferLineBatch.BatchID=iNVTransferLineBatch.BatchID;
			
			return _iNVTransferLineBatch.Insert();
		}
		/// <summary>
		/// This method will delete row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="INVTransferLinePrimaryKey">Primary Key information based on which data is to be deleted.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool DeleteAllByForeignKeyTransferLineID(INVTransferLinePrimaryKey pk)
		{
			return POS.DataLayer.INVTransferLineBatchBase.DeleteAllByForeignKeyTransferLineID(new POS.DataLayer.INVTransferLinePrimaryKey(pk.TransferLineID));
		}
		
		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="INVTransferLinePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class INVTransferLineBatchCollection</returns>
		public INVTransferLineBatchCollection SelectAllByForeignKeyTransferLineID(INVTransferLinePrimaryKey pk)
		{
			INVTransferLineBatchCollection iNVTransferLineBatchCollection=new INVTransferLineBatchCollection();
			foreach (POS.DataLayer.INVTransferLineBatch _iNVTransferLineBatch in POS.DataLayer.INVTransferLineBatchBase.SelectAllByForeignKeyTransferLineID(new POS.DataLayer.INVTransferLinePrimaryKey(pk.TransferLineID)))
			{
				_iNVTransferLineBatchWCF = new INVTransferLineBatch();
				_iNVTransferLineBatchWCF.TransferLineBatchID = _iNVTransferLineBatch.TransferLineBatchID;
				_iNVTransferLineBatchWCF.TransferLineID = _iNVTransferLineBatch.TransferLineID;
				_iNVTransferLineBatchWCF.BatchID = _iNVTransferLineBatch.BatchID;
				
				iNVTransferLineBatchCollection.Add(_iNVTransferLineBatchWCF);
			}
			return iNVTransferLineBatchCollection;
		}
		
		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="INVTransferLinePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>object of class INVTransferLineBatchCollection</returns>
		public INVTransferLineBatchCollection SelectAllByForeignKeyTransferLineIDPaged(INVTransferLinePrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			INVTransferLineBatchCollection iNVTransferLineBatchCollection=new INVTransferLineBatchCollection();
			foreach (POS.DataLayer.INVTransferLineBatch _iNVTransferLineBatch in POS.DataLayer.INVTransferLineBatchBase.SelectAllByForeignKeyTransferLineIDPaged(new POS.DataLayer.INVTransferLinePrimaryKey(pk.TransferLineID), pageSize, skipPages, orderByStatement))
			{
				_iNVTransferLineBatchWCF = new INVTransferLineBatch();
				_iNVTransferLineBatchWCF.TransferLineBatchID = _iNVTransferLineBatch.TransferLineBatchID;
				_iNVTransferLineBatchWCF.TransferLineID = _iNVTransferLineBatch.TransferLineID;
				_iNVTransferLineBatchWCF.BatchID = _iNVTransferLineBatch.BatchID;
				
				iNVTransferLineBatchCollection.Add(_iNVTransferLineBatchWCF);
			}
			return iNVTransferLineBatchCollection;
		}
			
		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>list of objects of class INVTransferLineBatch in the form of an object of class INVTransferLineBatchCollection </returns>
		public INVTransferLineBatchCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			INVTransferLineBatchCollection iNVTransferLineBatchCollection = new INVTransferLineBatchCollection();
			foreach (POS.DataLayer.INVTransferLineBatch _iNVTransferLineBatch in POS.DataLayer.INVTransferLineBatchBase.SelectAllPaged(pageSize, skipPages, orderByStatement))
			{
				_iNVTransferLineBatchWCF = new INVTransferLineBatch();
				
				_iNVTransferLineBatchWCF.TransferLineBatchID = _iNVTransferLineBatch.TransferLineBatchID;
				_iNVTransferLineBatchWCF.TransferLineID = _iNVTransferLineBatch.TransferLineID;
				_iNVTransferLineBatchWCF.BatchID = _iNVTransferLineBatch.BatchID;
				
				iNVTransferLineBatchCollection.Add(_iNVTransferLineBatchWCF);
			}
			return iNVTransferLineBatchCollection;
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class INVTransferLineBatch</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class INVTransferLineBatch in the form of an object of class INVTransferLineBatchCollection</returns>
		public INVTransferLineBatchCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
		{
			INVTransferLineBatchCollection iNVTransferLineBatchCollection = new INVTransferLineBatchCollection();
			foreach (POS.DataLayer.INVTransferLineBatch _iNVTransferLineBatch in POS.DataLayer.INVTransferLineBatchBase.SelectByFieldPaged(field, fieldValue, fieldValue2, typeOperation, pageSize, skipPages, orderByStatement))
			{
				_iNVTransferLineBatchWCF = new INVTransferLineBatch();
				
				_iNVTransferLineBatchWCF.TransferLineBatchID = _iNVTransferLineBatch.TransferLineBatchID;
				_iNVTransferLineBatchWCF.TransferLineID = _iNVTransferLineBatch.TransferLineID;
				_iNVTransferLineBatchWCF.BatchID = _iNVTransferLineBatch.BatchID;
				
				iNVTransferLineBatchCollection.Add(_iNVTransferLineBatchWCF);
			}
			return iNVTransferLineBatchCollection;
		}
			///<summary>
		/// This method will update one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="iNVTransferLineBatch" type="INVTransferLineBatch">This INVTransferLineBatch  will be updated in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Update(INVTransferLineBatch iNVTransferLineBatch)
		{
			_iNVTransferLineBatch=POS.DataLayer.INVTransferLineBatch.SelectOne(new POS.DataLayer.INVTransferLineBatchPrimaryKey(iNVTransferLineBatch.TransferLineBatchID));
			
			_iNVTransferLineBatch.TransferLineID=iNVTransferLineBatch.TransferLineID;
			_iNVTransferLineBatch.BatchID=iNVTransferLineBatch.BatchID;
			
			return _iNVTransferLineBatch.Update();
		}
	} 
}
