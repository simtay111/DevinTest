using System;

namespace DevinLearnGood
{
    public class AbilityToDriveCalculator
    {
        private readonly IAlcoholMultiplierProvider _alcoholMultiplierProvider;

        public AbilityToDriveCalculator(IAlcoholMultiplierProvider alcoholMultiplierProvider)
        {
            _alcoholMultiplierProvider = alcoholMultiplierProvider;
        }

        private const int BeerToHourRatioLimit = 1;
        private const int NumberOfCrackersToNegateABeer = 10;
        private const int MaxNumberOfBeersCrackersCanReduce = 3;

        public bool CalculateIfAbleToDrive(double numberOfBeersDrankTotal, double numberOfHours, double numberOfCrackers)
        {
            var numberOfDrinksDrank = numberOfBeersDrankTotal * _alcoholMultiplierProvider.GetMultiplier();

            var numberOfAffectingBeers = GetCountOfBeersDrankThatAffectRatio(numberOfDrinksDrank, numberOfCrackers);

            var actualRatioOfBeersToHours = numberOfAffectingBeers / numberOfHours;

            return actualRatioOfBeersToHours <= BeerToHourRatioLimit;
        }

        private static double GetCountOfBeersDrankThatAffectRatio(double numberOfBeersDrankTotal, double numberOfCrackers)
        {
            var numberOfBeersCrackersHelpedNegate = GetNumberOfBeersLessCrackerBeers(numberOfCrackers, numberOfBeersDrankTotal);

            return numberOfBeersDrankTotal - numberOfBeersCrackersHelpedNegate;
        }

        private static double GetNumberOfBeersLessCrackerBeers(double numberOfCrackers, double numberOfBeersDrankTotal)
        {
            if (numberOfCrackers >= 100)
                return numberOfBeersDrankTotal;

            var numberOfBeersCrackersHelpedNegate = Math.Floor(numberOfCrackers / NumberOfCrackersToNegateABeer);

            numberOfBeersCrackersHelpedNegate = AccountForMaximumBeersCrackersCanNegate(numberOfBeersCrackersHelpedNegate);

            return numberOfBeersCrackersHelpedNegate;
        }

        private static double AccountForMaximumBeersCrackersCanNegate(double numberOfBeersCrackersHelpedNegate)
        {
            if (numberOfBeersCrackersHelpedNegate > MaxNumberOfBeersCrackersCanReduce)
                numberOfBeersCrackersHelpedNegate = MaxNumberOfBeersCrackersCanReduce;
            return numberOfBeersCrackersHelpedNegate;
        }
    }
}