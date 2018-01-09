using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        string[] words = File.ReadAllText("words.txt").ToLower().Split();
        string[] text = File.ReadAllText("text.txt").ToLower()
                                                    .Split(new char[] {'\n', '\r', ' ', '.', ',', '!', '?', '-'},
                                                     StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string,int> wordCount = new Dictionary<string, int>();

        foreach (string word in words)
        {
            wordCount[word] = 0;
        }

        foreach (string word in text)
        {
            if (wordCount.ContainsKey(word))
            {
                wordCount[word]++;
            }
        }
        wordCount = wordCount.OrderByDescending(w => w.Value).ToDictionary(x => x.Key, x =>x.Value);
        File.WriteAllText("output.txt","");
        foreach (var pair in wordCount)
        {
            File.AppendAllText("output.txt", $"{pair.Key} - {pair.Value}\r\n");
        }
    }
}

