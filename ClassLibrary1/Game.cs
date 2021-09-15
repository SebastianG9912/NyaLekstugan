using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Game
    {
        private int _score;
        private int[] _rolls = new int[21];
        private int _currentRoll;
        public void Roll(int pins)
        {
            _score += pins;
            _rolls[_currentRoll++] = pins;
        }

        public int Score()
        {
            return _score;
        }
    }
}
