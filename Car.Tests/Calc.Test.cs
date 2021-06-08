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
        [TestCase()]
        public void calcCarValueShouldSuccess(double value, int years, int volume, int hp)
        {
            double calcValue = c.calcCarValue(value, years, volume, hp);
            double expected = 1372.5;
            Assert.AreEqual(value, expected);
        }
        [Test]
        public void calcDriverModShouldSuccess()
        {
            double value = c.calcDriverMod(1, 1, 1, 1);
            double expected = 1372.5;
            Assert.That(value, Is.EqualTo(expected));
        }
    }
}