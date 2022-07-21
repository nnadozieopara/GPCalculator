using GPACalculator.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPACalculator.UI
{
    public class Table
    {
        public static void PrintTable(Student student)
        {
            CreateTableHeader();
            int count = student.NumberOfCourses;
            for (int i = 0; i < count; i++)
            {
                AddTableElement(student.CourseNameAndCode[i], student.CourseUnits[i], student.AcquiredGrades[i], student.AcquiredGradeUnits[i], student.GradeWeight[i],student.Remarks[i]);
            }
            Console.WriteLine(".................................................................................................");
        }
        private static void CreateTableHeader()
        {
            Console.WriteLine("|...............................................................................................|");
            Console.WriteLine($"|{"COURSE & CODE", 15}|{"COURSE UNIT",15}|{"GRADE",15}|{"GRADE UNIT",15}|{"WEIGHT Pt.",15}|{"REMARK",15}|");
            Console.WriteLine(".................................................................................................");
        }

        private static void AddTableElement(string courseCode, int courseUnit, char acquiredGrade, int acquiredGradeUnit, int gradeWeight, string remark)
        {
            Console.WriteLine($"|{courseCode,-15}|{courseUnit,-15}|{acquiredGrade,-15}|{acquiredGradeUnit,-15}|{gradeWeight,-15}|{remark,-15}|");
        }
    }
}
