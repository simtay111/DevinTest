using DevinLearnGood;
using FluentAssertions;
using NUnit.Framework;

namespace DevinLearnGoodTest
{
    [TestFixture]
    public class DevinCounterTests
    {
        private DrinkCounter _counter = new DrinkCounter();

        [SetUp]
        public void Setup()
        {
            

        }

        [Test]
        public void CanReturnNumberOfDrinksConsumed()
        {
            //Arrange
            _counter = new DrinkCounter();
            _counter.EnjoyBeverage();
            _counter.EnjoyBeverage();

            //ACt
            var returnedNumberOfDrinks = _counter.GetDrinksEnjoyed();

            //Assert
            returnedNumberOfDrinks.Should().Be(2);
        }
    }
}