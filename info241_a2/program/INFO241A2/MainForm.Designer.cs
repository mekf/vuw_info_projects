namespace INFO241A2
{
    partial class MainForm
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
            this.adminButton = new System.Windows.Forms.Button();
            this.playerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminButton
            // 
            this.adminButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminButton.Location = new System.Drawing.Point(46, 22);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(200, 100);
            this.adminButton.TabIndex = 0;
            this.adminButton.Text = "ADMIN";
            this.adminButton.UseVisualStyleBackColor = true;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // playerButton
            // 
            this.playerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerButton.Location = new System.Drawing.Point(46, 151);
            this.playerButton.Name = "playerButton";
            this.playerButton.Size = new System.Drawing.Size(200, 100);
            this.playerButton.TabIndex = 1;
            this.playerButton.Text = "PLAYER";
            this.playerButton.UseVisualStyleBackColor = true;
            this.playerButton.Click += new System.EventHandler(this.playerButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.playerButton);
            this.Controls.Add(this.adminButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "KID SUDOKU";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.Button playerButton;
    }
}

