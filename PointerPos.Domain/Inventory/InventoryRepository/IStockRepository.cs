using PointerPos.Domain.Inventory.Stock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointerPos.Domain.Inventory.InventoryRepository
{
    interface IStockRepository
    {
        float GetProductsQuantityInStock(int productId);
        void AddProductToStock(int placeOfStockId, int productId, float quantity);
        void DeductProductFromStock(int placeOfStockId, int productId, float quantity);
    }
}
