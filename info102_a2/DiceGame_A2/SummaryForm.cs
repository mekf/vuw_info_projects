/*Minh HA
 * 300113109
 * INFO102 - Assignment1*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _300113109_DiceGame_A2
{
    public partial class SummaryForm : Form
    {
        int rollNumInt;
        int pointsTotalInt;
        int winSumNumInt;
        int winDoubleNumInt;
        int winDiceNumNumInt;
        int topUpNumInt;

        public SummaryForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public int DisplayRollNum   //Roll numbers
        {
            set
            {
                rollNumInt = value;
            }
            get
            {
                return rollNumInt;
            }
        }

        public int DisplayPointsTotal   //Total points
        {
            set
            {
                pointsTotalInt = value;
            }
            get
            {
                return pointsTotalInt;
            }
        }

        public int DisplayBetSumWin //Wins for bet on sum
        {
            set
            {
                winSumNumInt = value;
            }
            get
            {
                return winSumNumInt;
            }
        }

        public int DisplayBetDoubleWin  //Wins for bet on double dice
        {
            set
            {
                winDoubleNumInt = value;
            }
            get
            {
                return winDoubleNumInt;
            }
        }

        public int DislayBetDiceNumWin  //Wins for bet on dice number
        {
            set
            {
                winDiceNumNumInt = value;
            }
            get
            {
                return winDiceNumNumInt;
            }
        }

        public int DisplayTopUpNum  //Numbers of top up used
        {
            set
            {
                topUpNumInt = value;
            }
            get
            {
                return topUpNumInt;
            }
        }

        private void SummaryForm_Activated(object sender, EventArgs e)  //Updated everytime Summary_Click occurs in MainForm
        {
            clickNumLabel.Text = "Roll Times :" + rollNumInt.ToString();
            pointsSumLabel.Text = "Total Points: " + pointsTotalInt.ToString();
            betSumWinLabel.Text = "Sum Guess Correct: " + winSumNumInt.ToString();
            betDoubleWinLabel.Text = "Double Guess Correct: " + winDoubleNumInt.ToString();
            betDiceNumWinLabel.Text = "Dice Num Guess Correct: " + winDiceNumNumInt.ToString();
            topUpLabel.Text = "Top Up Times :" + topUpNumInt.ToString();
        }

        private void continueButton_Click(object sender, EventArgs e)   //Close, do not destroy app
        {
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)   //Quit app for good
        {
            Application.Exit();
        }
    }
}
