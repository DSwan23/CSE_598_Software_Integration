using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;

namespace AccessServiceConsoleApplication
{

    public sealed class DisplayMenu : CodeActivity
    {
        // Define an activity input argument of type string
        public InArgument<string> Text { get; set; }
        // Define activity output
        public OutArgument<double> UserSelection { get; set; }

        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override void Execute(CodeActivityContext context)
        {
            // Obtain the runtime value of the Text input argument
            string text = context.GetValue(this.Text);
            // Write the text to the screen
            Console.WriteLine(text);
            // Get user input
            string userSelection = Console.ReadLine();
            // Try to convert the user value to a integer value
            double convertedSelection; 
            while(!Double.TryParse(userSelection,out convertedSelection))
            {
                // Display error to user
                Console.WriteLine("Please enter a number corresponding with an option displayed above!\n ");
                // Get user input
                userSelection = Console.ReadLine();
            }
            // Set the output variable
            context.SetValue(this.UserSelection, convertedSelection);
        }
    }
}
