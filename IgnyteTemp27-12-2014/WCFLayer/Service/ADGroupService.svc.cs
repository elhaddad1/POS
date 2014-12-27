//
// Class	:	ADGroupServices.svc.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:56:03 PM
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
	///WCF service for the ADGroup
	///</summary>
	public class ADGroupService : IADGroupService
	{
		private ADGroup _aDGroupWCF;
		private POS.DataLayer.ADGroup _aDGroup;
		
		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="ADGroupFields">Field of the class ADGroup</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <returns>True if succeeded</returns>
		public bool DeleteByField(string field, object fieldValue)
		{
			return POS.DataLayer.ADGroupBase.DeleteByField(field, fieldValue);
		}

		///<summary>
		///This method will Delete the object from the database
		///</summary>
		///<param name="pk" type="ADGroupPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <returns>True if succeeded</returns>
		public bool Delete(ADGroupPrimaryKey pk)
		{
			return POS.DataLayer.ADGroupBase.Delete(new POS.DataLayer.ADGroupPrimaryKey(pk.GroupID));
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="ADGroupPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class ADGroup</returns>
		public ADGroup SelectOne(ADGroupPrimaryKey pk)
		{
			_aDGroupWCF = new ADGroup();
			_aDGroup = POS.DataLayer.ADGroupBase.SelectOne(new POS.DataLayer.ADGroupPrimaryKey(pk.GroupID));
			
				_aDGroupWCF.GroupID = _aDGroup.GroupID;
				_aDGroupWCF.GroupName = _aDGroup.GroupName;
				
			return _aDGroupWCF;
		}

		/// <summary>
		/// This method will return a list of objects representing all records in the table.
		/// </summary>
		///
		/// <returns>list of objects of class ADGroup in the form of object of ADGroupCollection </returns>
		public ADGroupCollection SelectAll()
		{
			ADGroupCollection aDGroupCollection = new ADGroupCollection();
			foreach (POS.DataLayer.ADGroup _aDGroup in POS.DataLayer.ADGroupBase.SelectAll())
			{
				_aDGroupWCF = new ADGroup();
				
				_aDGroupWCF.GroupID = _aDGroup.GroupID;
				_aDGroupWCF.GroupName = _aDGroup.GroupName;
				
				aDGroupCollection.Add(_aDGroupWCF);
			}
			return aDGroupCollection;
		}
    
    /// <summary>
		/// This method will return a count all records in the table.
		/// </summary>
		///
		/// <returns>count records</returns>
		public int SelectAllCount()
		{
			return POS.DataLayer.ADGroupBase.SelectAllCount();			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class ADGroup</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class ADGroup in the form of an object of class ADGroupCollection</returns>
		public ADGroupCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
		{
			ADGroupCollection aDGroupCollection = new ADGroupCollection();
			foreach (POS.DataLayer.ADGroup _aDGroup in POS.DataLayer.ADGroupBase.SelectByField(field, fieldValue, fieldValue2, typeOperation))
			{
				_aDGroupWCF = new ADGroup();
				
				_aDGroupWCF.GroupID = _aDGroup.GroupID;
				_aDGroupWCF.GroupName = _aDGroup.GroupName;
				
				aDGroupCollection.Add(_aDGroupWCF);
			}
			return aDGroupCollection;
		}
		
		/// <summary>
		/// This method will insert one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="aDGroup" type="ADGroup">This ADGroup  will be inserted in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Insert(ADGroup aDGroup)
		{
			_aDGroup = new POS.DataLayer.ADGroup();
			_aDGroup.GroupID=aDGroup.GroupID;
			_aDGroup.GroupName=aDGroup.GroupName;
			
			return _aDGroup.Insert();
		}
		
		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>list of objects of class ADGroup in the form of an object of class ADGroupCollection </returns>
		public ADGroupCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			ADGroupCollection aDGroupCollection = new ADGroupCollection();
			foreach (POS.DataLayer.ADGroup _aDGroup in POS.DataLayer.ADGroupBase.SelectAllPaged(pageSize, skipPages, orderByStatement))
			{
				_aDGroupWCF = new ADGroup();
				
				_aDGroupWCF.GroupID = _aDGroup.GroupID;
				_aDGroupWCF.GroupName = _aDGroup.GroupName;
				
				aDGroupCollection.Add(_aDGroupWCF);
			}
			return aDGroupCollection;
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class ADGroup</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class ADGroup in the form of an object of class ADGroupCollection</returns>
		public ADGroupCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
		{
			ADGroupCollection aDGroupCollection = new ADGroupCollection();
			foreach (POS.DataLayer.ADGroup _aDGroup in POS.DataLayer.ADGroupBase.SelectByFieldPaged(field, fieldValue, fieldValue2, typeOperation, pageSize, skipPages, orderByStatement))
			{
				_aDGroupWCF = new ADGroup();
				
				_aDGroupWCF.GroupID = _aDGroup.GroupID;
				_aDGroupWCF.GroupName = _aDGroup.GroupName;
				
				aDGroupCollection.Add(_aDGroupWCF);
			}
			return aDGroupCollection;
		}
			///<summary>
		/// This method will update one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="aDGroup" type="ADGroup">This ADGroup  will be updated in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Update(ADGroup aDGroup)
		{
			_aDGroup=POS.DataLayer.ADGroup.SelectOne(new POS.DataLayer.ADGroupPrimaryKey(aDGroup.GroupID));
			
			_aDGroup.GroupName=aDGroup.GroupName;
			
			return _aDGroup.Update();
		}
	} 
}
