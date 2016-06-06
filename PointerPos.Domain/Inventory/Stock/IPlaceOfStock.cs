using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointerPos.Domain.Inventory.Stock
{
    interface IPlaceOfStock
    {
        float ProductsInStock(int productId);
        void AddProductToStock(int productId, float quantity, DateTime operationDate);
        void DeductProductFromStock(int productId, float quantity, DateTime operationDate);
    }
}
