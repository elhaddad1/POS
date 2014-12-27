//
// Class	:	SALSalesLineBatchServices.svc.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:56:06 PM
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
	///WCF service for the SALSalesLineBatch
	///</summary>
	public class SALSalesLineBatchService : ISALSalesLineBatchService
	{
		private SALSalesLineBatch _sALSalesLineBatchWCF;
		private POS.DataLayer.SALSalesLineBatch _sALSalesLineBatch;
		
		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="SALSalesLineBatchFields">Field of the class SALSalesLineBatch</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <returns>True if succeeded</returns>
		public bool DeleteByField(string field, object fieldValue)
		{
			return POS.DataLayer.SALSalesLineBatchBase.DeleteByField(field, fieldValue);
		}

		///<summary>
		///This method will Delete the object from the database
		///</summary>
		///<param name="pk" type="SALSalesLineBatchPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <returns>True if succeeded</returns>
		public bool Delete(SALSalesLineBatchPrimaryKey pk)
		{
			return POS.DataLayer.SALSalesLineBatchBase.Delete(new POS.DataLayer.SALSalesLineBatchPrimaryKey(pk.SalesLineBatchID));
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="SALSalesLineBatchPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class SALSalesLineBatch</returns>
		public SALSalesLineBatch SelectOne(SALSalesLineBatchPrimaryKey pk)
		{
			_sALSalesLineBatchWCF = new SALSalesLineBatch();
			_sALSalesLineBatch = POS.DataLayer.SALSalesLineBatchBase.SelectOne(new POS.DataLayer.SALSalesLineBatchPrimaryKey(pk.SalesLineBatchID));
			
				_sALSalesLineBatchWCF.SalesLineBatchID = _sALSalesLineBatch.SalesLineBatchID;
				_sALSalesLineBatchWCF.SalesLineID = _sALSalesLineBatch.SalesLineID;
				_sALSalesLineBatchWCF.BatchID = _sALSalesLineBatch.BatchID;
				
			return _sALSalesLineBatchWCF;
		}

		/// <summary>
		/// This method will return a list of objects representing all records in the table.
		/// </summary>
		///
		/// <returns>list of objects of class SALSalesLineBatch in the form of object of SALSalesLineBatchCollection </returns>
		public SALSalesLineBatchCollection SelectAll()
		{
			SALSalesLineBatchCollection sALSalesLineBatchCollection = new SALSalesLineBatchCollection();
			foreach (POS.DataLayer.SALSalesLineBatch _sALSalesLineBatch in POS.DataLayer.SALSalesLineBatchBase.SelectAll())
			{
				_sALSalesLineBatchWCF = new SALSalesLineBatch();
				
				_sALSalesLineBatchWCF.SalesLineBatchID = _sALSalesLineBatch.SalesLineBatchID;
				_sALSalesLineBatchWCF.SalesLineID = _sALSalesLineBatch.SalesLineID;
				_sALSalesLineBatchWCF.BatchID = _sALSalesLineBatch.BatchID;
				
				sALSalesLineBatchCollection.Add(_sALSalesLineBatchWCF);
			}
			return sALSalesLineBatchCollection;
		}
    
    /// <summary>
		/// This method will return a count all records in the table.
		/// </summary>
		///
		/// <returns>count records</returns>
		public int SelectAllCount()
		{
			return POS.DataLayer.SALSalesLineBatchBase.SelectAllCount();			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class SALSalesLineBatch</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class SALSalesLineBatch in the form of an object of class SALSalesLineBatchCollection</returns>
		public SALSalesLineBatchCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
		{
			SALSalesLineBatchCollection sALSalesLineBatchCollection = new SALSalesLineBatchCollection();
			foreach (POS.DataLayer.SALSalesLineBatch _sALSalesLineBatch in POS.DataLayer.SALSalesLineBatchBase.SelectByField(field, fieldValue, fieldValue2, typeOperation))
			{
				_sALSalesLineBatchWCF = new SALSalesLineBatch();
				
				_sALSalesLineBatchWCF.SalesLineBatchID = _sALSalesLineBatch.SalesLineBatchID;
				_sALSalesLineBatchWCF.SalesLineID = _sALSalesLineBatch.SalesLineID;
				_sALSalesLineBatchWCF.BatchID = _sALSalesLineBatch.BatchID;
				
				sALSalesLineBatchCollection.Add(_sALSalesLineBatchWCF);
			}
			return sALSalesLineBatchCollection;
		}
		
		/// <summary>
		/// This method will insert one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="sALSalesLineBatch" type="SALSalesLineBatch">This SALSalesLineBatch  will be inserted in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Insert(SALSalesLineBatch sALSalesLineBatch)
		{
			_sALSalesLineBatch = new POS.DataLayer.SALSalesLineBatch();
			_sALSalesLineBatch.SalesLineBatchID=sALSalesLineBatch.SalesLineBatchID;
			_sALSalesLineBatch.SalesLineID=sALSalesLineBatch.SalesLineID;
			_sALSalesLineBatch.BatchID=sALSalesLineBatch.BatchID;
			
			return _sALSalesLineBatch.Insert();
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
			return POS.DataLayer.SALSalesLineBatchBase.DeleteAllByForeignKeyBatchID(new POS.DataLayer.INVBatchPrimaryKey(pk.BatchID));
		}
		
		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="INVBatchPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class SALSalesLineBatchCollection</returns>
		public SALSalesLineBatchCollection SelectAllByForeignKeyBatchID(INVBatchPrimaryKey pk)
		{
			SALSalesLineBatchCollection sALSalesLineBatchCollection=new SALSalesLineBatchCollection();
			foreach (POS.DataLayer.SALSalesLineBatch _sALSalesLineBatch in POS.DataLayer.SALSalesLineBatchBase.SelectAllByForeignKeyBatchID(new POS.DataLayer.INVBatchPrimaryKey(pk.BatchID)))
			{
				_sALSalesLineBatchWCF = new SALSalesLineBatch();
				_sALSalesLineBatchWCF.SalesLineBatchID = _sALSalesLineBatch.SalesLineBatchID;
				_sALSalesLineBatchWCF.SalesLineID = _sALSalesLineBatch.SalesLineID;
				_sALSalesLineBatchWCF.BatchID = _sALSalesLineBatch.BatchID;
				
				sALSalesLineBatchCollection.Add(_sALSalesLineBatchWCF);
			}
			return sALSalesLineBatchCollection;
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
		/// <returns>object of class SALSalesLineBatchCollection</returns>
		public SALSalesLineBatchCollection SelectAllByForeignKeyBatchIDPaged(INVBatchPrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			SALSalesLineBatchCollection sALSalesLineBatchCollection=new SALSalesLineBatchCollection();
			foreach (POS.DataLayer.SALSalesLineBatch _sALSalesLineBatch in POS.DataLayer.SALSalesLineBatchBase.SelectAllByForeignKeyBatchIDPaged(new POS.DataLayer.INVBatchPrimaryKey(pk.BatchID), pageSize, skipPages, orderByStatement))
			{
				_sALSalesLineBatchWCF = new SALSalesLineBatch();
				_sALSalesLineBatchWCF.SalesLineBatchID = _sALSalesLineBatch.SalesLineBatchID;
				_sALSalesLineBatchWCF.SalesLineID = _sALSalesLineBatch.SalesLineID;
				_sALSalesLineBatchWCF.BatchID = _sALSalesLineBatch.BatchID;
				
				sALSalesLineBatchCollection.Add(_sALSalesLineBatchWCF);
			}
			return sALSalesLineBatchCollection;
		}
			/// <summary>
		/// This method will delete row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="SALSalesLinePrimaryKey">Primary Key information based on which data is to be deleted.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool DeleteAllByForeignKeySalesLineID(SALSalesLinePrimaryKey pk)
		{
			return POS.DataLayer.SALSalesLineBatchBase.DeleteAllByForeignKeySalesLineID(new POS.DataLayer.SALSalesLinePrimaryKey(pk.SalesLineID));
		}
		
		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="SALSalesLinePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class SALSalesLineBatchCollection</returns>
		public SALSalesLineBatchCollection SelectAllByForeignKeySalesLineID(SALSalesLinePrimaryKey pk)
		{
			SALSalesLineBatchCollection sALSalesLineBatchCollection=new SALSalesLineBatchCollection();
			foreach (POS.DataLayer.SALSalesLineBatch _sALSalesLineBatch in POS.DataLayer.SALSalesLineBatchBase.SelectAllByForeignKeySalesLineID(new POS.DataLayer.SALSalesLinePrimaryKey(pk.SalesLineID)))
			{
				_sALSalesLineBatchWCF = new SALSalesLineBatch();
				_sALSalesLineBatchWCF.SalesLineBatchID = _sALSalesLineBatch.SalesLineBatchID;
				_sALSalesLineBatchWCF.SalesLineID = _sALSalesLineBatch.SalesLineID;
				_sALSalesLineBatchWCF.BatchID = _sALSalesLineBatch.BatchID;
				
				sALSalesLineBatchCollection.Add(_sALSalesLineBatchWCF);
			}
			return sALSalesLineBatchCollection;
		}
		
		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="SALSalesLinePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>object of class SALSalesLineBatchCollection</returns>
		public SALSalesLineBatchCollection SelectAllByForeignKeySalesLineIDPaged(SALSalesLinePrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			SALSalesLineBatchCollection sALSalesLineBatchCollection=new SALSalesLineBatchCollection();
			foreach (POS.DataLayer.SALSalesLineBatch _sALSalesLineBatch in POS.DataLayer.SALSalesLineBatchBase.SelectAllByForeignKeySalesLineIDPaged(new POS.DataLayer.SALSalesLinePrimaryKey(pk.SalesLineID), pageSize, skipPages, orderByStatement))
			{
				_sALSalesLineBatchWCF = new SALSalesLineBatch();
				_sALSalesLineBatchWCF.SalesLineBatchID = _sALSalesLineBatch.SalesLineBatchID;
				_sALSalesLineBatchWCF.SalesLineID = _sALSalesLineBatch.SalesLineID;
				_sALSalesLineBatchWCF.BatchID = _sALSalesLineBatch.BatchID;
				
				sALSalesLineBatchCollection.Add(_sALSalesLineBatchWCF);
			}
			return sALSalesLineBatchCollection;
		}
			
		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>list of objects of class SALSalesLineBatch in the form of an object of class SALSalesLineBatchCollection </returns>
		public SALSalesLineBatchCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			SALSalesLineBatchCollection sALSalesLineBatchCollection = new SALSalesLineBatchCollection();
			foreach (POS.DataLayer.SALSalesLineBatch _sALSalesLineBatch in POS.DataLayer.SALSalesLineBatchBase.SelectAllPaged(pageSize, skipPages, orderByStatement))
			{
				_sALSalesLineBatchWCF = new SALSalesLineBatch();
				
				_sALSalesLineBatchWCF.SalesLineBatchID = _sALSalesLineBatch.SalesLineBatchID;
				_sALSalesLineBatchWCF.SalesLineID = _sALSalesLineBatch.SalesLineID;
				_sALSalesLineBatchWCF.BatchID = _sALSalesLineBatch.BatchID;
				
				sALSalesLineBatchCollection.Add(_sALSalesLineBatchWCF);
			}
			return sALSalesLineBatchCollection;
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class SALSalesLineBatch</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class SALSalesLineBatch in the form of an object of class SALSalesLineBatchCollection</returns>
		public SALSalesLineBatchCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
		{
			SALSalesLineBatchCollection sALSalesLineBatchCollection = new SALSalesLineBatchCollection();
			foreach (POS.DataLayer.SALSalesLineBatch _sALSalesLineBatch in POS.DataLayer.SALSalesLineBatchBase.SelectByFieldPaged(field, fieldValue, fieldValue2, typeOperation, pageSize, skipPages, orderByStatement))
			{
				_sALSalesLineBatchWCF = new SALSalesLineBatch();
				
				_sALSalesLineBatchWCF.SalesLineBatchID = _sALSalesLineBatch.SalesLineBatchID;
				_sALSalesLineBatchWCF.SalesLineID = _sALSalesLineBatch.SalesLineID;
				_sALSalesLineBatchWCF.BatchID = _sALSalesLineBatch.BatchID;
				
				sALSalesLineBatchCollection.Add(_sALSalesLineBatchWCF);
			}
			return sALSalesLineBatchCollection;
		}
			///<summary>
		/// This method will update one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="sALSalesLineBatch" type="SALSalesLineBatch">This SALSalesLineBatch  will be updated in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Update(SALSalesLineBatch sALSalesLineBatch)
		{
			_sALSalesLineBatch=POS.DataLayer.SALSalesLineBatch.SelectOne(new POS.DataLayer.SALSalesLineBatchPrimaryKey(sALSalesLineBatch.SalesLineBatchID));
			
			_sALSalesLineBatch.SalesLineID=sALSalesLineBatch.SalesLineID;
			_sALSalesLineBatch.BatchID=sALSalesLineBatch.BatchID;
			
			return _sALSalesLineBatch.Update();
		}
	} 
}
