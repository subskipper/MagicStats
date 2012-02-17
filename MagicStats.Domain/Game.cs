using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MagicStats.Domain.Enums;

namespace MagicStats.Domain
{
    public class Game
    {
        private GameType m_GameType;
        private Player m_PlayerOne;
        private Player m_PlayerTwo;
        private int m_PlayerOneLifeTotal;
        private int m_PlayerTwoLifeTotal;
        private int m_NumberOfPlayers;

        public int NumberOfPlayers
        {
            get { return m_NumberOfPlayers; }
            private set { m_NumberOfPlayers = value; }

        }
        
        public int PlayerOneLifeTotal
        {
            get { return m_PlayerOneLifeTotal; }
            private set { m_PlayerOneLifeTotal = value; }
        }
        public int PlayerTwoLifeTotal
        {
            get { return m_PlayerTwoLifeTotal; }
            private set { m_PlayerTwoLifeTotal = 20; }
        }

        public Game(){}
        
        public Game(GameType gameType)
        {
            m_GameType = gameType;
            //Temp players if life tracker is publically vailable
            m_PlayerOne = new Player("Player1");
            m_PlayerTwo = new Player("Player2");

            m_PlayerOneLifeTotal = 20;
            m_PlayerTwoLifeTotal = 20;

            m_NumberOfPlayers = 2;
        }

        public Game(Player playerOne, Player playerTwo, GameType gameType)
        {
            m_GameType = gameType;

            m_PlayerOne = playerOne;
            m_PlayerTwo = playerTwo;

            m_PlayerOneLifeTotal = 20;
            m_PlayerTwoLifeTotal = 20;

            m_NumberOfPlayers = 2;
        }

        //These two methods can be combined to one. Pass damage and player id or name (for anon players where no ID exists). We'll do it later though.
        public int DecreasePlayerOneLife(int damageTaken)
        {
            m_PlayerOneLifeTotal -= damageTaken;

            return m_PlayerOneLifeTotal;
        }

        public int DecreasePlayerTwoLife(int damageTaken)
        {
            m_PlayerTwoLifeTotal -= damageTaken;

            return m_PlayerTwoLifeTotal;
        }
    }
}
