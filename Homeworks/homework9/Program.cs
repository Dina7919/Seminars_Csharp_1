// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void FindNumbersGap(int N)
// {
//     if(N>0)
//     {
//         Console.Write(N + " ");
//         FindNumbersGap(N-1);
//     }
// }
// Console.WriteLine("Input N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// FindNumbersGap(N);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int FindNumbersGap(int M, int N)
// {
// int sum = 0;
//     if(M!=N)
//     {
//         if (N >= M)
//         {
//             sum =  N + FindNumbersGap(M, N-1);
//         }
//         if (M >= N) 
//         {
//             sum = M + FindNumbersGap(M-1, N);
//         }
//     }
//     else
//     {
//         return 0;
//     }
//     return sum;
// }


// Console.WriteLine("Input M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(FindNumbersGap(M, N));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int Akerman (int n, int m)
// {
//   if (n == 0)
//     return m + 1;
//   else
//     if ((n != 0) && (m == 0))
//       return Akerman(n - 1, 1);
//     else
//       return Akerman(n - 1, Akerman(n, m - 1));
// }