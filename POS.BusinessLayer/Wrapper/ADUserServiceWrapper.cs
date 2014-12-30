using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.BusinessLayer.Utility;

namespace POS.BusinessLayer.Wrapper
{
    public class ADUserServiceWrapper : ADUserService
    {
        private ADUser _aDUserBl;
        private POS.DataLayer.ADUser _aDUserDa;

        public bool SelectByUserNameAndPassword(string userName, string password)
        {
            _aDUserBl = new ADUser();
            _aDUserDa = POS.DataLayer.ADUser.SelectByUserNameAndPassword(userName, password);
            if (_aDUserDa != null)
            {
                GlobalVariables.CurrentUser.UserID = _aDUserDa.UserID;
                GlobalVariables.CurrentUser.UserFullName = _aDUserDa.UserFullName;
                GlobalVariables.CurrentUser.UserName = _aDUserDa.UserName;
                return true;
            }
            return false;
        }

    }
}
