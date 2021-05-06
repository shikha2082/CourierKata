using System;
using System.Collections.Generic;
using CourierCostCalculator;

namespace CourierApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<Parcel> parcels = GetParcelData();

            CostCalculator costCalculator = new CostCalculator(parcels);

            ParcelCostDetails parcelCostDetails = costCalculator.CalculateCost();

            foreach(Parcel parcel in parcelCostDetails.Parcels)
            {
                Console.WriteLine($"Item - {parcel.ItemName}, Type -{parcel.ParcelType.Value}, Cost - {parcel.ItemCost}");
            }

            Console.WriteLine($"Total Cost - {parcelCostDetails.TotalCost}");

        }

        public static List<Parcel> GetParcelData()
        {
            List<Parcel> parcels = new List<Parcel>();

            Parcel parcel1 = new Parcel()
            {
                ItemName ="Item1",
                Length = 6,
                Height = 5,
                Width = 8
            };
            parcels.Add(parcel1);
            Parcel parcel2 = new Parcel()
            {
                ItemName = "Item2",
                Length = 60,
                Height = 56,
                Width = 89
            };
            parcels.Add(parcel2);
            Parcel parcel3 = new Parcel()
            {
                ItemName = "Item3",
                Length = 16,
                Height = 5,
                Width = 8
            };
            parcels.Add(parcel3);
            Parcel parcel4 = new Parcel()
            {
                ItemName = "Item4",
                Length = 16,
                Height = 50,
                Width = 8
            };
            parcels.Add(parcel4);
            return parcels;
        }
    }
}
