//
// Class	:	ADGroupRoleServices.svc.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	3/7/2015 2:37:00 PM
//


using POS.DataLayer;

namespace POS.BusinessLayer
{
	///<summary>
	///WCF service for the ADGroupRole
	///</summary>
	public class ADGroupRoleService 
	{
		private ADGroupRole _aDGroupRoleWCF;
		private POS.DataLayer.ADGroupRole _aDGroupRole;
		
		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="ADGroupRoleFields">Field of the class ADGroupRole</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <returns>True if succeeded</returns>
		public bool DeleteByField(string field, object fieldValue)
		{
			return POS.DataLayer.ADGroupRoleBase.DeleteByField(field, fieldValue);
		}

		///<summary>
		///This method will Delete the object from the database
		///</summary>
		///<param name="pk" type="ADGroupRolePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <returns>True if succeeded</returns>
		public bool Delete(ADGroupRolePrimaryKey pk)
		{
			return POS.DataLayer.ADGroupRoleBase.Delete(new POS.DataLayer.ADGroupRolePrimaryKey(pk.GroupRoleID));
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="ADGroupRolePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class ADGroupRole</returns>
		public ADGroupRole SelectOne(ADGroupRolePrimaryKey pk)
		{
			_aDGroupRoleWCF = new ADGroupRole();
			_aDGroupRole = POS.DataLayer.ADGroupRoleBase.SelectOne(new POS.DataLayer.ADGroupRolePrimaryKey(pk.GroupRoleID));
			
				_aDGroupRoleWCF.GroupRoleID = _aDGroupRole.GroupRoleID;
				_aDGroupRoleWCF.GroupID = _aDGroupRole.GroupID;
				_aDGroupRoleWCF.RoleID = _aDGroupRole.RoleID;
				
			return _aDGroupRoleWCF;
		}

		/// <summary>
		/// This method will return a list of objects representing all records in the table.
		/// </summary>
		///
		/// <returns>list of objects of class ADGroupRole in the form of object of ADGroupRoleCollection </returns>
		public ADGroupRoleCollection SelectAll()
		{
			ADGroupRoleCollection aDGroupRoleCollection = new ADGroupRoleCollection();
			foreach (POS.DataLayer.ADGroupRole _aDGroupRole in POS.DataLayer.ADGroupRoleBase.SelectAll())
			{
				_aDGroupRoleWCF = new ADGroupRole();
				
				_aDGroupRoleWCF.GroupRoleID = _aDGroupRole.GroupRoleID;
				_aDGroupRoleWCF.GroupID = _aDGroupRole.GroupID;
				_aDGroupRoleWCF.RoleID = _aDGroupRole.RoleID;
				
				aDGroupRoleCollection.Add(_aDGroupRoleWCF);
			}
			return aDGroupRoleCollection;
		}
    
    /// <summary>
		/// This method will return a count all records in the table.
		/// </summary>
		///
		/// <returns>count records</returns>
		public int SelectAllCount()
		{
			return POS.DataLayer.ADGroupRoleBase.SelectAllCount();			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class ADGroupRole</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class ADGroupRole in the form of an object of class ADGroupRoleCollection</returns>
		public ADGroupRoleCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
		{
			ADGroupRoleCollection aDGroupRoleCollection = new ADGroupRoleCollection();
			foreach (POS.DataLayer.ADGroupRole _aDGroupRole in POS.DataLayer.ADGroupRoleBase.SelectByField(field, fieldValue, fieldValue2, typeOperation))
			{
				_aDGroupRoleWCF = new ADGroupRole();
				
				_aDGroupRoleWCF.GroupRoleID = _aDGroupRole.GroupRoleID;
				_aDGroupRoleWCF.GroupID = _aDGroupRole.GroupID;
				_aDGroupRoleWCF.RoleID = _aDGroupRole.RoleID;
				
				aDGroupRoleCollection.Add(_aDGroupRoleWCF);
			}
			return aDGroupRoleCollection;
		}
		
		/// <summary>
		/// This method will insert one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="aDGroupRole" type="ADGroupRole">This ADGroupRole  will be inserted in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Insert(ADGroupRole aDGroupRole)
		{
			_aDGroupRole = new POS.DataLayer.ADGroupRole();
			_aDGroupRole.GroupRoleID=aDGroupRole.GroupRoleID;
			_aDGroupRole.GroupID=aDGroupRole.GroupID;
			_aDGroupRole.RoleID=aDGroupRole.RoleID;
			
			return _aDGroupRole.Insert();
		}
		
		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>list of objects of class ADGroupRole in the form of an object of class ADGroupRoleCollection </returns>
		public ADGroupRoleCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			ADGroupRoleCollection aDGroupRoleCollection = new ADGroupRoleCollection();
			foreach (POS.DataLayer.ADGroupRole _aDGroupRole in POS.DataLayer.ADGroupRoleBase.SelectAllPaged(pageSize, skipPages, orderByStatement))
			{
				_aDGroupRoleWCF = new ADGroupRole();
				
				_aDGroupRoleWCF.GroupRoleID = _aDGroupRole.GroupRoleID;
				_aDGroupRoleWCF.GroupID = _aDGroupRole.GroupID;
				_aDGroupRoleWCF.RoleID = _aDGroupRole.RoleID;
				
				aDGroupRoleCollection.Add(_aDGroupRoleWCF);
			}
			return aDGroupRoleCollection;
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class ADGroupRole</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class ADGroupRole in the form of an object of class ADGroupRoleCollection</returns>
		public ADGroupRoleCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
		{
			ADGroupRoleCollection aDGroupRoleCollection = new ADGroupRoleCollection();
			foreach (POS.DataLayer.ADGroupRole _aDGroupRole in POS.DataLayer.ADGroupRoleBase.SelectByFieldPaged(field, fieldValue, fieldValue2, typeOperation, pageSize, skipPages, orderByStatement))
			{
				_aDGroupRoleWCF = new ADGroupRole();
				
				_aDGroupRoleWCF.GroupRoleID = _aDGroupRole.GroupRoleID;
				_aDGroupRoleWCF.GroupID = _aDGroupRole.GroupID;
				_aDGroupRoleWCF.RoleID = _aDGroupRole.RoleID;
				
				aDGroupRoleCollection.Add(_aDGroupRoleWCF);
			}
			return aDGroupRoleCollection;
		}
			///<summary>
		/// This method will update one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="aDGroupRole" type="ADGroupRole">This ADGroupRole  will be updated in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Update(ADGroupRole aDGroupRole)
		{
			_aDGroupRole=POS.DataLayer.ADGroupRole.SelectOne(new POS.DataLayer.ADGroupRolePrimaryKey(aDGroupRole.GroupRoleID));
			
			_aDGroupRole.GroupID=aDGroupRole.GroupID;
			_aDGroupRole.RoleID=aDGroupRole.RoleID;
			
			return _aDGroupRole.Update();
		}
	} 
}
