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
    public partial class NewPuzzleForm : Form
    {
        string lastPIDString = null; //Use for the INFO label + checking during adding a new puzzle
        string currentPIDString = null;
        int addNewPuzzle = 1;       //Use to check whether the user have already added this puzzle

        public NewPuzzleForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void NewPuzzleForm_Activated(object sender, EventArgs e)
        {
            lastPIDString = pullLastPIDString();    //Get the Latest Puzzle ID
            infoLabel.Text = "The Puzzle ID must follow this syntax: SP + 2 digits \nThe lastest PID is "+lastPIDString+"";
        }

        private void pIDMaskedTextBox_Leave(object sender, EventArgs e)
        {
            sIDTextBox.Text = pIDMaskedTextBox.Text;    //Copy the string from PID to SID -> less error prone
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //##### ADD BUTTON STARTS #####
        /* Define an int existedPID = 0 (always prevent adding)
         * Check for validity of the 16 pBOXiTextBoxes (0 = something wrong, 1 OK)
         * Check for null in the pIDMaskedTextBox and the dIFFComboBox
         * If pIDMaskedTextBox is not null Call the PID check -> existedPID (return 0 = existed; 1  OK to use)
         * 
         * Proceed to check Uniqueness when validity == 1 && existedPID == 1
         * If all cells are unique, but addNewPuzzle = 0, break 
         *      (addPuzzle = 1 was defined at start. addPuzzle = 0 means the current Puzzle has already been successfully added)
         *      
         * If all cells are unique and addNewPuzzle = 1, proceed with adding the value to: PUZZLE and SOLUTION tables
         */ 
        private void addButton_Click(object sender, EventArgs e)
        {
            int existedPID = 0;
            int checkValidity = validityCheck();

            if (string.IsNullOrEmpty(pIDMaskedTextBox.Text))
            {
                MessageBox.Show("Please enter 2 numbers for the Puzzle ID", "Missing Puzzle ID");
            }

            else if (string.IsNullOrEmpty(dIFFComboBox.Text))
            {
                MessageBox.Show("Please choose a difficulty level", "Missing Difficulty Level");
            }

            else if (!string.IsNullOrEmpty(pIDMaskedTextBox.Text))
            {
                currentPIDString = "SP" + pIDMaskedTextBox.Text;
                existedPID = checkExistedPID();
                
                if (checkValidity == 1 && existedPID == 0)  //Checking for UNIQUE is done last | only proceed when validity check found no error
                {
                    MessageBox.Show("SEQUENCE with ID " + currentPIDString + " has already existed in the database", "SEQUENCE EXISTED");
                }
                else if (checkValidity == 1 && existedPID == 1)
                {
                    addPuzzle();
                }
            }
        }

        /* Insert into PUZZLE (PID, PNAME, DIFF) and SOLUTION (SID, PID) with their relevant values
         * Loop throught the values of the pBOXiTextBoxes to update the PUZZLE AND SOLUTION TABLE
         * Update each TextBoxes to its Cell in the PUZZLE table
         * Combine all TextBoxes into a 16 digits string to update the SOLUTION cell of the SOLUTION table
         */  
        private void addPuzzle()
        {
            int checkQUnique = checkQuadrantUnique();
            int checkVUnique = checkVerticalUnique();
            int checkHUnique = checkHorizontalUnique();

            if (checkQUnique == 1 && checkVUnique == 1 && checkHUnique == 1 && addNewPuzzle == 0)
            {
                MessageBox.Show("You have already added this sequence to the database", "SEQUENCE EXISTED");
            }
            else if (checkQUnique == 1 && checkVUnique == 1 && checkHUnique == 1 && addNewPuzzle == 1)
            {
                string ConnectionString = "Data Source=KTZ-VBXP32-DEV;Initial Catalog=SUDOKU;Integrated Security=True";
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                string sIDString = "SS" + sIDTextBox.Text;
                string dIFFString = dIFFComboBox.Text;
                string sqlUpdatePuzzleString1 = "INSERT INTO PUZZLE(PID,PNAME,DIFF) VALUES (" + "'" + currentPIDString + "'" + ", " + "'" + currentPIDString + "'" + ", " + "'" + dIFFString + "'" + ")";
                SqlCommand sqlUpdatePuzzleCmd1 = new SqlCommand(sqlUpdatePuzzleString1, conn);
                sqlUpdatePuzzleCmd1.ExecuteNonQuery();

                string solutionString = null;
                string sqlUpdateSolutionString1 = "INSERT INTO SOLUTION(SID,PID) VALUES (" + "'" + sIDString + "'" + ", " + "'" + currentPIDString + "'" + ")";
                SqlCommand sqlUpdateSolutionCmd1 = new SqlCommand(sqlUpdateSolutionString1, conn);
                sqlUpdateSolutionCmd1.ExecuteNonQuery();

                for (int i = 1; i < 17; i++)
                {
                    TextBox txt = Controls["pBOX" + i.ToString() + "TextBox"] as TextBox;
                    int pBOXInt = int.Parse(txt.Text);
                    string pBOXName = "PBOX" + i.ToString();
                    string sqlUpdatePuzzleString2 = "UPDATE PUZZLE SET " + pBOXName + " = " + "'" + pBOXInt + "'" + " WHERE PID = " + "'" + currentPIDString + "'" + "";
                    SqlCommand sqlUpdatePuzzleCmd2 = new SqlCommand(sqlUpdatePuzzleString2, conn);
                    sqlUpdatePuzzleCmd2.ExecuteNonQuery();

                    solutionString = solutionString + pBOXInt.ToString();
                    string sqlUpdateSolutionString2 = "UPDATE SOLUTION SET SOLUTION = " + "'" + solutionString + "'" + " WHERE SID = " + "'" + sIDString + "'" + "";
                    SqlCommand sqlUpdateSolutionCmd2 = new SqlCommand(sqlUpdateSolutionString2, conn);
                    sqlUpdateSolutionCmd2.ExecuteNonQuery();
                }

                conn.Close();

                addNewPuzzle = 0;   //Set the addNewPuzzle integer = 0 -> cannot add this puzzle again
                MessageBox.Show("The Sequence " + currentPIDString + " has been added to the database", "SUCCESS");

                lastPIDString = pullLastPIDString();    //Get the Latest Puzzle ID
                infoLabel.Text = "The Puzzle ID must follow this syntax: SP + 2 digits \nThe lastest PID is " + lastPIDString + "";
            }
        }
        //#!#!#!#!# ADD BUTTON ENDS #!#!#!#!#

        //##### RESET BUTTON STARTS #####
        //Clear all textboxes, difficulty combobox, get latest Puzzle ID, reset the addNewPuzzle check
        private void resetButton_Click(object sender, EventArgs e)
        {
            pIDMaskedTextBox.Clear();
            sIDTextBox.Clear();
            dIFFComboBox.SelectedIndex = -1;
            for (int i = 1; i < 17; i++)
            {
                TextBox txt = Controls["pBOX" + i.ToString() + "TextBox"] as TextBox;
                txt.Clear();
            }

            addNewPuzzle = 1;

            lastPIDString = pullLastPIDString();
            infoLabel.Text = "The Puzzle ID must follow this syntax: SP + 2 digits \nThe lastest PID is " + lastPIDString + "";
        }
        //#!#!#!#!# RESET BUTTON ENDS #!#!#!#!#


        //##### GET LATEST PID #####
        /* Get Column PID from table PUZZLE, Order it by DESC to get the latest one
         * Count the number of PID
         * If the countPID = 0 | there's no entries in the  PUZZLE table, set the digit part of the PID to 00
         * If the countPID = a number, proceed with checking the latest PID
         */
        private string pullLastPIDString()
        {
            string ConnectionString = "Data Source=KTZ-VBXP32-DEV;Initial Catalog=SUDOKU;Integrated Security=True";
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            string selectPIDString = "SELECT PID FROM PUZZLE ORDER BY PID DESC";
            SqlDataAdapter selectPIDDataAdapter = new SqlDataAdapter(selectPIDString, conn);
            DataTable pIDTable = new DataTable("pIDTable");
            selectPIDDataAdapter.Fill(pIDTable);

            string countPIDString = "SELECT COUNT(PID) FROM PUZZLE";
            SqlDataAdapter countPIDDataAdapter = new SqlDataAdapter(countPIDString, conn);
            DataTable countPIDTable = new DataTable("countPIDTable");
            countPIDDataAdapter.Fill(countPIDTable);

            conn.Close();

            string pIDString = null;
            if (countPIDTable.Rows[0].ItemArray[0].ToString() == "0")
            {
                pIDString = "00";
            }
            else
            {
                pIDString = pIDTable.Rows[0].ItemArray[0].ToString();
            }
            return pIDString;
        }
        //#!#!#!#!# GET LATEST PID ENDS #!#!#!#!#

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
                    MessageBox.Show("Please check whether the puzzle contains 16 numbers", "MISSING CELL(s)");
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

        //Check whether the current ID has already been used
        /* Get Column PID from table PUZZLE
         * Count the number of PID to use it as the limit in the ckeck loop
         * If the countPID == 0 | there's no entries in the PUZZLE table, return check existed = 1 (ok to use)
         * If the countPID != 0 number, proceed with check loop
         *      If the proposedPID == storedPID, break the loop, return check existed = 0 (already used)
         *      If cannot find a match, return check existed = 1
         */
        private int checkExistedPID()
        {
            int checkExistedPIDInt = 0;
            string ConnectionString = "Data Source=KTZ-VBXP32-DEV;Initial Catalog=SUDOKU;Integrated Security=True";
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            string selectPIDString = "SELECT PID FROM PUZZLE";
            SqlDataAdapter selectPIDDataAdapter = new SqlDataAdapter(selectPIDString, conn);
            DataTable pIDTable = new DataTable("pIDTable");
            selectPIDDataAdapter.Fill(pIDTable);

            string countPIDString = "SELECT COUNT(PID) FROM PUZZLE";
            SqlDataAdapter countPIDDataAdapter = new SqlDataAdapter(countPIDString, conn);
            DataTable countPIDTable = new DataTable("countPIDTable");
            countPIDDataAdapter.Fill(countPIDTable);

            if (countPIDTable.Rows[0].ItemArray[0].ToString() == "0")
            {
                checkExistedPIDInt = 1;
            }

            else if (countPIDTable.Rows[0].ItemArray[0].ToString() != "0")
            {
                for (int i = 0; i < Convert.ToInt32(countPIDTable.Rows[0].ItemArray[0].ToString()); i++)
                {
                    string storedPIDString = pIDTable.Rows[i].ItemArray[0].ToString();
                    if (currentPIDString == storedPIDString)
                    {
                        checkExistedPIDInt = 0;
                        break;
                    }
                    else
                    {
                        checkExistedPIDInt = 1;
                    }
                }
            }
            return checkExistedPIDInt;
        }
        //#!#!# EXEPTION HANDLING CHECKS END #!#!#

        //##### UNIQUENESS CHECKS START #####
        /* It involves create 4 virtual cells based on the integer i of the loop
         * as the integer i cannot be implicitly convert to the actual pBOXiTextBoxes
         * It's also easier to parse the value for these TextBoxes
         * Example: for quadrant 1.2.5.6; and 3.4.7.8
         *      integer i starts at 1, increase by 2 -> base pBOXiTextBoxes: 1, 3
         *      a = i = 1, b = i+4 = 5, c = i+5 = 6
         */
        private int checkQuadrantUnique()   //CHECK QUADRANTS FOR UNIQUENESS
        {
            int checkQuadrantUniqueInt = 0;
            for (int i = 1; i < 4; i += 2)  //Check 2top quads: 1 2 5 6; 3 4 7 8
            {                               //i has 2 values: 1, 3
                int a = i;                  //Base cell a = 1 3 | bcd are the subsequent cells in the quad
                int b = i + 1;
                int c = i + 4;
                int d = i + 5;
                TextBox cell0 = Controls["pBOX" + a.ToString() + "TextBox"] as TextBox;
                TextBox cell1 = Controls["pBOX" + b.ToString() + "TextBox"] as TextBox;
                TextBox cell2 = Controls["pBOX" + c.ToString() + "TextBox"] as TextBox;
                TextBox cell3 = Controls["pBOX" + d.ToString() + "TextBox"] as TextBox;
                int cell0Int = int.Parse(cell0.Text);
                int cell1Int = int.Parse(cell1.Text);
                int cell2Int = int.Parse(cell2.Text);
                int cell3Int = int.Parse(cell3.Text);
                if (cell0Int != cell1Int && cell0Int != cell2Int && cell0Int != cell3Int && cell1Int != cell2Int && cell1Int != cell3Int && cell2Int != cell3Int)
                {
                    //MessageBox.Show("quad unique");
                    checkQuadrantUniqueInt = 1;
                }
                else
                {
                    MessageBox.Show("1 quad not unique");
                    checkQuadrantUniqueInt = 0;
                }
            }
            for (int i = 9; i < 12; i += 2) //Check 2bottom quads: 9 10 13 14; 11 12 15 16
            {                               //i has 2 values: 9, 11
                int a = i;                  //Base cell a = 9 11 | bcd are the subsequent cells in the quad
                int b = i + 1;
                int c = i + 4;
                int d = i + 5;
                TextBox cell0 = Controls["pBOX" + a.ToString() + "TextBox"] as TextBox;
                TextBox cell1 = Controls["pBOX" + b.ToString() + "TextBox"] as TextBox;
                TextBox cell2 = Controls["pBOX" + c.ToString() + "TextBox"] as TextBox;
                TextBox cell3 = Controls["pBOX" + d.ToString() + "TextBox"] as TextBox;
                int cell0Int = int.Parse(cell0.Text);
                int cell1Int = int.Parse(cell1.Text);
                int cell2Int = int.Parse(cell2.Text);
                int cell3Int = int.Parse(cell3.Text);
                if (cell0Int != cell1Int && cell0Int != cell2Int && cell0Int != cell3Int && cell1Int != cell2Int && cell1Int != cell3Int && cell2Int != cell3Int)
                {
                    //MessageBox.Show("quad unique");
                    checkQuadrantUniqueInt = 1;
                }
                else
                {
                    MessageBox.Show("1 quad not unique");
                    checkQuadrantUniqueInt = 0;
                }
            }
            return checkQuadrantUniqueInt;
        }

        private int checkVerticalUnique()   //CHECK VERTICAL LINES FOR UNIQUENESS
        {
            int checkVerticalUniqueInt = 0;
            for (int i = 1; i < 5; i++)     //Vertical lines: 1 5 9 13; 2 6 10 14; 3 7 11 15; 4 8 12 16
            {                               //Loop starts at 1, increase by 1: 1 2 3 4
                int a = i;                  //Base cell a = 1 2 3 4 | bcd are the subsequent cells in the vLine
                int b = i + 4;
                int c = i + 8;
                int d = i + 12;
                TextBox cell0 = Controls["pBOX" + a.ToString() + "TextBox"] as TextBox;
                TextBox cell1 = Controls["pBOX" + b.ToString() + "TextBox"] as TextBox;
                TextBox cell2 = Controls["pBOX" + c.ToString() + "TextBox"] as TextBox;
                TextBox cell3 = Controls["pBOX" + d.ToString() + "TextBox"] as TextBox;
                int cell0Int = int.Parse(cell0.Text);
                int cell1Int = int.Parse(cell1.Text);
                int cell2Int = int.Parse(cell2.Text);
                int cell3Int = int.Parse(cell3.Text);
                if (cell0Int != cell1Int && cell0Int != cell2Int && cell0Int != cell3Int && cell1Int != cell2Int && cell1Int != cell3Int && cell2Int != cell3Int)
                {
                    //MessageBox.Show("vertical unique");
                    checkVerticalUniqueInt = 1;
                }
                else
                {
                    MessageBox.Show("1 vLine not unique");
                    checkVerticalUniqueInt = 0;
                }
            }
            return checkVerticalUniqueInt;
        }

        private int checkHorizontalUnique()     //CHECK HORIZONTAL LINES FOR UNIQUENESS
        {
            int checkHorizontalUniqueInt = 0;
            for (int i = 1; i < 14; i += 4)     //Horizontal lines: 1 2 3 4; 5 6 7 8; 9 10 11 12; 13 14 15 16 
            {                                   //Loop starts at 1, increase by 4: 1 5 9 13
                int a = i;                      //Base cell a = 1 5 9 13 | bcd are the subsequent cells in the hLine
                int b = i + 1;
                int c = i + 2;
                int d = i + 3;
                TextBox cell0 = Controls["pBOX" + a.ToString() + "TextBox"] as TextBox;
                TextBox cell1 = Controls["pBOX" + b.ToString() + "TextBox"] as TextBox;
                TextBox cell2 = Controls["pBOX" + c.ToString() + "TextBox"] as TextBox;
                TextBox cell3 = Controls["pBOX" + d.ToString() + "TextBox"] as TextBox;
                int cell0Int = int.Parse(cell0.Text);
                int cell1Int = int.Parse(cell1.Text);
                int cell2Int = int.Parse(cell2.Text);
                int cell3Int = int.Parse(cell3.Text);
                if (cell0Int != cell1Int && cell0Int != cell2Int && cell0Int != cell3Int && cell1Int != cell2Int && cell1Int != cell3Int && cell2Int != cell3Int)
                {
                    //MessageBox.Show("horizontal unique");
                    checkHorizontalUniqueInt = 1;
                }
                else
                {
                    MessageBox.Show("1 hLine not unique");
                    checkHorizontalUniqueInt = 0;
                }
            }
            return checkHorizontalUniqueInt;
        }
        //#!#!# UNIQUENESS CHECKS END #!#!#

        private void pUZZLEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pUZZLEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sUDOKUDataSet);
        }

        private void NewPuzzleForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sUDOKUDataSet.DIFFICULTY' table. You can move, or remove it, as needed.
            this.dIFFICULTYTableAdapter.Fill(this.sUDOKUDataSet.DIFFICULTY);
            // TODO: This line of code loads data into the 'sUDOKUDataSet.PUZZLE' table. You can move, or remove it, as needed.
            this.pUZZLETableAdapter.Fill(this.sUDOKUDataSet.PUZZLE);
        }
    }
}
