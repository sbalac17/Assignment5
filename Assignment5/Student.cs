using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    /**
    * <summary>
    * This class contains students information
    * </summary>
    * 
    * @class Student
    */
    class Student
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string ID { get; private set; }
        public string Program { get; private set; }
        public string Grade { get; private set; }

        /**
        * <summary>
        * This constructor builds a student with grade information
        * </summary>
        * 
        * @constructor
        */
        private Student(string firstName, string lastName, string id, string program, string grade)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = id;
            Program = program;
            Grade = grade;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}: {2} {3}, {4} ", LastName, FirstName, ID, Program, Grade);
        }

        /**
      * <summary>
      * This utility method creates a student from a line of text 
      * </summary>
      * 
      * @static
      * @method Parse
      * @param {string} line
      * @returns {Student}
      */
        public static Student Parse(string line)
        {// parses rows into students 
            string[] columns = line.Split(':');
            Student s = new Student(columns[0], columns[1], columns[2], columns[3], columns[4]);
            return s; 
        }
    }

}
