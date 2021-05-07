using CourierCostCalculator;
using NUnit.Framework;
using System.Collections.Generic;

namespace CourierApplicationTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        
        [Test]
        public void CanCalculateCost()
        {
            //Arrange
            List<Parcel> parcels = GetParcelData();
            CostCalculator costCalculator = new CostCalculator(parcels);

            //Act
            ParcelCostDetails parcelCostDetails = costCalculator.CalculateCost();

            //Assert
            Assert.IsNotNull(parcelCostDetails, "Invalid Result");
            Assert.AreEqual(4, parcelCostDetails.Parcels.Count, "Invalid Result");

            Assert.AreEqual(3, parcelCostDetails.Parcels[0].ItemCost, "Invalid Result");
            Assert.AreEqual(ParcelType.SmallParcel, parcelCostDetails.Parcels[0].ParcelType, "Invalid Result");

            Assert.AreEqual(15, parcelCostDetails.Parcels[1].ItemCost, "Invalid Result");
            Assert.AreEqual(ParcelType.LargeParcel, parcelCostDetails.Parcels[1].ParcelType, "Invalid Result");

            Assert.AreEqual(8, parcelCostDetails.Parcels[2].ItemCost, "Invalid Result");
            Assert.AreEqual(ParcelType.MediumParcel, parcelCostDetails.Parcels[2].ParcelType, "Invalid Result");

            Assert.AreEqual(25, parcelCostDetails.Parcels[3].ItemCost, "Invalid Result");
            Assert.AreEqual(ParcelType.ExtraLargeParcel, parcelCostDetails.Parcels[3].ParcelType, "Invalid Result");
        }

        public static List<Parcel> GetParcelData()
        {
            List<Parcel> parcels = new List<Parcel>();

            Parcel parcel1 = new Parcel()
            {
                ItemName = "Item1",
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
                Length = 160,
                Height = 50,
                Width = 8
            };
            parcels.Add(parcel4);
            return parcels;
        }
    }
}