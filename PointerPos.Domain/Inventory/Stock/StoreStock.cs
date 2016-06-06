﻿using PointerPos.Domain.Inventory.InventoryRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointerPos.Domain.Inventory.Stock
{
    public class StoreStock : IPlaceOfStock
    {
        private int _storeId;
        private IStockRepository _stockRepository;
        public StoreStock(int storeId)
        {
            _storeId = storeId;
            _stockRepository = new StoreRepository();
        }
        public float ProductsInStock(int productId)
        {
            return _stockRepository.GetProductsQuantityInStock(productId);
        }

        public void AddProductToStock(int productId, float quantity, DateTime operationDate)
        {
            _stockRepository.AddProductToStock(this._storeId, productId, quantity, operationDate);
        }

        public void DeductProductFromStock(int productId, float quantity, DateTime operationDate)
        {
            _stockRepository.DeductProductFromStock(this._storeId, productId, quantity, operationDate);
        }
    }
}