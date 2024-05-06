// 1. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

// void PrintMtoN(int m, int n)
// {
//     if (m > n)
//     {
//         if (n > 0)
//         {
//             System.Console.Write($"{n} ");
//         }
//         PrintMtoN(m, n + 1);
//     }

//     if (m < n)
//     {
//         if (m > 0)
//         {
//             System.Console.Write($"{m} ");
//         }
//         PrintMtoN(m + 1, n);
//     }

//     if (m == n)
//     {
//         if (m > 0)
//         {
//             System.Console.Write($"{m} ");
//         }
//         else
//         {
//             System.Console.WriteLine($"В промежутке чисел от M до N нет натуральных чисел");
//         }
//     }
// }


// System.Console.WriteLine("Ввведите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Ввведите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// PrintMtoN(m, n);


// 2. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// int Ackermann(int m, int n)
// {
//     if (m == 0) 
//     {
//         return n + 1; // базовый случай
//     }

//     if (n == 0) 
//     {
//         return Ackermann(m - 1, 1); // рекурсивный случай
//     }

//     return Ackermann(m - 1, Ackermann(m, n - 1)); // рекурсивный случай
// }

// void Main()
// {
//     System.Console.WriteLine("Введите значение m:");
//     int m = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("Введите значение n:");
//     int n = Convert.ToInt32(Console.ReadLine());

//     Console.WriteLine(Ackermann(m, n));
// }

// Main();

// 3. Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

int[] CreateArray(int size, int min, int max) // создаем массив
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array, int index) // печать массива с начала, с помощью рекурсии
{
    if (index >= array.Length)
    {
        System.Console.WriteLine();
        return;
    }

    System.Console.Write(array[index] + " ");

    PrintArray(array, index + 1);
}

void PrintArrayRevers(int[] array, int index) // печатб массива с конца, с помощью рекурсии
{
    if (index < 0)
    {
        System.Console.WriteLine();
        return;
    }

    System.Console.Write(array[index] + " ");

    PrintArrayRevers(array, index - 1);
}

System.Console.WriteLine($"Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Введите минимальное значение элемента: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Введите максимальное значение элемента: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size, min, max);
System.Console.Write("Вывод массива сначала: ");
PrintArray(array, 0);
System.Console.Write("Вывод массива с конца: ");
PrintArrayRevers(array, array.Length - 1);