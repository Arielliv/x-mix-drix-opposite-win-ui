using System.Drawing;
using System.Windows.Forms;
using Ex05.GameLogic;

namespace Ex05.UserInterface
{
    public sealed partial class PlayerScoreDisplay : Label
    {
        private Player m_Player;

        public void SetPlayer(Player i_Player)
        {
            if (m_Player != null)
            {
                m_Player.BecameActive -= m_Player_BecameActive;
                m_Player.BecameInactive -= m_Player_BecameInactive;
                m_Player.ScoreChanged -= m_Player_ScoreChanged;
            }

            m_Player = i_Player;

            if (m_Player != null)
            {
                m_Player.BecameActive += m_Player_BecameActive;
                m_Player.BecameInactive += m_Player_BecameInactive;
                m_Player.ScoreChanged += m_Player_ScoreChanged;
                setPlayerText();
            }
        }

        public int Score
        {
            set
            {
                this.m_Player.Score = value;
                m_Player_ScoreChanged();
            }
            get
            {
                return this.m_Player.Score;
            }
        }

        private void m_Player_ScoreChanged()
        {
            setPlayerText();
        }

        private void setPlayerText()
        {
            Text = $"{m_Player.PlayerName}:{m_Player.Score}";
        }

        private void m_Player_BecameInactive()
        {
            Font = new Font(Font, FontStyle.Regular);
        }

        private void m_Player_BecameActive()
        {
            Font = new Font(Font, FontStyle.Bold);
        }
    }
}