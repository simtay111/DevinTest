using DevinLearnGood;
using FluentAssertions;
using NUnit.Framework;

namespace DevinLearnGoodTest
{
    [TestFixture]
    public class HorseHayToFeedAmountProviderTests
    {
        private HorseHayToFeedAmountProvider _provider;

        [SetUp]
        public void SetUp()
        {
            _provider = new HorseHayToFeedAmountProvider();
        }

        [Test]
        public void ReturnsZeroForHorsesWithNoBodyWeight()
        {
            var horse = new Horse { WeightInPounds = 0 };

            var leaves = _provider.GetHayForHorse(horse);

            leaves.Should().Be(0);
        }

        [Test]
        public void ReturnsOneLeaveForEveryThirtyPounds()
        {
            var horse = new Horse { WeightInPounds = 61 };

            var leaves = _provider.GetHayForHorse(horse);

            leaves.Should().Be(3);

            new Horse { WeightInPounds = 60 };

            leaves = _provider.GetHayForHorse(horse);

            leaves.Should().Be(2);
        }

        [Test]
        public void ReturnsTwiceAsMuchAsHayForHorsesUnderFour()
        {
            var horse = new Horse { WeightInPounds = 60, Age = 3 };

            var leaves = _provider.GetHayForHorse(horse);

            leaves.Should().Be(4);

            new Horse { WeightInPounds = 60, Age = 4 };

            leaves = _provider.GetHayForHorse(horse);

            leaves.Should().Be(2);
        }
    }
}