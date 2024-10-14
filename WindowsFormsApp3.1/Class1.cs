using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3._1
{
    namespace WindowsFormsApp3
    {
        public class StudentFirstYear
        {
            public string FullName { get; set; }
            public List<double> Grades { get; set; }

            // Конструктор
            public StudentFirstYear(string fullName, List<double> grades)
            {
                FullName = fullName;
                Grades = grades;
            }

            public double CalculateAverageGrade()
            {
                if (Grades.Count == 0) return 0;
                double sum = 0;
                foreach (var grade in Grades)
                {
                    sum += grade;
                }
                return sum / Grades.Count;
            }

            public string GetFullName()
            {
                return FullName;
            }

            public int GetCourse()
            {
                return 1; // или любая логика для определения курса
            }
        }
    }

}
