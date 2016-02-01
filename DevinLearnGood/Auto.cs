using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevinLearnGood
{
    class Auto
    {
        
        public string Model;
        public int Year;
        public string Color;
        public int Miles;
        public int Speed;
        public string make;

        public string Maker
        {
            get { return make; }
            set { make = value; }
        }



        public int Accelerate(int increasedSpeed)
        {
            Speed += increasedSpeed;
            //Console.WriteLine("Current speed: " + Speed.ToString());
            return Speed;
        }

        public int Decelerate(int decreasedSpeed)
        {
            Speed -= decreasedSpeed;
            //Console.WriteLine("Current speed: " + Speed.ToString());
            return Speed;
        }

        public string SpeedLimitViolation(string initialMessage, int speedLimit)
        {
            string message = "";

            if (Speed > speedLimit)
                message = "Too fast";
            else
                message = "You're OK";
            return initialMessage + " " + message;
        }

    }
}
