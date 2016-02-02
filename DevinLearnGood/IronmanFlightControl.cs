using System.Dynamic;

namespace DevinLearnGood
{
    public class IronmanFlightControl
    {
        public JetpackFlightResult CanMake(JetPack jetPack, int startingAltitude, int startingFuelInGallons, int desiredDistanceInMiles)
        {
            return null;
        }
    }

    public class JetpackFlightResult
    {
        public int FuelBurned { get; set; }
        public bool CanMakeIt { get; set; }
    }

    public class JetPack
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MaxAltitudeInThousandsOfFeet { get; set; }
        public int MaxFuel { get; set; }
        public int DirectionControlRating { get; set; }
        public int Weight { get; set; }
        public int FuelEffeciency { get; set; }
    }
}