//
// Class	:	INVAdjustStockReasonServices.svc.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	3/7/2015 2:37:09 PM
//

using POS.DataLayer;

namespace POS.BusinessLayer
{
	///<summary>
	///WCF service for the INVAdjustStockReason
	///</summary>
	public class INVAdjustStockReasonService 
	{
		private INVAdjustStockReason _iNVAdjustStockReasonWCF;
		private POS.DataLayer.INVAdjustStockReason _iNVAdjustStockReason;
		
		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="INVAdjustStockReasonFields">Field of the class INVAdjustStockReason</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <returns>True if succeeded</returns>
		public bool DeleteByField(string field, object fieldValue)
		{
			return POS.DataLayer.INVAdjustStockReasonBase.DeleteByField(field, fieldValue);
		}

		///<summary>
		///This method will Delete the object from the database
		///</summary>
		///<param name="pk" type="INVAdjustStockReasonPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <returns>True if succeeded</returns>
		public bool Delete(INVAdjustStockReasonPrimaryKey pk)
		{
			return POS.DataLayer.INVAdjustStockReasonBase.Delete(new POS.DataLayer.INVAdjustStockReasonPrimaryKey(pk.AdjustStockReasonID));
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="INVAdjustStockReasonPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class INVAdjustStockReason</returns>
		public INVAdjustStockReason SelectOne(INVAdjustStockReasonPrimaryKey pk)
		{
			_iNVAdjustStockReasonWCF = new INVAdjustStockReason();
			_iNVAdjustStockReason = POS.DataLayer.INVAdjustStockReasonBase.SelectOne(new POS.DataLayer.INVAdjustStockReasonPrimaryKey(pk.AdjustStockReasonID));
			
				_iNVAdjustStockReasonWCF.AdjustStockReasonID = _iNVAdjustStockReason.AdjustStockReasonID;
				_iNVAdjustStockReasonWCF.AdjustStockreasonName = _iNVAdjustStockReason.AdjustStockreasonName;
				
			return _iNVAdjustStockReasonWCF;
		}

		/// <summary>
		/// This method will return a list of objects representing all records in the table.
		/// </summary>
		///
		/// <returns>list of objects of class INVAdjustStockReason in the form of object of INVAdjustStockReasonCollection </returns>
		public INVAdjustStockReasonCollection SelectAll()
		{
			INVAdjustStockReasonCollection iNVAdjustStockReasonCollection = new INVAdjustStockReasonCollection();
			foreach (POS.DataLayer.INVAdjustStockReason _iNVAdjustStockReason in POS.DataLayer.INVAdjustStockReasonBase.SelectAll())
			{
				_iNVAdjustStockReasonWCF = new INVAdjustStockReason();
				
				_iNVAdjustStockReasonWCF.AdjustStockReasonID = _iNVAdjustStockReason.AdjustStockReasonID;
				_iNVAdjustStockReasonWCF.AdjustStockreasonName = _iNVAdjustStockReason.AdjustStockreasonName;
				
				iNVAdjustStockReasonCollection.Add(_iNVAdjustStockReasonWCF);
			}
			return iNVAdjustStockReasonCollection;
		}
    
    /// <summary>
		/// This method will return a count all records in the table.
		/// </summary>
		///
		/// <returns>count records</returns>
		public int SelectAllCount()
		{
			return POS.DataLayer.INVAdjustStockReasonBase.SelectAllCount();			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class INVAdjustStockReason</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class INVAdjustStockReason in the form of an object of class INVAdjustStockReasonCollection</returns>
		public INVAdjustStockReasonCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
		{
			INVAdjustStockReasonCollection iNVAdjustStockReasonCollection = new INVAdjustStockReasonCollection();
			foreach (POS.DataLayer.INVAdjustStockReason _iNVAdjustStockReason in POS.DataLayer.INVAdjustStockReasonBase.SelectByField(field, fieldValue, fieldValue2, typeOperation))
			{
				_iNVAdjustStockReasonWCF = new INVAdjustStockReason();
				
				_iNVAdjustStockReasonWCF.AdjustStockReasonID = _iNVAdjustStockReason.AdjustStockReasonID;
				_iNVAdjustStockReasonWCF.AdjustStockreasonName = _iNVAdjustStockReason.AdjustStockreasonName;
				
				iNVAdjustStockReasonCollection.Add(_iNVAdjustStockReasonWCF);
			}
			return iNVAdjustStockReasonCollection;
		}
		
		/// <summary>
		/// This method will insert one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="iNVAdjustStockReason" type="INVAdjustStockReason">This INVAdjustStockReason  will be inserted in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Insert(INVAdjustStockReason iNVAdjustStockReason)
		{
			_iNVAdjustStockReason = new POS.DataLayer.INVAdjustStockReason();
			_iNVAdjustStockReason.AdjustStockReasonID=iNVAdjustStockReason.AdjustStockReasonID;
			_iNVAdjustStockReason.AdjustStockreasonName=iNVAdjustStockReason.AdjustStockreasonName;
			
			return _iNVAdjustStockReason.Insert();
		}
		
		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>list of objects of class INVAdjustStockReason in the form of an object of class INVAdjustStockReasonCollection </returns>
		public INVAdjustStockReasonCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			INVAdjustStockReasonCollection iNVAdjustStockReasonCollection = new INVAdjustStockReasonCollection();
			foreach (POS.DataLayer.INVAdjustStockReason _iNVAdjustStockReason in POS.DataLayer.INVAdjustStockReasonBase.SelectAllPaged(pageSize, skipPages, orderByStatement))
			{
				_iNVAdjustStockReasonWCF = new INVAdjustStockReason();
				
				_iNVAdjustStockReasonWCF.AdjustStockReasonID = _iNVAdjustStockReason.AdjustStockReasonID;
				_iNVAdjustStockReasonWCF.AdjustStockreasonName = _iNVAdjustStockReason.AdjustStockreasonName;
				
				iNVAdjustStockReasonCollection.Add(_iNVAdjustStockReasonWCF);
			}
			return iNVAdjustStockReasonCollection;
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class INVAdjustStockReason</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class INVAdjustStockReason in the form of an object of class INVAdjustStockReasonCollection</returns>
		public INVAdjustStockReasonCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
		{
			INVAdjustStockReasonCollection iNVAdjustStockReasonCollection = new INVAdjustStockReasonCollection();
			foreach (POS.DataLayer.INVAdjustStockReason _iNVAdjustStockReason in POS.DataLayer.INVAdjustStockReasonBase.SelectByFieldPaged(field, fieldValue, fieldValue2, typeOperation, pageSize, skipPages, orderByStatement))
			{
				_iNVAdjustStockReasonWCF = new INVAdjustStockReason();
				
				_iNVAdjustStockReasonWCF.AdjustStockReasonID = _iNVAdjustStockReason.AdjustStockReasonID;
				_iNVAdjustStockReasonWCF.AdjustStockreasonName = _iNVAdjustStockReason.AdjustStockreasonName;
				
				iNVAdjustStockReasonCollection.Add(_iNVAdjustStockReasonWCF);
			}
			return iNVAdjustStockReasonCollection;
		}
			///<summary>
		/// This method will update one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="iNVAdjustStockReason" type="INVAdjustStockReason">This INVAdjustStockReason  will be updated in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Update(INVAdjustStockReason iNVAdjustStockReason)
		{
			_iNVAdjustStockReason=POS.DataLayer.INVAdjustStockReason.SelectOne(new POS.DataLayer.INVAdjustStockReasonPrimaryKey(iNVAdjustStockReason.AdjustStockReasonID));
			
			_iNVAdjustStockReason.AdjustStockreasonName=iNVAdjustStockReason.AdjustStockreasonName;
			
			return _iNVAdjustStockReason.Update();
		}
	} 
}
