using NUnit.Framework;
using System;

namespace DevinTest
{
    public class SetupExample
    {
        public SetupExample()
        {
        


        }
    }

    [TestFixture]
    public class SetupExampleTests
    {
        private int MyNumber = 0;

        [SetUp]
        public void setup()
        {
            Console.WriteLine("In Setup lol");
            MyNumber = 9;

        }

        [Test]
        public void ShouldFireIfBaconIsInvolved()
        {
            MyNumber++;
            Console.WriteLine("Within Test lol" + MyNumber);

        }
        [Test]
        public void ShouldFireIfBaconIsInvolved2()
        {
            MyNumber++;
            Console.WriteLine("Within Test2 lol" + MyNumber);

        }
    }
}