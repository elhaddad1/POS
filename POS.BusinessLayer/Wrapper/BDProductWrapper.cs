using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BusinessLayer.Wrapper
{
    public class BDProductWrapper : BDProductService
    {
        BDProduct _bDProductWCF;
        public BDProductCollection SelectAllProducDetailsForeignKeyProductGroupID(BDProductGroupPrimaryKey pk)
        {
            BDProductCollection bDProductCollection = new BDProductCollection();
            foreach (POS.DataLayer.BDProduct _bDProduct in POS.DataLayer.BDProductBase.SelectAllByForeignKeyProductGroupID(new POS.DataLayer.BDProductGroupPrimaryKey(pk.ProductGroupID)))
            {
                _bDProductWCF = new BDProduct();
                _bDProductWCF.ProductID = _bDProduct.ProductID;
                _bDProductWCF.ProductName = _bDProduct.ProductName;
                _bDProductWCF.ProductGroupID = _bDProduct.ProductGroupID;
                _bDProductWCF.ProductCode = _bDProduct.ProductCode;
                _bDProductWCF.IsAcceptBatch = _bDProduct.IsAcceptBatch;
                _bDProductWCF.ProductPrice = _bDProduct.ProductPrice;
                _bDProductWCF.IsFixedPrice = _bDProduct.IsFixedPrice;
                _bDProductWCF.HasDiscount = _bDProduct.HasDiscount;
                _bDProductWCF.DiscountAmount = _bDProduct.DiscountAmount;
                _bDProductWCF.DescountRatio = _bDProduct.DescountRatio;
                _bDProductWCF.IsActive = _bDProduct.IsActive;
                _bDProductWCF.Notes = _bDProduct.Notes;
                _bDProductWCF.MinPrice = _bDProduct.MinPrice;
                _bDProductWCF.MaxPrice = _bDProduct.MaxPrice;
                _bDProductWCF.TotalQty = _bDProduct.TotalQty;
                bDProductCollection.Add(_bDProductWCF);
            }
            return bDProductCollection;
        }
    }
}
