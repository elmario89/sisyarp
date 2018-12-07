using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook grades = new GradeBook();

            grades.AddGrade(96.2f);
            grades.AddGrade(78.4f);
            grades.AddGrade(60.0f);

            GradeStatistics stats = grades.ComputeStatistics();

            Console.WriteLine("Average grade is " + stats.averageGrade);
            Console.WriteLine("The lowest grade is " + stats.lowestGrade);
            Console.WriteLine("The highest grade is " + stats.highestGrade);

        }
    }
}
