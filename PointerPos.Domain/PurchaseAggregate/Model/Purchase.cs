using PointerPos.Domain.PurchaseAggregate.Enumerations;
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

        private readonly IList<Item> _lineItems = new List<Item>();
        public IEnumerable<Item> LineItems
        {
            get { return _lineItems; }
        }

        public Purchase(DateTime purchaseDate, int supplierId, IPurchaseRepository purchaseRepository)
        {
            _purchaseRepository = purchaseRepository;
        }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }

        public Item AssignItem(int itemId, int quantity, decimal unitCost)
        {
            Item item = new Item(this, itemId, unitCost, quantity, _purchaseRepository);
            _lineItems.Add(item);
            return item;
        }

        public Item AssignItem(int itemId, int quantity, decimal unitCost, decimal discountAmount, DiscountUnit discountUnit)
        {
            Item item = this.AssignItem(itemId, quantity, unitCost);
            item.AddDiscount(discountAmount, discountUnit);

            return item;
        }

        public decimal GetNetTotal()
        {
            decimal netTotal = 0;
            foreach (Item item in _lineItems)
            {
                netTotal += item.GetItemSubtotalWithDiscount();
            }

            return netTotal;
        }
    }
}
