using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*
    Shivya Balachandran
    Comp123
    07/19/2016
    300884989
*/


namespace Assignment5
{
    /**
    * <summary>
    * This class is the main program
    * </summary>
    * 
    * @class Program
    */
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            do
            {
                // print menu options
                Console.WriteLine("1.Display Grades");
                Console.WriteLine("2. Exit");
                // prompt for choice
                Console.Write("Choose something: ");
                // accept choice
                choice = Console.ReadLine();
                // switch
                switch (choice)
                {
                    case "1":
                        Console.Write("enter file name: ");
                        string fileName = Console.ReadLine();
                        DisplayGrades(fileName);
                        break;
                    case "2":
                        Console.WriteLine("goodbye");
                        break;
                    default: Console.WriteLine("Invalid option");
                        break;
                }

            }
            while (choice != "2");

          
        }
        /**
        * <summary>
        * This method reads and displays students grades from a file
        * </summary>
        * 
        * @static
        * @method DisplayGrades
        * @param {string} fileName
        * @returns {void}
        */
        private static void DisplayGrades(string fileName)
        {
            try
            { 
                //reads the lines from the file 
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        Student s = Student.Parse(line);
                        Console.WriteLine(s);

                        line = reader.ReadLine();
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("No such file");
            }
        }
    }
}
