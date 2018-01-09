using System;

class BonusScore
{
    static void Main()
    {
        var score = double.Parse(Console.ReadLine());
        var bonusScore = 0.0;

        if (score<=100)
        {
            bonusScore = +5;
        }
        else if (score<=1000)
        {
            bonusScore = score * 0.2;
        }
        else
        {
            bonusScore =  score * 0.1;
        }
        
        if (score % 2 == 0)
        {
            bonusScore += 1;
        }
        else if (score % 10 ==5)
        {
            bonusScore += 2;
        }
        Console.WriteLine(bonusScore);
        Console.WriteLine(score+bonusScore);
    }
}

