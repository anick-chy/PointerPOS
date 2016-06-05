using PointerPos.Domain.Inventory.Stock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointerPos.Domain.Inventory.InventoryRepository
{
    public class StoreRepository : IStockRepository
    {
        public float GetProductsQuantityInStock(int productId)
        {
            throw new NotImplementedException();
        }

        public void AddProductToStock(int placeOfStockId, int productId, float quantity)
        {
            throw new NotImplementedException();
        }


        public void DeductProductFromStock(int placeOfStockId, int productId, float quantity)
        {
            throw new NotImplementedException();
        }
    }
}
