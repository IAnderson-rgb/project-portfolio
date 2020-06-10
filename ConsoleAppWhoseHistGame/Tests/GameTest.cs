using ConsoleAppWhoseHistGame.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleAppWhoseHistGame.Tests
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void SelectedDateValid()
        {
            // Arrange
            string dateSelected = "5-14";
            var createdGame = CreateGame();

            // Act
            createdGame.PlayGame(dateSelected);

            // Assert
            Assert.AreEqual(dateSelected + ".txt", dateSelected);
        }
        private Game CreateGame()
        {
            int seconds = 30;
            bool isNewGameTrue = true;
            string playerName = "Joe";
            Game newGame = new Game(seconds, isNewGameTrue, playerName);
            return newGame;
        }
    }
}
