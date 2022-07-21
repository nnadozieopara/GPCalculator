using GPACalculator.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPACalculator.UI
{
    public static class UserInput
    {
        public static Student GetUserInput()
        {
            Console.WriteLine("This is a GPA calculator!\n You will be required to enter your name, number of courses, list of courseCodes, list of course scores and list of course units");
            
            try
            {
                Console.Write("Enter your name:  ");
                string Name = Console.ReadLine();
                while (string.IsNullOrEmpty(Name))
                {
                    Console.Write("Name can't be empty! Input your name once more:  ");
                    Name = Console.ReadLine();
                }
                Console.Write("How many courses did you take?  ");
                var num = Console.ReadLine();
                int numberOfCourses;
                while (!int.TryParse(num, out numberOfCourses))
                {
                    Console.Write("This is not a number! How many courses did you take?  ");
                    num = Console.ReadLine();
                }

                List<string> courseNameAndCode = new List<string>();
                List<double> courseScores = new List<double>();
                List<int> courseUnits = new List<int>();
                int counter = 0;
                while (counter < numberOfCourses)
                {
                    Console.Write($"Enter coursecode{counter + 1}:  ");
                    string courseCode = Console.ReadLine();
                    while (string.IsNullOrEmpty(courseCode))
                    {
                        Console.Write("course code can't be empty! Input your coursecode once more:  ");
                        courseCode = Console.ReadLine();
                    }
                    courseNameAndCode.Add(courseCode);
                    Console.Write($"Enter courseScore{counter + 1}:  ");
                    var score = Console.ReadLine();
                    double courseScore;
                    while (!double.TryParse(score, out courseScore)|| courseScore<0 || courseScore >100)
                    {
                        Console.Write("This is not a number!Re-enter your score?  ");
                        score = Console.ReadLine();
                    }
                    courseScores.Add(courseScore);
                    Console.Write($"Enter courseUnit{counter + 1}:  ");
                    var unit = Console.ReadLine();
                    int courseUnit;
                    while (!int.TryParse(unit, out courseUnit))
                    {
                        Console.Write("This is not a number! Re-enter course unit? ");
                        unit = Console.ReadLine();
                    }
                    courseUnits.Add(courseUnit);
                    counter++;
                    Console.WriteLine();
                }
                return new Student(Name, numberOfCourses, courseNameAndCode, courseScores, courseUnits);
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
