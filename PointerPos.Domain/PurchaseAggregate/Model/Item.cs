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
        private int itemID;
        private readonly IPurchaseRepository _purchaseRepository;
        public Purchase PurchaseBelong { get; private set; }
        
        public Item(Purchase purchase, int itemId, decimal unitCost, int quantity, IPurchaseRepository purchaseRepository)
        {
            PurchaseBelong = purchase;
            itemID = itemId;
            UnitCost = unitCost;
            Quantity = quantity;
            _purchaseRepository = purchaseRepository;
        }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
