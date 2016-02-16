using System;

namespace DevinLearnGood
{
    public class LotteryDeterminator
    {
        private readonly ICanGenerateRandomNumbers _canGenerateRandomNumbers;

        public LotteryDeterminator(ICanGenerateRandomNumbers canGenerateRandomNumbers)
        {
            _canGenerateRandomNumbers = canGenerateRandomNumbers;
        }


        public bool Bet()
        {
            var theRandomNumber = _canGenerateRandomNumbers.GenerateRandomNumber();
            if (theRandomNumber <= 100000)
                return true;

            return false;

            //throw new System.NotImplementedException();
        }
    }
}