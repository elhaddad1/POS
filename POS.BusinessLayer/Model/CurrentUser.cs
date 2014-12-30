using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BusinessLayer.Model
{
    public class CurrentUser
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserFullName { get; set; }
    }
}
