using PointerPos.Domain.Inventory.InventoryRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointerPos.Domain.Inventory.Stock
{
    public class StoreStock : IPlaceOfStock
    {
        private int StoreID;
        private IStockRepository _stockRepository;
        public StoreStock(int storeId)
        {
            StoreID = storeId;
            _stockRepository = new StoreRepository();
        }
        public float ProductsInStock(int productId)
        {
            return _stockRepository.GetProductsQuantityInStock(productId);
        }

        public void AddNewProduct(int productId, float quantity)
        {
            _stockRepository.AddProductToStock(this.StoreID, productId, quantity);
        }

        public void DeductProductFromStock(int productId, float quantity)
        {
            _stockRepository.DeductProductFromStock(this.StoreID, productId, quantity);
        }
    }
}
