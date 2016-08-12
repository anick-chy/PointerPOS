using PointerPOS.Infrastructure.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointerPos.Domain.PurchaseAggregate.Model
{
    public class Purchase : EntityBase<int>
    {
        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
