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
            var abilityToDriveCalculator = new AbilityToDriveCalculator(new CiderAlcoholMultiplierProvider());

            Console.WriteLine("Drink");
            var numberOfDrinks = double.Parse(Console.ReadLine());
            Console.WriteLine("Crakcers");
            var numberOfCrackers = double.Parse(Console.ReadLine());
            Console.WriteLine("Hours");
            var numberOfHours = double.Parse(Console.ReadLine());

            var shouldIdrive = abilityToDriveCalculator.CalculateIfAbleToDrive(numberOfDrinks, numberOfHours,
                numberOfCrackers);

            Console.WriteLine("Should I drive? " + shouldIdrive);
        }
    }
}
