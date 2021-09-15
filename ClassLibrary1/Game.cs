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
            for (int i = 0; i < _rolls.Length; i++)
                _score += _rolls[i];
            return _score;
        }
    }
}
