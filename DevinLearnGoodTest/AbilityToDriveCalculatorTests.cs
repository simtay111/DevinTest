using System;
using DevinLearnGood;
using FluentAssertions;
using Moq;
using NUnit.Framework;

namespace DevinLearnGoodTest
{
    [TestFixture]
    public class AbilityToDriveCalculatorTests
    {
        private AbilityToDriveCalculator _calculator;
        private MockedAlcoholProvider _alcoholProvider;

        [SetUp]
        public void SetUp()
        {
            _alcoholProvider = new MockedAlcoholProvider();
            _alcoholProvider.SetupProviderToReturnMultipler(1);
            _calculator = new AbilityToDriveCalculator(_alcoholProvider);
        }

        [Test]
        public void AccountsForAlcoholMultiplierWhenCountingDrinksDrank()
        {
            _alcoholProvider.SetupProviderToReturnMultipler(2);

            _calculator.CalculateIfAbleToDrive(1, 3, 0).Should().BeTrue();
            _calculator.CalculateIfAbleToDrive(2, 3, 0).Should().BeFalse();
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
