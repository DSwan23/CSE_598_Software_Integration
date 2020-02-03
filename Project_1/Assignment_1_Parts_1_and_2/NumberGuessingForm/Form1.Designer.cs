namespace NumberGuessingForm
{
    partial class FormNumberGuessingGameClient
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
            this.TextLowerLimit = new System.Windows.Forms.TextBox();
            this.TextUpperLimit = new System.Windows.Forms.TextBox();
            this.LabelLowerLimit = new System.Windows.Forms.Label();
            this.LabelUpperLimit = new System.Windows.Forms.Label();
            this.ButtonGenerateSecretNumber = new System.Windows.Forms.Button();
            this.LabelGuess = new System.Windows.Forms.Label();
            this.TextGuess = new System.Windows.Forms.TextBox();
            this.ButtonPlay = new System.Windows.Forms.Button();
            this.LabelAttempts = new System.Windows.Forms.Label();
            this.LabelGuessResult = new System.Windows.Forms.Label();
            this.ButtonShowSecret = new System.Windows.Forms.Button();
            this.LabelSecretNumber = new System.Windows.Forms.Label();
            this.LabelConsole = new System.Windows.Forms.Label();
            this.LabelGuessOutput = new System.Windows.Forms.Label();
            this.LabelAttemptsOutput = new System.Windows.Forms.Label();
            this.LabelSecretNumberOutput = new System.Windows.Forms.Label();
            this.LabelConsoleOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextLowerLimit
            // 
            this.TextLowerLimit.Location = new System.Drawing.Point(95, 7);
            this.TextLowerLimit.Name = "TextLowerLimit";
            this.TextLowerLimit.Size = new System.Drawing.Size(100, 22);
            this.TextLowerLimit.TabIndex = 0;
            // 
            // TextUpperLimit
            // 
            this.TextUpperLimit.Location = new System.Drawing.Point(292, 7);
            this.TextUpperLimit.Name = "TextUpperLimit";
            this.TextUpperLimit.Size = new System.Drawing.Size(100, 22);
            this.TextUpperLimit.TabIndex = 1;
            // 
            // LabelLowerLimit
            // 
            this.LabelLowerLimit.AutoSize = true;
            this.LabelLowerLimit.Location = new System.Drawing.Point(9, 9);
            this.LabelLowerLimit.Name = "LabelLowerLimit";
            this.LabelLowerLimit.Size = new System.Drawing.Size(83, 17);
            this.LabelLowerLimit.TabIndex = 2;
            this.LabelLowerLimit.Text = "Lower Limit:";
            // 
            // LabelUpperLimit
            // 
            this.LabelUpperLimit.AutoSize = true;
            this.LabelUpperLimit.Location = new System.Drawing.Point(206, 10);
            this.LabelUpperLimit.Name = "LabelUpperLimit";
            this.LabelUpperLimit.Size = new System.Drawing.Size(84, 17);
            this.LabelUpperLimit.TabIndex = 3;
            this.LabelUpperLimit.Text = "Upper Limit:";
            // 
            // ButtonGenerateSecretNumber
            // 
            this.ButtonGenerateSecretNumber.Location = new System.Drawing.Point(398, 7);
            this.ButtonGenerateSecretNumber.Name = "ButtonGenerateSecretNumber";
            this.ButtonGenerateSecretNumber.Size = new System.Drawing.Size(200, 25);
            this.ButtonGenerateSecretNumber.TabIndex = 4;
            this.ButtonGenerateSecretNumber.Text = "Generate a Secret Number";
            this.ButtonGenerateSecretNumber.UseVisualStyleBackColor = true;
            this.ButtonGenerateSecretNumber.Click += new System.EventHandler(this.ButtonGenerateSecretNumber_Click);
            // 
            // LabelGuess
            // 
            this.LabelGuess.AutoSize = true;
            this.LabelGuess.Location = new System.Drawing.Point(12, 53);
            this.LabelGuess.Name = "LabelGuess";
            this.LabelGuess.Size = new System.Drawing.Size(103, 17);
            this.LabelGuess.TabIndex = 5;
            this.LabelGuess.Text = "Make a Guess:";
            // 
            // TextGuess
            // 
            this.TextGuess.Location = new System.Drawing.Point(112, 53);
            this.TextGuess.Name = "TextGuess";
            this.TextGuess.Size = new System.Drawing.Size(100, 22);
            this.TextGuess.TabIndex = 6;
            // 
            // ButtonPlay
            // 
            this.ButtonPlay.Location = new System.Drawing.Point(218, 53);
            this.ButtonPlay.Name = "ButtonPlay";
            this.ButtonPlay.Size = new System.Drawing.Size(73, 25);
            this.ButtonPlay.TabIndex = 7;
            this.ButtonPlay.Text = "Play";
            this.ButtonPlay.UseVisualStyleBackColor = true;
            this.ButtonPlay.Click += new System.EventHandler(this.ButtonPlay_Click);
            // 
            // LabelAttempts
            // 
            this.LabelAttempts.AutoSize = true;
            this.LabelAttempts.Location = new System.Drawing.Point(12, 104);
            this.LabelAttempts.Name = "LabelAttempts";
            this.LabelAttempts.Size = new System.Drawing.Size(106, 17);
            this.LabelAttempts.TabIndex = 8;
            this.LabelAttempts.Text = "Attempts Made:";
            // 
            // LabelGuessResult
            // 
            this.LabelGuessResult.AutoSize = true;
            this.LabelGuessResult.Location = new System.Drawing.Point(12, 87);
            this.LabelGuessResult.Name = "LabelGuessResult";
            this.LabelGuessResult.Size = new System.Drawing.Size(101, 17);
            this.LabelGuessResult.TabIndex = 9;
            this.LabelGuessResult.Text = "Your Guess is:";
            // 
            // ButtonShowSecret
            // 
            this.ButtonShowSecret.Location = new System.Drawing.Point(304, 53);
            this.ButtonShowSecret.Name = "ButtonShowSecret";
            this.ButtonShowSecret.Size = new System.Drawing.Size(153, 25);
            this.ButtonShowSecret.TabIndex = 10;
            this.ButtonShowSecret.Text = "Show Secret Number";
            this.ButtonShowSecret.UseVisualStyleBackColor = true;
            this.ButtonShowSecret.Click += new System.EventHandler(this.ButtonShowSecret_Click);
            // 
            // LabelSecretNumber
            // 
            this.LabelSecretNumber.AutoSize = true;
            this.LabelSecretNumber.Location = new System.Drawing.Point(307, 87);
            this.LabelSecretNumber.Name = "LabelSecretNumber";
            this.LabelSecretNumber.Size = new System.Drawing.Size(150, 17);
            this.LabelSecretNumber.TabIndex = 11;
            this.LabelSecretNumber.Text = "The Secret Number is:";
            // 
            // LabelConsole
            // 
            this.LabelConsole.AutoSize = true;
            this.LabelConsole.Location = new System.Drawing.Point(307, 105);
            this.LabelConsole.Name = "LabelConsole";
            this.LabelConsole.Size = new System.Drawing.Size(110, 17);
            this.LabelConsole.TabIndex = 12;
            this.LabelConsole.Text = "Console Output:";
            // 
            // LabelGuessOutput
            // 
            this.LabelGuessOutput.AutoSize = true;
            this.LabelGuessOutput.Location = new System.Drawing.Point(111, 87);
            this.LabelGuessOutput.Name = "LabelGuessOutput";
            this.LabelGuessOutput.Size = new System.Drawing.Size(12, 17);
            this.LabelGuessOutput.TabIndex = 13;
            this.LabelGuessOutput.Text = " ";
            // 
            // LabelAttemptsOutput
            // 
            this.LabelAttemptsOutput.AutoSize = true;
            this.LabelAttemptsOutput.Location = new System.Drawing.Point(119, 104);
            this.LabelAttemptsOutput.Name = "LabelAttemptsOutput";
            this.LabelAttemptsOutput.Size = new System.Drawing.Size(12, 17);
            this.LabelAttemptsOutput.TabIndex = 14;
            this.LabelAttemptsOutput.Text = " ";
            // 
            // LabelSecretNumberOutput
            // 
            this.LabelSecretNumberOutput.AutoSize = true;
            this.LabelSecretNumberOutput.Location = new System.Drawing.Point(463, 87);
            this.LabelSecretNumberOutput.Name = "LabelSecretNumberOutput";
            this.LabelSecretNumberOutput.Size = new System.Drawing.Size(12, 17);
            this.LabelSecretNumberOutput.TabIndex = 15;
            this.LabelSecretNumberOutput.Text = " ";
            // 
            // LabelConsoleOutput
            // 
            this.LabelConsoleOutput.AutoSize = true;
            this.LabelConsoleOutput.Location = new System.Drawing.Point(423, 105);
            this.LabelConsoleOutput.Name = "LabelConsoleOutput";
            this.LabelConsoleOutput.Size = new System.Drawing.Size(12, 17);
            this.LabelConsoleOutput.TabIndex = 16;
            this.LabelConsoleOutput.Text = " ";
            // 
            // FormNumberGuessingGameClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 126);
            this.Controls.Add(this.LabelConsoleOutput);
            this.Controls.Add(this.LabelSecretNumberOutput);
            this.Controls.Add(this.LabelAttemptsOutput);
            this.Controls.Add(this.LabelGuessOutput);
            this.Controls.Add(this.LabelConsole);
            this.Controls.Add(this.LabelSecretNumber);
            this.Controls.Add(this.ButtonShowSecret);
            this.Controls.Add(this.LabelGuessResult);
            this.Controls.Add(this.LabelAttempts);
            this.Controls.Add(this.ButtonPlay);
            this.Controls.Add(this.TextGuess);
            this.Controls.Add(this.LabelGuess);
            this.Controls.Add(this.ButtonGenerateSecretNumber);
            this.Controls.Add(this.LabelUpperLimit);
            this.Controls.Add(this.LabelLowerLimit);
            this.Controls.Add(this.TextUpperLimit);
            this.Controls.Add(this.TextLowerLimit);
            this.Name = "FormNumberGuessingGameClient";
            this.Text = "Number Guessing Game Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormNumberGuessingGameClient_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextLowerLimit;
        private System.Windows.Forms.TextBox TextUpperLimit;
        private System.Windows.Forms.Label LabelLowerLimit;
        private System.Windows.Forms.Label LabelUpperLimit;
        private System.Windows.Forms.Button ButtonGenerateSecretNumber;
        private System.Windows.Forms.Label LabelGuess;
        private System.Windows.Forms.TextBox TextGuess;
        private System.Windows.Forms.Button ButtonPlay;
        private System.Windows.Forms.Label LabelAttempts;
        private System.Windows.Forms.Label LabelGuessResult;
        private System.Windows.Forms.Button ButtonShowSecret;
        private System.Windows.Forms.Label LabelSecretNumber;
        private System.Windows.Forms.Label LabelConsole;
        private System.Windows.Forms.Label LabelGuessOutput;
        private System.Windows.Forms.Label LabelAttemptsOutput;
        private System.Windows.Forms.Label LabelSecretNumberOutput;
        private System.Windows.Forms.Label LabelConsoleOutput;
    }
}

