using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevinLearnGood;

namespace ShouldIDrive
{
    class Program
    {
        static void Main(string[] args)
        {
            var animalIntroducer = new AnimalIntroducer();

            var myCat = new Cat();
            var myDog = new Dog();

            animalIntroducer.IntroduceAnimal(myDog);
            animalIntroducer.IntroduceAnimal(myCat);
        }
    }

    public interface IAnimalThatMakesSound
    {
        string GetSound();
    }

    public class GenericAnimal
    {
        public void Walk(int numberOfSteps)
        {

        }

    }

    public class Dog : GenericAnimal, IAnimalThatMakesSound
    {
        public int NumberOfTennisBallsEaten { get; set; }

        public string GetSound()
        {
            return "Woof";
        }
    }

    public class Cat : GenericAnimal, IAnimalThatMakesSound
    {
        public int NumberOfLives { get; set; }

        public string GetSound()
        {
            return "Meow";
        }
    }

    public class AnimalIntroducer
    {
        public void IntroduceAnimal(IAnimalThatMakesSound animalThatMakesSound)
        {
            Console.WriteLine("This animal makes the sound: " + animalThatMakesSound.GetSound());
        }
    }


}
