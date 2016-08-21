﻿using PointerPos.Domain.PurchaseAggregate.Enumerations;
using PointerPos.Domain.PurchaseAggregate.Repositories;
using PointerPOS.Infrastructure.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointerPos.Domain.PurchaseAggregate.Model
{
    public class Item : EntityBase<int>
    {
        public decimal UnitCost { get; private set; }
        public int Quantity { get; private set; }
        private readonly IPurchaseRepository _purchaseRepository;
        public Purchase PurchaseBelong { get; private set; }
        public DiscountUnit DiscountUnit { get; private set; }
        public decimal DiscountAmount { get; private set; }

        
        public Item(Purchase purchase, int itemId, decimal unitCost, int quantity, IPurchaseRepository purchaseRepository)
        {
            PurchaseBelong = purchase;
            Id = itemId;
            UnitCost = unitCost;
            Quantity = quantity;
            _purchaseRepository = purchaseRepository;
        }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }

        public void AddDiscount(decimal discountAmount, DiscountUnit discountUnit)
        {
            DiscountAmount = discountAmount;
            DiscountUnit = discountUnit;
        }

        public decimal GetItemSubtotalWithoutDiscount()
        {
            return UnitCost * Quantity;
        }

        public decimal GetItemSubtotalWithDiscount()
        {
            decimal subtotal = GetItemSubtotalWithoutDiscount();
            subtotal -= DiscountUnit.GetMoneyValueOfDiscount(subtotal, DiscountAmount);

            return subtotal;
        }
    }
}
