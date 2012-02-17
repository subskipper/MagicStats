using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MagicStats.Domain
{
    public class Player
    {
        private string m_UserName;
        private string m_Email;
        private IList<GameResult> m_MatchHistory;

        public IList<GameResult> MatchHistory
        {
            get { return new ReadOnlyCollection<GameResult>(m_MatchHistory); }
        }

        public string UserName
        {
            get { return m_UserName; }
            private set { m_UserName = value; }
        }

        public string Email
        {
            get { return m_Email; }
            private set { m_Email = value; }
        }

        public Player(){}//default ctr

        public Player(string userName)
        {
            UserName = userName;
            m_MatchHistory = new List<GameResult>();
        }
        
        public Player(string userName, string eMail)
        {
            UserName = userName;
            Email = eMail;
            m_MatchHistory = new List<GameResult>();
        }

        /// <summary>
        /// Changes user E-mail address
        /// </summary>
        /// <param name="newAddress">New E-Mail Address</param>
        /// <returns>Updated e-mail address</returns>
        public string ChangeEmail(string newAddress)
        {
            Email = newAddress;

            return Email;
        }

        public void AddGameResult(GameResult playedGame)
        {
            m_MatchHistory.Add(playedGame);
        }
    }
}
