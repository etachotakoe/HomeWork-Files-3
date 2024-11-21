
using System;

class Program
{
    enum DayWeek
    {
        Понедельник = 1,
        Вторник,
        Среда,
        Четверг,
        Пятница,
        Суббота,
        Воскресенье
    }

    static void Main()
    {
        int dayNum;

        while (true) 
        {
            Console.WriteLine("Составить программу, которая в зависимости от порядкового номера дня недели (1, 2,\r\n...,7) выводит на экран его название (понедельник, вторник, ..., воскресенье).\r\nИспользовать enum.");
            Console.WriteLine("Введите номер дня недели (1 - 7):");

            if (int.TryParse(Console.ReadLine(), out dayNum) && dayNum >= 1 && dayNum <= 7)
            {
                break; 
            }
            else
            {
                Console.WriteLine("Ошибка: Введите корректный номер дня недели (в диапазоне от 1 до 7).");
            }
        }

        DayWeek day = (DayWeek)dayNum; 
        Console.WriteLine($"День недели: {day}");
    }
}
