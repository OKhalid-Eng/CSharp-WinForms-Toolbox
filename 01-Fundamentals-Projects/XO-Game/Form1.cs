using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XO_Game.Properties;

namespace XO_Game
{
    public partial class frmXO : Form
    {
        public frmXO()
        {
            InitializeComponent();
        }


        stGameStatus GameStatus;
        enPlayer PlayerTurn = enPlayer.Player1;
        enum enPlayer
        {
            Player1,
            Player2
        }

        enum enWinner
        {
            Player1,
            Player2,
            Draw,
            GameInProgress
        }

        struct stGameStatus
        {
            public enWinner Winner;
            public bool GameOver;
            public short PlayCount;

        }

        private void EndGame()
        {
           
            lblTurn.Text = "Game Over";
            
            switch(GameStatus.Winner)
            {
                case enWinner.Player1:
                    lblWinner.Text = "Player 1";
                    break;

                case enWinner.Player2:
                    lblWinner.Text = "Player 2";
                    break;

                default:
                    lblWinner.Text = "Draw";
                    break;
            }
            MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private bool CheckValues(Button btn1,Button btn2,Button btn3)
        {
            if (btn1.Tag.ToString() != "?" && btn1.Tag.ToString() == btn2.Tag.ToString() && btn1.Tag.ToString() == btn3.Tag.ToString()) 
            {


                btn1.BackColor = Color.LemonChiffon;
                btn2.BackColor = Color.LemonChiffon;
                btn3.BackColor = Color.LemonChiffon;

                if (btn1.Tag.ToString()=="X")
                {
                    GameStatus.Winner = enWinner.Player1;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
                else
                {
                    GameStatus.Winner = enWinner.Player2;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
            }


            GameStatus.GameOver = false;
            return false;
        }


       private void CheckWinner()
        {
            if (CheckValues(button1, button2, button3))
                return;
            if (CheckValues(button4, button5, button6))
                return;
            if (CheckValues(button7, button8, button9))
                return;

            if (CheckValues(button1, button4, button7))
                return;
            if (CheckValues(button2, button5, button8))
                return;
            if (CheckValues(button3, button6, button9))
                return;

            if (CheckValues(button1, button5, button9))
                return;
            if (CheckValues(button3, button5, button7))
                return;


        }







        private void ChangeImage(Button btn)
        {
            if (btn.Tag.ToString() == "?" && GameStatus.GameOver == false) 
            {
                switch (PlayerTurn)
                {
                    case enPlayer.Player1:

                        btn.Image = Resources.close__8_;
                        PlayerTurn = enPlayer.Player2;
                        lblTurn.Text = "Player1";
                        GameStatus.PlayCount++;
                        btn.Tag = "X";
                        CheckWinner();
                        break;

                    case enPlayer.Player2:
                        btn.Image = Resources.o;
                        PlayerTurn = enPlayer.Player1;
                        lblTurn.Text = "Player2";
                        GameStatus.PlayCount++;
                        btn.Tag = "O";
                        CheckWinner();
                        break;
                        

                }
                
            }

            else
                MessageBox.Show("Wrong Choice", "Worng", MessageBoxButtons.OK, MessageBoxIcon.Error);


            if(GameStatus.PlayCount==9)
            {
                GameStatus.GameOver = true;
                GameStatus.Winner = enWinner.Draw;
                EndGame();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeImage(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangeImage(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangeImage(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChangeImage(button4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ChangeImage(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ChangeImage(button7);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangeImage(button5);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ChangeImage(button9);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ChangeImage(button8);
        }



        private void ResetButton(Button btn)
        {
            btn.Image = Resources.question_sign1;
            btn.Tag = "?";
            btn.BackColor = Color.Indigo;
        }


        private void ResetGame()
        {
            ResetButton(button1);
            ResetButton(button2);
            ResetButton(button3);
            ResetButton(button4);
            ResetButton(button5);
            ResetButton(button6);
            ResetButton(button7);
            ResetButton(button8);
            ResetButton(button9);

            lblTurn.Text = "Player 1";
            lblWinner.Text = "In Progress";

            PlayerTurn = enPlayer.Player1;
            GameStatus.GameOver = false;
            GameStatus.PlayCount = 0;
            GameStatus.Winner = enWinner.GameInProgress;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color lavender = Color.FromArgb(230, 230, 250);
            Pen whitePen = new Pen(lavender);
            whitePen.Width = 15;
            //whitePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            whitePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            whitePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            // Draw Horizontal lines
            e.Graphics.DrawLine(whitePen, 500, 300, 1150, 300);
            e.Graphics.DrawLine(whitePen, 500, 460, 1150, 460);

            // Draw Vertical lines
            e.Graphics.DrawLine(whitePen, 710, 140, 710, 620);
            e.Graphics.DrawLine(whitePen, 940, 140, 940, 620);

        }

        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
    }
}
