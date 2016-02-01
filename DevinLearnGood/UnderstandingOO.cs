using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevinLearnGood
{
    class UnderstandingOO
    {
        static void Main()
        {
            Auto myCar = new Auto();
            myCar.Speed = 0;
            myCar.Maker = "Oldsmobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1988;
            myCar.Color = "Silver";
            myCar.Miles = 50000;

            Console.WriteLine(myCar.Maker + " " + myCar.Model);

            int myCurrentSpeed = 0;
            myCurrentSpeed = myCar.Accelerate(3);
            Console.WriteLine(myCar.Maker + " " + myCurrentSpeed);

            myCar.Accelerate(5);
            myCar.Accelerate(6);
            myCar.Accelerate(2);
            myCar.Accelerate(10);

            string message = myCar.SpeedLimitViolation("Warning: ", 20);
            Console.WriteLine(message);

            myCurrentSpeed = myCar.Decelerate(5);
            Console.WriteLine("My current Speed: " + myCurrentSpeed);

            Console.ReadLine();
        }
    }
}
