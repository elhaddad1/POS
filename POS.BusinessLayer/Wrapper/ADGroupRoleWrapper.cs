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

       
    }
}
