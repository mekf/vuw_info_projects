/*Minh HA
 * 300113109
 * INFO102 - Assignment1*/
/*Extra feature:
 * User has an option to add 10 extra points each time TopUp Button is clicked
 * After 5 top ups, user cannot add any more, message box appear saying time to work
 * User can keep playing with the remaining points
 * To reset top up count, new game must be used, which reset everything
 */
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
    public partial class DiceGameMainForm : Form
    {
        SummaryForm mySummaryForm;
        AboutBox1 aboutForm;

        int winNumInt;  //variables for number of wins n' total points
        int winSumNumInt;
        int winDoubleNumInt;
        int winDiceNumNumInt;
        int pointsTotalInt = 10;

        int betSumValueInt; //this variable is used in two places: exception handling n' reward

        int betSumOk;   //variables for Exception handling
        int betDoubleOk;
        int betDiceNumOk;

        int diceOneInt; //variables for two dices
        int diceTwoInt;
        
        int topUpNumInt;    // variables for extra feature
        int rollNumInt;

        //public int Color;
 
        public DiceGameMainForm()
        {
            InitializeComponent();
            mySummaryForm = new SummaryForm();
            aboutForm = new AboutBox1();
            StartPosition = FormStartPosition.CenterScreen;
            pointsTotalTextBox.Text = pointsTotalInt.ToString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //### CHECK NUMBERS OF BET ###
        private int checkBetNum()
        {
            int betSumCheckInt;
            int betDoubleCheckInt;
            int betDiceCheckInt;

            if (betSumCheckBox.Checked) //check betSum, checked = 1, unchecked = 0
            {
                betSumCheckInt = 1;
            }
            else
            {
                betSumCheckInt = 0;
            }

            if (betDoubleCheckBox.Checked)  //check betDouble, checked = 1, unchecked = 0
            {
                betDoubleCheckInt = 1;
            }
            else
            {
                betDoubleCheckInt = 0;
            }

            if (betDiceNumCheckBox.Checked) //check betDiceNumber, checked = 1, unchecked = 0
            {
                betDiceCheckInt = 1;
            }
            else
            {
                betDiceCheckInt = 0;
            }

            return betSumCheckInt + betDoubleCheckInt + betDiceCheckInt;    //total number of bet options chosen
        }
        //!!! CHECK NUMBERS OF BET END !!!

        //### RANDOM NUMBER GENERATOR ###
        private int generateRandomDice()
        {
            Random random = new Random();
            System.Threading.Thread.Sleep(350);
            return random.Next(1, 7);
        }
        //!!! RANDOM NUMBER GENERATOR END !!!
        
        //### GET DICE PICTURE ###
        //Assign the diceOne or diceTwo Integer -> diceResultInt
        //Check diceResultInt -> return imgString = path
        private string getDiceFile(int diceResultInt)
        {
            string imgString;
            switch (diceResultInt)
            {
                case 1:
                    imgString = "Dice1.png";
                    break;
                case 2:
                    imgString = "Dice2.png";
                    break;
                case 3:
                    imgString = "Dice3.png";
                    break;
                case 4:
                    imgString = "Dice4.png";
                    break;
                case 5:
                    imgString = "Dice5.png";
                    break;
                default:
                    imgString = "Dice6.png";
                    break;
            }
            return imgString;            
        }
        //!!! GET DICE PICTURE END !!!

        //### EXCEPTIONS HANDLING ###
        /*Hierachy of check: 1.betSum, 2.betDouble, 3.betDiceNum
         *Failsafe: if the precedent check results notOK -> subsequent check results notOK (won't miss any weird exceptions)
         */
        private int exceptionBetSum()
        {
            if (betSumCheckBox.Checked) //Check Bet Sum: 1.null val; 2.validity check || OK=1, notOK=0 || nochecked = Ok
            {
                if (string.IsNullOrEmpty(betSumTextBox.Text))   //1. check null
                {
                    MessageBox.Show("betSum = null is not a valid bet mate","No bet sum");
                    betSumTextBox.Focus();
                    betSumOk = 0;
                }
                else
                {
                    try     //2. validity check, only accept numeric input, accept all integer with no limit
                    {
                        int num;
                        bool isNumeric = int.TryParse(betSumTextBox.Text, out num);
                        if (isNumeric)
                        {
                            betSumOk = 1;
                        }
                        betSumValueInt = int.Parse(betSumTextBox.Text); //only get the value if input is numeric
                    }
                    catch
                    {
                        //multiline message box for any other exceptions
                        MessageBox.Show("Sorry mate, you can't trick this program" + "\nOnly bet between 1 - 12 is accepted", "Invalid bet sum");
                        betSumTextBox.Clear();
                        betSumTextBox.Focus();
                        betSumOk = 0;
                    }   //2. validity check end
                }
            }
            else
            {
                betSumOk = 1;   //bet is unchecked, always return ok
            }
            return betSumOk;
        }

        private int exceptionBetDouble()    //Check Bet Double || OK=1, notOK=0 || nochecked = Ok
        {
            if (betDoubleCheckBox.Checked)
            {
                if (betSumOk == 1)
                {
                    betDoubleOk = 1;
                }
                else
                {
                    betDoubleOk = 0;
                }
            }
            else
            {
                betDoubleOk = 1;    //bet is unchecked, always return ok
            }
            return betDoubleOk;
        }

        private int exceptionBetDiceNum()   //Check Bet Dice Number || OK=1, notOK=0 || nochecked = Ok
        {
            if (betDiceNumCheckBox.Checked)
            {
                
                if(betSumOk == 0 || betDoubleOk == 0)   //if either precedent checks notOk -> results notOk
                {
                    betDiceNumOk = 0;
                }
                else if (betSumOk == 1 && betDoubleOk == 1 && this.betDiceNumComboBox.SelectedIndex != -1)
                {
                    betDiceNumOk = 1;   //results Ok if a combox entry is selected
                }
                else if (betSumOk == 1 && betDoubleOk == 1 && this.betDiceNumComboBox.SelectedIndex == -1)
                {
                    betDiceNumOk = 0;   //results notOk if none is selected
                    MessageBox.Show("Dice Number = null is not a valid bet mate","No bet dice num");
                    betDiceNumComboBox.Focus();
                }
            }
            else
            {
                betDiceNumOk = 1;   //bet is unchecked, always return ok
            }
            return betDiceNumOk;
        }
        //!!! EXCEPTIONS HANDLING END !!!

        //### CHECK BET CORRECT/UNCORRECT -> REWARD ###
        /* 1. if a bet is checked then the guess will be compared with the two dices
         * 2. if the bet is not checked then reward always = 0
         * 3. if an individual bet is correct -> win count of that bet increases by 1
         * 4. return total of reward
         */
        private int checkRewardResult()
        {
            int betSumRewardValueInt;   //variables for rewards
            int betDoubleRewardValueInt;
            int betDiceNumRewardValueInt;

            if (betSumCheckBox.Checked) //Check Bet Sum
            {
                int diceResultSumInt = diceOneInt + diceTwoInt;
                if (betSumValueInt == diceResultSumInt && betSumValueInt >= 1 && betSumValueInt <= 12)
                {
                    betSumRewardValueInt = 5;   //reward 5 if 1 <= guess <= 12
                    winSumNumInt ++;
                }
                else
                {
                    betSumRewardValueInt = -1;  //penalty
                }
            }
            else
            {
                betSumRewardValueInt = 0;
            }

            if (betDoubleCheckBox.Checked)  //Check Bet Double
            {
                if (diceOneInt == diceTwoInt)
                {
                    betDoubleRewardValueInt = 3;    //reward 3 if two dices have the same value
                    winDoubleNumInt ++;
                }
                else
                {
                    betDoubleRewardValueInt = -1;   //penalty
                }
            }
            else
            {
                betDoubleRewardValueInt = 0;
            }

            if (betDiceNumCheckBox.Checked) //Check Dice Num
            {
                int betDiceNumValueInt;
                string betDiceNumValueString = Convert.ToString(betDiceNumComboBox.Text);
                switch (betDiceNumValueString)
                {
                    case "1":
                        betDiceNumValueInt = 1;
                        break;
                    case "2":
                        betDiceNumValueInt = 2;
                        break;
                    case "3":
                        betDiceNumValueInt = 3;
                        break;
                    case "4":
                        betDiceNumValueInt = 4;
                        break;
                    case "5":
                        betDiceNumValueInt = 5;
                        break;
                    default:
                        betDiceNumValueInt = 6;
                        break;
                }
                if (diceOneInt == betDiceNumValueInt || diceTwoInt == betDiceNumValueInt)
                {
                    betDiceNumRewardValueInt = 1;   //reward 1 if any one dice has the same value as guess
                    winDiceNumNumInt ++;
                }
                else
                {
                    betDiceNumRewardValueInt = -1;  //penalty
                }
            }
            else
            {
                betDiceNumRewardValueInt = 0;
            }

            winNumInt = winSumNumInt + winDoubleNumInt + winDiceNumNumInt;

            return betSumRewardValueInt + betDoubleRewardValueInt + betDiceNumRewardValueInt;
        }
        //!!! CHECK BET CORRECT/UNCORRECT -> REWARD END !!!

        //### ROLL BUTTON CLICK ###
        //Check betNum < points, call checkBetNum
        //Call generateRandomDice individually, assign diceOneInt, diceTwoInt
        //Call getDiceFile, assign  diceResultInt -> diceOneInt, diceTwoInt individually. Display Image + textboxes
        //Call checkRewardResult -> call points
        private void rollButton_Click(object sender, EventArgs e)
        {
            rollNumInt++;

            int betNumTotalInt = checkBetNum(); // Check Number of Bet, proceed when betNum < points)
            if (betNumTotalInt > pointsTotalInt)
            {
                MessageBox.Show("sorry dude, not enough points");
            }
            else
            {
                //Call 3 exception methods
                //if check1ok, check2ok, check3ok then proceed. otherwise hang
                this.exceptionBetSum();
                this.exceptionBetDouble();
                this.exceptionBetDiceNum();

                if (betSumOk == 1 && betDoubleOk == 1 && betDiceNumOk == 1)
                {
                    diceOneInt = generateRandomDice();
                    diceTwoInt = generateRandomDice();

                    //display piz
                    string diceOneString = getDiceFile(diceOneInt);
                    string diceTwoString = getDiceFile(diceTwoInt);
                    diceOnePictureBox.Image = Image.FromFile(diceOneString);
                    diceTwoPictureBox.Image = Image.FromFile(diceTwoString);

                    // REWARDS (points + call checkReward)
                    pointsTotalInt += checkRewardResult();
                    winNumTextBox.Text = winNumInt.ToString();
                    pointsTotalTextBox.Text = pointsTotalInt.ToString();
                }

                if (pointsTotalInt == 0)    //If player reaches 0 points, app closes
                {
                    MessageBox.Show("fun time is over mate");
                    Application.Exit();
                }
            }
        }
        //!!! ROLL BUTTON CLICK END !!!

        //### SUMMARY ###
        private void summaryButton_Click(object sender, EventArgs e)
        {
            mySummaryForm.DisplayRollNum = rollNumInt;
            mySummaryForm.DisplayPointsTotal = pointsTotalInt;
            mySummaryForm.DisplayBetSumWin = winSumNumInt;
            mySummaryForm.DisplayBetDoubleWin = winDoubleNumInt;
            mySummaryForm.DislayBetDiceNumWin = winDiceNumNumInt;
            mySummaryForm.DisplayTopUpNum = topUpNumInt;

            mySummaryForm.ShowDialog();
        }
        //!!! SUMMARY END !!!

        //### NEW GAME ###
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //clear every textboxes
            //reset all variables to default values
            //reset combo box
            //unchecked all bet options
            pointsTotalInt = 10;
            pointsTotalTextBox.Text = pointsTotalInt.ToString();

            winNumInt = 0;
            winNumTextBox.Text = winNumInt.ToString();

            rollNumInt = 0;

            winSumNumInt = 0;
            winDoubleNumInt = 0;
            winDiceNumNumInt = 0;

            topUpNumInt = 0;
            topUpNumTextBox.Text = topUpNumInt.ToString();

            betSumCheckBox.Checked = false;
            betDoubleCheckBox.Checked = false;
            betDiceNumCheckBox.Checked = false;
            betSumTextBox.Clear();
            betDiceNumComboBox.SelectedIndex = -1;
        }
        //!!! NEW GAME END !!!

        //### COLOR ###
        public void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = this.BackColor;    //get default color from the current color of form
            colorDialog1.ShowDialog();              //new color = color chosen in colordialog
            this.BackColor = colorDialog1.Color;    //apply new color to all forms
            mySummaryForm.BackColor = this.BackColor;
            aboutForm.BackColor = this.BackColor;
            
        }
        //!!! COLOR END !!!

        //### ABOUT BOX ###
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutForm.ShowDialog();
        }
        //!!! ABOUT BOX END !!

        //### EXTRA FEATURE ###
        private void topUpButton_Click(object sender, EventArgs e)
        {
            if (topUpNumInt < 5)
            {
                topUpNumInt++;
                topUpNumTextBox.Text = topUpNumInt.ToString();

                pointsTotalInt += 10;
                pointsTotalTextBox.Text = pointsTotalInt.ToString();
            }
            else
            {
                MessageBox.Show("You should get back to work soon");
            }
        }
        //!!! EXTRA FEATURE END !!!
    }
}