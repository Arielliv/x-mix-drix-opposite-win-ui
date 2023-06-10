using System;

namespace Ex05.GameLogic
{
    public enum eMarks
    {
        X = 'X',
        O = 'O',
        Empty = ' '
    }

    public class Cell
    {
        private eMarks m_Mark = eMarks.Empty;
        public event Action ValueChanged;

        public eMarks Mark
        {
            get { return m_Mark; }
            set 
            { 
                m_Mark = value;
                onValueChanged();
            }
        }

        public bool IsEmpty()
        {
            return this.m_Mark == eMarks.Empty;
        }

        private void onValueChanged()
        {
            ValueChanged?.Invoke();
        }
    }
}
