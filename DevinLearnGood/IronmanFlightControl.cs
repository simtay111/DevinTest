using System;
using System.Dynamic;

namespace DevinLearnGood
{
    public class IronmanFlightControl
    {

        public JetpackFlightResult CanMake(Jetpack jetpack, int startingAltitude, int startingFuelInPlasmaUnits, int desiredDistanceInMiles)
        {
            if (jetpack.Id <= 0)
                throw new Exception("*JARVIS* \"Sir, I cannot allow you to fly to your destination without a valid flight authorization ID.\"");
            if (jetpack.MaxAltitudeInThousandsOfFeet > 50000)
            {
                var failResult = new JetpackFlightResult();
                failResult.CanMakeIt = false;
                failResult.Message = "*JARVIS* \"Sir, I do not recommend flying to that altitude unless you want to gamble loss of flight capabilities due to high altitude freezing.\"";
                return failResult;
            }
            if (jetpack.FuelEfficiencyInPercentage <= 0)
            {
                throw new Exception("*JARVIS* \"Sir, your total flight fuel consumption efficiency is 100% inadequte. Recommend shedding weight in the suits armaments.\"");
            }
            int addedWeight = jetpack.SuitWeightInPounds - 225;
            jetpack.FuelEfficiencyInPercentage = (jetpack.FuelEfficiencyInPercentage - (addedWeight / 10));


            var goodResult = new JetpackFlightResult();
            goodResult.CanMakeIt = true;
            goodResult.Message = $"*JARVIS* \"Sir, I've made the necessary preflight weight optimization calculations, and am informing you that your flight efficiency will be reduced down to {jetpack.FuelEfficiencyInPercentage}%.\"";
            return goodResult;
        }


    }

    public class JetpackFlightResult
    {
        public int FuelBurned { get; set; }
        public bool CanMakeIt { get; set; }
        public string Message { get; set; }
    }

    public class Jetpack
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MaxAltitudeInThousandsOfFeet { get; set; }
        public int MaxFuel { get; set; }
        public int DirectionControlRating { get; set; }
        public int SuitWeightInPounds { get; set; }
        public int TonyStarksWeightInPounds { get; set; }
        public int FuelEfficiencyInPercentage { get; set; }
    }
}
