//
// Class	:	PURPurchaseReturnLineServices.svc.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	3/7/2015 2:37:27 PM
//


using POS.DataLayer;

namespace POS.BusinessLayer
{
	///<summary>
	///WCF service for the PURPurchaseReturnLine
	///</summary>
	public class PURPurchaseReturnLineService 
	{
		private PURPurchaseReturnLine _pURPurchaseReturnLineWCF;
		private POS.DataLayer.PURPurchaseReturnLine _pURPurchaseReturnLine;
		
		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="PURPurchaseReturnLineFields">Field of the class PURPurchaseReturnLine</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <returns>True if succeeded</returns>
		public bool DeleteByField(string field, object fieldValue)
		{
			return POS.DataLayer.PURPurchaseReturnLineBase.DeleteByField(field, fieldValue);
		}

		///<summary>
		///This method will Delete the object from the database
		///</summary>
		///<param name="pk" type="PURPurchaseReturnLinePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <returns>True if succeeded</returns>
		public bool Delete(PURPurchaseReturnLinePrimaryKey pk)
		{
			return POS.DataLayer.PURPurchaseReturnLineBase.Delete(new POS.DataLayer.PURPurchaseReturnLinePrimaryKey(pk.PurchaseReturnLineID));
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="PURPurchaseReturnLinePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class PURPurchaseReturnLine</returns>
		public PURPurchaseReturnLine SelectOne(PURPurchaseReturnLinePrimaryKey pk)
		{
			_pURPurchaseReturnLineWCF = new PURPurchaseReturnLine();
			_pURPurchaseReturnLine = POS.DataLayer.PURPurchaseReturnLineBase.SelectOne(new POS.DataLayer.PURPurchaseReturnLinePrimaryKey(pk.PurchaseReturnLineID));
			
				_pURPurchaseReturnLineWCF.PurchaseReturnLineID = _pURPurchaseReturnLine.PurchaseReturnLineID;
				_pURPurchaseReturnLineWCF.Qty = _pURPurchaseReturnLine.Qty;
				_pURPurchaseReturnLineWCF.Reason = _pURPurchaseReturnLine.Reason;
				_pURPurchaseReturnLineWCF.OriginalpurchaseLineID = _pURPurchaseReturnLine.OriginalpurchaseLineID;
				_pURPurchaseReturnLineWCF.BatchID = _pURPurchaseReturnLine.BatchID;
				_pURPurchaseReturnLineWCF.BatchNumber = _pURPurchaseReturnLine.BatchNumber;
				_pURPurchaseReturnLineWCF.ExpiryDate = _pURPurchaseReturnLine.ExpiryDate;
				
			return _pURPurchaseReturnLineWCF;
		}

		/// <summary>
		/// This method will return a list of objects representing all records in the table.
		/// </summary>
		///
		/// <returns>list of objects of class PURPurchaseReturnLine in the form of object of PURPurchaseReturnLineCollection </returns>
		public PURPurchaseReturnLineCollection SelectAll()
		{
			PURPurchaseReturnLineCollection pURPurchaseReturnLineCollection = new PURPurchaseReturnLineCollection();
			foreach (POS.DataLayer.PURPurchaseReturnLine _pURPurchaseReturnLine in POS.DataLayer.PURPurchaseReturnLineBase.SelectAll())
			{
				_pURPurchaseReturnLineWCF = new PURPurchaseReturnLine();
				
				_pURPurchaseReturnLineWCF.PurchaseReturnLineID = _pURPurchaseReturnLine.PurchaseReturnLineID;
				_pURPurchaseReturnLineWCF.Qty = _pURPurchaseReturnLine.Qty;
				_pURPurchaseReturnLineWCF.Reason = _pURPurchaseReturnLine.Reason;
				_pURPurchaseReturnLineWCF.OriginalpurchaseLineID = _pURPurchaseReturnLine.OriginalpurchaseLineID;
				_pURPurchaseReturnLineWCF.BatchID = _pURPurchaseReturnLine.BatchID;
				_pURPurchaseReturnLineWCF.BatchNumber = _pURPurchaseReturnLine.BatchNumber;
				_pURPurchaseReturnLineWCF.ExpiryDate = _pURPurchaseReturnLine.ExpiryDate;
				
				pURPurchaseReturnLineCollection.Add(_pURPurchaseReturnLineWCF);
			}
			return pURPurchaseReturnLineCollection;
		}
    
    /// <summary>
		/// This method will return a count all records in the table.
		/// </summary>
		///
		/// <returns>count records</returns>
		public int SelectAllCount()
		{
			return POS.DataLayer.PURPurchaseReturnLineBase.SelectAllCount();			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class PURPurchaseReturnLine</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class PURPurchaseReturnLine in the form of an object of class PURPurchaseReturnLineCollection</returns>
		public PURPurchaseReturnLineCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
		{
			PURPurchaseReturnLineCollection pURPurchaseReturnLineCollection = new PURPurchaseReturnLineCollection();
			foreach (POS.DataLayer.PURPurchaseReturnLine _pURPurchaseReturnLine in POS.DataLayer.PURPurchaseReturnLineBase.SelectByField(field, fieldValue, fieldValue2, typeOperation))
			{
				_pURPurchaseReturnLineWCF = new PURPurchaseReturnLine();
				
				_pURPurchaseReturnLineWCF.PurchaseReturnLineID = _pURPurchaseReturnLine.PurchaseReturnLineID;
				_pURPurchaseReturnLineWCF.Qty = _pURPurchaseReturnLine.Qty;
				_pURPurchaseReturnLineWCF.Reason = _pURPurchaseReturnLine.Reason;
				_pURPurchaseReturnLineWCF.OriginalpurchaseLineID = _pURPurchaseReturnLine.OriginalpurchaseLineID;
				_pURPurchaseReturnLineWCF.BatchID = _pURPurchaseReturnLine.BatchID;
				_pURPurchaseReturnLineWCF.BatchNumber = _pURPurchaseReturnLine.BatchNumber;
				_pURPurchaseReturnLineWCF.ExpiryDate = _pURPurchaseReturnLine.ExpiryDate;
				
				pURPurchaseReturnLineCollection.Add(_pURPurchaseReturnLineWCF);
			}
			return pURPurchaseReturnLineCollection;
		}
		
		/// <summary>
		/// This method will insert one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="pURPurchaseReturnLine" type="PURPurchaseReturnLine">This PURPurchaseReturnLine  will be inserted in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Insert(PURPurchaseReturnLine pURPurchaseReturnLine)
		{
			_pURPurchaseReturnLine = new POS.DataLayer.PURPurchaseReturnLine();
			_pURPurchaseReturnLine.PurchaseReturnLineID=pURPurchaseReturnLine.PurchaseReturnLineID;
			_pURPurchaseReturnLine.Qty=pURPurchaseReturnLine.Qty;
			_pURPurchaseReturnLine.Reason=pURPurchaseReturnLine.Reason;
			_pURPurchaseReturnLine.OriginalpurchaseLineID=pURPurchaseReturnLine.OriginalpurchaseLineID;
			_pURPurchaseReturnLine.BatchID=pURPurchaseReturnLine.BatchID;
			_pURPurchaseReturnLine.BatchNumber=pURPurchaseReturnLine.BatchNumber;
			_pURPurchaseReturnLine.ExpiryDate=pURPurchaseReturnLine.ExpiryDate;
			
			return _pURPurchaseReturnLine.Insert();
		}
		/// <summary>
		/// This method will delete row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="INVBatchPrimaryKey">Primary Key information based on which data is to be deleted.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool DeleteAllByForeignKeyPurchaseReturnLineID(INVBatchPrimaryKey pk)
		{
			return POS.DataLayer.PURPurchaseReturnLineBase.DeleteAllByForeignKeyPurchaseReturnLineID(new POS.DataLayer.INVBatchPrimaryKey(pk.BatchID));
		}
		
		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="INVBatchPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class PURPurchaseReturnLineCollection</returns>
		public PURPurchaseReturnLineCollection SelectAllByForeignKeyPurchaseReturnLineID(INVBatchPrimaryKey pk)
		{
			PURPurchaseReturnLineCollection pURPurchaseReturnLineCollection=new PURPurchaseReturnLineCollection();
			foreach (POS.DataLayer.PURPurchaseReturnLine _pURPurchaseReturnLine in POS.DataLayer.PURPurchaseReturnLineBase.SelectAllByForeignKeyPurchaseReturnLineID(new POS.DataLayer.INVBatchPrimaryKey(pk.BatchID)))
			{
				_pURPurchaseReturnLineWCF = new PURPurchaseReturnLine();
				_pURPurchaseReturnLineWCF.PurchaseReturnLineID = _pURPurchaseReturnLine.PurchaseReturnLineID;
				_pURPurchaseReturnLineWCF.Qty = _pURPurchaseReturnLine.Qty;
				_pURPurchaseReturnLineWCF.Reason = _pURPurchaseReturnLine.Reason;
				_pURPurchaseReturnLineWCF.OriginalpurchaseLineID = _pURPurchaseReturnLine.OriginalpurchaseLineID;
				_pURPurchaseReturnLineWCF.BatchID = _pURPurchaseReturnLine.BatchID;
				_pURPurchaseReturnLineWCF.BatchNumber = _pURPurchaseReturnLine.BatchNumber;
				_pURPurchaseReturnLineWCF.ExpiryDate = _pURPurchaseReturnLine.ExpiryDate;
				
				pURPurchaseReturnLineCollection.Add(_pURPurchaseReturnLineWCF);
			}
			return pURPurchaseReturnLineCollection;
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
		/// <returns>object of class PURPurchaseReturnLineCollection</returns>
		public PURPurchaseReturnLineCollection SelectAllByForeignKeyPurchaseReturnLineIDPaged(INVBatchPrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			PURPurchaseReturnLineCollection pURPurchaseReturnLineCollection=new PURPurchaseReturnLineCollection();
			foreach (POS.DataLayer.PURPurchaseReturnLine _pURPurchaseReturnLine in POS.DataLayer.PURPurchaseReturnLineBase.SelectAllByForeignKeyPurchaseReturnLineIDPaged(new POS.DataLayer.INVBatchPrimaryKey(pk.BatchID), pageSize, skipPages, orderByStatement))
			{
				_pURPurchaseReturnLineWCF = new PURPurchaseReturnLine();
				_pURPurchaseReturnLineWCF.PurchaseReturnLineID = _pURPurchaseReturnLine.PurchaseReturnLineID;
				_pURPurchaseReturnLineWCF.Qty = _pURPurchaseReturnLine.Qty;
				_pURPurchaseReturnLineWCF.Reason = _pURPurchaseReturnLine.Reason;
				_pURPurchaseReturnLineWCF.OriginalpurchaseLineID = _pURPurchaseReturnLine.OriginalpurchaseLineID;
				_pURPurchaseReturnLineWCF.BatchID = _pURPurchaseReturnLine.BatchID;
				_pURPurchaseReturnLineWCF.BatchNumber = _pURPurchaseReturnLine.BatchNumber;
				_pURPurchaseReturnLineWCF.ExpiryDate = _pURPurchaseReturnLine.ExpiryDate;
				
				pURPurchaseReturnLineCollection.Add(_pURPurchaseReturnLineWCF);
			}
			return pURPurchaseReturnLineCollection;
		}
			/// <summary>
		/// This method will delete row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="PURPurchaseLinePrimaryKey">Primary Key information based on which data is to be deleted.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool DeleteAllByForeignKeyOriginalpurchaseLineID(PURPurchaseLinePrimaryKey pk)
		{
			return POS.DataLayer.PURPurchaseReturnLineBase.DeleteAllByForeignKeyOriginalpurchaseLineID(new POS.DataLayer.PURPurchaseLinePrimaryKey(pk.PurchaseLineID));
		}
		
		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="PURPurchaseLinePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class PURPurchaseReturnLineCollection</returns>
		public PURPurchaseReturnLineCollection SelectAllByForeignKeyOriginalpurchaseLineID(PURPurchaseLinePrimaryKey pk)
		{
			PURPurchaseReturnLineCollection pURPurchaseReturnLineCollection=new PURPurchaseReturnLineCollection();
			foreach (POS.DataLayer.PURPurchaseReturnLine _pURPurchaseReturnLine in POS.DataLayer.PURPurchaseReturnLineBase.SelectAllByForeignKeyOriginalpurchaseLineID(new POS.DataLayer.PURPurchaseLinePrimaryKey(pk.PurchaseLineID)))
			{
				_pURPurchaseReturnLineWCF = new PURPurchaseReturnLine();
				_pURPurchaseReturnLineWCF.PurchaseReturnLineID = _pURPurchaseReturnLine.PurchaseReturnLineID;
				_pURPurchaseReturnLineWCF.Qty = _pURPurchaseReturnLine.Qty;
				_pURPurchaseReturnLineWCF.Reason = _pURPurchaseReturnLine.Reason;
				_pURPurchaseReturnLineWCF.OriginalpurchaseLineID = _pURPurchaseReturnLine.OriginalpurchaseLineID;
				_pURPurchaseReturnLineWCF.BatchID = _pURPurchaseReturnLine.BatchID;
				_pURPurchaseReturnLineWCF.BatchNumber = _pURPurchaseReturnLine.BatchNumber;
				_pURPurchaseReturnLineWCF.ExpiryDate = _pURPurchaseReturnLine.ExpiryDate;
				
				pURPurchaseReturnLineCollection.Add(_pURPurchaseReturnLineWCF);
			}
			return pURPurchaseReturnLineCollection;
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
		/// <returns>object of class PURPurchaseReturnLineCollection</returns>
		public PURPurchaseReturnLineCollection SelectAllByForeignKeyOriginalpurchaseLineIDPaged(PURPurchaseLinePrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			PURPurchaseReturnLineCollection pURPurchaseReturnLineCollection=new PURPurchaseReturnLineCollection();
			foreach (POS.DataLayer.PURPurchaseReturnLine _pURPurchaseReturnLine in POS.DataLayer.PURPurchaseReturnLineBase.SelectAllByForeignKeyOriginalpurchaseLineIDPaged(new POS.DataLayer.PURPurchaseLinePrimaryKey(pk.PurchaseLineID), pageSize, skipPages, orderByStatement))
			{
				_pURPurchaseReturnLineWCF = new PURPurchaseReturnLine();
				_pURPurchaseReturnLineWCF.PurchaseReturnLineID = _pURPurchaseReturnLine.PurchaseReturnLineID;
				_pURPurchaseReturnLineWCF.Qty = _pURPurchaseReturnLine.Qty;
				_pURPurchaseReturnLineWCF.Reason = _pURPurchaseReturnLine.Reason;
				_pURPurchaseReturnLineWCF.OriginalpurchaseLineID = _pURPurchaseReturnLine.OriginalpurchaseLineID;
				_pURPurchaseReturnLineWCF.BatchID = _pURPurchaseReturnLine.BatchID;
				_pURPurchaseReturnLineWCF.BatchNumber = _pURPurchaseReturnLine.BatchNumber;
				_pURPurchaseReturnLineWCF.ExpiryDate = _pURPurchaseReturnLine.ExpiryDate;
				
				pURPurchaseReturnLineCollection.Add(_pURPurchaseReturnLineWCF);
			}
			return pURPurchaseReturnLineCollection;
		}
			
		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>list of objects of class PURPurchaseReturnLine in the form of an object of class PURPurchaseReturnLineCollection </returns>
		public PURPurchaseReturnLineCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			PURPurchaseReturnLineCollection pURPurchaseReturnLineCollection = new PURPurchaseReturnLineCollection();
			foreach (POS.DataLayer.PURPurchaseReturnLine _pURPurchaseReturnLine in POS.DataLayer.PURPurchaseReturnLineBase.SelectAllPaged(pageSize, skipPages, orderByStatement))
			{
				_pURPurchaseReturnLineWCF = new PURPurchaseReturnLine();
				
				_pURPurchaseReturnLineWCF.PurchaseReturnLineID = _pURPurchaseReturnLine.PurchaseReturnLineID;
				_pURPurchaseReturnLineWCF.Qty = _pURPurchaseReturnLine.Qty;
				_pURPurchaseReturnLineWCF.Reason = _pURPurchaseReturnLine.Reason;
				_pURPurchaseReturnLineWCF.OriginalpurchaseLineID = _pURPurchaseReturnLine.OriginalpurchaseLineID;
				_pURPurchaseReturnLineWCF.BatchID = _pURPurchaseReturnLine.BatchID;
				_pURPurchaseReturnLineWCF.BatchNumber = _pURPurchaseReturnLine.BatchNumber;
				_pURPurchaseReturnLineWCF.ExpiryDate = _pURPurchaseReturnLine.ExpiryDate;
				
				pURPurchaseReturnLineCollection.Add(_pURPurchaseReturnLineWCF);
			}
			return pURPurchaseReturnLineCollection;
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class PURPurchaseReturnLine</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class PURPurchaseReturnLine in the form of an object of class PURPurchaseReturnLineCollection</returns>
		public PURPurchaseReturnLineCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
		{
			PURPurchaseReturnLineCollection pURPurchaseReturnLineCollection = new PURPurchaseReturnLineCollection();
			foreach (POS.DataLayer.PURPurchaseReturnLine _pURPurchaseReturnLine in POS.DataLayer.PURPurchaseReturnLineBase.SelectByFieldPaged(field, fieldValue, fieldValue2, typeOperation, pageSize, skipPages, orderByStatement))
			{
				_pURPurchaseReturnLineWCF = new PURPurchaseReturnLine();
				
				_pURPurchaseReturnLineWCF.PurchaseReturnLineID = _pURPurchaseReturnLine.PurchaseReturnLineID;
				_pURPurchaseReturnLineWCF.Qty = _pURPurchaseReturnLine.Qty;
				_pURPurchaseReturnLineWCF.Reason = _pURPurchaseReturnLine.Reason;
				_pURPurchaseReturnLineWCF.OriginalpurchaseLineID = _pURPurchaseReturnLine.OriginalpurchaseLineID;
				_pURPurchaseReturnLineWCF.BatchID = _pURPurchaseReturnLine.BatchID;
				_pURPurchaseReturnLineWCF.BatchNumber = _pURPurchaseReturnLine.BatchNumber;
				_pURPurchaseReturnLineWCF.ExpiryDate = _pURPurchaseReturnLine.ExpiryDate;
				
				pURPurchaseReturnLineCollection.Add(_pURPurchaseReturnLineWCF);
			}
			return pURPurchaseReturnLineCollection;
		}
			///<summary>
		/// This method will update one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="pURPurchaseReturnLine" type="PURPurchaseReturnLine">This PURPurchaseReturnLine  will be updated in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Update(PURPurchaseReturnLine pURPurchaseReturnLine)
		{
			_pURPurchaseReturnLine=POS.DataLayer.PURPurchaseReturnLine.SelectOne(new POS.DataLayer.PURPurchaseReturnLinePrimaryKey(pURPurchaseReturnLine.PurchaseReturnLineID));
			
			_pURPurchaseReturnLine.Qty=pURPurchaseReturnLine.Qty;
			_pURPurchaseReturnLine.Reason=pURPurchaseReturnLine.Reason;
			_pURPurchaseReturnLine.OriginalpurchaseLineID=pURPurchaseReturnLine.OriginalpurchaseLineID;
			_pURPurchaseReturnLine.BatchID=pURPurchaseReturnLine.BatchID;
			_pURPurchaseReturnLine.BatchNumber=pURPurchaseReturnLine.BatchNumber;
			_pURPurchaseReturnLine.ExpiryDate=pURPurchaseReturnLine.ExpiryDate;
			
			return _pURPurchaseReturnLine.Update();
		}
	} 
}
