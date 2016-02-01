using DevinLearnGood;
using FluentAssertions;
using NUnit.Framework;

namespace DevinLearnGoodTest
{
    [TestFixture]
    public class UncleBobBowlingTests
    {
        private UncleBobBowling _bowlingGame;

        [SetUp]
        public void SetUp()
        {
            _bowlingGame = new UncleBobBowling();
        }

        [Test]
        public void RollAllZeros()
        {
            RollMany(20, 0);

            _bowlingGame.Score().Should().Be(0);
        }
        [Test]
        public void RollAllOnes()
        {
            RollMany(20, 1);

            _bowlingGame.Score().Should().Be(20);
        }

        [Test]
        public void OneSpare()
        {
            _bowlingGame.Roll(5);
            _bowlingGame.Roll(5);
            _bowlingGame.Roll(3);
            RollMany(17, 0);

            _bowlingGame.Score().Should().Be(16);
        }

        private void RollMany(int numberOfRolls, int pins)
        {
            for (int i = 0; i < numberOfRolls; i++)
            {
                _bowlingGame.Roll(pins);
            }

        }
    }
}