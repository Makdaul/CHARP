﻿using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите координату X: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите координату Y: ");
        double y = Convert.ToDouble(Console.ReadLine());
        if (x > 0 && y > 0)
            Console.WriteLine("1");
        else if (x < 0 && y > 0)
            Console.WriteLine("2");
        else if (x < 0 && y < 0)
            Console.WriteLine("3");
        else if (x > 0 && y < 0)
            Console.WriteLine("4");
        else
            Console.WriteLine("Точка находится на оси координат");
    }
}
