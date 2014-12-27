//
// Class	:	SALSalesReturnLineServices.svc.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:56:04 PM
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
	///WCF service for the SALSalesReturnLine
	///</summary>
	public class SALSalesReturnLineService : ISALSalesReturnLineService
	{
		private SALSalesReturnLine _sALSalesReturnLineWCF;
		private POS.DataLayer.SALSalesReturnLine _sALSalesReturnLine;
		
		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="SALSalesReturnLineFields">Field of the class SALSalesReturnLine</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <returns>True if succeeded</returns>
		public bool DeleteByField(string field, object fieldValue)
		{
			return POS.DataLayer.SALSalesReturnLineBase.DeleteByField(field, fieldValue);
		}

		///<summary>
		///This method will Delete the object from the database
		///</summary>
		///<param name="pk" type="SALSalesReturnLinePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <returns>True if succeeded</returns>
		public bool Delete(SALSalesReturnLinePrimaryKey pk)
		{
			return POS.DataLayer.SALSalesReturnLineBase.Delete(new POS.DataLayer.SALSalesReturnLinePrimaryKey(pk.SalesReturnLineID));
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="SALSalesReturnLinePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class SALSalesReturnLine</returns>
		public SALSalesReturnLine SelectOne(SALSalesReturnLinePrimaryKey pk)
		{
			_sALSalesReturnLineWCF = new SALSalesReturnLine();
			_sALSalesReturnLine = POS.DataLayer.SALSalesReturnLineBase.SelectOne(new POS.DataLayer.SALSalesReturnLinePrimaryKey(pk.SalesReturnLineID));
			
				_sALSalesReturnLineWCF.SalesReturnLineID = _sALSalesReturnLine.SalesReturnLineID;
				_sALSalesReturnLineWCF.Qty = _sALSalesReturnLine.Qty;
				_sALSalesReturnLineWCF.Reason = _sALSalesReturnLine.Reason;
				_sALSalesReturnLineWCF.OriginalSalesLineID = _sALSalesReturnLine.OriginalSalesLineID;
				_sALSalesReturnLineWCF.BatchID = _sALSalesReturnLine.BatchID;
				_sALSalesReturnLineWCF.BatchNumber = _sALSalesReturnLine.BatchNumber;
				_sALSalesReturnLineWCF.ExpiryDate = _sALSalesReturnLine.ExpiryDate;
				
			return _sALSalesReturnLineWCF;
		}

		/// <summary>
		/// This method will return a list of objects representing all records in the table.
		/// </summary>
		///
		/// <returns>list of objects of class SALSalesReturnLine in the form of object of SALSalesReturnLineCollection </returns>
		public SALSalesReturnLineCollection SelectAll()
		{
			SALSalesReturnLineCollection sALSalesReturnLineCollection = new SALSalesReturnLineCollection();
			foreach (POS.DataLayer.SALSalesReturnLine _sALSalesReturnLine in POS.DataLayer.SALSalesReturnLineBase.SelectAll())
			{
				_sALSalesReturnLineWCF = new SALSalesReturnLine();
				
				_sALSalesReturnLineWCF.SalesReturnLineID = _sALSalesReturnLine.SalesReturnLineID;
				_sALSalesReturnLineWCF.Qty = _sALSalesReturnLine.Qty;
				_sALSalesReturnLineWCF.Reason = _sALSalesReturnLine.Reason;
				_sALSalesReturnLineWCF.OriginalSalesLineID = _sALSalesReturnLine.OriginalSalesLineID;
				_sALSalesReturnLineWCF.BatchID = _sALSalesReturnLine.BatchID;
				_sALSalesReturnLineWCF.BatchNumber = _sALSalesReturnLine.BatchNumber;
				_sALSalesReturnLineWCF.ExpiryDate = _sALSalesReturnLine.ExpiryDate;
				
				sALSalesReturnLineCollection.Add(_sALSalesReturnLineWCF);
			}
			return sALSalesReturnLineCollection;
		}
    
    /// <summary>
		/// This method will return a count all records in the table.
		/// </summary>
		///
		/// <returns>count records</returns>
		public int SelectAllCount()
		{
			return POS.DataLayer.SALSalesReturnLineBase.SelectAllCount();			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class SALSalesReturnLine</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class SALSalesReturnLine in the form of an object of class SALSalesReturnLineCollection</returns>
		public SALSalesReturnLineCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
		{
			SALSalesReturnLineCollection sALSalesReturnLineCollection = new SALSalesReturnLineCollection();
			foreach (POS.DataLayer.SALSalesReturnLine _sALSalesReturnLine in POS.DataLayer.SALSalesReturnLineBase.SelectByField(field, fieldValue, fieldValue2, typeOperation))
			{
				_sALSalesReturnLineWCF = new SALSalesReturnLine();
				
				_sALSalesReturnLineWCF.SalesReturnLineID = _sALSalesReturnLine.SalesReturnLineID;
				_sALSalesReturnLineWCF.Qty = _sALSalesReturnLine.Qty;
				_sALSalesReturnLineWCF.Reason = _sALSalesReturnLine.Reason;
				_sALSalesReturnLineWCF.OriginalSalesLineID = _sALSalesReturnLine.OriginalSalesLineID;
				_sALSalesReturnLineWCF.BatchID = _sALSalesReturnLine.BatchID;
				_sALSalesReturnLineWCF.BatchNumber = _sALSalesReturnLine.BatchNumber;
				_sALSalesReturnLineWCF.ExpiryDate = _sALSalesReturnLine.ExpiryDate;
				
				sALSalesReturnLineCollection.Add(_sALSalesReturnLineWCF);
			}
			return sALSalesReturnLineCollection;
		}
		
		/// <summary>
		/// This method will insert one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="sALSalesReturnLine" type="SALSalesReturnLine">This SALSalesReturnLine  will be inserted in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Insert(SALSalesReturnLine sALSalesReturnLine)
		{
			_sALSalesReturnLine = new POS.DataLayer.SALSalesReturnLine();
			_sALSalesReturnLine.SalesReturnLineID=sALSalesReturnLine.SalesReturnLineID;
			_sALSalesReturnLine.Qty=sALSalesReturnLine.Qty;
			_sALSalesReturnLine.Reason=sALSalesReturnLine.Reason;
			_sALSalesReturnLine.OriginalSalesLineID=sALSalesReturnLine.OriginalSalesLineID;
			_sALSalesReturnLine.BatchID=sALSalesReturnLine.BatchID;
			_sALSalesReturnLine.BatchNumber=sALSalesReturnLine.BatchNumber;
			_sALSalesReturnLine.ExpiryDate=sALSalesReturnLine.ExpiryDate;
			
			return _sALSalesReturnLine.Insert();
		}
		
		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>list of objects of class SALSalesReturnLine in the form of an object of class SALSalesReturnLineCollection </returns>
		public SALSalesReturnLineCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			SALSalesReturnLineCollection sALSalesReturnLineCollection = new SALSalesReturnLineCollection();
			foreach (POS.DataLayer.SALSalesReturnLine _sALSalesReturnLine in POS.DataLayer.SALSalesReturnLineBase.SelectAllPaged(pageSize, skipPages, orderByStatement))
			{
				_sALSalesReturnLineWCF = new SALSalesReturnLine();
				
				_sALSalesReturnLineWCF.SalesReturnLineID = _sALSalesReturnLine.SalesReturnLineID;
				_sALSalesReturnLineWCF.Qty = _sALSalesReturnLine.Qty;
				_sALSalesReturnLineWCF.Reason = _sALSalesReturnLine.Reason;
				_sALSalesReturnLineWCF.OriginalSalesLineID = _sALSalesReturnLine.OriginalSalesLineID;
				_sALSalesReturnLineWCF.BatchID = _sALSalesReturnLine.BatchID;
				_sALSalesReturnLineWCF.BatchNumber = _sALSalesReturnLine.BatchNumber;
				_sALSalesReturnLineWCF.ExpiryDate = _sALSalesReturnLine.ExpiryDate;
				
				sALSalesReturnLineCollection.Add(_sALSalesReturnLineWCF);
			}
			return sALSalesReturnLineCollection;
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class SALSalesReturnLine</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class SALSalesReturnLine in the form of an object of class SALSalesReturnLineCollection</returns>
		public SALSalesReturnLineCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
		{
			SALSalesReturnLineCollection sALSalesReturnLineCollection = new SALSalesReturnLineCollection();
			foreach (POS.DataLayer.SALSalesReturnLine _sALSalesReturnLine in POS.DataLayer.SALSalesReturnLineBase.SelectByFieldPaged(field, fieldValue, fieldValue2, typeOperation, pageSize, skipPages, orderByStatement))
			{
				_sALSalesReturnLineWCF = new SALSalesReturnLine();
				
				_sALSalesReturnLineWCF.SalesReturnLineID = _sALSalesReturnLine.SalesReturnLineID;
				_sALSalesReturnLineWCF.Qty = _sALSalesReturnLine.Qty;
				_sALSalesReturnLineWCF.Reason = _sALSalesReturnLine.Reason;
				_sALSalesReturnLineWCF.OriginalSalesLineID = _sALSalesReturnLine.OriginalSalesLineID;
				_sALSalesReturnLineWCF.BatchID = _sALSalesReturnLine.BatchID;
				_sALSalesReturnLineWCF.BatchNumber = _sALSalesReturnLine.BatchNumber;
				_sALSalesReturnLineWCF.ExpiryDate = _sALSalesReturnLine.ExpiryDate;
				
				sALSalesReturnLineCollection.Add(_sALSalesReturnLineWCF);
			}
			return sALSalesReturnLineCollection;
		}
			///<summary>
		/// This method will update one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="sALSalesReturnLine" type="SALSalesReturnLine">This SALSalesReturnLine  will be updated in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Update(SALSalesReturnLine sALSalesReturnLine)
		{
			_sALSalesReturnLine=POS.DataLayer.SALSalesReturnLine.SelectOne(new POS.DataLayer.SALSalesReturnLinePrimaryKey(sALSalesReturnLine.SalesReturnLineID));
			
			_sALSalesReturnLine.Qty=sALSalesReturnLine.Qty;
			_sALSalesReturnLine.Reason=sALSalesReturnLine.Reason;
			_sALSalesReturnLine.OriginalSalesLineID=sALSalesReturnLine.OriginalSalesLineID;
			_sALSalesReturnLine.BatchID=sALSalesReturnLine.BatchID;
			_sALSalesReturnLine.BatchNumber=sALSalesReturnLine.BatchNumber;
			_sALSalesReturnLine.ExpiryDate=sALSalesReturnLine.ExpiryDate;
			
			return _sALSalesReturnLine.Update();
		}
	} 
}
