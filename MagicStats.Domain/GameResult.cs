using System;
using MagicStats.Domain.Enums;

namespace MagicStats.Domain
{
    public class GameResult
    {
        private GameResultEnum m_Result;
        private Player m_Opponent;
        private DateTime m_GameDate;


        public GameResult(){}
        public GameResult(GameResultEnum gameResultEnum, Player opponent, DateTime gameDate)
        {
            m_Result = gameResultEnum;
            m_Opponent = opponent;
            m_GameDate = gameDate;
        }

        //Todo: Add decks for players

        public GameResultEnum Result
        {
            get { return m_Result; }
            private set { m_Result = value; }
        }

        public Player Opponent
        {
            get { return m_Opponent; }
            private set { m_Opponent = value; }
        }

        public DateTime GameDate
        {
            get { return m_GameDate; }
            private set { m_GameDate = value; }
        }
    }
}