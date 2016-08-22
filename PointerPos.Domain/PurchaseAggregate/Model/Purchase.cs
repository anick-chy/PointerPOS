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
        private decimal _grossTotal = 0;
        private decimal _subTotal = 0;

        public IEnumerable<Item> LineItems
        {
            get { return _lineItems; }
        }

        public decimal GrossTotal { get { return _grossTotal; } }
        public decimal SubTotal { get { return _subTotal; } }

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
            Item item = new Item(this, itemId, unitCost, quantity);
            _lineItems.Add(item);

            _subTotal += item.ItemSubtotal;
            _grossTotal += item.ItemSubtotal;
            return item;
        }

        public Item AssignItem(int itemId, int quantity, decimal unitCost, decimal discountAmount, DiscountUnit discountUnit)
        {
            Item item = AssignItem(itemId, quantity, unitCost);
            item.AddDiscount(discountAmount, discountUnit);

            _subTotal -= item.ItemDiscount;
            _grossTotal -= item.ItemDiscount;
            return item;
        }
        
    }
}
