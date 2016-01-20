using System;

namespace DevinLearnGood
{
    public class HorseHayToFeedAmountProvider
    {
        public double GetHayForHorse(Horse horse)
        {
            var preciseNumberOfLeavesToProvide = Math.Ceiling((double)horse.WeightInPounds / 30);

            if ((double)horse.Age < 4)
                preciseNumberOfLeavesToProvide = preciseNumberOfLeavesToProvide * 2;

            var doubleOfRoundedValue = (preciseNumberOfLeavesToProvide);

            return doubleOfRoundedValue;

        }
    }

    public class Horse
    {
        public string Name { get; set; }
        public int WeightInPounds { get; set; }
        public int Age { get; set; }
    }
}