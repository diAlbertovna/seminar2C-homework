// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

//if(num > 1000)
// int newthird = num / 10;
    // Console.WriteLine($"{newthird}");

Console.Write("Enter num : ");
int num = int.Parse(Console.ReadLine());
int third = num % 10; 
if(num < 100) Console.WriteLine("third number not exist");
if( num > 999)
{
     int newthird0 = num % 1000;
     int newthird = newthird0 / 100;
     Console.WriteLine($"{newthird}");
}
else
{
    Console.WriteLine($"{third}");
}