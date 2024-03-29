﻿using System.Drawing;
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
                m_Player.BecameActive -= player_BecameActive;
                m_Player.BecameInactive -= player_BecameInactive;
                m_Player.ScoreChanged -= player_ScoreChanged;
            }

            m_Player = i_Player;
            if (m_Player != null)
            {
                m_Player.BecameActive += player_BecameActive;
                m_Player.BecameInactive += player_BecameInactive;
                m_Player.ScoreChanged += player_ScoreChanged;
                setPlayerText();
            }
        }

        public int Score
        {
            get
            {
                return this.m_Player.Score;
            }

            set
            {
                this.m_Player.Score = value;
                player_ScoreChanged();
            }  
        }

        private void player_ScoreChanged()
        {
            setPlayerText();
        }

        private void setPlayerText()
        {
            Text = $"{m_Player.PlayerName}:{m_Player.Score}";
        }

        private void player_BecameInactive()
        {
            Font = new Font(Font, FontStyle.Regular);
        }

        private void player_BecameActive()
        {
            Font = new Font(Font, FontStyle.Bold);
        }
    }
}