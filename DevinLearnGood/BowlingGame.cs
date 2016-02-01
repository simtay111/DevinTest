using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DevinLearnGood
{
    public class BowlingGame
    {
        private int[] rolls = new int[21];
        private int currentRoll = 0;

        public void Roll(int pins)
        {
            rolls[currentRoll++] = pins;
        }

        public int Score()
        {
            int _totalScore = 0;
            int firstInFrame = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                isStrike(ref _totalScore, ref firstInFrame);
                isSpare(ref _totalScore, ref firstInFrame);

            }

            return _totalScore;
        }

        private void isStrike(ref int _totalScore, ref int firstInFrame)
        {
            if (rolls[firstInFrame] == 10)
            {
                _totalScore += 10 + rolls[firstInFrame + 1] + rolls[firstInFrame + 2];
                firstInFrame++;
            }
        }

        private void isSpare(ref int _totalScore, ref int firstInFrame)
        {
            if (rolls[firstInFrame] + rolls[firstInFrame + 1] == 10)
            {
                _totalScore += 10 + rolls[firstInFrame + 2];
                firstInFrame += 2;
            }
            else
            {
                _totalScore += rolls[firstInFrame] + rolls[firstInFrame + 1];
                firstInFrame += 2;
            }
        }
    }

}
