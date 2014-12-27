//
// Class	:	PaymentTypeServices.svc.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:55:56 PM
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
	///WCF service for the PaymentType
	///</summary>
	public class PaymentTypeService : IPaymentTypeService
	{
		private PaymentType _paymentTypeWCF;
		private POS.DataLayer.PaymentType _paymentType;
		
		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="PaymentTypeFields">Field of the class PaymentType</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <returns>True if succeeded</returns>
		public bool DeleteByField(string field, object fieldValue)
		{
			return POS.DataLayer.PaymentTypeBase.DeleteByField(field, fieldValue);
		}

		///<summary>
		///This method will Delete the object from the database
		///</summary>
		///<param name="pk" type="PaymentTypePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <returns>True if succeeded</returns>
		public bool Delete(PaymentTypePrimaryKey pk)
		{
			return POS.DataLayer.PaymentTypeBase.Delete(new POS.DataLayer.PaymentTypePrimaryKey(pk.PaymentTypeID));
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="PaymentTypePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class PaymentType</returns>
		public PaymentType SelectOne(PaymentTypePrimaryKey pk)
		{
			_paymentTypeWCF = new PaymentType();
			_paymentType = POS.DataLayer.PaymentTypeBase.SelectOne(new POS.DataLayer.PaymentTypePrimaryKey(pk.PaymentTypeID));
			
				_paymentTypeWCF.PaymentTypeID = _paymentType.PaymentTypeID;
				_paymentTypeWCF.PaymentTypeName = _paymentType.PaymentTypeName;
				
			return _paymentTypeWCF;
		}

		/// <summary>
		/// This method will return a list of objects representing all records in the table.
		/// </summary>
		///
		/// <returns>list of objects of class PaymentType in the form of object of PaymentTypeCollection </returns>
		public PaymentTypeCollection SelectAll()
		{
			PaymentTypeCollection paymentTypeCollection = new PaymentTypeCollection();
			foreach (POS.DataLayer.PaymentType _paymentType in POS.DataLayer.PaymentTypeBase.SelectAll())
			{
				_paymentTypeWCF = new PaymentType();
				
				_paymentTypeWCF.PaymentTypeID = _paymentType.PaymentTypeID;
				_paymentTypeWCF.PaymentTypeName = _paymentType.PaymentTypeName;
				
				paymentTypeCollection.Add(_paymentTypeWCF);
			}
			return paymentTypeCollection;
		}
    
    /// <summary>
		/// This method will return a count all records in the table.
		/// </summary>
		///
		/// <returns>count records</returns>
		public int SelectAllCount()
		{
			return POS.DataLayer.PaymentTypeBase.SelectAllCount();			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class PaymentType</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class PaymentType in the form of an object of class PaymentTypeCollection</returns>
		public PaymentTypeCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
		{
			PaymentTypeCollection paymentTypeCollection = new PaymentTypeCollection();
			foreach (POS.DataLayer.PaymentType _paymentType in POS.DataLayer.PaymentTypeBase.SelectByField(field, fieldValue, fieldValue2, typeOperation))
			{
				_paymentTypeWCF = new PaymentType();
				
				_paymentTypeWCF.PaymentTypeID = _paymentType.PaymentTypeID;
				_paymentTypeWCF.PaymentTypeName = _paymentType.PaymentTypeName;
				
				paymentTypeCollection.Add(_paymentTypeWCF);
			}
			return paymentTypeCollection;
		}
		
		/// <summary>
		/// This method will insert one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="paymentType" type="PaymentType">This PaymentType  will be inserted in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Insert(PaymentType paymentType)
		{
			_paymentType = new POS.DataLayer.PaymentType();
			_paymentType.PaymentTypeID=paymentType.PaymentTypeID;
			_paymentType.PaymentTypeName=paymentType.PaymentTypeName;
			
			return _paymentType.Insert();
		}
		
		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>list of objects of class PaymentType in the form of an object of class PaymentTypeCollection </returns>
		public PaymentTypeCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			PaymentTypeCollection paymentTypeCollection = new PaymentTypeCollection();
			foreach (POS.DataLayer.PaymentType _paymentType in POS.DataLayer.PaymentTypeBase.SelectAllPaged(pageSize, skipPages, orderByStatement))
			{
				_paymentTypeWCF = new PaymentType();
				
				_paymentTypeWCF.PaymentTypeID = _paymentType.PaymentTypeID;
				_paymentTypeWCF.PaymentTypeName = _paymentType.PaymentTypeName;
				
				paymentTypeCollection.Add(_paymentTypeWCF);
			}
			return paymentTypeCollection;
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class PaymentType</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class PaymentType in the form of an object of class PaymentTypeCollection</returns>
		public PaymentTypeCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
		{
			PaymentTypeCollection paymentTypeCollection = new PaymentTypeCollection();
			foreach (POS.DataLayer.PaymentType _paymentType in POS.DataLayer.PaymentTypeBase.SelectByFieldPaged(field, fieldValue, fieldValue2, typeOperation, pageSize, skipPages, orderByStatement))
			{
				_paymentTypeWCF = new PaymentType();
				
				_paymentTypeWCF.PaymentTypeID = _paymentType.PaymentTypeID;
				_paymentTypeWCF.PaymentTypeName = _paymentType.PaymentTypeName;
				
				paymentTypeCollection.Add(_paymentTypeWCF);
			}
			return paymentTypeCollection;
		}
			///<summary>
		/// This method will update one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="paymentType" type="PaymentType">This PaymentType  will be updated in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Update(PaymentType paymentType)
		{
			_paymentType=POS.DataLayer.PaymentType.SelectOne(new POS.DataLayer.PaymentTypePrimaryKey(paymentType.PaymentTypeID));
			
			_paymentType.PaymentTypeName=paymentType.PaymentTypeName;
			
			return _paymentType.Update();
		}
	} 
}
