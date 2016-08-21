using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointerPos.Domain.PurchaseAggregate.Enumerations
{
    public abstract class DiscountUnit
    {
        public static DiscountUnit MoneyDiscount = new MoneyDiscountEnum(1, "Money Discount");
        public static DiscountUnit PercentageDiscount = new PercentageDiscountEnum(2, "Percentage Discount");

        public abstract decimal GetMoneyValueOfDiscount(decimal amount, decimal discount);

        private int _value;
        private string _displayName;

        private DiscountUnit(int value, string displayName)
        {
            _value = value;
            _displayName = displayName;
        }

        public override string ToString()
        {
            return _displayName;
        }

        private class MoneyDiscountEnum : DiscountUnit
        {
            public MoneyDiscountEnum(int value, string displayName)
                : base(value, displayName) { }

            public override decimal GetMoneyValueOfDiscount(decimal amount, decimal discount)
            {
                return discount;
            }
        }

        private class PercentageDiscountEnum : DiscountUnit
        {
            public PercentageDiscountEnum(int value, string displayName)
                : base(value, displayName) { }

            public override decimal GetMoneyValueOfDiscount(decimal amount, decimal discount)
            {
                return (discount * amount) / 100;
            }
        }
    }
}
