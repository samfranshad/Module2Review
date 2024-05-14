using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Review
{
    public class Student
    {
        private List<double> grades;
        public List<double> Grades
        {
            get { return grades; }
            set { grades = value; }
        }

        public string Name { get; set; }
        public int ID { get; set; }

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
            double average = Grades.Count > 0 ? Grades.Average() : 0;
            return average;
        }
    }

}
