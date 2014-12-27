//
// Class	:	AGGroupRoleServices.svc.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:56:01 PM
//

using POS.DataLayer;

namespace POS.BusinessLayer
{
	///<summary>
	///WCF service for the AGGroupRole
	///</summary>
	public class AGGroupRoleService 
	{
		private AGGroupRole _aGGroupRoleWCF;
		private POS.DataLayer.AGGroupRole _aGGroupRole;
		
		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="AGGroupRoleFields">Field of the class AGGroupRole</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <returns>True if succeeded</returns>
		public bool DeleteByField(string field, object fieldValue)
		{
			return POS.DataLayer.AGGroupRoleBase.DeleteByField(field, fieldValue);
		}

		///<summary>
		///This method will Delete the object from the database
		///</summary>
		///<param name="pk" type="AGGroupRolePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <returns>True if succeeded</returns>
		public bool Delete(AGGroupRolePrimaryKey pk)
		{
			return POS.DataLayer.AGGroupRoleBase.Delete(new POS.DataLayer.AGGroupRolePrimaryKey(pk.GroupRoleID));
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="AGGroupRolePrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class AGGroupRole</returns>
		public AGGroupRole SelectOne(AGGroupRolePrimaryKey pk)
		{
			_aGGroupRoleWCF = new AGGroupRole();
			_aGGroupRole = POS.DataLayer.AGGroupRoleBase.SelectOne(new POS.DataLayer.AGGroupRolePrimaryKey(pk.GroupRoleID));
			
				_aGGroupRoleWCF.GroupRoleID = _aGGroupRole.GroupRoleID;
				_aGGroupRoleWCF.GroupID = _aGGroupRole.GroupID;
				_aGGroupRoleWCF.RoleID = _aGGroupRole.RoleID;
				
			return _aGGroupRoleWCF;
		}

		/// <summary>
		/// This method will return a list of objects representing all records in the table.
		/// </summary>
		///
		/// <returns>list of objects of class AGGroupRole in the form of object of AGGroupRoleCollection </returns>
		public AGGroupRoleCollection SelectAll()
		{
			AGGroupRoleCollection aGGroupRoleCollection = new AGGroupRoleCollection();
			foreach (POS.DataLayer.AGGroupRole _aGGroupRole in POS.DataLayer.AGGroupRoleBase.SelectAll())
			{
				_aGGroupRoleWCF = new AGGroupRole();
				
				_aGGroupRoleWCF.GroupRoleID = _aGGroupRole.GroupRoleID;
				_aGGroupRoleWCF.GroupID = _aGGroupRole.GroupID;
				_aGGroupRoleWCF.RoleID = _aGGroupRole.RoleID;
				
				aGGroupRoleCollection.Add(_aGGroupRoleWCF);
			}
			return aGGroupRoleCollection;
		}
    
    /// <summary>
		/// This method will return a count all records in the table.
		/// </summary>
		///
		/// <returns>count records</returns>
		public int SelectAllCount()
		{
			return POS.DataLayer.AGGroupRoleBase.SelectAllCount();			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class AGGroupRole</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class AGGroupRole in the form of an object of class AGGroupRoleCollection</returns>
		public AGGroupRoleCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
		{
			AGGroupRoleCollection aGGroupRoleCollection = new AGGroupRoleCollection();
			foreach (POS.DataLayer.AGGroupRole _aGGroupRole in POS.DataLayer.AGGroupRoleBase.SelectByField(field, fieldValue, fieldValue2, typeOperation))
			{
				_aGGroupRoleWCF = new AGGroupRole();
				
				_aGGroupRoleWCF.GroupRoleID = _aGGroupRole.GroupRoleID;
				_aGGroupRoleWCF.GroupID = _aGGroupRole.GroupID;
				_aGGroupRoleWCF.RoleID = _aGGroupRole.RoleID;
				
				aGGroupRoleCollection.Add(_aGGroupRoleWCF);
			}
			return aGGroupRoleCollection;
		}
		
		/// <summary>
		/// This method will insert one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="aGGroupRole" type="AGGroupRole">This AGGroupRole  will be inserted in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Insert(AGGroupRole aGGroupRole)
		{
			_aGGroupRole = new POS.DataLayer.AGGroupRole();
			_aGGroupRole.GroupRoleID=aGGroupRole.GroupRoleID;
			_aGGroupRole.GroupID=aGGroupRole.GroupID;
			_aGGroupRole.RoleID=aGGroupRole.RoleID;
			
			return _aGGroupRole.Insert();
		}
		
		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>list of objects of class AGGroupRole in the form of an object of class AGGroupRoleCollection </returns>
		public AGGroupRoleCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			AGGroupRoleCollection aGGroupRoleCollection = new AGGroupRoleCollection();
			foreach (POS.DataLayer.AGGroupRole _aGGroupRole in POS.DataLayer.AGGroupRoleBase.SelectAllPaged(pageSize, skipPages, orderByStatement))
			{
				_aGGroupRoleWCF = new AGGroupRole();
				
				_aGGroupRoleWCF.GroupRoleID = _aGGroupRole.GroupRoleID;
				_aGGroupRoleWCF.GroupID = _aGGroupRole.GroupID;
				_aGGroupRoleWCF.RoleID = _aGGroupRole.RoleID;
				
				aGGroupRoleCollection.Add(_aGGroupRoleWCF);
			}
			return aGGroupRoleCollection;
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class AGGroupRole</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class AGGroupRole in the form of an object of class AGGroupRoleCollection</returns>
		public AGGroupRoleCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
		{
			AGGroupRoleCollection aGGroupRoleCollection = new AGGroupRoleCollection();
			foreach (POS.DataLayer.AGGroupRole _aGGroupRole in POS.DataLayer.AGGroupRoleBase.SelectByFieldPaged(field, fieldValue, fieldValue2, typeOperation, pageSize, skipPages, orderByStatement))
			{
				_aGGroupRoleWCF = new AGGroupRole();
				
				_aGGroupRoleWCF.GroupRoleID = _aGGroupRole.GroupRoleID;
				_aGGroupRoleWCF.GroupID = _aGGroupRole.GroupID;
				_aGGroupRoleWCF.RoleID = _aGGroupRole.RoleID;
				
				aGGroupRoleCollection.Add(_aGGroupRoleWCF);
			}
			return aGGroupRoleCollection;
		}
			///<summary>
		/// This method will update one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="aGGroupRole" type="AGGroupRole">This AGGroupRole  will be updated in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Update(AGGroupRole aGGroupRole)
		{
			_aGGroupRole=POS.DataLayer.AGGroupRole.SelectOne(new POS.DataLayer.AGGroupRolePrimaryKey(aGGroupRole.GroupRoleID));
			
			_aGGroupRole.GroupID=aGGroupRole.GroupID;
			_aGGroupRole.RoleID=aGGroupRole.RoleID;
			
			return _aGGroupRole.Update();
		}
	} 
}
