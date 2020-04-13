using System;
using System.Collections.Generic;
using Assignment_7.Controller;
using Assignment_7.Model;

namespace Assignment_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Assignment 7 Linq");

            string courseCsvPath = @"D:\Git_Projects\CSE_598_Software_Integration\Project_4\Assignment_7\Courses.csv";
            string instructorCsvPath = @"D:\Git_Projects\CSE_598_Software_Integration\Project_4\Assignment_7\Instructor.csv";

            DataController mController = new DataController(courseCsvPath, instructorCsvPath);

            // Read in the course data
            mController.ReadInCourseData();
            // Perform the first query
            IEnumerable<dynamic> result = mController.GetIEECourses();
            // Write the results to the screen
            Console.WriteLine("========== Courses by Title - Instructor ==========");
            foreach(dynamic courseItem in result)
            {
                Console.WriteLine($"{courseItem.Title} - {courseItem.Instructor}");
            }
            Console.WriteLine("");
            Console.WriteLine("========== Subjects and Course Codes with Multiple Courses ==========");
            // View courses in a group manner
            mController.ViewGroupCourses();
        }
    }
}
