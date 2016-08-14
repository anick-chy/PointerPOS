using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointerPos.Domain.PurchaseAggregate.Model
{
    public interface IPurchase
    {
        Item AssignItem(int itemId, int quantity, decimal unitCost);
    }
}
