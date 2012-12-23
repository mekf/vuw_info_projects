namespace _300113109_DiceGame_A2
{
    partial class SummaryForm
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
            this.pointsSumLabel = new System.Windows.Forms.Label();
            this.continueButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.betSumWinLabel = new System.Windows.Forms.Label();
            this.betDoubleWinLabel = new System.Windows.Forms.Label();
            this.betDiceNumWinLabel = new System.Windows.Forms.Label();
            this.clickNumLabel = new System.Windows.Forms.Label();
            this.topUpLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pointsSumLabel
            // 
            this.pointsSumLabel.AutoSize = true;
            this.pointsSumLabel.Location = new System.Drawing.Point(12, 53);
            this.pointsSumLabel.Name = "pointsSumLabel";
            this.pointsSumLabel.Size = new System.Drawing.Size(63, 13);
            this.pointsSumLabel.TabIndex = 0;
            this.pointsSumLabel.Text = "Total Points";
            // 
            // continueButton
            // 
            this.continueButton.Location = new System.Drawing.Point(45, 233);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(75, 23);
            this.continueButton.TabIndex = 1;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(173, 233);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // betSumWinLabel
            // 
            this.betSumWinLabel.AutoSize = true;
            this.betSumWinLabel.Location = new System.Drawing.Point(12, 89);
            this.betSumWinLabel.Name = "betSumWinLabel";
            this.betSumWinLabel.Size = new System.Drawing.Size(69, 13);
            this.betSumWinLabel.TabIndex = 0;
            this.betSumWinLabel.Text = "Bet Sum Win";
            // 
            // betDoubleWinLabel
            // 
            this.betDoubleWinLabel.AutoSize = true;
            this.betDoubleWinLabel.Location = new System.Drawing.Point(12, 125);
            this.betDoubleWinLabel.Name = "betDoubleWinLabel";
            this.betDoubleWinLabel.Size = new System.Drawing.Size(82, 13);
            this.betDoubleWinLabel.TabIndex = 0;
            this.betDoubleWinLabel.Text = "Bet Double Win";
            // 
            // betDiceNumWinLabel
            // 
            this.betDiceNumWinLabel.AutoSize = true;
            this.betDiceNumWinLabel.Location = new System.Drawing.Point(12, 161);
            this.betDiceNumWinLabel.Name = "betDiceNumWinLabel";
            this.betDiceNumWinLabel.Size = new System.Drawing.Size(95, 13);
            this.betDiceNumWinLabel.TabIndex = 0;
            this.betDiceNumWinLabel.Text = "Bet Dice Num Win";
            // 
            // clickNumLabel
            // 
            this.clickNumLabel.AutoSize = true;
            this.clickNumLabel.Location = new System.Drawing.Point(12, 17);
            this.clickNumLabel.Name = "clickNumLabel";
            this.clickNumLabel.Size = new System.Drawing.Size(40, 13);
            this.clickNumLabel.TabIndex = 0;
            this.clickNumLabel.Text = "Click #";
            // 
            // topUpLabel
            // 
            this.topUpLabel.AutoSize = true;
            this.topUpLabel.Location = new System.Drawing.Point(12, 197);
            this.topUpLabel.Name = "topUpLabel";
            this.topUpLabel.Size = new System.Drawing.Size(74, 13);
            this.topUpLabel.TabIndex = 0;
            this.topUpLabel.Text = "Top Up Times";
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.ControlBox = false;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.topUpLabel);
            this.Controls.Add(this.betDiceNumWinLabel);
            this.Controls.Add(this.betDoubleWinLabel);
            this.Controls.Add(this.betSumWinLabel);
            this.Controls.Add(this.clickNumLabel);
            this.Controls.Add(this.pointsSumLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SummaryForm";
            this.Text = "Summary";
            this.Activated += new System.EventHandler(this.SummaryForm_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pointsSumLabel;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label betSumWinLabel;
        private System.Windows.Forms.Label betDoubleWinLabel;
        private System.Windows.Forms.Label betDiceNumWinLabel;
        private System.Windows.Forms.Label clickNumLabel;
        private System.Windows.Forms.Label topUpLabel;
    }
}