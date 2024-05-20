using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        bool player0turn = true;
        bool gameEnd = false;
        int p1Score = 0;
        int p2Score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        /*
            if (!gameEnd)
            {
                if (button.Text == "")
                {
                    if (player0turn)
                    {
                        button.Text = "O";
                        textBoxTurn.Text = "Player 2 [X]";
                    }
                    else
                    {
                        button.Text = "X";
                        textBoxTurn.Text = "Player 1 [O]";
                    }

                    player0turn = !player0turn;


                    if (CheckForWin("O"))
                    {
                        p1Score++;
                        UpdateScore();
                        MessageBox.Show("Player 1 Won");
                        gameEnd = true;
                    }
                    else if (CheckForWin("X"))
                    {
                        p1Score++;
                        UpdateScore();
                        MessageBox.Show("Player 2 Won");
                        gameEnd = true;
                    }
                    else if (IsBoardFull())
                    {
                        MessageBox.Show("Press Play Again");
                        gameEnd = true;
                    }
                }
            }
        }

        */

        public bool CheckForWin(string player)
        {

            for (int i = 0; i < 3; i++)
            {
                if (button1.Text == player && button2.Text == player && button3.Text == player)
                {
                    button1.BackColor = button2.BackColor = button3.BackColor = Color.ForestGreen;
                    return true;
                }
                if (button4.Text == player && button5.Text == player && button6.Text == player)
                {
                    button4.BackColor = button5.BackColor = button6.BackColor = Color.ForestGreen;
                    return true;
                }
                if (button7.Text == player && button8.Text == player && button9.Text == player)
                {
                    button7.BackColor = button8.BackColor = button9.BackColor = Color.ForestGreen;
                    return true;
                }
            }


            for (int i = 0; i < 3; i++)
            {
                if (button1.Text == player && button4.Text == player && button7.Text == player)
                {
                    button1.BackColor = button4.BackColor = button7.BackColor = Color.ForestGreen;
                    return true;
                }
                if (button2.Text == player && button5.Text == player && button8.Text == player)
                {
                    button2.BackColor = button5.BackColor = button8.BackColor = Color.ForestGreen;
                    return true;
                }
                if (button3.Text == player && button6.Text == player && button9.Text == player)
                {
                    button3.BackColor = button6.BackColor = button9.BackColor = Color.ForestGreen;
                    return true;
                }
            }


            if (button1.Text == player && button5.Text == player && button9.Text == player)
            {
                button1.BackColor = button5.BackColor = button9.BackColor = Color.ForestGreen;
                return true;
            }
            if (button3.Text == player && button5.Text == player && button7.Text == player)
            {
                button3.BackColor = button5.BackColor = button7.BackColor = Color.ForestGreen;
                return true;
            }

            return false;
        }

        public bool IsBoardFull()
        {
            foreach (Control control in Controls)
            {
                if (control is Button button && button.Text == "")
                {
                    return false;
                }
            }
            return true;
        }

        public void UpdateScore()
        {
            P1scoreBox.Text = p1Score.ToString();
            P2scoreBox.Text = p2Score.ToString();

        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            button1.Text = button2.Text = button3.Text = button4.Text = button5.Text= "";
            button6.Text = button7.Text = button8.Text = button9.Text= "";
            

            button1.BackColor = button2.BackColor = button3.BackColor = Color.White;
            button4.BackColor = button5.BackColor = button6.BackColor = Color.White;
            button7.BackColor = button8.BackColor = button9.BackColor = Color.White;

            P1scoreBox.Text = "";
            P2scoreBox.Text = "";
            textBoxTurn.Text = "Player 1 [O]"; 
            player0turn = true;
            gameEnd = false;
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            button1.Text = button2.Text = button3.Text = button4.Text = button5.Text = "";
            button6.Text = button7.Text = button8.Text = button9.Text = "";

            button1.BackColor = button2.BackColor = button3.BackColor = Color.White;
            button4.BackColor = button5.BackColor = button6.BackColor = Color.White;
            button7.BackColor = button8.BackColor = button9.BackColor = Color.White;

            textBoxTurn.Text = "Player 1 [O]"; 
            player0turn = true; 
            gameEnd = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!gameEnd)
            {

                if (button1.Text == "")
                {
                    if (player0turn)
                    {
                        button1.Text = "O";
                        textBoxTurn.Text = "Player 2 [X]";
                    }
                    else
                    {
                        button1.Text = "X";
                        textBoxTurn.Text = "Player 1 [O]";
                    }

                    player0turn = !player0turn;


                    if (CheckForWin("O"))
                    {
                        p1Score++;
                        UpdateScore();
                        MessageBox.Show("Player 1 Won");
                        gameEnd = true;
                    }
                    else if (CheckForWin("X"))
                    {
                        p1Score++;
                        UpdateScore();
                        MessageBox.Show("Player 2 Won");
                        gameEnd = true;
                    }
                    else if (IsBoardFull())
                    {
                        MessageBox.Show("Press Play Again");
                        gameEnd = true;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!gameEnd)
            {

                if (button2.Text == "")
                {
                    if (player0turn)
                    {
                        button2.Text = "O";
                        textBoxTurn.Text = "Player 2 [X]";
                    }
                    else
                    {
                        button2.Text = "X";
                        textBoxTurn.Text = "Player 1 [O]";
                    }

                    player0turn = !player0turn;


                    if (CheckForWin("O"))
                    {
                        p1Score++;
                        UpdateScore();
                        MessageBox.Show("Player 1 Won");
                        gameEnd = true;
                    }
                    else if (CheckForWin("X"))
                    {
                        p1Score++;
                        UpdateScore();
                        MessageBox.Show("Player 2 Won");
                        gameEnd = true;
                    }
                    else if (IsBoardFull())
                    {
                        MessageBox.Show("Press Play Again");
                        gameEnd = true;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!gameEnd)
            {

                if (button3.Text == "")
                {
                    if (player0turn)
                    {
                        button3.Text = "O";
                        textBoxTurn.Text = "Player 2 [X]";
                    }
                    else
                    {
                        button3.Text = "X";
                        textBoxTurn.Text = "Player 1 [O]";
                    }

                    player0turn = !player0turn;


                    if (CheckForWin("O"))
                    {
                        p1Score++;
                        UpdateScore();
                        MessageBox.Show("Player 1 Won");
                        gameEnd = true;
                    }
                    else if (CheckForWin("X"))
                    {
                        p1Score++;
                        UpdateScore();
                        MessageBox.Show("Player 2 Won");
                        gameEnd = true;
                    }
                    else if (IsBoardFull())
                    {
                        MessageBox.Show("Press Play Again");
                        gameEnd = true;
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!gameEnd)
            {

                if (button4.Text == "")
                {
                    if (player0turn)
                    {
                        button4.Text = "O";
                        textBoxTurn.Text = "Player 2 [X]";
                    }
                    else
                    {
                        button4.Text = "X";
                        textBoxTurn.Text = "Player 1 [O]";
                    }

                    player0turn = !player0turn;


                    if (CheckForWin("O"))
                    {
                        p1Score++;
                        UpdateScore();
                        MessageBox.Show("Player 1 Won");
                        gameEnd = true;
                    }
                    else if (CheckForWin("X"))
                    {
                        p1Score++;
                        UpdateScore();
                        MessageBox.Show("Player 2 Won");
                        gameEnd = true;
                    }
                    else if (IsBoardFull())
                    {
                        MessageBox.Show("Press Play Again");
                        gameEnd = true;
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!gameEnd)
            {

                if (button5.Text == "")
                {
                    if (player0turn)
                    {
                        button5.Text = "O";
                        textBoxTurn.Text = "Player 2 [X]";
                    }
                    else
                    {
                        button5.Text = "X";
                        textBoxTurn.Text = "Player 1 [O]";
                    }

                    player0turn = !player0turn;


                    if (CheckForWin("O"))
                    {
                        p1Score++;
                        UpdateScore();
                        MessageBox.Show("Player 1 Won");
                        gameEnd = true;
                    }
                    else if (CheckForWin("X"))
                    {
                        p1Score++;
                        UpdateScore();
                        MessageBox.Show("Player 2 Won");
                        gameEnd = true;
                    }
                    else if (IsBoardFull())
                    {
                        MessageBox.Show("Press Play Again");
                        gameEnd = true;
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!gameEnd)
            {

                if (button6.Text == "")
                {
                    if (player0turn)
                    {
                        button6.Text = "O";
                        textBoxTurn.Text = "Player 2 [X]";
                    }
                    else
                    {
                        button6.Text = "X";
                        textBoxTurn.Text = "Player 1 [O]";
                    }

                    player0turn = !player0turn;


                    if (CheckForWin("O"))
                    {
                        p1Score++;
                        UpdateScore();
                        MessageBox.Show("Player 1 Won");
                        gameEnd = true;
                    }
                    else if (CheckForWin("X"))
                    {
                        p1Score++;
                        UpdateScore();
                        MessageBox.Show("Player 2 Won");
                        gameEnd = true;
                    }
                    else if (IsBoardFull())
                    {
                        MessageBox.Show("Press Play Again");
                        gameEnd = true;
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!gameEnd)
            {

                if (button7.Text == "")
                {
                    if (player0turn)
                    {
                        button7.Text = "O";
                        textBoxTurn.Text = "Player 2 [X]";
                    }
                    else
                    {
                        button7.Text = "X";
                        textBoxTurn.Text = "Player 1 [O]";
                    }

                    player0turn = !player0turn;


                    if (CheckForWin("O"))
                    {
                        p1Score++;
                        UpdateScore();
                        MessageBox.Show("Player 1 Won");
                        gameEnd = true;
                    }
                    else if (CheckForWin("X"))
                    {
                        p1Score++;
                        UpdateScore();
                        MessageBox.Show("Player 2 Won");
                        gameEnd = true;
                    }
                    else if (IsBoardFull())
                    {
                        MessageBox.Show("Press Play Again");
                        gameEnd = true;
                    }
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!gameEnd)
            {

                if (button8.Text == "")
                {
                    if (player0turn)
                    {
                        button8.Text = "O";
                        textBoxTurn.Text = "Player 2 [X]";
                    }
                    else
                    {
                        button8.Text = "X";
                        textBoxTurn.Text = "Player 1 [O]";
                    }

                    player0turn = !player0turn;


                    if (CheckForWin("O"))
                    {
                        p1Score++;
                        UpdateScore();
                        MessageBox.Show("Player 1 Won");
                        gameEnd = true;
                    }
                    else if (CheckForWin("X"))
                    {
                        p1Score++;
                        UpdateScore();
                        MessageBox.Show("Player 2 Won");
                        gameEnd = true;
                    }
                    else if (IsBoardFull())
                    {
                        MessageBox.Show("Press Play Again");
                        gameEnd = true;
                    }
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!gameEnd)
            {

                if (button9.Text == "")
                {
                    if (player0turn)
                    {
                        button9.Text = "O";
                        textBoxTurn.Text = "Player 2 [X]";
                    }
                    else
                    {
                        button9.Text = "X";
                        textBoxTurn.Text = "Player 1 [O]";
                    }

                    player0turn = !player0turn;


                    if (CheckForWin("O"))
                    {
                        p1Score++;
                        UpdateScore();
                        MessageBox.Show("Player 1 Won");
                        gameEnd = true;
                    }
                    else if (CheckForWin("X"))
                    {
                        p1Score++;
                        UpdateScore();
                        MessageBox.Show("Player 2 Won");
                        gameEnd = true;
                    }
                    else if (IsBoardFull())
                    {
                        MessageBox.Show("Press Play Again");
                        gameEnd = true;
                    }
                }
            }
        }
    }
}