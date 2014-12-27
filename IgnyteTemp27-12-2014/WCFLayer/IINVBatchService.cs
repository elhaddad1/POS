//
// Class	:	IINVBatchService.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:56:17 PM
//

using System.Collections.Generic;
using System.ServiceModel;
using POS.DataLayer;

namespace POS.BusinessLayer
{
	///<summary>
	///This interface is implemented by WCF services
	///</summary>
	[ServiceContract]
	public interface IINVBatchService
	{
		///<summary>
		///This method will Delete the object from the database
		///</summary>
		///<param name="pk" type="INVBatchPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		/// <returns>True if succeeded</returns>
		[OperationContract]
		bool Delete(INVBatchPrimaryKey pk);

		/// <summary>
		/// This method will Delete row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="INVBatchFields">Field of the class INVBatch</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <returns>True if succeeded</returns>
		[OperationContract]
		bool DeleteByField(string field, object fieldValue);

		/// <summary>
		/// This method will return an object representing the record matching the primary key information specified.
		/// </summary>
		///
		/// <param name="pk" type="INVBatchPrimaryKey">Primary Key information based on which data is to be fetched.</param>
		///
		/// <returns>object of class INVBatch</returns>
		[OperationContract]
		INVBatch SelectOne(INVBatchPrimaryKey pk);

		/// <summary>
		/// This method will return a list of objects representing all records in the table.
		/// </summary>
		///
		/// <returns>list of objects of class INVBatch in the form of object of INVBatchCollection </returns>
		[OperationContract]
		INVBatchCollection SelectAll();
    
    /// <summary>
		/// This method will return a count all records in the table.
		/// </summary>
		///
		/// <returns>count records</returns>
		[OperationContract]
		int SelectAllCount();

		/// <summary>
		/// This method will get row(s) from the database using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class INVBatch</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		///
		/// <returns>List of object of class INVBatch in the form of an object of class INVBatchCollection</returns>
		[OperationContract]
		INVBatchCollection SelectByField(string field, object fieldValue,object fielValue2, TypeOperation typeOperation);	
		
		
		///<summary>
		///This method will insert one row into the database using the object
		///</summary>
		///<param name="POS.DataLayer" type="INVBatch">This INVBatch  will be inserted in the database.</param>
		/// <returns>True if succeeded</returns>
		[OperationContract]
		bool Insert(INVBatch POS.DataLayer);
    
    
	///	<summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
		/// </summary>
		///
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		///
		/// <returns>list of objects of class INVBatch in the form of an object of class INVBatchCollection </returns>
		[OperationContract]
		INVBatchCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement);

		/// <summary>
		/// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
		/// using the value of the field specified
		/// </summary>
		///
		/// <param name="field" type="string">Field of the class INVBatch</param>
		/// <param name="fieldValue" type="object">Value for the field specified.</param>
		/// <param name="fieldValue2" type="object">Value for the field specified.</param>
		/// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
		/// <param name="orderByStatement" type="string">The field value to number.</param>
		/// <param name="pageSize" type="int">Number of records returned.</param>
		/// <param name="skipPages" type="int">The number of missing pages.</param>
		///
		/// <returns>List of object of class INVBatch in the form of an object of class INVBatchCollection</returns>
		[OperationContract]
		INVBatchCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement);
			///<summary>
		///This method will updated one row into the database using the object
		///</summary>
		///<param name="iNVBatch" type="INVBatch">This INVBatch  will be updated in the database.</param>
		/// <returns>True if succeeded</returns>
		[OperationContract]
		bool Update(INVBatch iNVBatch);
	} 
}
