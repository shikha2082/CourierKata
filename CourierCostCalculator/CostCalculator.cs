using System;
using System.Collections.Generic;
using System.Linq;

namespace CourierCostCalculator
{
    public class CostCalculator
    {
        private readonly List<Parcel> _parcels;
        public CostCalculator(List<Parcel> parcels)
        {
            _parcels = parcels;
        }

        public ParcelCostDetails CalculateCost()
        {
            ParcelCostDetails parcelCostDetails = new ParcelCostDetails();
            
            foreach(Parcel parcel in _parcels)
            {
                parcel.ParcelType = GetParcelType(parcel);
                parcel.ItemCost = GetParcelCost(parcel.ParcelType.Value);
            }

            parcelCostDetails.Parcels = _parcels;
            parcelCostDetails.TotalCost = _parcels.Sum(p => p.ItemCost);

            return parcelCostDetails;
        }

        internal double GetParcelCost(ParcelType parcelType)
        {
            switch (parcelType)
            {
                case ParcelType.SmallParcel:
                    return 3;
                case ParcelType.MediumParcel:
                    return 8;
                case ParcelType.LargeParcel:
                    return 15;
                case ParcelType.ExtraLargeParcel:
                    return 25;
                default:
                    return 0;
            }

        }

        internal ParcelType GetParcelType(Parcel parcel)
        {            
            if(parcel.Height < 10 && parcel.Length < 10 && parcel.Width < 10)
            {
                return ParcelType.SmallParcel;
            }
            else if (parcel.Height < 50 && parcel.Length < 50 && parcel.Width < 50)
            {
                return ParcelType.MediumParcel;
            }
            else if (parcel.Height < 100 && parcel.Length < 100 && parcel.Width < 100)
            {
                return ParcelType.LargeParcel;
            }
            else
            {
                return ParcelType.ExtraLargeParcel;
            }
        }
    }
}
