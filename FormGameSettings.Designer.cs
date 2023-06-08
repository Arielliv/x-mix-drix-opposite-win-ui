
namespace Ex05.UserInterface
{
    partial class FormGameSettings
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.numericUpDownCols = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRows = new System.Windows.Forms.NumericUpDown();
            this.textBoxPlayer2 = new System.Windows.Forms.TextBox();
            this.textBoxPlayer1 = new System.Windows.Forms.TextBox();
            this.checkBoxIsHuman = new System.Windows.Forms.CheckBox();
            this.labelCols = new System.Windows.Forms.Label();
            this.labelRows = new System.Windows.Forms.Label();
            this.labelBoardSize = new System.Windows.Forms.Label();
            this.labelPlayer2 = new System.Windows.Forms.Label();
            this.labelPlayer1 = new System.Windows.Forms.Label();
            this.labelPlayers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(23, 206);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(247, 28);
            this.buttonStart.TabIndex = 23;
            this.buttonStart.Text = "Start!";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.startButton_Click);
            // 
            // numericUpDownCols
            // 
            this.numericUpDownCols.Location = new System.Drawing.Point(222, 167);
            this.numericUpDownCols.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownCols.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCols.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownCols.Name = "numericUpDownCols";
            this.numericUpDownCols.Size = new System.Drawing.Size(48, 22);
            this.numericUpDownCols.TabIndex = 22;
            this.numericUpDownCols.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numericUpDownRows
            // 
            this.numericUpDownRows.Location = new System.Drawing.Point(97, 169);
            this.numericUpDownRows.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownRows.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownRows.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownRows.Name = "numericUpDownRows";
            this.numericUpDownRows.Size = new System.Drawing.Size(49, 22);
            this.numericUpDownRows.TabIndex = 21;
            this.numericUpDownRows.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // textBoxPlayer2
            // 
            this.textBoxPlayer2.Enabled = false;
            this.textBoxPlayer2.Location = new System.Drawing.Point(131, 77);
            this.textBoxPlayer2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPlayer2.Name = "textBoxPlayer2";
            this.textBoxPlayer2.ReadOnly = true;
            this.textBoxPlayer2.Size = new System.Drawing.Size(137, 22);
            this.textBoxPlayer2.TabIndex = 20;
            this.textBoxPlayer2.Text = "[Computer]";
            // 
            // textBoxPlayer1
            // 
            this.textBoxPlayer1.Location = new System.Drawing.Point(131, 44);
            this.textBoxPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPlayer1.Name = "textBoxPlayer1";
            this.textBoxPlayer1.Size = new System.Drawing.Size(137, 22);
            this.textBoxPlayer1.TabIndex = 19;
            // 
            // checkBoxIsHuman
            // 
            this.checkBoxIsHuman.AutoSize = true;
            this.checkBoxIsHuman.Location = new System.Drawing.Point(40, 79);
            this.checkBoxIsHuman.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxIsHuman.Name = "checkBoxIsHuman";
            this.checkBoxIsHuman.Size = new System.Drawing.Size(18, 17);
            this.checkBoxIsHuman.TabIndex = 18;
            this.checkBoxIsHuman.UseVisualStyleBackColor = true;
            this.checkBoxIsHuman.CheckedChanged += new System.EventHandler(this.isSecondPlayerHumanCheckBox_CheckedChanged);
            // 
            // labelCols
            // 
            this.labelCols.AutoSize = true;
            this.labelCols.Location = new System.Drawing.Point(174, 169);
            this.labelCols.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCols.Name = "labelCols";
            this.labelCols.Size = new System.Drawing.Size(39, 17);
            this.labelCols.TabIndex = 17;
            this.labelCols.Text = "Cols:";
            // 
            // labelRows
            // 
            this.labelRows.AutoSize = true;
            this.labelRows.Location = new System.Drawing.Point(40, 171);
            this.labelRows.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRows.Name = "labelRows";
            this.labelRows.Size = new System.Drawing.Size(46, 17);
            this.labelRows.TabIndex = 16;
            this.labelRows.Text = "Rows:";
            // 
            // labelBoardSize
            // 
            this.labelBoardSize.AutoSize = true;
            this.labelBoardSize.Location = new System.Drawing.Point(27, 137);
            this.labelBoardSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBoardSize.Name = "labelBoardSize";
            this.labelBoardSize.Size = new System.Drawing.Size(81, 17);
            this.labelBoardSize.TabIndex = 15;
            this.labelBoardSize.Text = "Board Size:";
            // 
            // labelPlayer2
            // 
            this.labelPlayer2.AutoSize = true;
            this.labelPlayer2.Location = new System.Drawing.Point(59, 81);
            this.labelPlayer2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlayer2.Name = "labelPlayer2";
            this.labelPlayer2.Size = new System.Drawing.Size(64, 17);
            this.labelPlayer2.TabIndex = 14;
            this.labelPlayer2.Text = "Player 2:";
            // 
            // labelPlayer1
            // 
            this.labelPlayer1.AutoSize = true;
            this.labelPlayer1.Location = new System.Drawing.Point(37, 49);
            this.labelPlayer1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlayer1.Name = "labelPlayer1";
            this.labelPlayer1.Size = new System.Drawing.Size(64, 17);
            this.labelPlayer1.TabIndex = 13;
            this.labelPlayer1.Text = "Player 1:";
            // 
            // labelPlayers
            // 
            this.labelPlayers.AutoSize = true;
            this.labelPlayers.Location = new System.Drawing.Point(19, 19);
            this.labelPlayers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlayers.Name = "labelPlayers";
            this.labelPlayers.Size = new System.Drawing.Size(59, 17);
            this.labelPlayers.TabIndex = 12;
            this.labelPlayers.Text = "Players:";
            // 
            // FormGameSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 252);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.numericUpDownCols);
            this.Controls.Add(this.numericUpDownRows);
            this.Controls.Add(this.textBoxPlayer2);
            this.Controls.Add(this.textBoxPlayer1);
            this.Controls.Add(this.checkBoxIsHuman);
            this.Controls.Add(this.labelCols);
            this.Controls.Add(this.labelRows);
            this.Controls.Add(this.labelBoardSize);
            this.Controls.Add(this.labelPlayer2);
            this.Controls.Add(this.labelPlayer1);
            this.Controls.Add(this.labelPlayers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormGameSettings";
            this.Text = "Game Settings";
            this.Load += new System.EventHandler(this.FormGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.NumericUpDown numericUpDownCols;
        private System.Windows.Forms.NumericUpDown numericUpDownRows;
        private System.Windows.Forms.TextBox textBoxPlayer2;
        private System.Windows.Forms.TextBox textBoxPlayer1;
        private System.Windows.Forms.CheckBox checkBoxIsHuman;
        private System.Windows.Forms.Label labelCols;
        private System.Windows.Forms.Label labelRows;
        private System.Windows.Forms.Label labelBoardSize;
        private System.Windows.Forms.Label labelPlayer2;
        private System.Windows.Forms.Label labelPlayer1;
        private System.Windows.Forms.Label labelPlayers;
    }
}