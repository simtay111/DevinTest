using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevinLearnGood
{
    public class FizzBuzz
    {
        public List<string> FizzBuzzer()
        {
            List<string> fizzBuzzList = new List<string>();

            for (int i = 1; i < 101; i++)
            {
                var defaultValue = i.ToString();

                
                if (i % 3 == 0)
                    defaultValue = "Fizz";
                if (i % 5 == 0)
                    defaultValue = "Buzz";
                if (i % 3 == 0 && i % 5 == 0)
                    defaultValue = "FizzBuzz";



                fizzBuzzList.Add(defaultValue);
            }

            return fizzBuzzList;
        }
    }
}





















































//public void DoFizzBuzz()
//{
//    for (int i = 1; i <= 100; i++)
//    {
//        bool fizz = i % 3 == 0;
//        bool buzz = i % 5 == 0;
//        if (fizz && buzz)
//            Console.WriteLine("FizzBuzz");
//        else if (fizz)
//            Console.WriteLine("Fizz");
//        else if (buzz)
//            Console.WriteLine("Buzz");
//        else
//            Console.WriteLine(i);
//    }
//}