using DevinLearnGood;
using FluentAssertions;
using NUnit.Framework;

namespace DevinLearnGoodTest
{
    [TestFixture]
    public class BeerAlcoholProviderTests
    {
        private BeerAlcoholMultiplierProvider _provider;

        [SetUp]
        public void SetUp()
        {
            _provider = new BeerAlcoholMultiplierProvider();
        }

        [Test]
        public void GetsCorrectAmountForWine()
        {
            _provider.GetMultiplier().Should().Be(1);
        }
    }
}