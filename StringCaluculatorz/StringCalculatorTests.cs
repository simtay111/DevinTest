using System;
using FluentAssertions;
using NUnit.Framework;

namespace StringCaluculatorz
{
    [TestFixture]
    public class StringCalculatorTests
    {
        private StringCalculator _calculator = new StringCalculator();

        [SetUp]
        public void Setup()
        {
            _calculator = new StringCalculator();
        }

        [Test]
        public void AnEmptyStringReturnsZero()
        {
            var input = "";

            int result = _calculator.Calculate(input);

            result.Should().Be(0);
        }
        [Test]
        public void ASingleNumberReturnsTheValue()
        {
            var input = "42";

            int result = _calculator.Calculate(input);

            result.Should().Be(42);
        }

        [Test]
        public void TwoNumbersCommaDelimitedReturnsTheSum()
        {
            var input = "9,42";

            int result = _calculator.Calculate(input);

            result.Should().Be(51);
        }


        [Test]
        public void TwoNumbersNewLineDelimitedReturnsTheSum()
        {
            var input = "1\n9";

            int result = _calculator.Calculate(input);

            result.Should().Be(10);
        }

        [Test]
        public void ThreeNumbersDelimitedEitherWayReturnTheSum()
        {
            var input = "1,4\n42";

            int result = _calculator.Calculate(input);
            
            result.Should().Be(47);
        }

        [Test]
        public void NegativeNumbersThrowException()
        {
            var input = "1,-3,4,7";

            Assert.Throws<FormatException>(() => _calculator.Calculate(input));
        }

        [Test]
        public void NumbersOverOneThousandAreIgnoredxorz()
        {
            var input = "9001,2,56,101,42,1000";

            var result = _calculator.Calculate(input);

            result.Should().Be(1201);
        }
    }
}