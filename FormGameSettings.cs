using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ex05.GameLogic;

namespace Ex05.UserInterface
{
    public partial class FormGameSettings : Form
    {
        public string FirstPlayerName => textBoxPlayer1.Text;

        public string SecondPlayerName => textBoxPlayer2.Text.TrimStart('[').TrimEnd(']');

        public ePlayerTypes SecondPlayerType =>
            checkBoxIsHuman.Checked
                ? ePlayerTypes.Person
                : ePlayerTypes.Computer;

        public int RowsNumber => (int)numericUpDownRows.Value;

        public int ColsNumber => (int)numericUpDownCols.Value;

        public FormGameSettings()
        {
            InitializeComponent();
        }

        private void FormGame_Load(object sender, EventArgs e)
        {

        }

        private void isSecondPlayerHumanCheckBox_CheckedChanged(object i_Sender, EventArgs i_EventArgs)
        {
            textBoxPlayer2.ReadOnly = !checkBoxIsHuman.Checked;
            textBoxPlayer2.Enabled = checkBoxIsHuman.Checked;
            textBoxPlayer2.Text = checkBoxIsHuman.Checked
                                          ? string.Empty
                                          : "[Computer]";
        }

        private void startButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            if (validateInput())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool validateInput()
        {
            bool isValidInput = true;
            StringBuilder errorMessageStringBuilder = new StringBuilder().AppendLine("Invalid input please note the following errors:");

            if (string.IsNullOrWhiteSpace(FirstPlayerName))
            {
                errorMessageStringBuilder.AppendLine(" - You should provide a name for player 1");
                isValidInput = false;
            }

            if (string.IsNullOrWhiteSpace(SecondPlayerName))
            {
                errorMessageStringBuilder.AppendLine(" - You should provide a name for player 2");
                isValidInput = false;
            }

            if (!isValidInput)
            {
                MessageBox.Show(errorMessageStringBuilder.ToString(), "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return isValidInput;
        }
    }
}
