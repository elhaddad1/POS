//
// Class	:	VSALSalesOrderServices.svc.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	3/19/2015 1:00:18 PM
//


using POS.DataLayer;

namespace POS.BusinessLayer
{
	///<summary>
	///WCF service for the VSALSalesOrder
	///</summary>
	public class VSALSalesOrderService 
	{
		private VSALSalesOrder _vSALSalesOrderWCF;
		private POS.DataLayer.VSALSalesOrder _vSALSalesOrder;
		

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="VSALSalesOrderPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class VSALSalesOrder</returns>
		public VSALSalesOrder SelectOne(VSALSalesOrderPrimaryKey pk)
		{
			_vSALSalesOrderWCF = new VSALSalesOrder();
			_vSALSalesOrder = POS.DataLayer.VSALSalesOrderBase.SelectOne(new POS.DataLayer.VSALSalesOrderPrimaryKey(pk.CustomerID, pk.SalesLineID, pk.SalesHeaderID, pk.ProductID));
			
				_vSALSalesOrderWCF.CustomerID = _vSALSalesOrder.CustomerID;
				_vSALSalesOrderWCF.CustomerName = _vSALSalesOrder.CustomerName;
				_vSALSalesOrderWCF.Qty = _vSALSalesOrder.Qty;
				_vSALSalesOrderWCF.SalesLineID = _vSALSalesOrder.SalesLineID;
				_vSALSalesOrderWCF.TotalQty = _vSALSalesOrder.TotalQty;
				_vSALSalesOrderWCF.UnitPrice = _vSALSalesOrder.UnitPrice;
				_vSALSalesOrderWCF.BatchNumber = _vSALSalesOrder.BatchNumber;
				_vSALSalesOrderWCF.ExpiryDate = _vSALSalesOrder.ExpiryDate;
				_vSALSalesOrderWCF.TaxValue = _vSALSalesOrder.TaxValue;
				_vSALSalesOrderWCF.SalesHeaderID = _vSALSalesOrder.SalesHeaderID;
				_vSALSalesOrderWCF.SalesDate = _vSALSalesOrder.SalesDate;
				_vSALSalesOrderWCF.InvoiceNumber = _vSALSalesOrder.InvoiceNumber;
				_vSALSalesOrderWCF.InvoiceDate = _vSALSalesOrder.InvoiceDate;
				_vSALSalesOrderWCF.PaymentTypeID = _vSALSalesOrder.PaymentTypeID;
				_vSALSalesOrderWCF.TotalDiscountRatio = _vSALSalesOrder.TotalDiscountRatio;
				_vSALSalesOrderWCF.TaxTypeName = _vSALSalesOrder.TaxTypeName;
				_vSALSalesOrderWCF.IsClosed = _vSALSalesOrder.IsClosed;
				_vSALSalesOrderWCF.IsVoid = _vSALSalesOrder.IsVoid;
				_vSALSalesOrderWCF.FinalPrice = _vSALSalesOrder.FinalPrice;
				_vSALSalesOrderWCF.ChequeNumber = _vSALSalesOrder.ChequeNumber;
				_vSALSalesOrderWCF.ProductName = _vSALSalesOrder.ProductName;
				_vSALSalesOrderWCF.ProductCode = _vSALSalesOrder.ProductCode;
				_vSALSalesOrderWCF.IsAcceptBatch = _vSALSalesOrder.IsAcceptBatch;
				_vSALSalesOrderWCF.UserFullName = _vSALSalesOrder.UserFullName;
				_vSALSalesOrderWCF.ProductID = _vSALSalesOrder.ProductID;
				
			return _vSALSalesOrderWCF;
		}

