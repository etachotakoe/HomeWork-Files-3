using System;

class Program
{
    static void Main()
    {
        // Упражнение 4.1
        int[] daymonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        Console.WriteLine("Упражнение 4.1 Написать программу, которая читает с экрана число от 1 до 365 (номер дня в году), переводит это число в месяц и день месяца. Например, число 40 соответствует 9 февраля (високосный год не учитывать).");

        Console.Write("\nВведите номер дня в году (от 1 до 365): ");
        int dayyear = int.Parse(Console.ReadLine());

        // Проверка на корректность ввода
        if (dayyear < 1 || dayyear > 365)
        {
            Console.WriteLine("Ошибка: число должно быть от 1 до 365.");
            return;
        }

        int month = 0;
        int day = dayyear;

        while (day > daymonth[month])
        {
            day -= daymonth[month];
            month++;
        }

        Console.WriteLine($"День {dayyear} соответствует {day} дню {month + 1} месяца.");


        // Упражнение 4.2
        Console.WriteLine("\n\nУпражнение 4.2 Добавить к задаче из предыдущего упражнения проверку числа введенного пользователем.");
        Console.Write("\nВведите номер дня в году (от 1 до 365): ");
        int dayyear1;

        while (!int.TryParse(Console.ReadLine(), out dayyear1) || dayyear1 < 1 || dayyear1 > 365)
        {
            Console.Write("Неверный ввод. Пожалуйста, введите число от 1 до 365: ");
        }

        int month1 = 0;
        int day1 = dayyear1;

        while (day1 > daymonth[month1])
        {
            day1 -= daymonth[month1];
            month1++;
        }

        Console.WriteLine($"День {dayyear1} соответствует {day1} дню {month1 + 1} месяца.");


        // Домашнее задание 4.1
        Console.WriteLine("\n\nДомашнее задание 4.1 Изменить программу из упражнений 4.1 и 4.2 так, чтобы она учитывала год (високосный или нет).");
        Console.Write("\nВведите год: ");
        int year2 = int.Parse(Console.ReadLine());

        bool isLeapYear = (year2 % 4 == 0 && year2 % 100 != 0) || (year2 % 400 == 0);

        int[] daymonth2 = isLeapYear ? new int[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 }
                                     : new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        Console.Write("Введите номер дня в году (от 1 до {0}): ", isLeapYear ? "366" : "365");
        int dayyear2 = int.Parse(Console.ReadLine());

        // Проверка на корректность ввода
        if ((isLeapYear && (dayyear2 < 1 || dayyear2 > 366)) || (!isLeapYear && (dayyear2 < 1 || dayyear2 > 365)))
        {
            Console.WriteLine("Ошибка: число должно быть от 1 до {0}.", isLeapYear ? "366" : "365");
            return;
        }

        int month2 = 0;
        int day2 = dayyear2;

        while (day2 > daymonth2[month2])
        {
            day2 -= daymonth2[month2];
            month2++;
        }

        Console.WriteLine($"День {dayyear2} соответствует {day2} дню {month2 + 1} месяца в году {year2}.");
    }
}
