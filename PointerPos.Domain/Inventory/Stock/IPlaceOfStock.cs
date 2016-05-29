using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointerPos.Domain.Inventory.Stock
{
    interface IPlaceOfStock
    {
        float ProductsInStock(int productId);
        void AddNewProduct(int productId, float quantity);
        void DeductProductFromStock(int productId, float quantity);
    }
}
