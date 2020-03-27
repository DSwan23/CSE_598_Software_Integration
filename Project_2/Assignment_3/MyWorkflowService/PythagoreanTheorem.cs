using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;

namespace MyWorkflowService
{
    public enum CalcType { Hypotonuse, SideA, SideB };

    public sealed class PythagoreanTheorem : CodeActivity
    {        
        // Define an activity input argument of type string
        public InArgument<int> CalculationType { get; set; }
        public InArgument<double> Length1 { get; set; }
        public InArgument<double> Length2 { get; set; }

        // Output Arguments
        public InOutArgument<double> CalculatedLength { get; set; }

        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override void Execute(CodeActivityContext context)
        {
            // Obtain the runtime value of the Text input argument
            int type = context.GetValue(this.CalculationType);
            double length1 = context.GetValue(this.Length1);
            double length2 = context.GetValue(this.Length2);
            double outputValue = -1;

            // depending on the type, calculate the third side
            switch(type)
            {
                case 0:
                    outputValue = Math.Sqrt((length1 * length1) + (length2 * length2));
                    break;
                case 1:
                case 2:
                    outputValue = Math.Sqrt((length1 * length1) - (length2 * length2));
                    break;
            }
            // Set the output variable
            context.SetValue(this.CalculatedLength, outputValue);
        }
    }
}
