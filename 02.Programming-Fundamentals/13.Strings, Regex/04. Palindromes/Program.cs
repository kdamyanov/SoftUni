using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(new char[] {' ', '!', '?', '.', ','}, StringSplitOptions.RemoveEmptyEntries);

            List<string> palindroms = new List<string>();
            foreach (string word in words.Distinct().OrderBy(w => w))
            {
                if (IsPalindrome(word))
                {
                    palindroms.Add(word);
                }
            }
            Console.WriteLine(string.Join(", ",palindroms));

        }

        private static bool IsPalindrome(string word)
        {
            bool result = true; // = word == string.Join("",word.Reverse());

            for (int i = 0; i < word.Length/2; i++)
            {
                if (word[i] != word[word.Length-i-1])
                {
                    result = false;
                    break;
                }
            }
           
            return result;
        }
    }
}
