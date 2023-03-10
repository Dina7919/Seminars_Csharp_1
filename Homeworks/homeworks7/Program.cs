// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// double[,] Create2DRandomArray(Random rng, double minValue, double maxValue)
// {
//     double[,] newArray = new double[3, 4];
//     double[,] newArrayRound = new double[3,4];
//     for (int i = 0; i < 3; i++)
//     {
//         for (int j = 0; j < 4; j++)
//         {
//             newArray[i, j] = minValue + (rng.NextDouble() * (maxValue - minValue));
//             newArrayRound[i,j] = Math.Round(newArray[i,j],1);
//         }
//     }
//     return newArrayRound;
// }

// void Show2DArray(double[,]array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Input minimal value of array element: ");
// double minValue = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input maximal value of array element: ");
// double maxValue = Convert.ToDouble(Console.ReadLine());
// System.Random rng = new System.Random();
// double[,] array = Create2DRandomArray(rng,minValue, maxValue);
// Show2DArray(array);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

// int[,] Create2DRandomArray(int colums, int rows, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue+1);
//         }
//     }
//     return newArray;
// }

// void Show2DArray(int[,]array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void FindNumber (int[,]array, int number)
// {
//     int count = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if(array[i,j] == number)
//             {
//                 count = 1;
//             }
//         }
//     }
//     if (count == 1)
//     {
//         Console.WriteLine(number);
//     }
//     else
//     {
//         Console.WriteLine("This number doesn't exist");
//     }
// }
// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int[,] array = Create2DRandomArray(columns, rows,minValue, maxValue);
// Show2DArray(array);
// Console.WriteLine("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// FindNumber(array, number);

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] Create2DRandomArray(int colums, int rows, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return newArray;
}

void Show2DArray(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ArithmeticMeanOfColumns (int[,]array, int columns)
{
    int sum = 0;
    int arithmeticMean = 0;
    Console.WriteLine(array.GetLength(0));
    for (int i = 0; i < array.GetLength(0); i++)
    {
            sum += array[i,0];
            arithmeticMean = sum/columns;
    }
}
Console.WriteLine("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input minimal value of array element: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maximal value of array element: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[,] array = Create2DRandomArray(columns, rows,minValue, maxValue);
Show2DArray(array);
ArithmeticMeanOfColumns(array, columns);