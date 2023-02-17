// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// void Zadanie1 (int number){
// int ostatokOtSot = number % 100;
// int ostatokOtDec = ostatokOtSot % 10;
// int dec = (ostatokOtSot - ostatokOtDec)/10; 
// Console.WriteLine(dec);
// }
// Console.WriteLine("Enter 3 digit number: ");
// int randomNumber = Convert.ToInt32(Console.ReadLine());
// Zadanie1(randomNumber);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// void Zadanie2 (int number)
// {
// if(number >= 100 && number < 1000){
//     int ed = number % 10;
//     Console.WriteLine(ed);
// } else if(number >= 1000){
//     for (int i = 10; i < 100000000000; i=i*10){
//         int ost= number/i;
//         if (ost >=100 && ost < 1000){
//             int ed = ost%10;
//             Console.WriteLine(ed);
//         }
//     }
// }
// }
// Console.WriteLine("Enter number: ");
// int randomNumber = Convert.ToInt32(Console.ReadLine());
// Zadanie2(randomNumber);

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

void Zadanie2 (int number)
{
if(number > 0 && number <= 7 ){
    if (number == 6 || number == 7){
        Console.WriteLine("да");
    } else{
        Console.WriteLine("нет");
    }
}
}
Console.WriteLine("Enter number: ");
int randomNumber = Convert.ToInt32(Console.ReadLine());
Zadanie2(randomNumber);