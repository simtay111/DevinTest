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
            var horse = new Horse { WeightInPounds = 61, Age = 5 };

            var leaves = _provider.GetHayForHorse(horse);

            leaves.Should().Be(3);

            horse.WeightInPounds = 60;

            leaves = _provider.GetHayForHorse(horse);

            leaves.Should().Be(2);
        }

        [Test]
        public void ReturnsTwiceAsMuchAsHayForHorsesUnderFour()
        {
            var horse = new Horse { WeightInPounds = 60, Age = 3 };

            var leaves = _provider.GetHayForHorse(horse);

            leaves.Should().Be(4);

            horse = new Horse { WeightInPounds = 60, Age = 4 };

            leaves = _provider.GetHayForHorse(horse);

            leaves.Should().Be(2);
        }

        [Test]
        public void UnderageDoublesTheRoundedAdultAmountOfLeaves()
        {
            var horse = new Horse { WeightInPounds = 45, Age = 2 };

            var leaves = _provider.GetHayForHorse(horse);

            leaves.Should().Be(4);
        }
    }
}