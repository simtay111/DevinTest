using System;

namespace DevinLearnGood
{
    public interface ICanGenerateRandomNumbers
    {
        int GenerateRandomNumber();
    }

    public class AdultRandomNumberGenerator : ICanGenerateRandomNumbers
    {
        public const int MaxNumber = 1000000000;
        private readonly Random _random;

        public AdultRandomNumberGenerator(Random random)
        {
            _random = random;
        }

        public int GenerateRandomNumber()
        {
            var generateRandomNumber = _random.Next(1000, MaxNumber);
            return generateRandomNumber;
        }
    }

    public class ChildRandomNumberGenerat : ICanGenerateRandomNumbers
    {
        public const int MaxNumber = 10000;
        private readonly Random _random;

        public ChildRandomNumberGenerat(Random random)
        {
            _random = random;
        }

        public int GenerateRandomNumber()
        {
            var generateRandomNumber = _random.Next(1000, MaxNumber);
            return generateRandomNumber;
        }
    }


}