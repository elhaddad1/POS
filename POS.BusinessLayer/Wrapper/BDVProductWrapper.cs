using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BusinessLayer.Wrapper
{
    public class BDVProductWrapper : VProductService
    {
        private VProduct _vProduct;
        public List<VProduct> SearchByCriteria(string productName, string productCode)
        {
            List<VProduct> bDProductCollection = new List<VProduct>();
            foreach (POS.DataLayer.VProduct _bDProduct in POS.DataLayer.VProduct.SearcByCriteria(productName, productCode))
            {
                _vProduct = new VProduct();

                _vProduct.ProductID = _bDProduct.ProductID;
                _vProduct.ProductName = _bDProduct.ProductName;
                _vProduct.ProductCode = _bDProduct.ProductCode;
                _vProduct.ProductGroupID = _bDProduct.ProductGroupID;
                _vProduct.IsAcceptBatch = _bDProduct.IsAcceptBatch;
                _vProduct.ProductPrice = _bDProduct.ProductPrice;
                _vProduct.IsFixedPrice = _bDProduct.IsFixedPrice;
                _vProduct.HasDiscount = _bDProduct.HasDiscount;
                _vProduct.DiscountAmount = _bDProduct.DiscountAmount;
                _vProduct.DescountRatio = _bDProduct.DescountRatio;
                _vProduct.Notes = _bDProduct.Notes;
                _vProduct.ProductGroupName = _bDProduct.ProductGroupName;
                _vProduct.IsActive = _bDProduct.IsActive;
                _vProduct.Expr1 = _bDProduct.Expr1;
                bDProductCollection.Add(_vProduct);
            }
            return bDProductCollection;
        }
    }
}
