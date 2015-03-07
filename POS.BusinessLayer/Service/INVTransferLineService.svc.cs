//
// Class	:	INVTransferLineServices.svc.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	3/7/2015 2:37:01 PM
//


using POS.DataLayer;

namespace POS.BusinessLayer
{
    ///<summary>
    ///WCF service for the INVTransferLine
    ///</summary>
    public class INVTransferLineService
    {
        private INVTransferLine _iNVTransferLineWCF;
        private POS.DataLayer.INVTransferLine _iNVTransferLine;

        /// <summary>
        /// This method will Delete row(s) from the database using the value of the field specified
        /// </summary>
        ///
        /// <param name="field" type="INVTransferLineFields">Field of the class INVTransferLine</param>
        /// <param name="fieldValue" type="object">Value for the field specified.</param>
        /// <returns>True if succeeded</returns>
        public bool DeleteByField(string field, object fieldValue)
        {
            return POS.DataLayer.INVTransferLineBase.DeleteByField(field, fieldValue);
        }

        ///<summary>
        ///This method will Delete the object from the database
        ///</summary>
        ///<param name="pk" type="INVTransferLinePrimaryKey">Primary Key information based on which data is to be fetched.</param>
        /// <returns>True if succeeded</returns>
        public bool Delete(INVTransferLinePrimaryKey pk)
        {
            return POS.DataLayer.INVTransferLineBase.Delete(new POS.DataLayer.INVTransferLinePrimaryKey(pk.TransferLineID));
        }

        /// <summary>
        /// This method will return an object representing the record matching the primary key information specified.
        /// </summary>
        ///
        /// <param name="pk" type="INVTransferLinePrimaryKey">Primary Key information based on which data is to be fetched.</param>
        ///
        /// <returns>object of class INVTransferLine</returns>
        public INVTransferLine SelectOne(INVTransferLinePrimaryKey pk)
        {
            _iNVTransferLineWCF = new INVTransferLine();
            _iNVTransferLine = POS.DataLayer.INVTransferLineBase.SelectOne(new POS.DataLayer.INVTransferLinePrimaryKey(pk.TransferLineID));

            _iNVTransferLineWCF.TransferLineID = _iNVTransferLine.TransferLineID;
            _iNVTransferLineWCF.TransferHeaderID = _iNVTransferLine.TransferHeaderID;
            _iNVTransferLineWCF.ProductID = _iNVTransferLine.ProductID;
            _iNVTransferLineWCF.Qty = _iNVTransferLine.Qty;
            _iNVTransferLineWCF.CreatedBy = _iNVTransferLine.CreatedBy;
            _iNVTransferLineWCF.CreateDate = _iNVTransferLine.CreateDate;
            _iNVTransferLineWCF.UpdatedBy = _iNVTransferLine.UpdatedBy;
            _iNVTransferLineWCF.UpdateDate = _iNVTransferLine.UpdateDate;
            _iNVTransferLineWCF.IsDeleted = _iNVTransferLine.IsDeleted;
            _iNVTransferLineWCF.DeletedBy = _iNVTransferLine.DeletedBy;
            _iNVTransferLineWCF.DeletedDate = _iNVTransferLine.DeletedDate;

            return _iNVTransferLineWCF;
        }

        /// <summary>
        /// This method will return a list of objects representing all records in the table.
        /// </summary>
        ///
        /// <returns>list of objects of class INVTransferLine in the form of object of INVTransferLineCollection </returns>
        public INVTransferLineCollection SelectAll()
        {
            INVTransferLineCollection iNVTransferLineCollection = new INVTransferLineCollection();
            foreach (POS.DataLayer.INVTransferLine _iNVTransferLine in POS.DataLayer.INVTransferLineBase.SelectAll())
            {
                _iNVTransferLineWCF = new INVTransferLine();

                _iNVTransferLineWCF.TransferLineID = _iNVTransferLine.TransferLineID;
                _iNVTransferLineWCF.TransferHeaderID = _iNVTransferLine.TransferHeaderID;
                _iNVTransferLineWCF.ProductID = _iNVTransferLine.ProductID;
                _iNVTransferLineWCF.Qty = _iNVTransferLine.Qty;
                _iNVTransferLineWCF.CreatedBy = _iNVTransferLine.CreatedBy;
                _iNVTransferLineWCF.CreateDate = _iNVTransferLine.CreateDate;
                _iNVTransferLineWCF.UpdatedBy = _iNVTransferLine.UpdatedBy;
                _iNVTransferLineWCF.UpdateDate = _iNVTransferLine.UpdateDate;
                _iNVTransferLineWCF.IsDeleted = _iNVTransferLine.IsDeleted;
                _iNVTransferLineWCF.DeletedBy = _iNVTransferLine.DeletedBy;
                _iNVTransferLineWCF.DeletedDate = _iNVTransferLine.DeletedDate;

                iNVTransferLineCollection.Add(_iNVTransferLineWCF);
            }
            return iNVTransferLineCollection;
        }

