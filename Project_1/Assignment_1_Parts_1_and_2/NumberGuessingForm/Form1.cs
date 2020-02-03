using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGuessingForm
{
    public partial class FormNumberGuessingGameClient : Form
    {
        // Form variables
        NumberGuessingService.ServiceClient serviceProxy;
        int currentSecretNumber = int.MinValue;
        int currentAttemptCount = 0;

        public FormNumberGuessingGameClient()
        {
            InitializeComponent();
            InitializeCustomComponets();
        }

        private void InitializeCustomComponets()
        {
            // Create a service proxy object
            serviceProxy = new NumberGuessingService.ServiceClient();
            serviceProxy.Open();
            // Show the initial count number to the user
            LabelAttemptsOutput.Text = currentAttemptCount.ToString();
        }

        private void ButtonGenerateSecretNumber_Click(object sender, EventArgs e)
        {
            // Local variables
            int lowerLimit = 0;
            int upperLimit = 0;
            // Check to see if both of the inputs have values
            if(!string.IsNullOrWhiteSpace(TextLowerLimit.Text) && !string.IsNullOrWhiteSpace(TextUpperLimit.Text))
            {
                // Check to see if the input boxes contain integers
                if(int.TryParse(TextLowerLimit.Text, out lowerLimit) && int.TryParse(TextUpperLimit.Text, out upperLimit))
                {
                    // Check to see if the upper limit is greater than the lower limit
                    if (upperLimit >= lowerLimit)
                    {
                        // Generate the secret number
                        currentSecretNumber = serviceProxy.SecretNumber(lowerLimit, upperLimit);
                        // Set the attempts to 0
                        currentAttemptCount = 0;
                        LabelAttemptsOutput.Text = currentAttemptCount.ToString();
                        // Inform the user
                        LabelConsoleOutput.Text = "Secret Number Generated!";
                    }
                    else
                    {
                        LabelConsoleOutput.Text = "Please set the upper limit greater than the lower, then try again.";
                    }
                }
                else
                {
                    LabelConsoleOutput.Text = "Ensure that the limits are integers, then try again.";
                }
            }
            else
            {
                LabelConsoleOutput.Text = "Please enter both limits and try again!";
            }
        }

        private void ButtonPlay_Click(object sender, EventArgs e)
        {
            // Local Variables
            int guessNumber = 0;
            // Check to see if the secret number has been set
            if(currentSecretNumber == int.MinValue)
            {
                LabelConsoleOutput.Text = "Please generate a secret number before guessing.";
                return;
            }
            // Check to see if the guess box is empty
            if(!string.IsNullOrWhiteSpace(TextGuess.Text))
            {
                // Check to see if the value entered is an integer
                if(int.TryParse(TextGuess.Text, out guessNumber))
                {
                    // Compare the the guess to the secret number
                    LabelGuessOutput.Text = serviceProxy.CheckNumber(guessNumber, currentSecretNumber);
                    // Increase the attempt counts
                    currentAttemptCount++;
                    LabelAttemptsOutput.Text = currentAttemptCount.ToString();
                    // Inform the user that the guess has been made
                    LabelConsoleOutput.Text = "Guess submitted!";
                }
                else
                {
                    LabelConsoleOutput.Text = "Ensure that your guess is an integer then retry.";
                }
            }
            else
            {
                LabelConsoleOutput.Text = "Please enter a guess number then retry.";
            }
        }

        private void ButtonShowSecret_Click(object sender, EventArgs e)
        {
            // Display the current secret number to the user
            LabelSecretNumberOutput.Text = currentSecretNumber.ToString();
        }

        private void FormNumberGuessingGameClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Close the connection to the service
            serviceProxy.Close();
        }
    }
}
