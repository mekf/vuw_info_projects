namespace _300113109_DiceGame_A2
{
    partial class DiceGameMainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diceOnePictureBox = new System.Windows.Forms.PictureBox();
            this.diceTwoPictureBox = new System.Windows.Forms.PictureBox();
            this.rollButton = new System.Windows.Forms.Button();
            this.betGroupBox = new System.Windows.Forms.GroupBox();
            this.betDiceNumComboBox = new System.Windows.Forms.ComboBox();
            this.betSumTextBox = new System.Windows.Forms.TextBox();
            this.betDiceNumCheckBox = new System.Windows.Forms.CheckBox();
            this.betDoubleCheckBox = new System.Windows.Forms.CheckBox();
            this.betSumCheckBox = new System.Windows.Forms.CheckBox();
            this.summaryButton = new System.Windows.Forms.Button();
            this.winLabel = new System.Windows.Forms.Label();
            this.winNumTextBox = new System.Windows.Forms.TextBox();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.pointsTotalTextBox = new System.Windows.Forms.TextBox();
            this.topUpButton = new System.Windows.Forms.Button();
            this.topUpNumTextBox = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diceOnePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceTwoPictureBox)).BeginInit();
            this.betGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(490, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.newGameToolStripMenuItem.Text = "&New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.colorToolStripMenuItem.Text = "&Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // diceOnePictureBox
            // 
            this.diceOnePictureBox.Location = new System.Drawing.Point(16, 38);
            this.diceOnePictureBox.Name = "diceOnePictureBox";
            this.diceOnePictureBox.Size = new System.Drawing.Size(222, 222);
            this.diceOnePictureBox.TabIndex = 1;
            this.diceOnePictureBox.TabStop = false;
            // 
            // diceTwoPictureBox
            // 
            this.diceTwoPictureBox.Location = new System.Drawing.Point(252, 38);
            this.diceTwoPictureBox.Name = "diceTwoPictureBox";
            this.diceTwoPictureBox.Size = new System.Drawing.Size(222, 222);
            this.diceTwoPictureBox.TabIndex = 1;
            this.diceTwoPictureBox.TabStop = false;
            // 
            // rollButton
            // 
            this.rollButton.Location = new System.Drawing.Point(170, 266);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(150, 30);
            this.rollButton.TabIndex = 1;
            this.rollButton.Text = "ROLL";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // betGroupBox
            // 
            this.betGroupBox.Controls.Add(this.betDiceNumComboBox);
            this.betGroupBox.Controls.Add(this.betSumTextBox);
            this.betGroupBox.Controls.Add(this.betDiceNumCheckBox);
            this.betGroupBox.Controls.Add(this.betDoubleCheckBox);
            this.betGroupBox.Controls.Add(this.betSumCheckBox);
            this.betGroupBox.Location = new System.Drawing.Point(16, 302);
            this.betGroupBox.Name = "betGroupBox";
            this.betGroupBox.Size = new System.Drawing.Size(222, 120);
            this.betGroupBox.TabIndex = 3;
            this.betGroupBox.TabStop = false;
            this.betGroupBox.Text = "BET";
            // 
            // betDiceNumComboBox
            // 
            this.betDiceNumComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.betDiceNumComboBox.FormattingEnabled = true;
            this.betDiceNumComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.betDiceNumComboBox.Location = new System.Drawing.Point(79, 82);
            this.betDiceNumComboBox.Name = "betDiceNumComboBox";
            this.betDiceNumComboBox.Size = new System.Drawing.Size(120, 21);
            this.betDiceNumComboBox.TabIndex = 6;
            // 
            // betSumTextBox
            // 
            this.betSumTextBox.Location = new System.Drawing.Point(79, 22);
            this.betSumTextBox.Name = "betSumTextBox";
            this.betSumTextBox.Size = new System.Drawing.Size(120, 20);
            this.betSumTextBox.TabIndex = 3;
            // 
            // betDiceNumCheckBox
            // 
            this.betDiceNumCheckBox.AutoSize = true;
            this.betDiceNumCheckBox.Location = new System.Drawing.Point(16, 86);
            this.betDiceNumCheckBox.Name = "betDiceNumCheckBox";
            this.betDiceNumCheckBox.Size = new System.Drawing.Size(57, 17);
            this.betDiceNumCheckBox.TabIndex = 5;
            this.betDiceNumCheckBox.Text = "1 Dice";
            this.betDiceNumCheckBox.UseVisualStyleBackColor = true;
            // 
            // betDoubleCheckBox
            // 
            this.betDoubleCheckBox.AutoSize = true;
            this.betDoubleCheckBox.Location = new System.Drawing.Point(16, 55);
            this.betDoubleCheckBox.Name = "betDoubleCheckBox";
            this.betDoubleCheckBox.Size = new System.Drawing.Size(60, 17);
            this.betDoubleCheckBox.TabIndex = 4;
            this.betDoubleCheckBox.Text = "Double";
            this.betDoubleCheckBox.UseVisualStyleBackColor = true;
            // 
            // betSumCheckBox
            // 
            this.betSumCheckBox.AutoSize = true;
            this.betSumCheckBox.Location = new System.Drawing.Point(16, 24);
            this.betSumCheckBox.Name = "betSumCheckBox";
            this.betSumCheckBox.Size = new System.Drawing.Size(47, 17);
            this.betSumCheckBox.TabIndex = 2;
            this.betSumCheckBox.Text = "Sum";
            this.betSumCheckBox.UseVisualStyleBackColor = true;
            // 
            // summaryButton
            // 
            this.summaryButton.Location = new System.Drawing.Point(388, 392);
            this.summaryButton.Name = "summaryButton";
            this.summaryButton.Size = new System.Drawing.Size(90, 30);
            this.summaryButton.TabIndex = 4;
            this.summaryButton.TabStop = false;
            this.summaryButton.Text = "Summary";
            this.summaryButton.UseVisualStyleBackColor = true;
            this.summaryButton.Click += new System.EventHandler(this.summaryButton_Click);
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.Location = new System.Drawing.Point(291, 327);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(40, 13);
            this.winLabel.TabIndex = 5;
            this.winLabel.Text = "WIN#";
            // 
            // winNumTextBox
            // 
            this.winNumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winNumTextBox.Location = new System.Drawing.Point(350, 315);
            this.winNumTextBox.Name = "winNumTextBox";
            this.winNumTextBox.ReadOnly = true;
            this.winNumTextBox.Size = new System.Drawing.Size(60, 31);
            this.winNumTextBox.TabIndex = 6;
            this.winNumTextBox.TabStop = false;
            this.winNumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsLabel.Location = new System.Drawing.Point(291, 364);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(53, 13);
            this.pointsLabel.TabIndex = 5;
            this.pointsLabel.Text = "POINTS";
            // 
            // pointsTotalTextBox
            // 
            this.pointsTotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsTotalTextBox.Location = new System.Drawing.Point(350, 352);
            this.pointsTotalTextBox.Name = "pointsTotalTextBox";
            this.pointsTotalTextBox.ReadOnly = true;
            this.pointsTotalTextBox.Size = new System.Drawing.Size(60, 31);
            this.pointsTotalTextBox.TabIndex = 7;
            this.pointsTotalTextBox.TabStop = false;
            this.pointsTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // topUpButton
            // 
            this.topUpButton.Location = new System.Drawing.Point(254, 392);
            this.topUpButton.Name = "topUpButton";
            this.topUpButton.Size = new System.Drawing.Size(90, 30);
            this.topUpButton.TabIndex = 12;
            this.topUpButton.Text = "Top Up";
            this.topUpButton.UseVisualStyleBackColor = true;
            this.topUpButton.Click += new System.EventHandler(this.topUpButton_Click);
            // 
            // topUpNumTextBox
            // 
            this.topUpNumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topUpNumTextBox.Location = new System.Drawing.Point(350, 392);
            this.topUpNumTextBox.Name = "topUpNumTextBox";
            this.topUpNumTextBox.ReadOnly = true;
            this.topUpNumTextBox.Size = new System.Drawing.Size(31, 29);
            this.topUpNumTextBox.TabIndex = 6;
            this.topUpNumTextBox.TabStop = false;
            this.topUpNumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DiceGameMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 431);
            this.ControlBox = false;
            this.Controls.Add(this.topUpButton);
            this.Controls.Add(this.pointsTotalTextBox);
            this.Controls.Add(this.topUpNumTextBox);
            this.Controls.Add(this.winNumTextBox);
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.summaryButton);
            this.Controls.Add(this.betGroupBox);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.diceTwoPictureBox);
            this.Controls.Add(this.diceOnePictureBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DiceGameMainForm";
            this.Text = "INFO102 Portal Dice";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diceOnePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceTwoPictureBox)).EndInit();
            this.betGroupBox.ResumeLayout(false);
            this.betGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox diceOnePictureBox;
        private System.Windows.Forms.PictureBox diceTwoPictureBox;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.GroupBox betGroupBox;
        private System.Windows.Forms.CheckBox betDiceNumCheckBox;
        private System.Windows.Forms.CheckBox betDoubleCheckBox;
        private System.Windows.Forms.CheckBox betSumCheckBox;
        private System.Windows.Forms.ComboBox betDiceNumComboBox;
        private System.Windows.Forms.TextBox betSumTextBox;
        private System.Windows.Forms.Button summaryButton;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.TextBox winNumTextBox;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.TextBox pointsTotalTextBox;
        private System.Windows.Forms.Button topUpButton;
        private System.Windows.Forms.TextBox topUpNumTextBox;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

