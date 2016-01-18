using DevinLearnGood;
using FluentAssertions;
using NUnit.Framework;

namespace DevinLearnGoodTest
{
    [TestFixture]
    public class AbilityToDriveCalculatorTests
    {
        private AbilityToDriveCalculator _calculator;

        [SetUp]
        public void SetUp()
        {
            _calculator = new AbilityToDriveCalculator();
        }

        [Test]
        public void NotAbleToDriveAfterOneBeerPerHour()
        {
            var numberOfBeers = 3;
            var numberOfHours = 3;
            var numberOfCrackers = 0;

            var isAbleToDrive = _calculator.CalculateIfAbleToDrive(numberOfBeers, numberOfHours, numberOfCrackers);

            isAbleToDrive.Should().BeTrue();

            numberOfBeers = 4;
            isAbleToDrive = _calculator.CalculateIfAbleToDrive(numberOfBeers, numberOfHours, numberOfCrackers);

            isAbleToDrive.Should().BeFalse();
        }

        [Test]
        public void EveryTenCrackersAllowsForOneExtraBeer()
        {
            var numberOfBeers = 4;
            var numberOfHours = 3;
            var numberOfCrackers = 9;

            var isAbleToDrive = _calculator.CalculateIfAbleToDrive(numberOfBeers, numberOfHours, numberOfCrackers);

            isAbleToDrive.Should().BeFalse();

            numberOfCrackers = 10;
            isAbleToDrive = _calculator.CalculateIfAbleToDrive(numberOfBeers, numberOfHours, numberOfCrackers);

            isAbleToDrive.Should().BeTrue();
        }

        [Test]
        public void CrackersCanTakeAMaximumOf3BeersAway()
        {
            var numberOfBeers = 5;
            var numberOfHours = 2;
            var numberOfCrackers = 30;

            var isAbleToDrive = _calculator.CalculateIfAbleToDrive(numberOfBeers, numberOfHours, numberOfCrackers);

            isAbleToDrive.Should().BeTrue();


            numberOfCrackers = 40;
            numberOfBeers = 6;
            isAbleToDrive = _calculator.CalculateIfAbleToDrive(numberOfBeers, numberOfHours, numberOfCrackers);

            isAbleToDrive.Should().BeFalse();
        }

        [Test]
        public void OneHundredCrackersEatenWillNegateAllBeer()
        {
            var numberOfBeers = 25;
            var numberOfHours = 1;
            var numberOfCrackers = 99;

            var isAbleToDrive = _calculator.CalculateIfAbleToDrive(numberOfBeers, numberOfHours, numberOfCrackers);

            isAbleToDrive.Should().BeFalse();

            numberOfCrackers = 100;

            isAbleToDrive = _calculator.CalculateIfAbleToDrive(numberOfBeers, numberOfHours, numberOfCrackers);

            isAbleToDrive.Should().BeTrue();
        }
    }
}