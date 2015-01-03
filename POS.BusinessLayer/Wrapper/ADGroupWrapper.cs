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
    }
}
