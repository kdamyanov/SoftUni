using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] {'.',',',':',';','(',')','[',']','\\','\"','\'','/','!','?',' '};

            string sentence = Console.ReadLine().ToLower();
            string[] words = sentence.Split(separators);

            var result = words.Where(w => w != "")
                              .Where (w => w.Length<5)
                              .Distinct()
                              .OrderBy(w => w);


            Console.WriteLine(string.Join(", ", result));
        }
    }
}
