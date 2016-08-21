using PointerPos.Domain.PurchaseAggregate.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointerPos.Domain.PurchaseAggregate.Services
{
    public class DiscountPerItemOnUnitQuantity : IDiscountPerItem
    {
        public decimal CalculateDiscountPerItem(decimal unitCost, int quantity, decimal discountAmount, DiscountUnit discountUnit)
        {
            decimal unitCostAfterDiscount = discountUnit.GetMoneyValueOfDiscount(unitCost, discountAmount);
            return unitCostAfterDiscount * quantity;
        }
    }
}
