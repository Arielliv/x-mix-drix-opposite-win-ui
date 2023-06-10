using Ex05.GameLogic;
using System;
using System.Text;
using System.Windows.Forms;

namespace Ex05.UserInterface
{
    public sealed partial class FormGame : Form
    {
        private readonly GameController r_GameController;
        private readonly FormGameSettings r_Settings = new FormGameSettings();

        public event Action RoundFinished;

        public FormGame()
        {
            DialogResult dialogResult = this.r_Settings.ShowDialog();

            if (dialogResult != DialogResult.OK)
            {
                DialogResult = dialogResult;
                Close();
            }

            InitializeComponent();

            this.r_GameController = new GameController(
                new Player(ePlayerTypes.Person, eMarks.X, this.r_Settings.FirstPlayerName),
                new Player(this.r_Settings.SecondPlayerType, eMarks.O, this.r_Settings.SecondPlayerName));
            this.r_GameController.InitNewGame(this.r_Settings.ColsNumber);

            this.r_GameController.RoundFinished += game_RoundFinished;

            GameBoardDisplay.ColSize = this.r_GameController.GetGrid().GetGridSize();
            GameBoardDisplay.RowSize = GameBoardDisplay.ColSize;

            for (int i = 0; i < GameBoardDisplay.RowSize; i++)
            {
                for (int j = 0; j < GameBoardDisplay.ColSize; j++)
                {
                    CellButton cellButton = new CellButton(new Cell(), i, j);
                    cellButton.Click += colButton_OnClick;
                    GameBoardDisplay[i, j] = cellButton;
                }
            }

            FirstPlayerScoreDisplay.SetPlayer(this.r_GameController.Players[0]);
            SecondPlayerScoreDisplay.SetPlayer(this.r_GameController.Players[1]);
            this.r_GameController.InitNewGame(this.r_Settings.ColsNumber);
        }

        private void game_RoundFinished()
        {
            string title;
            StringBuilder roundFinishedStringBuilder = new StringBuilder();

            if (this.r_GameController.IsTie())
            {
                roundFinishedStringBuilder.AppendLine("Tie!!");
                title = "A Tie!";
            }
            else
            {
                title = "A Win!";
                roundFinishedStringBuilder.AppendLine($"{this.r_GameController.GetActivePlayer().PlayerName} Won!!");
            }

            roundFinishedStringBuilder.AppendLine("Another Round?");
            DialogResult dialogResult = MessageBox.Show(
                roundFinishedStringBuilder.ToString(),
                title,
                MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.r_GameController.InitNewGame(this.r_Settings.ColsNumber);
                for (int i = 0; i < this.r_Settings.ColsNumber; i++)
                {
                    if (GameBoardDisplay[0, i] is CellButton cellButton)
                    {
                        cellButton.Enabled = true;
                    }
                }
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void colButton_OnClick(object i_Sender, EventArgs i_E)
        {
            if (i_Sender is CellButton senderAsBoardButton)
            {
                int[] cellIndex = senderAsBoardButton.GetCellIndex();
                this.r_GameController.ApplyNextMove(cellIndex);
            }
        }
    }
}