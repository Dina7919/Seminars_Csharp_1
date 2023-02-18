// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

// void palindrom (int number){
//     int fives = number % 10;
//     int fourth = ((number%100) - fives) /10;
//     int first = number /10000;
//     int second = (number/1000) % 10;
//     if (fives == first && fourth == second){
//         Console.WriteLine("да");
//     } else{
//         Console.WriteLine("нет");
//     }
// }
// Console.WriteLine("Input 5-digit number: ");
// int x = Convert.ToInt32(Console.ReadLine());
// palindrom(x);

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// double FindDistance (double xa, double ya, double za, double xb, double yb, double zb)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb-za, 2)),2);

// }
// Console.WriteLine("Input coordinate X for first point: ");
// double xa = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate Y for first point: ");
// double ya = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate Z for first point: ");
// double za = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate X for second point: ");
// double xb = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate Y for second point: ");
// double yb = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate Z for second point: ");
// double zb = Convert.ToDouble(Console.ReadLine());


// Console.WriteLine($"Distance between our points --> {FindDistance(xa, ya, za, xb, yb, zb)}");

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void triple (int N){
//     int i = 0;
//     while(i <= N){
//         Console.WriteLine($"{i} --> {i*i*i}");
//         i++;
//     }
// }
// Console.WriteLine("Input number: ");
// int x = Convert.ToInt32(Console.ReadLine());
// triple(x);

