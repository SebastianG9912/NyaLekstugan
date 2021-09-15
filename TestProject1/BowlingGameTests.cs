using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Sdk;
using ClassLibrary1;

namespace TestProject1
{
    //TODO upprepning av kod i båda tester
    public class BowlingGameTests
    {
        private Game _game;

        public BowlingGameTests()
        {
            _game = new Game();
        }

        [Fact]
        public void TestGutterGame()
        {
            MakeRolls(20, 0);

            Assert.Equal(0, _game.Score());
        }

        [Fact]
        public void TestAllOnes()
        {
            MakeRolls(20, 1);

            Assert.Equal(20, _game.Score());
        }

        private void MakeRolls(int rolls, int pinsHitPerRound)
        {
            for (int i = 0; i < rolls; i++)
                _game.Roll(pinsHitPerRound);
        }

        [Fact]
        public void TestOneSpare()
        {
            RollSpare();
            _game.Roll(3);
            MakeRolls(17,0);
            Assert.Equal(16, _game.Score());
        }

        private void RollSpare()
        {
            _game.Roll(5);
            _game.Roll(5);
        }

        [Fact]
        public void TestOneStrike()
        {
            RollStrike();
            _game.Roll(3);
            _game.Roll(4);
            MakeRolls(16, 0);
            Assert.Equal(24, _game.Score());
        }

        private void RollStrike()
        {
            _game.Roll(10);
        }

        public void TestPerfectGame()
        {
            MakeRolls(12, 10);
            Assert.Equal(300, _game.Score());
        }
    }
}
