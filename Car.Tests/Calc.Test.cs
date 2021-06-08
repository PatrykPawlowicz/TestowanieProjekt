using CarRental;
using NUnit.Framework;

namespace Car.Tests
{
    public class Tests
    {
        Calculator c;
        [OneTimeSetUp]
        public void setUp()
        {
            c = new Calculator();
        }
        [OneTimeTearDown]
        public void tearDown()
        {
            c = null;
        }
        [TestCase(50000.00, 3, 1500, 150, 1368.75)]
        [TestCase(1, 1, 1, 1, 0.000475)]
        [TestCase(100000.00, 5, 2300, 230, 3007.25)]
        public void calcCarValueShouldSuccess(double value, double years, double volume, double hp, double expected)
        {
            double calcValue = c.calcCarValue(value, years, volume, hp);
            
            Assert.That(calcValue, Is.EqualTo(expected));
        }
        [TestCase(30, 12, 0.84)]
        [TestCase(45, 25, 0.3)]
        [TestCase(50, 10, 0.7)]
        public void calcDriverModShouldSuccess(double age, double driverLicence, double expected)
        {
            double value = c.calcDriverMod(age, driverLicence);
            Assert.That(value, Is.EqualTo(expected));
        }
        [TestCase(50000.00, 3, 1500, 150, 30, 12, 1149.75)]
        [TestCase(100000.00, 5, 2300, 230, 50, 10, 2105.075)]
        public void calcResultShouldSuccess(double value, double years, double volume, double hp, double age, double driverLicence, double expected)
        {
           double result =  c.calcResult(value, years, volume, hp, age, driverLicence);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}