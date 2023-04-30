// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Input number:");
int a=Convert.ToInt32(Console.ReadLine());
int b=0;
int i=0;
int c=a;

while(a>0)
{
 b=b*10+a%10;
 a=a/10;
 i++;
}
if (b==c)
{
 Console.WriteLine($"{c} -> да"); 
}
else Console.WriteLine($"{c} -> нет");

 