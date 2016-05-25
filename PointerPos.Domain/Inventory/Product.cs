using PointerPOS.Infrastructure.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointerPos.Domain.Inventory
{
    public class Product : EntityBase<int>
    {
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        public int BrandID { get; set; }
        public string SalesUnit { get; set; }
        public string Model { get; set; }
        public double SizeOrCapacity { get; set; }
        public string SizeOrCapacityUnit { get; set; }
        public double Power { get; set; }
        public float Warranty { get; set; }
        public string WarrantyUnit { get; set; }
        public float WarrantyOfParts { get; set; }
        public string WarrantyOfPartsUnit { get; set; }
        public float ServiceDuration { get; set; }
        public string ServiceDurationUnit { get; set; }
        public float ReorderAmount { get; set; }
        public string Color { get; set; }
        public string ManufacturedIn { get; set; }
        public string Features { get; set; }
        public string Status { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
