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
        public void SaysFizzIfItsDivisibleByThree()
        {
            int input = 9;

            string result = _fizzbuzz.FizzBuzzer(input);

            result.Should().Be("Fizz");

            Console.WriteLine(result);
        }

        [Test]
        public void SaysBuzzIfItsDivisibleByFive()
        {
            //nerp
        }

        [Test]
        public void SaysFizzAndBuzzIfItsDivisibleByThreeAndFive()
        {
            //herp
        }
    }
}
