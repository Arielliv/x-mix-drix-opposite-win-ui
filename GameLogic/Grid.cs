﻿namespace Ex05.GameLogic
{
    public class Grid
    {
        private readonly Cell[,] r_GridMatrix;
        private int m_AmountOfAvailableCells;
        public const int k_MinGridSize = 3;
        public const int k_MaxGridSize = 9;


        public int AmountOfAvialibleCell
        {
            get { return this.m_AmountOfAvailableCells; }
        }

        public Grid(int i_Size)
        {
            this.r_GridMatrix = new Cell[i_Size, i_Size];
            this.m_AmountOfAvailableCells = i_Size * i_Size;

            for (int x = 0; x < i_Size; x++)
            {
                for (int y = 0; y < i_Size; y++)
                {
                    this.r_GridMatrix[x, y] = new Cell();
                }
            }
        }

        public int GetGridSize()
        {
            return this.r_GridMatrix.GetLength(0);
        }

        public eMarks GetCellContent(int i_X, int i_Y)
        {
            return this.r_GridMatrix[i_X, i_Y].Mark;
        }

        public bool IsCellEmpty(int i_X, int i_Y)
        {
            return this.r_GridMatrix[i_X, i_Y].IsEmpty();
        }

        public void SetCellMark(int i_X, int i_Y, eMarks i_NewMark) 
        {
            this.r_GridMatrix[i_X, i_Y].Mark = i_NewMark;
            this.m_AmountOfAvailableCells--;
        }

        public bool IsNextMoveValid(int i_X, int i_Y)
        {
            int gridSize = this.GetGridSize();

            return i_X < gridSize && i_X >= 0
                && i_Y < gridSize && i_Y >= 0
                && this.IsCellEmpty(i_X, i_Y);
        }

        public Cell getCellAt(int i_X, int i_Y)
        {
            return this.r_GridMatrix[i_X, i_Y];
        }
    }
}
