using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevinLearnGood;
using NUnit.Framework;
using FluentAssertions;

namespace DevinLearnGoodTest
{
    [TestFixture]
    public class FizzBuzzTests
    {
        private FizzBuzz _fizzbuzz = new FizzBuzz();

        [SetUp]
        public void Setup()
        {
            _fizzbuzz = new FizzBuzz();
        }

        [Test]
        public void TextForDivisibleByThreeIsFizz()
        {
            var resultingOutput = _fizzbuzz.FizzBuzzer();

            resultingOutput[0].Should().Be("1");
            resultingOutput[1].Should().Be("2");
            resultingOutput[2].Should().Be("Fizz");
        }

        [Test]
        public void TextForDivisibleByFiveIsBuzz()
        {
            var resultingOutput = _fizzbuzz.FizzBuzzer();

            resultingOutput[3].Should().Be("4");
            resultingOutput[4].Should().Be("Buzz");
            resultingOutput[9].Should().Be("Buzz");
        }

        [Test]
        public void TextForDivisibleByThreeAndFiveIsFizzBuzz()
        {
            var resultingOutput = _fizzbuzz.FizzBuzzer();

            resultingOutput[14].Should().Be("FizzBuzz");
            resultingOutput[29].Should().Be("FizzBuzz");
            resultingOutput[44].Should().Be("FizzBuzz");
        }
    }
}
