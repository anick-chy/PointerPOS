using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointerPos.Domain.Inventory
{
    public class ProductMeasurement
    {
        public double SizeOrCapacity { get; private set; }
        public string SizeOrCapacityUnit { get; private set; }
        public double Power { get; private set; }
        public string SalesUnit { get; private set; }

        public ProductMeasurement(double sizeOrCapacity, string sizeOrCapacityUnit, double power, string salesUnit)
        {
            SizeOrCapacity = sizeOrCapacity;
            SizeOrCapacityUnit = sizeOrCapacityUnit;
            Power = power;
            SalesUnit = salesUnit;
        }
    }
}
