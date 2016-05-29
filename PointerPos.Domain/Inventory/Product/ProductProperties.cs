using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointerPos.Domain.Inventory.Product
{
    public class ProductProperties
    {
        public string Model { get; private set; }
        public string Color { get; private set; }
        public string ManufacturedIn { get; private set; }
        public string Features { get; private set; }

        public ProductProperties(string model, string color, string manufacturedIn, string features)
        {
            Model = model;
            Color = color;
            manufacturedIn = ManufacturedIn;
            Features = features;
        }
    }
}
