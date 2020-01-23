using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SummerCamp.Models
{
    public class StudentList
    {
        private static List<StudentSignup> mylist = new List<StudentSignup>();

        public static IEnumerable<StudentSignup> Responses
        {
            get
            {
                return mylist;
            }
        }

        public static void AddResponse(StudentSignup student)
        {
            mylist.Add(student);
        }
    }

}
