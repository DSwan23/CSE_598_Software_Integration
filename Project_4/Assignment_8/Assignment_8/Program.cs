using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Assignment_8.Controller;
using Assignment_8.Model;

namespace Assignment_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Assignment 8 Linq and XML");

            string courseCsvPath = @"D:\Git_Projects\CSE_598_Software_Integration\Project_4\Assignment_8\Assignment_8\App_Data\Courses.csv";
            string instructorCsvPath = @"D:\Git_Projects\CSE_598_Software_Integration\Project_4\Assignment_8\Assignment_8\App_Data\Instructors.csv";
            string xmlFilePath = @"D:\Git_Projects\CSE_598_Software_Integration\Project_4\Assignment_8\Assignment_8\App_Data\CourseData.xml";

            DataController mController = new DataController(courseCsvPath, instructorCsvPath, xmlFilePath);

            // Read in and convert the course data
            mController.ConvertCourseDataToXml();
            // Write the course data to xml
            mController.WriteCourseDataToXmlFile();

            // Get all of the cpi 200 courses
            IEnumerable<XElement> cpiCourses = mController.GetCPICourses();
            // Print the course data to the screen
            Console.WriteLine("========== Courses by Title - Instructor ==========");
            foreach (XElement result in cpiCourses)
            {
                Console.WriteLine($"{(string) result.Element("Title")} - {(string) result.Element("Instructor")}");
            }
            Console.WriteLine("");
            Console.WriteLine("========== Subjects and Course Codes with Multiple Courses ==========");
            // Display the grouped courses
            mController.ViewGroupCoursesXML();
            // Read in instructor data
            mController.ReadInInstructorData();
            // Display the 200 level course and instructor data
            Console.WriteLine("");
            Console.WriteLine("========== 200 Level Course Instructor Emails ==========");
            mController.View200LvlcourseDataXml();
        }
    }
}
