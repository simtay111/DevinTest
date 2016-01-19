namespace DevinLearnGood
{
    public class HorseHayToFeedAmountProvider
    {
        public int GetHayForHorse(Horse horse)
        {
            throw new System.NotImplementedException();
        }
    }

    public class Horse
    {
        public string Name { get; set; }
        public int WeightInPounds { get; set; }
        public int Age { get; set; }
    }
}