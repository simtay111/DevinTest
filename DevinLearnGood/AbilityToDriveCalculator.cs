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
            var beersNegatedByCrackers = GetBeersNEgatedByCrackers(numberOfCrackers);

            var actualBeerToHourRatio = GetBeersToHoursRatio(numberOfBeersDrankTotal, numberOfHours, beersNegatedByCrackers);

            var isBeerRatioOverLimit = actualBeerToHourRatio > BeerToHourRatioLimit;

            return !isBeerRatioOverLimit;
        }

        private static double GetBeersToHoursRatio(double numberOfBeersDrankTotal, double numberOfHours,
            double beersNegatedByCrackers)
        {
            var totalNumberOfAffectingBeers = (numberOfBeersDrankTotal - beersNegatedByCrackers);

            var beersToHoursRatio = (totalNumberOfAffectingBeers / numberOfHours);
            return beersToHoursRatio;
        }

        private double GetBeersNEgatedByCrackers(double numberOfCrackers)
        {
            var beersNegatedByCrackers = Math.Floor(numberOfCrackers / NumberOfCrackersToNegateABeer);

            var crackersHaveMaxedOutHelpingBloodAlcoholContent = beersNegatedByCrackers >= MaxNumberOfBeersCrackersCanReduce;

            beersNegatedByCrackers = crackersHaveMaxedOutHelpingBloodAlcoholContent ? MaxNumberOfBeersCrackersCanReduce : beersNegatedByCrackers;

            return beersNegatedByCrackers;
        }
    }
}