using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace DevinTest
{
    public class LinqSelect
    {
        public List<string> GetSounds(List<Animal> animals)
        {
            //return animals.Select(animal => "Hello, my name is " + animal.Name + ". I am " + animal.Color).ToList();
            var string1 = "Bork";
            var string2 = "Bork";


            return animals.OrderBy(x => x.Color).Select(animal => "Hello, my name is " + animal.Name + ". I am " + animal.Color).ToList();
        }
    }

    public class LinqSelectTest
    {
        [Test]
        public void LinqSelectTestTest()
        {
            var classToTest = new LinqSelect();
            var zebra = new Zebra("Green", "Zeby1", 3);
            var zebra2 = new Zebra("Blue", "Zeby2", 3);
            var zebra3 = new Zebra("Red", "Zeby3", 3);

            var animalsWithSounds = classToTest.GetSounds(new List<Animal> { zebra, zebra2, zebra3 });

            foreach (var intro in animalsWithSounds)
            {
                Console.WriteLine(intro);
            }
        }
    }
}