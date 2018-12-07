using System;
using System.Collections.Generic;

namespace test
{
    public class GradeBook
    {
        public GradeBook()
        {
            grades = new List<float>();
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public void GenerateRandomGrades()
        {
            int counter = 0;
            do
            {
                Random number = new Random();
                AddGrade(((float)(number.NextDouble() * (100 - 0) + 0)));
                counter++;
            } while (counter < 100);
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;

            foreach(float grade in grades)
            {
                sum += grade;
                stats.highestGrade = Math.Max(grade, stats.highestGrade);
                stats.lowestGrade = Math.Min(grade, stats.lowestGrade);
            }

            stats.averageGrade = sum / grades.Count;
            stats.count = grades.Count;

            return stats;
        }

        private List<float> grades;
    }
}
