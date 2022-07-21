using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPACalculator.Core
{
    public class Student
    {
        public string Name { get; set; }
        public int NumberOfCourses { get; set; }
        public List<string> CourseNameAndCode { get; set; }
        public List<double> CourseScores { get; set; } = new List<double>();
        public List<int> CourseUnits { get; set; } =  new List<int>();
        public List<char> AcquiredGrades => SetGrades();
        public List<int> AcquiredGradeUnits =>SetAcquiredGradeUnit();
        public List<int> GradeWeight => SetGradeWeight();
        public List<string> Remarks => SetRemark();
        public int TotalRegisteredUnits => SetTotalRegisteredUnits();
        public int TotalPassedUnits => SetTotalPassedUnits();
        public double TotalGradeWeight => SetTotalGradeWeight(); 
        public double GPA => SetGPA();

        public Student(string name, int numberOfCourses, List<string> courseNameAndCode,List<double> courseScores, List<int> courseUnits)
        {
            Name = name;
            NumberOfCourses = numberOfCourses;
            CourseNameAndCode = courseNameAndCode;
            CourseScores = courseScores;
            CourseUnits = courseUnits;
        }

        private double SetGPA()
        {
            return Math.Round(TotalGradeWeight / TotalRegisteredUnits, 2);
        }
        private int SetTotalGradeWeight()
        {
            int temp = 0;
            for (int i = 0; i < NumberOfCourses; i++)
            {
                temp += GradeWeight[i];
            }
            return temp;
        }
        private int SetTotalPassedUnits()
        {
            int totalPassedUnits = 0;
            for (int i = 0; i < NumberOfCourses; i++)
            {
                if(CourseScores[i] >= 40 ) totalPassedUnits +=CourseUnits[i];
            }
            return totalPassedUnits;
        }
        private int SetTotalRegisteredUnits()
        {
            int totalRegisteredUnit = 0;
            foreach (var item in CourseUnits)
            {
                totalRegisteredUnit += item;
            }
            return totalRegisteredUnit;
        }
        private List<int> SetGradeWeight()
        {
            List<int> temp = new List<int>();
            for (int i = 0; i < NumberOfCourses; i++)
            {
                temp.Add(CourseUnits[i] * AcquiredGradeUnits[i]);
            }
            return temp;
        }
        private List<string> SetRemark()
        {
            List<string> temp = new List<string>();
            for (int i = 0; i < NumberOfCourses; i++)
            {
                if (CourseScores[i] >= 70 && CourseScores[i] <= 100)
                {
                    temp.Add("Excellent");
                }
                else if (CourseScores[i] >= 60 && CourseScores[i] <= 69)
                {
                    temp.Add("Very Good");
                }
                else if (CourseScores[i] >= 50 && CourseScores[i] <= 59)
                {
                    temp.Add("Good");
                }
                else if (CourseScores[i] >= 45 && CourseScores[i] <= 49)
                {
                    temp.Add("Fair");
                }
                else if (CourseScores[i] >= 40 && CourseScores[i] <= 44)
                {
                    temp.Add("Pass");
                }
                else if (CourseScores[i] >= 0 && CourseScores[i] <= 39)
                {
                    temp.Add("Fail");
                }
            }
            return temp;
        }
        private List<int> SetAcquiredGradeUnit()
        {
            List<int> temp = new List<int>();
            for (int i = 0; i < NumberOfCourses; i++)
            {
                if (CourseScores[i] >= 70 && CourseScores[i] <= 100)
                {
                    temp.Add(5);
                }
                else if (CourseScores[i] >= 60 && CourseScores[i] <= 69)
                {
                    temp.Add(4);
                }
                else if (CourseScores[i] >= 50 && CourseScores[i] <= 59)
                {
                    temp.Add(3);
                }
                else if (CourseScores[i] >= 45 && CourseScores[i] <= 49)
                {
                    temp.Add(2);
                }
                else if (CourseScores[i] >= 40 && CourseScores[i] <= 44)
                {
                    temp.Add(1);
                }
                else if (CourseScores[i] >= 0 && CourseScores[i] <= 39)
                {
                    temp.Add(0);
                }
            }
            return  temp;
        }
        private List<char> SetGrades()
        {
            List<char> acquiredGrades = new List<char>();
            for (int i = 0; i < NumberOfCourses; i++)
            {
                if (CourseScores[i] >=70 && CourseScores[i] <=100 )
                {
                    acquiredGrades.Add('A');
                }
                else if (CourseScores[i] >= 60 && CourseScores[i] <= 69)
                {
                    acquiredGrades.Add('B');
                }
                else if (CourseScores[i] >= 50 && CourseScores[i] <= 59)
                {
                    acquiredGrades.Add('C');
                }
                else if (CourseScores[i] >= 45 && CourseScores[i] <= 49)
                {
                    acquiredGrades.Add('D');
                }
                else if (CourseScores[i] >= 40 && CourseScores[i] <= 44)
                {
                    acquiredGrades.Add('E');
                }
                else if (CourseScores[i] >= 0 && CourseScores[i] <= 39)
                {
                    acquiredGrades.Add('F');
                }
            }
            return acquiredGrades;
        }
    }
}
