using System;
using System.CodeDom;

namespace DevinLearnGood
{
    public class HorseHayQualityProvider
    {

        public HayQuality GetQualityBasedOnGreenness(int greenness)
        {
            if (greenness < 50)
                return HayQuality.Poor;
            if (greenness >= 50 && greenness < 80)
                return HayQuality.Average;
            if (greenness >= 80 && greenness < 90)
                return HayQuality.Good;

            return greenness >= 90 ? HayQuality.Excellent : HayQuality.Good;
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