// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1


Console.Write("Enter num : ");
int num = int.Parse(Console.ReadLine());
int firstdelit = num % 100;
int second = firstdelit / 10;
Console.WriteLine($"{second}");