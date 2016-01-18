using System;
using System.Security.Cryptography.X509Certificates;

namespace DevinLearnGood
{
    public class AbilityToDriveCalculator
    {
        private const int BeerToHourRatioLimit = 1;
        private const int NumberOfCrackersToNegateABeer = 10;
        private const int MaxNumberOfBeersCrackersCanReduce = 3;

        public bool CalculateIfAbleToDrive(double numberOfBeersDrankTotal, double numberOfHours, double numberOfCrackers)
        {
            var numberOfBeersCrackersHelpedNegate = Math.Floor(numberOfCrackers / NumberOfCrackersToNegateABeer);

            var isBeerRatioOverTheLimit = ((numberOfBeersDrankTotal - numberOfBeersCrackersHelpedNegate) / numberOfHours <= BeerToHourRatioLimit);

            



            return isBeerRatioOverTheLimit;



        }
    }
}