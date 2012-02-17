using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using MagicStats.Domain;
using MagicStats.Domain.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MagicStats.Tests
{
    [TestClass]
    public class PlayerTests
    {
        //No constructur tests needed yet

        [TestMethod]
        public void Can_assign_UserName_To_New_Player()
        {
            var player = new Player("daft");

            var expected = "daft";
            Assert.AreEqual(expected, player.UserName);
        }

        [TestMethod]
        public void Can_Assign_User_Name_To_New_Player()
        {
            var player = new Player();

            var expected = "henric@edwards.se";
            player.ChangeEmail("henric@edwards.se");

            Assert.AreEqual(expected, player.Email);
        }

        [TestMethod]
        public void Can_Add_Game_Stat_To_Player()
        {
            var player = new Player("daft", "daft@daft.com");
            var result = new GameResult();

            var opponent = new Player("dork", "test@test.com");
            var date = new DateTime(2011, 12, 24, 16, 0, 0);

            var expected = new GameResult(GameResultEnum.Win, opponent, date);

            player.AddGameResult(result);

            Assert.AreEqual(1, player.MatchHistory.Count);
        }
    }
}
