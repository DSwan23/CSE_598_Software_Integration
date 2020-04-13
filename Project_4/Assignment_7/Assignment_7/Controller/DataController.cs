using Assignment_7.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Assignment_7.Controller
{
    /// <summary>
    /// A connection to outside data
    /// </summary>
    class DataController
    {
        // Private Properties
        private int mCourseEntryCount = 0;
        private int mInstructorCount = 0;
        private string mCourseFilePath;
        private string mInstructorFilePath;
        private List<Course> mTempCourseList = new List<Course>();
        private Course[] mCourses;
        private List<Instructor> mInstructors = new List<Instructor>();

        // Public Properties
        /// <summary>
        /// The number of courses currently stored.
        /// </summary>
        public int CourseEntryCount
        {
            get
            {
                return mCourseEntryCount;
            }
        }

        /// <summary>
        /// The number of instructors currently stored.
        /// </summary>
        public int InstructorCount
        {
            get
            {
                return mInstructorCount;
            }
        }

        /// <summary>
        /// The stored array of courses
        /// </summary>
        public Course[] Courses
        {
            get
            {
                return mCourses;
            }
        }

        /// <summary>
        /// The stored list of instructors.
        /// </summary>
        public List<Instructor> Instructors
        {
            get
            {
                return mInstructors;
            }
        }

        // Constructor

        /// <summary>
        /// Creates a controller object.
        /// </summary>
        /// <param name="courseFilePath">
        /// The file path to the course csv data file.
        /// </param>
        /// <param name="instructorFilePath">
        /// The file path to the instructor csv data file.
        /// </param>
        public DataController(string courseFilePath, string instructorFilePath)
        {
            mCourseFilePath = courseFilePath;
            mInstructorFilePath = instructorFilePath;
        }

        // Reading CSV Data Methods

        /// <summary>
        /// Reads and stores the course data from the course csv file.
        /// </summary>
        public void ReadInCourseData()
        {
            // Read in the entries one by one
            using (var textReader = new StreamReader(mCourseFilePath))
            {
                string line = textReader.ReadLine();
                int skipCount = 0;
                while (line != null && skipCount < 1)
                {
                    line = textReader.ReadLine();
                    skipCount++;
                }
                while (line != null)
                {
                    // Break the string down into it's component parts
                    string[] columns = line.Split(",");
                    // Create and store a course object from the data
                    ParseCourseData(columns);
                    // Get the next line
                    line = textReader.ReadLine();
                }
            }
            // Convert the temp list into a course array
            mCourses = mTempCourseList.ToArray();
        }

        /// <summary>
        /// Reads and stores the instructor data from the instructor csv file.
        /// </summary>
        public void ReadInInstructorData()
        {
            // Read in the entries one by one
            using (var textReader = new StreamReader(mInstructorFilePath))
            {
                string line = textReader.ReadLine();
                int skipCount = 0;
                while (line != null && skipCount < 1)
                {
                    line = textReader.ReadLine();
                    skipCount++;
                }
                while (line != null)
                {
                    // Break the string down into it's component parts
                    string[] columns = line.Split(",");
                    // Create and store a course object from the data
                    ParseInstructorData(columns);
                    // Get the next line
                    line = textReader.ReadLine();
                }
            }
        }

        /// <summary>
        /// Converts a string array of values pulled from a csv file into a 
        /// course object. Also stores this new course object into 
        /// the storage data structure.
        /// </summary>
        /// <param name="csvData">
        /// The array of separated csv data.
        /// </param>
        private void ParseCourseData(string[] csvData)
        {
            // Create a course object
            Course newCourse = new Course(csvData);
            // Add the object to the list
            mTempCourseList.Add(newCourse);
            // Increase the course counter by one
            mCourseEntryCount++;
        }

        /// <summary>
        /// Converts a string array of values pulled from a csv file into a 
        /// instructor object. Also stores this new instructor object into 
        /// the storage data structure.
        /// </summary>
        /// <param name="csvData">
        /// The array of separated csv data.
        /// </param>
        private void ParseInstructorData(string[] csvData)
        {
            // Create a new instructor object
            Instructor newInstructor = new Instructor(csvData);
            // Add the obejct to the instructor list
            mInstructors.Add(newInstructor);
            // Increase the instructor count
            mInstructorCount++;
        }

        // LINQ Queries

        public IEnumerable<dynamic> GetIEECourses()
        {
            IEnumerable<dynamic> query =
                from course in mCourses
                where course.Subject == "IEE" && course.CourseCode >= 300
                orderby course.Instructor ascending
                select new { Title = course.Title, Instructor = course.Instructor };

            return query;
        }

        public void ViewGroupCourses()
        {
            var courseGroups =
                from course in mCourses
                group course by course.Subject into subjectGroup
                select new
                {
                    subjectGroup.Key,
                    Count = subjectGroup.Count(),
                    SubGroup =
                                from course in subjectGroup
                                group course by course.CourseCode into codeGroup
                                select codeGroup
                };
            foreach(var group in courseGroups)
            {
                if(group.Count >= 2)
                {
                    Console.WriteLine($"{group.Key}");
                    foreach(var subGroup in group.SubGroup)
                    {
                        Console.WriteLine($"\t{subGroup.Key}");
                    }
                }
            }
        }
    }
}
