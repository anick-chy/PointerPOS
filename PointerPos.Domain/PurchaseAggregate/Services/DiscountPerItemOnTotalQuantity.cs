using PointerPos.Domain.PurchaseAggregate.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointerPos.Domain.PurchaseAggregate.Services
{
    public class DiscountPerItemOnTotalQuantity : IDiscountPerItem
    {
        public decimal CalculateDiscountPerItem(decimal unitCost, int quantity, decimal discountAmount, DiscountUnit discountUnit)
        {
            decimal totalCost = unitCost * quantity;

            totalCost = totalCost - discountUnit.GetMoneyValueOfDiscount(totalCost, discountAmount);

            return totalCost;
        }
    }
}
