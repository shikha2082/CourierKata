using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CourierCostCalculator
{
    public enum ParcelType
    {
        [Description("Small Parcel: $3. Total Cost: $3")]
        SmallParcel = 1,
        [Description("Medium Parcel: $8. Total Cost: $8")]
        MediumParcel = 2,
        [Description("Large Parcel: $15. Total Cost: $15")]
        LargeParcel = 3,
        [Description("XL Parcel: $25. Total Cost: $25")]
        ExtraLargeParcel = 4

    }
}
