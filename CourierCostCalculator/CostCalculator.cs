﻿using System;
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

        public ParcelCostDetails CalculateCost(bool isSpeedyShipping = false)
        {
            ParcelCostDetails parcelCostDetails = new ParcelCostDetails();
            
            foreach(Parcel parcel in _parcels)
            {
                parcel.ParcelType = GetParcelType(parcel);
                parcel.ItemCost = GetParcelCost(parcel);
            }

            parcelCostDetails.Parcels = _parcels;

            double totalCost = _parcels.Sum(p => p.ItemCost);

            parcelCostDetails.TotalCost = isSpeedyShipping ? totalCost * 2 : totalCost;
            parcelCostDetails.IsSpeedyShipping = isSpeedyShipping;
            return parcelCostDetails;
        }

        internal double GetParcelCost(Parcel parcel)
        {
            switch (parcel.ParcelType)
            {
                case ParcelType.SmallParcel:
                    return parcel.Weight > 1 ? 3 + (parcel.Weight - 1) * 2 : 3;
                case ParcelType.MediumParcel:
                    return parcel.Weight > 3 ? 8 + (parcel.Weight - 3) * 2 : 8;
                case ParcelType.LargeParcel:
                    return parcel.Weight > 6 ? 15 + (parcel.Weight - 6) * 2 : 15; 
                case ParcelType.ExtraLargeParcel:
                    return parcel.Weight > 10 ? 25 + (parcel.Weight - 10) * 2 : 25;
                case ParcelType.HeavyParcel:
                    return parcel.Weight > 50 ? 50 + (parcel.Weight - 50) : 50;
                default:
                    return 0;
            }

        }

        internal ParcelType GetParcelType(Parcel parcel)
        {
            if(parcel.Weight >= 50)
            {
                return ParcelType.HeavyParcel;
            }
            else if(parcel.Height < 10 && parcel.Length < 10 && parcel.Width < 10)
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
