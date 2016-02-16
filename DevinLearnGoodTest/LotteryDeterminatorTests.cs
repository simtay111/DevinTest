using System;
using DevinLearnGood;
using FluentAssertions;
using Moq;
using NUnit.Framework;

namespace DevinLearnGoodTest
{
    [TestFixture]
    public class LotteryDeterminatorTests
    {
        private LotteryDeterminator _determinator;
        private Mock<ICanGenerateRandomNumbers> _mockRandomNumberGenerator;

        [SetUp]
        public void SetUp()
        {
            _mockRandomNumberGenerator = new Mock<ICanGenerateRandomNumbers>();
            _determinator = new LotteryDeterminator(_mockRandomNumberGenerator.Object);
        }

        [Test]
        public void IsWinnerIfNumberIsUnder1HundredThousand()
        {
            _mockRandomNumberGenerator.Setup(x => x.GenerateRandomNumber()).Returns(99999);

                var isWinner = _determinator.Bet();

            isWinner.Should().BeTrue();
        }

        [Test]
        public void IsWinnerIfNumberIsOn1HundredThousand()
        {
            _mockRandomNumberGenerator.Setup(x => x.GenerateRandomNumber()).Returns(100000);

            var isWinner = _determinator.Bet();

            isWinner.Should().BeTrue();
        }

        [Test]
        public void IsLoserIfNumberIsOver1HundredThousand()
        {

            _mockRandomNumberGenerator.Setup(x => x.GenerateRandomNumber()).Returns(142000);

            var isWinner = _determinator.Bet();

            isWinner.Should().BeFalse();
        }
    }
}