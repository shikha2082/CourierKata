using System;
using System.Collections.Generic;
using System.Text;

namespace CourierCostCalculator
{
    public class Parcel
    {
        public string ItemName { get; set; }
        public int Length { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public ParcelType? ParcelType { get; set; }

        public double ItemCost { get; set; }
    }
}
