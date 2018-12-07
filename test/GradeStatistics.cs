using System;
namespace test
{
    public class GradeStatistics
    {
        static float MaximumGrade = float.MaxValue;    
        static float MinimumGrade = 0;

        public GradeStatistics()
        {
            highestGrade = MinimumGrade;
            lowestGrade = MaximumGrade;
        }

        public float averageGrade;
        public float highestGrade;
        public float lowestGrade;
        public int count;
    }
}
