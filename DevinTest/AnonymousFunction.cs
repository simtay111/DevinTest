using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DevinTest
{
    [TestFixture]
    class AnonymousFunction
    {
        [Test]
        public void FirstTest()
        {
        var alertCompleteFunction = new Action<int>((int x) =>
            {
                Console.WriteLine("All DOne!!!" + x);
                
            });

            CalculateSpeedOfLight(alertCompleteFunction);

        }

        private void CalculateSpeedOfLight(Action<int> alertCompleteFunction)
        {
            Console.WriteLine("Step 1");
            Thread.Sleep(1000);
            Console.WriteLine("Step 2");
            Thread.Sleep(1000);
            Console.WriteLine("Step 3");
            alertCompleteFunction(3000);
        }
    }
  
}
