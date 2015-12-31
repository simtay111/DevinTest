using System;
using NUnit.Framework;


namespace DevinTest
{

    public class Person
    {
        public string SurName { get; set; }
        public Person()
        {
            SurName = "Unknown";

        }


    }
    public class PersonTest
    {
        [SetUp]
        public void setup()
        {
            Console.WriteLine("Starting Up");
        }
        [Test]
        public void PersondefaultsToUnknownName()

        {
            var myPerson = new Person();

            Assert.AreEqual("Unknown", myPerson.SurName);
        }
    }


}