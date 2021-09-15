using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Game
    {
        private int[] _rolls = new int[21];
        private int _currentRoll;
        public void Roll(int pins)
        {
            _rolls[_currentRoll++] = pins;
        }

        public int Score()
        {
            int _score = 0;
            int frameIndex = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (IsSpare(frameIndex)) // spare
                {
                    _score += 10 + _rolls[frameIndex + 2];
                    frameIndex += 2;
                }
                else
                {
                    _score += _rolls[frameIndex] + _rolls[frameIndex + 1];
                    frameIndex += 2;
                }

            }
            return _score;
        }

        private Boolean IsSpare(int frameIndex)
        {
            return _rolls[frameIndex] + _rolls[frameIndex + 1] == 10;
        }
    }
}
