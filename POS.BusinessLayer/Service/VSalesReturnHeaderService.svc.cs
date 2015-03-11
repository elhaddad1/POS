//
// Class	:	VSalesReturnHeaderServices.svc.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	3/9/2015 4:39:22 PM
//


using POS.DataLayer;

namespace POS.BusinessLayer
{
	///<summary>
	///WCF service for the VSalesReturnHeader
	///</summary>
	public class VSalesReturnHeaderService 
	{
		private VSalesReturnHeader _vSalesReturnHeaderWCF;
		private POS.DataLayer.VSalesReturnHeader _vSalesReturnHeader;
		
			/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="VSalesReturnHeaderPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class VSalesReturnHeader</returns>
		public VSalesReturnHeader SelectOne(VSalesReturnHeaderPrimaryKey pk)
		{
			_vSalesReturnHeaderWCF = new VSalesReturnHeader();
			_vSalesReturnHeader = POS.DataLayer.VSalesReturnHeaderBase.SelectOne(new POS.DataLayer.VSalesReturnHeaderPrimaryKey(pk.SlaesReturnHeaderID, pk.SalesHeaderID));
			
				_vSalesReturnHeaderWCF.SlaesReturnHeaderID = _vSalesReturnHeader.SlaesReturnHeaderID;
				_vSalesReturnHeaderWCF.ReturnDate = _vSalesReturnHeader.ReturnDate;
				_vSalesReturnHeaderWCF.IsClosed = _vSalesReturnHeader.IsClosed;
				_vSalesReturnHeaderWCF.InvoiceNumber = _vSalesReturnHeader.InvoiceNumber;
				_vSalesReturnHeaderWCF.CustomerName = _vSalesReturnHeader.CustomerName;
				_vSalesReturnHeaderWCF.SalesHeaderID = _vSalesReturnHeader.SalesHeaderID;
				
			return _vSalesReturnHeaderWCF;
		}

		/// <summary>
		/// This method will return a list of objects representing all records in the table.
		/// </summary>
		///
		/// <returns>list of objects of class VSalesReturnHeader in the form of object of VSalesReturnHeaderCollection </returns>
		public VSalesReturnHeaderCollection SelectAll()
		{
			VSalesReturnHeaderCollection vSalesReturnHeaderCollection = new VSalesReturnHeaderCollection();
			foreach (POS.DataLayer.VSalesReturnHeader _vSalesReturnHeader in POS.DataLayer.VSalesReturnHeaderBase.SelectAll())
			{
				_vSalesReturnHeaderWCF = new VSalesReturnHeader();
				
				_vSalesReturnHeaderWCF.SlaesReturnHeaderID = _vSalesReturnHeader.SlaesReturnHeaderID;
				_vSalesReturnHeaderWCF.ReturnDate = _vSalesReturnHeader.ReturnDate;
				_vSalesReturnHeaderWCF.IsClosed = _vSalesReturnHeader.IsClosed;
				_vSalesReturnHeaderWCF.InvoiceNumber = _vSalesReturnHeader.InvoiceNumber;
				_vSalesReturnHeaderWCF.CustomerName = _vSalesReturnHeader.CustomerName;
				_vSalesReturnHeaderWCF.SalesHeaderID = _vSalesReturnHeader.SalesHeaderID;
				
				vSalesReturnHeaderCollection.Add(_vSalesReturnHeaderWCF);
			}
			return vSalesReturnHeaderCollection;
		}
    
