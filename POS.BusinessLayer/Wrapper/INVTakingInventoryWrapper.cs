using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.BusinessLayer.Utility;

namespace POS.BusinessLayer.Wrapper
{
    public class INVTakingInventoryWrapper :INVTakingInventoryService
    {
        private INVTakingInventory _iNVTakingInventoryWCF;
        private POS.DataLayer.INVTakingInventory _iNVTakingInventory;
		
        public INVTakingInventoryCollection GetUnCommittedTaking()
        {
            INVTakingInventoryCollection iNVTakingInventoryCollection = new INVTakingInventoryCollection();
            foreach (POS.DataLayer.INVTakingInventory _iNVTakingInventory in new POS.DataLayer.INVTakingInventory().GetNotCommittedTaking())
            {
                _iNVTakingInventoryWCF = new INVTakingInventory();

                _iNVTakingInventoryWCF.TakingHeaderID = _iNVTakingInventory.TakingHeaderID;
                _iNVTakingInventoryWCF.TakingDate = _iNVTakingInventory.TakingDate;
                _iNVTakingInventoryWCF.TakingName = _iNVTakingInventory.TakingName;
                _iNVTakingInventoryWCF.CreatedBy = _iNVTakingInventory.CreatedBy;
                
                _iNVTakingInventoryWCF.Notes = _iNVTakingInventory.Notes;
                _iNVTakingInventoryWCF.InventoryID = _iNVTakingInventory.InventoryID;
                _iNVTakingInventoryWCF.InventoryName = _iNVTakingInventory.InventoryName;
                iNVTakingInventoryCollection.Add(_iNVTakingInventoryWCF);
            }
            return iNVTakingInventoryCollection;

        }

        public static  bool CommitTaking(int  TakingHeaderID)
        {
            int userID = GlobalVariables.CurrentUser.UserID;
            bool a = POS.DataLayer.INVTakingInventory.CommitTakingInventory(TakingHeaderID, userID);
            return true;
        }
    }
}
