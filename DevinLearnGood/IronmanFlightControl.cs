using System;
using System.Collections.Generic;
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
                failResult.FailureMessages.Add($"*JARVIS* \"Sir, I do not recommend flying to that altitude unless you want to gamble loss of flight " +
                                            "capabilities due to high altitude freezing.\"");
                return failResult;
            }

            var goodResult = new JetpackFlightResult();

            int pointReductionDueToOverweight = (jetpack.SuitWeightInPounds - 225) / 10;
            jetpack.FuelEfficiencyInPercentage = jetpack.FuelEfficiencyInPercentage - pointReductionDueToOverweight;

            var pointReductionDueToDirectionControlFlaws = ((100 - jetpack.DirectionControlRating) / 2);
            jetpack.FuelEfficiencyInPercentage = jetpack.FuelEfficiencyInPercentage - pointReductionDueToDirectionControlFlaws;

            if (jetpack.FuelEfficiencyInPercentage <= 0)
            {
                var failResult = new JetpackFlightResult();
                failResult.CanMakeIt = false;
                failResult.FailureMessages.Add($"*JARVIS* \"Sir, your total flight fuel consumption efficiency is 100% inadequte. Recommend shedding " +
                                            "weight in the suits armaments to increase flight performance.\"");
                return failResult;
            }

            if (pointReductionDueToOverweight > 0)
                goodResult.WarningMessages.Add($"*JARVIS* \"Sir, I've made the necessary preflight weight optimization calculations, and am informing " +
                                               $"you that your flight efficiency will be reduced down to {jetpack.FuelEfficiencyInPercentage}%.\"");
            if (pointReductionDueToDirectionControlFlaws > 0)
                goodResult.WarningMessages.Add($"*JARVIS* \"Sir, I've made the necessary preflight direction control optimization calculations, and am " +
                                               $"informing you that your flight efficiency will be reduced down to {jetpack.FuelEfficiencyInPercentage}%.\"");

            int flightCalculation = startingFuelInPlasmaUnits - desiredDistanceInMiles / 100;
            if (flightCalculation < 1)
            {
                var failResult = new JetpackFlightResult();
                failResult.CanMakeIt = false;
                failResult.FailureMessages.Add($"*JARVIS* \"Sir, I regret to inform you that you do not have enough total fuel to make it to your destination.\"");
                return failResult;
            }
            
            goodResult.CanMakeIt = true;
            return goodResult;
        }
    }
    public class JetpackFlightResult
    {
        public JetpackFlightResult()
        {
            WarningMessages = new List<string>();
            FailureMessages = new List<string>();
        }
        public int FuelBurned { get; set; }
        public bool CanMakeIt { get; set; }
        public List<string> FailureMessages { get; set; }
        public List<string> WarningMessages { get; set; }
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
