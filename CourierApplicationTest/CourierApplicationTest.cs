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
        [TestCase(false)]
        [TestCase(true)]
        public void CanCalculateCost(bool isSpeedyShipping)
        {
            //Arrange
            List<Parcel> parcels = GetParcelData();
            CostCalculator costCalculator = new CostCalculator(parcels);

            //Act
            ParcelCostDetails parcelCostDetails = costCalculator.CalculateCost(isSpeedyShipping);

            //Assert
            Assert.IsNotNull(parcelCostDetails, "Invalid Result");
            Assert.AreEqual(5, parcelCostDetails.Parcels.Count, "Invalid Result");

            Assert.AreEqual(3, parcelCostDetails.Parcels[0].ItemCost, "Invalid Result");
            Assert.AreEqual(ParcelType.SmallParcel, parcelCostDetails.Parcels[0].ParcelType, "Invalid Result");

            Assert.AreEqual(19, parcelCostDetails.Parcels[1].ItemCost, "Invalid Result");
            Assert.AreEqual(ParcelType.LargeParcel, parcelCostDetails.Parcels[1].ParcelType, "Invalid Result");

            Assert.AreEqual(12, parcelCostDetails.Parcels[2].ItemCost, "Invalid Result");
            Assert.AreEqual(ParcelType.MediumParcel, parcelCostDetails.Parcels[2].ParcelType, "Invalid Result");

            Assert.AreEqual(31, parcelCostDetails.Parcels[3].ItemCost, "Invalid Result");
            Assert.AreEqual(ParcelType.ExtraLargeParcel, parcelCostDetails.Parcels[3].ParcelType, "Invalid Result");

            Assert.AreEqual(55, parcelCostDetails.Parcels[4].ItemCost, "Invalid Result");
            Assert.AreEqual(ParcelType.HeavyParcel, parcelCostDetails.Parcels[4].ParcelType, "Invalid Result");

            if (isSpeedyShipping)
            {
                Assert.IsTrue(parcelCostDetails.IsSpeedyShipping, "Invalid Result");
                Assert.AreEqual(240, parcelCostDetails.TotalCost, "Invalid Result");
            }
            else
            {
                Assert.IsFalse(parcelCostDetails.IsSpeedyShipping, "Invalid Result");
                Assert.AreEqual(117, parcelCostDetails.TotalCost, "Invalid Result");
            }
            
        }

        public static List<Parcel> GetParcelData()
        {
            List<Parcel> parcels = new List<Parcel>();

            Parcel parcel1 = new Parcel()
            {
                ItemName = "Item1",
                Length = 6,
                Height = 5,
                Width = 8,
                Weight = 1
            };
            parcels.Add(parcel1);
            Parcel parcel2 = new Parcel()
            {
                ItemName = "Item2",
                Length = 60,
                Height = 56,
                Width = 89,
                Weight = 8
            };
            parcels.Add(parcel2);
            Parcel parcel3 = new Parcel()
            {
                ItemName = "Item3",
                Length = 16,
                Height = 5,
                Width = 8,
                Weight = 5
            };
            parcels.Add(parcel3);
            Parcel parcel4 = new Parcel()
            {
                ItemName = "Item4",
                Length = 160,
                Height = 50,
                Width = 8,
                Weight = 13
            };
            parcels.Add(parcel4);
            Parcel parcel5 = new Parcel()
            {
                ItemName = "Item4",
                Length = 160,
                Height = 50,
                Width = 8,
                Weight = 55
            };
            parcels.Add(parcel5);
            return parcels;
        }
    }
}