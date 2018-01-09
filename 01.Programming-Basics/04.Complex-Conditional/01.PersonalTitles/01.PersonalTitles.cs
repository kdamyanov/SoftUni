using System;

class Program
{
    static void Main()
    {
        var age = double.Parse(Console.ReadLine());
        var gender = (Console.ReadLine());

        if (gender == "m")
        {
            if (age >= 16)
            {
                Console.WriteLine("Mr.");
            }
            else if (age <16)
            {
                Console.WriteLine("Master");
            }
        }
        if (gender == "f")
        {
            if (age >= 16)
            {
                Console.WriteLine("Ms.");
            }
            else if (age < 16)
            {
                Console.WriteLine("Miss");
            }
        }
    }
}