        /// <summary>
        /// This method will return a count all records in the table.
        /// </summary>
        ///
        /// <returns>count records</returns>
        public int SelectAllCount()
        {
            return POS.DataLayer.INVTransferLineBase.SelectAllCount();
        }

        /// <summary>
        /// This method will get row(s) from the database using the value of the field specified
        /// </summary>
        ///
        /// <param name="field" type="string">Field of the class INVTransferLine</param>
        /// <param name="fieldValue" type="object">Value for the field specified.</param>
        /// <param name="fieldValue2" type="object">Value for the field specified.</param>
        /// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
        ///
        /// <returns>List of object of class INVTransferLine in the form of an object of class INVTransferLineCollection</returns>
        public INVTransferLineCollection SelectByField(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation)
        {
            INVTransferLineCollection iNVTransferLineCollection = new INVTransferLineCollection();
            foreach (POS.DataLayer.INVTransferLine _iNVTransferLine in POS.DataLayer.INVTransferLineBase.SelectByField(field, fieldValue, fieldValue2, typeOperation))
            {
                _iNVTransferLineWCF = new INVTransferLine();

                _iNVTransferLineWCF.TransferLineID = _iNVTransferLine.TransferLineID;
                _iNVTransferLineWCF.TransferHeaderID = _iNVTransferLine.TransferHeaderID;
                _iNVTransferLineWCF.ProductID = _iNVTransferLine.ProductID;
                _iNVTransferLineWCF.Qty = _iNVTransferLine.Qty;
                _iNVTransferLineWCF.CreatedBy = _iNVTransferLine.CreatedBy;
                _iNVTransferLineWCF.CreateDate = _iNVTransferLine.CreateDate;
                _iNVTransferLineWCF.UpdatedBy = _iNVTransferLine.UpdatedBy;
                _iNVTransferLineWCF.UpdateDate = _iNVTransferLine.UpdateDate;
                _iNVTransferLineWCF.IsDeleted = _iNVTransferLine.IsDeleted;
                _iNVTransferLineWCF.DeletedBy = _iNVTransferLine.DeletedBy;
                _iNVTransferLineWCF.DeletedDate = _iNVTransferLine.DeletedDate;

                iNVTransferLineCollection.Add(_iNVTransferLineWCF);
            }
            return iNVTransferLineCollection;
        }

        /// <summary>
        /// This method will insert one new row into the database using the property Information
        /// </summary>
        ///
        /// <param name="iNVTransferLine" type="INVTransferLine">This INVTransferLine  will be inserted in the database.</param>
        ///
        /// <returns>True if succeeded</returns>
        public bool Insert(INVTransferLine iNVTransferLine)
        {
            _iNVTransferLine = new POS.DataLayer.INVTransferLine();
            _iNVTransferLine.TransferLineID = iNVTransferLine.TransferLineID;
            _iNVTransferLine.TransferHeaderID = iNVTransferLine.TransferHeaderID;
            _iNVTransferLine.ProductID = iNVTransferLine.ProductID;
            _iNVTransferLine.Qty = iNVTransferLine.Qty;
            _iNVTransferLine.CreatedBy = iNVTransferLine.CreatedBy;
            _iNVTransferLine.CreateDate = iNVTransferLine.CreateDate;
            _iNVTransferLine.UpdatedBy = iNVTransferLine.UpdatedBy;
            _iNVTransferLine.UpdateDate = iNVTransferLine.UpdateDate;
            _iNVTransferLine.IsDeleted = iNVTransferLine.IsDeleted;
            _iNVTransferLine.DeletedBy = iNVTransferLine.DeletedBy;
            _iNVTransferLine.DeletedDate = iNVTransferLine.DeletedDate;

            return _iNVTransferLine.Insert();
        }

        /// <summary>
        /// This method will return a list of objects representing the specified number of entries from the specified record number in the table.
        /// </summary>
        ///
        /// <param name="pageSize" type="int">Number of records returned.</param>
        /// <param name="skipPages" type="int">The number of missing pages.</param>
        /// <param name="orderByStatement" type="string">The field value to number.</param>
        ///
        /// <returns>list of objects of class INVTransferLine in the form of an object of class INVTransferLineCollection </returns>
        public INVTransferLineCollection SelectAllPaged(int? pageSize, int? skipPages, string orderByStatement)
        {
            INVTransferLineCollection iNVTransferLineCollection = new INVTransferLineCollection();
            foreach (POS.DataLayer.INVTransferLine _iNVTransferLine in POS.DataLayer.INVTransferLineBase.SelectAllPaged(pageSize, skipPages, orderByStatement))
            {
                _iNVTransferLineWCF = new INVTransferLine();

                _iNVTransferLineWCF.TransferLineID = _iNVTransferLine.TransferLineID;
                _iNVTransferLineWCF.TransferHeaderID = _iNVTransferLine.TransferHeaderID;
                _iNVTransferLineWCF.ProductID = _iNVTransferLine.ProductID;
                _iNVTransferLineWCF.Qty = _iNVTransferLine.Qty;
                _iNVTransferLineWCF.CreatedBy = _iNVTransferLine.CreatedBy;
                _iNVTransferLineWCF.CreateDate = _iNVTransferLine.CreateDate;
                _iNVTransferLineWCF.UpdatedBy = _iNVTransferLine.UpdatedBy;
                _iNVTransferLineWCF.UpdateDate = _iNVTransferLine.UpdateDate;
                _iNVTransferLineWCF.IsDeleted = _iNVTransferLine.IsDeleted;
                _iNVTransferLineWCF.DeletedBy = _iNVTransferLine.DeletedBy;
                _iNVTransferLineWCF.DeletedDate = _iNVTransferLine.DeletedDate;

                iNVTransferLineCollection.Add(_iNVTransferLineWCF);
            }
            return iNVTransferLineCollection;
        }

