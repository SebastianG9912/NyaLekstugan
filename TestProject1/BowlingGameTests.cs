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
    public class BowlingGameTests
    {
        [Fact]
        public void TestGutterGame()
        {
            Game game = new Game();

            for (int i = 0; i < 20; i++)
            {
                game.Roll(0);
            }

            Assert.Equal(0, game.Score());
        }
    }
}
