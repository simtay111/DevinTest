using DevinLearnGood;
using FluentAssertions;
using NUnit.Framework;

namespace DevinLearnGoodTest
{
    [TestFixture]
    public class WineAlcoholProviderTests
    {
        private WineAlcoholMultiplierProvider _provider;

        [SetUp]
        public void SetUp()
        {
            _provider = new WineAlcoholMultiplierProvider();
        }

        [Test]
        public void GetsCorrectAmountForWine()
        {
            _provider.GetMultiplier().Should().Be(1.5);
        }
    }
}