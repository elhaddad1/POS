//
// Class	:	ADRoleServices.svc.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	5/2/2015 4:01:02 AM
//

using POS.DataLayer;

namespace POS.BusinessLayer
{
	///<summary>
	///WCF service for the ADRole
	///</summary>
	public class ADRoleService 
	{
		private ADRole _aDRoleWCF;
		private POS.DataLayer.ADRole _aDRole;
		
		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="ADRoleFields">Field of the class ADRole</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <returns>True if succeeded</returns>
		public bool DeleteByField(string field, object fieldValue)
		{
			return POS.DataLayer.ADRoleBase.DeleteByField(field, fieldValue);
		}

		///<summary>
		///This method will Delete the object from the database
		///</summary>
		///<param name="pk" type="ADRolePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <returns>True if succeeded</returns>
		public bool Delete(ADRolePrimaryKey pk)
		{
			return POS.DataLayer.ADRoleBase.Delete(new POS.DataLayer.ADRolePrimaryKey(pk.RoleID));
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="ADRolePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class ADRole</returns>
		public ADRole SelectOne(ADRolePrimaryKey pk)
		{
			_aDRoleWCF = new ADRole();
			_aDRole = POS.DataLayer.ADRoleBase.SelectOne(new POS.DataLayer.ADRolePrimaryKey(pk.RoleID));
			
				_aDRoleWCF.RoleID = _aDRole.RoleID;
				_aDRoleWCF.RoleName = _aDRole.RoleName;
				_aDRoleWCF.RolePath = _aDRole.RolePath;
				_aDRoleWCF.MenuButton = _aDRole.MenuButton;
				
			return _aDRoleWCF;
		}

		/// <summary>
		/// This method will return a list of objects representing all records in the table.
		/// </summary>
		///
		/// <returns>list of objects of class ADRole in the form of object of ADRoleCollection </returns>
		public ADRoleCollection SelectAll()
		{
			ADRoleCollection aDRoleCollection = new ADRoleCollection();
			foreach (POS.DataLayer.ADRole _aDRole in POS.DataLayer.ADRoleBase.SelectAll())
			{
				_aDRoleWCF = new ADRole();
				
				_aDRoleWCF.RoleID = _aDRole.RoleID;
				_aDRoleWCF.RoleName = _aDRole.RoleName;
				_aDRoleWCF.RolePath = _aDRole.RolePath;
				_aDRoleWCF.MenuButton = _aDRole.MenuButton;
				
				aDRoleCollection.Add(_aDRoleWCF);
			}
			return aDRoleCollection;
		}
    
    /// <summary>
		/// This method will return a count all records in the table.
		/// </summary>
		///
		/// <returns>count records</returns>
		public int SelectAllCount()
		{
			return POS.DataLayer.ADRoleBase.SelectAllCount();			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class ADRole</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class ADRole in the form of an object of class ADRoleCollection</returns>
		public ADRoleCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
		{
			ADRoleCollection aDRoleCollection = new ADRoleCollection();
			foreach (POS.DataLayer.ADRole _aDRole in POS.DataLayer.ADRoleBase.SelectByField(field, fieldValue, fieldValue2, typeOperation))
			{
				_aDRoleWCF = new ADRole();
				
				_aDRoleWCF.RoleID = _aDRole.RoleID;
				_aDRoleWCF.RoleName = _aDRole.RoleName;
				_aDRoleWCF.RolePath = _aDRole.RolePath;
				_aDRoleWCF.MenuButton = _aDRole.MenuButton;
				
				aDRoleCollection.Add(_aDRoleWCF);
			}
			return aDRoleCollection;
		}
		
		/// <summary>
		/// This method will insert one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="aDRole" type="ADRole">This ADRole  will be inserted in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Insert(ADRole aDRole)
		{
			_aDRole = new POS.DataLayer.ADRole();
			_aDRole.RoleID=aDRole.RoleID;
			_aDRole.RoleName=aDRole.RoleName;
			_aDRole.RolePath=aDRole.RolePath;
			_aDRole.MenuButton=aDRole.MenuButton;
			
			return _aDRole.Insert();
		}
		
		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>list of objects of class ADRole in the form of an object of class ADRoleCollection </returns>
		public ADRoleCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			ADRoleCollection aDRoleCollection = new ADRoleCollection();
			foreach (POS.DataLayer.ADRole _aDRole in POS.DataLayer.ADRoleBase.SelectAllPaged(pageSize, skipPages, orderByStatement))
			{
				_aDRoleWCF = new ADRole();
				
				_aDRoleWCF.RoleID = _aDRole.RoleID;
				_aDRoleWCF.RoleName = _aDRole.RoleName;
				_aDRoleWCF.RolePath = _aDRole.RolePath;
				_aDRoleWCF.MenuButton = _aDRole.MenuButton;
				
				aDRoleCollection.Add(_aDRoleWCF);
			}
			return aDRoleCollection;
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class ADRole</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class ADRole in the form of an object of class ADRoleCollection</returns>
		public ADRoleCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
		{
			ADRoleCollection aDRoleCollection = new ADRoleCollection();
			foreach (POS.DataLayer.ADRole _aDRole in POS.DataLayer.ADRoleBase.SelectByFieldPaged(field, fieldValue, fieldValue2, typeOperation, pageSize, skipPages, orderByStatement))
			{
				_aDRoleWCF = new ADRole();
				
				_aDRoleWCF.RoleID = _aDRole.RoleID;
				_aDRoleWCF.RoleName = _aDRole.RoleName;
				_aDRoleWCF.RolePath = _aDRole.RolePath;
				_aDRoleWCF.MenuButton = _aDRole.MenuButton;
				
				aDRoleCollection.Add(_aDRoleWCF);
			}
			return aDRoleCollection;
		}
			///<summary>
		/// This method will update one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="aDRole" type="ADRole">This ADRole  will be updated in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Update(ADRole aDRole)
		{
			_aDRole=POS.DataLayer.ADRole.SelectOne(new POS.DataLayer.ADRolePrimaryKey(aDRole.RoleID));
			
			_aDRole.RoleName=aDRole.RoleName;
			_aDRole.RolePath=aDRole.RolePath;
			_aDRole.MenuButton=aDRole.MenuButton;
			
			return _aDRole.Update();
		}
	} 
}
