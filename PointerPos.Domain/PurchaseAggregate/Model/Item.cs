using PointerPos.Domain.PurchaseAggregate.Enumerations;
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
        private readonly decimal _subTotal = 0;
        private decimal _discount = 0;
        public decimal UnitCost { get; private set; }
        public int Quantity { get; private set; }
        public Purchase PurchaseBelong { get; private set; }
        public DiscountUnit DiscountUnit { get; private set; }
        public decimal DiscountAmount { get; private set; }

        
        public Item(Purchase purchase, int itemId, decimal unitCost, int quantity)
        {
            PurchaseBelong = purchase;
            Id = itemId;
            UnitCost = unitCost;
            Quantity = quantity;

            _subTotal = unitCost * quantity;
        }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }

        public void AddDiscount(decimal discountAmount, DiscountUnit discountUnit)
        {
            DiscountAmount = discountAmount;
            DiscountUnit = discountUnit;

            _discount = discountUnit.GetMoneyValueOfDiscount(_subTotal, discountAmount);
        }

        public decimal ItemSubtotal
        {
            get { return _subTotal; }
        }

        public decimal ItemDiscount
        {
            get
            {
                return _discount;
            }
        }
    }
}