        /// <summary>
        /// This method will return a list of objects representing the specified number of entries from the specified record number in the table 
        /// using the value of the field specified
        /// </summary>
        ///
        /// <param name="field" type="string">Field of the class INVTransferLine</param>
        /// <param name="fieldValue" type="object">Value for the field specified.</param>
        /// <param name="fieldValue2" type="object">Value for the field specified.</param>
        /// <param name="typeOperation" type="TypeOperation">Operator that is used if fieldValue2=null or fieldValue2="".</param>
        /// <param name="orderByStatement" type="string">The field value to number.</param>
        /// <param name="pageSize" type="int">Number of records returned.</param>
        /// <param name="skipPages" type="int">The number of missing pages.</param>
        ///
        /// <returns>List of object of class INVTransferLine in the form of an object of class INVTransferLineCollection</returns>
        public INVTransferLineCollection SelectByFieldPaged(string field, object fieldValue, object fieldValue2, TypeOperation typeOperation, int pageSize, int skipPages, string orderByStatement)
        {
            INVTransferLineCollection iNVTransferLineCollection = new INVTransferLineCollection();
            foreach (POS.DataLayer.INVTransferLine _iNVTransferLine in POS.DataLayer.INVTransferLineBase.SelectByFieldPaged(field, fieldValue, fieldValue2, typeOperation, pageSize, skipPages, orderByStatement))
            {
                _iNVTransferLineWCF = new INVTransferLine();

                _iNVTransferLineWCF.TransferLineID = _iNVTransferLine.TransferLineID;
                _iNVTransferLineWCF.TransferHeaderID = _iNVTransferLine.TransferHeaderID;
                _iNVTransferLineWCF.ProductID = _iNVTransferLine.ProductID;
                _iNVTransferLineWCF.Qty = _iNVTransferLine.Qty;
                _iNVTransferLineWCF.CreatedBy = _iNVTransferLine.CreatedBy;
                _iNVTransferLineWCF.CreateDate = _iNVTransferLine.CreateDate;
                _iNVTransferLineWCF.UpdatedBy = _iNVTransferLine.UpdatedBy;
                _iNVTransferLineWCF.UpdateDate = _iNVTransferLine.UpdateDate;
                _iNVTransferLineWCF.IsDeleted = _iNVTransferLine.IsDeleted;
                _iNVTransferLineWCF.DeletedBy = _iNVTransferLine.DeletedBy;
                _iNVTransferLineWCF.DeletedDate = _iNVTransferLine.DeletedDate;

                iNVTransferLineCollection.Add(_iNVTransferLineWCF);
            }
            return iNVTransferLineCollection;
        }
        ///<summary>
        /// This method will update one new row into the database using the property Information
        /// </summary>
        ///
        /// <param name="iNVTransferLine" type="INVTransferLine">This INVTransferLine  will be updated in the database.</param>
        ///
        /// <returns>True if succeeded</returns>
        public bool Update(INVTransferLine iNVTransferLine)
        {
            _iNVTransferLine = POS.DataLayer.INVTransferLine.SelectOne(new POS.DataLayer.INVTransferLinePrimaryKey(iNVTransferLine.TransferLineID));

            _iNVTransferLine.TransferHeaderID = iNVTransferLine.TransferHeaderID;
            _iNVTransferLine.ProductID = iNVTransferLine.ProductID;
            _iNVTransferLine.Qty = iNVTransferLine.Qty;
            _iNVTransferLine.CreatedBy = iNVTransferLine.CreatedBy;
            _iNVTransferLine.CreateDate = iNVTransferLine.CreateDate;
            _iNVTransferLine.UpdatedBy = iNVTransferLine.UpdatedBy;
            _iNVTransferLine.UpdateDate = iNVTransferLine.UpdateDate;
            _iNVTransferLine.IsDeleted = iNVTransferLine.IsDeleted;
            _iNVTransferLine.DeletedBy = iNVTransferLine.DeletedBy;
            _iNVTransferLine.DeletedDate = iNVTransferLine.DeletedDate;

            return _iNVTransferLine.Update();
        }
    }
}
