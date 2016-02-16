//using System;
//using System.Runtime.InteropServices;
//using System.Security.Cryptography;
//using DevinLearnGood;
//using FluentAssertions;
//using NUnit.Framework;

//namespace DevinLearnGoodTest
//{
//    [TestFixture]
//    public class MyRandomNumberGeneratorTests
//    {
//        private MyRandomNumberGenerator _generator;

//        [SetUp]
//        public void SetUp()
//        {
//            _generator = new MyRandomNumberGenerator(new Random());
//        }

//        [Test]
//        public void CreatesNumberBetween1000And1Million()
//        {
//            for (int i = 0; i < 100000; i++)
//            {
//                var result = _generator.GenerateRandomNumber();

//                result.Should().BeGreaterThan(1000);
//                result.Should().BeLessThan(1000000000);
//            }
//        }

//        [Test]
//        public void AtLeastOneNumberIsOver1Million()
//        {
//            var weHadANumberOfOver1Million = false;
//            for (int i = 0; i < 100000; i++)
//            {
//                var result = _generator.GenerateRandomNumber();

//                if (result > 1000000)
//                    weHadANumberOfOver1Million = true;
//            }

//            weHadANumberOfOver1Million.Should().BeTrue();
//        }
//    }
//}