using System.Windows.Forms;
using System.Drawing;
namespace Ex05.UserInterface
{
    partial class FormGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GameBoardDisplay = new GameBoardDisplay();
            this.FirstPlayerScoreDisplay = new PlayerScoreDisplay();
            this.SecondPlayerScoreDisplay = new PlayerScoreDisplay();
            this.SuspendLayout();

            ///
            /// GameBoardDisplay
            /// 
            this.GameBoardDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GameBoardDisplay.Location = new System.Drawing.Point(12, 12);
            this.GameBoardDisplay.Name = "BoardButtons";
            this.GameBoardDisplay.ColSize = 0;
            this.GameBoardDisplay.RowSize = 0;
            this.GameBoardDisplay.Size = new System.Drawing.Size(460, 411);
            this.GameBoardDisplay.TabIndex = 0;
            this.GameBoardDisplay.Text = "squareTableLayoutPanel1";

            ///
            /// FirstScoreDisplayLabel
            ///
            this.FirstPlayerScoreDisplay.Anchor = AnchorStyles.Bottom;
            this.FirstPlayerScoreDisplay.AutoSize = true;
            this.FirstPlayerScoreDisplay.Location = new Point(169, 426);
            this.FirstPlayerScoreDisplay.Name = "FirstPlayerSocreDisplay";
            this.FirstPlayerScoreDisplay.Size = new Size(57, 13);
            this.FirstPlayerScoreDisplay.TabIndex = 1;
            this.FirstPlayerScoreDisplay.Text = "Player 1: 0";
            this.FirstPlayerScoreDisplay.TextAlign = ContentAlignment.MiddleCenter;

            ///
            /// SecondScoreDisplayLabel
            ///
            this.SecondPlayerScoreDisplay.Anchor = AnchorStyles.Bottom;
            this.SecondPlayerScoreDisplay.AutoSize = true;
            this.SecondPlayerScoreDisplay.Location = new Point(256, 426);
            this.SecondPlayerScoreDisplay.Name = "FirstPlayerSocreDisplay";
            this.SecondPlayerScoreDisplay.Size = new Size(57, 13);
            this.SecondPlayerScoreDisplay.TabIndex = 1;
            this.SecondPlayerScoreDisplay.Text = "Player 2: 0";
            this.SecondPlayerScoreDisplay.TextAlign = ContentAlignment.MiddleCenter;




            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.SecondPlayerScoreDisplay);
            this.Controls.Add(this.FirstPlayerScoreDisplay);
            this.Controls.Add(this.GameBoardDisplay);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "FormGame";
            this.Text = "TicTacToeMisere";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GameBoardDisplay GameBoardDisplay;
        private PlayerScoreDisplay FirstPlayerScoreDisplay;
        private PlayerScoreDisplay SecondPlayerScoreDisplay;
    }
}