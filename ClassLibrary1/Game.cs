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
            int i = 0;
            for (int frame = 0; frame < 10; frame++)
            {

                _score += _rolls[i] + _rolls[i+1];
                i += 2;
            }
            return _score;
        }
    }
}
