using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using MagicStats.Domain;
using MagicStats.Domain.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MagicStats.Tests
{
    //Game implies we are doing current stats wrong. Lets look at that later though.
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void Game_Has_Correct_Number_Of_Players_For_Standard_Type_Game()
        {
            var game = new Game(GameType.StandardConstructed);
            int expected = 2;

            Assert.AreEqual(expected, game.NumberOfPlayers);
        }

        [TestMethod]
        public void Game_Has_Correct_Life_Total_For_2_Player_Standard_Constructed()
        {
            var playerOne = new Player();
            var playerTwo = new Player();

            var game = new Game(playerOne, playerTwo, GameType.StandardConstructed);
            int expected = 20;

            Assert.AreEqual(expected, game.PlayerOneLifeTotal);
            Assert.AreEqual(expected, game.PlayerTwoLifeTotal);
        }

        [TestMethod]
        public void Player_Life_Totals_Can_Be_Decreased()
        {
            var playerOne = new Player();
            var playerTwo = new Player();

            var game = new Game(playerOne, playerTwo, GameType.StandardConstructed);
            int expectedPlayerOne = 18;
            int expectedPlayerTwo = 15;

            game.DecreasePlayerOneLife(2);
            game.DecreasePlayerTwoLife(5);

            Assert.AreEqual(expectedPlayerOne, game.PlayerOneLifeTotal);
            Assert.AreEqual(expectedPlayerTwo, game.PlayerTwoLifeTotal);
        }
    }
}
