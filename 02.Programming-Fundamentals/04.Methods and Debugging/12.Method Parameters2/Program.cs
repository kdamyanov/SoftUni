using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Method_Parameters2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintStudent("Kiro", 36, 6);
            PrintStudent("Ivan", 22, 4);
        }

        static void PrintStudent(string name, int age, double grade)
        {
            Console.Write("Student: {0}; Age: {1}, Grade: {2}", name, age, grade);
            Console.WriteLine();
        }
    }
}
