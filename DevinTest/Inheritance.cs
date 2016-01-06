using System.Collections.Generic;

namespace DevinTest
{
    public class Animal
    {
        public string Color { get; set; }
        public string Name { get; set; }
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
    }

    public class Lion : Animal
    {
        public int ZebrasEaten { get; set; }
    }

    public class Zoo
    {
        public void GetCOuntOfANimal()
        {
            var animals = new List<Animal>();

            var zebra1 = new Zebra("Black", "Zeby", 44);


            var zebra2 = new Zebra("Black", "Name", 55);
            var lion = new Lion();

            animals.Add(zebra1);
            animals.Add(zebra2);
            animals.Add(lion);

            //animals length is 3
            lion.Name = "Simon";

            var integerList = new List<int> { 2, 3, 4 };
            integerList.Add(23);
            //integerList.Add("23");


        }
    }

    public class GenericList<T>
    {
        public void Add(T item)
        {

        }
    }


}