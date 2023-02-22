using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary.Tests
{
    [TestClass()]
    public class CarTests
    {
        Car car = new Car() { Model = "Mercedes", ID = 1, LicensePlate = "BA55368", Price = 10000 };
        Car carModelUnder4 = new Car() { Model = "Kia", ID = 1, LicensePlate = "BA55368", Price = 10000};
        Car carPriceUnder0 = new Car() { Model = "Mercedes", ID = 3, LicensePlate = "OK34934", Price = -100 };
        Car carLicensePlateOver = new Car() { Model = "Mercedes", ID = 3, LicensePlate = "OB334350", Price = 10000 };
        Car carLicensePlateUnder = new Car() { Model = "Mercedes", ID = 3, LicensePlate = "0", Price = 10000 };

        [TestMethod()]
        public void ValidateModelTest()
        {
            car.ValidateModel();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => carModelUnder4.ValidateModel());
        }
        [TestMethod()]
        public void ValidatePriceTest()
        {
            car.ValidatePrice();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => carPriceUnder0.ValidatePrice());

        }
        [TestMethod()]
        public void ValidateLicensePlateTest()
        {
            car.ValidateLicensePlate();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => carLicensePlateOver.ValidateLicensePlate());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => carLicensePlateUnder.ValidateLicensePlate());

        }
    }
}