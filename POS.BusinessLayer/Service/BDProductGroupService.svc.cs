//
// Class	:	BDProductGroupServices.svc.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	3/7/2015 2:37:08 PM
//


using POS.DataLayer;

namespace POS.BusinessLayer
{
	///<summary>
	///WCF service for the BDProductGroup
	///</summary>
	public class BDProductGroupService 
	{
		private BDProductGroup _bDProductGroupWCF;
		private POS.DataLayer.BDProductGroup _bDProductGroup;
		
		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="BDProductGroupFields">Field of the class BDProductGroup</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <returns>True if succeeded</returns>
		public bool DeleteByField(string field, object fieldValue)
		{
			return POS.DataLayer.BDProductGroupBase.DeleteByField(field, fieldValue);
		}

		///<summary>
		///This method will Delete the object from the database
		///</summary>
		///<param name="pk" type="BDProductGroupPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <returns>True if succeeded</returns>
		public bool Delete(BDProductGroupPrimaryKey pk)
		{
			return POS.DataLayer.BDProductGroupBase.Delete(new POS.DataLayer.BDProductGroupPrimaryKey(pk.ProductGroupID));
		}

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="BDProductGroupPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class BDProductGroup</returns>
		public BDProductGroup SelectOne(BDProductGroupPrimaryKey pk)
		{
			_bDProductGroupWCF = new BDProductGroup();
			_bDProductGroup = POS.DataLayer.BDProductGroupBase.SelectOne(new POS.DataLayer.BDProductGroupPrimaryKey(pk.ProductGroupID));
			
				_bDProductGroupWCF.ProductGroupID = _bDProductGroup.ProductGroupID;
				_bDProductGroupWCF.ProductGroupName = _bDProductGroup.ProductGroupName;
				_bDProductGroupWCF.Notes = _bDProductGroup.Notes;
				
			return _bDProductGroupWCF;
		}

		/// <summary>
		/// This method will return a list of objects representing all records in the table.
		/// </summary>
		///
		/// <returns>list of objects of class BDProductGroup in the form of object of BDProductGroupCollection </returns>
		public BDProductGroupCollection SelectAll()
		{
			BDProductGroupCollection bDProductGroupCollection = new BDProductGroupCollection();
			foreach (POS.DataLayer.BDProductGroup _bDProductGroup in POS.DataLayer.BDProductGroupBase.SelectAll())
			{
				_bDProductGroupWCF = new BDProductGroup();
				
				_bDProductGroupWCF.ProductGroupID = _bDProductGroup.ProductGroupID;
				_bDProductGroupWCF.ProductGroupName = _bDProductGroup.ProductGroupName;
				_bDProductGroupWCF.Notes = _bDProductGroup.Notes;
				
				bDProductGroupCollection.Add(_bDProductGroupWCF);
			}
			return bDProductGroupCollection;
		}
    
    /// <summary>
		/// This method will return a count all records in the table.
		/// </summary>
		///
		/// <returns>count records</returns>
		public int SelectAllCount()
		{
			return POS.DataLayer.BDProductGroupBase.SelectAllCount();			
		}

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class BDProductGroup</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class BDProductGroup in the form of an object of class BDProductGroupCollection</returns>
		public BDProductGroupCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
		{
			BDProductGroupCollection bDProductGroupCollection = new BDProductGroupCollection();
			foreach (POS.DataLayer.BDProductGroup _bDProductGroup in POS.DataLayer.BDProductGroupBase.SelectByField(field, fieldValue, fieldValue2, typeOperation))
			{
				_bDProductGroupWCF = new BDProductGroup();
				
				_bDProductGroupWCF.ProductGroupID = _bDProductGroup.ProductGroupID;
				_bDProductGroupWCF.ProductGroupName = _bDProductGroup.ProductGroupName;
				_bDProductGroupWCF.Notes = _bDProductGroup.Notes;
				
				bDProductGroupCollection.Add(_bDProductGroupWCF);
			}
			return bDProductGroupCollection;
		}
		
		/// <summary>
		/// This method will insert one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="bDProductGroup" type="BDProductGroup">This BDProductGroup  will be inserted in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Insert(BDProductGroup bDProductGroup)
		{
			_bDProductGroup = new POS.DataLayer.BDProductGroup();
			_bDProductGroup.ProductGroupID=bDProductGroup.ProductGroupID;
			_bDProductGroup.ProductGroupName=bDProductGroup.ProductGroupName;
			_bDProductGroup.Notes=bDProductGroup.Notes;
			
			return _bDProductGroup.Insert();
		}
		
		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>list of objects of class BDProductGroup in the form of an object of class BDProductGroupCollection </returns>
		public BDProductGroupCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
		{
			BDProductGroupCollection bDProductGroupCollection = new BDProductGroupCollection();
			foreach (POS.DataLayer.BDProductGroup _bDProductGroup in POS.DataLayer.BDProductGroupBase.SelectAllPaged(pageSize, skipPages, orderByStatement))
			{
				_bDProductGroupWCF = new BDProductGroup();
				
				_bDProductGroupWCF.ProductGroupID = _bDProductGroup.ProductGroupID;
				_bDProductGroupWCF.ProductGroupName = _bDProductGroup.ProductGroupName;
				_bDProductGroupWCF.Notes = _bDProductGroup.Notes;
				
				bDProductGroupCollection.Add(_bDProductGroupWCF);
			}
			return bDProductGroupCollection;
		}

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class BDProductGroup</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class BDProductGroup in the form of an object of class BDProductGroupCollection</returns>
		public BDProductGroupCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
		{
			BDProductGroupCollection bDProductGroupCollection = new BDProductGroupCollection();
			foreach (POS.DataLayer.BDProductGroup _bDProductGroup in POS.DataLayer.BDProductGroupBase.SelectByFieldPaged(field, fieldValue, fieldValue2, typeOperation, pageSize, skipPages, orderByStatement))
			{
				_bDProductGroupWCF = new BDProductGroup();
				
				_bDProductGroupWCF.ProductGroupID = _bDProductGroup.ProductGroupID;
				_bDProductGroupWCF.ProductGroupName = _bDProductGroup.ProductGroupName;
				_bDProductGroupWCF.Notes = _bDProductGroup.Notes;
				
				bDProductGroupCollection.Add(_bDProductGroupWCF);
			}
			return bDProductGroupCollection;
		}
			///<summary>
		/// This method will update one new row into the database using the property Information
		/// </summary>
		///
		/// <param name="bDProductGroup" type="BDProductGroup">This BDProductGroup  will be updated in the database.</param>
		///
		/// <returns>True if succeeded</returns>
		public bool Update(BDProductGroup bDProductGroup)
		{
			_bDProductGroup=POS.DataLayer.BDProductGroup.SelectOne(new POS.DataLayer.BDProductGroupPrimaryKey(bDProductGroup.ProductGroupID));
			
			_bDProductGroup.ProductGroupName=bDProductGroup.ProductGroupName;
			_bDProductGroup.Notes=bDProductGroup.Notes;
			
			return _bDProductGroup.Update();
		}
	} 
}
