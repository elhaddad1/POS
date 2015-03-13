using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.DataLayer;
using POS.BusinessLayer.Utility;
namespace POS.BusinessLayer.Wrapper
{
    public class INVTakingInventoryLineWrapper:INVTakingInventoryLineService
    {
        public bool OpenTakingInventory(string TakingName, DateTime TakingDate, int InventoryID, int TakingType,
                                        int? ProductID, int? ProductGroupID, string Notes)
        {
            int userID = GlobalVariables.CurrentUser.UserID;
           bool a= POS.DataLayer. INVTakingInventoryLine.OpenTakingInventory(TakingName, TakingDate, InventoryID, TakingType, ProductID,
                                                                 ProductGroupID, Notes,userID);
            return true;
        }


    }
}
