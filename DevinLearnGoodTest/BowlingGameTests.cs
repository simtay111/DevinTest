using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DevinLearnGood;
using FluentAssertions;
using NUnit.Framework;

namespace DevinLearnGoodTest
{
    [TestFixture]
    public class BowlingGameTests
    {
        private BowlingGame _bowling = new BowlingGame();

        [SetUp]
        public void Setup()
        {
            _bowling = new BowlingGame();
        }

        private void RollMany(int n, int pins)
        {
            for (int i = 0; i < n; i++)
            {
                _bowling.Roll(pins);
            }
        }

        [Test]
        public void ScoresCorrectlyForGutterGame()
        {
            RollMany(20, 0);
            _bowling.Score().Should().Be(0);
        }

        [Test]
        public void ScoresCorrectlyForAllOnes()
        {
            RollMany(20, 1);
            _bowling.Score().Should().Be(20);
        }

        [Test]
        public void ScoresCorrectlyForOneSpare()
        {
            rollSpare();
            _bowling.Roll(3);
            RollMany(17, 0);
            _bowling.Score().Should().Be(16);
        }

        private void rollSpare()
        {
            _bowling.Roll(5);
            _bowling.Roll(5);
        }

        [Test]
        public void ScoresCorrectlyForOneStrike()
        {
            _bowling.Roll(10);
            _bowling.Roll(3);
            _bowling.Roll(4);
            RollMany(16, 0);
            _bowling.Score().Should().Be(24);
        }

        [Test]
        public void ScoresCorrectlyForAllStrikes()
        {
            RollMany(12, 10);
            _bowling.Score().Should().Be(300);
        }
    }
}
