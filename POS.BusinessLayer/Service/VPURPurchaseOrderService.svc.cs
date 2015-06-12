//
// Class	:	VPURPurchaseOrderServices.svc.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	11/4/2015 9:57:47 PM
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
	///WCF service for the VPURPurchaseOrder
	///</summary>
	public class VPURPurchaseOrderService 
	{
		private VPURPurchaseOrder _vPURPurchaseOrderWCF;
		private POS.DataLayer.VPURPurchaseOrder _vPURPurchaseOrder;
		
		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="VPURPurchaseOrderFields">Field of the class VPURPurchaseOrder</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <returns>True if succeeded</returns>
        //public bool DeleteByField(string field, object fieldValue)
        //{
        //    //return POS.DataLayer.VPURPurchaseOrderBase.DeleteByField(field, fieldValue);
        //}

		///<summary>
		///This method will Delete the object from the database
		///</summary>
		///<param name="pk" type="VPURPurchaseOrderPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <returns>True if succeeded</returns>
        //public bool Delete(VPURPurchaseOrderPrimaryKey pk)
        //{
        //    return POS.DataLayer.VPURPurchaseOrderBase.Delete(new POS.DataLayer.VPURPurchaseOrderPrimaryKey(pk.SupplierID, pk.PurchaseLineID, pk.PurcaseHeaderID, pk.ProductID));
        //}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="VPURPurchaseOrderPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class VPURPurchaseOrder</returns>
		public VPURPurchaseOrder SelectOne(VPURPurchaseOrderPrimaryKey pk)
		{
			_vPURPurchaseOrderWCF = new VPURPurchaseOrder();
			_vPURPurchaseOrder = POS.DataLayer.VPURPurchaseOrderBase.SelectOne(new POS.DataLayer.VPURPurchaseOrderPrimaryKey(pk.SupplierID, pk.PurchaseLineID, pk.PurcaseHeaderID, pk.ProductID));
			
				_vPURPurchaseOrderWCF.SupplierID = _vPURPurchaseOrder.SupplierID;
				_vPURPurchaseOrderWCF.SupplierName = _vPURPurchaseOrder.SupplierName;
				_vPURPurchaseOrderWCF.Qty = _vPURPurchaseOrder.Qty;
				_vPURPurchaseOrderWCF.PurchaseLineID = _vPURPurchaseOrder.PurchaseLineID;
				_vPURPurchaseOrderWCF.TotalQty = _vPURPurchaseOrder.TotalQty;
				_vPURPurchaseOrderWCF.UnitPrice = _vPURPurchaseOrder.UnitPrice;
				_vPURPurchaseOrderWCF.BatchNumber = _vPURPurchaseOrder.BatchNumber;
				_vPURPurchaseOrderWCF.ExpiryDate = _vPURPurchaseOrder.ExpiryDate;
				_vPURPurchaseOrderWCF.TaxValue = _vPURPurchaseOrder.TaxValue;
				_vPURPurchaseOrderWCF.PurcaseHeaderID = _vPURPurchaseOrder.PurcaseHeaderID;
				_vPURPurchaseOrderWCF.PurchaseDate = _vPURPurchaseOrder.PurchaseDate;
				_vPURPurchaseOrderWCF.InvoiceNumber = _vPURPurchaseOrder.InvoiceNumber;
				_vPURPurchaseOrderWCF.InvoiceDate = _vPURPurchaseOrder.InvoiceDate;
				_vPURPurchaseOrderWCF.PaymentTypeID = _vPURPurchaseOrder.PaymentTypeID;
				_vPURPurchaseOrderWCF.TotalDiscountRatio = _vPURPurchaseOrder.TotalDiscountRatio;
				_vPURPurchaseOrderWCF.TaxTypeName = _vPURPurchaseOrder.TaxTypeName;
				_vPURPurchaseOrderWCF.IsClosed = _vPURPurchaseOrder.IsClosed;
				_vPURPurchaseOrderWCF.IsVoid = _vPURPurchaseOrder.IsVoid;
				_vPURPurchaseOrderWCF.ChequeNumber = _vPURPurchaseOrder.ChequeNumber;
				_vPURPurchaseOrderWCF.ProductName = _vPURPurchaseOrder.ProductName;
				_vPURPurchaseOrderWCF.ProductCode = _vPURPurchaseOrder.ProductCode;
				_vPURPurchaseOrderWCF.IsAcceptBatch = _vPURPurchaseOrder.IsAcceptBatch;
				_vPURPurchaseOrderWCF.UserFullName = _vPURPurchaseOrder.UserFullName;
				_vPURPurchaseOrderWCF.ProductID = _vPURPurchaseOrder.ProductID;
				
			return _vPURPurchaseOrderWCF;
		}

		/// <summary>
		/// This method will return a list of objects representing all records in the table.
		/// </summary>
		///
		/// <returns>list of objects of class VPURPurchaseOrder in the form of object of VPURPurchaseOrderCollection </returns>
		public VPURPurchaseOrderCollection SelectAll()
		{
			VPURPurchaseOrderCollection vPURPurchaseOrderCollection = new VPURPurchaseOrderCollection();
			foreach (POS.DataLayer.VPURPurchaseOrder _vPURPurchaseOrder in POS.DataLayer.VPURPurchaseOrderBase.SelectAll())
			{
				_vPURPurchaseOrderWCF = new VPURPurchaseOrder();
				
				_vPURPurchaseOrderWCF.SupplierID = _vPURPurchaseOrder.SupplierID;
				_vPURPurchaseOrderWCF.SupplierName = _vPURPurchaseOrder.SupplierName;
				_vPURPurchaseOrderWCF.Qty = _vPURPurchaseOrder.Qty;
				_vPURPurchaseOrderWCF.PurchaseLineID = _vPURPurchaseOrder.PurchaseLineID;
				_vPURPurchaseOrderWCF.TotalQty = _vPURPurchaseOrder.TotalQty;
				_vPURPurchaseOrderWCF.UnitPrice = _vPURPurchaseOrder.UnitPrice;
				_vPURPurchaseOrderWCF.BatchNumber = _vPURPurchaseOrder.BatchNumber;
				_vPURPurchaseOrderWCF.ExpiryDate = _vPURPurchaseOrder.ExpiryDate;
				_vPURPurchaseOrderWCF.TaxValue = _vPURPurchaseOrder.TaxValue;
				_vPURPurchaseOrderWCF.PurcaseHeaderID = _vPURPurchaseOrder.PurcaseHeaderID;
				_vPURPurchaseOrderWCF.PurchaseDate = _vPURPurchaseOrder.PurchaseDate;
				_vPURPurchaseOrderWCF.InvoiceNumber = _vPURPurchaseOrder.InvoiceNumber;
				_vPURPurchaseOrderWCF.InvoiceDate = _vPURPurchaseOrder.InvoiceDate;
				_vPURPurchaseOrderWCF.PaymentTypeID = _vPURPurchaseOrder.PaymentTypeID;
				_vPURPurchaseOrderWCF.TotalDiscountRatio = _vPURPurchaseOrder.TotalDiscountRatio;
				_vPURPurchaseOrderWCF.TaxTypeName = _vPURPurchaseOrder.TaxTypeName;
				_vPURPurchaseOrderWCF.IsClosed = _vPURPurchaseOrder.IsClosed;
				_vPURPurchaseOrderWCF.IsVoid = _vPURPurchaseOrder.IsVoid;
				_vPURPurchaseOrderWCF.ChequeNumber = _vPURPurchaseOrder.ChequeNumber;
				_vPURPurchaseOrderWCF.ProductName = _vPURPurchaseOrder.ProductName;
				_vPURPurchaseOrderWCF.ProductCode = _vPURPurchaseOrder.ProductCode;
				_vPURPurchaseOrderWCF.IsAcceptBatch = _vPURPurchaseOrder.IsAcceptBatch;
				_vPURPurchaseOrderWCF.UserFullName = _vPURPurchaseOrder.UserFullName;
				_vPURPurchaseOrderWCF.ProductID = _vPURPurchaseOrder.ProductID;
				
				vPURPurchaseOrderCollection.Add(_vPURPurchaseOrderWCF);
			}
			return vPURPurchaseOrderCollection;
		}
    
    /// <summary>
		/// This method will return a count all records in the table.
		/// </summary>
		///
		/// <returns>count records</returns>
		public int SelectAllCount()
		{
			return POS.DataLayer.VPURPurchaseOrderBase.SelectAllCount();			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class VPURPurchaseOrder</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class VPURPurchaseOrder in the form of an object of class VPURPurchaseOrderCollection</returns>
		public VPURPurchaseOrderCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
		{
			VPURPurchaseOrderCollection vPURPurchaseOrderCollection = new VPURPurchaseOrderCollection();
			foreach (POS.DataLayer.VPURPurchaseOrder _vPURPurchaseOrder in POS.DataLayer.VPURPurchaseOrder.SelectByField(field, fieldValue, fieldValue2, typeOperation))
			{
				_vPURPurchaseOrderWCF = new VPURPurchaseOrder();
				
				_vPURPurchaseOrderWCF.SupplierID = _vPURPurchaseOrder.SupplierID;
				_vPURPurchaseOrderWCF.SupplierName = _vPURPurchaseOrder.SupplierName;
				_vPURPurchaseOrderWCF.Qty = _vPURPurchaseOrder.Qty;
				_vPURPurchaseOrderWCF.PurchaseLineID = _vPURPurchaseOrder.PurchaseLineID;
				_vPURPurchaseOrderWCF.TotalQty = _vPURPurchaseOrder.TotalQty;
				_vPURPurchaseOrderWCF.UnitPrice = _vPURPurchaseOrder.UnitPrice;
				_vPURPurchaseOrderWCF.BatchNumber = _vPURPurchaseOrder.BatchNumber;
				_vPURPurchaseOrderWCF.ExpiryDate = _vPURPurchaseOrder.ExpiryDate;
				_vPURPurchaseOrderWCF.TaxValue = _vPURPurchaseOrder.TaxValue;
				_vPURPurchaseOrderWCF.PurcaseHeaderID = _vPURPurchaseOrder.PurcaseHeaderID;
				_vPURPurchaseOrderWCF.PurchaseDate = _vPURPurchaseOrder.PurchaseDate;
				_vPURPurchaseOrderWCF.InvoiceNumber = _vPURPurchaseOrder.InvoiceNumber;
				_vPURPurchaseOrderWCF.InvoiceDate = _vPURPurchaseOrder.InvoiceDate;
				_vPURPurchaseOrderWCF.PaymentTypeID = _vPURPurchaseOrder.PaymentTypeID;
				_vPURPurchaseOrderWCF.TotalDiscountRatio = _vPURPurchaseOrder.TotalDiscountRatio;
				_vPURPurchaseOrderWCF.TaxTypeName = _vPURPurchaseOrder.TaxTypeName;
				_vPURPurchaseOrderWCF.IsClosed = _vPURPurchaseOrder.IsClosed;
				_vPURPurchaseOrderWCF.IsVoid = _vPURPurchaseOrder.IsVoid;
				_vPURPurchaseOrderWCF.ChequeNumber = _vPURPurchaseOrder.ChequeNumber;
				_vPURPurchaseOrderWCF.ProductName = _vPURPurchaseOrder.ProductName;
				_vPURPurchaseOrderWCF.ProductCode = _vPURPurchaseOrder.ProductCode;
				_vPURPurchaseOrderWCF.IsAcceptBatch = _vPURPurchaseOrder.IsAcceptBatch;
				_vPURPurchaseOrderWCF.UserFullName = _vPURPurchaseOrder.UserFullName;
				_vPURPurchaseOrderWCF.ProductID = _vPURPurchaseOrder.ProductID;
				
				vPURPurchaseOrderCollection.Add(_vPURPurchaseOrderWCF);
			}
			return vPURPurchaseOrderCollection;
		}
		
		/// <summary>
		/// This method will insert one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="vPURPurchaseOrder" type="VPURPurchaseOrder">This VPURPurchaseOrder  will be inserted in the database.</param>
		///
		/// <returns>True if succeeded</returns>
        //public bool Insert(VPURPurchaseOrder vPURPurchaseOrder)
        //{
        //    _vPURPurchaseOrder = new POS.DataLayer.VPURPurchaseOrder();
        //    _vPURPurchaseOrder.SupplierID=vPURPurchaseOrder.SupplierID;
        //    _vPURPurchaseOrder.SupplierName=vPURPurchaseOrder.SupplierName;
        //    _vPURPurchaseOrder.Qty=vPURPurchaseOrder.Qty;
        //    _vPURPurchaseOrder.PurchaseLineID=vPURPurchaseOrder.PurchaseLineID;
        //    _vPURPurchaseOrder.TotalQty=vPURPurchaseOrder.TotalQty;
        //    _vPURPurchaseOrder.UnitPrice=vPURPurchaseOrder.UnitPrice;
        //    _vPURPurchaseOrder.BatchNumber=vPURPurchaseOrder.BatchNumber;
        //    _vPURPurchaseOrder.ExpiryDate=vPURPurchaseOrder.ExpiryDate;
        //    _vPURPurchaseOrder.TaxValue=vPURPurchaseOrder.TaxValue;
        //    _vPURPurchaseOrder.PurcaseHeaderID=vPURPurchaseOrder.PurcaseHeaderID;
        //    _vPURPurchaseOrder.PurchaseDate=vPURPurchaseOrder.PurchaseDate;
        //    _vPURPurchaseOrder.InvoiceNumber=vPURPurchaseOrder.InvoiceNumber;
        //    _vPURPurchaseOrder.InvoiceDate=vPURPurchaseOrder.InvoiceDate;
        //    _vPURPurchaseOrder.PaymentTypeID=vPURPurchaseOrder.PaymentTypeID;
        //    _vPURPurchaseOrder.TotalDiscountRatio=vPURPurchaseOrder.TotalDiscountRatio;
        //    _vPURPurchaseOrder.TaxTypeName=vPURPurchaseOrder.TaxTypeName;
        //    _vPURPurchaseOrder.IsClosed=vPURPurchaseOrder.IsClosed;
        //    _vPURPurchaseOrder.IsVoid=vPURPurchaseOrder.IsVoid;
        //    _vPURPurchaseOrder.ChequeNumber=vPURPurchaseOrder.ChequeNumber;
        //    _vPURPurchaseOrder.ProductName=vPURPurchaseOrder.ProductName;
        //    _vPURPurchaseOrder.ProductCode=vPURPurchaseOrder.ProductCode;
        //    _vPURPurchaseOrder.IsAcceptBatch=vPURPurchaseOrder.IsAcceptBatch;
        //    _vPURPurchaseOrder.UserFullName=vPURPurchaseOrder.UserFullName;
        //    _vPURPurchaseOrder.ProductID=vPURPurchaseOrder.ProductID;
			
        //    return _vPURPurchaseOrder.Insert();
        //}
		
		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>list of objects of class VPURPurchaseOrder in the form of an object of class VPURPurchaseOrderCollection </returns>
		public VPURPurchaseOrderCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			VPURPurchaseOrderCollection vPURPurchaseOrderCollection = new VPURPurchaseOrderCollection();
			foreach (POS.DataLayer.VPURPurchaseOrder _vPURPurchaseOrder in POS.DataLayer.VPURPurchaseOrderBase.SelectAllPaged(pageSize, skipPages, orderByStatement))
			{
				_vPURPurchaseOrderWCF = new VPURPurchaseOrder();
				
				_vPURPurchaseOrderWCF.SupplierID = _vPURPurchaseOrder.SupplierID;
				_vPURPurchaseOrderWCF.SupplierName = _vPURPurchaseOrder.SupplierName;
				_vPURPurchaseOrderWCF.Qty = _vPURPurchaseOrder.Qty;
				_vPURPurchaseOrderWCF.PurchaseLineID = _vPURPurchaseOrder.PurchaseLineID;
				_vPURPurchaseOrderWCF.TotalQty = _vPURPurchaseOrder.TotalQty;
				_vPURPurchaseOrderWCF.UnitPrice = _vPURPurchaseOrder.UnitPrice;
				_vPURPurchaseOrderWCF.BatchNumber = _vPURPurchaseOrder.BatchNumber;
				_vPURPurchaseOrderWCF.ExpiryDate = _vPURPurchaseOrder.ExpiryDate;
				_vPURPurchaseOrderWCF.TaxValue = _vPURPurchaseOrder.TaxValue;
				_vPURPurchaseOrderWCF.PurcaseHeaderID = _vPURPurchaseOrder.PurcaseHeaderID;
				_vPURPurchaseOrderWCF.PurchaseDate = _vPURPurchaseOrder.PurchaseDate;
				_vPURPurchaseOrderWCF.InvoiceNumber = _vPURPurchaseOrder.InvoiceNumber;
				_vPURPurchaseOrderWCF.InvoiceDate = _vPURPurchaseOrder.InvoiceDate;
				_vPURPurchaseOrderWCF.PaymentTypeID = _vPURPurchaseOrder.PaymentTypeID;
				_vPURPurchaseOrderWCF.TotalDiscountRatio = _vPURPurchaseOrder.TotalDiscountRatio;
				_vPURPurchaseOrderWCF.TaxTypeName = _vPURPurchaseOrder.TaxTypeName;
				_vPURPurchaseOrderWCF.IsClosed = _vPURPurchaseOrder.IsClosed;
				_vPURPurchaseOrderWCF.IsVoid = _vPURPurchaseOrder.IsVoid;
				_vPURPurchaseOrderWCF.ChequeNumber = _vPURPurchaseOrder.ChequeNumber;
				_vPURPurchaseOrderWCF.ProductName = _vPURPurchaseOrder.ProductName;
				_vPURPurchaseOrderWCF.ProductCode = _vPURPurchaseOrder.ProductCode;
				_vPURPurchaseOrderWCF.IsAcceptBatch = _vPURPurchaseOrder.IsAcceptBatch;
				_vPURPurchaseOrderWCF.UserFullName = _vPURPurchaseOrder.UserFullName;
				_vPURPurchaseOrderWCF.ProductID = _vPURPurchaseOrder.ProductID;
				
				vPURPurchaseOrderCollection.Add(_vPURPurchaseOrderWCF);
			}
			return vPURPurchaseOrderCollection;
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class VPURPurchaseOrder</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class VPURPurchaseOrder in the form of an object of class VPURPurchaseOrderCollection</returns>
		public VPURPurchaseOrderCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
		{
			VPURPurchaseOrderCollection vPURPurchaseOrderCollection = new VPURPurchaseOrderCollection();
			foreach (POS.DataLayer.VPURPurchaseOrder _vPURPurchaseOrder in POS.DataLayer.VPURPurchaseOrderBase.SelectByFieldPaged(field, fieldValue, fieldValue2, typeOperation, pageSize, skipPages, orderByStatement))
			{
				_vPURPurchaseOrderWCF = new VPURPurchaseOrder();
				
				_vPURPurchaseOrderWCF.SupplierID = _vPURPurchaseOrder.SupplierID;
				_vPURPurchaseOrderWCF.SupplierName = _vPURPurchaseOrder.SupplierName;
				_vPURPurchaseOrderWCF.Qty = _vPURPurchaseOrder.Qty;
				_vPURPurchaseOrderWCF.PurchaseLineID = _vPURPurchaseOrder.PurchaseLineID;
				_vPURPurchaseOrderWCF.TotalQty = _vPURPurchaseOrder.TotalQty;
				_vPURPurchaseOrderWCF.UnitPrice = _vPURPurchaseOrder.UnitPrice;
				_vPURPurchaseOrderWCF.BatchNumber = _vPURPurchaseOrder.BatchNumber;
				_vPURPurchaseOrderWCF.ExpiryDate = _vPURPurchaseOrder.ExpiryDate;
				_vPURPurchaseOrderWCF.TaxValue = _vPURPurchaseOrder.TaxValue;
				_vPURPurchaseOrderWCF.PurcaseHeaderID = _vPURPurchaseOrder.PurcaseHeaderID;
				_vPURPurchaseOrderWCF.PurchaseDate = _vPURPurchaseOrder.PurchaseDate;
				_vPURPurchaseOrderWCF.InvoiceNumber = _vPURPurchaseOrder.InvoiceNumber;
				_vPURPurchaseOrderWCF.InvoiceDate = _vPURPurchaseOrder.InvoiceDate;
				_vPURPurchaseOrderWCF.PaymentTypeID = _vPURPurchaseOrder.PaymentTypeID;
				_vPURPurchaseOrderWCF.TotalDiscountRatio = _vPURPurchaseOrder.TotalDiscountRatio;
				_vPURPurchaseOrderWCF.TaxTypeName = _vPURPurchaseOrder.TaxTypeName;
				_vPURPurchaseOrderWCF.IsClosed = _vPURPurchaseOrder.IsClosed;
				_vPURPurchaseOrderWCF.IsVoid = _vPURPurchaseOrder.IsVoid;
				_vPURPurchaseOrderWCF.ChequeNumber = _vPURPurchaseOrder.ChequeNumber;
				_vPURPurchaseOrderWCF.ProductName = _vPURPurchaseOrder.ProductName;
				_vPURPurchaseOrderWCF.ProductCode = _vPURPurchaseOrder.ProductCode;
				_vPURPurchaseOrderWCF.IsAcceptBatch = _vPURPurchaseOrder.IsAcceptBatch;
				_vPURPurchaseOrderWCF.UserFullName = _vPURPurchaseOrder.UserFullName;
				_vPURPurchaseOrderWCF.ProductID = _vPURPurchaseOrder.ProductID;
				
				vPURPurchaseOrderCollection.Add(_vPURPurchaseOrderWCF);
			}
			return vPURPurchaseOrderCollection;
		}
			///<summary>
		/// This method will update one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="vPURPurchaseOrder" type="VPURPurchaseOrder">This VPURPurchaseOrder  will be updated in the database.</param>
		///
		/// <returns>True if succeeded</returns>
        //public bool Update(VPURPurchaseOrder vPURPurchaseOrder)
        //{
        //    _vPURPurchaseOrder=POS.DataLayer.VPURPurchaseOrder.SelectOne(new POS.DataLayer.VPURPurchaseOrderPrimaryKey(vPURPurchaseOrder.SupplierID, vPURPurchaseOrder.PurchaseLineID, vPURPurchaseOrder.PurcaseHeaderID, vPURPurchaseOrder.ProductID));
			
        //    _vPURPurchaseOrder.SupplierName=vPURPurchaseOrder.SupplierName;
        //    _vPURPurchaseOrder.Qty=vPURPurchaseOrder.Qty;
        //    _vPURPurchaseOrder.TotalQty=vPURPurchaseOrder.TotalQty;
        //    _vPURPurchaseOrder.UnitPrice=vPURPurchaseOrder.UnitPrice;
        //    _vPURPurchaseOrder.BatchNumber=vPURPurchaseOrder.BatchNumber;
        //    _vPURPurchaseOrder.ExpiryDate=vPURPurchaseOrder.ExpiryDate;
        //    _vPURPurchaseOrder.TaxValue=vPURPurchaseOrder.TaxValue;
        //    _vPURPurchaseOrder.PurchaseDate=vPURPurchaseOrder.PurchaseDate;
        //    _vPURPurchaseOrder.InvoiceNumber=vPURPurchaseOrder.InvoiceNumber;
        //    _vPURPurchaseOrder.InvoiceDate=vPURPurchaseOrder.InvoiceDate;
        //    _vPURPurchaseOrder.PaymentTypeID=vPURPurchaseOrder.PaymentTypeID;
        //    _vPURPurchaseOrder.TotalDiscountRatio=vPURPurchaseOrder.TotalDiscountRatio;
        //    _vPURPurchaseOrder.TaxTypeName=vPURPurchaseOrder.TaxTypeName;
        //    _vPURPurchaseOrder.IsClosed=vPURPurchaseOrder.IsClosed;
        //    _vPURPurchaseOrder.IsVoid=vPURPurchaseOrder.IsVoid;
        //    _vPURPurchaseOrder.ChequeNumber=vPURPurchaseOrder.ChequeNumber;
        //    _vPURPurchaseOrder.ProductName=vPURPurchaseOrder.ProductName;
        //    _vPURPurchaseOrder.ProductCode=vPURPurchaseOrder.ProductCode;
        //    _vPURPurchaseOrder.IsAcceptBatch=vPURPurchaseOrder.IsAcceptBatch;
        //    _vPURPurchaseOrder.UserFullName=vPURPurchaseOrder.UserFullName;
			
        //    return _vPURPurchaseOrder.Update();
        //}
	} 
}
