/* INFO241 - Assignment #2
 * Minh, HA 300113109
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace INFO241A2
{
    public partial class PlayForm : Form
    {
        string dIFFString;  //get these 2 strings from the ChoosePuzzleForm
        string pIDString;

        string userSolutionString = null;
        string currentRCODEString = null;

        int mytime = 0;
        int submitInt = 1;  //submitInt = 1 allows the user to keep adding solution. Only the correct solution set this int to = 0

        RankingForm disRankingForm;

        public PlayForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            disRankingForm = new RankingForm();
        }

        public string PassDIFF
        {
            set { dIFFString = value;} get { return dIFFString; }
        }

        public string PassPID
        {
            set { pIDString = value;} get { return pIDString; }
        }

        //##### FORM LOAD STARTS #####
        /* Enable the Timer
         * Clear the cheat label (which display the correct solution, update the label1 with current Puzzle ID
         * Connect to the Database SUDOKU, query table PUZZLE with the current PID, bind the data to a "tempTable"
         * 
         * Check whether the DIFFICULTY LEVEL is "Easy" or "Hard"
         * 
         * If "Easy"
         * Call the generateRandomNumber method for random number of these 8 pairs: 1.2; 3.4; 5.6; 7.8; 9.10; 11.12; 13.14; 15.16
         * Perform a loop with 16 values
         * Use a Control to generate the Name for the 16 TextBoxes
         * The value of the TextBox would be the next 2 cells from the int i of the loop
         * Example: (i = 1, pBOX1TextBox value = PBOX1, PBOX1 column = 4th [i + 2 = 3], Table count start at column 0
         * Example: (i = 6, pBOX6TextBox value = PBOX6, PBOX6 column = 9th [i + 2 = 8]
         * 
         * Check for a match between TextBox NAME == 8 random pairs
         *      If "Match" -> 8 display pBOXiTextBoxes
         *          Set them to Read Only, Disable Tab Stop, Bold Font
         *      If "NOT Match" -> 8 non-display pBOXiTextBoxes
         *          Clear them, change font color to Gray
         *      
         * If "Hard"
         * Call the generateRandomNumber method for a random number of each line: 1.2.3.4; 5.6.7.8; 9.10.11.12; 13.14.15.16
         * Same as Easy but only display 4 pBOXiTextBoxes
         */
        private void PlayForm_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
            cheatLabel.Text = null;
            label1.Text = "PuzzleID:" + " " + pIDString;

            if (dIFFString == "Easy")   //Easy: Display 2 cells per quadrant
            {
                easyDisplay();
            }
            else                        //Hard: Only display 1 cell per line
            {
                hardDisplay();
            }
        }

        private void easyDisplay()
        {
            string ConnectionString = "Data Source=KTZ-VBXP32-DEV;Initial Catalog=SUDOKU;Integrated Security=True";
            string selectPuzzleDataString = "SELECT * FROM PUZZLE WHERE PID = " + "'" + pIDString + "'" + "";
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            SqlDataAdapter selectPuzzleDataAdapter = new SqlDataAdapter(selectPuzzleDataString, conn);
            DataTable tempTable = new DataTable("tempPuzzle");
            selectPuzzleDataAdapter.Fill(tempTable);

            conn.Close();

            int q11Int = generateRandomNumber(1, 3);
            int q12Int = generateRandomNumber(5, 7);
            int q21Int = generateRandomNumber(3, 5);
            int q22Int = generateRandomNumber(7, 9);
            int q31Int = generateRandomNumber(9, 11);
            int q32Int = generateRandomNumber(13, 15);
            int q41Int = generateRandomNumber(11, 13);
            int q42Int = generateRandomNumber(15, 17);

            for (int i = 1; i < 17; i++)
            {
                if (i == q11Int || i == q12Int || i == q21Int || i == q22Int || i == q31Int || i == q32Int || i == q41Int || i == q42Int)
                {
                    TextBox displayTextBox = Controls["pBOX" + i.ToString() + "TextBox"] as TextBox;
                    displayTextBox.Text = tempTable.Rows[0].ItemArray[i + 2].ToString();
                    displayTextBox.ReadOnly = true;
                    displayTextBox.TabStop = false;
                    displayTextBox.Font = new Font(displayTextBox.Font, FontStyle.Bold);
                    displayTextBox.Font = displayTextBox.Font;
                }
                else
                {
                    TextBox nonDisplayTextBox = Controls["pBOX" + i.ToString() + "TextBox"] as TextBox;
                    nonDisplayTextBox.Text = tempTable.Rows[0].ItemArray[i + 2].ToString();
                    nonDisplayTextBox.ForeColor = Color.Gray;
                    nonDisplayTextBox.Clear();
                }
            }
        }

        private void hardDisplay()
        {
            string ConnectionString = "Data Source=KTZ-VBXP32-DEV;Initial Catalog=SUDOKU;Integrated Security=True";
            string selectPuzzleDataString = "SELECT * FROM PUZZLE WHERE PID = " + "'" + pIDString + "'" + "";
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            SqlDataAdapter selectPuzzleDataAdapter = new SqlDataAdapter(selectPuzzleDataString, conn);
            DataTable tempTable = new DataTable("tempPuzzle");
            selectPuzzleDataAdapter.Fill(tempTable);

            conn.Close();

            int l1Int = generateRandomNumber(1, 5);
            int l2Int = generateRandomNumber(5, 9);
            int l3Int = generateRandomNumber(9, 13);
            int l4Int = generateRandomNumber(13, 17);

            for (int i = 1; i < 17; i++)
            {
                if (i == l1Int || i == l2Int || i == l3Int || i == l4Int)
                {
                    TextBox displayTextBox = Controls["pBOX" + i.ToString() + "TextBox"] as TextBox;
                    displayTextBox.Text = tempTable.Rows[0].ItemArray[i + 2].ToString();
                    displayTextBox.ReadOnly = true;
                    displayTextBox.TabStop = false;
                    displayTextBox.Font = new Font(displayTextBox.Font, FontStyle.Bold);
                    displayTextBox.Font = displayTextBox.Font;
                }
                else
                {
                    TextBox nonDisplayTextBox = Controls["pBOX" + i.ToString() + "TextBox"] as TextBox;
                    nonDisplayTextBox.Text = tempTable.Rows[0].ItemArray[i + 2].ToString();
                    nonDisplayTextBox.ForeColor = Color.Gray;
                    nonDisplayTextBox.Clear();
                }
            }
        }
        //#!#!#!#!# FORM LOAD ENDS #!#!#!#!#

        //##### SUBMIT BUTTON STARTS #####
        /* Call the validityCheck method to check the 16 pBOXiTextBoxes: return 0 ; 1
         * Call the currentRCODE method to get the latest rCODE of the RESULT table
         * Get a current Timestamp
         * 
         * Generate an integer emailExistInt, return 0 ; 1
         *      If emailTextBox is null
         *          Display Messagebox, focus the cursor to the emailTextBox, return 0
         *      If emailTextBox is not null
         *          Return 1
         *  
         * If validityCheck == 1 && emailExistInt == 1
         *      Call checkCorrectSolution method to check the current userSolutionString (the checkCorrectSolution will get the latest userSolutionString)
         *      
         *      If correctSolution == 1 && submitInt == 1 (submitInt already defined as a public variable, = 1 at start)
         *          Write to table RESULT in SUDOKU (currentRCODE, Datetime.Now, currentPID, CORRECT = 1, userSolutionString, email, mytime)
         *          Set submitInt = 0 (disable future submitting of the current solution)
         *          Disable the Timer
         *          Display a congrat MessageBox
         *          Launch RaningForm
         *      
         *      If correctSolution == 0 && submitInt == 1
         *          Write to table RESULT in SUDOKU (currentRCODE, Datetime.Now, currentPID, CORRECT = 0, userSolutionString, email, mytime)
         *          Set submitInt = 1 (future submitting is possible)
         *          Display a MessagBox telling the user to check their answer
         *          
         *      If validityCheck == 1 == && submitInt == 0 should not be needed but was left there as a fail safe
         */
        private void submitButton_Click(object sender, EventArgs e)
        {
            int checkValidity = validityCheck();
            currentRCODEString = currentRCODE();

            int emailExistInt = 0;
            if (string.IsNullOrEmpty(emailTextBox.Text))                                        //Check for existence of email
            {
                MessageBox.Show("Which Constellation are you at now, StarHopper?");
                emailTextBox.Focus();
                emailExistInt = 0;
            }
            else
            {
                emailExistInt = 1;
            }

            if (checkValidity == 1 && emailExistInt == 1)                                       //Only proceed once textboxes and email are valid 
            {
                int correctSolution = checkCorrectSolution();                                   //Call checkCorrectSolution method 
                if (correctSolution == 1 && submitInt == 1)                                     //Proceed to ADO code once correctSolution returns 1 and there's a chance to submit
                {
                    correctSubmit();
                }

                else if (correctSolution == 0 && submitInt == 1)
                {
                    unCorrectSubmit();
                    timer1.Enabled = true;
                }

                else if (correctSolution == 1 && submitInt == 0)
                {
                    MessageBox.Show("You have already submitted the solution");
                }
            }
        }

        private void correctSubmit()
        {
            timer1.Enabled = false;

            string ConnectionString = "Data Source=KTZ-VBXP32-DEV;Initial Catalog=SUDOKU;Integrated Security=True";
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            DateTime currentDateTime = DateTime.Now;
            string rCODE1 = "PY" + currentRCODEString;
            string eMAIL1 = emailTextBox.Text;
            string cLOCKTIME1 = clockTimeTextBox.Text;
            string updateResultString = "INSERT INTO RESULT(RCODE,DATETIME,PID,CORRECT,SOLUTION,EMAIL,CLOCKTIME) VALUES (" + "'" + rCODE1 + "'" + ", " + "'" + currentDateTime + "'" + ", " + "'" + pIDString + "'" + ", " + 1 + ", " + "'" + userSolutionString + "'" + "," + "'" + eMAIL1 + "'" + "," + cLOCKTIME1 + ")";
            SqlCommand updateResultCommand = new SqlCommand(updateResultString, conn);
            updateResultCommand.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Added the correct sequence into the database with RCODE " + rCODE1 + " \nGOOD JOB", "SUCCESS");
            submitInt = 0;
            disRankingForm.Show();
        }

        private void unCorrectSubmit()
        {
            timer1.Enabled = false;
            string ConnectionString = "Data Source=KTZ-VBXP32-DEV;Initial Catalog=SUDOKU;Integrated Security=True";
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            DateTime currentDateTime = DateTime.Now;
            string rCODE1 = "PY" + currentRCODEString;
            string eMAIL1 = emailTextBox.Text;
            string cLOCKTIME1 = clockTimeTextBox.Text;
            string updateResultString = "INSERT INTO RESULT(RCODE,DATETIME,PID,CORRECT,SOLUTION,EMAIL,CLOCKTIME) VALUES (" + "'" + rCODE1 + "'" + ", " + "'" + currentDateTime + "'" + ", " + "'" + pIDString + "'" + ", " + 0 + ", " + "'" + userSolutionString + "'" + "," + "'" + eMAIL1 + "'" + "," + cLOCKTIME1 + ")";
            SqlCommand updateResultCommand = new SqlCommand(updateResultString, conn);
            updateResultCommand.ExecuteNonQuery();

            conn.Close();

            submitInt = 1;
            MessageBox.Show("Added the sequence into the database with RCODE " + rCODE1 + " \nBUT YOUR SOLUTION IS NOT CORRECT! PLEASE CHECK", "NOT SUCCESS");
        }
        //#!#!#!#!# SUBMIT BUTTON ENDS #!#!#!#!#

        //##### CHEAT BUTTON STARTS #####
        /* Connect to the SOLUTION Table and get column SOLUTION
         * Break the 16digits strings into 4digits substrings: first4(0,4) second4(4,4) third4(8,4) remainging4(12)
         * Display it on the cheatLabel
         */
        private void cheatButton_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=KTZ-VBXP32-DEV;Initial Catalog=SUDOKU;Integrated Security=True";
            string selectSolutionDataString = "SELECT SOLUTION FROM SOLUTION WHERE PID = " + "'" + pIDString + "'" + "";
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            SqlDataAdapter selectSolutionDataAdapter = new SqlDataAdapter(selectSolutionDataString, conn);
            DataTable solutionTable = new DataTable("solutionTable");
            selectSolutionDataAdapter.Fill(solutionTable);

            conn.Close();

            cheatLabel.Text = "L=>R" + " " + "|" + " " +
                                solutionTable.Rows[0].ItemArray[0].ToString().Substring(0, 4) + " " +
                                solutionTable.Rows[0].ItemArray[0].ToString().Substring(4, 4) + " " +
                                solutionTable.Rows[0].ItemArray[0].ToString().Substring(8, 4) + " " +
                                solutionTable.Rows[0].ItemArray[0].ToString().Substring(12);
        }
        //#!#!#!#!# CHEAT BUTTON ENDS #!#!#!#!#

        //##### RESET BUTTON STARTS #####
        /* Reset the Timer, cheat label
         * Reset the 16 pBOXiTextBoxes to their original states
         * Then do the same thing as the Formload does
         */ 
        private void resetButton_Click(object sender, EventArgs e)
        {
            mytime = 0;

            cheatLabel.Text = null;
            label1.Text = "PuzzleID:" + " " + pIDString;

            for (int i = 1; i < 17; i++)                                                //Reset the 16 boxes to their original states
            {
                TextBox txt = Controls["pBOX" + i.ToString() + "TextBox"] as TextBox;
                txt.Clear();
                txt.ForeColor = Color.Black;
                txt.ReadOnly = false;
                txt.TabStop = true;
            }

            string ConnectionString = "Data Source=KTZ-VBXP32-DEV;Initial Catalog=SUDOKU;Integrated Security=True";
            string selectPuzzleDataString = "SELECT * FROM PUZZLE WHERE PID = " + "'" + pIDString + "'" + "";
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            SqlDataAdapter selectPuzzleDataAdapter = new SqlDataAdapter(selectPuzzleDataString, conn);
            DataTable tempTable = new DataTable("tempPuzzle");
            selectPuzzleDataAdapter.Fill(tempTable);

            conn.Close();

            if (dIFFString == "Easy")
            {
                easyDisplay();
            }
            else
            {
                hardDisplay();
            }
        }
        //#!#!#!#!# RESET BUTTON ENDS #!#!#!#!#

        private void timer1_Tick(object sender, EventArgs e)        //Timer
        {
            mytime = mytime + 1;
            clockTimeTextBox.Text = mytime.ToString();
        }

        private int generateRandomNumber(int minInt, int maxInt)    //Random Number which will be called by FormLoad and ResetButton
        {
            Random random = new Random();
            System.Threading.Thread.Sleep(150);
            return random.Next(minInt, maxInt);
        }

        //##### EXEPTION HANDLING CHECK START #####
        /* Check if any of the 16 pBOXiTextBoxes is null
         * If null, warn the user, if not return = 1
         * Check the validity of the 16pBOXiTextBoxes
         *      Call the null check first
         *      Check numerical and range 1~4
         */
        private int nullCheck()
        {
            int nullCheckInt = 0;
            for (int i = 1; i < 17; i++)
            {
                TextBox txt = Controls["pBOX" + i.ToString() + "TextBox"] as TextBox;
                if (string.IsNullOrEmpty(txt.Text))
                {
                    nullCheckInt = 0;
                    MessageBox.Show("Please check whether the puzzle contains 16 numbers", "Missing Sudoku Cell");
                    break;
                }
                else
                {
                    nullCheckInt = 1;
                }
            }
            return nullCheckInt;
        }

        private int validityCheck()
        {
            int validityCheckInt = 0;
            int checkNull = nullCheck();
            if (checkNull == 1)
            {
                for (int i = 1; i < 17; i++)
                {
                    TextBox txt = Controls["pBOX" + i.ToString() + "TextBox"] as TextBox;
                    int num;
                    bool isNumeric = int.TryParse(txt.Text, out num);
                    if (isNumeric)
                    {
                        num = int.Parse(txt.Text);
                        if (0 > num || num > 4) //Is Numerical and within range 1~4
                        {
                            validityCheckInt = 0;
                            MessageBox.Show("Please only use numbers from 1~4 in the puzzle", "INVALID INPUT");
                            txt.Focus();
                            txt.SelectionStart = 0;
                            txt.SelectionLength = txt.Text.Length;
                            break;
                        }
                        else                    //Is Numerical But out of range 1~4
                        {
                            validityCheckInt = 1;
                        }
                    }
                    else                        //Is not numerical
                    {
                        validityCheckInt = 0;
                        MessageBox.Show("Please only use numbers from 1~4 in the puzzle", "INVALID INPUT");
                        txt.Focus();
                        txt.SelectionStart = 0;
                        txt.SelectionLength = txt.Text.Length;
                        break;
                    }
                }
            }
            return validityCheckInt;
        }
        //#!#!#!#!# EXEPTION HANDLING CHECKS END #!#!#!#!#

        //##### GET CURRENT RCODE #####
        /* Get Column RCODE from table RESULT, Order it by DESC to get the latest one
         * Count the number of RCODE
         * If the countRCODE == 0, there's no entries in the RESULT table, set the digit part of the RCODE to 01
         * If the countRCODE != 0, proceed with checking the latest RCODE
         * 
         * Break the RCODE into a substring. The RCODE format is PY00, the subtring(2) get the remaining letters, starting from the 3rd one (00)
         * Break this substring into another substring(0,1) to check whether the RCODE is still in 1~9 range
         * Example: PY08 -> 08 -> 0
         * 
         * If it's still in 1~9 range, + 1 to get the current RCODE, then append a 0.
         * Example: PY08 -> 08 -> 0. 8 + 1 = 9, then "0" + 9.ToString
         * 
         * If it's in the 2 digits range, just + 1
         */ 
        private string currentRCODE()
        {
            string ConnectionString = "Data Source=KTZ-VBXP32-DEV;Initial Catalog=SUDOKU;Integrated Security=True";
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            string selectRCODEString = "SELECT RCODE FROM RESULT ORDER BY RCODE DESC";
            SqlDataAdapter selectRCODEDataAdapter = new SqlDataAdapter(selectRCODEString, conn);
            DataTable rCODETable = new DataTable("rCODETable");
            selectRCODEDataAdapter.Fill(rCODETable);

            string countRCODEString = "SELECT COUNT(RCODE) FROM RESULT";
            SqlDataAdapter countRCODEDataAdapter = new SqlDataAdapter(countRCODEString, conn);
            DataTable countRCODETable = new DataTable("countRCODETable");
            countRCODEDataAdapter.Fill(countRCODETable);

            conn.Close();

            if (countRCODETable.Rows[0].ItemArray[0].ToString() == "0")
            {
                currentRCODEString = "01";
            }
            else
            {
                string lastRCODEString = rCODETable.Rows[0].ItemArray[0].ToString().Substring(2);
                int lastRCODEInt = Convert.ToInt32(lastRCODEString);
                if (lastRCODEString.Substring(0, 1).Contains("0") && !lastRCODEString.Substring(0, 1).Contains("0"))
                {
                    currentRCODEString = "0" + (lastRCODEInt + 1).ToString();
                }
                else
                {
                    currentRCODEString = (lastRCODEInt + 1).ToString();
                }
            }
            return currentRCODEString;
        }
        //#!#!#!#!# GET CURRENT RCODE ENDS #!#!#!#!#

        //##### UPDATE LATEST USER SOLUTION THEN CHECK FOR CORRECT SOLUTION #####
        /* Loop the pBOXiTextBoxes 16 times, append the value for each on to the userSolutionString
         * Get the SOLUTION column from SOLUTION table, compare this with userSolutionString
         * Return check = 0 (not correct); 1 (correct) to be used in the submitButton
         */ 
        private string getUserSolution()
        {
            userSolutionString = null;
            for (int i = 1; i < 17; i++)
            {
                TextBox txt = Controls["pBOX" + i.ToString() + "TextBox"] as TextBox;
                userSolutionString += txt.Text;
            }
            return userSolutionString;
        }
      
        private int checkCorrectSolution()
        {
            string ConnectionString = "Data Source=KTZ-VBXP32-DEV;Initial Catalog=SUDOKU;Integrated Security=True";
            string selectPuzzleDataString = "SELECT SOLUTION FROM SOLUTION WHERE PID = " + "'" + pIDString + "'" + "";
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            SqlDataAdapter selectPuzzleDataAdapter = new SqlDataAdapter(selectPuzzleDataString, conn);
            DataTable solutionTable = new DataTable("solutionTable");
            selectPuzzleDataAdapter.Fill(solutionTable);

            conn.Close();

            int correctSolutionCheckInt = 0;
            string correctSolution = solutionTable.Rows[0].ItemArray[0].ToString();

            userSolutionString = getUserSolution();

            if (userSolutionString == correctSolution)
            {
                correctSolutionCheckInt = 1;
            }
            else
            {
                correctSolutionCheckInt = 0;
            }
            return correctSolutionCheckInt;
        }
        //#!#!#!#!# UPDATE LATEST USER SOLUTION THEN CHECK FOR CORRECT SOLUTION ENDS #!#!#!#!#
    }
}
