using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeWinFormApp
{
    enum GameStatus
    {
        Win,
        Draw,
        Game
    }

    public partial class MainForm : Form
    {
        string[] players = new string[2];
        int currentPlayerNumber;

        Button[,] buttonBoard = new Button[3, 3];

        public MainForm()
        {
            InitializeComponent();
            comboBoxWhoStartGame.SelectedIndex = 0;
            players[0] = "O";
            players[1] = "X";
            buttonBoard[0, 0] = buttonPosition00;
            buttonBoard[1, 0] = buttonPosition10;
            buttonBoard[2, 0] = buttonPosition20;
            buttonBoard[0, 1] = buttonPosition01;
            buttonBoard[1, 1] = buttonPosition11;
            buttonBoard[2, 1] = buttonPosition21;
            buttonBoard[0, 2] = buttonPosition02;
            buttonBoard[1, 2] = buttonPosition12;
            buttonBoard[2, 2] = buttonPosition22;
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            currentPlayerNumber = comboBoxWhoStartGame.SelectedIndex;

            for (int col = 0; col < 3; col++)
                for (int row = 0; row < 3; row++)
                    buttonBoard[col, row].Text = "";

            tableLayoutPanelBoard.Visible = true;
        }

        private void buttonPosition_Click(object sender, EventArgs e)
        {
            Button buttonSender = sender as Button;
            if (buttonSender == null)
                return;

            //przycisk jest już zajęty przez gracza
            if (buttonSender.Text != "")
                return;

            buttonSender.Text = players[currentPlayerNumber];

            //sprawdzenie czy koniec gry (wygrana lub remis)
            GameStatus gameStatus = CheckWin(currentPlayerNumber);

            if (gameStatus == GameStatus.Win)
            {
                MessageBox.Show("Wygrana " + players[currentPlayerNumber] + "!!!!!!!");
                tableLayoutPanelBoard.Visible = false;
                return;
            }

            if (gameStatus == GameStatus.Draw)
            {
                MessageBox.Show("Remis !!!!!!!");
                tableLayoutPanelBoard.Visible = false;
                return;
            }

            currentPlayerNumber++;
            if (currentPlayerNumber == 2)
                currentPlayerNumber = 0;
            /*
            if (currentPlayerNumber == 0)
                currentPlayerNumber = 1;
            else
                currentPlayerNumber = 0;
            */
            /*
            currentPlayerNumber = (currentPlayerNumber == 0) ? 1 : 0;
            */

            //currentPlayerNumber = (currentPlayerNumber + 1) % 2;
        }

        private GameStatus CheckWin(int currentPlayerNumber)
        {
            for (int col = 0; col < 3; col++)
            {
                if (buttonBoard[col, 0].Text == players[currentPlayerNumber]
                    && buttonBoard[col, 1].Text == players[currentPlayerNumber]
                    && buttonBoard[col, 2].Text == players[currentPlayerNumber])
                    return GameStatus.Win;
            }

            for (int row = 0; row < 3; row++)
            {
                if (buttonBoard[0, row].Text == players[currentPlayerNumber]
                    && buttonBoard[1, row].Text == players[currentPlayerNumber]
                    && buttonBoard[2, row].Text == players[currentPlayerNumber])
                    return GameStatus.Win;
            }

            if (buttonBoard[0, 0].Text == players[currentPlayerNumber]
                && buttonBoard[1, 1].Text == players[currentPlayerNumber]
                && buttonBoard[2, 2].Text == players[currentPlayerNumber])
                return GameStatus.Win;

            if (buttonBoard[2, 0].Text == players[currentPlayerNumber]
                && buttonBoard[1, 1].Text == players[currentPlayerNumber]
                && buttonBoard[0, 2].Text == players[currentPlayerNumber])
                return GameStatus.Win;

            bool isDraw = true;
            for (int col = 0; col < 3; col++)
                for (int row = 0; row < 3; row++)
                    if (buttonBoard[col, row].Text == "")
                        isDraw = false;

            if (isDraw)
                return GameStatus.Draw;

            return GameStatus.Game;
        }
    }
}
