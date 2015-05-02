using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.BusinessLayer.Utility;

namespace POS.BusinessLayer.Wrapper
{
    public class ADUserWrapper : ADUserService
    {
        private VUserRoleService _vUserRoleService = new VUserRoleService();
        private POS.DataLayer.ADUser _aDUserDa;
        private POS.BusinessLayer.VUserRoleCollection _vUserRoleCollection;

        public bool SelectByUserNameAndPassword(string userName, string password, out string Message)
        {
            _aDUserDa = POS.DataLayer.ADUser.SelectByUserNameAndPassword(userName, password);
            if (_aDUserDa != null)
            {
                _vUserRoleCollection = _vUserRoleService.SelectByField("UserID", _aDUserDa.UserID, null, DataLayer.TypeOperation.Equal);
                if (_vUserRoleCollection.Count != 0)
                {
                    GlobalVariables.CurrentUser.UserID = (int)_aDUserDa.UserID;
                    GlobalVariables.CurrentUser.UserFullName = _aDUserDa.UserFullName;
                    GlobalVariables.CurrentUser.UserName = _aDUserDa.UserName;
                    foreach (VUserRole userRole in _vUserRoleCollection)
                    {
                        GlobalVariables.CurrentUser.UserRoles.Add(userRole.RolePath);
                        if (!string.IsNullOrWhiteSpace(userRole.MenuButton))
                            GlobalVariables.CurrentUser.UserShrtBtn.Add(userRole.MenuButton);
                    }

                    Message = "success";
                    return true;
                }
                else
                {
                    Message = "هذا المستخدم ليس له صلاحيات";
                    return false;
                }
            }
            Message = "خطا فى بيانات الدخول";
            return false;
        }
    }
}
