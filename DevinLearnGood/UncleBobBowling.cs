using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace DevinLearnGood
{
    public class UncleBobBowling
    {
        private int[] _rolls = new int[21];
        private int _currentRoll = 0;


        public void Roll(int pins)
        {
            _rolls[_currentRoll] = pins;
            _currentRoll = _currentRoll + 1;
        }

        public int Score()
        {
            var score = 0;
            var rollInFrame = 0;

            for (int frame = 0; frame < 10; frame++)
            {
                score += _rolls[rollInFrame] + _rolls[rollInFrame + 1];
                rollInFrame += 2;
            }

            return score;
        }
    }
}