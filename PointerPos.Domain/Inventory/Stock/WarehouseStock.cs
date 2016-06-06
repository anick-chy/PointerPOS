using PointerPos.Domain.Inventory.InventoryRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointerPos.Domain.Inventory.Stock
{
    public class WarehouseStock : IPlaceOfStock
    {
        private int _warehouseId;
        private IStockRepository _stockRepository;
        public WarehouseStock(int warehouseId)
        {
            _warehouseId = warehouseId;
            _stockRepository = new WarehouseRepository();
        }
        public float ProductsInStock(int productId)
        {
            return _stockRepository.GetProductsQuantityInStock(productId);
        }

        public void AddProductToStock(int productId, float quantity, DateTime operationDate)
        {
            _stockRepository.AddProductToStock(this._warehouseId, productId, quantity, operationDate);
        }

        public void DeductProductFromStock(int productId, float quantity, DateTime operationDate)
        {
            _stockRepository.DeductProductFromStock(this._warehouseId, productId, quantity, operationDate);
        }
    }
}
