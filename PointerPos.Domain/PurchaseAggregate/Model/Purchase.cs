using PointerPos.Domain.PurchaseAggregate.Repositories;
using PointerPOS.Infrastructure.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointerPos.Domain.PurchaseAggregate.Model
{
    public class Purchase : EntityBase<int>, IPurchase
    {
        private IPurchaseRepository _purchaseRepository;

        public Purchase(IPurchaseRepository purchaseRepository)
        {
            _purchaseRepository = purchaseRepository;
        }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }

        public Item AssignItem(int itemId, int quantity, decimal unitCost)
        {
            throw new NotImplementedException();
        }

    }
}
