using DevinLearnGood;
using FluentAssertions;
using NUnit.Framework;

namespace DevinLearnGoodTest
{
    [TestFixture]
    public class HorseHayQualityProviderTests
    {
        private HorseHayQualityProvider _provider;

        [SetUp]
        public void SetUp()
        {
            _provider = new HorseHayQualityProvider();
        }

        [Test]
        public void ReturnsPoorForHayThatIsUnder50Green()
        {
            var quality = _provider.GetQualityBasedOnGreenness(49);

            quality.Should().Be(HayQuality.Poor);

            quality = _provider.GetQualityBasedOnGreenness(50);

            quality.Should().Be(HayQuality.Average);
        }

        [Test]
        public void ReturnsAverageForNumbersBetween()
        {
            var quality = _provider.GetQualityBasedOnGreenness(79);

            quality.Should().Be(HayQuality.Average);

            quality = _provider.GetQualityBasedOnGreenness(80);

            quality.Should().Be(HayQuality.Good);
        }

        [Test]
        public void ReturnsAverageForNumbersBetweenEightyAndEightyNine()
        {
            var quality = _provider.GetQualityBasedOnGreenness(89);

            quality.Should().Be(HayQuality.Good);

            quality = _provider.GetQualityBasedOnGreenness(90);

            quality.Should().Be(HayQuality.Excellent);
        }

        [Test]
        public void ReturnsAverageForNumbersAboveNinety()
        {
            var quality = _provider.GetQualityBasedOnGreenness(90);

            quality.Should().Be(HayQuality.Excellent);

            quality = _provider.GetQualityBasedOnGreenness(10230);

            quality.Should().Be(HayQuality.Excellent);
        }
    }
}