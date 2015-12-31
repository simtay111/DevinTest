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

        public Person(string name)
        {
            SurName = name;
        }

        public string GetIntroduction()
        {
            return "Hello, my name is Bill";
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

        [Test]
        public void CanCreateWithSpecificName()
        {
            var myNamedPerson = new Person("Bill");
            var my2NamedPerson = new Person("Bob");

            Assert.AreEqual("Bill", myNamedPerson.SurName);
            Console.WriteLine(myNamedPerson.SurName);
            Console.WriteLine(my2NamedPerson.SurName);
        }

        [Test]
        public void PersonCanIntroduceThemselves()
        {
            var myNamedPerson = new Person("Bill");

            var resultingIntroducation = myNamedPerson.GetIntroduction();

            Console.WriteLine(resultingIntroducation);

            Assert.AreEqual("Hello, my name is Bill", resultingIntroducation);
            //if ("Hello, my name is Bill" != resultingIntroducation)
            //throw new Exception("You Suck");
        }
    }


}