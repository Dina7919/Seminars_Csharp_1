﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// void Array(int[] numbers, int size)
// {
//     Console.Write("[ ");
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }

// int NumbersOver0(int[] numbers, int size)
// {
//     int count = 0;  
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         if (numbers[i] > 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }
// Console.Write("Input size of array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// Console.WriteLine("Input elements of array: ");
// for (int i = 0; i < numbers.Length; i++)
// {
//     numbers[i] = Convert.ToInt32(Console.ReadLine());
// }
// Array(numbers, size);
// int task1 = NumbersOver0(numbers, size);
// Console.WriteLine(task1);


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Array(double[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < 2; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

double[] PointOfIntersection (double b1, double k1, double b2, double k2)
{
    double[] coord = new double[2];
    double x = (b1-b2)/(k2-k1);
    coord[0] = x;
    double y = b1*x + b1;
    coord[1] = y;
    return coord;
}
Console.WriteLine("Input b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
double[] coord = PointOfIntersection(b1, k1, b2, k2);
Array(coord);


