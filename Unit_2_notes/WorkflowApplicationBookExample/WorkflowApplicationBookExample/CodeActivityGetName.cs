using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;

namespace WorkflowApplicationBookExample
{

    public sealed class CodeActivityGetName : CodeActivity
    {
        // Define an activity input argument of type string
        public InArgument<string> defaultName { get; set; }
        public OutArgument<string> enteredName { get; set; }

        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override void Execute(CodeActivityContext context)
        {
            Console.WriteLine("Please enter your name: ");
            string yourName = Console.ReadLine();
            if(yourName == "")
            {
                string dName = context.GetValue(this.defaultName);
                yourName = dName;
            }
            string helloName = "Hello " + yourName;
            context.SetValue(this.enteredName, helloName);
        }


    }
}
