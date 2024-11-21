
using System;

class Program
{
    static void Main()
    {
        
        string[] dolls = { "Hello Kitty", "Lego", "Barbie doll", "Play-Doh", "Math Book", "Naruto Manga", "Hello Kitty", "Barbie doll" };

        int bagCount = 0; 

        
        foreach (var doll in dolls)// проходим по всем куклам в массиве
        {
           
            if (doll == "Hello Kitty" || doll == "Barbie doll") // если кукла Hello Kitty или Barbie doll, увеличиваем счетчик
            {
                bagCount++;
            }
        }

        
        Console.WriteLine($"Количество кукол в сумке: {bagCount}");
    }
}
