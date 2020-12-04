using NUnit.Framework;
using UnitTestingCore.Controllers;

namespace NUnitTestProject
{
    public class NunitTest
    {
        private PrimeService _primeService;
        [SetUp]
        public void Setup()
        {
            _primeService = new PrimeService();
        }

        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        //[TestCase(2)]
        public void TestMethod(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.IsFalse(result, $"{value} should not be prime");
        }
    }
}