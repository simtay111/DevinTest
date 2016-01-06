using System;
using System.Net.NetworkInformation;
using System.Threading;
using NUnit.Framework;

namespace DevinTest
{
    public class Statics
    {
        public static Statics Now { get { return new Statics(); } }

        public static void TheStaticMethod()
        {
            Console.WriteLine("Static Method");
        }

        public void NonStaticMethod()
        {
            Console.WriteLine("Non Static Method");
        }
    }

    [TestFixture]
    public class StaticsTest
    {
        [Test]
        public void FirstTest()
        {
            var newDateTime = new DateTime(2000, 1, 1);

            var staticlyMade = DateTime.Now;
            var timeCreated1 = DateTime.UtcNow;
            Thread.Sleep(2000);
            var timeCreated2 = DateTime.UtcNow;
            Thread.Sleep(2000);
            var timeCreated3 = DateTime.UtcNow;
            Thread.Sleep(2000);
            var timeCreated4 = DateTime.UtcNow;
            Thread.Sleep(2000);

            var staticlyMadeInstanceOfStatics = Statics.Now;

            Console.WriteLine(timeCreated1);
            Console.WriteLine(timeCreated2);
            Console.WriteLine(timeCreated3);
            Console.WriteLine(timeCreated4);
        }
    }
}