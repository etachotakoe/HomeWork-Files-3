using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("\n Напишите программу, которая принимает на вход строку и производит выходные данные в соответствии с таблицей:");

        Console.WriteLine("\n Введите строку:");
        string input = Console.ReadLine();

        string output = GetDrink(input);
        Console.WriteLine(output);
    }

    static string GetDrink(string input)
    {
      
        var drinkRec = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "Jabroni", "Patron Tequila" },
            { "School Counselor", "Anything with Alcohol" },
            { "Programmer", "Hipster Craft Beer" },
            { "Bike Gang Member", "Moonshine" },
            { "Politician", "Your tax dollars" },
            { "Rapper", "Cristal" }
        };

        
        if (drinkRec.TryGetValue(input, out string drink))
        {
            return drink; 
        }

        return "Beer"; 
    }
}
