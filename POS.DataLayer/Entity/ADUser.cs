//
// Class	:	ADUser.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:56:08 PM
//

using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Collections;
using System.Data.Common;

namespace POS.DataLayer
{

    /// <summary>
    /// Data access class for the "ADUser" table.
    /// </summary>
    [Serializable]
    public class ADUser : ADUserBase
    {

        #region Class Level Variables

        #endregion

        #region Constants

        #endregion

        #region Constructors / Destructors

        public ADUser()
            : base()
        {
        }

        #endregion

        #region Properties

        #endregion

        #region Methods (Public)
        public static ADUser SelectByUserNameAndPassword(string UserName, string Password)
        {
            DatabaseHelper oDatabaseHelper = new DatabaseHelper();
            bool ExecutionState = false;

            oDatabaseHelper.AddParameter("@UserName", UserName);
            oDatabaseHelper.AddParameter("@Password", Password);

            // The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
            oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);

            IDataReader dr = oDatabaseHelper.ExecuteReader("gsp_ADUser_SelectUserNameAndPassword", ref ExecutionState);
            if (dr.Read())
            {
                ADUser obj = new ADUser();
                PopulateObjectFromReader(obj, dr);
                dr.Close();
                oDatabaseHelper.Dispose();
                return obj;
            }
            else
            {
                dr.Close();
                oDatabaseHelper.Dispose();
                return null;
            }

        }
        #endregion

        #region Methods (Private)

        #endregion

    }

}
