using System;
using System.Collections.Generic;

namespace DevinLearnGood
{
    public abstract class AbstractEmployee
    {
        public string Name { get; set; }

        public string IntroduceSelf()
        {
            return "My name is " + Name;
        }

        public abstract string Speak(string stringToSay);
    }

    public class EnglishEmployee : AbstractEmployee
    {
        public override string Speak(string stringToSay)
        {
            return stringToSay;
        }
    }

    public class FrenchEmployee : AbstractEmployee
    {
        public override string Speak(string stringToSay)
        {
            return stringToSay + "French";
        }
    }

    public class AbstractEmployyeTest
    {
        public void Test()
        {
            var englishEmployee = new EnglishEmployee();
            englishEmployee.Name = "Bob";
            var frenchEmployee = new FrenchEmployee();
            frenchEmployee.Name = "WeWe";

            var listOfTheEmployees = new List<AbstractEmployee>();
            listOfTheEmployees.Add(englishEmployee);
            listOfTheEmployees.Add(frenchEmployee);

            foreach (var employee in listOfTheEmployees)
            {
                Console.WriteLine(employee.IntroduceSelf());
                Console.WriteLine(employee.Speak("Hola"));
            }
        }
    }
}