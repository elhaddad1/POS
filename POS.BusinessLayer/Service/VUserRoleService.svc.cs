//
// Class	:	VUserRoleServices.svc.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	1/2/2015 2:16:12 AM
//

using POS.DataLayer;

namespace POS.BusinessLayer
{
	///<summary>
	///WCF service for the VUserRole
	///</summary>
	public class VUserRoleService 
	{
		private VUserRole _vUserRoleWCF;
		private POS.DataLayer.VUserRole _vUserRole;
		
		
		public VUserRole SelectOne(VUserRolePrimaryKey pk)
		{
			_vUserRoleWCF = new VUserRole();
			_vUserRole = POS.DataLayer.VUserRoleBase.SelectOne(new POS.DataLayer.VUserRolePrimaryKey(pk.UserID, pk.GroupID, pk.Expr1));
			
				_vUserRoleWCF.UserID = _vUserRole.UserID;
				_vUserRoleWCF.GroupID = _vUserRole.GroupID;
				_vUserRoleWCF.GroupName = _vUserRole.GroupName;
				_vUserRoleWCF.RoleName = _vUserRole.RoleName;
				_vUserRoleWCF.RolePath = _vUserRole.RolePath;
				_vUserRoleWCF.Expr1 = _vUserRole.Expr1;
				
			return _vUserRoleWCF;
		}

		/// <summary>
		/// This method will return a list of objects representing all records in the table.
		/// </summary>
		///
		/// <returns>list of objects of class VUserRole in the form of object of VUserRoleCollection </returns>
		public VUserRoleCollection SelectAll()
		{
			VUserRoleCollection vUserRoleCollection = new VUserRoleCollection();
			foreach (POS.DataLayer.VUserRole _vUserRole in POS.DataLayer.VUserRoleBase.SelectAll())
			{
				_vUserRoleWCF = new VUserRole();
				
				_vUserRoleWCF.UserID = _vUserRole.UserID;
				_vUserRoleWCF.GroupID = _vUserRole.GroupID;
				_vUserRoleWCF.GroupName = _vUserRole.GroupName;
				_vUserRoleWCF.RoleName = _vUserRole.RoleName;
				_vUserRoleWCF.RolePath = _vUserRole.RolePath;
				_vUserRoleWCF.Expr1 = _vUserRole.Expr1;
				
				vUserRoleCollection.Add(_vUserRoleWCF);
			}
			return vUserRoleCollection;
		}
    
    /// <summary>
		/// This method will return a count all records in the table.
		/// </summary>
		///
		/// <returns>count records</returns>
		public int SelectAllCount()
		{
			return POS.DataLayer.VUserRoleBase.SelectAllCount();			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class VUserRole</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class VUserRole in the form of an object of class VUserRoleCollection</returns>
		public VUserRoleCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
		{
			VUserRoleCollection vUserRoleCollection = new VUserRoleCollection();
			foreach (POS.DataLayer.VUserRole _vUserRole in POS.DataLayer.VUserRoleBase.SelectByField(field, fieldValue, fieldValue2, typeOperation))
			{
				_vUserRoleWCF = new VUserRole();
				
				_vUserRoleWCF.UserID = _vUserRole.UserID;
				_vUserRoleWCF.GroupID = _vUserRole.GroupID;
				_vUserRoleWCF.GroupName = _vUserRole.GroupName;
				_vUserRoleWCF.RoleName = _vUserRole.RoleName;
				_vUserRoleWCF.RolePath = _vUserRole.RolePath;
				_vUserRoleWCF.Expr1 = _vUserRole.Expr1;
				
				vUserRoleCollection.Add(_vUserRoleWCF);
			}
			return vUserRoleCollection;
		}		
		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>list of objects of class VUserRole in the form of an object of class VUserRoleCollection </returns>
		public VUserRoleCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			VUserRoleCollection vUserRoleCollection = new VUserRoleCollection();
			foreach (POS.DataLayer.VUserRole _vUserRole in POS.DataLayer.VUserRoleBase.SelectAllPaged(pageSize, skipPages, orderByStatement))
			{
				_vUserRoleWCF = new VUserRole();
				
				_vUserRoleWCF.UserID = _vUserRole.UserID;
				_vUserRoleWCF.GroupID = _vUserRole.GroupID;
				_vUserRoleWCF.GroupName = _vUserRole.GroupName;
				_vUserRoleWCF.RoleName = _vUserRole.RoleName;
				_vUserRoleWCF.RolePath = _vUserRole.RolePath;
				_vUserRoleWCF.Expr1 = _vUserRole.Expr1;
				
				vUserRoleCollection.Add(_vUserRoleWCF);
			}
			return vUserRoleCollection;
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class VUserRole</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class VUserRole in the form of an object of class VUserRoleCollection</returns>
		public VUserRoleCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
		{
			VUserRoleCollection vUserRoleCollection = new VUserRoleCollection();
			foreach (POS.DataLayer.VUserRole _vUserRole in POS.DataLayer.VUserRoleBase.SelectByFieldPaged(field, fieldValue, fieldValue2, typeOperation, pageSize, skipPages, orderByStatement))
			{
				_vUserRoleWCF = new VUserRole();
				
				_vUserRoleWCF.UserID = _vUserRole.UserID;
				_vUserRoleWCF.GroupID = _vUserRole.GroupID;
				_vUserRoleWCF.GroupName = _vUserRole.GroupName;
				_vUserRoleWCF.RoleName = _vUserRole.RoleName;
				_vUserRoleWCF.RolePath = _vUserRole.RolePath;
				_vUserRoleWCF.Expr1 = _vUserRole.Expr1;
				
				vUserRoleCollection.Add(_vUserRoleWCF);
			}
			return vUserRoleCollection;
		}

	} 
}
