using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        Random _rand = new Random();


        private enum enWinner { Player1, Computer, Draw };

        private enum enChoice { Scissor = 1, Paper = 2, Rock = 3 };

        stRoundInfo RoundInfo;
        stGameResult GameResult;

        private struct stRoundInfo
        {
            public int RoundCount;
            public  short TotalRound;
            public enChoice PlayerChoice;
            public enChoice ComputerChoice;
            public enWinner winner;

            public string WinnerName;
        }


        private struct stGameResult
        {

            public short Player1WonsTime;
            public short ComputerWonsTime;
            public short DrawWonsTime;
        }
     
        private enChoice GetComputerChoice()
        {
            return (enChoice)_rand.Next(1, 3);
        }

        private enWinner WhoWonTheRound(stRoundInfo Roundinfo)
        {
           

            if ((RoundInfo.PlayerChoice == enChoice.Paper) && (RoundInfo.ComputerChoice == enChoice.Rock))
                return enWinner.Player1;

            if ((RoundInfo.PlayerChoice == enChoice.Rock) && (RoundInfo.ComputerChoice == enChoice.Paper))
                return enWinner.Player1;

            if ((RoundInfo.PlayerChoice == enChoice.Paper) && (RoundInfo.ComputerChoice == enChoice.Scissor))
                return enWinner.Computer;

            if ((RoundInfo.PlayerChoice == enChoice.Rock) && (RoundInfo.ComputerChoice == enChoice.Paper))
                return enWinner.Computer;

            else
                return enWinner.Draw;
        }

        private string GetWinnerName(enWinner Winner)
        {
            string WinnerName = Winner.ToString();
            return WinnerName;

        }

        private void  UpdateUI(stRoundInfo RoundInfo)
        {
            //Update and Complete Logic:
        }

        private void StartGame(enChoice PlayerChoice)
        {
            enChoice ComputerChoice = GetComputerChoice();

            RoundInfo.PlayerChoice = PlayerChoice;
            RoundInfo.ComputerChoice = ComputerChoice;
            RoundInfo.winner = WhoWonTheRound(RoundInfo);
            RoundInfo.WinnerName = GetWinnerName(RoundInfo.winner);

            RoundInfo.RoundCount++;




        }



        private void Form1_Load(object sender, EventArgs e)
        {
            cbNumRound.SelectedIndex = 0;
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            RoundInfo.TotalRound = (short)(cbNumRound.SelectedIndex + 1);
            panel.Visible = false;
            lblRoundNumber.Text = RoundInfo.TotalRound.ToString();
        }

        

        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Cursor = Cursors.Hand;
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Location = new Point(pb.Location.X + 2, pb.Location.Y + 2);
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Location = new Point(pb.Location.X - 2, pb.Location.Y - 2);
        }


        private void btnPaper_Click(object sender, EventArgs e)
        {
            StartGame((enChoice)int.Parse(btnPaper.Tag.ToString()));
        }
    }
}
