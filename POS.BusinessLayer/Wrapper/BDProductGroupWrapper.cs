using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BusinessLayer.Wrapper
{
    public class BDProductGroupWrapper : BDProductGroupService
    {
        private BDProductGroup _bDProductGroupWCF;
        public BDProductGroupCollection SearchByCriteria(string ProductGroupName)
        {
            BDProductGroupCollection bDProductGroupCollection = new BDProductGroupCollection();
            foreach (POS.DataLayer.BDProductGroup _bDProductGroup in POS.DataLayer.BDProductGroup.SearcByCriteria(ProductGroupName))
            {
                _bDProductGroupWCF = new BDProductGroup();

                _bDProductGroupWCF.ProductGroupID = _bDProductGroup.ProductGroupID;
                _bDProductGroupWCF.ProductGroupName = _bDProductGroup.ProductGroupName;
                _bDProductGroupWCF.Notes = _bDProductGroup.Notes;

                bDProductGroupCollection.Add(_bDProductGroupWCF);
            }
            return bDProductGroupCollection;
        }
    }
}