		/// <summary>
		/// This method will return a list of objects representing all records in the table.
		/// </summary>
		///
		/// <returns>list of objects of class VSALSalesOrder in the form of object of VSALSalesOrderCollection </returns>
		public VSALSalesOrderCollection SelectAll()
		{
			VSALSalesOrderCollection vSALSalesOrderCollection = new VSALSalesOrderCollection();
			foreach (POS.DataLayer.VSALSalesOrder _vSALSalesOrder in POS.DataLayer.VSALSalesOrderBase.SelectAll())
			{
				_vSALSalesOrderWCF = new VSALSalesOrder();
				
				_vSALSalesOrderWCF.CustomerID = _vSALSalesOrder.CustomerID;
				_vSALSalesOrderWCF.CustomerName = _vSALSalesOrder.CustomerName;
				_vSALSalesOrderWCF.Qty = _vSALSalesOrder.Qty;
				_vSALSalesOrderWCF.SalesLineID = _vSALSalesOrder.SalesLineID;
				_vSALSalesOrderWCF.TotalQty = _vSALSalesOrder.TotalQty;
				_vSALSalesOrderWCF.UnitPrice = _vSALSalesOrder.UnitPrice;
				_vSALSalesOrderWCF.BatchNumber = _vSALSalesOrder.BatchNumber;
				_vSALSalesOrderWCF.ExpiryDate = _vSALSalesOrder.ExpiryDate;
				_vSALSalesOrderWCF.TaxValue = _vSALSalesOrder.TaxValue;
				_vSALSalesOrderWCF.SalesHeaderID = _vSALSalesOrder.SalesHeaderID;
				_vSALSalesOrderWCF.SalesDate = _vSALSalesOrder.SalesDate;
				_vSALSalesOrderWCF.InvoiceNumber = _vSALSalesOrder.InvoiceNumber;
				_vSALSalesOrderWCF.InvoiceDate = _vSALSalesOrder.InvoiceDate;
				_vSALSalesOrderWCF.PaymentTypeID = _vSALSalesOrder.PaymentTypeID;
				_vSALSalesOrderWCF.TotalDiscountRatio = _vSALSalesOrder.TotalDiscountRatio;
				_vSALSalesOrderWCF.TaxTypeName = _vSALSalesOrder.TaxTypeName;
				_vSALSalesOrderWCF.IsClosed = _vSALSalesOrder.IsClosed;
				_vSALSalesOrderWCF.IsVoid = _vSALSalesOrder.IsVoid;
				_vSALSalesOrderWCF.FinalPrice = _vSALSalesOrder.FinalPrice;
				_vSALSalesOrderWCF.ChequeNumber = _vSALSalesOrder.ChequeNumber;
				_vSALSalesOrderWCF.ProductName = _vSALSalesOrder.ProductName;
				_vSALSalesOrderWCF.ProductCode = _vSALSalesOrder.ProductCode;
				_vSALSalesOrderWCF.IsAcceptBatch = _vSALSalesOrder.IsAcceptBatch;
				_vSALSalesOrderWCF.UserFullName = _vSALSalesOrder.UserFullName;
				_vSALSalesOrderWCF.ProductID = _vSALSalesOrder.ProductID;
				
				vSALSalesOrderCollection.Add(_vSALSalesOrderWCF);
			}
			return vSALSalesOrderCollection;
		}
    
