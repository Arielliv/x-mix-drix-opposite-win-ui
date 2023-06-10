using System.Windows.Forms;

namespace Ex05.UserInterface
{
    public sealed partial class GameBoardDisplay : Control
    {
        private readonly TableLayoutPanel r_Panel;

        public int RowSize
        {
            get => r_Panel.RowCount;
            set
            {
                r_Panel.RowCount = value;
                setRowsAndColumnsStyle();
            }
        }

        public int ColSize
        {
            get => r_Panel.ColumnCount;
            set => r_Panel.ColumnCount = value;
        }

        public Button this[int i_Row, int i_Column]
        {
            get => r_Panel.GetControlFromPosition(i_Column, i_Row) as Button;
            set
            {
                value.Dock = DockStyle.Fill;
                r_Panel.Controls.Add(value, i_Column, i_Row);
            }
        }

        public GameBoardDisplay()
        {
            r_Panel = new TableLayoutPanel
            {
                Size = Size,
                Anchor = AnchorStyles.Bottom |
                                                                   AnchorStyles.Left |
                                                                   AnchorStyles.Right |
                                                                   AnchorStyles.Top
            };
            Controls.Add(r_Panel);
        }

        private void setRowsAndColumnsStyle()
        {
            r_Panel.ColumnStyles.Clear();
            r_Panel.RowStyles.Clear();

            for (int i = 0; i < r_Panel.ColumnCount; i++)
            {
                r_Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / ColSize));
            }

            for (int i = 0; i < r_Panel.RowCount; i++)
            {
                r_Panel.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / RowSize));
            }
        }
    }
}