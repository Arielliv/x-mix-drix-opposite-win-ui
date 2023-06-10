using System;
using System.Drawing;
using System.Windows.Forms;
using Ex05.GameLogic;

namespace Ex05.UserInterface
{
    public sealed partial class CellButton : Button
    {
        private readonly Cell r_Cell;
        private readonly int r_ColIndex;
        private readonly int r_RowIndex;

        public CellButton(Cell i_Cell, int i_ColIndex, int i_RowIndex)
        {
            this.r_Cell = i_Cell;
            this.r_Cell.ValueChanged += cell_ValueChanged;
            this.r_ColIndex = i_ColIndex;
            this.r_RowIndex = i_RowIndex;
            this.TextAlign = ContentAlignment.MiddleCenter;

        }

        public int[] GetCellIndex()
        {
            return new int[] { this.r_ColIndex, this.r_RowIndex };
        }

        private void cell_ValueChanged()
        {
            this.Text = r_Cell.Mark.ToString() ?? string.Empty;
            this.Enabled = r_Cell.IsEmpty();
        }

        protected override void OnSizeChanged(EventArgs i_EventArgs)
        {
            this.Font = new Font(Font.Name, (Size.Width + Size.Height) / 10, FontStyle.Bold);
            base.OnSizeChanged(i_EventArgs);
        }
    }
}
