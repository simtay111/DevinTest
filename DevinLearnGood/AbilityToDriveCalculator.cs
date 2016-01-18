namespace DevinLearnGood
{
    public class AbilityToDriveCalculator
    {
        public bool CalculateIfAbleToDrive(double numberOfBeers, double numberOfHours, double numberOfCrackers)
        {
            var beersToHoursRatio = (numberOfBeers / numberOfHours);

            var isGreaterThanOnePerHour = beersToHoursRatio > 1;

            return !isGreaterThanOnePerHour;
        }
    }
}