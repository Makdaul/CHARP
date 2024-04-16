// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, 
// сумма цифр которого чётная.

using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Введите число или 'q' для выхода:");
            string input = Console.ReadLine();

            if (input == "q")
            {
                break; // Завершаем цикл и программу
            }

            int number;
            bool isNumberParsed = int.TryParse(input, out number);

            if (!isNumberParsed || IsEvenSumOfDigits(number))
            {
                Console.WriteLine($"Вы ввели число {number}, которое не подходит.");
            }
            else
            {
                Console.WriteLine($"Вы ввели подходящее число {number}.");
            }
        }
    }

    static bool IsEvenSumOfDigits(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10; // Добавляем последнюю цифру к сумме
            number /= 10;       // Удаляем последнюю цифру из числа
        }
        return sum % 2 == 0;   // Возвращаем true, если сумма четная
    }
}
