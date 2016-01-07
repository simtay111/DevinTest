using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace DevinTest
{
    public class Animal
    {
        public string Color { get; set; }
        public string Name { get; set; }

        public virtual void MakeSound()
        {
            Console.WriteLine("Grunt from " + Name);
        }

        public void EatFood()
        {

        }
    }

    public class Zebra : Animal
    {
        public Zebra(string color, string name, int numberOfStripe)
        {
            Color = color;
            Name = name;
            NumberOfStripes = numberOfStripe;
        }

        public int NumberOfStripes { get; set; }

        public override void MakeSound()
        {
            Console.WriteLine("Neight from " + Name);
        }

    }

    public class Lion : Animal
    {
        public int ZebrasEaten { get; set; }

        public override string ToString()
        {
            return "I am a lion" + Name;
        }
    }

    public class ScreamingLion : Lion
    {
        public override void MakeSound()
        {
            Console.WriteLine("I am a screaming lion");
        }
    }

    public class Zoo
    {
        [Test]
        public void GetCOuntOfANimal()
        {
            var animals = new List<Animal>();

            var zebra1 = new Zebra("Black", "Zeby", 44);
            var zebra2 = new Zebra("Black", "Zeby2", 55);
            var lion = new Lion() { Name = "Lioner" };

            animals.Add(zebra1);
            animals.Add(zebra2);
            animals.Add(lion);
            animals.Add(new ScreamingLion());

            foreach (var animal in animals)
            {
                animal.MakeSound();
            }


        }

        [Test]
        public void ToStringTest()
        {
            var zebra = new Lion();

            Console.WriteLine(zebra.ToString());

        }
    }

    public class GenericList<T>
    {
        public void Add(T item)
        {

        }
    }


}