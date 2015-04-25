//
// Class	:	VPurchaseReturnHeaderServices.svc.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	11/4/2015 9:57:48 PM
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
	///WCF service for the VPurchaseReturnHeader
	///</summary>
	public class VPurchaseReturnHeaderService 
	{
		private VPurchaseReturnHeader _vPurchaseReturnHeaderWCF;
		private POS.DataLayer.VPurchaseReturnHeader _vPurchaseReturnHeader;
		
		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="VPurchaseReturnHeaderFields">Field of the class VPurchaseReturnHeader</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <returns>True if succeeded</returns>
        //public bool DeleteByField(string field, object fieldValue)
        //{
        //    return POS.DataLayer.VPurchaseReturnHeaderBase.DeleteByField(field, fieldValue);
        //}

		///<summary>
		///This method will Delete the object from the database
		///</summary>
		///<param name="pk" type="VPurchaseReturnHeaderPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <returns>True if succeeded</returns>
        //public bool Delete(VPurchaseReturnHeaderPrimaryKey pk)
        //{
        //    return POS.DataLayer.VPurchaseReturnHeaderBase.Delete(new POS.DataLayer.VPurchaseReturnHeaderPrimaryKey(pk.PurchaseReturnID, pk.PurcaseHeaderID));
        //}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="VPurchaseReturnHeaderPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class VPurchaseReturnHeader</returns>
		public VPurchaseReturnHeader SelectOne(VPurchaseReturnHeaderPrimaryKey pk)
		{
			_vPurchaseReturnHeaderWCF = new VPurchaseReturnHeader();
			_vPurchaseReturnHeader = POS.DataLayer.VPurchaseReturnHeaderBase.SelectOne(new POS.DataLayer.VPurchaseReturnHeaderPrimaryKey(pk.PurchaseReturnID, pk.PurcaseHeaderID));
			
				_vPurchaseReturnHeaderWCF.PurchaseReturnID = _vPurchaseReturnHeader.PurchaseReturnID;
				_vPurchaseReturnHeaderWCF.ReturnDate = _vPurchaseReturnHeader.ReturnDate;
				_vPurchaseReturnHeaderWCF.IsClosed = _vPurchaseReturnHeader.IsClosed;
				_vPurchaseReturnHeaderWCF.InvoiceNumber = _vPurchaseReturnHeader.InvoiceNumber;
				_vPurchaseReturnHeaderWCF.SupplierName = _vPurchaseReturnHeader.SupplierName;
				_vPurchaseReturnHeaderWCF.PurcaseHeaderID = _vPurchaseReturnHeader.PurcaseHeaderID;
				
			return _vPurchaseReturnHeaderWCF;
		}

		/// <summary>
		/// This method will return a list of objects representing all records in the table.
		/// </summary>
		///
		/// <returns>list of objects of class VPurchaseReturnHeader in the form of object of VPurchaseReturnHeaderCollection </returns>
		public VPurchaseReturnHeaderCollection SelectAll()
		{
			VPurchaseReturnHeaderCollection vPurchaseReturnHeaderCollection = new VPurchaseReturnHeaderCollection();
			foreach (POS.DataLayer.VPurchaseReturnHeader _vPurchaseReturnHeader in POS.DataLayer.VPurchaseReturnHeaderBase.SelectAll())
			{
				_vPurchaseReturnHeaderWCF = new VPurchaseReturnHeader();
				
				_vPurchaseReturnHeaderWCF.PurchaseReturnID = _vPurchaseReturnHeader.PurchaseReturnID;
				_vPurchaseReturnHeaderWCF.ReturnDate = _vPurchaseReturnHeader.ReturnDate;
				_vPurchaseReturnHeaderWCF.IsClosed = _vPurchaseReturnHeader.IsClosed;
				_vPurchaseReturnHeaderWCF.InvoiceNumber = _vPurchaseReturnHeader.InvoiceNumber;
				_vPurchaseReturnHeaderWCF.SupplierName = _vPurchaseReturnHeader.SupplierName;
				_vPurchaseReturnHeaderWCF.PurcaseHeaderID = _vPurchaseReturnHeader.PurcaseHeaderID;
				
				vPurchaseReturnHeaderCollection.Add(_vPurchaseReturnHeaderWCF);
			}
			return vPurchaseReturnHeaderCollection;
		}
    
    /// <summary>
		/// This method will return a count all records in the table.
		/// </summary>
		///
		/// <returns>count records</returns>
		public int SelectAllCount()
		{
			return POS.DataLayer.VPurchaseReturnHeaderBase.SelectAllCount();			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class VPurchaseReturnHeader</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class VPurchaseReturnHeader in the form of an object of class VPurchaseReturnHeaderCollection</returns>
		public VPurchaseReturnHeaderCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
		{
			VPurchaseReturnHeaderCollection vPurchaseReturnHeaderCollection = new VPurchaseReturnHeaderCollection();
			foreach (POS.DataLayer.VPurchaseReturnHeader _vPurchaseReturnHeader in POS.DataLayer.VPurchaseReturnHeaderBase.SelectByField(field, fieldValue, fieldValue2, typeOperation))
			{
				_vPurchaseReturnHeaderWCF = new VPurchaseReturnHeader();
				
				_vPurchaseReturnHeaderWCF.PurchaseReturnID = _vPurchaseReturnHeader.PurchaseReturnID;
				_vPurchaseReturnHeaderWCF.ReturnDate = _vPurchaseReturnHeader.ReturnDate;
				_vPurchaseReturnHeaderWCF.IsClosed = _vPurchaseReturnHeader.IsClosed;
				_vPurchaseReturnHeaderWCF.InvoiceNumber = _vPurchaseReturnHeader.InvoiceNumber;
				_vPurchaseReturnHeaderWCF.SupplierName = _vPurchaseReturnHeader.SupplierName;
				_vPurchaseReturnHeaderWCF.PurcaseHeaderID = _vPurchaseReturnHeader.PurcaseHeaderID;
				
				vPurchaseReturnHeaderCollection.Add(_vPurchaseReturnHeaderWCF);
			}
			return vPurchaseReturnHeaderCollection;
		}
		
		/// <summary>
		/// This method will insert one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="vPurchaseReturnHeader" type="VPurchaseReturnHeader">This VPurchaseReturnHeader  will be inserted in the database.</param>
		///
		/// <returns>True if succeeded</returns>
        //public bool Insert(VPurchaseReturnHeader vPurchaseReturnHeader)
        //{
        //    _vPurchaseReturnHeader = new POS.DataLayer.VPurchaseReturnHeader();
        //    _vPurchaseReturnHeader.PurchaseReturnID=vPurchaseReturnHeader.PurchaseReturnID;
        //    _vPurchaseReturnHeader.ReturnDate=vPurchaseReturnHeader.ReturnDate;
        //    _vPurchaseReturnHeader.IsClosed=vPurchaseReturnHeader.IsClosed;
        //    _vPurchaseReturnHeader.InvoiceNumber=vPurchaseReturnHeader.InvoiceNumber;
        //    _vPurchaseReturnHeader.SupplierName=vPurchaseReturnHeader.SupplierName;
        //    _vPurchaseReturnHeader.PurcaseHeaderID=vPurchaseReturnHeader.PurcaseHeaderID;
			
        //    return _vPurchaseReturnHeader.Insert();
        //}
		
		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>list of objects of class VPurchaseReturnHeader in the form of an object of class VPurchaseReturnHeaderCollection </returns>
		public VPurchaseReturnHeaderCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			VPurchaseReturnHeaderCollection vPurchaseReturnHeaderCollection = new VPurchaseReturnHeaderCollection();
			foreach (POS.DataLayer.VPurchaseReturnHeader _vPurchaseReturnHeader in POS.DataLayer.VPurchaseReturnHeaderBase.SelectAllPaged(pageSize, skipPages, orderByStatement))
			{
				_vPurchaseReturnHeaderWCF = new VPurchaseReturnHeader();
				
				_vPurchaseReturnHeaderWCF.PurchaseReturnID = _vPurchaseReturnHeader.PurchaseReturnID;
				_vPurchaseReturnHeaderWCF.ReturnDate = _vPurchaseReturnHeader.ReturnDate;
				_vPurchaseReturnHeaderWCF.IsClosed = _vPurchaseReturnHeader.IsClosed;
				_vPurchaseReturnHeaderWCF.InvoiceNumber = _vPurchaseReturnHeader.InvoiceNumber;
				_vPurchaseReturnHeaderWCF.SupplierName = _vPurchaseReturnHeader.SupplierName;
				_vPurchaseReturnHeaderWCF.PurcaseHeaderID = _vPurchaseReturnHeader.PurcaseHeaderID;
				
				vPurchaseReturnHeaderCollection.Add(_vPurchaseReturnHeaderWCF);
			}
			return vPurchaseReturnHeaderCollection;
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class VPurchaseReturnHeader</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class VPurchaseReturnHeader in the form of an object of class VPurchaseReturnHeaderCollection</returns>
		public VPurchaseReturnHeaderCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
		{
			VPurchaseReturnHeaderCollection vPurchaseReturnHeaderCollection = new VPurchaseReturnHeaderCollection();
			foreach (POS.DataLayer.VPurchaseReturnHeader _vPurchaseReturnHeader in POS.DataLayer.VPurchaseReturnHeaderBase.SelectByFieldPaged(field, fieldValue, fieldValue2, typeOperation, pageSize, skipPages, orderByStatement))
			{
				_vPurchaseReturnHeaderWCF = new VPurchaseReturnHeader();
				
				_vPurchaseReturnHeaderWCF.PurchaseReturnID = _vPurchaseReturnHeader.PurchaseReturnID;
				_vPurchaseReturnHeaderWCF.ReturnDate = _vPurchaseReturnHeader.ReturnDate;
				_vPurchaseReturnHeaderWCF.IsClosed = _vPurchaseReturnHeader.IsClosed;
				_vPurchaseReturnHeaderWCF.InvoiceNumber = _vPurchaseReturnHeader.InvoiceNumber;
				_vPurchaseReturnHeaderWCF.SupplierName = _vPurchaseReturnHeader.SupplierName;
				_vPurchaseReturnHeaderWCF.PurcaseHeaderID = _vPurchaseReturnHeader.PurcaseHeaderID;
				
				vPurchaseReturnHeaderCollection.Add(_vPurchaseReturnHeaderWCF);
			}
			return vPurchaseReturnHeaderCollection;
		}
			///<summary>
		/// This method will update one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="vPurchaseReturnHeader" type="VPurchaseReturnHeader">This VPurchaseReturnHeader  will be updated in the database.</param>
		///
		/// <returns>True if succeeded</returns>
        //public bool Update(VPurchaseReturnHeader vPurchaseReturnHeader)
        //{
        //    _vPurchaseReturnHeader=POS.DataLayer.VPurchaseReturnHeader.SelectOne(new POS.DataLayer.VPurchaseReturnHeaderPrimaryKey(vPurchaseReturnHeader.PurchaseReturnID, vPurchaseReturnHeader.PurcaseHeaderID));
			
        //    _vPurchaseReturnHeader.ReturnDate=vPurchaseReturnHeader.ReturnDate;
        //    _vPurchaseReturnHeader.IsClosed=vPurchaseReturnHeader.IsClosed;
        //    _vPurchaseReturnHeader.InvoiceNumber=vPurchaseReturnHeader.InvoiceNumber;
        //    _vPurchaseReturnHeader.SupplierName=vPurchaseReturnHeader.SupplierName;
			
        //    return _vPurchaseReturnHeader.Update();
        //}
	} 
}
