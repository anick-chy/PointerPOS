using FluentValidation;
using PointerPos.Domain.PurchaseAggregate.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointerPos.Domain.PurchaseAggregate.Validation
{
    public class PurchaseValidator : AbstractValidator<Purchase>
    {
        public PurchaseValidator()
        {
            RuleFor(purchase => purchase.LineItems).Must(HaveMoreThanZeroItems).WithMessage("At least one item required.");
            RuleFor(purchase => purchase.SubTotal).GreaterThan(0).WithMessage("Purchase Items' subtotal must be greater than zero.");
            RuleFor(purchase => purchase.GrossTotal).GreaterThan(0).WithMessage("Purchase Items' gross total must be greater than zero.");
        }

        private bool HaveMoreThanZeroItems(IEnumerable<Item> item)
        {
            return item.Count() > 0;
        }
    }
}
