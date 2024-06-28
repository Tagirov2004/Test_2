using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args) 
    {
        Console.Write("Введите количество бенгальских огней у Игоря (c1): ");
        int c1 = int.Parse(Console.ReadLine());
        Console.Write("Введите количество потухших огоньков (b1): ");
        int b1 = int.Parse(Console.ReadLine());

        int totalBurningTime = OptimalBurningTime(c1, b1);

        Console.WriteLine($"Общее время горения огней: {totalBurningTime} часов");
    }

    static int OptimalBurningTime(int c1, int b1)
    {
        // Сжигаем первый набор из c1 огоньков
        int totalTime = c1 * 2;

        // Создаем новые огни из потухших огоньков
        int newFireworks = b1 / 2;
        totalTime += newFireworks * 2;

        return totalTime;
    }
}