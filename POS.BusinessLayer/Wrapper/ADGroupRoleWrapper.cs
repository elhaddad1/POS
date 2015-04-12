using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BusinessLayer.Wrapper
{
    public class ADGroupRoleWrapper : ADGroupRoleService
    {
        public ADGroupRoleCollection SelectByGroupID(int groupID)
        {
            return base.SelectByField("GroupID", groupID, null, DataLayer.TypeOperation.Equal);
        }

        public bool InsertGroupRoles(ADGroupRoleCollection aDGroupRoleCollection, int groupID)
        {
            POS.DataLayer.ADGroupRoleCollection _aDGroupRoleCollection = new DataLayer.ADGroupRoleCollection();
            POS.DataLayer.ADGroupRole _aDGroupRole;
            foreach (ADGroupRole groupRole in aDGroupRoleCollection)
            {
                _aDGroupRole = new DataLayer.ADGroupRole();
                _aDGroupRole.GroupID = groupRole.GroupID;
                _aDGroupRole.RoleID = groupRole.RoleID;
                _aDGroupRoleCollection.Add(_aDGroupRole);
            }

            return POS.DataLayer.ADGroupRole.InsertGroupRoles(_aDGroupRoleCollection, groupID);
        }
    }
}
