using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Assignment_8.Model
{
    /// <summary>
    /// A representation of a couse at ASU
    /// </summary>
    class Course
    {
        // Course properties
        public int CourseId { get; set; }
        public int CourseCode { get; set; }
        public string Subject { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public string Instructor { get; set; }

        // Constructor
        /// <summary>
        /// Creates a course object from a string array.
        /// </summary>
        /// <param name="initValues">
        /// The values in which to initialize this object from. 
        /// [0] - Subject
        /// [1] - Course Code (int)
        /// [2] - Course Id (int)
        /// [3] - Title 
        /// [4] - Location
        /// [5] - Instructor Name
        /// </param>
        public Course(string[] initValues)
        {
            Subject = initValues[0];
            CourseCode = Int32.Parse(initValues[1]);
            CourseId = Int32.Parse(initValues[2]);
            Title = initValues[3];
            Location = initValues[7];
            Instructor = initValues[10];
        }

        /// <summary>
        /// Creates a course object from a xml data element.
        /// </summary>
        /// <param name="courseElement">
        /// The element containing the course properties.
        ///   <Course>
        ///     </Subject>
        ///     </CourseCode>
        ///     </CourseID>
        ///     </Title>
        ///     </Location>
        ///     </Instructor>
        ///   </Course>
        /// </param>
        public Course(XElement courseElement)
        {
            Subject = (string)courseElement.Element("Subject");
            CourseCode = (int) courseElement.Element("CourseCode");
            CourseId = (int)courseElement.Element("CourseID");
            Title = (string)courseElement.Element("Title");
            Location = (string)courseElement.Element("Location");
            Instructor = (string)courseElement.Element("Instructor");
        }
    }
}
