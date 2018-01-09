using System;
using System.Text.RegularExpressions;

public class Example
{
    public static void Main()
    {
        string pattern = @"@(\w+)";
        string input = @"1 #Beers @roli @trophon @alice
2 #GameDevMeetup @sino @valyo
3 #Karaoke @nakov @royal @ROYAL @ivo
Time for Code";

        foreach (Match m in Regex.Matches(input, pattern))
        {
            Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
        }
    }
}