// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num>100)
{
while(num>=1000)
{
    num/=10;
}
var digit = num%10;
Console.WriteLine(digit);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}