    /// <summary>
		/// This method will return a count all records in the table.
		/// </summary>
		///
		/// <returns>count records</returns>
		public int SelectAllCount()
		{
			return POS.DataLayer.VSalesReturnHeaderBase.SelectAllCount();			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class VSalesReturnHeader</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class VSalesReturnHeader in the form of an object of class VSalesReturnHeaderCollection</returns>
		public VSalesReturnHeaderCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
		{
			VSalesReturnHeaderCollection vSalesReturnHeaderCollection = new VSalesReturnHeaderCollection();
			foreach (POS.DataLayer.VSalesReturnHeader _vSalesReturnHeader in POS.DataLayer.VSalesReturnHeaderBase.SelectByField(field, fieldValue, fieldValue2, typeOperation))
			{
				_vSalesReturnHeaderWCF = new VSalesReturnHeader();
				
				_vSalesReturnHeaderWCF.SlaesReturnHeaderID = _vSalesReturnHeader.SlaesReturnHeaderID;
				_vSalesReturnHeaderWCF.ReturnDate = _vSalesReturnHeader.ReturnDate;
				_vSalesReturnHeaderWCF.IsClosed = _vSalesReturnHeader.IsClosed;
				_vSalesReturnHeaderWCF.InvoiceNumber = _vSalesReturnHeader.InvoiceNumber;
				_vSalesReturnHeaderWCF.CustomerName = _vSalesReturnHeader.CustomerName;
				_vSalesReturnHeaderWCF.SalesHeaderID = _vSalesReturnHeader.SalesHeaderID;
				
				vSalesReturnHeaderCollection.Add(_vSalesReturnHeaderWCF);
			}
			return vSalesReturnHeaderCollection;
		}
			
		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>list of objects of class VSalesReturnHeader in the form of an object of class VSalesReturnHeaderCollection </returns>
		public VSalesReturnHeaderCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			VSalesReturnHeaderCollection vSalesReturnHeaderCollection = new VSalesReturnHeaderCollection();
			foreach (POS.DataLayer.VSalesReturnHeader _vSalesReturnHeader in POS.DataLayer.VSalesReturnHeaderBase.SelectAllPaged(pageSize, skipPages, orderByStatement))
			{
				_vSalesReturnHeaderWCF = new VSalesReturnHeader();
				
				_vSalesReturnHeaderWCF.SlaesReturnHeaderID = _vSalesReturnHeader.SlaesReturnHeaderID;
				_vSalesReturnHeaderWCF.ReturnDate = _vSalesReturnHeader.ReturnDate;
				_vSalesReturnHeaderWCF.IsClosed = _vSalesReturnHeader.IsClosed;
				_vSalesReturnHeaderWCF.InvoiceNumber = _vSalesReturnHeader.InvoiceNumber;
				_vSalesReturnHeaderWCF.CustomerName = _vSalesReturnHeader.CustomerName;
				_vSalesReturnHeaderWCF.SalesHeaderID = _vSalesReturnHeader.SalesHeaderID;
				
				vSalesReturnHeaderCollection.Add(_vSalesReturnHeaderWCF);
			}
			return vSalesReturnHeaderCollection;
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class VSalesReturnHeader</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class VSalesReturnHeader in the form of an object of class VSalesReturnHeaderCollection</returns>
		public VSalesReturnHeaderCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
		{
			VSalesReturnHeaderCollection vSalesReturnHeaderCollection = new VSalesReturnHeaderCollection();
			foreach (POS.DataLayer.VSalesReturnHeader _vSalesReturnHeader in POS.DataLayer.VSalesReturnHeaderBase.SelectByFieldPaged(field, fieldValue, fieldValue2, typeOperation, pageSize, skipPages, orderByStatement))
			{
				_vSalesReturnHeaderWCF = new VSalesReturnHeader();
				
				_vSalesReturnHeaderWCF.SlaesReturnHeaderID = _vSalesReturnHeader.SlaesReturnHeaderID;
				_vSalesReturnHeaderWCF.ReturnDate = _vSalesReturnHeader.ReturnDate;
				_vSalesReturnHeaderWCF.IsClosed = _vSalesReturnHeader.IsClosed;
				_vSalesReturnHeaderWCF.InvoiceNumber = _vSalesReturnHeader.InvoiceNumber;
				_vSalesReturnHeaderWCF.CustomerName = _vSalesReturnHeader.CustomerName;
				_vSalesReturnHeaderWCF.SalesHeaderID = _vSalesReturnHeader.SalesHeaderID;
				
				vSalesReturnHeaderCollection.Add(_vSalesReturnHeaderWCF);
			}
			return vSalesReturnHeaderCollection;
		}

	} 
}
