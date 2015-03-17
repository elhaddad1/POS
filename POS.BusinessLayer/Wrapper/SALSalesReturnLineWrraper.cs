using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BusinessLayer.Wrapper
{
    public class SALSalesReturnLineWrraper : SALSalesReturnLineService
    {
        public SALSalesReturnLineCollection SelectByField(int salesReturnHeaderID)
        {
            return base.SelectByField("SalesReturnLineID", salesReturnHeaderID, null, DataLayer.TypeOperation.Equal);
        }
    }
}
