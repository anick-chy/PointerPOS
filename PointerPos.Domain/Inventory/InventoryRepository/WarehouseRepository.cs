using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointerPos.Domain.Inventory.InventoryRepository
{
    public class WarehouseRepository : IStockRepository
    {
        public float GetProductsQuantityInStock(int productId)
        {
            throw new NotImplementedException();
        }

        public void AddProductToStock(int placeOfStockId, int productId, float quantity, DateTime operationDate)
        {
            throw new NotImplementedException();
        }

        public void DeductProductFromStock(int placeOfStockId, int productId, float quantity, DateTime operationDate)
        {
            throw new NotImplementedException();
        }
    }
}
