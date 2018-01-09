using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Average_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            List<Student> students= new List<Student>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] inputTokens = Console.ReadLine().Split();
                string studentName = inputTokens[0];

                List<double> grades =new List<double>();
                for (int j = 1; j < inputTokens.Length; j++)
                {
                    double grade = double.Parse(inputTokens[j]);
                    grades.Add(grade);
                }

                Student student = new Student();
                student.Name = studentName;
                student.Grades = grades;

                students.Add(student);

            }
            foreach (Student student in students.Where(s => s.AverageGrades() >=5)
                .OrderBy(s => s.Name).ThenByDescending(s => s.AverageGrades()))
            {
                Console.WriteLine("{0} -> {1:F2}", student.Name,student.AverageGrades());
            }
        }

        public class Student
        {
            public string Name { get; set; }
            public List<double> Grades { get; set; }

            public double AverageGrades()
            {
                double averageGrade = this.Grades.Average();
                return averageGrade;
            }
        }
       
    }
}