    /// <summary>
		/// This method will return a count all records in the table.
		/// </summary>
		///
		/// <returns>count records</returns>
		public int SelectAllCount()
		{
			return POS.DataLayer.VSALSalesOrderBase.SelectAllCount();			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class VSALSalesOrder</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class VSALSalesOrder in the form of an object of class VSALSalesOrderCollection</returns>
		public VSALSalesOrderCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
		{
			VSALSalesOrderCollection vSALSalesOrderCollection = new VSALSalesOrderCollection();
			foreach (POS.DataLayer.VSALSalesOrder _vSALSalesOrder in POS.DataLayer.VSALSalesOrderBase.SelectByField(field, fieldValue, fieldValue2, typeOperation))
			{
				_vSALSalesOrderWCF = new VSALSalesOrder();
				
				_vSALSalesOrderWCF.CustomerID = _vSALSalesOrder.CustomerID;
				_vSALSalesOrderWCF.CustomerName = _vSALSalesOrder.CustomerName;
				_vSALSalesOrderWCF.Qty = _vSALSalesOrder.Qty;
				_vSALSalesOrderWCF.SalesLineID = _vSALSalesOrder.SalesLineID;
				_vSALSalesOrderWCF.TotalQty = _vSALSalesOrder.TotalQty;
				_vSALSalesOrderWCF.UnitPrice = _vSALSalesOrder.UnitPrice;
				_vSALSalesOrderWCF.BatchNumber = _vSALSalesOrder.BatchNumber;
				_vSALSalesOrderWCF.ExpiryDate = _vSALSalesOrder.ExpiryDate;
				_vSALSalesOrderWCF.TaxValue = _vSALSalesOrder.TaxValue;
				_vSALSalesOrderWCF.SalesHeaderID = _vSALSalesOrder.SalesHeaderID;
				_vSALSalesOrderWCF.SalesDate = _vSALSalesOrder.SalesDate;
				_vSALSalesOrderWCF.InvoiceNumber = _vSALSalesOrder.InvoiceNumber;
				_vSALSalesOrderWCF.InvoiceDate = _vSALSalesOrder.InvoiceDate;
				_vSALSalesOrderWCF.PaymentTypeID = _vSALSalesOrder.PaymentTypeID;
				_vSALSalesOrderWCF.TotalDiscountRatio = _vSALSalesOrder.TotalDiscountRatio;
				_vSALSalesOrderWCF.TaxTypeName = _vSALSalesOrder.TaxTypeName;
				_vSALSalesOrderWCF.IsClosed = _vSALSalesOrder.IsClosed;
				_vSALSalesOrderWCF.IsVoid = _vSALSalesOrder.IsVoid;
				_vSALSalesOrderWCF.FinalPrice = _vSALSalesOrder.FinalPrice;
				_vSALSalesOrderWCF.ChequeNumber = _vSALSalesOrder.ChequeNumber;
				_vSALSalesOrderWCF.ProductName = _vSALSalesOrder.ProductName;
				_vSALSalesOrderWCF.ProductCode = _vSALSalesOrder.ProductCode;
				_vSALSalesOrderWCF.IsAcceptBatch = _vSALSalesOrder.IsAcceptBatch;
				_vSALSalesOrderWCF.UserFullName = _vSALSalesOrder.UserFullName;
				_vSALSalesOrderWCF.ProductID = _vSALSalesOrder.ProductID;
				
				vSALSalesOrderCollection.Add(_vSALSalesOrderWCF);
			}
			return vSALSalesOrderCollection;
		}
		
	
		
		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>list of objects of class VSALSalesOrder in the form of an object of class VSALSalesOrderCollection </returns>
		public VSALSalesOrderCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			VSALSalesOrderCollection vSALSalesOrderCollection = new VSALSalesOrderCollection();
			foreach (POS.DataLayer.VSALSalesOrder _vSALSalesOrder in POS.DataLayer.VSALSalesOrderBase.SelectAllPaged(pageSize, skipPages, orderByStatement))
			{
				_vSALSalesOrderWCF = new VSALSalesOrder();
				
				_vSALSalesOrderWCF.CustomerID = _vSALSalesOrder.CustomerID;
				_vSALSalesOrderWCF.CustomerName = _vSALSalesOrder.CustomerName;
				_vSALSalesOrderWCF.Qty = _vSALSalesOrder.Qty;
				_vSALSalesOrderWCF.SalesLineID = _vSALSalesOrder.SalesLineID;
				_vSALSalesOrderWCF.TotalQty = _vSALSalesOrder.TotalQty;
				_vSALSalesOrderWCF.UnitPrice = _vSALSalesOrder.UnitPrice;
				_vSALSalesOrderWCF.BatchNumber = _vSALSalesOrder.BatchNumber;
				_vSALSalesOrderWCF.ExpiryDate = _vSALSalesOrder.ExpiryDate;
				_vSALSalesOrderWCF.TaxValue = _vSALSalesOrder.TaxValue;
				_vSALSalesOrderWCF.SalesHeaderID = _vSALSalesOrder.SalesHeaderID;
				_vSALSalesOrderWCF.SalesDate = _vSALSalesOrder.SalesDate;
				_vSALSalesOrderWCF.InvoiceNumber = _vSALSalesOrder.InvoiceNumber;
				_vSALSalesOrderWCF.InvoiceDate = _vSALSalesOrder.InvoiceDate;
				_vSALSalesOrderWCF.PaymentTypeID = _vSALSalesOrder.PaymentTypeID;
				_vSALSalesOrderWCF.TotalDiscountRatio = _vSALSalesOrder.TotalDiscountRatio;
				_vSALSalesOrderWCF.TaxTypeName = _vSALSalesOrder.TaxTypeName;
				_vSALSalesOrderWCF.IsClosed = _vSALSalesOrder.IsClosed;
				_vSALSalesOrderWCF.IsVoid = _vSALSalesOrder.IsVoid;
				_vSALSalesOrderWCF.FinalPrice = _vSALSalesOrder.FinalPrice;
				_vSALSalesOrderWCF.ChequeNumber = _vSALSalesOrder.ChequeNumber;
				_vSALSalesOrderWCF.ProductName = _vSALSalesOrder.ProductName;
				_vSALSalesOrderWCF.ProductCode = _vSALSalesOrder.ProductCode;
				_vSALSalesOrderWCF.IsAcceptBatch = _vSALSalesOrder.IsAcceptBatch;
				_vSALSalesOrderWCF.UserFullName = _vSALSalesOrder.UserFullName;
				_vSALSalesOrderWCF.ProductID = _vSALSalesOrder.ProductID;
				
				vSALSalesOrderCollection.Add(_vSALSalesOrderWCF);
			}
			return vSALSalesOrderCollection;
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class VSALSalesOrder</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class VSALSalesOrder in the form of an object of class VSALSalesOrderCollection</returns>
		public VSALSalesOrderCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
		{
			VSALSalesOrderCollection vSALSalesOrderCollection = new VSALSalesOrderCollection();
			foreach (POS.DataLayer.VSALSalesOrder _vSALSalesOrder in POS.DataLayer.VSALSalesOrderBase.SelectByFieldPaged(field, fieldValue, fieldValue2, typeOperation, pageSize, skipPages, orderByStatement))
			{
				_vSALSalesOrderWCF = new VSALSalesOrder();
				
				_vSALSalesOrderWCF.CustomerID = _vSALSalesOrder.CustomerID;
				_vSALSalesOrderWCF.CustomerName = _vSALSalesOrder.CustomerName;
				_vSALSalesOrderWCF.Qty = _vSALSalesOrder.Qty;
				_vSALSalesOrderWCF.SalesLineID = _vSALSalesOrder.SalesLineID;
				_vSALSalesOrderWCF.TotalQty = _vSALSalesOrder.TotalQty;
				_vSALSalesOrderWCF.UnitPrice = _vSALSalesOrder.UnitPrice;
				_vSALSalesOrderWCF.BatchNumber = _vSALSalesOrder.BatchNumber;
				_vSALSalesOrderWCF.ExpiryDate = _vSALSalesOrder.ExpiryDate;
				_vSALSalesOrderWCF.TaxValue = _vSALSalesOrder.TaxValue;
				_vSALSalesOrderWCF.SalesHeaderID = _vSALSalesOrder.SalesHeaderID;
				_vSALSalesOrderWCF.SalesDate = _vSALSalesOrder.SalesDate;
				_vSALSalesOrderWCF.InvoiceNumber = _vSALSalesOrder.InvoiceNumber;
				_vSALSalesOrderWCF.InvoiceDate = _vSALSalesOrder.InvoiceDate;
				_vSALSalesOrderWCF.PaymentTypeID = _vSALSalesOrder.PaymentTypeID;
				_vSALSalesOrderWCF.TotalDiscountRatio = _vSALSalesOrder.TotalDiscountRatio;
				_vSALSalesOrderWCF.TaxTypeName = _vSALSalesOrder.TaxTypeName;
				_vSALSalesOrderWCF.IsClosed = _vSALSalesOrder.IsClosed;
				_vSALSalesOrderWCF.IsVoid = _vSALSalesOrder.IsVoid;
				_vSALSalesOrderWCF.FinalPrice = _vSALSalesOrder.FinalPrice;
				_vSALSalesOrderWCF.ChequeNumber = _vSALSalesOrder.ChequeNumber;
				_vSALSalesOrderWCF.ProductName = _vSALSalesOrder.ProductName;
				_vSALSalesOrderWCF.ProductCode = _vSALSalesOrder.ProductCode;
				_vSALSalesOrderWCF.IsAcceptBatch = _vSALSalesOrder.IsAcceptBatch;
				_vSALSalesOrderWCF.UserFullName = _vSALSalesOrder.UserFullName;
				_vSALSalesOrderWCF.ProductID = _vSALSalesOrder.ProductID;
				
				vSALSalesOrderCollection.Add(_vSALSalesOrderWCF);
			}
			return vSALSalesOrderCollection;
		}
	
	} 
}
