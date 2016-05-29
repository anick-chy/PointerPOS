using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointerPos.Domain.Inventory.Product
{
    public class ProductService
    {
        public float Warranty { get; private set; }
        public ServicePeriod WarrantyUnit { get; private set; }
        public float WarrantyOfParts { get; private set; }
        public ServicePeriod WarrantyOfPartsUnit { get; private set; }
        public float ServiceDuration { get; private set; }
        public ServicePeriod ServiceDurationUnit { get; private set; }

        public ProductService(float warranty, ServicePeriod warrantyUnit,
            float warrantyOfParts, ServicePeriod warrantyOfPartsUnit,
            float serviceDuration, ServicePeriod serviceDurationUnit)
        {
            Warranty = warranty;
            WarrantyUnit = warrantyUnit;
            WarrantyOfParts = warrantyOfParts;
            WarrantyOfPartsUnit = warrantyOfPartsUnit;
            ServiceDuration = serviceDuration;
        }
    }
}
