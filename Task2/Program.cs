// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Write("Enter number of the day : ");
int num = int.Parse(Console.ReadLine());
if(num > 5 & num < 8) 
{
    Console.WriteLine("Yes, day off ");
}
if(num >= 8) Console.WriteLine("day not exist");
if(num <= 5) Console.WriteLine("Not a day off");
