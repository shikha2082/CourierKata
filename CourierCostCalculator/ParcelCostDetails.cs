using System;
using System.Collections.Generic;
using System.Text;

namespace CourierCostCalculator
{
    public class ParcelCostDetails
    {
        public List<Parcel> Parcels { get; set; }

        public double TotalCost { get; set; }
        
        public bool IsSpeedyShipping { get; set; }

        public double Discount { get; set; }
    }
}
