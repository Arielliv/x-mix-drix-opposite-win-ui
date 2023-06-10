using System;

namespace Ex05.GameLogic
{
    public enum ePlayerTypes
    {
        Computer,
        Person
    }

    public class Player
    {
        public event Action ScoreChanged;
        public event Action BecameActive;
        public event Action BecameInactive;

        private ePlayerTypes m_Type;
        private eMarks m_Mark;
        private int m_Score = 0;
        private string m_PlayerName;

        public eMarks Mark
        {
            get { return this.m_Mark; }
            set { this.m_Mark = value; }
        }

        public int Score
        {
            get { return this.m_Score; }
            set { this.m_Score = value; }
        }

        public string PlayerName
        {
            get { return this.m_PlayerName; }
        }

        public ePlayerTypes Type
        {
            get { return this.m_Type; }
            set { this.m_Type = value; }
        }

        public Player(ePlayerTypes i_Type, eMarks i_Mark, string i_PlayerName)
        {
            this.m_Type = i_Type;
            this.m_Mark = i_Mark;
            this.m_PlayerName = i_PlayerName;
        }

        public void IncrementScore()
        {
            Score++;
            onScoreChanged();
        }

        public void SetActive()
        {
            onBecameActive();
        }

        public void SetInactive()
        {
            onBecameInactive();
        }

        private void onScoreChanged()
        {
            ScoreChanged?.Invoke();
        }

        private void onBecameActive()
        {
            BecameActive?.Invoke();
        }

        private void onBecameInactive()
        {
            BecameInactive?.Invoke();
        }
    }
}
