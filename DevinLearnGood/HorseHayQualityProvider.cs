namespace DevinLearnGood
{
    public class HorseHayQualityProvider
    {
        public HayQuality GetQualityBasedOnGreenness(int greenness)
        {
            return HayQuality.Average;
        }
    }

    public enum HayQuality
    {
        Poor,
        Average,
        Good,
        Excellent
    }

    //public class HayQaulityz
    //{
    //    public const int Poor = 0;
    //    public const int Average = 1;
    //    public const int Good = 2;
    //    public const int Excellent = 3;
    //}
}