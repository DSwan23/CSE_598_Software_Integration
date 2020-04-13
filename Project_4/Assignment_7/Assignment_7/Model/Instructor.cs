using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_7.Model
{
    /// <summary>
    /// A representation of an instructor at ASU
    /// </summary>
    class Instructor
    {
        // Properties
        public string InstructorName { get; set; }
        public int OfficeNumber { get; set; }
        public string EmailAddress { get; set; }

        // Constructor
        /// <summary>
        /// Creates an instructor object.
        /// </summary>
        /// <param name="initValues">
        /// The values in which to initialize this object from. 
        /// [0] - Instructor Name
        /// [1] - Office Number
        /// [2] - Email Address
        /// </param>
        public Instructor(string[] initValues)
        {
            InstructorName = initValues[0];
            OfficeNumber = Int32.Parse(initValues[1]);
            EmailAddress = initValues[2];
        }
    }
}
