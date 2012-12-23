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
    public partial class AdminAuthenticationForm : Form
    {
        NewPuzzleForm addNewPuzzleForm;
        public AdminAuthenticationForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            addNewPuzzleForm = new NewPuzzleForm();
        }

        private void AdminAuthenticationForm_Activated(object sender, EventArgs e)
        {
            errorLabel.Text = "";
            usernameTextBox.Clear();
            passwordTextBox.Clear();
            usernameTextBox.Focus();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
   
        private void logInButton_Click(object sender, EventArgs e)
        {
            authAdmin();
        }

        private void usernameTextBox_KeyPress(object sender, KeyPressEventArgs e)   //Press Enter -> focus Password TextBox
        {
            if (e.KeyChar == (char)13)
            {
                passwordTextBox.Focus();
            }
        }

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)   //Press Enter -> Authenticate Username/Password 
        {
            if (e.KeyChar == (char)13)
            {
                authAdmin();
            }
        }

        //##### AUTHENTICATE ADMIN ######
        /* Query the ADMIN table
         * Count the number of USERNAME (assuming that there's always an admin)
         * Use the count as the limit for the check loop
         * ONLY PROCEED WITH LOGIN CHECKS IF USERNAME AND PASSWORD IS NOT NULL
         * 
         * count returns a number from 1 -> last number in the table
         * loop starts from 0 -> (the last number returned from count) -1
         * Username = row i and column 2 of the database (ID,Username,Password)
         * Password = row i and column 3 of the database
         * loop breaks when Username or Password is found
         *                    
         * Username and Password matched
         * Hide the LogIn formm and start the Add Puzzle form
         */
        private void authAdmin()
        {
            string usernameString = null;
            string passwordString = null;
            if (string.IsNullOrEmpty(usernameTextBox.Text) || string.IsNullOrEmpty(passwordTextBox.Text))
            {
                MessageBox.Show("Please Enter Username AND/OR Password", "No Username And/Or Password");
            }
            else
            {
                usernameString = usernameTextBox.Text;
                passwordString = passwordTextBox.Text;

                string ConnectionString = "Data Source=KTZ-VBXP32-DEV;Initial Catalog=SUDOKU;Integrated Security=True";
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                string selectAdminDataString = "SELECT * FROM ADMIN";
                SqlDataAdapter selectAdminDataAdapter = new SqlDataAdapter(selectAdminDataString, conn);
                DataTable adminTable = new DataTable("adminTable");
                selectAdminDataAdapter.Fill(adminTable);

                string countAdminDataString = "SELECT COUNT(USERNAME) FROM ADMIN";
                SqlDataAdapter countAdminDataAdapter = new SqlDataAdapter(countAdminDataString, conn);
                DataTable adminTableCount = new DataTable("adminTableCount");
                countAdminDataAdapter.Fill(adminTableCount);

                conn.Close();

                int adminNum = int.Parse(adminTableCount.Rows[0].ItemArray[0].ToString());
                for (int i = 0; i < adminNum; i++)
                {
                    string storedUsernameString = adminTable.Rows[i].ItemArray[1].ToString();
                    string storedPasswordString = adminTable.Rows[i].ItemArray[2].ToString();
                    if (usernameString != storedUsernameString && passwordString == storedPasswordString)
                    {
                        errorLabel.Text = "Incorrect Username!\nHINT: Default settings of a Linksys router.";
                    }
                    else if (usernameString == storedUsernameString && passwordString != storedPasswordString)
                    {
                        errorLabel.Text = "Incorrect Password!\nHINT: Default settings of a Linksys router.";
                    }
                    else if (usernameString == storedUsernameString && passwordString == storedPasswordString)
                    {
                        this.Hide();
                        addNewPuzzleForm.Show();
                        break;
                    }
                }
            }
        }
    }
}
