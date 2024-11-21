using System;
using System.Runtime.ConstrainedExecution;

using System;

class Program
{
    static void Main()

    {
        int cardNumber = 0;

        try
        {
            Console.WriteLine("Игральным картам условно присвоены следующие порядковые номера в зависимости от\r\nих достоинства: «валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14.\r\nПорядковые номера остальных карт соответствуют их названиям («шестерка»,\r\n«девятка» и т. п.). По заданному номеру карты k (6 <=k <= 14) определить достоинство\r\nсоответствующей карты. Использовать try-catch-finally.");
            Console.WriteLine("\n Введите номер карты (6 <= k <= 14):");
            string input = Console.ReadLine();

            
            cardNumber = int.Parse(input);

            
            if (cardNumber < 6 || cardNumber > 14)
            {
                throw new ArgumentOutOfRangeException("Номер карты должен быть от 6 до 14.");
            }

            string cardValue = "";

           
            switch (cardNumber)
            {
                case 6:
                    cardValue = "Шестёрка";
                    break;
                case 7:
                    cardValue = "Семёрка";
                    break;
                case 8:
                    cardValue = "Восьмёрка";
                    break;
                case 9:
                    cardValue = "Девятка";
                    break;
                case 10:
                    cardValue = "Десятка";
                    break;
                case 11:
                    cardValue = "Валет";
                    break;
                case 12:
                    cardValue = "Дама";
                    break;
                case 13:
                    cardValue = "Король";
                    break;
                case 14:
                    cardValue = "Туз";
                    break;
            }

            Console.WriteLine("Достоинство карты: " + cardValue);
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: Ввод должен быть целым числом.");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Произошла ошибка: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Завершение работы программы.");
        }

        int[] numbers = new int[10];

        // new prog

        Console.WriteLine("\n \n Дана последовательность из 10 чисел. Определить, является ли эта последовательность\r\nупорядоченной по возрастанию. В случае отрицательного ответа определить\r\nпорядковый номер первого числа, которое нарушает данную последовательность.\r\nИспользовать break.");
        Console.WriteLine("\n Введите 10 чисел:");
        for (int i = 0; i < 10; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

       
        bool isSorted = true;
        int position = -1;

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < numbers[i - 1])
            {
                isSorted = false;
                position = i; // позиция первого элемента нарушающего порядок
                break;
            }
        }

        // 
        if (isSorted)
        {
            Console.WriteLine("Последовательность упорядочена по возрастанию.");
        }
        else
        {
            Console.WriteLine($"Последовательность не упорядочена. Первое нарушение на позиции: {position + 1} (число: {numbers[position]})");
        }
    }
}
