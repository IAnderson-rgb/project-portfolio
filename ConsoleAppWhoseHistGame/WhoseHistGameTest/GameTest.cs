using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppWhoseHistGame.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleAppWhoseHistGame.Classes.Tests
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
            Assert.AreEqual(dateSelected.Contains("5-14"), true);
        }

        [TestMethod]
        public void AnsweresFilled()
        {
            // Arrange
            string dateSelected = "5-14";
            var createdGame = CreateGame();

            // Act
            createdGame.PlayGame(dateSelected);

            // Assert
            Assert.IsFalse(createdGame.Answers.Contains(null));
        }

        [TestMethod]
        public void PlayerGeussesFilled()
        {
            // Arrange
            string dateSelected = "5-14";
            var createdGame = CreateGame();
            // Act
            createdGame.PlayGame(dateSelected);
           
            // Assert
            Assert.AreEqual(createdGame.PlayerGeusses.Contains(""), false);
        }

        private Game CreateGame()
        {
            int seconds = 30;
            bool isNewGameTrue = true;
            string playerName = "Joe";;
            Game newGame = new Game(seconds, isNewGameTrue, playerName);
            return newGame;
        }
    }
}
