using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Roli_The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Dictionary<string, string>> inputData = new Dictionary<int, Dictionary<string, string>>();

            string commandLine = Console.ReadLine();

            while (!commandLine.Equals("Time for Code"))
            {
                string[] idAndName = commandLine.Split(' ','#');
                string id = idAndName[0];
                string eventName = idAndName[2];

           


                //Console.WriteLine(id);
                //Console.WriteLine(eventName);
                Console.WriteLine(string.Join("",participants));

                commandLine = Console.ReadLine();
            }

           
        }
    }
}
