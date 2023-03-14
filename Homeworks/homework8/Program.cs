// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] Create2DRandomArray(int colums, int rows, int minValue, int maxValue){
//     int[,] newArray = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//         {
//         for (int j = 0; j < colums; j++)
//             {
//             newArray[i, j] = new Random().Next(minValue, maxValue+1);
//             }
//         }
// return newArray;
// }

// void Show2DArray(int[,] array) {
//     for (int i = 0; i < array.GetLength(0); i++)
//         {
//         for (int j = 0; j < array.GetLength(1); j++)
//             {
//             Console.Write(array[i, j] + " ");
//             }
//         Console.WriteLine();
//         }   
// Console.WriteLine();
// }

// int[,] FormMaxRows(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++) //i=1
//     {
//         for (int j = 0; j < array.GetLength(1); j++)//j=2
//         {
//             for (int l = j + 1; l < array.GetLength(0); l++)
//             {
//                 if(array[i,j] < array[i,l]) //array[1;2] 9 > 2 array[1;3] 
//                     {
//                     int temp = array[i,j]; // temp = 9 array[1;2] 
//                     array[i,j] = array[i,l]; //array[1;2] = 2 array[1;3]
//                     array[i,l] = temp; //array[1;3] = 9
//                 }
//             }
//         }
//     }
//     return array;
// }


// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns:");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] array = Create2DRandomArray(columns, rows, minValue, maxValue);
// Show2DArray(array);
// array = FormMaxRows(array);
// Show2DArray(array);


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] Create2DRandomArray(int colums, int rows, int minValue, int maxValue){
//     int[,] newArray = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//         {
//         for (int j = 0; j < colums; j++)
//             {
//             newArray[i, j] = new Random().Next(minValue, maxValue+1);
//             }
//         }
// return newArray;
// }

// void Show2DArray(int[,] array) {
//     for (int i = 0; i < array.GetLength(0); i++)
//         {
//         for (int j = 0; j < array.GetLength(1); j++)
//             {
//             Console.Write(array[i, j] + " ");
//             }
//         Console.WriteLine();
//         }   
// Console.WriteLine();
// }

// int ValidateArray(int columns, int rows)
// {
//     if (columns == rows)
//     {
//         Console.WriteLine("Error. Number of columns can not be similar to number of rows");
//     }
//     return rows;
// }

// void FindMinSumRow(int[,] array, int rows)
// {
//     int sum = 0;
//     int[] maxArray = new int[rows];
//     for (int i = 0; i < array.GetLength(0); i++) //i=0/1/2/3
//     {
//         sum=0;
//         for (int j = 0; j < array.GetLength(1); j++)//j=0/1/2/3
//         {
//             sum += array[i,j];// sum = 8/14/17/17
//         }
//         maxArray[i] = sum; //rows[0] = 24/11/22/14
//     }
//     int max = maxArray[0];
//     int maxIndex = 0;
//     Console.Write("sum of elements of array : [ ");
//     for (int i = 0; i < maxArray.GetLength(0); i++)
//     {
//         Console.Write(maxArray[i] + " ");
//         if(max < maxArray[i])
//         {
//             max = maxArray[i];
//         }
//         if (maxArray[i] == max)
//         {
//             maxIndex = i;
//         }
//     }
//     Console.WriteLine("]");
//     Console.WriteLine($"{maxIndex+1} row");
// }


// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns:");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] array = Create2DRandomArray(columns, rows, minValue, maxValue);
// Show2DArray(array);
// FindMinSumRow(array, ValidateArray(columns, rows));



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] Create2DRandomArray(int colums, int rows, int minValue, int maxValue){
//     int[,] newArray = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//         {
//         for (int j = 0; j < colums; j++)
//             {
//             newArray[i, j] = new Random().Next(minValue, maxValue+1);
//             }
//         }
// return newArray;
// }

// void Show2DArray(int[,] array) {
//     for (int i = 0; i < array.GetLength(0); i++)
//         {
//         for (int j = 0; j < array.GetLength(1); j++)
//             {
//             Console.Write(array[i, j] + " ");
//             }
//         Console.WriteLine();
//         }   
// Console.WriteLine();
// }

// void MultArray(int[,] array1, int[,] array2)
// {
//     int rows1 = array1.GetLength(0); 
//     int columns1 = array2.GetLength(1);
//     int rows2 = array2.GetLength(0); 
//     int columns2 = array2.GetLength(1);
//     int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
//     if (columns1 == rows2)
//     {
//         for (int i = 0; i < rows1; i++)
//         {
//             for (int j = 0; j < columns2; j++)
//             { 
//             for (int l = 0; l < columns1; l++)
//             {
//                 array3[i,j] += array1[i,l] * array2[l,j];
//             }
//             }
//         }
//     } else{
//         Console.WriteLine("Invalid array");
//     }
//     for (int i = 0; i < array3.GetLength(0); i++)
//         {
//         for (int j = 0; j < array3.GetLength(1); j++)
//             {
//             Console.Write(array3[i, j] + " ");
//             }
//         Console.WriteLine();
//         }   
// Console.WriteLine();
// }


// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns:");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] array1 = Create2DRandomArray(columns, rows, minValue, maxValue);
// Show2DArray(array1);
// int[,] array2 = Create2DRandomArray(columns, rows, minValue, maxValue);
// Show2DArray(array2);
// MultArray(array1, array2);



// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[,,] Create3DRandomArray(int colums, int rows, int height, int minValue, int maxValue){
//     int[,,] newArray = new int[rows, colums, height];
//     for (int i = 0; i < rows; i++)
//         {
//         for (int j = 0; j < colums; j++)
//             {
//                 for (int l = 0; l < height; l++)
//                 {
//                     newArray[i, j, l] = new Random().Next(minValue, maxValue+1);
//                 }
//             }
//         }
// return newArray;
// }

// void Show3D2digitArray(int[,,] array) {
//     for (int i = 0; i < array.GetLength(0); i++)
//         {
//         for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 for (int l = 0; l < array.GetLength(2); l++)
//                 {
//                     if((array[i,j,l] / 10 >= 1)&&(array[i,j,l] / 10 < 10))
//                     {
//                         Console.Write(array[i, j, l] + " ");
//                     }
//                     else{
//                         Console.WriteLine("Invalid array");
//                     }
//                 }
//             }
//         Console.WriteLine();
//         }   
// Console.WriteLine();
// }

// void ShowArrayWithIndex(string validate, int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         {
//         for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 for (int l = 0; l < array.GetLength(2); l++)
//                 {
//                     Console.Write($"{array[i,j,l]} ({i},{j},{l})");
//                 }
//             }
//         Console.WriteLine();
//         }   
// Console.WriteLine();
// }

// string ValidArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0)-1; i++)
//         {
//         for (int j = i+1; j < array.GetLength(1); j++)
//             {
//                 for (int l = j+1; l < array.GetLength(2); l++)
//                 {
//                     if((array[i,j,l] == array[i-1,j-1,l-1])&&(array[i,j,l] == array[i+1,j+1,l+1]))
//                     {
//                         Console.WriteLine("Invalid massiv");
//                     }
//                 }
//             }
//         }   
//     return "all is ok";
// }


// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns:");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array 2 digit element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maximal value of array 2 digit element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of heights: ");
// int height = Convert.ToInt32(Console.ReadLine());

// int[,,] array = Create3DRandomArray(columns, rows, height, minValue, maxValue);
// Show3D2digitArray(array);
// ShowArrayWithIndex(ValidArray(array), array);


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01(0;0) 02(0;1) 03(0;2) 04(0;3)
// 12(1;0) 13(1;1) 14(1;2) 05(1;3)
// 11(2;0) 16(2;1) 15(2;2) 06(2;3)
// 10(3;0) 09(3;1) 08(3;2) 07(3;3)

int[,] Create2DArray(){
    int count1 = 10;
    int[,] newArray = new int[4, 4];
    for (int j = 0; j < 4; j++)
        {
            newArray[0,j] = j+1;
        }
    for (int i = 0; i < 4; i++)
        {
        newArray[i,3] = i+4;
        }
    int l = 0;
    while(l < 3)
        {
        newArray[3,l] = count1;
        count1--;
        l++;
        }
        int k = 1;
        int count2 = 12;
    while(k < 3)
        {
        newArray[k,0] = count2;
        count2--;
        k++;
        }
        int h = 1;
        int count3 = 13;
    while(h < 3)
        {
        newArray[1,h] = count3;
        count3++;
        h++;
        }
        int m = 1;
        int count4 = 16;
    while(m < 3)
        {
        newArray[2,m] = count4;
        count4--;
        m++;
        }
return newArray;
}

void Show2DArray(int[,] array) {
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

int[,] array = Create2DArray();
Show2DArray(array);