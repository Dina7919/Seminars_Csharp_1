// Задача 34: Задайте массив заполненный 
// случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество 
// чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] numbers = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         numbers[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return numbers;
// }

// void ThreeDigitArray (int[] numbers, int size){
//     int count = 0;
//     for (int i = 0; i < size; i++){
//         if (numbers[i] %2 == 0){
//             count++;
//         }
//         Console.Write(numbers[i] + " ");
//     }
// Console.WriteLine();
// Console.WriteLine(count);    
// }

// bool Validation (int[] numbers, int size)
// {
//     for (int i = 0; i < size; i++)
//     {
//         if (numbers[i] < 100 || numbers[i]>1000)
//         {
//             return false;
//         }
//     }
//     return true;
// }
// Console.WriteLine("Input length of massiv: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input min 3 digit number: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max 3 digit number: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// if (Validation(CreateRandomArray(size, minValue, maxValue), size))
// {
//     ThreeDigitArray(CreateRandomArray(size, minValue, maxValue), size);
// }

// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] numbers = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         numbers[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return numbers;
// }
// void SumOfOddNumbers (int[] numbers, int size){
//     int sum = 0;
//     for (int i = 0; i < size; i++){
//         if (!(i %2 == 0)){
//             sum+=numbers[i];
//         }
//         Console.Write(numbers[i] + " ");
//     }
// Console.WriteLine();
// Console.WriteLine($"sum odd numbers of massiv -> {sum}");    
// }

// Console.WriteLine("Input length of massiv: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input min number: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max number: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// SumOfOddNumbers(CreateRandomArray(size, minValue, maxValue), size);

//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и 
//минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] CreateRandomArray(int size, int minValue, int maxValue)
{
    double[] numbers = new double[size];
    for (int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(minValue, maxValue + 1);
    }
    return numbers;
}

void DifferenceMaxMin (double[] numbers, int size){
    double max = numbers[0];
    double min = numbers[0];
    int maxValue = 0;
    int minValue = 0;
    double difference = 0;
    for (int i = 0; i < size; i++){
        if (numbers[i] > max){
            max = numbers[i];
        }
        if (numbers[i] < min)
        {
            min = numbers[i];
        }
        Console.Write(numbers[i] + " ");
    }
    difference = max-min;
Console.WriteLine();
Console.WriteLine($"difference between max and min number -> {difference}");    
}

Console.WriteLine("Input length of massiv: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min number: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max number: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
DifferenceMaxMin(CreateRandomArray(size, minValue, maxValue), size);