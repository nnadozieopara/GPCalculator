using GPACalculator.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPACalculator.UI
{
    public class CGPA
    {
        public static void PrintCGPA(Student student)
        {
            Console.WriteLine($"Total Course Unit Registered is  {student.TotalRegisteredUnits}\nTotal Course Unit Passed is {student.TotalPassedUnits}\nTotal Weight Point is {student.TotalGradeWeight}\nYour GPA is = {student.GPA} to 2 decimal places.");
        }
    }
}
