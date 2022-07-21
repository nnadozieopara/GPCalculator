using GPACalculator.Core;
using GPACalculator.UI;
using System;
using System.Collections.Generic;

namespace GPACalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Student myStudent = UserInput.GetUserInput();
            Table.PrintTable(myStudent);
            CGPA.PrintCGPA(myStudent);
            Console.ReadLine();

        }
    }
}
