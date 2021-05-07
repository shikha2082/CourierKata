using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CourierCostCalculator
{
    public enum ParcelType
    {
        [Description("Small Parcel: $3")]
        SmallParcel = 1,
        [Description("Medium Parcel: $8")]
        MediumParcel = 2,
        [Description("Large Parcel: $15")]
        LargeParcel = 3,
        [Description("XL Parcel: $25")]
        ExtraLargeParcel = 4,
        [Description("Heavy Parcel: $50")]
        HeavyParcel = 5


    }
}
