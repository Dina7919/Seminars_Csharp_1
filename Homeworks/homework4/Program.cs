// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// void Degree(int A, int B)
// {
//     Console.WriteLine($"{A}, {B} --> {(long)Math.Pow(A, B)}");
    
// }
// Console.WriteLine("Enter first number");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter second number");
// int B = Convert.ToInt32(Console.ReadLine());
// Degree(A, B);

// Задача 27: Напишите программу, которая 
//принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// int SumOfNumbers(int number)
// {
//     int sum = 0;
//     while(number != 0)
//     {
//         if (number>0 && number<10){ 
//         sum+= number;
//         break;
//     }
//         int ed = number%10; 
//         sum += ed; 
//         number = number/10; 
//     }
//     return sum;
//     }
// Console.WriteLine("Enter number");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Sum of {number} --> {SumOfNumbers(number)}");


// Задача 29: Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

void Array (int[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine("]");
}
Console.WriteLine("Enter length of massiv: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[length];
Console.WriteLine("Enter elements of massiv: ");
for (int i = 0; i < length; i++){
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}
Array(numbers);