using System;
using System.Globalization;

class DaysAfterBirth
{
    static void Main()
    {
        var birthDateAsString = Console.ReadLine();
        var format = "dd-MM-yyyy";
        var birthDate = DateTime.ParseExact(birthDateAsString, format, CultureInfo.InvariantCulture);
        birthDate = birthDate.AddDays(999);
        Console.WriteLine(birthDate.ToString(format));
    }

}
