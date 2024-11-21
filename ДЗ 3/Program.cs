

using System;

class Program
{
    static void Main()
    {
        int[] daymonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        Console.WriteLine("Упражнение 4.1 Написать программу, которая читает с экрана число от 1 до 365 (номер дня\r\nв году), переводит этот число в месяц и день месяца. Например, число 40 соответствует 9\r\nфевраля (високосный год не учитывать).");
        Console.Write("\n Введите номер дня в году (от 1 до 365): ");
        int dayyear = int.Parse(Console.ReadLine()); 

        int month = 0;
        int day = dayyear;

        
        while (day > daymonth[month])
        {
            day -= daymonth[month];
            month++;
        }

       
        Console.WriteLine($"День {dayyear} соответствует {day} дню {month + 1} месяца.");

        int[] daymonth1 = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        Console.WriteLine("\n \n Упражнение 4.2 Добавить к задаче из предыдущего упражнения проверку числа введенного\r\nпользователем. Если число меньше 1 или больше 365, программа должна вырабатывать\r\nисключение, и выдавать на экран сообщение.");
        Console.Write("\n Введите номер дня в году (от 1 до 365): ");
        int dayyear1;


        while (!int.TryParse(Console.ReadLine(), out dayyear1) || dayyear1 < 1 || dayyear1 > 365)
        {
            Console.Write("Неверный ввод. Пожалуйста, введите число от 1 до 365: ");
        }

        int month1 = 0;
        int day1 = dayyear;


        while (day1 > daymonth1[month1])
        {
            day1 -= daymonth1[month1];
            month1++;
        }


        Console.WriteLine($"День {dayyear1} соответствует {day1} дню {month1 + 1} месяца.");


        //yjdjtrjoihhugergyurfgsdufsugfyusgfuerguwsgfeufsiskiiiiii


        Console.WriteLine("\n \n Домашнее задание 4.1 Изменить программу из упражнений 4.1 и 4.2 так, чтобы она\r\nучитывала год (високосный или нет). Год вводится с экрана. (Год високосный, если он\r\nделится на четыре без остатка, но если он делится на 100 без остатка, это не високосный\r\nгод. Однако, если он делится без остатка на 400, это високосный год.)");
        Console.Write("\n Введите год: ");
        int year2 = int.Parse(Console.ReadLine());

        
        bool isLeapYear = (year2 % 4 == 0 && year2 % 100 != 0) || (year2 % 400 == 0);

        int[] daymonth2 = isLeapYear ? new int[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 }
                                     : new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        Console.Write("Введите номер дня в году (от 1 до 365 или 366 для високосного года): ");
        int dayyear2 = int.Parse(Console.ReadLine());

        int month2 = 0;
        int day2 = dayyear;

        
        while (day2 > daymonth2[month2])
        {
            day -= daymonth2[month2];
            month++;
        }

        
        Console.WriteLine($"День {dayyear2} соответствует {day2} дню {month2 + 1} месяца в году {year2}.");

    }
}
