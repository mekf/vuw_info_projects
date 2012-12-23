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

namespace Personal_Fitness_Tracker
{
    public partial class PersonalFitnessTrackerForm : Form
    {
        //variable for catching simulation number
        int simulationNumberInterger;

        public PersonalFitnessTrackerForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            simulationNumberTextBox.Text = "0";

            //!NOT DONE - IMPROVEMENT: Think of a way to get timer working -> real time updated time
            dateTextBox.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");

        }

        //!NOT DONE: only allow text box to accept integer, one decimal dot
        //private void weightTextBox_TextChanged(object sender, EventArgs e)
        //{
            /*if(!Regex.IsMatch(weightTextBox.Text, @"[0-9]+(\.[0-9][0-9]?)?"))
            weightTextBox.BackColor = Color.Red;*/

            /*decimal value;
            if(!decimal.TryParse(weightTextBox.Text, out value))
            weightTextBox.BackColor = Color.Red;*/
        //}

        //###CLEAR TEXTBOXES###
        private void clearButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Clear();
            genderComboBox.SelectedIndex = -1;
            weightTextBox.Clear();
            heightTextBox.Clear();
            bMITextBox.Clear();
            aerobicsTextBox.Clear();
            runningTextBox.Clear();
            swimmingTextBox.Clear();
            hikingTextBox.Clear();
            walkingTextBox.Clear();
            sittingTextBox.Clear();
            caloTotalTextBox.Clear();
            infoTextBox.Clear();

        }

        //###PROGRAM TERMINATION###
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //###BMI CALCULATION###
        private void calculateBMIButton_Click(object sender, EventArgs e)
        {
            //simulation # increase by one regardless error states
            simulationNumberInterger++;
            simulationNumberTextBox.Text = simulationNumberInterger.ToString();
            //ghetto update for time
            dateTextBox.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");

            //declare variables
            decimal weightDecimal = 0;
            decimal heightDecimal = 0;
            decimal bMIDecimal = 0;

            //also declare as double for later cast -- Math.Pow
            double heightDouble = 0;
            double weightDouble = 0;
            double bMIDouble = 0;

            //1.check empty weightTextBox & heightTextBox -> display MessageBox -- 2.check validity --- 3.calc
            //1.CHECK EMPTY
            if (string.IsNullOrEmpty(weightTextBox.Text)) 
            {
                MessageBox.Show("weight?", "Entry Error");
                    weightTextBox.Focus();
            }
            else if (string.IsNullOrEmpty(heightTextBox.Text))
            {
                MessageBox.Show("height?", "Entry Error");
                    heightTextBox.Focus();
            }
            else
            {
                //2.VALIDITY CHECK
                //2.1 Weight
                try
                {
                    //parse string to value
                    weightDecimal = decimal.Parse(weightTextBox.Text);

                    //check data within valid range
                    if (weightDecimal < 0 || weightDecimal > 250)
                    {
                        MessageBox.Show("Please enter weight data within 0 - 250kg range", "Entry Error");
                        weightTextBox.Focus();
                        weightTextBox.SelectAll();
                    }
                }
                 
                catch
                {
                    MessageBox.Show("IV is no longer a half of V, please enter Weight as numerical data", "Entry Error");
                    weightTextBox.Focus();
                    weightTextBox.SelectAll();
                }
                //2.2 Height
                try
                {
                    //parse string to value
                    heightDecimal = decimal.Parse(heightTextBox.Text);

                    if (heightDecimal < 0 || heightDecimal > 2.5M)
                    {
                        MessageBox.Show("Please enter height data within 0 - 2.5m range", "Entry Error");
                        heightTextBox.Focus();
                        heightTextBox.SelectAll();
                    }
                    else
                    {   //3. CALCULATION is done within height check -> avoid devide by 0 or letter
                        //cast Decimal to Double, calc using Math.Pow, calculate BMI then display
                        heightDouble = (double)heightDecimal;
                        weightDouble = (double)weightDecimal;
                        bMIDouble = (double)bMIDecimal;

                        bMIDouble = weightDouble / Math.Pow(heightDouble, 2);
                        bMIDouble = Math.Round(bMIDouble, 1);

                        bMITextBox.Text = bMIDouble.ToString();
                    }
                }
                catch
                {
                    MessageBox.Show("IV is no longer a half of V, please enter Height as numerical data", "Entry Error");
                    heightTextBox.Focus();
                    heightTextBox.SelectAll();
                }
            }
            //4. CHECK END - CALCULATION END


            //###EXTRA FEATURE###
            //TEXTBOX TO DISPLAY BMI JOKEs
            try
            {
                if (bMIDouble < 0.1)
                {
                    infoTextBox.Text = "";
                }
                else if (bMIDouble < 16.5)
                {
                    infoTextBox.Text = "EAT (!!), the world is in a recession, help the economy and yourself";
                }
                else if (bMIDouble >= 16.5 & bMIDouble < 18.5)
                {
                    infoTextBox.Text = "(Underweight) gain some weight and you are good";
                }
                else if (bMIDouble >= 18.5 && bMIDouble < 25)
                {
                    infoTextBox.Text = "(Normal) spot on mate";
                }
                else if (bMIDouble >= 25 && bMIDouble < 30)
                {
                    infoTextBox.Text = "(Overweight) lose a few kg and you are good";
                }
                else if (bMIDouble > 30)
                {
                    infoTextBox.Text = "A JOKE (!?) even IT guys are lean these days";
                }
            }
            catch 
            {
                infoTextBox.Text = "";
            }

            //###EXTRA FEATURE END###
            
        }//###BMI CALCULATION END###

        //###CALORIES CALCULATION###
        private void calculateCaloButton_Click(object sender, EventArgs e)
        {
            //simulation # increase by one regardless error states
            simulationNumberInterger++;
            simulationNumberTextBox.Text = simulationNumberInterger.ToString();
            //ghetto update for time
            dateTextBox.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");

            const decimal AEROBICS_CALO_Decimal = 12.5M;
            const decimal RUNNING_CALO_Decimal = 14.2M;
            const decimal SITTING_CALO_Decimal = 1.3M;
            const decimal WALKING_CALO_Decimal = 5.7M;
            const decimal HIKING_CALO_Decimal = 18.9M;
            const decimal SWIMMING_CALO_Decimal = 11.3M;

            decimal aerobicsTimeDecimal = 0;
            decimal runningTimeDecimal = 0;
            decimal swimmingTimeDecimal = 0;
            decimal hikingTimeDecimal = 0;
            decimal walkingTimeDecimal = 0;
            decimal sittingTimeDecimal = 0;
            decimal caloTotalDecimal = 0;

            //1.check textboxes for input or use null = 0, extreme value is not relevant (one day, one week, one year?)
            try
            {
                //Aerobics
                if (string.IsNullOrEmpty(aerobicsTextBox.Text))
                {
                    aerobicsTimeDecimal = 0;
                }
                else
                {
                    aerobicsTimeDecimal = decimal.Parse(aerobicsTextBox.Text);
                }

                //Running
                if (string.IsNullOrEmpty(runningTextBox.Text))
                {
                    runningTimeDecimal = 0;
                }
                else
                {
                    runningTimeDecimal = decimal.Parse(runningTextBox.Text);
                }

                //Swimming
                if (string.IsNullOrEmpty(swimmingTextBox.Text))
                {
                    swimmingTimeDecimal = 0;
                }
                else
                {
                    swimmingTimeDecimal = decimal.Parse(swimmingTextBox.Text);
                }

                //Hiking
                if (string.IsNullOrEmpty(hikingTextBox.Text))
                {
                    hikingTimeDecimal = 0;
                }
                else
                {
                    hikingTimeDecimal = decimal.Parse(hikingTextBox.Text);
                }

                //Walking
                if (string.IsNullOrEmpty(walkingTextBox.Text))
                {
                    walkingTimeDecimal = 0;
                }
                else
                {
                    walkingTimeDecimal = decimal.Parse(walkingTextBox.Text);
                }

                //Sitting
                if (string.IsNullOrEmpty(sittingTextBox.Text))
                {
                    sittingTimeDecimal = 0;
                }
                else
                {
                    sittingTimeDecimal = decimal.Parse(sittingTextBox.Text);
                }
            }
            catch
            {
                MessageBox.Show("IV is no longer a half of V, please enter Calories as numerical data", "Entry Error");
            }//2. Check End
            
            //3.calculation and display
            caloTotalDecimal = aerobicsTimeDecimal * AEROBICS_CALO_Decimal + runningTimeDecimal * RUNNING_CALO_Decimal + swimmingTimeDecimal * SWIMMING_CALO_Decimal + hikingTimeDecimal * HIKING_CALO_Decimal + walkingTimeDecimal * WALKING_CALO_Decimal + sittingTimeDecimal * SITTING_CALO_Decimal;

            caloTotalDecimal = Math.Round(caloTotalDecimal, 1);
            caloTotalTextBox.Text = caloTotalDecimal.ToString();

        }//###CALORIES CALCULATION END###
    }
}