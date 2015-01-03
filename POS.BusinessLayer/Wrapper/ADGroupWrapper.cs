using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BusinessLayer.Wrapper
{
    public class ADGroupWrapper : ADGroupService
    {
        //  private ADGroupCollection _aDGroupCollection = new ADGroupCollection();

        public ADGroupCollection SelectAll()
        {
            return base.SelectAll();
        }

        public ADGroup SelectOneByID(int? GroupID)
        {
            ADGroupPrimaryKey pk = new ADGroupPrimaryKey();
            pk.GroupID = GroupID;
            return base.SelectOne(pk);
        }

        public bool DeleteByPrimaryKey(int GroupID)
        {
            ADGroupPrimaryKey pk = new ADGroupPrimaryKey();
            pk.GroupID = GroupID;
            return base.Delete(pk);
        }
    }
}
