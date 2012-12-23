namespace Personal_Fitness_Tracker
{
    partial class PersonalFitnessTrackerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalFitnessTrackerForm));
            this.bMIGroupBox = new System.Windows.Forms.GroupBox();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.bMIPictureBox = new System.Windows.Forms.PictureBox();
            this.calculateBMIButton = new System.Windows.Forms.Button();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.bMITextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.bMILabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.caloriesGroupBox = new System.Windows.Forms.GroupBox();
            this.calculateCaloButton = new System.Windows.Forms.Button();
            this.hikingLabel = new System.Windows.Forms.Label();
            this.timeLabel2 = new System.Windows.Forms.Label();
            this.caloTotalTextBox = new System.Windows.Forms.TextBox();
            this.timeLabel1 = new System.Windows.Forms.Label();
            this.walkingLabel = new System.Windows.Forms.Label();
            this.sittingTextBox = new System.Windows.Forms.TextBox();
            this.swimmingTextBox = new System.Windows.Forms.TextBox();
            this.walkingTextBox = new System.Windows.Forms.TextBox();
            this.runningTextBox = new System.Windows.Forms.TextBox();
            this.aerobicsLabel = new System.Windows.Forms.Label();
            this.hikingTextBox = new System.Windows.Forms.TextBox();
            this.aerobicsTextBox = new System.Windows.Forms.TextBox();
            this.sittingLabel = new System.Windows.Forms.Label();
            this.runningLabel = new System.Windows.Forms.Label();
            this.totalCaloLabel = new System.Windows.Forms.Label();
            this.swimmingLabel = new System.Windows.Forms.Label();
            this.simulationNumberLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.simulationNumberTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bMIGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bMIPictureBox)).BeginInit();
            this.caloriesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // bMIGroupBox
            // 
            this.bMIGroupBox.Controls.Add(this.infoTextBox);
            this.bMIGroupBox.Controls.Add(this.bMIPictureBox);
            this.bMIGroupBox.Controls.Add(this.calculateBMIButton);
            this.bMIGroupBox.Controls.Add(this.genderComboBox);
            this.bMIGroupBox.Controls.Add(this.bMITextBox);
            this.bMIGroupBox.Controls.Add(this.heightTextBox);
            this.bMIGroupBox.Controls.Add(this.weightTextBox);
            this.bMIGroupBox.Controls.Add(this.nameTextBox);
            this.bMIGroupBox.Controls.Add(this.bMILabel);
            this.bMIGroupBox.Controls.Add(this.heightLabel);
            this.bMIGroupBox.Controls.Add(this.weightLabel);
            this.bMIGroupBox.Controls.Add(this.genderLabel);
            this.bMIGroupBox.Controls.Add(this.nameLabel);
            this.bMIGroupBox.Location = new System.Drawing.Point(7, 38);
            this.bMIGroupBox.Name = "bMIGroupBox";
            this.bMIGroupBox.Size = new System.Drawing.Size(380, 230);
            this.bMIGroupBox.TabIndex = 0;
            this.bMIGroupBox.TabStop = false;
            this.bMIGroupBox.Text = "BMI Calculator";
            // 
            // infoTextBox
            // 
            this.infoTextBox.Location = new System.Drawing.Point(5, 199);
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.ReadOnly = true;
            this.infoTextBox.Size = new System.Drawing.Size(370, 21);
            this.infoTextBox.TabIndex = 7;
            this.infoTextBox.TabStop = false;
            this.infoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bMIPictureBox
            // 
            this.bMIPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("bMIPictureBox.Image")));
            this.bMIPictureBox.Location = new System.Drawing.Point(193, 11);
            this.bMIPictureBox.Name = "bMIPictureBox";
            this.bMIPictureBox.Size = new System.Drawing.Size(182, 182);
            this.bMIPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bMIPictureBox.TabIndex = 6;
            this.bMIPictureBox.TabStop = false;
            // 
            // calculateBMIButton
            // 
            this.calculateBMIButton.Location = new System.Drawing.Point(74, 130);
            this.calculateBMIButton.Name = "calculateBMIButton";
            this.calculateBMIButton.Size = new System.Drawing.Size(100, 21);
            this.calculateBMIButton.TabIndex = 5;
            this.calculateBMIButton.Text = "Calculate &BMI";
            this.toolTip1.SetToolTip(this.calculateBMIButton, "Calculate BMI");
            this.calculateBMIButton.UseVisualStyleBackColor = true;
            this.calculateBMIButton.Click += new System.EventHandler(this.calculateBMIButton_Click);
            // 
            // genderComboBox
            // 
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderComboBox.Location = new System.Drawing.Point(74, 51);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(100, 21);
            this.genderComboBox.TabIndex = 2;
            // 
            // bMITextBox
            // 
            this.bMITextBox.Location = new System.Drawing.Point(73, 173);
            this.bMITextBox.Name = "bMITextBox";
            this.bMITextBox.ReadOnly = true;
            this.bMITextBox.Size = new System.Drawing.Size(100, 21);
            this.bMITextBox.TabIndex = 1;
            this.bMITextBox.TabStop = false;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(74, 104);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(100, 21);
            this.heightTextBox.TabIndex = 4;
            this.toolTip1.SetToolTip(this.heightTextBox, "Your Height in m");
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(74, 78);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 21);
            this.weightTextBox.TabIndex = 3;
            this.toolTip1.SetToolTip(this.weightTextBox, "Your Weight in kg");
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(74, 25);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 21);
            this.nameTextBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.nameTextBox, "Your Name Please");
            // 
            // bMILabel
            // 
            this.bMILabel.AutoSize = true;
            this.bMILabel.Location = new System.Drawing.Point(26, 176);
            this.bMILabel.Name = "bMILabel";
            this.bMILabel.Size = new System.Drawing.Size(36, 13);
            this.bMILabel.TabIndex = 0;
            this.bMILabel.Text = "BMI =";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(8, 107);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(57, 13);
            this.heightLabel.TabIndex = 0;
            this.heightLabel.Text = "Height (m)";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(8, 81);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(63, 13);
            this.weightLabel.TabIndex = 0;
            this.weightLabel.Text = "Weight (kg)";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(8, 55);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(42, 13);
            this.genderLabel.TabIndex = 0;
            this.genderLabel.Text = "Gender";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(8, 29);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(34, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // caloriesGroupBox
            // 
            this.caloriesGroupBox.Controls.Add(this.calculateCaloButton);
            this.caloriesGroupBox.Controls.Add(this.hikingLabel);
            this.caloriesGroupBox.Controls.Add(this.timeLabel2);
            this.caloriesGroupBox.Controls.Add(this.caloTotalTextBox);
            this.caloriesGroupBox.Controls.Add(this.timeLabel1);
            this.caloriesGroupBox.Controls.Add(this.walkingLabel);
            this.caloriesGroupBox.Controls.Add(this.sittingTextBox);
            this.caloriesGroupBox.Controls.Add(this.swimmingTextBox);
            this.caloriesGroupBox.Controls.Add(this.walkingTextBox);
            this.caloriesGroupBox.Controls.Add(this.runningTextBox);
            this.caloriesGroupBox.Controls.Add(this.aerobicsLabel);
            this.caloriesGroupBox.Controls.Add(this.hikingTextBox);
            this.caloriesGroupBox.Controls.Add(this.aerobicsTextBox);
            this.caloriesGroupBox.Controls.Add(this.sittingLabel);
            this.caloriesGroupBox.Controls.Add(this.runningLabel);
            this.caloriesGroupBox.Controls.Add(this.totalCaloLabel);
            this.caloriesGroupBox.Controls.Add(this.swimmingLabel);
            this.caloriesGroupBox.Location = new System.Drawing.Point(7, 276);
            this.caloriesGroupBox.Name = "caloriesGroupBox";
            this.caloriesGroupBox.Size = new System.Drawing.Size(380, 200);
            this.caloriesGroupBox.TabIndex = 1;
            this.caloriesGroupBox.TabStop = false;
            this.caloriesGroupBox.Text = "Calories Burned Calculator";
            // 
            // calculateCaloButton
            // 
            this.calculateCaloButton.Location = new System.Drawing.Point(140, 136);
            this.calculateCaloButton.Name = "calculateCaloButton";
            this.calculateCaloButton.Size = new System.Drawing.Size(100, 21);
            this.calculateCaloButton.TabIndex = 12;
            this.calculateCaloButton.Text = "Calculate &Calories";
            this.toolTip1.SetToolTip(this.calculateCaloButton, "Calculate Calories");
            this.calculateCaloButton.UseVisualStyleBackColor = true;
            this.calculateCaloButton.Click += new System.EventHandler(this.calculateCaloButton_Click);
            // 
            // hikingLabel
            // 
            this.hikingLabel.AutoSize = true;
            this.hikingLabel.Location = new System.Drawing.Point(207, 50);
            this.hikingLabel.Name = "hikingLabel";
            this.hikingLabel.Size = new System.Drawing.Size(35, 13);
            this.hikingLabel.TabIndex = 0;
            this.hikingLabel.Text = "Hiking";
            // 
            // timeLabel2
            // 
            this.timeLabel2.AutoSize = true;
            this.timeLabel2.Location = new System.Drawing.Point(259, 31);
            this.timeLabel2.Name = "timeLabel2";
            this.timeLabel2.Size = new System.Drawing.Size(90, 13);
            this.timeLabel2.TabIndex = 0;
            this.timeLabel2.Text = "Time spent (min.)";
            // 
            // caloTotalTextBox
            // 
            this.caloTotalTextBox.Location = new System.Drawing.Point(193, 163);
            this.caloTotalTextBox.Name = "caloTotalTextBox";
            this.caloTotalTextBox.ReadOnly = true;
            this.caloTotalTextBox.Size = new System.Drawing.Size(169, 21);
            this.caloTotalTextBox.TabIndex = 1;
            this.caloTotalTextBox.TabStop = false;
            // 
            // timeLabel1
            // 
            this.timeLabel1.AutoSize = true;
            this.timeLabel1.Location = new System.Drawing.Point(71, 31);
            this.timeLabel1.Name = "timeLabel1";
            this.timeLabel1.Size = new System.Drawing.Size(90, 13);
            this.timeLabel1.TabIndex = 0;
            this.timeLabel1.Text = "Time spent (min.)";
            // 
            // walkingLabel
            // 
            this.walkingLabel.AutoSize = true;
            this.walkingLabel.Location = new System.Drawing.Point(207, 76);
            this.walkingLabel.Name = "walkingLabel";
            this.walkingLabel.Size = new System.Drawing.Size(44, 13);
            this.walkingLabel.TabIndex = 0;
            this.walkingLabel.Text = "Walking";
            // 
            // sittingTextBox
            // 
            this.sittingTextBox.Location = new System.Drawing.Point(262, 99);
            this.sittingTextBox.Name = "sittingTextBox";
            this.sittingTextBox.Size = new System.Drawing.Size(100, 21);
            this.sittingTextBox.TabIndex = 11;
            this.toolTip1.SetToolTip(this.sittingTextBox, "Time Spent Doing Sitting in Minutes");
            // 
            // swimmingTextBox
            // 
            this.swimmingTextBox.Location = new System.Drawing.Point(74, 99);
            this.swimmingTextBox.Name = "swimmingTextBox";
            this.swimmingTextBox.Size = new System.Drawing.Size(100, 21);
            this.swimmingTextBox.TabIndex = 8;
            this.toolTip1.SetToolTip(this.swimmingTextBox, "Time Spent Doing Swimming in Minutes");
            // 
            // walkingTextBox
            // 
            this.walkingTextBox.Location = new System.Drawing.Point(262, 73);
            this.walkingTextBox.Name = "walkingTextBox";
            this.walkingTextBox.Size = new System.Drawing.Size(100, 21);
            this.walkingTextBox.TabIndex = 10;
            this.toolTip1.SetToolTip(this.walkingTextBox, "Time Spent Doing Walking in Minutes");
            // 
            // runningTextBox
            // 
            this.runningTextBox.Location = new System.Drawing.Point(74, 73);
            this.runningTextBox.Name = "runningTextBox";
            this.runningTextBox.Size = new System.Drawing.Size(100, 21);
            this.runningTextBox.TabIndex = 7;
            this.toolTip1.SetToolTip(this.runningTextBox, "Time Spent Doing Running in Minutes");
            // 
            // aerobicsLabel
            // 
            this.aerobicsLabel.AutoSize = true;
            this.aerobicsLabel.Location = new System.Drawing.Point(8, 50);
            this.aerobicsLabel.Name = "aerobicsLabel";
            this.aerobicsLabel.Size = new System.Drawing.Size(48, 13);
            this.aerobicsLabel.TabIndex = 0;
            this.aerobicsLabel.Text = "Aerobics";
            // 
            // hikingTextBox
            // 
            this.hikingTextBox.Location = new System.Drawing.Point(262, 47);
            this.hikingTextBox.Name = "hikingTextBox";
            this.hikingTextBox.Size = new System.Drawing.Size(100, 21);
            this.hikingTextBox.TabIndex = 9;
            this.toolTip1.SetToolTip(this.hikingTextBox, "Time Spent Doing Hiking in Minutes");
            // 
            // aerobicsTextBox
            // 
            this.aerobicsTextBox.Location = new System.Drawing.Point(74, 47);
            this.aerobicsTextBox.Name = "aerobicsTextBox";
            this.aerobicsTextBox.Size = new System.Drawing.Size(100, 21);
            this.aerobicsTextBox.TabIndex = 6;
            this.toolTip1.SetToolTip(this.aerobicsTextBox, "Time Spent Doing Aerobics in Minutes");
            // 
            // sittingLabel
            // 
            this.sittingLabel.AutoSize = true;
            this.sittingLabel.Location = new System.Drawing.Point(207, 102);
            this.sittingLabel.Name = "sittingLabel";
            this.sittingLabel.Size = new System.Drawing.Size(37, 13);
            this.sittingLabel.TabIndex = 0;
            this.sittingLabel.Text = "Sitting";
            // 
            // runningLabel
            // 
            this.runningLabel.AutoSize = true;
            this.runningLabel.Location = new System.Drawing.Point(8, 76);
            this.runningLabel.Name = "runningLabel";
            this.runningLabel.Size = new System.Drawing.Size(46, 13);
            this.runningLabel.TabIndex = 0;
            this.runningLabel.Text = "Running";
            // 
            // totalCaloLabel
            // 
            this.totalCaloLabel.AutoSize = true;
            this.totalCaloLabel.Location = new System.Drawing.Point(79, 166);
            this.totalCaloLabel.Name = "totalCaloLabel";
            this.totalCaloLabel.Size = new System.Drawing.Size(109, 13);
            this.totalCaloLabel.TabIndex = 0;
            this.totalCaloLabel.Text = "Total Calories Burned";
            // 
            // swimmingLabel
            // 
            this.swimmingLabel.AutoSize = true;
            this.swimmingLabel.Location = new System.Drawing.Point(8, 102);
            this.swimmingLabel.Name = "swimmingLabel";
            this.swimmingLabel.Size = new System.Drawing.Size(53, 13);
            this.swimmingLabel.TabIndex = 0;
            this.swimmingLabel.Text = "Swimming";
            // 
            // simulationNumberLabel
            // 
            this.simulationNumberLabel.AutoSize = true;
            this.simulationNumberLabel.Location = new System.Drawing.Point(106, 15);
            this.simulationNumberLabel.Name = "simulationNumberLabel";
            this.simulationNumberLabel.Size = new System.Drawing.Size(63, 13);
            this.simulationNumberLabel.TabIndex = 2;
            this.simulationNumberLabel.Text = "Simulation#";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(200, 15);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(30, 13);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "Date";
            // 
            // simulationNumberTextBox
            // 
            this.simulationNumberTextBox.Location = new System.Drawing.Point(174, 12);
            this.simulationNumberTextBox.Name = "simulationNumberTextBox";
            this.simulationNumberTextBox.ReadOnly = true;
            this.simulationNumberTextBox.Size = new System.Drawing.Size(20, 21);
            this.simulationNumberTextBox.TabIndex = 3;
            this.simulationNumberTextBox.TabStop = false;
            this.simulationNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(236, 12);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.ReadOnly = true;
            this.dateTextBox.Size = new System.Drawing.Size(150, 21);
            this.dateTextBox.TabIndex = 4;
            this.dateTextBox.TabStop = false;
            this.dateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(7, 493);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 21);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clea&r";
            this.toolTip1.SetToolTip(this.clearButton, "Clear Editable Textboxes");
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(287, 493);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 21);
            this.exitButton.TabIndex = 8;
            this.exitButton.TabStop = false;
            this.exitButton.Text = "E&xit";
            this.toolTip1.SetToolTip(this.exitButton, "Exit Program");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // PersonalFitnessTrackerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 525);
            this.ControlBox = false;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.simulationNumberTextBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.simulationNumberLabel);
            this.Controls.Add(this.caloriesGroupBox);
            this.Controls.Add(this.bMIGroupBox);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PersonalFitnessTrackerForm";
            this.Text = "Personal Fitness Tracker";
            this.bMIGroupBox.ResumeLayout(false);
            this.bMIGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bMIPictureBox)).EndInit();
            this.caloriesGroupBox.ResumeLayout(false);
            this.caloriesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox bMIGroupBox;
        private System.Windows.Forms.GroupBox caloriesGroupBox;
        private System.Windows.Forms.Label simulationNumberLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox simulationNumberTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.TextBox bMITextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label bMILabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button calculateBMIButton;
        private System.Windows.Forms.PictureBox bMIPictureBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label hikingLabel;
        private System.Windows.Forms.Label walkingLabel;
        private System.Windows.Forms.TextBox swimmingTextBox;
        private System.Windows.Forms.TextBox runningTextBox;
        private System.Windows.Forms.Label aerobicsLabel;
        private System.Windows.Forms.TextBox aerobicsTextBox;
        private System.Windows.Forms.Label sittingLabel;
        private System.Windows.Forms.Label runningLabel;
        private System.Windows.Forms.Label swimmingLabel;
        private System.Windows.Forms.Label timeLabel2;
        private System.Windows.Forms.Label timeLabel1;
        private System.Windows.Forms.TextBox sittingTextBox;
        private System.Windows.Forms.TextBox walkingTextBox;
        private System.Windows.Forms.TextBox hikingTextBox;
        private System.Windows.Forms.TextBox caloTotalTextBox;
        private System.Windows.Forms.Label totalCaloLabel;
        private System.Windows.Forms.Button calculateCaloButton;
        private System.Windows.Forms.TextBox infoTextBox;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

