using PointerPOS.Infrastructure.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointerPos.Domain.Inventory
{
    public class Product : EntityBase<int>
    {
        public string ProductName { get; private set; }
        public int CategoryID { get; private set; }
        public int BrandID { get; private set; }
        public float ReorderPoint { get; private set; }
        public ProductService ProductService { get; private set; }
        public ProductMeasurement ProductMeasurement { get; private set; }
        public ProductProperties ProductProperties { get; private set; }
        public string Status { get; private set; }

        public Product(string productName, int categoryId)
        {
            ProductName = productName;
            CategoryID = categoryId;
        }

        public void AssignBrand(int brandId)
        {
            BrandID = brandId;
        }

        public void AssignProductService(float warranty, ServicePeriod warrantyUnit,
            float warrantyOfParts, ServicePeriod warrantyOfPartsUnit,
            float serviceDuration, ServicePeriod serviceDurationUnit)
        {
            ProductService = new ProductService(warranty, warrantyUnit, warrantyOfParts, warrantyOfPartsUnit, serviceDuration, serviceDurationUnit);
        }

        public void AssignProductMeasurement(double sizeOrCapacity, string sizeOrCapacityUnit, double power, string salesUnit)
        {
            ProductMeasurement = new ProductMeasurement(sizeOrCapacity, sizeOrCapacityUnit, power, salesUnit);
        }

        public void AssignProductProperties(string model, string color, string manufacturedIn, string features)
        {
            ProductProperties = new ProductProperties(model, color, manufacturedIn, features);
        }

        public void SetReorderPoint(float reorderPoint)
        {
            ReorderPoint = reorderPoint;
        }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
