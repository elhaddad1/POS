//
// Class	:	ADGroupRole.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 11:07:46 PM
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
    /// Data access class for the "ADGroupRole" table.
    /// </summary>
    [Serializable]
    public class ADGroupRole : ADGroupRoleBase
    {

        #region Class Level Variables

        #endregion

        #region Constants

        #endregion

        #region Constructors / Destructors

        public ADGroupRole()
            : base()
        {
        }

        #endregion

        #region Properties

        #endregion

        #region Methods (Public)
        public static bool InsertGroupRoles(ADGroupRoleCollection aDGroupRoleCollection, int groupID)
        {

            DatabaseHelper oDatabaseHelper = new DatabaseHelper();
            bool ExecutionState = false;
            oDatabaseHelper.BeginTransaction();
            if (Deletelines(oDatabaseHelper, groupID))
            {
                foreach (ADGroupRole groupRole in aDGroupRoleCollection)
                {
                    if (!InsertDetails(oDatabaseHelper, groupRole))
                    {
                        ExecutionState = false;
                        break;
                    }
                    else
                        ExecutionState = true;

                }
                if (ExecutionState)
                    oDatabaseHelper.CommitTransaction();
                else
                    oDatabaseHelper.RollbackTransaction();

            }
            else
                ExecutionState = false;

            oDatabaseHelper.Dispose();
            return ExecutionState;

        }



        #endregion

        #region Methods (Private)
        private static bool Deletelines(DatabaseHelper oDatabaseHelper, int groupID)
        {
            bool ExecutionState = false;
            oDatabaseHelper.AddParameter("@Field", "GroupID");
            oDatabaseHelper.AddParameter("@Value", groupID);
            // The parameter '@dlgErrorCode' will contain the status after execution of the stored procedure.
            oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
            oDatabaseHelper.ExecuteScalar("gsp_ADGroupRole_DeleteByField", CommandType.StoredProcedure, ConnectionState.KeepOpen, ref ExecutionState);

            return ExecutionState;
        }
        private static bool InsertDetails(DatabaseHelper oDatabaseHelper, ADGroupRole groupRole)
        {
            bool ExecutionState = false;
            oDatabaseHelper.AddParameter("@GroupID", groupRole.GroupID);
            oDatabaseHelper.AddParameter("@RoleID", groupRole.RoleID);
            oDatabaseHelper.AddParameter("@dlgErrorCode", -1, System.Data.ParameterDirection.Output);
            oDatabaseHelper.ExecuteScalar("gsp_ADGroupRole_Insert", CommandType.StoredProcedure, ConnectionState.KeepOpen, ref ExecutionState);
            return ExecutionState;
        }

        #endregion

    }

}
