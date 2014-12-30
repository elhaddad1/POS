using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BusinessLayer.Wrapper
{
    public class ADUserServiceWrapper : ADUserService
    {
        private ADUser _aDUserBl;
        private POS.DataLayer.ADUser _aDUserDa;

        public ADUser SelectByUserNameAndPassword(string UserName, string Password)
        {
            _aDUserBl = new ADUser();
            _aDUserDa = POS.DataLayer.ADUser.SelectByUserNameAndPassword(UserName, Password);

            _aDUserBl.UserID = _aDUserDa.UserID;
            _aDUserBl.UserFullName = _aDUserDa.UserFullName;
            _aDUserBl.UserName = _aDUserDa.UserName;
            _aDUserBl.Password = _aDUserDa.Password;
            _aDUserBl.GroupID = _aDUserDa.GroupID;
            _aDUserBl.Email = _aDUserDa.Email;
            _aDUserBl.Address = _aDUserDa.Address;
            _aDUserBl.Phone = _aDUserDa.Phone;
            _aDUserBl.Mobile = _aDUserDa.Mobile;

            return _aDUserBl;
        }
    }
}
