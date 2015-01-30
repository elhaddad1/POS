using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BusinessLayer.Wrapper
{
    public class INVInventoryWrapper : INVInventoryService
    {
        private INVInventory _invInventoryWCF;
        public INVInventoryCollection SearchByCriteria(string InventoryName)
        {
            INVInventoryCollection invInventoryCollection = new INVInventoryCollection();
            foreach (POS.DataLayer.INVInventory _invInventory in POS.DataLayer.INVInventory.SearcByCriteria(InventoryName))
            {
                _invInventoryWCF = new INVInventory();

                _invInventoryWCF.InventoryID = _invInventory.InventoryID;
                _invInventoryWCF.InventoryName = _invInventory.InventoryName;
                _invInventoryWCF.Notes = _invInventory.Notes;

                invInventoryCollection.Add(_invInventoryWCF);
            }
            return invInventoryCollection;
        }
    }
}
