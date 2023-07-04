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
                    CellButton cellButton = new CellButton(this.r_GameController.GetGrid().getCellAt(i,j), i, j);
                    cellButton.Click += colButton_OnClick;
                    GameBoardDisplay[i, j] = cellButton;
                }
            }

            FirstPlayerScoreDisplay.SetPlayer(this.r_GameController.Players[0]);
            SecondPlayerScoreDisplay.SetPlayer(this.r_GameController.Players[1]);
        }

        private void game_RoundFinished()
        {
            string title;
            StringBuilder roundFinishedStringBuilder = new StringBuilder();

            onRoundFinished();
            if (this.r_GameController.IsTie())
            {
                roundFinishedStringBuilder.AppendLine("Tie!");
                title = "A Tie!";
            }
            else
            {
                title = "A Win!";
                roundFinishedStringBuilder.AppendLine($"The winner is {this.r_GameController.GetActivePlayer().PlayerName}!");
                this.r_GameController.GetActivePlayer().Score++;
                if (this.r_GameController.ActivePlayerIndex == 0) {
                    FirstPlayerScoreDisplay.Score = this.r_GameController.GetActivePlayer().Score;
                } 
                else
                {
                    SecondPlayerScoreDisplay.Score = this.r_GameController.GetActivePlayer().Score;
                }
            }

            roundFinishedStringBuilder.AppendLine("Would you like to play another round?");
            DialogResult dialogResult = MessageBox.Show(
                roundFinishedStringBuilder.ToString(),
                title,
                MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.r_GameController.InitNewGame(this.r_Settings.ColsNumber);
                for (int i = 0; i < GameBoardDisplay.RowSize; i++)
                {
                    for (int j = 0; j < GameBoardDisplay.ColSize; j++)
                    {
                        (GameBoardDisplay[i, j] as CellButton).Cell = this.r_GameController.GetGrid().getCellAt(i, j);
                        GameBoardDisplay[i, j].Text = "";
                        GameBoardDisplay[i, j].Enabled = true;
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

        private void onRoundFinished()
        {
            RoundFinished?.Invoke();
        }
    }
}