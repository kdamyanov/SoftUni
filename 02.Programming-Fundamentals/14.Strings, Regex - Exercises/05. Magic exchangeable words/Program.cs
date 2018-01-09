using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Magic_exchangeable_words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            string firstWord = words[0]; 
            string secondWord = words[1];

            Dictionary<char,char> map = new Dictionary<char, char>();

            int len = Math.Min(firstWord.Length, secondWord.Length);

            //fisrt

            int firstLen = firstWord.ToCharArray().Distinct().Count();
            int secondLen = secondWord.ToCharArray().Distinct().Count();

            if (firstLen != secondLen)
            {
                Console.WriteLine("false");
            }
            else
            {
                for (int i = 1; i < len; i++)
                {
                    bool check1 = firstWord[i] == firstWord[i - 1];
                    bool check2 = secondWord[i] == secondWord[i - 1];

                    if (check2 !=check1)
                    {
                        Console.WriteLine("false");
                        return;
                    }
                }
                Console.WriteLine("true"); 
            }


            //second

            //for (int i = 0; i < len; i++)
            //{
            //    if (!map.ContainsKey(firstWord[i]))
            //    {
            //        if (map.ContainsValue(secondWord[i]))
            //        {
            //            Console.WriteLine("false");
            //            return;
            //        }
            //        map.Add(firstWord[i], secondWord[i]);
            //    }
            //    else
            //    {
            //        if (map[firstWord[i]] != secondWord[i])
            //        {
            //            Console.WriteLine("false");
            //            return;
            //        }
            //    }
            //}
            //if (firstWord.Length == secondWord.Length)
            //{
            //    Console.WriteLine("true");
            //    return;
            //}
            //string substr = String.Empty;
            //bool isExchangeable = false;

            //if (firstWord.Length > secondWord.Length)
            //{
            //    substr = firstWord.Substring(len);

            //}
            //else
            //{
            //    substr = secondWord.Substring(len);
            //}

            //bool isContained = true;

            //foreach (char c in substr)
            //{
            //    if (!map.Keys.Contains(c) && !map.Values.Contains(c))
            //    {
            //        isContained = false;
            //        break;
            //    }
            //}
            //if (!isContained)
            //{
            //    Console.WriteLine("false");
            //    return;
            //}
            //Console.WriteLine("true");
        }
    }
}
