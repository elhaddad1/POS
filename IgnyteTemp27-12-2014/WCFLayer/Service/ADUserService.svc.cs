//
// Class	:	ADUserServices.svc.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:56:08 PM
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
	///WCF service for the ADUser
	///</summary>
	public class ADUserService : IADUserService
	{
		private ADUser _aDUserWCF;
		private POS.DataLayer.ADUser _aDUser;
		
		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="ADUserFields">Field of the class ADUser</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <returns>True if succeeded</returns>
		public bool DeleteByField(string field, object fieldValue)
		{
			return POS.DataLayer.ADUserBase.DeleteByField(field, fieldValue);
		}

		///<summary>
		///This method will Delete the object from the database
		///</summary>
		///<param name="pk" type="ADUserPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <returns>True if succeeded</returns>
		public bool Delete(ADUserPrimaryKey pk)
		{
			return POS.DataLayer.ADUserBase.Delete(new POS.DataLayer.ADUserPrimaryKey(pk.UserID));
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="ADUserPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class ADUser</returns>
		public ADUser SelectOne(ADUserPrimaryKey pk)
		{
			_aDUserWCF = new ADUser();
			_aDUser = POS.DataLayer.ADUserBase.SelectOne(new POS.DataLayer.ADUserPrimaryKey(pk.UserID));
			
				_aDUserWCF.UserID = _aDUser.UserID;
				_aDUserWCF.UserFullName = _aDUser.UserFullName;
				_aDUserWCF.UserName = _aDUser.UserName;
				_aDUserWCF.Password = _aDUser.Password;
				_aDUserWCF.GroupID = _aDUser.GroupID;
				_aDUserWCF.Email = _aDUser.Email;
				_aDUserWCF.Address = _aDUser.Address;
				_aDUserWCF.Phone = _aDUser.Phone;
				_aDUserWCF.Mobile = _aDUser.Mobile;
				
			return _aDUserWCF;
		}

		/// <summary>
		/// This method will return a list of objects representing all records in the table.
		/// </summary>
		///
		/// <returns>list of objects of class ADUser in the form of object of ADUserCollection </returns>
		public ADUserCollection SelectAll()
		{
			ADUserCollection aDUserCollection = new ADUserCollection();
			foreach (POS.DataLayer.ADUser _aDUser in POS.DataLayer.ADUserBase.SelectAll())
			{
				_aDUserWCF = new ADUser();
				
				_aDUserWCF.UserID = _aDUser.UserID;
				_aDUserWCF.UserFullName = _aDUser.UserFullName;
				_aDUserWCF.UserName = _aDUser.UserName;
				_aDUserWCF.Password = _aDUser.Password;
				_aDUserWCF.GroupID = _aDUser.GroupID;
				_aDUserWCF.Email = _aDUser.Email;
				_aDUserWCF.Address = _aDUser.Address;
				_aDUserWCF.Phone = _aDUser.Phone;
				_aDUserWCF.Mobile = _aDUser.Mobile;
				
				aDUserCollection.Add(_aDUserWCF);
			}
			return aDUserCollection;
		}
    
    /// <summary>
		/// This method will return a count all records in the table.
		/// </summary>
		///
		/// <returns>count records</returns>
		public int SelectAllCount()
		{
			return POS.DataLayer.ADUserBase.SelectAllCount();			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class ADUser</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class ADUser in the form of an object of class ADUserCollection</returns>
		public ADUserCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
		{
			ADUserCollection aDUserCollection = new ADUserCollection();
			foreach (POS.DataLayer.ADUser _aDUser in POS.DataLayer.ADUserBase.SelectByField(field, fieldValue, fieldValue2, typeOperation))
			{
				_aDUserWCF = new ADUser();
				
				_aDUserWCF.UserID = _aDUser.UserID;
				_aDUserWCF.UserFullName = _aDUser.UserFullName;
				_aDUserWCF.UserName = _aDUser.UserName;
				_aDUserWCF.Password = _aDUser.Password;
				_aDUserWCF.GroupID = _aDUser.GroupID;
				_aDUserWCF.Email = _aDUser.Email;
				_aDUserWCF.Address = _aDUser.Address;
				_aDUserWCF.Phone = _aDUser.Phone;
				_aDUserWCF.Mobile = _aDUser.Mobile;
				
				aDUserCollection.Add(_aDUserWCF);
			}
			return aDUserCollection;
		}
		
		/// <summary>
		/// This method will insert one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="aDUser" type="ADUser">This ADUser  will be inserted in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Insert(ADUser aDUser)
		{
			_aDUser = new POS.DataLayer.ADUser();
			_aDUser.UserID=aDUser.UserID;
			_aDUser.UserFullName=aDUser.UserFullName;
			_aDUser.UserName=aDUser.UserName;
			_aDUser.Password=aDUser.Password;
			_aDUser.GroupID=aDUser.GroupID;
			_aDUser.Email=aDUser.Email;
			_aDUser.Address=aDUser.Address;
			_aDUser.Phone=aDUser.Phone;
			_aDUser.Mobile=aDUser.Mobile;
			
			return _aDUser.Insert();
		}
		/// <summary>
		/// This method will delete row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="ADGroupPrimaryKey">Primary Key information based on which data is to be deleted.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool DeleteAllByForeignKeyGroupID(ADGroupPrimaryKey pk)
		{
			return POS.DataLayer.ADUserBase.DeleteAllByForeignKeyGroupID(new POS.DataLayer.ADGroupPrimaryKey(pk.GroupID));
		}
		
		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="ADGroupPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class ADUserCollection</returns>
		public ADUserCollection SelectAllByForeignKeyGroupID(ADGroupPrimaryKey pk)
		{
			ADUserCollection aDUserCollection=new ADUserCollection();
			foreach (POS.DataLayer.ADUser _aDUser in POS.DataLayer.ADUserBase.SelectAllByForeignKeyGroupID(new POS.DataLayer.ADGroupPrimaryKey(pk.GroupID)))
			{
				_aDUserWCF = new ADUser();
				_aDUserWCF.UserID = _aDUser.UserID;
				_aDUserWCF.UserFullName = _aDUser.UserFullName;
				_aDUserWCF.UserName = _aDUser.UserName;
				_aDUserWCF.Password = _aDUser.Password;
				_aDUserWCF.GroupID = _aDUser.GroupID;
				_aDUserWCF.Email = _aDUser.Email;
				_aDUserWCF.Address = _aDUser.Address;
				_aDUserWCF.Phone = _aDUser.Phone;
				_aDUserWCF.Mobile = _aDUser.Mobile;
				
				aDUserCollection.Add(_aDUserWCF);
			}
			return aDUserCollection;
		}
		
		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified 
		/// along with the details of the child table.
		/// </summary>
		///
		/// <param name="pk" type="ADGroupPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>object of class ADUserCollection</returns>
		public ADUserCollection SelectAllByForeignKeyGroupIDPaged(ADGroupPrimaryKey pk, int pageSize, int skipPages, string orderByStatement)
		{
			ADUserCollection aDUserCollection=new ADUserCollection();
			foreach (POS.DataLayer.ADUser _aDUser in POS.DataLayer.ADUserBase.SelectAllByForeignKeyGroupIDPaged(new POS.DataLayer.ADGroupPrimaryKey(pk.GroupID), pageSize, skipPages, orderByStatement))
			{
				_aDUserWCF = new ADUser();
				_aDUserWCF.UserID = _aDUser.UserID;
				_aDUserWCF.UserFullName = _aDUser.UserFullName;
				_aDUserWCF.UserName = _aDUser.UserName;
				_aDUserWCF.Password = _aDUser.Password;
				_aDUserWCF.GroupID = _aDUser.GroupID;
				_aDUserWCF.Email = _aDUser.Email;
				_aDUserWCF.Address = _aDUser.Address;
				_aDUserWCF.Phone = _aDUser.Phone;
				_aDUserWCF.Mobile = _aDUser.Mobile;
				
				aDUserCollection.Add(_aDUserWCF);
			}
			return aDUserCollection;
		}
			
		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>list of objects of class ADUser in the form of an object of class ADUserCollection </returns>
		public ADUserCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			ADUserCollection aDUserCollection = new ADUserCollection();
			foreach (POS.DataLayer.ADUser _aDUser in POS.DataLayer.ADUserBase.SelectAllPaged(pageSize, skipPages, orderByStatement))
			{
				_aDUserWCF = new ADUser();
				
				_aDUserWCF.UserID = _aDUser.UserID;
				_aDUserWCF.UserFullName = _aDUser.UserFullName;
				_aDUserWCF.UserName = _aDUser.UserName;
				_aDUserWCF.Password = _aDUser.Password;
				_aDUserWCF.GroupID = _aDUser.GroupID;
				_aDUserWCF.Email = _aDUser.Email;
				_aDUserWCF.Address = _aDUser.Address;
				_aDUserWCF.Phone = _aDUser.Phone;
				_aDUserWCF.Mobile = _aDUser.Mobile;
				
				aDUserCollection.Add(_aDUserWCF);
			}
			return aDUserCollection;
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class ADUser</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class ADUser in the form of an object of class ADUserCollection</returns>
		public ADUserCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
		{
			ADUserCollection aDUserCollection = new ADUserCollection();
			foreach (POS.DataLayer.ADUser _aDUser in POS.DataLayer.ADUserBase.SelectByFieldPaged(field, fieldValue, fieldValue2, typeOperation, pageSize, skipPages, orderByStatement))
			{
				_aDUserWCF = new ADUser();
				
				_aDUserWCF.UserID = _aDUser.UserID;
				_aDUserWCF.UserFullName = _aDUser.UserFullName;
				_aDUserWCF.UserName = _aDUser.UserName;
				_aDUserWCF.Password = _aDUser.Password;
				_aDUserWCF.GroupID = _aDUser.GroupID;
				_aDUserWCF.Email = _aDUser.Email;
				_aDUserWCF.Address = _aDUser.Address;
				_aDUserWCF.Phone = _aDUser.Phone;
				_aDUserWCF.Mobile = _aDUser.Mobile;
				
				aDUserCollection.Add(_aDUserWCF);
			}
			return aDUserCollection;
		}
			///<summary>
		/// This method will update one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="aDUser" type="ADUser">This ADUser  will be updated in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Update(ADUser aDUser)
		{
			_aDUser=POS.DataLayer.ADUser.SelectOne(new POS.DataLayer.ADUserPrimaryKey(aDUser.UserID));
			
			_aDUser.UserFullName=aDUser.UserFullName;
			_aDUser.UserName=aDUser.UserName;
			_aDUser.Password=aDUser.Password;
			_aDUser.GroupID=aDUser.GroupID;
			_aDUser.Email=aDUser.Email;
			_aDUser.Address=aDUser.Address;
			_aDUser.Phone=aDUser.Phone;
			_aDUser.Mobile=aDUser.Mobile;
			
			return _aDUser.Update();
		}
	} 
}
