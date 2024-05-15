using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Review
{
    public class Student
    {
        //Properties

        public List<double> Grades { get; set; } = new List<double>();

        public string Name { get; set; }
        public int ID { get; set; }

        // Methods for adding grades to list and calculating grade average

        public void AddGrade(double grade)
        {
            Grades.Add(grade);
        }
        public void AddGrade(params double[] grades)
        {
            Grades.AddRange(grades);
        }
        public double CalculateAverageGrade()
        {
            double gradeSum = 0;
            var gradeCount = 0;
            for (int i = 0; i < Grades.Count; i++)
            {
                gradeSum += Grades[i];
                gradeCount++;
            }
            return Math.Round(gradeSum / gradeCount, 2);
        }

    }

}
