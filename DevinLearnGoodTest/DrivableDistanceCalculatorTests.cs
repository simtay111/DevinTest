using DevinLearnGood;
using FluentAssertions;
using Moq;
using NUnit.Framework;

namespace DevinLearnGoodTest
{
    [TestFixture]
    public class DrivableDistanceCalculatorTests
    {
        private DrivableDistanceCalculator _calculator;
        private Mock<IProvideMilesPerGallon> _mockedMpgProvider;

        [SetUp]
        public void Setup()
        {
            _mockedMpgProvider = new Mock<IProvideMilesPerGallon>();
            _calculator = new DrivableDistanceCalculator(_mockedMpgProvider.Object);
        }

        [Test]
        public void CanGetMilesBasedOnMpgAndGallonsProvided()
        {
            _mockedMpgProvider.Setup(x => x.GetMilesPerGallon()).Returns(5);

            var result = _calculator.HowManyMilesCanIgetWithProvidedGallonsOfGas(20);

            result.Should().Be(100);

        }
    }
}