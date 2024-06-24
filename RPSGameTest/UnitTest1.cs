using Xunit;
using System.Runtime.CompilerServices;
using RPS_Game;
using System.Xml.Linq;
using System.Text;
using System.Numerics;

namespace RPSGameTest
{
    public class UnitTest1
    {
        [Fact]
        public void CompareMoves_PlayerWins()
        {

            // Arrange
            string name = "Ahmad";
            RPSGam game = new RPSGam(name);

            // Act
            string result = game.compareGame("ROCK", "SCISSORS");

            // Assert
            Assert.Contains($"{name}, you won", result);
        }

        [Fact]
        public void ScoreTest()
        {
            // Arrange
            string name = "Ahmad";
            RPSGam game = new RPSGam(name);

            game.player = new Player {Name = name }; 

            // Act
            string result = game.compareGame("ROCK", "SCISSORS");
            game.UpdateScore(result);

            // Assert
            Assert.Equal(1, game.player.Score);
        }
    }
}
