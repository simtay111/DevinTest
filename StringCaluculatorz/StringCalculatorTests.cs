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
        public void AnEmptyStringReturnsZero()
        {
            var input = "";

            var result = _calculator.Calculator(input);

            result.Should().Be(0);
        }

        [Test]
        public void ASingleNumberReturnsTheValue()
        {
            var input = "9";

            var result = _calculator.Calculator(input);

            result.Should().Be(9);
        }

        [Test]
        public void TwoNumbersCommaDelimitedReturnsTheSum()
        {
            var input = "1,2";

            var result = _calculator.Calculator(input);

            result.Should().Be(3);
        }

        [Test]
        public void TwoNumbersNewLineDelimitedReturnsTheSum()
        {
            var input = "1\n2";

            var result = _calculator.Calculator(input);

            result.Should().Be(3);
        }

        [Test]
        public void ThreeNumbersDelimitedEitherWayReturnTheSum()
        {
            var input = "1,2,3\n4";

            var result = _calculator.Calculator(input);

            result.Should().Be(10);
        }

        [Test]
        public void NegativeNumbersThrowException()
        {
            var input = "1,2,3,-4";

            Assert.Throws<FormatException>(() => _calculator.Calculator(input));
        }

        [Test]
        public void NumbersOverOneThousandAreIgnoredxorz()
        {
            var input = "1,2,3\n4,1004";

            var result = _calculator.Calculator(input);

            result.Should().Be(10);
        }
    }
}