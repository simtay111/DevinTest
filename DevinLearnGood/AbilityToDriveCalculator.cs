namespace DevinLearnGood
{
    public class AbilityToDriveCalculator
    {
        public bool CalculateIfAbleToDrive(double numberOfBeers, double numberOfHours, double numberOfCrackers)
        {
            var crackersWillHelpWithBeers = (numberOfCrackers / 10);

            var crackersHaveMaxedOutHelpingBloodAlcoholContent = crackersWillHelpWithBeers <= 3;

            var crackersDidDeluteBloodAlcoholContent = crackersWillHelpWithBeers >= 1;

            var beersToHoursRatio = (numberOfBeers / numberOfHours);

            var isGreaterThanOnePerHour = beersToHoursRatio > 1;

            return !isGreaterThanOnePerHour;

            //var beersToHoursRatio = (numberofbeers / numberofhours);

            //var isGreaterThanOnePerHour = beersToHoursRatio > 1;

            //return !isGreaterThanOnePerHour;

        }


    }
}